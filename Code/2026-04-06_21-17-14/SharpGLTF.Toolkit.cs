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
	public abstract class BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected BaseBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		protected BaseBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		protected BaseBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA75BAF0", Offset = "0xA75AAF0", VA = "0x18A75BAF0")]
		protected BaseBuilder(BaseBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA75B900", Offset = "0xA75A900", VA = "0x18A75B900")]
		protected static int GetContentHashCode(BaseBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA75B7F0", Offset = "0xA75A7F0", VA = "0x18A75B7F0")]
		protected static bool AreEqualByContent(BaseBuilder x, BaseBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA75BA10", Offset = "0xA75AA10", VA = "0x18A75BA10")]
		internal void SetNameAndExtrasFrom(BaseBuilder source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA75B990", Offset = "0xA75A990", VA = "0x18A75B990")]
		internal void SetNameAndExtrasFrom(LogicalChildOfRoot source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA75BA90", Offset = "0xA75AA90", VA = "0x18A75BA90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA75D790", Offset = "0xA75C790", VA = "0x18A75D790")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA75C760", Offset = "0xA75B760", VA = "0x18A75C760")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA75C9D0", Offset = "0xA75B9D0", VA = "0x18A75C9D0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA75CC20", Offset = "0xA75BC20", VA = "0x18A75CC20")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA75C6C0", Offset = "0xA75B6C0", VA = "0x18A75C6C0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA75D410", Offset = "0xA75C410", VA = "0x18A75D410")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA75D2F0", Offset = "0xA75C2F0", VA = "0x18A75D2F0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA75D8E0", Offset = "0xA75C8E0", VA = "0x18A75D8E0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA75D880", Offset = "0xA75C880", VA = "0x18A75D880")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA75D130", Offset = "0xA75C130", VA = "0x18A75D130")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFDF0", Offset = "0x3AEEDF0", VA = "0x183AEFDF0")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE4D0", Offset = "0x3AED4D0", VA = "0x183AEE4D0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA75D190", Offset = "0xA75C190", VA = "0x18A75D190")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF990", Offset = "0x3AEE990", VA = "0x183AEF990")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF530", Offset = "0x3AEE530", VA = "0x183AEF530")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF0F0", Offset = "0x3AEE0F0", VA = "0x183AEF0F0")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEDF0", Offset = "0x3AEDDF0", VA = "0x183AEEDF0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE0F0", Offset = "0x3AED0F0", VA = "0x183AEE0F0")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA75CD20", Offset = "0xA75BD20", VA = "0x18A75CD20")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA75CCC0", Offset = "0xA75BCC0", VA = "0x18A75CCC0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA75CD80", Offset = "0xA75BD80", VA = "0x18A75CD80")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA75D630", Offset = "0xA75C630", VA = "0x18A75D630")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA75D530", Offset = "0xA75C530", VA = "0x18A75D530")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2980", Offset = "0x3AF1980", VA = "0x183AF2980")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA75C430", Offset = "0xA75B430", VA = "0x18A75C430")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1D00", Offset = "0x3AF0D00", VA = "0x183AF1D00")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1340", Offset = "0x3AF0340", VA = "0x183AF1340")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1340", Offset = "0x3AF0340", VA = "0x183AF1340")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1340", Offset = "0x3AF0340", VA = "0x183AF1340")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1340", Offset = "0x3AF0340", VA = "0x183AF1340")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0750", Offset = "0x3AEF750", VA = "0x183AF0750")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x6721170", Offset = "0x6720170", VA = "0x186721170", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x671F3C0", Offset = "0x671E3C0", VA = "0x18671F3C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x67217A0", Offset = "0x67207A0", VA = "0x1867217A0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6F50660", Offset = "0x6F4F660", VA = "0x186F50660", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6F4CB30", Offset = "0x6F4BB30", VA = "0x186F4CB30", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6F50B60", Offset = "0x6F4FB60", VA = "0x186F50B60")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5165F00", Offset = "0x5164F00", VA = "0x185165F00", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5165A80", Offset = "0x5164A80", VA = "0x185165A80", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5165710", Offset = "0x5164710", VA = "0x185165710", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x51659D0", Offset = "0x51649D0", VA = "0x1851659D0", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x671B920", Offset = "0x671A920", VA = "0x18671B920", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6719F80", Offset = "0x6718F80", VA = "0x186719F80", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x671BCB0", Offset = "0x671ACB0", VA = "0x18671BCB0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6F47490", Offset = "0x6F46490", VA = "0x186F47490", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6F47110", Offset = "0x6F46110", VA = "0x186F47110", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6F478B0", Offset = "0x6F468B0", VA = "0x186F478B0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x515C820", Offset = "0x515B820", VA = "0x18515C820", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x515C4B0", Offset = "0x515B4B0", VA = "0x18515C4B0", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x515C690", Offset = "0x515B690", VA = "0x18515C690", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13FFA60", Offset = "0x13FEA60", VA = "0x1813FFA60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA779EC0", Offset = "0xA778EC0", VA = "0x18A779EC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65470C0", VA = "0x1865480C0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA779F10", Offset = "0xA778F10", VA = "0x18A779F10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA779B70", Offset = "0xA778B70", VA = "0x18A779B70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA779FD0", Offset = "0xA778FD0", VA = "0x18A779FD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA779E80", Offset = "0xA778E80", VA = "0x18A779E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA779DD0", Offset = "0xA778DD0", VA = "0x18A779DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA779DD0", Offset = "0xA778DD0", VA = "0x18A779DD0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A04590", Offset = "0x1A03590", VA = "0x181A04590", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA77A9B0", Offset = "0xA7799B0", VA = "0x18A77A9B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA77AA00", Offset = "0xA779A00", VA = "0x18A77AA00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA77A020", Offset = "0xA779020", VA = "0x18A77A020", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA77ABF0", Offset = "0xA779BF0", VA = "0x18A77ABF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA77AC40", Offset = "0xA779C40", VA = "0x18A77AC40")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA77AC90", Offset = "0xA779C90", VA = "0x18A77AC90")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA77A970", Offset = "0xA779970", VA = "0x18A77A970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA77A8C0", Offset = "0xA7798C0", VA = "0x18A77A8C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA77A8C0", Offset = "0xA7798C0", VA = "0x18A77A8C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A2590", Offset = "0xA6A1590", VA = "0x18A6A2590")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3F60", Offset = "0xA6A2F60", VA = "0x18A6A3F60")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4090", Offset = "0xA6A3090", VA = "0x18A6A4090")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3FA0", Offset = "0xA6A2FA0", VA = "0x18A6A3FA0")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A40C0", Offset = "0xA6A30C0", VA = "0x18A6A40C0")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4000", Offset = "0xA6A3000", VA = "0x18A6A4000")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4130", Offset = "0xA6A3130", VA = "0x18A6A4130")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4000", Offset = "0xA6A3000", VA = "0x18A6A4000")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3E90", Offset = "0xA6A2E90", VA = "0x18A6A3E90")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA77CB30", Offset = "0xA77BB30", VA = "0x18A77CB30")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA77CA10", Offset = "0xA77BA10", VA = "0x18A77CA10")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1930", Offset = "0xA6A0930", VA = "0x18A6A1930")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA77D3B0", Offset = "0xA77C3B0", VA = "0x18A77D3B0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2540", Offset = "0xA6A1540", VA = "0x18A6A2540")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6A24E0", Offset = "0xA6A14E0", VA = "0x18A6A24E0")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6A27C0", Offset = "0xA6A17C0", VA = "0x18A6A27C0")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA77DF50", Offset = "0xA77CF50", VA = "0x18A77DF50")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA77E0D0", Offset = "0xA77D0D0", VA = "0x18A77E0D0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA77CD20", Offset = "0xA77BD20", VA = "0x18A77CD20")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA77CC30", Offset = "0xA77BC30", VA = "0x18A77CC30")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA77CFF0", Offset = "0xA77BFF0", VA = "0x18A77CFF0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA77C880", Offset = "0xA77B880", VA = "0x18A77C880")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA755560", Offset = "0xA754560", VA = "0x18A755560")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3090", Offset = "0xA6A2090", VA = "0x18A6A3090")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA77CCB0", Offset = "0xA77BCB0", VA = "0x18A77CCB0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA6A22B0", Offset = "0xA6A12B0", VA = "0x18A6A22B0")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA6A21F0", Offset = "0xA6A11F0", VA = "0x18A6A21F0")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x413AA60", Offset = "0x4139A60", VA = "0x18413AA60")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1AA0", Offset = "0xA6A0AA0", VA = "0x18A6A1AA0")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1C10", Offset = "0xA6A0C10", VA = "0x18A6A1C10")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x413C420", Offset = "0x413B420", VA = "0x18413C420")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x413CF20", Offset = "0x413BF20", VA = "0x18413CF20")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x413D0F0", Offset = "0x413C0F0", VA = "0x18413D0F0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x413D1D0", Offset = "0x413C1D0", VA = "0x18413D1D0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x413AA80", Offset = "0x4139A80", VA = "0x18413AA80")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x413BC40", Offset = "0x413AC40", VA = "0x18413BC40")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x413BB30", Offset = "0x413AB30", VA = "0x18413BB30")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x413B270", Offset = "0x413A270", VA = "0x18413B270")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x413CE40", Offset = "0x413BE40", VA = "0x18413CE40")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x413C7B0", Offset = "0x413B7B0", VA = "0x18413C7B0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x413CD50", Offset = "0x413BD50", VA = "0x18413CD50")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x413C950", Offset = "0x413B950", VA = "0x18413C950")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x413B120", Offset = "0x413A120", VA = "0x18413B120")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x413ACC0", Offset = "0x4139CC0", VA = "0x18413ACC0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x413A6E0", Offset = "0x41396E0", VA = "0x18413A6E0")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x413AB10", Offset = "0x4139B10", VA = "0x18413AB10")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA77CDF0", Offset = "0xA77BDF0", VA = "0x18A77CDF0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA77D150", Offset = "0xA77C150", VA = "0x18A77D150")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x413CEA0", Offset = "0x413BEA0", VA = "0x18413CEA0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x413CEA0", Offset = "0x413BEA0", VA = "0x18413CEA0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA77D660", Offset = "0xA77C660", VA = "0x18A77D660")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA77C1E0", Offset = "0xA77B1E0", VA = "0x18A77C1E0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA77C130", Offset = "0xA77B130", VA = "0x18A77C130")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA77D5E0", Offset = "0xA77C5E0", VA = "0x18A77D5E0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA77DD20", Offset = "0xA77CD20", VA = "0x18A77DD20")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA77C260", Offset = "0xA77B260", VA = "0x18A77C260")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA77DC50", Offset = "0xA77CC50", VA = "0x18A77DC50")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA77D860", Offset = "0xA77C860", VA = "0x18A77D860")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA77C5D0", Offset = "0xA77B5D0", VA = "0x18A77C5D0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA77C320", Offset = "0xA77B320", VA = "0x18A77C320")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA77C6F0", Offset = "0xA77B6F0", VA = "0x18A77C6F0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA77C4B0", Offset = "0xA77B4B0", VA = "0x18A77C4B0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA77C670", Offset = "0xA77B670", VA = "0x18A77C670")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2388B00", Offset = "0x2387B00", VA = "0x182388B00")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3F80", Offset = "0xA6A2F80", VA = "0x18A6A3F80")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x413D400", Offset = "0x413C400", VA = "0x18413D400")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA77D520", Offset = "0xA77C520", VA = "0x18A77D520")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA77C530", Offset = "0xA77B530", VA = "0x18A77C530")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA77DEA0", Offset = "0xA77CEA0", VA = "0x18A77DEA0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA77E2D0", Offset = "0xA77D2D0", VA = "0x18A77E2D0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA77DDA0", Offset = "0xA77CDA0", VA = "0x18A77DDA0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1B40", Offset = "0xA6A0B40", VA = "0x18A6A1B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x40A6020", Offset = "0x40A5020", VA = "0x1840A6020")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA77BDC0", Offset = "0xA77ADC0", VA = "0x18A77BDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40B7910", Offset = "0x40B6910", VA = "0x1840B7910")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA77BF80", Offset = "0xA77AF80", VA = "0x18A77BF80")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA777F50", Offset = "0xA776F50", VA = "0x18A777F50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <EvaluateLines>d__77(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA777FA0", Offset = "0xA776FA0", VA = "0x18A777FA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA7778A0", Offset = "0xA7768A0", VA = "0x18A7778A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA778170", Offset = "0xA777170", VA = "0x18A778170")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA7781C0", Offset = "0xA7771C0", VA = "0x18A7781C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA777F10", Offset = "0xA776F10", VA = "0x18A777F10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA777E60", Offset = "0xA776E60", VA = "0x18A777E60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA777E60", Offset = "0xA776E60", VA = "0x18A777E60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA778800", Offset = "0xA777800", VA = "0x18A778800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1D167A0", Offset = "0x1D157A0", VA = "0x181D167A0")]
			[DebuggerHidden]
			public <EvaluatePoints>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA778850", Offset = "0xA777850", VA = "0x18A778850", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA778220", Offset = "0xA777220", VA = "0x18A778220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA778A50", Offset = "0xA777A50", VA = "0x18A778A50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA778AA0", Offset = "0xA777AA0", VA = "0x18A778AA0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA7787C0", Offset = "0xA7777C0", VA = "0x18A7787C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA778710", Offset = "0xA777710", VA = "0x18A778710", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA778710", Offset = "0xA777710", VA = "0x18A778710", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5088B00", Offset = "0x5087B00", VA = "0x185088B00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA779220", Offset = "0xA778220", VA = "0x18A779220", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x667DA70", Offset = "0x667CA70", VA = "0x18667DA70")]
			[DebuggerHidden]
			public <EvaluateTriangles>d__79(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA779270", Offset = "0xA778270", VA = "0x18A779270", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA778AF0", Offset = "0xA777AF0", VA = "0x18A778AF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA779450", Offset = "0xA778450", VA = "0x18A779450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA7794A0", Offset = "0xA7784A0", VA = "0x18A7794A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA7791E0", Offset = "0xA7781E0", VA = "0x18A7791E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA779130", Offset = "0xA778130", VA = "0x18A779130", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA779130", Offset = "0xA778130", VA = "0x18A779130", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA76E3D0", Offset = "0xA76D3D0", VA = "0x18A76E3D0")]
		public static Accessor CreateMorphTargetAccessor(this ModelRoot root, MemoryAccessor memAccessor, int sparsityPercent = 60)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA76E630", Offset = "0xA76D630", VA = "0x18A76E630")]
		public static Accessor CreateVertexAccessor(this ModelRoot root, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F540F0", Offset = "0x3F530F0", VA = "0x183F540F0")]
		public static BufferView CreateBufferView<T>(this ModelRoot root, IReadOnlyList<T> data) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA770610", Offset = "0xA76F610", VA = "0x18A770610")]
		public static Animation UseAnimation(this ModelRoot root, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA774770", Offset = "0xA773770", VA = "0x18A774770")]
		public static Node WithScaleAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA775EC0", Offset = "0xA774EC0", VA = "0x18A775EC0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA773550", Offset = "0xA772550", VA = "0x18A773550")]
		public static Node WithMorphingAnimation(this Node node, string animationName, ICurveSampler<SparseWeight8> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A8C0", Offset = "0x3F598C0", VA = "0x183F5A8C0")]
		public static Node WithMorphingAnimation<T>(this Node node, string animationName, ICurveSampler<T> sampler) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA774430", Offset = "0xA773430", VA = "0x18A774430")]
		public static Node WithRotationAnimation(this Node node, string animationName, ICurveSampler<Quaternion> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA776A00", Offset = "0xA775A00", VA = "0x18A776A00")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, ICurveSampler<bool> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA774980", Offset = "0xA773980", VA = "0x18A774980")]
		public static Node WithScaleAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA773FA0", Offset = "0xA772FA0", VA = "0x18A773FA0")]
		public static Node WithRotationAnimation(this Node node, string animationName, params (float Key, Quaternion Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA775B60", Offset = "0xA774B60", VA = "0x18A775B60")]
		public static Node WithTranslationAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA774640", Offset = "0xA773640", VA = "0x18A774640")]
		public static Node WithScaleAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA774300", Offset = "0xA773300", VA = "0x18A774300")]
		public static Node WithRotationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA775A30", Offset = "0xA774A30", VA = "0x18A775A30")]
		public static Node WithTranslationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA776BA0", Offset = "0xA775BA0", VA = "0x18A776BA0")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, IReadOnlyDictionary<float, bool> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA775960", Offset = "0xA774960", VA = "0x18A775960")]
		public static PunctualLight WithSpotCone(this PunctualLight light, float innerConeAngle, float outerConeAngle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA771270", Offset = "0xA770270", VA = "0x18A771270")]
		public static PunctualLight WithColor(this PunctualLight light, Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA771380", Offset = "0xA770380", VA = "0x18A771380")]
		public static Material WithDefault(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA771490", Offset = "0xA770490", VA = "0x18A771490")]
		public static Material WithDefault(this Material material, Vector4 diffuseColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA771670", Offset = "0xA770670", VA = "0x18A771670")]
		public static Material WithDoubleSide(this Material material, bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA770C60", Offset = "0xA76FC60", VA = "0x18A770C60")]
		[Obsolete("don't use vector4 based parameter. Use WithChannelColor and WithChannelFactor instead.")]
		public static Material WithChannelParameter(this Material material, string channelName, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA770970", Offset = "0xA76F970", VA = "0x18A770970")]
		public static Material WithChannelColor(this Material material, string channelName, Vector4 color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA770AE0", Offset = "0xA76FAE0", VA = "0x18A770AE0")]
		public static Material WithChannelFactor(this Material material, string channelName, string paramName, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA770F80", Offset = "0xA76FF80", VA = "0x18A770F80")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, string imageFilePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA770DD0", Offset = "0xA76FDD0", VA = "0x18A770DD0")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, Image image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7739C0", Offset = "0xA7729C0", VA = "0x18A7739C0")]
		public static Material WithPBRMetallicRoughness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA773A90", Offset = "0xA772A90", VA = "0x18A773A90")]
		public static Material WithPBRMetallicRoughness(this Material material, Vector4 baseColor, string baseColorImageFilePath, [Optional] string metallicImageFilePath, float metallicFactor = 1f, float roughnessFactor = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA773D90", Offset = "0xA772D90", VA = "0x18A773D90")]
		[Obsolete("SpecularGlossiness Extension has been declared deprecated by the Khronos Group. Use newer extensions instead.")]
		public static Material WithPBRSpecularGlossiness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7760D0", Offset = "0xA7750D0", VA = "0x18A7760D0")]
		public static Material WithUnlit(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA770850", Offset = "0xA76F850", VA = "0x18A770850")]
		public static Image UseImageWithFile(this ModelRoot root, string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA770780", Offset = "0xA76F780", VA = "0x18A770780")]
		public static Image UseImageWithContent(this ModelRoot root, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA76DEC0", Offset = "0xA76CEC0", VA = "0x18A76DEC0")]
		public static Material CreateMaterial(this ModelRoot root, MaterialBuilder mb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA76FCA0", Offset = "0xA76ECA0", VA = "0x18A76FCA0")]
		public static MaterialBuilder ToMaterialBuilder(this Material srcMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA7702B0", Offset = "0xA76F2B0", VA = "0x18A7702B0")]
		public static AlphaMode ToSchema2(this SharpGLTF.Materials.AlphaMode alpha)
		{
			return default(AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA770360", Offset = "0xA76F360", VA = "0x18A770360")]
		public static SharpGLTF.Materials.AlphaMode ToToolkit(this AlphaMode alpha)
		{
			return default(SharpGLTF.Materials.AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA76CB00", Offset = "0xA76BB00", VA = "0x18A76CB00")]
		public static void CopyTo(this Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7770F0", Offset = "0xA7760F0", VA = "0x18A7770F0")]
		private static void _CopyMetallicRoughnessTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA776E10", Offset = "0xA775E10", VA = "0x18A776E10")]
		private static void _CopyDefaultTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA76C090", Offset = "0xA76B090", VA = "0x18A76C090")]
		public static void CopyChannelsTo(this Material srcMaterial, MaterialBuilder dstMaterial, params string[] channelKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA76C380", Offset = "0xA76B380", VA = "0x18A76C380")]
		public static void CopyTo(this MaterialChannel srcChannel, ChannelBuilder dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA76D470", Offset = "0xA76C470", VA = "0x18A76D470")]
		public static void CopyTo(this MaterialBuilder srcMaterial, Material dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA76BF30", Offset = "0xA76AF30", VA = "0x18A76BF30")]
		[Obsolete]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params string[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA76BC70", Offset = "0xA76AC70", VA = "0x18A76BC70")]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params KnownChannel[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA76CE80", Offset = "0xA76BE80", VA = "0x18A76CE80")]
		public static void CopyTo(this ChannelBuilder srcChannel, MaterialChannel dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA776CD0", Offset = "0xA775CD0", VA = "0x18A776CD0")]
		private static Image _ConvertToImage(MaterialChannel dstChannel, ImageBuilder srcImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA76F390", Offset = "0xA76E390", VA = "0x18A76F390")]
		public static Vector4 GetDiffuseColor(this Material material, Vector4 defaultColor)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA76F7F0", Offset = "0xA76E7F0", VA = "0x18A76F7F0")]
		public static Texture GetDiffuseTexture(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA76F6B0", Offset = "0xA76E6B0", VA = "0x18A76F6B0")]
		public static TextureTransform GetDiffuseTextureTransform(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA76F4E0", Offset = "0xA76E4E0", VA = "0x18A76F4E0")]
		public static Matrix3x2? GetDiffuseTextureMatrix(this Material material, Animation track, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA76DFF0", Offset = "0xA76CFF0", VA = "0x18A76DFF0")]
		public static Mesh CreateMesh(this ModelRoot root, IMeshBuilder<MaterialBuilder> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F55EC0", Offset = "0x3F54EC0", VA = "0x183F55EC0")]
		public static Mesh CreateMesh<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialEvaluator, IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA76E230", Offset = "0xA76D230", VA = "0x18A76E230")]
		public static IReadOnlyList<Mesh> CreateMeshes(this ModelRoot root, params IMeshBuilder<MaterialBuilder>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F57BA0", Offset = "0x3F56BA0", VA = "0x183F57BA0")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F56F20", Offset = "0x3F55F20", VA = "0x183F56F20")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, SceneBuilderSchema2Settings settings, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA771B00", Offset = "0xA770B00", VA = "0x18A771B00")]
		public static MeshPrimitive WithIndicesAutomatic(this MeshPrimitive primitive, PrimitiveType primitiveType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA771730", Offset = "0xA770730", VA = "0x18A771730")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, IReadOnlyList<int> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B260", Offset = "0x3F5A260", VA = "0x183F5B260")]
		public static MeshPrimitive WithVertexAccessor<T>(this MeshPrimitive primitive, string attribute, IReadOnlyList<T> values, bool useExplicitByteStride = false) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA7768A0", Offset = "0xA7758A0", VA = "0x18A7768A0")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPosition> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA776740", Offset = "0xA775740", VA = "0x18A776740")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPositionNormal> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B870", Offset = "0x3F5A870", VA = "0x183F5B870")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5B870", Offset = "0x3F5A870", VA = "0x183F5B870")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM, TvS>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat, TvS Skin)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BA30", Offset = "0x3F5AA30", VA = "0x183F5BA30")]
		public static MeshPrimitive WithVertexAccessors<TVertex>(this MeshPrimitive primitive, IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA776390", Offset = "0xA775390", VA = "0x18A776390")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA776180", Offset = "0xA775180", VA = "0x18A776180")]
		public static MeshPrimitive WithVertexAccessor(this MeshPrimitive primitive, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA7719E0", Offset = "0xA7709E0", VA = "0x18A7719E0")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA773270", Offset = "0xA772270", VA = "0x18A773270")]
		public static MeshPrimitive WithMorphTargetAccessors(this MeshPrimitive primitive, int targetIndex, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A020", Offset = "0x3F59020", VA = "0x183F5A020")]
		public static MeshGpuInstancing WithInstanceAccessor<T>(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<T> values) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA771BE0", Offset = "0xA770BE0", VA = "0x18A771BE0")]
		public static MeshGpuInstancing WithInstanceAccessors(this MeshGpuInstancing instancing, IReadOnlyList<AffineTransform> transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA772640", Offset = "0xA771640", VA = "0x18A772640")]
		public static MeshGpuInstancing WithInstanceCustomAccessors(this MeshGpuInstancing instancing, IReadOnlyList<JsonNode> extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA7723D0", Offset = "0xA7713D0", VA = "0x18A7723D0")]
		public static MeshGpuInstancing WithInstanceCustomAccessor(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<JsonNode> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BEE0", Offset = "0x3F5AEE0", VA = "0x183F5BEE0")]
		private static List<T> _SelectAttribute<T>(IReadOnlyList<JsonNode> values, string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA7730F0", Offset = "0xA7720F0", VA = "0x18A7730F0")]
		public static MeshPrimitive WithMaterial(this MeshPrimitive primitive, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA76E9E0", Offset = "0xA76D9E0", VA = "0x18A76E9E0")]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA76E950", Offset = "0xA76D950", VA = "0x18A76E950")]
		[IteratorStateMachine(typeof(<EvaluatePoints>d__75))]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA76E760", Offset = "0xA76D760", VA = "0x18A76E760")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA76E8C0", Offset = "0xA76D8C0", VA = "0x18A76E8C0")]
		[IteratorStateMachine(typeof(<EvaluateLines>d__77))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA76EDB0", Offset = "0xA76DDB0", VA = "0x18A76EDB0")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA76EEB0", Offset = "0xA76DEB0", VA = "0x18A76EEB0")]
		[IteratorStateMachine(typeof(<EvaluateTriangles>d__79))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3F580A0", Offset = "0x3F570A0", VA = "0x183F580A0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> EvaluateTriangles<TvG, TvM, TvS>(this Mesh mesh, [Optional] IGeometryTransform xform) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA76F930", Offset = "0xA76E930", VA = "0x18A76F930")]
		public static VertexBufferColumns GetVertexColumns(this MeshPrimitive primitive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA7772A0", Offset = "0xA7762A0", VA = "0x18A7772A0")]
		private static void _Initialize(IReadOnlyDictionary<string, Accessor> vertexAccessors, VertexBufferColumns dstColumns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F52D50", Offset = "0x3F51D50", VA = "0x183F52D50")]
		public static void AddMesh<TMaterial, TvG, TvM, TvS>(this MeshBuilder<TMaterial, TvG, TvM, TvS> meshBuilder, Mesh srcMesh, Converter<Material, TMaterial> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3F59190", Offset = "0x3F58190", VA = "0x183F59190")]
		public static MeshBuilder<TMaterial, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TMaterial, TvG, TvM>(this Scene srcScene, Converter<Material, TMaterial> materialFunc, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F597E0", Offset = "0x3F587E0", VA = "0x183F597E0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TvG, TvM>(this Scene srcScene, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA76FD30", Offset = "0xA76ED30", VA = "0x18A76FD30")]
		public static IMeshBuilder<MaterialBuilder> ToMeshBuilder(this Mesh srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F58EC0", Offset = "0x3F57EC0", VA = "0x183F58EC0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS>(this IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F587C0", Offset = "0x3F577C0", VA = "0x183F587C0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS, TMaterial>(this IEnumerable<(VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, TMaterial Material)> triangles, Converter<TMaterial, MaterialBuilder> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA76AB30", Offset = "0xA769B30", VA = "0x18A76AB30")]
		private static void AddPrimitiveGeometry(this IPrimitiveBuilder dstPrim, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA76FBA0", Offset = "0xA76EBA0", VA = "0x18A76FBA0")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA76FA70", Offset = "0xA76EA70", VA = "0x18A76FA70")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA772E80", Offset = "0xA771E80", VA = "0x18A772E80")]
		public static Node WithLocalTransform(this Node node, AffineTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA772F60", Offset = "0xA771F60", VA = "0x18A772F60")]
		public static Node WithLocalTranslation(this Node node, Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA772B70", Offset = "0xA771B70", VA = "0x18A772B70")]
		public static Node WithLocalRotation(this Node node, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA772CF0", Offset = "0xA771CF0", VA = "0x18A772CF0")]
		public static Node WithLocalScale(this Node node, Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA7731B0", Offset = "0xA7721B0", VA = "0x18A7731B0")]
		public static Node WithMesh(this Node node, Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA7751D0", Offset = "0xA7741D0", VA = "0x18A7751D0")]
		public static Node WithSkin(this Node node, Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA774FE0", Offset = "0xA773FE0", VA = "0x18A774FE0")]
		public static Node WithSkinBinding(this Node node, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA774CE0", Offset = "0xA773CE0", VA = "0x18A774CE0")]
		public static Node WithSkinBinding(this Node node, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA775290", Offset = "0xA774290", VA = "0x18A775290")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA7755E0", Offset = "0xA7745E0", VA = "0x18A7755E0")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA773E40", Offset = "0xA772E40", VA = "0x18A773E40")]
		public static Node WithPerspectiveCamera(this Node node, float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA773860", Offset = "0xA772860", VA = "0x18A773860")]
		public static Node WithOrthographicCamera(this Node node, float xmag, float ymag, float znear, float zfar)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA76F1D0", Offset = "0xA76E1D0", VA = "0x18A76F1D0")]
		public static Node FindNode(this Scene scene, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA76EF40", Offset = "0xA76DF40", VA = "0x18A76EF40")]
		public static Node FindNode(this Node node, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA76EB40", Offset = "0xA76DB40", VA = "0x18A76EB40")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3F580F0", Offset = "0x3F570F0", VA = "0x183F580F0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, VertexEmpty>> EvaluateTriangles<TvG, TvM>(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA765E00", Offset = "0xA764E00", VA = "0x18A765E00")]
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
				[Cpp2IlInjected.Address(RVA = "0x66EDB70", Offset = "0x66ECB70", VA = "0x1866EDB70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x72EA1F0", Offset = "0x72E91F0", VA = "0x1872EA1F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6CC36D0", Offset = "0x6CC26D0", VA = "0x186CC36D0")]
			[DebuggerHidden]
			public <_EvaluateTriangles>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x72EA470", Offset = "0x72E9470", VA = "0x1872EA470", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x72E8BD0", Offset = "0x72E7BD0", VA = "0x1872E8BD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x72EA6C0", Offset = "0x72E96C0", VA = "0x1872EA6C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x72E9BB0", Offset = "0x72E8BB0", VA = "0x1872E9BB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>> IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x72E9FF0", Offset = "0x72E8FF0", VA = "0x1872E9FF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x62AFC20", Offset = "0x62AEC20", VA = "0x1862AFC20")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> GetTrianglesFromMesh(Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x62B29B0", Offset = "0x62B19B0", VA = "0x1862B29B0")]
		private static List<(Material, VertexBufferColumns, IEnumerable<(int, int, int)>)> _GatherMeshGeometry(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x62B0CF0", Offset = "0x62AFCF0", VA = "0x1862B0CF0")]
		[IteratorStateMachine(typeof(EvaluatedTriangle<, , >.<_EvaluateTriangles>d__2))]
		private static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> _EvaluateTriangles(Material material, VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x62B5810", Offset = "0x62B4810", VA = "0x1862B5810")]
		public static implicit operator EvaluatedTriangle<TvG, TvM, TvS>((VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, Material Material) tri)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x62B5320", Offset = "0x62B4320", VA = "0x1862B5320")]
		public EvaluatedTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, Material m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x62B0610", Offset = "0x62AF610", VA = "0x1862B0610")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> TransformTextureCoordsByMaterial(IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles, [Optional] Animation track, float time = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x62B4550", Offset = "0x62B3550", VA = "0x1862B4550")]
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
				[Cpp2IlInjected.Address(RVA = "0x10BF4D0", Offset = "0x10BE4D0", VA = "0x1810BF4D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x1354300", Offset = "0x1353300", VA = "0x181354300")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float YMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xE71300", Offset = "0xE70300", VA = "0x180E71300")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xF07D10", Offset = "0xF06D10", VA = "0x180F07D10")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA762AC0", Offset = "0xA761AC0", VA = "0x18A762AC0")]
			public Orthographic(float xmag, float ymag, float znear, float zfar)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA762B20", Offset = "0xA761B20", VA = "0x18A762B20")]
			internal Orthographic(CameraOrthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA762960", Offset = "0xA761960", VA = "0x18A762960", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA762BB0", Offset = "0xA761BB0", VA = "0x18A762BB0")]
			private Orthographic(Orthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA762A60", Offset = "0xA761A60", VA = "0x18A762A60", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCFCB30", Offset = "0xCFBB30", VA = "0x180CFCB30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public float VerticalFOV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xE712F0", Offset = "0xE702F0", VA = "0x180E712F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x10B0500", Offset = "0x10AF500", VA = "0x1810B0500")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA762E40", Offset = "0xA761E40", VA = "0x18A762E40")]
			public Perspective(float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA762EA0", Offset = "0xA761EA0", VA = "0x18A762EA0")]
			internal Perspective(CameraPerspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA762C90", Offset = "0xA761C90", VA = "0x18A762C90", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA762F30", Offset = "0xA761F30", VA = "0x18A762F30")]
			private Perspective(Perspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA762D90", Offset = "0xA761D90", VA = "0x18A762D90", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0C90", Offset = "0xA6AFC90", VA = "0x18A6B0C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD46190", Offset = "0xD45190", VA = "0x180D46190")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10BE130", Offset = "0x10BD130", VA = "0x1810BE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD4BA50", Offset = "0xD4AA50", VA = "0x180D4BA50")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD4B840", Offset = "0xD4A840", VA = "0x180D4B840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA75BCF0", Offset = "0xA75ACF0", VA = "0x18A75BCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA75BD20", Offset = "0xA75AD20", VA = "0x18A75BD20")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CameraBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA75BCB0", Offset = "0xA75ACB0", VA = "0x18A75BCB0")]
		protected CameraBuilder(float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA75BBE0", Offset = "0xA75ABE0", VA = "0x18A75BBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EmptyContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA75C3E0", Offset = "0xA75B3E0", VA = "0x18A75C3E0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public MeshContent(IMeshBuilder<MaterialBuilder> mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA75E1D0", Offset = "0xA75D1D0", VA = "0x18A75E1D0", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9260", Offset = "0x8FC8260", VA = "0x188FC9260")]
		private MeshContent(MeshContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B76350", Offset = "0x2B75350", VA = "0x182B76350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA75E320", Offset = "0xA75D320", VA = "0x18A75E320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA75E240", Offset = "0xA75D240", VA = "0x18A75E240", Slot = "6")]
		public bool Equals(IRenderableContent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA75E430", Offset = "0xA75D430", VA = "0x18A75E430", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public CameraContent(CameraBuilder camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA75BD70", Offset = "0xA75AD70", VA = "0x18A75BD70", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA75C150", Offset = "0xA75B150", VA = "0x18A75C150")]
		private CameraContent(CameraContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA75BE00", Offset = "0xA75AE00", VA = "0x18A75BE00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public LightContent(LightBuilder light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA75DDF0", Offset = "0xA75CDF0", VA = "0x18A75DDF0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA75C150", Offset = "0xA75B150", VA = "0x18A75C150")]
		private LightContent(LightContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA75DE80", Offset = "0xA75CE80", VA = "0x18A75DE80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75DCA0", Offset = "0xA75CCA0", VA = "0x18A75DCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA75DC00", Offset = "0xA75CC00", VA = "0x18A75DC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ContentTransformer Content
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA75DC20", Offset = "0xA75CC20", VA = "0x18A75DC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		internal InstanceBuilder(SceneBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA75DB20", Offset = "0xA75CB20", VA = "0x18A75DB20")]
		public InstanceBuilder WithName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA75DAF0", Offset = "0xA75CAF0", VA = "0x18A75DAF0")]
		public InstanceBuilder WithExtras(JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA75DA80", Offset = "0xA75CA80", VA = "0x18A75DA80")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA75DB50", Offset = "0xA75CB50", VA = "0x18A75DB50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75C2C0", Offset = "0xA75B2C0", VA = "0x18A75C2C0")]
			public Directional()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA75C3D0", Offset = "0xA75B3D0", VA = "0x18A75C3D0")]
			internal Directional(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA75C1C0", Offset = "0xA75B1C0", VA = "0x18A75C1C0", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA75C300", Offset = "0xA75B300", VA = "0x18A75C300")]
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
				[Cpp2IlInjected.Address(RVA = "0xE712F0", Offset = "0xE702F0", VA = "0x180E712F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x10B0500", Offset = "0x10AF500", VA = "0x1810B0500")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA763230", Offset = "0xA762230", VA = "0x18A763230")]
			public Point()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA7631F0", Offset = "0xA7621F0", VA = "0x18A7631F0")]
			internal Point(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA763010", Offset = "0xA762010", VA = "0x18A763010", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA763110", Offset = "0xA762110", VA = "0x18A763110")]
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
				[Cpp2IlInjected.Address(RVA = "0xE712F0", Offset = "0xE702F0", VA = "0x180E712F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x10B0500", Offset = "0x10AF500", VA = "0x1810B0500")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public float InnerConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0xDD4560", Offset = "0xDD3560", VA = "0x180DD4560")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0xDD4570", Offset = "0xDD3570", VA = "0x180DD4570")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public float OuterConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0xD8DC50", Offset = "0xD8CC50", VA = "0x180D8DC50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x112F670", Offset = "0x112E670", VA = "0x18112F670")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA76AA80", Offset = "0xA769A80", VA = "0x18A76AA80")]
			public Spot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA76AAD0", Offset = "0xA769AD0", VA = "0x18A76AAD0")]
			internal Spot(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA76A880", Offset = "0xA769880", VA = "0x18A76A880", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA76A990", Offset = "0xA769990", VA = "0x18A76A990")]
			private Spot(Spot other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0C90", Offset = "0xA6AFC90", VA = "0x18A6B0C90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xFCA0E0", Offset = "0xFC90E0", VA = "0x180FCA0E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xFCA100", Offset = "0xFC9100", VA = "0x180FCA100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xE71300", Offset = "0xE70300", VA = "0x180E71300")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xF07D10", Offset = "0xF06D10", VA = "0x180F07D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA75C2C0", Offset = "0xA75B2C0", VA = "0x18A75C2C0")]
		protected LightBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA75DCC0", Offset = "0xA75CCC0", VA = "0x18A75DCC0")]
		protected LightBuilder(PunctualLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LightBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA75C300", Offset = "0xA75B300", VA = "0x18A75C300")]
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
				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <Flatten>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA779930", Offset = "0xA778930", VA = "0x18A779930", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA779500", Offset = "0xA778500", VA = "0x18A779500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA779AD0", Offset = "0xA778AD0", VA = "0x18A779AD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA779B20", Offset = "0xA778B20", VA = "0x18A779B20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA7798F0", Offset = "0xA7788F0", VA = "0x18A7798F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA779850", Offset = "0xA778850", VA = "0x18A779850", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NodeBuilder> IEnumerable<NodeBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA779850", Offset = "0xA778850", VA = "0x18A779850", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NodeBuilder Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA761E50", Offset = "0xA760E50", VA = "0x18A761E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<NodeBuilder> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IEnumerable<string> AnimationTracksNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA7612C0", Offset = "0xA7602C0", VA = "0x18A7612C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HasAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA761450", Offset = "0xA760450", VA = "0x18A761450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HasTransformAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA7614B0", Offset = "0xA7604B0", VA = "0x18A7614B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AnimatableProperty<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnimatableProperty<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD01440", Offset = "0xD00440", VA = "0x180D01440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AnimatableProperty<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD01430", Offset = "0xD00430", VA = "0x180D01430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA761B20", Offset = "0xA760B20", VA = "0x18A761B20")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA762330", Offset = "0xA761330", VA = "0x18A762330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA761C00", Offset = "0xA760C00", VA = "0x18A761C00")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA7623F0", Offset = "0xA7613F0", VA = "0x18A7623F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA762130", Offset = "0xA761130", VA = "0x18A762130")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA762880", Offset = "0xA761880", VA = "0x18A762880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA7615C0", Offset = "0xA7605C0", VA = "0x18A7615C0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA761E70", Offset = "0xA760E70", VA = "0x18A761E70")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public AnimatableProperty<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD24A30", Offset = "0xD23A30", VA = "0x180D24A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool? IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA761550", Offset = "0xA760550", VA = "0x18A761550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA762240", Offset = "0xA761240", VA = "0x18A762240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA760AF0", Offset = "0xA75FAF0", VA = "0x18A760AF0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA761180", Offset = "0xA760180", VA = "0x18A761180")]
		public NodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA7610E0", Offset = "0xA7600E0", VA = "0x18A7610E0")]
		public NodeBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA761200", Offset = "0xA760200", VA = "0x18A761200")]
		public NodeBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA75EAF0", Offset = "0xA75DAF0", VA = "0x18A75EAF0")]
		public Dictionary<NodeBuilder, NodeBuilder> DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA75E790", Offset = "0xA75D790", VA = "0x18A75E790")]
		private NodeBuilder DeepClone(IDictionary<NodeBuilder, NodeBuilder> nodeMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA75E700", Offset = "0xA75D700", VA = "0x18A75E700")]
		public NodeBuilder CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA75E4B0", Offset = "0xA75D4B0", VA = "0x18A75E4B0")]
		public void AddNode(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA75F320", Offset = "0xA75E320", VA = "0x18A75F320")]
		public static bool IsValidArmature(IEnumerable<NodeBuilder> joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA75EB60", Offset = "0xA75DB60", VA = "0x18A75EB60")]
		[IteratorStateMachine(typeof(<Flatten>d__52))]
		public static IEnumerable<NodeBuilder> Flatten(NodeBuilder container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA760F30", Offset = "0xA75FF30", VA = "0x18A760F30")]
		private void _UseDecomposedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA75FE60", Offset = "0xA75EE60", VA = "0x18A75FE60")]
		public AnimatableProperty<Vector3> UseScale()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA75FF20", Offset = "0xA75EF20", VA = "0x18A75FF20")]
		public CurveBuilder<Vector3> UseScale(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA75FD90", Offset = "0xA75ED90", VA = "0x18A75FD90")]
		public AnimatableProperty<Quaternion> UseRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA75FD30", Offset = "0xA75ED30", VA = "0x18A75FD30")]
		public CurveBuilder<Quaternion> UseRotation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA75FF80", Offset = "0xA75EF80", VA = "0x18A75FF80")]
		public AnimatableProperty<Vector3> UseTranslation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA760050", Offset = "0xA75F050", VA = "0x18A760050")]
		public CurveBuilder<Vector3> UseTranslation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA75FC50", Offset = "0xA75EC50", VA = "0x18A75FC50")]
		public void SetScaleTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA75FCC0", Offset = "0xA75ECC0", VA = "0x18A75FCC0")]
		public void SetTranslationTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA75FBE0", Offset = "0xA75EBE0", VA = "0x18A75FBE0")]
		public void SetRotationTrack(string track, ICurveSampler<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA75EEF0", Offset = "0xA75DEF0", VA = "0x18A75EEF0")]
		public AffineTransform GetLocalTransform(string animationTrack, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA75F140", Offset = "0xA75E140", VA = "0x18A75F140")]
		public Matrix4x4 GetWorldMatrix(string animationTrack, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA75EBE0", Offset = "0xA75DBE0", VA = "0x18A75EBE0")]
		public Matrix4x4 GetInverseBindMatrix([Optional] Matrix4x4? meshWorldMatrix)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA75F800", Offset = "0xA75E800", VA = "0x18A75F800")]
		public void SetLocalTransform(AffineTransform newLocalTransform, bool keepChildrenInPlace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA7600B0", Offset = "0xA75F0B0", VA = "0x18A7600B0")]
		public AnimatableProperty<bool> UseVisibility()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA760A90", Offset = "0xA75FA90", VA = "0x18A760A90")]
		public NodeBuilder WithLocalTranslation(Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA760490", Offset = "0xA75F490", VA = "0x18A760490")]
		public NodeBuilder WithLocalScale(Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA760430", Offset = "0xA75F430", VA = "0x18A760430")]
		public NodeBuilder WithLocalRotation(Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA7607C0", Offset = "0xA75F7C0", VA = "0x18A7607C0")]
		public NodeBuilder WithLocalTranslation(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA760160", Offset = "0xA75F160", VA = "0x18A760160")]
		public NodeBuilder WithLocalRotation(string animTrack, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA7604F0", Offset = "0xA75F4F0", VA = "0x18A7604F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <CreateFrom>d__31(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA790540", Offset = "0xA78F540", VA = "0x18A790540", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA790090", Offset = "0xA78F090", VA = "0x18A790090", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA790620", Offset = "0xA78F620", VA = "0x18A790620")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA790500", Offset = "0xA78F500", VA = "0x18A790500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA790460", Offset = "0xA78F460", VA = "0x18A790460", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SceneBuilder> IEnumerable<SceneBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA790460", Offset = "0xA78F460", VA = "0x18A790460", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA76A6E0", Offset = "0xA7696E0", VA = "0x18A76A6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal IEnumerable<string> AnimationTrackNames
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA76A5B0", Offset = "0xA7695B0", VA = "0x18A76A5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA76A510", Offset = "0xA769510", VA = "0x18A76A510")]
		public SceneBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA765E70", Offset = "0xA764E70", VA = "0x18A765E70")]
		public SceneBuilder DeepClone(bool cloneArmatures = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA766790", Offset = "0xA765790", VA = "0x18A766790")]
		[Obsolete("Use LoadDefaultScene(...); or LoadAllScenes(...) instead.", true)]
		public static SceneBuilder Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA766790", Offset = "0xA765790", VA = "0x18A766790")]
		public static SceneBuilder LoadDefaultScene(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA7666C0", Offset = "0xA7656C0", VA = "0x18A7666C0")]
		public static SceneBuilder[] LoadAllScenes(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA7641A0", Offset = "0xA7631A0", VA = "0x18A7641A0")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA764630", Offset = "0xA763630", VA = "0x18A764630")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA7643C0", Offset = "0xA7633C0", VA = "0x18A7643C0")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node, AffineTransform instanceTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA7649C0", Offset = "0xA7639C0", VA = "0x18A7649C0")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, Matrix4x4 meshWorldMatrix, params NodeBuilder[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA764D30", Offset = "0xA763D30", VA = "0x18A764D30")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, params (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA763270", Offset = "0xA762270", VA = "0x18A763270")]
		public InstanceBuilder AddCamera(CameraBuilder camera, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA7636E0", Offset = "0xA7626E0", VA = "0x18A7636E0")]
		public InstanceBuilder AddCamera(CameraBuilder camera, Vector3 cameraPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA7634C0", Offset = "0xA7624C0", VA = "0x18A7634C0")]
		public InstanceBuilder AddCamera(CameraBuilder camera, AffineTransform cameraTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA763B50", Offset = "0xA762B50", VA = "0x18A763B50")]
		public InstanceBuilder AddLight(LightBuilder light, AffineTransform lightTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA763D70", Offset = "0xA762D70", VA = "0x18A763D70")]
		public InstanceBuilder AddLight(LightBuilder light, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA763FC0", Offset = "0xA762FC0", VA = "0x18A763FC0")]
		public InstanceBuilder AddNode(NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA7664A0", Offset = "0xA7654A0", VA = "0x18A7664A0")]
		public IReadOnlyList<NodeBuilder> FindArmatures()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA7650E0", Offset = "0xA7640E0", VA = "0x18A7650E0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA764820", Offset = "0xA763820", VA = "0x18A764820")]
		public IReadOnlyList<InstanceBuilder> AddScene(SceneBuilder scene, Matrix4x4 sceneTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA766D70", Offset = "0xA765D70", VA = "0x18A766D70", Slot = "8")]
		public ModelRoot ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA766830", Offset = "0xA765830", VA = "0x18A766830")]
		public ModelRoot ToGltf2(SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA766900", Offset = "0xA765900", VA = "0x18A766900")]
		public static ModelRoot ToGltf2(IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA765D30", Offset = "0xA764D30", VA = "0x18A765D30")]
		public static SceneBuilder[] CreateFrom(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA765E00", Offset = "0xA764E00", VA = "0x18A765E00")]
		public static SceneBuilder CreateFrom(Scene srcScene)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA765CB0", Offset = "0xA764CB0", VA = "0x18A765CB0")]
		[IteratorStateMachine(typeof(<CreateFrom>d__31))]
		public static IEnumerable<SceneBuilder> CreateFrom(IEnumerable<Scene> srcScenes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA768BA0", Offset = "0xA767BA0", VA = "0x18A768BA0")]
		private static SceneBuilder _CreateFrom(Scene srcScene, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshInstances)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA7692F0", Offset = "0xA7682F0", VA = "0x18A7692F0")]
		private static Dictionary<Node, IMeshBuilder<MaterialBuilder>> _GatherMeshInstances(IEnumerable<Node> srcNodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA7678E0", Offset = "0xA7668E0", VA = "0x18A7678E0")]
		private static void _AddMeshInstances(SceneBuilder dstScene, IEnumerable<Node> srcNodes, IReadOnlyDictionary<Node, NodeBuilder> nodesDict, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshesDict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA766E90", Offset = "0xA765E90", VA = "0x18A766E90")]
		private static void _AddCameraInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA7674F0", Offset = "0xA7664F0", VA = "0x18A7674F0")]
		private static void _AddLightInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA767260", Offset = "0xA766260", VA = "0x18A767260")]
		private static void _AddEmptyInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA768400", Offset = "0xA767400", VA = "0x18A768400")]
		private static void _CopyToNodeBuilder(NodeBuilder dstNode, Node srcNode, IDictionary<Node, NodeBuilder> nodeMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA768840", Offset = "0xA767840", VA = "0x18A768840")]
		private static void _CopyTransformAnimation(NodeBuilder dstNode, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA767F50", Offset = "0xA766F50", VA = "0x18A767F50")]
		private static void _CopyMorphingAnimation(InstanceBuilder dstInst, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFABA0", Offset = "0x3EF9BA0", VA = "0x183EFABA0")]
		internal static void _VerifyCurveConversion<T>(IAnimationSampler<T> a, IConvertibleCurve<T> b, Func<T, T, bool> equalityComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA769820", Offset = "0xA768820", VA = "0x18A769820")]
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
			[Cpp2IlInjected.Address(RVA = "0xA788910", Offset = "0xA787910", VA = "0x18A788910")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SceneBuilderSchema2Settings WithGpuInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA788930", Offset = "0xA787930", VA = "0x18A788930")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UseStridedBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x10B2150", Offset = "0x10B1150", VA = "0x1810B2150")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2722470", Offset = "0x2721470", VA = "0x182722470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CompactVertexWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x112F840", Offset = "0x112E840", VA = "0x18112F840")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x112F870", Offset = "0x112E870", VA = "0x18112F870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x30C0890", Offset = "0x30BF890", VA = "0x1830C0890")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x30C08A0", Offset = "0x30BF8A0", VA = "0x1830C08A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xECDF70", Offset = "0xECCF70", VA = "0x180ECDF70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xECDF90", Offset = "0xECCF90", VA = "0x180ECDF90")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA60", Offset = "0xCFAA60", VA = "0x180CFBA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA78B3A0", Offset = "0xA78A3A0", VA = "0x18A78B3A0")]
		public Mesh GetMesh(IMeshBuilder<MaterialBuilder> key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA78B430", Offset = "0xA78A430", VA = "0x18A78B430")]
		public Node GetNode(NodeBuilder key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA78B4C0", Offset = "0xA78A4C0", VA = "0x18A78B4C0")]
		public static bool HasContent(Node node, bool checkTransform = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA788E20", Offset = "0xA787E20", VA = "0x18A788E20")]
		public void AddGeometryResources(ModelRoot root, IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA788950", Offset = "0xA787950", VA = "0x18A788950")]
		private void AddArmatureResources(IEnumerable<SceneBuilder> srcScenes, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA78A740", Offset = "0xA789740", VA = "0x18A78A740")]
		private void CreateArmature(NodeBuilder srcNode, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA78B6B0", Offset = "0xA78A6B0", VA = "0x18A78B6B0")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<SparseWeight8> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA78BA10", Offset = "0xA78AA10", VA = "0x18A78BA10")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<ArraySegment<float>> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA78A5A0", Offset = "0xA7895A0", VA = "0x18A78A5A0")]
		public void AddScene(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA789F60", Offset = "0xA788F60", VA = "0x18A789F60")]
		private void AddMeshes(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA789960", Offset = "0xA788960", VA = "0x18A789960")]
		private void AddLightsAndCameras(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA78BE80", Offset = "0xA78AE80", VA = "0x18A78BE80")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AffineTransform? Child
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x691C520", Offset = "0x691B520", VA = "0x18691C520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA78EE20", Offset = "0xA78DE20", VA = "0x18A78EE20")]
		public static implicit operator TransformChainBuilder(NodeBuilder node)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA78EE70", Offset = "0xA78DE70", VA = "0x18A78EE70")]
		public static implicit operator TransformChainBuilder(AffineTransform transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA78EED0", Offset = "0xA78DED0", VA = "0x18A78EED0")]
		public static implicit operator TransformChainBuilder(Matrix4x4 transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA78EC60", Offset = "0xA78DC60", VA = "0x18A78EC60")]
		public TransformChainBuilder(AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA78EC30", Offset = "0xA78DC30", VA = "0x18A78EC30")]
		public TransformChainBuilder(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA78ED40", Offset = "0xA78DD40", VA = "0x18A78ED40")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			internal DeepCloneContext(IReadOnlyDictionary<NodeBuilder, NodeBuilder> nmap)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA7811B0", Offset = "0xA7801B0", VA = "0x18A7811B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA781130", Offset = "0xA780130", VA = "0x18A781130")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AnimatableProperty<ArraySegment<float>> Morphings
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HasRenderableContent
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA7810E0", Offset = "0xA7800E0", VA = "0x18A7810E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA780FD0", Offset = "0xA77FFD0", VA = "0x18A780FD0")]
		protected ContentTransformer(object content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ContentTransformer DeepClone(DeepCloneContext args);

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA780E90", Offset = "0xA77FE90", VA = "0x18A780E90")]
		protected ContentTransformer(ContentTransformer other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA780A70", Offset = "0xA77FA70", VA = "0x18A780A70")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA7809F0", Offset = "0xA77F9F0", VA = "0x18A7809F0")]
		public CameraBuilder GetCameraAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA780AD0", Offset = "0xA77FAD0", VA = "0x18A780AD0")]
		public LightBuilder GetLightAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract NodeBuilder GetArmatureRoot();

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA780D60", Offset = "0xA77FD60", VA = "0x18A780D60")]
		public AnimatableProperty<ArraySegment<float>> UseMorphing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA780B50", Offset = "0xA77FB50", VA = "0x18A780B50")]
		public CurveBuilder<ArraySegment<float>> UseMorphing(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract Matrix4x4 GetPoseWorldMatrix();

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA780820", Offset = "0xA77F820", VA = "0x18A780820")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NodeBuilder ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AffineTransform ChildTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x9568700", Offset = "0x9567700", VA = "0x189568700")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9568770", Offset = "0x9567770", VA = "0x189568770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA7817C0", Offset = "0xA7807C0", VA = "0x18A7817C0")]
		internal FixedTransformer(object content, AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA781620", Offset = "0xA780620", VA = "0x18A781620")]
		internal FixedTransformer(object content, NodeBuilder parentNode, AffineTransform childTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA781680", Offset = "0xA780680", VA = "0x18A781680")]
		protected FixedTransformer(FixedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA7812B0", Offset = "0xA7802B0", VA = "0x18A7812B0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA781420", Offset = "0xA780420", VA = "0x18A781420", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA781440", Offset = "0xA780440", VA = "0x18A781440", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7407E70", Offset = "0x7406E70", VA = "0x187407E70", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x99278F0", Offset = "0x99268F0", VA = "0x1899278F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x18B5290", Offset = "0x18B4290", VA = "0x1818B5290", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x99278A0", Offset = "0x99268A0", VA = "0x1899278A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NodeBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA7887F0", Offset = "0xA7877F0", VA = "0x18A7887F0")]
		internal RigidTransformer(object content, NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA788830", Offset = "0xA787830", VA = "0x18A788830")]
		protected RigidTransformer(RigidTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA788530", Offset = "0xA787530", VA = "0x18A788530", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA788650", Offset = "0xA787650", VA = "0x18A788650", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA788670", Offset = "0xA787670", VA = "0x18A788670", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA7886C0", Offset = "0xA7876C0", VA = "0x18A7886C0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA78D6F0", Offset = "0xA78C6F0", VA = "0x18A78D6F0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA78D7D0", Offset = "0xA78C7D0", VA = "0x18A78D7D0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA78D280", Offset = "0xA78C280", VA = "0x18A78D280")]
		protected SkinnedTransformer(SkinnedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA78BF90", Offset = "0xA78AF90", VA = "0x18A78BF90", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA78C7F0", Offset = "0xA78B7F0", VA = "0x18A78C7F0")]
		private void SetJoints(AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA78CAC0", Offset = "0xA78BAC0", VA = "0x18A78CAC0")]
		private void SetJoints((NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA78C150", Offset = "0xA78B150", VA = "0x18A78C150")]
		public (NodeBuilder, Matrix4x4)[] GetJointBindings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA78C000", Offset = "0xA78B000", VA = "0x18A78C000", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA78C650", Offset = "0xA78B650", VA = "0x18A78C650")]
		public IGeometryTransform GetWorldTransformer(string animationTrack, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA78C4F0", Offset = "0xA78B4F0", VA = "0x18A78C4F0", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA78CEC0", Offset = "0xA78BEC0", VA = "0x18A78CEC0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <CreateFrom>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA78FD10", Offset = "0xA78ED10", VA = "0x18A78FD10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA78EFB0", Offset = "0xA78DFB0", VA = "0x18A78EFB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA78FFA0", Offset = "0xA78EFA0", VA = "0x18A78FFA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA78FFF0", Offset = "0xA78EFF0", VA = "0x18A78FFF0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA790040", Offset = "0xA78F040", VA = "0x18A790040")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA78FCD0", Offset = "0xA78ECD0", VA = "0x18A78FCD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA78FC20", Offset = "0xA78EC20", VA = "0x18A78FC20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Schema2SceneBuilder.IOperator<Scene>> IEnumerable<Schema2SceneBuilder.IOperator<Scene>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA78FC20", Offset = "0xA78EC20", VA = "0x18A78FC20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79C710", Offset = "0xA79B710", VA = "0x18A79C710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA79BE20", Offset = "0xA79AE20", VA = "0x18A79BE20")]
		[IteratorStateMachine(typeof(<CreateFrom>d__2))]
		public static IEnumerable<Schema2SceneBuilder.IOperator<Scene>> CreateFrom(IEnumerable<FixedTransformer> instances, int gpuMinCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA79C600", Offset = "0xA79B600", VA = "0x18A79C600")]
		private _MeshInstancing(NodeBuilder parentNode, IEnumerable<FixedTransformer> children, int gpuMinCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA79BB90", Offset = "0xA79AB90", VA = "0x18A79BB90", Slot = "4")]
		public void ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA79BEA0", Offset = "0xA79AEA0", VA = "0x18A79BEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79BB30", Offset = "0xA79AB30", VA = "0x18A79BB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		public _FixedIntance(FixedTransformer fixedXformer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA79B980", Offset = "0xA79A980", VA = "0x18A79B980", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79B7B0", Offset = "0xA79A7B0", VA = "0x18A79B7B0", Slot = "4")]
			public bool Equals(ChannelBuilder x, ChannelBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA790BB0", Offset = "0xA78FBB0", VA = "0x18A790BB0", Slot = "5")]
			public int GetHashCode(ChannelBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KnownChannel Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
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
			[Cpp2IlInjected.Address(RVA = "0xA77ECD0", Offset = "0xA77DCD0", VA = "0x18A77ECD0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA77ED10", Offset = "0xA77DD10", VA = "0x18A77ED10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MaterialValue.Collection Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
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
			[Cpp2IlInjected.Address(RVA = "0xA77EC80", Offset = "0xA77DC80", VA = "0x18A77EC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA77E9B0", Offset = "0xA77D9B0", VA = "0x18A77E9B0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA77EA90", Offset = "0xA77DA90", VA = "0x18A77EA90")]
		internal ChannelBuilder(MaterialBuilder parent, KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA77E6D0", Offset = "0xA77D6D0", VA = "0x18A77E6D0")]
		public static bool AreEqualByContent(ChannelBuilder x, ChannelBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA77E840", Offset = "0xA77D840", VA = "0x18A77E840")]
		public static int GetContentHashCode(ChannelBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA77E8C0", Offset = "0xA77D8C0", VA = "0x18A77E8C0")]
		public TextureBuilder GetValidTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA77E8E0", Offset = "0xA77D8E0", VA = "0x18A77E8E0")]
		public TextureBuilder UseTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xD226A0", Offset = "0xD216A0", VA = "0x180D226A0")]
		public void RemoveTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA77E7C0", Offset = "0xA77D7C0", VA = "0x18A77E7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xED7510", Offset = "0xED6510", VA = "0x180ED7510")]
			[CompilerGenerated]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x53A8DB0", Offset = "0x53A7DB0", VA = "0x1853A8DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA781CC0", Offset = "0xA780CC0", VA = "0x18A781CC0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA781E00", Offset = "0xA780E00", VA = "0x18A781E00")]
		public static implicit operator ImageBuilder(ArraySegment<byte> image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA781FB0", Offset = "0xA780FB0", VA = "0x18A781FB0")]
		public static implicit operator ImageBuilder(byte[] image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA781EE0", Offset = "0xA780EE0", VA = "0x18A781EE0")]
		public static implicit operator ImageBuilder(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA782080", Offset = "0xA781080", VA = "0x18A782080")]
		public static implicit operator ImageBuilder(MemoryImage content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA7819C0", Offset = "0xA7809C0", VA = "0x18A7819C0")]
		public static ImageBuilder From(MemoryImage content, [Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA781A80", Offset = "0xA780A80", VA = "0x18A781A80")]
		public static ImageBuilder From(MemoryImage content, string name, JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA781D80", Offset = "0xA780D80", VA = "0x18A781D80")]
		private ImageBuilder(MemoryImage content, string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA781940", Offset = "0xA780940", VA = "0x18A781940")]
		internal ImageBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA781DC0", Offset = "0xA780DC0", VA = "0x18A781DC0")]
		private ImageBuilder(ImageBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA781800", Offset = "0xA780800", VA = "0x18A781800")]
		public static bool AreEqualByContent(ImageBuilder x, ImageBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA781B50", Offset = "0xA780B50", VA = "0x18A781B50")]
		public static int GetContentHashCode(ImageBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA781BE0", Offset = "0xA780BE0", VA = "0x18A781BE0")]
		public static bool IsEmpty(ImageBuilder ib)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA781C50", Offset = "0xA780C50", VA = "0x18A781C50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79B730", Offset = "0xA79A730", VA = "0x18A79B730", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA79B7D0", Offset = "0xA79A7D0", VA = "0x18A79B7D0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x171C8B0", Offset = "0x171B8B0", VA = "0x18171C8B0", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7A343E0", Offset = "0x7A333E0", VA = "0x187A343E0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0")]
			[CompilerGenerated]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xDEFC00", Offset = "0xDEEC00", VA = "0x180DEFC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD24D90", Offset = "0xD23D90", VA = "0x180D24D90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xD24AC0", Offset = "0xD23AC0", VA = "0x180D24AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xF57640", Offset = "0xF56640", VA = "0x180F57640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xF57520", Offset = "0xF56520", VA = "0x180F57520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ShaderStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA786260", Offset = "0xA785260", VA = "0x18A786260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD47610", Offset = "0xD46610", VA = "0x180D47610")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x14FAFD0", Offset = "0x14F9FD0", VA = "0x1814FAFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x12238A0", Offset = "0x12228A0", VA = "0x1812238A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA9ED0", Offset = "0x2AA8ED0", VA = "0x182AA9ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MaterialBuilder CompatibilityFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA7861C0", Offset = "0xA7851C0", VA = "0x18A7861C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public static IEqualityComparer<MaterialBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA786120", Offset = "0xA785120", VA = "0x18A786120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static IEqualityComparer<MaterialBuilder> ReferenceComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA786170", Offset = "0xA785170", VA = "0x18A786170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA785710", Offset = "0xA784710", VA = "0x18A785710")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA782590", Offset = "0xA781590", VA = "0x18A782590")]
		public static MaterialBuilder CreateDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA786060", Offset = "0xA785060", VA = "0x18A786060")]
		public MaterialBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA782C00", Offset = "0xA781C00", VA = "0x18A782C00", Slot = "8")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA782530", Offset = "0xA781530", VA = "0x18A782530")]
		public MaterialBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA785D10", Offset = "0xA784D10", VA = "0x18A785D10")]
		public MaterialBuilder(MaterialBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF8C80", Offset = "0xCF7C80", VA = "0x180CF8C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF8AD0", Offset = "0xCF7AD0", VA = "0x180CF8AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA782130", Offset = "0xA781130", VA = "0x18A782130")]
		public static bool AreEqualByContent(MaterialBuilder x, MaterialBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA782890", Offset = "0xA781890", VA = "0x18A782890")]
		public static int GetContentHashCode(MaterialBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7859D0", Offset = "0xA7849D0", VA = "0x18A7859D0")]
		private void _SetShader(string shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA782760", Offset = "0xA781760", VA = "0x18A782760")]
		[Obsolete("Use GetChannel with KnownChannel whenever possible")]
		public ChannelBuilder GetChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA782DF0", Offset = "0xA781DF0", VA = "0x18A782DF0")]
		[Obsolete("Use UseChannel with KnownChannel whenever possible")]
		public ChannelBuilder UseChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA782690", Offset = "0xA781690", VA = "0x18A782690")]
		public ChannelBuilder GetChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA782C60", Offset = "0xA781C60", VA = "0x18A782C60")]
		public ChannelBuilder UseChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA782B00", Offset = "0xA781B00", VA = "0x18A782B00")]
		public void RemoveChannel(KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA782F20", Offset = "0xA781F20", VA = "0x18A782F20")]
		internal void ValidateForSchema2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA784EE0", Offset = "0xA783EE0", VA = "0x18A784EE0")]
		public MaterialBuilder WithShader(string shader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA7854C0", Offset = "0xA7844C0", VA = "0x18A7854C0")]
		public MaterialBuilder WithUnlitShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA784A60", Offset = "0xA783A60", VA = "0x18A784A60")]
		public MaterialBuilder WithMetallicRoughnessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA785090", Offset = "0xA784090", VA = "0x18A785090")]
		[Obsolete("SpecularGlossiness has been deprecated by Khronos")]
		public MaterialBuilder WithSpecularGlossinessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA783580", Offset = "0xA782580", VA = "0x18A783580")]
		public MaterialBuilder WithAlpha(AlphaMode alphaMode = AlphaMode.OPAQUE, float alphaCutoff = 0.5f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x9196700", Offset = "0x9195700", VA = "0x189196700")]
		public MaterialBuilder WithDoubleSide(bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA783AE0", Offset = "0xA782AE0", VA = "0x18A783AE0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA783A00", Offset = "0xA782A00", VA = "0x18A783A00")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(string channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA7838C0", Offset = "0xA7828C0", VA = "0x18A7838C0")]
		[Obsolete("Use WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)")]
		public MaterialBuilder WithChannelImage(string channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA783A50", Offset = "0xA782A50", VA = "0x18A783A50")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, object parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA783910", Offset = "0xA782910", VA = "0x18A783910")]
		public MaterialBuilder WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA784380", Offset = "0xA783380", VA = "0x18A784380")]
		public MaterialBuilder WithFallback(MaterialBuilder fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7846D0", Offset = "0xA7836D0", VA = "0x18A7846D0")]
		public MaterialBuilder WithMetallicRoughnessFallback(ImageBuilder baseColor, Vector4? rgba, ImageBuilder metallicRoughness, float? metallic, float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA784D60", Offset = "0xA783D60", VA = "0x18A784D60")]
		public MaterialBuilder WithNormal(ImageBuilder imageFile, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA784E20", Offset = "0xA783E20", VA = "0x18A784E20")]
		public MaterialBuilder WithOcclusion(ImageBuilder imageFile, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA784210", Offset = "0xA783210", VA = "0x18A784210")]
		public MaterialBuilder WithEmissive(Vector3 rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA784050", Offset = "0xA783050", VA = "0x18A784050")]
		public MaterialBuilder WithEmissive(ImageBuilder imageFile, [Optional] Vector3? rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7836E0", Offset = "0xA7826E0", VA = "0x18A7836E0")]
		public MaterialBuilder WithBaseColor(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7837A0", Offset = "0xA7827A0", VA = "0x18A7837A0")]
		public MaterialBuilder WithBaseColor(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA784C00", Offset = "0xA783C00", VA = "0x18A784C00")]
		public MaterialBuilder WithMetallicRoughness([Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA784AA0", Offset = "0xA783AA0", VA = "0x18A784AA0")]
		public MaterialBuilder WithMetallicRoughness(ImageBuilder imageFile, [Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA783B30", Offset = "0xA782B30", VA = "0x18A783B30")]
		public MaterialBuilder WithClearCoatNormal(ImageBuilder imageFile)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA783C20", Offset = "0xA782C20", VA = "0x18A783C20")]
		public MaterialBuilder WithClearCoat(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA783B60", Offset = "0xA782B60", VA = "0x18A783B60")]
		public MaterialBuilder WithClearCoatRoughness(ImageBuilder imageFile, float roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA785400", Offset = "0xA784400", VA = "0x18A785400")]
		public MaterialBuilder WithTransmission(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA783DB0", Offset = "0xA782DB0", VA = "0x18A783DB0")]
		public MaterialBuilder WithDiffuseTransmissionFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA783CE0", Offset = "0xA782CE0", VA = "0x18A783CE0")]
		public MaterialBuilder WithDiffuseTransmissionColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA784F00", Offset = "0xA783F00", VA = "0x18A784F00")]
		public MaterialBuilder WithSpecularColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA784FD0", Offset = "0xA783FD0", VA = "0x18A784FD0")]
		public MaterialBuilder WithSpecularFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA785650", Offset = "0xA784650", VA = "0x18A785650")]
		public MaterialBuilder WithVolumeThickness(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA785500", Offset = "0xA784500", VA = "0x18A785500")]
		public MaterialBuilder WithVolumeAttenuation(Vector3 color, float distance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA784580", Offset = "0xA783580", VA = "0x18A784580")]
		public MaterialBuilder WithIridescence(ImageBuilder imageFile, float factor = 0f, float ior = 1.3f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA784430", Offset = "0xA783430", VA = "0x18A784430")]
		public MaterialBuilder WithIridescenceThickness(ImageBuilder imageFile, float min = 100f, float max = 400f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA783590", Offset = "0xA782590", VA = "0x18A783590")]
		public MaterialBuilder WithAnisotropy(ImageBuilder imageFile, float strength = 0f, float rotation = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA783E70", Offset = "0xA782E70", VA = "0x18A783E70")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA783F30", Offset = "0xA782F30", VA = "0x18A783F30")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA785270", Offset = "0xA784270", VA = "0x18A785270")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness([Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7850D0", Offset = "0xA7840D0", VA = "0x18A7850D0")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness(ImageBuilder imageFile, [Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA785870", Offset = "0xA784870", VA = "0x18A785870")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79CD70", Offset = "0xA79BD70", VA = "0x18A79CD70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public MaterialValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0xFFD960", Offset = "0xFFC960", VA = "0x180FFD960")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0xA79CE10", Offset = "0xA79BE10", VA = "0x18A79CE10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA79CB00", Offset = "0xA79BB00", VA = "0x18A79CB00")]
			internal _Property(KnownProperty key, float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA79CBC0", Offset = "0xA79BBC0", VA = "0x18A79CBC0")]
			internal _Property(KnownProperty key, Vector2 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA79CA30", Offset = "0xA79BA30", VA = "0x18A79CA30")]
			internal _Property(KnownProperty key, Vector3 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA79CC90", Offset = "0xA79BC90", VA = "0x18A79CC90")]
			internal _Property(KnownProperty key, Vector4 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA79C900", Offset = "0xA79B900", VA = "0x18A79C900", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA79C890", Offset = "0xA79B890", VA = "0x18A79C890", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA79C760", Offset = "0xA79B760", VA = "0x18A79C760", Slot = "4")]
			public bool Equals(_Property other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA79CDD0", Offset = "0xA79BDD0", VA = "0x18A79CDD0")]
			public static bool operator ==(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA79CDF0", Offset = "0xA79BDF0", VA = "0x18A79CDF0")]
			public static bool operator !=(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA79C760", Offset = "0xA79B760", VA = "0x18A79C760")]
			public static bool AreEqual(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA79C940", Offset = "0xA79B940", VA = "0x18A79C940")]
			public void SetDefault()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA79C950", Offset = "0xA79B950", VA = "0x18A79C950", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xA77FC50", Offset = "0xA77EC50", VA = "0x18A77FC50", Slot = "6")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0xA780640", Offset = "0xA77F640", VA = "0x18A780640")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public MaterialValue this[string keyName]
			{
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0xA77FAD0", Offset = "0xA77EAD0", VA = "0x18A77FAD0")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0xA780560", Offset = "0xA77F560", VA = "0x18A780560")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<KnownProperty> Keys
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0xA77FD40", Offset = "0xA77ED40", VA = "0x18A77FD40", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0xA77FE60", Offset = "0xA77EE60", VA = "0x18A77FE60", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x28396E0", Offset = "0x28386E0", VA = "0x1828396E0", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xA77F920", Offset = "0xA77E920", VA = "0x18A77F920")]
				get
				{
					return default(Vector4);
				}
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0xA77FF80", Offset = "0xA77EF80", VA = "0x18A77FF80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA77F7E0", Offset = "0xA77E7E0", VA = "0x18A77F7E0")]
			private string _GetDebuggerDisplay()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
			internal Collection(_Property[] properties)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA77F4B0", Offset = "0xA77E4B0", VA = "0x18A77F4B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA77ED40", Offset = "0xA77DD40", VA = "0x18A77ED40")]
			public static bool AreEqual(Collection x, Collection y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA77EFF0", Offset = "0xA77DFF0", VA = "0x18A77EFF0", Slot = "4")]
			public bool ContainsKey(KnownProperty key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA77F6B0", Offset = "0xA77E6B0", VA = "0x18A77F6B0", Slot = "5")]
			public bool TryGetValue(KnownProperty key, [Out] MaterialValue value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA77F370", Offset = "0xA77E370", VA = "0x18A77F370", Slot = "10")]
			public IEnumerator<KeyValuePair<KnownProperty, MaterialValue>> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA77F570", Offset = "0xA77E570", VA = "0x18A77F570", Slot = "11")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA77F520", Offset = "0xA77E520", VA = "0x18A77F520")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA77F0C0", Offset = "0xA77E0C0", VA = "0x18A77F0C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <_CreateDefaultProperties>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA7921D0", Offset = "0xA7911D0", VA = "0x18A7921D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA792CA0", Offset = "0xA791CA0", VA = "0x18A792CA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA792C00", Offset = "0xA791C00", VA = "0x18A792C00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<_Property> IEnumerable<_Property>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA792C00", Offset = "0xA791C00", VA = "0x18A792C00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA786D00", Offset = "0xA785D00", VA = "0x18A786D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7862D0", Offset = "0xA7852D0", VA = "0x18A7862D0")]
		internal static Collection CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA786C00", Offset = "0xA785C00", VA = "0x18A786C00")]
		[IteratorStateMachine(typeof(<_CreateDefaultProperties>d__1))]
		private static IEnumerable<_Property> _CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA787100", Offset = "0xA786100", VA = "0x18A787100")]
		public static implicit operator MaterialValue(float value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA787070", Offset = "0xA786070", VA = "0x18A787070")]
		public static implicit operator MaterialValue(Vector2 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7870A0", Offset = "0xA7860A0", VA = "0x18A7870A0")]
		public static implicit operator MaterialValue(Vector3 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7870D0", Offset = "0xA7860D0", VA = "0x18A7870D0")]
		public static implicit operator MaterialValue(Vector4 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7863E0", Offset = "0xA7853E0", VA = "0x18A7863E0")]
		public static MaterialValue CreateFrom(object value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA786CE0", Offset = "0xA785CE0", VA = "0x18A786CE0")]
		private MaterialValue(float x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA786CC0", Offset = "0xA785CC0", VA = "0x18A786CC0")]
		private MaterialValue(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA786C70", Offset = "0xA785C70", VA = "0x18A786C70")]
		private MaterialValue(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA786C90", Offset = "0xA785C90", VA = "0x18A786C90")]
		private MaterialValue(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7867C0", Offset = "0xA7857C0", VA = "0x18A7867C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7866C0", Offset = "0xA7856C0", VA = "0x18A7866C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA786270", Offset = "0xA785270", VA = "0x18A786270", Slot = "4")]
		public bool Equals(MaterialValue other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA786270", Offset = "0xA785270", VA = "0x18A786270")]
		public static bool operator ==([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA787120", Offset = "0xA786120", VA = "0x18A787120")]
		public static bool operator !=([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA786270", Offset = "0xA785270", VA = "0x18A786270")]
		public static bool AreEqual([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA786E90", Offset = "0xA785E90", VA = "0x18A786E90")]
		public static explicit operator float(MaterialValue value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA786FF0", Offset = "0xA785FF0", VA = "0x18A786FF0")]
		public static explicit operator Vector2(MaterialValue value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA786F70", Offset = "0xA785F70", VA = "0x18A786F70")]
		public static explicit operator Vector3(MaterialValue value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA786EF0", Offset = "0xA785EF0", VA = "0x18A786EF0")]
		public static explicit operator Vector4(MaterialValue value)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA7868B0", Offset = "0xA7858B0", VA = "0x18A7868B0")]
		public object ToTypeless()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA786870", Offset = "0xA785870", VA = "0x18A786870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA786B90", Offset = "0xA785B90", VA = "0x18A786B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79B790", Offset = "0xA79A790", VA = "0x18A79B790", Slot = "4")]
			public bool Equals(TextureBuilder x, TextureBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA79B820", Offset = "0xA79A820", VA = "0x18A79B820", Slot = "5")]
			public int GetHashCode(TextureBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12FF0", Offset = "0xD11FF0", VA = "0x180D12FF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD675F0", Offset = "0xD665F0", VA = "0x180D675F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000")]
			[CompilerGenerated]
			get
			{
				return default(TextureMipMapFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xD675E0", Offset = "0xD665E0", VA = "0x180D675E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD6D840", Offset = "0xD6C840", VA = "0x180D6D840")]
			[CompilerGenerated]
			get
			{
				return default(TextureInterpolationFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xD6F040", Offset = "0xD6E040", VA = "0x180D6F040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x167EE10", Offset = "0x167DE10", VA = "0x18167EE10")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1C79BF0", Offset = "0x1C78BF0", VA = "0x181C79BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xED7420", Offset = "0xED6420", VA = "0x180ED7420")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1AABF50", Offset = "0x1AAAF50", VA = "0x181AABF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ImageBuilder PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA78E880", Offset = "0xA78D880", VA = "0x18A78E880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ImageBuilder FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA78E760", Offset = "0xA78D760", VA = "0x18A78E760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public TextureTransformBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static IEqualityComparer<TextureBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA78E710", Offset = "0xA78D710", VA = "0x18A78E710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E370", Offset = "0xA78D370", VA = "0x18A78E370")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA78E630", Offset = "0xA78D630", VA = "0x18A78E630")]
		internal TextureBuilder(ChannelBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA78D880", Offset = "0xA78C880", VA = "0x18A78D880")]
		public static bool AreEqualByContent(TextureBuilder x, TextureBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA78DD50", Offset = "0xA78CD50", VA = "0x18A78DD50")]
		public static int GetContentHashCode(TextureBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA78DB00", Offset = "0xA78CB00", VA = "0x18A78DB00")]
		internal void CopyTo(TextureBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA78DF00", Offset = "0xA78CF00", VA = "0x18A78DF00")]
		public TextureBuilder WithCoordinateSet(int cset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA78E030", Offset = "0xA78D030", VA = "0x18A78E030")]
		public TextureBuilder WithPrimaryImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA78DF10", Offset = "0xA78CF10", VA = "0x18A78DF10")]
		public TextureBuilder WithFallbackImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA78E120", Offset = "0xA78D120", VA = "0x18A78E120")]
		public TextureBuilder WithSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA78E140", Offset = "0xA78D140", VA = "0x18A78E140")]
		public TextureBuilder WithTransform(float offsetX, float offsetY, float scaleX = 1f, float scaleY = 1f, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA78E280", Offset = "0xA78D280", VA = "0x18A78E280")]
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
			[Cpp2IlInjected.Address(RVA = "0x32AF310", Offset = "0x32AE310", VA = "0x1832AF310")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xE8FE60", Offset = "0xE8EE60", VA = "0x180E8FE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E8A360", Offset = "0x1E89360", VA = "0x181E8A360")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD46190", Offset = "0xD45190", VA = "0x180D46190")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x10BE130", Offset = "0x10BD130", VA = "0x1810BE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int? CoordinateSetOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x13FFBD0", Offset = "0x13FEBD0", VA = "0x1813FFBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x10BE0D0", Offset = "0x10BD0D0", VA = "0x1810BE0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA78EB60", Offset = "0xA78DB60", VA = "0x18A78EB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA78EAD0", Offset = "0xA78DAD0", VA = "0x18A78EAD0")]
		internal TextureTransformBuilder(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E9E0", Offset = "0xA78D9E0", VA = "0x18A78E9E0")]
		internal TextureTransformBuilder(TextureTransformBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA78E890", Offset = "0xA78D890", VA = "0x18A78E890")]
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
			[Cpp2IlInjected.Address(RVA = "0xA787380", Offset = "0xA786380", VA = "0x18A787380", Slot = "2")]
			public override readonly int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA7872D0", Offset = "0xA7862D0", VA = "0x18A7872D0", Slot = "0")]
			public override readonly bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA787180", Offset = "0xA786180", VA = "0x18A787180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA796850", Offset = "0xA795850", VA = "0x18A796850")]
		public void AddTriangle(Material material, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> a, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> b, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA797010", Offset = "0xA796010", VA = "0x18A797010")]
		public void WriteFiles(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA796990", Offset = "0xA795990", VA = "0x18A796990")]
		public IReadOnlyDictionary<string, ArraySegment<byte>> GetFiles(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA7972E0", Offset = "0xA7962E0", VA = "0x18A7972E0")]
		private Dictionary<string, Action<Stream>> _GetFileGenerators(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA7976C0", Offset = "0xA7966C0", VA = "0x18A7976C0")]
		private static Dictionary<Material, string> _GetMaterialsFileGenerator(IDictionary<string, Action<Stream>> fileGenerators, string baseName, IEnumerable<Material> materials)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA7996F0", Offset = "0xA7986F0", VA = "0x18A7996F0")]
		private static void _WriteMaterialsFile(Stream fs, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA799840", Offset = "0xA798840", VA = "0x18A799840")]
		private static void _WriteMaterialsFile(StreamWriter sw, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA7980C0", Offset = "0xA7970C0", VA = "0x18A7980C0")]
		private void _WriteGeometryFile(Stream s, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA7981F0", Offset = "0xA7971F0", VA = "0x18A7981F0")]
		private void _WriteGeometryFile(StreamWriter sw, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA796200", Offset = "0xA795200", VA = "0x18A796200")]
		public void AddModel(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA796510", Offset = "0xA795510", VA = "0x18A796510")]
		public void AddModel(ModelRoot model, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA796DD0", Offset = "0xA795DD0", VA = "0x18A796DD0")]
		private static Material GetMaterialFromTriangle(SharpGLTF.Schema2.Material srcMaterial)
		{
			return default(Material);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA79A320", Offset = "0xA799320", VA = "0x18A79A320")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79B180", Offset = "0xA79A180", VA = "0x18A79B180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA79A3D0", Offset = "0xA7993D0", VA = "0x18A79A3D0")]
		public static ModelRoot LoadModelFromZip(string zipPath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA79B110", Offset = "0xA79A110", VA = "0x18A79B110")]
		public ZipReader(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA79B040", Offset = "0xA79A040", VA = "0x18A79B040")]
		public ZipReader(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA79A3A0", Offset = "0xA7993A0", VA = "0x18A79A3A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA90", Offset = "0xA799A90", VA = "0x18A79AA90")]
		private IEnumerable<ZipArchiveEntry> _GetEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA79A760", Offset = "0xA799760", VA = "0x18A79A760")]
		public ModelRoot LoadModel([Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA79A6A0", Offset = "0xA7996A0", VA = "0x18A79A6A0")]
		public ModelRoot LoadModel(string gltfFile, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA79ACA0", Offset = "0xA799CA0", VA = "0x18A79ACA0")]
		private ArraySegment<byte> _ReadAsset(string rawUri)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA79A950", Offset = "0xA799950", VA = "0x18A79A950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA79B6C0", Offset = "0xA79A6C0", VA = "0x18A79B6C0")]
		public ZipWriter(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA79B5F0", Offset = "0xA79A5F0", VA = "0x18A79B5F0")]
		public ZipWriter(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA79A3A0", Offset = "0xA7993A0", VA = "0x18A79A3A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA79B2A0", Offset = "0xA79A2A0", VA = "0x18A79B2A0")]
		public void AddModel(string filePath, ModelRoot model, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA79B4A0", Offset = "0xA79A4A0", VA = "0x18A79B4A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x70CE0B0", Offset = "0x70CD0B0", VA = "0x1870CE0B0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public VertexPreprocessor<TvG, TvM, TvS> VertexPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x70CE2C0", Offset = "0x70CD2C0", VA = "0x1870CE2C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyCollection<PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x70C7400", Offset = "0x70C6400", VA = "0x1870C7400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> IMeshBuilder<TMaterial>.Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x70C7400", Offset = "0x70C6400", VA = "0x1870C7400", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x70CDA70", Offset = "0x70CCA70", VA = "0x1870CDA70")]
		public MeshBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x70CD540", Offset = "0x70CC540", VA = "0x1870CD540")]
		public MeshBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x70C7580", Offset = "0x70C6580", VA = "0x1870C7580", Slot = "19")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x70C6280", Offset = "0x70C5280", VA = "0x1870C6280", Slot = "17")]
		IMeshBuilder<TMaterial> IMeshBuilder<TMaterial>.Clone(Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x70C6280", Offset = "0x70C5280", VA = "0x1870C6280")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x70CDA90", Offset = "0x70CCA90", VA = "0x1870CDA90")]
		private MeshBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> other, [Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x70C89C0", Offset = "0x70C79C0", VA = "0x1870C89C0")]
		public MorphTargetBuilder<TMaterial, TvG, TvS, TvM> UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x70C6720", Offset = "0x70C5720", VA = "0x1870C6720", Slot = "16")]
		IMorphTargetBuilder IMeshBuilder<TMaterial>.UseMorphTarget(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x70CA8F0", Offset = "0x70C98F0", VA = "0x1870CA8F0")]
		private PrimitiveBuilder<TMaterial, TvG, TvM, TvS> _UsePrimitive((TMaterial Material, int PrimType) key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x70C9070", Offset = "0x70C8070", VA = "0x1870C9070")]
		public PrimitiveBuilder<TMaterial, TvG, TvM, TvS> UsePrimitive(TMaterial material, int primitiveVertexCount = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x70C6E80", Offset = "0x70C5E80", VA = "0x1870C6E80", Slot = "15")]
		IPrimitiveBuilder IMeshBuilder<TMaterial>.UsePrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x70C3200", Offset = "0x70C2200", VA = "0x1870C3200")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, Matrix4x4 vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x70C46D0", Offset = "0x70C36D0", VA = "0x1870C46D0")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, [Optional] Func<TMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39E5FD0", Offset = "0x39E4FD0", VA = "0x1839E5FD0")]
		public void AddMesh<TSourceMaterial>(IMeshBuilder<TSourceMaterial> mesh, Func<TSourceMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x70C77B0", Offset = "0x70C67B0", VA = "0x1870C77B0")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x70CA150", Offset = "0x70C9150", VA = "0x1870CA150", Slot = "18")]
		public void Validate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MeshBuilder<TvG, TvM, TvS> : MeshBuilder<MaterialBuilder, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x70C2D80", Offset = "0x70C1D80", VA = "0x1870C2D80")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MeshBuilder<TvG, TvM> : MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x62BC780", Offset = "0x62BB780", VA = "0x1862BC780")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MeshBuilder<TvG> : MeshBuilder<MaterialBuilder, TvG, VertexEmpty, VertexEmpty> where TvG : struct, IVertexGeometry
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x62BC780", Offset = "0x62BB780", VA = "0x1862BC780")]
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
		[Cpp2IlInjected.Address(RVA = "0xA787450", Offset = "0xA786450", VA = "0x18A787450")]
		public static VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>[] GetMorphTargetVertices(this IPrimitiveMorphTargetReader morphTarget, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D13D30", Offset = "0x3D12D30", VA = "0x183D13D30")]
		public static EncodingType GetOptimalIndexEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D14920", Offset = "0x3D13920", VA = "0x183D14920")]
		public static EncodingType GetOptimalJointEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D13690", Offset = "0x3D12690", VA = "0x183D13690")]
		public static IMeshBuilder<TMaterial> CreateMeshBuilderFromVertexAttributes<TMaterial>(params string[] vertexAttributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D12A40", Offset = "0x3D11A40", VA = "0x183D12A40")]
		public static IReadOnlyDictionary<Vector3, Vector3> CalculateSmoothNormals<TMaterial>(this IMeshBuilder<TMaterial> srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D14F10", Offset = "0x3D13F10", VA = "0x183D14F10")]
		public static bool IsEmpty<TMaterial>(this IPrimitiveReader<TMaterial> primitive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D152A0", Offset = "0x3D142A0", VA = "0x183D152A0")]
		public static bool IsEmpty<TMaterial>(this IMeshBuilder<TMaterial> mesh)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7875E0", Offset = "0xA7865E0", VA = "0x18A7875E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76F5A90", Offset = "0x76F4A90", VA = "0x1876F5A90")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x76F6150", Offset = "0x76F5150", VA = "0x1876F6150")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc, PrimitiveMorphTargetBuilder<TvG, TvM> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x76C7E10", Offset = "0x76C6E10", VA = "0x1876C7E10", Slot = "4")]
		public IReadOnlyCollection<int> GetTargetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x76CCAB0", Offset = "0x76CBAB0", VA = "0x1876CCAB0", Slot = "6")]
		public VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex)
		{
			return default(VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x76E0EE0", Offset = "0x76DFEE0", VA = "0x1876E0EE0")]
		public void SetVertexDelta(int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E8F50", Offset = "0x76E7F50", VA = "0x1876E8F50", Slot = "5")]
		IVertexBuilder IPrimitiveMorphTargetReader.GetVertex(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x76CFD20", Offset = "0x76CED20", VA = "0x1876CFD20")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex(int vertexIndex)
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E50B0", Offset = "0x76E40B0", VA = "0x1876E50B0")]
		public void SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x76F4EF0", Offset = "0x76F3EF0", VA = "0x1876F4EF0")]
		private void _SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x76F49C0", Offset = "0x76F39C0", VA = "0x1876F49C0")]
		private void _RemoveVertex(int vertexIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x76F3CE0", Offset = "0x76F2CE0", VA = "0x1876F3CE0")]
		internal void TransformVertices(Func<VertexBuilder<TvG, TvM, VertexEmpty>, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x76D1B70", Offset = "0x76D0B70", VA = "0x1876D1B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x719F7D0", Offset = "0x719E7D0", VA = "0x18719F7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x719F7A0", Offset = "0x719E7A0", VA = "0x18719F7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		IReadOnlyCollection<IVertexGeometry> IMorphTargetBuilder.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x719C270", Offset = "0x719B270", VA = "0x18719C270", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x719F120", Offset = "0x719E120", VA = "0x18719F120")]
		internal MorphTargetBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x718F970", Offset = "0x718E970", VA = "0x18718F970")]
		public IReadOnlyList<TvG> GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7191830", Offset = "0x7190830", VA = "0x187191830")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7190B90", Offset = "0x718FB90", VA = "0x187190B90")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x71972F0", Offset = "0x71962F0", VA = "0x1871972F0")]
		public void SetVertex(TvG meshVertex, VertexBuilder<TvG, TvM, VertexEmpty> morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x71949F0", Offset = "0x71939F0", VA = "0x1871949F0")]
		public void SetVertex(TvG meshVertex, TvG morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7197E90", Offset = "0x7196E90", VA = "0x187197E90", Slot = "6")]
		IReadOnlyList<IVertexGeometry> IMorphTargetBuilder.GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x719AFF0", Offset = "0x7199FF0", VA = "0x18719AFF0", Slot = "7")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x719A590", Offset = "0x7199590", VA = "0x18719A590", Slot = "8")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x719A270", Offset = "0x7199270", VA = "0x18719A270", Slot = "9")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x7198FA0", Offset = "0x7197FA0", VA = "0x187198FA0", Slot = "10")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7191AD0", Offset = "0x7190AD0", VA = "0x187191AD0", Slot = "11")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7192CD0", Offset = "0x7191CD0", VA = "0x187192CD0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA788430", Offset = "0xA787430", VA = "0x18A788430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA787AC0", Offset = "0xA786AC0", VA = "0x18A787AC0")]
		public void AddAccessors(params MemoryAccessor[] accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA787C90", Offset = "0xA786C90", VA = "0x18A787C90")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA7883B0", Offset = "0xA7873B0", VA = "0x18A7883B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D7C8A0", Offset = "0x3D7B8A0", VA = "0x183D7C8A0")]
		public void AdjustJointEncoding<TVertex>(IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <CreatePackedMeshes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x6551B50", Offset = "0x6550B50", VA = "0x186551B50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x6551060", Offset = "0x6550060", VA = "0x186551060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x6551CA0", Offset = "0x6550CA0", VA = "0x186551CA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x65517F0", Offset = "0x65507F0", VA = "0x1865517F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<PackedMeshBuilder<TMaterial>> IEnumerable<PackedMeshBuilder<TMaterial>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x65519A0", Offset = "0x65509A0", VA = "0x1865519A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7547AF0", Offset = "0x7546AF0", VA = "0x187547AF0")]
		[IteratorStateMachine(typeof(PackedMeshBuilder<>.<CreatePackedMeshes>d__0))]
		internal static IEnumerable<PackedMeshBuilder<TMaterial>> CreatePackedMeshes(IEnumerable<IMeshBuilder<TMaterial>> meshBuilders, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7549100", Offset = "0x7548100", VA = "0x187549100")]
		private static PackedMeshBuilder<TMaterial> Create(IMeshBuilder<TMaterial> srcMesh, PackedEncoding vertexEncodings, EncodingType indexEncoding, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x754A470", Offset = "0x7549470", VA = "0x18754A470")]
		private PackedMeshBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x75476B0", Offset = "0x75466B0", VA = "0x1875476B0")]
		public PackedPrimitiveBuilder<TMaterial> AddPrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7547BC0", Offset = "0x7546BC0", VA = "0x187547BC0")]
		public Mesh CreateSchema2Mesh(ModelRoot root, Converter<TMaterial, Material> materialEvaluator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x754A1C0", Offset = "0x75491C0", VA = "0x18754A1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7552950", Offset = "0x7551950", VA = "0x187552950")]
		public PackedPrimitiveBuilder(TMaterial material, int primitiveVertexCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7550740", Offset = "0x754F740", VA = "0x187550740")]
		public void SetStridedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x754FC30", Offset = "0x754EC30", VA = "0x18754FC30")]
		public void SetStreamedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x754CC20", Offset = "0x754BC20", VA = "0x18754CC20")]
		public void SetIndices(IPrimitiveReader<TMaterial> srcPrim, EncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x754E290", Offset = "0x754D290", VA = "0x18754E290")]
		public void SetMorphTargets(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncodings, ISet<string> morphTargetAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x754A9D0", Offset = "0x75499D0", VA = "0x18754A9D0")]
		private void AddMorphTarget(params MemoryAccessor[] morphTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x754B420", Offset = "0x754A420", VA = "0x18754B420")]
		internal void CopyToMesh(Mesh dstMesh, Converter<TMaterial, Material> materialEvaluator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x754ADB0", Offset = "0x7549DB0", VA = "0x18754ADB0")]
		private void CopyMorphTargets(MeshPrimitive dstPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x754C1A0", Offset = "0x754B1A0", VA = "0x18754C1A0")]
		public static void MergeBuffers(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7551780", Offset = "0x7550780", VA = "0x187551780")]
		private static void _MergeSequentialVertices(IEnumerable<MemoryAccessor[]> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7552370", Offset = "0x7551370", VA = "0x187552370")]
		private static void _MergeStridedVertices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7550D00", Offset = "0x754FD00", VA = "0x187550D00")]
		private static void _MergeIndices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal static class _PackedPrimitiveHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x413DD90", Offset = "0x413CD90", VA = "0x18413DD90")]
		public static void _GatherMorphTargetAttributes<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, HashSet<string> attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x413E5D0", Offset = "0x413D5D0", VA = "0x18413E5D0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x6E02890", Offset = "0x6E01890", VA = "0x186E02890", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x6DFF3C0", Offset = "0x6DFE3C0", VA = "0x186DFF3C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x6E03440", Offset = "0x6E02440", VA = "0x186E03440")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			IVertexBuilder IReadOnlyList<IVertexBuilder>.this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600057C")]
				[Cpp2IlInjected.Address(RVA = "0x86C3D10", Offset = "0x86C2D10", VA = "0x1886C3D10", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x86C3710", Offset = "0x86C2710", VA = "0x1886C3710", Slot = "10")]
			[IteratorStateMachine(typeof(PrimitiveBuilder<, , , >.VertexListWrapper.<System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2))]
			IEnumerator<IVertexBuilder> IEnumerable<IVertexBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x86C5730", Offset = "0x86C4730", VA = "0x1886C5730")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x75BBBF0", Offset = "0x75BABF0", VA = "0x1875BBBF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x75BA0F0", Offset = "0x75B90F0", VA = "0x1875BA0F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<VertexBuilder<TvG, TvM, TvS>> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		IReadOnlyList<IVertexBuilder> IPrimitiveReader<TMaterial>.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		IReadOnlyList<IPrimitiveMorphTargetReader> IPrimitiveReader<TMaterial>.MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public virtual IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x75B94F0", Offset = "0x75B84F0", VA = "0x1875B94F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public virtual IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x75B92B0", Offset = "0x75B82B0", VA = "0x1875B92B0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public virtual IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x75B9BB0", Offset = "0x75B8BB0", VA = "0x1875B9BB0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public virtual IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x75B9820", Offset = "0x75B8820", VA = "0x1875B9820", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		internal IReadOnlyList<PrimitiveMorphTargetBuilder<TvG, TvM>> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x75B6540", Offset = "0x75B5540", VA = "0x1875B6540")]
		internal PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x75B86B0", Offset = "0x75B76B0", VA = "0x1875B86B0")]
		protected PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		internal abstract PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x75B2550", Offset = "0x75B1550", VA = "0x1875B2550")]
		internal PrimitiveMorphTargetBuilder<TvG, TvM> _UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x75B15B0", Offset = "0x75B05B0", VA = "0x1875B15B0")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x75A6BD0", Offset = "0x75A5BD0", VA = "0x1875A6BD0")]
		private static VertexBuilder<TvG, TvM, TvS> ConvertVertex(IVertexBuilder vertex)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x75ACB60", Offset = "0x75ABB60", VA = "0x1875ACB60")]
		protected int UseVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x75A76F0", Offset = "0x75A66F0", VA = "0x1875A76F0", Slot = "6")]
		void IPrimitiveBuilder.SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x75A6880", Offset = "0x75A5880", VA = "0x1875A6880")]
		public bool ContainsVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x759A970", Offset = "0x7599970", VA = "0x18759A970", Slot = "7")]
		public int AddPoint(IVertexBuilder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7596E40", Offset = "0x7595E40", VA = "0x187596E40", Slot = "8")]
		public (int, int) AddLine(IVertexBuilder a, IVertexBuilder b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x75A4570", Offset = "0x75A3570", VA = "0x1875A4570", Slot = "9")]
		public (int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x759FEF0", Offset = "0x759EEF0", VA = "0x18759FEF0", Slot = "10")]
		public (int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x759D580", Offset = "0x759C580", VA = "0x18759D580")]
		internal void AddPrimitive(PrimitiveBuilder<TMaterial, TvG, TvM, TvS> primitive, Converter<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3A102E0", Offset = "0x3A0F2E0", VA = "0x183A102E0")]
		internal void AddPrimitive<TAnyMaterial>(IPrimitiveReader<TAnyMaterial> primitive, Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x75A82C0", Offset = "0x75A72C0", VA = "0x1875A82C0")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract IReadOnlyList<int> GetIndices();

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x7599230", Offset = "0x7598230", VA = "0x187599230", Slot = "28")]
		public virtual int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7596B90", Offset = "0x7595B90", VA = "0x187596B90", Slot = "29")]
		public virtual (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x75A2970", Offset = "0x75A1970", VA = "0x1875A2970", Slot = "30")]
		public virtual (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x759DDC0", Offset = "0x759CDC0", VA = "0x18759DDC0", Slot = "31")]
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
				[Cpp2IlInjected.Address(RVA = "0xD5A6D0", Offset = "0xD596D0", VA = "0x180D5A6D0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x757BA00", Offset = "0x757AA00", VA = "0x18757BA00", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			public PointListWrapper(IReadOnlyList<T> vertices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x7572580", Offset = "0x7571580", VA = "0x187572580", Slot = "6")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x757B060", Offset = "0x757A060", VA = "0x18757B060", Slot = "7")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x758F430", Offset = "0x758E430", VA = "0x18758F430", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x758ED50", Offset = "0x758DD50", VA = "0x18758ED50")]
		internal PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x758A960", Offset = "0x7589960", VA = "0x18758A960", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x758E750", Offset = "0x758D750", VA = "0x18758E750")]
		private PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x75815C0", Offset = "0x75805C0", VA = "0x1875815C0", Slot = "28")]
		public override int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x758C0A0", Offset = "0x758B0A0", VA = "0x18758C0A0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x69D79C0", Offset = "0x69D69C0", VA = "0x1869D79C0")]
		internal LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x69C51F0", Offset = "0x69C41F0", VA = "0x1869C51F0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x69DBDD0", Offset = "0x69DADD0", VA = "0x1869DBDD0")]
		private LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x69BEAB0", Offset = "0x69BDAB0", VA = "0x1869BEAB0", Slot = "29")]
		public override (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x69CE200", Offset = "0x69CD200", VA = "0x1869CE200", Slot = "27")]
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
					[Cpp2IlInjected.Address(RVA = "0x1A04590", Offset = "0x1A03590", VA = "0x181A04590", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x6720BA0", Offset = "0x671FBA0", VA = "0x186720BA0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x671EA00", Offset = "0x671DA00", VA = "0x18671EA00", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6F47C20", Offset = "0x6F46C20", VA = "0x186F47C20", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7DD2460", Offset = "0x7DD1460", VA = "0x187DD2460", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public (int A, int B, int C) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x7DD4120", Offset = "0x7DD3120", VA = "0x187DD4120", Slot = "4")]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public TriangleList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x7DD2230", Offset = "0x7DD1230", VA = "0x187DD2230", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x7C28B40", Offset = "0x7C27B40", VA = "0x187C28B40", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x23C91F0", Offset = "0x23C81F0", VA = "0x1823C91F0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x6720CE0", Offset = "0x671FCE0", VA = "0x186720CE0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x671D2F0", Offset = "0x671C2F0", VA = "0x18671D2F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x6F4BD80", Offset = "0x6F4AD80", VA = "0x186F4BD80", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C298F0", Offset = "0x7C288F0", VA = "0x187C298F0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public (int A, int B, int C, int? D) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x7C3CAC0", Offset = "0x7C3BAC0", VA = "0x187C3CAC0", Slot = "4")]
				get
				{
					return default((int, int, int, int?));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public SurfaceList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x7C28A90", Offset = "0x7C27A90", VA = "0x187C28A90", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int, int?)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7C28B40", Offset = "0x7C27B40", VA = "0x187C28B40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public override IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7DF0F60", Offset = "0x7DEFF60", VA = "0x187DF0F60", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7DF0F00", Offset = "0x7DEFF00", VA = "0x187DF0F00", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0480", Offset = "0x7DEF480", VA = "0x187DF0480")]
		internal TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DEE070", Offset = "0x7DED070", VA = "0x187DEE070", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF0940", Offset = "0x7DEF940", VA = "0x187DF0940")]
		private TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DED0D0", Offset = "0x7DEC0D0", VA = "0x187DED0D0", Slot = "30")]
		public override (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC740", Offset = "0x7DEB740", VA = "0x187DEC740", Slot = "31")]
		public override (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEF790", Offset = "0x7DEE790", VA = "0x187DEF790")]
		private (int, int, int) _AddTriangle([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b, [In] VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DEEC50", Offset = "0x7DEDC50", VA = "0x187DEEC50", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x71856C0", Offset = "0x71846C0", VA = "0x1871856C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7184480", Offset = "0x7183480", VA = "0x187184480")]
		public static IReadOnlyDictionary<IPrimitiveReader<TMaterial>, MeshPrimitiveNormalsAndTangents<TMaterial>> GenerateNormalsTangents(IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		private MeshPrimitiveNormalsAndTangents(IPrimitiveReader<TMaterial> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7184E40", Offset = "0x7183E40", VA = "0x187184E40", Slot = "13")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7185060", Offset = "0x7184060", VA = "0x187185060", Slot = "9")]
		public Vector3 GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7184E90", Offset = "0x7183E90", VA = "0x187184E90", Slot = "10")]
		public Vector3 GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x71851D0", Offset = "0x71841D0", VA = "0x1871851D0")]
		public Vector4 GetVertexTangent(int idx)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7185380", Offset = "0x7184380", VA = "0x187185380", Slot = "11")]
		public Vector2 GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7185510", Offset = "0x7184510", VA = "0x187185510", Slot = "6")]
		public void SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x71855F0", Offset = "0x71845F0", VA = "0x1871855F0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BD930", Offset = "0xA7BC930", VA = "0x18A7BD930", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public _NormalTangentAgent(VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "13")]
			public IEnumerable<(int, int, int)> GetTriangleIndices()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD540", Offset = "0xA7BC540", VA = "0x18A7BD540", Slot = "9")]
			public Vector3 GetVertexPosition(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD450", Offset = "0xA7BC450", VA = "0x18A7BD450", Slot = "10")]
			public Vector3 GetVertexNormal(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD630", Offset = "0xA7BC630", VA = "0x18A7BD630", Slot = "11")]
			public Vector2 GetVertexTexCoord(int idx)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD690", Offset = "0xA7BC690", VA = "0x18A7BD690", Slot = "6")]
			public void SetVertexNormal(int idx, Vector3 normal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD7E0", Offset = "0xA7BC7E0", VA = "0x18A7BD7E0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IList<Vector3> Normals
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IList<Vector4> Tangents
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public IList<Vector4> Colors0
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public IList<Vector4> Colors1
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IList<Vector2> TexCoords0
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public IList<Vector2> TexCoords1
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public IList<Vector2> TexCoords2
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public IList<Vector2> TexCoords3
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public IList<Vector4> Joints0
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public IList<Vector4> Joints1
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B70", Offset = "0xCF6B70", VA = "0x180CF7B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IList<Vector4> Weights0
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B80", Offset = "0xCF6B80", VA = "0x180CF7B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public IList<Vector4> Weights1
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BA0", Offset = "0xCF6BA0", VA = "0x180CF7BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public IReadOnlyList<VertexBufferColumns> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xA796160", Offset = "0xA795160", VA = "0x18A796160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public VertexBufferColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA795FB0", Offset = "0xA794FB0", VA = "0x18A795FB0")]
		public VertexBufferColumns(VertexBufferColumns other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x40A4B20", Offset = "0x40A3B20", VA = "0x1840A4B20")]
		private static T[] _IsolateColumn<T>(IList<T> column)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA793460", Offset = "0xA792460", VA = "0x18A793460")]
		public void IsolateColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA793730", Offset = "0xA792730", VA = "0x18A793730")]
		public VertexBufferColumns WithTransform(IGeometryTransform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA793830", Offset = "0xA792830", VA = "0x18A793830")]
		private void _ApplyTransform(IGeometryTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA795BD0", Offset = "0xA794BD0", VA = "0x18A795BD0")]
		private void _FillMorphData(Vector2[] array, Converter<VertexBufferColumns, Vector2> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA795DF0", Offset = "0xA794DF0", VA = "0x18A795DF0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector3> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA795CB0", Offset = "0xA794CB0", VA = "0x18A795CB0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA795ED0", Offset = "0xA794ED0", VA = "0x18A795ED0")]
		private void _FillMorphData(Vector4[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA792CE0", Offset = "0xA791CE0", VA = "0x18A792CE0")]
		public VertexBufferColumns AddMorphTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA793170", Offset = "0xA792170", VA = "0x18A793170")]
		public (Type, Func<IVertexBuilder>) GetCompatibleVertexType()
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x40A2570", Offset = "0x40A1570", VA = "0x1840A2570")]
		private TvG GetVertexGeometry<TvG>(int index) where TvG : struct, IVertexGeometry
		{
			return (TvG)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x40A31A0", Offset = "0x40A21A0", VA = "0x1840A31A0")]
		private TvM GetVertexMaterial<TvM>(int index) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40A3F00", Offset = "0x40A2F00", VA = "0x1840A3F00")]
		private TvS GetVertexSkinning<TvS>(int index) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA7932A0", Offset = "0xA7922A0", VA = "0x18A7932A0")]
		public IVertexBuilder GetVertex(Func<IVertexBuilder> factory, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x40A4730", Offset = "0x40A3730", VA = "0x1840A4730")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex<TvG, TvM>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x40A4940", Offset = "0x40A3940", VA = "0x1840A4940")]
		public VertexBuilder<TvG, TvM, TvS> GetVertex<TvG, TvM, TvS>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA792E10", Offset = "0xA791E10", VA = "0x18A792E10")]
		public static void CalculateSmoothNormals(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA792FC0", Offset = "0xA791FC0", VA = "0x18A792FC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85A24A0", Offset = "0x85A14A0", VA = "0x1885A24A0")]
			readonly get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x85A3E70", Offset = "0x85A2E70", VA = "0x1885A3E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x859EF50", Offset = "0x859DF50", VA = "0x18859EF50")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x859E650", Offset = "0x859D650", VA = "0x18859E650")]
		private static string _GetDebuggerDisplayTextFrom(object o)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x859CFB0", Offset = "0x859BFB0", VA = "0x18859CFB0")]
		private readonly string _GetDebugWarnings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x85A1DF0", Offset = "0x85A0DF0", VA = "0x1885A1DF0")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x85A1C90", Offset = "0x85A0C90", VA = "0x1885A1C90")]
		public VertexBuilder([In] TvG g, [In] TvM m, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x85A1810", Offset = "0x85A0810", VA = "0x1885A1810")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x85A2310", Offset = "0x85A1310", VA = "0x1885A2310")]
		public VertexBuilder([In] TvG g, [In] TvM m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x85A2020", Offset = "0x85A1020", VA = "0x1885A2020")]
		public VertexBuilder([In] TvG g, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x85A0B30", Offset = "0x859FB30", VA = "0x1885A0B30")]
		public VertexBuilder([In] TvG g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x85A19A0", Offset = "0x85A09A0", VA = "0x1885A19A0")]
		public VertexBuilder([In] TvG g, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x85A12D0", Offset = "0x85A02D0", VA = "0x1885A12D0")]
		public VertexBuilder(TvG g, SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x85A32C0", Offset = "0x85A22C0", VA = "0x1885A32C0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x85A2B20", Offset = "0x85A1B20", VA = "0x1885A2B20")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x85A36D0", Offset = "0x85A26D0", VA = "0x1885A36D0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x85A31E0", Offset = "0x85A21E0", VA = "0x1885A31E0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] TvG g)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x858E520", Offset = "0x858D520", VA = "0x18858E520")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x858E6C0", Offset = "0x858D6C0", VA = "0x18858E6C0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x858E320", Offset = "0x858D320", VA = "0x18858E320")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x858C170", Offset = "0x858B170", VA = "0x18858C170")]
		public static VertexBuilder<TvG, TvM, TvS> CreateFrom(IVertexBuilder src)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x858FF00", Offset = "0x858EF00", VA = "0x18858FF00", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x858FCC0", Offset = "0x858ECC0", VA = "0x18858FCC0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x858FEB0", Offset = "0x858EEB0", VA = "0x18858FEB0", Slot = "11")]
		public readonly bool Equals(VertexBuilder<TvG, TvM, TvS> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x85A2580", Offset = "0x85A1580", VA = "0x1885A2580")]
		public static bool operator ==([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x85A3E20", Offset = "0x85A2E20", VA = "0x1885A3E20")]
		public static bool operator !=([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x858AD90", Offset = "0x8589D90", VA = "0x18858AD90")]
		public static bool AreEqual([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8592F50", Offset = "0x8591F50", VA = "0x188592F50")]
		public readonly void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3848FA0", Offset = "0x3847FA0", VA = "0x183848FA0")]
		public static MeshBuilder<TMaterial, TvG, TvM, TvS> CreateCompatibleMesh<TMaterial>([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x858B600", Offset = "0x858A600", VA = "0x18858B600")]
		public static MeshBuilder<TvG, TvM, TvS> CreateCompatibleMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x41752C0", Offset = "0x41742C0", VA = "0x1841752C0", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x858FFF0", Offset = "0x858EFF0", VA = "0x18858FFF0", Slot = "4")]
		readonly IVertexGeometry IVertexBuilder.GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x85900D0", Offset = "0x858F0D0", VA = "0x1885900D0", Slot = "5")]
		readonly IVertexMaterial IVertexBuilder.GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8590260", Offset = "0x858F260", VA = "0x188590260", Slot = "6")]
		readonly IVertexSkinning IVertexBuilder.GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8590920", Offset = "0x858F920", VA = "0x188590920", Slot = "7")]
		void IVertexBuilder.SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x85916B0", Offset = "0x85906B0", VA = "0x1885916B0", Slot = "8")]
		void IVertexBuilder.SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x85925A0", Offset = "0x85915A0", VA = "0x1885925A0", Slot = "9")]
		void IVertexBuilder.SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8592AB0", Offset = "0x8591AB0", VA = "0x188592AB0")]
		public readonly VertexBuilder<TvG, TvM, TvS> TransformedBy([In] Matrix4x4 transform)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x85945B0", Offset = "0x85935B0", VA = "0x1885945B0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8595010", Offset = "0x8594010", VA = "0x188595010")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8593B70", Offset = "0x8592B70", VA = "0x188593B70")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8596B60", Offset = "0x8595B60", VA = "0x188596B60")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial(params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8598400", Offset = "0x8597400", VA = "0x188598400")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x85976B0", Offset = "0x85966B0", VA = "0x1885976B0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, Vector4 color1, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8599410", Offset = "0x8598410", VA = "0x188599410")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning([In] SparseWeight8 sparse)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x859A020", Offset = "0x8599020", VA = "0x18859A020")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(params (int Index, float Weight)[] bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8599210", Offset = "0x8598210", VA = "0x188599210")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7A2140", Offset = "0xA7A1140", VA = "0x18A7A2140")]
		public VertexBuilder(IVertexGeometry g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		public VertexBuilder(IVertexGeometry g, IVertexMaterial m, IVertexSkinning s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x14A6390", Offset = "0x14A5390", VA = "0x1814A6390", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60", Slot = "4")]
		public readonly IVertexGeometry GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660", Slot = "5")]
		public readonly IVertexMaterial GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "6")]
		public readonly IVertexSkinning GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80", Slot = "7")]
		public void SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xF2D670", Offset = "0xF2C670", VA = "0x180F2D670", Slot = "8")]
		public void SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160", Slot = "9")]
		public void SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2090", Offset = "0xA7A1090", VA = "0x18A7A2090")]
		public readonly IVertexBuilder ConvertToType(Func<IVertexBuilder> factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3C07E40", Offset = "0x3C06E40", VA = "0x183C07E40", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			[CompilerGenerated]
			get
			{
				return default(EncodingType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xE9D7B0", Offset = "0xE9C7B0", VA = "0x180E9D7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xED4590", Offset = "0xED3590", VA = "0x180ED4590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1FF0", Offset = "0xA7A0FF0", VA = "0x18A7A1FF0")]
		public VertexAttributeAttribute(string attributeName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2030", Offset = "0xA7A1030", VA = "0x18A7A2030")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79D880", Offset = "0xA79C880", VA = "0x18A79D880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x10106A0", Offset = "0x100F6A0", VA = "0x1810106A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xA79D840", Offset = "0xA79C840", VA = "0x18A79D840", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xA79D7A0", Offset = "0xA79C7A0", VA = "0x18A79D7A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xA79D7A0", Offset = "0xA79C7A0", VA = "0x18A79D7A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "21")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8180", Offset = "0xA7A7180", VA = "0x18A7A8180", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7E10", Offset = "0xA7A6E10", VA = "0x18A7A7E10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "22")]
		public bool Equals(VertexEmpty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
		public static bool operator ==([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
		public static bool operator !=([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7FA0", Offset = "0xA7A6FA0", VA = "0x18A7A7FA0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7FF0", Offset = "0xA7A6FF0", VA = "0x18A7A7FF0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8040", Offset = "0xA7A7040", VA = "0x18A7A8040", Slot = "10")]
		VertexMaterialDelta IVertexMaterial.Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7F00", Offset = "0xA7A6F00", VA = "0x18A7A7F00", Slot = "6")]
		Vector4 IVertexMaterial.GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7F50", Offset = "0xA7A6F50", VA = "0x18A7A7F50", Slot = "7")]
		Vector2 IVertexMaterial.GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7E60", Offset = "0xA7A6E60", VA = "0x18A7A7E60", Slot = "17")]
		public SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7EC0", Offset = "0xA7A6EC0", VA = "0x18A7A7EC0")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7E80", Offset = "0xA7A6E80", VA = "0x18A7A7E80", Slot = "16")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A81F0", Offset = "0xA7A71F0", VA = "0x18A7A81F0", Slot = "14")]
		(int, float) IVertexSkinning.GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8240", Offset = "0xA7A7240", VA = "0x18A7A8240", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79EBE0", Offset = "0xA79DBE0", VA = "0x18A79EBE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA79DE80", Offset = "0xA79CE80", VA = "0x18A79DE80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xA79EA00", Offset = "0xA79DA00", VA = "0x18A79EA00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xA79E740", Offset = "0xA79D740", VA = "0x18A79E740", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xA79E740", Offset = "0xA79D740", VA = "0x18A79E740", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7AE370", Offset = "0xA7AD370", VA = "0x18A7AE370")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6010", Offset = "0x2DD5010", VA = "0x182DD6010")]
		public VertexPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE3F0", Offset = "0xA7AD3F0", VA = "0x18A7AE3F0")]
		public VertexPosition(float px, float py, float pz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE430", Offset = "0xA7AD430", VA = "0x18A7AE430")]
		public VertexPosition(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6960", Offset = "0x2DD5960", VA = "0x182DD6960")]
		public static implicit operator VertexPosition([In] Vector3 position)
		{
			return default(VertexPosition);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE1C0", Offset = "0xA7AD1C0", VA = "0x18A7AE1C0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8570", Offset = "0xA7A7570", VA = "0x18A7A8570", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE0F0", Offset = "0xA7AD0F0", VA = "0x18A7AE0F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE0A0", Offset = "0xA7AD0A0", VA = "0x18A7AE0A0", Slot = "14")]
		public readonly bool Equals(VertexPosition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE0A0", Offset = "0xA7AD0A0", VA = "0x18A7AE0A0")]
		public static bool operator ==([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE570", Offset = "0xA7AD570", VA = "0x18A7AE570")]
		public static bool operator !=([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE0A0", Offset = "0xA7AD0A0", VA = "0x18A7AE0A0")]
		public static bool AreEqual([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6010", Offset = "0x2DD5010", VA = "0x182DD6010", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		readonly void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE230", Offset = "0xA7AD230", VA = "0x18A7AE230", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADEC0", Offset = "0xA7ACEC0", VA = "0x18A7ADEC0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6960", Offset = "0x2DD5960", VA = "0x182DD6960", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE360", Offset = "0xA7AD360", VA = "0x18A7AE360", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x173A980", Offset = "0x1739980", VA = "0x18173A980", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADF30", Offset = "0xA7ACF30", VA = "0x18A7ADF30")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE1B0", Offset = "0xA7AD1B0", VA = "0x18A7AE1B0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADEC0", Offset = "0xA7ACEC0", VA = "0x18A7ADEC0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A00E0", Offset = "0xA79F0E0", VA = "0x18A7A00E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA79EF50", Offset = "0xA79DF50", VA = "0x18A79EF50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xA79FFB0", Offset = "0xA79EFB0", VA = "0x18A79FFB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA79FBD0", Offset = "0xA79EBD0", VA = "0x18A79FBD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xA79FBD0", Offset = "0xA79EBD0", VA = "0x18A79FBD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7ADBE0", Offset = "0xA7ACBE0", VA = "0x18A7ADBE0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADE40", Offset = "0xA7ACE40", VA = "0x18A7ADE40")]
		public VertexPositionNormal([In] Vector3 p, [In] Vector3 n)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADDB0", Offset = "0xA7ACDB0", VA = "0x18A7ADDB0")]
		public VertexPositionNormal(float px, float py, float pz, float nx, float ny, float nz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADC60", Offset = "0xA7ACC60", VA = "0x18A7ADC60")]
		public VertexPositionNormal(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADE70", Offset = "0xA7ACE70", VA = "0x18A7ADE70")]
		public static implicit operator VertexPositionNormal([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexPositionNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADAA0", Offset = "0xA7ACAA0", VA = "0x18A7ADAA0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8570", Offset = "0xA7A7570", VA = "0x18A7A8570", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD950", Offset = "0xA7AC950", VA = "0x18A7AD950", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADA60", Offset = "0xA7ACA60", VA = "0x18A7ADA60", Slot = "14")]
		public readonly bool Equals(VertexPositionNormal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADE60", Offset = "0xA7ACE60", VA = "0x18A7ADE60")]
		public static bool operator ==([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADEA0", Offset = "0xA7ACEA0", VA = "0x18A7ADEA0")]
		public static bool operator !=([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD8D0", Offset = "0xA7AC8D0", VA = "0x18A7AD8D0")]
		public static bool AreEqual([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6010", Offset = "0x2DD5010", VA = "0x182DD6010", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85C0", Offset = "0xA7A75C0", VA = "0x18A7A85C0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADB20", Offset = "0xA7ACB20", VA = "0x18A7ADB20", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD5B0", Offset = "0xA7AC5B0", VA = "0x18A7AD5B0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6960", Offset = "0x2DD5960", VA = "0x182DD6960", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8760", Offset = "0xA7A7760", VA = "0x18A7A8760", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x173A980", Offset = "0x1739980", VA = "0x18173A980", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD680", Offset = "0xA7AC680", VA = "0x18A7AD680")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADA90", Offset = "0xA7ACA90", VA = "0x18A7ADA90", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADA80", Offset = "0xA7ACA80", VA = "0x18A7ADA80", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A0180", Offset = "0xA79F180", VA = "0x18A7A0180", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA79F630", Offset = "0xA79E630", VA = "0x18A79F630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA79FEB0", Offset = "0xA79EEB0", VA = "0x18A79FEB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA79FA80", Offset = "0xA79EA80", VA = "0x18A79FA80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA79FA80", Offset = "0xA79EA80", VA = "0x18A79FA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7AD320", Offset = "0xA7AC320", VA = "0x18A7AD320")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD3B0", Offset = "0xA7AC3B0", VA = "0x18A7AD3B0")]
		public VertexPositionNormalTangent([In] Vector3 p, [In] Vector3 n, [In] Vector4 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD3E0", Offset = "0xA7AC3E0", VA = "0x18A7AD3E0")]
		public VertexPositionNormalTangent(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD560", Offset = "0xA7AC560", VA = "0x18A7AD560")]
		public static implicit operator VertexPositionNormalTangent([In] (Vector3 Pos, Vector3 Nrm, Vector4 Tgt) tuple)
		{
			return default(VertexPositionNormalTangent);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD1D0", Offset = "0xA7AC1D0", VA = "0x18A7AD1D0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8570", Offset = "0xA7A7570", VA = "0x18A7A8570", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD040", Offset = "0xA7AC040", VA = "0x18A7AD040", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD190", Offset = "0xA7AC190", VA = "0x18A7AD190", Slot = "14")]
		public readonly bool Equals(VertexPositionNormalTangent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD550", Offset = "0xA7AC550", VA = "0x18A7AD550")]
		public static bool operator ==([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD590", Offset = "0xA7AC590", VA = "0x18A7AD590")]
		public static bool operator !=([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACFA0", Offset = "0xA7ABFA0", VA = "0x18A7ACFA0")]
		public static bool AreEqual([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6010", Offset = "0x2DD5010", VA = "0x182DD6010", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85C0", Offset = "0xA7A75C0", VA = "0x18A7A85C0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF713E0", Offset = "0xF703E0", VA = "0x180F713E0", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD250", Offset = "0xA7AC250", VA = "0x18A7AD250", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACAB0", Offset = "0xA7ABAB0", VA = "0x18A7ACAB0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6960", Offset = "0x2DD5960", VA = "0x182DD6960", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8760", Offset = "0xA7A7760", VA = "0x18A7A8760", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD310", Offset = "0xA7AC310", VA = "0x18A7AD310", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACC20", Offset = "0xA7ABC20", VA = "0x18A7ACC20")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD1C0", Offset = "0xA7AC1C0", VA = "0x18A7AD1C0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD1B0", Offset = "0xA7AC1B0", VA = "0x18A7AD1B0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79D1F0", Offset = "0xA79C1F0", VA = "0x18A79D1F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA79CEF0", Offset = "0xA79BEF0", VA = "0x18A79CEF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xA79D1B0", Offset = "0xA79C1B0", VA = "0x18A79D1B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xA79D100", Offset = "0xA79C100", VA = "0x18A79D100", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xA79D100", Offset = "0xA79C100", VA = "0x18A79D100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7A87D0", Offset = "0xA7A77D0", VA = "0x18A7A87D0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9040", Offset = "0xA7A8040", VA = "0x18A7A9040")]
		public static implicit operator VertexGeometryDelta([In] Vector3 position)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8FE0", Offset = "0xA7A7FE0", VA = "0x18A7A8FE0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8FA0", Offset = "0xA7A7FA0", VA = "0x18A7A8FA0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm, Vector3 tgt) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8B90", Offset = "0xA7A7B90", VA = "0x18A7A8B90")]
		public VertexGeometryDelta(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A89C0", Offset = "0xA7A79C0", VA = "0x18A7A89C0")]
		public VertexGeometryDelta([In] Vector3 p, [In] Vector3 n, [In] Vector3 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8EE0", Offset = "0xA7A7EE0", VA = "0x18A7A8EE0")]
		internal VertexGeometryDelta([In] VertexPosition rootVal, [In] VertexPosition morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A88B0", Offset = "0xA7A78B0", VA = "0x18A7A88B0")]
		internal VertexGeometryDelta([In] VertexPositionNormal rootVal, [In] VertexPositionNormal morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8A00", Offset = "0xA7A7A00", VA = "0x18A7A8A00")]
		internal VertexGeometryDelta([In] VertexPositionNormalTangent rootVal, [In] VertexPositionNormalTangent morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8DB0", Offset = "0xA7A7DB0", VA = "0x18A7A8DB0")]
		internal VertexGeometryDelta([In] VertexGeometryDelta rootVal, [In] VertexGeometryDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8620", Offset = "0xA7A7620", VA = "0x18A7A8620", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8570", Offset = "0xA7A7570", VA = "0x18A7A8570", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA7A84C0", Offset = "0xA7A74C0", VA = "0x18A7A84C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA7A84A0", Offset = "0xA7A74A0", VA = "0x18A7A84A0", Slot = "14")]
		public readonly bool Equals(VertexGeometryDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8F90", Offset = "0xA7A7F90", VA = "0x18A7A8F90")]
		public static bool operator ==([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA7A90C0", Offset = "0xA7A80C0", VA = "0x18A7A90C0")]
		public static bool operator !=([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA7A83E0", Offset = "0xA7A73E0", VA = "0x18A7A83E0")]
		public static bool AreEqual([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6010", Offset = "0x2DD5010", VA = "0x182DD6010", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85C0", Offset = "0xA7A75C0", VA = "0x18A7A85C0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85D0", Offset = "0xA7A75D0", VA = "0x18A7A85D0", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6960", Offset = "0x2DD5960", VA = "0x182DD6960", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8760", Offset = "0xA7A7760", VA = "0x18A7A8760", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8780", Offset = "0xA7A7780", VA = "0x18A7A8780", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A83A0", Offset = "0xA7A73A0", VA = "0x18A7A83A0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A86A0", Offset = "0xA7A76A0", VA = "0x18A7A86A0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8280", Offset = "0xA7A7280", VA = "0x18A7A8280")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85B0", Offset = "0xA7A75B0", VA = "0x18A7A85B0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA7A85A0", Offset = "0xA7A75A0", VA = "0x18A7A85A0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79DC60", Offset = "0xA79CC60", VA = "0x18A79DC60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA79D9B0", Offset = "0xA79C9B0", VA = "0x18A79D9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA79DC20", Offset = "0xA79CC20", VA = "0x18A79DC20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xA79DAA0", Offset = "0xA79CAA0", VA = "0x18A79DAA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xA79DAA0", Offset = "0xA79CAA0", VA = "0x18A79DAA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public static implicit operator VertexColor1(Vector4 color)
		{
			return default(VertexColor1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4910", Offset = "0xA7A3910", VA = "0x18A7A4910")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x15315F0", Offset = "0x15305F0", VA = "0x1815315F0")]
		public VertexColor1(Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4990", Offset = "0xA7A3990", VA = "0x18A7A4990")]
		public VertexColor1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA7A47F0", Offset = "0xA7A37F0", VA = "0x18A7A47F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4770", Offset = "0xA7A3770", VA = "0x18A7A4770", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4620", Offset = "0xA7A3620", VA = "0x18A7A4620", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A46D0", Offset = "0xA7A36D0", VA = "0x18A7A46D0", Slot = "13")]
		public readonly bool Equals(VertexColor1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A46D0", Offset = "0xA7A36D0", VA = "0x18A7A46D0")]
		public static bool operator ==([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4AF0", Offset = "0xA7A3AF0", VA = "0x18A7A4AF0")]
		public static bool operator !=([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A45F0", Offset = "0xA7A35F0", VA = "0x18A7A45F0")]
		public static bool AreEqual([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4860", Offset = "0xA7A3860", VA = "0x18A7A4860", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4570", Offset = "0xA7A3570", VA = "0x18A7A4570")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2550", Offset = "0xA7A1550", VA = "0x18A7A2550", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4700", Offset = "0xA7A3700", VA = "0x18A7A4700", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4790", Offset = "0xA7A3790", VA = "0x18A7A4790", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA7A47E0", Offset = "0xA7A37E0", VA = "0x18A7A47E0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79EB40", Offset = "0xA79DB40", VA = "0x18A79EB40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA79E470", Offset = "0xA79D470", VA = "0x18A79E470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA79EAC0", Offset = "0xA79DAC0", VA = "0x18A79EAC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA79E600", Offset = "0xA79D600", VA = "0x18A79E600", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xA79E600", Offset = "0xA79D600", VA = "0x18A79E600", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7DD0", Offset = "0xA7A6DD0", VA = "0x18A7A7DD0")]
		public static implicit operator VertexColor2((Vector4 Color0, Vector4 Color1) tuple)
		{
			return default(VertexColor2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7B30", Offset = "0xA7A6B30", VA = "0x18A7A7B30")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x63165A0", Offset = "0x63155A0", VA = "0x1863165A0")]
		public VertexColor2(Vector4 color0, Vector4 color1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7BB0", Offset = "0xA7A6BB0", VA = "0x18A7A7BB0")]
		public VertexColor2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7A00", Offset = "0xA7A6A00", VA = "0x18A7A7A00", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7950", Offset = "0xA7A6950", VA = "0x18A7A7950", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA7A77B0", Offset = "0xA7A67B0", VA = "0x18A7A77B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA7A78B0", Offset = "0xA7A68B0", VA = "0x18A7A78B0", Slot = "13")]
		public readonly bool Equals(VertexColor2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7DC0", Offset = "0xA7A6DC0", VA = "0x18A7A7DC0")]
		public static bool operator ==([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7DF0", Offset = "0xA7A6DF0", VA = "0x18A7A7DF0")]
		public static bool operator !=([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7730", Offset = "0xA7A6730", VA = "0x18A7A7730")]
		public static bool AreEqual([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7A70", Offset = "0xA7A6A70", VA = "0x18A7A7A70", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7640", Offset = "0xA7A6640", VA = "0x18A7A7640")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA7A78D0", Offset = "0xA7A68D0", VA = "0x18A7A78D0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA7A79A0", Offset = "0xA7A69A0", VA = "0x18A7A79A0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA7A79F0", Offset = "0xA7A69F0", VA = "0x18A7A79F0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79DCB0", Offset = "0xA79CCB0", VA = "0x18A79DCB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xA79D8D0", Offset = "0xA79C8D0", VA = "0x18A79D8D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xA79DBE0", Offset = "0xA79CBE0", VA = "0x18A79DBE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xA79DB40", Offset = "0xA79CB40", VA = "0x18A79DB40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA79DB40", Offset = "0xA79CB40", VA = "0x18A79DB40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0")]
		public static implicit operator VertexTexture1(Vector2 uv)
		{
			return default(VertexTexture1);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE940", Offset = "0xA7AD940", VA = "0x18A7AE940")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x1407120", Offset = "0x1406120", VA = "0x181407120")]
		public VertexTexture1(Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE9C0", Offset = "0xA7AD9C0", VA = "0x18A7AE9C0")]
		public VertexTexture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE800", Offset = "0xA7AD800", VA = "0x18A7AE800", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE760", Offset = "0xA7AD760", VA = "0x18A7AE760", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE640", Offset = "0xA7AD640", VA = "0x18A7AE640", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE6F0", Offset = "0xA7AD6F0", VA = "0x18A7AE6F0", Slot = "13")]
		public readonly bool Equals(VertexTexture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEAD0", Offset = "0xA7ADAD0", VA = "0x18A7AEAD0")]
		public static bool operator ==([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEB00", Offset = "0xA7ADB00", VA = "0x18A7AEB00")]
		public static bool operator !=([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE610", Offset = "0xA7AD610", VA = "0x18A7AE610")]
		public static bool AreEqual([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE880", Offset = "0xA7AD880", VA = "0x18A7AE880", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE5C0", Offset = "0xA7AD5C0", VA = "0x18A7AE5C0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE7F0", Offset = "0xA7AD7F0", VA = "0x18A7AE7F0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE710", Offset = "0xA7AD710", VA = "0x18A7AE710", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE780", Offset = "0xA7AD780", VA = "0x18A7AE780", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE5C0", Offset = "0xA7AD5C0", VA = "0x18A7AE5C0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79EC30", Offset = "0xA79DC30", VA = "0x18A79EC30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA79E2F0", Offset = "0xA79D2F0", VA = "0x18A79E2F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xA79EA40", Offset = "0xA79DA40", VA = "0x18A79EA40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xA79E880", Offset = "0xA79D880", VA = "0x18A79E880", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA79E880", Offset = "0xA79D880", VA = "0x18A79E880", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public static implicit operator VertexTexture2((Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexTexture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEFE0", Offset = "0xA7ADFE0", VA = "0x18A7AEFE0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x3113730", Offset = "0x3112730", VA = "0x183113730")]
		public VertexTexture2(Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF060", Offset = "0xA7AE060", VA = "0x18A7AF060")]
		public VertexTexture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEEC0", Offset = "0xA7ADEC0", VA = "0x18A7AEEC0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEDC0", Offset = "0xA7ADDC0", VA = "0x18A7AEDC0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEC60", Offset = "0xA7ADC60", VA = "0x18A7AEC60", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEC40", Offset = "0xA7ADC40", VA = "0x18A7AEC40", Slot = "13")]
		public readonly bool Equals(VertexTexture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF1D0", Offset = "0xA7AE1D0", VA = "0x18A7AF1D0")]
		public static bool operator ==([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF1E0", Offset = "0xA7AE1E0", VA = "0x18A7AF1E0")]
		public static bool operator !=([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEBC0", Offset = "0xA7ADBC0", VA = "0x18A7AEBC0")]
		public static bool AreEqual([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEF30", Offset = "0xA7ADF30", VA = "0x18A7AEF30", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEB30", Offset = "0xA7ADB30", VA = "0x18A7AEB30")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEEA0", Offset = "0xA7ADEA0", VA = "0x18A7AEEA0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7AED70", Offset = "0xA7ADD70", VA = "0x18A7AED70", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEE10", Offset = "0xA7ADE10", VA = "0x18A7AEE10", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AEE90", Offset = "0xA7ADE90", VA = "0x18A7AEE90", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79EB90", Offset = "0xA79DB90", VA = "0x18A79EB90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xA79DD00", Offset = "0xA79CD00", VA = "0x18A79DD00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA79E9C0", Offset = "0xA79D9C0", VA = "0x18A79E9C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA79E920", Offset = "0xA79D920", VA = "0x18A79E920", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA79E920", Offset = "0xA79D920", VA = "0x18A79E920", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x3052140", Offset = "0x3051140", VA = "0x183052140")]
		public static implicit operator VertexColor1Texture1((Vector4 Color, Vector2 Tex) tuple)
		{
			return default(VertexColor1Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A26B0", Offset = "0xA7A16B0", VA = "0x18A7A26B0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x69131B0", Offset = "0x69121B0", VA = "0x1869131B0")]
		public VertexColor1Texture1(Vector4 color, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2730", Offset = "0xA7A1730", VA = "0x18A7A2730")]
		public VertexColor1Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2570", Offset = "0xA7A1570", VA = "0x18A7A2570", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2470", Offset = "0xA7A1470", VA = "0x18A7A2470", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A22E0", Offset = "0xA7A12E0", VA = "0x18A7A22E0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A23E0", Offset = "0xA7A13E0", VA = "0x18A7A23E0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A28E0", Offset = "0xA7A18E0", VA = "0x18A7A28E0")]
		public static bool operator ==([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A28F0", Offset = "0xA7A18F0", VA = "0x18A7A28F0")]
		public static bool operator !=([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2250", Offset = "0xA7A1250", VA = "0x18A7A2250")]
		public static bool AreEqual([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A25F0", Offset = "0xA7A15F0", VA = "0x18A7A25F0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2180", Offset = "0xA7A1180", VA = "0x18A7A2180")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2550", Offset = "0xA7A1550", VA = "0x18A7A2550", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2560", Offset = "0xA7A1560", VA = "0x18A7A2560", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2400", Offset = "0xA7A1400", VA = "0x18A7A2400", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A24C0", Offset = "0xA7A14C0", VA = "0x18A7A24C0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2540", Offset = "0xA7A1540", VA = "0x18A7A2540", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A0130", Offset = "0xA79F130", VA = "0x18A7A0130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA79ED20", Offset = "0xA79DD20", VA = "0x18A79ED20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA79FEF0", Offset = "0xA79EEF0", VA = "0x18A79FEF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xA79FC70", Offset = "0xA79EC70", VA = "0x18A79FC70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xA79FC70", Offset = "0xA79EC70", VA = "0x18A79FC70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9E640", Offset = "0x2D9D640", VA = "0x182D9E640")]
		public static implicit operator VertexColor1Texture2((Vector4 Color, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor1Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2E70", Offset = "0xA7A1E70", VA = "0x18A7A2E70")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x83879C0", Offset = "0x83869C0", VA = "0x1883879C0")]
		public VertexColor1Texture2(Vector4 color, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2EF0", Offset = "0xA7A1EF0", VA = "0x18A7A2EF0")]
		public VertexColor1Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2D40", Offset = "0xA7A1D40", VA = "0x18A7A2D40", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2C00", Offset = "0xA7A1C00", VA = "0x18A7A2C00", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2AF0", Offset = "0xA7A1AF0", VA = "0x18A7A2AF0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2AD0", Offset = "0xA7A1AD0", VA = "0x18A7A2AD0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3100", Offset = "0xA7A2100", VA = "0x18A7A3100")]
		public static bool operator ==([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3110", Offset = "0xA7A2110", VA = "0x18A7A3110")]
		public static bool operator !=([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2A10", Offset = "0xA7A1A10", VA = "0x18A7A2A10")]
		public static bool AreEqual([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2DB0", Offset = "0xA7A1DB0", VA = "0x18A7A2DB0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2910", Offset = "0xA7A1910", VA = "0x18A7A2910")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2550", Offset = "0xA7A1550", VA = "0x18A7A2550", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2D20", Offset = "0xA7A1D20", VA = "0x18A7A2D20", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2B90", Offset = "0xA7A1B90", VA = "0x18A7A2B90", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2C80", Offset = "0xA7A1C80", VA = "0x18A7A2C80", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2D10", Offset = "0xA7A1D10", VA = "0x18A7A2D10", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A0040", Offset = "0xA79F040", VA = "0x18A7A0040", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA79F840", Offset = "0xA79E840", VA = "0x18A79F840", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA79FE70", Offset = "0xA79EE70", VA = "0x18A79FE70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xA79FD10", Offset = "0xA79ED10", VA = "0x18A79FD10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xA79FD10", Offset = "0xA79ED10", VA = "0x18A79FD10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A54A0", Offset = "0xA7A44A0", VA = "0x18A7A54A0")]
		public static implicit operator VertexColor2Texture1((Vector4 Color0, Vector4 Color1, Vector2 Tex) tuple)
		{
			return default(VertexColor2Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5190", Offset = "0xA7A4190", VA = "0x18A7A5190")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x8387AE0", Offset = "0x8386AE0", VA = "0x188387AE0")]
		public VertexColor2Texture1(Vector4 color0, Vector4 color1, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5220", Offset = "0xA7A4220", VA = "0x18A7A5220")]
		public VertexColor2Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5040", Offset = "0xA7A4040", VA = "0x18A7A5040", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4F00", Offset = "0xA7A3F00", VA = "0x18A7A4F00", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4D20", Offset = "0xA7A3D20", VA = "0x18A7A4D20", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4D00", Offset = "0xA7A3D00", VA = "0x18A7A4D00", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5490", Offset = "0xA7A4490", VA = "0x18A7A5490")]
		public static bool operator ==([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A54C0", Offset = "0xA7A44C0", VA = "0x18A7A54C0")]
		public static bool operator !=([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4C50", Offset = "0xA7A3C50", VA = "0x18A7A4C50")]
		public static bool AreEqual([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A50C0", Offset = "0xA7A40C0", VA = "0x18A7A50C0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4B20", Offset = "0xA7A3B20", VA = "0x18A7A4B20")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5030", Offset = "0xA7A4030", VA = "0x18A7A5030", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4E80", Offset = "0xA7A3E80", VA = "0x18A7A4E80", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4F80", Offset = "0xA7A3F80", VA = "0x18A7A4F80", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5000", Offset = "0xA7A4000", VA = "0x18A7A5000", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A1220", Offset = "0xA7A0220", VA = "0x18A7A1220", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0530", Offset = "0xA79F530", VA = "0x18A7A0530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1120", Offset = "0xA7A0120", VA = "0x18A7A1120", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1070", Offset = "0xA7A0070", VA = "0x18A7A1070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1070", Offset = "0xA7A0070", VA = "0x18A7A1070", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5EA0", Offset = "0xA7A4EA0", VA = "0x18A7A5EA0")]
		public static implicit operator VertexColor2Texture2((Vector4 Color0, Vector4 Color1, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor2Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5B40", Offset = "0xA7A4B40", VA = "0x18A7A5B40")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x8490920", Offset = "0x848F920", VA = "0x188490920")]
		public VertexColor2Texture2(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5BD0", Offset = "0xA7A4BD0", VA = "0x18A7A5BD0")]
		public VertexColor2Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A59F0", Offset = "0xA7A49F0", VA = "0x18A7A59F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5890", Offset = "0xA7A4890", VA = "0x18A7A5890", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5760", Offset = "0xA7A4760", VA = "0x18A7A5760", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5740", Offset = "0xA7A4740", VA = "0x18A7A5740", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5E90", Offset = "0xA7A4E90", VA = "0x18A7A5E90")]
		public static bool operator ==([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5EC0", Offset = "0xA7A4EC0", VA = "0x18A7A5EC0")]
		public static bool operator !=([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5650", Offset = "0xA7A4650", VA = "0x18A7A5650")]
		public static bool AreEqual([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5A70", Offset = "0xA7A4A70", VA = "0x18A7A5A70", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA7A54E0", Offset = "0xA7A44E0", VA = "0x18A7A54E0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA7A59D0", Offset = "0xA7A49D0", VA = "0x18A7A59D0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5810", Offset = "0xA7A4810", VA = "0x18A7A5810", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5930", Offset = "0xA7A4930", VA = "0x18A7A5930", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A59C0", Offset = "0xA7A49C0", VA = "0x18A7A59C0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79D750", Offset = "0xA79C750", VA = "0x18A79D750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xA79D240", Offset = "0xA79C240", VA = "0x18A79D240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xA79D710", Offset = "0xA79C710", VA = "0x18A79D710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA79D640", Offset = "0xA79C640", VA = "0x18A79D640", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA79D640", Offset = "0xA79C640", VA = "0x18A79D640", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7AC8B0", Offset = "0xA7AB8B0", VA = "0x18A7AC8B0")]
			get
			{
				return default(VertexMaterialDelta);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xD12FF0", Offset = "0xD11FF0", VA = "0x180D12FF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA970", Offset = "0xA7A9970", VA = "0x18A7AA970")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC9B0", Offset = "0xA7AB9B0", VA = "0x18A7AC9B0")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACA50", Offset = "0xA7ABA50", VA = "0x18A7ACA50")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta, Vector2 TextCoord2Delta, Vector2 TextCoord3Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA7ABBF0", Offset = "0xA7AABF0", VA = "0x18A7ABBF0")]
		public VertexMaterialDelta(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA7ABFC0", Offset = "0xA7AAFC0", VA = "0x18A7ABFC0")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA7AAE90", Offset = "0xA7A9E90", VA = "0x18A7AAE90")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta, [In] Vector2 texCoord2Delta, [In] Vector2 texCoord3Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB4C0", Offset = "0xA7AA4C0", VA = "0x18A7AB4C0")]
		internal VertexMaterialDelta([In] VertexMaterialDelta rootVal, [In] VertexMaterialDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA7F0", Offset = "0xA7A97F0", VA = "0x18A7AA7F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA5B0", Offset = "0xA7A95B0", VA = "0x18A7AA5B0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA460", Offset = "0xA7A9460", VA = "0x18A7AA460", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA440", Offset = "0xA7A9440", VA = "0x18A7AA440", Slot = "13")]
		public readonly bool Equals(VertexMaterialDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC9A0", Offset = "0xA7AB9A0", VA = "0x18A7AC9A0")]
		public static bool operator ==([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACA90", Offset = "0xA7ABA90", VA = "0x18A7ACA90")]
		public static bool operator !=([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA2E0", Offset = "0xA7A92E0", VA = "0x18A7AA2E0")]
		public static bool AreEqual([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA890", Offset = "0xA7A9890", VA = "0x18A7AA890", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6A10", Offset = "0xA7A5A10", VA = "0x18A7A6A10")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010")]
		private void SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA760", Offset = "0xA7A9760", VA = "0x18A7AA760", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7080", Offset = "0xA7A6080", VA = "0x18A7A7080")]
		private void SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA530", Offset = "0xA7A9530", VA = "0x18A7AA530", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA690", Offset = "0xA7A9690", VA = "0x18A7AA690", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA7ABAE0", Offset = "0xA7AAAE0", VA = "0x18A7ABAE0")]
		internal VertexMaterialDelta([In] VertexTexture1 rootVal, [In] VertexTexture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB390", Offset = "0xA7AA390", VA = "0x18A7AB390")]
		internal VertexMaterialDelta([In] VertexTexture2 rootVal, [In] VertexTexture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AAD40", Offset = "0xA7A9D40", VA = "0x18A7AAD40")]
		internal VertexMaterialDelta([In] VertexTexture3 rootVal, [In] VertexTexture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB230", Offset = "0xA7AA230", VA = "0x18A7AB230")]
		internal VertexMaterialDelta([In] VertexTexture4 rootVal, [In] VertexTexture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC790", Offset = "0xA7AB790", VA = "0x18A7AC790")]
		internal VertexMaterialDelta([In] VertexColor1 rootVal, [In] VertexColor1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA7AAF20", Offset = "0xA7A9F20", VA = "0x18A7AAF20")]
		internal VertexMaterialDelta([In] VertexColor1Texture1 rootVal, [In] VertexColor1Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB770", Offset = "0xA7AA770", VA = "0x18A7AB770")]
		internal VertexMaterialDelta([In] VertexColor1Texture2 rootVal, [In] VertexColor1Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA7AABB0", Offset = "0xA7A9BB0", VA = "0x18A7AABB0")]
		internal VertexMaterialDelta([In] VertexColor1Texture3 rootVal, [In] VertexColor1Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB080", Offset = "0xA7AA080", VA = "0x18A7AB080")]
		internal VertexMaterialDelta([In] VertexColor1Texture4 rootVal, [In] VertexColor1Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC220", Offset = "0xA7AB220", VA = "0x18A7AC220")]
		internal VertexMaterialDelta([In] VertexColor2 rootVal, [In] VertexColor2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC070", Offset = "0xA7AB070", VA = "0x18A7AC070")]
		internal VertexMaterialDelta([In] VertexColor2Texture1 rootVal, [In] VertexColor2Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC5C0", Offset = "0xA7AB5C0", VA = "0x18A7AC5C0")]
		internal VertexMaterialDelta([In] VertexColor2Texture2 rootVal, [In] VertexColor2Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB8F0", Offset = "0xA7AA8F0", VA = "0x18A7AB8F0")]
		internal VertexMaterialDelta([In] VertexColor2Texture3 rootVal, [In] VertexColor2Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC3B0", Offset = "0xA7AB3B0", VA = "0x18A7AC3B0")]
		internal VertexMaterialDelta([In] VertexColor2Texture4 rootVal, [In] VertexColor2Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7070", Offset = "0xA7A6070", VA = "0x18A7A7070", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79ECD0", Offset = "0xA79DCD0", VA = "0x18A79ECD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA79DF60", Offset = "0xA79CF60", VA = "0x18A79DF60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA79EB00", Offset = "0xA79DB00", VA = "0x18A79EB00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xA79E6A0", Offset = "0xA79D6A0", VA = "0x18A79E6A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA79E6A0", Offset = "0xA79D6A0", VA = "0x18A79E6A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF740", Offset = "0xA7AE740", VA = "0x18A7AF740")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x833AE50", Offset = "0x8339E50", VA = "0x18833AE50")]
		public VertexTexture3(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF7C0", Offset = "0xA7AE7C0", VA = "0x18A7AF7C0")]
		public VertexTexture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF600", Offset = "0xA7AE600", VA = "0x18A7AF600", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF4C0", Offset = "0xA7AE4C0", VA = "0x18A7AF4C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF3C0", Offset = "0xA7AE3C0", VA = "0x18A7AF3C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF3A0", Offset = "0xA7AE3A0", VA = "0x18A7AF3A0", Slot = "13")]
		public readonly bool Equals(VertexTexture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF980", Offset = "0xA7AE980", VA = "0x18A7AF980")]
		public static bool operator ==([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF990", Offset = "0xA7AE990", VA = "0x18A7AF990")]
		public static bool operator !=([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF2E0", Offset = "0xA7AE2E0", VA = "0x18A7AF2E0")]
		public static bool AreEqual([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF680", Offset = "0xA7AE680", VA = "0x18A7AF680", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF200", Offset = "0xA7AE200", VA = "0x18A7AF200")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF5E0", Offset = "0xA7AE5E0", VA = "0x18A7AF5E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF470", Offset = "0xA7AE470", VA = "0x18A7AF470", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF530", Offset = "0xA7AE530", VA = "0x18A7AF530", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF5D0", Offset = "0xA7AE5D0", VA = "0x18A7AF5D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79FFF0", Offset = "0xA79EFF0", VA = "0x18A79FFF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA79F0D0", Offset = "0xA79E0D0", VA = "0x18A79F0D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA79FF70", Offset = "0xA79EF70", VA = "0x18A79FF70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA79FB30", Offset = "0xA79EB30", VA = "0x18A79FB30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA79FB30", Offset = "0xA79EB30", VA = "0x18A79FB30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFF90", Offset = "0xA7AEF90", VA = "0x18A7AFF90")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0010", Offset = "0xA7AF010", VA = "0x18A7B0010")]
		public VertexTexture4(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0030", Offset = "0xA7AF030", VA = "0x18A7B0030")]
		public VertexTexture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFE60", Offset = "0xA7AEE60", VA = "0x18A7AFE60", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFCC0", Offset = "0xA7AECC0", VA = "0x18A7AFCC0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFBB0", Offset = "0xA7AEBB0", VA = "0x18A7AFBB0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFC50", Offset = "0xA7AEC50", VA = "0x18A7AFC50", Slot = "13")]
		public readonly bool Equals(VertexTexture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0240", Offset = "0xA7AF240", VA = "0x18A7B0240")]
		public static bool operator ==([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0250", Offset = "0xA7AF250", VA = "0x18A7B0250")]
		public static bool operator !=([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFAC0", Offset = "0xA7AEAC0", VA = "0x18A7AFAC0")]
		public static bool AreEqual([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFED0", Offset = "0xA7AEED0", VA = "0x18A7AFED0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF9B0", Offset = "0xA7AE9B0", VA = "0x18A7AF9B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFE30", Offset = "0xA7AEE30", VA = "0x18A7AFE30", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFC70", Offset = "0xA7AEC70", VA = "0x18A7AFC70", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFD60", Offset = "0xA7AED60", VA = "0x18A7AFD60", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFE20", Offset = "0xA7AEE20", VA = "0x18A7AFE20", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A0090", Offset = "0xA79F090", VA = "0x18A7A0090", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA79F370", Offset = "0xA79E370", VA = "0x18A79F370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA79FF30", Offset = "0xA79EF30", VA = "0x18A79FF30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xA79FDC0", Offset = "0xA79EDC0", VA = "0x18A79FDC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xA79FDC0", Offset = "0xA79EDC0", VA = "0x18A79FDC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3780", Offset = "0xA7A2780", VA = "0x18A7A3780")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3810", Offset = "0xA7A2810", VA = "0x18A7A3810")]
		public VertexColor1Texture3(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3830", Offset = "0xA7A2830", VA = "0x18A7A3830")]
		public VertexColor1Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3630", Offset = "0xA7A2630", VA = "0x18A7A3630", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A34B0", Offset = "0xA7A24B0", VA = "0x18A7A34B0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3390", Offset = "0xA7A2390", VA = "0x18A7A3390", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3370", Offset = "0xA7A2370", VA = "0x18A7A3370", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3A90", Offset = "0xA7A2A90", VA = "0x18A7A3A90")]
		public static bool operator ==([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3AA0", Offset = "0xA7A2AA0", VA = "0x18A7A3AA0")]
		public static bool operator !=([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3270", Offset = "0xA7A2270", VA = "0x18A7A3270")]
		public static bool AreEqual([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA7A36B0", Offset = "0xA7A26B0", VA = "0x18A7A36B0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3130", Offset = "0xA7A2130", VA = "0x18A7A3130")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2550", Offset = "0xA7A1550", VA = "0x18A7A2550", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3610", Offset = "0xA7A2610", VA = "0x18A7A3610", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3440", Offset = "0xA7A2440", VA = "0x18A7A3440", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3550", Offset = "0xA7A2550", VA = "0x18A7A3550", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3600", Offset = "0xA7A2600", VA = "0x18A7A3600", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A1310", Offset = "0xA7A0310", VA = "0x18A7A1310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xA7A01D0", Offset = "0xA79F1D0", VA = "0x18A7A01D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xA7A11A0", Offset = "0xA7A01A0", VA = "0x18A7A11A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0F00", Offset = "0xA79FF00", VA = "0x18A7A0F00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0F00", Offset = "0xA79FF00", VA = "0x18A7A0F00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A41D0", Offset = "0xA7A31D0", VA = "0x18A7A41D0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4510", Offset = "0xA7A3510", VA = "0x18A7A4510")]
		public VertexColor1Texture4(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4260", Offset = "0xA7A3260", VA = "0x18A7A4260")]
		public VertexColor1Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4080", Offset = "0xA7A3080", VA = "0x18A7A4080", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3EB0", Offset = "0xA7A2EB0", VA = "0x18A7A3EB0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3D70", Offset = "0xA7A2D70", VA = "0x18A7A3D70", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3E20", Offset = "0xA7A2E20", VA = "0x18A7A3E20", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4540", Offset = "0xA7A3540", VA = "0x18A7A4540")]
		public static bool operator ==([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4550", Offset = "0xA7A3550", VA = "0x18A7A4550")]
		public static bool operator !=([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3C40", Offset = "0xA7A2C40", VA = "0x18A7A3C40")]
		public static bool AreEqual([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4100", Offset = "0xA7A3100", VA = "0x18A7A4100", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3AC0", Offset = "0xA7A2AC0", VA = "0x18A7A3AC0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2550", Offset = "0xA7A1550", VA = "0x18A7A2550", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4050", Offset = "0xA7A3050", VA = "0x18A7A4050", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3E40", Offset = "0xA7A2E40", VA = "0x18A7A3E40", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3F70", Offset = "0xA7A2F70", VA = "0x18A7A3F70", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4040", Offset = "0xA7A3040", VA = "0x18A7A4040", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A12C0", Offset = "0xA7A02C0", VA = "0x18A7A12C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0AD0", Offset = "0xA79FAD0", VA = "0x18A7A0AD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7A11E0", Offset = "0xA7A01E0", VA = "0x18A7A11E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0FB0", Offset = "0xA79FFB0", VA = "0x18A7A0FB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0FB0", Offset = "0xA79FFB0", VA = "0x18A7A0FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6610", Offset = "0xA7A5610", VA = "0x18A7A6610")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A69B0", Offset = "0xA7A59B0", VA = "0x18A7A69B0")]
		public VertexColor2Texture3(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A66A0", Offset = "0xA7A56A0", VA = "0x18A7A66A0")]
		public VertexColor2Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A64B0", Offset = "0xA7A54B0", VA = "0x18A7A64B0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6320", Offset = "0xA7A5320", VA = "0x18A7A6320", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A61E0", Offset = "0xA7A51E0", VA = "0x18A7A61E0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A61C0", Offset = "0xA7A51C0", VA = "0x18A7A61C0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A69E0", Offset = "0xA7A59E0", VA = "0x18A7A69E0")]
		public static bool operator ==([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA7A69F0", Offset = "0xA7A59F0", VA = "0x18A7A69F0")]
		public static bool operator !=([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6090", Offset = "0xA7A5090", VA = "0x18A7A6090")]
		public static bool AreEqual([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6540", Offset = "0xA7A5540", VA = "0x18A7A6540", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5EE0", Offset = "0xA7A4EE0", VA = "0x18A7A5EE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6490", Offset = "0xA7A5490", VA = "0x18A7A6490", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7A62A0", Offset = "0xA7A52A0", VA = "0x18A7A62A0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A63D0", Offset = "0xA7A53D0", VA = "0x18A7A63D0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6480", Offset = "0xA7A5480", VA = "0x18A7A6480", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A1860", Offset = "0xA7A0860", VA = "0x18A7A1860", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1360", Offset = "0xA7A0360", VA = "0x18A7A1360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1820", Offset = "0xA7A0820", VA = "0x18A7A1820", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1760", Offset = "0xA7A0760", VA = "0x18A7A1760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1760", Offset = "0xA7A0760", VA = "0x18A7A1760", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7210", Offset = "0xA7A6210", VA = "0x18A7A7210")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x84B9F70", Offset = "0x84B8F70", VA = "0x1884B9F70")]
		public VertexColor2Texture4(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A72A0", Offset = "0xA7A62A0", VA = "0x18A7A72A0")]
		public VertexColor2Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7A70B0", Offset = "0xA7A60B0", VA = "0x18A7A70B0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6EC0", Offset = "0xA7A5EC0", VA = "0x18A7A6EC0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6D60", Offset = "0xA7A5D60", VA = "0x18A7A6D60", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6E20", Offset = "0xA7A5E20", VA = "0x18A7A6E20", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7610", Offset = "0xA7A6610", VA = "0x18A7A7610")]
		public static bool operator ==([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7620", Offset = "0xA7A6620", VA = "0x18A7A7620")]
		public static bool operator !=([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6C00", Offset = "0xA7A5C00", VA = "0x18A7A6C00")]
		public static bool AreEqual([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7140", Offset = "0xA7A6140", VA = "0x18A7A7140", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6A10", Offset = "0xA7A5A10", VA = "0x18A7A6A10")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A5010", Offset = "0xA7A4010", VA = "0x18A7A5010", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7080", Offset = "0xA7A6080", VA = "0x18A7A7080", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6E40", Offset = "0xA7A5E40", VA = "0x18A7A6E40", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6FA0", Offset = "0xA7A5FA0", VA = "0x18A7A6FA0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7070", Offset = "0xA7A6070", VA = "0x18A7A7070", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C7D50", Offset = "0x86C6D50", VA = "0x1886C7D50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x86C7CD0", Offset = "0x86C6CD0", VA = "0x1886C7CD0")]
		public void Append(VertexGeometryPreprocessor<TvG> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x86C7C50", Offset = "0x86C6C50", VA = "0x1886C7C50")]
		public void Append(VertexMaterialPreprocessor<TvM> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x86C7BD0", Offset = "0x86C6BD0", VA = "0x1886C7BD0")]
		public void Append(VertexSkinningPreprocessor<TvS> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x86CC940", Offset = "0x86CB940", VA = "0x1886CC940")]
		public void SetValidationPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x86CAEC0", Offset = "0x86C9EC0", VA = "0x1886CAEC0")]
		public void SetSanitizerPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x86C9180", Offset = "0x86C8180", VA = "0x1886C9180")]
		public bool PreprocessVertex(VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x86CCE00", Offset = "0x86CBE00", VA = "0x1886CCE00")]
		public VertexPreprocessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class VertexPreprocessorLambdas
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x40AE600", Offset = "0x40AD600", VA = "0x1840AE600")]
		public static TvG? ValidateVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x40B0C90", Offset = "0x40AFC90", VA = "0x1840B0C90")]
		public static TvM? ValidateVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x40B4970", Offset = "0x40B3970", VA = "0x1840B4970")]
		public static TvS? ValidateVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x40A9710", Offset = "0x40A8710", VA = "0x1840A9710")]
		public static TvG? SanitizeVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x40AB930", Offset = "0x40AA930", VA = "0x1840AB930")]
		public static TvM? SanitizeVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x40ADBD0", Offset = "0x40ACBD0", VA = "0x1840ADBD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA79EC80", Offset = "0xA79DC80", VA = "0x18A79EC80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xA79E170", Offset = "0xA79D170", VA = "0x18A79E170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xA79EA80", Offset = "0xA79DA80", VA = "0x18A79EA80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xA79E7E0", Offset = "0xA79D7E0", VA = "0x18A79E7E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xA79E7E0", Offset = "0xA79D7E0", VA = "0x18A79E7E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD64890", Offset = "0xD63890", VA = "0x180D64890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A8250", Offset = "0xA7A7250", VA = "0x18A7A8250", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA7A94E0", Offset = "0xA7A84E0", VA = "0x18A7A94E0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9730", Offset = "0xA7A8730", VA = "0x18A7A9730")]
		public VertexJoints4(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9790", Offset = "0xA7A8790", VA = "0x18A7A9790")]
		public VertexJoints4(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9560", Offset = "0xA7A8560", VA = "0x18A7A9560")]
		public VertexJoints4([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9470", Offset = "0xA7A8470", VA = "0x18A7A9470", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4770", Offset = "0xA7A3770", VA = "0x18A7A4770", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9170", Offset = "0xA7A8170", VA = "0x18A7A9170", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9150", Offset = "0xA7A8150", VA = "0x18A7A9150", Slot = "14")]
		public readonly bool Equals(VertexJoints4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9800", Offset = "0xA7A8800", VA = "0x18A7A9800")]
		public static bool operator ==([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9810", Offset = "0xA7A8810", VA = "0x18A7A9810")]
		public static bool operator !=([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA7A90E0", Offset = "0xA7A80E0", VA = "0x18A7A90E0")]
		public static bool AreEqual([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9350", Offset = "0xA7A8350", VA = "0x18A7A9350", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9430", Offset = "0xA7A8430", VA = "0x18A7A9430")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A93A0", Offset = "0xA7A83A0", VA = "0x18A7A93A0", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9270", Offset = "0xA7A8270", VA = "0x18A7A9270", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9430", Offset = "0xA7A8430", VA = "0x18A7A9430", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7A1270", Offset = "0xA7A0270", VA = "0x18A7A1270", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0800", Offset = "0xA79F800", VA = "0x18A7A0800", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1160", Offset = "0xA7A0160", VA = "0x18A7A1160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0E40", Offset = "0xA79FE40", VA = "0x18A7A0E40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xA7A0E40", Offset = "0xA79FE40", VA = "0x18A7A0E40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF22F30", Offset = "0xF21F30", VA = "0x180F22F30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xED7510", Offset = "0xED6510", VA = "0x180ED7510", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xF71A20", Offset = "0xF70A20", VA = "0x180F71A20", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9DA0", Offset = "0xA7A8DA0", VA = "0x18A7A9DA0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA1C0", Offset = "0xA7A91C0", VA = "0x18A7AA1C0")]
		public VertexJoints8(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA240", Offset = "0xA7A9240", VA = "0x18A7AA240")]
		public VertexJoints8(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9E30", Offset = "0xA7A8E30", VA = "0x18A7A9E30")]
		public VertexJoints8([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9D10", Offset = "0xA7A8D10", VA = "0x18A7A9D10", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4770", Offset = "0xA7A3770", VA = "0x18A7A4770", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9920", Offset = "0xA7A8920", VA = "0x18A7A9920", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9900", Offset = "0xA7A8900", VA = "0x18A7A9900", Slot = "14")]
		public readonly bool Equals(VertexJoints8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA2B0", Offset = "0xA7A92B0", VA = "0x18A7AA2B0")]
		public static bool operator ==([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA2C0", Offset = "0xA7A92C0", VA = "0x18A7AA2C0")]
		public static bool operator !=([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9830", Offset = "0xA7A8830", VA = "0x18A7A9830")]
		public static bool AreEqual([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9BA0", Offset = "0xA7A8BA0", VA = "0x18A7A9BA0", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9C00", Offset = "0xA7A8C00", VA = "0x18A7A9C00")]
		public void SetBindings([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9C60", Offset = "0xA7A8C60", VA = "0x18A7A9C60", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA7A99E0", Offset = "0xA7A89E0", VA = "0x18A7A99E0", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9C00", Offset = "0xA7A8C00", VA = "0x18A7A9C00", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C4DF0", Offset = "0x40C3DF0", VA = "0x1840C4DF0")]
		public static MemoryAccessor CreateVertexMemoryAccessor<TVertex>(this IReadOnlyList<TVertex> vertices, string attributeName, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x40C5980", Offset = "0x40C4980", VA = "0x1840C5980")]
		public static MemoryAccessor[] CreateVertexMemoryAccessors<TVertex>(this IReadOnlyList<TVertex> vertices, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x40C7070", Offset = "0x40C6070", VA = "0x1840C7070")]
		private static void FillAccessor<TVertex>(this MemoryAccessor dstAccessor, IReadOnlyList<TVertex> srcVertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0270", Offset = "0xA7AF270", VA = "0x18A7B0270")]
		public static MemoryAccessor CreateIndexMemoryAccessor(this IReadOnlyList<int> indices, EncodingType indexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0560", Offset = "0xA7AF560", VA = "0x18A7B0560")]
		public static MemoryAccessInfo[] GetVertexAttributes(this IVertexBuilder firstVertex, int vertexCount, PackedEncoding vertexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA7BBCC0", Offset = "0xA7BACC0", VA = "0x18A7BBCC0")]
		private static Converter<IVertexBuilder, object> _GetVertexBuilderAttributeFunc(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA7BD2D0", Offset = "0xA7BC2D0", VA = "0x18A7BD2D0")]
		private static object _GetVertexBuilderCustomAttributeFunc(IVertexMaterial vertex, string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x40C90D0", Offset = "0x40C80D0", VA = "0x1840C90D0")]
		private static TColumn[] _GetColumn<TColumn, TVertex>(this IReadOnlyList<TVertex> vertices, Converter<IVertexBuilder, object> func) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA7BAD80", Offset = "0xA7B9D80", VA = "0x18A7BAD80")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(params string[] vertexAttributes)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x40BDB00", Offset = "0x40BCB00", VA = "0x1840BDB00")]
		public static TvP ConvertToGeometry<TvP>(this IVertexGeometry src) where TvP : struct, IVertexGeometry
		{
			return (TvP)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x40C0650", Offset = "0x40BF650", VA = "0x1840C0650")]
		public static TvM ConvertToMaterial<TvM>(this IVertexMaterial src) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x40C4160", Offset = "0x40C3160", VA = "0x1840C4160")]
		public static TvS ConvertToSkinning<TvS>(this IVertexSkinning src) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1300", Offset = "0xA7B0300", VA = "0x18A7B1300")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA7BB3F0", Offset = "0xA7BA3F0", VA = "0x18A7BB3F0")]
		public static string _GetDebuggerDisplay(IVertexGeometry geo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA7BB6D0", Offset = "0xA7BA6D0", VA = "0x18A7BB6D0")]
		public static string _GetDebuggerDisplay(IVertexMaterial mat)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA7BBA80", Offset = "0xA7BAA80", VA = "0x18A7BBA80")]
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
			[Cpp2IlInjected.Address(RVA = "0x515F000", Offset = "0x515E000", VA = "0x18515F000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x515EE50", Offset = "0x515DE50", VA = "0x18515EE50")]
		public _CurveBuilderDebugProxy(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x515DF50", Offset = "0x515CF50", VA = "0x18515DF50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7C4B60", Offset = "0xA7C3B60", VA = "0x18A7C4B60")]
		public _CurveBuilderDebugProxyBoolean(CurveBuilder<bool> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4B20", Offset = "0xA7C3B20", VA = "0x18A7C4B20", Slot = "4")]
		protected override bool GetTangent(bool a, bool b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal sealed class _CurveBuilderDebugProxyVector3 : _CurveBuilderDebugProxy<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4CC0", Offset = "0xA7C3CC0", VA = "0x18A7C4CC0")]
		public _CurveBuilderDebugProxyVector3(CurveBuilder<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4C50", Offset = "0xA7C3C50", VA = "0x18A7C4C50", Slot = "4")]
		protected override Vector3 GetTangent(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	internal sealed class _CurveBuilderDebugProxyQuaternion : _CurveBuilderDebugProxy<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4BB0", Offset = "0xA7C3BB0", VA = "0x18A7C4BB0")]
		public _CurveBuilderDebugProxyQuaternion(CurveBuilder<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE090", Offset = "0xA7BD090", VA = "0x18A7BE090", Slot = "4")]
		protected override Quaternion GetTangent(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	internal sealed class _CurveBuilderDebugProxySparse : _CurveBuilderDebugProxy<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4C00", Offset = "0xA7C3C00", VA = "0x18A7C4C00")]
		public _CurveBuilderDebugProxySparse(CurveBuilder<SparseWeight8> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA7BED20", Offset = "0xA7BDD20", VA = "0x18A7BED20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x66ED4F0", Offset = "0x66EC4F0", VA = "0x1866ED4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0x10106A0", Offset = "0x100F6A0", VA = "0x1810106A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x10106A0", Offset = "0x100F6A0", VA = "0x1810106A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B6A330", Offset = "0x5B69330", VA = "0x185B6A330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public TValue this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x5B6A460", Offset = "0x5B69460", VA = "0x185B6A460", Slot = "6")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x5B6A4A0", Offset = "0x5B694A0", VA = "0x185B6A4A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<TValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x5B6A4F0", Offset = "0x5B694F0", VA = "0x185B6A4F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x5724EA0", Offset = "0x5723EA0", VA = "0x185724EA0")]
		static EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5B6A2F0", Offset = "0x5B692F0", VA = "0x185B6A2F0", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5B6A1C0", Offset = "0x5B691C0", VA = "0x185B6A1C0", Slot = "10")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<GetEnumerator>d__15))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x5B6A290", Offset = "0x5B69290", VA = "0x185B6A290", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x4EE3450", Offset = "0x4EE2450", VA = "0x184EE3450", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4F215C0", Offset = "0x4F205C0", VA = "0x184F215C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5088B20", Offset = "0x5087B20", VA = "0x185088B20")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x6714660", Offset = "0x6713660", VA = "0x186714660", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x67142B0", Offset = "0x67132B0", VA = "0x1867142B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x650C1D0", Offset = "0x650B1D0", VA = "0x18650C1D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x650C1D0", Offset = "0x650B1D0", VA = "0x18650C1D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5088B20", Offset = "0x5087B20", VA = "0x185088B20")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x6714660", Offset = "0x6713660", VA = "0x186714660", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x6F459D0", Offset = "0x6F449D0", VA = "0x186F459D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x7E93590", Offset = "0x7E92590", VA = "0x187E93590", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7E93800", Offset = "0x7E92800", VA = "0x187E93800")]
		public static implicit operator Triple<T>([In] (T A, T B, T C) triple)
		{
			return default(Triple<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x7E93360", Offset = "0x7E92360", VA = "0x187E93360")]
		public Triple(T a, T b, T c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7E92B30", Offset = "0x7E91B30", VA = "0x187E92B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x7E92880", Offset = "0x7E91880", VA = "0x187E92880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7E92240", Offset = "0x7E91240", VA = "0x187E92240", Slot = "8")]
		public bool Equals(Triple<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7E93710", Offset = "0x7E92710", VA = "0x187E93710")]
		public static bool operator ==([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x7E93B40", Offset = "0x7E92B40", VA = "0x187E93B40")]
		public static bool operator !=([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x7E929C0", Offset = "0x7E919C0", VA = "0x187E929C0", Slot = "6")]
		[IteratorStateMachine(typeof(Triple<>.<GetEnumerator>d__14))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7E931F0", Offset = "0x7E921F0", VA = "0x187E931F0", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0x516FAF0", Offset = "0x516EAF0", VA = "0x18516FAF0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A60")]
				[Cpp2IlInjected.Address(RVA = "0x516F3A0", Offset = "0x516E3A0", VA = "0x18516F3A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x516F930", Offset = "0x516E930", VA = "0x18516F930")]
			internal _ValueEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x516E440", Offset = "0x516D440", VA = "0x18516E440", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x516F020", Offset = "0x516E020", VA = "0x18516F020", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			public _IndexCollection(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x5163010", Offset = "0x5162010", VA = "0x185163010", Slot = "4")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x5163010", Offset = "0x5162010", VA = "0x185163010", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A69")]
				[Cpp2IlInjected.Address(RVA = "0x24190F0", Offset = "0x24180F0", VA = "0x1824190F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x5164970", Offset = "0x5163970", VA = "0x185164970")]
			internal _IndexEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x5163BF0", Offset = "0x5162BF0", VA = "0x185163BF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x51648F0", Offset = "0x51638F0", VA = "0x1851648F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x80D22F0", Offset = "0x80D12F0", VA = "0x1880D22F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public IEnumerable<int> Indices
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x80D2190", Offset = "0x80D1190", VA = "0x1880D2190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x80D1FB0", Offset = "0x80D0FB0", VA = "0x1880D1FB0")]
		public ValueListSet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x80D1DD0", Offset = "0x80D0DD0", VA = "0x1880D1DD0")]
		public ValueListSet(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x80CFA60", Offset = "0x80CEA60", VA = "0x1880CFA60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x80D0720", Offset = "0x80CF720", VA = "0x1880D0720")]
		public bool Exists(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x80D0910", Offset = "0x80CF910", VA = "0x1880D0910")]
		public int IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x80D0970", Offset = "0x80CF970", VA = "0x1880D0970")]
		public int Use([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x80CF730", Offset = "0x80CE730", VA = "0x1880CF730")]
		public int Add([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x80CFCE0", Offset = "0x80CECE0", VA = "0x1880CFCE0")]
		public bool Contains([In] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x80D04A0", Offset = "0x80CF4A0", VA = "0x1880D04A0")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x80D00F0", Offset = "0x80CF0F0", VA = "0x1880D00F0")]
		public void CopyTo(ValueListSet<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x80D07C0", Offset = "0x80CF7C0", VA = "0x1880D07C0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x80D07C0", Offset = "0x80CF7C0", VA = "0x1880D07C0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x80CF7E0", Offset = "0x80CE7E0", VA = "0x1880CF7E0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x80D11A0", Offset = "0x80D01A0", VA = "0x1880D11A0")]
		private void _Initialize(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x80D0B50", Offset = "0x80CFB50", VA = "0x1880D0B50")]
		private int _IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x80D1580", Offset = "0x80D0580", VA = "0x1880D1580")]
		private int _Insert([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x80D0A50", Offset = "0x80CFA50", VA = "0x1880D0A50")]
		private void _Grow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x80D1810", Offset = "0x80D0810", VA = "0x1880D1810")]
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
				[Cpp2IlInjected.Address(RVA = "0x51655B0", Offset = "0x51645B0", VA = "0x1851655B0")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x5165660", Offset = "0x5164660", VA = "0x185165660")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x5165540", Offset = "0x5164540", VA = "0x185165540")]
			public _KeyComparer(IReadOnlyList<T> items)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x5164FF0", Offset = "0x5163FF0", VA = "0x185164FF0", Slot = "4")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x5165320", Offset = "0x5164320", VA = "0x185165320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86C6B90", Offset = "0x86C5B90", VA = "0x1886C6B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0x86C6B50", Offset = "0x86C5B50", VA = "0x1886C6B50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x86C6A00", Offset = "0x86C5A00", VA = "0x1886C6A00")]
		public VertexList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x86C6440", Offset = "0x86C5440", VA = "0x1886C6440", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x86C6440", Offset = "0x86C5440", VA = "0x1886C6440", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x86C66D0", Offset = "0x86C56D0", VA = "0x1886C66D0")]
		public int Use([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x86C64F0", Offset = "0x86C54F0", VA = "0x1886C64F0")]
		public int IndexOf([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x86C6750", Offset = "0x86C5750", VA = "0x1886C6750")]
		private int _Add([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x86C61D0", Offset = "0x86C51D0", VA = "0x1886C61D0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x86C6400", Offset = "0x86C5400", VA = "0x1886C6400")]
		public void CopyTo(VertexList<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x86C6890", Offset = "0x86C5890", VA = "0x1886C6890")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7C5020", Offset = "0xA7C4020", VA = "0x18A7C5020")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4E00", Offset = "0xA7C3E00", VA = "0x18A7C4E00")]
		public static int GetPrime(int min)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4D90", Offset = "0xA7C3D90", VA = "0x18A7C4D90")]
		public static int GetMinPrime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4D10", Offset = "0xA7C3D10", VA = "0x18A7C4D10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xF56C40", Offset = "0xF55C40", VA = "0x180F56C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x74D9FA0", Offset = "0x74D8FA0", VA = "0x1874D9FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public IReadOnlyDictionary<string, ICurveSampler<T>> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x74DA1A0", Offset = "0x74D91A0", VA = "0x1874DA1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		internal AnimatableProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x74D9CE0", Offset = "0x74D8CE0", VA = "0x1874D9CE0")]
		internal AnimatableProperty(AnimatableProperty<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x74CFA60", Offset = "0x74CEA60", VA = "0x1874CFA60")]
		public AnimatableProperty<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x74D0B20", Offset = "0x74CFB20", VA = "0x1874D0B20")]
		public void RemoveTrack(string track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x74CFD70", Offset = "0x74CED70", VA = "0x1874CFD70")]
		public T GetValueAt(string track, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x74D3820", Offset = "0x74D2820", VA = "0x1874D3820")]
		public void SetTrack(string track, ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x74D4D20", Offset = "0x74D3D20", VA = "0x1874D4D20")]
		public CurveBuilder<T> UseTrackBuilder(string track)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x74D43B0", Offset = "0x74D33B0", VA = "0x1874D43B0")]
		public void SetValue(params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x74D5380", Offset = "0x74D4380", VA = "0x1874D5380")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
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
			[Cpp2IlInjected.Address(RVA = "0x539C540", Offset = "0x539B540", VA = "0x18539C540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x539C7A0", Offset = "0x539B7A0", VA = "0x18539C7A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x539BDA0", Offset = "0x539ADA0", VA = "0x18539BDA0")]
		protected CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x539BA30", Offset = "0x539AA30", VA = "0x18539BA30")]
		protected CurveBuilder(CurveBuilder<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5388EE0", Offset = "0x5387EE0", VA = "0x185388EE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x5389BC0", Offset = "0x5388BC0", VA = "0x185389BC0")]
		public void RemoveKey(float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x5392FD0", Offset = "0x5391FD0", VA = "0x185392FD0")]
		public void SetPoint(float offset, bool isLinear, params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x5392AC0", Offset = "0x5391AC0", VA = "0x185392AC0")]
		public void SetPoint(float offset, T value, bool isLinear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x538FB40", Offset = "0x538EB40", VA = "0x18538FB40")]
		public void SetIncomingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x5392190", Offset = "0x5391190", VA = "0x185392190")]
		public void SetOutgoingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x5388F10", Offset = "0x5387F10", VA = "0x185388F10")]
		private protected (_CurveNode<T>, _CurveNode<T>, float) FindSample(float offset)
		{
			return default((_CurveNode<T>, _CurveNode<T>, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x538ABA0", Offset = "0x5389BA0", VA = "0x18538ABA0")]
		public void SetCurve(ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x538A3A0", Offset = "0x53893A0", VA = "0x18538A3A0")]
		public void SetCurve(IConvertibleCurve<T> convertible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x538D440", Offset = "0x538C440", VA = "0x18538D440")]
		public void SetCurve(IAnimationSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x539AEB0", Offset = "0x5399EB0", VA = "0x18539AEB0")]
		public CurveBuilder<T> WithPoint(float offset, T value, bool isLinear = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x539A850", Offset = "0x5399850", VA = "0x18539A850")]
		public CurveBuilder<T> WithIncomingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x539ABC0", Offset = "0x5399BC0", VA = "0x18539ABC0")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x539AD60", Offset = "0x5399D60", VA = "0x18539AD60")]
		public CurveBuilder<T> WithPoint(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x539AB30", Offset = "0x5399B30", VA = "0x18539AB30")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x539A890", Offset = "0x5399890", VA = "0x18539A890")]
		public CurveBuilder<T> WithIncomingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x5399F80", Offset = "0x5398F80", VA = "0x185399F80", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x5393C20", Offset = "0x5392C20", VA = "0x185393C20", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x5395EF0", Offset = "0x5394EF0", VA = "0x185395EF0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x5160660", Offset = "0x515F660", VA = "0x185160660")]
		private string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x5162580", Offset = "0x5161580", VA = "0x185162580")]
		private static string _ToString(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x5162CF0", Offset = "0x5161CF0", VA = "0x185162CF0")]
		public _CurveNode(T value, bool isLinear)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x51629A0", Offset = "0x51619A0", VA = "0x1851629A0")]
		public _CurveNode(T incoming, T value, T outgoing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x515F180", Offset = "0x515E180", VA = "0x18515F180")]
		public _CurveNode<T> Clone(Func<T, T> cloneValue)
		{
			return default(_CurveNode<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal static class CurveFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x38DF250", Offset = "0x38DE250", VA = "0x1838DF250")]
		public static CurveBuilder<T> CreateCurveBuilder<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x38DF6B0", Offset = "0x38DE6B0", VA = "0x1838DF6B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BDC20", Offset = "0xA7BCC20", VA = "0x18A7BDC20")]
		public BooleanCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDC60", Offset = "0xA7BCC60", VA = "0x18A7BDC60")]
		private BooleanCurveBuilder(BooleanCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA7BD980", Offset = "0xA7BC980", VA = "0x18A7BD980", Slot = "10")]
		public override CurveBuilder<bool> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6EA0", Offset = "0xA4F5EA0", VA = "0x18A4F6EA0", Slot = "11")]
		protected override bool AreEqual(bool left, bool right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x1416C40", Offset = "0x1415C40", VA = "0x181416C40", Slot = "12")]
		protected override bool CloneValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDA00", Offset = "0xA7BCA00", VA = "0x18A7BDA00", Slot = "13")]
		protected override bool CreateValue(IReadOnlyList<float> values)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDBE0", Offset = "0xA7BCBE0", VA = "0x18A7BDBE0", Slot = "15")]
		protected override bool GetTangent(bool fromValue, bool toValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDB20", Offset = "0xA7BCB20", VA = "0x18A7BDB20", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7C4AE0", Offset = "0xA7C3AE0", VA = "0x18A7C4AE0")]
		public Vector3CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4A90", Offset = "0xA7C3A90", VA = "0x18A7C4A90")]
		private Vector3CurveBuilder(Vector3CurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4670", Offset = "0xA7C3670", VA = "0x18A7C4670", Slot = "10")]
		public override CurveBuilder<Vector3> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4620", Offset = "0xA7C3620", VA = "0x18A7C4620", Slot = "11")]
		protected override bool AreEqual(Vector3 left, Vector3 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1049510", Offset = "0x1048510", VA = "0x181049510", Slot = "12")]
		protected override Vector3 CloneValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xA7C46F0", Offset = "0xA7C36F0", VA = "0x18A7C46F0", Slot = "13")]
		protected override Vector3 CreateValue(IReadOnlyList<float> values)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4A20", Offset = "0xA7C3A20", VA = "0x18A7C4A20", Slot = "15")]
		protected override Vector3 GetTangent(Vector3 fromValue, Vector3 toValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4870", Offset = "0xA7C3870", VA = "0x18A7C4870", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BE0E0", Offset = "0xA7BD0E0", VA = "0x18A7BE0E0")]
		public QuaternionCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE120", Offset = "0xA7BD120", VA = "0x18A7BE120")]
		private QuaternionCurveBuilder(QuaternionCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDCE0", Offset = "0xA7BCCE0", VA = "0x18A7BDCE0", Slot = "10")]
		public override CurveBuilder<Quaternion> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDCB0", Offset = "0xA7BCCB0", VA = "0x18A7BDCB0", Slot = "11")]
		protected override bool AreEqual(Quaternion left, Quaternion right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x12B0130", Offset = "0x12AF130", VA = "0x1812B0130", Slot = "12")]
		protected override Quaternion CloneValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDD60", Offset = "0xA7BCD60", VA = "0x18A7BDD60", Slot = "13")]
		protected override Quaternion CreateValue(IReadOnlyList<float> values)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE090", Offset = "0xA7BD090", VA = "0x18A7BE090", Slot = "15")]
		protected override Quaternion GetTangent(Quaternion fromValue, Quaternion toValue)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA7BDF10", Offset = "0xA7BCF10", VA = "0x18A7BDF10", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BEDB0", Offset = "0xA7BDDB0", VA = "0x18A7BEDB0")]
		public SparseCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA7BED60", Offset = "0xA7BDD60", VA = "0x18A7BED60")]
		private SparseCurveBuilder(SparseCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEA50", Offset = "0xA7BDA50", VA = "0x18A7BEA50", Slot = "10")]
		public override CurveBuilder<SparseWeight8> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEA10", Offset = "0xA7BDA10", VA = "0x18A7BEA10", Slot = "11")]
		protected override bool AreEqual(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x5718960", Offset = "0x5717960", VA = "0x185718960", Slot = "12")]
		protected override SparseWeight8 CloneValue(SparseWeight8 value)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEAD0", Offset = "0xA7BDAD0", VA = "0x18A7BEAD0", Slot = "13")]
		protected override SparseWeight8 CreateValue(IReadOnlyList<float> values)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xA7BED20", Offset = "0xA7BDD20", VA = "0x18A7BED20", Slot = "15")]
		protected override SparseWeight8 GetTangent(SparseWeight8 fromValue, SparseWeight8 toValue)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEB10", Offset = "0xA7BDB10", VA = "0x18A7BEB10", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BE9D0", Offset = "0xA7BD9D0", VA = "0x18A7BE9D0")]
		public SegmentCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE980", Offset = "0xA7BD980", VA = "0x18A7BE980")]
		private SegmentCurveBuilder(SegmentCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE4C0", Offset = "0xA7BD4C0", VA = "0x18A7BE4C0", Slot = "10")]
		public override CurveBuilder<ArraySegment<float>> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE170", Offset = "0xA7BD170", VA = "0x18A7BE170", Slot = "11")]
		protected override bool AreEqual(ArraySegment<float> left, ArraySegment<float> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE3B0", Offset = "0xA7BD3B0", VA = "0x18A7BE3B0", Slot = "12")]
		protected override ArraySegment<float> CloneValue(ArraySegment<float> value)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE540", Offset = "0xA7BD540", VA = "0x18A7BE540", Slot = "13")]
		protected override ArraySegment<float> CreateValue(IReadOnlyList<float> values)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE8D0", Offset = "0xA7BD8D0", VA = "0x18A7BE8D0", Slot = "15")]
		protected override ArraySegment<float> GetTangent(ArraySegment<float> fromValue, ArraySegment<float> toValue)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE680", Offset = "0xA7BD680", VA = "0x18A7BE680", Slot = "14")]
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

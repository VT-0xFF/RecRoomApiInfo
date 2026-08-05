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
	public abstract class BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected BaseBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		protected BaseBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		protected BaseBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA79F300", Offset = "0xA79E300", VA = "0x18A79F300")]
		protected BaseBuilder(BaseBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA79F110", Offset = "0xA79E110", VA = "0x18A79F110")]
		protected static int GetContentHashCode(BaseBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA79F000", Offset = "0xA79E000", VA = "0x18A79F000")]
		protected static bool AreEqualByContent(BaseBuilder x, BaseBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA79F220", Offset = "0xA79E220", VA = "0x18A79F220")]
		internal void SetNameAndExtrasFrom(BaseBuilder source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA79F1A0", Offset = "0xA79E1A0", VA = "0x18A79F1A0")]
		internal void SetNameAndExtrasFrom(LogicalChildOfRoot source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA79F2A0", Offset = "0xA79E2A0", VA = "0x18A79F2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7A0FA0", Offset = "0xA79FFA0", VA = "0x18A7A0FA0")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA79FF70", Offset = "0xA79EF70", VA = "0x18A79FF70")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA7A01E0", Offset = "0xA79F1E0", VA = "0x18A7A01E0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0430", Offset = "0xA79F430", VA = "0x18A7A0430")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA79FED0", Offset = "0xA79EED0", VA = "0x18A79FED0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0C20", Offset = "0xA79FC20", VA = "0x18A7A0C20")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0B00", Offset = "0xA79FB00", VA = "0x18A7A0B00")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA7A10F0", Offset = "0xA7A00F0", VA = "0x18A7A10F0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1090", Offset = "0xA7A0090", VA = "0x18A7A1090")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0940", Offset = "0xA79F940", VA = "0x18A7A0940")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B028B0", Offset = "0x3B018B0", VA = "0x183B028B0")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B00F90", Offset = "0x3AFFF90", VA = "0x183B00F90")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A09A0", Offset = "0xA79F9A0", VA = "0x18A7A09A0")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B02450", Offset = "0x3B01450", VA = "0x183B02450")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B01FF0", Offset = "0x3B00FF0", VA = "0x183B01FF0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3B01BB0", Offset = "0x3B00BB0", VA = "0x183B01BB0")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B018B0", Offset = "0x3B008B0", VA = "0x183B018B0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B00BB0", Offset = "0x3AFFBB0", VA = "0x183B00BB0")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0530", Offset = "0xA79F530", VA = "0x18A7A0530")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA7A04D0", Offset = "0xA79F4D0", VA = "0x18A7A04D0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0590", Offset = "0xA79F590", VA = "0x18A7A0590")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0E40", Offset = "0xA79FE40", VA = "0x18A7A0E40")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA7A0D40", Offset = "0xA79FD40", VA = "0x18A7A0D40")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B002C0", Offset = "0x3AFF2C0", VA = "0x183B002C0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA79FC40", Offset = "0xA79EC40", VA = "0x18A79FC40")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF570", Offset = "0x3AFE570", VA = "0x183AFF570")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEAE0", Offset = "0x3AFDAE0", VA = "0x183AFEAE0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEAE0", Offset = "0x3AFDAE0", VA = "0x183AFEAE0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEAE0", Offset = "0x3AFDAE0", VA = "0x183AFEAE0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEAE0", Offset = "0x3AFDAE0", VA = "0x183AFEAE0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDEF0", Offset = "0x3AFCEF0", VA = "0x183AFDEF0")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x675E2E0", Offset = "0x675D2E0", VA = "0x18675E2E0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x675C530", Offset = "0x675B530", VA = "0x18675C530", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x675E910", Offset = "0x675D910", VA = "0x18675E910")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6F54740", Offset = "0x6F53740", VA = "0x186F54740", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6F50C10", Offset = "0x6F4FC10", VA = "0x186F50C10", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6F54C40", Offset = "0x6F53C40", VA = "0x186F54C40")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51AF230", Offset = "0x51AE230", VA = "0x1851AF230", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x51AEDB0", Offset = "0x51ADDB0", VA = "0x1851AEDB0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x51AEA40", Offset = "0x51ADA40", VA = "0x1851AEA40", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x51AED00", Offset = "0x51ADD00", VA = "0x1851AED00", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6758A90", Offset = "0x6757A90", VA = "0x186758A90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x67570F0", Offset = "0x67560F0", VA = "0x1867570F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x6758E20", Offset = "0x6757E20", VA = "0x186758E20")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B570", Offset = "0x6F4A570", VA = "0x186F4B570", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B1F0", Offset = "0x6F4A1F0", VA = "0x186F4B1F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B990", Offset = "0x6F4A990", VA = "0x186F4B990")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51A5B50", Offset = "0x51A4B50", VA = "0x1851A5B50", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x51A57E0", Offset = "0x51A47E0", VA = "0x1851A57E0", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x51A59C0", Offset = "0x51A49C0", VA = "0x1851A59C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x1414B90", Offset = "0x1413B90", VA = "0x181414B90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BD6D0", Offset = "0xA7BC6D0", VA = "0x18A7BD6D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD720", Offset = "0xA7BC720", VA = "0x18A7BD720", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD380", Offset = "0xA7BC380", VA = "0x18A7BD380", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD7E0", Offset = "0xA7BC7E0", VA = "0x18A7BD7E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD690", Offset = "0xA7BC690", VA = "0x18A7BD690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD5E0", Offset = "0xA7BC5E0", VA = "0x18A7BD5E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD5E0", Offset = "0xA7BC5E0", VA = "0x18A7BD5E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A191E0", Offset = "0x1A181E0", VA = "0x181A191E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BE1C0", Offset = "0xA7BD1C0", VA = "0x18A7BE1C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE210", Offset = "0xA7BD210", VA = "0x18A7BE210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD830", Offset = "0xA7BC830", VA = "0x18A7BD830", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE400", Offset = "0xA7BD400", VA = "0x18A7BE400")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE450", Offset = "0xA7BD450", VA = "0x18A7BE450")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE4A0", Offset = "0xA7BD4A0", VA = "0x18A7BE4A0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE180", Offset = "0xA7BD180", VA = "0x18A7BE180", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE0D0", Offset = "0xA7BD0D0", VA = "0x18A7BE0D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA7BE0D0", Offset = "0xA7BD0D0", VA = "0x18A7BE0D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6E5DA0", Offset = "0xA6E4DA0", VA = "0x18A6E5DA0")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7770", Offset = "0xA6E6770", VA = "0x18A6E7770")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78A0", Offset = "0xA6E68A0", VA = "0x18A6E78A0")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E77B0", Offset = "0xA6E67B0", VA = "0x18A6E77B0")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78D0", Offset = "0xA6E68D0", VA = "0x18A6E78D0")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7940", Offset = "0xA6E6940", VA = "0x18A6E7940")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6E76A0", Offset = "0xA6E66A0", VA = "0x18A6E76A0")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0340", Offset = "0xA7BF340", VA = "0x18A7C0340")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0220", Offset = "0xA7BF220", VA = "0x18A7C0220")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5140", Offset = "0xA6E4140", VA = "0x18A6E5140")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0BC0", Offset = "0xA7BFBC0", VA = "0x18A7C0BC0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5D50", Offset = "0xA6E4D50", VA = "0x18A6E5D50")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5CF0", Offset = "0xA6E4CF0", VA = "0x18A6E5CF0")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5FD0", Offset = "0xA6E4FD0", VA = "0x18A6E5FD0")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1760", Offset = "0xA7C0760", VA = "0x18A7C1760")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA7C18E0", Offset = "0xA7C08E0", VA = "0x18A7C18E0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0530", Offset = "0xA7BF530", VA = "0x18A7C0530")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0440", Offset = "0xA7BF440", VA = "0x18A7C0440")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0800", Offset = "0xA7BF800", VA = "0x18A7C0800")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0090", Offset = "0xA7BF090", VA = "0x18A7C0090")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA798D70", Offset = "0xA797D70", VA = "0x18A798D70")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E68A0", Offset = "0xA6E58A0", VA = "0x18A6E68A0")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA7C04C0", Offset = "0xA7BF4C0", VA = "0x18A7C04C0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5AC0", Offset = "0xA6E4AC0", VA = "0x18A6E5AC0")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5A00", Offset = "0xA6E4A00", VA = "0x18A6E5A00")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x415CE30", Offset = "0x415BE30", VA = "0x18415CE30")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6E52B0", Offset = "0xA6E42B0", VA = "0x18A6E52B0")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5420", Offset = "0xA6E4420", VA = "0x18A6E5420")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x415E7F0", Offset = "0x415D7F0", VA = "0x18415E7F0")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x415F2F0", Offset = "0x415E2F0", VA = "0x18415F2F0")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x415F4C0", Offset = "0x415E4C0", VA = "0x18415F4C0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x415F5A0", Offset = "0x415E5A0", VA = "0x18415F5A0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x415CE50", Offset = "0x415BE50", VA = "0x18415CE50")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x415E010", Offset = "0x415D010", VA = "0x18415E010")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x415DF00", Offset = "0x415CF00", VA = "0x18415DF00")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x415D640", Offset = "0x415C640", VA = "0x18415D640")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x415F210", Offset = "0x415E210", VA = "0x18415F210")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x415EB80", Offset = "0x415DB80", VA = "0x18415EB80")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x415F120", Offset = "0x415E120", VA = "0x18415F120")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x415ED20", Offset = "0x415DD20", VA = "0x18415ED20")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x415D4F0", Offset = "0x415C4F0", VA = "0x18415D4F0")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x415D090", Offset = "0x415C090", VA = "0x18415D090")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x415CAB0", Offset = "0x415BAB0", VA = "0x18415CAB0")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x415CEE0", Offset = "0x415BEE0", VA = "0x18415CEE0")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0600", Offset = "0xA7BF600", VA = "0x18A7C0600")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0960", Offset = "0xA7BF960", VA = "0x18A7C0960")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0E70", Offset = "0xA7BFE70", VA = "0x18A7C0E70")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF9F0", Offset = "0xA7BE9F0", VA = "0x18A7BF9F0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF940", Offset = "0xA7BE940", VA = "0x18A7BF940")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0DF0", Offset = "0xA7BFDF0", VA = "0x18A7C0DF0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1530", Offset = "0xA7C0530", VA = "0x18A7C1530")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFA70", Offset = "0xA7BEA70", VA = "0x18A7BFA70")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1460", Offset = "0xA7C0460", VA = "0x18A7C1460")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1070", Offset = "0xA7C0070", VA = "0x18A7C1070")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFDE0", Offset = "0xA7BEDE0", VA = "0x18A7BFDE0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFB30", Offset = "0xA7BEB30", VA = "0x18A7BFB30")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFF00", Offset = "0xA7BEF00", VA = "0x18A7BFF00")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFCC0", Offset = "0xA7BECC0", VA = "0x18A7BFCC0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFE80", Offset = "0xA7BEE80", VA = "0x18A7BFE80")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x239D950", Offset = "0x239C950", VA = "0x18239D950")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7790", Offset = "0xA6E6790", VA = "0x18A6E7790")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x415F7D0", Offset = "0x415E7D0", VA = "0x18415F7D0")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C0D30", Offset = "0xA7BFD30", VA = "0x18A7C0D30")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA7BFD40", Offset = "0xA7BED40", VA = "0x18A7BFD40")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C16B0", Offset = "0xA7C06B0", VA = "0x18A7C16B0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1AE0", Offset = "0xA7C0AE0", VA = "0x18A7C1AE0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C15B0", Offset = "0xA7C05B0", VA = "0x18A7C15B0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5350", Offset = "0xA6E4350", VA = "0x18A6E5350")]
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
		[Cpp2IlInjected.Address(RVA = "0x40F40A0", Offset = "0x40F30A0", VA = "0x1840F40A0")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF5D0", Offset = "0xA7BE5D0", VA = "0x18A7BF5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4105B30", Offset = "0x4104B30", VA = "0x184105B30")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF790", Offset = "0xA7BE790", VA = "0x18A7BF790")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BB760", Offset = "0xA7BA760", VA = "0x18A7BB760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <EvaluateLines>d__77(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB7B0", Offset = "0xA7BA7B0", VA = "0x18A7BB7B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB0B0", Offset = "0xA7BA0B0", VA = "0x18A7BB0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB980", Offset = "0xA7BA980", VA = "0x18A7BB980")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB9D0", Offset = "0xA7BA9D0", VA = "0x18A7BB9D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB720", Offset = "0xA7BA720", VA = "0x18A7BB720", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB670", Offset = "0xA7BA670", VA = "0x18A7BB670", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA7BB670", Offset = "0xA7BA670", VA = "0x18A7BB670", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BC010", Offset = "0xA7BB010", VA = "0x18A7BC010", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1D1DB60", Offset = "0x1D1CB60", VA = "0x181D1DB60")]
			[DebuggerHidden]
			public <EvaluatePoints>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC060", Offset = "0xA7BB060", VA = "0x18A7BC060", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA7BBA30", Offset = "0xA7BAA30", VA = "0x18A7BBA30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC260", Offset = "0xA7BB260", VA = "0x18A7BC260")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC2B0", Offset = "0xA7BB2B0", VA = "0x18A7BC2B0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA7BBFD0", Offset = "0xA7BAFD0", VA = "0x18A7BBFD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA7BBF20", Offset = "0xA7BAF20", VA = "0x18A7BBF20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA7BBF20", Offset = "0xA7BAF20", VA = "0x18A7BBF20", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5165E40", Offset = "0x5164E40", VA = "0x185165E40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7BCA30", Offset = "0xA7BBA30", VA = "0x18A7BCA30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x519A500", Offset = "0x5199500", VA = "0x18519A500")]
			[DebuggerHidden]
			public <EvaluateTriangles>d__79(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA7BCA80", Offset = "0xA7BBA80", VA = "0x18A7BCA80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC300", Offset = "0xA7BB300", VA = "0x18A7BC300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA7BCC60", Offset = "0xA7BBC60", VA = "0x18A7BCC60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA7BCCB0", Offset = "0xA7BBCB0", VA = "0x18A7BCCB0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC9F0", Offset = "0xA7BB9F0", VA = "0x18A7BC9F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC940", Offset = "0xA7BB940", VA = "0x18A7BC940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA7BC940", Offset = "0xA7BB940", VA = "0x18A7BC940", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1BE0", Offset = "0xA7B0BE0", VA = "0x18A7B1BE0")]
		public static Accessor CreateMorphTargetAccessor(this ModelRoot root, MemoryAccessor memAccessor, int sparsityPercent = 60)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1E40", Offset = "0xA7B0E40", VA = "0x18A7B1E40")]
		public static Accessor CreateVertexAccessor(this ModelRoot root, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F95610", Offset = "0x3F94610", VA = "0x183F95610")]
		public static BufferView CreateBufferView<T>(this ModelRoot root, IReadOnlyList<T> data) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3E20", Offset = "0xA7B2E20", VA = "0x18A7B3E20")]
		public static Animation UseAnimation(this ModelRoot root, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7F80", Offset = "0xA7B6F80", VA = "0x18A7B7F80")]
		public static Node WithScaleAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7B96D0", Offset = "0xA7B86D0", VA = "0x18A7B96D0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6D60", Offset = "0xA7B5D60", VA = "0x18A7B6D60")]
		public static Node WithMorphingAnimation(this Node node, string animationName, ICurveSampler<SparseWeight8> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F9C850", Offset = "0x3F9B850", VA = "0x183F9C850")]
		public static Node WithMorphingAnimation<T>(this Node node, string animationName, ICurveSampler<T> sampler) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7C40", Offset = "0xA7B6C40", VA = "0x18A7B7C40")]
		public static Node WithRotationAnimation(this Node node, string animationName, ICurveSampler<Quaternion> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA210", Offset = "0xA7B9210", VA = "0x18A7BA210")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, ICurveSampler<bool> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7B8190", Offset = "0xA7B7190", VA = "0x18A7B8190")]
		public static Node WithScaleAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA7B77B0", Offset = "0xA7B67B0", VA = "0x18A7B77B0")]
		public static Node WithRotationAnimation(this Node node, string animationName, params (float Key, Quaternion Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9370", Offset = "0xA7B8370", VA = "0x18A7B9370")]
		public static Node WithTranslationAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7E50", Offset = "0xA7B6E50", VA = "0x18A7B7E50")]
		public static Node WithScaleAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B10", Offset = "0xA7B6B10", VA = "0x18A7B7B10")]
		public static Node WithRotationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9240", Offset = "0xA7B8240", VA = "0x18A7B9240")]
		public static Node WithTranslationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA3B0", Offset = "0xA7B93B0", VA = "0x18A7BA3B0")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, IReadOnlyDictionary<float, bool> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9170", Offset = "0xA7B8170", VA = "0x18A7B9170")]
		public static PunctualLight WithSpotCone(this PunctualLight light, float innerConeAngle, float outerConeAngle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4A80", Offset = "0xA7B3A80", VA = "0x18A7B4A80")]
		public static PunctualLight WithColor(this PunctualLight light, Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4B90", Offset = "0xA7B3B90", VA = "0x18A7B4B90")]
		public static Material WithDefault(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4CA0", Offset = "0xA7B3CA0", VA = "0x18A7B4CA0")]
		public static Material WithDefault(this Material material, Vector4 diffuseColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4E80", Offset = "0xA7B3E80", VA = "0x18A7B4E80")]
		public static Material WithDoubleSide(this Material material, bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4470", Offset = "0xA7B3470", VA = "0x18A7B4470")]
		[Obsolete("don't use vector4 based parameter. Use WithChannelColor and WithChannelFactor instead.")]
		public static Material WithChannelParameter(this Material material, string channelName, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4180", Offset = "0xA7B3180", VA = "0x18A7B4180")]
		public static Material WithChannelColor(this Material material, string channelName, Vector4 color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA7B42F0", Offset = "0xA7B32F0", VA = "0x18A7B42F0")]
		public static Material WithChannelFactor(this Material material, string channelName, string paramName, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4790", Offset = "0xA7B3790", VA = "0x18A7B4790")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, string imageFilePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7B45E0", Offset = "0xA7B35E0", VA = "0x18A7B45E0")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, Image image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7B71D0", Offset = "0xA7B61D0", VA = "0x18A7B71D0")]
		public static Material WithPBRMetallicRoughness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7B72A0", Offset = "0xA7B62A0", VA = "0x18A7B72A0")]
		public static Material WithPBRMetallicRoughness(this Material material, Vector4 baseColor, string baseColorImageFilePath, [Optional] string metallicImageFilePath, float metallicFactor = 1f, float roughnessFactor = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7B75A0", Offset = "0xA7B65A0", VA = "0x18A7B75A0")]
		[Obsolete("SpecularGlossiness Extension has been declared deprecated by the Khronos Group. Use newer extensions instead.")]
		public static Material WithPBRSpecularGlossiness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7B98E0", Offset = "0xA7B88E0", VA = "0x18A7B98E0")]
		public static Material WithUnlit(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4060", Offset = "0xA7B3060", VA = "0x18A7B4060")]
		public static Image UseImageWithFile(this ModelRoot root, string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3F90", Offset = "0xA7B2F90", VA = "0x18A7B3F90")]
		public static Image UseImageWithContent(this ModelRoot root, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7B16D0", Offset = "0xA7B06D0", VA = "0x18A7B16D0")]
		public static Material CreateMaterial(this ModelRoot root, MaterialBuilder mb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7B34B0", Offset = "0xA7B24B0", VA = "0x18A7B34B0")]
		public static MaterialBuilder ToMaterialBuilder(this Material srcMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3AC0", Offset = "0xA7B2AC0", VA = "0x18A7B3AC0")]
		public static AlphaMode ToSchema2(this SharpGLTF.Materials.AlphaMode alpha)
		{
			return default(AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3B70", Offset = "0xA7B2B70", VA = "0x18A7B3B70")]
		public static SharpGLTF.Materials.AlphaMode ToToolkit(this AlphaMode alpha)
		{
			return default(SharpGLTF.Materials.AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0310", Offset = "0xA7AF310", VA = "0x18A7B0310")]
		public static void CopyTo(this Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA900", Offset = "0xA7B9900", VA = "0x18A7BA900")]
		private static void _CopyMetallicRoughnessTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA620", Offset = "0xA7B9620", VA = "0x18A7BA620")]
		private static void _CopyDefaultTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF8A0", Offset = "0xA7AE8A0", VA = "0x18A7AF8A0")]
		public static void CopyChannelsTo(this Material srcMaterial, MaterialBuilder dstMaterial, params string[] channelKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFB90", Offset = "0xA7AEB90", VA = "0x18A7AFB90")]
		public static void CopyTo(this MaterialChannel srcChannel, ChannelBuilder dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0C80", Offset = "0xA7AFC80", VA = "0x18A7B0C80")]
		public static void CopyTo(this MaterialBuilder srcMaterial, Material dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF740", Offset = "0xA7AE740", VA = "0x18A7AF740")]
		[Obsolete]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params string[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7AF480", Offset = "0xA7AE480", VA = "0x18A7AF480")]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params KnownChannel[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0690", Offset = "0xA7AF690", VA = "0x18A7B0690")]
		public static void CopyTo(this ChannelBuilder srcChannel, MaterialChannel dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA4E0", Offset = "0xA7B94E0", VA = "0x18A7BA4E0")]
		private static Image _ConvertToImage(MaterialChannel dstChannel, ImageBuilder srcImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2BA0", Offset = "0xA7B1BA0", VA = "0x18A7B2BA0")]
		public static Vector4 GetDiffuseColor(this Material material, Vector4 defaultColor)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3000", Offset = "0xA7B2000", VA = "0x18A7B3000")]
		public static Texture GetDiffuseTexture(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2EC0", Offset = "0xA7B1EC0", VA = "0x18A7B2EC0")]
		public static TextureTransform GetDiffuseTextureTransform(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2CF0", Offset = "0xA7B1CF0", VA = "0x18A7B2CF0")]
		public static Matrix3x2? GetDiffuseTextureMatrix(this Material material, Animation track, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1800", Offset = "0xA7B0800", VA = "0x18A7B1800")]
		public static Mesh CreateMesh(this ModelRoot root, IMeshBuilder<MaterialBuilder> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F98260", Offset = "0x3F97260", VA = "0x183F98260")]
		public static Mesh CreateMesh<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialEvaluator, IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1A40", Offset = "0xA7B0A40", VA = "0x18A7B1A40")]
		public static IReadOnlyList<Mesh> CreateMeshes(this ModelRoot root, params IMeshBuilder<MaterialBuilder>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F99F40", Offset = "0x3F98F40", VA = "0x183F99F40")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F992C0", Offset = "0x3F982C0", VA = "0x183F992C0")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, SceneBuilderSchema2Settings settings, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA7B5310", Offset = "0xA7B4310", VA = "0x18A7B5310")]
		public static MeshPrimitive WithIndicesAutomatic(this MeshPrimitive primitive, PrimitiveType primitiveType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA7B4F40", Offset = "0xA7B3F40", VA = "0x18A7B4F40")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, IReadOnlyList<int> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D1F0", Offset = "0x3F9C1F0", VA = "0x183F9D1F0")]
		public static MeshPrimitive WithVertexAccessor<T>(this MeshPrimitive primitive, string attribute, IReadOnlyList<T> values, bool useExplicitByteStride = false) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA7BA0B0", Offset = "0xA7B90B0", VA = "0x18A7BA0B0")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPosition> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9F50", Offset = "0xA7B8F50", VA = "0x18A7B9F50")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPositionNormal> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D800", Offset = "0x3F9C800", VA = "0x183F9D800")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D800", Offset = "0x3F9C800", VA = "0x183F9D800")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM, TvS>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat, TvS Skin)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F9D9C0", Offset = "0x3F9C9C0", VA = "0x183F9D9C0")]
		public static MeshPrimitive WithVertexAccessors<TVertex>(this MeshPrimitive primitive, IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9BA0", Offset = "0xA7B8BA0", VA = "0x18A7B9BA0")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9990", Offset = "0xA7B8990", VA = "0x18A7B9990")]
		public static MeshPrimitive WithVertexAccessor(this MeshPrimitive primitive, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA7B51F0", Offset = "0xA7B41F0", VA = "0x18A7B51F0")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6A80", Offset = "0xA7B5A80", VA = "0x18A7B6A80")]
		public static MeshPrimitive WithMorphTargetAccessors(this MeshPrimitive primitive, int targetIndex, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F9BFB0", Offset = "0x3F9AFB0", VA = "0x183F9BFB0")]
		public static MeshGpuInstancing WithInstanceAccessor<T>(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<T> values) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA7B53F0", Offset = "0xA7B43F0", VA = "0x18A7B53F0")]
		public static MeshGpuInstancing WithInstanceAccessors(this MeshGpuInstancing instancing, IReadOnlyList<AffineTransform> transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA7B5E50", Offset = "0xA7B4E50", VA = "0x18A7B5E50")]
		public static MeshGpuInstancing WithInstanceCustomAccessors(this MeshGpuInstancing instancing, IReadOnlyList<JsonNode> extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA7B5BE0", Offset = "0xA7B4BE0", VA = "0x18A7B5BE0")]
		public static MeshGpuInstancing WithInstanceCustomAccessor(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<JsonNode> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3F9DE70", Offset = "0x3F9CE70", VA = "0x183F9DE70")]
		private static List<T> _SelectAttribute<T>(IReadOnlyList<JsonNode> values, string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6900", Offset = "0xA7B5900", VA = "0x18A7B6900")]
		public static MeshPrimitive WithMaterial(this MeshPrimitive primitive, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA7B21F0", Offset = "0xA7B11F0", VA = "0x18A7B21F0")]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2160", Offset = "0xA7B1160", VA = "0x18A7B2160")]
		[IteratorStateMachine(typeof(<EvaluatePoints>d__75))]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA7B1F70", Offset = "0xA7B0F70", VA = "0x18A7B1F70")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B20D0", Offset = "0xA7B10D0", VA = "0x18A7B20D0")]
		[IteratorStateMachine(typeof(<EvaluateLines>d__77))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA7B25C0", Offset = "0xA7B15C0", VA = "0x18A7B25C0")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B26C0", Offset = "0xA7B16C0", VA = "0x18A7B26C0")]
		[IteratorStateMachine(typeof(<EvaluateTriangles>d__79))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A440", Offset = "0x3F99440", VA = "0x183F9A440")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> EvaluateTriangles<TvG, TvM, TvS>(this Mesh mesh, [Optional] IGeometryTransform xform) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3140", Offset = "0xA7B2140", VA = "0x18A7B3140")]
		public static VertexBufferColumns GetVertexColumns(this MeshPrimitive primitive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA7BAAB0", Offset = "0xA7B9AB0", VA = "0x18A7BAAB0")]
		private static void _Initialize(IReadOnlyDictionary<string, Accessor> vertexAccessors, VertexBufferColumns dstColumns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F94BC0", Offset = "0x3F93BC0", VA = "0x183F94BC0")]
		public static void AddMesh<TMaterial, TvG, TvM, TvS>(this MeshBuilder<TMaterial, TvG, TvM, TvS> meshBuilder, Mesh srcMesh, Converter<Material, TMaterial> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B530", Offset = "0x3F9A530", VA = "0x183F9B530")]
		public static MeshBuilder<TMaterial, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TMaterial, TvG, TvM>(this Scene srcScene, Converter<Material, TMaterial> materialFunc, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F9BB80", Offset = "0x3F9AB80", VA = "0x183F9BB80")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TvG, TvM>(this Scene srcScene, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3540", Offset = "0xA7B2540", VA = "0x18A7B3540")]
		public static IMeshBuilder<MaterialBuilder> ToMeshBuilder(this Mesh srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F9B260", Offset = "0x3F9A260", VA = "0x183F9B260")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS>(this IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F9AB60", Offset = "0x3F99B60", VA = "0x183F9AB60")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS, TMaterial>(this IEnumerable<(VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, TMaterial Material)> triangles, Converter<TMaterial, MaterialBuilder> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA7AE340", Offset = "0xA7AD340", VA = "0x18A7AE340")]
		private static void AddPrimitiveGeometry(this IPrimitiveBuilder dstPrim, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA7B33B0", Offset = "0xA7B23B0", VA = "0x18A7B33B0")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3280", Offset = "0xA7B2280", VA = "0x18A7B3280")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6690", Offset = "0xA7B5690", VA = "0x18A7B6690")]
		public static Node WithLocalTransform(this Node node, AffineTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6770", Offset = "0xA7B5770", VA = "0x18A7B6770")]
		public static Node WithLocalTranslation(this Node node, Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6380", Offset = "0xA7B5380", VA = "0x18A7B6380")]
		public static Node WithLocalRotation(this Node node, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B6500", Offset = "0xA7B5500", VA = "0x18A7B6500")]
		public static Node WithLocalScale(this Node node, Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA7B69C0", Offset = "0xA7B59C0", VA = "0x18A7B69C0")]
		public static Node WithMesh(this Node node, Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA7B89E0", Offset = "0xA7B79E0", VA = "0x18A7B89E0")]
		public static Node WithSkin(this Node node, Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA7B87F0", Offset = "0xA7B77F0", VA = "0x18A7B87F0")]
		public static Node WithSkinBinding(this Node node, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA7B84F0", Offset = "0xA7B74F0", VA = "0x18A7B84F0")]
		public static Node WithSkinBinding(this Node node, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA7B8AA0", Offset = "0xA7B7AA0", VA = "0x18A7B8AA0")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA7B8DF0", Offset = "0xA7B7DF0", VA = "0x18A7B8DF0")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7650", Offset = "0xA7B6650", VA = "0x18A7B7650")]
		public static Node WithPerspectiveCamera(this Node node, float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7070", Offset = "0xA7B6070", VA = "0x18A7B7070")]
		public static Node WithOrthographicCamera(this Node node, float xmag, float ymag, float znear, float zfar)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA7B29E0", Offset = "0xA7B19E0", VA = "0x18A7B29E0")]
		public static Node FindNode(this Scene scene, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2750", Offset = "0xA7B1750", VA = "0x18A7B2750")]
		public static Node FindNode(this Node node, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA7B2350", Offset = "0xA7B1350", VA = "0x18A7B2350")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A490", Offset = "0x3F99490", VA = "0x183F9A490")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, VertexEmpty>> EvaluateTriangles<TvG, TvM>(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9610", Offset = "0xA7A8610", VA = "0x18A7A9610")]
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
				[Cpp2IlInjected.Address(RVA = "0x67504A0", Offset = "0x674F4A0", VA = "0x1867504A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x72BE4B0", Offset = "0x72BD4B0", VA = "0x1872BE4B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6CC79D0", Offset = "0x6CC69D0", VA = "0x186CC79D0")]
			[DebuggerHidden]
			public <_EvaluateTriangles>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x72BE730", Offset = "0x72BD730", VA = "0x1872BE730", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x72BCE90", Offset = "0x72BBE90", VA = "0x1872BCE90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x72BE980", Offset = "0x72BD980", VA = "0x1872BE980")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x72BDE70", Offset = "0x72BCE70", VA = "0x1872BDE70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>> IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x72BE2B0", Offset = "0x72BD2B0", VA = "0x1872BE2B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6338840", Offset = "0x6337840", VA = "0x186338840")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> GetTrianglesFromMesh(Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x633B5D0", Offset = "0x633A5D0", VA = "0x18633B5D0")]
		private static List<(Material, VertexBufferColumns, IEnumerable<(int, int, int)>)> _GatherMeshGeometry(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6339910", Offset = "0x6338910", VA = "0x186339910")]
		[IteratorStateMachine(typeof(EvaluatedTriangle<, , >.<_EvaluateTriangles>d__2))]
		private static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> _EvaluateTriangles(Material material, VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x633E430", Offset = "0x633D430", VA = "0x18633E430")]
		public static implicit operator EvaluatedTriangle<TvG, TvM, TvS>((VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, Material Material) tri)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x633DF40", Offset = "0x633CF40", VA = "0x18633DF40")]
		public EvaluatedTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, Material m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6339230", Offset = "0x6338230", VA = "0x186339230")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> TransformTextureCoordsByMaterial(IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles, [Optional] Animation track, float time = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x633D170", Offset = "0x633C170", VA = "0x18633D170")]
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
				[Cpp2IlInjected.Address(RVA = "0x10D3570", Offset = "0x10D2570", VA = "0x1810D3570")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x136A260", Offset = "0x1369260", VA = "0x18136A260")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float YMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xE856E0", Offset = "0xE846E0", VA = "0x180E856E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xF1C2A0", Offset = "0xF1B2A0", VA = "0x180F1C2A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA7A62D0", Offset = "0xA7A52D0", VA = "0x18A7A62D0")]
			public Orthographic(float xmag, float ymag, float znear, float zfar)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6330", Offset = "0xA7A5330", VA = "0x18A7A6330")]
			internal Orthographic(CameraOrthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6170", Offset = "0xA7A5170", VA = "0x18A7A6170", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA7A63C0", Offset = "0xA7A53C0", VA = "0x18A7A63C0")]
			private Orthographic(Orthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6270", Offset = "0xA7A5270", VA = "0x18A7A6270", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xD0FCF0", Offset = "0xD0ECF0", VA = "0x180D0FCF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public float VerticalFOV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xE856D0", Offset = "0xE846D0", VA = "0x180E856D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x10AB300", Offset = "0x10AA300", VA = "0x1810AB300")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6650", Offset = "0xA7A5650", VA = "0x18A7A6650")]
			public Perspective(float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA7A66B0", Offset = "0xA7A56B0", VA = "0x18A7A66B0")]
			internal Perspective(CameraPerspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA7A64A0", Offset = "0xA7A54A0", VA = "0x18A7A64A0", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6740", Offset = "0xA7A5740", VA = "0x18A7A6740")]
			private Perspective(Perspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA7A65A0", Offset = "0xA7A55A0", VA = "0x18A7A65A0", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6F44A0", Offset = "0xA6F34A0", VA = "0x18A6F44A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD632D0", Offset = "0xD622D0", VA = "0x180D632D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10C8F50", Offset = "0x10C7F50", VA = "0x1810C8F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD60CF0", Offset = "0xD5FCF0", VA = "0x180D60CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD60B40", Offset = "0xD5FB40", VA = "0x180D60B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA79F500", Offset = "0xA79E500", VA = "0x18A79F500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA79F530", Offset = "0xA79E530", VA = "0x18A79F530")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CameraBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA79F4C0", Offset = "0xA79E4C0", VA = "0x18A79F4C0")]
		protected CameraBuilder(float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA79F3F0", Offset = "0xA79E3F0", VA = "0x18A79F3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public EmptyContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA79FBF0", Offset = "0xA79EBF0", VA = "0x18A79FBF0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public MeshContent(IMeshBuilder<MaterialBuilder> mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7A19E0", Offset = "0xA7A09E0", VA = "0x18A7A19E0", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x900C540", Offset = "0x900B540", VA = "0x18900C540")]
		private MeshContent(MeshContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C9E0", Offset = "0x2B8B9E0", VA = "0x182B8C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1B30", Offset = "0xA7A0B30", VA = "0x18A7A1B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1A50", Offset = "0xA7A0A50", VA = "0x18A7A1A50", Slot = "6")]
		public bool Equals(IRenderableContent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1C40", Offset = "0xA7A0C40", VA = "0x18A7A1C40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public CameraContent(CameraBuilder camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA79F580", Offset = "0xA79E580", VA = "0x18A79F580", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA79F960", Offset = "0xA79E960", VA = "0x18A79F960")]
		private CameraContent(CameraContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA79F610", Offset = "0xA79E610", VA = "0x18A79F610", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public LightContent(LightBuilder light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1600", Offset = "0xA7A0600", VA = "0x18A7A1600", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA79F960", Offset = "0xA79E960", VA = "0x18A79F960")]
		private LightContent(LightContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1690", Offset = "0xA7A0690", VA = "0x18A7A1690", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7A14B0", Offset = "0xA7A04B0", VA = "0x18A7A14B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1410", Offset = "0xA7A0410", VA = "0x18A7A1410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ContentTransformer Content
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA7A1430", Offset = "0xA7A0430", VA = "0x18A7A1430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		internal InstanceBuilder(SceneBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1330", Offset = "0xA7A0330", VA = "0x18A7A1330")]
		public InstanceBuilder WithName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1300", Offset = "0xA7A0300", VA = "0x18A7A1300")]
		public InstanceBuilder WithExtras(JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1290", Offset = "0xA7A0290", VA = "0x18A7A1290")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1360", Offset = "0xA7A0360", VA = "0x18A7A1360")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79FAD0", Offset = "0xA79EAD0", VA = "0x18A79FAD0")]
			public Directional()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA79FBE0", Offset = "0xA79EBE0", VA = "0x18A79FBE0")]
			internal Directional(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA79F9D0", Offset = "0xA79E9D0", VA = "0x18A79F9D0", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA79FB10", Offset = "0xA79EB10", VA = "0x18A79FB10")]
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
				[Cpp2IlInjected.Address(RVA = "0xE856D0", Offset = "0xE846D0", VA = "0x180E856D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x10AB300", Offset = "0x10AA300", VA = "0x1810AB300")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6A40", Offset = "0xA7A5A40", VA = "0x18A7A6A40")]
			public Point()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6A00", Offset = "0xA7A5A00", VA = "0x18A7A6A00")]
			internal Point(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6820", Offset = "0xA7A5820", VA = "0x18A7A6820", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6920", Offset = "0xA7A5920", VA = "0x18A7A6920")]
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
				[Cpp2IlInjected.Address(RVA = "0xE856D0", Offset = "0xE846D0", VA = "0x180E856D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x10AB300", Offset = "0x10AA300", VA = "0x1810AB300")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public float InnerConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0xDF04E0", Offset = "0xDEF4E0", VA = "0x180DF04E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0xDF04F0", Offset = "0xDEF4F0", VA = "0x180DF04F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public float OuterConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0xD9E630", Offset = "0xD9D630", VA = "0x180D9E630")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x11443D0", Offset = "0x11433D0", VA = "0x1811443D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE290", Offset = "0xA7AD290", VA = "0x18A7AE290")]
			public Spot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE2E0", Offset = "0xA7AD2E0", VA = "0x18A7AE2E0")]
			internal Spot(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE090", Offset = "0xA7AD090", VA = "0x18A7AE090", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA7AE1A0", Offset = "0xA7AD1A0", VA = "0x18A7AE1A0")]
			private Spot(Spot other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xA6F44A0", Offset = "0xA6F34A0", VA = "0x18A6F44A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xFE2A10", Offset = "0xFE1A10", VA = "0x180FE2A10")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xFE29C0", Offset = "0xFE19C0", VA = "0x180FE29C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xE856E0", Offset = "0xE846E0", VA = "0x180E856E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xF1C2A0", Offset = "0xF1B2A0", VA = "0x180F1C2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA79FAD0", Offset = "0xA79EAD0", VA = "0x18A79FAD0")]
		protected LightBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA7A14D0", Offset = "0xA7A04D0", VA = "0x18A7A14D0")]
		protected LightBuilder(PunctualLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LightBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA79FB10", Offset = "0xA79EB10", VA = "0x18A79FB10")]
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
				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <Flatten>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD140", Offset = "0xA7BC140", VA = "0x18A7BD140", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA7BCD10", Offset = "0xA7BBD10", VA = "0x18A7BCD10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD2E0", Offset = "0xA7BC2E0", VA = "0x18A7BD2E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD330", Offset = "0xA7BC330", VA = "0x18A7BD330")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD100", Offset = "0xA7BC100", VA = "0x18A7BD100", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD060", Offset = "0xA7BC060", VA = "0x18A7BD060", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NodeBuilder> IEnumerable<NodeBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA7BD060", Offset = "0xA7BC060", VA = "0x18A7BD060", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NodeBuilder Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5660", Offset = "0xA7A4660", VA = "0x18A7A5660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<NodeBuilder> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IEnumerable<string> AnimationTracksNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4AD0", Offset = "0xA7A3AD0", VA = "0x18A7A4AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HasAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4C60", Offset = "0xA7A3C60", VA = "0x18A7A4C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HasTransformAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4CC0", Offset = "0xA7A3CC0", VA = "0x18A7A4CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AnimatableProperty<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xD12820", Offset = "0xD11820", VA = "0x180D12820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnimatableProperty<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xD12E90", Offset = "0xD11E90", VA = "0x180D12E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AnimatableProperty<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD12870", Offset = "0xD11870", VA = "0x180D12870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5330", Offset = "0xA7A4330", VA = "0x18A7A5330")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5B40", Offset = "0xA7A4B40", VA = "0x18A7A5B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5410", Offset = "0xA7A4410", VA = "0x18A7A5410")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5C00", Offset = "0xA7A4C00", VA = "0x18A7A5C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5940", Offset = "0xA7A4940", VA = "0x18A7A5940")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA7A6090", Offset = "0xA7A5090", VA = "0x18A7A6090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4DD0", Offset = "0xA7A3DD0", VA = "0x18A7A4DD0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5680", Offset = "0xA7A4680", VA = "0x18A7A5680")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public AnimatableProperty<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD39E70", Offset = "0xD38E70", VA = "0x180D39E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool? IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA7A4D60", Offset = "0xA7A3D60", VA = "0x18A7A4D60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA7A5A50", Offset = "0xA7A4A50", VA = "0x18A7A5A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4300", Offset = "0xA7A3300", VA = "0x18A7A4300")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4990", Offset = "0xA7A3990", VA = "0x18A7A4990")]
		public NodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A48F0", Offset = "0xA7A38F0", VA = "0x18A7A48F0")]
		public NodeBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4A10", Offset = "0xA7A3A10", VA = "0x18A7A4A10")]
		public NodeBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2300", Offset = "0xA7A1300", VA = "0x18A7A2300")]
		public Dictionary<NodeBuilder, NodeBuilder> DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1FA0", Offset = "0xA7A0FA0", VA = "0x18A7A1FA0")]
		private NodeBuilder DeepClone(IDictionary<NodeBuilder, NodeBuilder> nodeMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1F10", Offset = "0xA7A0F10", VA = "0x18A7A1F10")]
		public NodeBuilder CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1CC0", Offset = "0xA7A0CC0", VA = "0x18A7A1CC0")]
		public void AddNode(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2B30", Offset = "0xA7A1B30", VA = "0x18A7A2B30")]
		public static bool IsValidArmature(IEnumerable<NodeBuilder> joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2370", Offset = "0xA7A1370", VA = "0x18A7A2370")]
		[IteratorStateMachine(typeof(<Flatten>d__52))]
		public static IEnumerable<NodeBuilder> Flatten(NodeBuilder container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A4740", Offset = "0xA7A3740", VA = "0x18A7A4740")]
		private void _UseDecomposedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3670", Offset = "0xA7A2670", VA = "0x18A7A3670")]
		public AnimatableProperty<Vector3> UseScale()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3730", Offset = "0xA7A2730", VA = "0x18A7A3730")]
		public CurveBuilder<Vector3> UseScale(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A35A0", Offset = "0xA7A25A0", VA = "0x18A7A35A0")]
		public AnimatableProperty<Quaternion> UseRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3540", Offset = "0xA7A2540", VA = "0x18A7A3540")]
		public CurveBuilder<Quaternion> UseRotation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3790", Offset = "0xA7A2790", VA = "0x18A7A3790")]
		public AnimatableProperty<Vector3> UseTranslation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3860", Offset = "0xA7A2860", VA = "0x18A7A3860")]
		public CurveBuilder<Vector3> UseTranslation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3460", Offset = "0xA7A2460", VA = "0x18A7A3460")]
		public void SetScaleTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA7A34D0", Offset = "0xA7A24D0", VA = "0x18A7A34D0")]
		public void SetTranslationTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA7A33F0", Offset = "0xA7A23F0", VA = "0x18A7A33F0")]
		public void SetRotationTrack(string track, ICurveSampler<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2700", Offset = "0xA7A1700", VA = "0x18A7A2700")]
		public AffineTransform GetLocalTransform(string animationTrack, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA7A2950", Offset = "0xA7A1950", VA = "0x18A7A2950")]
		public Matrix4x4 GetWorldMatrix(string animationTrack, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA7A23F0", Offset = "0xA7A13F0", VA = "0x18A7A23F0")]
		public Matrix4x4 GetInverseBindMatrix([Optional] Matrix4x4? meshWorldMatrix)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3010", Offset = "0xA7A2010", VA = "0x18A7A3010")]
		public void SetLocalTransform(AffineTransform newLocalTransform, bool keepChildrenInPlace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA7A38C0", Offset = "0xA7A28C0", VA = "0x18A7A38C0")]
		public AnimatableProperty<bool> UseVisibility()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA7A42A0", Offset = "0xA7A32A0", VA = "0x18A7A42A0")]
		public NodeBuilder WithLocalTranslation(Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3CA0", Offset = "0xA7A2CA0", VA = "0x18A7A3CA0")]
		public NodeBuilder WithLocalScale(Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3C40", Offset = "0xA7A2C40", VA = "0x18A7A3C40")]
		public NodeBuilder WithLocalRotation(Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3FD0", Offset = "0xA7A2FD0", VA = "0x18A7A3FD0")]
		public NodeBuilder WithLocalTranslation(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3970", Offset = "0xA7A2970", VA = "0x18A7A3970")]
		public NodeBuilder WithLocalRotation(string animTrack, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA7A3D00", Offset = "0xA7A2D00", VA = "0x18A7A3D00")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <CreateFrom>d__31(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3D50", Offset = "0xA7D2D50", VA = "0x18A7D3D50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA7D38A0", Offset = "0xA7D28A0", VA = "0x18A7D38A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3E30", Offset = "0xA7D2E30", VA = "0x18A7D3E30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3D10", Offset = "0xA7D2D10", VA = "0x18A7D3D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3C70", Offset = "0xA7D2C70", VA = "0x18A7D3C70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SceneBuilder> IEnumerable<SceneBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3C70", Offset = "0xA7D2C70", VA = "0x18A7D3C70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA7ADEF0", Offset = "0xA7ACEF0", VA = "0x18A7ADEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal IEnumerable<string> AnimationTrackNames
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA7ADDC0", Offset = "0xA7ACDC0", VA = "0x18A7ADDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA7ADD20", Offset = "0xA7ACD20", VA = "0x18A7ADD20")]
		public SceneBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9680", Offset = "0xA7A8680", VA = "0x18A7A9680")]
		public SceneBuilder DeepClone(bool cloneArmatures = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9FA0", Offset = "0xA7A8FA0", VA = "0x18A7A9FA0")]
		[Obsolete("Use LoadDefaultScene(...); or LoadAllScenes(...) instead.", true)]
		public static SceneBuilder Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9FA0", Offset = "0xA7A8FA0", VA = "0x18A7A9FA0")]
		public static SceneBuilder LoadDefaultScene(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9ED0", Offset = "0xA7A8ED0", VA = "0x18A7A9ED0")]
		public static SceneBuilder[] LoadAllScenes(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA7A79B0", Offset = "0xA7A69B0", VA = "0x18A7A79B0")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7E40", Offset = "0xA7A6E40", VA = "0x18A7A7E40")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7BD0", Offset = "0xA7A6BD0", VA = "0x18A7A7BD0")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node, AffineTransform instanceTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA7A81D0", Offset = "0xA7A71D0", VA = "0x18A7A81D0")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, Matrix4x4 meshWorldMatrix, params NodeBuilder[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8540", Offset = "0xA7A7540", VA = "0x18A7A8540")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, params (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6A80", Offset = "0xA7A5A80", VA = "0x18A7A6A80")]
		public InstanceBuilder AddCamera(CameraBuilder camera, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6EF0", Offset = "0xA7A5EF0", VA = "0x18A7A6EF0")]
		public InstanceBuilder AddCamera(CameraBuilder camera, Vector3 cameraPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA7A6CD0", Offset = "0xA7A5CD0", VA = "0x18A7A6CD0")]
		public InstanceBuilder AddCamera(CameraBuilder camera, AffineTransform cameraTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7360", Offset = "0xA7A6360", VA = "0x18A7A7360")]
		public InstanceBuilder AddLight(LightBuilder light, AffineTransform lightTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA7A7580", Offset = "0xA7A6580", VA = "0x18A7A7580")]
		public InstanceBuilder AddLight(LightBuilder light, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA7A77D0", Offset = "0xA7A67D0", VA = "0x18A7A77D0")]
		public InstanceBuilder AddNode(NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9CB0", Offset = "0xA7A8CB0", VA = "0x18A7A9CB0")]
		public IReadOnlyList<NodeBuilder> FindArmatures()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA7A88F0", Offset = "0xA7A78F0", VA = "0x18A7A88F0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA7A8030", Offset = "0xA7A7030", VA = "0x18A7A8030")]
		public IReadOnlyList<InstanceBuilder> AddScene(SceneBuilder scene, Matrix4x4 sceneTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA580", Offset = "0xA7A9580", VA = "0x18A7AA580", Slot = "8")]
		public ModelRoot ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA040", Offset = "0xA7A9040", VA = "0x18A7AA040")]
		public ModelRoot ToGltf2(SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA110", Offset = "0xA7A9110", VA = "0x18A7AA110")]
		public static ModelRoot ToGltf2(IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9540", Offset = "0xA7A8540", VA = "0x18A7A9540")]
		public static SceneBuilder[] CreateFrom(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA7A9610", Offset = "0xA7A8610", VA = "0x18A7A9610")]
		public static SceneBuilder CreateFrom(Scene srcScene)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA7A94C0", Offset = "0xA7A84C0", VA = "0x18A7A94C0")]
		[IteratorStateMachine(typeof(<CreateFrom>d__31))]
		public static IEnumerable<SceneBuilder> CreateFrom(IEnumerable<Scene> srcScenes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC3B0", Offset = "0xA7AB3B0", VA = "0x18A7AC3B0")]
		private static SceneBuilder _CreateFrom(Scene srcScene, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshInstances)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA7ACB00", Offset = "0xA7ABB00", VA = "0x18A7ACB00")]
		private static Dictionary<Node, IMeshBuilder<MaterialBuilder>> _GatherMeshInstances(IEnumerable<Node> srcNodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB0F0", Offset = "0xA7AA0F0", VA = "0x18A7AB0F0")]
		private static void _AddMeshInstances(SceneBuilder dstScene, IEnumerable<Node> srcNodes, IReadOnlyDictionary<Node, NodeBuilder> nodesDict, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshesDict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA6A0", Offset = "0xA7A96A0", VA = "0x18A7AA6A0")]
		private static void _AddCameraInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA7AAD00", Offset = "0xA7A9D00", VA = "0x18A7AAD00")]
		private static void _AddLightInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA7AAA70", Offset = "0xA7A9A70", VA = "0x18A7AAA70")]
		private static void _AddEmptyInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA7ABC10", Offset = "0xA7AAC10", VA = "0x18A7ABC10")]
		private static void _CopyToNodeBuilder(NodeBuilder dstNode, Node srcNode, IDictionary<Node, NodeBuilder> nodeMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA7AC050", Offset = "0xA7AB050", VA = "0x18A7AC050")]
		private static void _CopyTransformAnimation(NodeBuilder dstNode, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA7AB760", Offset = "0xA7AA760", VA = "0x18A7AB760")]
		private static void _CopyMorphingAnimation(InstanceBuilder dstInst, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F254E0", Offset = "0x3F244E0", VA = "0x183F254E0")]
		internal static void _VerifyCurveConversion<T>(IAnimationSampler<T> a, IConvertibleCurve<T> b, Func<T, T, bool> equalityComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AD030", Offset = "0xA7AC030", VA = "0x18A7AD030")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7CC120", Offset = "0xA7CB120", VA = "0x18A7CC120")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SceneBuilderSchema2Settings WithGpuInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA7CC140", Offset = "0xA7CB140", VA = "0x18A7CC140")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UseStridedBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x10C8400", Offset = "0x10C7400", VA = "0x1810C8400")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2737DF0", Offset = "0x2736DF0", VA = "0x182737DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CompactVertexWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1144440", Offset = "0x1143440", VA = "0x181144440")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1144470", Offset = "0x1143470", VA = "0x181144470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A70", Offset = "0x30D3A70", VA = "0x1830D4A70")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x30D4A80", Offset = "0x30D3A80", VA = "0x1830D4A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xEE3910", Offset = "0xEE2910", VA = "0x180EE3910")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xEE3930", Offset = "0xEE2930", VA = "0x180EE3930")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xD0CAA0", Offset = "0xD0BAA0", VA = "0x180D0CAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA7CEBB0", Offset = "0xA7CDBB0", VA = "0x18A7CEBB0")]
		public Mesh GetMesh(IMeshBuilder<MaterialBuilder> key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7CEC40", Offset = "0xA7CDC40", VA = "0x18A7CEC40")]
		public Node GetNode(NodeBuilder key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA7CECD0", Offset = "0xA7CDCD0", VA = "0x18A7CECD0")]
		public static bool HasContent(Node node, bool checkTransform = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC630", Offset = "0xA7CB630", VA = "0x18A7CC630")]
		public void AddGeometryResources(ModelRoot root, IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC160", Offset = "0xA7CB160", VA = "0x18A7CC160")]
		private void AddArmatureResources(IEnumerable<SceneBuilder> srcScenes, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7CDF50", Offset = "0xA7CCF50", VA = "0x18A7CDF50")]
		private void CreateArmature(NodeBuilder srcNode, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7CEEC0", Offset = "0xA7CDEC0", VA = "0x18A7CEEC0")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<SparseWeight8> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF220", Offset = "0xA7CE220", VA = "0x18A7CF220")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<ArraySegment<float>> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7CDDB0", Offset = "0xA7CCDB0", VA = "0x18A7CDDB0")]
		public void AddScene(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7CD770", Offset = "0xA7CC770", VA = "0x18A7CD770")]
		private void AddMeshes(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7CD170", Offset = "0xA7CC170", VA = "0x18A7CD170")]
		private void AddLightsAndCameras(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF690", Offset = "0xA7CE690", VA = "0x18A7CF690")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AffineTransform? Child
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6939D40", Offset = "0x6938D40", VA = "0x186939D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA7D2630", Offset = "0xA7D1630", VA = "0x18A7D2630")]
		public static implicit operator TransformChainBuilder(NodeBuilder node)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7D2680", Offset = "0xA7D1680", VA = "0x18A7D2680")]
		public static implicit operator TransformChainBuilder(AffineTransform transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7D26E0", Offset = "0xA7D16E0", VA = "0x18A7D26E0")]
		public static implicit operator TransformChainBuilder(Matrix4x4 transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7D2470", Offset = "0xA7D1470", VA = "0x18A7D2470")]
		public TransformChainBuilder(AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7D2440", Offset = "0xA7D1440", VA = "0x18A7D2440")]
		public TransformChainBuilder(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7D2550", Offset = "0xA7D1550", VA = "0x18A7D2550")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
			internal DeepCloneContext(IReadOnlyDictionary<NodeBuilder, NodeBuilder> nmap)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA7C49C0", Offset = "0xA7C39C0", VA = "0x18A7C49C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7C4940", Offset = "0xA7C3940", VA = "0x18A7C4940")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AnimatableProperty<ArraySegment<float>> Morphings
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HasRenderableContent
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA7C48F0", Offset = "0xA7C38F0", VA = "0x18A7C48F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA7C47E0", Offset = "0xA7C37E0", VA = "0x18A7C47E0")]
		protected ContentTransformer(object content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ContentTransformer DeepClone(DeepCloneContext args);

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA7C46A0", Offset = "0xA7C36A0", VA = "0x18A7C46A0")]
		protected ContentTransformer(ContentTransformer other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4280", Offset = "0xA7C3280", VA = "0x18A7C4280")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4200", Offset = "0xA7C3200", VA = "0x18A7C4200")]
		public CameraBuilder GetCameraAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C42E0", Offset = "0xA7C32E0", VA = "0x18A7C42E0")]
		public LightBuilder GetLightAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract NodeBuilder GetArmatureRoot();

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4570", Offset = "0xA7C3570", VA = "0x18A7C4570")]
		public AnimatableProperty<ArraySegment<float>> UseMorphing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4360", Offset = "0xA7C3360", VA = "0x18A7C4360")]
		public CurveBuilder<ArraySegment<float>> UseMorphing(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract Matrix4x4 GetPoseWorldMatrix();

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4030", Offset = "0xA7C3030", VA = "0x18A7C4030")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NodeBuilder ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AffineTransform ChildTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x95AC330", Offset = "0x95AB330", VA = "0x1895AC330")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x95AC3A0", Offset = "0x95AB3A0", VA = "0x1895AC3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4FD0", Offset = "0xA7C3FD0", VA = "0x18A7C4FD0")]
		internal FixedTransformer(object content, AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4E30", Offset = "0xA7C3E30", VA = "0x18A7C4E30")]
		internal FixedTransformer(object content, NodeBuilder parentNode, AffineTransform childTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4E90", Offset = "0xA7C3E90", VA = "0x18A7C4E90")]
		protected FixedTransformer(FixedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4AC0", Offset = "0xA7C3AC0", VA = "0x18A7C4AC0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4C30", Offset = "0xA7C3C30", VA = "0x18A7C4C30", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA7C4C50", Offset = "0xA7C3C50", VA = "0x18A7C4C50", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x73F6860", Offset = "0x73F5860", VA = "0x1873F6860", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x996A810", Offset = "0x9969810", VA = "0x18996A810", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x18CACC0", Offset = "0x18C9CC0", VA = "0x1818CACC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x996AB80", Offset = "0x9969B80", VA = "0x18996AB80", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NodeBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC000", Offset = "0xA7CB000", VA = "0x18A7CC000")]
		internal RigidTransformer(object content, NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA7CC040", Offset = "0xA7CB040", VA = "0x18A7CC040")]
		protected RigidTransformer(RigidTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBD40", Offset = "0xA7CAD40", VA = "0x18A7CBD40", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBE60", Offset = "0xA7CAE60", VA = "0x18A7CBE60", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBE80", Offset = "0xA7CAE80", VA = "0x18A7CBE80", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBED0", Offset = "0xA7CAED0", VA = "0x18A7CBED0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA7D0F00", Offset = "0xA7CFF00", VA = "0x18A7D0F00")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA7D0FE0", Offset = "0xA7CFFE0", VA = "0x18A7D0FE0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA7D0A90", Offset = "0xA7CFA90", VA = "0x18A7D0A90")]
		protected SkinnedTransformer(SkinnedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF7A0", Offset = "0xA7CE7A0", VA = "0x18A7CF7A0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA7D0000", Offset = "0xA7CF000", VA = "0x18A7D0000")]
		private void SetJoints(AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA7D02D0", Offset = "0xA7CF2D0", VA = "0x18A7D02D0")]
		private void SetJoints((NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF960", Offset = "0xA7CE960", VA = "0x18A7CF960")]
		public (NodeBuilder, Matrix4x4)[] GetJointBindings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CF810", Offset = "0xA7CE810", VA = "0x18A7CF810", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFE60", Offset = "0xA7CEE60", VA = "0x18A7CFE60")]
		public IGeometryTransform GetWorldTransformer(string animationTrack, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFD00", Offset = "0xA7CED00", VA = "0x18A7CFD00", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA7D06D0", Offset = "0xA7CF6D0", VA = "0x18A7D06D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <CreateFrom>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3520", Offset = "0xA7D2520", VA = "0x18A7D3520", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA7D27C0", Offset = "0xA7D17C0", VA = "0x18A7D27C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA7D37B0", Offset = "0xA7D27B0", VA = "0x18A7D37B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3800", Offset = "0xA7D2800", VA = "0x18A7D3800")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3850", Offset = "0xA7D2850", VA = "0x18A7D3850")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA7D34E0", Offset = "0xA7D24E0", VA = "0x18A7D34E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3430", Offset = "0xA7D2430", VA = "0x18A7D3430", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Schema2SceneBuilder.IOperator<Scene>> IEnumerable<Schema2SceneBuilder.IOperator<Scene>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA7D3430", Offset = "0xA7D2430", VA = "0x18A7D3430", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DFF20", Offset = "0xA7DEF20", VA = "0x18A7DFF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF630", Offset = "0xA7DE630", VA = "0x18A7DF630")]
		[IteratorStateMachine(typeof(<CreateFrom>d__2))]
		public static IEnumerable<Schema2SceneBuilder.IOperator<Scene>> CreateFrom(IEnumerable<FixedTransformer> instances, int gpuMinCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA7DFE10", Offset = "0xA7DEE10", VA = "0x18A7DFE10")]
		private _MeshInstancing(NodeBuilder parentNode, IEnumerable<FixedTransformer> children, int gpuMinCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF3A0", Offset = "0xA7DE3A0", VA = "0x18A7DF3A0", Slot = "4")]
		public void ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF6B0", Offset = "0xA7DE6B0", VA = "0x18A7DF6B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DF340", Offset = "0xA7DE340", VA = "0x18A7DF340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
		public _FixedIntance(FixedTransformer fixedXformer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF190", Offset = "0xA7DE190", VA = "0x18A7DF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DEFC0", Offset = "0xA7DDFC0", VA = "0x18A7DEFC0", Slot = "4")]
			public bool Equals(ChannelBuilder x, ChannelBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA7D43C0", Offset = "0xA7D33C0", VA = "0x18A7D43C0", Slot = "5")]
			public int GetHashCode(ChannelBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KnownChannel Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7C24E0", Offset = "0xA7C14E0", VA = "0x18A7C24E0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2520", Offset = "0xA7C1520", VA = "0x18A7C2520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MaterialValue.Collection Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7C2490", Offset = "0xA7C1490", VA = "0x18A7C2490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C21C0", Offset = "0xA7C11C0", VA = "0x18A7C21C0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C22A0", Offset = "0xA7C12A0", VA = "0x18A7C22A0")]
		internal ChannelBuilder(MaterialBuilder parent, KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1EE0", Offset = "0xA7C0EE0", VA = "0x18A7C1EE0")]
		public static bool AreEqualByContent(ChannelBuilder x, ChannelBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C2050", Offset = "0xA7C1050", VA = "0x18A7C2050")]
		public static int GetContentHashCode(ChannelBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA7C20D0", Offset = "0xA7C10D0", VA = "0x18A7C20D0")]
		public TextureBuilder GetValidTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA7C20F0", Offset = "0xA7C10F0", VA = "0x18A7C20F0")]
		public TextureBuilder UseTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xD376A0", Offset = "0xD366A0", VA = "0x180D376A0")]
		public void RemoveTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA7C1FD0", Offset = "0xA7C0FD0", VA = "0x18A7C1FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEEF550", Offset = "0xEEE550", VA = "0x180EEF550")]
			[CompilerGenerated]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7A595A0", Offset = "0x7A585A0", VA = "0x187A595A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C54D0", Offset = "0xA7C44D0", VA = "0x18A7C54D0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5610", Offset = "0xA7C4610", VA = "0x18A7C5610")]
		public static implicit operator ImageBuilder(ArraySegment<byte> image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C57C0", Offset = "0xA7C47C0", VA = "0x18A7C57C0")]
		public static implicit operator ImageBuilder(byte[] image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA7C56F0", Offset = "0xA7C46F0", VA = "0x18A7C56F0")]
		public static implicit operator ImageBuilder(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5890", Offset = "0xA7C4890", VA = "0x18A7C5890")]
		public static implicit operator ImageBuilder(MemoryImage content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA7C51D0", Offset = "0xA7C41D0", VA = "0x18A7C51D0")]
		public static ImageBuilder From(MemoryImage content, [Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5290", Offset = "0xA7C4290", VA = "0x18A7C5290")]
		public static ImageBuilder From(MemoryImage content, string name, JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5590", Offset = "0xA7C4590", VA = "0x18A7C5590")]
		private ImageBuilder(MemoryImage content, string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5150", Offset = "0xA7C4150", VA = "0x18A7C5150")]
		internal ImageBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA7C55D0", Offset = "0xA7C45D0", VA = "0x18A7C55D0")]
		private ImageBuilder(ImageBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5010", Offset = "0xA7C4010", VA = "0x18A7C5010")]
		public static bool AreEqualByContent(ImageBuilder x, ImageBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5360", Offset = "0xA7C4360", VA = "0x18A7C5360")]
		public static int GetContentHashCode(ImageBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C53F0", Offset = "0xA7C43F0", VA = "0x18A7C53F0")]
		public static bool IsEmpty(ImageBuilder ib)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5460", Offset = "0xA7C4460", VA = "0x18A7C5460")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DEF40", Offset = "0xA7DDF40", VA = "0x18A7DEF40", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA7DEFE0", Offset = "0xA7DDFE0", VA = "0x18A7DEFE0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0x1734D60", Offset = "0x1733D60", VA = "0x181734D60", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x79D43B0", Offset = "0x79D33B0", VA = "0x1879D43B0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3A1E0", Offset = "0xD391E0", VA = "0x180D3A1E0")]
			[CompilerGenerated]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xE04F50", Offset = "0xE03F50", VA = "0x180E04F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD3A1D0", Offset = "0xD391D0", VA = "0x180D3A1D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xD39F00", Offset = "0xD38F00", VA = "0x180D39F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xF6C200", Offset = "0xF6B200", VA = "0x180F6C200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xF6BDA0", Offset = "0xF6ADA0", VA = "0x180F6BDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ShaderStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9A70", Offset = "0xA7C8A70", VA = "0x18A7C9A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD5BDC0", Offset = "0xD5ADC0", VA = "0x180D5BDC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x15103C0", Offset = "0x150F3C0", VA = "0x1815103C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1238890", Offset = "0x1237890", VA = "0x181238890")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2ABF560", Offset = "0x2ABE560", VA = "0x182ABF560")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MaterialBuilder CompatibilityFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA7C99D0", Offset = "0xA7C89D0", VA = "0x18A7C99D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public static IEqualityComparer<MaterialBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9930", Offset = "0xA7C8930", VA = "0x18A7C9930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static IEqualityComparer<MaterialBuilder> ReferenceComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9980", Offset = "0xA7C8980", VA = "0x18A7C9980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8F20", Offset = "0xA7C7F20", VA = "0x18A7C8F20")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5DA0", Offset = "0xA7C4DA0", VA = "0x18A7C5DA0")]
		public static MaterialBuilder CreateDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9870", Offset = "0xA7C8870", VA = "0x18A7C9870")]
		public MaterialBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6410", Offset = "0xA7C5410", VA = "0x18A7C6410", Slot = "8")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5D40", Offset = "0xA7C4D40", VA = "0x18A7C5D40")]
		public MaterialBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9520", Offset = "0xA7C8520", VA = "0x18A7C9520")]
		public MaterialBuilder(MaterialBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xD0D640", Offset = "0xD0C640", VA = "0x180D0D640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD10700", Offset = "0xD0F700", VA = "0x180D10700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5940", Offset = "0xA7C4940", VA = "0x18A7C5940")]
		public static bool AreEqualByContent(MaterialBuilder x, MaterialBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C60A0", Offset = "0xA7C50A0", VA = "0x18A7C60A0")]
		public static int GetContentHashCode(MaterialBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7C91E0", Offset = "0xA7C81E0", VA = "0x18A7C91E0")]
		private void _SetShader(string shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5F70", Offset = "0xA7C4F70", VA = "0x18A7C5F70")]
		[Obsolete("Use GetChannel with KnownChannel whenever possible")]
		public ChannelBuilder GetChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6600", Offset = "0xA7C5600", VA = "0x18A7C6600")]
		[Obsolete("Use UseChannel with KnownChannel whenever possible")]
		public ChannelBuilder UseChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5EA0", Offset = "0xA7C4EA0", VA = "0x18A7C5EA0")]
		public ChannelBuilder GetChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6470", Offset = "0xA7C5470", VA = "0x18A7C6470")]
		public ChannelBuilder UseChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6310", Offset = "0xA7C5310", VA = "0x18A7C6310")]
		public void RemoveChannel(KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6730", Offset = "0xA7C5730", VA = "0x18A7C6730")]
		internal void ValidateForSchema2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7C86F0", Offset = "0xA7C76F0", VA = "0x18A7C86F0")]
		public MaterialBuilder WithShader(string shader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8CD0", Offset = "0xA7C7CD0", VA = "0x18A7C8CD0")]
		public MaterialBuilder WithUnlitShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8270", Offset = "0xA7C7270", VA = "0x18A7C8270")]
		public MaterialBuilder WithMetallicRoughnessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C88A0", Offset = "0xA7C78A0", VA = "0x18A7C88A0")]
		[Obsolete("SpecularGlossiness has been deprecated by Khronos")]
		public MaterialBuilder WithSpecularGlossinessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6D90", Offset = "0xA7C5D90", VA = "0x18A7C6D90")]
		public MaterialBuilder WithAlpha(AlphaMode alphaMode = AlphaMode.OPAQUE, float alphaCutoff = 0.5f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x91D99E0", Offset = "0x91D89E0", VA = "0x1891D99E0")]
		public MaterialBuilder WithDoubleSide(bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7C72F0", Offset = "0xA7C62F0", VA = "0x18A7C72F0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7210", Offset = "0xA7C6210", VA = "0x18A7C7210")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(string channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA7C70D0", Offset = "0xA7C60D0", VA = "0x18A7C70D0")]
		[Obsolete("Use WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)")]
		public MaterialBuilder WithChannelImage(string channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7260", Offset = "0xA7C6260", VA = "0x18A7C7260")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, object parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7120", Offset = "0xA7C6120", VA = "0x18A7C7120")]
		public MaterialBuilder WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7B90", Offset = "0xA7C6B90", VA = "0x18A7C7B90")]
		public MaterialBuilder WithFallback(MaterialBuilder fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7EE0", Offset = "0xA7C6EE0", VA = "0x18A7C7EE0")]
		public MaterialBuilder WithMetallicRoughnessFallback(ImageBuilder baseColor, Vector4? rgba, ImageBuilder metallicRoughness, float? metallic, float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8570", Offset = "0xA7C7570", VA = "0x18A7C8570")]
		public MaterialBuilder WithNormal(ImageBuilder imageFile, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8630", Offset = "0xA7C7630", VA = "0x18A7C8630")]
		public MaterialBuilder WithOcclusion(ImageBuilder imageFile, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7A20", Offset = "0xA7C6A20", VA = "0x18A7C7A20")]
		public MaterialBuilder WithEmissive(Vector3 rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7860", Offset = "0xA7C6860", VA = "0x18A7C7860")]
		public MaterialBuilder WithEmissive(ImageBuilder imageFile, [Optional] Vector3? rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6EF0", Offset = "0xA7C5EF0", VA = "0x18A7C6EF0")]
		public MaterialBuilder WithBaseColor(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6FB0", Offset = "0xA7C5FB0", VA = "0x18A7C6FB0")]
		public MaterialBuilder WithBaseColor(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8410", Offset = "0xA7C7410", VA = "0x18A7C8410")]
		public MaterialBuilder WithMetallicRoughness([Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C82B0", Offset = "0xA7C72B0", VA = "0x18A7C82B0")]
		public MaterialBuilder WithMetallicRoughness(ImageBuilder imageFile, [Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7340", Offset = "0xA7C6340", VA = "0x18A7C7340")]
		public MaterialBuilder WithClearCoatNormal(ImageBuilder imageFile)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7430", Offset = "0xA7C6430", VA = "0x18A7C7430")]
		public MaterialBuilder WithClearCoat(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7370", Offset = "0xA7C6370", VA = "0x18A7C7370")]
		public MaterialBuilder WithClearCoatRoughness(ImageBuilder imageFile, float roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8C10", Offset = "0xA7C7C10", VA = "0x18A7C8C10")]
		public MaterialBuilder WithTransmission(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7C75C0", Offset = "0xA7C65C0", VA = "0x18A7C75C0")]
		public MaterialBuilder WithDiffuseTransmissionFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA7C74F0", Offset = "0xA7C64F0", VA = "0x18A7C74F0")]
		public MaterialBuilder WithDiffuseTransmissionColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8710", Offset = "0xA7C7710", VA = "0x18A7C8710")]
		public MaterialBuilder WithSpecularColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA7C87E0", Offset = "0xA7C77E0", VA = "0x18A7C87E0")]
		public MaterialBuilder WithSpecularFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8E60", Offset = "0xA7C7E60", VA = "0x18A7C8E60")]
		public MaterialBuilder WithVolumeThickness(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8D10", Offset = "0xA7C7D10", VA = "0x18A7C8D10")]
		public MaterialBuilder WithVolumeAttenuation(Vector3 color, float distance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7D90", Offset = "0xA7C6D90", VA = "0x18A7C7D90")]
		public MaterialBuilder WithIridescence(ImageBuilder imageFile, float factor = 0f, float ior = 1.3f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7C40", Offset = "0xA7C6C40", VA = "0x18A7C7C40")]
		public MaterialBuilder WithIridescenceThickness(ImageBuilder imageFile, float min = 100f, float max = 400f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6DA0", Offset = "0xA7C5DA0", VA = "0x18A7C6DA0")]
		public MaterialBuilder WithAnisotropy(ImageBuilder imageFile, float strength = 0f, float rotation = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7680", Offset = "0xA7C6680", VA = "0x18A7C7680")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C7740", Offset = "0xA7C6740", VA = "0x18A7C7740")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8A80", Offset = "0xA7C7A80", VA = "0x18A7C8A80")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness([Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7C88E0", Offset = "0xA7C78E0", VA = "0x18A7C88E0")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness(ImageBuilder imageFile, [Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9080", Offset = "0xA7C8080", VA = "0x18A7C9080")]
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
				[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E0580", Offset = "0xA7DF580", VA = "0x18A7E0580")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public MaterialValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0x1016B80", Offset = "0x1015B80", VA = "0x181016B80")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0xA7E0620", Offset = "0xA7DF620", VA = "0x18A7E0620")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0310", Offset = "0xA7DF310", VA = "0x18A7E0310")]
			internal _Property(KnownProperty key, float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA7E03D0", Offset = "0xA7DF3D0", VA = "0x18A7E03D0")]
			internal _Property(KnownProperty key, Vector2 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0240", Offset = "0xA7DF240", VA = "0x18A7E0240")]
			internal _Property(KnownProperty key, Vector3 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA7E04A0", Offset = "0xA7DF4A0", VA = "0x18A7E04A0")]
			internal _Property(KnownProperty key, Vector4 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0110", Offset = "0xA7DF110", VA = "0x18A7E0110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA7E00A0", Offset = "0xA7DF0A0", VA = "0x18A7E00A0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA7DFF70", Offset = "0xA7DEF70", VA = "0x18A7DFF70", Slot = "4")]
			public bool Equals(_Property other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA7E05E0", Offset = "0xA7DF5E0", VA = "0x18A7E05E0")]
			public static bool operator ==(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0600", Offset = "0xA7DF600", VA = "0x18A7E0600")]
			public static bool operator !=(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA7DFF70", Offset = "0xA7DEF70", VA = "0x18A7DFF70")]
			public static bool AreEqual(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0150", Offset = "0xA7DF150", VA = "0x18A7E0150")]
			public void SetDefault()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0160", Offset = "0xA7DF160", VA = "0x18A7E0160", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7C3460", Offset = "0xA7C2460", VA = "0x18A7C3460", Slot = "6")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0xA7C3E50", Offset = "0xA7C2E50", VA = "0x18A7C3E50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public MaterialValue this[string keyName]
			{
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0xA7C32E0", Offset = "0xA7C22E0", VA = "0x18A7C32E0")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0xA7C3D70", Offset = "0xA7C2D70", VA = "0x18A7C3D70")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<KnownProperty> Keys
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0xA7C3550", Offset = "0xA7C2550", VA = "0x18A7C3550", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7C3670", Offset = "0xA7C2670", VA = "0x18A7C3670", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x284F060", Offset = "0x284E060", VA = "0x18284F060", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7C3130", Offset = "0xA7C2130", VA = "0x18A7C3130")]
				get
				{
					return default(Vector4);
				}
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0xA7C3790", Offset = "0xA7C2790", VA = "0x18A7C3790")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2FF0", Offset = "0xA7C1FF0", VA = "0x18A7C2FF0")]
			private string _GetDebuggerDisplay()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
			internal Collection(_Property[] properties)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2CC0", Offset = "0xA7C1CC0", VA = "0x18A7C2CC0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2550", Offset = "0xA7C1550", VA = "0x18A7C2550")]
			public static bool AreEqual(Collection x, Collection y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2800", Offset = "0xA7C1800", VA = "0x18A7C2800", Slot = "4")]
			public bool ContainsKey(KnownProperty key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2EC0", Offset = "0xA7C1EC0", VA = "0x18A7C2EC0", Slot = "5")]
			public bool TryGetValue(KnownProperty key, [Out] MaterialValue value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2B80", Offset = "0xA7C1B80", VA = "0x18A7C2B80", Slot = "10")]
			public IEnumerator<KeyValuePair<KnownProperty, MaterialValue>> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2D80", Offset = "0xA7C1D80", VA = "0x18A7C2D80", Slot = "11")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA7C2D30", Offset = "0xA7C1D30", VA = "0x18A7C2D30")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA7C28D0", Offset = "0xA7C18D0", VA = "0x18A7C28D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <_CreateDefaultProperties>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA7D59E0", Offset = "0xA7D49E0", VA = "0x18A7D59E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA7D64B0", Offset = "0xA7D54B0", VA = "0x18A7D64B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA7D6410", Offset = "0xA7D5410", VA = "0x18A7D6410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<_Property> IEnumerable<_Property>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA7D6410", Offset = "0xA7D5410", VA = "0x18A7D6410", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7CA510", Offset = "0xA7C9510", VA = "0x18A7CA510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9AE0", Offset = "0xA7C8AE0", VA = "0x18A7C9AE0")]
		internal static Collection CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA410", Offset = "0xA7C9410", VA = "0x18A7CA410")]
		[IteratorStateMachine(typeof(<_CreateDefaultProperties>d__1))]
		private static IEnumerable<_Property> _CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA910", Offset = "0xA7C9910", VA = "0x18A7CA910")]
		public static implicit operator MaterialValue(float value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA880", Offset = "0xA7C9880", VA = "0x18A7CA880")]
		public static implicit operator MaterialValue(Vector2 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA8B0", Offset = "0xA7C98B0", VA = "0x18A7CA8B0")]
		public static implicit operator MaterialValue(Vector3 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA8E0", Offset = "0xA7C98E0", VA = "0x18A7CA8E0")]
		public static implicit operator MaterialValue(Vector4 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9BF0", Offset = "0xA7C8BF0", VA = "0x18A7C9BF0")]
		public static MaterialValue CreateFrom(object value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA4F0", Offset = "0xA7C94F0", VA = "0x18A7CA4F0")]
		private MaterialValue(float x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA4D0", Offset = "0xA7C94D0", VA = "0x18A7CA4D0")]
		private MaterialValue(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA480", Offset = "0xA7C9480", VA = "0x18A7CA480")]
		private MaterialValue(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA4A0", Offset = "0xA7C94A0", VA = "0x18A7CA4A0")]
		private MaterialValue(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9FD0", Offset = "0xA7C8FD0", VA = "0x18A7C9FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9ED0", Offset = "0xA7C8ED0", VA = "0x18A7C9ED0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9A80", Offset = "0xA7C8A80", VA = "0x18A7C9A80", Slot = "4")]
		public bool Equals(MaterialValue other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9A80", Offset = "0xA7C8A80", VA = "0x18A7C9A80")]
		public static bool operator ==([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA930", Offset = "0xA7C9930", VA = "0x18A7CA930")]
		public static bool operator !=([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9A80", Offset = "0xA7C8A80", VA = "0x18A7C9A80")]
		public static bool AreEqual([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA6A0", Offset = "0xA7C96A0", VA = "0x18A7CA6A0")]
		public static explicit operator float(MaterialValue value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA800", Offset = "0xA7C9800", VA = "0x18A7CA800")]
		public static explicit operator Vector2(MaterialValue value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA780", Offset = "0xA7C9780", VA = "0x18A7CA780")]
		public static explicit operator Vector3(MaterialValue value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA700", Offset = "0xA7C9700", VA = "0x18A7CA700")]
		public static explicit operator Vector4(MaterialValue value)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA0C0", Offset = "0xA7C90C0", VA = "0x18A7CA0C0")]
		public object ToTypeless()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA080", Offset = "0xA7C9080", VA = "0x18A7CA080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA3A0", Offset = "0xA7C93A0", VA = "0x18A7CA3A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DEFA0", Offset = "0xA7DDFA0", VA = "0x18A7DEFA0", Slot = "4")]
			public bool Equals(TextureBuilder x, TextureBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF030", Offset = "0xA7DE030", VA = "0x18A7DF030", Slot = "5")]
			public int GetHashCode(TextureBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD27F80", Offset = "0xD26F80", VA = "0x180D27F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD89760", Offset = "0xD88760", VA = "0x180D89760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD27F90", Offset = "0xD26F90", VA = "0x180D27F90")]
			[CompilerGenerated]
			get
			{
				return default(TextureMipMapFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xD89750", Offset = "0xD88750", VA = "0x180D89750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD82430", Offset = "0xD81430", VA = "0x180D82430")]
			[CompilerGenerated]
			get
			{
				return default(TextureInterpolationFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xD835A0", Offset = "0xD825A0", VA = "0x180D835A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x1699E60", Offset = "0x1698E60", VA = "0x181699E60")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1C8F1C0", Offset = "0x1C8E1C0", VA = "0x181C8F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xF0AFC0", Offset = "0xF09FC0", VA = "0x180F0AFC0")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1AC5500", Offset = "0x1AC4500", VA = "0x181AC5500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ImageBuilder PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA7D2090", Offset = "0xA7D1090", VA = "0x18A7D2090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ImageBuilder FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA7D1F70", Offset = "0xA7D0F70", VA = "0x18A7D1F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public TextureTransformBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static IEqualityComparer<TextureBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA7D1F20", Offset = "0xA7D0F20", VA = "0x18A7D1F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1B80", Offset = "0xA7D0B80", VA = "0x18A7D1B80")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1E40", Offset = "0xA7D0E40", VA = "0x18A7D1E40")]
		internal TextureBuilder(ChannelBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1090", Offset = "0xA7D0090", VA = "0x18A7D1090")]
		public static bool AreEqualByContent(TextureBuilder x, TextureBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1560", Offset = "0xA7D0560", VA = "0x18A7D1560")]
		public static int GetContentHashCode(TextureBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1310", Offset = "0xA7D0310", VA = "0x18A7D1310")]
		internal void CopyTo(TextureBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1710", Offset = "0xA7D0710", VA = "0x18A7D1710")]
		public TextureBuilder WithCoordinateSet(int cset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1840", Offset = "0xA7D0840", VA = "0x18A7D1840")]
		public TextureBuilder WithPrimaryImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1720", Offset = "0xA7D0720", VA = "0x18A7D1720")]
		public TextureBuilder WithFallbackImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1930", Offset = "0xA7D0930", VA = "0x18A7D1930")]
		public TextureBuilder WithSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1950", Offset = "0xA7D0950", VA = "0x18A7D1950")]
		public TextureBuilder WithTransform(float offsetX, float offsetY, float scaleX = 1f, float scaleY = 1f, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA7D1A90", Offset = "0xA7D0A90", VA = "0x18A7D1A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x32C5240", Offset = "0x32C4240", VA = "0x1832C5240")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xEA0770", Offset = "0xE9F770", VA = "0x180EA0770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E9F6D0", Offset = "0x1E9E6D0", VA = "0x181E9F6D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xDF8E10", Offset = "0xDF7E10", VA = "0x180DF8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD632D0", Offset = "0xD622D0", VA = "0x180D632D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x10C8F50", Offset = "0x10C7F50", VA = "0x1810C8F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int? CoordinateSetOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1414D00", Offset = "0x1413D00", VA = "0x181414D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x10C88B0", Offset = "0x10C78B0", VA = "0x1810C88B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA7D2370", Offset = "0xA7D1370", VA = "0x18A7D2370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA7D22E0", Offset = "0xA7D12E0", VA = "0x18A7D22E0")]
		internal TextureTransformBuilder(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xA7D21F0", Offset = "0xA7D11F0", VA = "0x18A7D21F0")]
		internal TextureTransformBuilder(TextureTransformBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA7D20A0", Offset = "0xA7D10A0", VA = "0x18A7D20A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7CAB90", Offset = "0xA7C9B90", VA = "0x18A7CAB90", Slot = "2")]
			public override readonly int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA7CAAE0", Offset = "0xA7C9AE0", VA = "0x18A7CAAE0", Slot = "0")]
			public override readonly bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA7CA990", Offset = "0xA7C9990", VA = "0x18A7CA990", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DA060", Offset = "0xA7D9060", VA = "0x18A7DA060")]
		public void AddTriangle(Material material, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> a, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> b, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA820", Offset = "0xA7D9820", VA = "0x18A7DA820")]
		public void WriteFiles(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA1A0", Offset = "0xA7D91A0", VA = "0x18A7DA1A0")]
		public IReadOnlyDictionary<string, ArraySegment<byte>> GetFiles(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DAAF0", Offset = "0xA7D9AF0", VA = "0x18A7DAAF0")]
		private Dictionary<string, Action<Stream>> _GetFileGenerators(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA7DAED0", Offset = "0xA7D9ED0", VA = "0x18A7DAED0")]
		private static Dictionary<Material, string> _GetMaterialsFileGenerator(IDictionary<string, Action<Stream>> fileGenerators, string baseName, IEnumerable<Material> materials)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA7DCF00", Offset = "0xA7DBF00", VA = "0x18A7DCF00")]
		private static void _WriteMaterialsFile(Stream fs, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA7DD050", Offset = "0xA7DC050", VA = "0x18A7DD050")]
		private static void _WriteMaterialsFile(StreamWriter sw, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA7DB8D0", Offset = "0xA7DA8D0", VA = "0x18A7DB8D0")]
		private void _WriteGeometryFile(Stream s, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA7DBA00", Offset = "0xA7DAA00", VA = "0x18A7DBA00")]
		private void _WriteGeometryFile(StreamWriter sw, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA7D9A10", Offset = "0xA7D8A10", VA = "0x18A7D9A10")]
		public void AddModel(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA7D9D20", Offset = "0xA7D8D20", VA = "0x18A7D9D20")]
		public void AddModel(ModelRoot model, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA5E0", Offset = "0xA7D95E0", VA = "0x18A7DA5E0")]
		private static Material GetMaterialFromTriangle(SharpGLTF.Schema2.Material srcMaterial)
		{
			return default(Material);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDB30", Offset = "0xA7DCB30", VA = "0x18A7DDB30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7DE990", Offset = "0xA7DD990", VA = "0x18A7DE990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDBE0", Offset = "0xA7DCBE0", VA = "0x18A7DDBE0")]
		public static ModelRoot LoadModelFromZip(string zipPath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA7DE920", Offset = "0xA7DD920", VA = "0x18A7DE920")]
		public ZipReader(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA7DE850", Offset = "0xA7DD850", VA = "0x18A7DE850")]
		public ZipReader(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDBB0", Offset = "0xA7DCBB0", VA = "0x18A7DDBB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DE2A0", Offset = "0xA7DD2A0", VA = "0x18A7DE2A0")]
		private IEnumerable<ZipArchiveEntry> _GetEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDF70", Offset = "0xA7DCF70", VA = "0x18A7DDF70")]
		public ModelRoot LoadModel([Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDEB0", Offset = "0xA7DCEB0", VA = "0x18A7DDEB0")]
		public ModelRoot LoadModel(string gltfFile, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA7DE4B0", Offset = "0xA7DD4B0", VA = "0x18A7DE4B0")]
		private ArraySegment<byte> _ReadAsset(string rawUri)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA7DE160", Offset = "0xA7DD160", VA = "0x18A7DE160")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DEED0", Offset = "0xA7DDED0", VA = "0x18A7DEED0")]
		public ZipWriter(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA7DEE00", Offset = "0xA7DDE00", VA = "0x18A7DEE00")]
		public ZipWriter(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDBB0", Offset = "0xA7DCBB0", VA = "0x18A7DDBB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA7DEAB0", Offset = "0xA7DDAB0", VA = "0x18A7DEAB0")]
		public void AddModel(string filePath, ModelRoot model, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA7DECB0", Offset = "0xA7DDCB0", VA = "0x18A7DECB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x70A3760", Offset = "0x70A2760", VA = "0x1870A3760", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public VertexPreprocessor<TvG, TvM, TvS> VertexPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x70A3970", Offset = "0x70A2970", VA = "0x1870A3970", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyCollection<PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x709AF90", Offset = "0x7099F90", VA = "0x18709AF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> IMeshBuilder<TMaterial>.Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x709AF90", Offset = "0x7099F90", VA = "0x18709AF90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x70A2F00", Offset = "0x70A1F00", VA = "0x1870A2F00")]
		public MeshBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x70A25D0", Offset = "0x70A15D0", VA = "0x1870A25D0")]
		public MeshBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x709B110", Offset = "0x709A110", VA = "0x18709B110", Slot = "19")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x7099990", Offset = "0x7098990", VA = "0x187099990", Slot = "17")]
		IMeshBuilder<TMaterial> IMeshBuilder<TMaterial>.Clone(Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x7099990", Offset = "0x7098990", VA = "0x187099990")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x70A2F20", Offset = "0x70A1F20", VA = "0x1870A2F20")]
		private MeshBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> other, [Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x709CB20", Offset = "0x709BB20", VA = "0x18709CB20")]
		public MorphTargetBuilder<TMaterial, TvG, TvS, TvM> UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7099FF0", Offset = "0x7098FF0", VA = "0x187099FF0", Slot = "16")]
		IMorphTargetBuilder IMeshBuilder<TMaterial>.UseMorphTarget(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x709F080", Offset = "0x709E080", VA = "0x18709F080")]
		private PrimitiveBuilder<TMaterial, TvG, TvM, TvS> _UsePrimitive((TMaterial Material, int PrimType) key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x709D260", Offset = "0x709C260", VA = "0x18709D260")]
		public PrimitiveBuilder<TMaterial, TvG, TvM, TvS> UsePrimitive(TMaterial material, int primitiveVertexCount = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x709AA10", Offset = "0x7099A10", VA = "0x18709AA10", Slot = "15")]
		IPrimitiveBuilder IMeshBuilder<TMaterial>.UsePrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7095D10", Offset = "0x7094D10", VA = "0x187095D10")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, Matrix4x4 vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x70971E0", Offset = "0x70961E0", VA = "0x1870971E0")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, [Optional] Func<TMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39EF520", Offset = "0x39EE520", VA = "0x1839EF520")]
		public void AddMesh<TSourceMaterial>(IMeshBuilder<TSourceMaterial> mesh, Func<TSourceMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x709B420", Offset = "0x709A420", VA = "0x18709B420")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x709E8E0", Offset = "0x709D8E0", VA = "0x18709E8E0", Slot = "18")]
		public void Validate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MeshBuilder<TvG, TvM, TvS> : MeshBuilder<MaterialBuilder, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7095890", Offset = "0x7094890", VA = "0x187095890")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MeshBuilder<TvG, TvM> : MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x63451F0", Offset = "0x63441F0", VA = "0x1863451F0")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MeshBuilder<TvG> : MeshBuilder<MaterialBuilder, TvG, VertexEmpty, VertexEmpty> where TvG : struct, IVertexGeometry
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x63451F0", Offset = "0x63441F0", VA = "0x1863451F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7CAC60", Offset = "0xA7C9C60", VA = "0x18A7CAC60")]
		public static VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>[] GetMorphTargetVertices(this IPrimitiveMorphTargetReader morphTarget, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E290", Offset = "0x3D2D290", VA = "0x183D2E290")]
		public static EncodingType GetOptimalIndexEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EE80", Offset = "0x3D2DE80", VA = "0x183D2EE80")]
		public static EncodingType GetOptimalJointEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DBF0", Offset = "0x3D2CBF0", VA = "0x183D2DBF0")]
		public static IMeshBuilder<TMaterial> CreateMeshBuilderFromVertexAttributes<TMaterial>(params string[] vertexAttributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CFA0", Offset = "0x3D2BFA0", VA = "0x183D2CFA0")]
		public static IReadOnlyDictionary<Vector3, Vector3> CalculateSmoothNormals<TMaterial>(this IMeshBuilder<TMaterial> srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F470", Offset = "0x3D2E470", VA = "0x183D2F470")]
		public static bool IsEmpty<TMaterial>(this IPrimitiveReader<TMaterial> primitive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F800", Offset = "0x3D2E800", VA = "0x183D2F800")]
		public static bool IsEmpty<TMaterial>(this IMeshBuilder<TMaterial> mesh)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7CADF0", Offset = "0xA7C9DF0", VA = "0x18A7CADF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x768EBA0", Offset = "0x768DBA0", VA = "0x18768EBA0")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x768EC30", Offset = "0x768DC30", VA = "0x18768EC30")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc, PrimitiveMorphTargetBuilder<TvG, TvM> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x768B1A0", Offset = "0x768A1A0", VA = "0x18768B1A0", Slot = "4")]
		public IReadOnlyCollection<int> GetTargetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x768B6E0", Offset = "0x768A6E0", VA = "0x18768B6E0", Slot = "6")]
		public VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex)
		{
			return default(VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x768CDD0", Offset = "0x768BDD0", VA = "0x18768CDD0")]
		public void SetVertexDelta(int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x768D9F0", Offset = "0x768C9F0", VA = "0x18768D9F0", Slot = "5")]
		IVertexBuilder IPrimitiveMorphTargetReader.GetVertex(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x768BBA0", Offset = "0x768ABA0", VA = "0x18768BBA0")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex(int vertexIndex)
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x768D420", Offset = "0x768C420", VA = "0x18768D420")]
		public void SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x768EA20", Offset = "0x768DA20", VA = "0x18768EA20")]
		private void _SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x768E990", Offset = "0x768D990", VA = "0x18768E990")]
		private void _RemoveVertex(int vertexIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x768E3D0", Offset = "0x768D3D0", VA = "0x18768E3D0")]
		internal void TransformVertices(Func<VertexBuilder<TvG, TvM, VertexEmpty>, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x768BCD0", Offset = "0x768ACD0", VA = "0x18768BCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7174210", Offset = "0x7173210", VA = "0x187174210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x71741E0", Offset = "0x71731E0", VA = "0x1871741E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		IReadOnlyCollection<IVertexGeometry> IMorphTargetBuilder.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x7170650", Offset = "0x716F650", VA = "0x187170650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7173B60", Offset = "0x7172B60", VA = "0x187173B60")]
		internal MorphTargetBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x71624A0", Offset = "0x71614A0", VA = "0x1871624A0")]
		public IReadOnlyList<TvG> GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7164810", Offset = "0x7163810", VA = "0x187164810")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7163B70", Offset = "0x7162B70", VA = "0x187163B70")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x716AE50", Offset = "0x7169E50", VA = "0x18716AE50")]
		public void SetVertex(TvG meshVertex, VertexBuilder<TvG, TvM, VertexEmpty> morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7168150", Offset = "0x7167150", VA = "0x187168150")]
		public void SetVertex(TvG meshVertex, TvG morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x716BC60", Offset = "0x716AC60", VA = "0x18716BC60", Slot = "6")]
		IReadOnlyList<IVertexGeometry> IMorphTargetBuilder.GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x716F040", Offset = "0x716E040", VA = "0x18716F040", Slot = "7")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x716E5E0", Offset = "0x716D5E0", VA = "0x18716E5E0", Slot = "8")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x716E2C0", Offset = "0x716D2C0", VA = "0x18716E2C0", Slot = "9")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x716CD70", Offset = "0x716BD70", VA = "0x18716CD70", Slot = "10")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7164D50", Offset = "0x7163D50", VA = "0x187164D50", Slot = "11")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7165F50", Offset = "0x7164F50", VA = "0x187165F50", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7CBC40", Offset = "0xA7CAC40", VA = "0x18A7CBC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA7CB2D0", Offset = "0xA7CA2D0", VA = "0x18A7CB2D0")]
		public void AddAccessors(params MemoryAccessor[] accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA7CB4A0", Offset = "0xA7CA4A0", VA = "0x18A7CB4A0")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA7CBBC0", Offset = "0xA7CABC0", VA = "0x18A7CBBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DAD230", Offset = "0x3DAC230", VA = "0x183DAD230")]
		public void AdjustJointEncoding<TVertex>(IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <CreatePackedMeshes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x65B9920", Offset = "0x65B8920", VA = "0x1865B9920", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x65B8E30", Offset = "0x65B7E30", VA = "0x1865B8E30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x65B9A70", Offset = "0x65B8A70", VA = "0x1865B9A70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x65B95C0", Offset = "0x65B85C0", VA = "0x1865B95C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<PackedMeshBuilder<TMaterial>> IEnumerable<PackedMeshBuilder<TMaterial>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x65B9770", Offset = "0x65B8770", VA = "0x1865B9770", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7509EA0", Offset = "0x7508EA0", VA = "0x187509EA0")]
		[IteratorStateMachine(typeof(PackedMeshBuilder<>.<CreatePackedMeshes>d__0))]
		internal static IEnumerable<PackedMeshBuilder<TMaterial>> CreatePackedMeshes(IEnumerable<IMeshBuilder<TMaterial>> meshBuilders, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x750B4B0", Offset = "0x750A4B0", VA = "0x18750B4B0")]
		private static PackedMeshBuilder<TMaterial> Create(IMeshBuilder<TMaterial> srcMesh, PackedEncoding vertexEncodings, EncodingType indexEncoding, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x750C820", Offset = "0x750B820", VA = "0x18750C820")]
		private PackedMeshBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7509A60", Offset = "0x7508A60", VA = "0x187509A60")]
		public PackedPrimitiveBuilder<TMaterial> AddPrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7509F70", Offset = "0x7508F70", VA = "0x187509F70")]
		public Mesh CreateSchema2Mesh(ModelRoot root, Converter<TMaterial, Material> materialEvaluator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x750C570", Offset = "0x750B570", VA = "0x18750C570")]
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
		[Cpp2IlInjected.Address(RVA = "0x7514D00", Offset = "0x7513D00", VA = "0x187514D00")]
		public PackedPrimitiveBuilder(TMaterial material, int primitiveVertexCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7512AF0", Offset = "0x7511AF0", VA = "0x187512AF0")]
		public void SetStridedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7511FE0", Offset = "0x7510FE0", VA = "0x187511FE0")]
		public void SetStreamedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x750EFD0", Offset = "0x750DFD0", VA = "0x18750EFD0")]
		public void SetIndices(IPrimitiveReader<TMaterial> srcPrim, EncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x7510640", Offset = "0x750F640", VA = "0x187510640")]
		public void SetMorphTargets(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncodings, ISet<string> morphTargetAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x750CD80", Offset = "0x750BD80", VA = "0x18750CD80")]
		private void AddMorphTarget(params MemoryAccessor[] morphTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x750D7D0", Offset = "0x750C7D0", VA = "0x18750D7D0")]
		internal void CopyToMesh(Mesh dstMesh, Converter<TMaterial, Material> materialEvaluator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x750D160", Offset = "0x750C160", VA = "0x18750D160")]
		private void CopyMorphTargets(MeshPrimitive dstPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x750E550", Offset = "0x750D550", VA = "0x18750E550")]
		public static void MergeBuffers(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7513B30", Offset = "0x7512B30", VA = "0x187513B30")]
		private static void _MergeSequentialVertices(IEnumerable<MemoryAccessor[]> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7514720", Offset = "0x7513720", VA = "0x187514720")]
		private static void _MergeStridedVertices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x75130B0", Offset = "0x75120B0", VA = "0x1875130B0")]
		private static void _MergeIndices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal static class _PackedPrimitiveHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x4160160", Offset = "0x415F160", VA = "0x184160160")]
		public static void _GatherMorphTargetAttributes<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, HashSet<string> attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x41609A0", Offset = "0x415F9A0", VA = "0x1841609A0")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x6E07420", Offset = "0x6E06420", VA = "0x186E07420", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x6E03F50", Offset = "0x6E02F50", VA = "0x186E03F50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x6E07FD0", Offset = "0x6E06FD0", VA = "0x186E07FD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			IVertexBuilder IReadOnlyList<IVertexBuilder>.this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600057C")]
				[Cpp2IlInjected.Address(RVA = "0x8714390", Offset = "0x8713390", VA = "0x188714390", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x8713D90", Offset = "0x8712D90", VA = "0x188713D90", Slot = "10")]
			[IteratorStateMachine(typeof(PrimitiveBuilder<, , , >.VertexListWrapper.<System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2))]
			IEnumerator<IVertexBuilder> IEnumerable<IVertexBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x8715DB0", Offset = "0x8714DB0", VA = "0x188715DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x7581E10", Offset = "0x7580E10", VA = "0x187581E10", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x757FFB0", Offset = "0x757EFB0", VA = "0x18757FFB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<VertexBuilder<TvG, TvM, TvS>> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		IReadOnlyList<IVertexBuilder> IPrimitiveReader<TMaterial>.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		IReadOnlyList<IPrimitiveMorphTargetReader> IPrimitiveReader<TMaterial>.MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public virtual IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x757F290", Offset = "0x757E290", VA = "0x18757F290", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public virtual IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x757F050", Offset = "0x757E050", VA = "0x18757F050", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public virtual IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x757FA10", Offset = "0x757EA10", VA = "0x18757FA10", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public virtual IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x757F620", Offset = "0x757E620", VA = "0x18757F620", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		internal IReadOnlyList<PrimitiveMorphTargetBuilder<TvG, TvM>> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x757B810", Offset = "0x757A810", VA = "0x18757B810")]
		internal PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x757E3F0", Offset = "0x757D3F0", VA = "0x18757E3F0")]
		protected PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		internal abstract PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7577710", Offset = "0x7576710", VA = "0x187577710")]
		internal PrimitiveMorphTargetBuilder<TvG, TvM> _UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x7576770", Offset = "0x7575770", VA = "0x187576770")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x756ABA0", Offset = "0x7569BA0", VA = "0x18756ABA0")]
		private static VertexBuilder<TvG, TvM, TvS> ConvertVertex(IVertexBuilder vertex)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x75713C0", Offset = "0x75703C0", VA = "0x1875713C0")]
		protected int UseVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x756B7F0", Offset = "0x756A7F0", VA = "0x18756B7F0", Slot = "6")]
		void IPrimitiveBuilder.SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x756A8D0", Offset = "0x75698D0", VA = "0x18756A8D0")]
		public bool ContainsVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x755D470", Offset = "0x755C470", VA = "0x18755D470", Slot = "7")]
		public int AddPoint(IVertexBuilder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x75591A0", Offset = "0x75581A0", VA = "0x1875591A0", Slot = "8")]
		public (int, int) AddLine(IVertexBuilder a, IVertexBuilder b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7568210", Offset = "0x7567210", VA = "0x187568210", Slot = "9")]
		public (int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x75637F0", Offset = "0x75627F0", VA = "0x1875637F0", Slot = "10")]
		public (int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x7560600", Offset = "0x755F600", VA = "0x187560600")]
		internal void AddPrimitive(PrimitiveBuilder<TMaterial, TvG, TvM, TvS> primitive, Converter<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3A19440", Offset = "0x3A18440", VA = "0x183A19440")]
		internal void AddPrimitive<TAnyMaterial>(IPrimitiveReader<TAnyMaterial> primitive, Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x756C4A0", Offset = "0x756B4A0", VA = "0x18756C4A0")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract IReadOnlyList<int> GetIndices();

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x755BA30", Offset = "0x755AA30", VA = "0x18755BA30", Slot = "28")]
		public virtual int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7558EF0", Offset = "0x7557EF0", VA = "0x187558EF0", Slot = "29")]
		public virtual (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7566270", Offset = "0x7565270", VA = "0x187566270", Slot = "30")]
		public virtual (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x7560E40", Offset = "0x755FE40", VA = "0x187560E40", Slot = "31")]
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
				[Cpp2IlInjected.Address(RVA = "0xD6F990", Offset = "0xD6E990", VA = "0x180D6F990", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x753DD60", Offset = "0x753CD60", VA = "0x18753DD60", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
			public PointListWrapper(IReadOnlyList<T> vertices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x75348E0", Offset = "0x75338E0", VA = "0x1875348E0", Slot = "6")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x753D3C0", Offset = "0x753C3C0", VA = "0x18753D3C0", Slot = "7")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x7544F90", Offset = "0x7543F90", VA = "0x187544F90", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7544E30", Offset = "0x7543E30", VA = "0x187544E30")]
		internal PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7544220", Offset = "0x7543220", VA = "0x187544220", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7544CB0", Offset = "0x7543CB0", VA = "0x187544CB0")]
		private PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x75425D0", Offset = "0x75415D0", VA = "0x1875425D0", Slot = "28")]
		public override int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x75446A0", Offset = "0x75436A0", VA = "0x1875446A0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x69CE920", Offset = "0x69CD920", VA = "0x1869CE920")]
		internal LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x69C77B0", Offset = "0x69C67B0", VA = "0x1869C77B0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x69CFFA0", Offset = "0x69CEFA0", VA = "0x1869CFFA0")]
		private LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x69C5100", Offset = "0x69C4100", VA = "0x1869C5100", Slot = "29")]
		public override (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x69CAEC0", Offset = "0x69C9EC0", VA = "0x1869CAEC0", Slot = "27")]
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
					[Cpp2IlInjected.Address(RVA = "0x1A191E0", Offset = "0x1A181E0", VA = "0x181A191E0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x675DD10", Offset = "0x675CD10", VA = "0x18675DD10", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x675BB70", Offset = "0x675AB70", VA = "0x18675BB70", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6F4BD00", Offset = "0x6F4AD00", VA = "0x186F4BD00", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7D63D30", Offset = "0x7D62D30", VA = "0x187D63D30", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public (int A, int B, int C) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x7D659F0", Offset = "0x7D649F0", VA = "0x187D659F0", Slot = "4")]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public TriangleList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x7D63B00", Offset = "0x7D62B00", VA = "0x187D63B00", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB0000", Offset = "0x7BAF000", VA = "0x187BB0000", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x23CD5D0", Offset = "0x23CC5D0", VA = "0x1823CD5D0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x675DE50", Offset = "0x675CE50", VA = "0x18675DE50", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x675A500", Offset = "0x6759500", VA = "0x18675A500", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x6F4FE60", Offset = "0x6F4EE60", VA = "0x186F4FE60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BB04B0", Offset = "0x7BAF4B0", VA = "0x187BB04B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public (int A, int B, int C, int? D) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x7BB4890", Offset = "0x7BB3890", VA = "0x187BB4890", Slot = "4")]
				get
				{
					return default((int, int, int, int?));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public SurfaceList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x7BAFF50", Offset = "0x7BAEF50", VA = "0x187BAFF50", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int, int?)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7BB0000", Offset = "0x7BAF000", VA = "0x187BB0000", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public override IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7D82830", Offset = "0x7D81830", VA = "0x187D82830", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7D827D0", Offset = "0x7D817D0", VA = "0x187D827D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D81D50", Offset = "0x7D80D50", VA = "0x187D81D50")]
		internal TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F940", Offset = "0x7D7E940", VA = "0x187D7F940", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D82210", Offset = "0x7D81210", VA = "0x187D82210")]
		private TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E9A0", Offset = "0x7D7D9A0", VA = "0x187D7E9A0", Slot = "30")]
		public override (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E010", Offset = "0x7D7D010", VA = "0x187D7E010", Slot = "31")]
		public override (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D81060", Offset = "0x7D80060", VA = "0x187D81060")]
		private (int, int, int) _AddTriangle([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b, [In] VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D80520", Offset = "0x7D7F520", VA = "0x187D80520", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x7158210", Offset = "0x7157210", VA = "0x187158210", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7156FD0", Offset = "0x7155FD0", VA = "0x187156FD0")]
		public static IReadOnlyDictionary<IPrimitiveReader<TMaterial>, MeshPrimitiveNormalsAndTangents<TMaterial>> GenerateNormalsTangents(IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		private MeshPrimitiveNormalsAndTangents(IPrimitiveReader<TMaterial> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7157990", Offset = "0x7156990", VA = "0x187157990", Slot = "13")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7157BB0", Offset = "0x7156BB0", VA = "0x187157BB0", Slot = "9")]
		public Vector3 GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x71579E0", Offset = "0x71569E0", VA = "0x1871579E0", Slot = "10")]
		public Vector3 GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7157D20", Offset = "0x7156D20", VA = "0x187157D20")]
		public Vector4 GetVertexTangent(int idx)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7157ED0", Offset = "0x7156ED0", VA = "0x187157ED0", Slot = "11")]
		public Vector2 GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7158060", Offset = "0x7157060", VA = "0x187158060", Slot = "6")]
		public void SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7158140", Offset = "0x7157140", VA = "0x187158140", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0xA801140", Offset = "0xA800140", VA = "0x18A801140", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _NormalTangentAgent(VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0", Slot = "13")]
			public IEnumerable<(int, int, int)> GetTriangleIndices()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA800D50", Offset = "0xA7FFD50", VA = "0x18A800D50", Slot = "9")]
			public Vector3 GetVertexPosition(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA800C60", Offset = "0xA7FFC60", VA = "0x18A800C60", Slot = "10")]
			public Vector3 GetVertexNormal(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA800E40", Offset = "0xA7FFE40", VA = "0x18A800E40", Slot = "11")]
			public Vector2 GetVertexTexCoord(int idx)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA800EA0", Offset = "0xA7FFEA0", VA = "0x18A800EA0", Slot = "6")]
			public void SetVertexNormal(int idx, Vector3 normal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA800FF0", Offset = "0xA7FFFF0", VA = "0x18A800FF0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IList<Vector3> Normals
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IList<Vector4> Tangents
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public IList<Vector4> Colors0
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public IList<Vector4> Colors1
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IList<Vector2> TexCoords0
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5E0", Offset = "0xD0E5E0", VA = "0x180D0F5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public IList<Vector2> TexCoords1
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xD0F420", Offset = "0xD0E420", VA = "0x180D0F420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public IList<Vector2> TexCoords2
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5C0", Offset = "0xD0E5C0", VA = "0x180D0F5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public IList<Vector2> TexCoords3
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public IList<Vector4> Joints0
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xD09160", Offset = "0xD08160", VA = "0x180D09160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public IList<Vector4> Joints1
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xD09130", Offset = "0xD08130", VA = "0x180D09130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xD09140", Offset = "0xD08140", VA = "0x180D09140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IList<Vector4> Weights0
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xD09760", Offset = "0xD08760", VA = "0x180D09760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public IList<Vector4> Weights1
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xD09730", Offset = "0xD08730", VA = "0x180D09730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xD09740", Offset = "0xD08740", VA = "0x180D09740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public IReadOnlyList<VertexBufferColumns> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xA7D9970", Offset = "0xA7D8970", VA = "0x18A7D9970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public VertexBufferColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7D97C0", Offset = "0xA7D87C0", VA = "0x18A7D97C0")]
		public VertexBufferColumns(VertexBufferColumns other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x40F2BA0", Offset = "0x40F1BA0", VA = "0x1840F2BA0")]
		private static T[] _IsolateColumn<T>(IList<T> column)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA7D6C70", Offset = "0xA7D5C70", VA = "0x18A7D6C70")]
		public void IsolateColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA7D6F40", Offset = "0xA7D5F40", VA = "0x18A7D6F40")]
		public VertexBufferColumns WithTransform(IGeometryTransform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA7D7040", Offset = "0xA7D6040", VA = "0x18A7D7040")]
		private void _ApplyTransform(IGeometryTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA7D93E0", Offset = "0xA7D83E0", VA = "0x18A7D93E0")]
		private void _FillMorphData(Vector2[] array, Converter<VertexBufferColumns, Vector2> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA7D9600", Offset = "0xA7D8600", VA = "0x18A7D9600")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector3> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA7D94C0", Offset = "0xA7D84C0", VA = "0x18A7D94C0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA7D96E0", Offset = "0xA7D86E0", VA = "0x18A7D96E0")]
		private void _FillMorphData(Vector4[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA7D64F0", Offset = "0xA7D54F0", VA = "0x18A7D64F0")]
		public VertexBufferColumns AddMorphTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA7D6980", Offset = "0xA7D5980", VA = "0x18A7D6980")]
		public (Type, Func<IVertexBuilder>) GetCompatibleVertexType()
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x40F05F0", Offset = "0x40EF5F0", VA = "0x1840F05F0")]
		private TvG GetVertexGeometry<TvG>(int index) where TvG : struct, IVertexGeometry
		{
			return (TvG)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x40F1220", Offset = "0x40F0220", VA = "0x1840F1220")]
		private TvM GetVertexMaterial<TvM>(int index) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40F1F80", Offset = "0x40F0F80", VA = "0x1840F1F80")]
		private TvS GetVertexSkinning<TvS>(int index) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA7D6AB0", Offset = "0xA7D5AB0", VA = "0x18A7D6AB0")]
		public IVertexBuilder GetVertex(Func<IVertexBuilder> factory, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x40F27B0", Offset = "0x40F17B0", VA = "0x1840F27B0")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex<TvG, TvM>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x40F29C0", Offset = "0x40F19C0", VA = "0x1840F29C0")]
		public VertexBuilder<TvG, TvM, TvS> GetVertex<TvG, TvM, TvS>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA7D6620", Offset = "0xA7D5620", VA = "0x18A7D6620")]
		public static void CalculateSmoothNormals(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA7D67D0", Offset = "0xA7D57D0", VA = "0x18A7D67D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85E7050", Offset = "0x85E6050", VA = "0x1885E7050")]
			readonly get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x85E8A20", Offset = "0x85E7A20", VA = "0x1885E8A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x85E3B00", Offset = "0x85E2B00", VA = "0x1885E3B00")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x85E3200", Offset = "0x85E2200", VA = "0x1885E3200")]
		private static string _GetDebuggerDisplayTextFrom(object o)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x85E1B60", Offset = "0x85E0B60", VA = "0x1885E1B60")]
		private readonly string _GetDebugWarnings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x85E69A0", Offset = "0x85E59A0", VA = "0x1885E69A0")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x85E6840", Offset = "0x85E5840", VA = "0x1885E6840")]
		public VertexBuilder([In] TvG g, [In] TvM m, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x85E63C0", Offset = "0x85E53C0", VA = "0x1885E63C0")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x85E6EC0", Offset = "0x85E5EC0", VA = "0x1885E6EC0")]
		public VertexBuilder([In] TvG g, [In] TvM m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x85E6BD0", Offset = "0x85E5BD0", VA = "0x1885E6BD0")]
		public VertexBuilder([In] TvG g, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x85E56E0", Offset = "0x85E46E0", VA = "0x1885E56E0")]
		public VertexBuilder([In] TvG g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x85E6550", Offset = "0x85E5550", VA = "0x1885E6550")]
		public VertexBuilder([In] TvG g, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x85E5E80", Offset = "0x85E4E80", VA = "0x1885E5E80")]
		public VertexBuilder(TvG g, SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x85E7E70", Offset = "0x85E6E70", VA = "0x1885E7E70")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x85E76D0", Offset = "0x85E66D0", VA = "0x1885E76D0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x85E8280", Offset = "0x85E7280", VA = "0x1885E8280")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x85E7D90", Offset = "0x85E6D90", VA = "0x1885E7D90")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] TvG g)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x85D30D0", Offset = "0x85D20D0", VA = "0x1885D30D0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x85D3270", Offset = "0x85D2270", VA = "0x1885D3270")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x85D2ED0", Offset = "0x85D1ED0", VA = "0x1885D2ED0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x85D0D20", Offset = "0x85CFD20", VA = "0x1885D0D20")]
		public static VertexBuilder<TvG, TvM, TvS> CreateFrom(IVertexBuilder src)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x85D4AB0", Offset = "0x85D3AB0", VA = "0x1885D4AB0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x85D4870", Offset = "0x85D3870", VA = "0x1885D4870", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x85D4A60", Offset = "0x85D3A60", VA = "0x1885D4A60", Slot = "11")]
		public readonly bool Equals(VertexBuilder<TvG, TvM, TvS> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x85E7130", Offset = "0x85E6130", VA = "0x1885E7130")]
		public static bool operator ==([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x85E89D0", Offset = "0x85E79D0", VA = "0x1885E89D0")]
		public static bool operator !=([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x85CF940", Offset = "0x85CE940", VA = "0x1885CF940")]
		public static bool AreEqual([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x85D7B00", Offset = "0x85D6B00", VA = "0x1885D7B00")]
		public readonly void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AA30", Offset = "0x3C09A30", VA = "0x183C0AA30")]
		public static MeshBuilder<TMaterial, TvG, TvM, TvS> CreateCompatibleMesh<TMaterial>([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x85D01B0", Offset = "0x85CF1B0", VA = "0x1885D01B0")]
		public static MeshBuilder<TvG, TvM, TvS> CreateCompatibleMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x41A1200", Offset = "0x41A0200", VA = "0x1841A1200", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x85D4BA0", Offset = "0x85D3BA0", VA = "0x1885D4BA0", Slot = "4")]
		readonly IVertexGeometry IVertexBuilder.GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x85D4C80", Offset = "0x85D3C80", VA = "0x1885D4C80", Slot = "5")]
		readonly IVertexMaterial IVertexBuilder.GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x85D4E10", Offset = "0x85D3E10", VA = "0x1885D4E10", Slot = "6")]
		readonly IVertexSkinning IVertexBuilder.GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x85D54D0", Offset = "0x85D44D0", VA = "0x1885D54D0", Slot = "7")]
		void IVertexBuilder.SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x85D6260", Offset = "0x85D5260", VA = "0x1885D6260", Slot = "8")]
		void IVertexBuilder.SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x85D7150", Offset = "0x85D6150", VA = "0x1885D7150", Slot = "9")]
		void IVertexBuilder.SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x85D7660", Offset = "0x85D6660", VA = "0x1885D7660")]
		public readonly VertexBuilder<TvG, TvM, TvS> TransformedBy([In] Matrix4x4 transform)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x85D9160", Offset = "0x85D8160", VA = "0x1885D9160")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x85D9BC0", Offset = "0x85D8BC0", VA = "0x1885D9BC0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x85D8720", Offset = "0x85D7720", VA = "0x1885D8720")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x85DB710", Offset = "0x85DA710", VA = "0x1885DB710")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial(params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x85DCFB0", Offset = "0x85DBFB0", VA = "0x1885DCFB0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x85DC260", Offset = "0x85DB260", VA = "0x1885DC260")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, Vector4 color1, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x85DDFC0", Offset = "0x85DCFC0", VA = "0x1885DDFC0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning([In] SparseWeight8 sparse)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x85DEBD0", Offset = "0x85DDBD0", VA = "0x1885DEBD0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(params (int Index, float Weight)[] bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x85DDDC0", Offset = "0x85DCDC0", VA = "0x1885DDDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7E5950", Offset = "0xA7E4950", VA = "0x18A7E5950")]
		public VertexBuilder(IVertexGeometry g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public VertexBuilder(IVertexGeometry g, IVertexMaterial m, IVertexSkinning s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x14BB4C0", Offset = "0x14BA4C0", VA = "0x1814BB4C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900", Slot = "4")]
		public readonly IVertexGeometry GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0", Slot = "5")]
		public readonly IVertexMaterial GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "6")]
		public readonly IVertexSkinning GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920", Slot = "7")]
		public void SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xF429E0", Offset = "0xF419E0", VA = "0x180F429E0", Slot = "8")]
		public void SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470", Slot = "9")]
		public void SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA7E58A0", Offset = "0xA7E48A0", VA = "0x18A7E58A0")]
		public readonly IVertexBuilder ConvertToType(Func<IVertexBuilder> factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3C25D10", Offset = "0x3C24D10", VA = "0x183C25D10", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			[CompilerGenerated]
			get
			{
				return default(EncodingType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xD13CA0", Offset = "0xD12CA0", VA = "0x180D13CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB1930", VA = "0x180EB2930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xED6F40", Offset = "0xED5F40", VA = "0x180ED6F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5800", Offset = "0xA7E4800", VA = "0x18A7E5800")]
		public VertexAttributeAttribute(string attributeName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5840", Offset = "0xA7E4840", VA = "0x18A7E5840")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E1090", Offset = "0xA7E0090", VA = "0x18A7E1090", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x1018420", Offset = "0x1017420", VA = "0x181018420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1050", Offset = "0xA7E0050", VA = "0x18A7E1050", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0FB0", Offset = "0xA7DFFB0", VA = "0x18A7E0FB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0FB0", Offset = "0xA7DFFB0", VA = "0x18A7E0FB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "21")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB990", Offset = "0xA7EA990", VA = "0x18A7EB990", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB620", Offset = "0xA7EA620", VA = "0x18A7EB620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "22")]
		public bool Equals(VertexEmpty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0")]
		public static bool operator ==([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280")]
		public static bool operator !=([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB7B0", Offset = "0xA7EA7B0", VA = "0x18A7EB7B0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB800", Offset = "0xA7EA800", VA = "0x18A7EB800", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB850", Offset = "0xA7EA850", VA = "0x18A7EB850", Slot = "10")]
		VertexMaterialDelta IVertexMaterial.Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB710", Offset = "0xA7EA710", VA = "0x18A7EB710", Slot = "6")]
		Vector4 IVertexMaterial.GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB760", Offset = "0xA7EA760", VA = "0x18A7EB760", Slot = "7")]
		Vector2 IVertexMaterial.GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB670", Offset = "0xA7EA670", VA = "0x18A7EB670", Slot = "17")]
		public SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB6D0", Offset = "0xA7EA6D0", VA = "0x18A7EB6D0")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB690", Offset = "0xA7EA690", VA = "0x18A7EB690", Slot = "16")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBA00", Offset = "0xA7EAA00", VA = "0x18A7EBA00", Slot = "14")]
		(int, float) IVertexSkinning.GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBA50", Offset = "0xA7EAA50", VA = "0x18A7EBA50", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E23F0", Offset = "0xA7E13F0", VA = "0x18A7E23F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1690", Offset = "0xA7E0690", VA = "0x18A7E1690", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2210", Offset = "0xA7E1210", VA = "0x18A7E2210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1F50", Offset = "0xA7E0F50", VA = "0x18A7E1F50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1F50", Offset = "0xA7E0F50", VA = "0x18A7E1F50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7F1B80", Offset = "0xA7F0B80", VA = "0x18A7F1B80")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBB40", Offset = "0x2DEAB40", VA = "0x182DEBB40")]
		public VertexPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1C00", Offset = "0xA7F0C00", VA = "0x18A7F1C00")]
		public VertexPosition(float px, float py, float pz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1C40", Offset = "0xA7F0C40", VA = "0x18A7F1C40")]
		public VertexPosition(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B50", Offset = "0x2DE8B50", VA = "0x182DE9B50")]
		public static implicit operator VertexPosition([In] Vector3 position)
		{
			return default(VertexPosition);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7F19D0", Offset = "0xA7F09D0", VA = "0x18A7F19D0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBD80", Offset = "0xA7EAD80", VA = "0x18A7EBD80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1900", Offset = "0xA7F0900", VA = "0x18A7F1900", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7F18B0", Offset = "0xA7F08B0", VA = "0x18A7F18B0", Slot = "14")]
		public readonly bool Equals(VertexPosition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7F18B0", Offset = "0xA7F08B0", VA = "0x18A7F18B0")]
		public static bool operator ==([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1D80", Offset = "0xA7F0D80", VA = "0x18A7F1D80")]
		public static bool operator !=([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7F18B0", Offset = "0xA7F08B0", VA = "0x18A7F18B0")]
		public static bool AreEqual([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBB40", Offset = "0x2DEAB40", VA = "0x182DEBB40", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		readonly void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1A40", Offset = "0xA7F0A40", VA = "0x18A7F1A40", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA7F16D0", Offset = "0xA7F06D0", VA = "0x18A7F16D0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B50", Offset = "0x2DE8B50", VA = "0x182DE9B50", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1B70", Offset = "0xA7F0B70", VA = "0x18A7F1B70", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x17516C0", Offset = "0x17506C0", VA = "0x1817516C0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1740", Offset = "0xA7F0740", VA = "0x18A7F1740")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7F19C0", Offset = "0xA7F09C0", VA = "0x18A7F19C0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7F16D0", Offset = "0xA7F06D0", VA = "0x18A7F16D0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E38F0", Offset = "0xA7E28F0", VA = "0x18A7E38F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2760", Offset = "0xA7E1760", VA = "0x18A7E2760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xA7E37C0", Offset = "0xA7E27C0", VA = "0x18A7E37C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA7E33E0", Offset = "0xA7E23E0", VA = "0x18A7E33E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xA7E33E0", Offset = "0xA7E23E0", VA = "0x18A7E33E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7F13F0", Offset = "0xA7F03F0", VA = "0x18A7F13F0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1650", Offset = "0xA7F0650", VA = "0x18A7F1650")]
		public VertexPositionNormal([In] Vector3 p, [In] Vector3 n)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7F15C0", Offset = "0xA7F05C0", VA = "0x18A7F15C0")]
		public VertexPositionNormal(float px, float py, float pz, float nx, float ny, float nz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1470", Offset = "0xA7F0470", VA = "0x18A7F1470")]
		public VertexPositionNormal(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1680", Offset = "0xA7F0680", VA = "0x18A7F1680")]
		public static implicit operator VertexPositionNormal([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexPositionNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7F12B0", Offset = "0xA7F02B0", VA = "0x18A7F12B0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBD80", Offset = "0xA7EAD80", VA = "0x18A7EBD80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1160", Offset = "0xA7F0160", VA = "0x18A7F1160", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1270", Offset = "0xA7F0270", VA = "0x18A7F1270", Slot = "14")]
		public readonly bool Equals(VertexPositionNormal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1670", Offset = "0xA7F0670", VA = "0x18A7F1670")]
		public static bool operator ==([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7F16B0", Offset = "0xA7F06B0", VA = "0x18A7F16B0")]
		public static bool operator !=([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7F10E0", Offset = "0xA7F00E0", VA = "0x18A7F10E0")]
		public static bool AreEqual([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBB40", Offset = "0x2DEAB40", VA = "0x182DEBB40", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDD0", Offset = "0xA7EADD0", VA = "0x18A7EBDD0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1330", Offset = "0xA7F0330", VA = "0x18A7F1330", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0DC0", Offset = "0xA7EFDC0", VA = "0x18A7F0DC0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B50", Offset = "0x2DE8B50", VA = "0x182DE9B50", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBF70", Offset = "0xA7EAF70", VA = "0x18A7EBF70", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x17516C0", Offset = "0x17506C0", VA = "0x1817516C0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0E90", Offset = "0xA7EFE90", VA = "0x18A7F0E90")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7F12A0", Offset = "0xA7F02A0", VA = "0x18A7F12A0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1290", Offset = "0xA7F0290", VA = "0x18A7F1290", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E3990", Offset = "0xA7E2990", VA = "0x18A7E3990", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2E40", Offset = "0xA7E1E40", VA = "0x18A7E2E40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA7E36C0", Offset = "0xA7E26C0", VA = "0x18A7E36C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3290", Offset = "0xA7E2290", VA = "0x18A7E3290", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3290", Offset = "0xA7E2290", VA = "0x18A7E3290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7F0B30", Offset = "0xA7EFB30", VA = "0x18A7F0B30")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0BC0", Offset = "0xA7EFBC0", VA = "0x18A7F0BC0")]
		public VertexPositionNormalTangent([In] Vector3 p, [In] Vector3 n, [In] Vector4 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0BF0", Offset = "0xA7EFBF0", VA = "0x18A7F0BF0")]
		public VertexPositionNormalTangent(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0D70", Offset = "0xA7EFD70", VA = "0x18A7F0D70")]
		public static implicit operator VertexPositionNormalTangent([In] (Vector3 Pos, Vector3 Nrm, Vector4 Tgt) tuple)
		{
			return default(VertexPositionNormalTangent);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7F09E0", Offset = "0xA7EF9E0", VA = "0x18A7F09E0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBD80", Offset = "0xA7EAD80", VA = "0x18A7EBD80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0850", Offset = "0xA7EF850", VA = "0x18A7F0850", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA7F09A0", Offset = "0xA7EF9A0", VA = "0x18A7F09A0", Slot = "14")]
		public readonly bool Equals(VertexPositionNormalTangent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0D60", Offset = "0xA7EFD60", VA = "0x18A7F0D60")]
		public static bool operator ==([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0DA0", Offset = "0xA7EFDA0", VA = "0x18A7F0DA0")]
		public static bool operator !=([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA7F07B0", Offset = "0xA7EF7B0", VA = "0x18A7F07B0")]
		public static bool AreEqual([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBB40", Offset = "0x2DEAB40", VA = "0x182DEBB40", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDD0", Offset = "0xA7EADD0", VA = "0x18A7EBDD0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF87E50", Offset = "0xF86E50", VA = "0x180F87E50", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0A60", Offset = "0xA7EFA60", VA = "0x18A7F0A60", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA7F02C0", Offset = "0xA7EF2C0", VA = "0x18A7F02C0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B50", Offset = "0x2DE8B50", VA = "0x182DE9B50", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBF70", Offset = "0xA7EAF70", VA = "0x18A7EBF70", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0B20", Offset = "0xA7EFB20", VA = "0x18A7F0B20", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0430", Offset = "0xA7EF430", VA = "0x18A7F0430")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA7F09D0", Offset = "0xA7EF9D0", VA = "0x18A7F09D0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F09C0", Offset = "0xA7EF9C0", VA = "0x18A7F09C0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E0A00", Offset = "0xA7DFA00", VA = "0x18A7E0A00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0700", Offset = "0xA7DF700", VA = "0x18A7E0700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xA7E09C0", Offset = "0xA7DF9C0", VA = "0x18A7E09C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0910", Offset = "0xA7DF910", VA = "0x18A7E0910", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0910", Offset = "0xA7DF910", VA = "0x18A7E0910", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7EBFE0", Offset = "0xA7EAFE0", VA = "0x18A7EBFE0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC850", Offset = "0xA7EB850", VA = "0x18A7EC850")]
		public static implicit operator VertexGeometryDelta([In] Vector3 position)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC7F0", Offset = "0xA7EB7F0", VA = "0x18A7EC7F0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC7B0", Offset = "0xA7EB7B0", VA = "0x18A7EC7B0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm, Vector3 tgt) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC3A0", Offset = "0xA7EB3A0", VA = "0x18A7EC3A0")]
		public VertexGeometryDelta(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC1D0", Offset = "0xA7EB1D0", VA = "0x18A7EC1D0")]
		public VertexGeometryDelta([In] Vector3 p, [In] Vector3 n, [In] Vector3 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC6F0", Offset = "0xA7EB6F0", VA = "0x18A7EC6F0")]
		internal VertexGeometryDelta([In] VertexPosition rootVal, [In] VertexPosition morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC0C0", Offset = "0xA7EB0C0", VA = "0x18A7EC0C0")]
		internal VertexGeometryDelta([In] VertexPositionNormal rootVal, [In] VertexPositionNormal morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC210", Offset = "0xA7EB210", VA = "0x18A7EC210")]
		internal VertexGeometryDelta([In] VertexPositionNormalTangent rootVal, [In] VertexPositionNormalTangent morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC5C0", Offset = "0xA7EB5C0", VA = "0x18A7EC5C0")]
		internal VertexGeometryDelta([In] VertexGeometryDelta rootVal, [In] VertexGeometryDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBE30", Offset = "0xA7EAE30", VA = "0x18A7EBE30", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBD80", Offset = "0xA7EAD80", VA = "0x18A7EBD80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBCD0", Offset = "0xA7EACD0", VA = "0x18A7EBCD0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBCB0", Offset = "0xA7EACB0", VA = "0x18A7EBCB0", Slot = "14")]
		public readonly bool Equals(VertexGeometryDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC7A0", Offset = "0xA7EB7A0", VA = "0x18A7EC7A0")]
		public static bool operator ==([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC8D0", Offset = "0xA7EB8D0", VA = "0x18A7EC8D0")]
		public static bool operator !=([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBBF0", Offset = "0xA7EABF0", VA = "0x18A7EBBF0")]
		public static bool AreEqual([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2DEBB40", Offset = "0x2DEAB40", VA = "0x182DEBB40", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDD0", Offset = "0xA7EADD0", VA = "0x18A7EBDD0", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDE0", Offset = "0xA7EADE0", VA = "0x18A7EBDE0", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE9B50", Offset = "0x2DE8B50", VA = "0x182DE9B50", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBF70", Offset = "0xA7EAF70", VA = "0x18A7EBF70", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBF90", Offset = "0xA7EAF90", VA = "0x18A7EBF90", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBBB0", Offset = "0xA7EABB0", VA = "0x18A7EBBB0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBEB0", Offset = "0xA7EAEB0", VA = "0x18A7EBEB0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBA90", Offset = "0xA7EAA90", VA = "0x18A7EBA90")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDC0", Offset = "0xA7EADC0", VA = "0x18A7EBDC0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA7EBDB0", Offset = "0xA7EADB0", VA = "0x18A7EBDB0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E1470", Offset = "0xA7E0470", VA = "0x18A7E1470", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA7E11C0", Offset = "0xA7E01C0", VA = "0x18A7E11C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1430", Offset = "0xA7E0430", VA = "0x18A7E1430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xA7E12B0", Offset = "0xA7E02B0", VA = "0x18A7E12B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xA7E12B0", Offset = "0xA7E02B0", VA = "0x18A7E12B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20")]
		public static implicit operator VertexColor1(Vector4 color)
		{
			return default(VertexColor1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8120", Offset = "0xA7E7120", VA = "0x18A7E8120")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x1546720", Offset = "0x1545720", VA = "0x181546720")]
		public VertexColor1(Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA7E81A0", Offset = "0xA7E71A0", VA = "0x18A7E81A0")]
		public VertexColor1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8000", Offset = "0xA7E7000", VA = "0x18A7E8000", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7F80", Offset = "0xA7E6F80", VA = "0x18A7E7F80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7E30", Offset = "0xA7E6E30", VA = "0x18A7E7E30", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7EE0", Offset = "0xA7E6EE0", VA = "0x18A7E7EE0", Slot = "13")]
		public readonly bool Equals(VertexColor1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7EE0", Offset = "0xA7E6EE0", VA = "0x18A7E7EE0")]
		public static bool operator ==([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8300", Offset = "0xA7E7300", VA = "0x18A7E8300")]
		public static bool operator !=([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7E00", Offset = "0xA7E6E00", VA = "0x18A7E7E00")]
		public static bool AreEqual([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8070", Offset = "0xA7E7070", VA = "0x18A7E8070", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7D80", Offset = "0xA7E6D80", VA = "0x18A7E7D80")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D60", Offset = "0xA7E4D60", VA = "0x18A7E5D60", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7F10", Offset = "0xA7E6F10", VA = "0x18A7E7F10", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7FA0", Offset = "0xA7E6FA0", VA = "0x18A7E7FA0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7FF0", Offset = "0xA7E6FF0", VA = "0x18A7E7FF0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E2350", Offset = "0xA7E1350", VA = "0x18A7E2350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1C80", Offset = "0xA7E0C80", VA = "0x18A7E1C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA7E22D0", Offset = "0xA7E12D0", VA = "0x18A7E22D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1E10", Offset = "0xA7E0E10", VA = "0x18A7E1E10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1E10", Offset = "0xA7E0E10", VA = "0x18A7E1E10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB5E0", Offset = "0xA7EA5E0", VA = "0x18A7EB5E0")]
		public static implicit operator VertexColor2((Vector4 Color0, Vector4 Color1) tuple)
		{
			return default(VertexColor2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB340", Offset = "0xA7EA340", VA = "0x18A7EB340")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x6382CB0", Offset = "0x6381CB0", VA = "0x186382CB0")]
		public VertexColor2(Vector4 color0, Vector4 color1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB3C0", Offset = "0xA7EA3C0", VA = "0x18A7EB3C0")]
		public VertexColor2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB210", Offset = "0xA7EA210", VA = "0x18A7EB210", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB160", Offset = "0xA7EA160", VA = "0x18A7EB160", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAFC0", Offset = "0xA7E9FC0", VA = "0x18A7EAFC0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB0C0", Offset = "0xA7EA0C0", VA = "0x18A7EB0C0", Slot = "13")]
		public readonly bool Equals(VertexColor2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB5D0", Offset = "0xA7EA5D0", VA = "0x18A7EB5D0")]
		public static bool operator ==([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB600", Offset = "0xA7EA600", VA = "0x18A7EB600")]
		public static bool operator !=([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAF40", Offset = "0xA7E9F40", VA = "0x18A7EAF40")]
		public static bool AreEqual([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB280", Offset = "0xA7EA280", VA = "0x18A7EB280", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAE50", Offset = "0xA7E9E50", VA = "0x18A7EAE50")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB0E0", Offset = "0xA7EA0E0", VA = "0x18A7EB0E0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB1B0", Offset = "0xA7EA1B0", VA = "0x18A7EB1B0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB200", Offset = "0xA7EA200", VA = "0x18A7EB200", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E14C0", Offset = "0xA7E04C0", VA = "0x18A7E14C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xA7E10E0", Offset = "0xA7E00E0", VA = "0x18A7E10E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xA7E13F0", Offset = "0xA7E03F0", VA = "0x18A7E13F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1350", Offset = "0xA7E0350", VA = "0x18A7E1350", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1350", Offset = "0xA7E0350", VA = "0x18A7E1350", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80")]
		public static implicit operator VertexTexture1(Vector2 uv)
		{
			return default(VertexTexture1);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2150", Offset = "0xA7F1150", VA = "0x18A7F2150")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x141C250", Offset = "0x141B250", VA = "0x18141C250")]
		public VertexTexture1(Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F21D0", Offset = "0xA7F11D0", VA = "0x18A7F21D0")]
		public VertexTexture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2010", Offset = "0xA7F1010", VA = "0x18A7F2010", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1F70", Offset = "0xA7F0F70", VA = "0x18A7F1F70", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1E50", Offset = "0xA7F0E50", VA = "0x18A7F1E50", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1F00", Offset = "0xA7F0F00", VA = "0x18A7F1F00", Slot = "13")]
		public readonly bool Equals(VertexTexture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA7F22E0", Offset = "0xA7F12E0", VA = "0x18A7F22E0")]
		public static bool operator ==([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2310", Offset = "0xA7F1310", VA = "0x18A7F2310")]
		public static bool operator !=([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1E20", Offset = "0xA7F0E20", VA = "0x18A7F1E20")]
		public static bool AreEqual([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2090", Offset = "0xA7F1090", VA = "0x18A7F2090", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1DD0", Offset = "0xA7F0DD0", VA = "0x18A7F1DD0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2000", Offset = "0xA7F1000", VA = "0x18A7F2000", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1F20", Offset = "0xA7F0F20", VA = "0x18A7F1F20", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1F90", Offset = "0xA7F0F90", VA = "0x18A7F1F90", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F1DD0", Offset = "0xA7F0DD0", VA = "0x18A7F1DD0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E2440", Offset = "0xA7E1440", VA = "0x18A7E2440", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1B00", Offset = "0xA7E0B00", VA = "0x18A7E1B00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2250", Offset = "0xA7E1250", VA = "0x18A7E2250", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2090", Offset = "0xA7E1090", VA = "0x18A7E2090", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2090", Offset = "0xA7E1090", VA = "0x18A7E2090", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20")]
		public static implicit operator VertexTexture2((Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexTexture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA7F27F0", Offset = "0xA7F17F0", VA = "0x18A7F27F0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x312BB90", Offset = "0x312AB90", VA = "0x18312BB90")]
		public VertexTexture2(Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2870", Offset = "0xA7F1870", VA = "0x18A7F2870")]
		public VertexTexture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA7F26D0", Offset = "0xA7F16D0", VA = "0x18A7F26D0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F25D0", Offset = "0xA7F15D0", VA = "0x18A7F25D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2470", Offset = "0xA7F1470", VA = "0x18A7F2470", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2450", Offset = "0xA7F1450", VA = "0x18A7F2450", Slot = "13")]
		public readonly bool Equals(VertexTexture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA7F29E0", Offset = "0xA7F19E0", VA = "0x18A7F29E0")]
		public static bool operator ==([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA7F29F0", Offset = "0xA7F19F0", VA = "0x18A7F29F0")]
		public static bool operator !=([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA7F23D0", Offset = "0xA7F13D0", VA = "0x18A7F23D0")]
		public static bool AreEqual([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2740", Offset = "0xA7F1740", VA = "0x18A7F2740", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2340", Offset = "0xA7F1340", VA = "0x18A7F2340")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7F26B0", Offset = "0xA7F16B0", VA = "0x18A7F26B0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2580", Offset = "0xA7F1580", VA = "0x18A7F2580", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2620", Offset = "0xA7F1620", VA = "0x18A7F2620", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7F26A0", Offset = "0xA7F16A0", VA = "0x18A7F26A0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E23A0", Offset = "0xA7E13A0", VA = "0x18A7E23A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1510", Offset = "0xA7E0510", VA = "0x18A7E1510", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA7E21D0", Offset = "0xA7E11D0", VA = "0x18A7E21D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2130", Offset = "0xA7E1130", VA = "0x18A7E2130", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2130", Offset = "0xA7E1130", VA = "0x18A7E2130", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x3067910", Offset = "0x3066910", VA = "0x183067910")]
		public static implicit operator VertexColor1Texture1((Vector4 Color, Vector2 Tex) tuple)
		{
			return default(VertexColor1Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5EC0", Offset = "0xA7E4EC0", VA = "0x18A7E5EC0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x6938BF0", Offset = "0x6937BF0", VA = "0x186938BF0")]
		public VertexColor1Texture1(Vector4 color, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5F40", Offset = "0xA7E4F40", VA = "0x18A7E5F40")]
		public VertexColor1Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D80", Offset = "0xA7E4D80", VA = "0x18A7E5D80", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5C80", Offset = "0xA7E4C80", VA = "0x18A7E5C80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5AF0", Offset = "0xA7E4AF0", VA = "0x18A7E5AF0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5BF0", Offset = "0xA7E4BF0", VA = "0x18A7E5BF0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7E60F0", Offset = "0xA7E50F0", VA = "0x18A7E60F0")]
		public static bool operator ==([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6100", Offset = "0xA7E5100", VA = "0x18A7E6100")]
		public static bool operator !=([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5A60", Offset = "0xA7E4A60", VA = "0x18A7E5A60")]
		public static bool AreEqual([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5E00", Offset = "0xA7E4E00", VA = "0x18A7E5E00", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5990", Offset = "0xA7E4990", VA = "0x18A7E5990")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D60", Offset = "0xA7E4D60", VA = "0x18A7E5D60", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D70", Offset = "0xA7E4D70", VA = "0x18A7E5D70", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5C10", Offset = "0xA7E4C10", VA = "0x18A7E5C10", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5CD0", Offset = "0xA7E4CD0", VA = "0x18A7E5CD0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D50", Offset = "0xA7E4D50", VA = "0x18A7E5D50", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E3940", Offset = "0xA7E2940", VA = "0x18A7E3940", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2530", Offset = "0xA7E1530", VA = "0x18A7E2530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3700", Offset = "0xA7E2700", VA = "0x18A7E3700", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3480", Offset = "0xA7E2480", VA = "0x18A7E3480", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3480", Offset = "0xA7E2480", VA = "0x18A7E3480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3970", Offset = "0x2DB2970", VA = "0x182DB3970")]
		public static implicit operator VertexColor1Texture2((Vector4 Color, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor1Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6680", Offset = "0xA7E5680", VA = "0x18A7E6680")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x83E37E0", Offset = "0x83E27E0", VA = "0x1883E37E0")]
		public VertexColor1Texture2(Vector4 color, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6700", Offset = "0xA7E5700", VA = "0x18A7E6700")]
		public VertexColor1Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6550", Offset = "0xA7E5550", VA = "0x18A7E6550", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6410", Offset = "0xA7E5410", VA = "0x18A7E6410", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6300", Offset = "0xA7E5300", VA = "0x18A7E6300", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7E62E0", Offset = "0xA7E52E0", VA = "0x18A7E62E0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6910", Offset = "0xA7E5910", VA = "0x18A7E6910")]
		public static bool operator ==([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6920", Offset = "0xA7E5920", VA = "0x18A7E6920")]
		public static bool operator !=([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6220", Offset = "0xA7E5220", VA = "0x18A7E6220")]
		public static bool AreEqual([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E65C0", Offset = "0xA7E55C0", VA = "0x18A7E65C0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6120", Offset = "0xA7E5120", VA = "0x18A7E6120")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D60", Offset = "0xA7E4D60", VA = "0x18A7E5D60", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6530", Offset = "0xA7E5530", VA = "0x18A7E6530", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E63A0", Offset = "0xA7E53A0", VA = "0x18A7E63A0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6490", Offset = "0xA7E5490", VA = "0x18A7E6490", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6520", Offset = "0xA7E5520", VA = "0x18A7E6520", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E3850", Offset = "0xA7E2850", VA = "0x18A7E3850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3050", Offset = "0xA7E2050", VA = "0x18A7E3050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3680", Offset = "0xA7E2680", VA = "0x18A7E3680", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3520", Offset = "0xA7E2520", VA = "0x18A7E3520", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3520", Offset = "0xA7E2520", VA = "0x18A7E3520", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8CB0", Offset = "0xA7E7CB0", VA = "0x18A7E8CB0")]
		public static implicit operator VertexColor2Texture1((Vector4 Color0, Vector4 Color1, Vector2 Tex) tuple)
		{
			return default(VertexColor2Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E89A0", Offset = "0xA7E79A0", VA = "0x18A7E89A0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x83E3AB0", Offset = "0x83E2AB0", VA = "0x1883E3AB0")]
		public VertexColor2Texture1(Vector4 color0, Vector4 color1, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8A30", Offset = "0xA7E7A30", VA = "0x18A7E8A30")]
		public VertexColor2Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8850", Offset = "0xA7E7850", VA = "0x18A7E8850", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8710", Offset = "0xA7E7710", VA = "0x18A7E8710", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8530", Offset = "0xA7E7530", VA = "0x18A7E8530", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8510", Offset = "0xA7E7510", VA = "0x18A7E8510", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8CA0", Offset = "0xA7E7CA0", VA = "0x18A7E8CA0")]
		public static bool operator ==([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8CD0", Offset = "0xA7E7CD0", VA = "0x18A7E8CD0")]
		public static bool operator !=([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8460", Offset = "0xA7E7460", VA = "0x18A7E8460")]
		public static bool AreEqual([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7E88D0", Offset = "0xA7E78D0", VA = "0x18A7E88D0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8330", Offset = "0xA7E7330", VA = "0x18A7E8330")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8840", Offset = "0xA7E7840", VA = "0x18A7E8840", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8690", Offset = "0xA7E7690", VA = "0x18A7E8690", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8790", Offset = "0xA7E7790", VA = "0x18A7E8790", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8810", Offset = "0xA7E7810", VA = "0x18A7E8810", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E4A30", Offset = "0xA7E3A30", VA = "0x18A7E4A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3D40", Offset = "0xA7E2D40", VA = "0x18A7E3D40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4930", Offset = "0xA7E3930", VA = "0x18A7E4930", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4880", Offset = "0xA7E3880", VA = "0x18A7E4880", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4880", Offset = "0xA7E3880", VA = "0x18A7E4880", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA7E96B0", Offset = "0xA7E86B0", VA = "0x18A7E96B0")]
		public static implicit operator VertexColor2Texture2((Vector4 Color0, Vector4 Color1, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor2Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9350", Offset = "0xA7E8350", VA = "0x18A7E9350")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x84D3FD0", Offset = "0x84D2FD0", VA = "0x1884D3FD0")]
		public VertexColor2Texture2(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E93E0", Offset = "0xA7E83E0", VA = "0x18A7E93E0")]
		public VertexColor2Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9200", Offset = "0xA7E8200", VA = "0x18A7E9200", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA7E90A0", Offset = "0xA7E80A0", VA = "0x18A7E90A0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8F70", Offset = "0xA7E7F70", VA = "0x18A7E8F70", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8F50", Offset = "0xA7E7F50", VA = "0x18A7E8F50", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA7E96A0", Offset = "0xA7E86A0", VA = "0x18A7E96A0")]
		public static bool operator ==([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA7E96D0", Offset = "0xA7E86D0", VA = "0x18A7E96D0")]
		public static bool operator !=([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8E60", Offset = "0xA7E7E60", VA = "0x18A7E8E60")]
		public static bool AreEqual([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9280", Offset = "0xA7E8280", VA = "0x18A7E9280", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8CF0", Offset = "0xA7E7CF0", VA = "0x18A7E8CF0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA7E91E0", Offset = "0xA7E81E0", VA = "0x18A7E91E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9020", Offset = "0xA7E8020", VA = "0x18A7E9020", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9140", Offset = "0xA7E8140", VA = "0x18A7E9140", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E91D0", Offset = "0xA7E81D0", VA = "0x18A7E91D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E0F60", Offset = "0xA7DFF60", VA = "0x18A7E0F60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0A50", Offset = "0xA7DFA50", VA = "0x18A7E0A50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0F20", Offset = "0xA7DFF20", VA = "0x18A7E0F20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0E50", Offset = "0xA7DFE50", VA = "0x18A7E0E50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA7E0E50", Offset = "0xA7DFE50", VA = "0x18A7E0E50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7F00C0", Offset = "0xA7EF0C0", VA = "0x18A7F00C0")]
			get
			{
				return default(VertexMaterialDelta);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xD27F80", Offset = "0xD26F80", VA = "0x180D27F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD27F90", Offset = "0xD26F90", VA = "0x180D27F90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE180", Offset = "0xA7ED180", VA = "0x18A7EE180")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA7F01C0", Offset = "0xA7EF1C0", VA = "0x18A7F01C0")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA7F0260", Offset = "0xA7EF260", VA = "0x18A7F0260")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta, Vector2 TextCoord2Delta, Vector2 TextCoord3Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF400", Offset = "0xA7EE400", VA = "0x18A7EF400")]
		public VertexMaterialDelta(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF7D0", Offset = "0xA7EE7D0", VA = "0x18A7EF7D0")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE6A0", Offset = "0xA7ED6A0", VA = "0x18A7EE6A0")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta, [In] Vector2 texCoord2Delta, [In] Vector2 texCoord3Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA7EECD0", Offset = "0xA7EDCD0", VA = "0x18A7EECD0")]
		internal VertexMaterialDelta([In] VertexMaterialDelta rootVal, [In] VertexMaterialDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE000", Offset = "0xA7ED000", VA = "0x18A7EE000", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDDC0", Offset = "0xA7ECDC0", VA = "0x18A7EDDC0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDC70", Offset = "0xA7ECC70", VA = "0x18A7EDC70", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDC50", Offset = "0xA7ECC50", VA = "0x18A7EDC50", Slot = "13")]
		public readonly bool Equals(VertexMaterialDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA7F01B0", Offset = "0xA7EF1B0", VA = "0x18A7F01B0")]
		public static bool operator ==([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA7F02A0", Offset = "0xA7EF2A0", VA = "0x18A7F02A0")]
		public static bool operator !=([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDAF0", Offset = "0xA7ECAF0", VA = "0x18A7EDAF0")]
		public static bool AreEqual([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE0A0", Offset = "0xA7ED0A0", VA = "0x18A7EE0A0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA220", Offset = "0xA7E9220", VA = "0x18A7EA220")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820")]
		private void SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDF70", Offset = "0xA7ECF70", VA = "0x18A7EDF70", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA890", Offset = "0xA7E9890", VA = "0x18A7EA890")]
		private void SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDD40", Offset = "0xA7ECD40", VA = "0x18A7EDD40", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDEA0", Offset = "0xA7ECEA0", VA = "0x18A7EDEA0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF2F0", Offset = "0xA7EE2F0", VA = "0x18A7EF2F0")]
		internal VertexMaterialDelta([In] VertexTexture1 rootVal, [In] VertexTexture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA7EEBA0", Offset = "0xA7EDBA0", VA = "0x18A7EEBA0")]
		internal VertexMaterialDelta([In] VertexTexture2 rootVal, [In] VertexTexture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE550", Offset = "0xA7ED550", VA = "0x18A7EE550")]
		internal VertexMaterialDelta([In] VertexTexture3 rootVal, [In] VertexTexture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EEA40", Offset = "0xA7EDA40", VA = "0x18A7EEA40")]
		internal VertexMaterialDelta([In] VertexTexture4 rootVal, [In] VertexTexture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA7EFFA0", Offset = "0xA7EEFA0", VA = "0x18A7EFFA0")]
		internal VertexMaterialDelta([In] VertexColor1 rootVal, [In] VertexColor1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE730", Offset = "0xA7ED730", VA = "0x18A7EE730")]
		internal VertexMaterialDelta([In] VertexColor1Texture1 rootVal, [In] VertexColor1Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA7EEF80", Offset = "0xA7EDF80", VA = "0x18A7EEF80")]
		internal VertexMaterialDelta([In] VertexColor1Texture2 rootVal, [In] VertexColor1Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE3C0", Offset = "0xA7ED3C0", VA = "0x18A7EE3C0")]
		internal VertexMaterialDelta([In] VertexColor1Texture3 rootVal, [In] VertexColor1Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA7EE890", Offset = "0xA7ED890", VA = "0x18A7EE890")]
		internal VertexMaterialDelta([In] VertexColor1Texture4 rootVal, [In] VertexColor1Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA7EFA30", Offset = "0xA7EEA30", VA = "0x18A7EFA30")]
		internal VertexMaterialDelta([In] VertexColor2 rootVal, [In] VertexColor2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF880", Offset = "0xA7EE880", VA = "0x18A7EF880")]
		internal VertexMaterialDelta([In] VertexColor2Texture1 rootVal, [In] VertexColor2Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA7EFDD0", Offset = "0xA7EEDD0", VA = "0x18A7EFDD0")]
		internal VertexMaterialDelta([In] VertexColor2Texture2 rootVal, [In] VertexColor2Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA7EF100", Offset = "0xA7EE100", VA = "0x18A7EF100")]
		internal VertexMaterialDelta([In] VertexColor2Texture3 rootVal, [In] VertexColor2Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA7EFBC0", Offset = "0xA7EEBC0", VA = "0x18A7EFBC0")]
		internal VertexMaterialDelta([In] VertexColor2Texture4 rootVal, [In] VertexColor2Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA880", Offset = "0xA7E9880", VA = "0x18A7EA880", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E24E0", Offset = "0xA7E14E0", VA = "0x18A7E24E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1770", Offset = "0xA7E0770", VA = "0x18A7E1770", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2310", Offset = "0xA7E1310", VA = "0x18A7E2310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1EB0", Offset = "0xA7E0EB0", VA = "0x18A7E1EB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1EB0", Offset = "0xA7E0EB0", VA = "0x18A7E1EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2F50", Offset = "0xA7F1F50", VA = "0x18A7F2F50")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x8375510", Offset = "0x8374510", VA = "0x188375510")]
		public VertexTexture3(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2FD0", Offset = "0xA7F1FD0", VA = "0x18A7F2FD0")]
		public VertexTexture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2E10", Offset = "0xA7F1E10", VA = "0x18A7F2E10", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2CD0", Offset = "0xA7F1CD0", VA = "0x18A7F2CD0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2BD0", Offset = "0xA7F1BD0", VA = "0x18A7F2BD0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2BB0", Offset = "0xA7F1BB0", VA = "0x18A7F2BB0", Slot = "13")]
		public readonly bool Equals(VertexTexture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3190", Offset = "0xA7F2190", VA = "0x18A7F3190")]
		public static bool operator ==([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA7F31A0", Offset = "0xA7F21A0", VA = "0x18A7F31A0")]
		public static bool operator !=([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2AF0", Offset = "0xA7F1AF0", VA = "0x18A7F2AF0")]
		public static bool AreEqual([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2E90", Offset = "0xA7F1E90", VA = "0x18A7F2E90", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2A10", Offset = "0xA7F1A10", VA = "0x18A7F2A10")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2DF0", Offset = "0xA7F1DF0", VA = "0x18A7F2DF0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2C80", Offset = "0xA7F1C80", VA = "0x18A7F2C80", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2D40", Offset = "0xA7F1D40", VA = "0x18A7F2D40", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA7F2DE0", Offset = "0xA7F1DE0", VA = "0x18A7F2DE0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E3800", Offset = "0xA7E2800", VA = "0x18A7E3800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA7E28E0", Offset = "0xA7E18E0", VA = "0x18A7E28E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3780", Offset = "0xA7E2780", VA = "0x18A7E3780", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3340", Offset = "0xA7E2340", VA = "0x18A7E3340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3340", Offset = "0xA7E2340", VA = "0x18A7E3340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F37A0", Offset = "0xA7F27A0", VA = "0x18A7F37A0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3820", Offset = "0xA7F2820", VA = "0x18A7F3820")]
		public VertexTexture4(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3840", Offset = "0xA7F2840", VA = "0x18A7F3840")]
		public VertexTexture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3670", Offset = "0xA7F2670", VA = "0x18A7F3670", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA7F34D0", Offset = "0xA7F24D0", VA = "0x18A7F34D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA7F33C0", Offset = "0xA7F23C0", VA = "0x18A7F33C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3460", Offset = "0xA7F2460", VA = "0x18A7F3460", Slot = "13")]
		public readonly bool Equals(VertexTexture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3A50", Offset = "0xA7F2A50", VA = "0x18A7F3A50")]
		public static bool operator ==([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3A60", Offset = "0xA7F2A60", VA = "0x18A7F3A60")]
		public static bool operator !=([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA7F32D0", Offset = "0xA7F22D0", VA = "0x18A7F32D0")]
		public static bool AreEqual([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA7F36E0", Offset = "0xA7F26E0", VA = "0x18A7F36E0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA7F31C0", Offset = "0xA7F21C0", VA = "0x18A7F31C0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3640", Offset = "0xA7F2640", VA = "0x18A7F3640", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3480", Offset = "0xA7F2480", VA = "0x18A7F3480", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3570", Offset = "0xA7F2570", VA = "0x18A7F3570", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3630", Offset = "0xA7F2630", VA = "0x18A7F3630", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E38A0", Offset = "0xA7E28A0", VA = "0x18A7E38A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2B80", Offset = "0xA7E1B80", VA = "0x18A7E2B80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA7E3740", Offset = "0xA7E2740", VA = "0x18A7E3740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xA7E35D0", Offset = "0xA7E25D0", VA = "0x18A7E35D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xA7E35D0", Offset = "0xA7E25D0", VA = "0x18A7E35D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6F90", Offset = "0xA7E5F90", VA = "0x18A7E6F90")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7020", Offset = "0xA7E6020", VA = "0x18A7E7020")]
		public VertexColor1Texture3(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7040", Offset = "0xA7E6040", VA = "0x18A7E7040")]
		public VertexColor1Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6E40", Offset = "0xA7E5E40", VA = "0x18A7E6E40", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6CC0", Offset = "0xA7E5CC0", VA = "0x18A7E6CC0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6BA0", Offset = "0xA7E5BA0", VA = "0x18A7E6BA0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6B80", Offset = "0xA7E5B80", VA = "0x18A7E6B80", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA7E72A0", Offset = "0xA7E62A0", VA = "0x18A7E72A0")]
		public static bool operator ==([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA7E72B0", Offset = "0xA7E62B0", VA = "0x18A7E72B0")]
		public static bool operator !=([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6A80", Offset = "0xA7E5A80", VA = "0x18A7E6A80")]
		public static bool AreEqual([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6EC0", Offset = "0xA7E5EC0", VA = "0x18A7E6EC0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6940", Offset = "0xA7E5940", VA = "0x18A7E6940")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D60", Offset = "0xA7E4D60", VA = "0x18A7E5D60", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6E20", Offset = "0xA7E5E20", VA = "0x18A7E6E20", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6C50", Offset = "0xA7E5C50", VA = "0x18A7E6C50", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6D60", Offset = "0xA7E5D60", VA = "0x18A7E6D60", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA7E6E10", Offset = "0xA7E5E10", VA = "0x18A7E6E10", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E4B20", Offset = "0xA7E3B20", VA = "0x18A7E4B20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xA7E39E0", Offset = "0xA7E29E0", VA = "0x18A7E39E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xA7E49B0", Offset = "0xA7E39B0", VA = "0x18A7E49B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4710", Offset = "0xA7E3710", VA = "0x18A7E4710", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4710", Offset = "0xA7E3710", VA = "0x18A7E4710", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA7E79E0", Offset = "0xA7E69E0", VA = "0x18A7E79E0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7D20", Offset = "0xA7E6D20", VA = "0x18A7E7D20")]
		public VertexColor1Texture4(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7A70", Offset = "0xA7E6A70", VA = "0x18A7E7A70")]
		public VertexColor1Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7890", Offset = "0xA7E6890", VA = "0x18A7E7890", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA7E76C0", Offset = "0xA7E66C0", VA = "0x18A7E76C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7580", Offset = "0xA7E6580", VA = "0x18A7E7580", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7630", Offset = "0xA7E6630", VA = "0x18A7E7630", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7D50", Offset = "0xA7E6D50", VA = "0x18A7E7D50")]
		public static bool operator ==([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7D60", Offset = "0xA7E6D60", VA = "0x18A7E7D60")]
		public static bool operator !=([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7450", Offset = "0xA7E6450", VA = "0x18A7E7450")]
		public static bool AreEqual([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7910", Offset = "0xA7E6910", VA = "0x18A7E7910", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E72D0", Offset = "0xA7E62D0", VA = "0x18A7E72D0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E5D60", Offset = "0xA7E4D60", VA = "0x18A7E5D60", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7860", Offset = "0xA7E6860", VA = "0x18A7E7860", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7650", Offset = "0xA7E6650", VA = "0x18A7E7650", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7780", Offset = "0xA7E6780", VA = "0x18A7E7780", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7850", Offset = "0xA7E6850", VA = "0x18A7E7850", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E4AD0", Offset = "0xA7E3AD0", VA = "0x18A7E4AD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xA7E42E0", Offset = "0xA7E32E0", VA = "0x18A7E42E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7E49F0", Offset = "0xA7E39F0", VA = "0x18A7E49F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xA7E47C0", Offset = "0xA7E37C0", VA = "0x18A7E47C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xA7E47C0", Offset = "0xA7E37C0", VA = "0x18A7E47C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9E20", Offset = "0xA7E8E20", VA = "0x18A7E9E20")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA1C0", Offset = "0xA7E91C0", VA = "0x18A7EA1C0")]
		public VertexColor2Texture3(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9EB0", Offset = "0xA7E8EB0", VA = "0x18A7E9EB0")]
		public VertexColor2Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9CC0", Offset = "0xA7E8CC0", VA = "0x18A7E9CC0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9B30", Offset = "0xA7E8B30", VA = "0x18A7E9B30", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7E99F0", Offset = "0xA7E89F0", VA = "0x18A7E99F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E99D0", Offset = "0xA7E89D0", VA = "0x18A7E99D0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA1F0", Offset = "0xA7E91F0", VA = "0x18A7EA1F0")]
		public static bool operator ==([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA200", Offset = "0xA7E9200", VA = "0x18A7EA200")]
		public static bool operator !=([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7E98A0", Offset = "0xA7E88A0", VA = "0x18A7E98A0")]
		public static bool AreEqual([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9D50", Offset = "0xA7E8D50", VA = "0x18A7E9D50", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA7E96F0", Offset = "0xA7E86F0", VA = "0x18A7E96F0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9CA0", Offset = "0xA7E8CA0", VA = "0x18A7E9CA0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9AB0", Offset = "0xA7E8AB0", VA = "0x18A7E9AB0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9BE0", Offset = "0xA7E8BE0", VA = "0x18A7E9BE0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E9C90", Offset = "0xA7E8C90", VA = "0x18A7E9C90", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E5070", Offset = "0xA7E4070", VA = "0x18A7E5070", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4B70", Offset = "0xA7E3B70", VA = "0x18A7E4B70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA7E5030", Offset = "0xA7E4030", VA = "0x18A7E5030", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4F70", Offset = "0xA7E3F70", VA = "0x18A7E4F70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4F70", Offset = "0xA7E3F70", VA = "0x18A7E4F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD756C0", Offset = "0xD746C0", VA = "0x180D756C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAA20", Offset = "0xA7E9A20", VA = "0x18A7EAA20")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x8509B20", Offset = "0x8508B20", VA = "0x188509B20")]
		public VertexColor2Texture4(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAAB0", Offset = "0xA7E9AB0", VA = "0x18A7EAAB0")]
		public VertexColor2Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA8C0", Offset = "0xA7E98C0", VA = "0x18A7EA8C0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA6D0", Offset = "0xA7E96D0", VA = "0x18A7EA6D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA570", Offset = "0xA7E9570", VA = "0x18A7EA570", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA630", Offset = "0xA7E9630", VA = "0x18A7EA630", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAE20", Offset = "0xA7E9E20", VA = "0x18A7EAE20")]
		public static bool operator ==([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA7EAE30", Offset = "0xA7E9E30", VA = "0x18A7EAE30")]
		public static bool operator !=([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA410", Offset = "0xA7E9410", VA = "0x18A7EA410")]
		public static bool AreEqual([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA950", Offset = "0xA7E9950", VA = "0x18A7EA950", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA220", Offset = "0xA7E9220", VA = "0x18A7EA220")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7E8820", Offset = "0xA7E7820", VA = "0x18A7E8820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA890", Offset = "0xA7E9890", VA = "0x18A7EA890", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA650", Offset = "0xA7E9650", VA = "0x18A7EA650", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA7B0", Offset = "0xA7E97B0", VA = "0x18A7EA7B0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA7EA880", Offset = "0xA7E9880", VA = "0x18A7EA880", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x87183D0", Offset = "0x87173D0", VA = "0x1887183D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x8718350", Offset = "0x8717350", VA = "0x188718350")]
		public void Append(VertexGeometryPreprocessor<TvG> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x87182D0", Offset = "0x87172D0", VA = "0x1887182D0")]
		public void Append(VertexMaterialPreprocessor<TvM> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x8718250", Offset = "0x8717250", VA = "0x188718250")]
		public void Append(VertexSkinningPreprocessor<TvS> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x871CFC0", Offset = "0x871BFC0", VA = "0x18871CFC0")]
		public void SetValidationPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x871B540", Offset = "0x871A540", VA = "0x18871B540")]
		public void SetSanitizerPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x8719800", Offset = "0x8718800", VA = "0x188719800")]
		public bool PreprocessVertex(VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x871D480", Offset = "0x871C480", VA = "0x18871D480")]
		public VertexPreprocessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class VertexPreprocessorLambdas
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x40FC680", Offset = "0x40FB680", VA = "0x1840FC680")]
		public static TvG? ValidateVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x40FE5D0", Offset = "0x40FD5D0", VA = "0x1840FE5D0")]
		public static TvM? ValidateVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x4102A40", Offset = "0x4101A40", VA = "0x184102A40")]
		public static TvS? ValidateVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x40F7790", Offset = "0x40F6790", VA = "0x1840F7790")]
		public static TvG? SanitizeVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x40F99B0", Offset = "0x40F89B0", VA = "0x1840F99B0")]
		public static TvM? SanitizeVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x40FBC50", Offset = "0x40FAC50", VA = "0x1840FBC50")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E2490", Offset = "0xA7E1490", VA = "0x18A7E2490", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1980", Offset = "0xA7E0980", VA = "0x18A7E1980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xA7E2290", Offset = "0xA7E1290", VA = "0x18A7E2290", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1FF0", Offset = "0xA7E0FF0", VA = "0x18A7E1FF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xA7E1FF0", Offset = "0xA7E0FF0", VA = "0x18A7E1FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD79640", Offset = "0xD78640", VA = "0x180D79640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7EBA60", Offset = "0xA7EAA60", VA = "0x18A7EBA60", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECCF0", Offset = "0xA7EBCF0", VA = "0x18A7ECCF0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECF40", Offset = "0xA7EBF40", VA = "0x18A7ECF40")]
		public VertexJoints4(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECFA0", Offset = "0xA7EBFA0", VA = "0x18A7ECFA0")]
		public VertexJoints4(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECD70", Offset = "0xA7EBD70", VA = "0x18A7ECD70")]
		public VertexJoints4([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECC80", Offset = "0xA7EBC80", VA = "0x18A7ECC80", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7F80", Offset = "0xA7E6F80", VA = "0x18A7E7F80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC980", Offset = "0xA7EB980", VA = "0x18A7EC980", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC960", Offset = "0xA7EB960", VA = "0x18A7EC960", Slot = "14")]
		public readonly bool Equals(VertexJoints4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED010", Offset = "0xA7EC010", VA = "0x18A7ED010")]
		public static bool operator ==([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED020", Offset = "0xA7EC020", VA = "0x18A7ED020")]
		public static bool operator !=([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC8F0", Offset = "0xA7EB8F0", VA = "0x18A7EC8F0")]
		public static bool AreEqual([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECB60", Offset = "0xA7EBB60", VA = "0x18A7ECB60", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECC40", Offset = "0xA7EBC40", VA = "0x18A7ECC40")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECBB0", Offset = "0xA7EBBB0", VA = "0x18A7ECBB0", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECA80", Offset = "0xA7EBA80", VA = "0x18A7ECA80", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA7ECC40", Offset = "0xA7EBC40", VA = "0x18A7ECC40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7E4A80", Offset = "0xA7E3A80", VA = "0x18A7E4A80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4010", Offset = "0xA7E3010", VA = "0x18A7E4010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4970", Offset = "0xA7E3970", VA = "0x18A7E4970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4650", Offset = "0xA7E3650", VA = "0x18A7E4650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xA7E4650", Offset = "0xA7E3650", VA = "0x18A7E4650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF3E2D0", Offset = "0xF3D2D0", VA = "0x180F3E2D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xEEF550", Offset = "0xEEE550", VA = "0x180EEF550", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xF7CED0", Offset = "0xF7BED0", VA = "0x180F7CED0", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED5B0", Offset = "0xA7EC5B0", VA = "0x18A7ED5B0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED9D0", Offset = "0xA7EC9D0", VA = "0x18A7ED9D0")]
		public VertexJoints8(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDA50", Offset = "0xA7ECA50", VA = "0x18A7EDA50")]
		public VertexJoints8(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED640", Offset = "0xA7EC640", VA = "0x18A7ED640")]
		public VertexJoints8([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED520", Offset = "0xA7EC520", VA = "0x18A7ED520", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA7E7F80", Offset = "0xA7E6F80", VA = "0x18A7E7F80", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED130", Offset = "0xA7EC130", VA = "0x18A7ED130", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED110", Offset = "0xA7EC110", VA = "0x18A7ED110", Slot = "14")]
		public readonly bool Equals(VertexJoints8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDAC0", Offset = "0xA7ECAC0", VA = "0x18A7EDAC0")]
		public static bool operator ==([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA7EDAD0", Offset = "0xA7ECAD0", VA = "0x18A7EDAD0")]
		public static bool operator !=([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED040", Offset = "0xA7EC040", VA = "0x18A7ED040")]
		public static bool AreEqual([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED3B0", Offset = "0xA7EC3B0", VA = "0x18A7ED3B0", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED410", Offset = "0xA7EC410", VA = "0x18A7ED410")]
		public void SetBindings([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED470", Offset = "0xA7EC470", VA = "0x18A7ED470", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED1F0", Offset = "0xA7EC1F0", VA = "0x18A7ED1F0", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA7ED410", Offset = "0xA7EC410", VA = "0x18A7ED410", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4113230", Offset = "0x4112230", VA = "0x184113230")]
		public static MemoryAccessor CreateVertexMemoryAccessor<TVertex>(this IReadOnlyList<TVertex> vertices, string attributeName, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x4113DC0", Offset = "0x4112DC0", VA = "0x184113DC0")]
		public static MemoryAccessor[] CreateVertexMemoryAccessors<TVertex>(this IReadOnlyList<TVertex> vertices, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x41154B0", Offset = "0x41144B0", VA = "0x1841154B0")]
		private static void FillAccessor<TVertex>(this MemoryAccessor dstAccessor, IReadOnlyList<TVertex> srcVertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3A80", Offset = "0xA7F2A80", VA = "0x18A7F3A80")]
		public static MemoryAccessor CreateIndexMemoryAccessor(this IReadOnlyList<int> indices, EncodingType indexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA7F3D70", Offset = "0xA7F2D70", VA = "0x18A7F3D70")]
		public static MemoryAccessInfo[] GetVertexAttributes(this IVertexBuilder firstVertex, int vertexCount, PackedEncoding vertexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA7FF4D0", Offset = "0xA7FE4D0", VA = "0x18A7FF4D0")]
		private static Converter<IVertexBuilder, object> _GetVertexBuilderAttributeFunc(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA800AE0", Offset = "0xA7FFAE0", VA = "0x18A800AE0")]
		private static object _GetVertexBuilderCustomAttributeFunc(IVertexMaterial vertex, string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x4117510", Offset = "0x4116510", VA = "0x184117510")]
		private static TColumn[] _GetColumn<TColumn, TVertex>(this IReadOnlyList<TVertex> vertices, Converter<IVertexBuilder, object> func) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA7FE590", Offset = "0xA7FD590", VA = "0x18A7FE590")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(params string[] vertexAttributes)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x410BF40", Offset = "0x410AF40", VA = "0x18410BF40")]
		public static TvP ConvertToGeometry<TvP>(this IVertexGeometry src) where TvP : struct, IVertexGeometry
		{
			return (TvP)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x410EA90", Offset = "0x410DA90", VA = "0x18410EA90")]
		public static TvM ConvertToMaterial<TvM>(this IVertexMaterial src) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x41125A0", Offset = "0x41115A0", VA = "0x1841125A0")]
		public static TvS ConvertToSkinning<TvS>(this IVertexSkinning src) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA7F4B10", Offset = "0xA7F3B10", VA = "0x18A7F4B10")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA7FEC00", Offset = "0xA7FDC00", VA = "0x18A7FEC00")]
		public static string _GetDebuggerDisplay(IVertexGeometry geo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA7FEEE0", Offset = "0xA7FDEE0", VA = "0x18A7FEEE0")]
		public static string _GetDebuggerDisplay(IVertexMaterial mat)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA7FF290", Offset = "0xA7FE290", VA = "0x18A7FF290")]
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
			[Cpp2IlInjected.Address(RVA = "0x51A8330", Offset = "0x51A7330", VA = "0x1851A8330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x51A8180", Offset = "0x51A7180", VA = "0x1851A8180")]
		public _CurveBuilderDebugProxy(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x51A7280", Offset = "0x51A6280", VA = "0x1851A7280")]
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
		[Cpp2IlInjected.Address(RVA = "0xA808370", Offset = "0xA807370", VA = "0x18A808370")]
		public _CurveBuilderDebugProxyBoolean(CurveBuilder<bool> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA808330", Offset = "0xA807330", VA = "0x18A808330", Slot = "4")]
		protected override bool GetTangent(bool a, bool b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal sealed class _CurveBuilderDebugProxyVector3 : _CurveBuilderDebugProxy<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA8084D0", Offset = "0xA8074D0", VA = "0x18A8084D0")]
		public _CurveBuilderDebugProxyVector3(CurveBuilder<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA808460", Offset = "0xA807460", VA = "0x18A808460", Slot = "4")]
		protected override Vector3 GetTangent(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	internal sealed class _CurveBuilderDebugProxyQuaternion : _CurveBuilderDebugProxy<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA8083C0", Offset = "0xA8073C0", VA = "0x18A8083C0")]
		public _CurveBuilderDebugProxyQuaternion(CurveBuilder<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA8018A0", Offset = "0xA8008A0", VA = "0x18A8018A0", Slot = "4")]
		protected override Quaternion GetTangent(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	internal sealed class _CurveBuilderDebugProxySparse : _CurveBuilderDebugProxy<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA808410", Offset = "0xA807410", VA = "0x18A808410")]
		public _CurveBuilderDebugProxySparse(CurveBuilder<SparseWeight8> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA802530", Offset = "0xA801530", VA = "0x18A802530", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6750220", Offset = "0x674F220", VA = "0x186750220", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0x1018420", Offset = "0x1017420", VA = "0x181018420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x1018420", Offset = "0x1017420", VA = "0x181018420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BF4A50", Offset = "0x5BF3A50", VA = "0x185BF4A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public TValue this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4B80", Offset = "0x5BF3B80", VA = "0x185BF4B80", Slot = "6")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4BC0", Offset = "0x5BF3BC0", VA = "0x185BF4BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<TValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x5BF4C10", Offset = "0x5BF3C10", VA = "0x185BF4C10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x5788190", Offset = "0x5787190", VA = "0x185788190")]
		static EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4A10", Offset = "0x5BF3A10", VA = "0x185BF4A10", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5BF48E0", Offset = "0x5BF38E0", VA = "0x185BF48E0", Slot = "10")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<GetEnumerator>d__15))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x5BF49B0", Offset = "0x5BF39B0", VA = "0x185BF49B0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FF9290", Offset = "0x4FF8290", VA = "0x184FF9290", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x65AF700", Offset = "0x65AE700", VA = "0x1865AF700", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5169B30", Offset = "0x5168B30", VA = "0x185169B30")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x6751930", Offset = "0x6750930", VA = "0x186751930", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x6751580", Offset = "0x6750580", VA = "0x186751580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x541CE70", Offset = "0x541BE70", VA = "0x18541CE70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x541CE70", Offset = "0x541BE70", VA = "0x18541CE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5169B30", Offset = "0x5168B30", VA = "0x185169B30")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x6751930", Offset = "0x6750930", VA = "0x186751930", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x6F49AB0", Offset = "0x6F48AB0", VA = "0x186F49AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x7E1E1B0", Offset = "0x7E1D1B0", VA = "0x187E1E1B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E420", Offset = "0x7E1D420", VA = "0x187E1E420")]
		public static implicit operator Triple<T>([In] (T A, T B, T C) triple)
		{
			return default(Triple<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DF80", Offset = "0x7E1CF80", VA = "0x187E1DF80")]
		public Triple(T a, T b, T c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D750", Offset = "0x7E1C750", VA = "0x187E1D750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D4A0", Offset = "0x7E1C4A0", VA = "0x187E1D4A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7E1CE60", Offset = "0x7E1BE60", VA = "0x187E1CE60", Slot = "8")]
		public bool Equals(Triple<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E330", Offset = "0x7E1D330", VA = "0x187E1E330")]
		public static bool operator ==([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E760", Offset = "0x7E1D760", VA = "0x187E1E760")]
		public static bool operator !=([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D5E0", Offset = "0x7E1C5E0", VA = "0x187E1D5E0", Slot = "6")]
		[IteratorStateMachine(typeof(Triple<>.<GetEnumerator>d__14))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DE10", Offset = "0x7E1CE10", VA = "0x187E1DE10", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0x51BAAF0", Offset = "0x51B9AF0", VA = "0x1851BAAF0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A60")]
				[Cpp2IlInjected.Address(RVA = "0x51B9D80", Offset = "0x51B8D80", VA = "0x1851B9D80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x51BA6D0", Offset = "0x51B96D0", VA = "0x1851BA6D0")]
			internal _ValueEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x51B85C0", Offset = "0x51B75C0", VA = "0x1851B85C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x51B9670", Offset = "0x51B8670", VA = "0x1851B9670", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
			public _IndexCollection(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x51AC3E0", Offset = "0x51AB3E0", VA = "0x1851AC3E0", Slot = "4")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x51AC3E0", Offset = "0x51AB3E0", VA = "0x1851AC3E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A69")]
				[Cpp2IlInjected.Address(RVA = "0x242DD20", Offset = "0x242CD20", VA = "0x18242DD20", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x51AC920", Offset = "0x51AB920", VA = "0x1851AC920")]
			internal _IndexEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x51AC490", Offset = "0x51AB490", VA = "0x1851AC490", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x51AC8A0", Offset = "0x51AB8A0", VA = "0x1851AC8A0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x81268C0", Offset = "0x81258C0", VA = "0x1881268C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public IEnumerable<int> Indices
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x8125AD0", Offset = "0x8124AD0", VA = "0x188125AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x8125110", Offset = "0x8124110", VA = "0x188125110")]
		public ValueListSet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x8124450", Offset = "0x8123450", VA = "0x188124450")]
		public ValueListSet(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x8116070", Offset = "0x8115070", VA = "0x188116070")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x811AF60", Offset = "0x8119F60", VA = "0x18811AF60")]
		public bool Exists(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x811BAB0", Offset = "0x811AAB0", VA = "0x18811BAB0")]
		public int IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x811BD60", Offset = "0x811AD60", VA = "0x18811BD60")]
		public int Use([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x8114800", Offset = "0x8113800", VA = "0x188114800")]
		public int Add([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x8116A20", Offset = "0x8115A20", VA = "0x188116A20")]
		public bool Contains([In] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x8119D40", Offset = "0x8118D40", VA = "0x188119D40")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x81183A0", Offset = "0x81173A0", VA = "0x1881183A0")]
		public void CopyTo(ValueListSet<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x811B890", Offset = "0x811A890", VA = "0x18811B890", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x811B890", Offset = "0x811A890", VA = "0x18811B890", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x8114FE0", Offset = "0x8113FE0", VA = "0x188114FE0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x811F8B0", Offset = "0x811E8B0", VA = "0x18811F8B0")]
		private void _Initialize(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x811D090", Offset = "0x811C090", VA = "0x18811D090")]
		private int _IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x81219D0", Offset = "0x81209D0", VA = "0x1881219D0")]
		private int _Insert([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x811C320", Offset = "0x811B320", VA = "0x18811C320")]
		private void _Grow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x8122840", Offset = "0x8121840", VA = "0x188122840")]
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
				[Cpp2IlInjected.Address(RVA = "0x51AE8E0", Offset = "0x51AD8E0", VA = "0x1851AE8E0")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x51AE990", Offset = "0x51AD990", VA = "0x1851AE990")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x51AE870", Offset = "0x51AD870", VA = "0x1851AE870")]
			public _KeyComparer(IReadOnlyList<T> items)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x51AE320", Offset = "0x51AD320", VA = "0x1851AE320", Slot = "4")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x51AE650", Offset = "0x51AD650", VA = "0x1851AE650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8717210", Offset = "0x8716210", VA = "0x188717210", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0x87171D0", Offset = "0x87161D0", VA = "0x1887171D0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x8717080", Offset = "0x8716080", VA = "0x188717080")]
		public VertexList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x8716AC0", Offset = "0x8715AC0", VA = "0x188716AC0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x8716AC0", Offset = "0x8715AC0", VA = "0x188716AC0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x8716D50", Offset = "0x8715D50", VA = "0x188716D50")]
		public int Use([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x8716B70", Offset = "0x8715B70", VA = "0x188716B70")]
		public int IndexOf([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x8716DD0", Offset = "0x8715DD0", VA = "0x188716DD0")]
		private int _Add([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x8716850", Offset = "0x8715850", VA = "0x188716850")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x8716A80", Offset = "0x8715A80", VA = "0x188716A80")]
		public void CopyTo(VertexList<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x8716F10", Offset = "0x8715F10", VA = "0x188716F10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA808830", Offset = "0xA807830", VA = "0x18A808830")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA808610", Offset = "0xA807610", VA = "0x18A808610")]
		public static int GetPrime(int min)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA8085A0", Offset = "0xA8075A0", VA = "0x18A8085A0")]
		public static int GetMinPrime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA808520", Offset = "0xA807520", VA = "0x18A808520")]
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
			[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xF6AC00", Offset = "0xF69C00", VA = "0x180F6AC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x74A43B0", Offset = "0x74A33B0", VA = "0x1874A43B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public IReadOnlyDictionary<string, ICurveSampler<T>> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x74A45B0", Offset = "0x74A35B0", VA = "0x1874A45B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		internal AnimatableProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x74A40F0", Offset = "0x74A30F0", VA = "0x1874A40F0")]
		internal AnimatableProperty(AnimatableProperty<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x7499E70", Offset = "0x7498E70", VA = "0x187499E70")]
		public AnimatableProperty<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x749AF30", Offset = "0x7499F30", VA = "0x18749AF30")]
		public void RemoveTrack(string track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x749A180", Offset = "0x7499180", VA = "0x18749A180")]
		public T GetValueAt(string track, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x749DC30", Offset = "0x749CC30", VA = "0x18749DC30")]
		public void SetTrack(string track, ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x749F130", Offset = "0x749E130", VA = "0x18749F130")]
		public CurveBuilder<T> UseTrackBuilder(string track)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x749E7C0", Offset = "0x749D7C0", VA = "0x18749E7C0")]
		public void SetValue(params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x749F790", Offset = "0x749E790", VA = "0x18749F790")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x541B140", Offset = "0x541A140", VA = "0x18541B140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x541B3F0", Offset = "0x541A3F0", VA = "0x18541B3F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x541A450", Offset = "0x5419450", VA = "0x18541A450")]
		protected CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x541A0E0", Offset = "0x54190E0", VA = "0x18541A0E0")]
		protected CurveBuilder(CurveBuilder<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x4FB30D0", Offset = "0x4FB20D0", VA = "0x184FB30D0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5401820", Offset = "0x5400820", VA = "0x185401820")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x5402970", Offset = "0x5401970", VA = "0x185402970")]
		public void RemoveKey(float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x540EA50", Offset = "0x540DA50", VA = "0x18540EA50")]
		public void SetPoint(float offset, bool isLinear, params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x540E540", Offset = "0x540D540", VA = "0x18540E540")]
		public void SetPoint(float offset, T value, bool isLinear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x540A160", Offset = "0x5409160", VA = "0x18540A160")]
		public void SetIncomingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x540D780", Offset = "0x540C780", VA = "0x18540D780")]
		public void SetOutgoingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x5401880", Offset = "0x5400880", VA = "0x185401880")]
		private protected (_CurveNode<T>, _CurveNode<T>, float) FindSample(float offset)
		{
			return default((_CurveNode<T>, _CurveNode<T>, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x5403950", Offset = "0x5402950", VA = "0x185403950")]
		public void SetCurve(ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x5403150", Offset = "0x5402150", VA = "0x185403150")]
		public void SetCurve(IConvertibleCurve<T> convertible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x54061F0", Offset = "0x54051F0", VA = "0x1854061F0")]
		public void SetCurve(IAnimationSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x5419370", Offset = "0x5418370", VA = "0x185419370")]
		public CurveBuilder<T> WithPoint(float offset, T value, bool isLinear = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x5418B40", Offset = "0x5417B40", VA = "0x185418B40")]
		public CurveBuilder<T> WithIncomingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x5419080", Offset = "0x5418080", VA = "0x185419080")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x5419220", Offset = "0x5418220", VA = "0x185419220")]
		public CurveBuilder<T> WithPoint(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x5418FF0", Offset = "0x5417FF0", VA = "0x185418FF0")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x5418B80", Offset = "0x5417B80", VA = "0x185418B80")]
		public CurveBuilder<T> WithIncomingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x5417F30", Offset = "0x5416F30", VA = "0x185417F30", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x540F6A0", Offset = "0x540E6A0", VA = "0x18540F6A0", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x54128C0", Offset = "0x54118C0", VA = "0x1854128C0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x51A9990", Offset = "0x51A8990", VA = "0x1851A9990")]
		private string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x51AB8B0", Offset = "0x51AA8B0", VA = "0x1851AB8B0")]
		private static string _ToString(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x51AC020", Offset = "0x51AB020", VA = "0x1851AC020")]
		public _CurveNode(T value, bool isLinear)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x51ABCD0", Offset = "0x51AACD0", VA = "0x1851ABCD0")]
		public _CurveNode(T incoming, T value, T outgoing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x51A84B0", Offset = "0x51A74B0", VA = "0x1851A84B0")]
		public _CurveNode<T> Clone(Func<T, T> cloneValue)
		{
			return default(_CurveNode<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal static class CurveFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x38DB0B0", Offset = "0x38DA0B0", VA = "0x1838DB0B0")]
		public static CurveBuilder<T> CreateCurveBuilder<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x38DB510", Offset = "0x38DA510", VA = "0x1838DB510")]
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
		[Cpp2IlInjected.Address(RVA = "0xA801430", Offset = "0xA800430", VA = "0x18A801430")]
		public BooleanCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0xA801470", Offset = "0xA800470", VA = "0x18A801470")]
		private BooleanCurveBuilder(BooleanCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA801190", Offset = "0xA800190", VA = "0x18A801190", Slot = "10")]
		public override CurveBuilder<bool> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xA53AA70", Offset = "0xA539A70", VA = "0x18A53AA70", Slot = "11")]
		protected override bool AreEqual(bool left, bool right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x142BD70", Offset = "0x142AD70", VA = "0x18142BD70", Slot = "12")]
		protected override bool CloneValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0xA801210", Offset = "0xA800210", VA = "0x18A801210", Slot = "13")]
		protected override bool CreateValue(IReadOnlyList<float> values)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0xA8013F0", Offset = "0xA8003F0", VA = "0x18A8013F0", Slot = "15")]
		protected override bool GetTangent(bool fromValue, bool toValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0xA801330", Offset = "0xA800330", VA = "0x18A801330", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8082F0", Offset = "0xA8072F0", VA = "0x18A8082F0")]
		public Vector3CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0xA8082A0", Offset = "0xA8072A0", VA = "0x18A8082A0")]
		private Vector3CurveBuilder(Vector3CurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA807E80", Offset = "0xA806E80", VA = "0x18A807E80", Slot = "10")]
		public override CurveBuilder<Vector3> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA807E30", Offset = "0xA806E30", VA = "0x18A807E30", Slot = "11")]
		protected override bool AreEqual(Vector3 left, Vector3 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x10633D0", Offset = "0x10623D0", VA = "0x1810633D0", Slot = "12")]
		protected override Vector3 CloneValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xA807F00", Offset = "0xA806F00", VA = "0x18A807F00", Slot = "13")]
		protected override Vector3 CreateValue(IReadOnlyList<float> values)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA808230", Offset = "0xA807230", VA = "0x18A808230", Slot = "15")]
		protected override Vector3 GetTangent(Vector3 fromValue, Vector3 toValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA808080", Offset = "0xA807080", VA = "0x18A808080", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8018F0", Offset = "0xA8008F0", VA = "0x18A8018F0")]
		public QuaternionCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0xA801930", Offset = "0xA800930", VA = "0x18A801930")]
		private QuaternionCurveBuilder(QuaternionCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xA8014F0", Offset = "0xA8004F0", VA = "0x18A8014F0", Slot = "10")]
		public override CurveBuilder<Quaternion> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA8014C0", Offset = "0xA8004C0", VA = "0x18A8014C0", Slot = "11")]
		protected override bool AreEqual(Quaternion left, Quaternion right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x12C7CA0", Offset = "0x12C6CA0", VA = "0x1812C7CA0", Slot = "12")]
		protected override Quaternion CloneValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA801570", Offset = "0xA800570", VA = "0x18A801570", Slot = "13")]
		protected override Quaternion CreateValue(IReadOnlyList<float> values)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA8018A0", Offset = "0xA8008A0", VA = "0x18A8018A0", Slot = "15")]
		protected override Quaternion GetTangent(Quaternion fromValue, Quaternion toValue)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA801720", Offset = "0xA800720", VA = "0x18A801720", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8025C0", Offset = "0xA8015C0", VA = "0x18A8025C0")]
		public SparseCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA802570", Offset = "0xA801570", VA = "0x18A802570")]
		private SparseCurveBuilder(SparseCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0xA802260", Offset = "0xA801260", VA = "0x18A802260", Slot = "10")]
		public override CurveBuilder<SparseWeight8> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0xA802220", Offset = "0xA801220", VA = "0x18A802220", Slot = "11")]
		protected override bool AreEqual(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x577B340", Offset = "0x577A340", VA = "0x18577B340", Slot = "12")]
		protected override SparseWeight8 CloneValue(SparseWeight8 value)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0xA8022E0", Offset = "0xA8012E0", VA = "0x18A8022E0", Slot = "13")]
		protected override SparseWeight8 CreateValue(IReadOnlyList<float> values)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xA802530", Offset = "0xA801530", VA = "0x18A802530", Slot = "15")]
		protected override SparseWeight8 GetTangent(SparseWeight8 fromValue, SparseWeight8 toValue)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0xA802320", Offset = "0xA801320", VA = "0x18A802320", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8021E0", Offset = "0xA8011E0", VA = "0x18A8021E0")]
		public SegmentCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0xA802190", Offset = "0xA801190", VA = "0x18A802190")]
		private SegmentCurveBuilder(SegmentCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0xA801CD0", Offset = "0xA800CD0", VA = "0x18A801CD0", Slot = "10")]
		public override CurveBuilder<ArraySegment<float>> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0xA801980", Offset = "0xA800980", VA = "0x18A801980", Slot = "11")]
		protected override bool AreEqual(ArraySegment<float> left, ArraySegment<float> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0xA801BC0", Offset = "0xA800BC0", VA = "0x18A801BC0", Slot = "12")]
		protected override ArraySegment<float> CloneValue(ArraySegment<float> value)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0xA801D50", Offset = "0xA800D50", VA = "0x18A801D50", Slot = "13")]
		protected override ArraySegment<float> CreateValue(IReadOnlyList<float> values)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0xA8020E0", Offset = "0xA8010E0", VA = "0x18A8020E0", Slot = "15")]
		protected override ArraySegment<float> GetTangent(ArraySegment<float> fromValue, ArraySegment<float> toValue)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xA801E90", Offset = "0xA800E90", VA = "0x18A801E90", Slot = "14")]
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

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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected BaseBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		protected BaseBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		protected BaseBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA52AF20", Offset = "0xA52A320", VA = "0x18A52AF20")]
		protected BaseBuilder(BaseBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA52AD30", Offset = "0xA52A130", VA = "0x18A52AD30")]
		protected static int GetContentHashCode(BaseBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA52AC20", Offset = "0xA52A020", VA = "0x18A52AC20")]
		protected static bool AreEqualByContent(BaseBuilder x, BaseBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA52AE40", Offset = "0xA52A240", VA = "0x18A52AE40")]
		internal void SetNameAndExtrasFrom(BaseBuilder source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA52ADC0", Offset = "0xA52A1C0", VA = "0x18A52ADC0")]
		internal void SetNameAndExtrasFrom(LogicalChildOfRoot source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA52AEC0", Offset = "0xA52A2C0", VA = "0x18A52AEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52CBB0", Offset = "0xA52BFB0", VA = "0x18A52CBB0")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA52BB90", Offset = "0xA52AF90", VA = "0x18A52BB90")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA52BE00", Offset = "0xA52B200", VA = "0x18A52BE00")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA52C050", Offset = "0xA52B450", VA = "0x18A52C050")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA52BAF0", Offset = "0xA52AEF0", VA = "0x18A52BAF0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA52C830", Offset = "0xA52BC30", VA = "0x18A52C830")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA52C710", Offset = "0xA52BB10", VA = "0x18A52C710")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA52CD00", Offset = "0xA52C100", VA = "0x18A52CD00")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA52CCA0", Offset = "0xA52C0A0", VA = "0x18A52CCA0")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA52C550", Offset = "0xA52B950", VA = "0x18A52C550")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC290", Offset = "0x3ACB690", VA = "0x183ACC290")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA970", Offset = "0x3AC9D70", VA = "0x183ACA970")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA52C5B0", Offset = "0xA52B9B0", VA = "0x18A52C5B0")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBE30", Offset = "0x3ACB230", VA = "0x183ACBE30")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB9D0", Offset = "0x3ACADD0", VA = "0x183ACB9D0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB590", Offset = "0x3ACA990", VA = "0x183ACB590")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB290", Offset = "0x3ACA690", VA = "0x183ACB290")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7B00", Offset = "0x3AC6F00", VA = "0x183AC7B00")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA52C150", Offset = "0xA52B550", VA = "0x18A52C150")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA52C0F0", Offset = "0xA52B4F0", VA = "0x18A52C0F0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA52C1B0", Offset = "0xA52B5B0", VA = "0x18A52C1B0")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA52CA50", Offset = "0xA52BE50", VA = "0x18A52CA50")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA52C950", Offset = "0xA52BD50", VA = "0x18A52C950")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA6D0", Offset = "0x3AC9AD0", VA = "0x183ACA6D0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA52B860", Offset = "0xA52AC60", VA = "0x18A52B860")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9980", Offset = "0x3AC8D80", VA = "0x183AC9980")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8EF0", Offset = "0x3AC82F0", VA = "0x183AC8EF0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8EF0", Offset = "0x3AC82F0", VA = "0x183AC8EF0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8EF0", Offset = "0x3AC82F0", VA = "0x183AC8EF0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8EF0", Offset = "0x3AC82F0", VA = "0x183AC8EF0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8300", Offset = "0x3AC7700", VA = "0x183AC8300")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x668D5A0", Offset = "0x668C9A0", VA = "0x18668D5A0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x668B9F0", Offset = "0x668ADF0", VA = "0x18668B9F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x668DBD0", Offset = "0x668CFD0", VA = "0x18668DBD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6EF4F90", Offset = "0x6EF4390", VA = "0x186EF4F90", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6EF1540", Offset = "0x6EF0940", VA = "0x186EF1540", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6EF5490", Offset = "0x6EF4890", VA = "0x186EF5490")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x513EF80", Offset = "0x513E380", VA = "0x18513EF80", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x513EB10", Offset = "0x513DF10", VA = "0x18513EB10", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x513E7C0", Offset = "0x513DBC0", VA = "0x18513E7C0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x513EA60", Offset = "0x513DE60", VA = "0x18513EA60", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6688340", Offset = "0x6687740", VA = "0x186688340", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6686BA0", Offset = "0x6685FA0", VA = "0x186686BA0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x66886D0", Offset = "0x6687AD0", VA = "0x1866886D0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6EEBEE0", Offset = "0x6EEB2E0", VA = "0x186EEBEE0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6EEBB80", Offset = "0x6EEAF80", VA = "0x186EEBB80", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6EEC300", Offset = "0x6EEB700", VA = "0x186EEC300")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5135CE0", Offset = "0x51350E0", VA = "0x185135CE0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5135990", Offset = "0x5134D90", VA = "0x185135990", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5135B60", Offset = "0x5134F60", VA = "0x185135B60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5490F0", Offset = "0xA5484F0", VA = "0x18A5490F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA549140", Offset = "0xA548540", VA = "0x18A549140", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA548DA0", Offset = "0xA5481A0", VA = "0x18A548DA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA549200", Offset = "0xA548600", VA = "0x18A549200")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA5490B0", Offset = "0xA5484B0", VA = "0x18A5490B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA549000", Offset = "0xA548400", VA = "0x18A549000", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA549000", Offset = "0xA548400", VA = "0x18A549000", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A14640", Offset = "0x1A13A40", VA = "0x181A14640", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA549BE0", Offset = "0xA548FE0", VA = "0x18A549BE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA549C30", Offset = "0xA549030", VA = "0x18A549C30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA549250", Offset = "0xA548650", VA = "0x18A549250", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA549E20", Offset = "0xA549220", VA = "0x18A549E20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA549E70", Offset = "0xA549270", VA = "0x18A549E70")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA549EC0", Offset = "0xA5492C0", VA = "0x18A549EC0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA549BA0", Offset = "0xA548FA0", VA = "0x18A549BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA549AF0", Offset = "0xA548EF0", VA = "0x18A549AF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA549AF0", Offset = "0xA548EF0", VA = "0x18A549AF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA472700", Offset = "0xA471B00", VA = "0x18A472700")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA474100", Offset = "0xA473500", VA = "0x18A474100")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA474230", Offset = "0xA473630", VA = "0x18A474230")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA474140", Offset = "0xA473540", VA = "0x18A474140")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA474260", Offset = "0xA473660", VA = "0x18A474260")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA4741A0", Offset = "0xA4735A0", VA = "0x18A4741A0")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA4742D0", Offset = "0xA4736D0", VA = "0x18A4742D0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA4741A0", Offset = "0xA4735A0", VA = "0x18A4741A0")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA474030", Offset = "0xA473430", VA = "0x18A474030")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA54BD60", Offset = "0xA54B160", VA = "0x18A54BD60")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA54BC40", Offset = "0xA54B040", VA = "0x18A54BC40")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA471AA0", Offset = "0xA470EA0", VA = "0x18A471AA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA54C610", Offset = "0xA54BA10", VA = "0x18A54C610")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4726B0", Offset = "0xA471AB0", VA = "0x18A4726B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA472650", Offset = "0xA471A50", VA = "0x18A472650")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA472930", Offset = "0xA471D30", VA = "0x18A472930")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1B0", Offset = "0xA54C5B0", VA = "0x18A54D1B0")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA54D330", Offset = "0xA54C730", VA = "0x18A54D330")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA54BF50", Offset = "0xA54B350", VA = "0x18A54BF50")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA54BE60", Offset = "0xA54B260", VA = "0x18A54BE60")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA54C230", Offset = "0xA54B630", VA = "0x18A54C230")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA54BAB0", Offset = "0xA54AEB0", VA = "0x18A54BAB0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5249A0", Offset = "0xA523DA0", VA = "0x18A5249A0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA473230", Offset = "0xA472630", VA = "0x18A473230")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA54BEE0", Offset = "0xA54B2E0", VA = "0x18A54BEE0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA472420", Offset = "0xA471820", VA = "0x18A472420")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA472360", Offset = "0xA471760", VA = "0x18A472360")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x41469B0", Offset = "0x4145DB0", VA = "0x1841469B0")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA471C10", Offset = "0xA471010", VA = "0x18A471C10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA471D80", Offset = "0xA471180", VA = "0x18A471D80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4148370", Offset = "0x4147770", VA = "0x184148370")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4148E80", Offset = "0x4148280", VA = "0x184148E80")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4149050", Offset = "0x4148450", VA = "0x184149050")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4149130", Offset = "0x4148530", VA = "0x184149130")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x41469D0", Offset = "0x4145DD0", VA = "0x1841469D0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4147B90", Offset = "0x4146F90", VA = "0x184147B90")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4147A80", Offset = "0x4146E80", VA = "0x184147A80")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x41471C0", Offset = "0x41465C0", VA = "0x1841471C0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4148DA0", Offset = "0x41481A0", VA = "0x184148DA0")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4148710", Offset = "0x4147B10", VA = "0x184148710")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4148CB0", Offset = "0x41480B0", VA = "0x184148CB0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x41488B0", Offset = "0x4147CB0", VA = "0x1841488B0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4147070", Offset = "0x4146470", VA = "0x184147070")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4146C10", Offset = "0x4146010", VA = "0x184146C10")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4146630", Offset = "0x4145A30", VA = "0x184146630")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4146A60", Offset = "0x4145E60", VA = "0x184146A60")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA54C020", Offset = "0xA54B420", VA = "0x18A54C020")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA54C390", Offset = "0xA54B790", VA = "0x18A54C390")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4148E00", Offset = "0x4148200", VA = "0x184148E00")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4148E00", Offset = "0x4148200", VA = "0x184148E00")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA54C8C0", Offset = "0xA54BCC0", VA = "0x18A54C8C0")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA54B410", Offset = "0xA54A810", VA = "0x18A54B410")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA54B360", Offset = "0xA54A760", VA = "0x18A54B360")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA54C840", Offset = "0xA54BC40", VA = "0x18A54C840")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA54CF80", Offset = "0xA54C380", VA = "0x18A54CF80")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA54B490", Offset = "0xA54A890", VA = "0x18A54B490")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA54CEB0", Offset = "0xA54C2B0", VA = "0x18A54CEB0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA54CAC0", Offset = "0xA54BEC0", VA = "0x18A54CAC0")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA54B800", Offset = "0xA54AC00", VA = "0x18A54B800")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA54B550", Offset = "0xA54A950", VA = "0x18A54B550")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA54B920", Offset = "0xA54AD20", VA = "0x18A54B920")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA54B6E0", Offset = "0xA54AAE0", VA = "0x18A54B6E0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA54B8A0", Offset = "0xA54ACA0", VA = "0x18A54B8A0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x238B330", Offset = "0x238A730", VA = "0x18238B330")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA474120", Offset = "0xA473520", VA = "0x18A474120")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4149360", Offset = "0x4148760", VA = "0x184149360")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA54C780", Offset = "0xA54BB80", VA = "0x18A54C780")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA54B760", Offset = "0xA54AB60", VA = "0x18A54B760")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA54D100", Offset = "0xA54C500", VA = "0x18A54D100")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA54D530", Offset = "0xA54C930", VA = "0x18A54D530")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA54D000", Offset = "0xA54C400", VA = "0x18A54D000")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA471CB0", Offset = "0xA4710B0", VA = "0x18A471CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C5E40", Offset = "0x40C5240", VA = "0x1840C5E40")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA54AFF0", Offset = "0xA54A3F0", VA = "0x18A54AFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40D7760", Offset = "0x40D6B60", VA = "0x1840D7760")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA54B1B0", Offset = "0xA54A5B0", VA = "0x18A54B1B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA547180", Offset = "0xA546580", VA = "0x18A547180", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <EvaluateLines>d__77(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA5471D0", Offset = "0xA5465D0", VA = "0x18A5471D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA546AD0", Offset = "0xA545ED0", VA = "0x18A546AD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA5473A0", Offset = "0xA5467A0", VA = "0x18A5473A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA5473F0", Offset = "0xA5467F0", VA = "0x18A5473F0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA547140", Offset = "0xA546540", VA = "0x18A547140", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA547090", Offset = "0xA546490", VA = "0x18A547090", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA547090", Offset = "0xA546490", VA = "0x18A547090", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA547A30", Offset = "0xA546E30", VA = "0x18A547A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1BD70", VA = "0x181D1C970")]
			[DebuggerHidden]
			public <EvaluatePoints>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA547A80", Offset = "0xA546E80", VA = "0x18A547A80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA547450", Offset = "0xA546850", VA = "0x18A547450", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA547C80", Offset = "0xA547080", VA = "0x18A547C80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA547CD0", Offset = "0xA5470D0", VA = "0x18A547CD0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5479F0", Offset = "0xA546DF0", VA = "0x18A5479F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA547940", Offset = "0xA546D40", VA = "0x18A547940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA547940", Offset = "0xA546D40", VA = "0x18A547940", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E874C0", Offset = "0x4E868C0", VA = "0x184E874C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA548450", Offset = "0xA547850", VA = "0x18A548450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x65D8650", Offset = "0x65D7A50", VA = "0x1865D8650")]
			[DebuggerHidden]
			public <EvaluateTriangles>d__79(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5484A0", Offset = "0xA5478A0", VA = "0x18A5484A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA547D20", Offset = "0xA547120", VA = "0x18A547D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA548680", Offset = "0xA547A80", VA = "0x18A548680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5486D0", Offset = "0xA547AD0", VA = "0x18A5486D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA548410", Offset = "0xA547810", VA = "0x18A548410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA548360", Offset = "0xA547760", VA = "0x18A548360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA548360", Offset = "0xA547760", VA = "0x18A548360", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA53D720", Offset = "0xA53CB20", VA = "0x18A53D720")]
		public static Accessor CreateMorphTargetAccessor(this ModelRoot root, MemoryAccessor memAccessor, int sparsityPercent = 60)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA53D980", Offset = "0xA53CD80", VA = "0x18A53D980")]
		public static Accessor CreateVertexAccessor(this ModelRoot root, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F34D50", Offset = "0x3F34150", VA = "0x183F34D50")]
		public static BufferView CreateBufferView<T>(this ModelRoot root, IReadOnlyList<T> data) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA53F950", Offset = "0xA53ED50", VA = "0x18A53F950")]
		public static Animation UseAnimation(this ModelRoot root, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA543A20", Offset = "0xA542E20", VA = "0x18A543A20")]
		public static Node WithScaleAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA545130", Offset = "0xA544530", VA = "0x18A545130")]
		public static Node WithTranslationAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA542820", Offset = "0xA541C20", VA = "0x18A542820")]
		public static Node WithMorphingAnimation(this Node node, string animationName, ICurveSampler<SparseWeight8> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B4C0", Offset = "0x3F3A8C0", VA = "0x183F3B4C0")]
		public static Node WithMorphingAnimation<T>(this Node node, string animationName, ICurveSampler<T> sampler) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5436E0", Offset = "0xA542AE0", VA = "0x18A5436E0")]
		public static Node WithRotationAnimation(this Node node, string animationName, ICurveSampler<Quaternion> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA545C40", Offset = "0xA545040", VA = "0x18A545C40")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, ICurveSampler<bool> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA543C30", Offset = "0xA543030", VA = "0x18A543C30")]
		public static Node WithScaleAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA543270", Offset = "0xA542670", VA = "0x18A543270")]
		public static Node WithRotationAnimation(this Node node, string animationName, params (float Key, Quaternion Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA544DF0", Offset = "0xA5441F0", VA = "0x18A544DF0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5438F0", Offset = "0xA542CF0", VA = "0x18A5438F0")]
		public static Node WithScaleAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5435B0", Offset = "0xA5429B0", VA = "0x18A5435B0")]
		public static Node WithRotationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA544CC0", Offset = "0xA5440C0", VA = "0x18A544CC0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA545DE0", Offset = "0xA5451E0", VA = "0x18A545DE0")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, IReadOnlyDictionary<float, bool> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA544BF0", Offset = "0xA543FF0", VA = "0x18A544BF0")]
		public static PunctualLight WithSpotCone(this PunctualLight light, float innerConeAngle, float outerConeAngle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5405B0", Offset = "0xA53F9B0", VA = "0x18A5405B0")]
		public static PunctualLight WithColor(this PunctualLight light, Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5406C0", Offset = "0xA53FAC0", VA = "0x18A5406C0")]
		public static Material WithDefault(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5407D0", Offset = "0xA53FBD0", VA = "0x18A5407D0")]
		public static Material WithDefault(this Material material, Vector4 diffuseColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5409B0", Offset = "0xA53FDB0", VA = "0x18A5409B0")]
		public static Material WithDoubleSide(this Material material, bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA53FFA0", Offset = "0xA53F3A0", VA = "0x18A53FFA0")]
		[Obsolete("don't use vector4 based parameter. Use WithChannelColor and WithChannelFactor instead.")]
		public static Material WithChannelParameter(this Material material, string channelName, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA53FCB0", Offset = "0xA53F0B0", VA = "0x18A53FCB0")]
		public static Material WithChannelColor(this Material material, string channelName, Vector4 color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA53FE20", Offset = "0xA53F220", VA = "0x18A53FE20")]
		public static Material WithChannelFactor(this Material material, string channelName, string paramName, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5402C0", Offset = "0xA53F6C0", VA = "0x18A5402C0")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, string imageFilePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA540110", Offset = "0xA53F510", VA = "0x18A540110")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, Image image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA542C90", Offset = "0xA542090", VA = "0x18A542C90")]
		public static Material WithPBRMetallicRoughness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA542D60", Offset = "0xA542160", VA = "0x18A542D60")]
		public static Material WithPBRMetallicRoughness(this Material material, Vector4 baseColor, string baseColorImageFilePath, [Optional] string metallicImageFilePath, float metallicFactor = 1f, float roughnessFactor = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA543060", Offset = "0xA542460", VA = "0x18A543060")]
		[Obsolete("SpecularGlossiness Extension has been declared deprecated by the Khronos Group. Use newer extensions instead.")]
		public static Material WithPBRSpecularGlossiness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA545340", Offset = "0xA544740", VA = "0x18A545340")]
		public static Material WithUnlit(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA53FB90", Offset = "0xA53EF90", VA = "0x18A53FB90")]
		public static Image UseImageWithFile(this ModelRoot root, string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA53FAC0", Offset = "0xA53EEC0", VA = "0x18A53FAC0")]
		public static Image UseImageWithContent(this ModelRoot root, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA53D220", Offset = "0xA53C620", VA = "0x18A53D220")]
		public static Material CreateMaterial(this ModelRoot root, MaterialBuilder mb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA53EFF0", Offset = "0xA53E3F0", VA = "0x18A53EFF0")]
		public static MaterialBuilder ToMaterialBuilder(this Material srcMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA53F5F0", Offset = "0xA53E9F0", VA = "0x18A53F5F0")]
		public static AlphaMode ToSchema2(this SharpGLTF.Materials.AlphaMode alpha)
		{
			return default(AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA53F6A0", Offset = "0xA53EAA0", VA = "0x18A53F6A0")]
		public static SharpGLTF.Materials.AlphaMode ToToolkit(this AlphaMode alpha)
		{
			return default(SharpGLTF.Materials.AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA53BE50", Offset = "0xA53B250", VA = "0x18A53BE50")]
		public static void CopyTo(this Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA546330", Offset = "0xA545730", VA = "0x18A546330")]
		private static void _CopyMetallicRoughnessTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA546050", Offset = "0xA545450", VA = "0x18A546050")]
		private static void _CopyDefaultTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA53B3D0", Offset = "0xA53A7D0", VA = "0x18A53B3D0")]
		public static void CopyChannelsTo(this Material srcMaterial, MaterialBuilder dstMaterial, params string[] channelKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA53B6C0", Offset = "0xA53AAC0", VA = "0x18A53B6C0")]
		public static void CopyTo(this MaterialChannel srcChannel, ChannelBuilder dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA53C7D0", Offset = "0xA53BBD0", VA = "0x18A53C7D0")]
		public static void CopyTo(this MaterialBuilder srcMaterial, Material dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA53B280", Offset = "0xA53A680", VA = "0x18A53B280")]
		[Obsolete]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params string[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA53AFC0", Offset = "0xA53A3C0", VA = "0x18A53AFC0")]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params KnownChannel[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA53C1D0", Offset = "0xA53B5D0", VA = "0x18A53C1D0")]
		public static void CopyTo(this ChannelBuilder srcChannel, MaterialChannel dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA545F10", Offset = "0xA545310", VA = "0x18A545F10")]
		private static Image _ConvertToImage(MaterialChannel dstChannel, ImageBuilder srcImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA53E6E0", Offset = "0xA53DAE0", VA = "0x18A53E6E0")]
		public static Vector4 GetDiffuseColor(this Material material, Vector4 defaultColor)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA53EB40", Offset = "0xA53DF40", VA = "0x18A53EB40")]
		public static Texture GetDiffuseTexture(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA53EA00", Offset = "0xA53DE00", VA = "0x18A53EA00")]
		public static TextureTransform GetDiffuseTextureTransform(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA53E830", Offset = "0xA53DC30", VA = "0x18A53E830")]
		public static Matrix3x2? GetDiffuseTextureMatrix(this Material material, Animation track, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA53D350", Offset = "0xA53C750", VA = "0x18A53D350")]
		public static Mesh CreateMesh(this ModelRoot root, IMeshBuilder<MaterialBuilder> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F36B20", Offset = "0x3F35F20", VA = "0x183F36B20")]
		public static Mesh CreateMesh<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialEvaluator, IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA53D590", Offset = "0xA53C990", VA = "0x18A53D590")]
		public static IReadOnlyList<Mesh> CreateMeshes(this ModelRoot root, params IMeshBuilder<MaterialBuilder>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F387D0", Offset = "0x3F37BD0", VA = "0x183F387D0")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F37B70", Offset = "0x3F36F70", VA = "0x183F37B70")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, SceneBuilderSchema2Settings settings, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA540E40", Offset = "0xA540240", VA = "0x18A540E40")]
		public static MeshPrimitive WithIndicesAutomatic(this MeshPrimitive primitive, PrimitiveType primitiveType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA540A70", Offset = "0xA53FE70", VA = "0x18A540A70")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, IReadOnlyList<int> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BE60", Offset = "0x3F3B260", VA = "0x183F3BE60")]
		public static MeshPrimitive WithVertexAccessor<T>(this MeshPrimitive primitive, string attribute, IReadOnlyList<T> values, bool useExplicitByteStride = false) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA545AF0", Offset = "0xA544EF0", VA = "0x18A545AF0")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPosition> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA5459A0", Offset = "0xA544DA0", VA = "0x18A5459A0")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPositionNormal> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C470", Offset = "0x3F3B870", VA = "0x183F3C470")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C470", Offset = "0x3F3B870", VA = "0x183F3C470")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM, TvS>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat, TvS Skin)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C630", Offset = "0x3F3BA30", VA = "0x183F3C630")]
		public static MeshPrimitive WithVertexAccessors<TVertex>(this MeshPrimitive primitive, IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA545600", Offset = "0xA544A00", VA = "0x18A545600")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA5453F0", Offset = "0xA5447F0", VA = "0x18A5453F0")]
		public static MeshPrimitive WithVertexAccessor(this MeshPrimitive primitive, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA540D20", Offset = "0xA540120", VA = "0x18A540D20")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA542550", Offset = "0xA541950", VA = "0x18A542550")]
		public static MeshPrimitive WithMorphTargetAccessors(this MeshPrimitive primitive, int targetIndex, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F3AC20", Offset = "0x3F3A020", VA = "0x183F3AC20")]
		public static MeshGpuInstancing WithInstanceAccessor<T>(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<T> values) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA540F20", Offset = "0xA540320", VA = "0x18A540F20")]
		public static MeshGpuInstancing WithInstanceAccessors(this MeshGpuInstancing instancing, IReadOnlyList<AffineTransform> transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA541930", Offset = "0xA540D30", VA = "0x18A541930")]
		public static MeshGpuInstancing WithInstanceCustomAccessors(this MeshGpuInstancing instancing, IReadOnlyList<JsonNode> extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA5416C0", Offset = "0xA540AC0", VA = "0x18A5416C0")]
		public static MeshGpuInstancing WithInstanceCustomAccessor(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<JsonNode> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3F3CAE0", Offset = "0x3F3BEE0", VA = "0x183F3CAE0")]
		private static List<T> _SelectAttribute<T>(IReadOnlyList<JsonNode> values, string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA5423D0", Offset = "0xA5417D0", VA = "0x18A5423D0")]
		public static MeshPrimitive WithMaterial(this MeshPrimitive primitive, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA53DD30", Offset = "0xA53D130", VA = "0x18A53DD30")]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA53DCA0", Offset = "0xA53D0A0", VA = "0x18A53DCA0")]
		[IteratorStateMachine(typeof(<EvaluatePoints>d__75))]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA53DAB0", Offset = "0xA53CEB0", VA = "0x18A53DAB0")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA53DC10", Offset = "0xA53D010", VA = "0x18A53DC10")]
		[IteratorStateMachine(typeof(<EvaluateLines>d__77))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA53E100", Offset = "0xA53D500", VA = "0x18A53E100")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA53E200", Offset = "0xA53D600", VA = "0x18A53E200")]
		[IteratorStateMachine(typeof(<EvaluateTriangles>d__79))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3F38CC0", Offset = "0x3F380C0", VA = "0x183F38CC0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> EvaluateTriangles<TvG, TvM, TvS>(this Mesh mesh, [Optional] IGeometryTransform xform) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA53EC80", Offset = "0xA53E080", VA = "0x18A53EC80")]
		public static VertexBufferColumns GetVertexColumns(this MeshPrimitive primitive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA5464D0", Offset = "0xA5458D0", VA = "0x18A5464D0")]
		private static void _Initialize(IReadOnlyDictionary<string, Accessor> vertexAccessors, VertexBufferColumns dstColumns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F339B0", Offset = "0x3F32DB0", VA = "0x183F339B0")]
		public static void AddMesh<TMaterial, TvG, TvM, TvS>(this MeshBuilder<TMaterial, TvG, TvM, TvS> meshBuilder, Mesh srcMesh, Converter<Material, TMaterial> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3F39D90", Offset = "0x3F39190", VA = "0x183F39D90")]
		public static MeshBuilder<TMaterial, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TMaterial, TvG, TvM>(this Scene srcScene, Converter<Material, TMaterial> materialFunc, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A3E0", Offset = "0x3F397E0", VA = "0x183F3A3E0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TvG, TvM>(this Scene srcScene, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA53F080", Offset = "0xA53E480", VA = "0x18A53F080")]
		public static IMeshBuilder<MaterialBuilder> ToMeshBuilder(this Mesh srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F39AD0", Offset = "0x3F38ED0", VA = "0x183F39AD0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS>(this IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F393C0", Offset = "0x3F387C0", VA = "0x183F393C0")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS, TMaterial>(this IEnumerable<(VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, TMaterial Material)> triangles, Converter<TMaterial, MaterialBuilder> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA539E10", Offset = "0xA539210", VA = "0x18A539E10")]
		private static void AddPrimitiveGeometry(this IPrimitiveBuilder dstPrim, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA53EEF0", Offset = "0xA53E2F0", VA = "0x18A53EEF0")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA53EDC0", Offset = "0xA53E1C0", VA = "0x18A53EDC0")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA542160", Offset = "0xA541560", VA = "0x18A542160")]
		public static Node WithLocalTransform(this Node node, AffineTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA542240", Offset = "0xA541640", VA = "0x18A542240")]
		public static Node WithLocalTranslation(this Node node, Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA541E50", Offset = "0xA541250", VA = "0x18A541E50")]
		public static Node WithLocalRotation(this Node node, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA541FD0", Offset = "0xA5413D0", VA = "0x18A541FD0")]
		public static Node WithLocalScale(this Node node, Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA542490", Offset = "0xA541890", VA = "0x18A542490")]
		public static Node WithMesh(this Node node, Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA544460", Offset = "0xA543860", VA = "0x18A544460")]
		public static Node WithSkin(this Node node, Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA544270", Offset = "0xA543670", VA = "0x18A544270")]
		public static Node WithSkinBinding(this Node node, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA543F70", Offset = "0xA543370", VA = "0x18A543F70")]
		public static Node WithSkinBinding(this Node node, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA544520", Offset = "0xA543920", VA = "0x18A544520")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA544870", Offset = "0xA543C70", VA = "0x18A544870")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA543110", Offset = "0xA542510", VA = "0x18A543110")]
		public static Node WithPerspectiveCamera(this Node node, float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA542B30", Offset = "0xA541F30", VA = "0x18A542B30")]
		public static Node WithOrthographicCamera(this Node node, float xmag, float ymag, float znear, float zfar)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA53E520", Offset = "0xA53D920", VA = "0x18A53E520")]
		public static Node FindNode(this Scene scene, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA53E290", Offset = "0xA53D690", VA = "0x18A53E290")]
		public static Node FindNode(this Node node, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA53DE90", Offset = "0xA53D290", VA = "0x18A53DE90")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3F38D10", Offset = "0x3F38110", VA = "0x183F38D10")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, VertexEmpty>> EvaluateTriangles<TvG, TvM>(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA5351C0", Offset = "0xA5345C0", VA = "0x18A5351C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6626C80", Offset = "0x6626080", VA = "0x186626C80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x72234A0", Offset = "0x72228A0", VA = "0x1872234A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6C76590", Offset = "0x6C75990", VA = "0x186C76590")]
			[DebuggerHidden]
			public <_EvaluateTriangles>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x72236F0", Offset = "0x7222AF0", VA = "0x1872236F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7221F90", Offset = "0x7221390", VA = "0x187221F90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7223940", Offset = "0x7222D40", VA = "0x187223940")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7222E70", Offset = "0x7222270", VA = "0x187222E70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>> IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x72232A0", Offset = "0x72226A0", VA = "0x1872232A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6262420", Offset = "0x6261820", VA = "0x186262420")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> GetTrianglesFromMesh(Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6263AE0", Offset = "0x6262EE0", VA = "0x186263AE0")]
		private static List<(Material, VertexBufferColumns, IEnumerable<(int, int, int)>)> _GatherMeshGeometry(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6262DA0", Offset = "0x62621A0", VA = "0x186262DA0")]
		[IteratorStateMachine(typeof(EvaluatedTriangle<, , >.<_EvaluateTriangles>d__2))]
		private static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> _EvaluateTriangles(Material material, VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x62653B0", Offset = "0x62647B0", VA = "0x1862653B0")]
		public static implicit operator EvaluatedTriangle<TvG, TvM, TvS>((VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, Material Material) tri)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x62652D0", Offset = "0x62646D0", VA = "0x1862652D0")]
		public EvaluatedTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, Material m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x62628E0", Offset = "0x6261CE0", VA = "0x1862628E0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> TransformTextureCoordsByMaterial(IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles, [Optional] Animation track, float time = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6264720", Offset = "0x6263B20", VA = "0x186264720")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C0310", Offset = "0x10BF710", VA = "0x1810C0310")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x13456C0", Offset = "0x1344AC0", VA = "0x1813456C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float YMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xE7B220", Offset = "0xE7A620", VA = "0x180E7B220")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xF151C0", Offset = "0xF145C0", VA = "0x180F151C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA531E70", Offset = "0xA531270", VA = "0x18A531E70")]
			public Orthographic(float xmag, float ymag, float znear, float zfar)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA531ED0", Offset = "0xA5312D0", VA = "0x18A531ED0")]
			internal Orthographic(CameraOrthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA531D10", Offset = "0xA531110", VA = "0x18A531D10", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA531F60", Offset = "0xA531360", VA = "0x18A531F60")]
			private Orthographic(Orthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA531E10", Offset = "0xA531210", VA = "0x18A531E10", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4DC0", Offset = "0xCF41C0", VA = "0x180CF4DC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public float VerticalFOV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xE7B210", Offset = "0xE7A610", VA = "0x180E7B210")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x10B2140", Offset = "0x10B1540", VA = "0x1810B2140")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA5321F0", Offset = "0xA5315F0", VA = "0x18A5321F0")]
			public Perspective(float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA532250", Offset = "0xA531650", VA = "0x18A532250")]
			internal Perspective(CameraPerspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA532040", Offset = "0xA531440", VA = "0x18A532040", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5322E0", Offset = "0xA5316E0", VA = "0x18A5322E0")]
			private Perspective(Perspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA532140", Offset = "0xA531540", VA = "0x18A532140", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA480C60", Offset = "0xA480060", VA = "0x18A480C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD4C5C0", Offset = "0xD4B9C0", VA = "0x180D4C5C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10AF270", Offset = "0x10AE670", VA = "0x1810AF270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD470B0", Offset = "0xD464B0", VA = "0x180D470B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD47030", Offset = "0xD46430", VA = "0x180D47030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA52B120", Offset = "0xA52A520", VA = "0x18A52B120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA52B150", Offset = "0xA52A550", VA = "0x18A52B150")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CameraBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA52B0E0", Offset = "0xA52A4E0", VA = "0x18A52B0E0")]
		protected CameraBuilder(float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA52B010", Offset = "0xA52A410", VA = "0x18A52B010")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public EmptyContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA52B810", Offset = "0xA52AC10", VA = "0x18A52B810", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public MeshContent(IMeshBuilder<MaterialBuilder> mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA52D5E0", Offset = "0xA52C9E0", VA = "0x18A52D5E0", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEAD0", Offset = "0x8DBDED0", VA = "0x188DBEAD0")]
		private MeshContent(MeshContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B78D20", Offset = "0x2B78120", VA = "0x182B78D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA52D730", Offset = "0xA52CB30", VA = "0x18A52D730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA52D650", Offset = "0xA52CA50", VA = "0x18A52D650", Slot = "6")]
		public bool Equals(IRenderableContent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA52D840", Offset = "0xA52CC40", VA = "0x18A52D840", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public CameraContent(CameraBuilder camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA52B1A0", Offset = "0xA52A5A0", VA = "0x18A52B1A0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA52B580", Offset = "0xA52A980", VA = "0x18A52B580")]
		private CameraContent(CameraContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA52B230", Offset = "0xA52A630", VA = "0x18A52B230", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public LightContent(LightBuilder light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA52D200", Offset = "0xA52C600", VA = "0x18A52D200", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA52B580", Offset = "0xA52A980", VA = "0x18A52B580")]
		private LightContent(LightContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA52D290", Offset = "0xA52C690", VA = "0x18A52D290", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA52D0B0", Offset = "0xA52C4B0", VA = "0x18A52D0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA52D010", Offset = "0xA52C410", VA = "0x18A52D010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ContentTransformer Content
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA52D030", Offset = "0xA52C430", VA = "0x18A52D030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		internal InstanceBuilder(SceneBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA52CF30", Offset = "0xA52C330", VA = "0x18A52CF30")]
		public InstanceBuilder WithName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA52CF00", Offset = "0xA52C300", VA = "0x18A52CF00")]
		public InstanceBuilder WithExtras(JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA52CE90", Offset = "0xA52C290", VA = "0x18A52CE90")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA52CF60", Offset = "0xA52C360", VA = "0x18A52CF60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA52B6F0", Offset = "0xA52AAF0", VA = "0x18A52B6F0")]
			public Directional()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA52B800", Offset = "0xA52AC00", VA = "0x18A52B800")]
			internal Directional(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA52B5F0", Offset = "0xA52A9F0", VA = "0x18A52B5F0", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA52B730", Offset = "0xA52AB30", VA = "0x18A52B730")]
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
				[Cpp2IlInjected.Address(RVA = "0xE7B210", Offset = "0xE7A610", VA = "0x180E7B210")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x10B2140", Offset = "0x10B1540", VA = "0x1810B2140")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA5325E0", Offset = "0xA5319E0", VA = "0x18A5325E0")]
			public Point()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA5325A0", Offset = "0xA5319A0", VA = "0x18A5325A0")]
			internal Point(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA5323C0", Offset = "0xA5317C0", VA = "0x18A5323C0", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA5324C0", Offset = "0xA5318C0", VA = "0x18A5324C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xE7B210", Offset = "0xE7A610", VA = "0x180E7B210")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x10B2140", Offset = "0x10B1540", VA = "0x1810B2140")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public float InnerConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0xDCD9C0", Offset = "0xDCCDC0", VA = "0x180DCD9C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0xDCD9D0", Offset = "0xDCCDD0", VA = "0x180DCD9D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public float OuterConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0xD87CE0", Offset = "0xD870E0", VA = "0x180D87CE0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x1119510", Offset = "0x1118910", VA = "0x181119510")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA539D60", Offset = "0xA539160", VA = "0x18A539D60")]
			public Spot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA539DB0", Offset = "0xA5391B0", VA = "0x18A539DB0")]
			internal Spot(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA539B60", Offset = "0xA538F60", VA = "0x18A539B60", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA539C70", Offset = "0xA539070", VA = "0x18A539C70")]
			private Spot(Spot other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xA480C60", Offset = "0xA480060", VA = "0x18A480C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xFC8130", Offset = "0xFC7530", VA = "0x180FC8130")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xFC7AD0", Offset = "0xFC6ED0", VA = "0x180FC7AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xE7B220", Offset = "0xE7A620", VA = "0x180E7B220")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xF151C0", Offset = "0xF145C0", VA = "0x180F151C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA52B6F0", Offset = "0xA52AAF0", VA = "0x18A52B6F0")]
		protected LightBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA52D0D0", Offset = "0xA52C4D0", VA = "0x18A52D0D0")]
		protected LightBuilder(PunctualLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LightBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA52B730", Offset = "0xA52AB30", VA = "0x18A52B730")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <Flatten>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA548B60", Offset = "0xA547F60", VA = "0x18A548B60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA548730", Offset = "0xA547B30", VA = "0x18A548730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA548D00", Offset = "0xA548100", VA = "0x18A548D00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA548D50", Offset = "0xA548150", VA = "0x18A548D50")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA548B20", Offset = "0xA547F20", VA = "0x18A548B20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA548A80", Offset = "0xA547E80", VA = "0x18A548A80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NodeBuilder> IEnumerable<NodeBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA548A80", Offset = "0xA547E80", VA = "0x18A548A80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NodeBuilder Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA531200", Offset = "0xA530600", VA = "0x18A531200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<NodeBuilder> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IEnumerable<string> AnimationTracksNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA530670", Offset = "0xA52FA70", VA = "0x18A530670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HasAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA530800", Offset = "0xA52FC00", VA = "0x18A530800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HasTransformAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA530860", Offset = "0xA52FC60", VA = "0x18A530860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AnimatableProperty<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xCF8190", Offset = "0xCF7590", VA = "0x180CF8190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnimatableProperty<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B70", Offset = "0xCF6F70", VA = "0x180CF7B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AnimatableProperty<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xCF81A0", Offset = "0xCF75A0", VA = "0x180CF81A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA530ED0", Offset = "0xA5302D0", VA = "0x18A530ED0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA5316E0", Offset = "0xA530AE0", VA = "0x18A5316E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA530FB0", Offset = "0xA5303B0", VA = "0x18A530FB0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA5317A0", Offset = "0xA530BA0", VA = "0x18A5317A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA5314E0", Offset = "0xA5308E0", VA = "0x18A5314E0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA531C30", Offset = "0xA531030", VA = "0x18A531C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA530970", Offset = "0xA52FD70", VA = "0x18A530970")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA531220", Offset = "0xA530620", VA = "0x18A531220")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public AnimatableProperty<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD23EB0", Offset = "0xD232B0", VA = "0x180D23EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool? IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA530900", Offset = "0xA52FD00", VA = "0x18A530900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA5315F0", Offset = "0xA5309F0", VA = "0x18A5315F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA52FEA0", Offset = "0xA52F2A0", VA = "0x18A52FEA0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA530530", Offset = "0xA52F930", VA = "0x18A530530")]
		public NodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA530490", Offset = "0xA52F890", VA = "0x18A530490")]
		public NodeBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA5305B0", Offset = "0xA52F9B0", VA = "0x18A5305B0")]
		public NodeBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA52DF10", Offset = "0xA52D310", VA = "0x18A52DF10")]
		public Dictionary<NodeBuilder, NodeBuilder> DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA52DBA0", Offset = "0xA52CFA0", VA = "0x18A52DBA0")]
		private NodeBuilder DeepClone(IDictionary<NodeBuilder, NodeBuilder> nodeMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA52DB10", Offset = "0xA52CF10", VA = "0x18A52DB10")]
		public NodeBuilder CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA52D8C0", Offset = "0xA52CCC0", VA = "0x18A52D8C0")]
		public void AddNode(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA52E730", Offset = "0xA52DB30", VA = "0x18A52E730")]
		public static bool IsValidArmature(IEnumerable<NodeBuilder> joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA52DF80", Offset = "0xA52D380", VA = "0x18A52DF80")]
		[IteratorStateMachine(typeof(<Flatten>d__52))]
		public static IEnumerable<NodeBuilder> Flatten(NodeBuilder container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA5302E0", Offset = "0xA52F6E0", VA = "0x18A5302E0")]
		private void _UseDecomposedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA52F240", Offset = "0xA52E640", VA = "0x18A52F240")]
		public AnimatableProperty<Vector3> UseScale()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA52F300", Offset = "0xA52E700", VA = "0x18A52F300")]
		public CurveBuilder<Vector3> UseScale(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA52F170", Offset = "0xA52E570", VA = "0x18A52F170")]
		public AnimatableProperty<Quaternion> UseRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA52F110", Offset = "0xA52E510", VA = "0x18A52F110")]
		public CurveBuilder<Quaternion> UseRotation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA52F360", Offset = "0xA52E760", VA = "0x18A52F360")]
		public AnimatableProperty<Vector3> UseTranslation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA52F430", Offset = "0xA52E830", VA = "0x18A52F430")]
		public CurveBuilder<Vector3> UseTranslation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA52F030", Offset = "0xA52E430", VA = "0x18A52F030")]
		public void SetScaleTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA52F0A0", Offset = "0xA52E4A0", VA = "0x18A52F0A0")]
		public void SetTranslationTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA52EFC0", Offset = "0xA52E3C0", VA = "0x18A52EFC0")]
		public void SetRotationTrack(string track, ICurveSampler<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA52E300", Offset = "0xA52D700", VA = "0x18A52E300")]
		public AffineTransform GetLocalTransform(string animationTrack, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA52E550", Offset = "0xA52D950", VA = "0x18A52E550")]
		public Matrix4x4 GetWorldMatrix(string animationTrack, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA52E000", Offset = "0xA52D400", VA = "0x18A52E000")]
		public Matrix4x4 GetInverseBindMatrix([Optional] Matrix4x4? meshWorldMatrix)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA52EBE0", Offset = "0xA52DFE0", VA = "0x18A52EBE0")]
		public void SetLocalTransform(AffineTransform newLocalTransform, bool keepChildrenInPlace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA52F490", Offset = "0xA52E890", VA = "0x18A52F490")]
		public AnimatableProperty<bool> UseVisibility()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA52FE40", Offset = "0xA52F240", VA = "0x18A52FE40")]
		public NodeBuilder WithLocalTranslation(Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA52F860", Offset = "0xA52EC60", VA = "0x18A52F860")]
		public NodeBuilder WithLocalScale(Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA52F800", Offset = "0xA52EC00", VA = "0x18A52F800")]
		public NodeBuilder WithLocalRotation(Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA52FB80", Offset = "0xA52EF80", VA = "0x18A52FB80")]
		public NodeBuilder WithLocalTranslation(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA52F540", Offset = "0xA52E940", VA = "0x18A52F540")]
		public NodeBuilder WithLocalRotation(string animTrack, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA52F8C0", Offset = "0xA52ECC0", VA = "0x18A52F8C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <CreateFrom>d__31(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA55F590", Offset = "0xA55E990", VA = "0x18A55F590", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA55F0F0", Offset = "0xA55E4F0", VA = "0x18A55F0F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA55F670", Offset = "0xA55EA70", VA = "0x18A55F670")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA55F550", Offset = "0xA55E950", VA = "0x18A55F550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA55F4B0", Offset = "0xA55E8B0", VA = "0x18A55F4B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SceneBuilder> IEnumerable<SceneBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA55F4B0", Offset = "0xA55E8B0", VA = "0x18A55F4B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA5399D0", Offset = "0xA538DD0", VA = "0x18A5399D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal IEnumerable<string> AnimationTrackNames
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA5398B0", Offset = "0xA538CB0", VA = "0x18A5398B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA539810", Offset = "0xA538C10", VA = "0x18A539810")]
		public SceneBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA535230", Offset = "0xA534630", VA = "0x18A535230")]
		public SceneBuilder DeepClone(bool cloneArmatures = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA535B40", Offset = "0xA534F40", VA = "0x18A535B40")]
		[Obsolete("Use LoadDefaultScene(...); or LoadAllScenes(...) instead.", true)]
		public static SceneBuilder Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA535B40", Offset = "0xA534F40", VA = "0x18A535B40")]
		public static SceneBuilder LoadDefaultScene(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA535A70", Offset = "0xA534E70", VA = "0x18A535A70")]
		public static SceneBuilder[] LoadAllScenes(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA533550", Offset = "0xA532950", VA = "0x18A533550")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA533A30", Offset = "0xA532E30", VA = "0x18A533A30")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA533770", Offset = "0xA532B70", VA = "0x18A533770")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node, AffineTransform instanceTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA533DB0", Offset = "0xA5331B0", VA = "0x18A533DB0")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, Matrix4x4 meshWorldMatrix, params NodeBuilder[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA534120", Offset = "0xA533520", VA = "0x18A534120")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, params (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA532620", Offset = "0xA531A20", VA = "0x18A532620")]
		public InstanceBuilder AddCamera(CameraBuilder camera, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA532A90", Offset = "0xA531E90", VA = "0x18A532A90")]
		public InstanceBuilder AddCamera(CameraBuilder camera, Vector3 cameraPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA532870", Offset = "0xA531C70", VA = "0x18A532870")]
		public InstanceBuilder AddCamera(CameraBuilder camera, AffineTransform cameraTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA532F00", Offset = "0xA532300", VA = "0x18A532F00")]
		public InstanceBuilder AddLight(LightBuilder light, AffineTransform lightTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA533120", Offset = "0xA532520", VA = "0x18A533120")]
		public InstanceBuilder AddLight(LightBuilder light, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA533370", Offset = "0xA532770", VA = "0x18A533370")]
		public InstanceBuilder AddNode(NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA535860", Offset = "0xA534C60", VA = "0x18A535860")]
		public IReadOnlyList<NodeBuilder> FindArmatures()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA5344C0", Offset = "0xA5338C0", VA = "0x18A5344C0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA533C10", Offset = "0xA533010", VA = "0x18A533C10")]
		public IReadOnlyList<InstanceBuilder> AddScene(SceneBuilder scene, Matrix4x4 sceneTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA536140", Offset = "0xA535540", VA = "0x18A536140", Slot = "8")]
		public ModelRoot ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA535BE0", Offset = "0xA534FE0", VA = "0x18A535BE0")]
		public ModelRoot ToGltf2(SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA535CB0", Offset = "0xA5350B0", VA = "0x18A535CB0")]
		public static ModelRoot ToGltf2(IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA5350F0", Offset = "0xA5344F0", VA = "0x18A5350F0")]
		public static SceneBuilder[] CreateFrom(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA5351C0", Offset = "0xA5345C0", VA = "0x18A5351C0")]
		public static SceneBuilder CreateFrom(Scene srcScene)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA535070", Offset = "0xA534470", VA = "0x18A535070")]
		[IteratorStateMachine(typeof(<CreateFrom>d__31))]
		public static IEnumerable<SceneBuilder> CreateFrom(IEnumerable<Scene> srcScenes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA537F80", Offset = "0xA537380", VA = "0x18A537F80")]
		private static SceneBuilder _CreateFrom(Scene srcScene, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshInstances)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA5386A0", Offset = "0xA537AA0", VA = "0x18A5386A0")]
		private static Dictionary<Node, IMeshBuilder<MaterialBuilder>> _GatherMeshInstances(IEnumerable<Node> srcNodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA536CD0", Offset = "0xA5360D0", VA = "0x18A536CD0")]
		private static void _AddMeshInstances(SceneBuilder dstScene, IEnumerable<Node> srcNodes, IReadOnlyDictionary<Node, NodeBuilder> nodesDict, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshesDict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA536260", Offset = "0xA535660", VA = "0x18A536260")]
		private static void _AddCameraInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA5368D0", Offset = "0xA535CD0", VA = "0x18A5368D0")]
		private static void _AddLightInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA536640", Offset = "0xA535A40", VA = "0x18A536640")]
		private static void _AddEmptyInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA5377E0", Offset = "0xA536BE0", VA = "0x18A5377E0")]
		private static void _CopyToNodeBuilder(NodeBuilder dstNode, Node srcNode, IDictionary<Node, NodeBuilder> nodeMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA537C20", Offset = "0xA537020", VA = "0x18A537C20")]
		private static void _CopyTransformAnimation(NodeBuilder dstNode, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA537340", Offset = "0xA536740", VA = "0x18A537340")]
		private static void _CopyMorphingAnimation(InstanceBuilder dstInst, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA2D0", Offset = "0x3ED96D0", VA = "0x183EDA2D0")]
		internal static void _VerifyCurveConversion<T>(IAnimationSampler<T> a, IConvertibleCurve<T> b, Func<T, T, bool> equalityComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA538B90", Offset = "0xA537F90", VA = "0x18A538B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA557AA0", Offset = "0xA556EA0", VA = "0x18A557AA0")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SceneBuilderSchema2Settings WithGpuInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA557AC0", Offset = "0xA556EC0", VA = "0x18A557AC0")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UseStridedBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x10C36C0", Offset = "0x10C2AC0", VA = "0x1810C36C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2727620", Offset = "0x2726A20", VA = "0x182727620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CompactVertexWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x11196E0", Offset = "0x1118AE0", VA = "0x1811196E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1119710", Offset = "0x1118B10", VA = "0x181119710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x30BC770", Offset = "0x30BBB70", VA = "0x1830BC770")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x30BC780", Offset = "0x30BBB80", VA = "0x1830BC780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xED9430", Offset = "0xED8830", VA = "0x180ED9430")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xED9450", Offset = "0xED8850", VA = "0x180ED9450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCFB3B0", Offset = "0xCFA7B0", VA = "0x180CFB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA55A480", Offset = "0xA559880", VA = "0x18A55A480")]
		public Mesh GetMesh(IMeshBuilder<MaterialBuilder> key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA55A510", Offset = "0xA559910", VA = "0x18A55A510")]
		public Node GetNode(NodeBuilder key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA55A5A0", Offset = "0xA5599A0", VA = "0x18A55A5A0")]
		public static bool HasContent(Node node, bool checkTransform = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA557F80", Offset = "0xA557380", VA = "0x18A557F80")]
		public void AddGeometryResources(ModelRoot root, IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA557AE0", Offset = "0xA556EE0", VA = "0x18A557AE0")]
		private void AddArmatureResources(IEnumerable<SceneBuilder> srcScenes, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA559800", Offset = "0xA558C00", VA = "0x18A559800")]
		private void CreateArmature(NodeBuilder srcNode, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA55A790", Offset = "0xA559B90", VA = "0x18A55A790")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<SparseWeight8> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA55AAF0", Offset = "0xA559EF0", VA = "0x18A55AAF0")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<ArraySegment<float>> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA559660", Offset = "0xA558A60", VA = "0x18A559660")]
		public void AddScene(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA559040", Offset = "0xA558440", VA = "0x18A559040")]
		private void AddMeshes(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA558A60", Offset = "0xA557E60", VA = "0x18A558A60")]
		private void AddLightsAndCameras(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF60", Offset = "0xA55A360", VA = "0x18A55AF60")]
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
			[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AffineTransform? Child
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x68702D0", Offset = "0x686F6D0", VA = "0x1868702D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA55DED0", Offset = "0xA55D2D0", VA = "0x18A55DED0")]
		public static implicit operator TransformChainBuilder(NodeBuilder node)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA55DF20", Offset = "0xA55D320", VA = "0x18A55DF20")]
		public static implicit operator TransformChainBuilder(AffineTransform transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA55DF80", Offset = "0xA55D380", VA = "0x18A55DF80")]
		public static implicit operator TransformChainBuilder(Matrix4x4 transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA55DD10", Offset = "0xA55D110", VA = "0x18A55DD10")]
		public TransformChainBuilder(AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA55DCE0", Offset = "0xA55D0E0", VA = "0x18A55DCE0")]
		public TransformChainBuilder(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA55DDF0", Offset = "0xA55D1F0", VA = "0x18A55DDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			internal DeepCloneContext(IReadOnlyDictionary<NodeBuilder, NodeBuilder> nmap)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA5503C0", Offset = "0xA54F7C0", VA = "0x18A5503C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA550340", Offset = "0xA54F740", VA = "0x18A550340")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AnimatableProperty<ArraySegment<float>> Morphings
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HasRenderableContent
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA5502F0", Offset = "0xA54F6F0", VA = "0x18A5502F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA5501E0", Offset = "0xA54F5E0", VA = "0x18A5501E0")]
		protected ContentTransformer(object content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ContentTransformer DeepClone(DeepCloneContext args);

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA5500A0", Offset = "0xA54F4A0", VA = "0x18A5500A0")]
		protected ContentTransformer(ContentTransformer other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA54FC80", Offset = "0xA54F080", VA = "0x18A54FC80")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA54FC00", Offset = "0xA54F000", VA = "0x18A54FC00")]
		public CameraBuilder GetCameraAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA54FCE0", Offset = "0xA54F0E0", VA = "0x18A54FCE0")]
		public LightBuilder GetLightAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract NodeBuilder GetArmatureRoot();

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA54FF70", Offset = "0xA54F370", VA = "0x18A54FF70")]
		public AnimatableProperty<ArraySegment<float>> UseMorphing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA54FD60", Offset = "0xA54F160", VA = "0x18A54FD60")]
		public CurveBuilder<ArraySegment<float>> UseMorphing(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract Matrix4x4 GetPoseWorldMatrix();

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA54FA30", Offset = "0xA54EE30", VA = "0x18A54FA30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NodeBuilder ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AffineTransform ChildTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x93540A0", Offset = "0x93534A0", VA = "0x1893540A0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x9354110", Offset = "0x9353510", VA = "0x189354110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA5509D0", Offset = "0xA54FDD0", VA = "0x18A5509D0")]
		internal FixedTransformer(object content, AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA550830", Offset = "0xA54FC30", VA = "0x18A550830")]
		internal FixedTransformer(object content, NodeBuilder parentNode, AffineTransform childTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA550890", Offset = "0xA54FC90", VA = "0x18A550890")]
		protected FixedTransformer(FixedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA5504C0", Offset = "0xA54F8C0", VA = "0x18A5504C0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA550630", Offset = "0xA54FA30", VA = "0x18A550630", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA550650", Offset = "0xA54FA50", VA = "0x18A550650", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x735A930", Offset = "0x7359D30", VA = "0x18735A930", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9709DF0", Offset = "0x97091F0", VA = "0x189709DF0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x18B8EB0", Offset = "0x18B82B0", VA = "0x1818B8EB0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x9709D20", Offset = "0x9709120", VA = "0x189709D20", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NodeBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA557980", Offset = "0xA556D80", VA = "0x18A557980")]
		internal RigidTransformer(object content, NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA5579C0", Offset = "0xA556DC0", VA = "0x18A5579C0")]
		protected RigidTransformer(RigidTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA5576C0", Offset = "0xA556AC0", VA = "0x18A5576C0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA5577E0", Offset = "0xA556BE0", VA = "0x18A5577E0", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA557800", Offset = "0xA556C00", VA = "0x18A557800", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA557850", Offset = "0xA556C50", VA = "0x18A557850", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA55C7A0", Offset = "0xA55BBA0", VA = "0x18A55C7A0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA55C880", Offset = "0xA55BC80", VA = "0x18A55C880")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA55C330", Offset = "0xA55B730", VA = "0x18A55C330")]
		protected SkinnedTransformer(SkinnedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA55B070", Offset = "0xA55A470", VA = "0x18A55B070", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA55B8C0", Offset = "0xA55ACC0", VA = "0x18A55B8C0")]
		private void SetJoints(AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA55BB80", Offset = "0xA55AF80", VA = "0x18A55BB80")]
		private void SetJoints((NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA55B220", Offset = "0xA55A620", VA = "0x18A55B220")]
		public (NodeBuilder, Matrix4x4)[] GetJointBindings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA55B0E0", Offset = "0xA55A4E0", VA = "0x18A55B0E0", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA55B720", Offset = "0xA55AB20", VA = "0x18A55B720")]
		public IGeometryTransform GetWorldTransformer(string animationTrack, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA55B5C0", Offset = "0xA55A9C0", VA = "0x18A55B5C0", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA55BF70", Offset = "0xA55B370", VA = "0x18A55BF70", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <CreateFrom>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA55ED70", Offset = "0xA55E170", VA = "0x18A55ED70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA55E060", Offset = "0xA55D460", VA = "0x18A55E060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA55F000", Offset = "0xA55E400", VA = "0x18A55F000")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA55F050", Offset = "0xA55E450", VA = "0x18A55F050")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA55F0A0", Offset = "0xA55E4A0", VA = "0x18A55F0A0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA55ED30", Offset = "0xA55E130", VA = "0x18A55ED30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA55EC80", Offset = "0xA55E080", VA = "0x18A55EC80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Schema2SceneBuilder.IOperator<Scene>> IEnumerable<Schema2SceneBuilder.IOperator<Scene>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA55EC80", Offset = "0xA55E080", VA = "0x18A55EC80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56B580", Offset = "0xA56A980", VA = "0x18A56B580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA56ACA0", Offset = "0xA56A0A0", VA = "0x18A56ACA0")]
		[IteratorStateMachine(typeof(<CreateFrom>d__2))]
		public static IEnumerable<Schema2SceneBuilder.IOperator<Scene>> CreateFrom(IEnumerable<FixedTransformer> instances, int gpuMinCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA56B470", Offset = "0xA56A870", VA = "0x18A56B470")]
		private _MeshInstancing(NodeBuilder parentNode, IEnumerable<FixedTransformer> children, int gpuMinCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA56AA10", Offset = "0xA569E10", VA = "0x18A56AA10", Slot = "4")]
		public void ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD20", Offset = "0xA56A120", VA = "0x18A56AD20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56A9B0", Offset = "0xA569DB0", VA = "0x18A56A9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public _FixedIntance(FixedTransformer fixedXformer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA56A800", Offset = "0xA569C00", VA = "0x18A56A800", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56A630", Offset = "0xA569A30", VA = "0x18A56A630", Slot = "4")]
			public bool Equals(ChannelBuilder x, ChannelBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA55FC00", Offset = "0xA55F000", VA = "0x18A55FC00", Slot = "5")]
			public int GetHashCode(ChannelBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KnownChannel Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54DF30", Offset = "0xA54D330", VA = "0x18A54DF30")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA54DF70", Offset = "0xA54D370", VA = "0x18A54DF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MaterialValue.Collection Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54DEE0", Offset = "0xA54D2E0", VA = "0x18A54DEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA54DC10", Offset = "0xA54D010", VA = "0x18A54DC10")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA54DCF0", Offset = "0xA54D0F0", VA = "0x18A54DCF0")]
		internal ChannelBuilder(MaterialBuilder parent, KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA54D930", Offset = "0xA54CD30", VA = "0x18A54D930")]
		public static bool AreEqualByContent(ChannelBuilder x, ChannelBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA54DAA0", Offset = "0xA54CEA0", VA = "0x18A54DAA0")]
		public static int GetContentHashCode(ChannelBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA54DB20", Offset = "0xA54CF20", VA = "0x18A54DB20")]
		public TextureBuilder GetValidTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA54DB40", Offset = "0xA54CF40", VA = "0x18A54DB40")]
		public TextureBuilder UseTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xD21710", Offset = "0xD20B10", VA = "0x180D21710")]
		public void RemoveTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA54DA20", Offset = "0xA54CE20", VA = "0x18A54DA20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE4720", Offset = "0xEE3B20", VA = "0x180EE4720")]
			[CompilerGenerated]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x793C430", Offset = "0x793B830", VA = "0x18793C430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA550ED0", Offset = "0xA5502D0", VA = "0x18A550ED0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA551010", Offset = "0xA550410", VA = "0x18A551010")]
		public static implicit operator ImageBuilder(ArraySegment<byte> image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA5511C0", Offset = "0xA5505C0", VA = "0x18A5511C0")]
		public static implicit operator ImageBuilder(byte[] image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA5510F0", Offset = "0xA5504F0", VA = "0x18A5510F0")]
		public static implicit operator ImageBuilder(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA551290", Offset = "0xA550690", VA = "0x18A551290")]
		public static implicit operator ImageBuilder(MemoryImage content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA550BD0", Offset = "0xA54FFD0", VA = "0x18A550BD0")]
		public static ImageBuilder From(MemoryImage content, [Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA550C90", Offset = "0xA550090", VA = "0x18A550C90")]
		public static ImageBuilder From(MemoryImage content, string name, JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA550F90", Offset = "0xA550390", VA = "0x18A550F90")]
		private ImageBuilder(MemoryImage content, string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA550B50", Offset = "0xA54FF50", VA = "0x18A550B50")]
		internal ImageBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA550FD0", Offset = "0xA5503D0", VA = "0x18A550FD0")]
		private ImageBuilder(ImageBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA550A10", Offset = "0xA54FE10", VA = "0x18A550A10")]
		public static bool AreEqualByContent(ImageBuilder x, ImageBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA550D60", Offset = "0xA550160", VA = "0x18A550D60")]
		public static int GetContentHashCode(ImageBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA550DF0", Offset = "0xA5501F0", VA = "0x18A550DF0")]
		public static bool IsEmpty(ImageBuilder ib)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA550E60", Offset = "0xA550260", VA = "0x18A550E60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56A5B0", Offset = "0xA5699B0", VA = "0x18A56A5B0", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA56A650", Offset = "0xA569A50", VA = "0x18A56A650", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1731BC0", Offset = "0x1730FC0", VA = "0x181731BC0", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x78B6ED0", Offset = "0x78B62D0", VA = "0x1878B6ED0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24210", Offset = "0xD23610", VA = "0x180D24210")]
			[CompilerGenerated]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xE09150", Offset = "0xE08550", VA = "0x180E09150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD24200", Offset = "0xD23600", VA = "0x180D24200")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xD23F40", Offset = "0xD23340", VA = "0x180D23F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xF6BC90", Offset = "0xF6B090", VA = "0x180F6BC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xF6B830", Offset = "0xF6AC30", VA = "0x180F6B830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ShaderStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA555430", Offset = "0xA554830", VA = "0x18A555430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD46060", Offset = "0xD45460", VA = "0x180D46060")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x14F7140", Offset = "0x14F6540", VA = "0x1814F7140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x122F1D0", Offset = "0x122E5D0", VA = "0x18122F1D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD530", Offset = "0x2AAC930", VA = "0x182AAD530")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MaterialBuilder CompatibilityFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA555390", Offset = "0xA554790", VA = "0x18A555390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public static IEqualityComparer<MaterialBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5552F0", Offset = "0xA5546F0", VA = "0x18A5552F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static IEqualityComparer<MaterialBuilder> ReferenceComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA555340", Offset = "0xA554740", VA = "0x18A555340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA554900", Offset = "0xA553D00", VA = "0x18A554900")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA5517A0", Offset = "0xA550BA0", VA = "0x18A5517A0")]
		public static MaterialBuilder CreateDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA555230", Offset = "0xA554630", VA = "0x18A555230")]
		public MaterialBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA551E00", Offset = "0xA551200", VA = "0x18A551E00", Slot = "8")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA551740", Offset = "0xA550B40", VA = "0x18A551740")]
		public MaterialBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA554EE0", Offset = "0xA5542E0", VA = "0x18A554EE0")]
		public MaterialBuilder(MaterialBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xCFADA0", Offset = "0xCFA1A0", VA = "0x180CFADA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCFBF10", Offset = "0xCFB310", VA = "0x180CFBF10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA551340", Offset = "0xA550740", VA = "0x18A551340")]
		public static bool AreEqualByContent(MaterialBuilder x, MaterialBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA551AA0", Offset = "0xA550EA0", VA = "0x18A551AA0")]
		public static int GetContentHashCode(MaterialBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA554BB0", Offset = "0xA553FB0", VA = "0x18A554BB0")]
		private void _SetShader(string shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA551970", Offset = "0xA550D70", VA = "0x18A551970")]
		[Obsolete("Use GetChannel with KnownChannel whenever possible")]
		public ChannelBuilder GetChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA551FE0", Offset = "0xA5513E0", VA = "0x18A551FE0")]
		[Obsolete("Use UseChannel with KnownChannel whenever possible")]
		public ChannelBuilder UseChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5518A0", Offset = "0xA550CA0", VA = "0x18A5518A0")]
		public ChannelBuilder GetChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA551E60", Offset = "0xA551260", VA = "0x18A551E60")]
		public ChannelBuilder UseChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA551D00", Offset = "0xA551100", VA = "0x18A551D00")]
		public void RemoveChannel(KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA552110", Offset = "0xA551510", VA = "0x18A552110")]
		internal void ValidateForSchema2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5540D0", Offset = "0xA5534D0", VA = "0x18A5540D0")]
		public MaterialBuilder WithShader(string shader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5546B0", Offset = "0xA553AB0", VA = "0x18A5546B0")]
		public MaterialBuilder WithUnlitShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA553C50", Offset = "0xA553050", VA = "0x18A553C50")]
		public MaterialBuilder WithMetallicRoughnessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA554280", Offset = "0xA553680", VA = "0x18A554280")]
		[Obsolete("SpecularGlossiness has been deprecated by Khronos")]
		public MaterialBuilder WithSpecularGlossinessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA552770", Offset = "0xA551B70", VA = "0x18A552770")]
		public MaterialBuilder WithAlpha(AlphaMode alphaMode = AlphaMode.OPAQUE, float alphaCutoff = 0.5f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8F89570", Offset = "0x8F88970", VA = "0x188F89570")]
		public MaterialBuilder WithDoubleSide(bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA552CD0", Offset = "0xA5520D0", VA = "0x18A552CD0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA552BF0", Offset = "0xA551FF0", VA = "0x18A552BF0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(string channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA552AB0", Offset = "0xA551EB0", VA = "0x18A552AB0")]
		[Obsolete("Use WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)")]
		public MaterialBuilder WithChannelImage(string channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA552C40", Offset = "0xA552040", VA = "0x18A552C40")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, object parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA552B00", Offset = "0xA551F00", VA = "0x18A552B00")]
		public MaterialBuilder WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA553570", Offset = "0xA552970", VA = "0x18A553570")]
		public MaterialBuilder WithFallback(MaterialBuilder fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5538C0", Offset = "0xA552CC0", VA = "0x18A5538C0")]
		public MaterialBuilder WithMetallicRoughnessFallback(ImageBuilder baseColor, Vector4? rgba, ImageBuilder metallicRoughness, float? metallic, float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA553F50", Offset = "0xA553350", VA = "0x18A553F50")]
		public MaterialBuilder WithNormal(ImageBuilder imageFile, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA554010", Offset = "0xA553410", VA = "0x18A554010")]
		public MaterialBuilder WithOcclusion(ImageBuilder imageFile, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA553400", Offset = "0xA552800", VA = "0x18A553400")]
		public MaterialBuilder WithEmissive(Vector3 rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA553240", Offset = "0xA552640", VA = "0x18A553240")]
		public MaterialBuilder WithEmissive(ImageBuilder imageFile, [Optional] Vector3? rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5528D0", Offset = "0xA551CD0", VA = "0x18A5528D0")]
		public MaterialBuilder WithBaseColor(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA552990", Offset = "0xA551D90", VA = "0x18A552990")]
		public MaterialBuilder WithBaseColor(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA553DF0", Offset = "0xA5531F0", VA = "0x18A553DF0")]
		public MaterialBuilder WithMetallicRoughness([Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA553C90", Offset = "0xA553090", VA = "0x18A553C90")]
		public MaterialBuilder WithMetallicRoughness(ImageBuilder imageFile, [Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA552D20", Offset = "0xA552120", VA = "0x18A552D20")]
		public MaterialBuilder WithClearCoatNormal(ImageBuilder imageFile)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA552E10", Offset = "0xA552210", VA = "0x18A552E10")]
		public MaterialBuilder WithClearCoat(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA552D50", Offset = "0xA552150", VA = "0x18A552D50")]
		public MaterialBuilder WithClearCoatRoughness(ImageBuilder imageFile, float roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5545F0", Offset = "0xA5539F0", VA = "0x18A5545F0")]
		public MaterialBuilder WithTransmission(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA552FA0", Offset = "0xA5523A0", VA = "0x18A552FA0")]
		public MaterialBuilder WithDiffuseTransmissionFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA552ED0", Offset = "0xA5522D0", VA = "0x18A552ED0")]
		public MaterialBuilder WithDiffuseTransmissionColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5540F0", Offset = "0xA5534F0", VA = "0x18A5540F0")]
		public MaterialBuilder WithSpecularColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5541C0", Offset = "0xA5535C0", VA = "0x18A5541C0")]
		public MaterialBuilder WithSpecularFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA554840", Offset = "0xA553C40", VA = "0x18A554840")]
		public MaterialBuilder WithVolumeThickness(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5546F0", Offset = "0xA553AF0", VA = "0x18A5546F0")]
		public MaterialBuilder WithVolumeAttenuation(Vector3 color, float distance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA553770", Offset = "0xA552B70", VA = "0x18A553770")]
		public MaterialBuilder WithIridescence(ImageBuilder imageFile, float factor = 0f, float ior = 1.3f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA553620", Offset = "0xA552A20", VA = "0x18A553620")]
		public MaterialBuilder WithIridescenceThickness(ImageBuilder imageFile, float min = 100f, float max = 400f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA552780", Offset = "0xA551B80", VA = "0x18A552780")]
		public MaterialBuilder WithAnisotropy(ImageBuilder imageFile, float strength = 0f, float rotation = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA553060", Offset = "0xA552460", VA = "0x18A553060")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA553120", Offset = "0xA552520", VA = "0x18A553120")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA554460", Offset = "0xA553860", VA = "0x18A554460")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness([Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5542C0", Offset = "0xA5536C0", VA = "0x18A5542C0")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness(ImageBuilder imageFile, [Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA554A60", Offset = "0xA553E60", VA = "0x18A554A60")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56BBE0", Offset = "0xA56AFE0", VA = "0x18A56BBE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public MaterialValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0xFFF110", Offset = "0xFFE510", VA = "0x180FFF110")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0xA56BC80", Offset = "0xA56B080", VA = "0x18A56BC80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA56B970", Offset = "0xA56AD70", VA = "0x18A56B970")]
			internal _Property(KnownProperty key, float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA56BA30", Offset = "0xA56AE30", VA = "0x18A56BA30")]
			internal _Property(KnownProperty key, Vector2 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA56B8A0", Offset = "0xA56ACA0", VA = "0x18A56B8A0")]
			internal _Property(KnownProperty key, Vector3 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA56BB00", Offset = "0xA56AF00", VA = "0x18A56BB00")]
			internal _Property(KnownProperty key, Vector4 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA56B770", Offset = "0xA56AB70", VA = "0x18A56B770", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA56B700", Offset = "0xA56AB00", VA = "0x18A56B700", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA56B5D0", Offset = "0xA56A9D0", VA = "0x18A56B5D0", Slot = "4")]
			public bool Equals(_Property other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA56BC40", Offset = "0xA56B040", VA = "0x18A56BC40")]
			public static bool operator ==(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA56BC60", Offset = "0xA56B060", VA = "0x18A56BC60")]
			public static bool operator !=(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA56B5D0", Offset = "0xA56A9D0", VA = "0x18A56B5D0")]
			public static bool AreEqual(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA56B7B0", Offset = "0xA56ABB0", VA = "0x18A56B7B0")]
			public void SetDefault()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA56B7C0", Offset = "0xA56ABC0", VA = "0x18A56B7C0", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54EE80", Offset = "0xA54E280", VA = "0x18A54EE80", Slot = "6")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0xA54F850", Offset = "0xA54EC50", VA = "0x18A54F850")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public MaterialValue this[string keyName]
			{
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0xA54ED00", Offset = "0xA54E100", VA = "0x18A54ED00")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0xA54F770", Offset = "0xA54EB70", VA = "0x18A54F770")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<KnownProperty> Keys
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0xA54EF70", Offset = "0xA54E370", VA = "0x18A54EF70", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54F080", Offset = "0xA54E480", VA = "0x18A54F080", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x283E4B0", Offset = "0x283D8B0", VA = "0x18283E4B0", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54EB50", Offset = "0xA54DF50", VA = "0x18A54EB50")]
				get
				{
					return default(Vector4);
				}
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0xA54F190", Offset = "0xA54E590", VA = "0x18A54F190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA54EA20", Offset = "0xA54DE20", VA = "0x18A54EA20")]
			private string _GetDebuggerDisplay()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
			internal Collection(_Property[] properties)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA54E700", Offset = "0xA54DB00", VA = "0x18A54E700", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA54DFA0", Offset = "0xA54D3A0", VA = "0x18A54DFA0")]
			public static bool AreEqual(Collection x, Collection y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA54E250", Offset = "0xA54D650", VA = "0x18A54E250", Slot = "4")]
			public bool ContainsKey(KnownProperty key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA54E8F0", Offset = "0xA54DCF0", VA = "0x18A54E8F0", Slot = "5")]
			public bool TryGetValue(KnownProperty key, [Out] MaterialValue value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA54E5D0", Offset = "0xA54D9D0", VA = "0x18A54E5D0", Slot = "10")]
			public IEnumerator<KeyValuePair<KnownProperty, MaterialValue>> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA54E7C0", Offset = "0xA54DBC0", VA = "0x18A54E7C0", Slot = "11")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA54E770", Offset = "0xA54DB70", VA = "0x18A54E770")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA54E320", Offset = "0xA54D720", VA = "0x18A54E320")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <_CreateDefaultProperties>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA561220", Offset = "0xA560620", VA = "0x18A561220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA561CF0", Offset = "0xA5610F0", VA = "0x18A561CF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA561C50", Offset = "0xA561050", VA = "0x18A561C50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<_Property> IEnumerable<_Property>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA561C50", Offset = "0xA561050", VA = "0x18A561C50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA555EA0", Offset = "0xA5552A0", VA = "0x18A555EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5554A0", Offset = "0xA5548A0", VA = "0x18A5554A0")]
		internal static Collection CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA555DA0", Offset = "0xA5551A0", VA = "0x18A555DA0")]
		[IteratorStateMachine(typeof(<_CreateDefaultProperties>d__1))]
		private static IEnumerable<_Property> _CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5562A0", Offset = "0xA5556A0", VA = "0x18A5562A0")]
		public static implicit operator MaterialValue(float value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA556210", Offset = "0xA555610", VA = "0x18A556210")]
		public static implicit operator MaterialValue(Vector2 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA556240", Offset = "0xA555640", VA = "0x18A556240")]
		public static implicit operator MaterialValue(Vector3 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA556270", Offset = "0xA555670", VA = "0x18A556270")]
		public static implicit operator MaterialValue(Vector4 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5555B0", Offset = "0xA5549B0", VA = "0x18A5555B0")]
		public static MaterialValue CreateFrom(object value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA555E80", Offset = "0xA555280", VA = "0x18A555E80")]
		private MaterialValue(float x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA555E60", Offset = "0xA555260", VA = "0x18A555E60")]
		private MaterialValue(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA555E10", Offset = "0xA555210", VA = "0x18A555E10")]
		private MaterialValue(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA555E30", Offset = "0xA555230", VA = "0x18A555E30")]
		private MaterialValue(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA555960", Offset = "0xA554D60", VA = "0x18A555960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA555870", Offset = "0xA554C70", VA = "0x18A555870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA555440", Offset = "0xA554840", VA = "0x18A555440", Slot = "4")]
		public bool Equals(MaterialValue other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA555440", Offset = "0xA554840", VA = "0x18A555440")]
		public static bool operator ==([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5562C0", Offset = "0xA5556C0", VA = "0x18A5562C0")]
		public static bool operator !=([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA555440", Offset = "0xA554840", VA = "0x18A555440")]
		public static bool AreEqual([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA556030", Offset = "0xA555430", VA = "0x18A556030")]
		public static explicit operator float(MaterialValue value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA556190", Offset = "0xA555590", VA = "0x18A556190")]
		public static explicit operator Vector2(MaterialValue value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA556110", Offset = "0xA555510", VA = "0x18A556110")]
		public static explicit operator Vector3(MaterialValue value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA556090", Offset = "0xA555490", VA = "0x18A556090")]
		public static explicit operator Vector4(MaterialValue value)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA555A50", Offset = "0xA554E50", VA = "0x18A555A50")]
		public object ToTypeless()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA555A10", Offset = "0xA554E10", VA = "0x18A555A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA555D30", Offset = "0xA555130", VA = "0x18A555D30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56A610", Offset = "0xA569A10", VA = "0x18A56A610", Slot = "4")]
			public bool Equals(TextureBuilder x, TextureBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA56A6A0", Offset = "0xA569AA0", VA = "0x18A56A6A0", Slot = "5")]
			public int GetHashCode(TextureBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11F80", Offset = "0xD11380", VA = "0x180D11F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD6AF30", Offset = "0xD6A330", VA = "0x180D6AF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD11F90", Offset = "0xD11390", VA = "0x180D11F90")]
			[CompilerGenerated]
			get
			{
				return default(TextureMipMapFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xD6AF40", Offset = "0xD6A340", VA = "0x180D6AF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD6C420", Offset = "0xD6B820", VA = "0x180D6C420")]
			[CompilerGenerated]
			get
			{
				return default(TextureInterpolationFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xD6D6D0", Offset = "0xD6CAD0", VA = "0x180D6D6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x1685040", Offset = "0x1684440", VA = "0x181685040")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1C78E40", Offset = "0x1C78240", VA = "0x181C78E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xECD1E0", Offset = "0xECC5E0", VA = "0x180ECD1E0")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1AA5DF0", Offset = "0x1AA51F0", VA = "0x181AA5DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ImageBuilder PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA55D930", Offset = "0xA55CD30", VA = "0x18A55D930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ImageBuilder FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA55D810", Offset = "0xA55CC10", VA = "0x18A55D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public TextureTransformBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static IEqualityComparer<TextureBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA55D7C0", Offset = "0xA55CBC0", VA = "0x18A55D7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA55D420", Offset = "0xA55C820", VA = "0x18A55D420")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA55D6E0", Offset = "0xA55CAE0", VA = "0x18A55D6E0")]
		internal TextureBuilder(ChannelBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA55C930", Offset = "0xA55BD30", VA = "0x18A55C930")]
		public static bool AreEqualByContent(TextureBuilder x, TextureBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA55CE00", Offset = "0xA55C200", VA = "0x18A55CE00")]
		public static int GetContentHashCode(TextureBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA55CBB0", Offset = "0xA55BFB0", VA = "0x18A55CBB0")]
		internal void CopyTo(TextureBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA55CFB0", Offset = "0xA55C3B0", VA = "0x18A55CFB0")]
		public TextureBuilder WithCoordinateSet(int cset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA55D0E0", Offset = "0xA55C4E0", VA = "0x18A55D0E0")]
		public TextureBuilder WithPrimaryImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA55CFC0", Offset = "0xA55C3C0", VA = "0x18A55CFC0")]
		public TextureBuilder WithFallbackImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA55D1D0", Offset = "0xA55C5D0", VA = "0x18A55D1D0")]
		public TextureBuilder WithSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA55D1F0", Offset = "0xA55C5F0", VA = "0x18A55D1F0")]
		public TextureBuilder WithTransform(float offsetX, float offsetY, float scaleX = 1f, float scaleY = 1f, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA55D330", Offset = "0xA55C730", VA = "0x18A55D330")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A98E0", Offset = "0x32A8CE0", VA = "0x1832A98E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xEBCE20", Offset = "0xEBC220", VA = "0x180EBCE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E8A3A0", Offset = "0x1E897A0", VA = "0x181E8A3A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xDE68A0", Offset = "0xDE5CA0", VA = "0x180DE68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD4C5C0", Offset = "0xD4B9C0", VA = "0x180D4C5C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x10AF270", Offset = "0x10AE670", VA = "0x1810AF270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int? CoordinateSetOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x13F81F0", Offset = "0x13F75F0", VA = "0x1813F81F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x10AFBD0", Offset = "0x10AEFD0", VA = "0x1810AFBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA55DC10", Offset = "0xA55D010", VA = "0x18A55DC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA55DB80", Offset = "0xA55CF80", VA = "0x18A55DB80")]
		internal TextureTransformBuilder(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xA55DA90", Offset = "0xA55CE90", VA = "0x18A55DA90")]
		internal TextureTransformBuilder(TextureTransformBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA55D940", Offset = "0xA55CD40", VA = "0x18A55D940")]
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
			[Cpp2IlInjected.Address(RVA = "0xA556520", Offset = "0xA555920", VA = "0x18A556520", Slot = "2")]
			public override readonly int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA556470", Offset = "0xA555870", VA = "0x18A556470", Slot = "0")]
			public override readonly bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA556320", Offset = "0xA555720", VA = "0x18A556320", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA565780", Offset = "0xA564B80", VA = "0x18A565780")]
		public void AddTriangle(Material material, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> a, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> b, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA565F30", Offset = "0xA565330", VA = "0x18A565F30")]
		public void WriteFiles(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA5658C0", Offset = "0xA564CC0", VA = "0x18A5658C0")]
		public IReadOnlyDictionary<string, ArraySegment<byte>> GetFiles(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA566200", Offset = "0xA565600", VA = "0x18A566200")]
		private Dictionary<string, Action<Stream>> _GetFileGenerators(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA5665C0", Offset = "0xA5659C0", VA = "0x18A5665C0")]
		private static Dictionary<Material, string> _GetMaterialsFileGenerator(IDictionary<string, Action<Stream>> fileGenerators, string baseName, IEnumerable<Material> materials)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA5685C0", Offset = "0xA5679C0", VA = "0x18A5685C0")]
		private static void _WriteMaterialsFile(Stream fs, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA568710", Offset = "0xA567B10", VA = "0x18A568710")]
		private static void _WriteMaterialsFile(StreamWriter sw, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA566FC0", Offset = "0xA5663C0", VA = "0x18A566FC0")]
		private void _WriteGeometryFile(Stream s, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA5670F0", Offset = "0xA5664F0", VA = "0x18A5670F0")]
		private void _WriteGeometryFile(StreamWriter sw, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA565110", Offset = "0xA564510", VA = "0x18A565110")]
		public void AddModel(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA565420", Offset = "0xA564820", VA = "0x18A565420")]
		public void AddModel(ModelRoot model, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA565CF0", Offset = "0xA5650F0", VA = "0x18A565CF0")]
		private static Material GetMaterialFromTriangle(SharpGLTF.Schema2.Material srcMaterial)
		{
			return default(Material);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA5691C0", Offset = "0xA5685C0", VA = "0x18A5691C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56A000", Offset = "0xA569400", VA = "0x18A56A000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA569270", Offset = "0xA568670", VA = "0x18A569270")]
		public static ModelRoot LoadModelFromZip(string zipPath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA569F90", Offset = "0xA569390", VA = "0x18A569F90")]
		public ZipReader(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA569EC0", Offset = "0xA5692C0", VA = "0x18A569EC0")]
		public ZipReader(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA569240", Offset = "0xA568640", VA = "0x18A569240", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA569920", Offset = "0xA568D20", VA = "0x18A569920")]
		private IEnumerable<ZipArchiveEntry> _GetEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA569600", Offset = "0xA568A00", VA = "0x18A569600")]
		public ModelRoot LoadModel([Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA569540", Offset = "0xA568940", VA = "0x18A569540")]
		public ModelRoot LoadModel(string gltfFile, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA569B20", Offset = "0xA568F20", VA = "0x18A569B20")]
		private ArraySegment<byte> _ReadAsset(string rawUri)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA5697E0", Offset = "0xA568BE0", VA = "0x18A5697E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56A540", Offset = "0xA569940", VA = "0x18A56A540")]
		public ZipWriter(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA56A470", Offset = "0xA569870", VA = "0x18A56A470")]
		public ZipWriter(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA569240", Offset = "0xA568640", VA = "0x18A569240", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA56A120", Offset = "0xA569520", VA = "0x18A56A120")]
		public void AddModel(string filePath, ModelRoot model, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA56A320", Offset = "0xA569720", VA = "0x18A56A320")]
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
			[Cpp2IlInjected.Address(RVA = "0x7022DC0", Offset = "0x70221C0", VA = "0x187022DC0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public VertexPreprocessor<TvG, TvM, TvS> VertexPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x7022FB0", Offset = "0x70223B0", VA = "0x187022FB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyCollection<PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x70104B0", Offset = "0x700F8B0", VA = "0x1870104B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> IMeshBuilder<TMaterial>.Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x70104B0", Offset = "0x700F8B0", VA = "0x1870104B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x70217F0", Offset = "0x7020BF0", VA = "0x1870217F0")]
		public MeshBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7020100", Offset = "0x701F500", VA = "0x187020100")]
		public MeshBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x70107F0", Offset = "0x700FBF0", VA = "0x1870107F0", Slot = "19")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x700D4A0", Offset = "0x700C8A0", VA = "0x18700D4A0", Slot = "17")]
		IMeshBuilder<TMaterial> IMeshBuilder<TMaterial>.Clone(Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x700D4A0", Offset = "0x700C8A0", VA = "0x18700D4A0")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x7021C00", Offset = "0x7021000", VA = "0x187021C00")]
		private MeshBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> other, [Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x70142C0", Offset = "0x70136C0", VA = "0x1870142C0")]
		public MorphTargetBuilder<TMaterial, TvG, TvS, TvM> UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x700E2D0", Offset = "0x700D6D0", VA = "0x18700E2D0", Slot = "16")]
		IMorphTargetBuilder IMeshBuilder<TMaterial>.UseMorphTarget(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7019540", Offset = "0x7018940", VA = "0x187019540")]
		private PrimitiveBuilder<TMaterial, TvG, TvM, TvS> _UsePrimitive((TMaterial Material, int PrimType) key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7015660", Offset = "0x7014A60", VA = "0x187015660")]
		public PrimitiveBuilder<TMaterial, TvG, TvM, TvS> UsePrimitive(TMaterial material, int primitiveVertexCount = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x700F850", Offset = "0x700EC50", VA = "0x18700F850", Slot = "15")]
		IPrimitiveBuilder IMeshBuilder<TMaterial>.UsePrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7005540", Offset = "0x7004940", VA = "0x187005540")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, Matrix4x4 vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7007460", Offset = "0x7006860", VA = "0x187007460")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, [Optional] Func<TMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39B3290", Offset = "0x39B2690", VA = "0x1839B3290")]
		public void AddMesh<TSourceMaterial>(IMeshBuilder<TSourceMaterial> mesh, Func<TSourceMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7011120", Offset = "0x7010520", VA = "0x187011120")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7018680", Offset = "0x7017A80", VA = "0x187018680", Slot = "18")]
		public void Validate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MeshBuilder<TvG, TvM, TvS> : MeshBuilder<MaterialBuilder, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x7004F00", Offset = "0x7004300", VA = "0x187004F00")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MeshBuilder<TvG, TvM> : MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x53402D0", Offset = "0x533F6D0", VA = "0x1853402D0")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MeshBuilder<TvG> : MeshBuilder<MaterialBuilder, TvG, VertexEmpty, VertexEmpty> where TvG : struct, IVertexGeometry
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x53402D0", Offset = "0x533F6D0", VA = "0x1853402D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5565F0", Offset = "0xA5559F0", VA = "0x18A5565F0")]
		public static VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>[] GetMorphTargetVertices(this IPrimitiveMorphTargetReader morphTarget, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D01900", Offset = "0x3D00D00", VA = "0x183D01900")]
		public static EncodingType GetOptimalIndexEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D02490", Offset = "0x3D01890", VA = "0x183D02490")]
		public static EncodingType GetOptimalJointEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D01290", Offset = "0x3D00690", VA = "0x183D01290")]
		public static IMeshBuilder<TMaterial> CreateMeshBuilderFromVertexAttributes<TMaterial>(params string[] vertexAttributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D00640", Offset = "0x3CFFA40", VA = "0x183D00640")]
		public static IReadOnlyDictionary<Vector3, Vector3> CalculateSmoothNormals<TMaterial>(this IMeshBuilder<TMaterial> srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D02A50", Offset = "0x3D01E50", VA = "0x183D02A50")]
		public static bool IsEmpty<TMaterial>(this IPrimitiveReader<TMaterial> primitive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D02DD0", Offset = "0x3D021D0", VA = "0x183D02DD0")]
		public static bool IsEmpty<TMaterial>(this IMeshBuilder<TMaterial> mesh)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA556790", Offset = "0xA555B90", VA = "0x18A556790")]
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
		[Cpp2IlInjected.Address(RVA = "0x75FE090", Offset = "0x75FD490", VA = "0x1875FE090")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x75FE280", Offset = "0x75FD680", VA = "0x1875FE280")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc, PrimitiveMorphTargetBuilder<TvG, TvM> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x75EA4C0", Offset = "0x75E98C0", VA = "0x1875EA4C0", Slot = "4")]
		public IReadOnlyCollection<int> GetTargetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x75EC370", Offset = "0x75EB770", VA = "0x1875EC370", Slot = "6")]
		public VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex)
		{
			return default(VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x75F5840", Offset = "0x75F4C40", VA = "0x1875F5840")]
		public void SetVertexDelta(int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x75F8BA0", Offset = "0x75F7FA0", VA = "0x1875F8BA0", Slot = "5")]
		IVertexBuilder IPrimitiveMorphTargetReader.GetVertex(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x75EDC50", Offset = "0x75ED050", VA = "0x1875EDC50")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex(int vertexIndex)
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x75F7090", Offset = "0x75F6490", VA = "0x1875F7090")]
		public void SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x75FDC20", Offset = "0x75FD020", VA = "0x1875FDC20")]
		private void _SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x75FD920", Offset = "0x75FCD20", VA = "0x1875FD920")]
		private void _RemoveVertex(int vertexIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x75FCE00", Offset = "0x75FC200", VA = "0x1875FCE00")]
		internal void TransformVertices(Func<VertexBuilder<TvG, TvM, VertexEmpty>, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x75EE7B0", Offset = "0x75EDBB0", VA = "0x1875EE7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x70EC9D0", Offset = "0x70EBDD0", VA = "0x1870EC9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x70EC9A0", Offset = "0x70EBDA0", VA = "0x1870EC9A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		IReadOnlyCollection<IVertexGeometry> IMorphTargetBuilder.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x70E4C00", Offset = "0x70E4000", VA = "0x1870E4C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x70EB0D0", Offset = "0x70EA4D0", VA = "0x1870EB0D0")]
		internal MorphTargetBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x70C9DA0", Offset = "0x70C91A0", VA = "0x1870C9DA0")]
		public IReadOnlyList<TvG> GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x70CEEA0", Offset = "0x70CE2A0", VA = "0x1870CEEA0")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x70CD590", Offset = "0x70CC990", VA = "0x1870CD590")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x70DA2F0", Offset = "0x70D96F0", VA = "0x1870DA2F0")]
		public void SetVertex(TvG meshVertex, VertexBuilder<TvG, TvM, VertexEmpty> morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x70D3B60", Offset = "0x70D2F60", VA = "0x1870D3B60")]
		public void SetVertex(TvG meshVertex, TvG morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x70DBBA0", Offset = "0x70DAFA0", VA = "0x1870DBBA0", Slot = "6")]
		IReadOnlyList<IVertexGeometry> IMorphTargetBuilder.GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x70E2700", Offset = "0x70E1B00", VA = "0x1870E2700", Slot = "7")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x70E0C20", Offset = "0x70E0020", VA = "0x1870E0C20", Slot = "8")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x70E0640", Offset = "0x70DFA40", VA = "0x1870E0640", Slot = "9")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x70DDB70", Offset = "0x70DCF70", VA = "0x1870DDB70", Slot = "10")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x70CF3C0", Offset = "0x70CE7C0", VA = "0x1870CF3C0", Slot = "11")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x70D0500", Offset = "0x70CF900", VA = "0x1870D0500", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5575C0", Offset = "0xA5569C0", VA = "0x18A5575C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA556C70", Offset = "0xA556070", VA = "0x18A556C70")]
		public void AddAccessors(params MemoryAccessor[] accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA556E40", Offset = "0xA556240", VA = "0x18A556E40")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA557540", Offset = "0xA556940", VA = "0x18A557540")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D5A2B0", Offset = "0x3D596B0", VA = "0x183D5A2B0")]
		public void AdjustJointEncoding<TVertex>(IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <CreatePackedMeshes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x64BEFB0", Offset = "0x64BE3B0", VA = "0x1864BEFB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x64BE500", Offset = "0x64BD900", VA = "0x1864BE500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x64BF100", Offset = "0x64BE500", VA = "0x1864BF100")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x64BEC80", Offset = "0x64BE080", VA = "0x1864BEC80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<PackedMeshBuilder<TMaterial>> IEnumerable<PackedMeshBuilder<TMaterial>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x64BEE30", Offset = "0x64BE230", VA = "0x1864BEE30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x746D2E0", Offset = "0x746C6E0", VA = "0x18746D2E0")]
		[IteratorStateMachine(typeof(PackedMeshBuilder<>.<CreatePackedMeshes>d__0))]
		internal static IEnumerable<PackedMeshBuilder<TMaterial>> CreatePackedMeshes(IEnumerable<IMeshBuilder<TMaterial>> meshBuilders, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x746E810", Offset = "0x746DC10", VA = "0x18746E810")]
		private static PackedMeshBuilder<TMaterial> Create(IMeshBuilder<TMaterial> srcMesh, PackedEncoding vertexEncodings, EncodingType indexEncoding, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x746FAC0", Offset = "0x746EEC0", VA = "0x18746FAC0")]
		private PackedMeshBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x746CEE0", Offset = "0x746C2E0", VA = "0x18746CEE0")]
		public PackedPrimitiveBuilder<TMaterial> AddPrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x746D3B0", Offset = "0x746C7B0", VA = "0x18746D3B0")]
		public Mesh CreateSchema2Mesh(ModelRoot root, Converter<TMaterial, Material> materialEvaluator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x746F840", Offset = "0x746EC40", VA = "0x18746F840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7477A10", Offset = "0x7476E10", VA = "0x187477A10")]
		public PackedPrimitiveBuilder(TMaterial material, int primitiveVertexCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7475870", Offset = "0x7474C70", VA = "0x187475870")]
		public void SetStridedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x7474DC0", Offset = "0x74741C0", VA = "0x187474DC0")]
		public void SetStreamedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x7472060", Offset = "0x7471460", VA = "0x187472060")]
		public void SetIndices(IPrimitiveReader<TMaterial> srcPrim, EncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x74735B0", Offset = "0x74729B0", VA = "0x1874735B0")]
		public void SetMorphTargets(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncodings, ISet<string> morphTargetAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x746FFE0", Offset = "0x746F3E0", VA = "0x18746FFE0")]
		private void AddMorphTarget(params MemoryAccessor[] morphTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x74709E0", Offset = "0x746FDE0", VA = "0x1874709E0")]
		internal void CopyToMesh(Mesh dstMesh, Converter<TMaterial, Material> materialEvaluator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7470380", Offset = "0x746F780", VA = "0x187470380")]
		private void CopyMorphTargets(MeshPrimitive dstPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x7471690", Offset = "0x7470A90", VA = "0x187471690")]
		public static void MergeBuffers(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x74768C0", Offset = "0x7475CC0", VA = "0x1874768C0")]
		private static void _MergeSequentialVertices(IEnumerable<MemoryAccessor[]> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7477470", Offset = "0x7476870", VA = "0x187477470")]
		private static void _MergeStridedVertices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7475E30", Offset = "0x7475230", VA = "0x187475E30")]
		private static void _MergeIndices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal static class _PackedPrimitiveHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x4149CE0", Offset = "0x41490E0", VA = "0x184149CE0")]
		public static void _GatherMorphTargetAttributes<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, HashSet<string> attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x414A540", Offset = "0x4149940", VA = "0x18414A540")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x6DAEB10", Offset = "0x6DADF10", VA = "0x186DAEB10", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x6DAB640", Offset = "0x6DAAA40", VA = "0x186DAB640", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x6DAF6C0", Offset = "0x6DAEAC0", VA = "0x186DAF6C0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			IVertexBuilder IReadOnlyList<IVertexBuilder>.this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600057C")]
				[Cpp2IlInjected.Address(RVA = "0x84C7750", Offset = "0x84C6B50", VA = "0x1884C7750", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x84C7180", Offset = "0x84C6580", VA = "0x1884C7180", Slot = "10")]
			[IteratorStateMachine(typeof(PrimitiveBuilder<, , , >.VertexListWrapper.<System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2))]
			IEnumerator<IVertexBuilder> IEnumerable<IVertexBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x84C90E0", Offset = "0x84C84E0", VA = "0x1884C90E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x74E30D0", Offset = "0x74E24D0", VA = "0x1874E30D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x74E2950", Offset = "0x74E1D50", VA = "0x1874E2950", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<VertexBuilder<TvG, TvM, TvS>> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		IReadOnlyList<IVertexBuilder> IPrimitiveReader<TMaterial>.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		IReadOnlyList<IPrimitiveMorphTargetReader> IPrimitiveReader<TMaterial>.MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public virtual IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x74E26E0", Offset = "0x74E1AE0", VA = "0x1874E26E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public virtual IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x74E2620", Offset = "0x74E1A20", VA = "0x1874E2620", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public virtual IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x74E28C0", Offset = "0x74E1CC0", VA = "0x1874E28C0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public virtual IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x74E27D0", Offset = "0x74E1BD0", VA = "0x1874E27D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		internal IReadOnlyList<PrimitiveMorphTargetBuilder<TvG, TvM>> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x74E1A70", Offset = "0x74E0E70", VA = "0x1874E1A70")]
		internal PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x74E1C90", Offset = "0x74E1090", VA = "0x1874E1C90")]
		protected PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		internal abstract PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x74E06A0", Offset = "0x74DFAA0", VA = "0x1874E06A0")]
		internal PrimitiveMorphTargetBuilder<TvG, TvM> _UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x74DFC50", Offset = "0x74DF050", VA = "0x1874DFC50")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x74DD310", Offset = "0x74DC710", VA = "0x1874DD310")]
		private static VertexBuilder<TvG, TvM, TvS> ConvertVertex(IVertexBuilder vertex)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x74DEEF0", Offset = "0x74DE2F0", VA = "0x1874DEEF0")]
		protected int UseVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x74DD760", Offset = "0x74DCB60", VA = "0x1874DD760", Slot = "6")]
		void IPrimitiveBuilder.SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x74DD290", Offset = "0x74DC690", VA = "0x1874DD290")]
		public bool ContainsVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x74D9F30", Offset = "0x74D9330", VA = "0x1874D9F30", Slot = "7")]
		public int AddPoint(IVertexBuilder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x74D8E90", Offset = "0x74D8290", VA = "0x1874D8E90", Slot = "8")]
		public (int, int) AddLine(IVertexBuilder a, IVertexBuilder b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x74DC510", Offset = "0x74DB910", VA = "0x1874DC510", Slot = "9")]
		public (int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x74DB8E0", Offset = "0x74DACE0", VA = "0x1874DB8E0", Slot = "10")]
		public (int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x74DAAF0", Offset = "0x74D9EF0", VA = "0x1874DAAF0")]
		internal void AddPrimitive(PrimitiveBuilder<TMaterial, TvG, TvM, TvS> primitive, Converter<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x39EC250", Offset = "0x39EB650", VA = "0x1839EC250")]
		internal void AddPrimitive<TAnyMaterial>(IPrimitiveReader<TAnyMaterial> primitive, Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x74DD840", Offset = "0x74DCC40", VA = "0x1874DD840")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract IReadOnlyList<int> GetIndices();

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x74D9990", Offset = "0x74D8D90", VA = "0x1874D9990", Slot = "28")]
		public virtual int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x74D90D0", Offset = "0x74D84D0", VA = "0x1874D90D0", Slot = "29")]
		public virtual (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x74DC190", Offset = "0x74DB590", VA = "0x1874DC190", Slot = "30")]
		public virtual (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x74DAD80", Offset = "0x74DA180", VA = "0x1874DAD80", Slot = "31")]
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
				[Cpp2IlInjected.Address(RVA = "0xD59D60", Offset = "0xD59160", VA = "0x180D59D60", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x7495E90", Offset = "0x7495290", VA = "0x187495E90", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public PointListWrapper(IReadOnlyList<T> vertices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x7494890", Offset = "0x7493C90", VA = "0x187494890", Slot = "6")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x7495D30", Offset = "0x7495130", VA = "0x187495D30", Slot = "7")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x74B1030", Offset = "0x74B0430", VA = "0x1874B1030", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x74B09B0", Offset = "0x74AFDB0", VA = "0x1874B09B0")]
		internal PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x74ACF90", Offset = "0x74AC390", VA = "0x1874ACF90", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x74B0430", Offset = "0x74AF830", VA = "0x1874B0430")]
		private PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x74A5650", Offset = "0x74A4A50", VA = "0x1874A5650", Slot = "28")]
		public override int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x74AE4C0", Offset = "0x74AD8C0", VA = "0x1874AE4C0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x69A9690", Offset = "0x69A8A90", VA = "0x1869A9690")]
		internal LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x69A3910", Offset = "0x69A2D10", VA = "0x1869A3910", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x69AA9E0", Offset = "0x69A9DE0", VA = "0x1869AA9E0")]
		private LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x69A1630", Offset = "0x69A0A30", VA = "0x1869A1630", Slot = "29")]
		public override (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x69A6520", Offset = "0x69A5920", VA = "0x1869A6520", Slot = "27")]
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
					[Cpp2IlInjected.Address(RVA = "0x1A14640", Offset = "0x1A13A40", VA = "0x181A14640", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x668D070", Offset = "0x668C470", VA = "0x18668D070", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x668AFB0", Offset = "0x668A3B0", VA = "0x18668AFB0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6EEC670", Offset = "0x6EEBA70", VA = "0x186EEC670", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C2E0B0", Offset = "0x7C2D4B0", VA = "0x187C2E0B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public (int A, int B, int C) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x7C355B0", Offset = "0x7C349B0", VA = "0x187C355B0", Slot = "4")]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public TriangleList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D900", Offset = "0x7C2CD00", VA = "0x187C2D900", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x7A64BF0", Offset = "0x7A63FF0", VA = "0x187A64BF0", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x23ADF00", Offset = "0x23AD300", VA = "0x1823ADF00", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x668D160", Offset = "0x668C560", VA = "0x18668D160", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x6689C40", Offset = "0x6689040", VA = "0x186689C40", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x6EF07B0", Offset = "0x6EEFBB0", VA = "0x186EF07B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A65720", Offset = "0x7A64B20", VA = "0x187A65720", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public (int A, int B, int C, int? D) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x7A70F60", Offset = "0x7A70360", VA = "0x187A70F60", Slot = "4")]
				get
				{
					return default((int, int, int, int?));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public SurfaceList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x7A64B40", Offset = "0x7A63F40", VA = "0x187A64B40", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int, int?)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7A64BF0", Offset = "0x7A63FF0", VA = "0x187A64BF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public override IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A060", Offset = "0x7C59460", VA = "0x187C5A060", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A000", Offset = "0x7C59400", VA = "0x187C5A000", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C57C80", Offset = "0x7C57080", VA = "0x187C57C80")]
		internal TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C4EBC0", Offset = "0x7C4DFC0", VA = "0x187C4EBC0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C58800", Offset = "0x7C57C00", VA = "0x187C58800")]
		private TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B1F0", Offset = "0x7C4A5F0", VA = "0x187C4B1F0", Slot = "30")]
		public override (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C49F50", Offset = "0x7C49350", VA = "0x187C49F50", Slot = "31")]
		public override (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F80", Offset = "0x7C54380", VA = "0x187C54F80")]
		private (int, int, int) _AddTriangle([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b, [In] VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C51AB0", Offset = "0x7C50EB0", VA = "0x187C51AB0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x70BFEC0", Offset = "0x70BF2C0", VA = "0x1870BFEC0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x70BED40", Offset = "0x70BE140", VA = "0x1870BED40")]
		public static IReadOnlyDictionary<IPrimitiveReader<TMaterial>, MeshPrimitiveNormalsAndTangents<TMaterial>> GenerateNormalsTangents(IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		private MeshPrimitiveNormalsAndTangents(IPrimitiveReader<TMaterial> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x70BF650", Offset = "0x70BEA50", VA = "0x1870BF650", Slot = "13")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x70BF870", Offset = "0x70BEC70", VA = "0x1870BF870", Slot = "9")]
		public Vector3 GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x70BF6A0", Offset = "0x70BEAA0", VA = "0x1870BF6A0", Slot = "10")]
		public Vector3 GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x70BF9E0", Offset = "0x70BEDE0", VA = "0x1870BF9E0")]
		public Vector4 GetVertexTangent(int idx)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x70BFB90", Offset = "0x70BEF90", VA = "0x1870BFB90", Slot = "11")]
		public Vector2 GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x70BFD20", Offset = "0x70BF120", VA = "0x1870BFD20", Slot = "6")]
		public void SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x70BFDF0", Offset = "0x70BF1F0", VA = "0x1870BFDF0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0xA58BE30", Offset = "0xA58B230", VA = "0x18A58BE30", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public _NormalTangentAgent(VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410", Slot = "13")]
			public IEnumerable<(int, int, int)> GetTriangleIndices()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA58BA80", Offset = "0xA58AE80", VA = "0x18A58BA80", Slot = "9")]
			public Vector3 GetVertexPosition(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA58B9F0", Offset = "0xA58ADF0", VA = "0x18A58B9F0", Slot = "10")]
			public Vector3 GetVertexNormal(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA58BB10", Offset = "0xA58AF10", VA = "0x18A58BB10", Slot = "11")]
			public Vector2 GetVertexTexCoord(int idx)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA58BB70", Offset = "0xA58AF70", VA = "0x18A58BB70", Slot = "6")]
			public void SetVertexNormal(int idx, Vector3 normal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA58BCD0", Offset = "0xA58B0D0", VA = "0x18A58BCD0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IList<Vector3> Normals
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IList<Vector4> Tangents
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public IList<Vector4> Colors0
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public IList<Vector4> Colors1
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IList<Vector2> TexCoords0
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E50", Offset = "0xCF4250", VA = "0x180CF4E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public IList<Vector2> TexCoords1
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public IList<Vector2> TexCoords2
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public IList<Vector2> TexCoords3
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF4200", VA = "0x180CF4E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public IList<Vector4> Joints0
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xCF5520", Offset = "0xCF4920", VA = "0x180CF5520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public IList<Vector4> Joints1
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xCF8C40", Offset = "0xCF8040", VA = "0x180CF8C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xCF8C50", Offset = "0xCF8050", VA = "0x180CF8C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IList<Vector4> Weights0
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", VA = "0x180CF4DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF4090", VA = "0x180CF4C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public IList<Vector4> Weights1
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF4940", VA = "0x180CF5540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C70", Offset = "0xCF4070", VA = "0x180CF4C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public IReadOnlyList<VertexBufferColumns> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xA565070", Offset = "0xA564470", VA = "0x18A565070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public VertexBufferColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA564EC0", Offset = "0xA5642C0", VA = "0x18A564EC0")]
		public VertexBufferColumns(VertexBufferColumns other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x40C4920", Offset = "0x40C3D20", VA = "0x1840C4920")]
		private static T[] _IsolateColumn<T>(IList<T> column)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA562490", Offset = "0xA561890", VA = "0x18A562490")]
		public void IsolateColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA562760", Offset = "0xA561B60", VA = "0x18A562760")]
		public VertexBufferColumns WithTransform(IGeometryTransform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA562860", Offset = "0xA561C60", VA = "0x18A562860")]
		private void _ApplyTransform(IGeometryTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA564AE0", Offset = "0xA563EE0", VA = "0x18A564AE0")]
		private void _FillMorphData(Vector2[] array, Converter<VertexBufferColumns, Vector2> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA564D00", Offset = "0xA564100", VA = "0x18A564D00")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector3> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA564BC0", Offset = "0xA563FC0", VA = "0x18A564BC0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA564DE0", Offset = "0xA5641E0", VA = "0x18A564DE0")]
		private void _FillMorphData(Vector4[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA561D30", Offset = "0xA561130", VA = "0x18A561D30")]
		public VertexBufferColumns AddMorphTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA5621A0", Offset = "0xA5615A0", VA = "0x18A5621A0")]
		public (Type, Func<IVertexBuilder>) GetCompatibleVertexType()
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x40C2480", Offset = "0x40C1880", VA = "0x1840C2480")]
		private TvG GetVertexGeometry<TvG>(int index) where TvG : struct, IVertexGeometry
		{
			return (TvG)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x40C2F90", Offset = "0x40C2390", VA = "0x1840C2F90")]
		private TvM GetVertexMaterial<TvM>(int index) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40C3CF0", Offset = "0x40C30F0", VA = "0x1840C3CF0")]
		private TvS GetVertexSkinning<TvS>(int index) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA5622D0", Offset = "0xA5616D0", VA = "0x18A5622D0")]
		public IVertexBuilder GetVertex(Func<IVertexBuilder> factory, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x40C4520", Offset = "0x40C3920", VA = "0x1840C4520")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex<TvG, TvM>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x40C4730", Offset = "0x40C3B30", VA = "0x1840C4730")]
		public VertexBuilder<TvG, TvM, TvS> GetVertex<TvG, TvM, TvS>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA561E60", Offset = "0xA561260", VA = "0x18A561E60")]
		public static void CalculateSmoothNormals(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA562000", Offset = "0xA561400", VA = "0x18A562000")]
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
			[Cpp2IlInjected.Address(RVA = "0x83A61F0", Offset = "0x83A55F0", VA = "0x1883A61F0")]
			readonly get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x83A78E0", Offset = "0x83A6CE0", VA = "0x1883A78E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x83A3360", Offset = "0x83A2760", VA = "0x1883A3360")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x83A2B80", Offset = "0x83A1F80", VA = "0x1883A2B80")]
		private static string _GetDebuggerDisplayTextFrom(object o)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x83A1BC0", Offset = "0x83A0FC0", VA = "0x1883A1BC0")]
		private readonly string _GetDebugWarnings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x83A5B70", Offset = "0x83A4F70", VA = "0x1883A5B70")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x83A5A10", Offset = "0x83A4E10", VA = "0x1883A5A10")]
		public VertexBuilder([In] TvG g, [In] TvM m, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x83A55F0", Offset = "0x83A49F0", VA = "0x1883A55F0")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x83A6070", Offset = "0x83A5470", VA = "0x1883A6070")]
		public VertexBuilder([In] TvG g, [In] TvM m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D90", Offset = "0x83A5190", VA = "0x1883A5D90")]
		public VertexBuilder([In] TvG g, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x83A4C00", Offset = "0x83A4000", VA = "0x1883A4C00")]
		public VertexBuilder([In] TvG g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x83A5770", Offset = "0x83A4B70", VA = "0x1883A5770")]
		public VertexBuilder([In] TvG g, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x83A5250", Offset = "0x83A4650", VA = "0x1883A5250")]
		public VertexBuilder(TvG g, SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x83A6EB0", Offset = "0x83A62B0", VA = "0x1883A6EB0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x83A67A0", Offset = "0x83A5BA0", VA = "0x1883A67A0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x83A7230", Offset = "0x83A6630", VA = "0x1883A7230")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x83A6DD0", Offset = "0x83A61D0", VA = "0x1883A6DD0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] TvG g)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8394AE0", Offset = "0x8393EE0", VA = "0x188394AE0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8394B50", Offset = "0x8393F50", VA = "0x188394B50")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x8394900", Offset = "0x8393D00", VA = "0x188394900")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8392B70", Offset = "0x8391F70", VA = "0x188392B70")]
		public static VertexBuilder<TvG, TvM, TvS> CreateFrom(IVertexBuilder src)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x8395FF0", Offset = "0x83953F0", VA = "0x188395FF0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x8395DC0", Offset = "0x83951C0", VA = "0x188395DC0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8395FA0", Offset = "0x83953A0", VA = "0x188395FA0", Slot = "11")]
		public readonly bool Equals(VertexBuilder<TvG, TvM, TvS> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x83A62D0", Offset = "0x83A56D0", VA = "0x1883A62D0")]
		public static bool operator ==([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x83A7890", Offset = "0x83A6C90", VA = "0x1883A7890")]
		public static bool operator !=([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x8391B30", Offset = "0x8390F30", VA = "0x188391B30")]
		public static bool AreEqual([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8398B00", Offset = "0x8397F00", VA = "0x188398B00")]
		public readonly void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3BB71B0", Offset = "0x3BB65B0", VA = "0x183BB71B0")]
		public static MeshBuilder<TMaterial, TvG, TvM, TvS> CreateCompatibleMesh<TMaterial>([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x8392150", Offset = "0x8391550", VA = "0x188392150")]
		public static MeshBuilder<TvG, TvM, TvS> CreateCompatibleMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x4183210", Offset = "0x4182610", VA = "0x184183210", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x83960E0", Offset = "0x83954E0", VA = "0x1883960E0", Slot = "4")]
		readonly IVertexGeometry IVertexBuilder.GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x83961C0", Offset = "0x83955C0", VA = "0x1883961C0", Slot = "5")]
		readonly IVertexMaterial IVertexBuilder.GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8396340", Offset = "0x8395740", VA = "0x188396340", Slot = "6")]
		readonly IVertexSkinning IVertexBuilder.GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x83969A0", Offset = "0x8395DA0", VA = "0x1883969A0", Slot = "7")]
		void IVertexBuilder.SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x83974C0", Offset = "0x83968C0", VA = "0x1883974C0", Slot = "8")]
		void IVertexBuilder.SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8398240", Offset = "0x8397640", VA = "0x188398240", Slot = "9")]
		void IVertexBuilder.SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8398690", Offset = "0x8397A90", VA = "0x188398690")]
		public readonly VertexBuilder<TvG, TvM, TvS> TransformedBy([In] Matrix4x4 transform)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8399DA0", Offset = "0x83991A0", VA = "0x188399DA0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x839A6A0", Offset = "0x8399AA0", VA = "0x18839A6A0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8399580", Offset = "0x8398980", VA = "0x188399580")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x839BE10", Offset = "0x839B210", VA = "0x18839BE10")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial(params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x839D440", Offset = "0x839C840", VA = "0x18839D440")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x839C710", Offset = "0x839BB10", VA = "0x18839C710")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, Vector4 color1, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x839E1E0", Offset = "0x839D5E0", VA = "0x18839E1E0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning([In] SparseWeight8 sparse)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x839ED10", Offset = "0x839E110", VA = "0x18839ED10")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(params (int Index, float Weight)[] bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x839DFE0", Offset = "0x839D3E0", VA = "0x18839DFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA570EF0", Offset = "0xA5702F0", VA = "0x18A570EF0")]
		public VertexBuilder(IVertexGeometry g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1F2B580", Offset = "0x1F2A980", VA = "0x181F2B580")]
		public VertexBuilder(IVertexGeometry g, IVertexMaterial m, IVertexSkinning s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1498450", Offset = "0x1497850", VA = "0x181498450", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420", Slot = "4")]
		public readonly IVertexGeometry GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410", Slot = "5")]
		public readonly IVertexMaterial GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "6")]
		public readonly IVertexSkinning GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440", Slot = "7")]
		public void SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xF3E420", Offset = "0xF3D820", VA = "0x180F3E420", Slot = "8")]
		public void SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10", Slot = "9")]
		public void SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA570E40", Offset = "0xA570240", VA = "0x18A570E40")]
		public readonly IVertexBuilder ConvertToType(Func<IVertexBuilder> factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAF40", Offset = "0x3BEA340", VA = "0x183BEAF40", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			[CompilerGenerated]
			get
			{
				return default(EncodingType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xCFFA40", Offset = "0xCFEE40", VA = "0x180CFFA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xE8DE30", Offset = "0xE8D230", VA = "0x180E8DE30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xEC6240", Offset = "0xEC5640", VA = "0x180EC6240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA570DA0", Offset = "0xA5701A0", VA = "0x18A570DA0")]
		public VertexAttributeAttribute(string attributeName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA570DE0", Offset = "0xA5701E0", VA = "0x18A570DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56C6F0", Offset = "0xA56BAF0", VA = "0x18A56C6F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xFF78B0", Offset = "0xFF6CB0", VA = "0x180FF78B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xA56C6B0", Offset = "0xA56BAB0", VA = "0x18A56C6B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xA56C610", Offset = "0xA56BA10", VA = "0x18A56C610", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xA56C610", Offset = "0xA56BA10", VA = "0x18A56C610", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "21")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA576ED0", Offset = "0xA5762D0", VA = "0x18A576ED0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA576B60", Offset = "0xA575F60", VA = "0x18A576B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "22")]
		public bool Equals(VertexEmpty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0")]
		public static bool operator ==([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
		public static bool operator !=([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xA576CF0", Offset = "0xA5760F0", VA = "0x18A576CF0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA576D40", Offset = "0xA576140", VA = "0x18A576D40", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA576D90", Offset = "0xA576190", VA = "0x18A576D90", Slot = "10")]
		VertexMaterialDelta IVertexMaterial.Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA576C50", Offset = "0xA576050", VA = "0x18A576C50", Slot = "6")]
		Vector4 IVertexMaterial.GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xA576CA0", Offset = "0xA5760A0", VA = "0x18A576CA0", Slot = "7")]
		Vector2 IVertexMaterial.GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA576BB0", Offset = "0xA575FB0", VA = "0x18A576BB0", Slot = "17")]
		public SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA576C10", Offset = "0xA576010", VA = "0x18A576C10")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA576BD0", Offset = "0xA575FD0", VA = "0x18A576BD0", Slot = "16")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA576F40", Offset = "0xA576340", VA = "0x18A576F40", Slot = "14")]
		(int, float) IVertexSkinning.GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA576F90", Offset = "0xA576390", VA = "0x18A576F90", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56DA50", Offset = "0xA56CE50", VA = "0x18A56DA50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA56CCF0", Offset = "0xA56C0F0", VA = "0x18A56CCF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xA56D870", Offset = "0xA56CC70", VA = "0x18A56D870", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xA56D5B0", Offset = "0xA56C9B0", VA = "0x18A56D5B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xA56D5B0", Offset = "0xA56C9B0", VA = "0x18A56D5B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA57D060", Offset = "0xA57C460", VA = "0x18A57D060")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CD0", Offset = "0x2DD60D0", VA = "0x182DD6CD0")]
		public VertexPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA57D0E0", Offset = "0xA57C4E0", VA = "0x18A57D0E0")]
		public VertexPosition(float px, float py, float pz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA57D120", Offset = "0xA57C520", VA = "0x18A57D120")]
		public VertexPosition(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3640", Offset = "0x2DD2A40", VA = "0x182DD3640")]
		public static implicit operator VertexPosition([In] Vector3 position)
		{
			return default(VertexPosition);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA57CEB0", Offset = "0xA57C2B0", VA = "0x18A57CEB0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5772C0", Offset = "0xA5766C0", VA = "0x18A5772C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA57CDE0", Offset = "0xA57C1E0", VA = "0x18A57CDE0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA57CD90", Offset = "0xA57C190", VA = "0x18A57CD90", Slot = "14")]
		public readonly bool Equals(VertexPosition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA57CD90", Offset = "0xA57C190", VA = "0x18A57CD90")]
		public static bool operator ==([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA57D260", Offset = "0xA57C660", VA = "0x18A57D260")]
		public static bool operator !=([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA57CD90", Offset = "0xA57C190", VA = "0x18A57CD90")]
		public static bool AreEqual([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CD0", Offset = "0x2DD60D0", VA = "0x182DD6CD0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		readonly void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA57CF20", Offset = "0xA57C320", VA = "0x18A57CF20", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA57CBB0", Offset = "0xA57BFB0", VA = "0x18A57CBB0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3640", Offset = "0x2DD2A40", VA = "0x182DD3640", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA57D050", Offset = "0xA57C450", VA = "0x18A57D050", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x17403B0", Offset = "0x173F7B0", VA = "0x1817403B0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA57CC20", Offset = "0xA57C020", VA = "0x18A57CC20")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA57CEA0", Offset = "0xA57C2A0", VA = "0x18A57CEA0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA57CBB0", Offset = "0xA57BFB0", VA = "0x18A57CBB0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EF50", Offset = "0xA56E350", VA = "0x18A56EF50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA56DDC0", Offset = "0xA56D1C0", VA = "0x18A56DDC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xA56EE20", Offset = "0xA56E220", VA = "0x18A56EE20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA56EA40", Offset = "0xA56DE40", VA = "0x18A56EA40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xA56EA40", Offset = "0xA56DE40", VA = "0x18A56EA40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA57C8D0", Offset = "0xA57BCD0", VA = "0x18A57C8D0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA57CB30", Offset = "0xA57BF30", VA = "0x18A57CB30")]
		public VertexPositionNormal([In] Vector3 p, [In] Vector3 n)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA57CAA0", Offset = "0xA57BEA0", VA = "0x18A57CAA0")]
		public VertexPositionNormal(float px, float py, float pz, float nx, float ny, float nz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA57C950", Offset = "0xA57BD50", VA = "0x18A57C950")]
		public VertexPositionNormal(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA57CB60", Offset = "0xA57BF60", VA = "0x18A57CB60")]
		public static implicit operator VertexPositionNormal([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexPositionNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA57C7A0", Offset = "0xA57BBA0", VA = "0x18A57C7A0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5772C0", Offset = "0xA5766C0", VA = "0x18A5772C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA57C660", Offset = "0xA57BA60", VA = "0x18A57C660", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA57C760", Offset = "0xA57BB60", VA = "0x18A57C760", Slot = "14")]
		public readonly bool Equals(VertexPositionNormal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA57CB50", Offset = "0xA57BF50", VA = "0x18A57CB50")]
		public static bool operator ==([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA57CB90", Offset = "0xA57BF90", VA = "0x18A57CB90")]
		public static bool operator !=([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA57C5E0", Offset = "0xA57B9E0", VA = "0x18A57C5E0")]
		public static bool AreEqual([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CD0", Offset = "0x2DD60D0", VA = "0x182DD6CD0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA577310", Offset = "0xA576710", VA = "0x18A577310", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA57C820", Offset = "0xA57BC20", VA = "0x18A57C820", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA57C2C0", Offset = "0xA57B6C0", VA = "0x18A57C2C0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3640", Offset = "0x2DD2A40", VA = "0x182DD3640", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5774B0", Offset = "0xA5768B0", VA = "0x18A5774B0", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x17403B0", Offset = "0x173F7B0", VA = "0x1817403B0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA57C390", Offset = "0xA57B790", VA = "0x18A57C390")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA57C790", Offset = "0xA57BB90", VA = "0x18A57C790", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA57C780", Offset = "0xA57BB80", VA = "0x18A57C780", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EFF0", Offset = "0xA56E3F0", VA = "0x18A56EFF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA56E4A0", Offset = "0xA56D8A0", VA = "0x18A56E4A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA56ED20", Offset = "0xA56E120", VA = "0x18A56ED20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA56E8F0", Offset = "0xA56DCF0", VA = "0x18A56E8F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA56E8F0", Offset = "0xA56DCF0", VA = "0x18A56E8F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA57C030", Offset = "0xA57B430", VA = "0x18A57C030")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA57C0C0", Offset = "0xA57B4C0", VA = "0x18A57C0C0")]
		public VertexPositionNormalTangent([In] Vector3 p, [In] Vector3 n, [In] Vector4 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA57C0F0", Offset = "0xA57B4F0", VA = "0x18A57C0F0")]
		public VertexPositionNormalTangent(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA57C270", Offset = "0xA57B670", VA = "0x18A57C270")]
		public static implicit operator VertexPositionNormalTangent([In] (Vector3 Pos, Vector3 Nrm, Vector4 Tgt) tuple)
		{
			return default(VertexPositionNormalTangent);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA57BEE0", Offset = "0xA57B2E0", VA = "0x18A57BEE0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5772C0", Offset = "0xA5766C0", VA = "0x18A5772C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA57BD60", Offset = "0xA57B160", VA = "0x18A57BD60", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA57BEA0", Offset = "0xA57B2A0", VA = "0x18A57BEA0", Slot = "14")]
		public readonly bool Equals(VertexPositionNormalTangent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA57C260", Offset = "0xA57B660", VA = "0x18A57C260")]
		public static bool operator ==([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA57C2A0", Offset = "0xA57B6A0", VA = "0x18A57C2A0")]
		public static bool operator !=([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA57BCC0", Offset = "0xA57B0C0", VA = "0x18A57BCC0")]
		public static bool AreEqual([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CD0", Offset = "0x2DD60D0", VA = "0x182DD6CD0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA577310", Offset = "0xA576710", VA = "0x18A577310", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF65B60", Offset = "0xF64F60", VA = "0x180F65B60", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA57BF60", Offset = "0xA57B360", VA = "0x18A57BF60", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA57B7D0", Offset = "0xA57ABD0", VA = "0x18A57B7D0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3640", Offset = "0x2DD2A40", VA = "0x182DD3640", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA5774B0", Offset = "0xA5768B0", VA = "0x18A5774B0", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA57C020", Offset = "0xA57B420", VA = "0x18A57C020", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA57B940", Offset = "0xA57AD40", VA = "0x18A57B940")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA57BED0", Offset = "0xA57B2D0", VA = "0x18A57BED0", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA57BEC0", Offset = "0xA57B2C0", VA = "0x18A57BEC0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56C060", Offset = "0xA56B460", VA = "0x18A56C060", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA56BD60", Offset = "0xA56B160", VA = "0x18A56BD60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xA56C020", Offset = "0xA56B420", VA = "0x18A56C020", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xA56BF70", Offset = "0xA56B370", VA = "0x18A56BF70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xA56BF70", Offset = "0xA56B370", VA = "0x18A56BF70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA577520", Offset = "0xA576920", VA = "0x18A577520")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA577D90", Offset = "0xA577190", VA = "0x18A577D90")]
		public static implicit operator VertexGeometryDelta([In] Vector3 position)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA577D30", Offset = "0xA577130", VA = "0x18A577D30")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA577CF0", Offset = "0xA5770F0", VA = "0x18A577CF0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm, Vector3 tgt) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA5778E0", Offset = "0xA576CE0", VA = "0x18A5778E0")]
		public VertexGeometryDelta(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA577710", Offset = "0xA576B10", VA = "0x18A577710")]
		public VertexGeometryDelta([In] Vector3 p, [In] Vector3 n, [In] Vector3 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA577C30", Offset = "0xA577030", VA = "0x18A577C30")]
		internal VertexGeometryDelta([In] VertexPosition rootVal, [In] VertexPosition morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA577600", Offset = "0xA576A00", VA = "0x18A577600")]
		internal VertexGeometryDelta([In] VertexPositionNormal rootVal, [In] VertexPositionNormal morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA577750", Offset = "0xA576B50", VA = "0x18A577750")]
		internal VertexGeometryDelta([In] VertexPositionNormalTangent rootVal, [In] VertexPositionNormalTangent morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA577B00", Offset = "0xA576F00", VA = "0x18A577B00")]
		internal VertexGeometryDelta([In] VertexGeometryDelta rootVal, [In] VertexGeometryDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA577370", Offset = "0xA576770", VA = "0x18A577370", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA5772C0", Offset = "0xA5766C0", VA = "0x18A5772C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA577210", Offset = "0xA576610", VA = "0x18A577210", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA5771F0", Offset = "0xA5765F0", VA = "0x18A5771F0", Slot = "14")]
		public readonly bool Equals(VertexGeometryDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA577CE0", Offset = "0xA5770E0", VA = "0x18A577CE0")]
		public static bool operator ==([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA577E10", Offset = "0xA577210", VA = "0x18A577E10")]
		public static bool operator !=([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA577130", Offset = "0xA576530", VA = "0x18A577130")]
		public static bool AreEqual([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6CD0", Offset = "0x2DD60D0", VA = "0x182DD6CD0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA577310", Offset = "0xA576710", VA = "0x18A577310", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA577320", Offset = "0xA576720", VA = "0x18A577320", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3640", Offset = "0x2DD2A40", VA = "0x182DD3640", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA5774B0", Offset = "0xA5768B0", VA = "0x18A5774B0", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA5774D0", Offset = "0xA5768D0", VA = "0x18A5774D0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA5770F0", Offset = "0xA5764F0", VA = "0x18A5770F0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA5773F0", Offset = "0xA5767F0", VA = "0x18A5773F0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA576FD0", Offset = "0xA5763D0", VA = "0x18A576FD0")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA577300", Offset = "0xA576700", VA = "0x18A577300", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA5772F0", Offset = "0xA5766F0", VA = "0x18A5772F0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56CAD0", Offset = "0xA56BED0", VA = "0x18A56CAD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA56C820", Offset = "0xA56BC20", VA = "0x18A56C820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA56CA90", Offset = "0xA56BE90", VA = "0x18A56CA90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xA56C910", Offset = "0xA56BD10", VA = "0x18A56C910", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xA56C910", Offset = "0xA56BD10", VA = "0x18A56C910", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public static implicit operator VertexColor1(Vector4 color)
		{
			return default(VertexColor1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA573690", Offset = "0xA572A90", VA = "0x18A573690")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x15214C0", Offset = "0x15208C0", VA = "0x1815214C0")]
		public VertexColor1(Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA573710", Offset = "0xA572B10", VA = "0x18A573710")]
		public VertexColor1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA573570", Offset = "0xA572970", VA = "0x18A573570", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA5734F0", Offset = "0xA5728F0", VA = "0x18A5734F0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA5733B0", Offset = "0xA5727B0", VA = "0x18A5733B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA573450", Offset = "0xA572850", VA = "0x18A573450", Slot = "13")]
		public readonly bool Equals(VertexColor1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA573450", Offset = "0xA572850", VA = "0x18A573450")]
		public static bool operator ==([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA573870", Offset = "0xA572C70", VA = "0x18A573870")]
		public static bool operator !=([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA573380", Offset = "0xA572780", VA = "0x18A573380")]
		public static bool AreEqual([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA5735E0", Offset = "0xA5729E0", VA = "0x18A5735E0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA573300", Offset = "0xA572700", VA = "0x18A573300")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA5712F0", Offset = "0xA5706F0", VA = "0x18A5712F0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA573480", Offset = "0xA572880", VA = "0x18A573480", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA573510", Offset = "0xA572910", VA = "0x18A573510", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA573560", Offset = "0xA572960", VA = "0x18A573560", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56D9B0", Offset = "0xA56CDB0", VA = "0x18A56D9B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA56D2E0", Offset = "0xA56C6E0", VA = "0x18A56D2E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA56D930", Offset = "0xA56CD30", VA = "0x18A56D930", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA56D470", Offset = "0xA56C870", VA = "0x18A56D470", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xA56D470", Offset = "0xA56C870", VA = "0x18A56D470", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA576B20", Offset = "0xA575F20", VA = "0x18A576B20")]
		public static implicit operator VertexColor2((Vector4 Color0, Vector4 Color1) tuple)
		{
			return default(VertexColor2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA576870", Offset = "0xA575C70", VA = "0x18A576870")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x62AC070", Offset = "0x62AB470", VA = "0x1862AC070")]
		public VertexColor2(Vector4 color0, Vector4 color1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA5768F0", Offset = "0xA575CF0", VA = "0x18A5768F0")]
		public VertexColor2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA576740", Offset = "0xA575B40", VA = "0x18A576740", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA576690", Offset = "0xA575A90", VA = "0x18A576690", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA5764F0", Offset = "0xA5758F0", VA = "0x18A5764F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA5765F0", Offset = "0xA5759F0", VA = "0x18A5765F0", Slot = "13")]
		public readonly bool Equals(VertexColor2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA576B10", Offset = "0xA575F10", VA = "0x18A576B10")]
		public static bool operator ==([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA576B40", Offset = "0xA575F40", VA = "0x18A576B40")]
		public static bool operator !=([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA576470", Offset = "0xA575870", VA = "0x18A576470")]
		public static bool AreEqual([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA5767B0", Offset = "0xA575BB0", VA = "0x18A5767B0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA576380", Offset = "0xA575780", VA = "0x18A576380")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA576610", Offset = "0xA575A10", VA = "0x18A576610", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA5766E0", Offset = "0xA575AE0", VA = "0x18A5766E0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA576730", Offset = "0xA575B30", VA = "0x18A576730", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56CB20", Offset = "0xA56BF20", VA = "0x18A56CB20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xA56C740", Offset = "0xA56BB40", VA = "0x18A56C740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xA56CA50", Offset = "0xA56BE50", VA = "0x18A56CA50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xA56C9B0", Offset = "0xA56BDB0", VA = "0x18A56C9B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA56C9B0", Offset = "0xA56BDB0", VA = "0x18A56C9B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120")]
		public static implicit operator VertexTexture1(Vector2 uv)
		{
			return default(VertexTexture1);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA57D620", Offset = "0xA57CA20", VA = "0x18A57D620")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x14012C0", Offset = "0x14006C0", VA = "0x1814012C0")]
		public VertexTexture1(Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA57D6A0", Offset = "0xA57CAA0", VA = "0x18A57D6A0")]
		public VertexTexture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA57D4F0", Offset = "0xA57C8F0", VA = "0x18A57D4F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA57D450", Offset = "0xA57C850", VA = "0x18A57D450", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA57D330", Offset = "0xA57C730", VA = "0x18A57D330", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA57D3E0", Offset = "0xA57C7E0", VA = "0x18A57D3E0", Slot = "13")]
		public readonly bool Equals(VertexTexture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA57D7B0", Offset = "0xA57CBB0", VA = "0x18A57D7B0")]
		public static bool operator ==([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA57D7E0", Offset = "0xA57CBE0", VA = "0x18A57D7E0")]
		public static bool operator !=([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA57D300", Offset = "0xA57C700", VA = "0x18A57D300")]
		public static bool AreEqual([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA57D570", Offset = "0xA57C970", VA = "0x18A57D570", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA57D2B0", Offset = "0xA57C6B0", VA = "0x18A57D2B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA57D4E0", Offset = "0xA57C8E0", VA = "0x18A57D4E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA57D400", Offset = "0xA57C800", VA = "0x18A57D400", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA57D470", Offset = "0xA57C870", VA = "0x18A57D470", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA57D2B0", Offset = "0xA57C6B0", VA = "0x18A57D2B0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56DAA0", Offset = "0xA56CEA0", VA = "0x18A56DAA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA56D160", Offset = "0xA56C560", VA = "0x18A56D160", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xA56D8B0", Offset = "0xA56CCB0", VA = "0x18A56D8B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xA56D6F0", Offset = "0xA56CAF0", VA = "0x18A56D6F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA56D6F0", Offset = "0xA56CAF0", VA = "0x18A56D6F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public static implicit operator VertexTexture2((Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexTexture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA57DCC0", Offset = "0xA57D0C0", VA = "0x18A57DCC0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x3110620", Offset = "0x310FA20", VA = "0x183110620")]
		public VertexTexture2(Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA57DD40", Offset = "0xA57D140", VA = "0x18A57DD40")]
		public VertexTexture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA57DBA0", Offset = "0xA57CFA0", VA = "0x18A57DBA0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA57DAA0", Offset = "0xA57CEA0", VA = "0x18A57DAA0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA57D940", Offset = "0xA57CD40", VA = "0x18A57D940", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA57D920", Offset = "0xA57CD20", VA = "0x18A57D920", Slot = "13")]
		public readonly bool Equals(VertexTexture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA57DEB0", Offset = "0xA57D2B0", VA = "0x18A57DEB0")]
		public static bool operator ==([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA57DEC0", Offset = "0xA57D2C0", VA = "0x18A57DEC0")]
		public static bool operator !=([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA57D8A0", Offset = "0xA57CCA0", VA = "0x18A57D8A0")]
		public static bool AreEqual([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA57DC10", Offset = "0xA57D010", VA = "0x18A57DC10", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA57D810", Offset = "0xA57CC10", VA = "0x18A57D810")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA57DB80", Offset = "0xA57CF80", VA = "0x18A57DB80", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA57DA50", Offset = "0xA57CE50", VA = "0x18A57DA50", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA57DAF0", Offset = "0xA57CEF0", VA = "0x18A57DAF0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA57DB70", Offset = "0xA57CF70", VA = "0x18A57DB70", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56DA00", Offset = "0xA56CE00", VA = "0x18A56DA00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xA56CB70", Offset = "0xA56BF70", VA = "0x18A56CB70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA56D830", Offset = "0xA56CC30", VA = "0x18A56D830", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA56D790", Offset = "0xA56CB90", VA = "0x18A56D790", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA56D790", Offset = "0xA56CB90", VA = "0x18A56D790", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x304E810", Offset = "0x304DC10", VA = "0x18304E810")]
		public static implicit operator VertexColor1Texture1((Vector4 Color, Vector2 Tex) tuple)
		{
			return default(VertexColor1Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA571450", Offset = "0xA570850", VA = "0x18A571450")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x686F080", Offset = "0x686E480", VA = "0x18686F080")]
		public VertexColor1Texture1(Vector4 color, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5714D0", Offset = "0xA5708D0", VA = "0x18A5714D0")]
		public VertexColor1Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA571310", Offset = "0xA570710", VA = "0x18A571310", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA571210", Offset = "0xA570610", VA = "0x18A571210", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA571090", Offset = "0xA570490", VA = "0x18A571090", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA571180", Offset = "0xA570580", VA = "0x18A571180", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA571680", Offset = "0xA570A80", VA = "0x18A571680")]
		public static bool operator ==([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA571690", Offset = "0xA570A90", VA = "0x18A571690")]
		public static bool operator !=([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA571000", Offset = "0xA570400", VA = "0x18A571000")]
		public static bool AreEqual([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA571390", Offset = "0xA570790", VA = "0x18A571390", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA570F30", Offset = "0xA570330", VA = "0x18A570F30")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5712F0", Offset = "0xA5706F0", VA = "0x18A5712F0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA571300", Offset = "0xA570700", VA = "0x18A571300", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5711A0", Offset = "0xA5705A0", VA = "0x18A5711A0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA571260", Offset = "0xA570660", VA = "0x18A571260", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5712E0", Offset = "0xA5706E0", VA = "0x18A5712E0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EFA0", Offset = "0xA56E3A0", VA = "0x18A56EFA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA56DB90", Offset = "0xA56CF90", VA = "0x18A56DB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA56ED60", Offset = "0xA56E160", VA = "0x18A56ED60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xA56EAE0", Offset = "0xA56DEE0", VA = "0x18A56EAE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xA56EAE0", Offset = "0xA56DEE0", VA = "0x18A56EAE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CF80", Offset = "0x2D9C380", VA = "0x182D9CF80")]
		public static implicit operator VertexColor1Texture2((Vector4 Color, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor1Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA571C10", Offset = "0xA571010", VA = "0x18A571C10")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x819CD30", Offset = "0x819C130", VA = "0x18819CD30")]
		public VertexColor1Texture2(Vector4 color, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA571C90", Offset = "0xA571090", VA = "0x18A571C90")]
		public VertexColor1Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA571AE0", Offset = "0xA570EE0", VA = "0x18A571AE0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5719A0", Offset = "0xA570DA0", VA = "0x18A5719A0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA571890", Offset = "0xA570C90", VA = "0x18A571890", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA571870", Offset = "0xA570C70", VA = "0x18A571870", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA571EA0", Offset = "0xA5712A0", VA = "0x18A571EA0")]
		public static bool operator ==([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA571EB0", Offset = "0xA5712B0", VA = "0x18A571EB0")]
		public static bool operator !=([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5717B0", Offset = "0xA570BB0", VA = "0x18A5717B0")]
		public static bool AreEqual([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA571B50", Offset = "0xA570F50", VA = "0x18A571B50", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5716B0", Offset = "0xA570AB0", VA = "0x18A5716B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5712F0", Offset = "0xA5706F0", VA = "0x18A5712F0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA571AC0", Offset = "0xA570EC0", VA = "0x18A571AC0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA571930", Offset = "0xA570D30", VA = "0x18A571930", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA571A20", Offset = "0xA570E20", VA = "0x18A571A20", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA571AB0", Offset = "0xA570EB0", VA = "0x18A571AB0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EEB0", Offset = "0xA56E2B0", VA = "0x18A56EEB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA56E6B0", Offset = "0xA56DAB0", VA = "0x18A56E6B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA56ECE0", Offset = "0xA56E0E0", VA = "0x18A56ECE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xA56EB80", Offset = "0xA56DF80", VA = "0x18A56EB80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xA56EB80", Offset = "0xA56DF80", VA = "0x18A56EB80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA574200", Offset = "0xA573600", VA = "0x18A574200")]
		public static implicit operator VertexColor2Texture1((Vector4 Color0, Vector4 Color1, Vector2 Tex) tuple)
		{
			return default(VertexColor2Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA573EF0", Offset = "0xA5732F0", VA = "0x18A573EF0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x81B9ED0", Offset = "0x81B92D0", VA = "0x1881B9ED0")]
		public VertexColor2Texture1(Vector4 color0, Vector4 color1, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA573F80", Offset = "0xA573380", VA = "0x18A573F80")]
		public VertexColor2Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA573DB0", Offset = "0xA5731B0", VA = "0x18A573DB0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA573C70", Offset = "0xA573070", VA = "0x18A573C70", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA573AA0", Offset = "0xA572EA0", VA = "0x18A573AA0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA573A80", Offset = "0xA572E80", VA = "0x18A573A80", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5741F0", Offset = "0xA5735F0", VA = "0x18A5741F0")]
		public static bool operator ==([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA574220", Offset = "0xA573620", VA = "0x18A574220")]
		public static bool operator !=([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5739D0", Offset = "0xA572DD0", VA = "0x18A5739D0")]
		public static bool AreEqual([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA573E30", Offset = "0xA573230", VA = "0x18A573E30", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5738A0", Offset = "0xA572CA0", VA = "0x18A5738A0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA573DA0", Offset = "0xA5731A0", VA = "0x18A573DA0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA573BF0", Offset = "0xA572FF0", VA = "0x18A573BF0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA573CF0", Offset = "0xA5730F0", VA = "0x18A573CF0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA573D70", Offset = "0xA573170", VA = "0x18A573D70", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA570090", Offset = "0xA56F490", VA = "0x18A570090", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA56F3A0", Offset = "0xA56E7A0", VA = "0x18A56F3A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA56FF90", Offset = "0xA56F390", VA = "0x18A56FF90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA56FEE0", Offset = "0xA56F2E0", VA = "0x18A56FEE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA56FEE0", Offset = "0xA56F2E0", VA = "0x18A56FEE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA574BF0", Offset = "0xA573FF0", VA = "0x18A574BF0")]
		public static implicit operator VertexColor2Texture2((Vector4 Color0, Vector4 Color1, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor2Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA574890", Offset = "0xA573C90", VA = "0x18A574890")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x82A4580", Offset = "0x82A3980", VA = "0x1882A4580")]
		public VertexColor2Texture2(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA574920", Offset = "0xA573D20", VA = "0x18A574920")]
		public VertexColor2Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA574750", Offset = "0xA573B50", VA = "0x18A574750", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA5745F0", Offset = "0xA5739F0", VA = "0x18A5745F0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA5744C0", Offset = "0xA5738C0", VA = "0x18A5744C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA5744A0", Offset = "0xA5738A0", VA = "0x18A5744A0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA574BE0", Offset = "0xA573FE0", VA = "0x18A574BE0")]
		public static bool operator ==([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA574C10", Offset = "0xA574010", VA = "0x18A574C10")]
		public static bool operator !=([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA5743B0", Offset = "0xA5737B0", VA = "0x18A5743B0")]
		public static bool AreEqual([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA5747D0", Offset = "0xA573BD0", VA = "0x18A5747D0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA574240", Offset = "0xA573640", VA = "0x18A574240")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA574730", Offset = "0xA573B30", VA = "0x18A574730", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA574570", Offset = "0xA573970", VA = "0x18A574570", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA574690", Offset = "0xA573A90", VA = "0x18A574690", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA574720", Offset = "0xA573B20", VA = "0x18A574720", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56C5C0", Offset = "0xA56B9C0", VA = "0x18A56C5C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xA56C0B0", Offset = "0xA56B4B0", VA = "0x18A56C0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xA56C580", Offset = "0xA56B980", VA = "0x18A56C580", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA56C4B0", Offset = "0xA56B8B0", VA = "0x18A56C4B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA56C4B0", Offset = "0xA56B8B0", VA = "0x18A56C4B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57B5D0", Offset = "0xA57A9D0", VA = "0x18A57B5D0")]
			get
			{
				return default(VertexMaterialDelta);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xD11F80", Offset = "0xD11380", VA = "0x180D11F80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11F90", Offset = "0xD11390", VA = "0x180D11F90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA579690", Offset = "0xA578A90", VA = "0x18A579690")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA57B6D0", Offset = "0xA57AAD0", VA = "0x18A57B6D0")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA57B770", Offset = "0xA57AB70", VA = "0x18A57B770")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta, Vector2 TextCoord2Delta, Vector2 TextCoord3Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA57A900", Offset = "0xA579D00", VA = "0x18A57A900")]
		public VertexMaterialDelta(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA57ACE0", Offset = "0xA57A0E0", VA = "0x18A57ACE0")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA579BA0", Offset = "0xA578FA0", VA = "0x18A579BA0")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta, [In] Vector2 texCoord2Delta, [In] Vector2 texCoord3Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA57A1D0", Offset = "0xA5795D0", VA = "0x18A57A1D0")]
		internal VertexMaterialDelta([In] VertexMaterialDelta rootVal, [In] VertexMaterialDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA579510", Offset = "0xA578910", VA = "0x18A579510", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA5792D0", Offset = "0xA5786D0", VA = "0x18A5792D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA579190", Offset = "0xA578590", VA = "0x18A579190", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA579170", Offset = "0xA578570", VA = "0x18A579170", Slot = "13")]
		public readonly bool Equals(VertexMaterialDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA57B6C0", Offset = "0xA57AAC0", VA = "0x18A57B6C0")]
		public static bool operator ==([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA57B7B0", Offset = "0xA57ABB0", VA = "0x18A57B7B0")]
		public static bool operator !=([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA579010", Offset = "0xA578410", VA = "0x18A579010")]
		public static bool AreEqual([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA5795B0", Offset = "0xA5789B0", VA = "0x18A5795B0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA575760", Offset = "0xA574B60", VA = "0x18A575760")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80")]
		private void SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA579480", Offset = "0xA578880", VA = "0x18A579480", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA575DC0", Offset = "0xA5751C0", VA = "0x18A575DC0")]
		private void SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA579250", Offset = "0xA578650", VA = "0x18A579250", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA5793B0", Offset = "0xA5787B0", VA = "0x18A5793B0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA57A7F0", Offset = "0xA579BF0", VA = "0x18A57A7F0")]
		internal VertexMaterialDelta([In] VertexTexture1 rootVal, [In] VertexTexture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA57A0A0", Offset = "0xA5794A0", VA = "0x18A57A0A0")]
		internal VertexMaterialDelta([In] VertexTexture2 rootVal, [In] VertexTexture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA579A50", Offset = "0xA578E50", VA = "0x18A579A50")]
		internal VertexMaterialDelta([In] VertexTexture3 rootVal, [In] VertexTexture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA579F40", Offset = "0xA579340", VA = "0x18A579F40")]
		internal VertexMaterialDelta([In] VertexTexture4 rootVal, [In] VertexTexture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA57B4B0", Offset = "0xA57A8B0", VA = "0x18A57B4B0")]
		internal VertexMaterialDelta([In] VertexColor1 rootVal, [In] VertexColor1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA579C30", Offset = "0xA579030", VA = "0x18A579C30")]
		internal VertexMaterialDelta([In] VertexColor1Texture1 rootVal, [In] VertexColor1Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA57A480", Offset = "0xA579880", VA = "0x18A57A480")]
		internal VertexMaterialDelta([In] VertexColor1Texture2 rootVal, [In] VertexColor1Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA5798C0", Offset = "0xA578CC0", VA = "0x18A5798C0")]
		internal VertexMaterialDelta([In] VertexColor1Texture3 rootVal, [In] VertexColor1Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA579D90", Offset = "0xA579190", VA = "0x18A579D90")]
		internal VertexMaterialDelta([In] VertexColor1Texture4 rootVal, [In] VertexColor1Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA57AF40", Offset = "0xA57A340", VA = "0x18A57AF40")]
		internal VertexMaterialDelta([In] VertexColor2 rootVal, [In] VertexColor2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA57AD90", Offset = "0xA57A190", VA = "0x18A57AD90")]
		internal VertexMaterialDelta([In] VertexColor2Texture1 rootVal, [In] VertexColor2Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA57B2E0", Offset = "0xA57A6E0", VA = "0x18A57B2E0")]
		internal VertexMaterialDelta([In] VertexColor2Texture2 rootVal, [In] VertexColor2Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA57A600", Offset = "0xA579A00", VA = "0x18A57A600")]
		internal VertexMaterialDelta([In] VertexColor2Texture3 rootVal, [In] VertexColor2Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA57B0D0", Offset = "0xA57A4D0", VA = "0x18A57B0D0")]
		internal VertexMaterialDelta([In] VertexColor2Texture4 rootVal, [In] VertexColor2Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA575DB0", Offset = "0xA5751B0", VA = "0x18A575DB0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56DB40", Offset = "0xA56CF40", VA = "0x18A56DB40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA56CDD0", Offset = "0xA56C1D0", VA = "0x18A56CDD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA56D970", Offset = "0xA56CD70", VA = "0x18A56D970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xA56D510", Offset = "0xA56C910", VA = "0x18A56D510", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA56D510", Offset = "0xA56C910", VA = "0x18A56D510", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA57E410", Offset = "0xA57D810", VA = "0x18A57E410")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x8153600", Offset = "0x8152A00", VA = "0x188153600")]
		public VertexTexture3(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA57E490", Offset = "0xA57D890", VA = "0x18A57E490")]
		public VertexTexture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA57E2D0", Offset = "0xA57D6D0", VA = "0x18A57E2D0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA57E190", Offset = "0xA57D590", VA = "0x18A57E190", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA57E0A0", Offset = "0xA57D4A0", VA = "0x18A57E0A0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA57E080", Offset = "0xA57D480", VA = "0x18A57E080", Slot = "13")]
		public readonly bool Equals(VertexTexture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA57E650", Offset = "0xA57DA50", VA = "0x18A57E650")]
		public static bool operator ==([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA57E660", Offset = "0xA57DA60", VA = "0x18A57E660")]
		public static bool operator !=([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA57DFC0", Offset = "0xA57D3C0", VA = "0x18A57DFC0")]
		public static bool AreEqual([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA57E350", Offset = "0xA57D750", VA = "0x18A57E350", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA57DEE0", Offset = "0xA57D2E0", VA = "0x18A57DEE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA57E2B0", Offset = "0xA57D6B0", VA = "0x18A57E2B0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA57E140", Offset = "0xA57D540", VA = "0x18A57E140", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA57E200", Offset = "0xA57D600", VA = "0x18A57E200", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA57E2A0", Offset = "0xA57D6A0", VA = "0x18A57E2A0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EE60", Offset = "0xA56E260", VA = "0x18A56EE60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA56DF40", Offset = "0xA56D340", VA = "0x18A56DF40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA56EDE0", Offset = "0xA56E1E0", VA = "0x18A56EDE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA56E9A0", Offset = "0xA56DDA0", VA = "0x18A56E9A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA56E9A0", Offset = "0xA56DDA0", VA = "0x18A56E9A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA57EC60", Offset = "0xA57E060", VA = "0x18A57EC60")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA57ECE0", Offset = "0xA57E0E0", VA = "0x18A57ECE0")]
		public VertexTexture4(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA57ED00", Offset = "0xA57E100", VA = "0x18A57ED00")]
		public VertexTexture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA57EB30", Offset = "0xA57DF30", VA = "0x18A57EB30", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA57E990", Offset = "0xA57DD90", VA = "0x18A57E990", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA57E880", Offset = "0xA57DC80", VA = "0x18A57E880", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA57E920", Offset = "0xA57DD20", VA = "0x18A57E920", Slot = "13")]
		public readonly bool Equals(VertexTexture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF10", Offset = "0xA57E310", VA = "0x18A57EF10")]
		public static bool operator ==([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF20", Offset = "0xA57E320", VA = "0x18A57EF20")]
		public static bool operator !=([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA57E790", Offset = "0xA57DB90", VA = "0x18A57E790")]
		public static bool AreEqual([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA57EBA0", Offset = "0xA57DFA0", VA = "0x18A57EBA0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA57E680", Offset = "0xA57DA80", VA = "0x18A57E680")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA57EB00", Offset = "0xA57DF00", VA = "0x18A57EB00", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA57E940", Offset = "0xA57DD40", VA = "0x18A57E940", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA57EA30", Offset = "0xA57DE30", VA = "0x18A57EA30", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA57EAF0", Offset = "0xA57DEF0", VA = "0x18A57EAF0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56EF00", Offset = "0xA56E300", VA = "0x18A56EF00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA56E1E0", Offset = "0xA56D5E0", VA = "0x18A56E1E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA56EDA0", Offset = "0xA56E1A0", VA = "0x18A56EDA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xA56EC30", Offset = "0xA56E030", VA = "0x18A56EC30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xA56EC30", Offset = "0xA56E030", VA = "0x18A56EC30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA572510", Offset = "0xA571910", VA = "0x18A572510")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA5725A0", Offset = "0xA5719A0", VA = "0x18A5725A0")]
		public VertexColor1Texture3(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA5725C0", Offset = "0xA5719C0", VA = "0x18A5725C0")]
		public VertexColor1Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA5723D0", Offset = "0xA5717D0", VA = "0x18A5723D0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA572250", Offset = "0xA571650", VA = "0x18A572250", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA572130", Offset = "0xA571530", VA = "0x18A572130", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA572110", Offset = "0xA571510", VA = "0x18A572110", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA572820", Offset = "0xA571C20", VA = "0x18A572820")]
		public static bool operator ==([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA572830", Offset = "0xA571C30", VA = "0x18A572830")]
		public static bool operator !=([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA572010", Offset = "0xA571410", VA = "0x18A572010")]
		public static bool AreEqual([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA572450", Offset = "0xA571850", VA = "0x18A572450", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA571ED0", Offset = "0xA5712D0", VA = "0x18A571ED0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA5712F0", Offset = "0xA5706F0", VA = "0x18A5712F0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA5723B0", Offset = "0xA5717B0", VA = "0x18A5723B0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA5721E0", Offset = "0xA5715E0", VA = "0x18A5721E0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA5722F0", Offset = "0xA5716F0", VA = "0x18A5722F0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA5723A0", Offset = "0xA5717A0", VA = "0x18A5723A0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA570180", Offset = "0xA56F580", VA = "0x18A570180", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xA56F040", Offset = "0xA56E440", VA = "0x18A56F040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xA570010", Offset = "0xA56F410", VA = "0x18A570010", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xA56FD70", Offset = "0xA56F170", VA = "0x18A56FD70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xA56FD70", Offset = "0xA56F170", VA = "0x18A56FD70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA572F50", Offset = "0xA572350", VA = "0x18A572F50")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5732A0", Offset = "0xA5726A0", VA = "0x18A5732A0")]
		public VertexColor1Texture4(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA572FE0", Offset = "0xA5723E0", VA = "0x18A572FE0")]
		public VertexColor1Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA572E10", Offset = "0xA572210", VA = "0x18A572E10", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA572C40", Offset = "0xA572040", VA = "0x18A572C40", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA572B00", Offset = "0xA571F00", VA = "0x18A572B00", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA572BB0", Offset = "0xA571FB0", VA = "0x18A572BB0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5732D0", Offset = "0xA5726D0", VA = "0x18A5732D0")]
		public static bool operator ==([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5732E0", Offset = "0xA5726E0", VA = "0x18A5732E0")]
		public static bool operator !=([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5729D0", Offset = "0xA571DD0", VA = "0x18A5729D0")]
		public static bool AreEqual([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA572E90", Offset = "0xA572290", VA = "0x18A572E90", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA572850", Offset = "0xA571C50", VA = "0x18A572850")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5712F0", Offset = "0xA5706F0", VA = "0x18A5712F0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA572DE0", Offset = "0xA5721E0", VA = "0x18A572DE0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA572BD0", Offset = "0xA571FD0", VA = "0x18A572BD0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA572D00", Offset = "0xA572100", VA = "0x18A572D00", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA572DD0", Offset = "0xA5721D0", VA = "0x18A572DD0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA570130", Offset = "0xA56F530", VA = "0x18A570130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xA56F940", Offset = "0xA56ED40", VA = "0x18A56F940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xA570050", Offset = "0xA56F450", VA = "0x18A570050", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xA56FE20", Offset = "0xA56F220", VA = "0x18A56FE20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xA56FE20", Offset = "0xA56F220", VA = "0x18A56FE20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA575350", Offset = "0xA574750", VA = "0x18A575350")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA575700", Offset = "0xA574B00", VA = "0x18A575700")]
		public VertexColor2Texture3(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5753E0", Offset = "0xA5747E0", VA = "0x18A5753E0")]
		public VertexColor2Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5751F0", Offset = "0xA5745F0", VA = "0x18A5751F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA575060", Offset = "0xA574460", VA = "0x18A575060", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA574F30", Offset = "0xA574330", VA = "0x18A574F30", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA574F10", Offset = "0xA574310", VA = "0x18A574F10", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA575730", Offset = "0xA574B30", VA = "0x18A575730")]
		public static bool operator ==([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA575740", Offset = "0xA574B40", VA = "0x18A575740")]
		public static bool operator !=([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA574DE0", Offset = "0xA5741E0", VA = "0x18A574DE0")]
		public static bool AreEqual([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA575280", Offset = "0xA574680", VA = "0x18A575280", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA574C30", Offset = "0xA574030", VA = "0x18A574C30")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5751D0", Offset = "0xA5745D0", VA = "0x18A5751D0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xA574FE0", Offset = "0xA5743E0", VA = "0x18A574FE0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA575110", Offset = "0xA574510", VA = "0x18A575110", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5751C0", Offset = "0xA5745C0", VA = "0x18A5751C0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5706D0", Offset = "0xA56FAD0", VA = "0x18A5706D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5701D0", Offset = "0xA56F5D0", VA = "0x18A5701D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA570690", Offset = "0xA56FA90", VA = "0x18A570690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xA5705D0", Offset = "0xA56F9D0", VA = "0x18A5705D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5705D0", Offset = "0xA56F9D0", VA = "0x18A5705D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA575F50", Offset = "0xA575350", VA = "0x18A575F50")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x82CCA80", Offset = "0x82CBE80", VA = "0x1882CCA80")]
		public VertexColor2Texture4(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA575FE0", Offset = "0xA5753E0", VA = "0x18A575FE0")]
		public VertexColor2Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA575DF0", Offset = "0xA5751F0", VA = "0x18A575DF0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA575C00", Offset = "0xA575000", VA = "0x18A575C00", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA575AB0", Offset = "0xA574EB0", VA = "0x18A575AB0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA575B60", Offset = "0xA574F60", VA = "0x18A575B60", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA576350", Offset = "0xA575750", VA = "0x18A576350")]
		public static bool operator ==([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA576360", Offset = "0xA575760", VA = "0x18A576360")]
		public static bool operator !=([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA575950", Offset = "0xA574D50", VA = "0x18A575950")]
		public static bool AreEqual([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA575E80", Offset = "0xA575280", VA = "0x18A575E80", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA575760", Offset = "0xA574B60", VA = "0x18A575760")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA573D80", Offset = "0xA573180", VA = "0x18A573D80", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA575DC0", Offset = "0xA5751C0", VA = "0x18A575DC0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA575B80", Offset = "0xA574F80", VA = "0x18A575B80", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA575CE0", Offset = "0xA5750E0", VA = "0x18A575CE0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA575DB0", Offset = "0xA5751B0", VA = "0x18A575DB0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x84CB690", Offset = "0x84CAA90", VA = "0x1884CB690")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x84CB610", Offset = "0x84CAA10", VA = "0x1884CB610")]
		public void Append(VertexGeometryPreprocessor<TvG> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x84CB510", Offset = "0x84CA910", VA = "0x1884CB510")]
		public void Append(VertexMaterialPreprocessor<TvM> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x84CB590", Offset = "0x84CA990", VA = "0x1884CB590")]
		public void Append(VertexSkinningPreprocessor<TvS> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x84CD5B0", Offset = "0x84CC9B0", VA = "0x1884CD5B0")]
		public void SetValidationPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x84CCA20", Offset = "0x84CBE20", VA = "0x1884CCA20")]
		public void SetSanitizerPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD00", Offset = "0x84CB100", VA = "0x1884CBD00")]
		public bool PreprocessVertex(VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x84CD800", Offset = "0x84CCC00", VA = "0x1884CD800")]
		public VertexPreprocessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class VertexPreprocessorLambdas
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x40CE440", Offset = "0x40CD840", VA = "0x1840CE440")]
		public static TvG? ValidateVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x40D0AD0", Offset = "0x40CFED0", VA = "0x1840D0AD0")]
		public static TvM? ValidateVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x40D47B0", Offset = "0x40D3BB0", VA = "0x1840D47B0")]
		public static TvS? ValidateVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x40C9550", Offset = "0x40C8950", VA = "0x1840C9550")]
		public static TvG? SanitizeVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x40CB770", Offset = "0x40CAB70", VA = "0x1840CB770")]
		public static TvM? SanitizeVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x40CDA10", Offset = "0x40CCE10", VA = "0x1840CDA10")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA56DAF0", Offset = "0xA56CEF0", VA = "0x18A56DAF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xA56CFE0", Offset = "0xA56C3E0", VA = "0x18A56CFE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xA56D8F0", Offset = "0xA56CCF0", VA = "0x18A56D8F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xA56D650", Offset = "0xA56CA50", VA = "0x18A56D650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xA56D650", Offset = "0xA56CA50", VA = "0x18A56D650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD63AE0", Offset = "0xD62EE0", VA = "0x180D63AE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576FA0", Offset = "0xA5763A0", VA = "0x18A576FA0", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA578220", Offset = "0xA577620", VA = "0x18A578220")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA578470", Offset = "0xA577870", VA = "0x18A578470")]
		public VertexJoints4(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA5784D0", Offset = "0xA5778D0", VA = "0x18A5784D0")]
		public VertexJoints4(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA5782A0", Offset = "0xA5776A0", VA = "0x18A5782A0")]
		public VertexJoints4([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA5781B0", Offset = "0xA5775B0", VA = "0x18A5781B0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA5734F0", Offset = "0xA5728F0", VA = "0x18A5734F0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA577EC0", Offset = "0xA5772C0", VA = "0x18A577EC0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA577EA0", Offset = "0xA5772A0", VA = "0x18A577EA0", Slot = "14")]
		public readonly bool Equals(VertexJoints4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA578540", Offset = "0xA577940", VA = "0x18A578540")]
		public static bool operator ==([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA578550", Offset = "0xA577950", VA = "0x18A578550")]
		public static bool operator !=([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA577E30", Offset = "0xA577230", VA = "0x18A577E30")]
		public static bool AreEqual([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA578090", Offset = "0xA577490", VA = "0x18A578090", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA578170", Offset = "0xA577570", VA = "0x18A578170")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA5780E0", Offset = "0xA5774E0", VA = "0x18A5780E0", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA577FB0", Offset = "0xA5773B0", VA = "0x18A577FB0", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA578170", Offset = "0xA577570", VA = "0x18A578170", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5700E0", Offset = "0xA56F4E0", VA = "0x18A5700E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xA56F670", Offset = "0xA56EA70", VA = "0x18A56F670", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xA56FFD0", Offset = "0xA56F3D0", VA = "0x18A56FFD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xA56FCB0", Offset = "0xA56F0B0", VA = "0x18A56FCB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xA56FCB0", Offset = "0xA56F0B0", VA = "0x18A56FCB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF32050", Offset = "0xF31450", VA = "0x180F32050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE4720", Offset = "0xEE3B20", VA = "0x180EE4720", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xF5A7F0", Offset = "0xF59BF0", VA = "0x180F5A7F0", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA578AD0", Offset = "0xA577ED0", VA = "0x18A578AD0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA578EF0", Offset = "0xA5782F0", VA = "0x18A578EF0")]
		public VertexJoints8(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA578F70", Offset = "0xA578370", VA = "0x18A578F70")]
		public VertexJoints8(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA578B60", Offset = "0xA577F60", VA = "0x18A578B60")]
		public VertexJoints8([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA578A40", Offset = "0xA577E40", VA = "0x18A578A40", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA5734F0", Offset = "0xA5728F0", VA = "0x18A5734F0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA578660", Offset = "0xA577A60", VA = "0x18A578660", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA578640", Offset = "0xA577A40", VA = "0x18A578640", Slot = "14")]
		public readonly bool Equals(VertexJoints8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA578FE0", Offset = "0xA5783E0", VA = "0x18A578FE0")]
		public static bool operator ==([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA578FF0", Offset = "0xA5783F0", VA = "0x18A578FF0")]
		public static bool operator !=([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA578570", Offset = "0xA577970", VA = "0x18A578570")]
		public static bool AreEqual([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA5788D0", Offset = "0xA577CD0", VA = "0x18A5788D0", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA578930", Offset = "0xA577D30", VA = "0x18A578930")]
		public void SetBindings([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA578990", Offset = "0xA577D90", VA = "0x18A578990", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA578710", Offset = "0xA577B10", VA = "0x18A578710", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA578930", Offset = "0xA577D30", VA = "0x18A578930", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E4A50", Offset = "0x40E3E50", VA = "0x1840E4A50")]
		public static MemoryAccessor CreateVertexMemoryAccessor<TVertex>(this IReadOnlyList<TVertex> vertices, string attributeName, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x40E55E0", Offset = "0x40E49E0", VA = "0x1840E55E0")]
		public static MemoryAccessor[] CreateVertexMemoryAccessors<TVertex>(this IReadOnlyList<TVertex> vertices, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x40E6C70", Offset = "0x40E6070", VA = "0x1840E6C70")]
		private static void FillAccessor<TVertex>(this MemoryAccessor dstAccessor, IReadOnlyList<TVertex> srcVertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF40", Offset = "0xA57E340", VA = "0x18A57EF40")]
		public static MemoryAccessor CreateIndexMemoryAccessor(this IReadOnlyList<int> indices, EncodingType indexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA57F230", Offset = "0xA57E630", VA = "0x18A57F230")]
		public static MemoryAccessInfo[] GetVertexAttributes(this IVertexBuilder firstVertex, int vertexCount, PackedEncoding vertexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA58A380", Offset = "0xA589780", VA = "0x18A58A380")]
		private static Converter<IVertexBuilder, object> _GetVertexBuilderAttributeFunc(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA58B860", Offset = "0xA58AC60", VA = "0x18A58B860")]
		private static object _GetVertexBuilderCustomAttributeFunc(IVertexMaterial vertex, string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x40E8CE0", Offset = "0x40E80E0", VA = "0x1840E8CE0")]
		private static TColumn[] _GetColumn<TColumn, TVertex>(this IReadOnlyList<TVertex> vertices, Converter<IVertexBuilder, object> func) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA589420", Offset = "0xA588820", VA = "0x18A589420")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(params string[] vertexAttributes)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x40DD7C0", Offset = "0x40DCBC0", VA = "0x1840DD7C0")]
		public static TvP ConvertToGeometry<TvP>(this IVertexGeometry src) where TvP : struct, IVertexGeometry
		{
			return (TvP)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x40E0220", Offset = "0x40DF620", VA = "0x1840E0220")]
		public static TvM ConvertToMaterial<TvM>(this IVertexMaterial src) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x40E3DC0", Offset = "0x40E31C0", VA = "0x1840E3DC0")]
		public static TvS ConvertToSkinning<TvS>(this IVertexSkinning src) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA57FFF0", Offset = "0xA57F3F0", VA = "0x18A57FFF0")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA589A90", Offset = "0xA588E90", VA = "0x18A589A90")]
		public static string _GetDebuggerDisplay(IVertexGeometry geo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA589D90", Offset = "0xA589190", VA = "0x18A589D90")]
		public static string _GetDebuggerDisplay(IVertexMaterial mat)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA58A140", Offset = "0xA589540", VA = "0x18A58A140")]
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
			[Cpp2IlInjected.Address(RVA = "0x5138400", Offset = "0x5137800", VA = "0x185138400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x5138250", Offset = "0x5137650", VA = "0x185138250")]
		public _CurveBuilderDebugProxy(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x5137390", Offset = "0x5136790", VA = "0x185137390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA593110", Offset = "0xA592510", VA = "0x18A593110")]
		public _CurveBuilderDebugProxyBoolean(CurveBuilder<bool> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA5930D0", Offset = "0xA5924D0", VA = "0x18A5930D0", Slot = "4")]
		protected override bool GetTangent(bool a, bool b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal sealed class _CurveBuilderDebugProxyVector3 : _CurveBuilderDebugProxy<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA593270", Offset = "0xA592670", VA = "0x18A593270")]
		public _CurveBuilderDebugProxyVector3(CurveBuilder<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA593200", Offset = "0xA592600", VA = "0x18A593200", Slot = "4")]
		protected override Vector3 GetTangent(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	internal sealed class _CurveBuilderDebugProxyQuaternion : _CurveBuilderDebugProxy<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA593160", Offset = "0xA592560", VA = "0x18A593160")]
		public _CurveBuilderDebugProxyQuaternion(CurveBuilder<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA58C590", Offset = "0xA58B990", VA = "0x18A58C590", Slot = "4")]
		protected override Quaternion GetTangent(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	internal sealed class _CurveBuilderDebugProxySparse : _CurveBuilderDebugProxy<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA5931B0", Offset = "0xA5925B0", VA = "0x18A5931B0")]
		public _CurveBuilderDebugProxySparse(CurveBuilder<SparseWeight8> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA58D220", Offset = "0xA58C620", VA = "0x18A58D220", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6626680", Offset = "0x6625A80", VA = "0x186626680", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xFF78B0", Offset = "0xFF6CB0", VA = "0x180FF78B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xFF78B0", Offset = "0xFF6CB0", VA = "0x180FF78B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B3BE30", Offset = "0x5B3B230", VA = "0x185B3BE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public TValue this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BF50", Offset = "0x5B3B350", VA = "0x185B3BF50", Slot = "6")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BF90", Offset = "0x5B3B390", VA = "0x185B3BF90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<TValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BFD0", Offset = "0x5B3B3D0", VA = "0x185B3BFD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x56B26D0", Offset = "0x56B1AD0", VA = "0x1856B26D0")]
		static EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BDF0", Offset = "0x5B3B1F0", VA = "0x185B3BDF0", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BCD0", Offset = "0x5B3B0D0", VA = "0x185B3BCD0", Slot = "10")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<GetEnumerator>d__15))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BD90", Offset = "0x5B3B190", VA = "0x185B3BD90", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E992B0", Offset = "0x4E986B0", VA = "0x184E992B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64B5350", Offset = "0x64B4750", VA = "0x1864B5350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x4E974F0", Offset = "0x4E968F0", VA = "0x184E974F0")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x6681000", Offset = "0x6680400", VA = "0x186681000", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x6680C50", Offset = "0x6680050", VA = "0x186680C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6276A50", Offset = "0x6275E50", VA = "0x186276A50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6276A50", Offset = "0x6275E50", VA = "0x186276A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x4E974F0", Offset = "0x4E968F0", VA = "0x184E974F0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x6681000", Offset = "0x6680400", VA = "0x186681000", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x6EEA560", Offset = "0x6EE9960", VA = "0x186EEA560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x7CDC8E0", Offset = "0x7CDBCE0", VA = "0x187CDC8E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7CDCB40", Offset = "0x7CDBF40", VA = "0x187CDCB40")]
		public static implicit operator Triple<T>([In] (T A, T B, T C) triple)
		{
			return default(Triple<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC6C0", Offset = "0x7CDBAC0", VA = "0x187CDC6C0")]
		public Triple(T a, T b, T c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBEC0", Offset = "0x7CDB2C0", VA = "0x187CDBEC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBC30", Offset = "0x7CDB030", VA = "0x187CDBC30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7CDB620", Offset = "0x7CDAA20", VA = "0x187CDB620", Slot = "8")]
		public bool Equals(Triple<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7CDCA60", Offset = "0x7CDBE60", VA = "0x187CDCA60")]
		public static bool operator ==([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x7CDCE70", Offset = "0x7CDC270", VA = "0x187CDCE70")]
		public static bool operator !=([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x7CDBD60", Offset = "0x7CDB160", VA = "0x187CDBD60", Slot = "6")]
		[IteratorStateMachine(typeof(Triple<>.<GetEnumerator>d__14))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7CDC560", Offset = "0x7CDB960", VA = "0x187CDC560", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0x514A540", Offset = "0x5149940", VA = "0x18514A540", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A60")]
				[Cpp2IlInjected.Address(RVA = "0x51497E0", Offset = "0x5148BE0", VA = "0x1851497E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x514A120", Offset = "0x5149520", VA = "0x18514A120")]
			internal _ValueEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x5147EE0", Offset = "0x51472E0", VA = "0x185147EE0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x51490E0", Offset = "0x51484E0", VA = "0x1851490E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public _IndexCollection(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x513C1B0", Offset = "0x513B5B0", VA = "0x18513C1B0", Slot = "4")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x513C1B0", Offset = "0x513B5B0", VA = "0x18513C1B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A69")]
				[Cpp2IlInjected.Address(RVA = "0x241BF30", Offset = "0x241B330", VA = "0x18241BF30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x513DDA0", Offset = "0x513D1A0", VA = "0x18513DDA0")]
			internal _IndexEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x513D020", Offset = "0x513C420", VA = "0x18513D020", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x513DD20", Offset = "0x513D120", VA = "0x18513DD20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x7F15220", Offset = "0x7F14620", VA = "0x187F15220", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public IEnumerable<int> Indices
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x7F14180", Offset = "0x7F13580", VA = "0x187F14180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x7F132E0", Offset = "0x7F126E0", VA = "0x187F132E0")]
		public ValueListSet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x7F12480", Offset = "0x7F11880", VA = "0x187F12480")]
		public ValueListSet(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x7F00C30", Offset = "0x7F00030", VA = "0x187F00C30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x7F06D20", Offset = "0x7F06120", VA = "0x187F06D20")]
		public bool Exists(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x7F079B0", Offset = "0x7F06DB0", VA = "0x187F079B0")]
		public int IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x7F07D30", Offset = "0x7F07130", VA = "0x187F07D30")]
		public int Use([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x7EFEB80", Offset = "0x7EFDF80", VA = "0x187EFEB80")]
		public int Add([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x7F01690", Offset = "0x7F00A90", VA = "0x187F01690")]
		public bool Contains([In] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x7F05970", Offset = "0x7F04D70", VA = "0x187F05970")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x7F038F0", Offset = "0x7F02CF0", VA = "0x187F038F0")]
		public void CopyTo(ValueListSet<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x7F076F0", Offset = "0x7F06AF0", VA = "0x187F076F0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x7F076F0", Offset = "0x7F06AF0", VA = "0x187F076F0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF470", Offset = "0x7EFE870", VA = "0x187EFF470")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C310", Offset = "0x7F0B710", VA = "0x187F0C310")]
		private void _Initialize(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7F09D70", Offset = "0x7F09170", VA = "0x187F09D70")]
		private int _IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0EE50", Offset = "0x7F0E250", VA = "0x187F0EE50")]
		private int _Insert([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x7F08440", Offset = "0x7F07840", VA = "0x187F08440")]
		private void _Grow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0FCA0", Offset = "0x7F0F0A0", VA = "0x187F0FCA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x513E670", Offset = "0x513DA70", VA = "0x18513E670")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x513E720", Offset = "0x513DB20", VA = "0x18513E720")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x513E600", Offset = "0x513DA00", VA = "0x18513E600")]
			public _KeyComparer(IReadOnlyList<T> items)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x513E0E0", Offset = "0x513D4E0", VA = "0x18513E0E0", Slot = "4")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x513E3F0", Offset = "0x513D7F0", VA = "0x18513E3F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x84CA4E0", Offset = "0x84C98E0", VA = "0x1884CA4E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0x84CA4A0", Offset = "0x84C98A0", VA = "0x1884CA4A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x84CA360", Offset = "0x84C9760", VA = "0x1884CA360")]
		public VertexList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x84C9DE0", Offset = "0x84C91E0", VA = "0x1884C9DE0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x84C9DE0", Offset = "0x84C91E0", VA = "0x1884C9DE0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x84CA060", Offset = "0x84C9460", VA = "0x1884CA060")]
		public int Use([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x84C9E90", Offset = "0x84C9290", VA = "0x1884C9E90")]
		public int IndexOf([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x84CA0D0", Offset = "0x84C94D0", VA = "0x1884CA0D0")]
		private int _Add([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x84C9B80", Offset = "0x84C8F80", VA = "0x1884C9B80")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x84C9DA0", Offset = "0x84C91A0", VA = "0x1884C9DA0")]
		public void CopyTo(VertexList<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x84CA200", Offset = "0x84C9600", VA = "0x1884CA200")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5935C0", Offset = "0xA5929C0", VA = "0x18A5935C0")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA5933B0", Offset = "0xA5927B0", VA = "0x18A5933B0")]
		public static int GetPrime(int min)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA593340", Offset = "0xA592740", VA = "0x18A593340")]
		public static int GetMinPrime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA5932C0", Offset = "0xA5926C0", VA = "0x18A5932C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xF668E0", Offset = "0xF65CE0", VA = "0x180F668E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x74249F0", Offset = "0x7423DF0", VA = "0x1874249F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public IReadOnlyDictionary<string, ICurveSampler<T>> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x7424BD0", Offset = "0x7423FD0", VA = "0x187424BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		internal AnimatableProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x7424750", Offset = "0x7423B50", VA = "0x187424750")]
		internal AnimatableProperty(AnimatableProperty<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x741AAF0", Offset = "0x7419EF0", VA = "0x18741AAF0")]
		public AnimatableProperty<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x741BB40", Offset = "0x741AF40", VA = "0x18741BB40")]
		public void RemoveTrack(string track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x741ADE0", Offset = "0x741A1E0", VA = "0x18741ADE0")]
		public T GetValueAt(string track, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x741E620", Offset = "0x741DA20", VA = "0x18741E620")]
		public void SetTrack(string track, ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x741FA70", Offset = "0x741EE70", VA = "0x18741FA70")]
		public CurveBuilder<T> UseTrackBuilder(string track)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x741F160", Offset = "0x741E560", VA = "0x18741F160")]
		public void SetValue(params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x7420070", Offset = "0x741F470", VA = "0x187420070")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x531A2D0", Offset = "0x53196D0", VA = "0x18531A2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x531A300", Offset = "0x5319700", VA = "0x18531A300", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x5319FA0", Offset = "0x53193A0", VA = "0x185319FA0")]
		protected CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x5319C50", Offset = "0x5319050", VA = "0x185319C50")]
		protected CurveBuilder(CurveBuilder<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5313900", Offset = "0x5312D00", VA = "0x185313900")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x5313CD0", Offset = "0x53130D0", VA = "0x185313CD0")]
		public void RemoveKey(float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x5316EF0", Offset = "0x53162F0", VA = "0x185316EF0")]
		public void SetPoint(float offset, bool isLinear, params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x5316CD0", Offset = "0x53160D0", VA = "0x185316CD0")]
		public void SetPoint(float offset, T value, bool isLinear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x5315E70", Offset = "0x5315270", VA = "0x185315E70")]
		public void SetIncomingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x5316710", Offset = "0x5315B10", VA = "0x185316710")]
		public void SetOutgoingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x5313930", Offset = "0x5312D30", VA = "0x185313930")]
		private protected (_CurveNode<T>, _CurveNode<T>, float) FindSample(float offset)
		{
			return default((_CurveNode<T>, _CurveNode<T>, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x5314510", Offset = "0x5313910", VA = "0x185314510")]
		public void SetCurve(ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x5313D30", Offset = "0x5313130", VA = "0x185313D30")]
		public void SetCurve(IConvertibleCurve<T> convertible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x5314E80", Offset = "0x5314280", VA = "0x185314E80")]
		public void SetCurve(IAnimationSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x5319AE0", Offset = "0x5318EE0", VA = "0x185319AE0")]
		public CurveBuilder<T> WithPoint(float offset, T value, bool isLinear = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x5319830", Offset = "0x5318C30", VA = "0x185319830")]
		public CurveBuilder<T> WithIncomingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x53199E0", Offset = "0x5318DE0", VA = "0x1853199E0")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x5319A50", Offset = "0x5318E50", VA = "0x185319A50")]
		public CurveBuilder<T> WithPoint(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x5319960", Offset = "0x5318D60", VA = "0x185319960")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x5319870", Offset = "0x5318C70", VA = "0x185319870")]
		public CurveBuilder<T> WithIncomingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x5319440", Offset = "0x5318840", VA = "0x185319440", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x5316FA0", Offset = "0x53163A0", VA = "0x185316FA0", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x5317F60", Offset = "0x5317360", VA = "0x185317F60", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x51399B0", Offset = "0x5138DB0", VA = "0x1851399B0")]
		private string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x513B750", Offset = "0x513AB50", VA = "0x18513B750")]
		private static string _ToString(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x513BE90", Offset = "0x513B290", VA = "0x18513BE90")]
		public _CurveNode(T value, bool isLinear)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x513BB50", Offset = "0x513AF50", VA = "0x18513BB50")]
		public _CurveNode(T incoming, T value, T outgoing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x5138580", Offset = "0x5137980", VA = "0x185138580")]
		public _CurveNode<T> Clone(Func<T, T> cloneValue)
		{
			return default(_CurveNode<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal static class CurveFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x38AEAE0", Offset = "0x38ADEE0", VA = "0x1838AEAE0")]
		public static CurveBuilder<T> CreateCurveBuilder<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x38AEF40", Offset = "0x38AE340", VA = "0x1838AEF40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58C120", Offset = "0xA58B520", VA = "0x18A58C120")]
		public BooleanCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0xA58C160", Offset = "0xA58B560", VA = "0x18A58C160")]
		private BooleanCurveBuilder(BooleanCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA58BE80", Offset = "0xA58B280", VA = "0x18A58BE80", Slot = "10")]
		public override CurveBuilder<bool> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xA2C9670", Offset = "0xA2C8A70", VA = "0x18A2C9670", Slot = "11")]
		protected override bool AreEqual(bool left, bool right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x140F500", Offset = "0x140E900", VA = "0x18140F500", Slot = "12")]
		protected override bool CloneValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0xA58BF00", Offset = "0xA58B300", VA = "0x18A58BF00", Slot = "13")]
		protected override bool CreateValue(IReadOnlyList<float> values)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0xA58C0E0", Offset = "0xA58B4E0", VA = "0x18A58C0E0", Slot = "15")]
		protected override bool GetTangent(bool fromValue, bool toValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0xA58C020", Offset = "0xA58B420", VA = "0x18A58C020", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA593090", Offset = "0xA592490", VA = "0x18A593090")]
		public Vector3CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0xA593040", Offset = "0xA592440", VA = "0x18A593040")]
		private Vector3CurveBuilder(Vector3CurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA592C20", Offset = "0xA592020", VA = "0x18A592C20", Slot = "10")]
		public override CurveBuilder<Vector3> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA592BD0", Offset = "0xA591FD0", VA = "0x18A592BD0", Slot = "11")]
		protected override bool AreEqual(Vector3 left, Vector3 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1068160", Offset = "0x1067560", VA = "0x181068160", Slot = "12")]
		protected override Vector3 CloneValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xA592CA0", Offset = "0xA5920A0", VA = "0x18A592CA0", Slot = "13")]
		protected override Vector3 CreateValue(IReadOnlyList<float> values)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA592FD0", Offset = "0xA5923D0", VA = "0x18A592FD0", Slot = "15")]
		protected override Vector3 GetTangent(Vector3 fromValue, Vector3 toValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA592E20", Offset = "0xA592220", VA = "0x18A592E20", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58C5E0", Offset = "0xA58B9E0", VA = "0x18A58C5E0")]
		public QuaternionCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0xA58C620", Offset = "0xA58BA20", VA = "0x18A58C620")]
		private QuaternionCurveBuilder(QuaternionCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xA58C1E0", Offset = "0xA58B5E0", VA = "0x18A58C1E0", Slot = "10")]
		public override CurveBuilder<Quaternion> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA58C1B0", Offset = "0xA58B5B0", VA = "0x18A58C1B0", Slot = "11")]
		protected override bool AreEqual(Quaternion left, Quaternion right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x12BDAE0", Offset = "0x12BCEE0", VA = "0x1812BDAE0", Slot = "12")]
		protected override Quaternion CloneValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA58C260", Offset = "0xA58B660", VA = "0x18A58C260", Slot = "13")]
		protected override Quaternion CreateValue(IReadOnlyList<float> values)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA58C590", Offset = "0xA58B990", VA = "0x18A58C590", Slot = "15")]
		protected override Quaternion GetTangent(Quaternion fromValue, Quaternion toValue)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA58C410", Offset = "0xA58B810", VA = "0x18A58C410", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58D2B0", Offset = "0xA58C6B0", VA = "0x18A58D2B0")]
		public SparseCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA58D260", Offset = "0xA58C660", VA = "0x18A58D260")]
		private SparseCurveBuilder(SparseCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0xA58CF50", Offset = "0xA58C350", VA = "0x18A58CF50", Slot = "10")]
		public override CurveBuilder<SparseWeight8> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0xA58CF10", Offset = "0xA58C310", VA = "0x18A58CF10", Slot = "11")]
		protected override bool AreEqual(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x56A6C50", Offset = "0x56A6050", VA = "0x1856A6C50", Slot = "12")]
		protected override SparseWeight8 CloneValue(SparseWeight8 value)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0xA58CFD0", Offset = "0xA58C3D0", VA = "0x18A58CFD0", Slot = "13")]
		protected override SparseWeight8 CreateValue(IReadOnlyList<float> values)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xA58D220", Offset = "0xA58C620", VA = "0x18A58D220", Slot = "15")]
		protected override SparseWeight8 GetTangent(SparseWeight8 fromValue, SparseWeight8 toValue)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0xA58D010", Offset = "0xA58C410", VA = "0x18A58D010", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58CED0", Offset = "0xA58C2D0", VA = "0x18A58CED0")]
		public SegmentCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0xA58CE80", Offset = "0xA58C280", VA = "0x18A58CE80")]
		private SegmentCurveBuilder(SegmentCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0xA58C9C0", Offset = "0xA58BDC0", VA = "0x18A58C9C0", Slot = "10")]
		public override CurveBuilder<ArraySegment<float>> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0xA58C670", Offset = "0xA58BA70", VA = "0x18A58C670", Slot = "11")]
		protected override bool AreEqual(ArraySegment<float> left, ArraySegment<float> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0xA58C8B0", Offset = "0xA58BCB0", VA = "0x18A58C8B0", Slot = "12")]
		protected override ArraySegment<float> CloneValue(ArraySegment<float> value)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0xA58CA40", Offset = "0xA58BE40", VA = "0x18A58CA40", Slot = "13")]
		protected override ArraySegment<float> CreateValue(IReadOnlyList<float> values)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0xA58CDD0", Offset = "0xA58C1D0", VA = "0x18A58CDD0", Slot = "15")]
		protected override ArraySegment<float> GetTangent(ArraySegment<float> fromValue, ArraySegment<float> toValue)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xA58CB80", Offset = "0xA58BF80", VA = "0x18A58CB80", Slot = "14")]
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

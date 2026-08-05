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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA75FBB0", Offset = "0xA75E5B0", VA = "0x18A75FBB0")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA75EB80", Offset = "0xA75D580", VA = "0x18A75EB80")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA75EDF0", Offset = "0xA75D7F0", VA = "0x18A75EDF0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA75F040", Offset = "0xA75DA40", VA = "0x18A75F040")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA75EAE0", Offset = "0xA75D4E0", VA = "0x18A75EAE0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA75F830", Offset = "0xA75E230", VA = "0x18A75F830")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA75F710", Offset = "0xA75E110", VA = "0x18A75F710")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA75FD00", Offset = "0xA75E700", VA = "0x18A75FD00")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA75FCA0", Offset = "0xA75E6A0", VA = "0x18A75FCA0")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA75F550", Offset = "0xA75DF50", VA = "0x18A75F550")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B19960", Offset = "0x3B18360", VA = "0x183B19960")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B182B0", Offset = "0x3B16CB0", VA = "0x183B182B0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA75F5B0", Offset = "0xA75DFB0", VA = "0x18A75F5B0")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B19400", Offset = "0x3B17E00", VA = "0x183B19400")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B18FA0", Offset = "0x3B179A0", VA = "0x183B18FA0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B18B60", Offset = "0x3B17560", VA = "0x183B18B60")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B18860", Offset = "0x3B17260", VA = "0x183B18860")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B17B60", Offset = "0x3B16560", VA = "0x183B17B60")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA75F140", Offset = "0xA75DB40", VA = "0x18A75F140")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA75F0E0", Offset = "0xA75DAE0", VA = "0x18A75F0E0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA75F1A0", Offset = "0xA75DBA0", VA = "0x18A75F1A0")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA75FA50", Offset = "0xA75E450", VA = "0x18A75FA50")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA75F950", Offset = "0xA75E350", VA = "0x18A75F950")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B16850", Offset = "0x3B15250", VA = "0x183B16850")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA75E850", Offset = "0xA75D250", VA = "0x18A75E850")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B156E0", Offset = "0x3B140E0", VA = "0x183B156E0")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B156E0", Offset = "0x3B140E0", VA = "0x183B156E0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B156E0", Offset = "0x3B140E0", VA = "0x183B156E0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B156E0", Offset = "0x3B140E0", VA = "0x183B156E0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B156E0", Offset = "0x3B140E0", VA = "0x183B156E0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B14A80", Offset = "0x3B13480", VA = "0x183B14A80")]
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
					[Cpp2IlInjected.Address(RVA = "0x50B2FF0", Offset = "0x50B19F0", VA = "0x1850B2FF0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x50B3960", Offset = "0x50B2360", VA = "0x1850B3960", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4F519B0", Offset = "0x4F503B0", VA = "0x184F519B0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x67531F0", Offset = "0x6751BF0", VA = "0x1867531F0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x6753EF0", Offset = "0x67528F0", VA = "0x186753EF0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6758DA0", Offset = "0x67577A0", VA = "0x186758DA0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6EF9770", Offset = "0x6EF8170", VA = "0x186EF9770", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6EFEB50", Offset = "0x6EFD550", VA = "0x186EFEB50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F02F40", Offset = "0x6F01940", VA = "0x186F02F40")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5175C50", Offset = "0x5174650", VA = "0x185175C50", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x5175BF0", Offset = "0x51745F0", VA = "0x185175BF0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5175930", Offset = "0x5174330", VA = "0x185175930", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5175A60", Offset = "0x5174460", VA = "0x185175A60", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x50B2FF0", Offset = "0x50B19F0", VA = "0x1850B2FF0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x50B3960", Offset = "0x50B2360", VA = "0x1850B3960", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x4F519B0", Offset = "0x4F503B0", VA = "0x184F519B0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x67531F0", Offset = "0x6751BF0", VA = "0x1867531F0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6752840", Offset = "0x6751240", VA = "0x186752840", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x67537D0", Offset = "0x67521D0", VA = "0x1867537D0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6EF9770", Offset = "0x6EF8170", VA = "0x186EF9770", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6EF8580", Offset = "0x6EF6F80", VA = "0x186EF8580", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6EF9CA0", Offset = "0x6EF86A0", VA = "0x186EF9CA0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x516C920", Offset = "0x516B320", VA = "0x18516C920", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x516C660", Offset = "0x516B060", VA = "0x18516C660", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x516C840", Offset = "0x516B240", VA = "0x18516C840", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x141CB20", Offset = "0x141B520", VA = "0x18141CB20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA766A30", Offset = "0xA765430", VA = "0x18A766A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6570BD0", Offset = "0x656F5D0", VA = "0x186570BD0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA766A80", Offset = "0xA765480", VA = "0x18A766A80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA7666E0", Offset = "0xA7650E0", VA = "0x18A7666E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA766B40", Offset = "0xA765540", VA = "0x18A766B40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA7669F0", Offset = "0xA7653F0", VA = "0x18A7669F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA766940", Offset = "0xA765340", VA = "0x18A766940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA766940", Offset = "0xA765340", VA = "0x18A766940", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A4AEC0", Offset = "0x1A498C0", VA = "0x181A4AEC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA767520", Offset = "0xA765F20", VA = "0x18A767520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA767570", Offset = "0xA765F70", VA = "0x18A767570", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA766B90", Offset = "0xA765590", VA = "0x18A766B90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA767760", Offset = "0xA766160", VA = "0x18A767760")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA7677B0", Offset = "0xA7661B0", VA = "0x18A7677B0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA767800", Offset = "0xA766200", VA = "0x18A767800")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA7674E0", Offset = "0xA765EE0", VA = "0x18A7674E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA767430", Offset = "0xA765E30", VA = "0x18A767430", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA767430", Offset = "0xA765E30", VA = "0x18A767430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6B5E30", Offset = "0xA6B4830", VA = "0x18A6B5E30")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7820", Offset = "0xA6B6220", VA = "0x18A6B7820")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7950", Offset = "0xA6B6350", VA = "0x18A6B7950")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7860", Offset = "0xA6B6260", VA = "0x18A6B7860")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7980", Offset = "0xA6B6380", VA = "0x18A6B7980")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6B78C0", Offset = "0xA6B62C0", VA = "0x18A6B78C0")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6B79F0", Offset = "0xA6B63F0", VA = "0x18A6B79F0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6B78C0", Offset = "0xA6B62C0", VA = "0x18A6B78C0")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7750", Offset = "0xA6B6150", VA = "0x18A6B7750")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA768DD0", Offset = "0xA7677D0", VA = "0x18A768DD0")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA768CB0", Offset = "0xA7676B0", VA = "0x18A768CB0")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6B51D0", Offset = "0xA6B3BD0", VA = "0x18A6B51D0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA769680", Offset = "0xA768080", VA = "0x18A769680")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6B5DE0", Offset = "0xA6B47E0", VA = "0x18A6B5DE0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6B5D80", Offset = "0xA6B4780", VA = "0x18A6B5D80")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6B6060", Offset = "0xA6B4A60", VA = "0x18A6B6060")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA76A220", Offset = "0xA768C20", VA = "0x18A76A220")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA76A3A0", Offset = "0xA768DA0", VA = "0x18A76A3A0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA768FD0", Offset = "0xA7679D0", VA = "0x18A768FD0")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA768ED0", Offset = "0xA7678D0", VA = "0x18A768ED0")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA7692B0", Offset = "0xA767CB0", VA = "0x18A7692B0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA768B20", Offset = "0xA767520", VA = "0x18A768B20")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA768F50", Offset = "0xA767950", VA = "0x18A768F50")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6B6950", Offset = "0xA6B5350", VA = "0x18A6B6950")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA768F60", Offset = "0xA767960", VA = "0x18A768F60")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6B5B50", Offset = "0xA6B4550", VA = "0x18A6B5B50")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6B5A90", Offset = "0xA6B4490", VA = "0x18A6B5A90")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x418D590", Offset = "0x418BF90", VA = "0x18418D590")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6B5340", Offset = "0xA6B3D40", VA = "0x18A6B5340")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6B54B0", Offset = "0xA6B3EB0", VA = "0x18A6B54B0")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x418E930", Offset = "0x418D330", VA = "0x18418E930")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x418FA50", Offset = "0x418E450", VA = "0x18418FA50")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x418FC20", Offset = "0x418E620", VA = "0x18418FC20")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x418FD00", Offset = "0x418E700", VA = "0x18418FD00")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x418D5B0", Offset = "0x418BFB0", VA = "0x18418D5B0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x418E770", Offset = "0x418D170", VA = "0x18418E770")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x418E660", Offset = "0x418D060", VA = "0x18418E660")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x418DDA0", Offset = "0x418C7A0", VA = "0x18418DDA0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x418F970", Offset = "0x418E370", VA = "0x18418F970")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x418F2E0", Offset = "0x418DCE0", VA = "0x18418F2E0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x418F720", Offset = "0x418E120", VA = "0x18418F720")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x418F480", Offset = "0x418DE80", VA = "0x18418F480")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x418DC50", Offset = "0x418C650", VA = "0x18418DC50")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x418DA00", Offset = "0x418C400", VA = "0x18418DA00")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x418D210", Offset = "0x418BC10", VA = "0x18418D210")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x418D640", Offset = "0x418C040", VA = "0x18418D640")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA7690A0", Offset = "0xA767AA0", VA = "0x18A7690A0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA769410", Offset = "0xA767E10", VA = "0x18A769410")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x418F9D0", Offset = "0x418E3D0", VA = "0x18418F9D0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x418F9D0", Offset = "0x418E3D0", VA = "0x18418F9D0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA769930", Offset = "0xA768330", VA = "0x18A769930")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA768520", Offset = "0xA766F20", VA = "0x18A768520")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA768470", Offset = "0xA766E70", VA = "0x18A768470")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA7698B0", Offset = "0xA7682B0", VA = "0x18A7698B0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA769FF0", Offset = "0xA7689F0", VA = "0x18A769FF0")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA7685A0", Offset = "0xA766FA0", VA = "0x18A7685A0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA769B30", Offset = "0xA768530", VA = "0x18A769B30")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA769C00", Offset = "0xA768600", VA = "0x18A769C00")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA7688C0", Offset = "0xA7672C0", VA = "0x18A7688C0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA768660", Offset = "0xA767060", VA = "0x18A768660")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA768960", Offset = "0xA767360", VA = "0x18A768960")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA7687A0", Offset = "0xA7671A0", VA = "0x18A7687A0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA768AA0", Offset = "0xA7674A0", VA = "0x18A768AA0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x23BD7A0", Offset = "0x23BC1A0", VA = "0x1823BD7A0")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA6B7840", Offset = "0xA6B6240", VA = "0x18A6B7840")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x418FF30", Offset = "0x418E930", VA = "0x18418FF30")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA7697F0", Offset = "0xA7681F0", VA = "0x18A7697F0")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA768820", Offset = "0xA767220", VA = "0x18A768820")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA76A170", Offset = "0xA768B70", VA = "0x18A76A170")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA76A5A0", Offset = "0xA768FA0", VA = "0x18A76A5A0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA76A070", Offset = "0xA768A70", VA = "0x18A76A070")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6B53E0", Offset = "0xA6B3DE0", VA = "0x18A6B53E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD14CD0", Offset = "0xD136D0", VA = "0x180D14CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x73BE210", Offset = "0x73BCC10", VA = "0x1873BE210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73BCFB0", Offset = "0x73BB9B0", VA = "0x1873BCFB0")]
		internal AnimatableProperty(T defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x73B40A0", Offset = "0x73B2AA0", VA = "0x1873B40A0")]
		public T GetValueAt(int trackLogicalIndex, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73B5870", Offset = "0x73B4270", VA = "0x1873B5870")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD68AE0", Offset = "0xD674E0", VA = "0x180D68AE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x10E1E10", Offset = "0x10E0810", VA = "0x1810E1E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA75B930", Offset = "0xA75A330", VA = "0x18A75B930")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NodeInstance> VisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA75C130", Offset = "0xA75AB30", VA = "0x18A75C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<AnimationTrackInfo> AnimationTracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA75BEF0", Offset = "0xA75A8F0", VA = "0x18A75BEF0")]
		internal ArmatureInstance(ArmatureTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA75BA10", Offset = "0xA75A410", VA = "0x18A75BA10")]
		public void SetLocalMatrix(string name, Matrix4x4 localMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA75BBB0", Offset = "0xA75A5B0", VA = "0x18A75BBB0")]
		public void SetModelMatrix(string name, Matrix4x4 modelMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA75BEB0", Offset = "0xA75A8B0", VA = "0x18A75BEB0")]
		public void SetPoseTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA75B9A0", Offset = "0xA75A3A0", VA = "0x18A75B9A0")]
		public void SetAnimationFrame(int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA75B9E0", Offset = "0xA75A3E0", VA = "0x18A75B9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyList<MaterialTemplate> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<AnimationTrackInfo> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA75CF90", Offset = "0xA75B990", VA = "0x18A75CF90")]
		internal static ArmatureTemplate Create(Scene srcScene, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA75DE90", Offset = "0xA75C890", VA = "0x18A75DE90")]
		private ArmatureTemplate(NodeTemplate[] nodes, MaterialTemplate[] materials, AnimationTrackInfo[] animTracks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA75CF60", Offset = "0xA75B960", VA = "0x18A75CF60")]
		internal void ApplyDefaultPoseTo(ArmatureInstance instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA75C250", Offset = "0xA75AC50", VA = "0x18A75C250")]
		internal void ApplyAnimationTo(ArmatureInstance instance, int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA75C620", Offset = "0xA75B020", VA = "0x18A75C620")]
		internal void ApplyAnimationTo(ArmatureInstance instance, (int TrackIdx, float Time, float Weight)[] blended)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA75DC50", Offset = "0xA75C650", VA = "0x18A75DC50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75E780", Offset = "0xA75D180", VA = "0x18A75E780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA75E3F0", Offset = "0xA75CDF0", VA = "0x18A75E3F0")]
		private string _ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x165B970", Offset = "0x165A370", VA = "0x18165B970", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA75E7E0", Offset = "0xA75D1E0", VA = "0x18A75E7E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7650D0", Offset = "0xA763AD0", VA = "0x18A7650D0")]
		internal RigidDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA764F00", Offset = "0xA763900", VA = "0x18A764F00", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA764F50", Offset = "0xA763950", VA = "0x18A764F50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA760110", Offset = "0xA75EB10", VA = "0x18A760110")]
		internal InstancedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA75FEA0", Offset = "0xA75E8A0", VA = "0x18A75FEA0", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA75FF00", Offset = "0xA75E900", VA = "0x18A75FF00", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA766250", Offset = "0xA764C50", VA = "0x18A766250")]
		internal SkinnedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA765FD0", Offset = "0xA7649D0", VA = "0x18A765FD0", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA766020", Offset = "0xA764A20", VA = "0x18A766020", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform skinnedTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class MaterialInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF8B000", Offset = "0xF89A00", VA = "0x180F8B000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA760990", Offset = "0xA75F390", VA = "0x18A760990")]
		internal MaterialTemplate(Material srcMaterial, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3CF70E0", Offset = "0x3CF5AE0", VA = "0x183CF70E0")]
		private void _AddAnimatableProperty<T>(Dictionary<string, AnimatableProperty<T>> dict, int trackIdx, AnimationChannel channel, string pointerPath, T defaultSingle, bool isolateMemory) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA760610", Offset = "0xA75F010", VA = "0x18A760610")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, float> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA760290", Offset = "0xA75EC90", VA = "0x18A760290")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector2> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA7607B0", Offset = "0xA75F1B0", VA = "0x18A7607B0")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector3> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA760440", Offset = "0xA75EE40", VA = "0x18A760440")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A4AEC0", Offset = "0x1A498C0", VA = "0x181A4AEC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x69BEE00", Offset = "0x69BD800", VA = "0x1869BEE00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public <GetWorldVertices>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x69BEE50", Offset = "0x69BD850", VA = "0x1869BEE50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x69BE760", Offset = "0x69BD160", VA = "0x1869BE760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x69BF080", Offset = "0x69BDA80", VA = "0x1869BF080")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x69BF0D0", Offset = "0x69BDAD0", VA = "0x1869BF0D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5114760", Offset = "0x5113160", VA = "0x185114760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x69BED30", Offset = "0x69BD730", VA = "0x1869BED30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA761530", Offset = "0xA75FF30", VA = "0x18A761530")]
		public static IMeshDecoder<Material> Decode(this Mesh mesh, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA7613C0", Offset = "0xA75FDC0", VA = "0x18A7613C0")]
		public static IMeshDecoder<Material>[] Decode(this IReadOnlyList<Mesh> meshes, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA762480", Offset = "0xA760E80", VA = "0x18A762480")]
		public static Vector3 GetPosition(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA762180", Offset = "0xA760B80", VA = "0x18A762180")]
		public static Vector3 GetNormal(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA762780", Offset = "0xA761180", VA = "0x18A762780")]
		public static Vector4 GetTangent(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA762AD0", Offset = "0xA7614D0", VA = "0x18A762AD0")]
		public static Vector2 GetTextureCoord(this IMeshPrimitiveDecoder primitive, int vertexIdx, int textureSetIndex, IGeometryTransform xform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA761E20", Offset = "0xA760820", VA = "0x18A761E20")]
		public static Vector4 GetColor(this IMeshPrimitiveDecoder primitive, int vertexIdx, int colorSetIndex, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA7615E0", Offset = "0xA75FFE0", VA = "0x18A7615E0")]
		public static (Vector3, Vector3) EvaluateBoundingBox(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA761D00", Offset = "0xA760700", VA = "0x18A761D00")]
		public static (Vector3, float) EvaluateBoundingSphere(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA761A10", Offset = "0xA760410", VA = "0x18A761A10")]
		public static (Vector3, float) EvaluateBoundingSphere(this SceneTemplate sceneTemplate, IMeshDecoder<Material>[] decodedMeshes, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3D47630", Offset = "0x3D46030", VA = "0x183D47630")]
		public static (Vector3, Vector3) EvaluateBoundingBox<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3D47A70", Offset = "0x3D46470", VA = "0x183D47A70")]
		public static (Vector3, float) EvaluateBoundingSphere<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA762DE0", Offset = "0xA7617E0", VA = "0x18A762DE0")]
		private static void _AddPointToSphere(Vector3 c1, float r1, Vector3 c2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA7630E0", Offset = "0xA761AE0", VA = "0x18A7630E0")]
		private static void _MergeSphere(Vector3 c1, float r1, Vector3 c2, float r2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D47DC0", Offset = "0x3D467C0", VA = "0x183D47DC0")]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x39C2A20", Offset = "0x39C1420", VA = "0x1839C2A20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x517D970", Offset = "0x517C370", VA = "0x18517D970")]
		public _MeshDecoder(Mesh srcMesh, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x517CE10", Offset = "0x517B810", VA = "0x18517CE10")]
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
			[Cpp2IlInjected.Address(RVA = "0xDE9810", Offset = "0xDE8210", VA = "0x180DE9810", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x517DC30", Offset = "0x517C630", VA = "0x18517DC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76C9D0", Offset = "0xA76B3D0", VA = "0x18A76C9D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED40", Offset = "0xD2D740", VA = "0x180D2ED40", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xE3D3A0", Offset = "0xE3BDA0", VA = "0x180E3D3A0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xD1DD60", Offset = "0xD1C760", VA = "0x180D1DD60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA76C750", Offset = "0xA76B150", VA = "0x18A76C750", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsPointIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA76C4F0", Offset = "0xA76AEF0", VA = "0x18A76C4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA76C510", Offset = "0xA76AF10", VA = "0x18A76C510", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA76C790", Offset = "0xA76B190", VA = "0x18A76C790", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA76B8E0", Offset = "0xA76A2E0", VA = "0x18A76B8E0", Slot = "22")]
		protected virtual string _GetDebugString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA76B9E0", Offset = "0xA76A3E0", VA = "0x18A76B9E0")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA76B380", Offset = "0xA769D80", VA = "0x18A76B380", Slot = "11")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA76B2B0", Offset = "0xA769CB0", VA = "0x18A76B2B0", Slot = "17")]
		public IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA76B220", Offset = "0xA769C20", VA = "0x18A76B220", Slot = "12")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA76B150", Offset = "0xA769B50", VA = "0x18A76B150", Slot = "18")]
		public IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA76B6A0", Offset = "0xA76A0A0", VA = "0x18A76B6A0", Slot = "13")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA76B5D0", Offset = "0xA769FD0", VA = "0x18A76B5D0", Slot = "19")]
		public IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA76B820", Offset = "0xA76A220", VA = "0x18A76B820", Slot = "14")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA76B6E0", Offset = "0xA76A0E0", VA = "0x18A76B6E0", Slot = "20")]
		public IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int texCoordSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA76B0A0", Offset = "0xA769AA0", VA = "0x18A76B0A0", Slot = "15")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA76AF60", Offset = "0xA769960", VA = "0x18A76AF60", Slot = "21")]
		public IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA76B410", Offset = "0xA769E10", VA = "0x18A76B410", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76AF10", Offset = "0xA769910", VA = "0x18A76AF10", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x21B6450", Offset = "0x21B4E50", VA = "0x1821B6450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE3CEA0", Offset = "0xE3B8A0", VA = "0x180E3CEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA76ADE0", Offset = "0xA7697E0", VA = "0x18A76ADE0")]
		public _MeshGeometryDecoder(_MeshPrimitiveDecoder owner, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA76A940", Offset = "0xA769340", VA = "0x18A76A940")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA76A8C0", Offset = "0xA7692C0", VA = "0x18A76A8C0")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA76A9C0", Offset = "0xA7693C0", VA = "0x18A76A9C0")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA76AA90", Offset = "0xA769490", VA = "0x18A76AA90")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA76A800", Offset = "0xA769200", VA = "0x18A76A800")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA76AB60", Offset = "0xA769560", VA = "0x18A76AB60", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA76AB60", Offset = "0xA769560", VA = "0x18A76AB60", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA76A940", Offset = "0xA769340", VA = "0x18A76A940", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA76A940", Offset = "0xA769340", VA = "0x18A76A940", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA76A8C0", Offset = "0xA7692C0", VA = "0x18A76A8C0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA76AC70", Offset = "0xA769670", VA = "0x18A76AC70", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA76AB80", Offset = "0xA769580", VA = "0x18A76AB80", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA76ACF0", Offset = "0xA7696F0", VA = "0x18A76ACF0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76DE80", Offset = "0xA76C880", VA = "0x18A76DE80", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x21B6450", Offset = "0x21B4E50", VA = "0x1821B6450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE3CEA0", Offset = "0xE3B8A0", VA = "0x180E3CEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA76D8A0", Offset = "0xA76C2A0", VA = "0x18A76D8A0")]
		public _MorphTargetDecoder(_MeshGeometryDecoder geometry, MeshPrimitive srcPrim, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA76D170", Offset = "0xA76BB70", VA = "0x18A76D170")]
		public bool HasTexCoord(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA76D150", Offset = "0xA76BB50", VA = "0x18A76D150")]
		public bool HasColor(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA76CEA0", Offset = "0xA76B8A0", VA = "0x18A76CEA0")]
		public Vector3 GetPositionBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA76CF30", Offset = "0xA76B930", VA = "0x18A76CF30")]
		public Vector3 GetPositionDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA76CD80", Offset = "0xA76B780", VA = "0x18A76CD80")]
		public Vector3 GetNormalBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA76CE10", Offset = "0xA76B810", VA = "0x18A76CE10")]
		public Vector3 GetNormalDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA76CFC0", Offset = "0xA76B9C0", VA = "0x18A76CFC0")]
		public Vector4 GetTangentBase(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA76D000", Offset = "0xA76BA00", VA = "0x18A76D000")]
		public Vector3 GetTangentDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA76D130", Offset = "0xA76BB30", VA = "0x18A76D130")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA76D090", Offset = "0xA76BA90", VA = "0x18A76D090")]
		public Vector2 GetTextureCoordDelta(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA76CCB0", Offset = "0xA76B6B0", VA = "0x18A76CCB0")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA76CC00", Offset = "0xA76B600", VA = "0x18A76CC00")]
		public Vector4 GetColorDelta(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA76D190", Offset = "0xA76BB90", VA = "0x18A76D190", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA76D4C0", Offset = "0xA76BEC0", VA = "0x18A76D4C0", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA76D1E0", Offset = "0xA76BBE0", VA = "0x18A76D1E0", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA76D1E0", Offset = "0xA76BBE0", VA = "0x18A76D1E0", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA76D510", Offset = "0xA76BF10", VA = "0x18A76D510", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA76D660", Offset = "0xA76C060", VA = "0x18A76D660", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA76D330", Offset = "0xA76BD30", VA = "0x18A76D330", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA76D6E0", Offset = "0xA76C0E0", VA = "0x18A76D6E0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76E150", Offset = "0xA76CB50", VA = "0x18A76E150", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA76E100", Offset = "0xA76CB00", VA = "0x18A76E100", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public _MorphTargetPositionSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA76E080", Offset = "0xA76CA80", VA = "0x18A76E080", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA76E0C0", Offset = "0xA76CAC0", VA = "0x18A76E0C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76DFA0", Offset = "0xA76C9A0", VA = "0x18A76DFA0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF50", Offset = "0xA76C950", VA = "0x18A76DF50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public _MorphTargetNormalSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA76DED0", Offset = "0xA76C8D0", VA = "0x18A76DED0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA76DF10", Offset = "0xA76C910", VA = "0x18A76DF10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76E300", Offset = "0xA76CD00", VA = "0x18A76E300", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA76E2B0", Offset = "0xA76CCB0", VA = "0x18A76E2B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public _MorphTargetTangentSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA76E230", Offset = "0xA76CC30", VA = "0x18A76E230", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA76E270", Offset = "0xA76CC70", VA = "0x18A76E270", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76E4B0", Offset = "0xA76CEB0", VA = "0x18A76E4B0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA76E460", Offset = "0xA76CE60", VA = "0x18A76E460", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9B80", Offset = "0x4EF8580", VA = "0x184EF9B80")]
		public _MorphTargetTexCoordSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA76E3E0", Offset = "0xA76CDE0", VA = "0x18A76E3E0", Slot = "6")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA76E420", Offset = "0xA76CE20", VA = "0x18A76E420", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76CB00", Offset = "0xA76B500", VA = "0x18A76CB00", Slot = "4")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA76CAB0", Offset = "0xA76B4B0", VA = "0x18A76CAB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9B80", Offset = "0x4EF8580", VA = "0x184EF9B80")]
		public _MorphTargetColorSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA76CA30", Offset = "0xA76B430", VA = "0x18A76CA30", Slot = "6")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA76CA70", Offset = "0xA76B470", VA = "0x18A76CA70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x89E91A0", Offset = "0x89E7BA0", VA = "0x1889E91A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA1F2180", Offset = "0xA1F0B80", VA = "0x18A1F2180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NodeInstance VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA763A10", Offset = "0xA762410", VA = "0x18A763A10")]
			get
			{
				return default(SparseWeight8);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA763AF0", Offset = "0xA7624F0", VA = "0x18A763AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA7639A0", Offset = "0xA7623A0", VA = "0x18A7639A0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA763AA0", Offset = "0xA7624A0", VA = "0x18A763AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Matrix4x4 ModelMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA7639D0", Offset = "0xA7623D0", VA = "0x18A7639D0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA7637F0", Offset = "0xA7621F0", VA = "0x18A7637F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x10FB420", Offset = "0x10F9E20", VA = "0x1810FB420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10FB610", Offset = "0x10FA010", VA = "0x1810FB610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private bool TransformChainIsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA763A40", Offset = "0xA762440", VA = "0x18A763A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		internal NodeInstance(NodeTemplate template, NodeInstance parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA763580", Offset = "0xA761F80", VA = "0x18A763580")]
		private Matrix4x4 _GetModelMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7637F0", Offset = "0xA7621F0", VA = "0x18A7637F0")]
		private void _SetModelMatrix(Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA763490", Offset = "0xA761E90", VA = "0x18A763490")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1DDA0", Offset = "0xD1C7A0", VA = "0x180D1DDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1CDE0", VA = "0x180D1E3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xD1DC90", Offset = "0xD1C690", VA = "0x180D1DC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xD1DD00", Offset = "0xD1C700", VA = "0x180D1DD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<int> ChildIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA764E80", Offset = "0xA763880", VA = "0x18A764E80")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA764660", Offset = "0xA763060", VA = "0x18A764660")]
		internal NodeTemplate(Node srcNode, int parentIdx, int[] childIndices, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA764360", Offset = "0xA762D60", VA = "0x18A764360")]
		public SparseWeight8 GetMorphWeights(int trackLogicalIndex, float time)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA764090", Offset = "0xA762A90", VA = "0x18A764090")]
		public SparseWeight8 GetMorphWeights(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA763DA0", Offset = "0xA7627A0", VA = "0x18A763DA0")]
		public AffineTransform GetLocalTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA763E30", Offset = "0xA762830", VA = "0x18A763E30")]
		public AffineTransform GetLocalTransform(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA763B20", Offset = "0xA762520", VA = "0x18A763B20")]
		public Matrix4x4 GetLocalMatrix(int trackLogicalIndex, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA763C40", Offset = "0xA762640", VA = "0x18A763C40")]
		public Matrix4x4 GetLocalMatrix(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7645C0", Offset = "0xA762FC0", VA = "0x18A7645C0")]
		public bool? GetVisibility(int trackLogicalIndex, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA764440", Offset = "0xA762E40", VA = "0x18A764440")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76EC20", Offset = "0xA76D620", VA = "0x18A76EC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA76E8E0", Offset = "0xA76D2E0", VA = "0x18A76E8E0")]
		public _NodeTemplateTransforms(Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA76E790", Offset = "0xA76D190", VA = "0x18A76E790")]
		public void SetCurves(NodeCurveSamplers curves, int index, bool isolateMemory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA76E590", Offset = "0xA76CF90", VA = "0x18A76E590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE28730", Offset = "0xE27130", VA = "0x180E28730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MeshInstancing GpuMeshInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10")]
			[CompilerGenerated]
			get
			{
				return default(MeshInstancing);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Converter<ExtraProperties, object> ExtrasConverterCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA765170", Offset = "0xA763B70", VA = "0x18A765170")]
		internal static object ConvertExtras(ExtraProperties source, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1633F30", Offset = "0x1632930", VA = "0x181633F30")]
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
				[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA766690", Offset = "0xA765090", VA = "0x18A766690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x674BFC0", Offset = "0x674A9C0", VA = "0x18674BFC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA766490", Offset = "0xA764E90", VA = "0x18A766490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA766650", Offset = "0xA765050", VA = "0x18A766650", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA765250", Offset = "0xA763C50", VA = "0x18A765250")]
		internal SceneInstance(ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA7651E0", Offset = "0xA763BE0", VA = "0x18A7651E0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7651E0", Offset = "0xA763BE0", VA = "0x18A7651E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public (Vector3 center, float radius) SphereBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xF870D0", Offset = "0xF85AD0", VA = "0x180F870D0")]
			[CompilerGenerated]
			get
			{
				return default((Vector3, float));
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xF87A10", Offset = "0xF86410", VA = "0x180F87A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<int> LogicalMeshIds
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA765EA0", Offset = "0xA7648A0", VA = "0x18A765EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA765580", Offset = "0xA763F80", VA = "0x18A765580")]
		public static SceneTemplate Create(Scene srcScene, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x111E6D0", Offset = "0x111D0D0", VA = "0x18111E6D0")]
		private SceneTemplate(string name, object extras, ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7654D0", Offset = "0xA763ED0", VA = "0x18A7654D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E8170", Offset = "0x40E6B70", VA = "0x1840E8170")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA768100", Offset = "0xA766B00", VA = "0x18A768100")]
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
		[Cpp2IlInjected.Address(RVA = "0x40FADB0", Offset = "0x40F97B0", VA = "0x1840FADB0")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA7682C0", Offset = "0xA766CC0", VA = "0x18A7682C0")]
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

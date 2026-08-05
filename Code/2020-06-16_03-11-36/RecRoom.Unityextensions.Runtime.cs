using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EnumerableExt
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <SingleItemAsEnumerable>d__2<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private T item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public T <>3__item;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x11AC9B0", Offset = "0x11AAFB0", VA = "0x1811AC9B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x103CCA0", Offset = "0x103B2A0", VA = "0x18103CCA0")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x18A5970", Offset = "0x18A3F70", VA = "0x1818A5970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x18A5A50", Offset = "0x18A4050", VA = "0x1818A5A50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x18A59A0", Offset = "0x18A3FA0", VA = "0x1818A59A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x11A6040", Offset = "0x11A4640", VA = "0x1811A6040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x12E7EA0", Offset = "0x12E64A0", VA = "0x1812E7EA0")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x12E79F0", Offset = "0x12E5FF0", VA = "0x1812E79F0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xF2C410", Offset = "0xF2AA10", VA = "0x180F2C410")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x12E8150", Offset = "0x12E6750", VA = "0x1812E8150")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x2A2E0", Offset = "0x296E0")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1188820", Offset = "0x1186E20", VA = "0x181188820")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CA1350", Offset = "0x1C9F950", VA = "0x181CA1350")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x11889E0", Offset = "0x1186FE0", VA = "0x1811889E0")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2D84DC0", Offset = "0x2D833C0", VA = "0x182D84DC0")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class TimeExt
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float SafeDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D885B0", Offset = "0x2D86BB0", VA = "0x182D885B0")]
		get
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2D88620", Offset = "0x2D86C20", VA = "0x182D88620")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2D88760", Offset = "0x2D86D60", VA = "0x182D88760")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2D886D0", Offset = "0x2D86CD0", VA = "0x182D886D0")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2D88C40", Offset = "0x2D87240", VA = "0x182D88C40")]
	public static string GetFriendlyName(this Type type)
	{
		return null;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ArrayExt
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate int CompareDelegate<T>(in T lhs, in T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public sealed class SuspendableMergeSort<T>
		{
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private struct SuspendableMergeSortFrame
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public readonly int startIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public readonly int endIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public readonly bool needsCopyToWorkBuffer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public int childVisits;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x2590B0", Offset = "0x2584B0", VA = "0x1802590B0")]
				public SuspendableMergeSortFrame(int startIndex, int endIndex, bool needsCopyToWorkBuffer)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private readonly T[] arrayToSort;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private readonly T[] workBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly CompareDelegate<T> compare;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly int chunkSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly Func<bool> shouldSuspendHeuristic;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int currentFrameIdx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly SuspendableMergeSortFrame[] frames;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2122FE0", Offset = "0x21215E0", VA = "0x182122FE0")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2122860", Offset = "0x2120E60", VA = "0x182122860")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1616720", Offset = "0x1614D20", VA = "0x181616720")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xE117B0", Offset = "0xE0FDB0", VA = "0x180E117B0")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE116B0", Offset = "0xE0FCB0", VA = "0x180E116B0")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1368770", Offset = "0x1366D70", VA = "0x181368770")]
		public static int FindIndex<T>(this T[] array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x11F57D0", Offset = "0x11F3DD0", VA = "0x1811F57D0")]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xE128E0", Offset = "0xE10EE0", VA = "0x180E128E0")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE12760", Offset = "0xE10D60", VA = "0x180E12760")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xE121F0", Offset = "0xE107F0", VA = "0x180E121F0")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE11DC0", Offset = "0xE103C0", VA = "0x180E11DC0")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE12280", Offset = "0xE10880", VA = "0x180E12280")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE11930", Offset = "0xE0FF30", VA = "0x180E11930")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x126A1E0", Offset = "0x12687E0", VA = "0x18126A1E0")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x12062F0", Offset = "0x12048F0", VA = "0x1812062F0")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2D847E0", Offset = "0x2D82DE0", VA = "0x182D847E0")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CoroutineExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <WaitRoutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public float waitDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2D88F70", Offset = "0x2D87570", VA = "0x182D88F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2D89020", Offset = "0x2D87620", VA = "0x182D89020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2D88E00", Offset = "0x2D87400", VA = "0x182D88E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2D88EB0", Offset = "0x2D874B0", VA = "0x182D88EB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <WaitUntilTrueOrTimeout>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Func<bool> predicate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Action onTrue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float timeoutSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Action onTimedOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private float <startTime>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2D89070", Offset = "0x2D87670", VA = "0x182D89070", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2D89130", Offset = "0x2D87730", VA = "0x182D89130", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2D84C60", Offset = "0x2D83260", VA = "0x182D84C60")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2D84C00", Offset = "0x2D83200", VA = "0x182D84C00")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2D84CD0", Offset = "0x2D832D0", VA = "0x182D84CD0")]
		[IteratorStateMachine(typeof(<WaitUntilTrueOrTimeout>d__3))]
		public static IEnumerator WaitUntilTrueOrTimeout(Func<bool> predicate, Action onTrue, Action onTimedOut, float timeoutSeconds)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class WaitForSecondsIgnoreHitches : CustomYieldInstruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float elapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float targetSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2D8ADC0", Offset = "0x2D893C0", VA = "0x182D8ADC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD90", Offset = "0x2D89390", VA = "0x182D8AD90")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xE1CDA0", Offset = "0xE1B3A0", VA = "0x180E1CDA0")]
		public static void AddRange<T>(this HashSet<T> hashSet, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xE1D3A0", Offset = "0xE1B9A0", VA = "0x180E1D3A0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xE1D430", Offset = "0xE1BA30", VA = "0x180E1D430")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1422CF0", Offset = "0x14212F0", VA = "0x181422CF0")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x120B0C0", Offset = "0x12096C0", VA = "0x18120B0C0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC03770", Offset = "0xC01D70", VA = "0x180C03770")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE1D180", Offset = "0xE1B780", VA = "0x180E1D180")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xC036B0", Offset = "0xC01CB0", VA = "0x180C036B0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xE1D1E0", Offset = "0xE1B7E0", VA = "0x180E1D1E0")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xC03860", Offset = "0xC01E60", VA = "0x180C03860")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC037F0", Offset = "0xC01DF0", VA = "0x180C037F0")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x120ABA0", Offset = "0x12091A0", VA = "0x18120ABA0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC02B60", Offset = "0xC01160", VA = "0x180C02B60")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x120B180", Offset = "0x1209780", VA = "0x18120B180")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2D86210", Offset = "0x2D84810", VA = "0x182D86210")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D85F80", Offset = "0x2D84580", VA = "0x182D85F80")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D86120", Offset = "0x2D84720", VA = "0x182D86120")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2D853C0", Offset = "0x2D839C0", VA = "0x182D853C0")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2D852A0", Offset = "0x2D838A0", VA = "0x182D852A0")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2D86AE0", Offset = "0x2D850E0", VA = "0x182D86AE0")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2D86970", Offset = "0x2D84F70", VA = "0x182D86970")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D854A0", Offset = "0x2D83AA0", VA = "0x182D854A0")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2D868A0", Offset = "0x2D84EA0", VA = "0x182D868A0")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2D85630", Offset = "0x2D83C30", VA = "0x182D85630")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2D85AA0", Offset = "0x2D840A0", VA = "0x182D85AA0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2D85080", Offset = "0x2D83680", VA = "0x182D85080")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D863D0", Offset = "0x2D849D0", VA = "0x182D863D0")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2D86230", Offset = "0x2D84830", VA = "0x182D86230")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D86530", Offset = "0x2D84B30", VA = "0x182D86530")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2D85110", Offset = "0x2D83710", VA = "0x182D85110")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2D86D40", Offset = "0x2D85340", VA = "0x182D86D40")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2D86D90", Offset = "0x2D85390", VA = "0x182D86D90")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D86E20", Offset = "0x2D85420", VA = "0x182D86E20")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D86E70", Offset = "0x2D85470", VA = "0x182D86E70")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2D86C80", Offset = "0x2D85280", VA = "0x182D86C80")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2D86D50", Offset = "0x2D85350", VA = "0x182D86D50")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC06DE0", Offset = "0xC053E0", VA = "0x180C06DE0")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC070D0", Offset = "0xC056D0", VA = "0x180C070D0")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60D6C0", Offset = "0x60BCC0", VA = "0x18060D6C0")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D89180", Offset = "0x2D87780", VA = "0x182D89180")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2D891A0", Offset = "0x2D877A0", VA = "0x182D891A0")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2D86FB0", Offset = "0x2D855B0", VA = "0x182D86FB0")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2D870E0", Offset = "0x2D856E0", VA = "0x182D870E0")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2D87190", Offset = "0x2D85790", VA = "0x182D87190")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2D87340", Offset = "0x2D85940", VA = "0x182D87340")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2D87A30", Offset = "0x2D86030", VA = "0x182D87A30")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2D87860", Offset = "0x2D85E60", VA = "0x182D87860")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2D87780", Offset = "0x2D85D80", VA = "0x182D87780")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D87930", Offset = "0x2D85F30", VA = "0x182D87930")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2D87170", Offset = "0x2D85770", VA = "0x182D87170")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2D87590", Offset = "0x2D85B90", VA = "0x182D87590")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2D873F0", Offset = "0x2D859F0", VA = "0x182D873F0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2D87B80", Offset = "0x2D86180", VA = "0x182D87B80")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2D87D00", Offset = "0x2D86300", VA = "0x182D87D00")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2D87C40", Offset = "0x2D86240", VA = "0x182D87C40")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2D88290", Offset = "0x2D86890", VA = "0x182D88290")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2D87E70", Offset = "0x2D86470", VA = "0x182D87E70")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2D884A0", Offset = "0x2D86AA0", VA = "0x182D884A0")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2D87EE0", Offset = "0x2D864E0", VA = "0x182D87EE0")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2D87DF0", Offset = "0x2D863F0", VA = "0x182D87DF0")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2D88120", Offset = "0x2D86720", VA = "0x182D88120")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2D88080", Offset = "0x2D86680", VA = "0x182D88080")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2D88070", Offset = "0x2D86670", VA = "0x182D88070")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2D87F60", Offset = "0x2D86560", VA = "0x182D87F60")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2D87FE0", Offset = "0x2D865E0", VA = "0x182D87FE0")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2D87DC0", Offset = "0x2D863C0", VA = "0x182D87DC0")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2D881B0", Offset = "0x2D867B0", VA = "0x182D881B0")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2D88210", Offset = "0x2D86810", VA = "0x182D88210")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2D88A20", Offset = "0x2D87020", VA = "0x182D88A20")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x947D80", Offset = "0x946380", VA = "0x180947D80")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D89200", Offset = "0x2D87800", VA = "0x182D89200")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D89550", Offset = "0x2D87B50", VA = "0x182D89550")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A620", Offset = "0x2D88C20", VA = "0x182D8A620")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AA60", Offset = "0x2D89060", VA = "0x182D8AA60")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A7A0", Offset = "0x2D88DA0", VA = "0x182D8A7A0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A8C0", Offset = "0x2D88EC0", VA = "0x182D8A8C0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D89F10", Offset = "0x2D88510", VA = "0x182D89F10")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A100", Offset = "0x2D88700", VA = "0x182D8A100")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A230", Offset = "0x2D88830", VA = "0x182D8A230")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A2F0", Offset = "0x2D888F0", VA = "0x182D8A2F0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A380", Offset = "0x2D88980", VA = "0x182D8A380")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D892B0", Offset = "0x2D878B0", VA = "0x182D892B0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AC40", Offset = "0x2D89240", VA = "0x182D8AC40")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D89920", Offset = "0x2D87F20", VA = "0x182D89920")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A2A0", Offset = "0x2D888A0", VA = "0x182D8A2A0")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A0A0", Offset = "0x2D886A0", VA = "0x182D8A0A0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A040", Offset = "0x2D88640", VA = "0x182D8A040")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A4D0", Offset = "0x2D88AD0", VA = "0x182D8A4D0")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D89A90", Offset = "0x2D88090", VA = "0x182D89A90")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D89370", Offset = "0x2D87970", VA = "0x182D89370")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD00", Offset = "0x2D89300", VA = "0x182D8AD00")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D89B50", Offset = "0x2D88150", VA = "0x182D89B50")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D89B20", Offset = "0x2D88120", VA = "0x182D89B20")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A560", Offset = "0x2D88B60", VA = "0x182D8A560")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A5A0", Offset = "0x2D88BA0", VA = "0x182D8A5A0")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A5E0", Offset = "0x2D88BE0", VA = "0x182D8A5E0")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A6E0", Offset = "0x2D88CE0", VA = "0x182D8A6E0")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A410", Offset = "0x2D88A10", VA = "0x182D8A410")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xE1E5D0", Offset = "0xE1CBD0", VA = "0x180E1E5D0")]
		public static void Resize<T>(ref NativeArray<T> originalArray, int newSize, Allocator allocator) where T : struct
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

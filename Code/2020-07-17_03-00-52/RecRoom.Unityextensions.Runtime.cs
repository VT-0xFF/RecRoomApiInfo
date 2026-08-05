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
			[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x116DFF0", Offset = "0x116D1F0", VA = "0x18116DFF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x107C360", Offset = "0x107B560", VA = "0x18107C360")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x187ED80", Offset = "0x187DF80", VA = "0x18187ED80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x187EE60", Offset = "0x187E060", VA = "0x18187EE60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x187EDB0", Offset = "0x187DFB0", VA = "0x18187EDB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1167360", Offset = "0x1166560", VA = "0x181167360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x129B6C0", Offset = "0x129A8C0", VA = "0x18129B6C0")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x129B210", Offset = "0x129A410", VA = "0x18129B210")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xB35BD0", Offset = "0xB34DD0", VA = "0x180B35BD0")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x129B970", Offset = "0x129AB70", VA = "0x18129B970")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x29A80", Offset = "0x28E80")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1130890", Offset = "0x112FA90", VA = "0x181130890")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D140", Offset = "0x1D6C340", VA = "0x181D6D140")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x11D6CD0", Offset = "0x11D5ED0", VA = "0x1811D6CD0")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2DAB660", Offset = "0x2DAA860", VA = "0x182DAB660")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DAEE60", Offset = "0x2DAE060", VA = "0x182DAEE60")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DAEED0", Offset = "0x2DAE0D0", VA = "0x182DAEED0")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF010", Offset = "0x2DAE210", VA = "0x182DAF010")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEF80", Offset = "0x2DAE180", VA = "0x182DAEF80")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2DAF4F0", Offset = "0x2DAE6F0", VA = "0x182DAF4F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x232D00", Offset = "0x232100", VA = "0x180232D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A34940", Offset = "0x1A33B40", VA = "0x181A34940")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A34570", Offset = "0x1A33770", VA = "0x181A34570")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1645670", Offset = "0x1644870", VA = "0x181645670")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD68040", Offset = "0xD67240", VA = "0x180D68040")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD67F40", Offset = "0xD67140", VA = "0x180D67F40")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1430DE0", Offset = "0x142FFE0", VA = "0x181430DE0")]
		public static int FindIndex<T>(this T[] array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x11F76D0", Offset = "0x11F68D0", VA = "0x1811F76D0")]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD69170", Offset = "0xD68370", VA = "0x180D69170")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD68FF0", Offset = "0xD681F0", VA = "0x180D68FF0")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD68A80", Offset = "0xD67C80", VA = "0x180D68A80")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD68650", Offset = "0xD67850", VA = "0x180D68650")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD68B10", Offset = "0xD67D10", VA = "0x180D68B10")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xD681C0", Offset = "0xD673C0", VA = "0x180D681C0")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x127EAB0", Offset = "0x127DCB0", VA = "0x18127EAB0")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class CachedComponentHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private enum SearchType
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Self,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			Children
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct CacheParameters : IEquatable<CacheParameters>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly GameObject gameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly bool includeMultiple;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly SearchType searchType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly Type type;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2CB940", Offset = "0x2CAD40", VA = "0x1802CB940")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7A0", Offset = "0x2CABA0", VA = "0x1802CB7A0", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2CB7D0", Offset = "0x2CABD0", VA = "0x1802CB7D0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2CB870", Offset = "0x2CAC70", VA = "0x1802CB870", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2CB930", Offset = "0x2CAD30", VA = "0x1802CB930", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly List<CacheParameters> IMMEDIATE_KEYS;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static Dictionary<CacheParameters, ICollection> componentsCache;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static int queriesSinceLastPrune;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAA50", Offset = "0x2DA9C50", VA = "0x182DAAA50")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10F28C0", Offset = "0x10F1AC0", VA = "0x1810F28C0")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AB060", VA = "0x1808ABE60")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x10F29E0", Offset = "0x10F1BE0", VA = "0x1810F29E0")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF80", Offset = "0x8AB180", VA = "0x1808ABF80")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAF70", Offset = "0x2DAA170", VA = "0x182DAAF70")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAAAE0", Offset = "0x2DA9CE0", VA = "0x182DAAAE0")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8AC130", Offset = "0x8AB330", VA = "0x1808AC130")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8AC230", Offset = "0x8AB430", VA = "0x1808AC230")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1209180", Offset = "0x1208380", VA = "0x181209180")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB0B0", Offset = "0x2DAA2B0", VA = "0x182DAB0B0")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class CoroutineExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class <WaitRoutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public float waitDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x383420", Offset = "0x382620", VA = "0x180383420")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF820", Offset = "0x2DAEA20", VA = "0x182DAF820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF8D0", Offset = "0x2DAEAD0", VA = "0x182DAF8D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x383420", Offset = "0x382620", VA = "0x180383420")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF6B0", Offset = "0x2DAE8B0", VA = "0x182DAF6B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF760", Offset = "0x2DAE960", VA = "0x182DAF760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class <WaitUntilTrueOrTimeout>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<bool> predicate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Action onTrue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float timeoutSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public Action onTimedOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private float <startTime>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x3833B0", Offset = "0x3825B0", VA = "0x1803833B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x383420", Offset = "0x382620", VA = "0x180383420")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF920", Offset = "0x2DAEB20", VA = "0x182DAF920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF9E0", Offset = "0x2DAEBE0", VA = "0x182DAF9E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB500", Offset = "0x2DAA700", VA = "0x182DAB500")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB4A0", Offset = "0x2DAA6A0", VA = "0x182DAB4A0")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB570", Offset = "0x2DAA770", VA = "0x182DAB570")]
		[IteratorStateMachine(typeof(<WaitUntilTrueOrTimeout>d__3))]
		public static IEnumerator WaitUntilTrueOrTimeout(Func<bool> predicate, Action onTrue, Action onTimedOut, float timeoutSeconds)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class WaitForSecondsIgnoreHitches : CustomYieldInstruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float elapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float targetSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2DB1670", Offset = "0x2DB0870", VA = "0x182DB1670", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1640", Offset = "0x2DB0840", VA = "0x182DB1640")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD738D0", Offset = "0xD72AD0", VA = "0x180D738D0")]
		public static void AddRange<T>(this HashSet<T> hashSet, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD73ED0", Offset = "0xD730D0", VA = "0x180D73ED0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD73F60", Offset = "0xD73160", VA = "0x180D73F60")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3D0", Offset = "0x8AE5D0", VA = "0x1808AF3D0")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x120D360", Offset = "0x120C560", VA = "0x18120D360")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x10F34E0", Offset = "0x10F26E0", VA = "0x1810F34E0")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xD73CB0", Offset = "0xD72EB0", VA = "0x180D73CB0")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x10F3420", Offset = "0x10F2620", VA = "0x1810F3420")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD73D10", Offset = "0xD72F10", VA = "0x180D73D10")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x10F35D0", Offset = "0x10F27D0", VA = "0x1810F35D0")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x10F3560", Offset = "0x10F2760", VA = "0x1810F3560")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x120CE40", Offset = "0x120C040", VA = "0x18120CE40")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF2AC70", Offset = "0xF29E70", VA = "0x180F2AC70")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x120D420", Offset = "0x120C620", VA = "0x18120D420")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2DACAB0", Offset = "0x2DABCB0", VA = "0x182DACAB0")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC820", Offset = "0x2DABA20", VA = "0x182DAC820")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC9C0", Offset = "0x2DABBC0", VA = "0x182DAC9C0")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2DABC60", Offset = "0x2DAAE60", VA = "0x182DABC60")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2DABB40", Offset = "0x2DAAD40", VA = "0x182DABB40")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD380", Offset = "0x2DAC580", VA = "0x182DAD380")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD210", Offset = "0x2DAC410", VA = "0x182DAD210")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2DABD40", Offset = "0x2DAAF40", VA = "0x182DABD40")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD140", Offset = "0x2DAC340", VA = "0x182DAD140")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2DABED0", Offset = "0x2DAB0D0", VA = "0x182DABED0")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAC340", Offset = "0x2DAB540", VA = "0x182DAC340")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB920", Offset = "0x2DAAB20", VA = "0x182DAB920")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2DACC70", Offset = "0x2DABE70", VA = "0x182DACC70")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2DACAD0", Offset = "0x2DABCD0", VA = "0x182DACAD0")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2DACDD0", Offset = "0x2DABFD0", VA = "0x182DACDD0")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB9B0", Offset = "0x2DAABB0", VA = "0x182DAB9B0")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD5E0", Offset = "0x2DAC7E0", VA = "0x182DAD5E0")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD630", Offset = "0x2DAC830", VA = "0x182DAD630")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD6C0", Offset = "0x2DAC8C0", VA = "0x182DAD6C0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD710", Offset = "0x2DAC910", VA = "0x182DAD710")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD520", Offset = "0x2DAC720", VA = "0x182DAD520")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD5F0", Offset = "0x2DAC7F0", VA = "0x182DAD5F0")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x10F4610", Offset = "0x10F3810", VA = "0x1810F4610")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x10F4900", Offset = "0x10F3B00", VA = "0x1810F4900")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3850", Offset = "0x5E2A50", VA = "0x1805E3850")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFA30", Offset = "0x2DAEC30", VA = "0x182DAFA30")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFA50", Offset = "0x2DAEC50", VA = "0x182DAFA50")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD850", Offset = "0x2DACA50", VA = "0x182DAD850")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD980", Offset = "0x2DACB80", VA = "0x182DAD980")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2DADA30", Offset = "0x2DACC30", VA = "0x182DADA30")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2DADBE0", Offset = "0x2DACDE0", VA = "0x182DADBE0")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE2D0", Offset = "0x2DAD4D0", VA = "0x182DAE2D0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE100", Offset = "0x2DAD300", VA = "0x182DAE100")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE020", Offset = "0x2DAD220", VA = "0x182DAE020")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE1D0", Offset = "0x2DAD3D0", VA = "0x182DAE1D0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2DADA10", Offset = "0x2DACC10", VA = "0x182DADA10")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2DADE30", Offset = "0x2DAD030", VA = "0x182DADE30")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2DADC90", Offset = "0x2DACE90", VA = "0x182DADC90")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE420", Offset = "0x2DAD620", VA = "0x182DAE420")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE5A0", Offset = "0x2DAD7A0", VA = "0x182DAE5A0")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE4E0", Offset = "0x2DAD6E0", VA = "0x182DAE4E0")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEB40", Offset = "0x2DADD40", VA = "0x182DAEB40")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE710", Offset = "0x2DAD910", VA = "0x182DAE710")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2DAED50", Offset = "0x2DADF50", VA = "0x182DAED50")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE780", Offset = "0x2DAD980", VA = "0x182DAE780")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE690", Offset = "0x2DAD890", VA = "0x182DAE690")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE9D0", Offset = "0x2DADBD0", VA = "0x182DAE9D0")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE930", Offset = "0x2DADB30", VA = "0x182DAE930")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE910", Offset = "0x2DADB10", VA = "0x182DAE910")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE920", Offset = "0x2DADB20", VA = "0x182DAE920")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE800", Offset = "0x2DADA00", VA = "0x182DAE800")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE880", Offset = "0x2DADA80", VA = "0x182DAE880")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE660", Offset = "0x2DAD860", VA = "0x182DAE660")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEA60", Offset = "0x2DADC60", VA = "0x182DAEA60")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEAC0", Offset = "0x2DADCC0", VA = "0x182DAEAC0")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF2D0", Offset = "0x2DAE4D0", VA = "0x182DAF2D0")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA647C0", VA = "0x180A655C0")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFAB0", Offset = "0x2DAECB0", VA = "0x182DAFAB0")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFE00", Offset = "0x2DAF000", VA = "0x182DAFE00")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0ED0", Offset = "0x2DB00D0", VA = "0x182DB0ED0")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1310", Offset = "0x2DB0510", VA = "0x182DB1310")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1050", Offset = "0x2DB0250", VA = "0x182DB1050")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1170", Offset = "0x2DB0370", VA = "0x182DB1170")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2DB07C0", Offset = "0x2DAF9C0", VA = "0x182DB07C0")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DB09B0", Offset = "0x2DAFBB0", VA = "0x182DB09B0")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0AE0", Offset = "0x2DAFCE0", VA = "0x182DB0AE0")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0BA0", Offset = "0x2DAFDA0", VA = "0x182DB0BA0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0C30", Offset = "0x2DAFE30", VA = "0x182DB0C30")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFB60", Offset = "0x2DAED60", VA = "0x182DAFB60")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DB14F0", Offset = "0x2DB06F0", VA = "0x182DB14F0")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DB01D0", Offset = "0x2DAF3D0", VA = "0x182DB01D0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0B50", Offset = "0x2DAFD50", VA = "0x182DB0B50")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0950", Offset = "0x2DAFB50", VA = "0x182DB0950")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DB08F0", Offset = "0x2DAFAF0", VA = "0x182DB08F0")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0D80", Offset = "0x2DAFF80", VA = "0x182DB0D80")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0340", Offset = "0x2DAF540", VA = "0x182DB0340")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFC20", Offset = "0x2DAEE20", VA = "0x182DAFC20")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DB15B0", Offset = "0x2DB07B0", VA = "0x182DB15B0")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0400", Offset = "0x2DAF600", VA = "0x182DB0400")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DB03D0", Offset = "0x2DAF5D0", VA = "0x182DB03D0")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0E10", Offset = "0x2DB0010", VA = "0x182DB0E10")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0E50", Offset = "0x2DB0050", VA = "0x182DB0E50")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0E90", Offset = "0x2DB0090", VA = "0x182DB0E90")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0F90", Offset = "0x2DB0190", VA = "0x182DB0F90")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0CC0", Offset = "0x2DAFEC0", VA = "0x182DB0CC0")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD750E0", Offset = "0xD742E0", VA = "0x180D750E0")]
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

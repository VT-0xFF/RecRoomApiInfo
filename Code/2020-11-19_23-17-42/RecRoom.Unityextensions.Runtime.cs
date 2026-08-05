using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Networking;

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
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x139BB40", Offset = "0x139A940", VA = "0x18139BB40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x139BB90", Offset = "0x139A990", VA = "0x18139BB90")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x139B9D0", Offset = "0x139A7D0", VA = "0x18139B9D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x139BAA0", Offset = "0x139A8A0", VA = "0x18139BAA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x139BA00", Offset = "0x139A800", VA = "0x18139BA00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1381310", Offset = "0x1380110", VA = "0x181381310", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1911C50", Offset = "0x1910A50", VA = "0x181911C50")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x19117A0", Offset = "0x19105A0", VA = "0x1819117A0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x11AC180", Offset = "0x11AAF80", VA = "0x1811AC180")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1911F00", Offset = "0x1910D00", VA = "0x181911F00")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0xEF1D0", Offset = "0xEE5D0")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x183AD30", Offset = "0x1839B30", VA = "0x18183AD30")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x19115C0", Offset = "0x19103C0", VA = "0x1819115C0")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1793EC0", Offset = "0x1792CC0", VA = "0x181793EC0")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x183AEF0", Offset = "0x1839CF0", VA = "0x18183AEF0")]
	public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int skip, int take)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x183AB60", Offset = "0x1839960", VA = "0x18183AB60")]
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keyFunc)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x309D000", Offset = "0x309BE00", VA = "0x18309D000")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class TimeExt
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float SafeDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x30A2C40", Offset = "0x30A1A40", VA = "0x1830A2C40")]
		get
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30A2CB0", Offset = "0x30A1AB0", VA = "0x1830A2CB0")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30A2DE0", Offset = "0x30A1BE0", VA = "0x1830A2DE0")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30A2D50", Offset = "0x30A1B50", VA = "0x1830A2D50")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30A4450", Offset = "0x30A3250", VA = "0x1830A4450")]
	public static string GetFriendlyName(this Type type)
	{
		return null;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class AnimationExt
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x30996F0", Offset = "0x30984F0", VA = "0x1830996F0")]
		public static void SafeSetEnabled(this Animator animator, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3099770", Offset = "0x3098570", VA = "0x183099770")]
		public static void SetBoolIfActive(this Animator animator, int id, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x30997D0", Offset = "0x30985D0", VA = "0x1830997D0")]
		public static void SetIntegerIfActive(this Animator animator, int id, int value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ArrayExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate int CompareDelegate<T>(in T lhs, in T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class SuspendableMergeSort<T>
		{
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			private struct SuspendableMergeSortFrame
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public readonly int startIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public readonly int endIndex;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public readonly bool needsCopyToWorkBuffer;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public int childVisits;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x33B8F0", Offset = "0x33ACF0", VA = "0x18033B8F0")]
				public SuspendableMergeSortFrame(int startIndex, int endIndex, bool needsCopyToWorkBuffer)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly T[] arrayToSort;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly T[] workBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly CompareDelegate<T> compare;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly int chunkSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly Func<bool> shouldSuspendHeuristic;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int currentFrameIdx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private readonly SuspendableMergeSortFrame[] frames;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2510C90", Offset = "0x250FA90", VA = "0x182510C90")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2510530", Offset = "0x250F330", VA = "0x182510530")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x17E9A50", Offset = "0x17E8850", VA = "0x1817E9A50")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x12F5A70", Offset = "0x12F4870", VA = "0x1812F5A70")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x12F5970", Offset = "0x12F4770", VA = "0x1812F5970")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x12F6B10", Offset = "0x12F5910", VA = "0x1812F6B10")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x12F69A0", Offset = "0x12F57A0", VA = "0x1812F69A0")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12F6450", Offset = "0x12F5250", VA = "0x1812F6450")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12F6030", Offset = "0x12F4E30", VA = "0x1812F6030")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x12F64E0", Offset = "0x12F52E0", VA = "0x1812F64E0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x12F5BE0", Offset = "0x12F49E0", VA = "0x1812F5BE0")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1793C70", Offset = "0x1792A70", VA = "0x181793C70")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x17E9B60", Offset = "0x17E8960", VA = "0x1817E9B60")]
		public static T[] Sort<T>(this T[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x17E9100", Offset = "0x17E7F00", VA = "0x1817E9100")]
		public static T[] CopyAndAdd<T>(this T[] oldArray, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x17E91E0", Offset = "0x17E7FE0", VA = "0x1817E91E0")]
		public static T[] CopyAndInsert<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17E9780", Offset = "0x17E8580", VA = "0x1817E9780")]
		public static T[] CopyAndRemoveAt<T>(this T[] oldArray, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17E9830", Offset = "0x17E8630", VA = "0x1817E9830")]
		public static T[] CopyAndReplaceAt<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class CachedComponentHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private enum SearchType
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			Self,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Parent,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Children
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct CacheParameters : IEquatable<CacheParameters>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly GameObject gameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly bool includeMultiple;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly SearchType searchType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly Type type;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x379F40", Offset = "0x379340", VA = "0x180379F40")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x379DA0", Offset = "0x3791A0", VA = "0x180379DA0", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x379DD0", Offset = "0x3791D0", VA = "0x180379DD0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x379E70", Offset = "0x379270", VA = "0x180379E70", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x379F30", Offset = "0x379330", VA = "0x180379F30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly List<CacheParameters> IMMEDIATE_KEYS;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static Dictionary<CacheParameters, ICollection> componentsCache;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static int queriesSinceLastPrune;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3099FA0", Offset = "0x3098DA0", VA = "0x183099FA0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x14FDE20", Offset = "0x14FCC20", VA = "0x1814FDE20")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x13FBA80", Offset = "0x13FA880", VA = "0x1813FBA80")]
		public static IReadOnlyList<T> GetCachedComponentsInParent<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x13FB960", Offset = "0x13FA760", VA = "0x1813FB960")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x14FDF40", Offset = "0x14FCD40", VA = "0x1814FDF40")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x13FBBA0", Offset = "0x13FA9A0", VA = "0x1813FBBA0")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x309A480", Offset = "0x3099280", VA = "0x18309A480")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x309A030", Offset = "0x3098E30", VA = "0x18309A030")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x13FBD50", Offset = "0x13FAB50", VA = "0x1813FBD50")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x13FBE50", Offset = "0x13FAC50", VA = "0x1813FBE50")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CameraExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x309AAE0", Offset = "0x30998E0", VA = "0x18309AAE0")]
		public static float GetFrustumHeightAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x309AB10", Offset = "0x3099910", VA = "0x18309AB10")]
		public static float GetFrustumWidthAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x309AB60", Offset = "0x3099960", VA = "0x18309AB60")]
		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x309A650", Offset = "0x3099450", VA = "0x18309A650")]
		private static float GetCameraDistanceToHeightRatio(float cameraFieldOfView)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x309A6C0", Offset = "0x30994C0", VA = "0x18309A6C0")]
		private static float GetCameraDistanceToHeightRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x309A740", Offset = "0x3099540", VA = "0x18309A740")]
		private static float GetCameraDistanceToWidthRatio(float cameraFieldOfView, float cameraAspectRatio)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x309A7C0", Offset = "0x30995C0", VA = "0x18309A7C0")]
		private static float GetCameraDistanceToWidthRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x309A9D0", Offset = "0x30997D0", VA = "0x18309A9D0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(float cameraFieldOfView, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x309A8B0", Offset = "0x30996B0", VA = "0x18309A8B0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x309A8F0", Offset = "0x30996F0", VA = "0x18309A8F0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, Vector2 worldSpaceSize, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x309A800", Offset = "0x3099600", VA = "0x18309A800")]
		private static float GetDistanceFromProjectionCameraToFillFOVInternal(float distanceToSizeRatio, float worldSpaceSize, float viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x309ACD0", Offset = "0x3099AD0", VA = "0x18309ACD0")]
		public static float GetScaleFactorFromProjectionCameraToFillFOVAtDistance(float cameraFOV, float cameraAspectRatio, Vector2 worldSpaceSize, float desiredDistance, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x309AC10", Offset = "0x3099A10", VA = "0x18309AC10")]
		private static float GetScaleFactorFromProjectionCameraToFillFOVAtDistanceInternal(float distanceToSizeRatio, float worldSpaceSize, float desiredDistance, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x309A5C0", Offset = "0x30993C0", VA = "0x18309A5C0")]
		public static void CleanupRenderTexture(this Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x309AED0", Offset = "0x3099CD0", VA = "0x18309AED0")]
		public static bool IsInFov(this Camera camera, Renderer renderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x309AE50", Offset = "0x3099C50", VA = "0x18309AE50")]
		public static bool IsInFovSimple(this Camera camera, Vector3 point)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ColliderExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static RaycastHit[] raycastHits;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x309AF30", Offset = "0x3099D30", VA = "0x18309AF30")]
		public static bool CapsuleCast(this Collider collider, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x309BA50", Offset = "0x309A850", VA = "0x18309BA50")]
		public static int GetOverlapNonAlloc(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction, Collider[] hitColliders)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x309B5C0", Offset = "0x309A3C0", VA = "0x18309B5C0")]
		public static bool CheckOverlap(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x309BD10", Offset = "0x309AB10", VA = "0x18309BD10")]
		public static int Overlap(this BoxCollider collider, Collider[] hits, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x309B860", Offset = "0x309A660", VA = "0x18309B860")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x309B200", Offset = "0x309A000", VA = "0x18309B200")]
		public static bool CheckOverlap(this CapsuleCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ColorExt
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x309C150", Offset = "0x309AF50", VA = "0x18309C150")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x309C060", Offset = "0x309AE60", VA = "0x18309C060")]
		public static Vector3 GammaToLinearColorSpace(this Vector3 gammaColor)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x309C020", Offset = "0x309AE20", VA = "0x18309C020")]
		public static Color ChangeAlpha(this Color color, float newAlpha)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x309C190", Offset = "0x309AF90", VA = "0x18309C190")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x13FC120", Offset = "0x13FAF20", VA = "0x1813FC120")]
		public static List<T> FindAllObjectsOfType<T>(this Component component) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x14FE700", Offset = "0x14FD500", VA = "0x1814FE700")]
		public static T GetComponentInParent<T>(this Component component, bool includeDisabled) where T : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ComponentHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <GetAllComponentsInScenes>d__0<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private GameObject[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private T[] <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private int <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x139BB90", Offset = "0x139A990", VA = "0x18139BB90")]
			[DebuggerHidden]
			public <GetAllComponentsInScenes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1539DB0", Offset = "0x1538BB0", VA = "0x181539DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1539FC0", Offset = "0x1538DC0", VA = "0x181539FC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1539F20", Offset = "0x1538D20", VA = "0x181539F20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1387860", Offset = "0x1386660", VA = "0x181387860", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x183A150", Offset = "0x1838F50", VA = "0x18183A150")]
		[IteratorStateMachine(typeof(<GetAllComponentsInScenes>d__0<>))]
		public static IEnumerable<T> GetAllComponentsInScenes<T>() where T : Component
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class CoroutineExt
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <WaitRoutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float waitDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x408100", Offset = "0x406F00", VA = "0x180408100")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x30A49F0", Offset = "0x30A37F0", VA = "0x1830A49F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x30A4AA0", Offset = "0x30A38A0", VA = "0x1830A4AA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x408100", Offset = "0x406F00", VA = "0x180408100")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x30A4610", Offset = "0x30A3410", VA = "0x1830A4610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x30A46C0", Offset = "0x30A34C0", VA = "0x1830A46C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x309C5E0", Offset = "0x309B3E0", VA = "0x18309C5E0")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x309C580", Offset = "0x309B380", VA = "0x18309C580")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class WaitForSecondsIgnoreHitches : CustomYieldInstruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float elapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float targetSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x30A6F50", Offset = "0x30A5D50", VA = "0x1830A6F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x30A6F20", Offset = "0x30A5D20", VA = "0x1830A6F20")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DictionaryExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x17EAFD0", Offset = "0x17E9DD0", VA = "0x1817EAFD0")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EncodingExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x309C6B0", Offset = "0x309B4B0", VA = "0x18309C6B0")]
		public static string ToBase64String(this Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x309C790", Offset = "0x309B590", VA = "0x18309C790")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FileExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x309C870", Offset = "0x309B670", VA = "0x18309C870")]
		public static string ReadLines(this FileInfo file, string startPattern, string endPattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x309CA50", Offset = "0x309B850", VA = "0x18309CA50")]
		public static string ReadLines(this FileInfo file, int startLine, int numberOfLinesToRead)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class GameObjectExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class <GetGameObjectHierarchyHelper>d__8 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private GameObject go;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public GameObject <>3__go;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private Transform <t>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x3BD5D0", Offset = "0x3BC3D0", VA = "0x1803BD5D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA36090", Offset = "0xA34E90", VA = "0x180A36090")]
			[DebuggerHidden]
			public <GetGameObjectHierarchyHelper>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3B5860", Offset = "0x3B4660", VA = "0x1803B5860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x30A4710", Offset = "0x30A3510", VA = "0x1830A4710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x30A48A0", Offset = "0x30A36A0", VA = "0x1830A48A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x30A4800", Offset = "0x30A3600", VA = "0x1830A4800", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x30A4800", Offset = "0x30A3600", VA = "0x1830A4800", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x15000B0", Offset = "0x14FEEB0", VA = "0x1815000B0")]
		public static T GetComponentInParent<T>(this GameObject gameObject, bool includeDisabled) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1500190", Offset = "0x14FEF90", VA = "0x181500190")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x309CDA0", Offset = "0x309BBA0", VA = "0x18309CDA0")]
		public static void SetTagRecursively(this GameObject gameObject, string tag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x309CC70", Offset = "0x309BA70", VA = "0x18309CC70")]
		public static string GetGameObjectHierarchy(this GameObject go)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x309CC00", Offset = "0x309BA00", VA = "0x18309CC00")]
		[IteratorStateMachine(typeof(<GetGameObjectHierarchyHelper>d__8))]
		private static IEnumerable<string> GetGameObjectHierarchyHelper(GameObject go)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class GenericExt
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1A900E0", Offset = "0x1A8EEE0", VA = "0x181A900E0")]
		public static V IfNotNull<V, T>(this T t, Func<T, V> todo, [Optional] V defaultValue) where T : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1300F60", Offset = "0x12FFD60", VA = "0x181300F60")]
		public static void DoIfNotNull<T>(this T t, Action<T> todo) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x186D840", Offset = "0x186C640", VA = "0x18186D840")]
		public static int FindIndex<T>(this IReadOnlyList<T> array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x13013A0", Offset = "0x13001A0", VA = "0x1813013A0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1301430", Offset = "0x1300230", VA = "0x181301430")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x13FF100", Offset = "0x13FDF00", VA = "0x1813FF100")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x186DCC0", Offset = "0x186CAC0", VA = "0x18186DCC0")]
		public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1950DA0", Offset = "0x194FBA0", VA = "0x181950DA0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x15030D0", Offset = "0x1501ED0", VA = "0x1815030D0")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1950550", Offset = "0x194F350", VA = "0x181950550")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1503010", Offset = "0x1501E10", VA = "0x181503010")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x13011E0", Offset = "0x12FFFE0", VA = "0x1813011E0")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x15031B0", Offset = "0x1501FB0", VA = "0x1815031B0")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x19505C0", Offset = "0x194F3C0", VA = "0x1819505C0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1501490", Offset = "0x1500290", VA = "0x181501490")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1950E60", Offset = "0x194FC60", VA = "0x181950E60")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MaterialExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D89100", Offset = "0x1D87F00", VA = "0x181D89100")]
		public static void SetKeywordEnabled(this Material mat, string keyword, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x309EE30", Offset = "0x309DC30", VA = "0x18309EE30")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x309E5F0", Offset = "0x309D3F0", VA = "0x18309E5F0")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x309E790", Offset = "0x309D590", VA = "0x18309E790")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x309D600", Offset = "0x309C400", VA = "0x18309D600")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x309D4E0", Offset = "0x309C2E0", VA = "0x18309D4E0")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x309F920", Offset = "0x309E720", VA = "0x18309F920")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x309F7B0", Offset = "0x309E5B0", VA = "0x18309F7B0")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x309D6E0", Offset = "0x309C4E0", VA = "0x18309D6E0")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x309F4C0", Offset = "0x309E2C0", VA = "0x18309F4C0")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x309D870", Offset = "0x309C670", VA = "0x18309D870")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x309E130", Offset = "0x309CF30", VA = "0x18309E130")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x309D2C0", Offset = "0x309C0C0", VA = "0x18309D2C0")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x309EFF0", Offset = "0x309DDF0", VA = "0x18309EFF0")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x309EE50", Offset = "0x309DC50", VA = "0x18309EE50")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x309F150", Offset = "0x309DF50", VA = "0x18309F150")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x309D350", Offset = "0x309C150", VA = "0x18309D350")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x309DCE0", Offset = "0x309CAE0", VA = "0x18309DCE0")]
		public static Vector3 GetLegacyProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float maxRange, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x309E880", Offset = "0x309D680", VA = "0x18309E880")]
		public static Vector3 GetProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x309EB10", Offset = "0x309D910", VA = "0x18309EB10")]
		private static float GetProjectileMotionLaunchAngleDegrees(Vector3 origin, Vector3 target, float speed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x309EE10", Offset = "0x309DC10", VA = "0x18309EE10")]
		public static float InverseLerpForMin(float maxValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x309EDF0", Offset = "0x309DBF0", VA = "0x18309EDF0")]
		public static float InverseLerpForMax(float minValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x309F5D0", Offset = "0x309E3D0", VA = "0x18309F5D0")]
		public static float SolveQuadraticEquationMaxValue(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x309F6F0", Offset = "0x309E4F0", VA = "0x18309F6F0")]
		public static void SolveQuadraticEquation(float a, float b, float c, out float lowerResult, out float upperResult)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x309F590", Offset = "0x309E390", VA = "0x18309F590")]
		public static float ReMapRange(this float value, Vector2 range, Vector2 newRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x309EDC0", Offset = "0x309DBC0", VA = "0x18309EDC0")]
		public static float GetRandomSign()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x309FB80", Offset = "0x309E980", VA = "0x18309FB80")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x309FBD0", Offset = "0x309E9D0", VA = "0x18309FBD0")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x309FC60", Offset = "0x309EA60", VA = "0x18309FC60")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x309FCB0", Offset = "0x309EAB0", VA = "0x18309FCB0")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x309FAC0", Offset = "0x309E8C0", VA = "0x18309FAC0")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x309FB90", Offset = "0x309E990", VA = "0x18309FB90")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1509E90", Offset = "0x1508C90", VA = "0x181509E90")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x150A170", Offset = "0x1508F70", VA = "0x18150A170")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x30A01D0", Offset = "0x309EFD0", VA = "0x1830A01D0")]
		public static void SortByDistanceToCenter(this RaycastHit[] hits, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x309FD80", Offset = "0x309EB80", VA = "0x18309FD80")]
		public static void ClearVelocity(this Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x309FF40", Offset = "0x309ED40", VA = "0x18309FF40")]
		public static float CombinedBounciness(this PhysicMaterial thisMaterial, PhysicMaterial otherMaterial)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x309FE30", Offset = "0x309EC30", VA = "0x18309FE30")]
		private static float CombinePhysicsMaterialProperty(float lhs, float rhs, PhysicMaterialCombine combineFunction)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E85C0", Offset = "0x6E73C0", VA = "0x1806E85C0")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x201C9F0", Offset = "0x201B7F0", VA = "0x18201C9F0")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x30A4AF0", Offset = "0x30A38F0", VA = "0x1830A4AF0")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x30A0760", Offset = "0x309F560", VA = "0x1830A0760")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x30A0C10", Offset = "0x309FA10", VA = "0x1830A0C10")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x30A0E80", Offset = "0x309FC80", VA = "0x1830A0E80")]
		public static Quaternion ValueOrIdentityIfBogus(this Quaternion quaternion)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x30A0A40", Offset = "0x309F840", VA = "0x1830A0A40")]
		public static bool IsNaN(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x30A09F0", Offset = "0x309F7F0", VA = "0x1830A09F0")]
		public static bool IsInfinity(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x30A0940", Offset = "0x309F740", VA = "0x1830A0940")]
		public static Quaternion InverseTransformRotation(this Quaternion basis, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x30A0DE0", Offset = "0x309FBE0", VA = "0x1830A0DE0")]
		public static Quaternion TransformRotation(this Quaternion parent, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x30A0B50", Offset = "0x309F950", VA = "0x1830A0B50")]
		public static Quaternion RemoveRoll(this Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x30A0890", Offset = "0x309F690", VA = "0x1830A0890")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x30A0A90", Offset = "0x309F890", VA = "0x1830A0A90")]
		public static Quaternion QuaternionFromAngularVelocity(Vector3 angularVelocity)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x30A0500", Offset = "0x309F300", VA = "0x1830A0500")]
		public static Vector3 AngularDisplacementFromTo(Quaternion from, Quaternion to)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x30A0C60", Offset = "0x309FA60", VA = "0x1830A0C60")]
		public static Quaternion SmoothDamp(Quaternion current, Quaternion target, ref Vector3 eulerAngularVelocity, float smoothTime)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x30A1050", Offset = "0x309FE50", VA = "0x1830A1050")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x30A1200", Offset = "0x30A0000", VA = "0x1830A1200")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x30A18F0", Offset = "0x30A06F0", VA = "0x1830A18F0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x30A1720", Offset = "0x30A0520", VA = "0x1830A1720")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x30A1640", Offset = "0x30A0440", VA = "0x1830A1640")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x30A17F0", Offset = "0x30A05F0", VA = "0x1830A17F0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x30A1030", Offset = "0x309FE30", VA = "0x1830A1030")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x30A1450", Offset = "0x30A0250", VA = "0x1830A1450")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x30A12B0", Offset = "0x30A00B0", VA = "0x1830A12B0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x30A1A40", Offset = "0x30A0840", VA = "0x1830A1A40")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x30A1BC0", Offset = "0x30A09C0", VA = "0x1830A1BC0")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x30A1B00", Offset = "0x30A0900", VA = "0x1830A1B00")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class ScreenHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x30A1C80", Offset = "0x30A0A80", VA = "0x1830A1C80")]
		public static float GetLandscapeOrientationScreenAspectRatio()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class StreamingAssetsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x30A1D20", Offset = "0x30A0B20", VA = "0x1830A1D20")]
		public static byte[] LoadBytesFromStreamingAssets(string filename)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x30A1E60", Offset = "0x30A0C60", VA = "0x1830A1E60")]
		private static DownloadHandler LoadFromStreamingAssetsInternal(string filename)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x30A2430", Offset = "0x30A1230", VA = "0x1830A2430")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x30A2040", Offset = "0x30A0E40", VA = "0x1830A2040")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x30A2630", Offset = "0x30A1430", VA = "0x1830A2630")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x30A20A0", Offset = "0x30A0EA0", VA = "0x1830A20A0")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x30A1FC0", Offset = "0x30A0DC0", VA = "0x1830A1FC0")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x30A22E0", Offset = "0x30A10E0", VA = "0x1830A22E0")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x30A2240", Offset = "0x30A1040", VA = "0x1830A2240")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x30A2220", Offset = "0x30A1020", VA = "0x1830A2220")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x30A2230", Offset = "0x30A1030", VA = "0x1830A2230")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x30A2110", Offset = "0x30A0F10", VA = "0x1830A2110")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x30A2190", Offset = "0x30A0F90", VA = "0x1830A2190")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x30A1F90", Offset = "0x30A0D90", VA = "0x1830A1F90")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x30A2370", Offset = "0x30A1170", VA = "0x1830A2370")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x30A23D0", Offset = "0x30A11D0", VA = "0x1830A23D0")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class TextureExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x30A2740", Offset = "0x30A1540", VA = "0x1830A2740")]
		public static void ConvertPixelsToGamma(this Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x30A2850", Offset = "0x30A1650", VA = "0x1830A2850")]
		public static void GetTexture2D(this RenderTexture frame, ref Texture2D texture, bool cropSidesToSquare = false, bool convertToGamma = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly Vector3[] RectCornersBuffer;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x30A41E0", Offset = "0x30A2FE0", VA = "0x1830A41E0")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x30A3160", Offset = "0x30A1F60", VA = "0x1830A3160")]
		public static float GetRectLocalArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x30A3560", Offset = "0x30A2360", VA = "0x1830A3560")]
		public static Vector3 GetRectWorldCenter(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x30A3360", Offset = "0x30A2160", VA = "0x1830A3360")]
		public static float GetRectWorldArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x30A30A0", Offset = "0x30A1EA0", VA = "0x1830A30A0")]
		public static Vector3[] GetInstantaneousWorldCornersNonAlloc(this RectTransform rectTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x30A39F0", Offset = "0x30A27F0", VA = "0x1830A39F0")]
		public static Quaternion InverseTransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x30A4120", Offset = "0x30A2F20", VA = "0x1830A4120")]
		public static Quaternion TransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x30A37B0", Offset = "0x30A25B0", VA = "0x1830A37B0")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1737250", Offset = "0x1736050", VA = "0x181737250")]
		public static float GetLossyUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x30A3130", Offset = "0x30A1F30", VA = "0x1830A3130")]
		public static float GetLocalUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x30A3CD0", Offset = "0x30A2AD0", VA = "0x1830A3CD0")]
		public static void SetLocalUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x30A3B00", Offset = "0x30A2900", VA = "0x1830A3B00")]
		public static void SetLocalScale(this Transform transform, float uniformScale, Vector3 aspectRatio)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x30A3F00", Offset = "0x30A2D00", VA = "0x1830A3F00")]
		public static void SetLossyUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x30A36E0", Offset = "0x30A24E0", VA = "0x1830A36E0")]
		public static float InverseTransformLossyUniformScale(this Transform transform, float uniformLossyScale)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x30A40A0", Offset = "0x30A2EA0", VA = "0x1830A40A0")]
		public static float TransformLocalUniformScale(this Transform transform, float uniformLocalScale)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D060", Offset = "0xA2BE60", VA = "0x180A2D060")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x30A4ED0", Offset = "0x30A3CD0", VA = "0x1830A4ED0")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x30A4DE0", Offset = "0x30A3BE0", VA = "0x1830A4DE0")]
		public static Vector2 Clamp01(this Vector2 vector)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x30A4F80", Offset = "0x30A3D80", VA = "0x1830A4F80")]
		public static bool WithinBounds(this Vector2 bounds, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x30A4B50", Offset = "0x30A3950", VA = "0x1830A4B50")]
		public static float AngleSignedVector2(this Vector2 from, Vector2 to)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x30A5230", Offset = "0x30A4030", VA = "0x1830A5230")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x30A67B0", Offset = "0x30A55B0", VA = "0x1830A67B0")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x30A6BF0", Offset = "0x30A59F0", VA = "0x1830A6BF0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x30A6930", Offset = "0x30A5730", VA = "0x1830A6930")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x30A6A50", Offset = "0x30A5850", VA = "0x1830A6A50")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x30A5B50", Offset = "0x30A4950", VA = "0x1830A5B50")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x30A5D40", Offset = "0x30A4B40", VA = "0x1830A5D40")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x30A5E70", Offset = "0x30A4C70", VA = "0x1830A5E70")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x30A5EE0", Offset = "0x30A4CE0", VA = "0x1830A5EE0")]
		public static bool IsWithinUnitCube(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x30A5FA0", Offset = "0x30A4DA0", VA = "0x1830A5FA0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x30A6030", Offset = "0x30A4E30", VA = "0x1830A6030")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x30A4FB0", Offset = "0x30A3DB0", VA = "0x1830A4FB0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x30A6DD0", Offset = "0x30A5BD0", VA = "0x1830A6DD0")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x30A5530", Offset = "0x30A4330", VA = "0x1830A5530")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x30A5F50", Offset = "0x30A4D50", VA = "0x1830A5F50")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x30A5CE0", Offset = "0x30A4AE0", VA = "0x1830A5CE0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x30A5C80", Offset = "0x30A4A80", VA = "0x1830A5C80")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x30A6180", Offset = "0x30A4F80", VA = "0x1830A6180")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x30A56A0", Offset = "0x30A44A0", VA = "0x1830A56A0")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x30A5070", Offset = "0x30A3E70", VA = "0x1830A5070")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x30A6E90", Offset = "0x30A5C90", VA = "0x1830A6E90")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x30A5790", Offset = "0x30A4590", VA = "0x1830A5790")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x30A5730", Offset = "0x30A4530", VA = "0x1830A5730")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x30A5760", Offset = "0x30A4560", VA = "0x1830A5760")]
		public static Vector3 FromY(float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x30A65A0", Offset = "0x30A53A0", VA = "0x1830A65A0")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x30A65E0", Offset = "0x30A53E0", VA = "0x1830A65E0")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x30A6620", Offset = "0x30A5420", VA = "0x1830A6620")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x30A6870", Offset = "0x30A5670", VA = "0x1830A6870")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x30A60C0", Offset = "0x30A4EC0", VA = "0x1830A60C0")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x30A6210", Offset = "0x30A5010", VA = "0x1830A6210")]
		public static Vector3 ProjectDirectionOntoSurface(Vector3 desiredDirection, Vector3 surfaceNormal, Vector3 up)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x30A6350", Offset = "0x30A5150", VA = "0x1830A6350")]
		public static Vector3 ProjectGroundSpaceVectorOnToWall(Vector3 vector, Vector3 wallUp, Vector3 wallNormal, bool allowedToMoveUp)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x30A6660", Offset = "0x30A5460", VA = "0x1830A6660")]
		public static float SignedAngleOnPlane(this Vector3 from, Vector3 to, Vector3 planeNormalAxis, bool shiftPositive = false)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1302EB0", Offset = "0x1301CB0", VA = "0x181302EB0")]
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

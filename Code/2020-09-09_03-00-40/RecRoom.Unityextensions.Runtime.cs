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
			[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x1E46CC0", Offset = "0x1E458C0", VA = "0x181E46CC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x19A3190", Offset = "0x19A1D90", VA = "0x1819A3190")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2045030", Offset = "0x2043C30", VA = "0x182045030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x223E470", Offset = "0x223D070", VA = "0x18223E470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2045100", Offset = "0x2043D00", VA = "0x182045100", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C61280", Offset = "0x1C5FE80", VA = "0x181C61280", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0690", Offset = "0x1DDF290", VA = "0x181DE0690")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DE01E0", Offset = "0x1DDEDE0", VA = "0x181DE01E0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x170C830", Offset = "0x170B430", VA = "0x18170C830")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1DE0940", Offset = "0x1DDF540", VA = "0x181DE0940")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x14EA90", Offset = "0x14DE90")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D9CC80", Offset = "0x1D9B880", VA = "0x181D9CC80")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2250390", Offset = "0x224EF90", VA = "0x182250390")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D9CE80", Offset = "0x1D9BA80", VA = "0x181D9CE80")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D9CE40", Offset = "0x1D9BA40", VA = "0x181D9CE40")]
	public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int skip, int take)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D9CAB0", Offset = "0x1D9B6B0", VA = "0x181D9CAB0")]
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keyFunc)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2570", Offset = "0x2FC1170", VA = "0x182FC2570")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FC81B0", Offset = "0x2FC6DB0", VA = "0x182FC81B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2FC8220", Offset = "0x2FC6E20", VA = "0x182FC8220")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8350", Offset = "0x2FC6F50", VA = "0x182FC8350")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2FC82C0", Offset = "0x2FC6EC0", VA = "0x182FC82C0")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2FC92C0", Offset = "0x2FC7EC0", VA = "0x182FC92C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FBEC80", Offset = "0x2FBD880", VA = "0x182FBEC80")]
		public static void SafeSetEnabled(this Animator animator, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBED00", Offset = "0x2FBD900", VA = "0x182FBED00")]
		public static void SetBoolIfActive(this Animator animator, int id, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBED60", Offset = "0x2FBD960", VA = "0x182FBED60")]
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

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x334950", Offset = "0x333D50", VA = "0x180334950")]
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

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2616A00", Offset = "0x2615600", VA = "0x182616A00")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x26162A0", Offset = "0x2614EA0", VA = "0x1826162A0")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9F30", Offset = "0x1DA8B30", VA = "0x181DA9F30")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1B63440", Offset = "0x1B62040", VA = "0x181B63440")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1B63340", Offset = "0x1B61F40", VA = "0x181B63340")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DCE7C0", Offset = "0x1DCD3C0", VA = "0x181DCE7C0")]
		public static int FindIndex<T>(this T[] array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EF30", Offset = "0x1F1DB30", VA = "0x181F1EF30")]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1B644E0", Offset = "0x1B630E0", VA = "0x181B644E0")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1B64370", Offset = "0x1B62F70", VA = "0x181B64370")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1B63E20", Offset = "0x1B62A20", VA = "0x181B63E20")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1B63A00", Offset = "0x1B62600", VA = "0x181B63A00")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1B63EB0", Offset = "0x1B62AB0", VA = "0x181B63EB0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1B635B0", Offset = "0x1B621B0", VA = "0x181B635B0")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1E02FF0", Offset = "0x1E01BF0", VA = "0x181E02FF0")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA040", Offset = "0x1DA8C40", VA = "0x181DAA040")]
		public static T[] Sort<T>(this T[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9480", Offset = "0x1DA8080", VA = "0x181DA9480")]
		public static T[] CopyAndAdd<T>(this T[] oldArray, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9560", Offset = "0x1DA8160", VA = "0x181DA9560")]
		public static T[] CopyAndInsert<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9C60", Offset = "0x1DA8860", VA = "0x181DA9C60")]
		public static T[] CopyAndRemoveAt<T>(this T[] oldArray, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9D10", Offset = "0x1DA8910", VA = "0x181DA9D10")]
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

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x369FD0", Offset = "0x3693D0", VA = "0x180369FD0")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x369E30", Offset = "0x369230", VA = "0x180369E30", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x369E60", Offset = "0x369260", VA = "0x180369E60", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x369F00", Offset = "0x369300", VA = "0x180369F00", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x369FC0", Offset = "0x3693C0", VA = "0x180369FC0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF530", Offset = "0x2FBE130", VA = "0x182FBF530")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE9E0", Offset = "0x1AAD5E0", VA = "0x181AAE9E0")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFDC0", Offset = "0x1DEE9C0", VA = "0x181DEFDC0")]
		public static IReadOnlyList<T> GetCachedComponentsInParent<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFCA0", Offset = "0x1DEE8A0", VA = "0x181DEFCA0")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1AAEB00", Offset = "0x1AAD700", VA = "0x181AAEB00")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFEE0", Offset = "0x1DEEAE0", VA = "0x181DEFEE0")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFA10", Offset = "0x2FBE610", VA = "0x182FBFA10")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF5C0", Offset = "0x2FBE1C0", VA = "0x182FBF5C0")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF0090", Offset = "0x1DEEC90", VA = "0x181DF0090")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF0190", Offset = "0x1DEED90", VA = "0x181DF0190")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CameraExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0070", Offset = "0x2FBEC70", VA = "0x182FC0070")]
		public static float GetFrustumHeightAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2FC00A0", Offset = "0x2FBECA0", VA = "0x182FC00A0")]
		public static float GetFrustumWidthAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2FC00F0", Offset = "0x2FBECF0", VA = "0x182FC00F0")]
		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFBE0", Offset = "0x2FBE7E0", VA = "0x182FBFBE0")]
		private static float GetCameraDistanceToHeightRatio(float cameraFieldOfView)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFC50", Offset = "0x2FBE850", VA = "0x182FBFC50")]
		private static float GetCameraDistanceToHeightRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFCD0", Offset = "0x2FBE8D0", VA = "0x182FBFCD0")]
		private static float GetCameraDistanceToWidthRatio(float cameraFieldOfView, float cameraAspectRatio)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFD50", Offset = "0x2FBE950", VA = "0x182FBFD50")]
		private static float GetCameraDistanceToWidthRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFF60", Offset = "0x2FBEB60", VA = "0x182FBFF60")]
		public static float GetDistanceFromProjectionCameraToFillFOV(float cameraFieldOfView, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFE40", Offset = "0x2FBEA40", VA = "0x182FBFE40")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFE80", Offset = "0x2FBEA80", VA = "0x182FBFE80")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, Vector2 worldSpaceSize, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFD90", Offset = "0x2FBE990", VA = "0x182FBFD90")]
		private static float GetDistanceFromProjectionCameraToFillFOVInternal(float distanceToSizeRatio, float worldSpaceSize, float viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0260", Offset = "0x2FBEE60", VA = "0x182FC0260")]
		public static float GetScaleFactorFromProjectionCameraToFillFOVAtDistance(float cameraFOV, float cameraAspectRatio, Vector2 worldSpaceSize, float desiredDistance, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2FC01A0", Offset = "0x2FBEDA0", VA = "0x182FC01A0")]
		private static float GetScaleFactorFromProjectionCameraToFillFOVAtDistanceInternal(float distanceToSizeRatio, float worldSpaceSize, float desiredDistance, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFB50", Offset = "0x2FBE750", VA = "0x182FBFB50")]
		public static void CleanupRenderTexture(this Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0460", Offset = "0x2FBF060", VA = "0x182FC0460")]
		public static bool IsInFov(this Camera camera, Renderer renderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2FC03E0", Offset = "0x2FBEFE0", VA = "0x182FC03E0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2FC04C0", Offset = "0x2FBF0C0", VA = "0x182FC04C0")]
		public static bool CapsuleCast(this Collider collider, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0FC0", Offset = "0x2FBFBC0", VA = "0x182FC0FC0")]
		public static int GetOverlapNonAlloc(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction, Collider[] hitColliders)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0B30", Offset = "0x2FBF730", VA = "0x182FC0B30")]
		public static bool CheckOverlap(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1280", Offset = "0x2FBFE80", VA = "0x182FC1280")]
		public static int Overlap(this BoxCollider collider, Collider[] hits, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0DD0", Offset = "0x2FBF9D0", VA = "0x182FC0DD0")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0790", Offset = "0x2FBF390", VA = "0x182FC0790")]
		public static bool CheckOverlap(this CapsuleCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ColorExt
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC16C0", Offset = "0x2FC02C0", VA = "0x182FC16C0")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC15D0", Offset = "0x2FC01D0", VA = "0x182FC15D0")]
		public static Vector3 GammaToLinearColorSpace(this Vector3 gammaColor)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1590", Offset = "0x2FC0190", VA = "0x182FC1590")]
		public static Color ChangeAlpha(this Color color, float newAlpha)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1700", Offset = "0x2FC0300", VA = "0x182FC1700")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1DF0460", Offset = "0x1DEF060", VA = "0x181DF0460")]
		public static List<T> FindAllObjectsOfType<T>(this Component component) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1AAEDE0", Offset = "0x1AAD9E0", VA = "0x181AAEDE0")]
		public static T GetComponentInParent<T>(this Component component, bool includeDisabled) where T : Component
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
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x19A3190", Offset = "0x19A1D90", VA = "0x1819A3190")]
			[DebuggerHidden]
			public <GetAllComponentsInScenes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x19A2F30", Offset = "0x19A1B30", VA = "0x1819A2F30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x19A3140", Offset = "0x19A1D40", VA = "0x1819A3140", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x19A30A0", Offset = "0x19A1CA0", VA = "0x1819A30A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x189D0B0", Offset = "0x189BCB0", VA = "0x18189D0B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1D9C0A0", Offset = "0x1D9ACA0", VA = "0x181D9C0A0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3BF6E0", Offset = "0x3BE2E0", VA = "0x1803BF6E0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9860", Offset = "0x2FC8460", VA = "0x182FC9860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9910", Offset = "0x2FC8510", VA = "0x182FC9910", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3BF6E0", Offset = "0x3BE2E0", VA = "0x1803BF6E0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9480", Offset = "0x2FC8080", VA = "0x182FC9480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9530", Offset = "0x2FC8130", VA = "0x182FC9530", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1B50", Offset = "0x2FC0750", VA = "0x182FC1B50")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1AF0", Offset = "0x2FC06F0", VA = "0x182FC1AF0")]
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
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2FCBB10", Offset = "0x2FCA710", VA = "0x182FCBB10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBAE0", Offset = "0x2FCA6E0", VA = "0x182FCBAE0")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DictionaryExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAC40", Offset = "0x1DA9840", VA = "0x181DAAC40")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EncodingExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1C20", Offset = "0x2FC0820", VA = "0x182FC1C20")]
		public static string ToBase64String(this Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1D00", Offset = "0x2FC0900", VA = "0x182FC1D00")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FileExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1DE0", Offset = "0x2FC09E0", VA = "0x182FC1DE0")]
		public static string ReadLines(this FileInfo file, string startPattern, string endPattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1FC0", Offset = "0x2FC0BC0", VA = "0x182FC1FC0")]
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
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x39C240", Offset = "0x39AE40", VA = "0x18039C240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x608140", Offset = "0x606D40", VA = "0x180608140")]
			[DebuggerHidden]
			public <GetGameObjectHierarchyHelper>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9580", Offset = "0x2FC8180", VA = "0x182FC9580", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9710", Offset = "0x2FC8310", VA = "0x182FC9710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9670", Offset = "0x2FC8270", VA = "0x182FC9670", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2FC9670", Offset = "0x2FC8270", VA = "0x182FC9670", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1240", Offset = "0x1AAFE40", VA = "0x181AB1240")]
		public static T GetComponentInParent<T>(this GameObject gameObject, bool includeDisabled) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1AB1360", Offset = "0x1AAFF60", VA = "0x181AB1360")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2310", Offset = "0x2FC0F10", VA = "0x182FC2310")]
		public static void SetTagRecursively(this GameObject gameObject, string tag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2FC21E0", Offset = "0x2FC0DE0", VA = "0x182FC21E0")]
		public static string GetGameObjectHierarchy(this GameObject go)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2170", Offset = "0x2FC0D70", VA = "0x182FC2170")]
		[IteratorStateMachine(typeof(<GetGameObjectHierarchyHelper>d__8))]
		private static IEnumerable<string> GetGameObjectHierarchyHelper(GameObject go)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class GenericExt
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEBC0", Offset = "0x1DAD7C0", VA = "0x181DAEBC0")]
		public static V IfNotNull<V, T>(this T t, Func<T, V> todo, [Optional] V defaultValue) where T : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1B69E80", Offset = "0x1B68A80", VA = "0x181B69E80")]
		public static void DoIfNotNull<T>(this T t, Action<T> todo) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A510", Offset = "0x1B69110", VA = "0x181B6A510")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A5A0", Offset = "0x1B691A0", VA = "0x181B6A5A0")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4E80", Offset = "0x1DF3A80", VA = "0x181DF4E80")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1F33100", Offset = "0x1F31D00", VA = "0x181F33100")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2AD0", Offset = "0x1AB16D0", VA = "0x181AB2AD0")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1F32B70", Offset = "0x1F31770", VA = "0x181F32B70")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2A10", Offset = "0x1AB1610", VA = "0x181AB2A10")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A350", Offset = "0x1B68F50", VA = "0x181B6A350")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2BC0", Offset = "0x1AB17C0", VA = "0x181AB2BC0")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1AB2B50", Offset = "0x1AB1750", VA = "0x181AB2B50")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F32BE0", Offset = "0x1F317E0", VA = "0x181F32BE0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1A67070", Offset = "0x1A65C70", VA = "0x181A67070")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1F331C0", Offset = "0x1F31DC0", VA = "0x181F331C0")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MaterialExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x660220", Offset = "0x65EE20", VA = "0x180660220")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC43A0", Offset = "0x2FC2FA0", VA = "0x182FC43A0")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3B60", Offset = "0x2FC2760", VA = "0x182FC3B60")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3D00", Offset = "0x2FC2900", VA = "0x182FC3D00")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2B70", Offset = "0x2FC1770", VA = "0x182FC2B70")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2A50", Offset = "0x2FC1650", VA = "0x182FC2A50")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4E90", Offset = "0x2FC3A90", VA = "0x182FC4E90")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4D20", Offset = "0x2FC3920", VA = "0x182FC4D20")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2C50", Offset = "0x2FC1850", VA = "0x182FC2C50")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4A30", Offset = "0x2FC3630", VA = "0x182FC4A30")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2DE0", Offset = "0x2FC19E0", VA = "0x182FC2DE0")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC36A0", Offset = "0x2FC22A0", VA = "0x182FC36A0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC2830", Offset = "0x2FC1430", VA = "0x182FC2830")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4560", Offset = "0x2FC3160", VA = "0x182FC4560")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2FC43C0", Offset = "0x2FC2FC0", VA = "0x182FC43C0")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2FC46C0", Offset = "0x2FC32C0", VA = "0x182FC46C0")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC28C0", Offset = "0x2FC14C0", VA = "0x182FC28C0")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3250", Offset = "0x2FC1E50", VA = "0x182FC3250")]
		public static Vector3 GetLegacyProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float maxRange, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3DF0", Offset = "0x2FC29F0", VA = "0x182FC3DF0")]
		public static Vector3 GetProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4080", Offset = "0x2FC2C80", VA = "0x182FC4080")]
		private static float GetProjectileMotionLaunchAngleDegrees(Vector3 origin, Vector3 target, float speed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4380", Offset = "0x2FC2F80", VA = "0x182FC4380")]
		public static float InverseLerpForMin(float maxValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4360", Offset = "0x2FC2F60", VA = "0x182FC4360")]
		public static float InverseLerpForMax(float minValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4B40", Offset = "0x2FC3740", VA = "0x182FC4B40")]
		public static float SolveQuadraticEquationMaxValue(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4C60", Offset = "0x2FC3860", VA = "0x182FC4C60")]
		public static void SolveQuadraticEquation(float a, float b, float c, out float lowerResult, out float upperResult)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4B00", Offset = "0x2FC3700", VA = "0x182FC4B00")]
		public static float ReMapRange(this float value, Vector2 range, Vector2 newRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC4330", Offset = "0x2FC2F30", VA = "0x182FC4330")]
		public static float GetRandomSign()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC50F0", Offset = "0x2FC3CF0", VA = "0x182FC50F0")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5140", Offset = "0x2FC3D40", VA = "0x182FC5140")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC51D0", Offset = "0x2FC3DD0", VA = "0x182FC51D0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5220", Offset = "0x2FC3E20", VA = "0x182FC5220")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5030", Offset = "0x2FC3C30", VA = "0x182FC5030")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5100", Offset = "0x2FC3D00", VA = "0x182FC5100")]
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

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3B00", Offset = "0x1AB2700", VA = "0x181AB3B00")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3DE0", Offset = "0x1AB29E0", VA = "0x181AB3DE0")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5740", Offset = "0x2FC4340", VA = "0x182FC5740")]
		public static void SortByDistanceToCenter(this RaycastHit[] hits, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC52F0", Offset = "0x2FC3EF0", VA = "0x182FC52F0")]
		public static void ClearVelocity(this Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC54B0", Offset = "0x2FC40B0", VA = "0x182FC54B0")]
		public static float CombinedBounciness(this PhysicMaterial thisMaterial, PhysicMaterial otherMaterial)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC53A0", Offset = "0x2FC3FA0", VA = "0x182FC53A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xCCB500", Offset = "0xCCA100", VA = "0x180CCB500")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2887530", Offset = "0x2886130", VA = "0x182887530")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9960", Offset = "0x2FC8560", VA = "0x182FC9960")]
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

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5CD0", Offset = "0x2FC48D0", VA = "0x182FC5CD0")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6180", Offset = "0x2FC4D80", VA = "0x182FC6180")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC63F0", Offset = "0x2FC4FF0", VA = "0x182FC63F0")]
		public static Quaternion ValueOrIdentityIfBogus(this Quaternion quaternion)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5FB0", Offset = "0x2FC4BB0", VA = "0x182FC5FB0")]
		public static bool IsNaN(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5F60", Offset = "0x2FC4B60", VA = "0x182FC5F60")]
		public static bool IsInfinity(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5EB0", Offset = "0x2FC4AB0", VA = "0x182FC5EB0")]
		public static Quaternion InverseTransformRotation(this Quaternion basis, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6350", Offset = "0x2FC4F50", VA = "0x182FC6350")]
		public static Quaternion TransformRotation(this Quaternion parent, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2FC60C0", Offset = "0x2FC4CC0", VA = "0x182FC60C0")]
		public static Quaternion RemoveRoll(this Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5E00", Offset = "0x2FC4A00", VA = "0x182FC5E00")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6000", Offset = "0x2FC4C00", VA = "0x182FC6000")]
		public static Quaternion QuaternionFromAngularVelocity(Vector3 angularVelocity)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC5A70", Offset = "0x2FC4670", VA = "0x182FC5A70")]
		public static Vector3 AngularDisplacementFromTo(Quaternion from, Quaternion to)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC61D0", Offset = "0x2FC4DD0", VA = "0x182FC61D0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC65C0", Offset = "0x2FC51C0", VA = "0x182FC65C0")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6770", Offset = "0x2FC5370", VA = "0x182FC6770")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6E60", Offset = "0x2FC5A60", VA = "0x182FC6E60")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6C90", Offset = "0x2FC5890", VA = "0x182FC6C90")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6BB0", Offset = "0x2FC57B0", VA = "0x182FC6BB0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6D60", Offset = "0x2FC5960", VA = "0x182FC6D60")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2FC65A0", Offset = "0x2FC51A0", VA = "0x182FC65A0")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FC69C0", Offset = "0x2FC55C0", VA = "0x182FC69C0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6820", Offset = "0x2FC5420", VA = "0x182FC6820")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class ResourcesHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1AB4630", Offset = "0x1AB3230", VA = "0x181AB4630")]
		public static T SafeLoad<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6FB0", Offset = "0x2FC5BB0", VA = "0x182FC6FB0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7130", Offset = "0x2FC5D30", VA = "0x182FC7130")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7070", Offset = "0x2FC5C70", VA = "0x182FC7070")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class ScreenHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2FC71F0", Offset = "0x2FC5DF0", VA = "0x182FC71F0")]
		public static float GetLandscapeOrientationScreenAspectRatio()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class StreamingAssetsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7290", Offset = "0x2FC5E90", VA = "0x182FC7290")]
		public static byte[] LoadBytesFromStreamingAssets(string filename)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FC73D0", Offset = "0x2FC5FD0", VA = "0x182FC73D0")]
		private static DownloadHandler LoadFromStreamingAssetsInternal(string filename)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC79A0", Offset = "0x2FC65A0", VA = "0x182FC79A0")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2FC75B0", Offset = "0x2FC61B0", VA = "0x182FC75B0")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7BA0", Offset = "0x2FC67A0", VA = "0x182FC7BA0")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7610", Offset = "0x2FC6210", VA = "0x182FC7610")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7530", Offset = "0x2FC6130", VA = "0x182FC7530")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7850", Offset = "0x2FC6450", VA = "0x182FC7850")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2FC77B0", Offset = "0x2FC63B0", VA = "0x182FC77B0")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7790", Offset = "0x2FC6390", VA = "0x182FC7790")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2FC77A0", Offset = "0x2FC63A0", VA = "0x182FC77A0")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7680", Offset = "0x2FC6280", VA = "0x182FC7680")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7700", Offset = "0x2FC6300", VA = "0x182FC7700")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7500", Offset = "0x2FC6100", VA = "0x182FC7500")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2FC78E0", Offset = "0x2FC64E0", VA = "0x182FC78E0")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7940", Offset = "0x2FC6540", VA = "0x182FC7940")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class TextureExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7CB0", Offset = "0x2FC68B0", VA = "0x182FC7CB0")]
		public static void ConvertPixelsToGamma(this Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7DC0", Offset = "0x2FC69C0", VA = "0x182FC7DC0")]
		public static void GetTexture2D(this RenderTexture frame, ref Texture2D texture, bool cropSidesToSquare = false, bool convertToGamma = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2FC90A0", Offset = "0x2FC7CA0", VA = "0x182FC90A0")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8930", Offset = "0x2FC7530", VA = "0x182FC8930")]
		public static Quaternion InverseTransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8FE0", Offset = "0x2FC7BE0", VA = "0x182FC8FE0")]
		public static Quaternion TransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2FC86F0", Offset = "0x2FC72F0", VA = "0x182FC86F0")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x40BF90", Offset = "0x40AB90", VA = "0x18040BF90")]
		public static float GetLossyUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8610", Offset = "0x2FC7210", VA = "0x182FC8610")]
		public static float GetLocalUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8C10", Offset = "0x2FC7810", VA = "0x182FC8C10")]
		public static void SetLocalUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8A40", Offset = "0x2FC7640", VA = "0x182FC8A40")]
		public static void SetLocalScale(this Transform transform, float uniformScale, Vector3 aspectRatio)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8E20", Offset = "0x2FC7A20", VA = "0x182FC8E20")]
		public static void SetLossyUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8640", Offset = "0x2FC7240", VA = "0x182FC8640")]
		public static float InverseTransformLossyUniformScale(this Transform transform, float uniformLossyScale)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8FA0", Offset = "0x2FC7BA0", VA = "0x182FC8FA0")]
		public static float TransformLocalUniformScale(this Transform transform, float uniformLocalScale)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x17F6E50", Offset = "0x17F5A50", VA = "0x1817F6E50")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9C50", Offset = "0x2FC8850", VA = "0x182FC9C50")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9D00", Offset = "0x2FC8900", VA = "0x182FC9D00")]
		public static bool WithinBounds(this Vector2 bounds, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2FC99C0", Offset = "0x2FC85C0", VA = "0x182FC99C0")]
		public static float AngleSignedVector2(this Vector2 from, Vector2 to)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9FB0", Offset = "0x2FC8BB0", VA = "0x182FC9FB0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB370", Offset = "0x2FC9F70", VA = "0x182FCB370")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB7B0", Offset = "0x2FCA3B0", VA = "0x182FCB7B0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB4F0", Offset = "0x2FCA0F0", VA = "0x182FCB4F0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB610", Offset = "0x2FCA210", VA = "0x182FCB610")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA8D0", Offset = "0x2FC94D0", VA = "0x182FCA8D0")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAAC0", Offset = "0x2FC96C0", VA = "0x182FCAAC0")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2FCABF0", Offset = "0x2FC97F0", VA = "0x182FCABF0")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2FCACB0", Offset = "0x2FC98B0", VA = "0x182FCACB0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAD40", Offset = "0x2FC9940", VA = "0x182FCAD40")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9D30", Offset = "0x2FC8930", VA = "0x182FC9D30")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB990", Offset = "0x2FCA590", VA = "0x182FCB990")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA2B0", Offset = "0x2FC8EB0", VA = "0x182FCA2B0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAC60", Offset = "0x2FC9860", VA = "0x182FCAC60")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAA60", Offset = "0x2FC9660", VA = "0x182FCAA60")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAA00", Offset = "0x2FC9600", VA = "0x182FCAA00")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAE90", Offset = "0x2FC9A90", VA = "0x182FCAE90")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA420", Offset = "0x2FC9020", VA = "0x182FCA420")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9DF0", Offset = "0x2FC89F0", VA = "0x182FC9DF0")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2FCBA50", Offset = "0x2FCA650", VA = "0x182FCBA50")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA510", Offset = "0x2FC9110", VA = "0x182FCA510")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA4B0", Offset = "0x2FC90B0", VA = "0x182FCA4B0")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2FCA4E0", Offset = "0x2FC90E0", VA = "0x182FCA4E0")]
		public static Vector3 FromY(float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB2B0", Offset = "0x2FC9EB0", VA = "0x182FCB2B0")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB2F0", Offset = "0x2FC9EF0", VA = "0x182FCB2F0")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB330", Offset = "0x2FC9F30", VA = "0x182FCB330")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB430", Offset = "0x2FCA030", VA = "0x182FCB430")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2FCADD0", Offset = "0x2FC99D0", VA = "0x182FCADD0")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2FCAF20", Offset = "0x2FC9B20", VA = "0x182FCAF20")]
		public static Vector3 ProjectDirectionOntoSurface(Vector3 desiredDirection, Vector3 surfaceNormal, Vector3 up)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2FCB060", Offset = "0x2FC9C60", VA = "0x182FCB060")]
		public static Vector3 ProjectGroundSpaceVectorOnToWall(Vector3 vector, Vector3 wallUp, Vector3 wallNormal, bool allowedToMoveUp)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C4F0", Offset = "0x1B6B0F0", VA = "0x181B6C4F0")]
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

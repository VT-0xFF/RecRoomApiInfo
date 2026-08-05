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
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xFDF910", Offset = "0xFDEB10", VA = "0x180FDF910", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xFDF960", Offset = "0xFDEB60", VA = "0x180FDF960")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xFDF7A0", Offset = "0xFDE9A0", VA = "0x180FDF7A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFDF870", Offset = "0xFDEA70", VA = "0x180FDF870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xFDF7D0", Offset = "0xFDE9D0", VA = "0x180FDF7D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xFC4A10", Offset = "0xFC3C10", VA = "0x180FC4A10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15A7EE0", Offset = "0x15A70E0", VA = "0x1815A7EE0")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15A7A30", Offset = "0x15A6C30", VA = "0x1815A7A30")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAFFC90", Offset = "0xAFEE90", VA = "0x180AFFC90")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15A8190", Offset = "0x15A7390", VA = "0x1815A8190")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x52E00", Offset = "0x52200")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1507F80", Offset = "0x1507180", VA = "0x181507F80")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1BEA860", Offset = "0x1BE9A60", VA = "0x181BEA860")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13AAC60", Offset = "0x13A9E60", VA = "0x1813AAC60")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1508140", Offset = "0x1507340", VA = "0x181508140")]
	public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int skip, int take)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1507DB0", Offset = "0x1506FB0", VA = "0x181507DB0")]
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keyFunc)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3061650", Offset = "0x3060850", VA = "0x183061650")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class TimeExt
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float MinHypotheticalDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3067670", Offset = "0x3066870", VA = "0x183067670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float MaxHypotheticalDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x529910", Offset = "0x528B10", VA = "0x180529910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float SafeDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3067680", Offset = "0x3066880", VA = "0x183067680")]
		get
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30676F0", Offset = "0x30668F0", VA = "0x1830676F0")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3067820", Offset = "0x3066A20", VA = "0x183067820")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3067790", Offset = "0x3066990", VA = "0x183067790")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3069150", Offset = "0x3068350", VA = "0x183069150")]
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
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x305DCD0", Offset = "0x305CED0", VA = "0x18305DCD0")]
		public static void SafeSetEnabled(this Animator animator, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x305DD50", Offset = "0x305CF50", VA = "0x18305DD50")]
		public static void SetBoolIfActive(this Animator animator, int id, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x305DDB0", Offset = "0x305CFB0", VA = "0x18305DDB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2A1C20", Offset = "0x2A1020", VA = "0x1802A1C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x23D0570", Offset = "0x23CF770", VA = "0x1823D0570")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x23CFE10", Offset = "0x23CF010", VA = "0x1823CFE10")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x12AD7E0", Offset = "0x12AC9E0", VA = "0x1812AD7E0")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xFF7980", Offset = "0xFF6B80", VA = "0x180FF7980")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xFF7880", Offset = "0xFF6A80", VA = "0x180FF7880")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFF8A20", Offset = "0xFF7C20", VA = "0x180FF8A20")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xFF88B0", Offset = "0xFF7AB0", VA = "0x180FF88B0")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xFF8360", Offset = "0xFF7560", VA = "0x180FF8360")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xFF7F40", Offset = "0xFF7140", VA = "0x180FF7F40")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xFF83F0", Offset = "0xFF75F0", VA = "0x180FF83F0")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xFF7AF0", Offset = "0xFF6CF0", VA = "0x180FF7AF0")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x13AAA10", Offset = "0x13A9C10", VA = "0x1813AAA10")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12AD8F0", Offset = "0x12ACAF0", VA = "0x1812AD8F0")]
		public static T[] Sort<T>(this T[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12ACE90", Offset = "0x12AC090", VA = "0x1812ACE90")]
		public static T[] CopyAndAdd<T>(this T[] oldArray, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12ACF70", Offset = "0x12AC170", VA = "0x1812ACF70")]
		public static T[] CopyAndInsert<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12AD510", Offset = "0x12AC710", VA = "0x1812AD510")]
		public static T[] CopyAndRemoveAt<T>(this T[] oldArray, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x12AD5C0", Offset = "0x12AC7C0", VA = "0x1812AD5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EC320", Offset = "0x2EB720", VA = "0x1802EC320")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2EC180", Offset = "0x2EB580", VA = "0x1802EC180", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2EC1B0", Offset = "0x2EB5B0", VA = "0x1802EC1B0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2EC250", Offset = "0x2EB650", VA = "0x1802EC250", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2EC310", Offset = "0x2EB710", VA = "0x1802EC310", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x305E580", Offset = "0x305D780", VA = "0x18305E580")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x115A720", Offset = "0x1159920", VA = "0x18115A720")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDDEF40", Offset = "0xDDE140", VA = "0x180DDEF40")]
		public static IReadOnlyList<T> GetCachedComponentsInParent<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xDDEE20", Offset = "0xDDE020", VA = "0x180DDEE20")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x115A840", Offset = "0x1159A40", VA = "0x18115A840")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDDF060", Offset = "0xDDE260", VA = "0x180DDF060")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x305EA60", Offset = "0x305DC60", VA = "0x18305EA60")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x305E610", Offset = "0x305D810", VA = "0x18305E610")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDDF210", Offset = "0xDDE410", VA = "0x180DDF210")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xDDF310", Offset = "0xDDE510", VA = "0x180DDF310")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CameraExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x305F0C0", Offset = "0x305E2C0", VA = "0x18305F0C0")]
		public static float GetFrustumHeightAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x305F0F0", Offset = "0x305E2F0", VA = "0x18305F0F0")]
		public static float GetFrustumWidthAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x305F140", Offset = "0x305E340", VA = "0x18305F140")]
		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x305EC30", Offset = "0x305DE30", VA = "0x18305EC30")]
		private static float GetCameraDistanceToHeightRatio(float cameraFieldOfView)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x305ECA0", Offset = "0x305DEA0", VA = "0x18305ECA0")]
		private static float GetCameraDistanceToHeightRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x305ED20", Offset = "0x305DF20", VA = "0x18305ED20")]
		private static float GetCameraDistanceToWidthRatio(float cameraFieldOfView, float cameraAspectRatio)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x305EDA0", Offset = "0x305DFA0", VA = "0x18305EDA0")]
		private static float GetCameraDistanceToWidthRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x305EFB0", Offset = "0x305E1B0", VA = "0x18305EFB0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(float cameraFieldOfView, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x305EE90", Offset = "0x305E090", VA = "0x18305EE90")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x305EED0", Offset = "0x305E0D0", VA = "0x18305EED0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, Vector2 worldSpaceSize, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x305EDE0", Offset = "0x305DFE0", VA = "0x18305EDE0")]
		private static float GetDistanceFromProjectionCameraToFillFOVInternal(float distanceToSizeRatio, float worldSpaceSize, float viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x305F2B0", Offset = "0x305E4B0", VA = "0x18305F2B0")]
		public static float GetScaleFactorFromProjectionCameraToFillFOVAtDistance(float cameraFOV, float cameraAspectRatio, Vector2 worldSpaceSize, float desiredDistance, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x305F1F0", Offset = "0x305E3F0", VA = "0x18305F1F0")]
		private static float GetScaleFactorFromProjectionCameraToFillFOVAtDistanceInternal(float distanceToSizeRatio, float worldSpaceSize, float desiredDistance, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x305EBA0", Offset = "0x305DDA0", VA = "0x18305EBA0")]
		public static void CleanupRenderTexture(this Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x305F4B0", Offset = "0x305E6B0", VA = "0x18305F4B0")]
		public static bool IsInFov(this Camera camera, Renderer renderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x305F430", Offset = "0x305E630", VA = "0x18305F430")]
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
		[Cpp2IlInjected.Address(RVA = "0x305F510", Offset = "0x305E710", VA = "0x18305F510")]
		public static bool CapsuleCast(this Collider collider, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3060030", Offset = "0x305F230", VA = "0x183060030")]
		public static int GetOverlapNonAlloc(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction, Collider[] hitColliders)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x305FBA0", Offset = "0x305EDA0", VA = "0x18305FBA0")]
		public static bool CheckOverlap(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x30602F0", Offset = "0x305F4F0", VA = "0x1830602F0")]
		public static int Overlap(this BoxCollider collider, Collider[] hits, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x305FE40", Offset = "0x305F040", VA = "0x18305FE40")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x305F7E0", Offset = "0x305E9E0", VA = "0x18305F7E0")]
		public static bool CheckOverlap(this CapsuleCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ColorExt
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly Color RECROOM_ORANGE;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3060730", Offset = "0x305F930", VA = "0x183060730")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3060640", Offset = "0x305F840", VA = "0x183060640")]
		public static Vector3 GammaToLinearColorSpace(this Vector3 gammaColor)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3060600", Offset = "0x305F800", VA = "0x183060600")]
		public static Color ChangeAlpha(this Color color, float newAlpha)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x30607E0", Offset = "0x305F9E0", VA = "0x1830607E0")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xDDF5E0", Offset = "0xDDE7E0", VA = "0x180DDF5E0")]
		public static List<T> FindAllObjectsOfType<T>(this Component component) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x115B250", Offset = "0x115A450", VA = "0x18115B250")]
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
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private GameObject[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private T[] <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private int <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xFDF960", Offset = "0xFDEB60", VA = "0x180FDF960")]
			[DebuggerHidden]
			public <GetAllComponentsInScenes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x121D180", Offset = "0x121C380", VA = "0x18121D180", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x121D390", Offset = "0x121C590", VA = "0x18121D390", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x121D2F0", Offset = "0x121C4F0", VA = "0x18121D2F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xFCAF90", Offset = "0xFCA190", VA = "0x180FCAF90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x15073A0", Offset = "0x15065A0", VA = "0x1815073A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float waitDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7C0", Offset = "0x3AD9C0", VA = "0x1803AE7C0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x30696F0", Offset = "0x30688F0", VA = "0x1830696F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x30697A0", Offset = "0x30689A0", VA = "0x1830697A0", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7C0", Offset = "0x3AD9C0", VA = "0x1803AE7C0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3069310", Offset = "0x3068510", VA = "0x183069310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x30693C0", Offset = "0x30685C0", VA = "0x1830693C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3060C30", Offset = "0x305FE30", VA = "0x183060C30")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3060BD0", Offset = "0x305FDD0", VA = "0x183060BD0")]
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
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float elapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float targetSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x306BD10", Offset = "0x306AF10", VA = "0x18306BD10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x306BCE0", Offset = "0x306AEE0", VA = "0x18306BCE0")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DictionaryExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x12AED20", Offset = "0x12ADF20", VA = "0x1812AED20")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EncodingExt
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3060D00", Offset = "0x305FF00", VA = "0x183060D00")]
		public static string ToBase64String(this Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3060DE0", Offset = "0x305FFE0", VA = "0x183060DE0")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FileExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3060EC0", Offset = "0x30600C0", VA = "0x183060EC0")]
		public static string ReadLines(this FileInfo file, string startPattern, string endPattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x30610A0", Offset = "0x30602A0", VA = "0x1830610A0")]
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
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private GameObject go;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public GameObject <>3__go;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private Transform <t>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5BAEC0", Offset = "0x5BA0C0", VA = "0x1805BAEC0")]
			[DebuggerHidden]
			public <GetGameObjectHierarchyHelper>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x3069410", Offset = "0x3068610", VA = "0x183069410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x30695A0", Offset = "0x30687A0", VA = "0x1830695A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3069500", Offset = "0x3068700", VA = "0x183069500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3069500", Offset = "0x3068700", VA = "0x183069500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x115CC00", Offset = "0x115BE00", VA = "0x18115CC00")]
		public static T GetComponentInParent<T>(this GameObject gameObject, bool includeDisabled) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x115CCE0", Offset = "0x115BEE0", VA = "0x18115CCE0")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x30613F0", Offset = "0x30605F0", VA = "0x1830613F0")]
		public static void SetTagRecursively(this GameObject gameObject, string tag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x30612C0", Offset = "0x30604C0", VA = "0x1830612C0")]
		public static string GetGameObjectHierarchy(this GameObject go)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3061250", Offset = "0x3060450", VA = "0x183061250")]
		[IteratorStateMachine(typeof(<GetGameObjectHierarchyHelper>d__8))]
		private static IEnumerable<string> GetGameObjectHierarchyHelper(GameObject go)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class GenericExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x15CA260", Offset = "0x15C9460", VA = "0x1815CA260")]
		public static V IfNotNull<V, T>(this T t, Func<T, V> todo, [Optional] V defaultValue) where T : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1001730", Offset = "0x1000930", VA = "0x181001730")]
		public static void DoIfNotNull<T>(this T t, Action<T> todo) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x15EBCD0", Offset = "0x15EAED0", VA = "0x1815EBCD0")]
		public static int FindIndex<T>(this IReadOnlyList<T> array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1001B70", Offset = "0x1000D70", VA = "0x181001B70")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1001C00", Offset = "0x1000E00", VA = "0x181001C00")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xDE2660", Offset = "0xDE1860", VA = "0x180DE2660")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x15EC150", Offset = "0x15EB350", VA = "0x1815EC150")]
		public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x15E6570", Offset = "0x15E5770", VA = "0x1815E6570")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x115FC20", Offset = "0x115EE20", VA = "0x18115FC20")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x15E5D20", Offset = "0x15E4F20", VA = "0x1815E5D20")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x115FB60", Offset = "0x115ED60", VA = "0x18115FB60")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x10019B0", Offset = "0x1000BB0", VA = "0x1810019B0")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x115FD00", Offset = "0x115EF00", VA = "0x18115FD00")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x15E5D90", Offset = "0x15E4F90", VA = "0x1815E5D90")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x115DFE0", Offset = "0x115D1E0", VA = "0x18115DFE0")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x15E6630", Offset = "0x15E5830", VA = "0x1815E6630")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MaterialExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1A11910", Offset = "0x1A10B10", VA = "0x181A11910")]
		public static void SetKeywordEnabled(this Material mat, string keyword, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3063480", Offset = "0x3062680", VA = "0x183063480")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3062C40", Offset = "0x3061E40", VA = "0x183062C40")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3062DE0", Offset = "0x3061FE0", VA = "0x183062DE0")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3061C50", Offset = "0x3060E50", VA = "0x183061C50")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3061B30", Offset = "0x3060D30", VA = "0x183061B30")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3063F70", Offset = "0x3063170", VA = "0x183063F70")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3063E00", Offset = "0x3063000", VA = "0x183063E00")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3061D30", Offset = "0x3060F30", VA = "0x183061D30")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3063B10", Offset = "0x3062D10", VA = "0x183063B10")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3061EC0", Offset = "0x30610C0", VA = "0x183061EC0")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3062780", Offset = "0x3061980", VA = "0x183062780")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3061910", Offset = "0x3060B10", VA = "0x183061910")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3063640", Offset = "0x3062840", VA = "0x183063640")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x30634A0", Offset = "0x30626A0", VA = "0x1830634A0")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x30637A0", Offset = "0x30629A0", VA = "0x1830637A0")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x30619A0", Offset = "0x3060BA0", VA = "0x1830619A0")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3062330", Offset = "0x3061530", VA = "0x183062330")]
		public static Vector3 GetLegacyProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float maxRange, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3062ED0", Offset = "0x30620D0", VA = "0x183062ED0")]
		public static Vector3 GetProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3063160", Offset = "0x3062360", VA = "0x183063160")]
		private static float GetProjectileMotionLaunchAngleDegrees(Vector3 origin, Vector3 target, float speed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3063460", Offset = "0x3062660", VA = "0x183063460")]
		public static float InverseLerpForMin(float maxValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3063440", Offset = "0x3062640", VA = "0x183063440")]
		public static float InverseLerpForMax(float minValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3063C20", Offset = "0x3062E20", VA = "0x183063C20")]
		public static float SolveQuadraticEquationMaxValue(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3063D40", Offset = "0x3062F40", VA = "0x183063D40")]
		public static void SolveQuadraticEquation(float a, float b, float c, out float lowerResult, out float upperResult)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3063BE0", Offset = "0x3062DE0", VA = "0x183063BE0")]
		public static float ReMapRange(this float value, Vector2 range, Vector2 newRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3063410", Offset = "0x3062610", VA = "0x183063410")]
		public static float GetRandomSign()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x30641D0", Offset = "0x30633D0", VA = "0x1830641D0")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3064220", Offset = "0x3063420", VA = "0x183064220")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x30642B0", Offset = "0x30634B0", VA = "0x1830642B0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3064300", Offset = "0x3063500", VA = "0x183064300")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3064110", Offset = "0x3063310", VA = "0x183064110")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x30641E0", Offset = "0x30633E0", VA = "0x1830641E0")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x11669E0", Offset = "0x1165BE0", VA = "0x1811669E0")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1166CC0", Offset = "0x1165EC0", VA = "0x181166CC0")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3064820", Offset = "0x3063A20", VA = "0x183064820")]
		public static void SortByDistanceToCenter(this RaycastHit[] hits, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30643D0", Offset = "0x30635D0", VA = "0x1830643D0")]
		public static void ClearVelocity(this Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3064590", Offset = "0x3063790", VA = "0x183064590")]
		public static float CombinedBounciness(this PhysicMaterial thisMaterial, PhysicMaterial otherMaterial)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3064480", Offset = "0x3063680", VA = "0x183064480")]
		private static float CombinePhysicsMaterialProperty(float lhs, float rhs, PhysicMaterialCombine combineFunction)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C0A00", Offset = "0x8BFC00", VA = "0x1808C0A00")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x26E7360", Offset = "0x26E6560", VA = "0x1826E7360")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x30697F0", Offset = "0x30689F0", VA = "0x1830697F0")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3064DB0", Offset = "0x3063FB0", VA = "0x183064DB0")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3065260", Offset = "0x3064460", VA = "0x183065260")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x30654D0", Offset = "0x30646D0", VA = "0x1830654D0")]
		public static Quaternion ValueOrIdentityIfBogus(this Quaternion quaternion)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3065090", Offset = "0x3064290", VA = "0x183065090")]
		public static bool IsNaN(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3065040", Offset = "0x3064240", VA = "0x183065040")]
		public static bool IsInfinity(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3064F90", Offset = "0x3064190", VA = "0x183064F90")]
		public static Quaternion InverseTransformRotation(this Quaternion basis, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3065430", Offset = "0x3064630", VA = "0x183065430")]
		public static Quaternion TransformRotation(this Quaternion parent, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x30651A0", Offset = "0x30643A0", VA = "0x1830651A0")]
		public static Quaternion RemoveRoll(this Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3064EE0", Offset = "0x30640E0", VA = "0x183064EE0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x30650E0", Offset = "0x30642E0", VA = "0x1830650E0")]
		public static Quaternion QuaternionFromAngularVelocity(Vector3 angularVelocity)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3064B50", Offset = "0x3063D50", VA = "0x183064B50")]
		public static Vector3 AngularDisplacementFromTo(Quaternion from, Quaternion to)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x30652B0", Offset = "0x30644B0", VA = "0x1830652B0")]
		public static Quaternion SmoothDamp(Quaternion current, Quaternion target, ref Vector3 eulerAngularVelocity, float smoothTime)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class RectExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3065680", Offset = "0x3064880", VA = "0x183065680")]
		public static Rect Encompass(this Rect rect, Vector2 point)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3065960", Offset = "0x3064B60", VA = "0x183065960")]
		public static Vector2 UpperRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3065910", Offset = "0x3064B10", VA = "0x183065910")]
		public static Vector2 UpperLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x30658C0", Offset = "0x3064AC0", VA = "0x1830658C0")]
		public static Vector2 LowerRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3065870", Offset = "0x3064A70", VA = "0x183065870")]
		public static Vector2 LowerLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x30657A0", Offset = "0x30649A0", VA = "0x1830657A0")]
		public static Rect GUIRectToScreenRect(this Rect rect)
		{
			return default(Rect);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x30659D0", Offset = "0x3064BD0", VA = "0x1830659D0")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3065B80", Offset = "0x3064D80", VA = "0x183065B80")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3066270", Offset = "0x3065470", VA = "0x183066270")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x30660A0", Offset = "0x30652A0", VA = "0x1830660A0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3065FC0", Offset = "0x30651C0", VA = "0x183065FC0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3066170", Offset = "0x3065370", VA = "0x183066170")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x30659B0", Offset = "0x3064BB0", VA = "0x1830659B0")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3065DD0", Offset = "0x3064FD0", VA = "0x183065DD0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3065C30", Offset = "0x3064E30", VA = "0x183065C30")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x30663C0", Offset = "0x30655C0", VA = "0x1830663C0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3066540", Offset = "0x3065740", VA = "0x183066540")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3066480", Offset = "0x3065680", VA = "0x183066480")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class ScreenHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool IsIPadAspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x30666A0", Offset = "0x30658A0", VA = "0x1830666A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3066600", Offset = "0x3065800", VA = "0x183066600")]
		public static float GetLandscapeOrientationScreenAspectRatio()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class StreamingAssetsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3066750", Offset = "0x3065950", VA = "0x183066750")]
		public static byte[] LoadBytesFromStreamingAssets(string filename)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3066890", Offset = "0x3065A90", VA = "0x183066890")]
		private static DownloadHandler LoadFromStreamingAssetsInternal(string filename)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3066E60", Offset = "0x3066060", VA = "0x183066E60")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3066A70", Offset = "0x3065C70", VA = "0x183066A70")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3067060", Offset = "0x3066260", VA = "0x183067060")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3066AD0", Offset = "0x3065CD0", VA = "0x183066AD0")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x30669F0", Offset = "0x3065BF0", VA = "0x1830669F0")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3066D10", Offset = "0x3065F10", VA = "0x183066D10")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3066C70", Offset = "0x3065E70", VA = "0x183066C70")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3066C50", Offset = "0x3065E50", VA = "0x183066C50")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3066C60", Offset = "0x3065E60", VA = "0x183066C60")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3066B40", Offset = "0x3065D40", VA = "0x183066B40")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3066BC0", Offset = "0x3065DC0", VA = "0x183066BC0")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x30669C0", Offset = "0x3065BC0", VA = "0x1830669C0")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3066DA0", Offset = "0x3065FA0", VA = "0x183066DA0")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3066E00", Offset = "0x3066000", VA = "0x183066E00")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class TextureExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3067170", Offset = "0x3066370", VA = "0x183067170")]
		public static void ConvertPixelsToGamma(this Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3067280", Offset = "0x3066480", VA = "0x183067280")]
		public static void GetTexture2D(this RenderTexture frame, ref Texture2D texture, bool cropSidesToSquare = false, bool convertToGamma = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly Vector3[] RectCornersBuffer;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3068EE0", Offset = "0x30680E0", VA = "0x183068EE0")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3068290", Offset = "0x3067490", VA = "0x183068290")]
		public static Vector3 GetRectWorldSize(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3067DA0", Offset = "0x3066FA0", VA = "0x183067DA0")]
		public static Vector2 GetRectLocalSize(this RectTransform rectTransform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3067BA0", Offset = "0x3066DA0", VA = "0x183067BA0")]
		public static float GetRectLocalArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3068110", Offset = "0x3067310", VA = "0x183068110")]
		public static Vector3 GetRectWorldCenter(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3067F10", Offset = "0x3067110", VA = "0x183067F10")]
		public static float GetRectWorldArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3067AE0", Offset = "0x3066CE0", VA = "0x183067AE0")]
		public static Vector3[] GetInstantaneousWorldCornersNonAlloc(this RectTransform rectTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x30686F0", Offset = "0x30678F0", VA = "0x1830686F0")]
		public static Quaternion InverseTransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3068E20", Offset = "0x3068020", VA = "0x183068E20")]
		public static Quaternion TransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x30684B0", Offset = "0x30676B0", VA = "0x1830684B0")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1386A30", Offset = "0x1385C30", VA = "0x181386A30")]
		public static float GetLossyUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3067B70", Offset = "0x3066D70", VA = "0x183067B70")]
		public static float GetLocalUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x30689D0", Offset = "0x3067BD0", VA = "0x1830689D0")]
		public static void SetLocalUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3068800", Offset = "0x3067A00", VA = "0x183068800")]
		public static void SetLocalScale(this Transform transform, float uniformScale, Vector3 aspectRatio)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3068C00", Offset = "0x3067E00", VA = "0x183068C00")]
		public static void SetLossyUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x30683E0", Offset = "0x30675E0", VA = "0x1830683E0")]
		public static float InverseTransformLossyUniformScale(this Transform transform, float uniformLossyScale)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3068DA0", Offset = "0x3067FA0", VA = "0x183068DA0")]
		public static float TransformLocalUniformScale(this Transform transform, float uniformLocalScale)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F70", Offset = "0x5B1170", VA = "0x1805B1F70")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3069BD0", Offset = "0x3068DD0", VA = "0x183069BD0")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3069AE0", Offset = "0x3068CE0", VA = "0x183069AE0")]
		public static Vector2 Clamp01(this Vector2 vector)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3069C80", Offset = "0x3068E80", VA = "0x183069C80")]
		public static bool WithinBounds(this Vector2 bounds, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3069850", Offset = "0x3068A50", VA = "0x183069850")]
		public static float AngleSignedVector2(this Vector2 from, Vector2 to)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3069FF0", Offset = "0x30691F0", VA = "0x183069FF0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x306B570", Offset = "0x306A770", VA = "0x18306B570")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x306B9B0", Offset = "0x306ABB0", VA = "0x18306B9B0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x306B6F0", Offset = "0x306A8F0", VA = "0x18306B6F0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x306B810", Offset = "0x306AA10", VA = "0x18306B810")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x306A910", Offset = "0x3069B10", VA = "0x18306A910")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x306AB00", Offset = "0x3069D00", VA = "0x18306AB00")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x306AC30", Offset = "0x3069E30", VA = "0x18306AC30")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x306ACA0", Offset = "0x3069EA0", VA = "0x18306ACA0")]
		public static bool IsWithinUnitCube(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x306AD60", Offset = "0x3069F60", VA = "0x18306AD60")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x306ADF0", Offset = "0x3069FF0", VA = "0x18306ADF0")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3069CB0", Offset = "0x3068EB0", VA = "0x183069CB0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x306BB90", Offset = "0x306AD90", VA = "0x18306BB90")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x306A2F0", Offset = "0x30694F0", VA = "0x18306A2F0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x306AD10", Offset = "0x3069F10", VA = "0x18306AD10")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x306AAA0", Offset = "0x3069CA0", VA = "0x18306AAA0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x306AA40", Offset = "0x3069C40", VA = "0x18306AA40")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x306AF40", Offset = "0x306A140", VA = "0x18306AF40")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x306A460", Offset = "0x3069660", VA = "0x18306A460")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3069E30", Offset = "0x3069030", VA = "0x183069E30")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x306BC50", Offset = "0x306AE50", VA = "0x18306BC50")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x306A550", Offset = "0x3069750", VA = "0x18306A550")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x306A4F0", Offset = "0x30696F0", VA = "0x18306A4F0")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x306A520", Offset = "0x3069720", VA = "0x18306A520")]
		public static Vector3 FromY(float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x306B360", Offset = "0x306A560", VA = "0x18306B360")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x306B3A0", Offset = "0x306A5A0", VA = "0x18306B3A0")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x306B3E0", Offset = "0x306A5E0", VA = "0x18306B3E0")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3069D70", Offset = "0x3068F70", VA = "0x183069D70")]
		public static Vector3 AddY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x306B630", Offset = "0x306A830", VA = "0x18306B630")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x306AE80", Offset = "0x306A080", VA = "0x18306AE80")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x306AFD0", Offset = "0x306A1D0", VA = "0x18306AFD0")]
		public static Vector3 ProjectDirectionOntoSurface(Vector3 desiredDirection, Vector3 surfaceNormal, Vector3 up)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x306B110", Offset = "0x306A310", VA = "0x18306B110")]
		public static Vector3 ProjectGroundSpaceVectorOnToWall(Vector3 vector, Vector3 wallUp, Vector3 wallNormal, bool allowedToMoveUp)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x306B420", Offset = "0x306A620", VA = "0x18306B420")]
		public static float SignedAngleOnPlane(this Vector3 from, Vector3 to, Vector3 planeNormalAxis, bool shiftPositive = false)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1003680", Offset = "0x1002880", VA = "0x181003680")]
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

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
			[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x1048E30", Offset = "0x1048030", VA = "0x181048E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1048E80", Offset = "0x1048080", VA = "0x181048E80")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CC130", Offset = "0x3CB330", VA = "0x1803CC130", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1048CC0", Offset = "0x1047EC0", VA = "0x181048CC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1048D90", Offset = "0x1047F90", VA = "0x181048D90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1048CF0", Offset = "0x1047EF0", VA = "0x181048CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xFB72E0", Offset = "0xFB64E0", VA = "0x180FB72E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1737250", Offset = "0x1736450", VA = "0x181737250")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1736DA0", Offset = "0x1735FA0", VA = "0x181736DA0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xBBE1F0", Offset = "0xBBD3F0", VA = "0x180BBE1F0")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1737500", Offset = "0x1736700", VA = "0x181737500")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5FDA0", Offset = "0x5F1A0")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBBC7C0", Offset = "0xBBB9C0", VA = "0x180BBC7C0")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1736BC0", Offset = "0x1735DC0", VA = "0x181736BC0")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x143A690", Offset = "0x1439890", VA = "0x18143A690")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15CDE70", Offset = "0x15CD070", VA = "0x1815CDE70")]
	public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int skip, int take)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15CDCA0", Offset = "0x15CCEA0", VA = "0x1815CDCA0")]
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keyFunc)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x314EE80", Offset = "0x314E080", VA = "0x18314EE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3154EA0", Offset = "0x31540A0", VA = "0x183154EA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float MaxHypotheticalDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x51E3F0", Offset = "0x51D5F0", VA = "0x18051E3F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float SafeDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3154EB0", Offset = "0x31540B0", VA = "0x183154EB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3154F20", Offset = "0x3154120", VA = "0x183154F20")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3155050", Offset = "0x3154250", VA = "0x183155050")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3154FC0", Offset = "0x31541C0", VA = "0x183154FC0")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3156A00", Offset = "0x3155C00", VA = "0x183156A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x314B400", Offset = "0x314A600", VA = "0x18314B400")]
		public static void SafeSetEnabled(this Animator animator, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x314B480", Offset = "0x314A680", VA = "0x18314B480")]
		public static void SetBoolIfActive(this Animator animator, int id, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x314B4E0", Offset = "0x314A6E0", VA = "0x18314B4E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x2A84D0", Offset = "0x2A78D0", VA = "0x1802A84D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2328BE0", Offset = "0x2327DE0", VA = "0x182328BE0")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2328480", Offset = "0x2327680", VA = "0x182328480")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1310C30", Offset = "0x130FE30", VA = "0x181310C30")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xEDE320", Offset = "0xEDD520", VA = "0x180EDE320")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xEDE220", Offset = "0xEDD420", VA = "0x180EDE220")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEDF3C0", Offset = "0xEDE5C0", VA = "0x180EDF3C0")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEDF250", Offset = "0xEDE450", VA = "0x180EDF250")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEDED00", Offset = "0xEDDF00", VA = "0x180EDED00")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xEDE8E0", Offset = "0xEDDAE0", VA = "0x180EDE8E0")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xEDED90", Offset = "0xEDDF90", VA = "0x180EDED90")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xEDE490", Offset = "0xEDD690", VA = "0x180EDE490")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x143A430", Offset = "0x1439630", VA = "0x18143A430")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1310D40", Offset = "0x130FF40", VA = "0x181310D40")]
		public static T[] Sort<T>(this T[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x13102E0", Offset = "0x130F4E0", VA = "0x1813102E0")]
		public static T[] CopyAndAdd<T>(this T[] oldArray, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x13103C0", Offset = "0x130F5C0", VA = "0x1813103C0")]
		public static T[] CopyAndInsert<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1310960", Offset = "0x130FB60", VA = "0x181310960")]
		public static T[] CopyAndRemoveAt<T>(this T[] oldArray, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1310A10", Offset = "0x130FC10", VA = "0x181310A10")]
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

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2FD320", Offset = "0x2FC720", VA = "0x1802FD320")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2FD180", Offset = "0x2FC580", VA = "0x1802FD180", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2FD1B0", Offset = "0x2FC5B0", VA = "0x1802FD1B0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2FD250", Offset = "0x2FC650", VA = "0x1802FD250", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2FD310", Offset = "0x2FC710", VA = "0x1802FD310", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x314BCB0", Offset = "0x314AEB0", VA = "0x18314BCB0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x119BE70", Offset = "0x119B070", VA = "0x18119BE70")]
		public static T GetCachedComponent<T>(this GameObject gameObject, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x119BB90", Offset = "0x119AD90", VA = "0x18119BB90")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xC578D0", Offset = "0xC56AD0", VA = "0x180C578D0")]
		public static IReadOnlyList<T> GetCachedComponentsInParent<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC577B0", Offset = "0xC569B0", VA = "0x180C577B0")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x119BCB0", Offset = "0x119AEB0", VA = "0x18119BCB0")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC579F0", Offset = "0xC56BF0", VA = "0x180C579F0")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x314C190", Offset = "0x314B390", VA = "0x18314C190")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x314BD40", Offset = "0x314AF40", VA = "0x18314BD40")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xC57BA0", Offset = "0xC56DA0", VA = "0x180C57BA0")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC57CA0", Offset = "0xC56EA0", VA = "0x180C57CA0")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CameraExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x314C7F0", Offset = "0x314B9F0", VA = "0x18314C7F0")]
		public static float GetFrustumHeightAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x314C820", Offset = "0x314BA20", VA = "0x18314C820")]
		public static float GetFrustumWidthAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x314C870", Offset = "0x314BA70", VA = "0x18314C870")]
		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x314C360", Offset = "0x314B560", VA = "0x18314C360")]
		private static float GetCameraDistanceToHeightRatio(float cameraFieldOfView)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x314C3D0", Offset = "0x314B5D0", VA = "0x18314C3D0")]
		private static float GetCameraDistanceToHeightRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x314C450", Offset = "0x314B650", VA = "0x18314C450")]
		private static float GetCameraDistanceToWidthRatio(float cameraFieldOfView, float cameraAspectRatio)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x314C4D0", Offset = "0x314B6D0", VA = "0x18314C4D0")]
		private static float GetCameraDistanceToWidthRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x314C6E0", Offset = "0x314B8E0", VA = "0x18314C6E0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(float cameraFieldOfView, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x314C5C0", Offset = "0x314B7C0", VA = "0x18314C5C0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x314C600", Offset = "0x314B800", VA = "0x18314C600")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, Vector2 worldSpaceSize, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x314C510", Offset = "0x314B710", VA = "0x18314C510")]
		private static float GetDistanceFromProjectionCameraToFillFOVInternal(float distanceToSizeRatio, float worldSpaceSize, float viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x314C9E0", Offset = "0x314BBE0", VA = "0x18314C9E0")]
		public static float GetScaleFactorFromProjectionCameraToFillFOVAtDistance(float cameraFOV, float cameraAspectRatio, Vector2 worldSpaceSize, float desiredDistance, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x314C920", Offset = "0x314BB20", VA = "0x18314C920")]
		private static float GetScaleFactorFromProjectionCameraToFillFOVAtDistanceInternal(float distanceToSizeRatio, float worldSpaceSize, float desiredDistance, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x314C2D0", Offset = "0x314B4D0", VA = "0x18314C2D0")]
		public static void CleanupRenderTexture(this Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x314CBE0", Offset = "0x314BDE0", VA = "0x18314CBE0")]
		public static bool IsInFov(this Camera camera, Renderer renderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x314CB60", Offset = "0x314BD60", VA = "0x18314CB60")]
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

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x314CC40", Offset = "0x314BE40", VA = "0x18314CC40")]
		public static bool CapsuleCast(this Collider collider, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x314D760", Offset = "0x314C960", VA = "0x18314D760")]
		public static int GetOverlapNonAlloc(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction, Collider[] hitColliders)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x314D2D0", Offset = "0x314C4D0", VA = "0x18314D2D0")]
		public static bool CheckOverlap(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x314DA20", Offset = "0x314CC20", VA = "0x18314DA20")]
		public static int Overlap(this BoxCollider collider, Collider[] hits, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x314D570", Offset = "0x314C770", VA = "0x18314D570")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x314CF10", Offset = "0x314C110", VA = "0x18314CF10")]
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

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x314DF60", Offset = "0x314D160", VA = "0x18314DF60")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x314DD70", Offset = "0x314CF70", VA = "0x18314DD70")]
		public static Vector3 GammaToLinearColorSpace(this Vector3 gammaColor)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x314DE60", Offset = "0x314D060", VA = "0x18314DE60")]
		public static Color GammaToLinearColorSpace(this Color gammaColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x314DD30", Offset = "0x314CF30", VA = "0x18314DD30")]
		public static Color ChangeAlpha(this Color color, float newAlpha)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x314E010", Offset = "0x314D210", VA = "0x18314E010")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xC57DD0", Offset = "0xC56FD0", VA = "0x180C57DD0")]
		public static List<T> FindAllObjectsOfType<T>(this Component component) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x119C7D0", Offset = "0x119B9D0", VA = "0x18119C7D0")]
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
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1048E80", Offset = "0x1048080", VA = "0x181048E80")]
			[DebuggerHidden]
			public <GetAllComponentsInScenes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3CC130", Offset = "0x3CB330", VA = "0x1803CC130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x10A0410", Offset = "0x109F610", VA = "0x1810A0410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x10A0620", Offset = "0x109F820", VA = "0x1810A0620", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x10A0580", Offset = "0x109F780", VA = "0x1810A0580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xFBD860", Offset = "0xFBCA60", VA = "0x180FBD860", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x15CCF30", Offset = "0x15CC130", VA = "0x1815CCF30")]
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
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x3BF7C0", Offset = "0x3BE9C0", VA = "0x1803BF7C0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x3CC130", Offset = "0x3CB330", VA = "0x1803CC130", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x3156FA0", Offset = "0x31561A0", VA = "0x183156FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3157050", Offset = "0x3156250", VA = "0x183157050", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3BF7C0", Offset = "0x3BE9C0", VA = "0x1803BF7C0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3CC130", Offset = "0x3CB330", VA = "0x1803CC130", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3156BC0", Offset = "0x3155DC0", VA = "0x183156BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3156C70", Offset = "0x3155E70", VA = "0x183156C70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x314E460", Offset = "0x314D660", VA = "0x18314E460")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x314E400", Offset = "0x314D600", VA = "0x18314E400")]
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
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x31595C0", Offset = "0x31587C0", VA = "0x1831595C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3159590", Offset = "0x3158790", VA = "0x183159590")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DictionaryExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x104B140", Offset = "0x104A340", VA = "0x18104B140")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EncodingExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x314E530", Offset = "0x314D730", VA = "0x18314E530")]
		public static string ToBase64String(this Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x314E610", Offset = "0x314D810", VA = "0x18314E610")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FileExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x314E6F0", Offset = "0x314D8F0", VA = "0x18314E6F0")]
		public static string ReadLines(this FileInfo file, string startPattern, string endPattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x314E8D0", Offset = "0x314DAD0", VA = "0x18314E8D0")]
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
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x3BF670", Offset = "0x3BE870", VA = "0x1803BF670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5E8EA0", Offset = "0x5E80A0", VA = "0x1805E8EA0")]
			[DebuggerHidden]
			public <GetGameObjectHierarchyHelper>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3CC130", Offset = "0x3CB330", VA = "0x1803CC130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x3156CC0", Offset = "0x3155EC0", VA = "0x183156CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x3156E50", Offset = "0x3156050", VA = "0x183156E50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3156DB0", Offset = "0x3155FB0", VA = "0x183156DB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x3156DB0", Offset = "0x3155FB0", VA = "0x183156DB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x119E650", Offset = "0x119D850", VA = "0x18119E650")]
		public static T GetComponentInParent<T>(this GameObject gameObject, bool includeDisabled) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x119E730", Offset = "0x119D930", VA = "0x18119E730")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x314EC20", Offset = "0x314DE20", VA = "0x18314EC20")]
		public static void SetTagRecursively(this GameObject gameObject, string tag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x314EAF0", Offset = "0x314DCF0", VA = "0x18314EAF0")]
		public static string GetGameObjectHierarchy(this GameObject go)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x314EA80", Offset = "0x314DC80", VA = "0x18314EA80")]
		[IteratorStateMachine(typeof(<GetGameObjectHierarchyHelper>d__8))]
		private static IEnumerable<string> GetGameObjectHierarchyHelper(GameObject go)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class GenericExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1316D60", Offset = "0x1315F60", VA = "0x181316D60")]
		public static V IfNotNull<V, T>(this T t, Func<T, V> todo, [Optional] V defaultValue) where T : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xEEA410", Offset = "0xEE9610", VA = "0x180EEA410")]
		public static void DoIfNotNull<T>(this T t, Action<T> todo) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x13D4630", Offset = "0x13D3830", VA = "0x1813D4630")]
		public static int FindIndex<T>(this IReadOnlyList<T> array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xEEA850", Offset = "0xEE9A50", VA = "0x180EEA850")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xEEA8E0", Offset = "0xEE9AE0", VA = "0x180EEA8E0")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xC58730", Offset = "0xC57930", VA = "0x180C58730")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x13D4AB0", Offset = "0x13D3CB0", VA = "0x1813D4AB0")]
		public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1708D10", Offset = "0x1707F10", VA = "0x181708D10")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1708700", Offset = "0x1707900", VA = "0x181708700")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x11A1740", Offset = "0x11A0940", VA = "0x1811A1740")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1708590", Offset = "0x1707790", VA = "0x181708590")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x11A1680", Offset = "0x11A0880", VA = "0x1811A1680")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xEEA690", Offset = "0xEE9890", VA = "0x180EEA690")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A1820", Offset = "0x11A0A20", VA = "0x1811A1820")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1708600", Offset = "0x1707800", VA = "0x181708600")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x119FA80", Offset = "0x119EC80", VA = "0x18119FA80")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1708E50", Offset = "0x1708050", VA = "0x181708E50")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MaterialExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7750", Offset = "0x1AB6950", VA = "0x181AB7750")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3150CB0", Offset = "0x314FEB0", VA = "0x183150CB0")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3150470", Offset = "0x314F670", VA = "0x183150470")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3150610", Offset = "0x314F810", VA = "0x183150610")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x314F480", Offset = "0x314E680", VA = "0x18314F480")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x314F360", Offset = "0x314E560", VA = "0x18314F360")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x31517A0", Offset = "0x31509A0", VA = "0x1831517A0")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3151630", Offset = "0x3150830", VA = "0x183151630")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x314F560", Offset = "0x314E760", VA = "0x18314F560")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3151340", Offset = "0x3150540", VA = "0x183151340")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x314F6F0", Offset = "0x314E8F0", VA = "0x18314F6F0")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x314FFB0", Offset = "0x314F1B0", VA = "0x18314FFB0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x314F140", Offset = "0x314E340", VA = "0x18314F140")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3150E70", Offset = "0x3150070", VA = "0x183150E70")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3150CD0", Offset = "0x314FED0", VA = "0x183150CD0")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3150FD0", Offset = "0x31501D0", VA = "0x183150FD0")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x314F1D0", Offset = "0x314E3D0", VA = "0x18314F1D0")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x314FB60", Offset = "0x314ED60", VA = "0x18314FB60")]
		public static Vector3 GetLegacyProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float maxRange, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3150700", Offset = "0x314F900", VA = "0x183150700")]
		public static Vector3 GetProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3150990", Offset = "0x314FB90", VA = "0x183150990")]
		private static float GetProjectileMotionLaunchAngleDegrees(Vector3 origin, Vector3 target, float speed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3150C90", Offset = "0x314FE90", VA = "0x183150C90")]
		public static float InverseLerpForMin(float maxValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3150C70", Offset = "0x314FE70", VA = "0x183150C70")]
		public static float InverseLerpForMax(float minValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3151450", Offset = "0x3150650", VA = "0x183151450")]
		public static float SolveQuadraticEquationMaxValue(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3151570", Offset = "0x3150770", VA = "0x183151570")]
		public static void SolveQuadraticEquation(float a, float b, float c, out float lowerResult, out float upperResult)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3151410", Offset = "0x3150610", VA = "0x183151410")]
		public static float ReMapRange(this float value, Vector2 range, Vector2 newRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3150C40", Offset = "0x314FE40", VA = "0x183150C40")]
		public static float GetRandomSign()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3151A00", Offset = "0x3150C00", VA = "0x183151A00")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3151A50", Offset = "0x3150C50", VA = "0x183151A50")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3151AE0", Offset = "0x3150CE0", VA = "0x183151AE0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3151B30", Offset = "0x3150D30", VA = "0x183151B30")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3151940", Offset = "0x3150B40", VA = "0x183151940")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3151A10", Offset = "0x3150C10", VA = "0x183151A10")]
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

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x11A8500", Offset = "0x11A7700", VA = "0x1811A8500")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A87E0", Offset = "0x11A79E0", VA = "0x1811A87E0")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3152050", Offset = "0x3151250", VA = "0x183152050")]
		public static void SortByDistanceToCenter(this RaycastHit[] hits, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3151C00", Offset = "0x3150E00", VA = "0x183151C00")]
		public static void ClearVelocity(this Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3151DC0", Offset = "0x3150FC0", VA = "0x183151DC0")]
		public static float CombinedBounciness(this PhysicMaterial thisMaterial, PhysicMaterial otherMaterial)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3151CB0", Offset = "0x3150EB0", VA = "0x183151CB0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B91A0", Offset = "0x8B83A0", VA = "0x1808B91A0")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F4DB90", Offset = "0x2F4CD90", VA = "0x182F4DB90")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x31570A0", Offset = "0x31562A0", VA = "0x1831570A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x31525E0", Offset = "0x31517E0", VA = "0x1831525E0")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3152A90", Offset = "0x3151C90", VA = "0x183152A90")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3152D00", Offset = "0x3151F00", VA = "0x183152D00")]
		public static Quaternion ValueOrIdentityIfBogus(this Quaternion quaternion)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x31528C0", Offset = "0x3151AC0", VA = "0x1831528C0")]
		public static bool IsNaN(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3152870", Offset = "0x3151A70", VA = "0x183152870")]
		public static bool IsInfinity(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x31527C0", Offset = "0x31519C0", VA = "0x1831527C0")]
		public static Quaternion InverseTransformRotation(this Quaternion basis, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3152C60", Offset = "0x3151E60", VA = "0x183152C60")]
		public static Quaternion TransformRotation(this Quaternion parent, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x31529D0", Offset = "0x3151BD0", VA = "0x1831529D0")]
		public static Quaternion RemoveRoll(this Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3152710", Offset = "0x3151910", VA = "0x183152710")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3152910", Offset = "0x3151B10", VA = "0x183152910")]
		public static Quaternion QuaternionFromAngularVelocity(Vector3 angularVelocity)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3152380", Offset = "0x3151580", VA = "0x183152380")]
		public static Vector3 AngularDisplacementFromTo(Quaternion from, Quaternion to)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3152AE0", Offset = "0x3151CE0", VA = "0x183152AE0")]
		public static Quaternion SmoothDamp(Quaternion current, Quaternion target, ref Vector3 eulerAngularVelocity, float smoothTime)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class RectExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3152EB0", Offset = "0x31520B0", VA = "0x183152EB0")]
		public static Rect Encompass(this Rect rect, Vector2 point)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3153190", Offset = "0x3152390", VA = "0x183153190")]
		public static Vector2 UpperRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3153140", Offset = "0x3152340", VA = "0x183153140")]
		public static Vector2 UpperLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x31530F0", Offset = "0x31522F0", VA = "0x1831530F0")]
		public static Vector2 LowerRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x31530A0", Offset = "0x31522A0", VA = "0x1831530A0")]
		public static Vector2 LowerLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3152FD0", Offset = "0x31521D0", VA = "0x183152FD0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3153200", Offset = "0x3152400", VA = "0x183153200")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x31533B0", Offset = "0x31525B0", VA = "0x1831533B0")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3153AA0", Offset = "0x3152CA0", VA = "0x183153AA0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x31538D0", Offset = "0x3152AD0", VA = "0x1831538D0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x31537F0", Offset = "0x31529F0", VA = "0x1831537F0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x31539A0", Offset = "0x3152BA0", VA = "0x1831539A0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x31531E0", Offset = "0x31523E0", VA = "0x1831531E0")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3153600", Offset = "0x3152800", VA = "0x183153600")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3153460", Offset = "0x3152660", VA = "0x183153460")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3153BF0", Offset = "0x3152DF0", VA = "0x183153BF0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3153D70", Offset = "0x3152F70", VA = "0x183153D70")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3153CB0", Offset = "0x3152EB0", VA = "0x183153CB0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3153ED0", Offset = "0x31530D0", VA = "0x183153ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3153E30", Offset = "0x3153030", VA = "0x183153E30")]
		public static float GetLandscapeOrientationScreenAspectRatio()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class StreamingAssetsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3153F80", Offset = "0x3153180", VA = "0x183153F80")]
		public static byte[] LoadBytesFromStreamingAssets(string filename)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x31540C0", Offset = "0x31532C0", VA = "0x1831540C0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3154690", Offset = "0x3153890", VA = "0x183154690")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x31542A0", Offset = "0x31534A0", VA = "0x1831542A0")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3154890", Offset = "0x3153A90", VA = "0x183154890")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3154300", Offset = "0x3153500", VA = "0x183154300")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3154220", Offset = "0x3153420", VA = "0x183154220")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3154540", Offset = "0x3153740", VA = "0x183154540")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x31544A0", Offset = "0x31536A0", VA = "0x1831544A0")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3154480", Offset = "0x3153680", VA = "0x183154480")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3154490", Offset = "0x3153690", VA = "0x183154490")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3154370", Offset = "0x3153570", VA = "0x183154370")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x31543F0", Offset = "0x31535F0", VA = "0x1831543F0")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x31541F0", Offset = "0x31533F0", VA = "0x1831541F0")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x31545D0", Offset = "0x31537D0", VA = "0x1831545D0")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3154630", Offset = "0x3153830", VA = "0x183154630")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class TextureExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x31549A0", Offset = "0x3153BA0", VA = "0x1831549A0")]
		public static void ConvertPixelsToGamma(this Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3154AB0", Offset = "0x3153CB0", VA = "0x183154AB0")]
		public static void GetTexture2D(this RenderTexture frame, ref Texture2D texture, bool cropSidesToSquare = false, bool convertToGamma = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly Vector3[] RectCornersBuffer;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3156790", Offset = "0x3155990", VA = "0x183156790")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3156510", Offset = "0x3155710", VA = "0x183156510")]
		public static Vector3 YawForwardPitchCorrected(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x31558C0", Offset = "0x3154AC0", VA = "0x1831558C0")]
		public static Vector3 GetRectWorldSize(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x31555D0", Offset = "0x31547D0", VA = "0x1831555D0")]
		public static Vector2 GetRectLocalSize(this RectTransform rectTransform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x31553D0", Offset = "0x31545D0", VA = "0x1831553D0")]
		public static float GetRectLocalArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x3155740", Offset = "0x3154940", VA = "0x183155740")]
		public static Vector3 GetRectWorldCenter(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3155310", Offset = "0x3154510", VA = "0x183155310")]
		public static Vector3[] GetInstantaneousWorldCornersNonAlloc(this RectTransform rectTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3155D20", Offset = "0x3154F20", VA = "0x183155D20")]
		public static Quaternion InverseTransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3156450", Offset = "0x3155650", VA = "0x183156450")]
		public static Quaternion TransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3155AE0", Offset = "0x3154CE0", VA = "0x183155AE0")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x135CC50", Offset = "0x135BE50", VA = "0x18135CC50")]
		public static float GetLossyUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x31553A0", Offset = "0x31545A0", VA = "0x1831553A0")]
		public static float GetLocalUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3156000", Offset = "0x3155200", VA = "0x183156000")]
		public static void SetLocalUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3155E30", Offset = "0x3155030", VA = "0x183155E30")]
		public static void SetLocalScale(this Transform transform, float uniformScale, Vector3 aspectRatio)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3156230", Offset = "0x3155430", VA = "0x183156230")]
		public static void SetLossyUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3155A10", Offset = "0x3154C10", VA = "0x183155A10")]
		public static float InverseTransformLossyUniformScale(this Transform transform, float uniformLossyScale)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x31563D0", Offset = "0x31555D0", VA = "0x1831563D0")]
		public static float TransformLocalUniformScale(this Transform transform, float uniformLocalScale)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF50", Offset = "0x5DF150", VA = "0x1805DFF50")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3157480", Offset = "0x3156680", VA = "0x183157480")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3157390", Offset = "0x3156590", VA = "0x183157390")]
		public static Vector2 Clamp01(this Vector2 vector)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3157530", Offset = "0x3156730", VA = "0x183157530")]
		public static bool WithinBounds(this Vector2 bounds, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3157100", Offset = "0x3156300", VA = "0x183157100")]
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

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x31578A0", Offset = "0x3156AA0", VA = "0x1831578A0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3158E20", Offset = "0x3158020", VA = "0x183158E20")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3159260", Offset = "0x3158460", VA = "0x183159260")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3158FA0", Offset = "0x31581A0", VA = "0x183158FA0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x31590C0", Offset = "0x31582C0", VA = "0x1831590C0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x31581C0", Offset = "0x31573C0", VA = "0x1831581C0")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x31583B0", Offset = "0x31575B0", VA = "0x1831583B0")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x31584E0", Offset = "0x31576E0", VA = "0x1831584E0")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3158550", Offset = "0x3157750", VA = "0x183158550")]
		public static bool IsWithinUnitCube(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3158610", Offset = "0x3157810", VA = "0x183158610")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x31586A0", Offset = "0x31578A0", VA = "0x1831586A0")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3157560", Offset = "0x3156760", VA = "0x183157560")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3159440", Offset = "0x3158640", VA = "0x183159440")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3157BA0", Offset = "0x3156DA0", VA = "0x183157BA0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x31585C0", Offset = "0x31577C0", VA = "0x1831585C0")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3158350", Offset = "0x3157550", VA = "0x183158350")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x31582F0", Offset = "0x31574F0", VA = "0x1831582F0")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x31587F0", Offset = "0x31579F0", VA = "0x1831587F0")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3157D10", Offset = "0x3156F10", VA = "0x183157D10")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x31576E0", Offset = "0x31568E0", VA = "0x1831576E0")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3159500", Offset = "0x3158700", VA = "0x183159500")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3157E00", Offset = "0x3157000", VA = "0x183157E00")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3157DA0", Offset = "0x3156FA0", VA = "0x183157DA0")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3157DD0", Offset = "0x3156FD0", VA = "0x183157DD0")]
		public static Vector3 FromY(float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3158C10", Offset = "0x3157E10", VA = "0x183158C10")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3158C50", Offset = "0x3157E50", VA = "0x183158C50")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3158C90", Offset = "0x3157E90", VA = "0x183158C90")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3157620", Offset = "0x3156820", VA = "0x183157620")]
		public static Vector3 AddY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3158EE0", Offset = "0x31580E0", VA = "0x183158EE0")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3158730", Offset = "0x3157930", VA = "0x183158730")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3158880", Offset = "0x3157A80", VA = "0x183158880")]
		public static Vector3 ProjectDirectionOntoSurface(Vector3 desiredDirection, Vector3 surfaceNormal, Vector3 up)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x31589C0", Offset = "0x3157BC0", VA = "0x1831589C0")]
		public static Vector3 ProjectGroundSpaceVectorOnToWall(Vector3 vector, Vector3 wallUp, Vector3 wallNormal, bool allowedToMoveUp)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3158CD0", Offset = "0x3157ED0", VA = "0x183158CD0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xEEC360", Offset = "0xEEB560", VA = "0x180EEC360")]
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

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
			[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F26DF0", Offset = "0x1F25DF0", VA = "0x181F26DF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1F26E40", Offset = "0x1F25E40", VA = "0x181F26E40")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F26C80", Offset = "0x1F25C80", VA = "0x181F26C80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1F26D50", Offset = "0x1F25D50", VA = "0x181F26D50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F26CB0", Offset = "0x1F25CB0", VA = "0x181F26CB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA330", Offset = "0x1EB9330", VA = "0x181EBA330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23DF950", Offset = "0x23DE950", VA = "0x1823DF950")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23DF4A0", Offset = "0x23DE4A0", VA = "0x1823DF4A0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D36C20", Offset = "0x1D35C20", VA = "0x181D36C20")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21F57B0", Offset = "0x21F47B0", VA = "0x1821F57B0")]
	public static (T[], U[]) Unzip<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x13B6B0", Offset = "0x13AAB0")] this IEnumerable<(T, U)> self)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEC20", Offset = "0x1DCDC20", VA = "0x181DCEC20")]
	public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21F55D0", Offset = "0x21F45D0", VA = "0x1821F55D0")]
	public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21DE720", Offset = "0x21DD720", VA = "0x1821DE720")]
	public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2156880", Offset = "0x2155880", VA = "0x182156880")]
	public static IEnumerable<T> SkipTake<T>(this IEnumerable<T> enumerable, int skip, int take)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22C7980", Offset = "0x22C6980", VA = "0x1822C7980")]
	public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> enumerable, Func<T, TKey> keyFunc)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x124E0A0", Offset = "0x124D0A0", VA = "0x18124E0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1254150", Offset = "0x1253150", VA = "0x181254150")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float MaxHypotheticalDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D3C20", Offset = "0x7D2C20", VA = "0x1807D3C20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float SafeDeltaTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1254160", Offset = "0x1253160", VA = "0x181254160")]
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
	[Cpp2IlInjected.Address(RVA = "0x12541D0", Offset = "0x12531D0", VA = "0x1812541D0")]
	public static bool IsOlderThanUTC(this DateTime? dateTime, TimeSpan timeSpan)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1254300", Offset = "0x1253300", VA = "0x181254300")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1254270", Offset = "0x1253270", VA = "0x181254270")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class TypeExt
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1255D80", Offset = "0x1254D80", VA = "0x181255D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x124A620", Offset = "0x1249620", VA = "0x18124A620")]
		public static void SafeSetEnabled(this Animator animator, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x124A6A0", Offset = "0x12496A0", VA = "0x18124A6A0")]
		public static void SetBoolIfActive(this Animator animator, int id, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x124A700", Offset = "0x1249700", VA = "0x18124A700")]
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
				[Cpp2IlInjected.Address(RVA = "0x35C8B0", Offset = "0x35BCB0", VA = "0x18035C8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2836420", Offset = "0x2835420", VA = "0x182836420")]
			public SuspendableMergeSort(T[] arrayToSort, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2835CC0", Offset = "0x2834CC0", VA = "0x182835CC0")]
			public bool Continue()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x225F2C0", Offset = "0x225E2C0", VA = "0x18225F2C0")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x22E1E20", Offset = "0x22E0E20", VA = "0x1822E1E20")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x22E1D20", Offset = "0x22E0D20", VA = "0x1822E1D20")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22E2EC0", Offset = "0x22E1EC0", VA = "0x1822E2EC0")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22E2D50", Offset = "0x22E1D50", VA = "0x1822E2D50")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x22E2800", Offset = "0x22E1800", VA = "0x1822E2800")]
		public static void MergeSort<T>(this T[] self, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22E23E0", Offset = "0x22E13E0", VA = "0x1822E23E0")]
		private static void MergeSortImpl<T>(this T[] self, int startIndex, int endIndex, T[] workBuffer, bool needsCopyToWorkBuffer, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x22E2890", Offset = "0x22E1890", VA = "0x1822E2890")]
		private static void Merge<T>(this T[] self, int selfStartIndex, int selfEndIndex, T[] other, int otherStartIndex, int otherEndIndex, T[] result, int resultStartIndex, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22E1F90", Offset = "0x22E0F90", VA = "0x1822E1F90")]
		public static void InsertionSort<T>(this T[] self, int startIndex, int count, CompareDelegate<T> compare)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x21DE4D0", Offset = "0x21DD4D0", VA = "0x1821DE4D0")]
		public static SuspendableMergeSort<T> BeginSuspendableMergeSort<T>(this T[] self, CompareDelegate<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x225F3D0", Offset = "0x225E3D0", VA = "0x18225F3D0")]
		public static T[] Sort<T>(this T[] array)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x225E970", Offset = "0x225D970", VA = "0x18225E970")]
		public static T[] CopyAndAdd<T>(this T[] oldArray, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x225EA50", Offset = "0x225DA50", VA = "0x18225EA50")]
		public static T[] CopyAndInsert<T>(this T[] oldArray, int index, T newItem)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x225EFF0", Offset = "0x225DFF0", VA = "0x18225EFF0")]
		public static T[] CopyAndRemoveAt<T>(this T[] oldArray, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x225F0A0", Offset = "0x225E0A0", VA = "0x18225F0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B1B0", Offset = "0x4A5B0", VA = "0x18004B1B0")]
			public CacheParameters(GameObject gameObject, bool includeMultiple, SearchType searchType, bool includeInactive, Type type)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4B010", Offset = "0x4A410", VA = "0x18004B010", Slot = "4")]
			public bool Equals(CacheParameters other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4B040", Offset = "0x4A440", VA = "0x18004B040", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4B0E0", Offset = "0x4A4E0", VA = "0x18004B0E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4B1A0", Offset = "0x4A5A0", VA = "0x18004B1A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x124AED0", Offset = "0x1249ED0", VA = "0x18124AED0")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x209FEF0", Offset = "0x209EEF0", VA = "0x18209FEF0")]
		public static T GetCachedComponent<T>(this GameObject gameObject, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x209FC10", Offset = "0x209EC10", VA = "0x18209FC10")]
		public static T GetCachedComponentInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x22B25C0", Offset = "0x22B15C0", VA = "0x1822B25C0")]
		public static IReadOnlyList<T> GetCachedComponentsInParent<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x22B24A0", Offset = "0x22B14A0", VA = "0x1822B24A0")]
		public static IReadOnlyList<T> GetCachedComponentsInChildren<T>(this GameObject gameObject, bool includeInactive = true, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x209FD30", Offset = "0x209ED30", VA = "0x18209FD30")]
		private static T GetCachedComponentInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x22B26E0", Offset = "0x22B16E0", VA = "0x1822B26E0")]
		private static IReadOnlyList<T> GetCachedComponentsInternal<T>(CacheParameters cacheParameters, bool force = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x124B3B0", Offset = "0x124A3B0", VA = "0x18124B3B0")]
		private static void TryPrune()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x124AF60", Offset = "0x1249F60", VA = "0x18124AF60")]
		private static void PruneCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x22B2890", Offset = "0x22B1890", VA = "0x1822B2890")]
		private static IReadOnlyList<T> GetComponentForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x22B2990", Offset = "0x22B1990", VA = "0x1822B2990")]
		private static IReadOnlyList<T> GetComponentsForParameters<T>(CacheParameters cacheParameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class CameraExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x124BA10", Offset = "0x124AA10", VA = "0x18124BA10")]
		public static float GetFrustumHeightAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x124BA40", Offset = "0x124AA40", VA = "0x18124BA40")]
		public static float GetFrustumWidthAtDistance(this Camera camera, float distance)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x124BA90", Offset = "0x124AA90", VA = "0x18124BA90")]
		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x124B580", Offset = "0x124A580", VA = "0x18124B580")]
		private static float GetCameraDistanceToHeightRatio(float cameraFieldOfView)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x124B5F0", Offset = "0x124A5F0", VA = "0x18124B5F0")]
		private static float GetCameraDistanceToHeightRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x124B670", Offset = "0x124A670", VA = "0x18124B670")]
		private static float GetCameraDistanceToWidthRatio(float cameraFieldOfView, float cameraAspectRatio)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x124B6F0", Offset = "0x124A6F0", VA = "0x18124B6F0")]
		private static float GetCameraDistanceToWidthRatio(Camera camera)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x124B900", Offset = "0x124A900", VA = "0x18124B900")]
		public static float GetDistanceFromProjectionCameraToFillFOV(float cameraFieldOfView, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x124B7E0", Offset = "0x124A7E0", VA = "0x18124B7E0")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, float worldSpaceHeight, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x124B820", Offset = "0x124A820", VA = "0x18124B820")]
		public static float GetDistanceFromProjectionCameraToFillFOV(this Camera thisCamera, Vector2 worldSpaceSize, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x124B730", Offset = "0x124A730", VA = "0x18124B730")]
		private static float GetDistanceFromProjectionCameraToFillFOVInternal(float distanceToSizeRatio, float worldSpaceSize, float viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x124BC00", Offset = "0x124AC00", VA = "0x18124BC00")]
		public static float GetScaleFactorFromProjectionCameraToFillFOVAtDistance(float cameraFOV, float cameraAspectRatio, Vector2 worldSpaceSize, float desiredDistance, Vector2 viewportMargin)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x124BB40", Offset = "0x124AB40", VA = "0x18124BB40")]
		private static float GetScaleFactorFromProjectionCameraToFillFOVAtDistanceInternal(float distanceToSizeRatio, float worldSpaceSize, float desiredDistance, float viewportMargin = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x124B4F0", Offset = "0x124A4F0", VA = "0x18124B4F0")]
		public static void CleanupRenderTexture(this Camera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x124BE00", Offset = "0x124AE00", VA = "0x18124BE00")]
		public static bool IsInFov(this Camera camera, Renderer renderer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x124BD80", Offset = "0x124AD80", VA = "0x18124BD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x124BE60", Offset = "0x124AE60", VA = "0x18124BE60")]
		public static bool CapsuleCast(this Collider collider, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x124C980", Offset = "0x124B980", VA = "0x18124C980")]
		public static int GetOverlapNonAlloc(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction, Collider[] hitColliders)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x124C4F0", Offset = "0x124B4F0", VA = "0x18124C4F0")]
		public static bool CheckOverlap(this BoxCollider collider, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x124CC40", Offset = "0x124BC40", VA = "0x18124CC40")]
		public static int Overlap(this BoxCollider collider, Collider[] hits, int layerMask, QueryTriggerInteraction triggerInteraction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x124C790", Offset = "0x124B790", VA = "0x18124C790")]
		public static bool Contains(this BoxCollider boxCollider, Vector3 worldPosition)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x124C130", Offset = "0x124B130", VA = "0x18124C130")]
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
		[Cpp2IlInjected.Address(RVA = "0x124D180", Offset = "0x124C180", VA = "0x18124D180")]
		public static Color WithAlpha(this Color color, float alpha)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x124CF90", Offset = "0x124BF90", VA = "0x18124CF90")]
		public static Vector3 GammaToLinearColorSpace(this Vector3 gammaColor)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x124D080", Offset = "0x124C080", VA = "0x18124D080")]
		public static Color GammaToLinearColorSpace(this Color gammaColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x124CF50", Offset = "0x124BF50", VA = "0x18124CF50")]
		public static Color ChangeAlpha(this Color color, float newAlpha)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x124D230", Offset = "0x124C230", VA = "0x18124D230")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x22B2C60", Offset = "0x22B1C60", VA = "0x1822B2C60")]
		public static List<T> FindAllObjectsOfType<T>(this Component component) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x20A0850", Offset = "0x209F850", VA = "0x1820A0850")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1F26E40", Offset = "0x1F25E40", VA = "0x181F26E40")]
			[DebuggerHidden]
			public <GetAllComponentsInScenes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1F4A5D0", Offset = "0x1F495D0", VA = "0x181F4A5D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1F4A7E0", Offset = "0x1F497E0", VA = "0x181F4A7E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1F4A740", Offset = "0x1F49740", VA = "0x181F4A740", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1EC3530", Offset = "0x1EC2530", VA = "0x181EC3530", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2156820", Offset = "0x2155820", VA = "0x182156820")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x41AA10", Offset = "0x419A10", VA = "0x18041AA10")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x1256320", Offset = "0x1255320", VA = "0x181256320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x12563D0", Offset = "0x12553D0", VA = "0x1812563D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x41AA10", Offset = "0x419A10", VA = "0x18041AA10")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1255F40", Offset = "0x1254F40", VA = "0x181255F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1255FF0", Offset = "0x1254FF0", VA = "0x181255FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x124D680", Offset = "0x124C680", VA = "0x18124D680")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x124D620", Offset = "0x124C620", VA = "0x18124D620")]
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
			[Cpp2IlInjected.Address(RVA = "0x12589C0", Offset = "0x12579C0", VA = "0x1812589C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1258990", Offset = "0x1257990", VA = "0x181258990")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class DictionaryExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2260770", Offset = "0x225F770", VA = "0x182260770")]
		public static TValue GetOrCreate<TValue, TKey>(this IDictionary<TKey, TValue> dict, TKey key) where TValue : new()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class EncodingExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x124D750", Offset = "0x124C750", VA = "0x18124D750")]
		public static string ToBase64String(this Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x124D830", Offset = "0x124C830", VA = "0x18124D830")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class FileExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x124D910", Offset = "0x124C910", VA = "0x18124D910")]
		public static string ReadLines(this FileInfo file, string startPattern, string endPattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x124DAF0", Offset = "0x124CAF0", VA = "0x18124DAF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CA4A0", Offset = "0x3C94A0", VA = "0x1803CA4A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x99DB30", Offset = "0x99CB30", VA = "0x18099DB30")]
			[DebuggerHidden]
			public <GetGameObjectHierarchyHelper>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3E5580", Offset = "0x3E4580", VA = "0x1803E5580", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1256040", Offset = "0x1255040", VA = "0x181256040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x12561D0", Offset = "0x12551D0", VA = "0x1812561D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1256130", Offset = "0x1255130", VA = "0x181256130", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1256130", Offset = "0x1255130", VA = "0x181256130", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x20A1D90", Offset = "0x20A0D90", VA = "0x1820A1D90")]
		public static T GetComponentInParent<T>(this GameObject gameObject, bool includeDisabled) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x20A1E70", Offset = "0x20A0E70", VA = "0x1820A1E70")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x124DE40", Offset = "0x124CE40", VA = "0x18124DE40")]
		public static void SetTagRecursively(this GameObject gameObject, string tag)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x124DD10", Offset = "0x124CD10", VA = "0x18124DD10")]
		public static string GetGameObjectHierarchy(this GameObject go)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x124DCA0", Offset = "0x124CCA0", VA = "0x18124DCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2327FB0", Offset = "0x2326FB0", VA = "0x182327FB0")]
		public static V IfNotNull<V, T>(this T t, Func<T, V> todo, [Optional] V defaultValue) where T : class
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x22E4CB0", Offset = "0x22E3CB0", VA = "0x1822E4CB0")]
		public static void DoIfNotNull<T>(this T t, Action<T> todo) where T : class
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2177BB0", Offset = "0x2176BB0", VA = "0x182177BB0")]
		public static int FindIndex<T>(this IReadOnlyList<T> array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x22E4FD0", Offset = "0x22E3FD0", VA = "0x1822E4FD0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x22E5060", Offset = "0x22E4060", VA = "0x1822E5060")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x22B5E20", Offset = "0x22B4E20", VA = "0x1822B5E20")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2178030", Offset = "0x2177030", VA = "0x182178030")]
		public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2375E00", Offset = "0x2374E00", VA = "0x182375E00")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x23757F0", Offset = "0x23747F0", VA = "0x1823757F0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item, EqualityComparer<T> equalityComparer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x20A4BF0", Offset = "0x20A3BF0", VA = "0x1820A4BF0")]
		public static T Random<T>(this IReadOnlyList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2375680", Offset = "0x2374680", VA = "0x182375680")]
		public static bool AddUnique<T>(this List<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x20A4B30", Offset = "0x20A3B30", VA = "0x1820A4B30")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x22E4E10", Offset = "0x22E3E10", VA = "0x1822E4E10")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x20A4CD0", Offset = "0x20A3CD0", VA = "0x1820A4CD0")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x23756F0", Offset = "0x23746F0", VA = "0x1823756F0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x20A2F90", Offset = "0x20A1F90", VA = "0x1820A2F90")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2375F40", Offset = "0x2374F40", VA = "0x182375F40")]
		public static bool SafeTryGetAtIndex<T>(IReadOnlyList<T> list, int index, out T result)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MaterialExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9BEB00", Offset = "0x9BDB00", VA = "0x1809BEB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x124FED0", Offset = "0x124EED0", VA = "0x18124FED0")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x124F690", Offset = "0x124E690", VA = "0x18124F690")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x124F830", Offset = "0x124E830", VA = "0x18124F830")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x124E6A0", Offset = "0x124D6A0", VA = "0x18124E6A0")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x124E580", Offset = "0x124D580", VA = "0x18124E580")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x12509C0", Offset = "0x124F9C0", VA = "0x1812509C0")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1250850", Offset = "0x124F850", VA = "0x181250850")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x124E780", Offset = "0x124D780", VA = "0x18124E780")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1250560", Offset = "0x124F560", VA = "0x181250560")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x124E910", Offset = "0x124D910", VA = "0x18124E910")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x124F1D0", Offset = "0x124E1D0", VA = "0x18124F1D0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x124E360", Offset = "0x124D360", VA = "0x18124E360")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1250090", Offset = "0x124F090", VA = "0x181250090")]
		public static Vector3 MirrorPoint(Vector3 point, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x124FEF0", Offset = "0x124EEF0", VA = "0x18124FEF0")]
		public static Vector3 MirrorDirection(Vector3 direction, Vector3 mirrorPlaneNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x12501F0", Offset = "0x124F1F0", VA = "0x1812501F0")]
		public static void MirrorPrimitiveTransform(Transform transform, Vector3 mirrorPlaneNormal, Vector3 mirrorPlanePosition, Vector3 worldTranslation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x124E3F0", Offset = "0x124D3F0", VA = "0x18124E3F0")]
		public static Vector2 CalculateRectInteriorBoundsDepenetration(Rect rect, Rect boundsRect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x124ED80", Offset = "0x124DD80", VA = "0x18124ED80")]
		public static Vector3 GetLegacyProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float maxRange, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x124F920", Offset = "0x124E920", VA = "0x18124F920")]
		public static Vector3 GetProjectileMotionInitialVelocity(Vector3 origin, Vector3 target, float speed, out float totalLifetime)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x124FBB0", Offset = "0x124EBB0", VA = "0x18124FBB0")]
		private static float GetProjectileMotionLaunchAngleDegrees(Vector3 origin, Vector3 target, float speed)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x124FEB0", Offset = "0x124EEB0", VA = "0x18124FEB0")]
		public static float InverseLerpForMin(float maxValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x124FE90", Offset = "0x124EE90", VA = "0x18124FE90")]
		public static float InverseLerpForMax(float minValue, float tValue, float t)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1250670", Offset = "0x124F670", VA = "0x181250670")]
		public static float SolveQuadraticEquationMaxValue(float a, float b, float c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1250790", Offset = "0x124F790", VA = "0x181250790")]
		public static void SolveQuadraticEquation(float a, float b, float c, out float lowerResult, out float upperResult)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1250630", Offset = "0x124F630", VA = "0x181250630")]
		public static float ReMapRange(this float value, Vector2 range, Vector2 newRange)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x124FE60", Offset = "0x124EE60", VA = "0x18124FE60")]
		public static float GetRandomSign()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xADBD30", Offset = "0xADAD30", VA = "0x180ADBD30")]
		public static float Sqr(this float num)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1250C20", Offset = "0x124FC20", VA = "0x181250C20")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1250C70", Offset = "0x124FC70", VA = "0x181250C70")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1250D00", Offset = "0x124FD00", VA = "0x181250D00")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1250D50", Offset = "0x124FD50", VA = "0x181250D50")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1250B60", Offset = "0x124FB60", VA = "0x181250B60")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1250C30", Offset = "0x124FC30", VA = "0x181250C30")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class ObjectExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1250E20", Offset = "0x124FE20", VA = "0x181250E20")]
		public static string SafeGetName(this UnityEngine.Object obj)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x20AB150", Offset = "0x20AA150", VA = "0x1820AB150")]
		public static T GetClosestRaycastHit<T>(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction triggerInteraction, out Vector3 hitPoint, out Collider hitCollider, Func<Collider, T> vallidateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x20AB430", Offset = "0x20AA430", VA = "0x1820AB430")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1251300", Offset = "0x1250300", VA = "0x181251300")]
		public static void SortByDistanceToCenter(this RaycastHit[] hits, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1250EB0", Offset = "0x124FEB0", VA = "0x181250EB0")]
		public static void ClearVelocity(this Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1251070", Offset = "0x1250070", VA = "0x181251070")]
		public static float CombinedBounciness(this PhysicMaterial thisMaterial, PhysicMaterial otherMaterial)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1250F60", Offset = "0x124FF60", VA = "0x181250F60")]
		private static float CombinePhysicsMaterialProperty(float lhs, float rhs, PhysicMaterialCombine combineFunction)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x11F9B70", Offset = "0x11F8B70", VA = "0x1811F9B70")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1256420", Offset = "0x1255420", VA = "0x181256420")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1256440", Offset = "0x1255440", VA = "0x181256440")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1251890", Offset = "0x1250890", VA = "0x181251890")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1251D40", Offset = "0x1250D40", VA = "0x181251D40")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1251FB0", Offset = "0x1250FB0", VA = "0x181251FB0")]
		public static Quaternion ValueOrIdentityIfBogus(this Quaternion quaternion)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1251B70", Offset = "0x1250B70", VA = "0x181251B70")]
		public static bool IsNaN(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1251B20", Offset = "0x1250B20", VA = "0x181251B20")]
		public static bool IsInfinity(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1251A70", Offset = "0x1250A70", VA = "0x181251A70")]
		public static Quaternion InverseTransformRotation(this Quaternion basis, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1251F10", Offset = "0x1250F10", VA = "0x181251F10")]
		public static Quaternion TransformRotation(this Quaternion parent, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1251C80", Offset = "0x1250C80", VA = "0x181251C80")]
		public static Quaternion RemoveRoll(this Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x12519C0", Offset = "0x12509C0", VA = "0x1812519C0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1251BC0", Offset = "0x1250BC0", VA = "0x181251BC0")]
		public static Quaternion QuaternionFromAngularVelocity(Vector3 angularVelocity)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1251630", Offset = "0x1250630", VA = "0x181251630")]
		public static Vector3 AngularDisplacementFromTo(Quaternion from, Quaternion to)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1251D90", Offset = "0x1250D90", VA = "0x181251D90")]
		public static Quaternion SmoothDamp(Quaternion current, Quaternion target, ref Vector3 eulerAngularVelocity, float smoothTime)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class RectExt
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1252160", Offset = "0x1251160", VA = "0x181252160")]
		public static Rect Encompass(this Rect rect, Vector2 point)
		{
			return default(Rect);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1252440", Offset = "0x1251440", VA = "0x181252440")]
		public static Vector2 UpperRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x12523F0", Offset = "0x12513F0", VA = "0x1812523F0")]
		public static Vector2 UpperLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x12523A0", Offset = "0x12513A0", VA = "0x1812523A0")]
		public static Vector2 LowerRight(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1252350", Offset = "0x1251350", VA = "0x181252350")]
		public static Vector2 LowerLeft(this Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1252280", Offset = "0x1251280", VA = "0x181252280")]
		public static Rect GUIRectToScreenRect(this Rect rect)
		{
			return default(Rect);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x12524B0", Offset = "0x12514B0", VA = "0x1812524B0")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1252660", Offset = "0x1251660", VA = "0x181252660")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1252D50", Offset = "0x1251D50", VA = "0x181252D50")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1252B80", Offset = "0x1251B80", VA = "0x181252B80")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1252AA0", Offset = "0x1251AA0", VA = "0x181252AA0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1252C50", Offset = "0x1251C50", VA = "0x181252C50")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1252490", Offset = "0x1251490", VA = "0x181252490")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x12528B0", Offset = "0x12518B0", VA = "0x1812528B0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1252710", Offset = "0x1251710", VA = "0x181252710")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1252EA0", Offset = "0x1251EA0", VA = "0x181252EA0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1253020", Offset = "0x1252020", VA = "0x181253020")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1252F60", Offset = "0x1251F60", VA = "0x181252F60")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class ScreenHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool IsIPadAspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1253180", Offset = "0x1252180", VA = "0x181253180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x12530E0", Offset = "0x12520E0", VA = "0x1812530E0")]
		public static float GetLandscapeOrientationScreenAspectRatio()
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class StreamingAssetsHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1253230", Offset = "0x1252230", VA = "0x181253230")]
		public static byte[] LoadBytesFromStreamingAssets(string filename)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1253370", Offset = "0x1252370", VA = "0x181253370")]
		private static DownloadHandler LoadFromStreamingAssetsInternal(string filename)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly Regex KeyboardCharsRegex;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly Regex AlphaNumericRegex;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1253940", Offset = "0x1252940", VA = "0x181253940")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1253550", Offset = "0x1252550", VA = "0x181253550")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1253B40", Offset = "0x1252B40", VA = "0x181253B40")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x12535B0", Offset = "0x12525B0", VA = "0x1812535B0")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x12534D0", Offset = "0x12524D0", VA = "0x1812534D0")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x12537F0", Offset = "0x12527F0", VA = "0x1812537F0")]
		public static bool IsRecRoomKeyboardChar(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1253750", Offset = "0x1252750", VA = "0x181253750")]
		public static bool IsRecRoomKeyboardCharOrNewline(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1253730", Offset = "0x1252730", VA = "0x181253730")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1253740", Offset = "0x1252740", VA = "0x181253740")]
		public static bool IsNullOrWhiteSpace(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1253620", Offset = "0x1252620", VA = "0x181253620")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x12536A0", Offset = "0x12526A0", VA = "0x1812536A0")]
		public static bool IsAlphaNumeric(this char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x12534A0", Offset = "0x12524A0", VA = "0x1812534A0")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1253880", Offset = "0x1252880", VA = "0x181253880")]
		public static bool NullOrEmptyEqual(string a, string b, StringComparison stringComparison)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x12538E0", Offset = "0x12528E0", VA = "0x1812538E0")]
		public static string RemoveFromEnd(this string s, string suffix)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TextureExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1253C50", Offset = "0x1252C50", VA = "0x181253C50")]
		public static void ConvertPixelsToGamma(this Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1253D60", Offset = "0x1252D60", VA = "0x181253D60")]
		public static void GetTexture2D(this RenderTexture frame, ref Texture2D texture, bool cropSidesToSquare = false, bool convertToGamma = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class TransformExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly Vector3[] RectCornersBuffer;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1255B10", Offset = "0x1254B10", VA = "0x181255B10")]
		public static Vector3 YawForward(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1255890", Offset = "0x1254890", VA = "0x181255890")]
		public static Vector3 YawForwardPitchCorrected(this Transform transform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1254B70", Offset = "0x1253B70", VA = "0x181254B70")]
		public static Vector3 GetRectWorldSize(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1254880", Offset = "0x1253880", VA = "0x181254880")]
		public static Vector2 GetRectLocalSize(this RectTransform rectTransform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1254680", Offset = "0x1253680", VA = "0x181254680")]
		public static float GetRectLocalArea(this RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x12549F0", Offset = "0x12539F0", VA = "0x1812549F0")]
		public static Vector3 GetRectWorldCenter(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x12545C0", Offset = "0x12535C0", VA = "0x1812545C0")]
		public static Vector3[] GetInstantaneousWorldCornersNonAlloc(this RectTransform rectTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x12550A0", Offset = "0x12540A0", VA = "0x1812550A0")]
		public static Quaternion InverseTransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x12557D0", Offset = "0x12547D0", VA = "0x1812557D0")]
		public static Quaternion TransformRotation(this Transform transform, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1254E60", Offset = "0x1253E60", VA = "0x181254E60")]
		public static Vector3 InverseTransformPointUnscaled(this Transform transform, Vector3 position)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1254CC0", Offset = "0x1253CC0", VA = "0x181254CC0")]
		public static bool HasParent(this Transform transform, Transform searchTransform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x55B170", Offset = "0x55A170", VA = "0x18055B170")]
		public static float GetLossyUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1254650", Offset = "0x1253650", VA = "0x181254650")]
		public static float GetLocalUniformScale(this Transform transform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1255380", Offset = "0x1254380", VA = "0x181255380")]
		public static void SetLocalUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x12551B0", Offset = "0x12541B0", VA = "0x1812551B0")]
		public static void SetLocalScale(this Transform transform, float uniformScale, Vector3 aspectRatio)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x12555B0", Offset = "0x12545B0", VA = "0x1812555B0")]
		public static void SetLossyUniformScale(this Transform transform, float uniformScale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1254D90", Offset = "0x1253D90", VA = "0x181254D90")]
		public static float InverseTransformLossyUniformScale(this Transform transform, float uniformLossyScale)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1255750", Offset = "0x1254750", VA = "0x181255750")]
		public static float TransformLocalUniformScale(this Transform transform, float uniformLocalScale)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x12568D0", Offset = "0x12558D0", VA = "0x1812568D0")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1256820", Offset = "0x1255820", VA = "0x181256820")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1256730", Offset = "0x1255730", VA = "0x181256730")]
		public static Vector2 Clamp01(this Vector2 vector)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1256930", Offset = "0x1255930", VA = "0x181256930")]
		public static bool WithinBounds(this Vector2 bounds, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x12564A0", Offset = "0x12554A0", VA = "0x1812564A0")]
		public static float AngleSignedVector2(this Vector2 from, Vector2 to)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1256CA0", Offset = "0x1255CA0", VA = "0x181256CA0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1258220", Offset = "0x1257220", VA = "0x181258220")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1258660", Offset = "0x1257660", VA = "0x181258660")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x12583A0", Offset = "0x12573A0", VA = "0x1812583A0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x12584C0", Offset = "0x12574C0", VA = "0x1812584C0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation, Vector3 lossyScale)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x12575C0", Offset = "0x12565C0", VA = "0x1812575C0")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x12577B0", Offset = "0x12567B0", VA = "0x1812577B0")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x12578E0", Offset = "0x12568E0", VA = "0x1812578E0")]
		public static bool IsValidOnScreenViewportCoordinates(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1257950", Offset = "0x1256950", VA = "0x181257950")]
		public static bool IsWithinUnitCube(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1257A10", Offset = "0x1256A10", VA = "0x181257A10")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1257AA0", Offset = "0x1256AA0", VA = "0x181257AA0")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1256960", Offset = "0x1255960", VA = "0x181256960")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1258840", Offset = "0x1257840", VA = "0x181258840")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1256FA0", Offset = "0x1255FA0", VA = "0x181256FA0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x12579C0", Offset = "0x12569C0", VA = "0x1812579C0")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1257750", Offset = "0x1256750", VA = "0x181257750")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x12576F0", Offset = "0x12566F0", VA = "0x1812576F0")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1257BF0", Offset = "0x1256BF0", VA = "0x181257BF0")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1257110", Offset = "0x1256110", VA = "0x181257110")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1256AE0", Offset = "0x1255AE0", VA = "0x181256AE0")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1258900", Offset = "0x1257900", VA = "0x181258900")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1257200", Offset = "0x1256200", VA = "0x181257200")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x12571A0", Offset = "0x12561A0", VA = "0x1812571A0")]
		public static Vector3 FromX(float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x12571D0", Offset = "0x12561D0", VA = "0x1812571D0")]
		public static Vector3 FromY(float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1258010", Offset = "0x1257010", VA = "0x181258010")]
		public static Vector3 SetX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1258050", Offset = "0x1257050", VA = "0x181258050")]
		public static Vector3 SetY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1258090", Offset = "0x1257090", VA = "0x181258090")]
		public static Vector3 SetZ(this Vector3 self, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1256A20", Offset = "0x1255A20", VA = "0x181256A20")]
		public static Vector3 AddY(this Vector3 self, float y)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12582E0", Offset = "0x12572E0", VA = "0x1812582E0")]
		public static Vector3 SubX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1257B30", Offset = "0x1256B30", VA = "0x181257B30")]
		public static Vector3 MulX(this Vector3 self, float x)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1257C80", Offset = "0x1256C80", VA = "0x181257C80")]
		public static Vector3 ProjectDirectionOntoSurface(Vector3 desiredDirection, Vector3 surfaceNormal, Vector3 up)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1257DC0", Offset = "0x1256DC0", VA = "0x181257DC0")]
		public static Vector3 ProjectGroundSpaceVectorOnToWall(Vector3 vector, Vector3 wallUp, Vector3 wallNormal, bool allowedToMoveUp)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x12580D0", Offset = "0x12570D0", VA = "0x1812580D0")]
		public static float SignedAngleOnPlane(this Vector3 from, Vector3 to, Vector3 planeNormalAxis, bool shiftPositive = false)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x22E6700", Offset = "0x22E5700", VA = "0x1822E6700")]
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

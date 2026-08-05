using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ArrayExt
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BE43B0", Offset = "0x1BE35B0", VA = "0x181BE43B0")]
	public static T[] CreateFilled<T>(int size, T with)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xE3F3D0", Offset = "0xE3E5D0", VA = "0x180E3F3D0")]
	public static void Fill<T>(this T[] originalArray, T with)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xE3F2D0", Offset = "0xE3E4D0", VA = "0x180E3F2D0")]
	public static void Exchange<T>(this T[] array, int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xECB640", Offset = "0xECA840", VA = "0x180ECB640")]
	public static int FindIndex<T>(this T[] array, T value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCF6E70", Offset = "0xCF6070", VA = "0x180CF6E70")]
	public static bool Contains<T>(this T[] array, T item)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EnumerableExt
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x10A7700", Offset = "0x10A6900", VA = "0x1810A7700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD5B720", Offset = "0xD5A920", VA = "0x180D5B720")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10A7580", Offset = "0x10A6780", VA = "0x1810A7580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x10A7660", Offset = "0x10A6860", VA = "0x1810A7660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x10A75B0", Offset = "0x10A67B0", VA = "0x1810A75B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD59690", Offset = "0xD58890", VA = "0x180D59690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE4EE90", Offset = "0xE4E090", VA = "0x180E4EE90")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE4E9E0", Offset = "0xE4DBE0", VA = "0x180E4E9E0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x965000", Offset = "0x964200", VA = "0x180965000")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2404B10", Offset = "0x2403D10", VA = "0x182404B10")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2407810", Offset = "0x2406A10", VA = "0x182407810")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2407780", Offset = "0x2406980", VA = "0x182407780")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xCF7BF0", Offset = "0xCF6DF0", VA = "0x180CF7BF0")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2404530", Offset = "0x2403730", VA = "0x182404530")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class CoroutineExt
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class <WaitRoutine>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public float waitDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x339BC0", Offset = "0x338DC0", VA = "0x180339BC0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2407BD0", Offset = "0x2406DD0", VA = "0x182407BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2407C80", Offset = "0x2406E80", VA = "0x182407C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x339BC0", Offset = "0x338DC0", VA = "0x180339BC0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2407AD0", Offset = "0x2406CD0", VA = "0x182407AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2407B80", Offset = "0x2406D80", VA = "0x182407B80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class <WaitUntilTrueOrTimeout>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Func<bool> predicate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Action onTrue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float timeoutSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Action onTimedOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private float <startTime>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x339BC0", Offset = "0x338DC0", VA = "0x180339BC0")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2407CD0", Offset = "0x2406ED0", VA = "0x182407CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2407D90", Offset = "0x2406F90", VA = "0x182407D90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x24049B0", Offset = "0x2403BB0", VA = "0x1824049B0")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2404950", Offset = "0x2403B50", VA = "0x182404950")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2404A20", Offset = "0x2403C20", VA = "0x182404A20")]
		[IteratorStateMachine(typeof(<WaitUntilTrueOrTimeout>d__3))]
		public static IEnumerator WaitUntilTrueOrTimeout(Func<bool> predicate, Action onTrue, Action onTimedOut, float timeoutSeconds)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class WaitForSecondsIgnoreHitches : CustomYieldInstruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float elapsedSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float targetSeconds;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override bool keepWaiting
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2409600", Offset = "0x2408800", VA = "0x182409600", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x24095D0", Offset = "0x24087D0", VA = "0x1824095D0")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6F960", Offset = "0xA6EB60", VA = "0x180A6F960")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5A0", Offset = "0xA6E7A0", VA = "0x180A6F5A0")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xCF9CE0", Offset = "0xCF8EE0", VA = "0x180CF9CE0")]
		public static bool RemoveAllWhere<T>(this IList<T> collection, Predicate<T> match, out List<T> removedElements)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB04A00", Offset = "0xB03C00", VA = "0x180B04A00")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCF9AF0", Offset = "0xCF8CF0", VA = "0x180CF9AF0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x993B10", Offset = "0x992D10", VA = "0x180993B10")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6F380", Offset = "0xA6E580", VA = "0x180A6F380")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x993A50", Offset = "0x992C50", VA = "0x180993A50")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6F3E0", Offset = "0xA6E5E0", VA = "0x180A6F3E0")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x993C00", Offset = "0x992E00", VA = "0x180993C00")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x993B90", Offset = "0x992D90", VA = "0x180993B90")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xCF95D0", Offset = "0xCF87D0", VA = "0x180CF95D0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9938C0", Offset = "0x992AC0", VA = "0x1809938C0")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2405B40", Offset = "0x2404D40", VA = "0x182405B40")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2405CE0", Offset = "0x2404EE0", VA = "0x182405CE0")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2404F80", Offset = "0x2404180", VA = "0x182404F80")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2404E60", Offset = "0x2404060", VA = "0x182404E60")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2406010", Offset = "0x2405210", VA = "0x182406010")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2405EA0", Offset = "0x24050A0", VA = "0x182405EA0")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2405060", Offset = "0x2404260", VA = "0x182405060")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2405DD0", Offset = "0x2404FD0", VA = "0x182405DD0")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x24051F0", Offset = "0x24043F0", VA = "0x1824051F0")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2405660", Offset = "0x2404860", VA = "0x182405660")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2404DD0", Offset = "0x2403FD0", VA = "0x182404DD0")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x24062B0", Offset = "0x24054B0", VA = "0x1824062B0")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2406340", Offset = "0x2405540", VA = "0x182406340")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2406390", Offset = "0x2405590", VA = "0x182406390")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x24061B0", Offset = "0x24053B0", VA = "0x1824061B0")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2406270", Offset = "0x2405470", VA = "0x182406270")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9962B0", Offset = "0x9954B0", VA = "0x1809962B0")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2407DE0", Offset = "0x2406FE0", VA = "0x182407DE0")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2407E10", Offset = "0x2407010", VA = "0x182407E10")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2407E30", Offset = "0x2407030", VA = "0x182407E30")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class QuaternionExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly float ONE_HUNDRED_AND_EIGHTY;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly float THREE_HUNDRED_AND_SIXTY;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x24064D0", Offset = "0x24056D0", VA = "0x1824064D0")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2406600", Offset = "0x2405800", VA = "0x182406600")]
		public static Quaternion RightHandedToLeftHanded(this Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24066B0", Offset = "0x24058B0", VA = "0x1824066B0")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2406860", Offset = "0x2405A60", VA = "0x182406860")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2406F50", Offset = "0x2406150", VA = "0x182406F50")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2406D80", Offset = "0x2405F80", VA = "0x182406D80")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2406CA0", Offset = "0x2405EA0", VA = "0x182406CA0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2406E50", Offset = "0x2406050", VA = "0x182406E50")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2406690", Offset = "0x2405890", VA = "0x182406690")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2406AB0", Offset = "0x2405CB0", VA = "0x182406AB0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2406910", Offset = "0x2405B10", VA = "0x182406910")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x24070A0", Offset = "0x24062A0", VA = "0x1824070A0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2407220", Offset = "0x2406420", VA = "0x182407220")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2407160", Offset = "0x2406360", VA = "0x182407160")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x24074F0", Offset = "0x24066F0", VA = "0x1824074F0")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2407380", Offset = "0x2406580", VA = "0x182407380")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2407700", Offset = "0x2406900", VA = "0x182407700")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x24073F0", Offset = "0x24065F0", VA = "0x1824073F0")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2407310", Offset = "0x2406510", VA = "0x182407310")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24074E0", Offset = "0x24066E0", VA = "0x1824074E0")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2407470", Offset = "0x2406670", VA = "0x182407470")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x24072E0", Offset = "0x24064E0", VA = "0x1824072E0")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2407E90", Offset = "0x2407090", VA = "0x182407E90")]
		public static Vector2 ClampToRect(this Vector2 input, Rect rect)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x24081E0", Offset = "0x24073E0", VA = "0x1824081E0")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x24090C0", Offset = "0x24082C0", VA = "0x1824090C0")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x24092A0", Offset = "0x24084A0", VA = "0x1824092A0")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2409180", Offset = "0x2408380", VA = "0x182409180")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2408B60", Offset = "0x2407D60", VA = "0x182408B60")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2408D50", Offset = "0x2407F50", VA = "0x182408D50")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2408F10", Offset = "0x2408110", VA = "0x182408F10")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2408FA0", Offset = "0x24081A0", VA = "0x182408FA0")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2407F40", Offset = "0x2407140", VA = "0x182407F40")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2409480", Offset = "0x2408680", VA = "0x182409480")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24085A0", Offset = "0x24077A0", VA = "0x1824085A0")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2408EC0", Offset = "0x24080C0", VA = "0x182408EC0")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2408CF0", Offset = "0x2407EF0", VA = "0x182408CF0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2408C90", Offset = "0x2407E90", VA = "0x182408C90")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2409030", Offset = "0x2408230", VA = "0x182409030")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2408710", Offset = "0x2407910", VA = "0x182408710")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2408000", Offset = "0x2407200", VA = "0x182408000")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2409540", Offset = "0x2408740", VA = "0x182409540")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24087A0", Offset = "0x24079A0", VA = "0x1824087A0")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA72810", Offset = "0xA71A10", VA = "0x180A72810")]
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

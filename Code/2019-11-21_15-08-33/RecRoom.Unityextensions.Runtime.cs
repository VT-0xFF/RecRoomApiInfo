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
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x14CEB90", Offset = "0x14CDF90", VA = "0x1814CEB90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB8D920", Offset = "0xB8CD20", VA = "0x180B8D920")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x319640", Offset = "0x318A40", VA = "0x180319640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x14CEA10", Offset = "0x14CDE10", VA = "0x1814CEA10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14CEAF0", Offset = "0x14CDEF0", VA = "0x1814CEAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x14CEA40", Offset = "0x14CDE40", VA = "0x1814CEA40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96A5A0", Offset = "0x9699A0", VA = "0x18096A5A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCA7180", Offset = "0xCA6580", VA = "0x180CA7180")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCA6CD0", Offset = "0xCA60D0", VA = "0x180CA6CD0")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BF490", Offset = "0x6BE890", VA = "0x1806BF490")]
	[IteratorStateMachine(typeof(<SingleItemAsEnumerable>d__2<>))]
	public static IEnumerable<T> SingleItemAsEnumerable<T>(T item)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GizmoExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2223E30", Offset = "0x2223230", VA = "0x182223E30")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2226B60", Offset = "0x2225F60", VA = "0x182226B60")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2226AD0", Offset = "0x2225ED0", VA = "0x182226AD0")]
	private static string Pluralize(string word, double total)
	{
		return null;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ArrayExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x12DE6F0", Offset = "0x12DDAF0", VA = "0x1812DE6F0")]
		public static T[] CreateFilled<T>(int size, T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x834800", Offset = "0x833C00", VA = "0x180834800")]
		public static void Fill<T>(this T[] originalArray, T with)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x834700", Offset = "0x833B00", VA = "0x180834700")]
		public static void Exchange<T>(this T[] array, int i, int j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xBBE670", Offset = "0xBBDA70", VA = "0x180BBE670")]
		public static int FindIndex<T>(this T[] array, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5BC0", Offset = "0xAA4FC0", VA = "0x180AA5BC0")]
		public static bool Contains<T>(this T[] array, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x834B20", Offset = "0x833F20", VA = "0x180834B20")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8349A0", Offset = "0x833DA0", VA = "0x1808349A0")]
		public static void Shuffle<T>(this T[] array, int randomSeed)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA68A0", Offset = "0xAA5CA0", VA = "0x180AA68A0")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2223850", Offset = "0x2222C50", VA = "0x182223850")]
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
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x332ED0", Offset = "0x3322D0", VA = "0x180332ED0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x319640", Offset = "0x318A40", VA = "0x180319640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2226F20", Offset = "0x2226320", VA = "0x182226F20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2226FD0", Offset = "0x22263D0", VA = "0x182226FD0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x332ED0", Offset = "0x3322D0", VA = "0x180332ED0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x319640", Offset = "0x318A40", VA = "0x180319640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2226E20", Offset = "0x2226220", VA = "0x182226E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2226ED0", Offset = "0x22262D0", VA = "0x182226ED0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x31BDC0", Offset = "0x31B1C0", VA = "0x18031BDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x332ED0", Offset = "0x3322D0", VA = "0x180332ED0")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x319640", Offset = "0x318A40", VA = "0x180319640", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2227020", Offset = "0x2226420", VA = "0x182227020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x22270E0", Offset = "0x22264E0", VA = "0x1822270E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2223CD0", Offset = "0x22230D0", VA = "0x182223CD0")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2223C70", Offset = "0x2223070", VA = "0x182223C70")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2223D40", Offset = "0x2223140", VA = "0x182223D40")]
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
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x22289B0", Offset = "0x2227DB0", VA = "0x1822289B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2228980", Offset = "0x2227D80", VA = "0x182228980")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F0", Offset = "0x83D5F0", VA = "0x18083E1F0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83E280", Offset = "0x83D680", VA = "0x18083E280")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA88B0", Offset = "0xAA7CB0", VA = "0x180AA88B0")]
		public static bool RemoveAllWhere<T>(this IList<T> collection, Predicate<T> match, out List<T> removedElements)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8983D0", VA = "0x180898FD0")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA87F0", Offset = "0xAA7BF0", VA = "0x180AA87F0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x723F60", Offset = "0x723360", VA = "0x180723F60")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83DFD0", Offset = "0x83D3D0", VA = "0x18083DFD0")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x723EA0", Offset = "0x7232A0", VA = "0x180723EA0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83E030", Offset = "0x83D430", VA = "0x18083E030")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x724050", Offset = "0x723450", VA = "0x180724050")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x723FE0", Offset = "0x7233E0", VA = "0x180723FE0")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA8280", Offset = "0xAA7680", VA = "0x180AA8280")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x723D10", Offset = "0x723110", VA = "0x180723D10")]
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

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x22250F0", Offset = "0x22244F0", VA = "0x1822250F0")]
		public static bool IsInRangeInclusive(int value, int rangeA, int rangeB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2224E60", Offset = "0x2224260", VA = "0x182224E60")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2225000", Offset = "0x2224400", VA = "0x182225000")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x22242A0", Offset = "0x22236A0", VA = "0x1822242A0")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2224180", Offset = "0x2223580", VA = "0x182224180")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2225350", Offset = "0x2224750", VA = "0x182225350")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x22251E0", Offset = "0x22245E0", VA = "0x1822251E0")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2224380", Offset = "0x2223780", VA = "0x182224380")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2225110", Offset = "0x2224510", VA = "0x182225110")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2224510", Offset = "0x2223910", VA = "0x182224510")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2224980", Offset = "0x2223D80", VA = "0x182224980")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x22240F0", Offset = "0x22234F0", VA = "0x1822240F0")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x22255B0", Offset = "0x22249B0", VA = "0x1822255B0")]
		public static bool IsReferenceNull(this MonoBehaviour behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2225600", Offset = "0x2224A00", VA = "0x182225600")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2225690", Offset = "0x2224A90", VA = "0x182225690")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x22256E0", Offset = "0x2224AE0", VA = "0x1822256E0")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x22254F0", Offset = "0x22248F0", VA = "0x1822254F0")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x22255C0", Offset = "0x22249C0", VA = "0x1822255C0")]
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

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x726700", Offset = "0x725B00", VA = "0x180726700")]
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

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2227130", Offset = "0x2226530", VA = "0x182227130")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2227160", Offset = "0x2226560", VA = "0x182227160")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2227180", Offset = "0x2226580", VA = "0x182227180")]
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

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2225820", Offset = "0x2224C20", VA = "0x182225820")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2225950", Offset = "0x2224D50", VA = "0x182225950")]
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

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2225A00", Offset = "0x2224E00", VA = "0x182225A00")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2225BB0", Offset = "0x2224FB0", VA = "0x182225BB0")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x22262A0", Offset = "0x22256A0", VA = "0x1822262A0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x22260D0", Offset = "0x22254D0", VA = "0x1822260D0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2225FF0", Offset = "0x22253F0", VA = "0x182225FF0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x22261A0", Offset = "0x22255A0", VA = "0x1822261A0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x22259E0", Offset = "0x2224DE0", VA = "0x1822259E0")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2225E00", Offset = "0x2225200", VA = "0x182225E00")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2225C60", Offset = "0x2225060", VA = "0x182225C60")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22263F0", Offset = "0x22257F0", VA = "0x1822263F0")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2226570", Offset = "0x2225970", VA = "0x182226570")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x22264B0", Offset = "0x22258B0", VA = "0x1822264B0")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2226840", Offset = "0x2225C40", VA = "0x182226840")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x22266D0", Offset = "0x2225AD0", VA = "0x1822266D0")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2226A50", Offset = "0x2225E50", VA = "0x182226A50")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2226740", Offset = "0x2225B40", VA = "0x182226740")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2226660", Offset = "0x2225A60", VA = "0x182226660")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2226830", Offset = "0x2225C30", VA = "0x182226830")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x22267C0", Offset = "0x2225BC0", VA = "0x1822267C0")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2226630", Offset = "0x2225A30", VA = "0x182226630")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2227290", Offset = "0x2226690", VA = "0x182227290")]
		public static Vector2 ViewportToScreenPosition(Vector2 viewportPos)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x22271E0", Offset = "0x22265E0", VA = "0x1822271E0")]
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

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2227590", Offset = "0x2226990", VA = "0x182227590")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2228470", Offset = "0x2227870", VA = "0x182228470")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2228650", Offset = "0x2227A50", VA = "0x182228650")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2228530", Offset = "0x2227930", VA = "0x182228530")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2227F10", Offset = "0x2227310", VA = "0x182227F10")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2228100", Offset = "0x2227500", VA = "0x182228100")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x22282C0", Offset = "0x22276C0", VA = "0x1822282C0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2228350", Offset = "0x2227750", VA = "0x182228350")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x22272F0", Offset = "0x22266F0", VA = "0x1822272F0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2228830", Offset = "0x2227C30", VA = "0x182228830")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2227950", Offset = "0x2226D50", VA = "0x182227950")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2228270", Offset = "0x2227670", VA = "0x182228270")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x22280A0", Offset = "0x22274A0", VA = "0x1822280A0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2228040", Offset = "0x2227440", VA = "0x182228040")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x22283E0", Offset = "0x22277E0", VA = "0x1822283E0")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2227AC0", Offset = "0x2226EC0", VA = "0x182227AC0")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x22273B0", Offset = "0x22267B0", VA = "0x1822273B0")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x22288F0", Offset = "0x2227CF0", VA = "0x1822288F0")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2227B50", Offset = "0x2226F50", VA = "0x182227B50")]
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
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8410A0", Offset = "0x8404A0", VA = "0x1808410A0")]
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

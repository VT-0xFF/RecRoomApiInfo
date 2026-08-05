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
	[Cpp2IlInjected.Address(RVA = "0x1CFF870", Offset = "0x1CFE270", VA = "0x181CFF870")]
	public static T[] CreateFilled<T>(int size, T with)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15D1FF0", Offset = "0x15D09F0", VA = "0x1815D1FF0")]
	public static void Fill<T>(this T[] originalArray, T with)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15D1EF0", Offset = "0x15D08F0", VA = "0x1815D1EF0")]
	public static void Exchange<T>(this T[] array, int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1619270", Offset = "0x1617C70", VA = "0x181619270")]
	public static int FindIndex<T>(this T[] array, T value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14C1280", Offset = "0x14BFC80", VA = "0x1814C1280")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x16D5680", Offset = "0x16D4080", VA = "0x1816D5680", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14A3790", Offset = "0x14A2190", VA = "0x1814A3790")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x16D5500", Offset = "0x16D3F00", VA = "0x1816D5500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16D55E0", Offset = "0x16D3FE0", VA = "0x1816D55E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16D5530", Offset = "0x16D3F30", VA = "0x1816D5530", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1536DD0", Offset = "0x15357D0", VA = "0x181536DD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x15DF530", Offset = "0x15DDF30", VA = "0x1815DF530")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x15DF080", Offset = "0x15DDA80", VA = "0x1815DF080")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x10B3A10", Offset = "0x10B2410", VA = "0x1810B3A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x24C1AA0", Offset = "0x24C04A0", VA = "0x1824C1AA0")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class TimeSpanExt
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x24C47A0", Offset = "0x24C31A0", VA = "0x1824C47A0")]
	public static string TimeSpanToHumanReadableStringShort(this TimeSpan timeSpan, string zeroUnit = "minute", bool shortUnit = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x24C4710", Offset = "0x24C3110", VA = "0x1824C4710")]
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
		[Cpp2IlInjected.Address(RVA = "0x14C1FF0", Offset = "0x14C09F0", VA = "0x1814C1FF0")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24C14C0", Offset = "0x24BFEC0", VA = "0x1824C14C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x378C80", Offset = "0x377680", VA = "0x180378C80")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24C4B60", Offset = "0x24C3560", VA = "0x1824C4B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24C4C10", Offset = "0x24C3610", VA = "0x1824C4C10", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x378C80", Offset = "0x377680", VA = "0x180378C80")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x24C4A60", Offset = "0x24C3460", VA = "0x1824C4A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x24C4B10", Offset = "0x24C3510", VA = "0x1824C4B10", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x378C80", Offset = "0x377680", VA = "0x180378C80")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x24C4C60", Offset = "0x24C3660", VA = "0x1824C4C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x24C4D20", Offset = "0x24C3720", VA = "0x1824C4D20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x24C1940", Offset = "0x24C0340", VA = "0x1824C1940")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x24C18E0", Offset = "0x24C02E0", VA = "0x1824C18E0")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24C19B0", Offset = "0x24C03B0", VA = "0x1824C19B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x24C6590", Offset = "0x24C4F90", VA = "0x1824C6590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x24C6560", Offset = "0x24C4F60", VA = "0x1824C6560")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1311560", Offset = "0x130FF60", VA = "0x181311560")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x13111A0", Offset = "0x130FBA0", VA = "0x1813111A0")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x14C40E0", Offset = "0x14C2AE0", VA = "0x1814C40E0")]
		public static bool RemoveAllWhere<T>(this IList<T> collection, Predicate<T> match, out List<T> removedElements)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12ED7D0", Offset = "0x12EC1D0", VA = "0x1812ED7D0")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14C3EF0", Offset = "0x14C28F0", VA = "0x1814C3EF0")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1135C40", Offset = "0x1134640", VA = "0x181135C40")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1133E10", Offset = "0x1132810", VA = "0x181133E10")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1135B80", Offset = "0x1134580", VA = "0x181135B80")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1310FE0", Offset = "0x130F9E0", VA = "0x181310FE0")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1135D30", Offset = "0x1134730", VA = "0x181135D30")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1135CC0", Offset = "0x11346C0", VA = "0x181135CC0")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x14C39D0", Offset = "0x14C23D0", VA = "0x1814C39D0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x11359F0", Offset = "0x11343F0", VA = "0x1811359F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C2AD0", Offset = "0x24C14D0", VA = "0x1824C2AD0")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x24C2C70", Offset = "0x24C1670", VA = "0x1824C2C70")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x24C1F10", Offset = "0x24C0910", VA = "0x1824C1F10")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24C1DF0", Offset = "0x24C07F0", VA = "0x1824C1DF0")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x24C2FA0", Offset = "0x24C19A0", VA = "0x1824C2FA0")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x24C2E30", Offset = "0x24C1830", VA = "0x1824C2E30")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x24C1FF0", Offset = "0x24C09F0", VA = "0x1824C1FF0")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x24C2D60", Offset = "0x24C1760", VA = "0x1824C2D60")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x24C2180", Offset = "0x24C0B80", VA = "0x1824C2180")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x24C25F0", Offset = "0x24C0FF0", VA = "0x1824C25F0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x24C1D60", Offset = "0x24C0760", VA = "0x1824C1D60")]
		public static bool Approximately(float a, float b, float maxError)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x24C3240", Offset = "0x24C1C40", VA = "0x1824C3240")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x24C32D0", Offset = "0x24C1CD0", VA = "0x1824C32D0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x24C3320", Offset = "0x24C1D20", VA = "0x1824C3320")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x24C3140", Offset = "0x24C1B40", VA = "0x1824C3140")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x24C3200", Offset = "0x24C1C00", VA = "0x1824C3200")]
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
		[Cpp2IlInjected.Address(RVA = "0x11383E0", Offset = "0x1136DE0", VA = "0x1811383E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C4D70", Offset = "0x24C3770", VA = "0x1824C4D70")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x24C4DA0", Offset = "0x24C37A0", VA = "0x1824C4DA0")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x24C4DC0", Offset = "0x24C37C0", VA = "0x1824C4DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C3460", Offset = "0x24C1E60", VA = "0x1824C3460")]
		public static Vector3 EulerAnglesFromNegative180to180(this Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24C3590", Offset = "0x24C1F90", VA = "0x1824C3590")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C3640", Offset = "0x24C2040", VA = "0x1824C3640")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x24C37F0", Offset = "0x24C21F0", VA = "0x1824C37F0")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x24C3EE0", Offset = "0x24C28E0", VA = "0x1824C3EE0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x24C3D10", Offset = "0x24C2710", VA = "0x1824C3D10")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x24C3C30", Offset = "0x24C2630", VA = "0x1824C3C30")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x24C3DE0", Offset = "0x24C27E0", VA = "0x1824C3DE0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24C3620", Offset = "0x24C2020", VA = "0x1824C3620")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24C3A40", Offset = "0x24C2440", VA = "0x1824C3A40")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24C38A0", Offset = "0x24C22A0", VA = "0x1824C38A0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x24C4030", Offset = "0x24C2A30", VA = "0x1824C4030")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x24C41B0", Offset = "0x24C2BB0", VA = "0x1824C41B0")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x24C40F0", Offset = "0x24C2AF0", VA = "0x1824C40F0")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x24C4480", Offset = "0x24C2E80", VA = "0x1824C4480")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x24C4310", Offset = "0x24C2D10", VA = "0x1824C4310")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x24C4690", Offset = "0x24C3090", VA = "0x1824C4690")]
		public static string Truncate(this string value, int maxLength, string appendIfLong = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x24C4380", Offset = "0x24C2D80", VA = "0x1824C4380")]
		public static int GetStableHashCode(this string s)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x24C42A0", Offset = "0x24C2CA0", VA = "0x1824C42A0")]
		public static bool ContainsKeyboardCharsOnly(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24C4470", Offset = "0x24C2E70", VA = "0x1824C4470")]
		public static bool IsNullOrEmpty(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24C4400", Offset = "0x24C2E00", VA = "0x1824C4400")]
		public static bool IsAlphaNumeric(this string s)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x24C4270", Offset = "0x24C2C70", VA = "0x1824C4270")]
		public static bool CaseInsensitiveContains(this string str, string value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class Vector2Exts
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x24C4E20", Offset = "0x24C3820", VA = "0x1824C4E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C5170", Offset = "0x24C3B70", VA = "0x1824C5170")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x24C6050", Offset = "0x24C4A50", VA = "0x1824C6050")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x24C6230", Offset = "0x24C4C30", VA = "0x1824C6230")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x24C6110", Offset = "0x24C4B10", VA = "0x1824C6110")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x24C5AF0", Offset = "0x24C44F0", VA = "0x1824C5AF0")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x24C5CE0", Offset = "0x24C46E0", VA = "0x1824C5CE0")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x24C5EA0", Offset = "0x24C48A0", VA = "0x1824C5EA0")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x24C5F30", Offset = "0x24C4930", VA = "0x1824C5F30")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x24C4ED0", Offset = "0x24C38D0", VA = "0x1824C4ED0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x24C6410", Offset = "0x24C4E10", VA = "0x1824C6410")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24C5530", Offset = "0x24C3F30", VA = "0x1824C5530")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24C5E50", Offset = "0x24C4850", VA = "0x1824C5E50")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x24C5C80", Offset = "0x24C4680", VA = "0x1824C5C80")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x24C5C20", Offset = "0x24C4620", VA = "0x1824C5C20")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x24C5FC0", Offset = "0x24C49C0", VA = "0x1824C5FC0")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x24C56A0", Offset = "0x24C40A0", VA = "0x1824C56A0")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x24C4F90", Offset = "0x24C3990", VA = "0x1824C4F90")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24C64D0", Offset = "0x24C4ED0", VA = "0x1824C64D0")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24C5730", Offset = "0x24C4130", VA = "0x1824C5730")]
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
		[Cpp2IlInjected.Address(RVA = "0x1313C30", Offset = "0x1312630", VA = "0x181313C30")]
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

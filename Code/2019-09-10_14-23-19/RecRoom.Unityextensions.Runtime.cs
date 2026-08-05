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
	[Cpp2IlInjected.Address(RVA = "0x1451550", Offset = "0x1450950", VA = "0x181451550")]
	public static T[] CreateFilled<T>(int size, T with)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xEBD290", Offset = "0xEBC690", VA = "0x180EBD290")]
	public static void Fill<T>(this T[] originalArray, T with)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xEBD190", Offset = "0xEBC590", VA = "0x180EBD190")]
	public static void Exchange<T>(this T[] array, int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xE2EFF0", Offset = "0xE2E3F0", VA = "0x180E2EFF0")]
	public static int FindIndex<T>(this T[] array, T value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD22440", Offset = "0xD21840", VA = "0x180D22440")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xFEFC90", Offset = "0xFEF090", VA = "0x180FEFC90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDAF3F0", Offset = "0xDAE7F0", VA = "0x180DAF3F0")]
		[DebuggerHidden]
		public <SingleItemAsEnumerable>d__2(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xFEFB10", Offset = "0xFEEF10", VA = "0x180FEFB10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xFEFBF0", Offset = "0xFEEFF0", VA = "0x180FEFBF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xFEFB40", Offset = "0xFEEF40", VA = "0x180FEFB40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD966A0", Offset = "0xD95AA0", VA = "0x180D966A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xECC7E0", Offset = "0xECBBE0", VA = "0x180ECC7E0")]
	public static string ToFriendlyString<T>(this IEnumerable<T> enumerable, [Optional] Func<T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xECC330", Offset = "0xECB730", VA = "0x180ECC330")]
	public static string ToFriendlyString<T>(this IList<T> list, [Optional] Func<int, T, string> elementToString, string sep = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x618530", Offset = "0x617930", VA = "0x180618530")]
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
	[Cpp2IlInjected.Address(RVA = "0x2525300", Offset = "0x2524700", VA = "0x182525300")]
	public static void DrawGizmoArrow(Vector3 start, Vector3 end)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ComponentExt
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD231B0", Offset = "0xD225B0", VA = "0x180D231B0")]
		public static bool TryGetComponent<T>(this Component component, out T result) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2524D20", Offset = "0x2524120", VA = "0x182524D20")]
		public static void SetEnabled(this Component component, bool enabled)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class CoroutineExt
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
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
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x345DF0", Offset = "0x3451F0", VA = "0x180345DF0")]
			[DebuggerHidden]
			public <WaitRoutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2527C00", Offset = "0x2527000", VA = "0x182527C00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2527CB0", Offset = "0x25270B0", VA = "0x182527CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
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
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x345DF0", Offset = "0x3451F0", VA = "0x180345DF0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2527B00", Offset = "0x2526F00", VA = "0x182527B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2527BB0", Offset = "0x2526FB0", VA = "0x182527BB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
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
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x345DF0", Offset = "0x3451F0", VA = "0x180345DF0")]
			[DebuggerHidden]
			public <WaitUntilTrueOrTimeout>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2527D00", Offset = "0x2527100", VA = "0x182527D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2527DC0", Offset = "0x25271C0", VA = "0x182527DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static WaitForEndOfFrame EndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25251A0", Offset = "0x25245A0", VA = "0x1825251A0")]
		[IteratorStateMachine(typeof(<WaitRoutine>d__1))]
		public static IEnumerator WaitRoutine(float waitDuration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2525140", Offset = "0x2524540", VA = "0x182525140")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__2))]
		public static IEnumerator EndOfFrameRoutine(Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2525210", Offset = "0x2524610", VA = "0x182525210")]
		[IteratorStateMachine(typeof(<WaitUntilTrueOrTimeout>d__3))]
		public static IEnumerator WaitUntilTrueOrTimeout(Func<bool> predicate, Action onTrue, Action onTimedOut, float timeoutSeconds)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
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
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x25294F0", Offset = "0x25288F0", VA = "0x1825294F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x25294C0", Offset = "0x25288C0", VA = "0x1825294C0")]
		public WaitForSecondsIgnoreHitches(float seconds)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ListExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBB31B0", Offset = "0xBB25B0", VA = "0x180BB31B0")]
		public static void Shuffle<T>(this IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xBB2DF0", Offset = "0xBB21F0", VA = "0x180BB2DF0")]
		public static void Shuffle<T>(this IList<T> list, int seed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xD24C50", Offset = "0xD24050", VA = "0x180D24C50")]
		public static bool RemoveAllWhere<T>(this IList<T> collection, Predicate<T> match, out List<T> removedElements)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCE5E40", Offset = "0xCE5240", VA = "0x180CE5E40")]
		public static List<T> RemoveAllWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD24A60", Offset = "0xD23E60", VA = "0x180D24A60")]
		public static bool Contains<T>(this IReadOnlyList<T> list, T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x940B60", Offset = "0x93FF60", VA = "0x180940B60")]
		public static T Random<T>(this List<T> list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x93ED30", Offset = "0x93E130", VA = "0x18093ED30")]
		public static void AddUnique<T>(this List<T> list, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x940AA0", Offset = "0x93FEA0", VA = "0x180940AA0")]
		public static T Random<T>(this T[] list)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBB2C30", Offset = "0xBB2030", VA = "0x180BB2C30")]
		public static void RemoveNulls<T>(this List<T> collection) where T : UnityEngine.Object
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x940C50", Offset = "0x940050", VA = "0x180940C50")]
		public static T RemoveWhere<T>(this List<T> collection, Predicate<T> match) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x940BE0", Offset = "0x93FFE0", VA = "0x180940BE0")]
		public static T RemoveAndReturnAtIndex<T>(this List<T> collection, int index) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD246A0", Offset = "0xD23AA0", VA = "0x180D246A0")]
		public static bool AreEqualIgnoreOrder<T>(this List<T> listA, List<T> listB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x940910", Offset = "0x93FD10", VA = "0x180940910")]
		public static T LastItem<T>(this IList<T> list)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class MathExt
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly List<float> INSTANTANEOUS_FLOATS;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly List<float> INSTANTANEOUS_FLOATS2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x25262A0", Offset = "0x25256A0", VA = "0x1825262A0")]
		public static float GetNthHighestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2526440", Offset = "0x2525840", VA = "0x182526440")]
		public static float GetNthLowestValue(this IList<float> values, int n)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x25256E0", Offset = "0x2524AE0", VA = "0x1825256E0")]
		public static void CartesianPointToSphericalRadians(Vector3 cartesionPoint, out float pitchRadians, out float yawRadians, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x25255C0", Offset = "0x25249C0", VA = "0x1825255C0")]
		public static void CartesianPointToSphericalDegrees(Vector3 cartesionPoint, out float pitchDegrees, out float yawDegrees, out float radius)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2526770", Offset = "0x2525B70", VA = "0x182526770")]
		public static Vector3 SphericalPointRadiansToCartesian(float pitchRadians, float yawRadians, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2526600", Offset = "0x2525A00", VA = "0x182526600")]
		public static Vector3 SphericalPointDegreestoCartesian(float pitchDegrees, float yawDegrees, float radius)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x25257C0", Offset = "0x2524BC0", VA = "0x1825257C0")]
		public static Vector3 FindRayPlaneIntersectionPoint(Vector3 rayPoint, Vector3 rayDirection, Vector3 planePoint, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2526530", Offset = "0x2525930", VA = "0x182526530")]
		public static bool NormalizedParallel(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2525950", Offset = "0x2524D50", VA = "0x182525950")]
		public static float GetClosestDistToRay(Ray src, Ray target)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2525DC0", Offset = "0x25251C0", VA = "0x182525DC0")]
		private static float GetNthHighestValue(this IList<float> values, int n, float modifier)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MonoBehaviourExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2526A10", Offset = "0x2525E10", VA = "0x182526A10")]
		public static void SafeStopCoroutine(this MonoBehaviour behaviour, Coroutine routine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2526AA0", Offset = "0x2525EA0", VA = "0x182526AA0")]
		public static void SafeStopSchedule(this MonoBehaviour behaviour, IDisposable schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2526AF0", Offset = "0x2525EF0", VA = "0x182526AF0")]
		public static Coroutine WaitRoutine(this MonoBehaviour behaviour, float duration, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2526910", Offset = "0x2525D10", VA = "0x182526910")]
		public static Coroutine EndOfFrameRoutine(this MonoBehaviour behaviour, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x25269D0", Offset = "0x2525DD0", VA = "0x1825269D0")]
		public static bool IsStaggeredUpdateFrame(this MonoBehaviour behaviour, int frequencyFrames)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class PhysicsExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Collider[] IMMEDIATE_COLLIDER_HITS;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly RaycastHit[] IMMEDIATE_RAYCAST_HITS;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x943430", Offset = "0x942830", VA = "0x180943430")]
		public static T GetClosestSphereCastHit<T>(Vector3 origin, float radius, Vector3 direction, int layerMask, float maxDistance, out Vector3 hitPoint, out Collider collider, Func<Collider, float, T> validateColliderFunc)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class UncompressedQuaternion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Quaternion backingQuaternion;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2527E10", Offset = "0x2527210", VA = "0x182527E10")]
		public UncompressedQuaternion(Quaternion quaternion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2527E40", Offset = "0x2527240", VA = "0x182527E40")]
		public static implicit operator Quaternion(UncompressedQuaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2527E60", Offset = "0x2527260", VA = "0x182527E60")]
		public static implicit operator UncompressedQuaternion(Quaternion q)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RendererExt
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly int COLOR_ID;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly MaterialPropertyBlock IMMEDIATE_MATERIAL_PROPERTY_BLOCK;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2526C50", Offset = "0x2526050", VA = "0x182526C50")]
		public static Mesh GetMesh(this Renderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2526E00", Offset = "0x2526200", VA = "0x182526E00")]
		public static int GetSubmeshCount(this Renderer renderer)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x25274F0", Offset = "0x25268F0", VA = "0x1825274F0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2527320", Offset = "0x2526720", VA = "0x182527320")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2527240", Offset = "0x2526640", VA = "0x182527240")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x25273F0", Offset = "0x25267F0", VA = "0x1825273F0")]
		public static void SetMaterialProperty(this Renderer renderer, int propertyId, Matrix4x4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2526C30", Offset = "0x2526030", VA = "0x182526C30")]
		public static void ClearMaterialProperty(this Renderer renderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2527050", Offset = "0x2526450", VA = "0x182527050")]
		public static void SetColorAlpha(this Renderer renderer, float alpha)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2526EB0", Offset = "0x25262B0", VA = "0x182526EB0")]
		public static void SetColorAlpha(this Renderer renderer, float alpha, int shaderId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class SafeDestroy
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2527640", Offset = "0x2526A40", VA = "0x182527640")]
		public static void Asset(UnityEngine.Object asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x25277C0", Offset = "0x2526BC0", VA = "0x1825277C0")]
		public static void GameObject(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2527700", Offset = "0x2526B00", VA = "0x182527700")]
		public static void Component(Component component)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class StringExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x25278F0", Offset = "0x2526CF0", VA = "0x1825278F0")]
		public static string SplitPascalCaseIntoWords(string pascalCaseString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2527880", Offset = "0x2526C80", VA = "0x182527880")]
		public static string EnsureEndsWith(string str, char character)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class Vector3Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly float SIN_45;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2528160", Offset = "0x2527560", VA = "0x182528160")]
		public static Vector3 Average(this IEnumerable<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2528FB0", Offset = "0x25283B0", VA = "0x182528FB0")]
		public static float SqDistance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2529190", Offset = "0x2528590", VA = "0x182529190")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Vector3 coordinateSpaceRight, Vector3 coordinateSpaceUp, Vector3 coordinateSpaceForward)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2529070", Offset = "0x2528470", VA = "0x182529070")]
		public static Vector3 TransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2528A50", Offset = "0x2527E50", VA = "0x182528A50")]
		public static Vector3 InverseTransformCoordinateSpace(this Vector3 v, Vector3 coordinateSpaceOrigin, Quaternion coordinateSpaceRotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2528C40", Offset = "0x2528040", VA = "0x182528C40")]
		public static bool IsUniform(this Vector3 thisVector, float epsilon = 0.001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2528E00", Offset = "0x2528200", VA = "0x182528E00")]
		public static float MaxComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2528E90", Offset = "0x2528290", VA = "0x182528E90")]
		public static float MinComponent(this Vector3 v)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2527EC0", Offset = "0x25272C0", VA = "0x182527EC0")]
		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2529370", Offset = "0x2528770", VA = "0x182529370")]
		public static Vector3 ValueOrZeroIfBogus(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2528520", Offset = "0x2527920", VA = "0x182528520")]
		public static Vector3 ClampedValueOrZeroIfBogus(this Vector3 vector, float maxMagnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2528DB0", Offset = "0x25281B0", VA = "0x182528DB0")]
		public static bool IsZero(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2528BE0", Offset = "0x2527FE0", VA = "0x182528BE0")]
		public static bool IsNaN(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2528B80", Offset = "0x2527F80", VA = "0x182528B80")]
		public static bool IsInfinity(this Vector3 vector)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2528F20", Offset = "0x2528320", VA = "0x182528F20")]
		public static Vector3 MultiplyComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15A8C10", Offset = "0x15A8010", VA = "0x1815A8C10")]
		public static Vector3 DivideComponents(this Vector3 me, Vector3 other)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2527F80", Offset = "0x2527380", VA = "0x182527F80")]
		public static float AngleSignedVector3(this Vector3 from, Vector3 to, [Optional] Vector3? up)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2529430", Offset = "0x2528830", VA = "0x182529430")]
		public static Vector3 ZeroY(this Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2528690", Offset = "0x2527A90", VA = "0x182528690")]
		public static Vector3 GetClosestAxis(Vector3 dir, Quaternion rot)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Systems.Jobs
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NativeArrayExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xBB5880", Offset = "0xBB4C80", VA = "0x180BB5880")]
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

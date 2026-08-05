using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AggregatePromise<T1, T2> : Promise<Tuple<T1, T2>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x198BD80", Offset = "0x198AF80", VA = "0x18198BD80")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x198BD10", Offset = "0x198AF10", VA = "0x18198BD10")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AggregatePromise<T1, T2, T3> : Promise<Tuple<T1, T2, T3>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x198C020", Offset = "0x198B220", VA = "0x18198C020")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x198BFB0", Offset = "0x198B1B0", VA = "0x18198BFB0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AggregatePromise<T1, T2, T3, T4> : Promise<Tuple<T1, T2, T3, T4>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x198C340", Offset = "0x198B540", VA = "0x18198C340")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x198C2D0", Offset = "0x198B4D0", VA = "0x18198C2D0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AggregatePromise<T1, T2, T3, T4, T5> : Promise<Tuple<T1, T2, T3, T4, T5>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x198C6E0", Offset = "0x198B8E0", VA = "0x18198C6E0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x198C670", Offset = "0x198B870", VA = "0x18198C670")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6> : Promise<Tuple<T1, T2, T3, T4, T5, T6>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x198CAF0", Offset = "0x198BCF0", VA = "0x18198CAF0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x198CA80", Offset = "0x198BC80", VA = "0x18198CA80")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6, T7> : Promise<Tuple<T1, T2, T3, T4, T5, T6, T7>>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x198CF80", Offset = "0x198C180", VA = "0x18198CF80")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6, IPromise<T7> p7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x198CF10", Offset = "0x198C110", VA = "0x18198CF10")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6, T7, T8> : Promise<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x198D490", Offset = "0x198C690", VA = "0x18198D490")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6, IPromise<T7> p7, IPromise<T8> p8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x198D420", Offset = "0x198C620", VA = "0x18198D420")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HomogenousAggregatePromise<T> : Promise<List<T>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int uncompletedPromiseCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private T[] promiseResults;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x198E320", Offset = "0x198D520", VA = "0x18198E320")]
		public HomogenousAggregatePromise(List<IPromise<T>> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x198CF10", Offset = "0x198C110", VA = "0x18198CF10")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private struct Operation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public float? StartTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public float? EndTime;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x30F610", Offset = "0x30E810", VA = "0x18030F610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x30F610", Offset = "0x30E810", VA = "0x18030F610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x30F670", Offset = "0x30E870", VA = "0x18030F670")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2E3CD0", Offset = "0x2E2ED0", VA = "0x1802E3CD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xE6E0F0", Offset = "0xE6D2F0", VA = "0x180E6E0F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xE6E2A0", Offset = "0xE6D4A0", VA = "0x180E6E2A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class <PromiseCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Promise promise;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x30F610", Offset = "0x30E810", VA = "0x18030F610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x30F610", Offset = "0x30E810", VA = "0x18030F610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x30F670", Offset = "0x30E870", VA = "0x18030F670")]
			[DebuggerHidden]
			public <PromiseCoroutine>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2E3CD0", Offset = "0x2E2ED0", VA = "0x1802E3CD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xE6E050", Offset = "0xE6D250", VA = "0x180E6E050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D2A0", VA = "0x180E6E0A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<Operation> operations;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3EBAD0", Offset = "0x3EACD0", VA = "0x1803EBAD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x428940", Offset = "0x427B40", VA = "0x180428940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE6A3F0", Offset = "0xE695F0", VA = "0x180E6A3F0")]
		public static AsyncBatch Create(Transform parent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE6A4F0", Offset = "0xE696F0", VA = "0x180E6A4F0")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE6A320", Offset = "0xE69520", VA = "0x180E6A320")]
		public void Add(string name, IPromise promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE6A1C0", Offset = "0xE693C0", VA = "0x180E6A1C0")]
		public void Add(string name, IEnumerator coroutine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xE6A480", Offset = "0xE69680", VA = "0x180E6A480")]
		[IteratorStateMachine(typeof(<PromiseCoroutine>d__10))]
		private IEnumerator PromiseCoroutine(Promise promise, IEnumerator coroutine)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE6A550", Offset = "0xE69750", VA = "0x180E6A550")]
		public AsyncBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface ICancelablePromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICancelablePromise Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ICancelablePromise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICancelablePromise<T> Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class CancelablePromise : Promise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool _isCanceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x389170", Offset = "0x388370", VA = "0x180389170", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xE6B330", Offset = "0xE6A530", VA = "0x180E6B330", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE6AF90", Offset = "0xE6A190", VA = "0x180E6AF90", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE6B1F0", Offset = "0xE6A3F0", VA = "0x180E6B1F0", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE6B270", Offset = "0xE6A470", VA = "0x180E6B270", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE6B2C0", Offset = "0xE6A4C0", VA = "0x180E6B2C0")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CancelablePromise<T> : Promise<T>, ICancelablePromise<T>, IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool _isCanceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2F4150", Offset = "0x2F3350", VA = "0x1802F4150", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x198E100", Offset = "0x198D300", VA = "0x18198E100", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x198DC20", Offset = "0x198CE20", VA = "0x18198DC20", Slot = "28")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x198DF60", Offset = "0x198D160", VA = "0x18198DF60", Slot = "29")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x198E010", Offset = "0x198D210", VA = "0x18198E010", Slot = "25")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x198E080", Offset = "0x198D280", VA = "0x18198E080")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class CancelableCombinedPromise : CombinePromise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool _isCanceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2F4150", Offset = "0x2F3350", VA = "0x1802F4150", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE6AF70", Offset = "0xE6A170", VA = "0x180E6AF70", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE6AA70", Offset = "0xE69C70", VA = "0x180E6AA70")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE6ADE0", Offset = "0xE69FE0", VA = "0x180E6ADE0")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1, ICancelablePromise promise2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE6AB80", Offset = "0xE69D80", VA = "0x180E6AB80")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xE6A5B0", Offset = "0xE697B0", VA = "0x180E6A5B0", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE6A9A0", Offset = "0xE69BA0", VA = "0x180E6A9A0", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xE6AA20", Offset = "0xE69C20", VA = "0x180E6AA20", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CombinePromise : Promise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int countdownLatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected IList<IPromise> promises;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE6B360", Offset = "0xE6A560", VA = "0x180E6B360")]
		public CombinePromise(IPromise promise, IPromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xE6B7E0", Offset = "0xE6A9E0", VA = "0x180E6B7E0")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xE6B470", Offset = "0xE6A670", VA = "0x180E6B470")]
		public CombinePromise(IList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xE6B350", Offset = "0xE6A550", VA = "0x180E6B350")]
		private void Decrement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CompletedPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE6D350", Offset = "0xE6C550", VA = "0x180E6D350")]
		public CompletedPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CompletedPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x198E2C0", Offset = "0x198D4C0", VA = "0x18198E2C0")]
		public CompletedPromise(T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ErroredPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xE6D370", Offset = "0xE6C570", VA = "0x180E6D370")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ErroredPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x198E260", Offset = "0x198D460", VA = "0x18198E260")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface IPromise : IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPromise ContinueWith(Func<IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IPromise TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IPromise<T> : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise ContinueWith(Func<T, IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		new IPromise<T> TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xE6D520", Offset = "0xE6C720", VA = "0x180E6D520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xE6D3A0", Offset = "0xE6C5A0", VA = "0x180E6D3A0")]
		private static string FormatMessage(Exception innerException)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xE6D430", Offset = "0xE6C630", VA = "0x180E6D430")]
		public PromiseException(Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class Promise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<Action> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool _isCompleted;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x430C60", Offset = "0x42FE60", VA = "0x180430C60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE6D330", Offset = "0xE6C530", VA = "0x180E6D330", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xE6D310", Offset = "0xE6C510", VA = "0x180E6D310", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xE6E000", Offset = "0xE6D200", VA = "0x180E6E000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x38B3C0", Offset = "0x38A5C0", VA = "0x18038B3C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE6D8E0", Offset = "0xE6CAE0", VA = "0x180E6D8E0", Slot = "5")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE6DD40", Offset = "0xE6CF40", VA = "0x180E6DD40", Slot = "6")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE6DDC0", Offset = "0xE6CFC0", VA = "0x180E6DDC0", Slot = "4")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x17632D0", Offset = "0x17624D0", VA = "0x1817632D0", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE6D7E0", Offset = "0xE6C9E0", VA = "0x180E6D7E0", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1763420", Offset = "0x1762620", VA = "0x181763420", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xE6DE50", Offset = "0xE6D050", VA = "0x180E6DE50", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE6D5C0", Offset = "0xE6C7C0", VA = "0x180E6D5C0")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE6D970", Offset = "0xE6CB70", VA = "0x180E6D970")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE6DBE0", Offset = "0xE6CDE0", VA = "0x180E6DBE0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE6D550", Offset = "0xE6C750", VA = "0x180E6D550", Slot = "17")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE6C360", Offset = "0xE6B560", VA = "0x180E6C360", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CD0", Offset = "0x2E2ED0", VA = "0x1802E3CD0", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE6DF50", Offset = "0xE6D150", VA = "0x180E6DF50")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class Promise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<Action> _thenNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<Action<T>> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private T result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool _isCompleted;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4310A0", Offset = "0x4302A0", VA = "0x1804310A0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x16B5610", Offset = "0x16B4810", VA = "0x1816B5610", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x16B5510", Offset = "0x16B4710", VA = "0x1816B5510", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x38B3C0", Offset = "0x38A5C0", VA = "0x18038B3C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x16B0A60", Offset = "0x16AFC60", VA = "0x1816B0A60", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1AE20E0", Offset = "0x1AE12E0", VA = "0x181AE20E0", Slot = "7")]
		public IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3EF0", Offset = "0x1AE30F0", VA = "0x181AE3EF0", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1AE3CB0", Offset = "0x1AE2EB0", VA = "0x181AE3CB0", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x17606C0", Offset = "0x175F8C0", VA = "0x1817606C0", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD0E0", Offset = "0x1ADC2E0", VA = "0x181ADD0E0", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x175F520", Offset = "0x175E720", VA = "0x18175F520", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD250", Offset = "0x1ADC450", VA = "0x181ADD250", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1762A30", Offset = "0x1761C30", VA = "0x181762A30", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1760DF0", Offset = "0x175FFF0", VA = "0x181760DF0", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1AE2A60", Offset = "0x1AE1C60", VA = "0x181AE2A60", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1AE4540", Offset = "0x1AE3740", VA = "0x181AE4540", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x16AB570", Offset = "0x16AA770", VA = "0x1816AB570")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1350", Offset = "0x1AE0550", VA = "0x181AE1350")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x16B0B80", Offset = "0x16AFD80", VA = "0x1816B0B80")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1AD62C0", Offset = "0x1AD54C0", VA = "0x181AD62C0", Slot = "25")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x918070", Offset = "0x917270", VA = "0x180918070", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CD0", Offset = "0x2E2ED0", VA = "0x1802E3CD0", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x16B2AD0", Offset = "0x16B1CD0", VA = "0x1816B2AD0", Slot = "12")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2810", Offset = "0x9A1A10", VA = "0x1809A2810", Slot = "13")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x16B2AA0", Offset = "0x16B1CA0", VA = "0x1816B2AA0", Slot = "14")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1AE5B00", Offset = "0x1AE4D00", VA = "0x181AE5B00")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class CombinedPromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly List<Action> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool _isCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int countdownLatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<string> innerErrors;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x430C60", Offset = "0x42FE60", VA = "0x180430C60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xE6D330", Offset = "0xE6C530", VA = "0x180E6D330", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xE6D310", Offset = "0xE6C510", VA = "0x180E6D310", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE6D2C0", Offset = "0xE6C4C0", VA = "0x180E6D2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x38B3C0", Offset = "0x38A5C0", VA = "0x18038B3C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE6C790", Offset = "0xE6B990", VA = "0x180E6C790")]
		private CombinedPromise()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xE6CC50", Offset = "0xE6BE50", VA = "0x180E6CC50")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xE6C500", Offset = "0xE6B700", VA = "0x180E6C500")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB, IPromise promiseC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xE6CE50", Offset = "0xE6C050", VA = "0x180E6CE50")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB, IPromise promiseC, params IPromise[] promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE6C860", Offset = "0xE6BA60", VA = "0x180E6C860")]
		public CombinedPromise(IList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE6C300", Offset = "0xE6B500", VA = "0x180E6C300")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE6BD00", Offset = "0xE6AF00", VA = "0x180E6BD00")]
		private void Countdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xE6B9E0", Offset = "0xE6ABE0", VA = "0x180E6B9E0")]
		private void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xE6BEB0", Offset = "0xE6B0B0", VA = "0x180E6BEB0")]
		private IPromise Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE6BE20", Offset = "0xE6B020", VA = "0x180E6BE20", Slot = "5")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE6C280", Offset = "0xE6B480", VA = "0x180E6C280", Slot = "6")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xE6C370", Offset = "0xE6B570", VA = "0x180E6C370", Slot = "4")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1759FD0", Offset = "0x17591D0", VA = "0x181759FD0", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xE6BC00", Offset = "0xE6AE00", VA = "0x180E6BC00", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x175A120", Offset = "0x1759320", VA = "0x18175A120", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xE6C400", Offset = "0xE6B600", VA = "0x180E6C400", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xE6C120", Offset = "0xE6B320", VA = "0x180E6C120")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE6B970", Offset = "0xE6AB70", VA = "0x180E6B970")]
		protected void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xE6C360", Offset = "0xE6B560", VA = "0x180E6C360", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2E3CD0", Offset = "0x2E2ED0", VA = "0x1802E3CD0", Slot = "16")]
		void IEnumerator.Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PromiseCache<TKey>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private class CacheEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public TKey Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public DateTime ExpiresAt;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x73A150", Offset = "0x739350", VA = "0x18073A150")]
			public CacheEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<TKey, CacheEntry> cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LinkedList<CacheEntry> expirationList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private LinkedList<CacheEntry> leastRecentlyUsedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int cacheSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool cacheErrors;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x198F700", Offset = "0x198E900", VA = "0x18198F700")]
		public PromiseCache([Optional] int? cacheSize, bool cacheErrors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x198F0A0", Offset = "0x198E2A0", VA = "0x18198F0A0")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x175DD50", Offset = "0x175CF50", VA = "0x18175DD50")]
		public IPromise<TValue> GetPromise<TValue>(TKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x135B9D0", Offset = "0x135ABD0", VA = "0x18135B9D0")]
		public void SetValue<TValue>(TKey key, TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x135B920", Offset = "0x135AB20", VA = "0x18135B920")]
		public void SetValue<TValue>(TKey key, TValue value, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x135B540", Offset = "0x135A740", VA = "0x18135B540")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x135B5F0", Offset = "0x135A7F0", VA = "0x18135B5F0")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x175DA50", Offset = "0x175CC50", VA = "0x18175DA50")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x175DB00", Offset = "0x175CD00", VA = "0x18175DB00")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback, TimeSpan maxCacheAge)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x198F690", Offset = "0x198E890", VA = "0x18198F690")]
		public void Remove(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x198F020", Offset = "0x198E220", VA = "0x18198F020")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x198EE30", Offset = "0x198E030", VA = "0x18198EE30")]
		private void AddToHeadOfLRUList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x198E6E0", Offset = "0x198D8E0", VA = "0x18198E6E0")]
		private void AddToExpirationList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x198F4D0", Offset = "0x198E6D0", VA = "0x18198F4D0")]
		private void RemoveExpiredEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x198F1F0", Offset = "0x198E3F0", VA = "0x18198F1F0")]
		private void RemoveCacheEntry(CacheEntry cacheEntry)
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

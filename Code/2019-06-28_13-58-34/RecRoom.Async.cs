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
		[Cpp2IlInjected.Address(RVA = "0x14EB9B0", Offset = "0x14EABB0", VA = "0x1814EB9B0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x14EB940", Offset = "0x14EAB40", VA = "0x1814EB940")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AggregatePromise<T1, T2, T3> : Promise<Tuple<T1, T2, T3>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x14EBC50", Offset = "0x14EAE50", VA = "0x1814EBC50")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14EBBE0", Offset = "0x14EADE0", VA = "0x1814EBBE0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AggregatePromise<T1, T2, T3, T4> : Promise<Tuple<T1, T2, T3, T4>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14EBF70", Offset = "0x14EB170", VA = "0x1814EBF70")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x14EBF00", Offset = "0x14EB100", VA = "0x1814EBF00")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AggregatePromise<T1, T2, T3, T4, T5> : Promise<Tuple<T1, T2, T3, T4, T5>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x14EC310", Offset = "0x14EB510", VA = "0x1814EC310")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x14EC2A0", Offset = "0x14EB4A0", VA = "0x1814EC2A0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6> : Promise<Tuple<T1, T2, T3, T4, T5, T6>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14EC720", Offset = "0x14EB920", VA = "0x1814EC720")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14EC6B0", Offset = "0x14EB8B0", VA = "0x1814EC6B0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6, T7> : Promise<Tuple<T1, T2, T3, T4, T5, T6, T7>>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x14ECBB0", Offset = "0x14EBDB0", VA = "0x1814ECBB0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6, IPromise<T7> p7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14ECB40", Offset = "0x14EBD40", VA = "0x1814ECB40")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AggregatePromise<T1, T2, T3, T4, T5, T6, T7, T8> : Promise<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14ED0C0", Offset = "0x14EC2C0", VA = "0x1814ED0C0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2, IPromise<T3> p3, IPromise<T4> p4, IPromise<T5> p5, IPromise<T6> p6, IPromise<T7> p7, IPromise<T8> p8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x14ED050", Offset = "0x14EC250", VA = "0x1814ED050")]
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
		[Cpp2IlInjected.Address(RVA = "0x14EDF50", Offset = "0x14ED150", VA = "0x1814EDF50")]
		public HomogenousAggregatePromise(List<IPromise<T>> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x14ECB40", Offset = "0x14EBD40", VA = "0x1814ECB40")]
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
				[Cpp2IlInjected.Address(RVA = "0x2FA800", Offset = "0x2F9A00", VA = "0x1802FA800", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x2FA800", Offset = "0x2F9A00", VA = "0x1802FA800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2FA860", Offset = "0x2F9A60", VA = "0x1802FA860")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2EE340", Offset = "0x2ED540", VA = "0x1802EE340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E86C70", Offset = "0x1E85E70", VA = "0x181E86C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E86E20", Offset = "0x1E86020", VA = "0x181E86E20", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x2FA800", Offset = "0x2F9A00", VA = "0x1802FA800", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x2FA800", Offset = "0x2F9A00", VA = "0x1802FA800", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2FA860", Offset = "0x2F9A60", VA = "0x1802FA860")]
			[DebuggerHidden]
			public <PromiseCoroutine>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2EE340", Offset = "0x2ED540", VA = "0x1802EE340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E86BD0", Offset = "0x1E85DD0", VA = "0x181E86BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x1E86C20", Offset = "0x1E85E20", VA = "0x181E86C20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x380040", Offset = "0x37F240", VA = "0x180380040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x380050", Offset = "0x37F250", VA = "0x180380050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E82F70", Offset = "0x1E82170", VA = "0x181E82F70")]
		public static AsyncBatch Create(Transform parent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E83070", Offset = "0x1E82270", VA = "0x181E83070")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1E82EA0", Offset = "0x1E820A0", VA = "0x181E82EA0")]
		public void Add(string name, IPromise promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E82D40", Offset = "0x1E81F40", VA = "0x181E82D40")]
		public void Add(string name, IEnumerator coroutine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E83000", Offset = "0x1E82200", VA = "0x181E83000")]
		[IteratorStateMachine(typeof(<PromiseCoroutine>d__10))]
		private IEnumerator PromiseCoroutine(Promise promise, IEnumerator coroutine)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E830D0", Offset = "0x1E822D0", VA = "0x181E830D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37FB70", Offset = "0x37ED70", VA = "0x18037FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E83EB0", Offset = "0x1E830B0", VA = "0x181E83EB0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1E83B10", Offset = "0x1E82D10", VA = "0x181E83B10", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E83D70", Offset = "0x1E82F70", VA = "0x181E83D70", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E83DF0", Offset = "0x1E82FF0", VA = "0x181E83DF0", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E83E40", Offset = "0x1E83040", VA = "0x181E83E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x329020", Offset = "0x328220", VA = "0x180329020", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x14EDD30", Offset = "0x14ECF30", VA = "0x1814EDD30", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x14ED850", Offset = "0x14ECA50", VA = "0x1814ED850", Slot = "28")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x14EDB90", Offset = "0x14ECD90", VA = "0x1814EDB90", Slot = "29")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x14EDC40", Offset = "0x14ECE40", VA = "0x1814EDC40", Slot = "25")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14EDCB0", Offset = "0x14ECEB0", VA = "0x1814EDCB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x329020", Offset = "0x328220", VA = "0x180329020", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E83AF0", Offset = "0x1E82CF0", VA = "0x181E83AF0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1E835F0", Offset = "0x1E827F0", VA = "0x181E835F0")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E83960", Offset = "0x1E82B60", VA = "0x181E83960")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1, ICancelablePromise promise2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E83700", Offset = "0x1E82900", VA = "0x181E83700")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E83130", Offset = "0x1E82330", VA = "0x181E83130", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E83520", Offset = "0x1E82720", VA = "0x181E83520", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E835A0", Offset = "0x1E827A0", VA = "0x181E835A0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E83EE0", Offset = "0x1E830E0", VA = "0x181E83EE0")]
		public CombinePromise(IPromise promise, IPromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E84360", Offset = "0x1E83560", VA = "0x181E84360")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E83FF0", Offset = "0x1E831F0", VA = "0x181E83FF0")]
		public CombinePromise(IList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1E83ED0", Offset = "0x1E830D0", VA = "0x181E83ED0")]
		private void Decrement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CompletedPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1E85ED0", Offset = "0x1E850D0", VA = "0x181E85ED0")]
		public CompletedPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CompletedPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x14EDEF0", Offset = "0x14ED0F0", VA = "0x1814EDEF0")]
		public CompletedPromise(T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ErroredPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E85EF0", Offset = "0x1E850F0", VA = "0x181E85EF0")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ErroredPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14EDE90", Offset = "0x14ED090", VA = "0x1814EDE90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1E860A0", Offset = "0x1E852A0", VA = "0x181E860A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1E85F20", Offset = "0x1E85120", VA = "0x181E85F20")]
		private static string FormatMessage(Exception innerException)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E85FB0", Offset = "0x1E851B0", VA = "0x181E85FB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F97E0", Offset = "0x3F89E0", VA = "0x1803F97E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1E85EB0", Offset = "0x1E850B0", VA = "0x181E85EB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1E85E90", Offset = "0x1E85090", VA = "0x181E85E90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1E86B80", Offset = "0x1E85D80", VA = "0x181E86B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x33CF50", Offset = "0x33C150", VA = "0x18033CF50", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1E86460", Offset = "0x1E85660", VA = "0x181E86460", Slot = "5")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1E868C0", Offset = "0x1E85AC0", VA = "0x181E868C0", Slot = "6")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1E86940", Offset = "0x1E85B40", VA = "0x181E86940", Slot = "4")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC4D970", Offset = "0xC4CB70", VA = "0x180C4D970", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E86360", Offset = "0x1E85560", VA = "0x181E86360", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xC4DAC0", Offset = "0xC4CCC0", VA = "0x180C4DAC0", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E869D0", Offset = "0x1E85BD0", VA = "0x181E869D0", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E86140", Offset = "0x1E85340", VA = "0x181E86140")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E864F0", Offset = "0x1E856F0", VA = "0x181E864F0")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1E86760", Offset = "0x1E85960", VA = "0x181E86760")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E860D0", Offset = "0x1E852D0", VA = "0x181E860D0", Slot = "17")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E84EE0", Offset = "0x1E840E0", VA = "0x181E84EE0", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2EE340", Offset = "0x2ED540", VA = "0x1802EE340", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E86AD0", Offset = "0x1E85CD0", VA = "0x181E86AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x45FA80", Offset = "0x45EC80", VA = "0x18045FA80", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB5F960", Offset = "0xB5EB60", VA = "0x180B5F960", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB5F860", Offset = "0xB5EA60", VA = "0x180B5F860", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x33CF50", Offset = "0x33C150", VA = "0x18033CF50", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB5AD60", Offset = "0xB59F60", VA = "0x180B5AD60", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x17F32C0", Offset = "0x17F24C0", VA = "0x1817F32C0", Slot = "7")]
		public IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x17F50D0", Offset = "0x17F42D0", VA = "0x1817F50D0", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x17F4E90", Offset = "0x17F4090", VA = "0x1817F4E90", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xC4AD60", Offset = "0xC49F60", VA = "0x180C4AD60", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x17EE2C0", Offset = "0x17ED4C0", VA = "0x1817EE2C0", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xC49BC0", Offset = "0xC48DC0", VA = "0x180C49BC0", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x17EE430", Offset = "0x17ED630", VA = "0x1817EE430", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xC4D0D0", Offset = "0xC4C2D0", VA = "0x180C4D0D0", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xC4B490", Offset = "0xC4A690", VA = "0x180C4B490", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x17F3C40", Offset = "0x17F2E40", VA = "0x1817F3C40", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x17F5720", Offset = "0x17F4920", VA = "0x1817F5720", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB55870", Offset = "0xB54A70", VA = "0x180B55870")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x17F2530", Offset = "0x17F1730", VA = "0x1817F2530")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB5AE80", Offset = "0xB5A080", VA = "0x180B5AE80")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x17E74A0", Offset = "0x17E66A0", VA = "0x1817E74A0", Slot = "25")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB5DA50", Offset = "0xB5CC50", VA = "0x180B5DA50", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2EE340", Offset = "0x2ED540", VA = "0x1802EE340", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB5CE00", Offset = "0xB5C000", VA = "0x180B5CE00", Slot = "12")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB5CDA0", Offset = "0xB5BFA0", VA = "0x180B5CDA0", Slot = "13")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB5CDD0", Offset = "0xB5BFD0", VA = "0x180B5CDD0", Slot = "14")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x17F6CE0", Offset = "0x17F5EE0", VA = "0x1817F6CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F97E0", Offset = "0x3F89E0", VA = "0x1803F97E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1E85EB0", Offset = "0x1E850B0", VA = "0x181E85EB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1E85E90", Offset = "0x1E85090", VA = "0x181E85E90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1E85E40", Offset = "0x1E85040", VA = "0x181E85E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x33CF50", Offset = "0x33C150", VA = "0x18033CF50", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E85310", Offset = "0x1E84510", VA = "0x181E85310")]
		private CombinedPromise()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E857D0", Offset = "0x1E849D0", VA = "0x181E857D0")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E85080", Offset = "0x1E84280", VA = "0x181E85080")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB, IPromise promiseC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E859D0", Offset = "0x1E84BD0", VA = "0x181E859D0")]
		public CombinedPromise(IPromise promiseA, IPromise promiseB, IPromise promiseC, params IPromise[] promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E853E0", Offset = "0x1E845E0", VA = "0x181E853E0")]
		public CombinedPromise(IList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1E84E80", Offset = "0x1E84080", VA = "0x181E84E80")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1E84880", Offset = "0x1E83A80", VA = "0x181E84880")]
		private void Countdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1E84560", Offset = "0x1E83760", VA = "0x181E84560")]
		private void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E84A30", Offset = "0x1E83C30", VA = "0x181E84A30")]
		private IPromise Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E849A0", Offset = "0x1E83BA0", VA = "0x181E849A0", Slot = "5")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1E84E00", Offset = "0x1E84000", VA = "0x181E84E00", Slot = "6")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E84EF0", Offset = "0x1E840F0", VA = "0x181E84EF0", Slot = "4")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xC44670", Offset = "0xC43870", VA = "0x180C44670", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1E84780", Offset = "0x1E83980", VA = "0x181E84780", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xC447C0", Offset = "0xC439C0", VA = "0x180C447C0", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E84F80", Offset = "0x1E84180", VA = "0x181E84F80", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E84CA0", Offset = "0x1E83EA0", VA = "0x181E84CA0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E844F0", Offset = "0x1E836F0", VA = "0x181E844F0")]
		protected void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E84EE0", Offset = "0x1E840E0", VA = "0x181E84EE0", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2EE340", Offset = "0x2ED540", VA = "0x1802EE340", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xB55350", Offset = "0xB54550", VA = "0x180B55350")]
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
		[Cpp2IlInjected.Address(RVA = "0x14EF330", Offset = "0x14EE530", VA = "0x1814EF330")]
		public PromiseCache([Optional] int? cacheSize, bool cacheErrors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x14EECD0", Offset = "0x14EDED0", VA = "0x1814EECD0")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xC483F0", Offset = "0xC475F0", VA = "0x180C483F0")]
		public IPromise<TValue> GetPromise<TValue>(TKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79AF60", Offset = "0x79A160", VA = "0x18079AF60")]
		public void SetValue<TValue>(TKey key, TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x79AEB0", Offset = "0x79A0B0", VA = "0x18079AEB0")]
		public void SetValue<TValue>(TKey key, TValue value, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79AAD0", Offset = "0x799CD0", VA = "0x18079AAD0")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79AB80", Offset = "0x799D80", VA = "0x18079AB80")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xC480F0", Offset = "0xC472F0", VA = "0x180C480F0")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xC481A0", Offset = "0xC473A0", VA = "0x180C481A0")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback, TimeSpan maxCacheAge)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x14EF2C0", Offset = "0x14EE4C0", VA = "0x1814EF2C0")]
		public void Remove(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x14EEC50", Offset = "0x14EDE50", VA = "0x1814EEC50")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x14EEA60", Offset = "0x14EDC60", VA = "0x1814EEA60")]
		private void AddToHeadOfLRUList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x14EE310", Offset = "0x14ED510", VA = "0x1814EE310")]
		private void AddToExpirationList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x14EF100", Offset = "0x14EE300", VA = "0x1814EF100")]
		private void RemoveExpiredEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x14EEE20", Offset = "0x14EE020", VA = "0x1814EEE20")]
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

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
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct Operation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float? StartTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public float? EndTime;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31ED10", VA = "0x180320310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31ED10", VA = "0x180320310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x304660", Offset = "0x303060", VA = "0x180304660")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301AD0", VA = "0x1803030D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x20D77B0", Offset = "0x20D61B0", VA = "0x1820D77B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x20D7960", Offset = "0x20D6360", VA = "0x1820D7960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class <PromiseCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public Promise promise;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31ED10", VA = "0x180320310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x320310", Offset = "0x31ED10", VA = "0x180320310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x304660", Offset = "0x303060", VA = "0x180304660")]
			[DebuggerHidden]
			public <PromiseCoroutine>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x3030D0", Offset = "0x301AD0", VA = "0x1803030D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x20D7710", Offset = "0x20D6110", VA = "0x1820D7710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x20D7760", Offset = "0x20D6160", VA = "0x1820D7760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<Operation> operations;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x32A4C0", Offset = "0x328EC0", VA = "0x18032A4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x32A610", Offset = "0x329010", VA = "0x18032A610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x20D7070", Offset = "0x20D5A70", VA = "0x1820D7070")]
		public static AsyncBatch Create(Transform parent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20D7170", Offset = "0x20D5B70", VA = "0x1820D7170")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20D6FA0", Offset = "0x20D59A0", VA = "0x1820D6FA0")]
		public void Add(string name, IPromise promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20D6E40", Offset = "0x20D5840", VA = "0x1820D6E40")]
		public void Add(string name, IEnumerator coroutine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20D7100", Offset = "0x20D5B00", VA = "0x1820D7100")]
		[IteratorStateMachine(typeof(<PromiseCoroutine>d__10))]
		private IEnumerator PromiseCoroutine(Promise promise, IEnumerator coroutine)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20D71D0", Offset = "0x20D5BD0", VA = "0x1820D71D0")]
		public AsyncBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class GroupedPromise : Promise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected List<string> errors;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20D76B0", Offset = "0x20D60B0", VA = "0x1820D76B0")]
		public GroupedPromise(params IPromise[] promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20D7320", Offset = "0x20D5D20", VA = "0x1820D7320")]
		public GroupedPromise(IReadOnlyCollection<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x20D7230", Offset = "0x20D5C30", VA = "0x1820D7230")]
		private void Reject(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20D7290", Offset = "0x20D5C90", VA = "0x1820D7290")]
		private void Resolve()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IPersistentPromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		new IPersistentPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPersistentPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPersistentPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPersistentPromise SubscribeChange(Action changeFunc);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPersistentPromise UnsubscribeChange(Action changeFunc);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPersistentPromise SubscribeThen(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPersistentPromise UnsubscribeThen(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPersistentPromise SubscribeError(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPersistentPromise UnsubscribeError(Action<string> errorFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IPersistentPromise<T> : IPersistentPromise, IPromise, IEnumerator, IPromise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string Failure
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		new IPersistentPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPersistentPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPersistentPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPersistentPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPersistentPromise<T> SubscribeChange(Action<T, T> changeFunc);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPersistentPromise<T> UnsubscribeChange(Action<T, T> changeFunc);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPersistentPromise<T> SubscribeThen(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPersistentPromise<T> UnsubscribeThen(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		new IPersistentPromise<T> SubscribeError(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		new IPersistentPromise<T> UnsubscribeError(Action<string> errorFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PersistentPromise<T> : IPersistentPromise<T>, IPersistentPromise, IPromise, IEnumerator, IPromise<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<Action> thenCallbacksNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly List<Action<T>> thenCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Action<string>> errorCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly List<Action> finallyCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Action changeSubscriptionsNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Action<T, T> changeSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Action thenSubscriptionsNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Action<T> thenSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Action<string> errorSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private T result;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3187B0", Offset = "0x3171B0", VA = "0x1803187B0", Slot = "14")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1692520", Offset = "0x1690F20", VA = "0x181692520", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Failure
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x318780", Offset = "0x317180", VA = "0x180318780", Slot = "16")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x17FBD10", Offset = "0x17FA710", VA = "0x1817FBD10", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3079C0", Offset = "0x3063C0", VA = "0x1803079C0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x307A00", Offset = "0x306400", VA = "0x180307A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x198FA80", Offset = "0x198E480", VA = "0x18198FA80", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x198FA40", Offset = "0x198E440", VA = "0x18198FA40", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public object Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x32ED30", Offset = "0x32D730", VA = "0x18032ED30", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x198C1F0", Offset = "0x198ABF0", VA = "0x18198C1F0", Slot = "48")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x198DD50", Offset = "0x198C750", VA = "0x18198DD50")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x198C8E0", Offset = "0x198B2E0", VA = "0x18198C8E0")]
		public IPersistentPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x198D5B0", Offset = "0x198BFB0", VA = "0x18198D5B0")]
		public IPersistentPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x198E8F0", Offset = "0x198D2F0", VA = "0x18198E8F0")]
		public IPersistentPromise<T> SubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x198E7E0", Offset = "0x198D1E0", VA = "0x18198E7E0", Slot = "8")]
		public IPersistentPromise<T> SubscribeChange(Action<T, T> changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x198E380", Offset = "0x198CD80", VA = "0x18198E380", Slot = "21")]
		IPersistentPromise IPersistentPromise.SubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x198F4C0", Offset = "0x198DEC0", VA = "0x18198F4C0")]
		public IPersistentPromise<T> UnsubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x198F3B0", Offset = "0x198DDB0", VA = "0x18198F3B0", Slot = "9")]
		public IPersistentPromise<T> UnsubscribeChange(Action<T, T> changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x198E410", Offset = "0x198CE10", VA = "0x18198E410", Slot = "22")]
		IPersistentPromise IPersistentPromise.UnsubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x198ED10", Offset = "0x198D710", VA = "0x18198ED10")]
		public IPersistentPromise<T> SubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x198EC20", Offset = "0x198D620", VA = "0x18198EC20", Slot = "10")]
		public IPersistentPromise<T> SubscribeThen(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x198E3E0", Offset = "0x198CDE0", VA = "0x18198E3E0", Slot = "23")]
		IPersistentPromise IPersistentPromise.SubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x198F790", Offset = "0x198E190", VA = "0x18198F790")]
		public IPersistentPromise<T> UnsubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x198F700", Offset = "0x198E100", VA = "0x18198F700", Slot = "11")]
		public IPersistentPromise<T> UnsubscribeThen(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x198E470", Offset = "0x198CE70", VA = "0x18198E470", Slot = "24")]
		IPersistentPromise IPersistentPromise.UnsubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x198E980", Offset = "0x198D380", VA = "0x18198E980", Slot = "12")]
		public IPersistentPromise<T> SubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x198E3B0", Offset = "0x198CDB0", VA = "0x18198E3B0", Slot = "25")]
		IPersistentPromise IPersistentPromise.SubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x198F550", Offset = "0x198DF50", VA = "0x18198F550", Slot = "13")]
		public IPersistentPromise<T> UnsubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x198E440", Offset = "0x198CE40", VA = "0x18198E440", Slot = "26")]
		IPersistentPromise IPersistentPromise.UnsubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE8ADA0", Offset = "0xE897A0", VA = "0x180E8ADA0", Slot = "44")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x198D190", Offset = "0x198BB90", VA = "0x18198D190", Slot = "45")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE8AF50", Offset = "0xE89950", VA = "0x180E8AF50", Slot = "33")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x198D010", Offset = "0x198BA10", VA = "0x18198D010", Slot = "34")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x198E290", Offset = "0x198CC90", VA = "0x18198E290", Slot = "37")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x198E7A0", Offset = "0x198D1A0", VA = "0x18198E7A0", Slot = "39")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE8B8B0", Offset = "0xE8A2B0", VA = "0x180E8B8B0", Slot = "46")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE8C0F0", Offset = "0xE8AAF0", VA = "0x180E8C0F0", Slot = "35")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x198EFF0", Offset = "0x198D9F0", VA = "0x18198EFF0", Slot = "47")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x198E4A0", Offset = "0x198CEA0", VA = "0x18198E4A0", Slot = "36")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x198EF40", Offset = "0x198D940", VA = "0x18198EF40")]
		public IPersistentPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x198EEA0", Offset = "0x198D8A0", VA = "0x18198EEA0")]
		public IPersistentPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x198E320", Offset = "0x198CD20", VA = "0x18198E320", Slot = "30")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x198E320", Offset = "0x198CD20", VA = "0x18198E320", Slot = "41")]
		private IPromise<T> RecRoom.Async.IPromise<T>.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x198E350", Offset = "0x198CD50", VA = "0x18198E350", Slot = "40")]
		private IPromise<T> RecRoom.Async.IPromise<T>.Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x198E320", Offset = "0x198CD20", VA = "0x18198E320", Slot = "18")]
		IPersistentPromise IPersistentPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x198E320", Offset = "0x198CD20", VA = "0x18198E320", Slot = "5")]
		private IPersistentPromise<T> RecRoom.Async.IPersistentPromise<T>.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x198E350", Offset = "0x198CD50", VA = "0x18198E350", Slot = "4")]
		private IPersistentPromise<T> RecRoom.Async.IPersistentPromise<T>.Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x198DC90", Offset = "0x198C690", VA = "0x18198DC90")]
		public IPersistentPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x198E2C0", Offset = "0x198CCC0", VA = "0x18198E2C0", Slot = "31")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x198E2C0", Offset = "0x198CCC0", VA = "0x18198E2C0", Slot = "42")]
		IPromise<T> IPromise<T>.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x198E2F0", Offset = "0x198CCF0", VA = "0x18198E2F0", Slot = "43")]
		IPromise<T> IPromise<T>.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x198E2C0", Offset = "0x198CCC0", VA = "0x18198E2C0", Slot = "19")]
		IPersistentPromise IPersistentPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x198E2C0", Offset = "0x198CCC0", VA = "0x18198E2C0", Slot = "6")]
		IPersistentPromise<T> IPersistentPromise<T>.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x198E130", Offset = "0x198CB30", VA = "0x18198E130")]
		public IPersistentPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x198E2F0", Offset = "0x198CCF0", VA = "0x18198E2F0", Slot = "32")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x198E2F0", Offset = "0x198CCF0", VA = "0x18198E2F0", Slot = "20")]
		IPersistentPromise IPersistentPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x198E2F0", Offset = "0x198CCF0", VA = "0x18198E2F0", Slot = "7")]
		IPersistentPromise<T> IPersistentPromise<T>.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x198F820", Offset = "0x198E220", VA = "0x18198F820")]
		public PersistentPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PromiseCache<TKey>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class CacheEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public TKey Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public DateTime ExpiresAt;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xE111E0", Offset = "0xE0FBE0", VA = "0x180E111E0")]
			public CacheEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Dictionary<TKey, CacheEntry> cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LinkedList<CacheEntry> expirationList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LinkedList<CacheEntry> leastRecentlyUsedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int cacheSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool cacheErrors;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x19C09B0", Offset = "0x19BF3B0", VA = "0x1819C09B0")]
		public PromiseCache([Optional] int? cacheSize, bool cacheErrors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x19C0320", Offset = "0x19BED20", VA = "0x1819C0320")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE8C920", Offset = "0xE8B320", VA = "0x180E8C920")]
		public IPromise<TValue> GetPromise<TValue>(TKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1153370", Offset = "0x1151D70", VA = "0x181153370")]
		public void SetValue<TValue>(TKey key, TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x11532C0", Offset = "0x1151CC0", VA = "0x1811532C0")]
		public void SetValue<TValue>(TKey key, TValue value, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1152BB0", Offset = "0x11515B0", VA = "0x181152BB0")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1152C60", Offset = "0x1151660", VA = "0x181152C60")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE8C510", Offset = "0xE8AF10", VA = "0x180E8C510")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE8C270", Offset = "0xE8AC70", VA = "0x180E8C270")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback, TimeSpan maxCacheAge)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x19C0930", Offset = "0x19BF330", VA = "0x1819C0930")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x19C02A0", Offset = "0x19BECA0", VA = "0x1819C02A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x19C00B0", Offset = "0x19BEAB0", VA = "0x1819C00B0")]
		private void AddToHeadOfLRUList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x19BF960", Offset = "0x19BE360", VA = "0x1819BF960")]
		private void AddToExpirationList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x19C0770", Offset = "0x19BF170", VA = "0x1819C0770")]
		private void RemoveExpiredEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x19C0350", Offset = "0x19BED50", VA = "0x1819C0350")]
		private bool RemoveCacheEntry(CacheEntry cacheEntry)
		{
			return default(bool);
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

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
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct Operation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public float? StartTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float? EndTime;
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x3018F0", Offset = "0x3000F0", VA = "0x1803018F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x3018F0", Offset = "0x3000F0", VA = "0x1803018F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x336430", Offset = "0x334C30", VA = "0x180336430")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x302320", Offset = "0x300B20", VA = "0x180302320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x20E3C50", Offset = "0x20E2450", VA = "0x1820E3C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x20E3E00", Offset = "0x20E2600", VA = "0x1820E3E00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class <PromiseCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public Promise promise;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x3018F0", Offset = "0x3000F0", VA = "0x1803018F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x3018F0", Offset = "0x3000F0", VA = "0x1803018F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x336430", Offset = "0x334C30", VA = "0x180336430")]
			[DebuggerHidden]
			public <PromiseCoroutine>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x302320", Offset = "0x300B20", VA = "0x180302320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x20E3BB0", Offset = "0x20E23B0", VA = "0x1820E3BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x20E3C00", Offset = "0x20E2400", VA = "0x1820E3C00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x346440", Offset = "0x344C40", VA = "0x180346440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x346450", Offset = "0x344C50", VA = "0x180346450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x20E39F0", Offset = "0x20E21F0", VA = "0x1820E39F0")]
		public static AsyncBatch Create(Transform parent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20E3AF0", Offset = "0x20E22F0", VA = "0x1820E3AF0")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20E3920", Offset = "0x20E2120", VA = "0x1820E3920")]
		public void Add(string name, IPromise promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20E37C0", Offset = "0x20E1FC0", VA = "0x1820E37C0")]
		public void Add(string name, IEnumerator coroutine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20E3A80", Offset = "0x20E2280", VA = "0x1820E3A80")]
		[IteratorStateMachine(typeof(<PromiseCoroutine>d__10))]
		private IEnumerator PromiseCoroutine(Promise promise, IEnumerator coroutine)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20E3B50", Offset = "0x20E2350", VA = "0x1820E3B50")]
		public AsyncBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IPersistentPromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		new IPersistentPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPersistentPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPersistentPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPersistentPromise SubscribeChange(Action changeFunc);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPersistentPromise UnsubscribeChange(Action changeFunc);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPersistentPromise SubscribeThen(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPersistentPromise UnsubscribeThen(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPersistentPromise SubscribeError(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPersistentPromise UnsubscribeError(Action<string> errorFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IPersistentPromise<T> : IPersistentPromise, IPromise, IEnumerator, IPromise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		string Failure
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		new IPersistentPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPersistentPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPersistentPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPersistentPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPersistentPromise<T> SubscribeChange(Action<T, T> changeFunc);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPersistentPromise<T> UnsubscribeChange(Action<T, T> changeFunc);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPersistentPromise<T> SubscribeThen(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPersistentPromise<T> UnsubscribeThen(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		new IPersistentPromise<T> SubscribeError(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		new IPersistentPromise<T> UnsubscribeError(Action<string> errorFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PersistentPromise<T> : IPersistentPromise<T>, IPersistentPromise, IPromise, IEnumerator, IPromise<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly List<Action> thenCallbacksNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<Action<T>> thenCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<Action<string>> errorCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly List<Action> finallyCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Action changeSubscriptionsNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Action<T, T> changeSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Action thenSubscriptionsNoArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Action<T> thenSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Action<string> errorSubscriptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private T result;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x349DD0", Offset = "0x3485D0", VA = "0x180349DD0", Slot = "14")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x14F6CC0", Offset = "0x14F54C0", VA = "0x1814F6CC0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Failure
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x30AB10", Offset = "0x309310", VA = "0x18030AB10", Slot = "16")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1669640", Offset = "0x1667E40", VA = "0x181669640", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x60F130", Offset = "0x60D930", VA = "0x18060F130", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x60F190", Offset = "0x60D990", VA = "0x18060F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x177B4F0", Offset = "0x1779CF0", VA = "0x18177B4F0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x177B4B0", Offset = "0x1779CB0", VA = "0x18177B4B0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public object Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3F3890", Offset = "0x3F2090", VA = "0x1803F3890", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1777C60", Offset = "0x1776460", VA = "0x181777C60", Slot = "48")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x17797C0", Offset = "0x1777FC0", VA = "0x1817797C0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1778350", Offset = "0x1776B50", VA = "0x181778350")]
		public IPersistentPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1779020", Offset = "0x1777820", VA = "0x181779020")]
		public IPersistentPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x177A360", Offset = "0x1778B60", VA = "0x18177A360")]
		public IPersistentPromise<T> SubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x177A250", Offset = "0x1778A50", VA = "0x18177A250", Slot = "8")]
		public IPersistentPromise<T> SubscribeChange(Action<T, T> changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1779DF0", Offset = "0x17785F0", VA = "0x181779DF0", Slot = "21")]
		IPersistentPromise IPersistentPromise.SubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x177AF30", Offset = "0x1779730", VA = "0x18177AF30")]
		public IPersistentPromise<T> UnsubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x177AE20", Offset = "0x1779620", VA = "0x18177AE20", Slot = "9")]
		public IPersistentPromise<T> UnsubscribeChange(Action<T, T> changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1779E80", Offset = "0x1778680", VA = "0x181779E80", Slot = "22")]
		IPersistentPromise IPersistentPromise.UnsubscribeChange(Action changeFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x177A780", Offset = "0x1778F80", VA = "0x18177A780")]
		public IPersistentPromise<T> SubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x177A690", Offset = "0x1778E90", VA = "0x18177A690", Slot = "10")]
		public IPersistentPromise<T> SubscribeThen(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1779E50", Offset = "0x1778650", VA = "0x181779E50", Slot = "23")]
		IPersistentPromise IPersistentPromise.SubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x177B200", Offset = "0x1779A00", VA = "0x18177B200")]
		public IPersistentPromise<T> UnsubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x177B170", Offset = "0x1779970", VA = "0x18177B170", Slot = "11")]
		public IPersistentPromise<T> UnsubscribeThen(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1779EE0", Offset = "0x17786E0", VA = "0x181779EE0", Slot = "24")]
		IPersistentPromise IPersistentPromise.UnsubscribeThen(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x177A3F0", Offset = "0x1778BF0", VA = "0x18177A3F0", Slot = "12")]
		public IPersistentPromise<T> SubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1779E20", Offset = "0x1778620", VA = "0x181779E20", Slot = "25")]
		IPersistentPromise IPersistentPromise.SubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x177AFC0", Offset = "0x17797C0", VA = "0x18177AFC0", Slot = "13")]
		public IPersistentPromise<T> UnsubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1779EB0", Offset = "0x17786B0", VA = "0x181779EB0", Slot = "26")]
		IPersistentPromise IPersistentPromise.UnsubscribeError(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC4DFF0", Offset = "0xC4C7F0", VA = "0x180C4DFF0", Slot = "44")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1778C00", Offset = "0x1777400", VA = "0x181778C00", Slot = "45")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC4E1A0", Offset = "0xC4C9A0", VA = "0x180C4E1A0", Slot = "33")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1778A80", Offset = "0x1777280", VA = "0x181778A80", Slot = "34")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1779D00", Offset = "0x1778500", VA = "0x181779D00", Slot = "37")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x177A210", Offset = "0x1778A10", VA = "0x18177A210", Slot = "39")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC4EB00", Offset = "0xC4D300", VA = "0x180C4EB00", Slot = "46")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xC4F340", Offset = "0xC4DB40", VA = "0x180C4F340", Slot = "35")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x177AA60", Offset = "0x1779260", VA = "0x18177AA60", Slot = "47")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1779F10", Offset = "0x1778710", VA = "0x181779F10", Slot = "36")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x177A9B0", Offset = "0x17791B0", VA = "0x18177A9B0")]
		public IPersistentPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x177A910", Offset = "0x1779110", VA = "0x18177A910")]
		public IPersistentPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1779D90", Offset = "0x1778590", VA = "0x181779D90", Slot = "30")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1779D90", Offset = "0x1778590", VA = "0x181779D90", Slot = "41")]
		private IPromise<T> RecRoom.Async.IPromise<T>.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1779DC0", Offset = "0x17785C0", VA = "0x181779DC0", Slot = "40")]
		private IPromise<T> RecRoom.Async.IPromise<T>.Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1779D90", Offset = "0x1778590", VA = "0x181779D90", Slot = "18")]
		IPersistentPromise IPersistentPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1779D90", Offset = "0x1778590", VA = "0x181779D90", Slot = "5")]
		private IPersistentPromise<T> RecRoom.Async.IPersistentPromise<T>.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1779DC0", Offset = "0x17785C0", VA = "0x181779DC0", Slot = "4")]
		private IPersistentPromise<T> RecRoom.Async.IPersistentPromise<T>.Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1779700", Offset = "0x1777F00", VA = "0x181779700")]
		public IPersistentPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1779D30", Offset = "0x1778530", VA = "0x181779D30", Slot = "31")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1779D30", Offset = "0x1778530", VA = "0x181779D30", Slot = "42")]
		IPromise<T> IPromise<T>.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1779D60", Offset = "0x1778560", VA = "0x181779D60", Slot = "43")]
		IPromise<T> IPromise<T>.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1779D30", Offset = "0x1778530", VA = "0x181779D30", Slot = "19")]
		IPersistentPromise IPersistentPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1779D30", Offset = "0x1778530", VA = "0x181779D30", Slot = "6")]
		IPersistentPromise<T> IPersistentPromise<T>.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1779BA0", Offset = "0x17783A0", VA = "0x181779BA0")]
		public IPersistentPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1779D60", Offset = "0x1778560", VA = "0x181779D60", Slot = "32")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1779D60", Offset = "0x1778560", VA = "0x181779D60", Slot = "20")]
		IPersistentPromise IPersistentPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1779D60", Offset = "0x1778560", VA = "0x181779D60", Slot = "7")]
		IPersistentPromise<T> IPersistentPromise<T>.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x177B290", Offset = "0x1779A90", VA = "0x18177B290")]
		public PersistentPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PromiseCache<TKey>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private class CacheEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public TKey Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public DateTime ExpiresAt;

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xBE2450", Offset = "0xBE0C50", VA = "0x180BE2450")]
			public CacheEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Dictionary<TKey, CacheEntry> cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private LinkedList<CacheEntry> expirationList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LinkedList<CacheEntry> leastRecentlyUsedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int cacheSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool cacheErrors;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x18A47D0", Offset = "0x18A2FD0", VA = "0x1818A47D0")]
		public PromiseCache([Optional] int? cacheSize, bool cacheErrors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x18A4140", Offset = "0x18A2940", VA = "0x1818A4140")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xC4FB70", Offset = "0xC4E370", VA = "0x180C4FB70")]
		public IPromise<TValue> GetPromise<TValue>(TKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xF33E10", Offset = "0xF32610", VA = "0x180F33E10")]
		public void SetValue<TValue>(TKey key, TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF33D60", Offset = "0xF32560", VA = "0x180F33D60")]
		public void SetValue<TValue>(TKey key, TValue value, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xF33650", Offset = "0xF31E50", VA = "0x180F33650")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF33700", Offset = "0xF31F00", VA = "0x180F33700")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xC4F760", Offset = "0xC4DF60", VA = "0x180C4F760")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC4F4C0", Offset = "0xC4DCC0", VA = "0x180C4F4C0")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback, TimeSpan maxCacheAge)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x18A4750", Offset = "0x18A2F50", VA = "0x1818A4750")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x18A40C0", Offset = "0x18A28C0", VA = "0x1818A40C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x18A3ED0", Offset = "0x18A26D0", VA = "0x1818A3ED0")]
		private void AddToHeadOfLRUList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x18A3780", Offset = "0x18A1F80", VA = "0x1818A3780")]
		private void AddToExpirationList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x18A4590", Offset = "0x18A2D90", VA = "0x1818A4590")]
		private void RemoveExpiredEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x18A4170", Offset = "0x18A2970", VA = "0x1818A4170")]
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

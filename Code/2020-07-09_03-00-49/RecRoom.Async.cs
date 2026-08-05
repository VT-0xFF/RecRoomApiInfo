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
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct Operation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float? StartTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public float? EndTime;
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class <Start>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x456540", Offset = "0x454B40", VA = "0x180456540")]
			[DebuggerHidden]
			public <Start>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1EB7520", Offset = "0x1EB5B20", VA = "0x181EB7520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1EB76D0", Offset = "0x1EB5CD0", VA = "0x181EB76D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class <PromiseCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Promise promise;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x3DD2A0", Offset = "0x3DB8A0", VA = "0x1803DD2A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x456540", Offset = "0x454B40", VA = "0x180456540")]
			[DebuggerHidden]
			public <PromiseCoroutine>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3EC410", Offset = "0x3EAA10", VA = "0x1803EC410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1EB7480", Offset = "0x1EB5A80", VA = "0x181EB7480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1EB74D0", Offset = "0x1EB5AD0", VA = "0x181EB74D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C9CE0", Offset = "0x6C82E0", VA = "0x1806C9CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x83C7A0", Offset = "0x83ADA0", VA = "0x18083C7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1EB72C0", Offset = "0x1EB58C0", VA = "0x181EB72C0")]
		public static AsyncBatch Create(Transform parent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1EB73C0", Offset = "0x1EB59C0", VA = "0x181EB73C0")]
		[IteratorStateMachine(typeof(<Start>d__7))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1EB71F0", Offset = "0x1EB57F0", VA = "0x181EB71F0")]
		public void Add(string name, IPromise promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7090", Offset = "0x1EB5690", VA = "0x181EB7090")]
		public void Add(string name, IEnumerator coroutine)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7350", Offset = "0x1EB5950", VA = "0x181EB7350")]
		[IteratorStateMachine(typeof(<PromiseCoroutine>d__10))]
		private IEnumerator PromiseCoroutine(Promise promise, IEnumerator coroutine)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1EB7420", Offset = "0x1EB5A20", VA = "0x181EB7420")]
		public AsyncBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class PromiseCache<TKey>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class CacheEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TKey Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IPromise Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public DateTime ExpiresAt;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x744FD0", Offset = "0x7435D0", VA = "0x180744FD0")]
			public CacheEntry()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Dictionary<TKey, CacheEntry> cache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LinkedList<CacheEntry> expirationList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LinkedList<CacheEntry> leastRecentlyUsedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int cacheSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool cacheErrors;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1306A10", Offset = "0x1305010", VA = "0x181306A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2DDBC00", Offset = "0x2DDA200", VA = "0x182DDBC00")]
		public PromiseCache([Optional] int? cacheSize, bool cacheErrors = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B03B10", Offset = "0x2B02110", VA = "0x182B03B10")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2C29000", Offset = "0x2C27600", VA = "0x182C29000")]
		public IPromise<TValue> GetPromise<TValue>(TKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x298A380", Offset = "0x2988980", VA = "0x18298A380")]
		public void SetValue<TValue>(TKey key, TValue value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x298A2C0", Offset = "0x29888C0", VA = "0x18298A2C0")]
		public void SetValue<TValue>(TKey key, TValue value, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2989880", Offset = "0x2987E80", VA = "0x182989880")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2989C60", Offset = "0x2988260", VA = "0x182989C60")]
		public void SetPromise<TValue>(TKey key, IPromise<TValue> promise, TimeSpan maxCacheAge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C28850", Offset = "0x2C26E50", VA = "0x182C28850")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2C285B0", Offset = "0x2C26BB0", VA = "0x182C285B0")]
		public IPromise<TValue> GetOrCreatePromise<TValue>(TKey key, Func<IPromise<TValue>> createPromiseCallback, TimeSpan maxCacheAge)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB9A0", Offset = "0x2DD9FA0", VA = "0x182DDB9A0")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB040", Offset = "0x2DD9640", VA = "0x182DDB040")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAC60", Offset = "0x2DD9260", VA = "0x182DDAC60")]
		private void AddToHeadOfLRUList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA260", Offset = "0x2DD8860", VA = "0x182DDA260")]
		private void AddToExpirationList(CacheEntry cacheEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB7E0", Offset = "0x2DD9DE0", VA = "0x182DDB7E0")]
		private void RemoveExpiredEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB200", Offset = "0x2DD9800", VA = "0x182DDB200")]
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

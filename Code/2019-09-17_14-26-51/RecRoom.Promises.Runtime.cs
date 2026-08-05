using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface ICancelablePromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICancelablePromise Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ICancelablePromise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ICancelablePromise<T> Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CancelablePromise : Promise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x49AE80", Offset = "0x49A280", VA = "0x18049AE80", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7781F0", Offset = "0x7775F0", VA = "0x1807781F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2553EC0", Offset = "0x25532C0", VA = "0x182553EC0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2553B20", Offset = "0x2552F20", VA = "0x182553B20", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2553D80", Offset = "0x2553180", VA = "0x182553D80", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2553E00", Offset = "0x2553200", VA = "0x182553E00", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2553E50", Offset = "0x2553250", VA = "0x182553E50")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CancelablePromise<T> : Promise<T>, ICancelablePromise<T>, IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x3B0C10", Offset = "0x3B0010", VA = "0x1803B0C10", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA63540", Offset = "0xA62940", VA = "0x180A63540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6890", Offset = "0x1AE5C90", VA = "0x181AE6890", Slot = "26")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6C10", Offset = "0x1AE6010", VA = "0x181AE6C10", Slot = "27")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6CC0", Offset = "0x1AE60C0", VA = "0x181AE6CC0", Slot = "25")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6D30", Offset = "0x1AE6130", VA = "0x181AE6D30")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CancelableCombinedPromise : CombinePromise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x379330", Offset = "0x378730", VA = "0x180379330", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x395260", Offset = "0x394660", VA = "0x180395260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2553B00", Offset = "0x2552F00", VA = "0x182553B00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x25539F0", Offset = "0x2552DF0", VA = "0x1825539F0")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2553790", Offset = "0x2552B90", VA = "0x182553790")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x25532A0", Offset = "0x25526A0", VA = "0x1825532A0", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x25536C0", Offset = "0x2552AC0", VA = "0x1825536C0", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2553740", Offset = "0x2552B40", VA = "0x182553740", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CombinePromise : Promise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int countdownLatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly IReadOnlyList<IPromise> promises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<string> innerErrors;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2554060", Offset = "0x2553460", VA = "0x182554060")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2, IPromise promise3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2554240", Offset = "0x2553640", VA = "0x182554240")]
		public CombinePromise(IReadOnlyList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2554000", Offset = "0x2553400", VA = "0x182554000")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2553EE0", Offset = "0x25532E0", VA = "0x182553EE0")]
		private void Countdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CompletedPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x25545C0", Offset = "0x25539C0", VA = "0x1825545C0")]
		public CompletedPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CompletedPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6E10", Offset = "0x1AE6210", VA = "0x181AE6E10")]
		public CompletedPromise(T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ErroredPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x25545E0", Offset = "0x25539E0", VA = "0x1825545E0")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ErroredPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1AE6DB0", Offset = "0x1AE61B0", VA = "0x181AE6DB0")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IPromise : IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPromise ContinueWith(Func<IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IPromise TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IPromise<T> : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise ContinueWith(Func<T, IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "7")]
		new IPromise<T> TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class Promise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<Action> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private string error;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2555280", Offset = "0x2554680", VA = "0x182555280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x52A950", Offset = "0x529D50", VA = "0x18052A950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x52DD90", Offset = "0x52D190", VA = "0x18052DD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x25552F0", Offset = "0x25546F0", VA = "0x1825552F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x25552D0", Offset = "0x25546D0", VA = "0x1825552D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3AD040", Offset = "0x3AC440", VA = "0x1803AD040", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2554DC0", Offset = "0x25541C0", VA = "0x182554DC0", Slot = "8")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2554FB0", Offset = "0x25543B0", VA = "0x182554FB0", Slot = "9")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2555040", Offset = "0x2554440", VA = "0x182555040", Slot = "7")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD14F30", Offset = "0xD14330", VA = "0x180D14F30", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2554A50", Offset = "0x2553E50", VA = "0x182554A50", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD151D0", Offset = "0xD145D0", VA = "0x180D151D0", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x25550D0", Offset = "0x25544D0", VA = "0x1825550D0", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2555030", Offset = "0x2554430", VA = "0x182555030", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2554830", Offset = "0x2553C30", VA = "0x182554830")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2554B50", Offset = "0x2553F50", VA = "0x182554B50")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2554E50", Offset = "0x2554250", VA = "0x182554E50")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x25547C0", Offset = "0x2553BC0", VA = "0x1825547C0", Slot = "17")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x25551D0", Offset = "0x25545D0", VA = "0x1825551D0")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class Promise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct CallbackEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly Action<T> action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly Action noArgsAction;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1B2E10", Offset = "0x1B2210", VA = "0x1801B2E10")]
			public CallbackEntry(Action<T> action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1B2E80", Offset = "0x1B2280", VA = "0x1801B2E80")]
			public CallbackEntry(Action noArgsAction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2874F0", Offset = "0x2868F0", VA = "0x1802874F0")]
			public void Invoke(T payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<CallbackEntry> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private T result;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B30", Offset = "0x6F4F30", VA = "0x1806F5B30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7781F0", Offset = "0x7775F0", VA = "0x1807781F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCDF230", Offset = "0xCDE630", VA = "0x180CDF230", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCDF1F0", Offset = "0xCDE5F0", VA = "0x180CDF1F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3AD040", Offset = "0x3AC440", VA = "0x1803AD040", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3D0", Offset = "0xCDA7D0", VA = "0x180CDB3D0", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1BC7420", Offset = "0x1BC6820", VA = "0x181BC7420", Slot = "7")]
		public IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1BC9250", Offset = "0x1BC8650", VA = "0x181BC9250", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1BC93E0", Offset = "0x1BC87E0", VA = "0x181BC93E0", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD0E9F0", Offset = "0xD0DDF0", VA = "0x180D0E9F0", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1BBF8D0", Offset = "0x1BBECD0", VA = "0x181BBF8D0", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD11850", Offset = "0xD10C50", VA = "0x180D11850", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1BC0CD0", Offset = "0x1BC00D0", VA = "0x181BC0CD0", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD12C50", Offset = "0xD12050", VA = "0x180D12C50", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD13690", Offset = "0xD12A90", VA = "0x180D13690", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1BC7ED0", Offset = "0x1BC72D0", VA = "0x181BC7ED0", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1BCAB40", Offset = "0x1BC9F40", VA = "0x181BCAB40", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCDD620", Offset = "0xCDCA20", VA = "0x180CDD620", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xCDC9F0", Offset = "0xCDBDF0", VA = "0x180CDC9F0", Slot = "15")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xCDC990", Offset = "0xCDBD90", VA = "0x180CDC990", Slot = "16")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCDC9C0", Offset = "0xCDBDC0", VA = "0x180CDC9C0", Slot = "17")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD61D0", VA = "0x180CD6DD0")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1BC5E90", Offset = "0x1BC5290", VA = "0x181BC5E90")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xCD9250", Offset = "0xCD8650", VA = "0x180CD9250")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA7C0", Offset = "0x1BB9BC0", VA = "0x181BBA7C0", Slot = "25")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1BCB380", Offset = "0x1BCA780", VA = "0x181BCB380")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2554790", Offset = "0x2553B90", VA = "0x182554790", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x25546A0", Offset = "0x2553AA0", VA = "0x1825546A0")]
		public PromiseException(Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2554610", Offset = "0x2553A10", VA = "0x182554610")]
		private static string FormatMessage(Exception innerException)
		{
			return null;
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

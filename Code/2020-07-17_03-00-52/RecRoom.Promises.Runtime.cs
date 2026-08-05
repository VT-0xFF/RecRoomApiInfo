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
	public class AggregatePromise<T1, T2> : Promise<Tuple<T1, T2>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x24CDA60", Offset = "0x24CCC60", VA = "0x1824CDA60")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x24CD9F0", Offset = "0x24CCBF0", VA = "0x1824CD9F0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HomogenousAggregatePromise<T> : Promise<List<T>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] promiseResults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int uncompletedPromiseCount;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24CE510", Offset = "0x24CD710", VA = "0x1824CE510")]
		public HomogenousAggregatePromise(List<IPromise<T>> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24CE4A0", Offset = "0x24CD6A0", VA = "0x1824CE4A0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ICancelablePromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICancelablePromise Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface ICancelablePromise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ICancelablePromise<T> Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CancelablePromise : Promise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x40EEC0", Offset = "0x40E0C0", VA = "0x18040EEC0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5223F0", Offset = "0x5215F0", VA = "0x1805223F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2E09640", Offset = "0x2E08840", VA = "0x182E09640", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2E09210", Offset = "0x2E08410", VA = "0x182E09210", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E094A0", Offset = "0x2E086A0", VA = "0x182E094A0", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2E09520", Offset = "0x2E08720", VA = "0x182E09520", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2E09570", Offset = "0x2E08770", VA = "0x182E09570", Slot = "17")]
		public override IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2E095B0", Offset = "0x2E087B0", VA = "0x182E095B0")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CancelablePromise<T> : Promise<T>, ICancelablePromise<T>, IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C7B70", Offset = "0x3C6D70", VA = "0x1803C7B70", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3C7050", Offset = "0x3C6250", VA = "0x1803C7050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24CDEC0", Offset = "0x24CD0C0", VA = "0x1824CDEC0", Slot = "27")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24CE270", Offset = "0x24CD470", VA = "0x1824CE270", Slot = "28")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24CE320", Offset = "0x24CD520", VA = "0x1824CE320", Slot = "26")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x24CE390", Offset = "0x24CD590", VA = "0x1824CE390", Slot = "25")]
		public override IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24CE420", Offset = "0x24CD620", VA = "0x1824CE420")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CancelableCombinedPromise : CombinePromise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x390DA0", Offset = "0x38FFA0", VA = "0x180390DA0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x390DB0", Offset = "0x38FFB0", VA = "0x180390DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2E091F0", Offset = "0x2E083F0", VA = "0x182E091F0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2E090E0", Offset = "0x2E082E0", VA = "0x182E090E0")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E08E80", Offset = "0x2E08080", VA = "0x182E08E80")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2E08920", Offset = "0x2E07B20", VA = "0x182E08920", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2E08D70", Offset = "0x2E07F70", VA = "0x182E08D70", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E08DF0", Offset = "0x2E07FF0", VA = "0x182E08DF0", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2E08E40", Offset = "0x2E08040", VA = "0x182E08E40", Slot = "17")]
		public override IPromise Finally(Action finallyFunc)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CombinePromise : Promise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int countdownLatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly IReadOnlyList<IPromise> promises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly List<string> innerErrors;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2E099C0", Offset = "0x2E08BC0", VA = "0x182E099C0")]
		public CombinePromise(IPromise promise, IPromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2E097E0", Offset = "0x2E089E0", VA = "0x182E097E0")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2, IPromise promise3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2E09AD0", Offset = "0x2E08CD0", VA = "0x182E09AD0")]
		public CombinePromise(IReadOnlyList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2E09780", Offset = "0x2E08980", VA = "0x182E09780")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E09660", Offset = "0x2E08860", VA = "0x182E09660")]
		private void Countdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IPromise : IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPromise ContinueWith(Func<IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IPromise TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IPromise<out T> : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise ContinueWith(Func<T, IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		new IPromise<T> TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class Promise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly List<Action> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private string error;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IPromise CompletedPromise
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AC20", Offset = "0x2E09E20", VA = "0x182E0AC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AC80", Offset = "0x2E09E80", VA = "0x182E0AC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3C5EF0", Offset = "0x3C50F0", VA = "0x1803C5EF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3C5D00", Offset = "0x3C4F00", VA = "0x1803C5D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2E0ACF0", Offset = "0x2E09EF0", VA = "0x182E0ACF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2E0ACD0", Offset = "0x2E09ED0", VA = "0x182E0ACD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x404600", Offset = "0x403800", VA = "0x180404600", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AB00", Offset = "0x2E09D00", VA = "0x182E0AB00")]
		static Promise()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x128EC70", Offset = "0x128DE70", VA = "0x18128EC70")]
		public static IPromise<T> FromResult<T>(T result)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A8F0", Offset = "0x2E09AF0", VA = "0x182E0A8F0")]
		public static IPromise FromError(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x128EC70", Offset = "0x128DE70", VA = "0x18128EC70")]
		public static IPromise<T> FromError<T>(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A660", Offset = "0x2E09860", VA = "0x182E0A660", Slot = "8")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A870", Offset = "0x2E09A70", VA = "0x182E0A870", Slot = "17")]
		public virtual IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A970", Offset = "0x2E09B70", VA = "0x182E0A970", Slot = "7")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x128E490", Offset = "0x128D690", VA = "0x18128E490", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A2C0", Offset = "0x2E094C0", VA = "0x182E0A2C0", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x128F0B0", Offset = "0x128E2B0", VA = "0x18128F0B0", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AA00", Offset = "0x2E09C00", VA = "0x182E0AA00", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A960", Offset = "0x2E09B60", VA = "0x182E0A960", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A070", Offset = "0x2E09270", VA = "0x182E0A070")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A3C0", Offset = "0x2E095C0", VA = "0x182E0A3C0")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A6F0", Offset = "0x2E098F0", VA = "0x182E0A6F0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A000", Offset = "0x2E09200", VA = "0x182E0A000", Slot = "18")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AB70", Offset = "0x2E09D70", VA = "0x182E0AB70")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class Promise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct CallbackEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public readonly Action<T> action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public readonly Action noArgsAction;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x14B1D0", Offset = "0x14A5D0", VA = "0x18014B1D0")]
			public CallbackEntry(Action<T> action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x14B6F0", Offset = "0x14AAF0", VA = "0x18014B6F0")]
			public CallbackEntry(Action noArgsAction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2399B0", Offset = "0x238DB0", VA = "0x1802399B0")]
			public void Invoke(T payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<CallbackEntry> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private T result;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4CF140", Offset = "0x4CE340", VA = "0x1804CF140", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0480", Offset = "0x7AF680", VA = "0x1807B0480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1C25EE0", Offset = "0x1C250E0", VA = "0x181C25EE0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1C25EA0", Offset = "0x1C250A0", VA = "0x181C25EA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x404600", Offset = "0x403800", VA = "0x180404600", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2273330", Offset = "0x2272530", VA = "0x182273330", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1C239A0", Offset = "0x1C22BA0", VA = "0x181C239A0", Slot = "25")]
		public virtual IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22777F0", Offset = "0x22769F0", VA = "0x1822777F0", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2277CB0", Offset = "0x2276EB0", VA = "0x182277CB0", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x1287BA0", VA = "0x1812889A0", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F860", Offset = "0x1C1EA60", VA = "0x181C1F860", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1BE8310", Offset = "0x1BE7510", VA = "0x181BE8310", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1C201C0", Offset = "0x1C1F3C0", VA = "0x181C201C0", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x128D350", Offset = "0x128C550", VA = "0x18128D350", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1213640", Offset = "0x1212840", VA = "0x181213640", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C240A0", Offset = "0x1C232A0", VA = "0x181C240A0", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2279540", Offset = "0x2278740", VA = "0x182279540", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1C24820", Offset = "0x1C23A20", VA = "0x181C24820", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x383410", Offset = "0x382610", VA = "0x180383410", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1C23D70", Offset = "0x1C22F70", VA = "0x181C23D70", Slot = "15")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1C23D10", Offset = "0x1C22F10", VA = "0x181C23D10", Slot = "16")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1C23D40", Offset = "0x1C22F40", VA = "0x181C23D40", Slot = "17")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x226ACF0", Offset = "0x2269EF0", VA = "0x18226ACF0")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C23000", Offset = "0x1C22200", VA = "0x181C23000")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x226F5D0", Offset = "0x226E7D0", VA = "0x18226F5D0")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D8D0", Offset = "0x1C1CAD0", VA = "0x181C1D8D0", Slot = "26")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2279C80", Offset = "0x2278E80", VA = "0x182279C80")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2E09FD0", Offset = "0x2E091D0", VA = "0x182E09FD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E09EE0", Offset = "0x2E090E0", VA = "0x182E09EE0")]
		public PromiseException(Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2E09E50", Offset = "0x2E09050", VA = "0x182E09E50")]
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AggregatePromise<T1, T2> : Promise<Tuple<T1, T2>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x23CC390", Offset = "0x23CB590", VA = "0x1823CC390")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23CC320", Offset = "0x23CB520", VA = "0x1823CC320")]
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
		[Cpp2IlInjected.Address(RVA = "0x23CDC00", Offset = "0x23CCE00", VA = "0x1823CDC00")]
		public HomogenousAggregatePromise(List<IPromise<T>> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x23CDB90", Offset = "0x23CCD90", VA = "0x1823CDB90")]
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
	public interface ICancelablePromise<T> : IPromise<T>, IPromise, IEnumerator, ICancelablePromise
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		new ICancelablePromise<T> Canceled(Action onCanceled);
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
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3CDB70", Offset = "0x3CCD70", VA = "0x1803CDB70", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x70C110", Offset = "0x70B310", VA = "0x18070C110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x31364A0", Offset = "0x31356A0", VA = "0x1831364A0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3136040", Offset = "0x3135240", VA = "0x183136040", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x31362B0", Offset = "0x31354B0", VA = "0x1831362B0", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3136330", Offset = "0x3135530", VA = "0x183136330", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x31363D0", Offset = "0x31355D0", VA = "0x1831363D0", Slot = "17")]
		public override IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3136410", Offset = "0x3135610", VA = "0x183136410")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CancelablePromise<T> : Promise<T>, ICancelablePromise<T>, IPromise<T>, IPromise, IEnumerator, ICancelablePromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3B18B0", Offset = "0x3B0AB0", VA = "0x1803B18B0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3B0430", Offset = "0x3AF630", VA = "0x1803B0430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x23CD760", Offset = "0x23CC960", VA = "0x1823CD760", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x23CD1A0", Offset = "0x23CC3A0", VA = "0x1823CD1A0", Slot = "30")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x23CD530", Offset = "0x23CC730", VA = "0x1823CD530", Slot = "27")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1293DD0", Offset = "0x1292FD0", VA = "0x181293DD0", Slot = "31")]
		ICancelablePromise ICancelablePromise.Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23CD5E0", Offset = "0x23CC7E0", VA = "0x1823CD5E0", Slot = "26")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x23CD650", Offset = "0x23CC850", VA = "0x1823CD650", Slot = "25")]
		public override IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x23CD6E0", Offset = "0x23CC8E0", VA = "0x1823CD6E0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3B1860", Offset = "0x3B0A60", VA = "0x1803B1860", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A44B0", Offset = "0x4A36B0", VA = "0x1804A44B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3136020", Offset = "0x3135220", VA = "0x183136020", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3135F20", Offset = "0x3135120", VA = "0x183135F20")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3135CC0", Offset = "0x3134EC0", VA = "0x183135CC0")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3135750", Offset = "0x3134950", VA = "0x183135750", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3135B60", Offset = "0x3134D60", VA = "0x183135B60", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3135BE0", Offset = "0x3134DE0", VA = "0x183135BE0", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3135C80", Offset = "0x3134E80", VA = "0x183135C80", Slot = "17")]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3136800", Offset = "0x3135A00", VA = "0x183136800")]
		public CombinePromise(IPromise promise, IPromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3136640", Offset = "0x3135840", VA = "0x183136640")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2, IPromise promise3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3136900", Offset = "0x3135B00", VA = "0x183136900")]
		public CombinePromise(IReadOnlyList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x31365E0", Offset = "0x31357E0", VA = "0x1831365E0")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x31364C0", Offset = "0x31356C0", VA = "0x1831364C0")]
		private void Countdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ErroredPromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3136C70", Offset = "0x3135E70", VA = "0x183136C70")]
		public ErroredPromiseException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IPromise : IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPromise ContinueWith(Func<IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IPromise TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IPromise<out T> : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise ContinueWith(Func<T, IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "7")]
		new IPromise<T> TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
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

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IPromise CompletedPromise
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3137A10", Offset = "0x3136C10", VA = "0x183137A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3137A70", Offset = "0x3136C70", VA = "0x183137A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3D14A0", Offset = "0x3D06A0", VA = "0x1803D14A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x40EB70", Offset = "0x40DD70", VA = "0x18040EB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3137AD0", Offset = "0x3136CD0", VA = "0x183137AD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3137AB0", Offset = "0x3136CB0", VA = "0x183137AB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3F1B60", Offset = "0x3F0D60", VA = "0x1803F1B60", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x31378F0", Offset = "0x3136AF0", VA = "0x1831378F0")]
		static Promise()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1C7F360", Offset = "0x1C7E560", VA = "0x181C7F360")]
		public static IPromise<T> FromResult<T>(T result)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x31376F0", Offset = "0x31368F0", VA = "0x1831376F0")]
		public static IPromise FromError(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1C7F360", Offset = "0x1C7E560", VA = "0x181C7F360")]
		public static IPromise<T> FromError<T>(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3137480", Offset = "0x3136680", VA = "0x183137480", Slot = "8")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3137670", Offset = "0x3136870", VA = "0x183137670", Slot = "17")]
		public virtual IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3137760", Offset = "0x3136960", VA = "0x183137760", Slot = "7")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1C7EB80", Offset = "0x1C7DD80", VA = "0x181C7EB80", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3137100", Offset = "0x3136300", VA = "0x183137100", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1C7F790", Offset = "0x1C7E990", VA = "0x181C7F790", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x31377F0", Offset = "0x31369F0", VA = "0x1831377F0", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x214ACD0", Offset = "0x2149ED0", VA = "0x18214ACD0", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3136ED0", Offset = "0x31360D0", VA = "0x183136ED0")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3137200", Offset = "0x3136400", VA = "0x183137200")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3137510", Offset = "0x3136710", VA = "0x183137510")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3136E60", Offset = "0x3136060", VA = "0x183136E60", Slot = "18")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3137960", Offset = "0x3136B60", VA = "0x183137960")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class Promise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct CallbackEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public readonly Action<T> action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public readonly Action noArgsAction;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x168830", Offset = "0x167C30", VA = "0x180168830")]
			public CallbackEntry(Action<T> action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1688C0", Offset = "0x167CC0", VA = "0x1801688C0")]
			public CallbackEntry(Action noArgsAction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x28B440", Offset = "0x28A840", VA = "0x18028B440")]
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

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x440910", Offset = "0x43FB10", VA = "0x180440910", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x440920", Offset = "0x43FB20", VA = "0x180440920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x121CF80", Offset = "0x121C180", VA = "0x18121CF80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x121CF40", Offset = "0x121C140", VA = "0x18121CF40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3F1B60", Offset = "0x3F0D60", VA = "0x1803F1B60", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1219810", Offset = "0x1218A10", VA = "0x181219810", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x257C530", Offset = "0x257B730", VA = "0x18257C530", Slot = "25")]
		public virtual IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x121B670", Offset = "0x121A870", VA = "0x18121B670", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x121BA30", Offset = "0x121AC30", VA = "0x18121BA30", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1C6FC80", Offset = "0x1C6EE80", VA = "0x181C6FC80", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2574210", Offset = "0x2573410", VA = "0x182574210", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1BBD000", Offset = "0x1BBC200", VA = "0x181BBD000", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2574F90", Offset = "0x2574190", VA = "0x182574F90", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C7AC40", Offset = "0x1C79E40", VA = "0x181C7AC40", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1BC00D0", Offset = "0x1BBF2D0", VA = "0x181BC00D0", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x257E320", Offset = "0x257D520", VA = "0x18257E320", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x121C340", Offset = "0x121B540", VA = "0x18121C340", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x121B640", Offset = "0x121A840", VA = "0x18121B640", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x121AB90", Offset = "0x1219D90", VA = "0x18121AB90", Slot = "15")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x121AB30", Offset = "0x1219D30", VA = "0x18121AB30", Slot = "16")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x121AB60", Offset = "0x1219D60", VA = "0x18121AB60", Slot = "17")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2572B00", Offset = "0x2571D00", VA = "0x182572B00")]
		public void Complete(T payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x257B830", Offset = "0x257AA30", VA = "0x18257B830")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x257A340", Offset = "0x2579540", VA = "0x18257A340")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x256FFB0", Offset = "0x256F1B0", VA = "0x18256FFB0", Slot = "26")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x25802A0", Offset = "0x257F4A0", VA = "0x1825802A0")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x13DD1D0", Offset = "0x13DC3D0", VA = "0x1813DD1D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3136D70", Offset = "0x3135F70", VA = "0x183136D70")]
		public PromiseException(Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3136CE0", Offset = "0x3135EE0", VA = "0x183136CE0")]
		private static string FormatMessage(Exception innerException)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class PromiseTaskBridge
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x15B0880", Offset = "0x15AFA80", VA = "0x1815B0880")]
		public static Task<TResult> AsTask<TResult>(this IPromise<TResult> promise)
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

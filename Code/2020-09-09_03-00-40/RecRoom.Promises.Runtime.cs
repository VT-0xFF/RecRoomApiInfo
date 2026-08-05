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
		[Cpp2IlInjected.Address(RVA = "0x2612AC0", Offset = "0x26116C0", VA = "0x182612AC0")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612A50", Offset = "0x2611650", VA = "0x182612A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2614090", Offset = "0x2612C90", VA = "0x182614090")]
		public HomogenousAggregatePromise(List<IPromise<T>> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2614020", Offset = "0x2612C20", VA = "0x182614020")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FCDE0", Offset = "0x3FB9E0", VA = "0x1803FCDE0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3FCDF0", Offset = "0x3FB9F0", VA = "0x1803FCDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xDC4BA0", Offset = "0xDC37A0", VA = "0x180DC4BA0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDC4740", Offset = "0xDC3340", VA = "0x180DC4740", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDC49B0", Offset = "0xDC35B0", VA = "0x180DC49B0", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDC4A30", Offset = "0xDC3630", VA = "0x180DC4A30", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xDC4AD0", Offset = "0xDC36D0", VA = "0x180DC4AD0", Slot = "17")]
		public override IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDC4B10", Offset = "0xDC3710", VA = "0x180DC4B10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CBF40", Offset = "0x3CAB40", VA = "0x1803CBF40", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3CC290", Offset = "0x3CAE90", VA = "0x1803CC290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x26136A0", Offset = "0x26122A0", VA = "0x1826136A0", Slot = "27")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2613A30", Offset = "0x2612630", VA = "0x182613A30", Slot = "28")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2613AE0", Offset = "0x26126E0", VA = "0x182613AE0", Slot = "26")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2613B50", Offset = "0x2612750", VA = "0x182613B50", Slot = "25")]
		public override IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2613BE0", Offset = "0x26127E0", VA = "0x182613BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EFC90", Offset = "0x4EE890", VA = "0x1804EFC90", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4EFD80", Offset = "0x4EE980", VA = "0x1804EFD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xDC4720", Offset = "0xDC3320", VA = "0x180DC4720", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDC4620", Offset = "0xDC3220", VA = "0x180DC4620")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xDC43C0", Offset = "0xDC2FC0", VA = "0x180DC43C0")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDC3E50", Offset = "0xDC2A50", VA = "0x180DC3E50", Slot = "21")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC2E60", VA = "0x180DC4260", Slot = "22")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xDC42E0", Offset = "0xDC2EE0", VA = "0x180DC42E0", Slot = "18")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDC4380", Offset = "0xDC2F80", VA = "0x180DC4380", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC4F00", Offset = "0xDC3B00", VA = "0x180DC4F00")]
		public CombinePromise(IPromise promise, IPromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDC4D40", Offset = "0xDC3940", VA = "0x180DC4D40")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2, IPromise promise3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDC5000", Offset = "0xDC3C00", VA = "0x180DC5000")]
		public CombinePromise(IReadOnlyList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDC4CE0", Offset = "0xDC38E0", VA = "0x180DC4CE0")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xDC4BC0", Offset = "0xDC37C0", VA = "0x180DC4BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDC60B0", Offset = "0xDC4CB0", VA = "0x180DC60B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDC6110", Offset = "0xDC4D10", VA = "0x180DC6110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x481D80", Offset = "0x480980", VA = "0x180481D80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x481DF0", Offset = "0x4809F0", VA = "0x180481DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xDC6170", Offset = "0xDC4D70", VA = "0x180DC6170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xDC6150", Offset = "0xDC4D50", VA = "0x180DC6150", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3D3880", Offset = "0x3D2480", VA = "0x1803D3880", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xDC5F90", Offset = "0xDC4B90", VA = "0x180DC5F90")]
		static Promise()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x214F7C0", Offset = "0x214E3C0", VA = "0x18214F7C0")]
		public static IPromise<T> FromResult<T>(T result)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDC5D80", Offset = "0xDC4980", VA = "0x180DC5D80")]
		public static IPromise FromError(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x214F7C0", Offset = "0x214E3C0", VA = "0x18214F7C0")]
		public static IPromise<T> FromError<T>(string error)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xDC5B10", Offset = "0xDC4710", VA = "0x180DC5B10", Slot = "8")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDC5D00", Offset = "0xDC4900", VA = "0x180DC5D00", Slot = "17")]
		public virtual IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xDC5E00", Offset = "0xDC4A00", VA = "0x180DC5E00", Slot = "7")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x214EFE0", Offset = "0x214DBE0", VA = "0x18214EFE0", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDC5790", Offset = "0xDC4390", VA = "0x180DC5790", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x214FBF0", Offset = "0x214E7F0", VA = "0x18214FBF0", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDC5E90", Offset = "0xDC4A90", VA = "0x180DC5E90", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xDC5DF0", Offset = "0xDC49F0", VA = "0x180DC5DF0", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xDC5560", Offset = "0xDC4160", VA = "0x180DC5560")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xDC5890", Offset = "0xDC4490", VA = "0x180DC5890")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xDC5BA0", Offset = "0xDC47A0", VA = "0x180DC5BA0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDC54F0", Offset = "0xDC40F0", VA = "0x180DC54F0", Slot = "18")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDC6000", Offset = "0xDC4C00", VA = "0x180DC6000")]
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
			[Cpp2IlInjected.Address(RVA = "0xF3D0", Offset = "0xE7D0", VA = "0x18000F3D0")]
			public CallbackEntry(Action<T> action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xF3E0", Offset = "0xE7E0", VA = "0x18000F3E0")]
			public CallbackEntry(Action noArgsAction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x31D720", Offset = "0x31CB20", VA = "0x18031D720")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EFCA0", Offset = "0x4EE8A0", VA = "0x1804EFCA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x4EFDA0", Offset = "0x4EE9A0", VA = "0x1804EFDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x23B23A0", Offset = "0x23B0FA0", VA = "0x1823B23A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x23B2360", Offset = "0x23B0F60", VA = "0x1823B2360", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3D3880", Offset = "0x3D2480", VA = "0x1803D3880", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x277C2E0", Offset = "0x277AEE0", VA = "0x18277C2E0", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x23AF5F0", Offset = "0x23AE1F0", VA = "0x1823AF5F0", Slot = "25")]
		public virtual IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2780180", Offset = "0x277ED80", VA = "0x182780180", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2780630", Offset = "0x277F230", VA = "0x182780630", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x21414D0", Offset = "0x21400D0", VA = "0x1821414D0", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x23AA270", Offset = "0x23A8E70", VA = "0x1823AA270", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x21F1F30", Offset = "0x21F0B30", VA = "0x1821F1F30", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x23AB1F0", Offset = "0x23A9DF0", VA = "0x1823AB1F0", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x214BA80", Offset = "0x214A680", VA = "0x18214BA80", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x21F4C90", Offset = "0x21F3890", VA = "0x1821F4C90", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23AFCF0", Offset = "0x23AE8F0", VA = "0x1823AFCF0", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2781CE0", Offset = "0x27808E0", VA = "0x182781CE0", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x23B0770", Offset = "0x23AF370", VA = "0x1823B0770", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x23AF9C0", Offset = "0x23AE5C0", VA = "0x1823AF9C0", Slot = "15")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x23AF960", Offset = "0x23AE560", VA = "0x1823AF960", Slot = "16")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x23AF990", Offset = "0x23AE590", VA = "0x1823AF990", Slot = "17")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2774A80", Offset = "0x2773680", VA = "0x182774A80")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x23AE980", Offset = "0x23AD580", VA = "0x1823AE980")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2778B90", Offset = "0x2777790", VA = "0x182778B90")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x23A7D60", Offset = "0x23A6960", VA = "0x1823A7D60", Slot = "26")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2782420", Offset = "0x2781020", VA = "0x182782420")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B7DD0", Offset = "0x8B69D0", VA = "0x1808B7DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xDC5400", Offset = "0xDC4000", VA = "0x180DC5400")]
		public PromiseException(Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xDC5370", Offset = "0xDC3F70", VA = "0x180DC5370")]
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

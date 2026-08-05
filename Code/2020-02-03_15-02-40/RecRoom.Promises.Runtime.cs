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
		[Cpp2IlInjected.Address(RVA = "0x1BD5260", Offset = "0x1BD4460", VA = "0x181BD5260")]
		public AggregatePromise(IPromise<T1> p1, IPromise<T2> p2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1BD51F0", Offset = "0x1BD43F0", VA = "0x181BD51F0")]
		private void OnError(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ICancelablePromise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICancelablePromise Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ICancelablePromise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Cancel();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ICancelablePromise<T> Canceled(Action onCanceled);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CancelablePromise : Promise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3767F0", Offset = "0x3759F0", VA = "0x1803767F0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9C9290", Offset = "0x9C8490", VA = "0x1809C9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x260AA00", Offset = "0x2609C00", VA = "0x18260AA00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x260A660", Offset = "0x2609860", VA = "0x18260A660", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x260A8C0", Offset = "0x2609AC0", VA = "0x18260A8C0", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x260A940", Offset = "0x2609B40", VA = "0x18260A940", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x260A990", Offset = "0x2609B90", VA = "0x18260A990")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CancelablePromise<T> : Promise<T>, ICancelablePromise<T>, IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3BC780", Offset = "0x3BB980", VA = "0x1803BC780", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9F19C0", Offset = "0x9F0BC0", VA = "0x1809F19C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5490", Offset = "0x1BD4690", VA = "0x181BD5490", Slot = "26")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5810", Offset = "0x1BD4A10", VA = "0x181BD5810", Slot = "27")]
		public ICancelablePromise<T> Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1BD58C0", Offset = "0x1BD4AC0", VA = "0x181BD58C0", Slot = "25")]
		protected override void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5930", Offset = "0x1BD4B30", VA = "0x181BD5930")]
		public CancelablePromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class CancelableCombinedPromise : CombinePromise, ICancelablePromise, IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Action> onCanceled;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x35D0E0", Offset = "0x35C2E0", VA = "0x18035D0E0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x35D0F0", Offset = "0x35C2F0", VA = "0x18035D0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IsPending
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x260A640", Offset = "0x2609840", VA = "0x18260A640", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x260A530", Offset = "0x2609730", VA = "0x18260A530")]
		public CancelableCombinedPromise(ICancelablePromise promise, ICancelablePromise promise1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x260A2D0", Offset = "0x26094D0", VA = "0x18260A2D0")]
		public CancelableCombinedPromise(IList<ICancelablePromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2609E10", Offset = "0x2609010", VA = "0x182609E10", Slot = "20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x260A200", Offset = "0x2609400", VA = "0x18260A200", Slot = "21")]
		public ICancelablePromise Canceled(Action onCanceledFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x260A280", Offset = "0x2609480", VA = "0x18260A280", Slot = "17")]
		protected override void ClearQueuedActionLists()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CombinePromise : Promise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int countdownLatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly IReadOnlyList<IPromise> promises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<string> innerErrors;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x260ABA0", Offset = "0x2609DA0", VA = "0x18260ABA0")]
		public CombinePromise(IPromise promise, IPromise promise1, IPromise promise2, IPromise promise3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x260AD80", Offset = "0x2609F80", VA = "0x18260AD80")]
		public CombinePromise(IReadOnlyList<IPromise> promises)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x260AB40", Offset = "0x2609D40", VA = "0x18260AB40")]
		private void InnerError(string promiseError)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x260AA20", Offset = "0x2609C20", VA = "0x18260AA20")]
		private void Countdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CompletedPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x260B120", Offset = "0x260A320", VA = "0x18260B120")]
		public CompletedPromise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CompletedPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5B90", Offset = "0x1BD4D90", VA = "0x181BD5B90")]
		public CompletedPromise(T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ErroredPromise : Promise
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x260B140", Offset = "0x260A340", VA = "0x18260B140")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ErroredPromise<T> : Promise<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5B30", Offset = "0x1BD4D30", VA = "0x181BD5B30")]
		public ErroredPromise(string error)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IPromise : IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IPromise Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPromise ContinueWith(Func<IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IPromise TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IPromise<T> : IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IPromise<T> Then(Action<T> thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new IPromise<T> Then(Action thenFunc);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		new IPromise<T> Error(Action<string> errorFunc);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		new IPromise<T> Finally(Action finallyFunc);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IPromise ContinueWith(Func<T, IPromise> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		new IPromise<T> TransformError(Func<string, string> transformFunc);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Promise : IPromise, IEnumerator
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<Action> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private string error;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HasErrorHandler
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x260BDE0", Offset = "0x260AFE0", VA = "0x18260BDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x37A750", Offset = "0x379950", VA = "0x18037A750", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x37DBA0", Offset = "0x37CDA0", VA = "0x18037DBA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x260BE50", Offset = "0x260B050", VA = "0x18260BE50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x260BE30", Offset = "0x260B030", VA = "0x18260BE30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3A76E0", Offset = "0x3A68E0", VA = "0x1803A76E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x260B920", Offset = "0x260AB20", VA = "0x18260B920", Slot = "8")]
		public IPromise Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x260BB10", Offset = "0x260AD10", VA = "0x18260BB10", Slot = "9")]
		public IPromise Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x260BBA0", Offset = "0x260ADA0", VA = "0x18260BBA0", Slot = "7")]
		public IPromise Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xCDAE90", Offset = "0xCDA090", VA = "0x180CDAE90", Slot = "10")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x260B5B0", Offset = "0x260A7B0", VA = "0x18260B5B0", Slot = "11")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xCDB130", Offset = "0xCDA330", VA = "0x180CDB130", Slot = "12")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x260BC30", Offset = "0x260AE30", VA = "0x18260BC30", Slot = "13")]
		public IPromise TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x260BB90", Offset = "0x260AD90", VA = "0x18260BB90", Slot = "14")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x336780", Offset = "0x335980", VA = "0x180336780", Slot = "16")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x260B390", Offset = "0x260A590", VA = "0x18260B390")]
		public void Complete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x260B6B0", Offset = "0x260A8B0", VA = "0x18260B6B0")]
		public void Error(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x260B9B0", Offset = "0x260ABB0", VA = "0x18260B9B0")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x260B320", Offset = "0x260A520", VA = "0x18260B320", Slot = "17")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x260BD30", Offset = "0x260AF30", VA = "0x18260BD30")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class Promise<T> : IPromise<T>, IPromise, IEnumerator
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct CallbackEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly Action<T> action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly Action noArgsAction;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x12D370", Offset = "0x12C770", VA = "0x18012D370")]
			public CallbackEntry(Action<T> action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x12D3E0", Offset = "0x12C7E0", VA = "0x18012D3E0")]
			public CallbackEntry(Action noArgsAction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x20AA70", Offset = "0x209E70", VA = "0x18020AA70")]
			public void Invoke(T payload)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<CallbackEntry> _then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<Action<string>> _error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<Action> _finally;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private string error;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private T result;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5530C0", Offset = "0x5522C0", VA = "0x1805530C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9C9290", Offset = "0x9C8490", VA = "0x1809C9290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HasSucceeded
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCAA210", Offset = "0xCA9410", VA = "0x180CAA210", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HasError
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCAA1D0", Offset = "0xCA93D0", VA = "0x180CAA1D0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3A76E0", Offset = "0x3A68E0", VA = "0x1803A76E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCA64A0", Offset = "0xCA56A0", VA = "0x180CA64A0", Slot = "6")]
		public IPromise<T> Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1CAD710", Offset = "0x1CAC910", VA = "0x181CAD710", Slot = "7")]
		public IPromise<T> Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xCA8720", Offset = "0xCA7920", VA = "0x180CA8720", Slot = "5")]
		public IPromise<T> Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1CAFA50", Offset = "0x1CAEC50", VA = "0x181CAFA50", Slot = "4")]
		public IPromise<T> Then(Action<T> thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCD3F10", Offset = "0xCD3110", VA = "0x180CD3F10", Slot = "18")]
		public IPromise<TNew> ContinueWith<TNew>(Func<IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1CA4450", Offset = "0x1CA3650", VA = "0x181CA4450", Slot = "19")]
		public IPromise ContinueWith(Func<IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7330", Offset = "0xCD6530", VA = "0x180CD7330", Slot = "8")]
		public IPromise<TNew> ContinueWith<TNew>(Func<T, IPromise<TNew>> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1CA5CD0", Offset = "0x1CA4ED0", VA = "0x181CA5CD0", Slot = "9")]
		public IPromise ContinueWith(Func<T, IPromise> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCD88D0", Offset = "0xCD7AD0", VA = "0x180CD88D0", Slot = "20")]
		public IPromise<TNew> Transform<TNew>(Func<TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xCD9310", Offset = "0xCD8510", VA = "0x180CD9310", Slot = "10")]
		public IPromise<TNew> Transform<TNew>(Func<T, TNew> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1CAE3D0", Offset = "0x1CAD5D0", VA = "0x181CAE3D0", Slot = "21")]
		IPromise IPromise.TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1CB1870", Offset = "0x1CB0A70", VA = "0x181CB1870", Slot = "11")]
		public IPromise<T> TransformError(Func<string, string> transformFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xCA86F0", Offset = "0xCA78F0", VA = "0x180CA86F0", Slot = "22")]
		bool IEnumerator.MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x336780", Offset = "0x335980", VA = "0x180336780", Slot = "24")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xCA7AC0", Offset = "0xCA6CC0", VA = "0x180CA7AC0", Slot = "15")]
		IPromise IPromise.Then(Action thenFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xCA7A60", Offset = "0xCA6C60", VA = "0x180CA7A60", Slot = "16")]
		IPromise IPromise.Error(Action<string> errorFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xCA7A90", Offset = "0xCA6C90", VA = "0x180CA7A90", Slot = "17")]
		IPromise IPromise.Finally(Action finallyFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCA1710", Offset = "0xCA0910", VA = "0x180CA1710")]
		public IPromise<T> Complete(T payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1CABF90", Offset = "0x1CAB190", VA = "0x181CABF90")]
		protected Exception ExecuteFinallyFuncs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCA4A60", Offset = "0xCA3C60", VA = "0x180CA4A60")]
		public IPromise<T> Error(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1C9E1D0", Offset = "0x1C9D3D0", VA = "0x181C9E1D0", Slot = "25")]
		protected virtual void ClearQueuedActionLists()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1CB20B0", Offset = "0x1CB12B0", VA = "0x181CB20B0")]
		public Promise()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PromiseException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string StackTrace
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x260B2F0", Offset = "0x260A4F0", VA = "0x18260B2F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x260B200", Offset = "0x260A400", VA = "0x18260B200")]
		public PromiseException(Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x260B170", Offset = "0x260A370", VA = "0x18260B170")]
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

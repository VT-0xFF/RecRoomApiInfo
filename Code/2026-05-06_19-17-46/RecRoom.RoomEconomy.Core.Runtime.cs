using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.Statsig;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA05D040", Offset = "0xA05BA40", VA = "0x18A05D040")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface UVYWSTNVAYL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task Delay(int milliseconds, CancellationToken cancellationToken);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task Delay(TimeSpan timespan, CancellationToken cancellationToken);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class YMXDJFYJVTA : UVYWSTNVAYL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA05D380", Offset = "0xA05BD80", VA = "0x18A05D380")]
	[BQDQKYYGTTM.Root.GameOnly]
	internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public YMXDJFYJVTA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA05D320", Offset = "0xA05BD20", VA = "0x18A05D320", Slot = "4")]
	public Task Delay(int milliseconds, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA05D2C0", Offset = "0xA05BCC0", VA = "0x18A05D2C0", Slot = "5")]
	public Task Delay(TimeSpan timespan, CancellationToken cancellationToken)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA05DBC0", Offset = "0xA05C5C0", VA = "0x18A05DBC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RVNWFNUIDVR : QJXKZHEANKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private OHWCACFDLHV AFFWJAAHWXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly YFMKREJNONG<bool> RHNMACNDHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly YFMKREJNONG<bool> VAWEMFVXYHX;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DXFLMAORKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA05D110", Offset = "0xA05BB10", VA = "0x18A05D110", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JJZOCAOSBUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA05D0C0", Offset = "0xA05BAC0", VA = "0x18A05D0C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA05D160", Offset = "0xA05BB60", VA = "0x18A05D160")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void TRWAHLHDOMR(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA05D1D0", Offset = "0xA05BBD0", VA = "0x18A05D1D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public RVNWFNUIDVR([Inject(null)][NotNull] OHWCACFDLHV statsigCachedValueFactory)
		{
		}
	}
}
namespace RecRoom.RoomEconomy.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AwardUgcRequestBatcher<TRequest, TResult> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct BatchedAwardRequest
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TRequest Request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public TaskCompletionSource<TResult> TaskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public BatchedAwardRequest(TRequest request, TaskCompletionSource<TResult> taskCompletionSource)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <ProcessPendingRequestsDelayed>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AwardUgcRequestBatcher<TRequest, TResult> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CancellationToken taskDelayCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public CancellationToken outgoingRequestCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3450", Offset = "0x6BB1E50", VA = "0x186BB3450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3CF0", Offset = "0x6BB26F0", VA = "0x186BB3CF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <ProcessPendingRequestsImmediate>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AwardUgcRequestBatcher<TRequest, TResult> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private List<TRequest> <requests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<List<TResult>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB5E30", Offset = "0x6BB4830", VA = "0x186BB5E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB6C80", Offset = "0x6BB5680", VA = "0x186BB6C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <QueueRequest>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AwardUgcRequestBatcher<TRequest, TResult> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public TRequest request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<TResult> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6BBE100", Offset = "0x6BBCB00", VA = "0x186BBE100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x41CBCB0", Offset = "0x41CA6B0", VA = "0x1841CBCB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <ScheduleBatchProcess>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AwardUgcRequestBatcher<TRequest, TResult> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C6A680", Offset = "0x6C69080", VA = "0x186C6A680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C6AA20", Offset = "0x6C69420", VA = "0x186C6AA20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly ZLMJGEQVOFQ<TRequest, TResult> MWGJQOLFZEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly float SMMZQWDMQTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly UVYWSTNVAYL URNSKNBFJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool KILITZZWHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BatchedAwardRequest> MDFUQFMQTBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<BatchedAwardRequest> HSYYUGDGORU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool BZNMFYSQHXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CancellationTokenSource TUVDJOAHYTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource KWUMSMOAAYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task HTOOTHOYAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float JFSMTFRWELT;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CA0", Offset = "0xCD56A0", VA = "0x180CD6CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E30", Offset = "0xCD5830", VA = "0x180CD6E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EDEFB0", Offset = "0x4EDD9B0", VA = "0x184EDEFB0")]
		public AwardUgcRequestBatcher(ZLMJGEQVOFQ<TRequest, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] UVYWSTNVAYL taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD7C0", Offset = "0x4EDC1C0", VA = "0x184EDD7C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDDD0", Offset = "0x4EDC7D0", VA = "0x184EDDDD0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<QueueRequest>d__18))]
		public Task<TResult> FGNVRKYPEWC(TRequest a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDEE0", Offset = "0x4EDC8E0", VA = "0x184EDDEE0")]
		private void FGNVRKYPEWC(TRequest a, TaskCompletionSource<TResult> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE360", Offset = "0x4EDCD60", VA = "0x184EDE360")]
		public Task JYKJANUBAKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE1B0", Offset = "0x4EDCBB0", VA = "0x184EDE1B0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ScheduleBatchProcess>d__21))]
		private Task FWZGXHRUSRY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE890", Offset = "0x4EDD290", VA = "0x184EDE890")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsDelayed>d__22))]
		private Task UNNPTRISHMW(CancellationToken a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDEBD0", Offset = "0x4EDD5D0", VA = "0x184EDEBD0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsImmediate>d__23))]
		private Task WZOYAOUGZCR(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE4E0", Offset = "0x4EDCEE0", VA = "0x184EDE4E0")]
		private TimeSpan OABAYROGOUB()
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDFC0", Offset = "0x4EDC9C0", VA = "0x184EDDFC0")]
		private Task<List<TResult>> FRANJLVGZUN(IReadOnlyList<TRequest> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE670", Offset = "0x4EDD070", VA = "0x184EDE670")]
		private float QJLISBPWRAG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE830", Offset = "0x4EDD230", VA = "0x184EDE830")]
		private void RCAFCNCTWKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class JOGRYWZDJXJ<a, b> : ZLMJGEQVOFQ<ZDPTZGVAOPW<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class EZWOGTCCREE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<a, b> ETRTSZUSPMA;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EZWOGTCCREE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5BB46A0", Offset = "0x5BB30A0", VA = "0x185BB46A0")]
			internal b IZRRVCYYHGF(ZDPTZGVAOPW<a> a)
			{
				return (b)null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <BatchRequestsAndMakeServiceCall>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder<List<b>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public IReadOnlyList<ZDPTZGVAOPW<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public JOGRYWZDJXJ<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private EZWOGTCCREE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x65383F0", Offset = "0x6536DF0", VA = "0x1865383F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x65399F0", Offset = "0x65383F0", VA = "0x1865399F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ServiceCall SAPEENREJYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly IEqualityComparer<a> YYSBJHRHEMZ;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66CFAA0", Offset = "0x66CE4A0", VA = "0x1866CFAA0")]
		public JOGRYWZDJXJ(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66CF530", Offset = "0x66CDF30", VA = "0x1866CF530", Slot = "4")]
		[AsyncStateMachine(typeof(JOGRYWZDJXJ<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> QYJRVXYWPCG(IReadOnlyList<ZDPTZGVAOPW<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class RFMOEMKHRAQ<a, b> : ZLMJGEQVOFQ<a, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<List<b>> ServiceCall(IEnumerable<a> ids, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EZWOGTCCREE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Dictionary<a, b> ZPJRQWGQXWG;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EZWOGTCCREE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BB43B0", Offset = "0x5BB2DB0", VA = "0x185BB43B0")]
			internal b IZRRVCYYHGF(a a)
			{
				return (b)null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <BatchRequestsAndMakeServiceCall>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder<List<b>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public IReadOnlyList<a> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public RFMOEMKHRAQ<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private EZWOGTCCREE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<a> <distinctRequests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6537840", Offset = "0x6536240", VA = "0x186537840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6539B60", Offset = "0x6538560", VA = "0x186539B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ServiceCall SAPEENREJYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IEqualityComparer<a> YYSBJHRHEMZ;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77359A0", Offset = "0x77343A0", VA = "0x1877359A0")]
		public RFMOEMKHRAQ(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7735870", Offset = "0x7734270", VA = "0x187735870", Slot = "4")]
		[AsyncStateMachine(typeof(RFMOEMKHRAQ<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> QYJRVXYWPCG(IReadOnlyList<a> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface ZLMJGEQVOFQ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<b>> QYJRVXYWPCG(IReadOnlyList<a> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class PULNPTULIYO<a, b> : ZLMJGEQVOFQ<UKUQVQJTWNB<a>, object> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate Task AnalyticEventCall(IReadOnlyDictionary<a, UKUQVQJTWNB<a>.SJSNNPDMQHZ> requests, CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private struct <BatchRequestsAndMakeServiceCall>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder<List<object>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public PULNPTULIYO<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<UKUQVQJTWNB<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6534010", Offset = "0x6532A10", VA = "0x186534010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6535070", Offset = "0x6533A70", VA = "0x186535070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly AnalyticEventCall EKOUPTTQFZV;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public PULNPTULIYO(AnalyticEventCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74FD4C0", Offset = "0x74FBEC0", VA = "0x1874FD4C0", Slot = "4")]
		[AsyncStateMachine(typeof(PULNPTULIYO<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<object>> QYJRVXYWPCG(IReadOnlyList<UKUQVQJTWNB<a>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74FDBF0", Offset = "0x74FC5F0", VA = "0x1874FDBF0")]
		private IReadOnlyDictionary<a, UKUQVQJTWNB<a>.SJSNNPDMQHZ> TZLOMHYUQCJ(IReadOnlyList<UKUQVQJTWNB<a>> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class YVGWOHXDKEI<a, b> : ZLMJGEQVOFQ<ZDPTZGVAOPW<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private struct <BatchRequestsAndMakeServiceCall>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AsyncTaskMethodBuilder<List<b>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public IReadOnlyList<ZDPTZGVAOPW<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public YVGWOHXDKEI<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6534470", Offset = "0x6532E70", VA = "0x186534470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6534F60", Offset = "0x6533960", VA = "0x186534F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly ServiceCall JPXJIGTJKNA;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public YVGWOHXDKEI(ServiceCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50F3710", Offset = "0x50F2110", VA = "0x1850F3710", Slot = "4")]
		[AsyncStateMachine(typeof(YVGWOHXDKEI<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<b>> QYJRVXYWPCG(IReadOnlyList<ZDPTZGVAOPW<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class FSAZLDCLRGH<a> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Dictionary<string, EnumChoiceData> OGRLQEBWNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private List<a> VPHRJKHLBOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Func<IEnumerable<a>> HFSRGCKMETE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Func<a, string> PZTQDZTAYLX;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyDictionary<string, EnumChoiceData> XHPFUFLMGBT
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<a> RBXQCFDNYKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int LGGQVSJJIQO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63053B0", Offset = "0x6303DB0", VA = "0x1863053B0")]
		public FSAZLDCLRGH(Func<IEnumerable<a>> a, Func<a, string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63051F0", Offset = "0x6303BF0", VA = "0x1863051F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6304DA0", Offset = "0x63037A0", VA = "0x186304DA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KeyValueRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<ZDPTZGVAOPW<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6905BA0", Offset = "0x69045A0", VA = "0x186905BA0")]
		public KeyValueRequestBatcher(ZLMJGEQVOFQ<ZDPTZGVAOPW<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] UVYWSTNVAYL taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6905690", Offset = "0x6904090", VA = "0x186905690")]
		public Task<TResult> FGNVRKYPEWC(TItemId a, int b, [Optional] CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ZDPTZGVAOPW<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public a RHYPHCYVYLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int QZBTCEWVSZV;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x50F5D20", Offset = "0x50F4720", VA = "0x1850F5D20")]
		public ZDPTZGVAOPW(a a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface PUGQUAFRYEL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Guid WCPSNTFBOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Task<a> EXVLRTKYDSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ZXGBBDHWCCH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private interface ODAJARYVNMV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			int NFAPYOPSVWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool AINUCXVEPNG<a>(a a);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			bool MRCQOQWGDBA(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool ASYIJAPHBHY();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class YUJKYCEOFCK<b> : ODAJARYVNMV, PUGQUAFRYEL<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly TaskCompletionSource<b> OFNABDWGGOQ;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Guid WCPSNTFBOAG
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xEFDE50", Offset = "0xEFC850", VA = "0x180EFDE50", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int NFAPYOPSVWL
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Task<b> EXVLRTKYDSL
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x50F33D0", Offset = "0x50F1DD0", VA = "0x1850F33D0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x50F35F0", Offset = "0x50F1FF0", VA = "0x1850F35F0")]
			public YUJKYCEOFCK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3371210", Offset = "0x336FC10", VA = "0x183371210", Slot = "5")]
			public bool AINUCXVEPNG<a>(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x50F3490", Offset = "0x50F1E90", VA = "0x1850F3490", Slot = "6")]
			public bool MRCQOQWGDBA(Exception a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x50F3330", Offset = "0x50F1D30", VA = "0x1850F3330", Slot = "7")]
			public bool ASYIJAPHBHY()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string KRFXSQPOJST = "Remote player disconnected";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<Guid, ODAJARYVNMV> AWXOUKLASPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly YSFHTSKTXTS CQMQIWBDISG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool JJMJTSHDKAS;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA05DAD0", Offset = "0xA05C4D0", VA = "0x18A05DAD0")]
		public ZXGBBDHWCCH([Optional] YSFHTSKTXTS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA05D3F0", Offset = "0xA05BDF0", VA = "0x18A05D3F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4144680", Offset = "0x4143080", VA = "0x184144680")]
		public PUGQUAFRYEL<a> NNQWCHZGRKV<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4144280", Offset = "0x4142C80", VA = "0x184144280")]
		public bool BEFKBAMYGYX<b>(Guid a, b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA05D7C0", Offset = "0xA05C1C0", VA = "0x18A05D7C0")]
		private void VHVRPFYXNZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA05D3F0", Offset = "0xA05BDF0", VA = "0x18A05D3F0")]
		private void UXBYQATLHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA05D4F0", Offset = "0xA05BEF0", VA = "0x18A05D4F0")]
		private void OnPhotonPlayerDisconnected(int recNetAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA05D8D0", Offset = "0xA05C2D0", VA = "0x18A05D8D0")]
		private void XNMVTNKTTVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum InventoryItemSource
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		EQUIPMENT_SLOTS,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		CV2_USE_INVENTORY_ITEM,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		ROOM_INVENTORY_RRUI
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class UKUQVQJTWNB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class SJSNNPDMQHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int ZVWSBSEGXJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int VVABYIMFSGQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int QHTXTUFSNNW;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public SJSNNPDMQHZ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public a RHYPHCYVYLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int QZBTCEWVSZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public InventoryItemSource FZJVWQQYTXZ;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CD8210", Offset = "0x1CD6C10", VA = "0x181CD8210")]
		public UKUQVQJTWNB(a a, int b, InventoryItemSource c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RoomInventoryItemAnalyticsEventRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<UKUQVQJTWNB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x79AF580", Offset = "0x79ADF80", VA = "0x1879AF580")]
		public RoomInventoryItemAnalyticsEventRequestBatcher(ZLMJGEQVOFQ<UKUQVQJTWNB<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, [Optional] UVYWSTNVAYL taskDelay)
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

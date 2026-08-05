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
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
internal sealed class ZHPALOHOCAQ<a, b>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a SFBJRCNQIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b PIHJPCLRYWN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public a ZBJBQRAIHHQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public b EVGFJTUBHNY
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
		get
		{
			return (b)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
	[DebuggerHidden]
	public ZHPALOHOCAQ(a a, b b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4491820", Offset = "0x4490420", VA = "0x184491820", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4492CE0", Offset = "0x44918E0", VA = "0x184492CE0", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4492E60", Offset = "0x4491A60", VA = "0x184492E60", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x92280A0", Offset = "0x9226CA0", VA = "0x1892280A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface XPBIEDXVVOM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task Delay(int milliseconds, CancellationToken cancellationToken);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task Delay(TimeSpan timespan, CancellationToken cancellationToken);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KPJDPLIMPHJ : XPBIEDXVVOM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9228030", Offset = "0x9226C30", VA = "0x189228030")]
	[IFIZWETSKCB.Root.GameOnly]
	internal static void RIWNJSDCBRY(DiContainer a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	[RecRoom.NoEngine.Common.Preserve]
	public KPJDPLIMPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9227F70", Offset = "0x9226B70", VA = "0x189227F70", Slot = "4")]
	public Task Delay(int milliseconds, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9227FD0", Offset = "0x9226BD0", VA = "0x189227FD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9228320", Offset = "0x9226F20", VA = "0x189228320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ZEOVUQOCBRE : SBSTGCCCART
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ZZOXJIYGFXC BKIOUDDZEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly XCAIZHFGHZH<bool> IJYRQYHLCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly XCAIZHFGHZH<bool> JEHAMGDALDU;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool BAKPDXXLRYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x92281E0", Offset = "0x9226DE0", VA = "0x1892281E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OWCWIHMSDSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9228120", Offset = "0x9226D20", VA = "0x189228120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9228170", Offset = "0x9226D70", VA = "0x189228170")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void RIWNJSDCBRY(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9228230", Offset = "0x9226E30", VA = "0x189228230")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZEOVUQOCBRE([Inject(null)][NotNull] ZZOXJIYGFXC statsigCachedValueFactory)
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
			[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
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
			[Cpp2IlInjected.Address(RVA = "0x55CC860", Offset = "0x55CB460", VA = "0x1855CC860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x55CD100", Offset = "0x55CBD00", VA = "0x1855CD100", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x55CF240", Offset = "0x55CDE40", VA = "0x1855CF240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x55D0090", Offset = "0x55CEC90", VA = "0x1855D0090", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x55D2710", Offset = "0x55D1310", VA = "0x1855D2710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x428CDC0", Offset = "0x428B9C0", VA = "0x18428CDC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5602620", Offset = "0x5601220", VA = "0x185602620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x56029C0", Offset = "0x56015C0", VA = "0x1856029C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly NGNVLWVOWIP<TRequest, TResult> JRCVNRJWOXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly float HAKEIQGJNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly XPBIEDXVVOM IEMNZYFJVZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool CJEKYSPZCMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BatchedAwardRequest> BGYJGAFFNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<BatchedAwardRequest> GOOCPLFTNVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool WMSLNOJUYWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CancellationTokenSource PZEIBPMUNIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource BMWXRFMJVLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task QZLBQBNQWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float HFXLXYUBBHG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB131C0", Offset = "0xB11DC0", VA = "0x180B131C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB13270", Offset = "0xB11E70", VA = "0x180B13270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x76DF880", Offset = "0x76DE480", VA = "0x1876DF880")]
		public AwardUgcRequestBatcher(NGNVLWVOWIP<TRequest, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] XPBIEDXVVOM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76DE380", Offset = "0x76DCF80", VA = "0x1876DE380", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76DF3C0", Offset = "0x76DDFC0", VA = "0x1876DF3C0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<QueueRequest>d__18))]
		public Task<TResult> YDZLRFYAHGB(TRequest a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76DF140", Offset = "0x76DDD40", VA = "0x1876DF140")]
		private void YDZLRFYAHGB(TRequest a, TaskCompletionSource<TResult> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76DE950", Offset = "0x76DD550", VA = "0x1876DE950")]
		public Task NNXFQQQECGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76DF7B0", Offset = "0x76DE3B0", VA = "0x1876DF7B0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ScheduleBatchProcess>d__21))]
		private Task YMVUCVGZYAR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76DE770", Offset = "0x76DD370", VA = "0x1876DE770")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsDelayed>d__22))]
		private Task LIWVCHRPUNB(CancellationToken a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76DF4D0", Offset = "0x76DE0D0", VA = "0x1876DF4D0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsImmediate>d__23))]
		private Task YJTXZDXFHOM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76DEA10", Offset = "0x76DD610", VA = "0x1876DEA10")]
		private TimeSpan UWMGVUJNKUU()
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76DECA0", Offset = "0x76DD8A0", VA = "0x1876DECA0")]
		private Task<List<TResult>> XWUHPHUCHXK(IReadOnlyList<TRequest> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76DE5B0", Offset = "0x76DD1B0", VA = "0x1876DE5B0")]
		private float EIUOWVFWTHP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76DED90", Offset = "0x76DD990", VA = "0x1876DED90")]
		private void YBQMIUPSKTF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DDXLVCAABYG<a, b> : NGNVLWVOWIP<UMPRCZDORBH<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<a, b> FLTREZHETWN;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x43B0610", Offset = "0x43AF210", VA = "0x1843B0610")]
			internal b XEGHMEDTNEE(UMPRCZDORBH<a> a)
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
			public IReadOnlyList<UMPRCZDORBH<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public DDXLVCAABYG<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private CWLCWDGOHPR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x537F670", Offset = "0x537E270", VA = "0x18537F670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5381DA0", Offset = "0x53809A0", VA = "0x185381DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ServiceCall DHWJDJRZEVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly IEqualityComparer<a> ZAUCHTYZQMG;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4654720", Offset = "0x4653320", VA = "0x184654720")]
		public DDXLVCAABYG(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4654170", Offset = "0x4652D70", VA = "0x184654170", Slot = "4")]
		[AsyncStateMachine(typeof(DDXLVCAABYG<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> ZQVGSDMNRFB(IReadOnlyList<UMPRCZDORBH<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class WHBMUNLRCMR<a, b> : NGNVLWVOWIP<a, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<List<b>> ServiceCall(IEnumerable<a> ids, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Dictionary<a, b> DAOTNELIZKJ;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x43B0CF0", Offset = "0x43AF8F0", VA = "0x1843B0CF0")]
			internal b XEGHMEDTNEE(a a)
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
			public WHBMUNLRCMR<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private CWLCWDGOHPR <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<a> <distinctRequests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x537D4C0", Offset = "0x537C0C0", VA = "0x18537D4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5381D00", Offset = "0x5380900", VA = "0x185381D00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ServiceCall DHWJDJRZEVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IEqualityComparer<a> ZAUCHTYZQMG;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D58D60", Offset = "0x6D57960", VA = "0x186D58D60")]
		public WHBMUNLRCMR(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D58AE0", Offset = "0x6D576E0", VA = "0x186D58AE0", Slot = "4")]
		[AsyncStateMachine(typeof(WHBMUNLRCMR<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> ZQVGSDMNRFB(IReadOnlyList<a> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NGNVLWVOWIP<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<b>> ZQVGSDMNRFB(IReadOnlyList<a> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class MJGEQUSNRKD<a, b> : NGNVLWVOWIP<GLUYLSGKTVI<a>, object> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate Task AnalyticEventCall(IReadOnlyDictionary<a, GLUYLSGKTVI<a>.MAQTPRAUNLG> requests, CancellationToken cancellationToken);

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
			public MJGEQUSNRKD<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<GLUYLSGKTVI<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x537CE10", Offset = "0x537BA10", VA = "0x18537CE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x537D450", Offset = "0x537C050", VA = "0x18537D450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly AnalyticEventCall OXHPRHTOXWS;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public MJGEQUSNRKD(AnalyticEventCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3200", Offset = "0x5EB1E00", VA = "0x185EB3200", Slot = "4")]
		[AsyncStateMachine(typeof(MJGEQUSNRKD<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<object>> ZQVGSDMNRFB(IReadOnlyList<GLUYLSGKTVI<a>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2DE0", Offset = "0x5EB19E0", VA = "0x185EB2DE0")]
		private IReadOnlyDictionary<a, GLUYLSGKTVI<a>.MAQTPRAUNLG> BYRIAIQDIII(IReadOnlyList<GLUYLSGKTVI<a>> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AKNQSNVZQKR<a, b> : NGNVLWVOWIP<UMPRCZDORBH<a>, b> where a : IEquatable<a>
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
			public IReadOnlyList<UMPRCZDORBH<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AKNQSNVZQKR<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x537AD50", Offset = "0x5379950", VA = "0x18537AD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x537D270", Offset = "0x537BE70", VA = "0x18537D270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly ServiceCall CSUAWZKFHND;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public AKNQSNVZQKR(ServiceCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5C97FC0", Offset = "0x5C96BC0", VA = "0x185C97FC0", Slot = "4")]
		[AsyncStateMachine(typeof(AKNQSNVZQKR<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<b>> ZQVGSDMNRFB(IReadOnlyList<UMPRCZDORBH<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class VIOBIPDAODC<a> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Dictionary<string, EnumChoiceData> ZIEJIIEZZUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private List<a> MUNFHTMWYXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Func<IEnumerable<a>> SIVWAJGBTDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Func<a, string> VOGXEFLBTXI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyDictionary<string, EnumChoiceData> ORTZQRGZGOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<a> HETGXHRIXXA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int YBPKIPNOPJV
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6933E20", Offset = "0x6932A20", VA = "0x186933E20")]
		public VIOBIPDAODC(Func<IEnumerable<a>> a, Func<a, string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6933900", Offset = "0x6932500", VA = "0x186933900")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6933880", Offset = "0x6932480", VA = "0x186933880", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KeyValueRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<UMPRCZDORBH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x59738A0", Offset = "0x59724A0", VA = "0x1859738A0")]
		public KeyValueRequestBatcher(NGNVLWVOWIP<UMPRCZDORBH<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] XPBIEDXVVOM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5973390", Offset = "0x5971F90", VA = "0x185973390")]
		public Task<TResult> YDZLRFYAHGB(TItemId a, int b, [Optional] CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class UMPRCZDORBH<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public a BZUXNLHALBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int YIBMMPMZBXG;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x681A340", Offset = "0x6818F40", VA = "0x18681A340")]
		public UMPRCZDORBH(a a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface ZMKLUNOTZJG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Guid NTOLQNYWQVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Task<a> SZQSIFVECMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DEJFTPCSMYM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private interface MSMECGLXSDQ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			int COAQBOYPXYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool JHOHTTSKQIP<a>(a a);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			bool LVHWLBBUANN(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool IIGPJIHKVSF();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class ICJFRTBWXVF<b> : MSMECGLXSDQ, ZMKLUNOTZJG<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly TaskCompletionSource<b> JDNGBXHNYRH;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Guid NTOLQNYWQVZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int COAQBOYPXYK
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Task<b> SZQSIFVECMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x554CA20", Offset = "0x554B620", VA = "0x18554CA20", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x554CD10", Offset = "0x554B910", VA = "0x18554CD10")]
			public ICJFRTBWXVF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x40B3230", Offset = "0x40B1E30", VA = "0x1840B3230", Slot = "5")]
			public bool JHOHTTSKQIP<a>(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x554CB50", Offset = "0x554B750", VA = "0x18554CB50", Slot = "6")]
			public bool LVHWLBBUANN(Exception a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x554CAA0", Offset = "0x554B6A0", VA = "0x18554CAA0", Slot = "7")]
			public bool IIGPJIHKVSF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string ODLSFPNDDMI = "Remote player disconnected";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<Guid, MSMECGLXSDQ> KWTCPVWNCZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly TYHVAMYFASJ GRTBDFSMAFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool RKDCQSOEXYZ;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9227E80", Offset = "0x9226A80", VA = "0x189227E80")]
		public DEJFTPCSMYM([Optional] TYHVAMYFASJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x92278A0", Offset = "0x92264A0", VA = "0x1892278A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3A87750", Offset = "0x3A86350", VA = "0x183A87750")]
		public ZMKLUNOTZJG<a> MGDKHTBEHNQ<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3A87AF0", Offset = "0x3A866F0", VA = "0x183A87AF0")]
		public bool WBDSTDVGUGE<b>(Guid a, b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9227790", Offset = "0x9226390", VA = "0x189227790")]
		private void CZRHCPNZHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x92278A0", Offset = "0x92264A0", VA = "0x1892278A0")]
		private void EEFPARYRJWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x92279A0", Offset = "0x92265A0", VA = "0x1892279A0")]
		private void OnPhotonPlayerDisconnected(int recNetAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9227C80", Offset = "0x9226880", VA = "0x189227C80")]
		private void UPFGFDHSKMQ()
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
	public class GLUYLSGKTVI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class MAQTPRAUNLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int OAVIQZJZYKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int ELLNDHJHYHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int NPLHKSCQCLF;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public MAQTPRAUNLG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public a BZUXNLHALBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int YIBMMPMZBXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public InventoryItemSource JKJORIMASLC;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x24955C0", Offset = "0x24941C0", VA = "0x1824955C0")]
		public GLUYLSGKTVI(a a, int b, InventoryItemSource c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RoomInventoryItemAnalyticsEventRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<GLUYLSGKTVI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64E16E0", Offset = "0x64E02E0", VA = "0x1864E16E0")]
		public RoomInventoryItemAnalyticsEventRequestBatcher(NGNVLWVOWIP<GLUYLSGKTVI<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, [Optional] XPBIEDXVVOM taskDelay)
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

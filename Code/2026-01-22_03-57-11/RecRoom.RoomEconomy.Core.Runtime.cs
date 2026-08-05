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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ADCD00", Offset = "0x8ADB500", VA = "0x188ADCD00")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface SATCCBSFQPM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task Delay(int milliseconds, CancellationToken cancellationToken);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task Delay(TimeSpan timespan, CancellationToken cancellationToken);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LAZJFWTYAFL : SATCCBSFQPM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCC90", Offset = "0x8ADB490", VA = "0x188ADCC90")]
	[SLGIUIECCXF.Root.GameOnly]
	internal static void RGYVRYLRKIA(MUPQGBSCKZR a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
	[RecRoom.NoEngine.Common.Preserve]
	public LAZJFWTYAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCBD0", Offset = "0x8ADB3D0", VA = "0x188ADCBD0", Slot = "4")]
	public Task Delay(int milliseconds, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCC30", Offset = "0x8ADB430", VA = "0x188ADCC30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ADCF80", Offset = "0x8ADB780", VA = "0x188ADCF80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UPLDNKCPLKI : OYUDRRFJBLV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IXCTDCYYNKK UTGZRAVLASF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly DQGFSUJJIFN<bool> UEYEWWVHAQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DQGFSUJJIFN<bool> FUNXQFXXCCY;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ALMAINDZDBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCE40", Offset = "0x8ADB640", VA = "0x188ADCE40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OSYMLHSPJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCD80", Offset = "0x8ADB580", VA = "0x188ADCD80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCDD0", Offset = "0x8ADB5D0", VA = "0x188ADCDD0")]
		[SLGIUIECCXF.Root.GameOnly]
		internal static void RGYVRYLRKIA(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCE90", Offset = "0x8ADB690", VA = "0x188ADCE90")]
		[RecRoom.NoEngine.Common.Preserve]
		public UPLDNKCPLKI([Inject(null)][NotNull] IXCTDCYYNKK statsigCachedValueFactory)
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
			[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B1F80", Offset = "0x50B0780", VA = "0x1850B1F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50B2810", Offset = "0x50B1010", VA = "0x1850B2810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B4920", Offset = "0x50B3120", VA = "0x1850B4920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x50B5750", Offset = "0x50B3F50", VA = "0x1850B5750", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x50B8B50", Offset = "0x50B7350", VA = "0x1850B8B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3CCF110", Offset = "0x3CCD910", VA = "0x183CCF110", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5224680", Offset = "0x5222E80", VA = "0x185224680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5224A20", Offset = "0x5223220", VA = "0x185224A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IIWZEGRLOSJ<TRequest, TResult> XUPYRDNIHQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly float NOREBFGEEAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SATCCBSFQPM UCFFINIFXQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool BLJZPTCLEWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BatchedAwardRequest> ZRDYYTIOLRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<BatchedAwardRequest> WIJXRYLTFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool UNZGIJZQPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CancellationTokenSource GFQQDSOSWFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource BBKBTATIUOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task AALIOQKGBRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float RRXIBXCEECG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAB39F0", Offset = "0xAB21F0", VA = "0x180AB39F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAB4140", Offset = "0xAB2940", VA = "0x180AB4140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F64CF0", Offset = "0x6F634F0", VA = "0x186F64CF0")]
		public AwardUgcRequestBatcher(IIWZEGRLOSJ<TRequest, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] SATCCBSFQPM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F63980", Offset = "0x6F62180", VA = "0x186F63980", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F64960", Offset = "0x6F63160", VA = "0x186F64960")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<QueueRequest>d__18))]
		public Task<TResult> VSWTKCHFAWD(TRequest a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F64C10", Offset = "0x6F63410", VA = "0x186F64C10")]
		private void VSWTKCHFAWD(TRequest a, TaskCompletionSource<TResult> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F642E0", Offset = "0x6F62AE0", VA = "0x186F642E0")]
		public Task TAXZLSTFHZI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F643A0", Offset = "0x6F62BA0", VA = "0x186F643A0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ScheduleBatchProcess>d__21))]
		private Task VCLQFIVETDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F63D10", Offset = "0x6F62510", VA = "0x186F63D10")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsDelayed>d__22))]
		private Task NMFTACBOBOJ(CancellationToken a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F63F30", Offset = "0x6F62730", VA = "0x186F63F30")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsImmediate>d__23))]
		private Task PBYJMXFTBRU(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F63580", Offset = "0x6F61D80", VA = "0x186F63580")]
		private TimeSpan AGOJMSSZZHY()
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F64030", Offset = "0x6F62830", VA = "0x186F64030")]
		private Task<List<TResult>> QJCQYSIIOFQ(IReadOnlyList<TRequest> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F645F0", Offset = "0x6F62DF0", VA = "0x186F645F0")]
		private float VIBGOQJEMFZ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F63B90", Offset = "0x6F62390", VA = "0x186F63B90")]
		private void IKIPBVUVZHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class WRZSOHBOTCY<a, b> : IIWZEGRLOSJ<UWKTMXPSMYL<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class OVYXGTZWSNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<a, b> MJEADSGMLVV;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVYXGTZWSNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x59F0760", Offset = "0x59EEF60", VA = "0x1859F0760")]
			internal b EUUXEUIGUCC(UWKTMXPSMYL<a> a)
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
			public IReadOnlyList<UWKTMXPSMYL<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public WRZSOHBOTCY<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private OVYXGTZWSNL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D7A0", Offset = "0x4E3BFA0", VA = "0x184E3D7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4E41430", Offset = "0x4E3FC30", VA = "0x184E41430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ServiceCall ICGAEULSHVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly IEqualityComparer<a> SPCMLSKTGAM;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66B9900", Offset = "0x66B8100", VA = "0x1866B9900")]
		public WRZSOHBOTCY(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66B9180", Offset = "0x66B7980", VA = "0x1866B9180", Slot = "4")]
		[AsyncStateMachine(typeof(WRZSOHBOTCY<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> MCEGJEJBKQR(IReadOnlyList<UWKTMXPSMYL<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class QQAIPATKVNV<a, b> : IIWZEGRLOSJ<a, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<List<b>> ServiceCall(IEnumerable<a> ids, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class OVYXGTZWSNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Dictionary<a, b> NWVWPFUSWSH;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVYXGTZWSNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x59F08D0", Offset = "0x59EF0D0", VA = "0x1859F08D0")]
			internal b EUUXEUIGUCC(a a)
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
			public QQAIPATKVNV<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private OVYXGTZWSNL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<a> <distinctRequests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4E3FDC0", Offset = "0x4E3E5C0", VA = "0x184E3FDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4E41670", Offset = "0x4E3FE70", VA = "0x184E41670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ServiceCall ICGAEULSHVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IEqualityComparer<a> SPCMLSKTGAM;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8F70", Offset = "0x5BD7770", VA = "0x185BD8F70")]
		public QQAIPATKVNV(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8DB0", Offset = "0x5BD75B0", VA = "0x185BD8DB0", Slot = "4")]
		[AsyncStateMachine(typeof(QQAIPATKVNV<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> MCEGJEJBKQR(IReadOnlyList<a> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface IIWZEGRLOSJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<b>> MCEGJEJBKQR(IReadOnlyList<a> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class GXVQASPPPXL<a, b> : IIWZEGRLOSJ<TDNJKUSHCOY<a>, object> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate Task AnalyticEventCall(IReadOnlyDictionary<a, TDNJKUSHCOY<a>.PYBPLREDYHI> requests, CancellationToken cancellationToken);

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
			public GXVQASPPPXL<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<TDNJKUSHCOY<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4E3C610", Offset = "0x4E3AE10", VA = "0x184E3C610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4E3CA70", Offset = "0x4E3B270", VA = "0x184E3CA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly AnalyticEventCall PFJWQDOXGNW;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public GXVQASPPPXL(AnalyticEventCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFBE0", Offset = "0x4EBE3E0", VA = "0x184EBFBE0", Slot = "4")]
		[AsyncStateMachine(typeof(GXVQASPPPXL<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<object>> MCEGJEJBKQR(IReadOnlyList<TDNJKUSHCOY<a>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF090", Offset = "0x4EBD890", VA = "0x184EBF090")]
		private IReadOnlyDictionary<a, TDNJKUSHCOY<a>.PYBPLREDYHI> LZKVRSOQDMW(IReadOnlyList<TDNJKUSHCOY<a>> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UGJPLDDQNGX<a, b> : IIWZEGRLOSJ<UWKTMXPSMYL<a>, b> where a : IEquatable<a>
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
			public IReadOnlyList<UWKTMXPSMYL<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public UGJPLDDQNGX<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4E3BB30", Offset = "0x4E3A330", VA = "0x184E3BB30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4E3CAE0", Offset = "0x4E3B2E0", VA = "0x184E3CAE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly ServiceCall DHBKMCMQFBR;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public UGJPLDDQNGX(ServiceCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x619B240", Offset = "0x6199A40", VA = "0x18619B240", Slot = "4")]
		[AsyncStateMachine(typeof(UGJPLDDQNGX<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<b>> MCEGJEJBKQR(IReadOnlyList<UWKTMXPSMYL<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class JBKIHHDOYRU<a> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Dictionary<string, EnumChoiceData> WZMWWIKCSST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private List<a> TRLOWBEKBPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Func<IEnumerable<a>> DJBMXQVSOVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Func<a, string> EEATOWVJTBW;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyDictionary<string, EnumChoiceData> TNJARGAWZPS
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<a> CPGMQOWVYCM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JJSZTWXPDJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB02F10", Offset = "0xB01710", VA = "0x180B02F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x50C6A10", Offset = "0x50C5210", VA = "0x1850C6A10")]
		public JBKIHHDOYRU(Func<IEnumerable<a>> a, Func<a, string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x50C63C0", Offset = "0x50C4BC0", VA = "0x1850C63C0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x50C62D0", Offset = "0x50C4AD0", VA = "0x1850C62D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KeyValueRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<UWKTMXPSMYL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x52E5300", Offset = "0x52E3B00", VA = "0x1852E5300")]
		public KeyValueRequestBatcher(IIWZEGRLOSJ<UWKTMXPSMYL<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] SATCCBSFQPM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x52E5100", Offset = "0x52E3900", VA = "0x1852E5100")]
		public Task<TResult> VSWTKCHFAWD(TItemId a, int b, [Optional] CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class UWKTMXPSMYL<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public a JJDGCCJBDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int GJXAWVROPGC;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61B0190", Offset = "0x61AE990", VA = "0x1861B0190")]
		public UWKTMXPSMYL(a a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface SIIKSMYCKRA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Guid ONEZDRAKOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Task<a> HXHEFIFWSYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class FTTBSMIBGES : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private interface ZKFFWBYBIXK
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			int YKUVNXIZUME
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool MLUIUEZJTQJ<a>(a a);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			bool TIVIOKIMKSZ(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool CYBITBBXRCX();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class HGIGVCMXJWN<b> : ZKFFWBYBIXK, SIIKSMYCKRA<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly TaskCompletionSource<b> XQILGMAWIWP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Guid ONEZDRAKOMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int YKUVNXIZUME
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Task<b> HXHEFIFWSYC
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4F32650", Offset = "0x4F30E50", VA = "0x184F32650", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4F32830", Offset = "0x4F31030", VA = "0x184F32830")]
			public HGIGVCMXJWN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x35C4DF0", Offset = "0x35C35F0", VA = "0x1835C4DF0", Slot = "5")]
			public bool MLUIUEZJTQJ<a>(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4F325A0", Offset = "0x4F30DA0", VA = "0x184F325A0", Slot = "6")]
			public bool TIVIOKIMKSZ(Exception a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4F32470", Offset = "0x4F30C70", VA = "0x184F32470", Slot = "7")]
			public bool CYBITBBXRCX()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string NMWQWTMMKAK = "Remote player disconnected";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<Guid, ZKFFWBYBIXK> AMLVGOPXPRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly LCJWRMESFCP CRZWIZOSYWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool IDENVNOMUBJ;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCAE0", Offset = "0x8ADB2E0", VA = "0x188ADCAE0")]
		public FTTBSMIBGES([Optional] LCJWRMESFCP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC400", Offset = "0x8ADAC00", VA = "0x188ADC400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x36B01B0", Offset = "0x36AE9B0", VA = "0x1836B01B0")]
		public SIIKSMYCKRA<a> LUKDAGAVYFS<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x36B0540", Offset = "0x36AED40", VA = "0x1836B0540")]
		public bool ZUWNSLPPCYK<b>(Guid a, b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC500", Offset = "0x8ADAD00", VA = "0x188ADC500")]
		private void MDIGBGWQZJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC400", Offset = "0x8ADAC00", VA = "0x188ADC400")]
		private void JKLKWLNFUAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC610", Offset = "0x8ADAE10", VA = "0x188ADC610")]
		private void OnPhotonPlayerDisconnected(int recNetAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC8E0", Offset = "0x8ADB0E0", VA = "0x188ADC8E0")]
		private void VSKXRGWPBJA()
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
	public class TDNJKUSHCOY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class PYBPLREDYHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int ZPHIOHFHAOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int CCTQOUJEXYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int OSXRHTFVPMR;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public PYBPLREDYHI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public a JJDGCCJBDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int GJXAWVROPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public InventoryItemSource ZIRLVQYXIOK;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2480", Offset = "0x1AA0C80", VA = "0x181AA2480")]
		public TDNJKUSHCOY(a a, int b, InventoryItemSource c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RoomInventoryItemAnalyticsEventRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<TDNJKUSHCOY<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A610", Offset = "0x5E48E10", VA = "0x185E4A610")]
		public RoomInventoryItemAnalyticsEventRequestBatcher(IIWZEGRLOSJ<TDNJKUSHCOY<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, [Optional] SATCCBSFQPM taskDelay)
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

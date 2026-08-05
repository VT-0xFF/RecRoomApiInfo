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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1AF090", Offset = "0xA1AE090", VA = "0x18A1AF090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface SXWWBJWZSHF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task Delay(int milliseconds, CancellationToken cancellationToken);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task Delay(TimeSpan timespan, CancellationToken cancellationToken);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CXYPUFJQCEC : SXWWBJWZSHF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1AE850", Offset = "0xA1AD850", VA = "0x18A1AE850")]
	[GQJUYEPYYUG.Root.GameOnly]
	internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CXYPUFJQCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA1AE7F0", Offset = "0xA1AD7F0", VA = "0x18A1AE7F0", Slot = "4")]
	public Task Delay(int milliseconds, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA1AE790", Offset = "0xA1AD790", VA = "0x18A1AE790", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1AF310", Offset = "0xA1AE310", VA = "0x18A1AF310", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RTVDNYILIOD : UKIACOPNUFY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private FRYLGEWUQFV DFWHJERIVBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PTTJZOWZKAA<bool> ZBESZEQEAZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PTTJZOWZKAA<bool> MDLKGITYNWN;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HQZABOFIROB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF1D0", Offset = "0xA1AE1D0", VA = "0x18A1AF1D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool VCSSVYOYEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA1AF180", Offset = "0xA1AE180", VA = "0x18A1AF180", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF110", Offset = "0xA1AE110", VA = "0x18A1AF110")]
		[GQJUYEPYYUG.Root.GameOnly]
		internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1AF220", Offset = "0xA1AE220", VA = "0x18A1AF220")]
		[RecRoom.NoEngine.Common.Preserve]
		public RTVDNYILIOD([Inject(null)][NotNull] FRYLGEWUQFV statsigCachedValueFactory)
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
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B6A650", Offset = "0x6B69650", VA = "0x186B6A650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6B6AF00", Offset = "0x6B69F00", VA = "0x186B6AF00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B6D170", Offset = "0x6B6C170", VA = "0x186B6D170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B6E020", Offset = "0x6B6D020", VA = "0x186B6E020", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B75A10", Offset = "0x6B74A10", VA = "0x186B75A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x41B2A60", Offset = "0x41B1A60", VA = "0x1841B2A60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C22420", Offset = "0x6C21420", VA = "0x186C22420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C227D0", Offset = "0x6C217D0", VA = "0x186C227D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly QTMUXHUDKXU<TRequest, TResult> TXIXIQJBNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly float NFMMMTMBPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SXWWBJWZSHF EXGRCBOKHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool HSDFKTIVLTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BatchedAwardRequest> FVDPFNFHUON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<BatchedAwardRequest> LXSIQQEBMSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool CDZYSHCFKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CancellationTokenSource XIIVZOUPQEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource AUXXTNEJHQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task XSDXZBCGDRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float QLVBFVYYMCV;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCFC230", Offset = "0xCFB230", VA = "0x180CFC230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCFCB50", Offset = "0xCFBB50", VA = "0x180CFCB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC7C0", Offset = "0x4EDB7C0", VA = "0x184EDC7C0")]
		public AwardUgcRequestBatcher(QTMUXHUDKXU<TRequest, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] SXWWBJWZSHF taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBD30", Offset = "0x4EDAD30", VA = "0x184EDBD30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB7C0", Offset = "0x4EDA7C0", VA = "0x184EDB7C0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<QueueRequest>d__18))]
		public Task<TResult> DIIQJLIKOKS(TRequest a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB8E0", Offset = "0x4EDA8E0", VA = "0x184EDB8E0")]
		private void DIIQJLIKOKS(TRequest a, TaskCompletionSource<TResult> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC1B0", Offset = "0x4EDB1B0", VA = "0x184EDC1B0")]
		public Task NLUKOZHGPTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC6E0", Offset = "0x4EDB6E0", VA = "0x184EDC6E0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ScheduleBatchProcess>d__21))]
		private Task WZSQETTIIJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4EDAEE0", Offset = "0x4ED9EE0", VA = "0x184EDAEE0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsDelayed>d__22))]
		private Task BCCJDXFXLFM(CancellationToken a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC400", Offset = "0x4EDB400", VA = "0x184EDC400")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsImmediate>d__23))]
		private Task RQNCRSOZLHX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC270", Offset = "0x4EDB270", VA = "0x184EDC270")]
		private TimeSpan RAGXGTGBCYJ()
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB230", Offset = "0x4EDA230", VA = "0x184EDB230")]
		private Task<List<TResult>> BPBGWMDMRPH(IReadOnlyList<TRequest> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBF70", Offset = "0x4EDAF70", VA = "0x184EDBF70")]
		private float JQWKTFJQZRE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4EDC010", Offset = "0x4EDB010", VA = "0x184EDC010")]
		private void MDISSTYMKFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class KCTJJDRGSJR<a, b> : QTMUXHUDKXU<YGSDVVMUOEM<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<a, b> ODJXWVQYTBW;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5034320", Offset = "0x5033320", VA = "0x185034320")]
			internal b QDBFTHPGMGJ(YGSDVVMUOEM<a> a)
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
			public IReadOnlyList<YGSDVVMUOEM<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public KCTJJDRGSJR<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private CCYEXJECMVG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6544620", Offset = "0x6543620", VA = "0x186544620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6545D40", Offset = "0x6544D40", VA = "0x186545D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ServiceCall JTPHJYEJRSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly IEqualityComparer<a> QYWPGCXOWON;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x685EFE0", Offset = "0x685DFE0", VA = "0x18685EFE0")]
		public KCTJJDRGSJR(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x685ECA0", Offset = "0x685DCA0", VA = "0x18685ECA0", Slot = "4")]
		[AsyncStateMachine(typeof(KCTJJDRGSJR<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> JFUIZFOUIUW(IReadOnlyList<YGSDVVMUOEM<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SPEWNHOQMZK<a, b> : QTMUXHUDKXU<a, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<List<b>> ServiceCall(IEnumerable<a> ids, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Dictionary<a, b> RQGEVTMULUS;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5034750", Offset = "0x5033750", VA = "0x185034750")]
			internal b QDBFTHPGMGJ(a a)
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
			public SPEWNHOQMZK<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private CCYEXJECMVG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<a> <distinctRequests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6542E50", Offset = "0x6541E50", VA = "0x186542E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6545DE0", Offset = "0x6544DE0", VA = "0x186545DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ServiceCall JTPHJYEJRSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IEqualityComparer<a> QYWPGCXOWON;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC82E0", Offset = "0x7AC72E0", VA = "0x187AC82E0")]
		public SPEWNHOQMZK(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AC81A0", Offset = "0x7AC71A0", VA = "0x187AC81A0", Slot = "4")]
		[AsyncStateMachine(typeof(SPEWNHOQMZK<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> JFUIZFOUIUW(IReadOnlyList<a> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface QTMUXHUDKXU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<b>> JFUIZFOUIUW(IReadOnlyList<a> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class TZNTJAOBISC<a, b> : QTMUXHUDKXU<YZQCWRXTJUX<a>, object> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate Task AnalyticEventCall(IReadOnlyDictionary<a, YZQCWRXTJUX<a>.SZXXUADFVPV> requests, CancellationToken cancellationToken);

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
			public TZNTJAOBISC<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<YZQCWRXTJUX<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x653F9F0", Offset = "0x653E9F0", VA = "0x18653F9F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6540EF0", Offset = "0x653FEF0", VA = "0x186540EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly AnalyticEventCall IQKLABHHBFN;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public TZNTJAOBISC(AnalyticEventCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C60140", Offset = "0x7C5F140", VA = "0x187C60140", Slot = "4")]
		[AsyncStateMachine(typeof(TZNTJAOBISC<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<object>> JFUIZFOUIUW(IReadOnlyList<YZQCWRXTJUX<a>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C608A0", Offset = "0x7C5F8A0", VA = "0x187C608A0")]
		private IReadOnlyDictionary<a, YZQCWRXTJUX<a>.SZXXUADFVPV> RXNGPZECRPL(IReadOnlyList<YZQCWRXTJUX<a>> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class TSPFVERWKTC<a, b> : QTMUXHUDKXU<YGSDVVMUOEM<a>, b> where a : IEquatable<a>
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
			public IReadOnlyList<YGSDVVMUOEM<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public TSPFVERWKTC<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x65403D0", Offset = "0x653F3D0", VA = "0x1865403D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x65410A0", Offset = "0x65400A0", VA = "0x1865410A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly ServiceCall UEDVEWNPJOS;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public TSPFVERWKTC(ServiceCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C160", Offset = "0x7C5B160", VA = "0x187C5C160", Slot = "4")]
		[AsyncStateMachine(typeof(TSPFVERWKTC<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<b>> JFUIZFOUIUW(IReadOnlyList<YGSDVVMUOEM<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class HRZAWPSPELR<a> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Dictionary<string, EnumChoiceData> KTYVCCLOPMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private List<a> VEGUGPFOECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Func<IEnumerable<a>> VUEIWYQNCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Func<a, string> OFMJTAFWAOR;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyDictionary<string, EnumChoiceData> ANVYDADCSLH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<a> BNOVRNIMWOF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int GLUHBCVCCHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x651C580", Offset = "0x651B580", VA = "0x18651C580")]
		public HRZAWPSPELR(Func<IEnumerable<a>> a, Func<a, string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x651C290", Offset = "0x651B290", VA = "0x18651C290")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x651BE10", Offset = "0x651AE10", VA = "0x18651BE10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KeyValueRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<YGSDVVMUOEM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6922800", Offset = "0x6921800", VA = "0x186922800")]
		public KeyValueRequestBatcher(QTMUXHUDKXU<YGSDVVMUOEM<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] SXWWBJWZSHF taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x69226F0", Offset = "0x69216F0", VA = "0x1869226F0")]
		public Task<TResult> DIIQJLIKOKS(TItemId a, int b, [Optional] CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class YGSDVVMUOEM<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public a QSCTZZATPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int MMKUUPYFDOX;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x50D8D70", Offset = "0x50D7D70", VA = "0x1850D8D70")]
		public YGSDVVMUOEM(a a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface TLSHMQOMKWP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Guid HJACLHWOGSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Task<a> THVMHKDQLSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class DEUGYCCIQAL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private interface EJNJVVOZOGV
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			int KDXKZNRYOPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool ANSVCMIZHTK<a>(a a);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			bool ANGPAWTVSRU(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool TDPDZYNJYMS();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class ECLYJBDGBLI<b> : EJNJVVOZOGV, TLSHMQOMKWP<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly TaskCompletionSource<b> PDNOXLFCWJK;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Guid HJACLHWOGSS
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int KDXKZNRYOPV
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Task<b> THVMHKDQLSD
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5B344E0", Offset = "0x5B334E0", VA = "0x185B344E0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5B34750", Offset = "0x5B33750", VA = "0x185B34750")]
			public ECLYJBDGBLI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x37D5D40", Offset = "0x37D4D40", VA = "0x1837D5D40", Slot = "5")]
			public bool ANSVCMIZHTK<a>(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5B34480", Offset = "0x5B33480", VA = "0x185B34480", Slot = "6")]
			public bool ANGPAWTVSRU(Exception a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5B34580", Offset = "0x5B33580", VA = "0x185B34580", Slot = "7")]
			public bool TDPDZYNJYMS()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string XQFOJUVHJYH = "Remote player disconnected";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<Guid, EJNJVVOZOGV> AUHGKKLURHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly YHYUCUBONBO HNVKTTABKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool PFNHZSFPJVM;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1AEFA0", Offset = "0xA1ADFA0", VA = "0x18A1AEFA0")]
		public DEUGYCCIQAL([Optional] YHYUCUBONBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE8C0", Offset = "0xA1AD8C0", VA = "0x18A1AE8C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x38F2480", Offset = "0x38F1480", VA = "0x1838F2480")]
		public TLSHMQOMKWP<a> SWVYQIPLLEZ<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x38F2810", Offset = "0x38F1810", VA = "0x1838F2810")]
		public bool UYKADLUTGIX<b>(Guid a, b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1AEE90", Offset = "0xA1ADE90", VA = "0x18A1AEE90")]
		private void SGDEDOXLPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE8C0", Offset = "0xA1AD8C0", VA = "0x18A1AE8C0")]
		private void LMGWSPXCURC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1AEBC0", Offset = "0xA1ADBC0", VA = "0x18A1AEBC0")]
		private void OnPhotonPlayerDisconnected(int recNetAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1AE9C0", Offset = "0xA1AD9C0", VA = "0x18A1AE9C0")]
		private void LHLTYTMMKWJ()
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
	public class YZQCWRXTJUX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class SZXXUADFVPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int PDKFKYXGFWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int NOKOUHVTMBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int UXMNPKVNHYA;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SZXXUADFVPV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public a QSCTZZATPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int MMKUUPYFDOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public InventoryItemSource GWJIKPBWSOP;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC8E20", Offset = "0x1CC7E20", VA = "0x181CC8E20")]
		public YZQCWRXTJUX(a a, int b, InventoryItemSource c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RoomInventoryItemAnalyticsEventRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<YZQCWRXTJUX<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B020", Offset = "0x7A9A020", VA = "0x187A9B020")]
		public RoomInventoryItemAnalyticsEventRequestBatcher(QTMUXHUDKXU<YZQCWRXTJUX<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, [Optional] SXWWBJWZSHF taskDelay)
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

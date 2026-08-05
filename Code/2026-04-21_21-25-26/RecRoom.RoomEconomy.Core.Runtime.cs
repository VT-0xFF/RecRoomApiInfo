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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1BB2F0", Offset = "0xA1B9CF0", VA = "0x18A1BB2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BWDZXFMXGGM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task Delay(int milliseconds, CancellationToken cancellationToken);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task Delay(TimeSpan timespan, CancellationToken cancellationToken);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OFQEBYBIWOD : BWDZXFMXGGM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1BB430", Offset = "0xA1B9E30", VA = "0x18A1BB430")]
	[CXDXQIFYXBD.Root.GameOnly]
	internal static void EOQBVPFENUW(MZEBANDYSXL a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFQEBYBIWOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA1BB3D0", Offset = "0xA1B9DD0", VA = "0x18A1BB3D0", Slot = "4")]
	public Task Delay(int milliseconds, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xA1BB370", Offset = "0xA1B9D70", VA = "0x18A1BB370", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1BB6A0", Offset = "0xA1BA0A0", VA = "0x18A1BB6A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomEconomy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class YXIUTYWJOYW : LMWXDRHVVXX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private JZGXCOSWSBO FVNIYLPVSBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly JWTXVKXGCNX<bool> PRWGOBNVJVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly JWTXVKXGCNX<bool> PXZQQONWYIC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CNIIWPVWULY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1BB560", Offset = "0xA1B9F60", VA = "0x18A1BB560", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AFDXLWYCTHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA1BB510", Offset = "0xA1B9F10", VA = "0x18A1BB510", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1BB4A0", Offset = "0xA1B9EA0", VA = "0x18A1BB4A0")]
		[CXDXQIFYXBD.Root.GameOnly]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1BB5B0", Offset = "0xA1B9FB0", VA = "0x18A1BB5B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public YXIUTYWJOYW([Inject(null)][NotNull] JZGXCOSWSBO statsigCachedValueFactory)
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
			[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B7A3A0", Offset = "0x6B78DA0", VA = "0x186B7A3A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6B7AC50", Offset = "0x6B79650", VA = "0x186B7AC50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B7CEC0", Offset = "0x6B7B8C0", VA = "0x186B7CEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B7DD70", Offset = "0x6B7C770", VA = "0x186B7DD70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B853A0", Offset = "0x6B83DA0", VA = "0x186B853A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x41F7F00", Offset = "0x41F6900", VA = "0x1841F7F00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C35360", Offset = "0x6C33D60", VA = "0x186C35360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6C35710", Offset = "0x6C34110", VA = "0x186C35710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly CFSIJLNMKAL<TRequest, TResult> DCJRKITABEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly float HNNJTYJSGZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly BWDZXFMXGGM HBBTEZVFXTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly bool TJMKHHXVTSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BatchedAwardRequest> QBBDIMKTGVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly List<BatchedAwardRequest> MBIMPJCLJZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool MGQGYDBQFLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CancellationTokenSource OYTWPRLWVPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource BTQBOVFQXRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Task UKERFZOGAWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private float WIJVEGPBVFW;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11970", Offset = "0xD10370", VA = "0x180D11970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD11930", Offset = "0xD10330", VA = "0x180D11930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8FD0", Offset = "0x4EF79D0", VA = "0x184EF8FD0")]
		public AwardUgcRequestBatcher(CFSIJLNMKAL<TRequest, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] BWDZXFMXGGM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7740", Offset = "0x4EF6140", VA = "0x184EF7740", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8610", Offset = "0x4EF7010", VA = "0x184EF8610")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<QueueRequest>d__18))]
		public Task<TResult> TGOUSAKWSKR(TRequest a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8730", Offset = "0x4EF7130", VA = "0x184EF8730")]
		private void TGOUSAKWSKR(TRequest a, TaskCompletionSource<TResult> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4EF89D0", Offset = "0x4EF73D0", VA = "0x184EF89D0")]
		public Task XIRJWBNUPUY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4EF78E0", Offset = "0x4EF62E0", VA = "0x184EF78E0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ScheduleBatchProcess>d__21))]
		private Task EOLPGULGPGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4EF81F0", Offset = "0x4EF6BF0", VA = "0x184EF81F0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsDelayed>d__22))]
		private Task QKPGKZWMJZJ(CancellationToken a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7FD0", Offset = "0x4EF69D0", VA = "0x184EF7FD0")]
		[AsyncStateMachine(typeof(AwardUgcRequestBatcher<, >.<ProcessPendingRequestsImmediate>d__23))]
		private Task NKXYGRVUVQM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4EF8B50", Offset = "0x4EF7550", VA = "0x184EF8B50")]
		private TimeSpan YSDXLZPDRGI()
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7CC0", Offset = "0x4EF66C0", VA = "0x184EF7CC0")]
		private Task<List<TResult>> MPWJDOHFLVC(IReadOnlyList<TRequest> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7C20", Offset = "0x4EF6620", VA = "0x184EF7C20")]
		private float MIRYAVRTSZL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7AA0", Offset = "0x4EF64A0", VA = "0x184EF7AA0")]
		private void GQHDQDDBDBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ANRYDGRTWRU<a, b> : CFSIJLNMKAL<MCNXQKMQGVP<a>, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<Dictionary<a, b>> ServiceCall(Dictionary<a, int> requests, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Dictionary<a, b> LHBAJVHMHTX;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x636A840", Offset = "0x6369240", VA = "0x18636A840")]
			internal b OXUFULLBARC(MCNXQKMQGVP<a> a)
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
			public IReadOnlyList<MCNXQKMQGVP<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public ANRYDGRTWRU<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private FXRJPUNQTQT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6584370", Offset = "0x6582D70", VA = "0x186584370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6585A90", Offset = "0x6584490", VA = "0x186585A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly ServiceCall LKSAFOXEYTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly IEqualityComparer<a> YEOGIWBECFI;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72DDAD0", Offset = "0x72DC4D0", VA = "0x1872DDAD0")]
		public ANRYDGRTWRU(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72DD2D0", Offset = "0x72DBCD0", VA = "0x1872DD2D0", Slot = "4")]
		[AsyncStateMachine(typeof(ANRYDGRTWRU<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> YNVPOXDNSGP(IReadOnlyList<MCNXQKMQGVP<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class UJIJGAQUNFP<a, b> : CFSIJLNMKAL<a, b> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<List<b>> ServiceCall(IEnumerable<a> ids, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Dictionary<a, b> LTCTZNWKTEZ;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x636A400", Offset = "0x6368E00", VA = "0x18636A400")]
			internal b OXUFULLBARC(a a)
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
			public UJIJGAQUNFP<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private FXRJPUNQTQT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<a> <distinctRequests>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<List<b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6582BA0", Offset = "0x65815A0", VA = "0x186582BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6585CD0", Offset = "0x65846D0", VA = "0x186585CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly ServiceCall LKSAFOXEYTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IEqualityComparer<a> YEOGIWBECFI;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E27410", Offset = "0x7E25E10", VA = "0x187E27410")]
		public UJIJGAQUNFP(ServiceCall a, [Optional] IEqualityComparer<a> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E27170", Offset = "0x7E25B70", VA = "0x187E27170", Slot = "4")]
		[AsyncStateMachine(typeof(UJIJGAQUNFP<, >.<BatchRequestsAndMakeServiceCall>d__4))]
		public Task<List<b>> YNVPOXDNSGP(IReadOnlyList<a> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface CFSIJLNMKAL<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<List<b>> YNVPOXDNSGP(IReadOnlyList<a> a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class TCHPXNIRUTJ<a, b> : CFSIJLNMKAL<NBIYTWXPXHI<a>, object> where a : IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate Task AnalyticEventCall(IReadOnlyDictionary<a, NBIYTWXPXHI<a>.BAEOBDAHXRO> requests, CancellationToken cancellationToken);

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
			public TCHPXNIRUTJ<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public IReadOnlyList<NBIYTWXPXHI<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x657E5F0", Offset = "0x657CFF0", VA = "0x18657E5F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6580E20", Offset = "0x657F820", VA = "0x186580E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly AnalyticEventCall KXVSSHZSGYO;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public TCHPXNIRUTJ(AnalyticEventCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B49470", Offset = "0x7B47E70", VA = "0x187B49470", Slot = "4")]
		[AsyncStateMachine(typeof(TCHPXNIRUTJ<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<object>> YNVPOXDNSGP(IReadOnlyList<NBIYTWXPXHI<a>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B488C0", Offset = "0x7B472C0", VA = "0x187B488C0")]
		private IReadOnlyDictionary<a, NBIYTWXPXHI<a>.BAEOBDAHXRO> QSKKUGKTWXW(IReadOnlyList<NBIYTWXPXHI<a>> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class IHLHGOEVLRT<a, b> : CFSIJLNMKAL<MCNXQKMQGVP<a>, b> where a : IEquatable<a>
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
			public IReadOnlyList<MCNXQKMQGVP<a>> requests;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public IHLHGOEVLRT<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter<Dictionary<a, b>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6580120", Offset = "0x657EB20", VA = "0x186580120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6580C40", Offset = "0x657F640", VA = "0x186580C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly ServiceCall YOCTLCWCTHL;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public IHLHGOEVLRT(ServiceCall a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x664A230", Offset = "0x6648C30", VA = "0x18664A230", Slot = "4")]
		[AsyncStateMachine(typeof(IHLHGOEVLRT<, >.<BatchRequestsAndMakeServiceCall>d__3))]
		public Task<List<b>> YNVPOXDNSGP(IReadOnlyList<MCNXQKMQGVP<a>> a, CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class RMSGZYDYCTW<a> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Dictionary<string, EnumChoiceData> TALSHRXDLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private List<a> GVVXQCBFLFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Func<IEnumerable<a>> CQTSIUZEXMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Func<a, string> AKAIQSDFNYS;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyDictionary<string, EnumChoiceData> ZECJMOMHRGW
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IReadOnlyList<a> NRFZYMHMNYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CLFMPLFYWJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x776A020", Offset = "0x7768A20", VA = "0x18776A020")]
		public RMSGZYDYCTW(Func<IEnumerable<a>> a, Func<a, string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7769D30", Offset = "0x7768730", VA = "0x187769D30")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7769930", Offset = "0x7768330", VA = "0x187769930", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class KeyValueRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<MCNXQKMQGVP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x693FA70", Offset = "0x693E470", VA = "0x18693FA70")]
		public KeyValueRequestBatcher(CFSIJLNMKAL<MCNXQKMQGVP<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, bool retryOnServiceCallException, [Optional] BWDZXFMXGGM taskDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x693F650", Offset = "0x693E050", VA = "0x18693F650")]
		public Task<TResult> TGOUSAKWSKR(TItemId a, int b, [Optional] CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MCNXQKMQGVP<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public a APSDCFKLACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int LKLXZNJDACQ;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6FDCBD0", Offset = "0x6FDB5D0", VA = "0x186FDCBD0")]
		public MCNXQKMQGVP(a a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface NPQBITEYEIA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		Guid ZMREUECRYNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Task<a> KAYKWUFNIUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LLMGCDXPOBG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private interface KXSOKZCZJXY
		{
			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			int RBKHRQFQMTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "1")]
			bool KJOIGSSFVYP<a>(a a);

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "2")]
			bool UBHUIOIYPQP(Exception a);

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "3")]
			bool FMPOXEZPMSF();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class LZDXNVPFFZZ<b> : KXSOKZCZJXY, NPQBITEYEIA<b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private readonly TaskCompletionSource<b> UQKVQPZKLZH;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public Guid ZMREUECRYNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int RBKHRQFQMTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public Task<b> KAYKWUFNIUY
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x69AC270", Offset = "0x69AAC70", VA = "0x1869AC270", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x69AC470", Offset = "0x69AAE70", VA = "0x1869AC470")]
			public LZDXNVPFFZZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x39F9030", Offset = "0x39F7A30", VA = "0x1839F9030", Slot = "5")]
			public bool KJOIGSSFVYP<a>(a a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x69AC1D0", Offset = "0x69AABD0", VA = "0x1869AC1D0", Slot = "6")]
			public bool UBHUIOIYPQP(Exception a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x69AC090", Offset = "0x69AAA90", VA = "0x1869AC090", Slot = "7")]
			public bool FMPOXEZPMSF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string HOHMFDBTBZK = "Remote player disconnected";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<Guid, KXSOKZCZJXY> LFMSDXDREAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly VQYNSOIJNAN OSEQFMFVURP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool BOFNYBIEHLX;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1BB200", Offset = "0xA1B9C00", VA = "0x18A1BB200")]
		public LLMGCDXPOBG([Optional] VQYNSOIJNAN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BAD20", Offset = "0xA1B9720", VA = "0x18A1BAD20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C16F10", Offset = "0x3C15910", VA = "0x183C16F10")]
		public NPQBITEYEIA<a> AOIDTQDQRQO<a>(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3C16B10", Offset = "0x3C15510", VA = "0x183C16B10")]
		public bool ABNZJNEXEFC<b>(Guid a, b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BB0F0", Offset = "0xA1B9AF0", VA = "0x18A1BB0F0")]
		private void XZVKDYVMQUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BAD20", Offset = "0xA1B9720", VA = "0x18A1BAD20")]
		private void DQSIXCSRVMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BAE20", Offset = "0xA1B9820", VA = "0x18A1BAE20")]
		private void OnPhotonPlayerDisconnected(int recNetAccountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1BAB20", Offset = "0xA1B9520", VA = "0x18A1BAB20")]
		private void ANHMDBNTANC()
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
	public class NBIYTWXPXHI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public class BAEOBDAHXRO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public int RZHDVCYZXAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int UWOSHJHFVRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int STRQTJUXKXJ;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BAEOBDAHXRO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public a APSDCFKLACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int LKLXZNJDACQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public InventoryItemSource ZXBYZQEQXGM;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E950", Offset = "0x1D0D350", VA = "0x181D0E950")]
		public NBIYTWXPXHI(a a, int b, InventoryItemSource c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class RoomInventoryItemAnalyticsEventRequestBatcher<TItemId, TResult> : AwardUgcRequestBatcher<NBIYTWXPXHI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x79E2760", Offset = "0x79E1160", VA = "0x1879E2760")]
		public RoomInventoryItemAnalyticsEventRequestBatcher(CFSIJLNMKAL<NBIYTWXPXHI<TItemId>, TResult> batcherStrategy, TimeSpan cooldownTime, [Optional] BWDZXFMXGGM taskDelay)
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

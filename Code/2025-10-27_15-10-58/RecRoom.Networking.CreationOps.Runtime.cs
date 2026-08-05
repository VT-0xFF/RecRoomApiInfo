using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.Core.Creation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking.DataTypes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_CreationOps_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking.CreationOps
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class BBODDBONFIC<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		protected class JWTHILGZUUP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private readonly Dictionary<int, PendingRequest> MUIHFSNHZXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DateTime EPPOSPLMKBZ;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5444D70", Offset = "0x5443D70", VA = "0x185444D70")]
			public void YIXMZIIZGCI(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5444830", Offset = "0x5443830", VA = "0x185444830")]
			public void FDTQZQFUKNP(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5444940", Offset = "0x5443940", VA = "0x185444940")]
			public bool MZLFWALGUTA(int a, [Out] PendingRequest b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x54448D0", Offset = "0x54438D0", VA = "0x1854448D0")]
			public int FKKFIUJIXHE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5444C40", Offset = "0x5443C40", VA = "0x185444C40")]
			public TimeSpan QHNXENLTVZR([Optional] DateTime? a)
			{
				return default(TimeSpan);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5445110", Offset = "0x5444110", VA = "0x185445110")]
			public JWTHILGZUUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		protected readonly struct PendingRequest
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly int RequestId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public readonly CreationOp CreationOp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public readonly TaskCompletionSource<a> TaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public readonly DateTime RequestStartTime;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5DDFCE0", Offset = "0x5DDECE0", VA = "0x185DDFCE0")]
			public PendingRequest(int requestId, CreationOp creationOp, TaskCompletionSource<a> taskCompletionSource, DateTime requestStartTime)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const byte ICIDMDEKVZX = 1;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const byte DUJLRSHLSKK = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const byte MDQSTQATCVT = 3;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const byte WDZMBPWVHYK = 4;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const byte OWSUVVXJLUI = 5;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const byte KDGPSGUMAKV = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly JWTHILGZUUP GOPEAOAKNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly CreationOp NRBOUIBJKBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly bool OFDFIICXWEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly CGXCTBBTSQC XATNJPLCUAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly CancellationTokenSource SEVRBOZHHXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int PLKIODSHTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OpRateLimitInfo BTSUYBVEQGC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected int FRMAQMREBTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x745DEC0", Offset = "0x745CEC0", VA = "0x18745DEC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected NetworkEventCode FADEMZBNNCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x745DEA0", Offset = "0x745CEA0", VA = "0x18745DEA0")]
			get
			{
				return default(NetworkEventCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x745E9F0", Offset = "0x745D9F0", VA = "0x18745E9F0")]
		public BBODDBONFIC(CreationOp a, CGXCTBBTSQC b, [Optional] OpRateLimitInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x745E5F0", Offset = "0x745D5F0", VA = "0x18745E5F0")]
		internal bool ZTCHNEGQOWQ(CreationOp a, DateTime b, [Out] CreationResult c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x745E1B0", Offset = "0x745D1B0", VA = "0x18745E1B0")]
		private bool YNIEKOAIFMO(CreationOp a, DateTime b, OpRateLimitInfo c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		internal abstract void CHFLYAHFGTG(IRRSNCQWIPE a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x745DC60", Offset = "0x745CC60", VA = "0x18745DC60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZBDBITIEVZC : BBODDBONFIC<CreationOpResponse>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public delegate Task<CreationOpResponse> HandleOperation(int senderId, byte[] messagePayload, CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <HandleRequest>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IDictionary<object, object> eventData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ZBDBITIEVZC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CreationOp <op>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int <requestId>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private byte[] <data>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<CreationOpResponse> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8807DF0", Offset = "0x8806DF0", VA = "0x188807DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x88085B0", Offset = "0x88075B0", VA = "0x1888085B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <SendCreationOpToMaster>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<CreationOpResponse> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public ZBDBITIEVZC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TimeSpan? requestTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public byte[] payload;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public string requesterToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private PendingRequest <pendingRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<CreationOpResponse> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8808610", Offset = "0x8807610", VA = "0x188808610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8808FA0", Offset = "0x8807FA0", VA = "0x188808FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly GWGBIKXISIV OLMQGQPWOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HandleOperation QETJJZWKJUJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8809D00", Offset = "0x8808D00", VA = "0x188809D00")]
		public ZBDBITIEVZC(CreationOp a, CGXCTBBTSQC b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E180", Offset = "0x3F6D180", VA = "0x183F6E180")]
		public Task<CreationOpResponse> BHXYIGTWCVI<a>(string a, a b, [Optional] TimeSpan? c) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8809010", Offset = "0x8808010", VA = "0x188809010")]
		[AsyncStateMachine(typeof(<SendCreationOpToMaster>d__5))]
		public Task<CreationOpResponse> BHXYIGTWCVI(string a, byte[] b, [Optional] TimeSpan? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8809160", Offset = "0x8808160", VA = "0x188809160", Slot = "5")]
		internal override void CHFLYAHFGTG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88096F0", Offset = "0x88086F0", VA = "0x1888096F0")]
		[AsyncStateMachine(typeof(<HandleRequest>d__7))]
		private Task KRGTFXCKPCQ(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8809A90", Offset = "0x8808A90", VA = "0x188809A90")]
		private void PVWCUTHPPCQ(int a, CreationOp b, int c, CreationOpResponse d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8809820", Offset = "0x8808820", VA = "0x188809820")]
		private void PKTBYCPLXOM(IDictionary<object, object> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class HKSGBUZJDCB<a, b> : BBODDBONFIC<b> where a : IMessage<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate Task<b> HandleOperation(int senderId, a messagePayload, CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <HandleMessage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IDictionary<object, object> eventData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HKSGBUZJDCB<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int senderId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private CreationOp <op>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private PendingRequest <localPendingRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool <isOurRequest>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5300F20", Offset = "0x52FFF20", VA = "0x185300F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x53020B0", Offset = "0x53010B0", VA = "0x1853020B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <SendCreationOpMessage>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder<b> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public a data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public HKSGBUZJDCB<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public TimeSpan? requestTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public string requesterToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public bool isRoomBuffered;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private PendingRequest <pendingRequest>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x55325D0", Offset = "0x55315D0", VA = "0x1855325D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5534500", Offset = "0x5533500", VA = "0x185534500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HandleOperation QETJJZWKJUJ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x526C260", Offset = "0x526B260", VA = "0x18526C260")]
		public HKSGBUZJDCB(CreationOp a, CGXCTBBTSQC b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x526B240", Offset = "0x526A240", VA = "0x18526B240")]
		[AsyncStateMachine(typeof(HKSGBUZJDCB<, >.<SendCreationOpMessage>d__3))]
		public Task<b> AKRUNKQVRQY(string a, a b, [Optional] TimeSpan? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x526BF20", Offset = "0x526AF20", VA = "0x18526BF20")]
		public void PZFVXOPFNLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x526B780", Offset = "0x526A780", VA = "0x18526B780", Slot = "5")]
		internal override void CHFLYAHFGTG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x526BDE0", Offset = "0x526ADE0", VA = "0x18526BDE0")]
		[AsyncStateMachine(typeof(HKSGBUZJDCB<, >.<HandleMessage>d__6))]
		private Task NTTNRUYCFPE(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class SSNWXCQCFMY
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly List<CreationOp> BJFEOISMEJU;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly TimeSpan VCLPKEZXQWO;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly TimeSpan LBXZKUIYQJZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum CreationOp
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Invalid = 0,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SpawnInvention = 100,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		SpawnObject = 101,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Paste = 102,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Clone = 103,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		DeleteAll = 104,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Circuits = 105,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Circuits_SkipCheck = 106,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		BuiltInTooling = 200,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		BuiltInTooling_SkipCheck = 201
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CreationOpResponse
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly CreationResult CreationResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NYNMQIJRVPC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1D2CE40", Offset = "0x1D2BE40", VA = "0x181D2CE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1A340D0", Offset = "0x1A330D0", VA = "0x181A340D0")]
		public CreationOpResponse(CreationResult creationResult, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8807AE0", Offset = "0x8806AE0", VA = "0x188807AE0")]
		public static CreationOpResponse Failure(CreationResult result)
		{
			return default(CreationOpResponse);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct OpRateLimitInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly bool AllowsMultipleRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool IgnoreRateLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly TimeSpan? CustomMinimumInterval;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8807B70", Offset = "0x8806B70", VA = "0x188807B70")]
		public OpRateLimitInfo(bool allowsMultipleRequests, bool ignoreRateLimit, [Optional] TimeSpan? customMinimumInterval)
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

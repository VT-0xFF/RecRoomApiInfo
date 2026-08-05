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
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking.CreationOps
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class LUZERZMNQOD<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		protected class DDWROZIQLRS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private readonly Dictionary<int, PendingRequest> ZNHYTOPNQYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DateTime ZHUDIQYNTPA;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x53ADE00", Offset = "0x53AC800", VA = "0x1853ADE00")]
			public void HWCXPKWAOQF(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x53ADF50", Offset = "0x53AC950", VA = "0x1853ADF50")]
			public void HXUSYICGGAC(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x53ADF80", Offset = "0x53AC980", VA = "0x1853ADF80")]
			public bool IFWKOABDYRH(int a, [Out] PendingRequest b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x53AD810", Offset = "0x53AC210", VA = "0x1853AD810")]
			public int AWBWVKAKFSZ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x53AD9B0", Offset = "0x53AC3B0", VA = "0x1853AD9B0")]
			public TimeSpan EHNGIEHDFQE([Optional] DateTime? a)
			{
				return default(TimeSpan);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x53AE1C0", Offset = "0x53ACBC0", VA = "0x1853AE1C0")]
			public DDWROZIQLRS()
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
			[Cpp2IlInjected.Address(RVA = "0x7419BC0", Offset = "0x74185C0", VA = "0x187419BC0")]
			public PendingRequest(int requestId, CreationOp creationOp, TaskCompletionSource<a> taskCompletionSource, DateTime requestStartTime)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const byte QZUZRPCWDFI = 1;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const byte SOXLGHPCEKX = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const byte AMOVYPPEMTK = 3;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const byte PYENYBXHCJN = 4;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const byte RSPYJEFQFWF = 5;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const byte YMDYSWZWHNC = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly DDWROZIQLRS WVBACRUUFXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly CreationOp MNYSPZPDQDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly bool UTLVSXLGHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly GXLSEMXVYCP OGUPRCWALTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly CancellationTokenSource PDRVZTECOIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int KUSWKGQVUTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OpRateLimitInfo IHYXJLUHXKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected int SPIADBWENON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x68F0130", Offset = "0x68EEB30", VA = "0x1868F0130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected NetworkEventCode ZMGPUSRYYAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x68F0380", Offset = "0x68EED80", VA = "0x1868F0380")]
			get
			{
				return default(NetworkEventCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68F0EC0", Offset = "0x68EF8C0", VA = "0x1868F0EC0")]
		public LUZERZMNQOD(CreationOp a, GXLSEMXVYCP b, [Optional] OpRateLimitInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68F0490", Offset = "0x68EEE90", VA = "0x1868F0490")]
		internal bool PTCNAYOWWXD(CreationOp a, DateTime b, [Out] CreationResult c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68F0870", Offset = "0x68EF270", VA = "0x1868F0870")]
		private bool XSFEXAUDUYR(CreationOp a, DateTime b, OpRateLimitInfo c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		internal abstract void MZPDYTEMTXD(EPOORIVUAQX a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68F02C0", Offset = "0x68EECC0", VA = "0x1868F02C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HOZDSDHXZCP : LUZERZMNQOD<CreationOpResponse>
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
			public HOZDSDHXZCP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9AB64A0", Offset = "0x9AB4EA0", VA = "0x189AB64A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6C60", Offset = "0x9AB5660", VA = "0x189AB6C60", Slot = "5")]
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
			public HOZDSDHXZCP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9AB6CC0", Offset = "0x9AB56C0", VA = "0x189AB6CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB76D0", Offset = "0x9AB60D0", VA = "0x189AB76D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly CBEOKZVPQNC VFTBRXRWEUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HandleOperation FUDPOHINIIQ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6160", Offset = "0x9AB4B60", VA = "0x189AB6160")]
		public HOZDSDHXZCP(CreationOp a, GXLSEMXVYCP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B23AC0", Offset = "0x3B224C0", VA = "0x183B23AC0")]
		public Task<CreationOpResponse> DNWTIARDDON<a>(string a, a b, [Optional] TimeSpan? c) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5510", Offset = "0x9AB3F10", VA = "0x189AB5510")]
		[AsyncStateMachine(typeof(<SendCreationOpToMaster>d__5))]
		public Task<CreationOpResponse> DNWTIARDDON(string a, byte[] b, [Optional] TimeSpan? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5B40", Offset = "0x9AB4540", VA = "0x189AB5B40", Slot = "5")]
		internal override void MZPDYTEMTXD(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AB53E0", Offset = "0x9AB3DE0", VA = "0x189AB53E0")]
		[AsyncStateMachine(typeof(<HandleRequest>d__7))]
		private Task ATBDOCWAPLP(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AB58D0", Offset = "0x9AB42D0", VA = "0x189AB58D0")]
		private void KCSMSDTKWBT(int a, CreationOp b, int c, CreationOpResponse d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5660", Offset = "0x9AB4060", VA = "0x189AB5660")]
		private void IEFSXIRUGHL(IDictionary<object, object> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JDLJVPYSLVS<a, b> : LUZERZMNQOD<b> where a : IMessage<a>
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
			public JDLJVPYSLVS<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x69C22D0", Offset = "0x69C0CD0", VA = "0x1869C22D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69C29F0", Offset = "0x69C13F0", VA = "0x1869C29F0", Slot = "5")]
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
			public JDLJVPYSLVS<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6C7AE70", Offset = "0x6C79870", VA = "0x186C7AE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BA40", Offset = "0x6C7A440", VA = "0x186C7BA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HandleOperation FUDPOHINIIQ;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66CEB60", Offset = "0x66CD560", VA = "0x1866CEB60")]
		public JDLJVPYSLVS(CreationOp a, GXLSEMXVYCP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x66CE270", Offset = "0x66CCC70", VA = "0x1866CE270")]
		[AsyncStateMachine(typeof(JDLJVPYSLVS<, >.<SendCreationOpMessage>d__3))]
		public Task<b> WBUDMIFHISN(string a, a b, [Optional] TimeSpan? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66CE920", Offset = "0x66CD320", VA = "0x1866CE920")]
		public void XIDZWRVXNEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66CDD50", Offset = "0x66CC750", VA = "0x1866CDD50", Slot = "5")]
		internal override void MZPDYTEMTXD(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66CDC10", Offset = "0x66CC610", VA = "0x1866CDC10")]
		[AsyncStateMachine(typeof(JDLJVPYSLVS<, >.<HandleMessage>d__6))]
		private Task GWBMXSCSNMT(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class SWHHPWMTVSV
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly List<CreationOp> YVPMLZANWFP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly TimeSpan XVBFLSWTEOT;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly TimeSpan HTXHIRYYKDS;
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
		public bool OEGRWQTXUVL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1CDF9B0", Offset = "0x1CDE3B0", VA = "0x181CDF9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19C1B20", Offset = "0x19C0520", VA = "0x1819C1B20")]
		public CreationOpResponse(CreationResult creationResult, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5350", Offset = "0x9AB3D50", VA = "0x189AB5350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AB6220", Offset = "0x9AB4C20", VA = "0x189AB6220")]
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

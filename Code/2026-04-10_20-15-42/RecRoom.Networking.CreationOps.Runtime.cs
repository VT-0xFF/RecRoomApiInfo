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
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking.CreationOps
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class DIUHEFHSXCV<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		protected class XSUQUSOUNPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private readonly Dictionary<int, PendingRequest> TOMPSCHUAFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DateTime XREJWMDZPDC;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5121BA0", Offset = "0x5120BA0", VA = "0x185121BA0")]
			public void NLFVKAYGHRJ(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5121C80", Offset = "0x5120C80", VA = "0x185121C80")]
			public void TYGCMRILNMI(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5122120", Offset = "0x5121120", VA = "0x185122120")]
			public bool ZVCNKBTNRED(int a, [Out] PendingRequest b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5121940", Offset = "0x5120940", VA = "0x185121940")]
			public int HEQAFDVEZNR()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5121E50", Offset = "0x5120E50", VA = "0x185121E50")]
			public TimeSpan WCHVNWBDCJI([Optional] DateTime? a)
			{
				return default(TimeSpan);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x51222F0", Offset = "0x51212F0", VA = "0x1851222F0")]
			public XSUQUSOUNPA()
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
			[Cpp2IlInjected.Address(RVA = "0x752D210", Offset = "0x752C210", VA = "0x18752D210")]
			public PendingRequest(int requestId, CreationOp creationOp, TaskCompletionSource<a> taskCompletionSource, DateTime requestStartTime)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const byte TELLGXVMGZS = 1;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const byte KNWVRQMDWND = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const byte DYFSKTYRXFM = 3;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const byte TQNKAXCVPTH = 4;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const byte SYFXUOKCPWT = 5;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const byte GYSWDSHOZDI = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly XSUQUSOUNPA JEUMBLTQGZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly CreationOp QHHBLVKYAUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly bool KNKVXRTWHUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly IDLXRUJKSDP ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly CancellationTokenSource RDMZBDOYDKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int BSNVQKRDHJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OpRateLimitInfo TXUORBJQKHL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected int DBCWMZQFSCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5433500", Offset = "0x5432500", VA = "0x185433500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected NetworkEventCode QTLUUBZECFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5432BD0", Offset = "0x5431BD0", VA = "0x185432BD0")]
			get
			{
				return default(NetworkEventCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5433720", Offset = "0x5432720", VA = "0x185433720")]
		public DIUHEFHSXCV(CreationOp a, IDLXRUJKSDP b, [Optional] OpRateLimitInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5433120", Offset = "0x5432120", VA = "0x185433120")]
		internal bool KCPRNLLAYIH(CreationOp a, DateTime b, [Out] CreationResult c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5432D50", Offset = "0x5431D50", VA = "0x185432D50")]
		private bool FYUXFOYDAHR(CreationOp a, DateTime b, OpRateLimitInfo c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		internal abstract void FGHHYFWTLMH(VZMXLASXEMR a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5432A50", Offset = "0x5431A50", VA = "0x185432A50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class VFYLXPTRJGR : DIUHEFHSXCV<CreationOpResponse>
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
			public VFYLXPTRJGR <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9AE5570", Offset = "0x9AE4570", VA = "0x189AE5570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9AE5D30", Offset = "0x9AE4D30", VA = "0x189AE5D30", Slot = "5")]
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
			public VFYLXPTRJGR <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9AE5D90", Offset = "0x9AE4D90", VA = "0x189AE5D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9AE67A0", Offset = "0x9AE57A0", VA = "0x189AE67A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly SVLVGVMSMLM YYTUHFTTJUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HandleOperation YRAFYMOSLCS;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7590", Offset = "0x9AE6590", VA = "0x189AE7590")]
		public VFYLXPTRJGR(CreationOp a, IDLXRUJKSDP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x40D5AD0", Offset = "0x40D4AD0", VA = "0x1840D5AD0")]
		public Task<CreationOpResponse> ZLMSSWRGDWX<a>(string a, a b, [Optional] TimeSpan? c) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9AE73B0", Offset = "0x9AE63B0", VA = "0x189AE73B0")]
		[AsyncStateMachine(typeof(<SendCreationOpToMaster>d__5))]
		public Task<CreationOpResponse> ZLMSSWRGDWX(string a, byte[] b, [Optional] TimeSpan? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6940", Offset = "0x9AE5940", VA = "0x189AE6940", Slot = "5")]
		internal override void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6810", Offset = "0x9AE5810", VA = "0x189AE6810")]
		[AsyncStateMachine(typeof(<HandleRequest>d__7))]
		private Task BGVBGYGJDAX(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9AE7140", Offset = "0x9AE6140", VA = "0x189AE7140")]
		private void TBWCQNILSQX(int a, CreationOp b, int c, CreationOpResponse d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6ED0", Offset = "0x9AE5ED0", VA = "0x189AE6ED0")]
		private void PTKOANHTMKH(IDictionary<object, object> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class VZFXAYHJZPI<a, b> : DIUHEFHSXCV<b> where a : IMessage<a>
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
			public VZFXAYHJZPI<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6A18D70", Offset = "0x6A17D70", VA = "0x186A18D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6A19430", Offset = "0x6A18430", VA = "0x186A19430", Slot = "5")]
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
			public VZFXAYHJZPI<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x6CCBAC0", Offset = "0x6CCAAC0", VA = "0x186CCBAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6CCDAE0", Offset = "0x6CCCAE0", VA = "0x186CCDAE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HandleOperation YRAFYMOSLCS;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8072600", Offset = "0x8071600", VA = "0x188072600")]
		public VZFXAYHJZPI(CreationOp a, IDLXRUJKSDP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8071C40", Offset = "0x8070C40", VA = "0x188071C40")]
		[AsyncStateMachine(typeof(VZFXAYHJZPI<, >.<SendCreationOpMessage>d__3))]
		public Task<b> CVVXJBKQBEL(string a, a b, [Optional] TimeSpan? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8071580", Offset = "0x8070580", VA = "0x188071580")]
		public void CQPRBJTCEJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8071D90", Offset = "0x8070D90", VA = "0x188071D90", Slot = "5")]
		internal override void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x80723F0", Offset = "0x80713F0", VA = "0x1880723F0")]
		[AsyncStateMachine(typeof(VZFXAYHJZPI<, >.<HandleMessage>d__6))]
		private Task TPJULGHKFDD(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class LMLXJLDMTKH
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly List<CreationOp> BWNIKQIPYFF;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly TimeSpan EZUZFQNJMKB;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly TimeSpan YVBVJZBFSGO;
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
		public bool QBFPHMTBMQT
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1CD2A50", Offset = "0x1CD1A50", VA = "0x181CD2A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19AA8E0", Offset = "0x19A98E0", VA = "0x1819AA8E0")]
		public CreationOpResponse(CreationResult creationResult, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5260", Offset = "0x9AE4260", VA = "0x189AE5260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AE54B0", Offset = "0x9AE44B0", VA = "0x189AE54B0")]
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

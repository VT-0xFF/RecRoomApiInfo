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
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking.CreationOps
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class KRLZYVYNTXJ<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		protected class ONGMZZLFFJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private readonly Dictionary<int, PendingRequest> BZLIXVXYTBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DateTime MOGKREXONVQ;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5987470", Offset = "0x5986870", VA = "0x185987470")]
			public void LQXBEUFNYXT(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x59878E0", Offset = "0x5986CE0", VA = "0x1859878E0")]
			public void ZPABVIHLTXU(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5987970", Offset = "0x5986D70", VA = "0x185987970")]
			public bool ZYDOBPOZCQF(int a, [Out] PendingRequest b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5987210", Offset = "0x5986610", VA = "0x185987210")]
			public int HOCAQYXBMMF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x59877B0", Offset = "0x5986BB0", VA = "0x1859877B0")]
			public TimeSpan LVVLYWOXWKQ([Optional] DateTime? a)
			{
				return default(TimeSpan);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5987A10", Offset = "0x5986E10", VA = "0x185987A10")]
			public ONGMZZLFFJO()
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
			[Cpp2IlInjected.Address(RVA = "0x5A7E5D0", Offset = "0x5A7D9D0", VA = "0x185A7E5D0")]
			public PendingRequest(int requestId, CreationOp creationOp, TaskCompletionSource<a> taskCompletionSource, DateTime requestStartTime)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const byte CZOYAARVMMC = 1;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const byte MLCJWQCVPUD = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const byte FBOBVHQIFTK = 3;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const byte OUPZHABDGYT = 4;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const byte ZIZYDRAORXH = 5;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const byte MFHWZMKYXOM = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly ONGMZZLFFJO TDRVIEHJLJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly CreationOp IHQHWXRLYCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly bool VRAOVMXWIBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly RXXIMXLCZOP THXJFJHLCRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly CancellationTokenSource JKURUVOOQIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int FFDSODPVAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OpRateLimitInfo KZYQRWLMODB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected int CBUBYZMCOIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x52730E0", Offset = "0x52724E0", VA = "0x1852730E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected NetworkEventCode XRQDVOPTEKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5272C20", Offset = "0x5272020", VA = "0x185272C20")]
			get
			{
				return default(NetworkEventCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5273510", Offset = "0x5272910", VA = "0x185273510")]
		public KRLZYVYNTXJ(CreationOp a, RXXIMXLCZOP b, [Optional] OpRateLimitInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5272F00", Offset = "0x5272300", VA = "0x185272F00")]
		internal bool LZTDTBSGRYB(CreationOp a, DateTime b, [Out] CreationResult c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5272880", Offset = "0x5271C80", VA = "0x185272880")]
		private bool BJIMQHRYMXX(CreationOp a, DateTime b, OpRateLimitInfo c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		internal abstract void OKQIWPCSQCV(LEKSKUSYOLN a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5272AA0", Offset = "0x5271EA0", VA = "0x185272AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MIMJZAWHOBB : KRLZYVYNTXJ<CreationOpResponse>
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
			public MIMJZAWHOBB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x82FBCF0", Offset = "0x82FB0F0", VA = "0x1882FBCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x82FC4B0", Offset = "0x82FB8B0", VA = "0x1882FC4B0", Slot = "5")]
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
			public MIMJZAWHOBB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x82FC510", Offset = "0x82FB910", VA = "0x1882FC510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x82FCF20", Offset = "0x82FC320", VA = "0x1882FCF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly YTJXGECMSCM MPWYTHYSQMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HandleOperation OCBYCSPURXS;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82FB9C0", Offset = "0x82FADC0", VA = "0x1882FB9C0")]
		public MIMJZAWHOBB(CreationOp a, RXXIMXLCZOP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37C7E30", Offset = "0x37C7230", VA = "0x1837C7E30")]
		public Task<CreationOpResponse> RXEATCAGKTD<a>(string a, a b, [Optional] TimeSpan? c) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82FB450", Offset = "0x82FA850", VA = "0x1882FB450")]
		[AsyncStateMachine(typeof(<SendCreationOpToMaster>d__5))]
		public Task<CreationOpResponse> RXEATCAGKTD(string a, byte[] b, [Optional] TimeSpan? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82FAEC0", Offset = "0x82FA2C0", VA = "0x1882FAEC0", Slot = "5")]
		internal override void OKQIWPCSQCV(LEKSKUSYOLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82FB810", Offset = "0x82FAC10", VA = "0x1882FB810")]
		[AsyncStateMachine(typeof(<HandleRequest>d__7))]
		private Task WOARYXQGWZD(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82FB5A0", Offset = "0x82FA9A0", VA = "0x1882FB5A0")]
		private void USDJVYHQUGV(int a, CreationOp b, int c, CreationOpResponse d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82FAC50", Offset = "0x82FA050", VA = "0x1882FAC50")]
		private void EBYITURBUGJ(IDictionary<object, object> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OCBELOTUFUY<a, b> : KRLZYVYNTXJ<b> where a : IMessage<a>
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
			public OCBELOTUFUY<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x4FE6920", Offset = "0x4FE5D20", VA = "0x184FE6920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4FE7020", Offset = "0x4FE6420", VA = "0x184FE7020", Slot = "5")]
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
			public OCBELOTUFUY<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x520E7D0", Offset = "0x520DBD0", VA = "0x18520E7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x52107F0", Offset = "0x520FBF0", VA = "0x1852107F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HandleOperation OCBYCSPURXS;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x597A9A0", Offset = "0x5979DA0", VA = "0x18597A9A0")]
		public OCBELOTUFUY(CreationOp a, RXXIMXLCZOP b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x59799A0", Offset = "0x5978DA0", VA = "0x1859799A0")]
		[AsyncStateMachine(typeof(OCBELOTUFUY<, >.<SendCreationOpMessage>d__3))]
		public Task<b> GYRHEUBBSNT(string a, a b, [Optional] TimeSpan? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x597A770", Offset = "0x5979B70", VA = "0x18597A770")]
		public void ZNYNENIQEPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x597A0F0", Offset = "0x59794F0", VA = "0x18597A0F0", Slot = "5")]
		internal override void OKQIWPCSQCV(LEKSKUSYOLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5979E70", Offset = "0x5979270", VA = "0x185979E70")]
		[AsyncStateMachine(typeof(OCBELOTUFUY<, >.<HandleMessage>d__6))]
		private Task OIEWOYLYZTJ(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class RUXWSCJOKWV
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly List<CreationOp> OEBVGOMKVNP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly TimeSpan HUOWJVARZLJ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly TimeSpan NWNJCOQKXSU;
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
		public bool HJHGRYWLEVX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x19D8EB0", Offset = "0x19D82B0", VA = "0x1819D8EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x16B50C0", Offset = "0x16B44C0", VA = "0x1816B50C0")]
		public CreationOpResponse(CreationResult creationResult, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82FABC0", Offset = "0x82F9FC0", VA = "0x1882FABC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82FBA80", Offset = "0x82FAE80", VA = "0x1882FBA80")]
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

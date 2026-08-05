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
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking.CreationOps
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class ZGVABPRIZAT<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		protected class HXHHEBGGYHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private readonly Dictionary<int, PendingRequest> YTGDZKVLLBR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DateTime JMGGTGDBMNQ;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BF10", Offset = "0x4F4B310", VA = "0x184F4BF10")]
			public void VMRKTWDBFXL(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B9E0", Offset = "0x4F4ADE0", VA = "0x184F4B9E0")]
			public void MQQAMCXJUAS(PendingRequest a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C1B0", Offset = "0x4F4B5B0", VA = "0x184F4C1B0")]
			public bool ZFFPSWLEXBT(int a, [Out] PendingRequest b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C110", Offset = "0x4F4B510", VA = "0x184F4C110")]
			public int XMIPJFJVESF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4F4BA70", Offset = "0x4F4AE70", VA = "0x184F4BA70")]
			public TimeSpan TBFIRSWMWUQ([Optional] DateTime? a)
			{
				return default(TimeSpan);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4F4C1E0", Offset = "0x4F4B5E0", VA = "0x184F4C1E0")]
			public HXHHEBGGYHC()
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
			[Cpp2IlInjected.Address(RVA = "0x5A7EE50", Offset = "0x5A7E250", VA = "0x185A7EE50")]
			public PendingRequest(int requestId, CreationOp creationOp, TaskCompletionSource<a> taskCompletionSource, DateTime requestStartTime)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const byte APDDTPIQNHM = 1;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const byte XTCKSAPACCP = 2;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const byte TVSFOMGZQDS = 3;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected const byte NWCFYILBRDN = 4;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected const byte SIGKNOJRXUZ = 5;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected const byte KFCMJVHUEUY = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly HXHHEBGGYHC YJLGLHBWJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly CreationOp RHLJKYHBUIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly bool JNEXLDUNPVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly HFLLGBMWIHF UGOVYLDDXNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly CancellationTokenSource UVZUFTINRYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int MJIFPHEYPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly OpRateLimitInfo YGKHHWVXEZJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected int TRKIIFILKPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3F00680", Offset = "0x3EFFA80", VA = "0x183F00680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected NetworkEventCode DOIHOQONYNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3F00690", Offset = "0x3EFFA90", VA = "0x183F00690")]
			get
			{
				return default(NetworkEventCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F00750", Offset = "0x3EFFB50", VA = "0x183F00750")]
		public ZGVABPRIZAT(CreationOp a, HFLLGBMWIHF b, [Optional] OpRateLimitInfo c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F00340", Offset = "0x3EFF740", VA = "0x183F00340")]
		internal bool FLNASHWJOFP(CreationOp a, DateTime b, [Out] CreationResult c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F00520", Offset = "0x3EFF920", VA = "0x183F00520")]
		private bool MGNKTEPWPYN(CreationOp a, DateTime b, OpRateLimitInfo c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		internal abstract void FUUJLGJITVX(PTKTLSUVJWP a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3F00280", Offset = "0x3EFF680", VA = "0x183F00280", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class VQWJTBEVEST : ZGVABPRIZAT<CreationOpResponse>
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
			public VQWJTBEVEST <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x836D0B0", Offset = "0x836C4B0", VA = "0x18836D0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x836D860", Offset = "0x836CC60", VA = "0x18836D860", Slot = "5")]
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
			public VQWJTBEVEST <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x836D8C0", Offset = "0x836CCC0", VA = "0x18836D8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x836E240", Offset = "0x836D640", VA = "0x18836E240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly FRDJWLZNOWA DKBAVNHONUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly HandleOperation TNZGBKWAISE;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x836EF70", Offset = "0x836E370", VA = "0x18836EF70")]
		public VQWJTBEVEST(CreationOp a, HFLLGBMWIHF b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBFE0", Offset = "0x3BEB3E0", VA = "0x183BEBFE0")]
		public Task<CreationOpResponse> YMYYRTYXAAF<a>(string a, a b, [Optional] TimeSpan? c) where a : IMessage<a>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x836EDA0", Offset = "0x836E1A0", VA = "0x18836EDA0")]
		[AsyncStateMachine(typeof(<SendCreationOpToMaster>d__5))]
		public Task<CreationOpResponse> YMYYRTYXAAF(string a, byte[] b, [Optional] TimeSpan? c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x836E3E0", Offset = "0x836D7E0", VA = "0x18836E3E0", Slot = "5")]
		internal override void FUUJLGJITVX(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x836E2B0", Offset = "0x836D6B0", VA = "0x18836E2B0")]
		[AsyncStateMachine(typeof(<HandleRequest>d__7))]
		private Task DVRXRUMFOMB(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x836EBC0", Offset = "0x836DFC0", VA = "0x18836EBC0")]
		private void WAJQRRWESRT(int a, CreationOp b, int c, CreationOpResponse d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x836E960", Offset = "0x836DD60", VA = "0x18836E960")]
		private void KSZSIRLKQDL(IDictionary<object, object> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OQVMOUDNVEM<a, b> : ZGVABPRIZAT<b> where a : IMessage<a>
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
			public OQVMOUDNVEM<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x50436C0", Offset = "0x5042AC0", VA = "0x1850436C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5044820", Offset = "0x5043C20", VA = "0x185044820", Slot = "5")]
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
			public OQVMOUDNVEM<a, b> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5287C40", Offset = "0x5287040", VA = "0x185287C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5288740", Offset = "0x5287B40", VA = "0x185288740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HandleOperation TNZGBKWAISE;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5992F80", Offset = "0x5992380", VA = "0x185992F80")]
		public OQVMOUDNVEM(CreationOp a, HFLLGBMWIHF b, HandleOperation c, [Optional] OpRateLimitInfo d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5992380", Offset = "0x5991780", VA = "0x185992380")]
		[AsyncStateMachine(typeof(OQVMOUDNVEM<, >.<SendCreationOpMessage>d__3))]
		public Task<b> BZJZXVWNLTX(string a, a b, [Optional] TimeSpan? c, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5992C40", Offset = "0x5992040", VA = "0x185992C40")]
		public void VFRUFGSRMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x59926E0", Offset = "0x5991AE0", VA = "0x1859926E0", Slot = "5")]
		internal override void FUUJLGJITVX(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x59929C0", Offset = "0x5991DC0", VA = "0x1859929C0")]
		[AsyncStateMachine(typeof(OQVMOUDNVEM<, >.<HandleMessage>d__6))]
		private Task HVRPIDIBJLV(int a, IDictionary<object, object> b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class KIKLYCJVRYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly List<CreationOp> WQUIOXNYOHD;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly TimeSpan SYQKEMDIDRB;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly TimeSpan MLDGBCXENCA;
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
		public bool IINYCGRTWJL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1990D30", Offset = "0x1990130", VA = "0x181990D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1662AD0", Offset = "0x1661ED0", VA = "0x181662AD0")]
		public CreationOpResponse(CreationResult creationResult, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x836CDB0", Offset = "0x836C1B0", VA = "0x18836CDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836CFF0", Offset = "0x836C3F0", VA = "0x18836CFF0")]
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

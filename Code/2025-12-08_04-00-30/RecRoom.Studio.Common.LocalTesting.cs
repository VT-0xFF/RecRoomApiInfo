using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Studio.LocalTesting
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class XSPTCZLORST
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string QAKIBDYZHVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8D5E830", Offset = "0x8D5D030", VA = "0x188D5E830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static int LDMTXGBABIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8D5E8E0", Offset = "0x8D5D0E0", VA = "0x188D5E8E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E970", Offset = "0x8D5D170", VA = "0x188D5E970")]
		public static string OQSZVHYSKPG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E7B0", Offset = "0x8D5CFB0", VA = "0x188D5E7B0")]
		public static string DRXBCZTKFDW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E860", Offset = "0x8D5D060", VA = "0x188D5E860")]
		public static string KACXUZGSAEO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E8F0", Offset = "0x8D5D0F0", VA = "0x188D5E8F0")]
		public static string MLDUNMUZUZE(int a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class IQRXATAMZBR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class QFMADIQWEXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000001")]
			public HttpListener MIKGKBNITPZ;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public QFMADIQWEXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5B7FBA0", Offset = "0x5B7E3A0", VA = "0x185B7FBA0")]
			internal void QUFAOTUYSKK()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private struct <HandleCommandsUntilCanceled>d__0 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IQRXATAMZBR<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public int port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public CancellationToken cancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private QFMADIQWEXT <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private CancellationTokenRegistration <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private HttpListenerContext <listenerContext>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private TaskAwaiter<HttpListenerContext> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private HttpListenerResponse <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private TaskAwaiter<a> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private TaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4F15E80", Offset = "0x4F14680", VA = "0x184F15E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4F17C70", Offset = "0x4F16470", VA = "0x184F17C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private struct <ParseCommand>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public HttpListenerContext listenerContext;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private StreamReader <requestReader>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x506A600", Offset = "0x5068E00", VA = "0x18506A600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x506B1C0", Offset = "0x50699C0", VA = "0x18506B1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA480", Offset = "0x4FE8C80", VA = "0x184FEA480")]
		[AsyncStateMachine(typeof(IQRXATAMZBR<>.<HandleCommandsUntilCanceled>d__0))]
		public Task GVMEKNZQTKK(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract string BXKDJJEJSMF(int a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA260", Offset = "0x4FE8A60", VA = "0x184FEA260", Slot = "5")]
		[AsyncStateMachine(typeof(IQRXATAMZBR<>.<ParseCommand>d__2))]
		protected virtual Task<a> GDYPDAVVOJN(HttpListenerContext a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract Task XKHJFPGZEAJ(a a, HttpListenerContext b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "7")]
		protected virtual bool XIGMHJTHWYT(Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected IQRXATAMZBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class HIDMGZUTHWR : IQRXATAMZBR<object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E530", Offset = "0x8D5CD30", VA = "0x188D5E530", Slot = "5")]
		protected override Task<object> GDYPDAVVOJN(HttpListenerContext a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E590", Offset = "0x8D5CD90", VA = "0x188D5E590")]
		protected HIDMGZUTHWR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class OSCOOJTPZDW<a> : IQRXATAMZBR<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Func<a, HttpListenerContext, CancellationToken, Task> MXCBAOCOEAB;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDB60", Offset = "0x3DCC360", VA = "0x183DCDB60")]
		protected OSCOOJTPZDW(Func<a, HttpListenerContext, CancellationToken, Task> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5A06400", Offset = "0x5A04C00", VA = "0x185A06400", Slot = "6")]
		protected override Task XKHJFPGZEAJ(a a, HttpListenerContext b, CancellationToken c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class TBSQPBLXKEB : HIDMGZUTHWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E6A0", Offset = "0x8D5CEA0", VA = "0x188D5E6A0", Slot = "4")]
		protected override string BXKDJJEJSMF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E720", Offset = "0x8D5CF20", VA = "0x188D5E720", Slot = "6")]
		protected override Task XKHJFPGZEAJ(object a, HttpListenerContext b, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E590", Offset = "0x8D5CD90", VA = "0x188D5E590")]
		public TBSQPBLXKEB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LoadRoomCommand
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum VersionCode
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Initial = 0,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			AddedIsObjectModelEnabled = 1,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			StudioContentInInventions = 2,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			LatestPlusOne = 3,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Latest = 2
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public VersionCode Version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long RoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public long SubRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string SubRoomAssetBundleFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public string SubRoomDataFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public bool IsObjectModelEnabled;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LoadRoomCommand()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LoadConsumableCommand
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string SubRoomAssetBundleRootDirectory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string ConsumableJson;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LoadConsumableCommand()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class KPUGHFLVOTN : OSCOOJTPZDW<LoadRoomCommand>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E650", Offset = "0x8D5CE50", VA = "0x188D5E650")]
		public KPUGHFLVOTN(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E5D0", Offset = "0x8D5CDD0", VA = "0x188D5E5D0", Slot = "4")]
		protected override string BXKDJJEJSMF(int a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public sealed class BQRXXWDLPWT : OSCOOJTPZDW<LoadConsumableCommand>
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E4E0", Offset = "0x8D5CCE0", VA = "0x188D5E4E0")]
		public BQRXXWDLPWT(Func<LoadConsumableCommand, HttpListenerContext, CancellationToken, Task> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E460", Offset = "0x8D5CC60", VA = "0x188D5E460", Slot = "4")]
		protected override string BXKDJJEJSMF(int a)
		{
			return null;
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

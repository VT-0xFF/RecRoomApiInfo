using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Core.Studio.LocalTesting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FHADEBFAOEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string PKCPGBBGEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72CB5F0", Offset = "0x72CA5F0", VA = "0x1872CB5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int HHFOCJKGLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72CB550", Offset = "0x72CA550", VA = "0x1872CB550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72CB620", Offset = "0x72CA620", VA = "0x1872CB620")]
	public static string OBGAMHOIFHG(int BDOODJOGMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72CB560", Offset = "0x72CA560", VA = "0x1872CB560")]
	public static string EBJOKCOOJLP(int BDOODJOGMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72CB680", Offset = "0x72CA680", VA = "0x1872CB680")]
	public static string POPBMALALFC(int BDOODJOGMIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class JAAFKOHPPPK<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class NNMKNOMMGAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public NNMKNOMMGAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A80F90", Offset = "0x2A7FF90", VA = "0x182A80F90")]
		internal void LONIKJNPCEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FIIJEDMDBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public JAAFKOHPPPK<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private NNMKNOMMGAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private CancellationTokenRegistration <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private HttpListenerContext <listenerContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private HttpListenerContext <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private HttpListenerResponse <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TCommand <command>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TCommand <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Exception <ex>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<HttpListenerContext> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<TCommand> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public FIIJEDMDBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1F0F790", Offset = "0x1F0E790", VA = "0x181F0F790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LNEMNGALOPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder<TCommand> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HttpListenerContext listenerContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JAAFKOHPPPK<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private StreamReader <requestReader>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string <commandJson>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TCommand <command>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public LNEMNGALOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x24BB190", Offset = "0x24BA190", VA = "0x1824BB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3095170", Offset = "0x3094170", VA = "0x183095170")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JAAFKOHPPPK<>.FIIJEDMDBEP))]
	public Task GDDADFJEHMJ(int BDOODJOGMIP, CancellationToken OOCFJBIGCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string NKIBIDPKJBC(int BDOODJOGMIP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3094F70", Offset = "0x3093F70", VA = "0x183094F70", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JAAFKOHPPPK<>.LNEMNGALOPI))]
	protected virtual Task<TCommand> DONLFKLBHJC(HttpListenerContext JLGJEAAEDDC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task HMJCGGLNGAJ(TCommand DDDEKMACFOB, HttpListenerContext JLGJEAAEDDC, CancellationToken AOAEIGNDKPI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "7")]
	protected virtual bool JCCKGOGEOLE(Exception AEPEBFMCJDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
	protected JAAFKOHPPPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FBIMMHKPMOO : JAAFKOHPPPK<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72CB4F0", Offset = "0x72CA4F0", VA = "0x1872CB4F0", Slot = "5")]
	protected override Task<object> DONLFKLBHJC(HttpListenerContext JLGJEAAEDDC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72CB4B0", Offset = "0x72CA4B0", VA = "0x1872CB4B0")]
	protected FBIMMHKPMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class JJELDKEJEHG<TCommand> : JAAFKOHPPPK<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> HFFMOFDHAKD;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x111A6F0", Offset = "0x11196F0", VA = "0x18111A6F0")]
	protected JJELDKEJEHG(Func<TCommand, HttpListenerContext, CancellationToken, Task> HFFMOFDHAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x290CB70", Offset = "0x290BB70", VA = "0x18290CB70", Slot = "6")]
	protected override Task HMJCGGLNGAJ(TCommand DDDEKMACFOB, HttpListenerContext JLGJEAAEDDC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class BPCMHHGGEHG : FBIMMHKPMOO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72CB420", Offset = "0x72CA420", VA = "0x1872CB420", Slot = "4")]
	protected override string NKIBIDPKJBC(int BDOODJOGMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72CB3D0", Offset = "0x72CA3D0", VA = "0x1872CB3D0", Slot = "6")]
	protected override Task HMJCGGLNGAJ(object DDDEKMACFOB, HttpListenerContext JLGJEAAEDDC, CancellationToken AOAEIGNDKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72CB4B0", Offset = "0x72CA4B0", VA = "0x1872CB4B0")]
	public BPCMHHGGEHG()
	{
	}
}
namespace RecRoom.Core.Studio.LocalTesting
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LoadRoomCommand
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public long RoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public long SubRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string SubRoomAssetBundleFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string SubRoomDataFullPath;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NMKICGECHKP : JJELDKEJEHG<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72CB7A0", Offset = "0x72CA7A0", VA = "0x1872CB7A0")]
	public NMKICGECHKP(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> HFFMOFDHAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x72CB710", Offset = "0x72CA710", VA = "0x1872CB710", Slot = "4")]
	protected override string NKIBIDPKJBC(int BDOODJOGMIP)
	{
		return null;
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

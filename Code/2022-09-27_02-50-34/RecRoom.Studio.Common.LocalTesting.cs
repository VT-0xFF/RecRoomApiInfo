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
using RecRoom.Core.Studio.LocalTesting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IMBHOAGKFLI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FBDFLBMGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x289CAB0", Offset = "0x289BCB0", VA = "0x18289CAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int LNFMPGIMHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x289CA20", Offset = "0x289BC20", VA = "0x18289CA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x289CAE0", Offset = "0x289BCE0", VA = "0x18289CAE0")]
	public static string OLCNILODHJC(int JCPEDFLKFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x289CB30", Offset = "0x289BD30", VA = "0x18289CB30")]
	public static string ONLFMCJOFNG(int JCPEDFLKFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x289CA30", Offset = "0x289BC30", VA = "0x18289CA30")]
	public static string DBDHJODDPMM(int JCPEDFLKFHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class JNEFILKNLDB<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KKMLCIHPIED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::JNEFILKNLDB<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private HttpListenerContext <listenerContext>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<HttpListenerContext> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private HttpListenerResponse <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<TCommand> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1F76080", Offset = "0x1F75280", VA = "0x181F76080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct OCBBKGGIFJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder<TCommand> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HttpListenerContext listenerContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private StreamReader <requestReader>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F852E0", Offset = "0x1F844E0", VA = "0x181F852E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1F85650", Offset = "0x1F84850", VA = "0x181F85650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener GMADMJOCNNA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken DEIGNHBHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FF420", Offset = "0x5FE620", VA = "0x1805FF420")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F72C10", Offset = "0x1F71E10", VA = "0x181F72C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1F72C40", Offset = "0x1F71E40", VA = "0x181F72C40")]
	[AsyncStateMachine(typeof(global::JNEFILKNLDB<>.KKMLCIHPIED))]
	public Task HADKCOOMCLL(int JCPEDFLKFHJ, CancellationToken HADLCAMPAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string GCEDJDHNMKP(int JCPEDFLKFHJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1F72AB0", Offset = "0x1F71CB0", VA = "0x181F72AB0", Slot = "5")]
	[AsyncStateMachine(typeof(global::JNEFILKNLDB<>.OCBBKGGIFJK))]
	protected virtual Task<TCommand> ADDOGKCBCLO(HttpListenerContext OPEHMPPDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task MDCJPBNINJF(TCommand POGOBGJDBNP, HttpListenerContext OPEHMPPDNOH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9270", Offset = "0x5F8470", VA = "0x1805F9270", Slot = "7")]
	protected virtual bool PJFKGAMBNLD(Exception LGPNHAIJKII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F72D80", Offset = "0x1F71F80", VA = "0x181F72D80")]
	protected JNEFILKNLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F72C20", Offset = "0x1F71E20", VA = "0x181F72C20")]
	[CompilerGenerated]
	private void DECDKMPHGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BENGIJBMJJD : global::JNEFILKNLDB<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x289C7F0", Offset = "0x289B9F0", VA = "0x18289C7F0", Slot = "5")]
	protected override Task<object> ADDOGKCBCLO(HttpListenerContext OPEHMPPDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x289C840", Offset = "0x289BA40", VA = "0x18289C840")]
	protected BENGIJBMJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class OCDNDBFOAMD<TCommand> : global::JNEFILKNLDB<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> LJEFPLMBLCK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E065E0", Offset = "0x1E057E0", VA = "0x181E065E0")]
	protected OCDNDBFOAMD(Func<TCommand, HttpListenerContext, CancellationToken, Task> LJEFPLMBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E06560", Offset = "0x1E05760", VA = "0x181E06560", Slot = "6")]
	protected override Task MDCJPBNINJF(TCommand POGOBGJDBNP, HttpListenerContext OPEHMPPDNOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FPMMKKPNAAE : BENGIJBMJJD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x289C950", Offset = "0x289BB50", VA = "0x18289C950", Slot = "4")]
	protected override string GCEDJDHNMKP(int JCPEDFLKFHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x289C9D0", Offset = "0x289BBD0", VA = "0x18289C9D0", Slot = "6")]
	protected override Task MDCJPBNINJF(object POGOBGJDBNP, HttpListenerContext OPEHMPPDNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x289C840", Offset = "0x289BA40", VA = "0x18289C840")]
	public FPMMKKPNAAE()
	{
	}
}
namespace RecRoom.Core.Studio.LocalTesting
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class LoadRoomCommand
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string SubRoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string AssetBundleFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string RoomDataFullPath;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x289CBB0", Offset = "0x289BDB0", VA = "0x18289CBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DHFCBKEKNDE : global::OCDNDBFOAMD<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x289C900", Offset = "0x289BB00", VA = "0x18289C900")]
	public DHFCBKEKNDE(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> LJEFPLMBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x289C880", Offset = "0x289BA80", VA = "0x18289C880", Slot = "4")]
	protected override string GCEDJDHNMKP(int JCPEDFLKFHJ)
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

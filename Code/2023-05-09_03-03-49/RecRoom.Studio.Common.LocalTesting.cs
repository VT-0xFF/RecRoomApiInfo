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
public static class CBDLOLBLCLG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LLBBMBFGFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1E77340", Offset = "0x1E75D40", VA = "0x181E77340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int GEKBBILNJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E77240", Offset = "0x1E75C40", VA = "0x181E77240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E77250", Offset = "0x1E75C50", VA = "0x181E77250")]
	public static string HBOBFHPGHKF(int HACMNJOLGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E77370", Offset = "0x1E75D70", VA = "0x181E77370")]
	public static string KKNNEBJGGDH(int HACMNJOLGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E772B0", Offset = "0x1E75CB0", VA = "0x181E772B0")]
	public static string ICMEDPKFICO(int HACMNJOLGAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class IDKFPDLAPKM<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct BJHNOGGFPNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::IDKFPDLAPKM<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4885E40", Offset = "0x4884840", VA = "0x184885E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct BNEDBOIJLEN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x36271B0", Offset = "0x3625BB0", VA = "0x1836271B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2F0D010", Offset = "0x2F0BA10", VA = "0x182F0D010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener EOKFGJJAMEF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken ELFDGKCPLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x36CECA0", Offset = "0x36CD6A0", VA = "0x1836CECA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36CECB0", Offset = "0x36CD6B0", VA = "0x1836CECB0")]
	[AsyncStateMachine(typeof(global::IDKFPDLAPKM<>.BJHNOGGFPNJ))]
	public Task OFJHOENMOPE(int HACMNJOLGAK, CancellationToken FLKJFIHGJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string MLCMEDFMLLI(int HACMNJOLGAK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x36CEB40", Offset = "0x36CD540", VA = "0x1836CEB40", Slot = "5")]
	[AsyncStateMachine(typeof(global::IDKFPDLAPKM<>.BNEDBOIJLEN))]
	protected virtual Task<TCommand> OAKGAJLEHMA(HttpListenerContext EKGLCOAILND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task KONHNDCPGMN(TCommand GBEAAPEADNL, HttpListenerContext EKGLCOAILND);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "7")]
	protected virtual bool MHHEGCJCCPM(Exception HELJFFINGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36CEDF0", Offset = "0x36CD7F0", VA = "0x1836CEDF0")]
	protected IDKFPDLAPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36CEB20", Offset = "0x36CD520", VA = "0x1836CEB20")]
	[CompilerGenerated]
	private void JMHMEAALLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PPGNLJFHPMI : global::IDKFPDLAPKM<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E77600", Offset = "0x1E76000", VA = "0x181E77600", Slot = "5")]
	protected override Task<object> OAKGAJLEHMA(HttpListenerContext EKGLCOAILND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E774E0", Offset = "0x1E75EE0", VA = "0x181E774E0")]
	protected PPGNLJFHPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JAADNOIPCMP<TCommand> : global::IDKFPDLAPKM<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> HIHHOHBNIBN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x406CE30", Offset = "0x406B830", VA = "0x18406CE30")]
	protected JAADNOIPCMP(Func<TCommand, HttpListenerContext, CancellationToken, Task> HIHHOHBNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x406CDB0", Offset = "0x406B7B0", VA = "0x18406CDB0", Slot = "6")]
	protected override Task KONHNDCPGMN(TCommand GBEAAPEADNL, HttpListenerContext EKGLCOAILND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DMIEALDBBCG : PPGNLJFHPMI
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E77450", Offset = "0x1E75E50", VA = "0x181E77450", Slot = "4")]
	protected override string MLCMEDFMLLI(int HACMNJOLGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E77400", Offset = "0x1E75E00", VA = "0x181E77400", Slot = "6")]
	protected override Task KONHNDCPGMN(object GBEAAPEADNL, HttpListenerContext EKGLCOAILND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E774E0", Offset = "0x1E75EE0", VA = "0x181E774E0")]
	public DMIEALDBBCG()
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
		public long RoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long SubRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string SubRoomAssetBundleFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string SubRoomDataFullPath;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class NFGAHBGCOLF : global::JAADNOIPCMP<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E775B0", Offset = "0x1E75FB0", VA = "0x181E775B0")]
	public NFGAHBGCOLF(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> HIHHOHBNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E77520", Offset = "0x1E75F20", VA = "0x181E77520", Slot = "4")]
	protected override string MLCMEDFMLLI(int HACMNJOLGAK)
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

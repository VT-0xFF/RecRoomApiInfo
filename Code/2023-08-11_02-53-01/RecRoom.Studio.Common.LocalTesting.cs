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
public static class BCEMOLLMFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string GPAINLFMAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F2BE30", Offset = "0x6F2A630", VA = "0x186F2BE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int NDEOFCLGFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F2BF50", Offset = "0x6F2A750", VA = "0x186F2BF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BEF0", Offset = "0x6F2A6F0", VA = "0x186F2BEF0")]
	public static string LJICCEHCGFK(int DACABOPDKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BE60", Offset = "0x6F2A660", VA = "0x186F2BE60")]
	public static string JFJKJGBBOHJ(int DACABOPDKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BF60", Offset = "0x6F2A760", VA = "0x186F2BF60")]
	public static string PHIPMFFODGI(int DACABOPDKMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class ACPMNKHFFKK<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class LPICFKHBJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public LPICFKHBJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2A610F0", Offset = "0x2A5F8F0", VA = "0x182A610F0")]
		internal void LOCAAMNDMPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JLLOEBNJMFP : IAsyncStateMachine
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
		public ACPMNKHFFKK<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private LPICFKHBJID <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public JLLOEBNJMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x27CB700", Offset = "0x27C9F00", VA = "0x1827CB700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ADCLIABNAJJ : IAsyncStateMachine
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
		public ACPMNKHFFKK<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ADCLIABNAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3558340", Offset = "0x3556B40", VA = "0x183558340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35581C0", Offset = "0x35569C0", VA = "0x1835581C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACPMNKHFFKK<>.JLLOEBNJMFP))]
	public Task IMBIFLIDAJO(int DACABOPDKMD, CancellationToken AINIEMELMHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string COJPBLKEIOE(int DACABOPDKMD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3557FC0", Offset = "0x35567C0", VA = "0x183557FC0", Slot = "5")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACPMNKHFFKK<>.ADCLIABNAJJ))]
	protected virtual Task<TCommand> IFGPDDFOAJO(HttpListenerContext HDJMKKKLCDL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task HLNCLHKAFBD(TCommand DHLOEHOBPFO, HttpListenerContext HDJMKKKLCDL, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "7")]
	protected virtual bool IPIBPHKGPEO(Exception IDAOICDGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
	protected ACPMNKHFFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class KJBGNCPFIOG : ACPMNKHFFKK<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C0D0", Offset = "0x6F2A8D0", VA = "0x186F2C0D0", Slot = "5")]
	protected override Task<object> IFGPDDFOAJO(HttpListenerContext HDJMKKKLCDL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C130", Offset = "0x6F2A930", VA = "0x186F2C130")]
	protected KJBGNCPFIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class JMJNMLNCKLG<TCommand> : ACPMNKHFFKK<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> ILKLFEELDNF;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1731850", Offset = "0x1730050", VA = "0x181731850")]
	protected JMJNMLNCKLG(Func<TCommand, HttpListenerContext, CancellationToken, Task> ILKLFEELDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27CF780", Offset = "0x27CDF80", VA = "0x1827CF780", Slot = "6")]
	protected override Task HLNCLHKAFBD(TCommand DHLOEHOBPFO, HttpListenerContext HDJMKKKLCDL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LGKCJLKCALL : KJBGNCPFIOG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C170", Offset = "0x6F2A970", VA = "0x186F2C170", Slot = "4")]
	protected override string COJPBLKEIOE(int DACABOPDKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C200", Offset = "0x6F2AA00", VA = "0x186F2C200", Slot = "6")]
	protected override Task HLNCLHKAFBD(object DHLOEHOBPFO, HttpListenerContext HDJMKKKLCDL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C130", Offset = "0x6F2A930", VA = "0x186F2C130")]
	public LGKCJLKCALL()
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
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EGLOPCBEEDO : JMJNMLNCKLG<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C080", Offset = "0x6F2A880", VA = "0x186F2C080")]
	public EGLOPCBEEDO(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> ILKLFEELDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BFF0", Offset = "0x6F2A7F0", VA = "0x186F2BFF0", Slot = "4")]
	protected override string COJPBLKEIOE(int DACABOPDKMD)
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

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
public static class FEJKNINJBKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string MHOCNIHEEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6122200", Offset = "0x6121200", VA = "0x186122200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int JFACAEOKKCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6122070", Offset = "0x6121070", VA = "0x186122070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6122110", Offset = "0x6121110", VA = "0x186122110")]
	public static string JLBDCIHFMFO(int DCLFJOILAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6122170", Offset = "0x6121170", VA = "0x186122170")]
	public static string KFNLHCCABBA(int DCLFJOILAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6122080", Offset = "0x6121080", VA = "0x186122080")]
	public static string COMFOKBEKEF(int DCLFJOILAPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class MMMCBIJHGJM<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MPOAJAFPOEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::MMMCBIJHGJM<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x2C988B0", Offset = "0x2C978B0", VA = "0x182C988B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct NDGGCPECDGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3239EB0", Offset = "0x3238EB0", VA = "0x183239EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x323A260", Offset = "0x3239260", VA = "0x18323A260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener AEPHKNIDIDH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken HLNJBEPGBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24CDB60", Offset = "0x24CCB60", VA = "0x1824CDB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24CDCF0", Offset = "0x24CCCF0", VA = "0x1824CDCF0")]
	[AsyncStateMachine(typeof(global::MMMCBIJHGJM<>.MPOAJAFPOEA))]
	public Task LGDDJFFDAGA(int DCLFJOILAPL, CancellationToken APPAFBPLAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string EFMGMEEBEJD(int DCLFJOILAPL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24CDB90", Offset = "0x24CCB90", VA = "0x1824CDB90", Slot = "5")]
	[AsyncStateMachine(typeof(global::MMMCBIJHGJM<>.NDGGCPECDGD))]
	protected virtual Task<TCommand> JHPLABIBIMO(HttpListenerContext LPIMHMOLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task KLAMPKBFDEG(TCommand HHJBJIHEGAF, HttpListenerContext LPIMHMOLABA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00", Slot = "7")]
	protected virtual bool BNCPMICLPMK(Exception ILBPMKLBBAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24CDE30", Offset = "0x24CCE30", VA = "0x1824CDE30")]
	protected MMMCBIJHGJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24CDB70", Offset = "0x24CCB70", VA = "0x1824CDB70")]
	[CompilerGenerated]
	private void EIHGAOMKIAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EJOHONGBMAC : global::MMMCBIJHGJM<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6121FD0", Offset = "0x6120FD0", VA = "0x186121FD0", Slot = "5")]
	protected override Task<object> JHPLABIBIMO(HttpListenerContext LPIMHMOLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6122030", Offset = "0x6121030", VA = "0x186122030")]
	protected EJOHONGBMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class OPCMLBONEIG<TCommand> : global::MMMCBIJHGJM<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> HOOEMGLLCLJ;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47B12E0", Offset = "0x47B02E0", VA = "0x1847B12E0")]
	protected OPCMLBONEIG(Func<TCommand, HttpListenerContext, CancellationToken, Task> HOOEMGLLCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47B1260", Offset = "0x47B0260", VA = "0x1847B1260", Slot = "6")]
	protected override Task KLAMPKBFDEG(TCommand HHJBJIHEGAF, HttpListenerContext LPIMHMOLABA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HIFNMMAJFFE : EJOHONGBMAC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6122310", Offset = "0x6121310", VA = "0x186122310", Slot = "4")]
	protected override string EFMGMEEBEJD(int DCLFJOILAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61223A0", Offset = "0x61213A0", VA = "0x1861223A0", Slot = "6")]
	protected override Task KLAMPKBFDEG(object HHJBJIHEGAF, HttpListenerContext LPIMHMOLABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6122030", Offset = "0x6121030", VA = "0x186122030")]
	public HIFNMMAJFFE()
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HFBKLGCKCLM : global::OPCMLBONEIG<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61222C0", Offset = "0x61212C0", VA = "0x1861222C0")]
	public HFBKLGCKCLM(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> HOOEMGLLCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6122230", Offset = "0x6121230", VA = "0x186122230", Slot = "4")]
	protected override string EFMGMEEBEJD(int DCLFJOILAPL)
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

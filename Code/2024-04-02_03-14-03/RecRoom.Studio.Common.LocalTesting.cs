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
public static class OCPFDIMPLHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EKNOLEABLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69DBB60", Offset = "0x69DA760", VA = "0x1869DBB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int CNHPCHCGILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69DBC20", Offset = "0x69DA820", VA = "0x1869DBC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69DBA70", Offset = "0x69DA670", VA = "0x1869DBA70")]
	public static string AEKIFDELIBK(int IDHDCMJFMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69DBB90", Offset = "0x69DA790", VA = "0x1869DBB90")]
	public static string KCPLILEPGCI(int IDHDCMJFMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69DBAD0", Offset = "0x69DA6D0", VA = "0x1869DBAD0")]
	public static string HFEMMAJHJDK(int IDHDCMJFMDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class LPGMLGAEDEK<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GKBIHPHOHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public GKBIHPHOHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37A59B0", Offset = "0x37A45B0", VA = "0x1837A59B0")]
		internal void FIOOLLHKHNF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct AMDJPKBOPJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public LPGMLGAEDEK<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private GKBIHPHOHLK <>8__1;

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
		private TaskAwaiter<TCommand> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x38DDC90", Offset = "0x38DC890", VA = "0x1838DDC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38DEAF0", Offset = "0x38DD6F0", VA = "0x1838DEAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GMIMMMFENFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TCommand> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public HttpListenerContext listenerContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private StreamReader <requestReader>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37AA420", Offset = "0x37A9020", VA = "0x1837AA420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x37AA940", Offset = "0x37A9540", VA = "0x1837AA940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C47590", Offset = "0x3C46190", VA = "0x183C47590")]
	[AsyncStateMachine(typeof(LPGMLGAEDEK<>.AMDJPKBOPJD))]
	public Task GDIFBAGDNKD(int IDHDCMJFMDO, CancellationToken GILAIFBCNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string CECIHDCFNFB(int IDHDCMJFMDO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C476C0", Offset = "0x3C462C0", VA = "0x183C476C0", Slot = "5")]
	[AsyncStateMachine(typeof(LPGMLGAEDEK<>.GMIMMMFENFP))]
	protected virtual Task<TCommand> IGCONOAANBL(HttpListenerContext PBIPHBNMFAF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task CMOBEKBJJHD(TCommand OCODIPKECGF, HttpListenerContext PBIPHBNMFAF, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "7")]
	protected virtual bool DGAKILLNDBJ(Exception BJCOEJJDGCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected LPGMLGAEDEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HDCAMKMMNIL : LPGMLGAEDEK<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69DB930", Offset = "0x69DA530", VA = "0x1869DB930", Slot = "5")]
	protected override Task<object> IGCONOAANBL(HttpListenerContext PBIPHBNMFAF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69DB8F0", Offset = "0x69DA4F0", VA = "0x1869DB8F0")]
	protected HDCAMKMMNIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class PIDELFNLCHG<TCommand> : LPGMLGAEDEK<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> MCBNFPKNPNK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B69680", Offset = "0x3B68280", VA = "0x183B69680")]
	protected PIDELFNLCHG(Func<TCommand, HttpListenerContext, CancellationToken, Task> MCBNFPKNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4108BC0", Offset = "0x41077C0", VA = "0x184108BC0", Slot = "6")]
	protected override Task CMOBEKBJJHD(TCommand OCODIPKECGF, HttpListenerContext PBIPHBNMFAF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EDMPCMFAJCK : HDCAMKMMNIL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69DB7D0", Offset = "0x69DA3D0", VA = "0x1869DB7D0", Slot = "4")]
	protected override string CECIHDCFNFB(int IDHDCMJFMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69DB860", Offset = "0x69DA460", VA = "0x1869DB860", Slot = "6")]
	protected override Task CMOBEKBJJHD(object OCODIPKECGF, HttpListenerContext PBIPHBNMFAF, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69DB8F0", Offset = "0x69DA4F0", VA = "0x1869DB8F0")]
	public EDMPCMFAJCK()
	{
	}
}
namespace RecRoom.Core.Studio.LocalTesting
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LoadRoomCommand
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum OKBKIMFKJHD
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Initial = 0,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			AddedIsObjectModelEnabled = 1,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			LatestPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Latest = 1
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public OKBKIMFKJHD Version;

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

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class IPNJOPNKDHI : PIDELFNLCHG<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69DBA20", Offset = "0x69DA620", VA = "0x1869DBA20")]
	public IPNJOPNKDHI(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> MCBNFPKNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69DB990", Offset = "0x69DA590", VA = "0x1869DB990", Slot = "4")]
	protected override string CECIHDCFNFB(int IDHDCMJFMDO)
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

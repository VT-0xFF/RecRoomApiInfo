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
public static class FMHGAEGCKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KMEOKBKNGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x635F910", Offset = "0x635E110", VA = "0x18635F910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int LLILEOPMNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x635FA60", Offset = "0x635E260", VA = "0x18635FA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x635F8B0", Offset = "0x635E0B0", VA = "0x18635F8B0")]
	public static string AFKAFEONKAM(int PMKFLOKOEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x635F9D0", Offset = "0x635E1D0", VA = "0x18635F9D0")]
	public static string JGOMCMDKHKF(int PMKFLOKOEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x635F940", Offset = "0x635E140", VA = "0x18635F940")]
	public static string IPHNOAIJBGO(int PMKFLOKOEBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class FJJNPOFKJJK<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CIGODKJGNMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public CIGODKJGNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4A57FF0", Offset = "0x4A567F0", VA = "0x184A57FF0")]
		internal void LDKDDDFLDFA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct FBIPKMJKAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public FJJNPOFKJJK<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private CIGODKJGNMK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3372FE0", Offset = "0x33717E0", VA = "0x183372FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3373E40", Offset = "0x3372640", VA = "0x183373E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct FEBMOFDPLGD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x337A8A0", Offset = "0x33790A0", VA = "0x18337A8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x337ADC0", Offset = "0x33795C0", VA = "0x18337ADC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x339F220", Offset = "0x339DA20", VA = "0x18339F220")]
	[AsyncStateMachine(typeof(FJJNPOFKJJK<>.FBIPKMJKAIG))]
	public Task EAICKCIJKCD(int PMKFLOKOEBP, CancellationToken NBCGOFKOBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string HMJBMINGDCP(int PMKFLOKOEBP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x339F350", Offset = "0x339DB50", VA = "0x18339F350", Slot = "5")]
	[AsyncStateMachine(typeof(FJJNPOFKJJK<>.FEBMOFDPLGD))]
	protected virtual Task<TCommand> LNKCPHEBPLI(HttpListenerContext IMFAAMJKNKI, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task DHMBMMEDNLC(TCommand CALHOCIHKPM, HttpListenerContext IMFAAMJKNKI, CancellationToken NCEIDHNHODH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "7")]
	protected virtual bool IDJHABPEGLA(Exception DCJGKNPOAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected FJJNPOFKJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class DAHCJLBPHGH : FJJNPOFKJJK<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x635F810", Offset = "0x635E010", VA = "0x18635F810", Slot = "5")]
	protected override Task<object> LNKCPHEBPLI(HttpListenerContext IMFAAMJKNKI, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x635F870", Offset = "0x635E070", VA = "0x18635F870")]
	protected DAHCJLBPHGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class LOEMFGHHKAC<TCommand> : FJJNPOFKJJK<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> AFJJEIHHOHA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38EBEC0", Offset = "0x38EA6C0", VA = "0x1838EBEC0")]
	protected LOEMFGHHKAC(Func<TCommand, HttpListenerContext, CancellationToken, Task> AFJJEIHHOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x39C5000", Offset = "0x39C3800", VA = "0x1839C5000", Slot = "6")]
	protected override Task DHMBMMEDNLC(TCommand CALHOCIHKPM, HttpListenerContext IMFAAMJKNKI, CancellationToken NCEIDHNHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OGNMBECLDOH : DAHCJLBPHGH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x635FBE0", Offset = "0x635E3E0", VA = "0x18635FBE0", Slot = "4")]
	protected override string HMJBMINGDCP(int PMKFLOKOEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x635FB50", Offset = "0x635E350", VA = "0x18635FB50", Slot = "6")]
	protected override Task DHMBMMEDNLC(object CALHOCIHKPM, HttpListenerContext IMFAAMJKNKI, CancellationToken NCEIDHNHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x635F870", Offset = "0x635E070", VA = "0x18635F870")]
	public OGNMBECLDOH()
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
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public long RoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long SubRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string SubRoomAssetBundleFullPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string SubRoomDataFullPath;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JEJEHOKGGHO : LOEMFGHHKAC<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x635FB00", Offset = "0x635E300", VA = "0x18635FB00")]
	public JEJEHOKGGHO(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> AFJJEIHHOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x635FA70", Offset = "0x635E270", VA = "0x18635FA70", Slot = "4")]
	protected override string HMJBMINGDCP(int PMKFLOKOEBP)
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

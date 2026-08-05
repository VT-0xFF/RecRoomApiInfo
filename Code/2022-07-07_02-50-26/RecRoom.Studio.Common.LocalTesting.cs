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
public static class MDIHCIOPLAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IDBIHGCLGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x51F3C00", Offset = "0x51F2E00", VA = "0x1851F3C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51F3C30", Offset = "0x51F2E30", VA = "0x1851F3C30")]
	public static string NOCBNKOIFCN(int GLEJHNJKEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51F3B80", Offset = "0x51F2D80", VA = "0x1851F3B80")]
	public static string AKAIGAFAJIA(int GLEJHNJKEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51F3C80", Offset = "0x51F2E80", VA = "0x1851F3C80")]
	public static string PELECNBDOJB(int GLEJHNJKEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class CHLCMGBEFHP<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MGOIHPBEHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::CHLCMGBEFHP<TCommand> <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BADF90", Offset = "0x2BAD190", VA = "0x182BADF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE0", Offset = "0x7EB1E0", VA = "0x1807EBFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LNJIHPDFDFH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BADAD0", Offset = "0x2BACCD0", VA = "0x182BADAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BADE40", Offset = "0x2BAD040", VA = "0x182BADE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener AADNDBDIIDE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	protected CancellationToken KKAECDHDMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2BA2410", Offset = "0x2BA1610", VA = "0x182BA2410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2580", Offset = "0x2BA1780", VA = "0x182BA2580")]
	[AsyncStateMachine(typeof(global::CHLCMGBEFHP<>.MGOIHPBEHLE))]
	public Task CACOIJJLJOG(int GLEJHNJKEGN, CancellationToken DFPOCMAHEJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string GDIBCOBKJJK(int GLEJHNJKEGN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2420", Offset = "0x2BA1620", VA = "0x182BA2420", Slot = "5")]
	[AsyncStateMachine(typeof(global::CHLCMGBEFHP<>.LNJIHPDFDFH))]
	protected virtual Task<TCommand> AIMJJMFDHCL(HttpListenerContext IDBAJHAAAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task CKEMBIOBDPK(TCommand APCIJGDECOB, HttpListenerContext IDBAJHAAAHB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x58AEC0", Offset = "0x58A0C0", VA = "0x18058AEC0", Slot = "7")]
	protected virtual bool JEJOEPGKPAH(Exception AOKIHNBMBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA26E0", Offset = "0x2BA18E0", VA = "0x182BA26E0")]
	protected CHLCMGBEFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA26C0", Offset = "0x2BA18C0", VA = "0x182BA26C0")]
	[CompilerGenerated]
	private void ENIKKIMCLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BDAGCNDNBBI : global::CHLCMGBEFHP<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51F3530", Offset = "0x51F2730", VA = "0x1851F3530", Slot = "5")]
	protected override Task<object> AIMJJMFDHCL(HttpListenerContext IDBAJHAAAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x51F3580", Offset = "0x51F2780", VA = "0x1851F3580")]
	protected BDAGCNDNBBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class HJGGJDMLHLI<TCommand> : global::CHLCMGBEFHP<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> BIOAJFLFMNC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38CF430", Offset = "0x38CE630", VA = "0x1838CF430")]
	protected HJGGJDMLHLI(Func<TCommand, HttpListenerContext, CancellationToken, Task> BIOAJFLFMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38CF3B0", Offset = "0x38CE5B0", VA = "0x1838CF3B0", Slot = "6")]
	protected override Task CKEMBIOBDPK(TCommand APCIJGDECOB, HttpListenerContext IDBAJHAAAHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MGOCGAIBDNO : BDAGCNDNBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x51F3D50", Offset = "0x51F2F50", VA = "0x1851F3D50", Slot = "4")]
	protected override string GDIBCOBKJJK(int GLEJHNJKEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51F3D00", Offset = "0x51F2F00", VA = "0x1851F3D00", Slot = "6")]
	protected override Task CKEMBIOBDPK(object APCIJGDECOB, HttpListenerContext IDBAJHAAAHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x51F3580", Offset = "0x51F2780", VA = "0x1851F3580")]
	public MGOCGAIBDNO()
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

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x51F3690", Offset = "0x51F2890", VA = "0x1851F3690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class JJAJDAEFAFC : global::HJGGJDMLHLI<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51F3640", Offset = "0x51F2840", VA = "0x1851F3640")]
	public JJAJDAEFAFC(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> BIOAJFLFMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51F35C0", Offset = "0x51F27C0", VA = "0x1851F35C0", Slot = "4")]
	protected override string GDIBCOBKJJK(int GLEJHNJKEGN)
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

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
public static class GNBNCCOFHIG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LPCBIDFKDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EF4220", Offset = "0x7EF3620", VA = "0x187EF4220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int KJFCIOCIOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EF42E0", Offset = "0x7EF36E0", VA = "0x187EF42E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EF42F0", Offset = "0x7EF36F0", VA = "0x187EF42F0")]
	public static string KADIOIBICKM(int GMEMHACONIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4250", Offset = "0x7EF3650", VA = "0x187EF4250")]
	public static string EHJAIBEJBHN(int GMEMHACONIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4350", Offset = "0x7EF3750", VA = "0x187EF4350")]
	public static string MMKGLICNFJL(int GMEMHACONIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class FJMJHOGMAGA<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class ACPNABDDBFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ACPNABDDBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x47933C0", Offset = "0x47927C0", VA = "0x1847933C0")]
		internal void DKGMIAKHIJD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct FNMBJCBJCEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public FJMJHOGMAGA<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private ACPNABDDBFF <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x43DDD20", Offset = "0x43DD120", VA = "0x1843DDD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x43DEBC0", Offset = "0x43DDFC0", VA = "0x1843DEBC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct JEGOCDGAPEN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x496B400", Offset = "0x496A800", VA = "0x18496B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x496B920", Offset = "0x496AD20", VA = "0x18496B920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43CD8C0", Offset = "0x43CCCC0", VA = "0x1843CD8C0")]
	[AsyncStateMachine(typeof(FJMJHOGMAGA<>.FNMBJCBJCEL))]
	public Task FOKIMPBFIJO(int GMEMHACONIH, CancellationToken CPNLPDIBPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string KOFGOODFGLG(int GMEMHACONIH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43CD9E0", Offset = "0x43CCDE0", VA = "0x1843CD9E0", Slot = "5")]
	[AsyncStateMachine(typeof(FJMJHOGMAGA<>.JEGOCDGAPEN))]
	protected virtual Task<TCommand> IBBKJLODKNG(HttpListenerContext CCEKAGOIMGJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task PPJGCMNODEI(TCommand HLNLKLPFHPN, HttpListenerContext CCEKAGOIMGJ, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "7")]
	protected virtual bool BANKDFBFFGN(Exception DADIPHEHDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	protected FJMJHOGMAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class INJBJFNEONN : FJMJHOGMAGA<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EF43E0", Offset = "0x7EF37E0", VA = "0x187EF43E0", Slot = "5")]
	protected override Task<object> IBBKJLODKNG(HttpListenerContext CCEKAGOIMGJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4440", Offset = "0x7EF3840", VA = "0x187EF4440")]
	protected INJBJFNEONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class HDMJNKNEJCE<TCommand> : FJMJHOGMAGA<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> BPAFMEMBDKI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5D80", Offset = "0x3FF5180", VA = "0x183FF5D80")]
	protected HDMJNKNEJCE(Func<TCommand, HttpListenerContext, CancellationToken, Task> BPAFMEMBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45CF150", Offset = "0x45CE550", VA = "0x1845CF150", Slot = "6")]
	protected override Task PPJGCMNODEI(TCommand HLNLKLPFHPN, HttpListenerContext CCEKAGOIMGJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class OEOKLDKGECF : INJBJFNEONN
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4480", Offset = "0x7EF3880", VA = "0x187EF4480", Slot = "4")]
	protected override string KOFGOODFGLG(int GMEMHACONIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4510", Offset = "0x7EF3910", VA = "0x187EF4510", Slot = "6")]
	protected override Task PPJGCMNODEI(object HLNLKLPFHPN, HttpListenerContext CCEKAGOIMGJ, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4440", Offset = "0x7EF3840", VA = "0x187EF4440")]
	public OEOKLDKGECF()
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
		public enum BKJNAJLCHLC
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
		public BKJNAJLCHLC Version;

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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class PLHMKDIJCMH : HDMJNKNEJCE<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4630", Offset = "0x7EF3A30", VA = "0x187EF4630")]
	public PLHMKDIJCMH(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> BPAFMEMBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF45A0", Offset = "0x7EF39A0", VA = "0x187EF45A0", Slot = "4")]
	protected override string KOFGOODFGLG(int GMEMHACONIH)
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

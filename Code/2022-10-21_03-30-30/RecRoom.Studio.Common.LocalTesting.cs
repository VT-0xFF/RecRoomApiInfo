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
public static class JGPBJLAFINC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NLDDOKKBFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B860", Offset = "0x5E9A660", VA = "0x185E9B860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int ECLEPPANPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B920", Offset = "0x5E9A720", VA = "0x185E9B920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B800", Offset = "0x5E9A600", VA = "0x185E9B800")]
	public static string HOLLHKJHPFJ(int KNIIEBMLNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B890", Offset = "0x5E9A690", VA = "0x185E9B890")]
	public static string KBMELEBGIKF(int KNIIEBMLNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B930", Offset = "0x5E9A730", VA = "0x185E9B930")]
	public static string NFFKBHLAIOF(int KNIIEBMLNPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class KPAJLGAHGGB<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct CPNOBBACKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::KPAJLGAHGGB<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x24CB720", Offset = "0x24CA520", VA = "0x1824CB720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x750860", Offset = "0x74F660", VA = "0x180750860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct LPGEIGLFGOK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x2D676D0", Offset = "0x2D664D0", VA = "0x182D676D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2D67A80", Offset = "0x2D66880", VA = "0x182D67A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener BLCEMJHOLMB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken ONDDMEJLOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x30766D0", Offset = "0x30754D0", VA = "0x1830766D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3076570", Offset = "0x3075370", VA = "0x183076570")]
	[AsyncStateMachine(typeof(global::KPAJLGAHGGB<>.CPNOBBACKPN))]
	public Task HMBALCBJNIO(int KNIIEBMLNPF, CancellationToken IHLPJAIGJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string FOHJNBCBKDE(int KNIIEBMLNPF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3076410", Offset = "0x3075210", VA = "0x183076410", Slot = "5")]
	[AsyncStateMachine(typeof(global::KPAJLGAHGGB<>.LPGEIGLFGOK))]
	protected virtual Task<TCommand> CHEEGEPOGGE(HttpListenerContext MLOGMNOPOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task DDIBLEIAGPB(TCommand MBKFGPPACCF, HttpListenerContext MLOGMNOPOHO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65A820", Offset = "0x659620", VA = "0x18065A820", Slot = "7")]
	protected virtual bool JBNLMNLPIBP(Exception KLJBPOILBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30766E0", Offset = "0x30754E0", VA = "0x1830766E0")]
	protected KPAJLGAHGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x30766B0", Offset = "0x30754B0", VA = "0x1830766B0")]
	[CompilerGenerated]
	private void JHCONFBJION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HGECKMCJNNC : global::KPAJLGAHGGB<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B680", Offset = "0x5E9A480", VA = "0x185E9B680", Slot = "5")]
	protected override Task<object> CHEEGEPOGGE(HttpListenerContext MLOGMNOPOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B6E0", Offset = "0x5E9A4E0", VA = "0x185E9B6E0")]
	protected HGECKMCJNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class JAGKFEBJJEG<TCommand> : global::KPAJLGAHGGB<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> CLLNPAMJMAI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x350EAC0", Offset = "0x350D8C0", VA = "0x18350EAC0")]
	protected JAGKFEBJJEG(Func<TCommand, HttpListenerContext, CancellationToken, Task> CLLNPAMJMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x350EA40", Offset = "0x350D840", VA = "0x18350EA40", Slot = "6")]
	protected override Task DDIBLEIAGPB(TCommand MBKFGPPACCF, HttpListenerContext MLOGMNOPOHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JNIPAKIIIDL : HGECKMCJNNC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BA10", Offset = "0x5E9A810", VA = "0x185E9BA10", Slot = "4")]
	protected override string FOHJNBCBKDE(int KNIIEBMLNPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B9C0", Offset = "0x5E9A7C0", VA = "0x185E9B9C0", Slot = "6")]
	protected override Task DDIBLEIAGPB(object MBKFGPPACCF, HttpListenerContext MLOGMNOPOHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B6E0", Offset = "0x5E9A4E0", VA = "0x185E9B6E0")]
	public JNIPAKIIIDL()
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
		[Cpp2IlInjected.Address(RVA = "0x5E9BAA0", Offset = "0x5E9A8A0", VA = "0x185E9BAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HKMLEMLOPBI : global::JAGKFEBJJEG<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B7B0", Offset = "0x5E9A5B0", VA = "0x185E9B7B0")]
	public HKMLEMLOPBI(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> CLLNPAMJMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B720", Offset = "0x5E9A520", VA = "0x185E9B720", Slot = "4")]
	protected override string FOHJNBCBKDE(int KNIIEBMLNPF)
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

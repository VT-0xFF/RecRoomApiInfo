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
public static class INOIPIHCHCC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string CMMBGPGLACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5846340", Offset = "0x5844F40", VA = "0x185846340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int DOBIDOKBLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x58464C0", Offset = "0x58450C0", VA = "0x1858464C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5846370", Offset = "0x5844F70", VA = "0x185846370")]
	public static string KHFBGIDIBMD(int LIPKKDMGPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5846440", Offset = "0x5845040", VA = "0x185846440")]
	public static string NPOAFECJIGB(int LIPKKDMGPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58463C0", Offset = "0x5844FC0", VA = "0x1858463C0")]
	public static string LAADDOGPGKA(int LIPKKDMGPHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HBMBJAGDCPG<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct CIDGKNJEFPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::HBMBJAGDCPG<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x393C670", Offset = "0x393B270", VA = "0x18393C670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct NNKEMLAEEOD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x3953390", Offset = "0x3951F90", VA = "0x183953390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3953700", Offset = "0x3952300", VA = "0x183953700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener NGDDJMOHFFF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken PNIGKLJDMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x39467E0", Offset = "0x39453E0", VA = "0x1839467E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39466A0", Offset = "0x39452A0", VA = "0x1839466A0")]
	[AsyncStateMachine(typeof(global::HBMBJAGDCPG<>.CIDGKNJEFPO))]
	public Task LHEBDKALKOI(int LIPKKDMGPHJ, CancellationToken OLAEKEOGLNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string NKLHCFLAFPP(int LIPKKDMGPHJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3946520", Offset = "0x3945120", VA = "0x183946520", Slot = "5")]
	[AsyncStateMachine(typeof(global::HBMBJAGDCPG<>.NNKEMLAEEOD))]
	protected virtual Task<TCommand> ANLCAFPMEJI(HttpListenerContext OPNBLOIEPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task CHOMFMBAMMB(TCommand LLDDAGKDGOE, HttpListenerContext OPNBLOIEPJP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "7")]
	protected virtual bool JFFOEDIAAJG(Exception NINELMHCJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39467F0", Offset = "0x39453F0", VA = "0x1839467F0")]
	protected HBMBJAGDCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3946680", Offset = "0x3945280", VA = "0x183946680")]
	[CompilerGenerated]
	private void FKMGMDBHPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NBDINFHPPEA : global::HBMBJAGDCPG<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58469C0", Offset = "0x58455C0", VA = "0x1858469C0", Slot = "5")]
	protected override Task<object> ANLCAFPMEJI(HttpListenerContext OPNBLOIEPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5846230", Offset = "0x5844E30", VA = "0x185846230")]
	protected NBDINFHPPEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class ADEGFPFOPDM<TCommand> : global::HBMBJAGDCPG<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> CFGGKDHFKPM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44AA7D0", Offset = "0x44A93D0", VA = "0x1844AA7D0")]
	protected ADEGFPFOPDM(Func<TCommand, HttpListenerContext, CancellationToken, Task> CFGGKDHFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44AA750", Offset = "0x44A9350", VA = "0x1844AA750", Slot = "6")]
	protected override Task CHOMFMBAMMB(TCommand LLDDAGKDGOE, HttpListenerContext OPNBLOIEPJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class BIBEHIBNAAM : NBDINFHPPEA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58461B0", Offset = "0x5844DB0", VA = "0x1858461B0", Slot = "4")]
	protected override string NKLHCFLAFPP(int LIPKKDMGPHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5846160", Offset = "0x5844D60", VA = "0x185846160", Slot = "6")]
	protected override Task CHOMFMBAMMB(object LLDDAGKDGOE, HttpListenerContext OPNBLOIEPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5846230", Offset = "0x5844E30", VA = "0x185846230")]
	public BIBEHIBNAAM()
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
		[Cpp2IlInjected.Address(RVA = "0x58464D0", Offset = "0x58450D0", VA = "0x1858464D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HLLHJDOHMME : global::ADEGFPFOPDM<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58462F0", Offset = "0x5844EF0", VA = "0x1858462F0")]
	public HLLHJDOHMME(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> CFGGKDHFKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5846270", Offset = "0x5844E70", VA = "0x185846270", Slot = "4")]
	protected override string NKLHCFLAFPP(int LIPKKDMGPHJ)
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

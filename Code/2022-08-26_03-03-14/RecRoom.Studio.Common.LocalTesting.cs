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
public static class HEFFCHBNJIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string JEEDEJBFFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x58B22A0", Offset = "0x58B0EA0", VA = "0x1858B22A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int JALHGENCCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x58B2320", Offset = "0x58B0F20", VA = "0x1858B2320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58B22D0", Offset = "0x58B0ED0", VA = "0x1858B22D0")]
	public static string EMOPBFPPBBC(int JJAMAJBIPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58B2330", Offset = "0x58B0F30", VA = "0x1858B2330")]
	public static string HIOFGDJOEHC(int JJAMAJBIPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58B23B0", Offset = "0x58B0FB0", VA = "0x1858B23B0")]
	public static string KLJHMONCLHF(int JJAMAJBIPMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class LGNBAADMDAP<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MNOLLDKCNOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::LGNBAADMDAP<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x39BEFA0", Offset = "0x39BDBA0", VA = "0x1839BEFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84E2E0", Offset = "0x84CEE0", VA = "0x18084E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct PAIOCEBAMEK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x39BFC90", Offset = "0x39BE890", VA = "0x1839BFC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39C0000", Offset = "0x39BEC00", VA = "0x1839C0000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener OMANALFMHEI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken HFKIPIABOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x39B49C0", Offset = "0x39B35C0", VA = "0x1839B49C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39B49D0", Offset = "0x39B35D0", VA = "0x1839B49D0")]
	[AsyncStateMachine(typeof(global::LGNBAADMDAP<>.MNOLLDKCNOJ))]
	public Task JNIDCDELEKO(int JJAMAJBIPMN, CancellationToken BFGHNBPEMDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string GNHFADKEPJD(int JJAMAJBIPMN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39B4860", Offset = "0x39B3460", VA = "0x1839B4860", Slot = "5")]
	[AsyncStateMachine(typeof(global::LGNBAADMDAP<>.PAIOCEBAMEK))]
	protected virtual Task<TCommand> DDACBEBPNCK(HttpListenerContext FIBAKDEKIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task OJFLKLDCIBC(TCommand BHHPLLKMOGM, HttpListenerContext FIBAKDEKIMB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "7")]
	protected virtual bool CAFDDFDJPJA(Exception BJEAAGJFDCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39B4B30", Offset = "0x39B3730", VA = "0x1839B4B30")]
	protected LGNBAADMDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39B4B10", Offset = "0x39B3710", VA = "0x1839B4B10")]
	[CompilerGenerated]
	private void PBCNKILGPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FMEDEALLBNN : global::LGNBAADMDAP<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58B2140", Offset = "0x58B0D40", VA = "0x1858B2140", Slot = "5")]
	protected override Task<object> DDACBEBPNCK(HttpListenerContext FIBAKDEKIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58B2190", Offset = "0x58B0D90", VA = "0x1858B2190")]
	protected FMEDEALLBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class CDANAFIKLPE<TCommand> : global::LGNBAADMDAP<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> CJHMLKGNIBL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33C9390", Offset = "0x33C7F90", VA = "0x1833C9390")]
	protected CDANAFIKLPE(Func<TCommand, HttpListenerContext, CancellationToken, Task> CJHMLKGNIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x33C9310", Offset = "0x33C7F10", VA = "0x1833C9310", Slot = "6")]
	protected override Task OJFLKLDCIBC(TCommand BHHPLLKMOGM, HttpListenerContext FIBAKDEKIMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FPNDFPOINME : FMEDEALLBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58B21D0", Offset = "0x58B0DD0", VA = "0x1858B21D0", Slot = "4")]
	protected override string GNHFADKEPJD(int JJAMAJBIPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58B2250", Offset = "0x58B0E50", VA = "0x1858B2250", Slot = "6")]
	protected override Task OJFLKLDCIBC(object BHHPLLKMOGM, HttpListenerContext FIBAKDEKIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x58B2190", Offset = "0x58B0D90", VA = "0x1858B2190")]
	public FPNDFPOINME()
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
		[Cpp2IlInjected.Address(RVA = "0x58B2430", Offset = "0x58B1030", VA = "0x1858B2430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BPDNGDLKPHI : global::CDANAFIKLPE<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58B20F0", Offset = "0x58B0CF0", VA = "0x1858B20F0")]
	public BPDNGDLKPHI(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> CJHMLKGNIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58B2070", Offset = "0x58B0C70", VA = "0x1858B2070", Slot = "4")]
	protected override string GNHFADKEPJD(int JJAMAJBIPMN)
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

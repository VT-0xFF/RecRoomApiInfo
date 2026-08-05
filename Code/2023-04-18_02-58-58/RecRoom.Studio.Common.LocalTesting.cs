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
public static class MGFPGOGDLMG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EJAPFGNHJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68138E0", Offset = "0x6812AE0", VA = "0x1868138E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int NPEBPDFLELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6813910", Offset = "0x6812B10", VA = "0x186813910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6813920", Offset = "0x6812B20", VA = "0x186813920")]
	public static string LDDADECKLNA(int KNPJEMEMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6813980", Offset = "0x6812B80", VA = "0x186813980")]
	public static string OADJCJPKDFC(int KNPJEMEMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6813850", Offset = "0x6812A50", VA = "0x186813850")]
	public static string CKHNGHPLOEF(int KNPJEMEMOEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class OHEIGEMBAJN<TCommand>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PLBFKLIHOKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public global::OHEIGEMBAJN<TCommand> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x2BEFD50", Offset = "0x2BEEF50", VA = "0x182BEFD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct NJJMBFBEINJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x23E3390", Offset = "0x23E2590", VA = "0x1823E3390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1722C70", Offset = "0x1721E70", VA = "0x181722C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HttpListener KAIOPCJDGDO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected CancellationToken DIMGCAPGODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return default(CancellationToken);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x202DD50", Offset = "0x202CF50", VA = "0x18202DD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x202DA90", Offset = "0x202CC90", VA = "0x18202DA90")]
	[AsyncStateMachine(typeof(global::OHEIGEMBAJN<>.PLBFKLIHOKA))]
	public Task AGBDFOCANBD(int KNPJEMEMOEF, CancellationToken IPFDIDPJJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string ABKPHFEPFPC(int KNPJEMEMOEF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x202DBF0", Offset = "0x202CDF0", VA = "0x18202DBF0", Slot = "5")]
	[AsyncStateMachine(typeof(global::OHEIGEMBAJN<>.NJJMBFBEINJ))]
	protected virtual Task<TCommand> HPBKIBONFID(HttpListenerContext KJEFKJBFMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task JFPFNFGFIGA(TCommand KCHOJOEJIAA, HttpListenerContext KJEFKJBFMBP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "7")]
	protected virtual bool PMCJBHNHLCD(Exception AHHCFDOHCNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x202DD60", Offset = "0x202CF60", VA = "0x18202DD60")]
	protected OHEIGEMBAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x202DBD0", Offset = "0x202CDD0", VA = "0x18202DBD0")]
	[CompilerGenerated]
	private void FCMMEOAHBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class NJDEJEGEFEE : global::OHEIGEMBAJN<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6813A10", Offset = "0x6812C10", VA = "0x186813A10", Slot = "5")]
	protected override Task<object> HPBKIBONFID(HttpListenerContext KJEFKJBFMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6813A70", Offset = "0x6812C70", VA = "0x186813A70")]
	protected NJDEJEGEFEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class EMGCFNKKCPO<TCommand> : global::OHEIGEMBAJN<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> FEILMGBBBBN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27ED140", Offset = "0x27EC340", VA = "0x1827ED140")]
	protected EMGCFNKKCPO(Func<TCommand, HttpListenerContext, CancellationToken, Task> FEILMGBBBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27ED0C0", Offset = "0x27EC2C0", VA = "0x1827ED0C0", Slot = "6")]
	protected override Task JFPFNFGFIGA(TCommand KCHOJOEJIAA, HttpListenerContext KJEFKJBFMBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PFJKHNDJFMK : NJDEJEGEFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6813AB0", Offset = "0x6812CB0", VA = "0x186813AB0", Slot = "4")]
	protected override string ABKPHFEPFPC(int KNPJEMEMOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6813B40", Offset = "0x6812D40", VA = "0x186813B40", Slot = "6")]
	protected override Task JFPFNFGFIGA(object KCHOJOEJIAA, HttpListenerContext KJEFKJBFMBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6813A70", Offset = "0x6812C70", VA = "0x186813A70")]
	public PFJKHNDJFMK()
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class KAFJAAJCGHG : global::EMGCFNKKCPO<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6813800", Offset = "0x6812A00", VA = "0x186813800")]
	public KAFJAAJCGHG(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> FEILMGBBBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6813770", Offset = "0x6812970", VA = "0x186813770", Slot = "4")]
	protected override string ABKPHFEPFPC(int KNPJEMEMOEF)
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

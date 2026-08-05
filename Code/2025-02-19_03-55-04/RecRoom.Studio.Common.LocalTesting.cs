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
public static class KKOCDCLGLPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string MMPBHIDBIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F186F0", Offset = "0x7F172F0", VA = "0x187F186F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int PMMPKKBFHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F18720", Offset = "0x7F17320", VA = "0x187F18720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F18690", Offset = "0x7F17290", VA = "0x187F18690")]
	public static string DBEJLLHLCNJ(int JCJFNFCDOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F18570", Offset = "0x7F17170", VA = "0x187F18570")]
	public static string BKGFIGBDCJK(int JCJFNFCDOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F18600", Offset = "0x7F17200", VA = "0x187F18600")]
	public static string CNBCMDKFPGD(int JCJFNFCDOLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class DENBPOBOJLE<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class KAIHBCLDKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public KAIHBCLDKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4A05AA0", Offset = "0x4A046A0", VA = "0x184A05AA0")]
		internal void LLKNDBPKEPD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct OIIEINAPIDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public DENBPOBOJLE<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private KAIHBCLDKMJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x4F80140", Offset = "0x4F7ED40", VA = "0x184F80140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4F81000", Offset = "0x4F7FC00", VA = "0x184F81000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct LNPJJKCLBJE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4B4CA40", Offset = "0x4B4B640", VA = "0x184B4CA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4B4CF70", Offset = "0x4B4BB70", VA = "0x184B4CF70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63032B0", Offset = "0x6301EB0", VA = "0x1863032B0")]
	[AsyncStateMachine(typeof(DENBPOBOJLE<>.OIIEINAPIDI))]
	public Task PFOMNNBNMPM(int JCJFNFCDOLA, CancellationToken FMLKDLMIIBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string GAFHNCIIDFM(int JCJFNFCDOLA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63033E0", Offset = "0x6301FE0", VA = "0x1863033E0", Slot = "5")]
	[AsyncStateMachine(typeof(DENBPOBOJLE<>.LNPJJKCLBJE))]
	protected virtual Task<TCommand> PHDDLMDKHEJ(HttpListenerContext AJOMHCGOPGD, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task NIDEENOOEOI(TCommand LJDJMGGJMBE, HttpListenerContext AJOMHCGOPGD, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
	protected virtual bool EKCJNOFMPCE(Exception COMMOGJDAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected DENBPOBOJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NEODLLKOGMH : DENBPOBOJLE<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F18890", Offset = "0x7F17490", VA = "0x187F18890", Slot = "5")]
	protected override Task<object> PHDDLMDKHEJ(HttpListenerContext AJOMHCGOPGD, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F18850", Offset = "0x7F17450", VA = "0x187F18850")]
	protected NEODLLKOGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class DNBGACBNLAH<TCommand> : DENBPOBOJLE<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> NMHLCIGMKME;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FEB7A0", Offset = "0x3FEA3A0", VA = "0x183FEB7A0")]
	protected DNBGACBNLAH(Func<TCommand, HttpListenerContext, CancellationToken, Task> NMHLCIGMKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6332F30", Offset = "0x6331B30", VA = "0x186332F30", Slot = "6")]
	protected override Task NIDEENOOEOI(TCommand LJDJMGGJMBE, HttpListenerContext AJOMHCGOPGD, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MKDCICAOKEC : NEODLLKOGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F18730", Offset = "0x7F17330", VA = "0x187F18730", Slot = "4")]
	protected override string GAFHNCIIDFM(int JCJFNFCDOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F187C0", Offset = "0x7F173C0", VA = "0x187F187C0", Slot = "6")]
	protected override Task NIDEENOOEOI(object LJDJMGGJMBE, HttpListenerContext AJOMHCGOPGD, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F18850", Offset = "0x7F17450", VA = "0x187F18850")]
	public MKDCICAOKEC()
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
		public enum MKGECHNDHNI
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
		public MKGECHNDHNI Version;

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
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OLCLCAPIKKD : DNBGACBNLAH<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F18980", Offset = "0x7F17580", VA = "0x187F18980")]
	public OLCLCAPIKKD(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> NMHLCIGMKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F188F0", Offset = "0x7F174F0", VA = "0x187F188F0", Slot = "4")]
	protected override string GAFHNCIIDFM(int JCJFNFCDOLA)
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

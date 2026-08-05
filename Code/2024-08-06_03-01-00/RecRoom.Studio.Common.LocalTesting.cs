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
public static class OFMLPMEMEHB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NJBFMLJADIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x730F0A0", Offset = "0x730D6A0", VA = "0x18730F0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int FGCNGNBAHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x730F1F0", Offset = "0x730D7F0", VA = "0x18730F1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x730F200", Offset = "0x730D800", VA = "0x18730F200")]
	public static string JAOKEKANLMG(int NANHFFBKFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x730F0D0", Offset = "0x730D6D0", VA = "0x18730F0D0")]
	public static string CJHOBFKMMKP(int NANHFFBKFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x730F160", Offset = "0x730D760", VA = "0x18730F160")]
	public static string DKOHBFAIGMI(int NANHFFBKFEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class CNAMBAGFAPF<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CNMGLIICMCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public CNMGLIICMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51C1810", Offset = "0x51BFE10", VA = "0x1851C1810")]
		internal void AFLGOPFHKHJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct AFJNEIHJLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public CNAMBAGFAPF<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private CNMGLIICMCH <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x3C83D50", Offset = "0x3C82350", VA = "0x183C83D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C84BD0", Offset = "0x3C831D0", VA = "0x183C84BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct CGKBPPNNOOP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x50B4BB0", Offset = "0x50B31B0", VA = "0x1850B4BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x50B50E0", Offset = "0x50B36E0", VA = "0x1850B50E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x51BA620", Offset = "0x51B8C20", VA = "0x1851BA620")]
	[AsyncStateMachine(typeof(CNAMBAGFAPF<>.AFJNEIHJLHG))]
	public Task OBODEABNEDH(int NANHFFBKFEG, CancellationToken EJMFFALPIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string IBIMIHHDDMK(int NANHFFBKFEG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51BA510", Offset = "0x51B8B10", VA = "0x1851BA510", Slot = "5")]
	[AsyncStateMachine(typeof(CNAMBAGFAPF<>.CGKBPPNNOOP))]
	protected virtual Task<TCommand> LMGEPLJLCGA(HttpListenerContext JDALOFPFGLC, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task INHIIGMLCBB(TCommand PDOLIFPDINM, HttpListenerContext JDALOFPFGLC, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "7")]
	protected virtual bool FPNHFKMIBOD(Exception KLEFNMOCNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected CNAMBAGFAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PBEIIMHHBAB : CNAMBAGFAPF<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x730F260", Offset = "0x730D860", VA = "0x18730F260", Slot = "5")]
	protected override Task<object> LMGEPLJLCGA(HttpListenerContext JDALOFPFGLC, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x730F060", Offset = "0x730D660", VA = "0x18730F060")]
	protected PBEIIMHHBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class HEANDKIMPGM<TCommand> : CNAMBAGFAPF<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> IHCNBCBHEAI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37D8F00", Offset = "0x37D7500", VA = "0x1837D8F00")]
	protected HEANDKIMPGM(Func<TCommand, HttpListenerContext, CancellationToken, Task> IHCNBCBHEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3D35F10", Offset = "0x3D34510", VA = "0x183D35F10", Slot = "6")]
	protected override Task INHIIGMLCBB(TCommand PDOLIFPDINM, HttpListenerContext JDALOFPFGLC, CancellationToken NNGMAHIDECE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FCAMADELJFO : PBEIIMHHBAB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x730EF40", Offset = "0x730D540", VA = "0x18730EF40", Slot = "4")]
	protected override string IBIMIHHDDMK(int NANHFFBKFEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x730EFD0", Offset = "0x730D5D0", VA = "0x18730EFD0", Slot = "6")]
	protected override Task INHIIGMLCBB(object PDOLIFPDINM, HttpListenerContext JDALOFPFGLC, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x730F060", Offset = "0x730D660", VA = "0x18730F060")]
	public FCAMADELJFO()
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
		public enum HIKHJELKIHE
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
		public HIKHJELKIHE Version;

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
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class ACLIHHGGDKJ : HEANDKIMPGM<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x730EEF0", Offset = "0x730D4F0", VA = "0x18730EEF0")]
	public ACLIHHGGDKJ(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> IHCNBCBHEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x730EE60", Offset = "0x730D460", VA = "0x18730EE60", Slot = "4")]
	protected override string IBIMIHHDDMK(int NANHFFBKFEG)
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

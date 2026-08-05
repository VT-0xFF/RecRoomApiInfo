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
public static class EGJPLGAMFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string GJFOHDJCBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x878E7C0", Offset = "0x878D9C0", VA = "0x18878E7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static int CDJJFFNAIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x878E630", Offset = "0x878D830", VA = "0x18878E630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x878E760", Offset = "0x878D960", VA = "0x18878E760")]
	public static string HNNOMNLFLEC(int AKBKPEPJIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x878E6D0", Offset = "0x878D8D0", VA = "0x18878E6D0")]
	public static string FDLHPKPLJGP(int AKBKPEPJIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x878E640", Offset = "0x878D840", VA = "0x18878E640")]
	public static string DPPFAGMAMMC(int AKBKPEPJIKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class JDAECBAONDA<TCommand>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HKDKFBAMLCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public HttpListener httpListener;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HKDKFBAMLCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA0070", Offset = "0x4B9F270", VA = "0x184BA0070")]
		internal void MIHOEODOJPI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private struct AKNAPFNABPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public JDAECBAONDA<TCommand> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int port;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CancellationToken cancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private HKDKFBAMLCA <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x4B64600", Offset = "0x4B63800", VA = "0x184B64600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4B654A0", Offset = "0x4B646A0", VA = "0x184B654A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct JAKMMNFICBG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x4E7AEE0", Offset = "0x4E7A0E0", VA = "0x184E7AEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B400", Offset = "0x4E7A600", VA = "0x184E7B400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC890", Offset = "0x4EABA90", VA = "0x184EAC890")]
	[AsyncStateMachine(typeof(JDAECBAONDA<>.AKNAPFNABPN))]
	public Task KGHLFJCGKGL(int AKBKPEPJIKB, CancellationToken ALFKNKAGCKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract string HKKGBNCFOBJ(int AKBKPEPJIKB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC790", Offset = "0x4EAB990", VA = "0x184EAC790", Slot = "5")]
	[AsyncStateMachine(typeof(JDAECBAONDA<>.JAKMMNFICBG))]
	protected virtual Task<TCommand> IGFHJKFBCDE(HttpListenerContext FHDIMELJGGJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task ALPFNGDHFII(TCommand JIIDPCMGOEK, HttpListenerContext FHDIMELJGGJ, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "7")]
	protected virtual bool EFNDCBAPKLC(Exception MJPFDOAJBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected JDAECBAONDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PIHJOLELMBM : JDAECBAONDA<object>
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x878EA30", Offset = "0x878DC30", VA = "0x18878EA30", Slot = "5")]
	protected override Task<object> IGFHJKFBCDE(HttpListenerContext FHDIMELJGGJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x878E9F0", Offset = "0x878DBF0", VA = "0x18878E9F0")]
	protected PIHJOLELMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class FMCMMEBJHHM<TCommand> : JDAECBAONDA<TCommand>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TCommand, HttpListenerContext, CancellationToken, Task> NEPHMKBIDKO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4521690", Offset = "0x4520890", VA = "0x184521690")]
	protected FMCMMEBJHHM(Func<TCommand, HttpListenerContext, CancellationToken, Task> NEPHMKBIDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x49AF960", Offset = "0x49AEB60", VA = "0x1849AF960", Slot = "6")]
	protected override Task ALPFNGDHFII(TCommand JIIDPCMGOEK, HttpListenerContext FHDIMELJGGJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NBAABEKLAOB : PIHJOLELMBM
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x878E960", Offset = "0x878DB60", VA = "0x18878E960", Slot = "4")]
	protected override string HKKGBNCFOBJ(int AKBKPEPJIKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x878E8D0", Offset = "0x878DAD0", VA = "0x18878E8D0", Slot = "6")]
	protected override Task ALPFNGDHFII(object JIIDPCMGOEK, HttpListenerContext FHDIMELJGGJ, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x878E9F0", Offset = "0x878DBF0", VA = "0x18878E9F0")]
	public NBAABEKLAOB()
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
		public enum ONCHODLKHCK
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Initial = 0,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			AddedIsObjectModelEnabled = 1,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			StudioContentInInventions = 2,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			LatestPlusOne = 3,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Latest = 2
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public ONCHODLKHCK Version;

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
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public LoadRoomCommand()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KCIHCCACEDJ : FMCMMEBJHHM<LoadRoomCommand>
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x878E880", Offset = "0x878DA80", VA = "0x18878E880")]
	public KCIHCCACEDJ(Func<LoadRoomCommand, HttpListenerContext, CancellationToken, Task> NEPHMKBIDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x878E7F0", Offset = "0x878D9F0", VA = "0x18878E7F0", Slot = "4")]
	protected override string HKKGBNCFOBJ(int AKBKPEPJIKB)
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

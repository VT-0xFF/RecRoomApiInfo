using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FCBBDKABIII
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PLEIKCJEPHC(int IPNOIEIOICA, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PLEIKCJEPHC(TimeSpan GFIEMFKDGPM, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LAILJJFDBFI : FCBBDKABIII
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6C20", Offset = "0x6EA5420", VA = "0x186EA6C20")]
	[ANLGLDAOJJE(KKPEBAHBECP.Root, ELBANFBEGNE.GameOnly)]
	private static void KOADAPLLBPC(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	[Preserve]
	public LAILJJFDBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D80", Offset = "0x6EA5580", VA = "0x186EA6D80", Slot = "4")]
	public Task PLEIKCJEPHC(int IPNOIEIOICA, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6D20", Offset = "0x6EA5520", VA = "0x186EA6D20", Slot = "5")]
	public Task PLEIKCJEPHC(TimeSpan GFIEMFKDGPM, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BLDEMDBBABF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct PENHMGBHPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest BEMKHEPJCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> KLOJGIBKNKJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
		public PENHMGBHPGI(TRequest LOGLBHMJLPF, TaskCompletionSource<TResult> KCOFFNCLPOP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LGGJBFHDOGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public BLDEMDBBABF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4147700", Offset = "0x4145F00", VA = "0x184147700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4147CA0", Offset = "0x41464A0", VA = "0x184147CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct LOOPJBMONNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BLDEMDBBABF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4170A60", Offset = "0x416F260", VA = "0x184170A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4170E50", Offset = "0x416F650", VA = "0x184170E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BBILPKEFCEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public BLDEMDBBABF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4D17760", Offset = "0x4D15F60", VA = "0x184D17760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4D17C20", Offset = "0x4D16420", VA = "0x184D17C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct FDLKEIOPNID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BLDEMDBBABF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0660", Offset = "0x3ACEE60", VA = "0x183AD0660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1700", Offset = "0x3ACFF00", VA = "0x183AD1700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GCHLIACEDDD<TRequest, TResult> FJGGHMOPCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float MIALIIDIBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FCBBDKABIII MPPKIGOKOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<PENHMGBHPGI> CIELLLOBMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource CCEPCAIAJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource IINLOMFBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task BKMMGDJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float PFELJBBIINN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC12CB0", Offset = "0xC114B0", VA = "0x180C12CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC12C60", Offset = "0xC11460", VA = "0x180C12C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D34C80", Offset = "0x4D33480", VA = "0x184D34C80")]
	public BLDEMDBBABF(GCHLIACEDDD<TRequest, TResult> FJGGHMOPCHC, TimeSpan MIALIIDIBEO, [Optional] FCBBDKABIII MPPKIGOKOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D343A0", Offset = "0x4D32BA0", VA = "0x184D343A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D34B50", Offset = "0x4D33350", VA = "0x184D34B50")]
	[AsyncStateMachine(typeof(BLDEMDBBABF<, >.LGGJBFHDOGM))]
	public Task<TResult> PEKJLGEMBDK(TRequest LOGLBHMJLPF, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D347E0", Offset = "0x4D32FE0", VA = "0x184D347E0")]
	public Task GCJCPHDNLMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D345E0", Offset = "0x4D32DE0", VA = "0x184D345E0")]
	[AsyncStateMachine(typeof(BLDEMDBBABF<, >.LOOPJBMONNN))]
	private Task EOCGBCCLBNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D348A0", Offset = "0x4D330A0", VA = "0x184D348A0")]
	[AsyncStateMachine(typeof(BLDEMDBBABF<, >.BBILPKEFCEJ))]
	private Task GLIPAKDNCEK(CancellationToken HKNKKPHDNND, CancellationToken GFEDFOOPNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D342A0", Offset = "0x4D32AA0", VA = "0x184D342A0")]
	[AsyncStateMachine(typeof(BLDEMDBBABF<, >.FDLKEIOPNID))]
	private Task CFMNMDIMFGC(CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D349C0", Offset = "0x4D331C0", VA = "0x184D349C0")]
	private TimeSpan MELNAMBAGBF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D346C0", Offset = "0x4D32EC0", VA = "0x184D346C0")]
	private Task<List<TResult>> FKPDLPBJCNK(IReadOnlyList<TRequest> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D34200", Offset = "0x4D32A00", VA = "0x184D34200")]
	private float ACCAMANEKCM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D34AA0", Offset = "0x4D332A0", VA = "0x184D34AA0")]
	private void NDFGFFBCMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IKMDEJLFPHH<TItemId, TResult> : GCHLIACEDDD<LKPFGEALGDO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> BLGKHFEDMPA(Dictionary<TItemId, int> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AEBGIFGBDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public AEBGIFGBDCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B92270", Offset = "0x3B90A70", VA = "0x183B92270")]
		internal TResult HCPGFBKJOKG(LKPFGEALGDO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BFLLBLAPCAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<LKPFGEALGDO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public IKMDEJLFPHH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AEBGIFGBDCI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D25CA0", Offset = "0x4D244A0", VA = "0x184D25CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D26A90", Offset = "0x4D25290", VA = "0x184D26A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BLGKHFEDMPA IPCEGFFCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> DLJFDIOPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3CACD20", Offset = "0x3CAB520", VA = "0x183CACD20")]
	public IKMDEJLFPHH(BLGKHFEDMPA IPCEGFFCKAM, [Optional] IEqualityComparer<TItemId> DLJFDIOPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D92400", Offset = "0x3D90C00", VA = "0x183D92400", Slot = "4")]
	[AsyncStateMachine(typeof(IKMDEJLFPHH<, >.BFLLBLAPCAK))]
	public Task<List<TResult>> LEKNLLOMLMJ(IReadOnlyList<LKPFGEALGDO<TItemId>> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HHPGECONJEJ<TRequest, TResult> : GCHLIACEDDD<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> CDLBPKOHHPB(IEnumerable<TRequest> BDCCGOGHPMC, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NAIBOHMNLIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NAIBOHMNLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD1760", Offset = "0x3ACFF60", VA = "0x183AD1760")]
		internal TResult HCPGFBKJOKG(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct EELKPKNPMON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HHPGECONJEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NAIBOHMNLIH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37450A0", Offset = "0x37438A0", VA = "0x1837450A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3745FA0", Offset = "0x37447A0", VA = "0x183745FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CDLBPKOHHPB IPCEGFFCKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> DLJFDIOPEMA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3CACD20", Offset = "0x3CAB520", VA = "0x183CACD20")]
	public HHPGECONJEJ(CDLBPKOHHPB IPCEGFFCKAM, [Optional] IEqualityComparer<TRequest> DLJFDIOPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CACBD0", Offset = "0x3CAB3D0", VA = "0x183CACBD0", Slot = "4")]
	[AsyncStateMachine(typeof(HHPGECONJEJ<, >.EELKPKNPMON))]
	public Task<List<TResult>> LEKNLLOMLMJ(IReadOnlyList<TRequest> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GCHLIACEDDD<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> LEKNLLOMLMJ(IReadOnlyList<TRequest> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HDFIHJOBPLK<TItemId, TResult> : GCHLIACEDDD<FGBMGEJMKKD<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task CCDJECLNNDK(IReadOnlyDictionary<TItemId, FGBMGEJMKKD<TItemId>.OFFMDFANFBC> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FMPKLOKPMLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public HDFIHJOBPLK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<FGBMGEJMKKD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B05040", Offset = "0x3B03840", VA = "0x183B05040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B055C0", Offset = "0x3B03DC0", VA = "0x183B055C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CCDJECLNNDK PNGCALMMDGK;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public HDFIHJOBPLK(CCDJECLNNDK PNGCALMMDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3C82750", Offset = "0x3C80F50", VA = "0x183C82750", Slot = "4")]
	[AsyncStateMachine(typeof(HDFIHJOBPLK<, >.FMPKLOKPMLM))]
	public Task<List<object>> LEKNLLOMLMJ(IReadOnlyList<FGBMGEJMKKD<TItemId>> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C82200", Offset = "0x3C80A00", VA = "0x183C82200")]
	private IReadOnlyDictionary<TItemId, FGBMGEJMKKD<TItemId>.OFFMDFANFBC> JNMONDIFFLE(IReadOnlyList<FGBMGEJMKKD<TItemId>> GNNLMLFNHNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CJIKOBIKLAM<TItemId, TResult> : GCHLIACEDDD<LKPFGEALGDO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> FMMDNNKOAPN(Dictionary<TItemId, int> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct DJCGNPLHIAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<LKPFGEALGDO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CJIKOBIKLAM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5768BC0", Offset = "0x57673C0", VA = "0x185768BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x57698D0", Offset = "0x57680D0", VA = "0x1857698D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FMMDNNKOAPN HJBHBHPJENO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	public CJIKOBIKLAM(FMMDNNKOAPN IPCEGFFCKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D2E0", Offset = "0x4F8BAE0", VA = "0x184F8D2E0", Slot = "4")]
	[AsyncStateMachine(typeof(CJIKOBIKLAM<, >.DJCGNPLHIAP))]
	public Task<List<TResult>> LEKNLLOMLMJ(IReadOnlyList<LKPFGEALGDO<TItemId>> HKEBJNJIKEN, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BKDAIMELJAG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, FOFCIDGPHKD> DKPDACOGAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> IDCDBCJFJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> ANDAGKNKLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> FDNFOEACIDH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, FOFCIDGPHKD> LHCAHHAJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> CPJJGNCJKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EKAFHCIOAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E10", Offset = "0x8B7610", VA = "0x1808B8E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D31E90", Offset = "0x4D30690", VA = "0x184D31E90")]
	public BKDAIMELJAG(Func<IEnumerable<T>> ANDAGKNKLHP, Func<T, string> FDNFOEACIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D31BC0", Offset = "0x4D303C0", VA = "0x184D31BC0")]
	public void EAHBMFPNBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D31B30", Offset = "0x4D30330", VA = "0x184D31B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FPAHJJIDMLH<TItemId, TResult> : BLDEMDBBABF<LKPFGEALGDO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3742610", Offset = "0x3740E10", VA = "0x183742610")]
	public FPAHJJIDMLH(GCHLIACEDDD<LKPFGEALGDO<TItemId>, TResult> FJGGHMOPCHC, TimeSpan MIALIIDIBEO, [Optional] FCBBDKABIII MPPKIGOKOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DE60", Offset = "0x3B1C660", VA = "0x183B1DE60")]
	public Task<TResult> PEKJLGEMBDK(TItemId JOEHGGMHBAA, int GBNKKMMAMGK, [Optional] CancellationToken ODNHMAMKFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LKPFGEALGDO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId DCGMIJFPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int OFABENHHGGA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4158930", Offset = "0x4157130", VA = "0x184158930")]
	public LKPFGEALGDO(TItemId MKJDHALNMAA, int GBNKKMMAMGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BBBJHCMBGDN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid FEJJNELNJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> FCHPNCEPPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AAEAANDDOCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface MHLOEEKONKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int BOPLCALMNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DEEEEFHNNAK<TParam>(TParam IPHHABIKCHD);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CFMIAJMGLIP(Exception JLOICJBFAKG);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AALJENBONOF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GEJKGOKKOBA<TResult> : MHLOEEKONKK, BBBJHCMBGDN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> EIMIBCHGJKJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid FEJJNELNJOI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAAE0", Offset = "0x8B92E0", VA = "0x1808BAAE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BOPLCALMNMB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> FCHPNCEPPCO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3BD0740", Offset = "0x3BCEF40", VA = "0x183BD0740", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD07A0", Offset = "0x3BCEFA0", VA = "0x183BD07A0")]
		public GEJKGOKKOBA(int HINKBBAONNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4A70", Offset = "0x28E3270", VA = "0x1828E4A70", Slot = "5")]
		public bool DEEEEFHNNAK<TParam>(TParam IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3BD06E0", Offset = "0x3BCEEE0", VA = "0x183BD06E0", Slot = "6")]
		public bool CFMIAJMGLIP(Exception JLOICJBFAKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0680", Offset = "0x3BCEE80", VA = "0x183BD0680", Slot = "7")]
		public bool AALJENBONOF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string CPACBFMIEJM = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, MHLOEEKONKK> ICAHDPIHEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DEBPBIBFMIP GPLKNAKLFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool OANIHOJCDAM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6B50", Offset = "0x6EA5350", VA = "0x186EA6B50")]
	public AAEAANDDOCD([Optional] DEBPBIBFMIP GPLKNAKLFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6430", Offset = "0x6EA4C30", VA = "0x186EA6430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x31456A0", Offset = "0x3143EA0", VA = "0x1831456A0")]
	public BBBJHCMBGDN<TResult> EEEPJMECGFB<TResult>(int LCBAFFHEBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x31459C0", Offset = "0x31441C0", VA = "0x1831459C0")]
	public bool JPAKCKFFDKP<TResult>(Guid KPJLKKPOEPH, TResult KKBKNCNBBJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6540", Offset = "0x6EA4D40", VA = "0x186EA6540")]
	private void DOGMDBCKDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6430", Offset = "0x6EA4C30", VA = "0x186EA6430")]
	private void DNEAOKGPOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6660", Offset = "0x6EA4E60", VA = "0x186EA6660")]
	private void GONHMDDGPJG(int HINKBBAONNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6950", Offset = "0x6EA5150", VA = "0x186EA6950")]
	private void NKOBNADIJPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum LANDCDLBLHN
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FGBMGEJMKKD<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class OFFMDFANFBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int AIBBHODPBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int CIADHKGIKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int DAILOGCNGCK;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public OFFMDFANFBC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId DCGMIJFPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int OFABENHHGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public LANDCDLBLHN JKOGDHNJBMM;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10C6F40", Offset = "0x10C5740", VA = "0x1810C6F40")]
	public FGBMGEJMKKD(TItemId MKJDHALNMAA, int GBNKKMMAMGK, LANDCDLBLHN CMAEAOPOFPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JPFLDGMLDEO<TItemId, TResult> : BLDEMDBBABF<FGBMGEJMKKD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3742610", Offset = "0x3740E10", VA = "0x183742610")]
	public JPFLDGMLDEO(GCHLIACEDDD<FGBMGEJMKKD<TItemId>, TResult> FJGGHMOPCHC, TimeSpan MIALIIDIBEO, [Optional] FCBBDKABIII MPPKIGOKOFN)
	{
	}
}
namespace Cpp2IlInjected;

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

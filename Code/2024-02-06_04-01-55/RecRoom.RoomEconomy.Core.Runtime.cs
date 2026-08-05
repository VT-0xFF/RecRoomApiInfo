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
public interface EHNLGNCFADK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KHHBGFLMHOB(int BFGIMBDKDMF, CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KHHBGFLMHOB(TimeSpan AJNMPCEDKGD, CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IBEHIPAEGBC : EHNLGNCFADK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6663CA0", Offset = "0x66630A0", VA = "0x186663CA0")]
	[HMKFFNEGBBO(PNDDNINAHEG.Root, FMOKCMPGPEB.GameOnly)]
	private static void BEDMHIEHCCL(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	[Preserve]
	public IBEHIPAEGBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6663DA0", Offset = "0x66631A0", VA = "0x186663DA0", Slot = "4")]
	public Task KHHBGFLMHOB(int BFGIMBDKDMF, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6663E00", Offset = "0x6663200", VA = "0x186663E00", Slot = "5")]
	public Task KHHBGFLMHOB(TimeSpan AJNMPCEDKGD, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AFMGABKMJHO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId KKBGOCHAHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int HCCJJDEJCOL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x36D0F20", Offset = "0x36D0320", VA = "0x1836D0F20")]
	public AFMGABKMJHO(TItemId CLKANEFGNMP, int LBOHBLKMJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFHIBGGMNFE<TItemId, TResult> : BIPHFEEJABD<AFMGABKMJHO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x32B59C0", Offset = "0x32B4DC0", VA = "0x1832B59C0")]
	public EFHIBGGMNFE(KJONPIOELIN<AFMGABKMJHO<TItemId>, TResult> LFKBDIEEJAK, TimeSpan MDOGJBBEIMI, [Optional] EHNLGNCFADK GDGMLGCKBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32B5860", Offset = "0x32B4C60", VA = "0x1832B5860")]
	public Task<TResult> CFAOKIAIJOK(TItemId GPGELODKPOB, int LBOHBLKMJHE, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BIPHFEEJABD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct CGFGIHFELHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest OGFKOKIGCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> FPPINIAMECE;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87C050", Offset = "0x87B450", VA = "0x18087C050")]
		public CGFGIHFELHF(TRequest DKBCOOIEPBC, TaskCompletionSource<TResult> FGKMLCAPEPJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AAPBBOGDJLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BIPHFEEJABD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36B2640", Offset = "0x36B1A40", VA = "0x1836B2640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x36B2B80", Offset = "0x36B1F80", VA = "0x1836B2B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HKOLIGBFLDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public BIPHFEEJABD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3769B80", Offset = "0x3768F80", VA = "0x183769B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3769F50", Offset = "0x3769350", VA = "0x183769F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MOALPFOPBIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BIPHFEEJABD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E07690", Offset = "0x3E06A90", VA = "0x183E07690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B30", Offset = "0x3E06F30", VA = "0x183E07B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OMPOGBCAIDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BIPHFEEJABD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3FE1160", Offset = "0x3FE0560", VA = "0x183FE1160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3FE20A0", Offset = "0x3FE14A0", VA = "0x183FE20A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KJONPIOELIN<TRequest, TResult> LFKBDIEEJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float MDOGJBBEIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EHNLGNCFADK GDGMLGCKBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<CGFGIHFELHF> PJKGLFIGMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource PHMNOEDKNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource OJDLJNENIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task FJBGOHOINOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float KJPHFLDAIEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FMCKFONPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5A100", Offset = "0xA59500", VA = "0x180A5A100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5A120", Offset = "0xA59520", VA = "0x180A5A120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4735A90", Offset = "0x4734E90", VA = "0x184735A90")]
	public BIPHFEEJABD(KJONPIOELIN<TRequest, TResult> LFKBDIEEJAK, TimeSpan MDOGJBBEIMI, [Optional] EHNLGNCFADK GDGMLGCKBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4735290", Offset = "0x4734690", VA = "0x184735290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4735170", Offset = "0x4734570", VA = "0x184735170")]
	[AsyncStateMachine(typeof(BIPHFEEJABD<, >.AAPBBOGDJLJ))]
	public Task<TResult> CFAOKIAIJOK(TRequest DKBCOOIEPBC, [Optional] CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47359D0", Offset = "0x4734DD0", VA = "0x1847359D0")]
	public Task MGKLDAEAJMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4735090", Offset = "0x4734490", VA = "0x184735090")]
	[AsyncStateMachine(typeof(BIPHFEEJABD<, >.HKOLIGBFLDC))]
	private Task CABMGPOGDNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x47357E0", Offset = "0x4734BE0", VA = "0x1847357E0")]
	[AsyncStateMachine(typeof(BIPHFEEJABD<, >.MOALPFOPBIA))]
	private Task LPOGKEHDGPG(CancellationToken PIDLOKMACNF, CancellationToken GAOJCKELEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x47354A0", Offset = "0x47348A0", VA = "0x1847354A0")]
	[AsyncStateMachine(typeof(BIPHFEEJABD<, >.OMPOGBCAIDJ))]
	private Task FELDPFMKJBO(CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4735900", Offset = "0x4734D00", VA = "0x184735900")]
	private TimeSpan MAKCAMAKIND()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x47355A0", Offset = "0x47349A0", VA = "0x1847355A0")]
	private Task<List<TResult>> IMIGGKJNEOG(IReadOnlyList<TRequest> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4735740", Offset = "0x4734B40", VA = "0x184735740")]
	private float KHAIHLNDFBB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x47356B0", Offset = "0x4734AB0", VA = "0x1847356B0")]
	private void JJDMHKPBLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KMBBICCAONG<TItemId, TResult> : KJONPIOELIN<AFMGABKMJHO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> ABPPLEPBFOA(Dictionary<TItemId, int> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IKHEDBHOKOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public IKHEDBHOKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x382AAA0", Offset = "0x3829EA0", VA = "0x18382AAA0")]
		internal TResult FPCPINJHGFB(AFMGABKMJHO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DMHBOKGFFAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<AFMGABKMJHO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public KMBBICCAONG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IKHEDBHOKOE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5016710", Offset = "0x5015B10", VA = "0x185016710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5017460", Offset = "0x5016860", VA = "0x185017460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly ABPPLEPBFOA NJNMFFMHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> BELBPGMFIAC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3DE0", Offset = "0x3AD31E0", VA = "0x183AD3DE0")]
	public KMBBICCAONG(ABPPLEPBFOA NJNMFFMHGBK, [Optional] IEqualityComparer<TItemId> BELBPGMFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3AD39F0", Offset = "0x3AD2DF0", VA = "0x183AD39F0", Slot = "4")]
	[AsyncStateMachine(typeof(KMBBICCAONG<, >.DMHBOKGFFAE))]
	public Task<List<TResult>> ECJFGLLPKLP(IReadOnlyList<AFMGABKMJHO<TItemId>> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MDJCKDDPDNB<TRequest, TResult> : KJONPIOELIN<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> COCIBCMAKGA(IEnumerable<TRequest> KACCELJHPBO, CancellationToken PPJMMMGPFGD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CDFAJJAPGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public CDFAJJAPGLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x36C0BA0", Offset = "0x36BFFA0", VA = "0x1836C0BA0")]
		internal TResult FPCPINJHGFB(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct BKHKPAPIAOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public MDJCKDDPDNB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private CDFAJJAPGLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47377C0", Offset = "0x4736BC0", VA = "0x1847377C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x47385F0", Offset = "0x47379F0", VA = "0x1847385F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly COCIBCMAKGA NJNMFFMHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> BELBPGMFIAC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3AD3DE0", Offset = "0x3AD31E0", VA = "0x183AD3DE0")]
	public MDJCKDDPDNB(COCIBCMAKGA NJNMFFMHGBK, [Optional] IEqualityComparer<TRequest> BELBPGMFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DE0490", Offset = "0x3DDF890", VA = "0x183DE0490", Slot = "4")]
	[AsyncStateMachine(typeof(MDJCKDDPDNB<, >.BKHKPAPIAOM))]
	public Task<List<TResult>> ECJFGLLPKLP(IReadOnlyList<TRequest> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KJONPIOELIN<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> ECJFGLLPKLP(IReadOnlyList<TRequest> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NOMBMNGJNAF<TItemId, TResult> : KJONPIOELIN<LECIKHOGLCF<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task MOEHJHHCGEM(IReadOnlyDictionary<TItemId, LECIKHOGLCF<TItemId>.HEBIJDNCAIL> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct GEPHCMNKFIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public NOMBMNGJNAF<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<LECIKHOGLCF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x36FE4C0", Offset = "0x36FD8C0", VA = "0x1836FE4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36FE9F0", Offset = "0x36FDDF0", VA = "0x1836FE9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MOEHJHHCGEM FHLIMKGGBHO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public NOMBMNGJNAF(MOEHJHHCGEM FHLIMKGGBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F07140", Offset = "0x3F06540", VA = "0x183F07140", Slot = "4")]
	[AsyncStateMachine(typeof(NOMBMNGJNAF<, >.GEPHCMNKFIO))]
	public Task<List<object>> ECJFGLLPKLP(IReadOnlyList<LECIKHOGLCF<TItemId>> FMMNCBEKOKF, CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F07280", Offset = "0x3F06680", VA = "0x183F07280")]
	private IReadOnlyDictionary<TItemId, LECIKHOGLCF<TItemId>.HEBIJDNCAIL> INLAIKKILEO(IReadOnlyList<LECIKHOGLCF<TItemId>> NMJFJMDEMML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EJLPCFHBDMD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, KLKMDLGLEMA> ICMIJBFNMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> LNNEINMIMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> IFIIBJFEFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> ONIDDPNGNOP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, KLKMDLGLEMA> JAAOAHKPGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> MFHJOKKLGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JEJEHIKLIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDA0", Offset = "0x8BD1A0", VA = "0x1808BDDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x32BD500", Offset = "0x32BC900", VA = "0x1832BD500")]
	public EJLPCFHBDMD(Func<IEnumerable<T>> IFIIBJFEFPM, Func<T, string> ONIDDPNGNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32BD280", Offset = "0x32BC680", VA = "0x1832BD280")]
	public void NEPLKJNDANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x32BD210", Offset = "0x32BC610", VA = "0x1832BD210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BKPPNNAFKIB<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BACFOIKNNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> DMCGIKFKMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BCHIFDOFBGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface HFKCKPEJBAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int FBPLDHCFPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OLKFEJEPKIH<TParam>(TParam ANJCCKHBJJO);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CPFEJCEJLFM(Exception ADINNMOLMOH);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GADEFLEEHNN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class GLNFCBBJMFI<TResult> : HFKCKPEJBAP, BKPPNNAFKIB<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> OGKJLJLOADA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BACFOIKNNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int FBPLDHCFPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> DMCGIKFKMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3722EC0", Offset = "0x37222C0", VA = "0x183722EC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3722F00", Offset = "0x3722300", VA = "0x183722F00")]
		public GLNFCBBJMFI(int BFCBPOKPANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x221BD80", Offset = "0x221B180", VA = "0x18221BD80", Slot = "5")]
		public bool OLKFEJEPKIH<TParam>(TParam ANJCCKHBJJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3722E40", Offset = "0x3722240", VA = "0x183722E40", Slot = "6")]
		public bool CPFEJCEJLFM(Exception ADINNMOLMOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3722E80", Offset = "0x3722280", VA = "0x183722E80", Slot = "7")]
		public bool GADEFLEEHNN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string IICPOFEDBPB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, HFKCKPEJBAP> DEMNNADOLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BKEBANLKPJP APLOPMNNAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool KJANFOHKKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6663BD0", Offset = "0x6662FD0", VA = "0x186663BD0")]
	public BCHIFDOFBGH([Optional] BKEBANLKPJP APLOPMNNAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x66634B0", Offset = "0x66628B0", VA = "0x1866634B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2452C30", Offset = "0x2452030", VA = "0x182452C30")]
	public BKPPNNAFKIB<TResult> IFBJOBHJBFD<TResult>(int ONBAABNBJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2452ED0", Offset = "0x24522D0", VA = "0x182452ED0")]
	public bool NKDHCNOHKDD<TResult>(Guid GBGAIJNEJEJ, TResult ANIEEDIHIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6663AB0", Offset = "0x6662EB0", VA = "0x186663AB0")]
	private void MGFMMBDIMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66634B0", Offset = "0x66628B0", VA = "0x1866634B0")]
	private void AACCDMHCHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66637C0", Offset = "0x6662BC0", VA = "0x1866637C0")]
	private void GPPKCKMDHII(int BFCBPOKPANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x66635C0", Offset = "0x66629C0", VA = "0x1866635C0")]
	private void EIFICIENFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HCLLJNOALAH
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LECIKHOGLCF<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class HEBIJDNCAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int GHNJOFDIKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int AHPCKLEBEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int BNJBPCEBBDD;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public HEBIJDNCAIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId KKBGOCHAHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HCCJJDEJCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HCLLJNOALAH LKDDNEIGDCK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xD60BE0", Offset = "0xD5FFE0", VA = "0x180D60BE0")]
	public LECIKHOGLCF(TItemId CLKANEFGNMP, int LBOHBLKMJHE, HCLLJNOALAH HEKLPNHIOGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class HBBNMEDLJHA<TItemId, TResult> : BIPHFEEJABD<LECIKHOGLCF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x32B59C0", Offset = "0x32B4DC0", VA = "0x1832B59C0")]
	public HBBNMEDLJHA(KJONPIOELIN<LECIKHOGLCF<TItemId>, TResult> LFKBDIEEJAK, TimeSpan MDOGJBBEIMI, [Optional] EHNLGNCFADK GDGMLGCKBFM)
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

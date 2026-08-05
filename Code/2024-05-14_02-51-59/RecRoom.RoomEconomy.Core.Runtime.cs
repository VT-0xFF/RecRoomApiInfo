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
public interface PELLGPDMMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KIFLPKKHMCM(int CBOBJNCAGCO, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KIFLPKKHMCM(TimeSpan KPACOCHCBGI, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PAJNDBCFMOA : PELLGPDMMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x692F6F0", Offset = "0x692E0F0", VA = "0x18692F6F0")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	private static void EMFBPIFAPPJ(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	[Preserve]
	public PAJNDBCFMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x692F850", Offset = "0x692E250", VA = "0x18692F850", Slot = "4")]
	public Task KIFLPKKHMCM(int CBOBJNCAGCO, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x692F7F0", Offset = "0x692E1F0", VA = "0x18692F7F0", Slot = "5")]
	public Task KIFLPKKHMCM(TimeSpan KPACOCHCBGI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JKPCDHKDMBM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct HLPMFDGPJHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest JGHIONECKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> BEPDLKBDMBJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
		public HLPMFDGPJHI(TRequest ELBMMMMNOAO, TaskCompletionSource<TResult> DJLLJHIIGHE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DHBHJAOGIHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public JKPCDHKDMBM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x524E8F0", Offset = "0x524D2F0", VA = "0x18524E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x524EDF0", Offset = "0x524D7F0", VA = "0x18524EDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct GKNFHEHCGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JKPCDHKDMBM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x39931F0", Offset = "0x3991BF0", VA = "0x1839931F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39935B0", Offset = "0x3991FB0", VA = "0x1839935B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FAMKNJIGGGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JKPCDHKDMBM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3869BE0", Offset = "0x38685E0", VA = "0x183869BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x386A080", Offset = "0x3868A80", VA = "0x18386A080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PHACFCOLCNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JKPCDHKDMBM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x42FA4A0", Offset = "0x42F8EA0", VA = "0x1842FA4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x42FB340", Offset = "0x42F9D40", VA = "0x1842FB340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GKMENGCFGIG<TRequest, TResult> OKDHGHMBFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float EDEDAEBPLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PELLGPDMMJK NKLJPGGDDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<HLPMFDGPJHI> BMGHGJOEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource MDJNGDJILNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource NJLEDLBKFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task KIGBDMLGKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float HFHCHIOAICO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DNNOPBKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB21620", Offset = "0xB20020", VA = "0x180B21620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB216A0", Offset = "0xB200A0", VA = "0x180B216A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C81BE0", Offset = "0x3C805E0", VA = "0x183C81BE0")]
	public JKPCDHKDMBM(GKMENGCFGIG<TRequest, TResult> OKDHGHMBFLO, TimeSpan EDEDAEBPLHO, [Optional] PELLGPDMMJK NKLJPGGDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C812C0", Offset = "0x3C7FCC0", VA = "0x183C812C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C815B0", Offset = "0x3C7FFB0", VA = "0x183C815B0")]
	[AsyncStateMachine(typeof(JKPCDHKDMBM<, >.DHBHJAOGIHI))]
	public Task<TResult> JCAFNODLMAP(TRequest ELBMMMMNOAO, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C81B20", Offset = "0x3C80520", VA = "0x183C81B20")]
	public Task NGGAFHOJNOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C817A0", Offset = "0x3C801A0", VA = "0x183C817A0")]
	[AsyncStateMachine(typeof(JKPCDHKDMBM<, >.GKNFHEHCGHN))]
	private Task LACFJDLNECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C81A00", Offset = "0x3C80400", VA = "0x183C81A00")]
	[AsyncStateMachine(typeof(JKPCDHKDMBM<, >.FAMKNJIGGGO))]
	private Task MLCECMIMAOB(CancellationToken INPLLJNMOEF, CancellationToken PHLFDNBAGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C81900", Offset = "0x3C80300", VA = "0x183C81900")]
	[AsyncStateMachine(typeof(JKPCDHKDMBM<, >.PHACFCOLCNO))]
	private Task LEDNMGDHBHJ(CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C816D0", Offset = "0x3C800D0", VA = "0x183C816D0")]
	private TimeSpan KHKCIDEAPDC()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C814B0", Offset = "0x3C7FEB0", VA = "0x183C814B0")]
	private Task<List<TResult>> GKLHJDBCDPH(IReadOnlyList<TRequest> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C81220", Offset = "0x3C7FC20", VA = "0x183C81220")]
	private float DOHOCKJLKHP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C81870", Offset = "0x3C80270", VA = "0x183C81870")]
	private void LBBKFNKDFNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PFBFNJJBHEG<TItemId, TResult> : GKMENGCFGIG<LAGOMILCMEJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> JHPIHONKJFH(Dictionary<TItemId, int> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IEJDNJDCMJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public IEJDNJDCMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAD60", Offset = "0x3AA9760", VA = "0x183AAAD60")]
		internal TResult LKIPOBJNOIP(LAGOMILCMEJ<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CEHOKMCOOND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<LAGOMILCMEJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PFBFNJJBHEG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private IEJDNJDCMJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4AAE8A0", Offset = "0x4AAD2A0", VA = "0x184AAE8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4AAF540", Offset = "0x4AADF40", VA = "0x184AAF540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JHPIHONKJFH HECHMCIIHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> HBDIIEEEMDN;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42C9720", Offset = "0x42C8120", VA = "0x1842C9720")]
	public PFBFNJJBHEG(JHPIHONKJFH HECHMCIIHIC, [Optional] IEqualityComparer<TItemId> HBDIIEEEMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42F5120", Offset = "0x42F3B20", VA = "0x1842F5120", Slot = "4")]
	[AsyncStateMachine(typeof(PFBFNJJBHEG<, >.CEHOKMCOOND))]
	public Task<List<TResult>> JHJGNGIPNFD(IReadOnlyList<LAGOMILCMEJ<TItemId>> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PACEEEFCNGD<TRequest, TResult> : GKMENGCFGIG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> EALCFKKFBFK(IEnumerable<TRequest> GEKMOPKEHNH, CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NHMNMPPFGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public NHMNMPPFGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3511550", Offset = "0x350FF50", VA = "0x183511550")]
		internal TResult LKIPOBJNOIP(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct OMFKKNCBKLG : IAsyncStateMachine
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
		public PACEEEFCNGD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NHMNMPPFGIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x421F4C0", Offset = "0x421DEC0", VA = "0x18421F4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4220230", Offset = "0x421EC30", VA = "0x184220230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EALCFKKFBFK HECHMCIIHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> HBDIIEEEMDN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42C9720", Offset = "0x42C8120", VA = "0x1842C9720")]
	public PACEEEFCNGD(EALCFKKFBFK HECHMCIIHIC, [Optional] IEqualityComparer<TRequest> HBDIIEEEMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42C95E0", Offset = "0x42C7FE0", VA = "0x1842C95E0", Slot = "4")]
	[AsyncStateMachine(typeof(PACEEEFCNGD<, >.OMFKKNCBKLG))]
	public Task<List<TResult>> JHJGNGIPNFD(IReadOnlyList<TRequest> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GKMENGCFGIG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JHJGNGIPNFD(IReadOnlyList<TRequest> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CCLIMHJGBCN<TItemId, TResult> : GKMENGCFGIG<KCPLMLLCCGA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task PHPHCLFJNKH(IReadOnlyDictionary<TItemId, KCPLMLLCCGA<TItemId>.KKIAHEJOCJL> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EFMIJMJPHPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CCLIMHJGBCN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<KCPLMLLCCGA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x34D8330", Offset = "0x34D6D30", VA = "0x1834D8330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x34D8830", Offset = "0x34D7230", VA = "0x1834D8830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PHPHCLFJNKH AHOLEKKFJLO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public CCLIMHJGBCN(PHPHCLFJNKH AHOLEKKFJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4AABC70", Offset = "0x4AAA670", VA = "0x184AABC70", Slot = "4")]
	[AsyncStateMachine(typeof(CCLIMHJGBCN<, >.EFMIJMJPHPK))]
	public Task<List<object>> JHJGNGIPNFD(IReadOnlyList<KCPLMLLCCGA<TItemId>> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4AAB7D0", Offset = "0x4AAA1D0", VA = "0x184AAB7D0")]
	private IReadOnlyDictionary<TItemId, KCPLMLLCCGA<TItemId>.KKIAHEJOCJL> AGLFLMHDCKL(IReadOnlyList<KCPLMLLCCGA<TItemId>> HMCDBKAIMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BCKOKFNKINB<TItemId, TResult> : GKMENGCFGIG<LAGOMILCMEJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> LFEOIHPLJDA(Dictionary<TItemId, int> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JCFCINGPBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<LAGOMILCMEJ<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public BCKOKFNKINB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C68BF0", Offset = "0x3C675F0", VA = "0x183C68BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C6A3F0", Offset = "0x3C68DF0", VA = "0x183C6A3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LFEOIHPLJDA EHHALOBNCGE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public BCKOKFNKINB(LFEOIHPLJDA HECHMCIIHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4928C90", Offset = "0x4927690", VA = "0x184928C90", Slot = "4")]
	[AsyncStateMachine(typeof(BCKOKFNKINB<, >.JCFCINGPBGP))]
	public Task<List<TResult>> JHJGNGIPNFD(IReadOnlyList<LAGOMILCMEJ<TItemId>> IPOPFDIMCBI, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PLDHAHAAJGL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, IBBHNDCDBDE> DBLBCCHFCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> PDBLBIDAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> NGAPDEENNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> CDKADOKFKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, IBBHNDCDBDE> MPLBCDLABMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> AJAFLFHEGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KCFMOFIOIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x840040", Offset = "0x83EA40", VA = "0x180840040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x430DD40", Offset = "0x430C740", VA = "0x18430DD40")]
	public PLDHAHAAJGL(Func<IEnumerable<T>> NGAPDEENNHB, Func<T, string> CDKADOKFKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x430DAF0", Offset = "0x430C4F0", VA = "0x18430DAF0")]
	public void JACDOJBEGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x430DA80", Offset = "0x430C480", VA = "0x18430DA80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NKNIEAAEGGK<TItemId, TResult> : JKPCDHKDMBM<LAGOMILCMEJ<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3993930", Offset = "0x3992330", VA = "0x183993930")]
	public NKNIEAAEGGK(GKMENGCFGIG<LAGOMILCMEJ<TItemId>, TResult> OKDHGHMBFLO, TimeSpan EDEDAEBPLHO, [Optional] PELLGPDMMJK NKLJPGGDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40DEDE0", Offset = "0x40DD7E0", VA = "0x1840DEDE0")]
	public Task<TResult> JCAFNODLMAP(TItemId KLDFLAABJKH, int BKJKKPLNCEK, [Optional] CancellationToken CFAFANOFDNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LAGOMILCMEJ<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId KHIINBPAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int BPAGHFCGDLM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E12010", Offset = "0x3E10A10", VA = "0x183E12010")]
	public LAGOMILCMEJ(TItemId CIHIJLGOACG, int BKJKKPLNCEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HABCMKPJDDN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid OKBMHFPHNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> JNOGGHFAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class JILGKIOOLML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface JDMCDNFDBIK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int DHHOKGIBJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NKCOFCFINAP<TParam>(TParam AEJBOLFACJC);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ALAONOEKHFH(Exception JJIAPADECIB);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KKNEPIDMAAA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class FPHFGPLCGAF<TResult> : JDMCDNFDBIK, HABCMKPJDDN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> GMDHFJHLOJC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid OKBMHFPHNFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85BFA0", Offset = "0x85A9A0", VA = "0x18085BFA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DHHOKGIBJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> JNOGGHFAPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x38D1A50", Offset = "0x38D0450", VA = "0x1838D1A50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x38D1AD0", Offset = "0x38D04D0", VA = "0x1838D1AD0")]
		public FPHFGPLCGAF(int KBLMOJNBKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x281B4D0", Offset = "0x2819ED0", VA = "0x18281B4D0", Slot = "5")]
		public bool NKCOFCFINAP<TParam>(TParam AEJBOLFACJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x38D1A10", Offset = "0x38D0410", VA = "0x1838D1A10", Slot = "6")]
		public bool ALAONOEKHFH(Exception JJIAPADECIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x38D1A90", Offset = "0x38D0490", VA = "0x1838D1A90", Slot = "7")]
		public bool KKNEPIDMAAA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string HFKKDPIBOOA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, JDMCDNFDBIK> NHPJLIOPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DKAMOKEDNON BICMOALBGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool IHEKIBGBOMI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x692F620", Offset = "0x692E020", VA = "0x18692F620")]
	public JILGKIOOLML([Optional] DKAMOKEDNON BICMOALBGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x692F3F0", Offset = "0x692DDF0", VA = "0x18692F3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29A1210", Offset = "0x299FC10", VA = "0x1829A1210")]
	public HABCMKPJDDN<TResult> KGMJPFOADFI<TResult>(int NJFHGGLKJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29A0EE0", Offset = "0x299F8E0", VA = "0x1829A0EE0")]
	public bool FMOCBKJEODE<TResult>(Guid ALJDBMFHGKI, TResult LKBGEIGOHEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x692F500", Offset = "0x692DF00", VA = "0x18692F500")]
	private void MGCCJAEFMKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x692F3F0", Offset = "0x692DDF0", VA = "0x18692F3F0")]
	private void HEALBBEDILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x692EF10", Offset = "0x692D910", VA = "0x18692EF10")]
	private void BBCHLNKNKAE(int KBLMOJNBKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x692F1F0", Offset = "0x692DBF0", VA = "0x18692F1F0")]
	private void COECAKCBHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum NLLNJCOLMGD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KCPLMLLCCGA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KKIAHEJOCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int MPFPAHCEKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int DGLAKHDINBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int LPPOHIMHCEA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KKIAHEJOCJL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId KHIINBPAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int BPAGHFCGDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NLLNJCOLMGD FFPJENNJMMP;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xEF10B0", Offset = "0xEEFAB0", VA = "0x180EF10B0")]
	public KCPLMLLCCGA(TItemId CIHIJLGOACG, int BKJKKPLNCEK, NLLNJCOLMGD HIHHIJKIJFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GLFMKEFDGKH<TItemId, TResult> : JKPCDHKDMBM<KCPLMLLCCGA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3993930", Offset = "0x3992330", VA = "0x183993930")]
	public GLFMKEFDGKH(GKMENGCFGIG<KCPLMLLCCGA<TItemId>, TResult> OKDHGHMBFLO, TimeSpan EDEDAEBPLHO, [Optional] PELLGPDMMJK NKLJPGGDDEG)
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

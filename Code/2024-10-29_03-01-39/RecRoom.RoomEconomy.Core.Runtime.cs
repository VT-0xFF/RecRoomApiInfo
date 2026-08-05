using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OGFAMDGCAPP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NJGLBKBLGKJ(int HKNPFBNNHCF, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NJGLBKBLGKJ(TimeSpan ANFOFEOOLEG, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DMIOJJGMAEB : OGFAMDGCAPP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7547920", Offset = "0x7546920", VA = "0x187547920")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	[RecRoom.NoEngine.Common.Preserve]
	public DMIOJJGMAEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7547A80", Offset = "0x7546A80", VA = "0x187547A80", Slot = "4")]
	public Task NJGLBKBLGKJ(int HKNPFBNNHCF, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7547A20", Offset = "0x7546A20", VA = "0x187547A20", Slot = "5")]
	public Task NJGLBKBLGKJ(TimeSpan ANFOFEOOLEG, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75482F0", Offset = "0x75472F0", VA = "0x1875482F0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ENEABPAOCBN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct GCAFPOOCNOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest BEOAJFIPBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> FJLEAPAAHKL;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
		public GCAFPOOCNOA(TRequest ONMEAHDGGOB, TaskCompletionSource<TResult> GOBKHGGOFJJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct EIJHJLDCGIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public ENEABPAOCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D240", Offset = "0x3C5C240", VA = "0x183C5D240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5D780", Offset = "0x3C5C780", VA = "0x183C5D780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct EKCKCLIKEAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ENEABPAOCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C66A60", Offset = "0x3C65A60", VA = "0x183C66A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C66E50", Offset = "0x3C65E50", VA = "0x183C66E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MCFFAKFJOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ENEABPAOCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x492CE60", Offset = "0x492BE60", VA = "0x18492CE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x492D320", Offset = "0x492C320", VA = "0x18492D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CPOIDLOADDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ENEABPAOCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7AF0", Offset = "0x5AE6AF0", VA = "0x185AE7AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8D20", Offset = "0x5AE7D20", VA = "0x185AE8D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NIOELAPFPBK<TRequest, TResult> BNHAKBJNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float OFLAECPPBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OGFAMDGCAPP AGLBEOFLHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool APKILHDKBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<GCAFPOOCNOA> GNGDGMGPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<GCAFPOOCNOA> GMBLHJEOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MADEGAAGLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource DNAFLEOLLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource CNEGIOENNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task KFDJOGPAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float ECNJEPCDFHN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MKCCGLFKGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA050", Offset = "0x8B9050", VA = "0x1808BA050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E70", Offset = "0x8B8E70", VA = "0x1808B9E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C6EAD0", Offset = "0x3C6DAD0", VA = "0x183C6EAD0")]
	public ENEABPAOCBN(NIOELAPFPBK<TRequest, TResult> BNHAKBJNHLB, TimeSpan OFLAECPPBEG, bool APKILHDKBCN, [Optional] OGFAMDGCAPP AGLBEOFLHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E120", Offset = "0x3C6D120", VA = "0x183C6E120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E4D0", Offset = "0x3C6D4D0", VA = "0x183C6E4D0")]
	[AsyncStateMachine(typeof(ENEABPAOCBN<, >.EIJHJLDCGIK))]
	public Task<TResult> IICGFHDOHJL(TRequest ONMEAHDGGOB, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E430", Offset = "0x3C6D430", VA = "0x183C6E430")]
	private void IICGFHDOHJL(TRequest ONMEAHDGGOB, TaskCompletionSource<TResult> GOBKHGGOFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E370", Offset = "0x3C6D370", VA = "0x183C6E370")]
	public Task IAGACEDCJPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E7B0", Offset = "0x3C6D7B0", VA = "0x183C6E7B0")]
	[AsyncStateMachine(typeof(ENEABPAOCBN<, >.EKCKCLIKEAB))]
	private Task NPCNEIKGMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E890", Offset = "0x3C6D890", VA = "0x183C6E890")]
	[AsyncStateMachine(typeof(ENEABPAOCBN<, >.MCFFAKFJOEO))]
	private Task PEOKAIFPDKP(CancellationToken FACBGEHKJHF, CancellationToken JCANAGCMPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E6B0", Offset = "0x3C6D6B0", VA = "0x183C6E6B0")]
	[AsyncStateMachine(typeof(ENEABPAOCBN<, >.CPOIDLOADDK))]
	private Task NHADLJNPJDL(CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C6DFA0", Offset = "0x3C6CFA0", VA = "0x183C6DFA0")]
	private TimeSpan ACPDOMDIGPJ()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E9B0", Offset = "0x3C6D9B0", VA = "0x183C6E9B0")]
	private Task<List<TResult>> PJDNKALIEBC(IReadOnlyList<TRequest> PCCOKJCODDI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E080", Offset = "0x3C6D080", VA = "0x183C6E080")]
	private float DHOBHADCHCM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6E600", Offset = "0x3C6D600", VA = "0x183C6E600")]
	private void NBFHJEPOGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DDHKKHELCOC<TItemId, TResult> : NIOELAPFPBK<ADCODMIAPFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> OLCOHKDCBCD(Dictionary<TItemId, int> PCCOKJCODDI, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ELJCCLBPKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public ELJCCLBPKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B3B0", Offset = "0x3C6A3B0", VA = "0x183C6B3B0")]
		internal TResult OCFOLADOOFC(ADCODMIAPFI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct COIEMKONAFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<ADCODMIAPFI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DDHKKHELCOC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ELJCCLBPKAM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x59F7980", Offset = "0x59F6980", VA = "0x1859F7980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x59F8770", Offset = "0x59F7770", VA = "0x1859F8770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OLCOHKDCBCD GEAFFELBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> MPGIFOAHCCG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4162B40", Offset = "0x4161B40", VA = "0x184162B40")]
	public DDHKKHELCOC(OLCOHKDCBCD GEAFFELBOIF, [Optional] IEqualityComparer<TItemId> MPGIFOAHCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E340", Offset = "0x5D6D340", VA = "0x185D6E340", Slot = "4")]
	[AsyncStateMachine(typeof(DDHKKHELCOC<, >.COIEMKONAFK))]
	public Task<List<TResult>> EAMKGHBMLMJ(IReadOnlyList<ADCODMIAPFI<TItemId>> PCCOKJCODDI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GGCAMMLBMGH<TRequest, TResult> : NIOELAPFPBK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> GBFGDAGEBCO(IEnumerable<TRequest> BNCDBCNPBHL, CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HOFNFNBLJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HOFNFNBLJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x416A2E0", Offset = "0x41692E0", VA = "0x18416A2E0")]
		internal TResult OCFOLADOOFC(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JNNFIJHBLIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GGCAMMLBMGH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private HOFNFNBLJCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x45ACBA0", Offset = "0x45ABBA0", VA = "0x1845ACBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x45ADAA0", Offset = "0x45ACAA0", VA = "0x1845ADAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GBFGDAGEBCO GEAFFELBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> MPGIFOAHCCG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4162B40", Offset = "0x4161B40", VA = "0x184162B40")]
	public GGCAMMLBMGH(GBFGDAGEBCO GEAFFELBOIF, [Optional] IEqualityComparer<TRequest> MPGIFOAHCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x41629F0", Offset = "0x41619F0", VA = "0x1841629F0", Slot = "4")]
	[AsyncStateMachine(typeof(GGCAMMLBMGH<, >.JNNFIJHBLIH))]
	public Task<List<TResult>> EAMKGHBMLMJ(IReadOnlyList<TRequest> PCCOKJCODDI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NIOELAPFPBK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> EAMKGHBMLMJ(IReadOnlyList<TRequest> PCCOKJCODDI, CancellationToken CLIKNEKJHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NPCGNEKLDHC<TItemId, TResult> : NIOELAPFPBK<LLIPGHFJGMM<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task IHADMOCBCCM(IReadOnlyDictionary<TItemId, LLIPGHFJGMM<TItemId>.OEABIICONJG> PCCOKJCODDI, CancellationToken CLIKNEKJHEI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FPMLDLDELLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NPCGNEKLDHC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<LLIPGHFJGMM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4023850", Offset = "0x4022850", VA = "0x184023850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4023DD0", Offset = "0x4022DD0", VA = "0x184023DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IHADMOCBCCM EDNMIBDBKEE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public NPCGNEKLDHC(IHADMOCBCCM EDNMIBDBKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A001A0", Offset = "0x49FF1A0", VA = "0x184A001A0", Slot = "4")]
	[AsyncStateMachine(typeof(NPCGNEKLDHC<, >.FPMLDLDELLI))]
	public Task<List<object>> EAMKGHBMLMJ(IReadOnlyList<LLIPGHFJGMM<TItemId>> PCCOKJCODDI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49FFCA0", Offset = "0x49FECA0", VA = "0x1849FFCA0")]
	private IReadOnlyDictionary<TItemId, LLIPGHFJGMM<TItemId>.OEABIICONJG> DEHIKJLPPKN(IReadOnlyList<LLIPGHFJGMM<TItemId>> CPOKJJPBDMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OHNMMAOLCHO<TItemId, TResult> : NIOELAPFPBK<ADCODMIAPFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> NNALADIFMBO(Dictionary<TItemId, int> PCCOKJCODDI, CancellationToken CLIKNEKJHEI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct ANCMFBKCLEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<ADCODMIAPFI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OHNMMAOLCHO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x43DEE00", Offset = "0x43DDE00", VA = "0x1843DEE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x43DFB20", Offset = "0x43DEB20", VA = "0x1843DFB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NNALADIFMBO LHAAABIDGFK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public OHNMMAOLCHO(NNALADIFMBO GEAFFELBOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4B12360", Offset = "0x4B11360", VA = "0x184B12360", Slot = "4")]
	[AsyncStateMachine(typeof(OHNMMAOLCHO<, >.ANCMFBKCLEF))]
	public Task<List<TResult>> EAMKGHBMLMJ(IReadOnlyList<ADCODMIAPFI<TItemId>> PCCOKJCODDI, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LIDJOPACLME<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, GBEIEIMAINC> IKKDDMDKLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> JGPOLEIAPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> ENPHKKBHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> IDFHJAGICJJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GBEIEIMAINC> NAOKPJKNHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> ONFLOGACFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MMCJJLHKBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB48CD0", Offset = "0xB47CD0", VA = "0x180B48CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x474A100", Offset = "0x4749100", VA = "0x18474A100")]
	public LIDJOPACLME(Func<IEnumerable<T>> ENPHKKBHFCP, Func<T, string> IDFHJAGICJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4749E30", Offset = "0x4748E30", VA = "0x184749E30")]
	public void ECKIEDCBBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4749DA0", Offset = "0x4748DA0", VA = "0x184749DA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DIENFCCCHMA<TItemId, TResult> : ENEABPAOCBN<ADCODMIAPFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x417D7C0", Offset = "0x417C7C0", VA = "0x18417D7C0")]
	public DIENFCCCHMA(NIOELAPFPBK<ADCODMIAPFI<TItemId>, TResult> BNHAKBJNHLB, TimeSpan OFLAECPPBEG, bool APKILHDKBCN, [Optional] OGFAMDGCAPP AGLBEOFLHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D82170", Offset = "0x5D81170", VA = "0x185D82170")]
	public Task<TResult> IICGFHDOHJL(TItemId MLAECOMLIEC, int HDGMOPCDECK, [Optional] CancellationToken CLIKNEKJHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ADCODMIAPFI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId BNEIJDCALLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int MJILKOEHJKI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x408EFD0", Offset = "0x408DFD0", VA = "0x18408EFD0")]
	public ADCODMIAPFI(TItemId LLHPGHKHNNH, int HDGMOPCDECK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface CIOAIEFNCPM<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GFAHNAHMKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BAOMMGELEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OJGPLADLHDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface INAEKHCGAFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int CMGLNMMMHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HEPDDKOLHLN<TParam>(TParam BJDKOHEGDOK);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AMIEOFDIFBG(Exception ONPDAAPKDCJ);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IHDBBNOPMJB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class NOEOFCHNKGN<TResult> : INAEKHCGAFM, CIOAIEFNCPM<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> MEEPBDOOLIJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GFAHNAHMKFI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int CMGLNMMMHJH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x98E600", Offset = "0x98D600", VA = "0x18098E600", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BAOMMGELEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x49AC830", Offset = "0x49AB830", VA = "0x1849AC830", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49FEA10", Offset = "0x49FDA10", VA = "0x1849FEA10")]
		public NOEOFCHNKGN(int LFIKOFIFEAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x33C68B0", Offset = "0x33C58B0", VA = "0x1833C68B0", Slot = "5")]
		public bool HEPDDKOLHLN<TParam>(TParam BJDKOHEGDOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x49FE950", Offset = "0x49FD950", VA = "0x1849FE950", Slot = "6")]
		public bool AMIEOFDIFBG(Exception ONPDAAPKDCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49FE9B0", Offset = "0x49FD9B0", VA = "0x1849FE9B0", Slot = "7")]
		public bool IHDBBNOPMJB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string NNILDGPAMMN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, INAEKHCGAFM> MNLHLHBMGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AAILICFLKKA AJJOOCPFBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool MCOIBELMANO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x75481F0", Offset = "0x75471F0", VA = "0x1875481F0")]
	public OJGPLADLHDJ([Optional] AAILICFLKKA AJJOOCPFBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7547CE0", Offset = "0x7546CE0", VA = "0x187547CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3149FE0", Offset = "0x3148FE0", VA = "0x183149FE0")]
	public CIOAIEFNCPM<TResult> NKKPDNKEAEF<TResult>(int DKJGNFAAHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3149C70", Offset = "0x3148C70", VA = "0x183149C70")]
	public bool BLNKPPHFLMA<TResult>(Guid HIKJHHIHDMH, TResult POCKBMKNJHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7547DF0", Offset = "0x7546DF0", VA = "0x187547DF0")]
	private void GJDEHAHBABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7547CE0", Offset = "0x7546CE0", VA = "0x187547CE0")]
	private void HJKGLCPPFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7547F10", Offset = "0x7546F10", VA = "0x187547F10")]
	private void NIHPFOJIIMC(int LFIKOFIFEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7547AE0", Offset = "0x7546AE0", VA = "0x187547AE0")]
	private void BNBKEDKEMPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum KPDIHMMBHPA
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LLIPGHFJGMM<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class OEABIICONJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int PCIAMNGHBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int LDLPAIGELPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int HFGFNGLOEKC;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public OEABIICONJG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId BNEIJDCALLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int MJILKOEHJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public KPDIHMMBHPA KNGJEKPIKDE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x18AEBA0", Offset = "0x18ADBA0", VA = "0x1818AEBA0")]
	public LLIPGHFJGMM(TItemId LLHPGHKHNNH, int HDGMOPCDECK, KPDIHMMBHPA LNLOCMMGLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NBPBAOADLMB<TItemId, TResult> : ENEABPAOCBN<LLIPGHFJGMM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x49C5210", Offset = "0x49C4210", VA = "0x1849C5210")]
	public NBPBAOADLMB(NIOELAPFPBK<LLIPGHFJGMM<TItemId>, TResult> BNHAKBJNHLB, TimeSpan OFLAECPPBEG, [Optional] OGFAMDGCAPP AGLBEOFLHDK)
	{
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

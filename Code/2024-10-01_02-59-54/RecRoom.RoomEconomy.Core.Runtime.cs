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
public interface PCPDMKNLLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GHJDACIMHNP(int KLLLKMOGFJD, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GHJDACIMHNP(TimeSpan FJILDAHNDJF, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KBJFNJAIELD : PCPDMKNLLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7486FE0", Offset = "0x74863E0", VA = "0x187486FE0")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void IBMMKCGOKOK(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	[RecRoom.NoEngine.Common.Preserve]
	public KBJFNJAIELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7486F80", Offset = "0x7486380", VA = "0x187486F80", Slot = "4")]
	public Task GHJDACIMHNP(int KLLLKMOGFJD, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7486F20", Offset = "0x7486320", VA = "0x187486F20", Slot = "5")]
	public Task GHJDACIMHNP(TimeSpan FJILDAHNDJF, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74870E0", Offset = "0x74864E0", VA = "0x1874870E0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AKHALEGPLGP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HPCBNOHPCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest GLGKCCLCIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> JHNNDDHMCHP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
		public HPCBNOHPCEL(TRequest JHKMPCADNAF, TaskCompletionSource<TResult> ONBCLJCPOHM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct JGNDLKLEFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AKHALEGPLGP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x442ADF0", Offset = "0x442A1F0", VA = "0x18442ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4085C10", Offset = "0x4085010", VA = "0x184085C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NOIBOFPLBBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AKHALEGPLGP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x48FDEB0", Offset = "0x48FD2B0", VA = "0x1848FDEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x48FE2A0", Offset = "0x48FD6A0", VA = "0x1848FE2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ABCHAMBIBAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AKHALEGPLGP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3F822A0", Offset = "0x3F816A0", VA = "0x183F822A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F82760", Offset = "0x3F81B60", VA = "0x183F82760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PPGIDCABEGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AKHALEGPLGP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B79920", Offset = "0x4B78D20", VA = "0x184B79920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B7AB40", Offset = "0x4B79F40", VA = "0x184B7AB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OGNICLOAOKH<TRequest, TResult> LEBONMNNOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float BOGOKKNOIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PCPDMKNLLIC CLPFAACAIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool GIKGKBPPDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<HPCBNOHPCEL> KAMPOLHMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<HPCBNOHPCEL> FPOBFKEFEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MPBNIIFBJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource MGNOIEAICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource OAOFCEKIEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task MKHJPAFPAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float BFHDMAPPHBJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B80D0", Offset = "0x8B74D0", VA = "0x1808B80D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B82C0", Offset = "0x8B76C0", VA = "0x1808B82C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x402D400", Offset = "0x402C800", VA = "0x18402D400")]
	public AKHALEGPLGP(OGNICLOAOKH<TRequest, TResult> LEBONMNNOAA, TimeSpan BOGOKKNOIBM, bool GIKGKBPPDIH, [Optional] PCPDMKNLLIC CLPFAACAIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x402CD90", Offset = "0x402C190", VA = "0x18402CD90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x402D080", Offset = "0x402C480", VA = "0x18402D080")]
	[AsyncStateMachine(typeof(AKHALEGPLGP<, >.JGNDLKLEFAD))]
	public Task<TResult> FPENHJKIHLC(TRequest JHKMPCADNAF, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x402CFE0", Offset = "0x402C3E0", VA = "0x18402CFE0")]
	private void FPENHJKIHLC(TRequest JHKMPCADNAF, TaskCompletionSource<TResult> ONBCLJCPOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x402D290", Offset = "0x402C690", VA = "0x18402D290")]
	public Task JELMPOCADEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x402CCB0", Offset = "0x402C0B0", VA = "0x18402CCB0")]
	[AsyncStateMachine(typeof(AKHALEGPLGP<, >.NOIBOFPLBBK))]
	private Task DMPAJONLEJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x402C8D0", Offset = "0x402BCD0", VA = "0x18402C8D0")]
	[AsyncStateMachine(typeof(AKHALEGPLGP<, >.ABCHAMBIBAJ))]
	private Task AJMFBIPCOEO(CancellationToken GJMDMFEBCAN, CancellationToken HIJDHLBFMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x402C9F0", Offset = "0x402BDF0", VA = "0x18402C9F0")]
	[AsyncStateMachine(typeof(AKHALEGPLGP<, >.PPGIDCABEGG))]
	private Task BDBLKGLDFAM(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x402D1B0", Offset = "0x402C5B0", VA = "0x18402D1B0")]
	private TimeSpan HCAGAOBGFHC()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x402CB90", Offset = "0x402BF90", VA = "0x18402CB90")]
	private Task<List<TResult>> DFLBFMDIPME(IReadOnlyList<TRequest> OAJAOPDBAAH, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x402CAF0", Offset = "0x402BEF0", VA = "0x18402CAF0")]
	private float CFIGKEFPEOL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x402D350", Offset = "0x402C750", VA = "0x18402D350")]
	private void KCDGOOHAFBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FNBMANPCFHJ<TItemId, TResult> : OGNICLOAOKH<CPAEODNHIKB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> MEOOMINOFHE(Dictionary<TItemId, int> OAJAOPDBAAH, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HCBBFIKNBCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HCBBFIKNBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4077520", Offset = "0x4076920", VA = "0x184077520")]
		internal TResult HMEIPNOGCHM(CPAEODNHIKB<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EBPKGDLJDCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<CPAEODNHIKB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FNBMANPCFHJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HCBBFIKNBCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E980", Offset = "0x3B1DD80", VA = "0x183B1E980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F770", Offset = "0x3B1EB70", VA = "0x183B1F770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly MEOOMINOFHE LBNFIFJDEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> BEBALKAAJIF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F360E0", Offset = "0x3F354E0", VA = "0x183F360E0")]
	public FNBMANPCFHJ(MEOOMINOFHE LBNFIFJDEKC, [Optional] IEqualityComparer<TItemId> BEBALKAAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F35E40", Offset = "0x3F35240", VA = "0x183F35E40", Slot = "4")]
	[AsyncStateMachine(typeof(FNBMANPCFHJ<, >.EBPKGDLJDCF))]
	public Task<List<TResult>> HDFDJBLHMBH(IReadOnlyList<CPAEODNHIKB<TItemId>> OAJAOPDBAAH, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CHNDHCIPFOG<TRequest, TResult> : OGNICLOAOKH<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> MPHNIILGDHD(IEnumerable<TRequest> FEPOPEEAPAG, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PNGDBBECOOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PNGDBBECOOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B71770", Offset = "0x3B70B70", VA = "0x183B71770")]
		internal TResult HMEIPNOGCHM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CEFGMLDBDFC : IAsyncStateMachine
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
		public CHNDHCIPFOG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PNGDBBECOOJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x530A1E0", Offset = "0x53095E0", VA = "0x18530A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x530B0E0", Offset = "0x530A4E0", VA = "0x18530B0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly MPHNIILGDHD LBNFIFJDEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> BEBALKAAJIF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F360E0", Offset = "0x3F354E0", VA = "0x183F360E0")]
	public CHNDHCIPFOG(MPHNIILGDHD LBNFIFJDEKC, [Optional] IEqualityComparer<TRequest> BEBALKAAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x531E000", Offset = "0x531D400", VA = "0x18531E000", Slot = "4")]
	[AsyncStateMachine(typeof(CHNDHCIPFOG<, >.CEFGMLDBDFC))]
	public Task<List<TResult>> HDFDJBLHMBH(IReadOnlyList<TRequest> OAJAOPDBAAH, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OGNICLOAOKH<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HDFDJBLHMBH(IReadOnlyList<TRequest> OAJAOPDBAAH, CancellationToken EEHACKMODLA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LCNNNLPFGOJ<TItemId, TResult> : OGNICLOAOKH<NGBGDMPMCFH<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task KDNGFNCOFHO(IReadOnlyDictionary<TItemId, NGBGDMPMCFH<TItemId>.FEBHHCDPHID> OAJAOPDBAAH, CancellationToken EEHACKMODLA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct BDBDOEGOAMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LCNNNLPFGOJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<NGBGDMPMCFH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x525ED90", Offset = "0x525E190", VA = "0x18525ED90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x525F310", Offset = "0x525E710", VA = "0x18525F310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KDNGFNCOFHO NHDDGMCAEAN;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public LCNNNLPFGOJ(KDNGFNCOFHO NHDDGMCAEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x45D4260", Offset = "0x45D3660", VA = "0x1845D4260", Slot = "4")]
	[AsyncStateMachine(typeof(LCNNNLPFGOJ<, >.BDBDOEGOAMA))]
	public Task<List<object>> HDFDJBLHMBH(IReadOnlyList<NGBGDMPMCFH<TItemId>> OAJAOPDBAAH, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x45D3DD0", Offset = "0x45D31D0", VA = "0x1845D3DD0")]
	private IReadOnlyDictionary<TItemId, NGBGDMPMCFH<TItemId>.FEBHHCDPHID> HBPDIJFMOGD(IReadOnlyList<NGBGDMPMCFH<TItemId>> JOKAEKEDJEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BELJAJPFPNP<TItemId, TResult> : OGNICLOAOKH<CPAEODNHIKB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> NMADLIPNNAD(Dictionary<TItemId, int> OAJAOPDBAAH, CancellationToken EEHACKMODLA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MANBKENOPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<CPAEODNHIKB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BELJAJPFPNP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4800510", Offset = "0x47FF910", VA = "0x184800510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4801F30", Offset = "0x4801330", VA = "0x184801F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NMADLIPNNAD GDDPCDDJNPK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public BELJAJPFPNP(NMADLIPNNAD LBNFIFJDEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x526DFA0", Offset = "0x526D3A0", VA = "0x18526DFA0", Slot = "4")]
	[AsyncStateMachine(typeof(BELJAJPFPNP<, >.MANBKENOPKJ))]
	public Task<List<TResult>> HDFDJBLHMBH(IReadOnlyList<CPAEODNHIKB<TItemId>> OAJAOPDBAAH, CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NDKPNJJBDGC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, LDCIFMJMAPN> JLADHCDNAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> ACCOCNIHFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> KEGHFCMHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> EBFJOFLAEJH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LDCIFMJMAPN> OOCKMHMDEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> JAMCOOOPJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BKAGLKGPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA8F190", Offset = "0xA8E590", VA = "0x180A8F190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x48A1CB0", Offset = "0x48A10B0", VA = "0x1848A1CB0")]
	public NDKPNJJBDGC(Func<IEnumerable<T>> KEGHFCMHKGM, Func<T, string> EBFJOFLAEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x48A1950", Offset = "0x48A0D50", VA = "0x1848A1950")]
	public void BNOGHBKOPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x48A1C20", Offset = "0x48A1020", VA = "0x1848A1C20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KDCCCEPGLCL<TItemId, TResult> : AKHALEGPLGP<CPAEODNHIKB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F0DE30", Offset = "0x3F0D230", VA = "0x183F0DE30")]
	public KDCCCEPGLCL(OGNICLOAOKH<CPAEODNHIKB<TItemId>, TResult> LEBONMNNOAA, TimeSpan BOGOKKNOIBM, bool GIKGKBPPDIH, [Optional] PCPDMKNLLIC CLPFAACAIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4529490", Offset = "0x4528890", VA = "0x184529490")]
	public Task<TResult> FPENHJKIHLC(TItemId GMJINMLEEAC, int BOBIFLKNIKL, [Optional] CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CPAEODNHIKB<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId HNNCALLBIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int GEAPJLJDCCD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x53E36B0", Offset = "0x53E2AB0", VA = "0x1853E36B0")]
	public CPAEODNHIKB(TItemId PKBKDBMKMMA, int BOBIFLKNIKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PGHEFGHCDFA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid OEDMAJDGCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> FMCLDANHCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JJKOJKHLEGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface NJNLOOAAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int AJEELPLJOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MMMNAMBDNML<TParam>(TParam LIHHDPOHLDK);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LFFDGNOHPCM(Exception PBLCLNMOIGC);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool PAFFPNIGIBA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class HDLCIGDGAOA<TResult> : NJNLOOAAKBG, PGHEFGHCDFA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> DEEDJNIJDCK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid OEDMAJDGCGB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int AJEELPLJOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> FMCLDANHCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4080AF0", Offset = "0x407FEF0", VA = "0x184080AF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4080C10", Offset = "0x4080010", VA = "0x184080C10")]
		public HDLCIGDGAOA(int NLPADEDPENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3040CF0", Offset = "0x30400F0", VA = "0x183040CF0", Slot = "5")]
		public bool MMMNAMBDNML<TParam>(TParam LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4080B50", Offset = "0x407FF50", VA = "0x184080B50", Slot = "6")]
		public bool LFFDGNOHPCM(Exception PBLCLNMOIGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4080BB0", Offset = "0x407FFB0", VA = "0x184080BB0", Slot = "7")]
		public bool PAFFPNIGIBA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string HGLPGACEEKB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, NJNLOOAAKBG> GHCMNDHAGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AGAELOIHELG DBLOMNLMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool BLCEALBICOC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7486E20", Offset = "0x7486220", VA = "0x187486E20")]
	public JJKOJKHLEGO([Optional] AGAELOIHELG DBLOMNLMEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74869F0", Offset = "0x7485DF0", VA = "0x1874869F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF5D0", Offset = "0x2ECE9D0", VA = "0x182ECF5D0")]
	public PGHEFGHCDFA<TResult> BLEHLOIMBKO<TResult>(int ECMJPPDMJIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2ECF260", Offset = "0x2ECE660", VA = "0x182ECF260")]
	public bool AMLNNHABFPL<TResult>(Guid NJALKLIOMDE, TResult CIFMGKBFCHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7486B00", Offset = "0x7485F00", VA = "0x187486B00")]
	private void IAAIAALEOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74869F0", Offset = "0x7485DF0", VA = "0x1874869F0")]
	private void MPFPEKFHJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7486710", Offset = "0x7485B10", VA = "0x187486710")]
	private void CJLLFDGBJEO(int NLPADEDPENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7486C20", Offset = "0x7486020", VA = "0x187486C20")]
	private void JDKLFGIFPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum JCLLCOBIODH
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class NGBGDMPMCFH<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FEBHHCDPHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int IFHCFCNAIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int ELJKDDFPLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int OGPODKFMCAH;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FEBHHCDPHID()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId HNNCALLBIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int GEAPJLJDCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public JCLLCOBIODH GFBNNMNNLFK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x17CF110", Offset = "0x17CE510", VA = "0x1817CF110")]
	public NGBGDMPMCFH(TItemId PKBKDBMKMMA, int BOBIFLKNIKL, JCLLCOBIODH PPIMIKDHEBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ONAJMJEDGKB<TItemId, TResult> : AKHALEGPLGP<NGBGDMPMCFH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4AB0D00", Offset = "0x4AB0100", VA = "0x184AB0D00")]
	public ONAJMJEDGKB(OGNICLOAOKH<NGBGDMPMCFH<TItemId>, TResult> LEBONMNNOAA, TimeSpan BOGOKKNOIBM, [Optional] PCPDMKNLLIC CLPFAACAIJK)
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

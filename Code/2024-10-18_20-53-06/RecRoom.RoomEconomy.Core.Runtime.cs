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
public interface LHCEGCIHNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OLBDNIIGJIA(int GAGMBPEFDNF, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OLBDNIIGJIA(TimeSpan ENBMMDLMKKG, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FJEKHCBIDPG : LHCEGCIHNFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7476D10", Offset = "0x7476110", VA = "0x187476D10")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void JEDBBFPEMOC(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FJEKHCBIDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7476E00", Offset = "0x7476200", VA = "0x187476E00", Slot = "4")]
	public Task OLBDNIIGJIA(int GAGMBPEFDNF, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7476E60", Offset = "0x7476260", VA = "0x187476E60", Slot = "5")]
	public Task OLBDNIIGJIA(TimeSpan ENBMMDLMKKG, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7476EC0", Offset = "0x74762C0", VA = "0x187476EC0", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HMMPAHDBAED<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct IOGJCJKAKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest HCEICHAIFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> DONGFOEKBKD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
		public IOGJCJKAKDN(TRequest BCGNIJHEBIO, TaskCompletionSource<TResult> JCMIOIBGHIO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HPLOODJHEIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public HMMPAHDBAED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4188F90", Offset = "0x4188390", VA = "0x184188F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x41754D0", Offset = "0x41748D0", VA = "0x1841754D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GJKIHKMEHNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HMMPAHDBAED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x40B2E00", Offset = "0x40B2200", VA = "0x1840B2E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x40B31F0", Offset = "0x40B25F0", VA = "0x1840B31F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KJCEHADNGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public HMMPAHDBAED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4508E10", Offset = "0x4508210", VA = "0x184508E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45092D0", Offset = "0x45086D0", VA = "0x1845092D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GKINJGHGHFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HMMPAHDBAED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x40B8680", Offset = "0x40B7A80", VA = "0x1840B8680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x40B98B0", Offset = "0x40B8CB0", VA = "0x1840B98B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IPFIMJBCEDM<TRequest, TResult> DEHOFBDDNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float EJFHAIEHCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LHCEGCIHNFJ LHFIAJCMKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool OAHBABEMIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<IOGJCJKAKDN> PNOOIDEEKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<IOGJCJKAKDN> NPKPHOEAHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool PADMDHGDCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource AAJDHLNKBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource JANDAFGDJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task OHGJCNJGHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float NDLJHEKBICM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C40", Offset = "0x8B2040", VA = "0x1808B2C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C90", Offset = "0x8B2090", VA = "0x1808B2C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41726B0", Offset = "0x4171AB0", VA = "0x1841726B0")]
	public HMMPAHDBAED(IPFIMJBCEDM<TRequest, TResult> DEHOFBDDNKJ, TimeSpan EJFHAIEHCPF, bool OAHBABEMIOO, [Optional] LHCEGCIHNFJ LHFIAJCMKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4171FF0", Offset = "0x41713F0", VA = "0x184171FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4172580", Offset = "0x4171980", VA = "0x184172580")]
	[AsyncStateMachine(typeof(HMMPAHDBAED<, >.HPLOODJHEIE))]
	public Task<TResult> PILNPCMFHEI(TRequest BCGNIJHEBIO, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x41724E0", Offset = "0x41718E0", VA = "0x1841724E0")]
	private void PILNPCMFHEI(TRequest BCGNIJHEBIO, TaskCompletionSource<TResult> JCMIOIBGHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4171C60", Offset = "0x4171060", VA = "0x184171C60")]
	public Task AFDIGDNKFAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4172360", Offset = "0x4171760", VA = "0x184172360")]
	[AsyncStateMachine(typeof(HMMPAHDBAED<, >.GJKIHKMEHNN))]
	private Task HMAFBCJDFGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4171DD0", Offset = "0x41711D0", VA = "0x184171DD0")]
	[AsyncStateMachine(typeof(HMMPAHDBAED<, >.KJCEHADNGKE))]
	private Task CMEGDDIMKGP(CancellationToken LFHGNALIJDB, CancellationToken CFIPEOCLOBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4171EF0", Offset = "0x41712F0", VA = "0x184171EF0")]
	[AsyncStateMachine(typeof(HMMPAHDBAED<, >.GKINJGHGHFC))]
	private Task DBDCOILMGIG(CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4171B80", Offset = "0x4170F80", VA = "0x184171B80")]
	private TimeSpan ACNLCICBFBO()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4172240", Offset = "0x4171640", VA = "0x184172240")]
	private Task<List<TResult>> EOLIKNBAGAH(IReadOnlyList<TRequest> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4172440", Offset = "0x4171840", VA = "0x184172440")]
	private float MEEJNGMLONM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4171D20", Offset = "0x4171120", VA = "0x184171D20")]
	private void CGPGPMEPPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BEKMDMLMDJD<TItemId, TResult> : IPFIMJBCEDM<EHMMIOLAEIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> NCNHLPBGJGN(Dictionary<TItemId, int> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DCEBAMIHMJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public DCEBAMIHMJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C927C0", Offset = "0x5C91BC0", VA = "0x185C927C0")]
		internal TResult BFLFKPACEDJ(EHMMIOLAEIM<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MAOOOAEMHHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<EHMMIOLAEIM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BEKMDMLMDJD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private DCEBAMIHMJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47B45E0", Offset = "0x47B39E0", VA = "0x1847B45E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x47B53D0", Offset = "0x47B47D0", VA = "0x1847B53D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NCNHLPBGJGN NNEGFDJKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> IPJKNPILFIK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x450FF50", Offset = "0x450F350", VA = "0x18450FF50")]
	public BEKMDMLMDJD(NCNHLPBGJGN NNEGFDJKMLI, [Optional] IEqualityComparer<TItemId> IPJKNPILFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5232E70", Offset = "0x5232270", VA = "0x185232E70", Slot = "4")]
	[AsyncStateMachine(typeof(BEKMDMLMDJD<, >.MAOOOAEMHHL))]
	public Task<List<TResult>> OLCBKHAGOHA(IReadOnlyList<EHMMIOLAEIM<TItemId>> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KNOJMJHKCFD<TRequest, TResult> : IPFIMJBCEDM<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> LEDKAAPNODD(IEnumerable<TRequest> GMNFFLNBACN, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class IPOKLBJCOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IPOKLBJCOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B0A0", Offset = "0x3B4A4A0", VA = "0x183B4B0A0")]
		internal TResult BFLFKPACEDJ(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JFLOIKJHBCO : IAsyncStateMachine
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
		public KNOJMJHKCFD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private IPOKLBJCOPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4419FE0", Offset = "0x44193E0", VA = "0x184419FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x441AEE0", Offset = "0x441A2E0", VA = "0x18441AEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LEDKAAPNODD NNEGFDJKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> IPJKNPILFIK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x450FF50", Offset = "0x450F350", VA = "0x18450FF50")]
	public KNOJMJHKCFD(LEDKAAPNODD NNEGFDJKMLI, [Optional] IEqualityComparer<TRequest> IPJKNPILFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x450FE00", Offset = "0x450F200", VA = "0x18450FE00", Slot = "4")]
	[AsyncStateMachine(typeof(KNOJMJHKCFD<, >.JFLOIKJHBCO))]
	public Task<List<TResult>> OLCBKHAGOHA(IReadOnlyList<TRequest> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IPFIMJBCEDM<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OLCBKHAGOHA(IReadOnlyList<TRequest> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PKMMDOHBHPC<TItemId, TResult> : IPFIMJBCEDM<MICNGLMIIEC<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task LMKBOLLHNDE(IReadOnlyDictionary<TItemId, MICNGLMIIEC<TItemId>.IIDHIHACLLN> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct AIGHAPEMHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PKMMDOHBHPC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<MICNGLMIIEC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE1B0", Offset = "0x3FDD5B0", VA = "0x183FDE1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3FDE730", Offset = "0x3FDDB30", VA = "0x183FDE730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LMKBOLLHNDE EIHIMPODENL;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public PKMMDOHBHPC(LMKBOLLHNDE EIHIMPODENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4B29A90", Offset = "0x4B28E90", VA = "0x184B29A90", Slot = "4")]
	[AsyncStateMachine(typeof(PKMMDOHBHPC<, >.AIGHAPEMHIO))]
	public Task<List<object>> OLCBKHAGOHA(IReadOnlyList<MICNGLMIIEC<TItemId>> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4B29590", Offset = "0x4B28990", VA = "0x184B29590")]
	private IReadOnlyDictionary<TItemId, MICNGLMIIEC<TItemId>.IIDHIHACLLN> ADLFFGCMDJD(IReadOnlyList<MICNGLMIIEC<TItemId>> NLMJAIIDFFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CCOJILKCAFL<TItemId, TResult> : IPFIMJBCEDM<EHMMIOLAEIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> BNBJHBPHAOF(Dictionary<TItemId, int> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct MNKLJHICIFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<EHMMIOLAEIM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CCOJILKCAFL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4853750", Offset = "0x4852B50", VA = "0x184853750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4855190", Offset = "0x4854590", VA = "0x184855190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BNBJHBPHAOF LDHDDLDPLAH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public CCOJILKCAFL(BNBJHBPHAOF NNEGFDJKMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x548D5E0", Offset = "0x548C9E0", VA = "0x18548D5E0", Slot = "4")]
	[AsyncStateMachine(typeof(CCOJILKCAFL<, >.MNKLJHICIFA))]
	public Task<List<TResult>> OLCBKHAGOHA(IReadOnlyList<EHMMIOLAEIM<TItemId>> FLIDBFKLGKA, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HIMDBKCEIDB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, GLMBEIECJOO> IAMBOBOBAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> NEFEIMLNFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> HNBBBCBMFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> OOMIIMDJNON;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GLMBEIECJOO> LABHLOHINBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> LHJOBKENFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NMCPDMMNAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA39D70", Offset = "0xA39170", VA = "0x180A39D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4161D30", Offset = "0x4161130", VA = "0x184161D30")]
	public HIMDBKCEIDB(Func<IEnumerable<T>> HNBBBCBMFCN, Func<T, string> OOMIIMDJNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4161A60", Offset = "0x4160E60", VA = "0x184161A60")]
	public void PPNDJIMKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41619D0", Offset = "0x4160DD0", VA = "0x1841619D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LOLBLDCLAKK<TItemId, TResult> : HMMPAHDBAED<EHMMIOLAEIM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x442FF60", Offset = "0x442F360", VA = "0x18442FF60")]
	public LOLBLDCLAKK(IPFIMJBCEDM<EHMMIOLAEIM<TItemId>, TResult> DEHOFBDDNKJ, TimeSpan EJFHAIEHCPF, bool OAHBABEMIOO, [Optional] LHCEGCIHNFJ LHFIAJCMKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x45F0220", Offset = "0x45EF620", VA = "0x1845F0220")]
	public Task<TResult> PILNPCMFHEI(TItemId OEOMDKHBDFI, int HBPMKNLKLPD, [Optional] CancellationToken NBBCMDKGJKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EHMMIOLAEIM<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId HANNDDOCDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int HBNMHCCLMHJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CF50", Offset = "0x3B6C350", VA = "0x183B6CF50")]
	public EHMMIOLAEIM(TItemId NNAHLJLIKCH, int HBPMKNLKLPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NINMADAAPMH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid OHIHJKBAAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> HACELDIBING
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FIBPNBALLDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface NOPPLLKMGDC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KNMAEEOHDKH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GJJALFPEFDA<TParam>(TParam EEPLCHCGAIN);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LMADJMKJPIB(Exception CDCDIGHMBPL);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MGLFGBPPCDO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class KENIGMEOJEL<TResult> : NOPPLLKMGDC, NINMADAAPMH<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> HLBKIOANHNK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid OHIHJKBAAOI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KNMAEEOHDKH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> HACELDIBING
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4500F20", Offset = "0x4500320", VA = "0x184500F20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4500F80", Offset = "0x4500380", VA = "0x184500F80")]
		public KENIGMEOJEL(int FFNKBLKDAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2D91A30", Offset = "0x2D90E30", VA = "0x182D91A30", Slot = "5")]
		public bool GJJALFPEFDA<TParam>(TParam EEPLCHCGAIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4500E60", Offset = "0x4500260", VA = "0x184500E60", Slot = "6")]
		public bool LMADJMKJPIB(Exception CDCDIGHMBPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4500EC0", Offset = "0x45002C0", VA = "0x184500EC0", Slot = "7")]
		public bool MGLFGBPPCDO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string PDFJGFOOIFP = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, NOPPLLKMGDC> JFODPPLGEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IEIPOIIILBP CDBIOLOOKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool FDGFFCFBIEN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7476C10", Offset = "0x7476010", VA = "0x187476C10")]
	public FIBPNBALLDA([Optional] IEIPOIIILBP CDBIOLOOKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74764F0", Offset = "0x74758F0", VA = "0x1874764F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E49B50", Offset = "0x2E48F50", VA = "0x182E49B50")]
	public NINMADAAPMH<TResult> AAOGDOGJNMH<TResult>(int PKFOBPLBOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E49E70", Offset = "0x2E49270", VA = "0x182E49E70")]
	public bool NNLGJLBMIKB<TResult>(Guid NEMMHGGPCGF, TResult IPNDOKDOGDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7476AF0", Offset = "0x7475EF0", VA = "0x187476AF0")]
	private void PAHHLJJEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74764F0", Offset = "0x74758F0", VA = "0x1874764F0")]
	private void ELEJAMMOLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7476600", Offset = "0x7475A00", VA = "0x187476600")]
	private void MCPOPJBPDPG(int FFNKBLKDAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74768F0", Offset = "0x7475CF0", VA = "0x1874768F0")]
	private void NPBHIIGKJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NDEOMCILNNC
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MICNGLMIIEC<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class IIDHIHACLLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int HHBJFAGDIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int MFMLLHIKFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int PLBINFHEHPH;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IIDHIHACLLN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId HANNDDOCDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int HBNMHCCLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NDEOMCILNNC GFIDLGHKCHM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x17826F0", Offset = "0x1781AF0", VA = "0x1817826F0")]
	public MICNGLMIIEC(TItemId NNAHLJLIKCH, int HBPMKNLKLPD, NDEOMCILNNC GHEAAGKLGOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JINGDOJBLCC<TItemId, TResult> : HMMPAHDBAED<MICNGLMIIEC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4421860", Offset = "0x4420C60", VA = "0x184421860")]
	public JINGDOJBLCC(IPFIMJBCEDM<MICNGLMIIEC<TItemId>, TResult> DEHOFBDDNKJ, TimeSpan EJFHAIEHCPF, [Optional] LHCEGCIHNFJ LHFIAJCMKMI)
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

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
public interface MMEHEIHKFNA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ELMBFKKEION(int LOCOKKOAIGD, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ELMBFKKEION(TimeSpan CGHMMIFAHPF, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AECIGHGDOGI : MMEHEIHKFNA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x721C130", Offset = "0x721AB30", VA = "0x18721C130")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	internal static void BIJCGGGFNIO(FNNNJBMCDDC NKDOKEFKKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	[RecRoom.NoEngine.Common.Preserve]
	public AECIGHGDOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x721C290", Offset = "0x721AC90", VA = "0x18721C290", Slot = "4")]
	public Task ELMBFKKEION(int LOCOKKOAIGD, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x721C230", Offset = "0x721AC30", VA = "0x18721C230", Slot = "5")]
	public Task ELMBFKKEION(TimeSpan CGHMMIFAHPF, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x721CB00", Offset = "0x721B500", VA = "0x18721CB00", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NCIJFOGBAEA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HLBDKGJPJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest BPLAKGEIDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> GOCBIFHHEAC;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEACC0", VA = "0x180CEC2C0")]
		public HLBDKGJPJPM(TRequest MGBHCKLJEHL, TaskCompletionSource<TResult> GGJEANCABJK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CLNHHNHMHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public NCIJFOGBAEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x56C53D0", Offset = "0x56C3DD0", VA = "0x1856C53D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x44968D0", Offset = "0x44952D0", VA = "0x1844968D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LFLBBNDPDOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public NCIJFOGBAEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x448A890", Offset = "0x4489290", VA = "0x18448A890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x448AC70", Offset = "0x4489670", VA = "0x18448AC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NMLDLCDAKNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public NCIJFOGBAEA<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x47F6720", Offset = "0x47F5120", VA = "0x1847F6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x47F6BD0", Offset = "0x47F55D0", VA = "0x1847F6BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct BMOFKHKDOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NCIJFOGBAEA<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x50FD470", Offset = "0x50FBE70", VA = "0x1850FD470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x50FE600", Offset = "0x50FD000", VA = "0x1850FE600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IAILFEDPIDI<TRequest, TResult> HLGCBFJCPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float GBNJLDHMEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MMEHEIHKFNA EADBJFGCCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool NCNPFIAMBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<HLBDKGJPJPM> MEDKDJANEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<HLBDKGJPJPM> GAIBGELGEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool BGIINMCBABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource GLDJJGLLGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource NHFJDAMLGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task GEGLHJKFBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float BFNHFBBAKKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88B1E0", Offset = "0x889BE0", VA = "0x18088B1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88B220", Offset = "0x889C20", VA = "0x18088B220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x47923E0", Offset = "0x4790DE0", VA = "0x1847923E0")]
	public NCIJFOGBAEA(IAILFEDPIDI<TRequest, TResult> HLGCBFJCPPM, TimeSpan GBNJLDHMEPB, bool NCNPFIAMBFJ, [Optional] MMEHEIHKFNA EADBJFGCCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4791C70", Offset = "0x4790670", VA = "0x184791C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x47918F0", Offset = "0x47902F0", VA = "0x1847918F0")]
	[AsyncStateMachine(typeof(NCIJFOGBAEA<, >.CLNHHNHMHNG))]
	public Task<TResult> AALEGLNKOFM(TRequest MGBHCKLJEHL, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4791A10", Offset = "0x4790410", VA = "0x184791A10")]
	private void AALEGLNKOFM(TRequest MGBHCKLJEHL, TaskCompletionSource<TResult> GGJEANCABJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4791EB0", Offset = "0x47908B0", VA = "0x184791EB0")]
	public Task FDNKFBMIKJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4792310", Offset = "0x4790D10", VA = "0x184792310")]
	[AsyncStateMachine(typeof(NCIJFOGBAEA<, >.LFLBBNDPDOH))]
	private Task OKCNGPHCMEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4791AB0", Offset = "0x47904B0", VA = "0x184791AB0")]
	[AsyncStateMachine(typeof(NCIJFOGBAEA<, >.NMLDLCDAKNB))]
	private Task BCGAJMKDJHL(CancellationToken PHMIDMJHENI, CancellationToken JJHKAIJANDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4792210", Offset = "0x4790C10", VA = "0x184792210")]
	[AsyncStateMachine(typeof(NCIJFOGBAEA<, >.BMOFKHKDOHC))]
	private Task MJPKIAPOBFN(CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4792130", Offset = "0x4790B30", VA = "0x184792130")]
	private TimeSpan LKBJNKKBBEE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4792010", Offset = "0x4790A10", VA = "0x184792010")]
	private Task<List<TResult>> HPIGCEMPKCK(IReadOnlyList<TRequest> ENBJOACEOJO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4791F70", Offset = "0x4790970", VA = "0x184791F70")]
	private float FLPFJEEODGH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4791BD0", Offset = "0x47905D0", VA = "0x184791BD0")]
	private void DBLOLBPJIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PLAILNCAAMK<TItemId, TResult> : IAILFEDPIDI<COACDGEPMGO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> IIHNLHJAGAA(Dictionary<TItemId, int> ENBJOACEOJO, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AJCDOJNEAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AJCDOJNEAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3E99470", Offset = "0x3E97E70", VA = "0x183E99470")]
		internal TResult IHNLPMGJPNK(COACDGEPMGO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JLOJMPLLNPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<COACDGEPMGO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PLAILNCAAMK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private AJCDOJNEAJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4305210", Offset = "0x4303C10", VA = "0x184305210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4305F50", Offset = "0x4304950", VA = "0x184305F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IIHNLHJAGAA GAANDECFJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> JJCIHJBGFLO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AA50", Offset = "0x3E79450", VA = "0x183E7AA50")]
	public PLAILNCAAMK(IIHNLHJAGAA GAANDECFJBF, [Optional] IEqualityComparer<TItemId> JJCIHJBGFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49BBEE0", Offset = "0x49BA8E0", VA = "0x1849BBEE0", Slot = "4")]
	[AsyncStateMachine(typeof(PLAILNCAAMK<, >.JLOJMPLLNPA))]
	public Task<List<TResult>> BCBGEEEGCDH(IReadOnlyList<COACDGEPMGO<TItemId>> ENBJOACEOJO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ABLMDOAHKLJ<TRequest, TResult> : IAILFEDPIDI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> LECMJAKIABM(IEnumerable<TRequest> KEFMAOCKCGL, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DHDNOFMBJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DHDNOFMBJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A4B200", Offset = "0x3A49C00", VA = "0x183A4B200")]
		internal TResult IHNLPMGJPNK(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct POJOECJOPAF : IAsyncStateMachine
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
		public ABLMDOAHKLJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private DHDNOFMBJJB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x49C5C00", Offset = "0x49C4600", VA = "0x1849C5C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x49C6A40", Offset = "0x49C5440", VA = "0x1849C6A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LECMJAKIABM GAANDECFJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> JJCIHJBGFLO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E7AA50", Offset = "0x3E79450", VA = "0x183E7AA50")]
	public ABLMDOAHKLJ(LECMJAKIABM GAANDECFJBF, [Optional] IEqualityComparer<TRequest> JJCIHJBGFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E7A910", Offset = "0x3E79310", VA = "0x183E7A910", Slot = "4")]
	[AsyncStateMachine(typeof(ABLMDOAHKLJ<, >.POJOECJOPAF))]
	public Task<List<TResult>> BCBGEEEGCDH(IReadOnlyList<TRequest> ENBJOACEOJO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IAILFEDPIDI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> BCBGEEEGCDH(IReadOnlyList<TRequest> ENBJOACEOJO, CancellationToken LOIOCMLGMKH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NHMLOKMNFLG<TItemId, TResult> : IAILFEDPIDI<DJIHCADPJPC<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task CKLAMHLKFOG(IReadOnlyDictionary<TItemId, DJIHCADPJPC<TItemId>.AHMKGMMGJGH> ENBJOACEOJO, CancellationToken LOIOCMLGMKH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MCDJKFOPBEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NHMLOKMNFLG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<DJIHCADPJPC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x468F820", Offset = "0x468E220", VA = "0x18468F820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x468FD70", Offset = "0x468E770", VA = "0x18468FD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly CKLAMHLKFOG NNPFMNFLDEA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public NHMLOKMNFLG(CKLAMHLKFOG NNPFMNFLDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47ECB60", Offset = "0x47EB560", VA = "0x1847ECB60", Slot = "4")]
	[AsyncStateMachine(typeof(NHMLOKMNFLG<, >.MCDJKFOPBEP))]
	public Task<List<object>> BCBGEEEGCDH(IReadOnlyList<DJIHCADPJPC<TItemId>> ENBJOACEOJO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x47ECCA0", Offset = "0x47EB6A0", VA = "0x1847ECCA0")]
	private IReadOnlyDictionary<TItemId, DJIHCADPJPC<TItemId>.AHMKGMMGJGH> LBKHHEOBBIM(IReadOnlyList<DJIHCADPJPC<TItemId>> NDBBGGKPFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AGCFIENIGBH<TItemId, TResult> : IAILFEDPIDI<COACDGEPMGO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> HLDBJMJCMFE(Dictionary<TItemId, int> ENBJOACEOJO, CancellationToken LOIOCMLGMKH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct EAOKCOECJMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<COACDGEPMGO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AGCFIENIGBH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x39FC720", Offset = "0x39FB120", VA = "0x1839FC720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x39FD3D0", Offset = "0x39FBDD0", VA = "0x1839FD3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HLDBJMJCMFE MFMGJGGOOIE;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public AGCFIENIGBH(HLDBJMJCMFE GAANDECFJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3E95CD0", Offset = "0x3E946D0", VA = "0x183E95CD0", Slot = "4")]
	[AsyncStateMachine(typeof(AGCFIENIGBH<, >.EAOKCOECJMN))]
	public Task<List<TResult>> BCBGEEEGCDH(IReadOnlyList<COACDGEPMGO<TItemId>> ENBJOACEOJO, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EIKPCLHDGEA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, BIECMIJGBJH> HNGFGPKHNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> HPHDIECEBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> EMKMNMNENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> OGPNCOKCOLJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, BIECMIJGBJH> LGIEDGJAJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> BPJMKCAHOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DLEMAGJAPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9BE080", Offset = "0x9BCA80", VA = "0x1809BE080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3A21650", Offset = "0x3A20050", VA = "0x183A21650")]
	public EIKPCLHDGEA(Func<IEnumerable<T>> EMKMNMNENAE, Func<T, string> OGPNCOKCOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3A21390", Offset = "0x3A1FD90", VA = "0x183A21390")]
	public void EOBPLEKHDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A21300", Offset = "0x3A1FD00", VA = "0x183A21300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PGMKLIOAEOO<TItemId, TResult> : NCIJFOGBAEA<COACDGEPMGO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA5450", Offset = "0x3EA3E50", VA = "0x183EA5450")]
	public PGMKLIOAEOO(IAILFEDPIDI<COACDGEPMGO<TItemId>, TResult> HLGCBFJCPPM, TimeSpan GBNJLDHMEPB, bool NCNPFIAMBFJ, [Optional] MMEHEIHKFNA EADBJFGCCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x49A7E30", Offset = "0x49A6830", VA = "0x1849A7E30")]
	public Task<TResult> AALEGLNKOFM(TItemId COMNIKKFEEB, int OGAPOFLNEHO, [Optional] CancellationToken LOIOCMLGMKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class COACDGEPMGO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId PNPBNNNJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int LNNNPEFHALM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x57A8530", Offset = "0x57A6F30", VA = "0x1857A8530")]
	public COACDGEPMGO(TItemId MCGOHIJBLDK, int OGAPOFLNEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FOMMFFEGFLO<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid NMADGHJLOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> NHDCIKJNAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NNGLHHCKLCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface KMOICAMAMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int JLFELIPPALD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ECBIKMABKLM<TParam>(TParam IPHMAHBENGI);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ELDBFIHIIFG(Exception OANLHKKGJFA);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DBNEHFPEIAL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class CCJCNHAJBMP<TResult> : KMOICAMAMLJ, FOMMFFEGFLO<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> FEMNMDPKHGE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid NMADGHJLOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JLFELIPPALD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> NHDCIKJNAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x47781A0", Offset = "0x4776BA0", VA = "0x1847781A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53E1F60", Offset = "0x53E0960", VA = "0x1853E1F60")]
		public CCJCNHAJBMP(int GGJJCNCIAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB6B0", Offset = "0x2ADA0B0", VA = "0x182ADB6B0", Slot = "5")]
		public bool ECBIKMABKLM<TParam>(TParam IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53E1F10", Offset = "0x53E0910", VA = "0x1853E1F10", Slot = "6")]
		public bool ELDBFIHIIFG(Exception OANLHKKGJFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53E1EC0", Offset = "0x53E08C0", VA = "0x1853E1EC0", Slot = "7")]
		public bool DBNEHFPEIAL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string MPFPDCEAGKC = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, KMOICAMAMLJ> GOOIGGCPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly ILALBPIBMCK EFODELKBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool EJICMMNAIIG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x721CA00", Offset = "0x721B400", VA = "0x18721CA00")]
	public NNGLHHCKLCI([Optional] ILALBPIBMCK EFODELKBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x721C4F0", Offset = "0x721AEF0", VA = "0x18721C4F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2EDAD40", Offset = "0x2ED9740", VA = "0x182EDAD40")]
	public FOMMFFEGFLO<TResult> LCAPDPAOCII<TResult>(int HGAGEHCMEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2EDA9D0", Offset = "0x2ED93D0", VA = "0x182EDA9D0")]
	public bool ANGOPJFOCCD<TResult>(Guid OOCNLFNKKML, TResult NLAECIHBKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x721C600", Offset = "0x721B000", VA = "0x18721C600")]
	private void HEPADLODEOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x721C4F0", Offset = "0x721AEF0", VA = "0x18721C4F0")]
	private void KILOIEMFKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x721C720", Offset = "0x721B120", VA = "0x18721C720")]
	private void PHPCFOCIAJF(int GGJJCNCIAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x721C2F0", Offset = "0x721ACF0", VA = "0x18721C2F0")]
	private void CEKCDHIPDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum GMCBDIILCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DJIHCADPJPC<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AHMKGMMGJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int NHOBKPBFFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int DCOGHBOOLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int HBMNBLKHDDJ;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public AHMKGMMGJGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId PNPBNNNJPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int LNNNPEFHALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public GMCBDIILCLL NKLHEHHPAAC;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x163A8E0", Offset = "0x16392E0", VA = "0x18163A8E0")]
	public DJIHCADPJPC(TItemId MCGOHIJBLDK, int OGAPOFLNEHO, GMCBDIILCLL FCLIEHCKPJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FJKMMBJIIKN<TItemId, TResult> : NCIJFOGBAEA<DJIHCADPJPC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE820", Offset = "0x3DFD220", VA = "0x183DFE820")]
	public FJKMMBJIIKN(IAILFEDPIDI<DJIHCADPJPC<TItemId>, TResult> HLGCBFJCPPM, TimeSpan GBNJLDHMEPB, [Optional] MMEHEIHKFNA EADBJFGCCPE)
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

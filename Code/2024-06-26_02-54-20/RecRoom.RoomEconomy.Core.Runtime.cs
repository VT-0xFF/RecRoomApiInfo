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
public interface HFKPGOPNCON
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ADJOAGFFBLM(int PCLKNDGANEI, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ADJOAGFFBLM(TimeSpan AHBLHAPCGID, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JMGHBALPGDA : HFKPGOPNCON
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D380", Offset = "0x6F9B980", VA = "0x186F9D380")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	private static void DBDMEAACDHD(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	[Preserve]
	public JMGHBALPGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D320", Offset = "0x6F9B920", VA = "0x186F9D320", Slot = "4")]
	public Task ADJOAGFFBLM(int PCLKNDGANEI, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D2C0", Offset = "0x6F9B8C0", VA = "0x186F9D2C0", Slot = "5")]
	public Task ADJOAGFFBLM(TimeSpan AHBLHAPCGID, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NAMNILFOJED<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct KJGGPMOOLJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest EKKCLFIOMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> BICEGINCAAA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
		public KJGGPMOOLJN(TRequest BDMHFDNBPPE, TaskCompletionSource<TResult> DOBFIJDMMAG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JNCKOIOMPGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NAMNILFOJED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x410F8F0", Offset = "0x410DEF0", VA = "0x18410F8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x410FE90", Offset = "0x410E490", VA = "0x18410FE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BPFNIOIJFCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NAMNILFOJED<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4E91020", Offset = "0x4E8F620", VA = "0x184E91020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E91410", Offset = "0x4E8FA10", VA = "0x184E91410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LJBINMAMCIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NAMNILFOJED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x42C70A0", Offset = "0x42C56A0", VA = "0x1842C70A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x42C7560", Offset = "0x42C5B60", VA = "0x1842C7560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct ADAJECAABGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NAMNILFOJED<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3CC9BA0", Offset = "0x3CC81A0", VA = "0x183CC9BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAC60", Offset = "0x3CC9260", VA = "0x183CCAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HGLHGHEFCOL<TRequest, TResult> JBEADIEHMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float MMFGIMEDIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HFKPGOPNCON FKGKLGIDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<KJGGPMOOLJN> PIOLMKAPMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource NJPGILOHCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource CLIDGAAPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task DHHKJGLEJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float DDDCDAJECGI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC5D420", Offset = "0xC5BA20", VA = "0x180C5D420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC5D160", Offset = "0xC5B760", VA = "0x180C5D160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45303C0", Offset = "0x452E9C0", VA = "0x1845303C0")]
	public NAMNILFOJED(HGLHGHEFCOL<TRequest, TResult> JBEADIEHMJH, TimeSpan MMFGIMEDIBJ, [Optional] HFKPGOPNCON FKGKLGIDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x452FA60", Offset = "0x452E060", VA = "0x18452FA60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45301F0", Offset = "0x452E7F0", VA = "0x1845301F0")]
	[AsyncStateMachine(typeof(NAMNILFOJED<, >.JNCKOIOMPGI))]
	public Task<TResult> PKAHMBMGLNI(TRequest BDMHFDNBPPE, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x452FF30", Offset = "0x452E530", VA = "0x18452FF30")]
	public Task LCKAJIEFFKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4530110", Offset = "0x452E710", VA = "0x184530110")]
	[AsyncStateMachine(typeof(NAMNILFOJED<, >.BPFNIOIJFCG))]
	private Task PACFINBNAIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x452F940", Offset = "0x452DF40", VA = "0x18452F940")]
	[AsyncStateMachine(typeof(NAMNILFOJED<, >.LJBINMAMCIM))]
	private Task AKGJFKLGJNJ(CancellationToken CDIKNFJEDPC, CancellationToken JJCDIDIMEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x452FD80", Offset = "0x452E380", VA = "0x18452FD80")]
	[AsyncStateMachine(typeof(NAMNILFOJED<, >.ADAJECAABGH))]
	private Task HHBABDOFGHG(CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x452FCA0", Offset = "0x452E2A0", VA = "0x18452FCA0")]
	private TimeSpan GPDPCPFGKJE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x452FFF0", Offset = "0x452E5F0", VA = "0x18452FFF0")]
	private Task<List<TResult>> OCCNKECKCCE(IReadOnlyList<TRequest> DGOFCABMPCN, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4530320", Offset = "0x452E920", VA = "0x184530320")]
	private float PLFKMOLCNJK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x452FE80", Offset = "0x452E480", VA = "0x18452FE80")]
	private void IHJILJBOKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class APCKAHBAJEP<TItemId, TResult> : HGLHGHEFCOL<GCMBKLOKGPK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> CAHGOGJILMD(Dictionary<TItemId, int> DGOFCABMPCN, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class HAGKGBJPCBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HAGKGBJPCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3DA68C0", Offset = "0x3DA4EC0", VA = "0x183DA68C0")]
		internal TResult BOKEDFMPHGA(GCMBKLOKGPK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NLJLNEJEIML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<GCMBKLOKGPK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public APCKAHBAJEP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private HAGKGBJPCBD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4574580", Offset = "0x4572B80", VA = "0x184574580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4575390", Offset = "0x4573990", VA = "0x184575390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly CAHGOGJILMD NMLFAHAECAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> PJCHJFCBECF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E78930", Offset = "0x3E76F30", VA = "0x183E78930")]
	public APCKAHBAJEP(CAHGOGJILMD NMLFAHAECAG, [Optional] IEqualityComparer<TItemId> PJCHJFCBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E7E5B0", Offset = "0x3E7CBB0", VA = "0x183E7E5B0", Slot = "4")]
	[AsyncStateMachine(typeof(APCKAHBAJEP<, >.NLJLNEJEIML))]
	public Task<List<TResult>> OHCJHNBANHI(IReadOnlyList<GCMBKLOKGPK<TItemId>> DGOFCABMPCN, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ANKGCDDFIBM<TRequest, TResult> : HGLHGHEFCOL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> AMMNJNEBGFK(IEnumerable<TRequest> LJHFJKOINPH, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LPACELBCKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LPACELBCKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C58B80", Offset = "0x3C57180", VA = "0x183C58B80")]
		internal TResult BOKEDFMPHGA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct PDGAGOCCPNM : IAsyncStateMachine
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
		public ANKGCDDFIBM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LPACELBCKIP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x474C3F0", Offset = "0x474A9F0", VA = "0x18474C3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x474D310", Offset = "0x474B910", VA = "0x18474D310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly AMMNJNEBGFK NMLFAHAECAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> PJCHJFCBECF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E78930", Offset = "0x3E76F30", VA = "0x183E78930")]
	public ANKGCDDFIBM(AMMNJNEBGFK NMLFAHAECAG, [Optional] IEqualityComparer<TRequest> PJCHJFCBECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E787E0", Offset = "0x3E76DE0", VA = "0x183E787E0", Slot = "4")]
	[AsyncStateMachine(typeof(ANKGCDDFIBM<, >.PDGAGOCCPNM))]
	public Task<List<TResult>> OHCJHNBANHI(IReadOnlyList<TRequest> DGOFCABMPCN, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HGLHGHEFCOL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OHCJHNBANHI(IReadOnlyList<TRequest> DGOFCABMPCN, CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LBAMAMCAPID<TItemId, TResult> : HGLHGHEFCOL<MLMLFGAPHOF<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task LDLBHEBBKKK(IReadOnlyDictionary<TItemId, MLMLFGAPHOF<TItemId>.JJDOIHJGENP> DGOFCABMPCN, CancellationToken DADBOHKBJNO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct FDCBEMCNPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LBAMAMCAPID<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<MLMLFGAPHOF<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C22850", Offset = "0x3C20E50", VA = "0x183C22850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C22DE0", Offset = "0x3C213E0", VA = "0x183C22DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LDLBHEBBKKK CAPOAGKJLOM;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public LBAMAMCAPID(LDLBHEBBKKK CAPOAGKJLOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x42A1030", Offset = "0x429F630", VA = "0x1842A1030", Slot = "4")]
	[AsyncStateMachine(typeof(LBAMAMCAPID<, >.FDCBEMCNPMM))]
	public Task<List<object>> OHCJHNBANHI(IReadOnlyList<MLMLFGAPHOF<TItemId>> DGOFCABMPCN, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x42A0BA0", Offset = "0x429F1A0", VA = "0x1842A0BA0")]
	private IReadOnlyDictionary<TItemId, MLMLFGAPHOF<TItemId>.JJDOIHJGENP> LDPCCAHEHPI(IReadOnlyList<MLMLFGAPHOF<TItemId>> AMFKOFDDLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ANCMAKBOKDJ<TItemId, TResult> : HGLHGHEFCOL<GCMBKLOKGPK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> FEEBGDHIHLH(Dictionary<TItemId, int> DGOFCABMPCN, CancellationToken DADBOHKBJNO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct EODLLNINEGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<GCMBKLOKGPK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ANCMAKBOKDJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38399C0", Offset = "0x3837FC0", VA = "0x1838399C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x383A6D0", Offset = "0x3838CD0", VA = "0x18383A6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FEEBGDHIHLH JHGJNAFKPAC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public ANCMAKBOKDJ(FEEBGDHIHLH NMLFAHAECAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E76600", Offset = "0x3E74C00", VA = "0x183E76600", Slot = "4")]
	[AsyncStateMachine(typeof(ANCMAKBOKDJ<, >.EODLLNINEGJ))]
	public Task<List<TResult>> OHCJHNBANHI(IReadOnlyList<GCMBKLOKGPK<TItemId>> DGOFCABMPCN, CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NKFDPFECLBM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, HGBNDFBPIAF> IFFHEPMGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> MCMGIMFADDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> NCMBCIHIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> FGMKLIPPIMA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, HGBNDFBPIAF> DBJLBIJEBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> OHBJICMDHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FECBKLIFFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D0", Offset = "0x8D76D0", VA = "0x1808D90D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x456D160", Offset = "0x456B760", VA = "0x18456D160")]
	public NKFDPFECLBM(Func<IEnumerable<T>> NCMBCIHIJGE, Func<T, string> FGMKLIPPIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x456CE90", Offset = "0x456B490", VA = "0x18456CE90")]
	public void OMKLHJHPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x456CE00", Offset = "0x456B400", VA = "0x18456CE00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PJLOPANAEBO<TItemId, TResult> : NAMNILFOJED<GCMBKLOKGPK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x418A8E0", Offset = "0x4188EE0", VA = "0x18418A8E0")]
	public PJLOPANAEBO(HGLHGHEFCOL<GCMBKLOKGPK<TItemId>, TResult> JBEADIEHMJH, TimeSpan MMFGIMEDIBJ, [Optional] HFKPGOPNCON FKGKLGIDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4767D40", Offset = "0x4766340", VA = "0x184767D40")]
	public Task<TResult> PKAHMBMGLNI(TItemId BHEIPBKEDLG, int IPAODJJPKNM, [Optional] CancellationToken DADBOHKBJNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GCMBKLOKGPK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId OOLCIIIJDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int HPLBFPGDGPM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D13780", Offset = "0x3D11D80", VA = "0x183D13780")]
	public GCMBKLOKGPK(TItemId BINMNDOPBLO, int IPAODJJPKNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GOEOFCFHJBC<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CLFHPNONDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> OPLHKNPCHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NNJFIHHPFKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface NBFIMDJGCKF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int DNAMFBMHNJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CMINOCAFICL<TParam>(TParam CBAEIEAPLIH);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JIDGJDGBCLC(Exception PHPBNDIBHHP);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JLNIGMCKLKH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class LFLHILMBPJH<TResult> : NBFIMDJGCKF, GOEOFCFHJBC<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> JJKMKHFJDHK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CLFHPNONDLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DNAMFBMHNJD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> OPLHKNPCHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x42AA680", Offset = "0x42A8C80", VA = "0x1842AA680", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x42AA740", Offset = "0x42A8D40", VA = "0x1842AA740")]
		public LFLHILMBPJH(int NALNPCCKDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A95BC0", Offset = "0x2A941C0", VA = "0x182A95BC0", Slot = "5")]
		public bool CMINOCAFICL<TParam>(TParam CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x42AA620", Offset = "0x42A8C20", VA = "0x1842AA620", Slot = "6")]
		public bool JIDGJDGBCLC(Exception PHPBNDIBHHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x42AA6E0", Offset = "0x42A8CE0", VA = "0x1842AA6E0", Slot = "7")]
		public bool JLNIGMCKLKH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string LKCKDKFLFIK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, NBFIMDJGCKF> NMGAMFFPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BMLFBKBONBE OLHEEEDPCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool EFBFHMNDHEF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DBA0", Offset = "0x6F9C1A0", VA = "0x186F9DBA0")]
	public NNJFIHHPFKM([Optional] BMLFBKBONBE OLHEEEDPCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D5A0", Offset = "0x6F9BBA0", VA = "0x186F9D5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C75FE0", Offset = "0x2C745E0", VA = "0x182C75FE0")]
	public GOEOFCFHJBC<TResult> KPFANHJDELO<TResult>(int HNLGFHCKEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C76300", Offset = "0x2C74900", VA = "0x182C76300")]
	public bool MIJMFAGPMPL<TResult>(Guid PNICJCCCLKL, TResult HJBJAPKPPFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D480", Offset = "0x6F9BA80", VA = "0x186F9D480")]
	private void DIAOGPHPDNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D5A0", Offset = "0x6F9BBA0", VA = "0x186F9D5A0")]
	private void HPJJHJLJIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D8B0", Offset = "0x6F9BEB0", VA = "0x186F9D8B0")]
	private void NGOBNABHIGA(int NALNPCCKDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F9D6B0", Offset = "0x6F9BCB0", VA = "0x186F9D6B0")]
	private void HCBBOLLNOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum JDIFOJEIECO
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MLMLFGAPHOF<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JJDOIHJGENP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int CCACAOJCKEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int NAFDEKMPDFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int ILGMALIMBDM;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JJDOIHJGENP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId OOLCIIIJDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int HPLBFPGDGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public JDIFOJEIECO DHPDJBINGBE;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10E52C0", Offset = "0x10E38C0", VA = "0x1810E52C0")]
	public MLMLFGAPHOF(TItemId BINMNDOPBLO, int IPAODJJPKNM, JDIFOJEIECO CHNGFEKJHON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BIFPKFBDPBA<TItemId, TResult> : NAMNILFOJED<MLMLFGAPHOF<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x418A8E0", Offset = "0x4188EE0", VA = "0x18418A8E0")]
	public BIFPKFBDPBA(HGLHGHEFCOL<MLMLFGAPHOF<TItemId>, TResult> JBEADIEHMJH, TimeSpan MMFGIMEDIBJ, [Optional] HFKPGOPNCON FKGKLGIDEGM)
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

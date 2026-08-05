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
public interface KIHJHHPPJMA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BIEAGBJDOJG(TimeSpan MFCJMPCEPEB, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ODIODBEDNLF : KIHJHHPPJMA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62392D0", Offset = "0x62380D0", VA = "0x1862392D0")]
	[GAPOPKHLLNB(KLEBEPKJPOL.Root, OGJCEJIMIKL.GameOnly)]
	private static void LPIADHCPHKP(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[Preserve]
	public ODIODBEDNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6239270", Offset = "0x6238070", VA = "0x186239270", Slot = "4")]
	public Task BIEAGBJDOJG(TimeSpan MFCJMPCEPEB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ELJODHFHMEN<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId DKFJEAJCAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int LJLALOFFPMM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3062CD0", Offset = "0x3061AD0", VA = "0x183062CD0")]
	public ELJODHFHMEN(TItemId CLLCABOCEKL, int JPCCGPIEECF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OGGNFIMBMJB<TItemId, TResult> : NPAIGFMDGEB<ELJODHFHMEN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D17BA0", Offset = "0x3D169A0", VA = "0x183D17BA0")]
	public OGGNFIMBMJB(MMNKKCOJHGO<ELJODHFHMEN<TItemId>, TResult> OLPNOGMOOOJ, TimeSpan GMPIJNPIBFC, [Optional] KIHJHHPPJMA OHANCEDNMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D178F0", Offset = "0x3D166F0", VA = "0x183D178F0")]
	public Task<TResult> BCGLGLHCIJB(TItemId JLDFGFPAIIN, int JPCCGPIEECF, [Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NPAIGFMDGEB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct NJEIJBLALOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest JLMKABMBFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> AHPPNLJEMED;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
		public NJEIJBLALOM(TRequest GDHOLDPNHCL, TaskCompletionSource<TResult> HBJHKLELGAL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HKPPGAFNNLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NPAIGFMDGEB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x359A600", Offset = "0x3599400", VA = "0x18359A600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x359AB00", Offset = "0x3599900", VA = "0x18359AB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FCNNIGJPIAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NPAIGFMDGEB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x33CF9B0", Offset = "0x33CE7B0", VA = "0x1833CF9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x33CFD80", Offset = "0x33CEB80", VA = "0x1833CFD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct LGMGJBPEPIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NPAIGFMDGEB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x39465D0", Offset = "0x39453D0", VA = "0x1839465D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3946A70", Offset = "0x3945870", VA = "0x183946A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HAKLGDDOPFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NPAIGFMDGEB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35559D0", Offset = "0x35547D0", VA = "0x1835559D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3556910", Offset = "0x3555710", VA = "0x183556910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MMNKKCOJHGO<TRequest, TResult> OLPNOGMOOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float GMPIJNPIBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KIHJHHPPJMA OHANCEDNMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<NJEIJBLALOM> GEGLDHGEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource BEBEDIMKGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource HGKLLFKFKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task GAKBBGFCPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float OAGOFKMIGLP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98FFE0", Offset = "0x98EDE0", VA = "0x18098FFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x990030", Offset = "0x98EE30", VA = "0x180990030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3BF23E0", Offset = "0x3BF11E0", VA = "0x183BF23E0")]
	public NPAIGFMDGEB(MMNKKCOJHGO<TRequest, TResult> OLPNOGMOOOJ, TimeSpan GMPIJNPIBFC, [Optional] KIHJHHPPJMA OHANCEDNMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1CB0", Offset = "0x3BF0AB0", VA = "0x183BF1CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3BF19E0", Offset = "0x3BF07E0", VA = "0x183BF19E0")]
	[AsyncStateMachine(typeof(NPAIGFMDGEB<, >.HKPPGAFNNLB))]
	public Task<TResult> BCGLGLHCIJB(TRequest GDHOLDPNHCL, [Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2320", Offset = "0x3BF1120", VA = "0x183BF2320")]
	public Task OHBFKNODHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1EC0", Offset = "0x3BF0CC0", VA = "0x183BF1EC0")]
	[AsyncStateMachine(typeof(NPAIGFMDGEB<, >.FCNNIGJPIAL))]
	private Task GJEAGOPFIBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1B00", Offset = "0x3BF0900", VA = "0x183BF1B00")]
	[AsyncStateMachine(typeof(NPAIGFMDGEB<, >.LGMGJBPEPIO))]
	private Task CBJHPKPOPAN(CancellationToken AGEIBAHGDIO, CancellationToken CLCFFMFCFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2150", Offset = "0x3BF0F50", VA = "0x183BF2150")]
	[AsyncStateMachine(typeof(NPAIGFMDGEB<, >.HAKLGDDOPFG))]
	private Task JACNNCHEOOI(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2250", Offset = "0x3BF1050", VA = "0x183BF2250")]
	private TimeSpan MJJBLHLMODK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2040", Offset = "0x3BF0E40", VA = "0x183BF2040")]
	private Task<List<TResult>> IDBPNNCCJAG(IReadOnlyList<TRequest> JLIAKEMOOFF, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1FA0", Offset = "0x3BF0DA0", VA = "0x183BF1FA0")]
	private float HFFBPKDDPJP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1C20", Offset = "0x3BF0A20", VA = "0x183BF1C20")]
	private void DOGAPMNGHFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IJDDDJMMLBJ<TItemId, TResult> : MMNKKCOJHGO<ELJODHFHMEN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> HNPFKCKPEOA(Dictionary<TItemId, int> JLIAKEMOOFF, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BLDNPHLOIKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BLDNPHLOIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4448580", Offset = "0x4447380", VA = "0x184448580")]
		internal TResult FBMJPAMPOBE(ELJODHFHMEN<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FBKFOMPCMFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<ELJODHFHMEN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IJDDDJMMLBJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private BLDNPHLOIKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33CCF80", Offset = "0x33CBD80", VA = "0x1833CCF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x33CDCD0", Offset = "0x33CCAD0", VA = "0x1833CDCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HNPFKCKPEOA LPHOODBGHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> KBMCPEOIHOH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3682F90", Offset = "0x3681D90", VA = "0x183682F90")]
	public IJDDDJMMLBJ(HNPFKCKPEOA LPHOODBGHNA, [Optional] IEqualityComparer<TItemId> KBMCPEOIHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3682BA0", Offset = "0x36819A0", VA = "0x183682BA0", Slot = "4")]
	[AsyncStateMachine(typeof(IJDDDJMMLBJ<, >.FBKFOMPCMFE))]
	public Task<List<TResult>> JGFIODMEOMA(IReadOnlyList<ELJODHFHMEN<TItemId>> JLIAKEMOOFF, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LFMHGGAHJGI<TRequest, TResult> : MMNKKCOJHGO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> BNFOKJHIJNN(IEnumerable<TRequest> AKCOCMPEGAL, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OLAEHLBNJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OLAEHLBNJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x382FAD0", Offset = "0x382E8D0", VA = "0x18382FAD0")]
		internal TResult FBMJPAMPOBE(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct GECCIDICKDB : IAsyncStateMachine
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
		public LFMHGGAHJGI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private OLAEHLBNJNF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34A2B70", Offset = "0x34A1970", VA = "0x1834A2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x34A39A0", Offset = "0x34A27A0", VA = "0x1834A39A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BNFOKJHIJNN LPHOODBGHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> KBMCPEOIHOH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3682F90", Offset = "0x3681D90", VA = "0x183682F90")]
	public LFMHGGAHJGI(BNFOKJHIJNN LPHOODBGHNA, [Optional] IEqualityComparer<TRequest> KBMCPEOIHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3940CE0", Offset = "0x393FAE0", VA = "0x183940CE0", Slot = "4")]
	[AsyncStateMachine(typeof(LFMHGGAHJGI<, >.GECCIDICKDB))]
	public Task<List<TResult>> JGFIODMEOMA(IReadOnlyList<TRequest> JLIAKEMOOFF, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MMNKKCOJHGO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JGFIODMEOMA(IReadOnlyList<TRequest> JLIAKEMOOFF, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AACEEGODIJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Dictionary<string, CCCPMPNPNDP> MPHLKJDCKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private List<T> LMOHHHFGLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Func<IEnumerable<T>> BCMPKLIICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private Func<T, string> CHLACGDJHEA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, CCCPMPNPNDP> CDKKDLOJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FAIHGGPJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GGGPHGNFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80C500", Offset = "0x80B300", VA = "0x18080C500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3457460", Offset = "0x3456260", VA = "0x183457460")]
	public AACEEGODIJH(Func<IEnumerable<T>> BCMPKLIICFH, Func<T, string> CHLACGDJHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34571E0", Offset = "0x3455FE0", VA = "0x1834571E0")]
	public void PFMOOMMEHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MBAOMDDEKHF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid PADBNNKLAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> BPNLKIEGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CAPJDICBNFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface APFDCAGCJNL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int BEHLKCLHNKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KJAJJMOLAPH<TParam>(TParam GNLEHBFFNFG);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PCLCLNLAHAI(Exception LLMCFHBADKL);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FFKGAJOPKBF();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class CLMKOIHOIIG<TResult> : APFDCAGCJNL, MBAOMDDEKHF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly TaskCompletionSource<TResult> LKHHMKEMOPL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid PADBNNKLAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BEHLKCLHNKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> BPNLKIEGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3BB0B40", Offset = "0x3BAF940", VA = "0x183BB0B40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4910080", Offset = "0x490EE80", VA = "0x184910080")]
		public CLMKOIHOIIG(int NMNCFGJIPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC5A0", Offset = "0x2BCB3A0", VA = "0x182BCC5A0", Slot = "5")]
		public bool KJAJJMOLAPH<TParam>(TParam GNLEHBFFNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4910040", Offset = "0x490EE40", VA = "0x184910040", Slot = "6")]
		public bool PCLCLNLAHAI(Exception LLMCFHBADKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4910000", Offset = "0x490EE00", VA = "0x184910000", Slot = "7")]
		public bool FFKGAJOPKBF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public const string LOGFACBGFLB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly Dictionary<Guid, APFDCAGCJNL> AGPCPBJDEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly HGCPHGIIKEC MIMKDPBOCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool KCDFOAABDFK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62391A0", Offset = "0x6237FA0", VA = "0x1862391A0")]
	public CAPJDICBNFK([Optional] HGCPHGIIKEC MIMKDPBOCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6238A80", Offset = "0x6237880", VA = "0x186238A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x21C8F70", Offset = "0x21C7D70", VA = "0x1821C8F70")]
	public MBAOMDDEKHF<TResult> OKLNNINPMIC<TResult>(int JIAHALOCLCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x21C8C40", Offset = "0x21C7A40", VA = "0x1821C8C40")]
	public bool LKGCBAKGPDA<TResult>(Guid HMFDPJCPEKL, TResult EKOLPKLNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6239080", Offset = "0x6237E80", VA = "0x186239080")]
	private void MJPNBBNBIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6238A80", Offset = "0x6237880", VA = "0x186238A80")]
	private void KIMEKPPGKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6238B90", Offset = "0x6237990", VA = "0x186238B90")]
	private void GMGLNJANBHO(int NMNCFGJIPEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6238E80", Offset = "0x6237C80", VA = "0x186238E80")]
	private void IIPIOHEGIIE()
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

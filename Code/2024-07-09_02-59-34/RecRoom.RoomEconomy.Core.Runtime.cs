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
public interface DHHJACKFIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PGOJMKAHNEN(int HFLKHLIAKJA, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PGOJMKAHNEN(TimeSpan EAKIIICGINA, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IDCHFPFJOJL : DHHJACKFIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7038EA0", Offset = "0x7037AA0", VA = "0x187038EA0")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.GameOnly)]
	private static void NGIENJGHIMG(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	[Preserve]
	public IDCHFPFJOJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7038F90", Offset = "0x7037B90", VA = "0x187038F90", Slot = "4")]
	public Task PGOJMKAHNEN(int HFLKHLIAKJA, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7038FF0", Offset = "0x7037BF0", VA = "0x187038FF0", Slot = "5")]
	public Task PGOJMKAHNEN(TimeSpan EAKIIICGINA, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AAONPLCAIFH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct FAMOCIINDNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest LCJMACMDFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> DBLJHNGKECG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAC5C80", Offset = "0xAC4880", VA = "0x180AC5C80")]
		public FAMOCIINDNJ(TRequest KAIGMLIOMBJ, TaskCompletionSource<TResult> PCLIDHDNAND)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NDMBNECLMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AAONPLCAIFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44E0FD0", Offset = "0x44DFBD0", VA = "0x1844E0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x44E1510", Offset = "0x44E0110", VA = "0x1844E1510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CGMFCBDNDBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AAONPLCAIFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5584FF0", Offset = "0x5583BF0", VA = "0x185584FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x55853E0", Offset = "0x5583FE0", VA = "0x1855853E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CNBDPBCKLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AAONPLCAIFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56AD2E0", Offset = "0x56ABEE0", VA = "0x1856AD2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x56AD7A0", Offset = "0x56AC3A0", VA = "0x1856AD7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct HHMHPEJGHGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AAONPLCAIFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9D80", Offset = "0x3DB8980", VA = "0x183DB9D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3DBAFC0", Offset = "0x3DB9BC0", VA = "0x183DBAFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MCOIJLFLNBO<TRequest, TResult> NJPCDKENCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float BHOCBPNICIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DHHJACKFIBB BGBKPIMLCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool IOHLCIBHJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<FAMOCIINDNJ> OKNMFGKEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<FAMOCIINDNJ> OLGDKEGEIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool KMPCLNCNKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource HMOLPMMIIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource CMDFNPLAINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DODCDACOGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float BNFNBCFLKPD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86FC00", Offset = "0x86E800", VA = "0x18086FC00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86FB40", Offset = "0x86E740", VA = "0x18086FB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5040", Offset = "0x3CE3C40", VA = "0x183CE5040")]
	public AAONPLCAIFH(MCOIJLFLNBO<TRequest, TResult> NJPCDKENCPO, TimeSpan BHOCBPNICIJ, bool IOHLCIBHJBP, [Optional] DHHJACKFIBB BGBKPIMLCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CE47C0", Offset = "0x3CE33C0", VA = "0x183CE47C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4D60", Offset = "0x3CE3960", VA = "0x183CE4D60")]
	[AsyncStateMachine(typeof(AAONPLCAIFH<, >.NDMBNECLMOJ))]
	public Task<TResult> MLDDPDNCJOD(TRequest KAIGMLIOMBJ, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4CC0", Offset = "0x3CE38C0", VA = "0x183CE4CC0")]
	private void MLDDPDNCJOD(TRequest KAIGMLIOMBJ, TaskCompletionSource<TResult> PCLIDHDNAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4C00", Offset = "0x3CE3800", VA = "0x183CE4C00")]
	public Task KAECMEHNJOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4B20", Offset = "0x3CE3720", VA = "0x183CE4B20")]
	[AsyncStateMachine(typeof(AAONPLCAIFH<, >.CGMFCBDNDBE))]
	private Task JFPCCGAPGBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3CE46A0", Offset = "0x3CE32A0", VA = "0x183CE46A0")]
	[AsyncStateMachine(typeof(AAONPLCAIFH<, >.CNBDPBCKLKD))]
	private Task CAHCJEPGCJD(CancellationToken NFHKFMHFOEG, CancellationToken MPLMMADOAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4F40", Offset = "0x3CE3B40", VA = "0x183CE4F40")]
	[AsyncStateMachine(typeof(AAONPLCAIFH<, >.HHMHPEJGHGH))]
	private Task NDJPGHBDAEK(CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4520", Offset = "0x3CE3120", VA = "0x183CE4520")]
	private TimeSpan BEELGLIDALC()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4A00", Offset = "0x3CE3600", VA = "0x183CE4A00")]
	private Task<List<TResult>> EHNDFHDMBGD(IReadOnlyList<TRequest> AELEACAABJM, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4600", Offset = "0x3CE3200", VA = "0x183CE4600")]
	private float BHBMJOCKIPI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE4E90", Offset = "0x3CE3A90", VA = "0x183CE4E90")]
	private void NDEPEGAGDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MFHMLAMBFHD<TItemId, TResult> : MCOIJLFLNBO<PCMKCPNPCEK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> KPKGOPHKOCE(Dictionary<TItemId, int> AELEACAABJM, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class BCGEBBDGOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public BCGEBBDGOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4E64F70", Offset = "0x4E63B70", VA = "0x184E64F70")]
		internal TResult CHPHLNMMINE(PCMKCPNPCEK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NKOENFOLOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<PCMKCPNPCEK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MFHMLAMBFHD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private BCGEBBDGOJM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x45218F0", Offset = "0x45204F0", VA = "0x1845218F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4522700", Offset = "0x4521300", VA = "0x184522700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly KPKGOPHKOCE HCDINGMEINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> DMKIEMJDBGM;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D46B60", Offset = "0x3D45760", VA = "0x183D46B60")]
	public MFHMLAMBFHD(KPKGOPHKOCE HCDINGMEINK, [Optional] IEqualityComparer<TItemId> DMKIEMJDBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4488EB0", Offset = "0x4487AB0", VA = "0x184488EB0", Slot = "4")]
	[AsyncStateMachine(typeof(MFHMLAMBFHD<, >.NKOENFOLOLM))]
	public Task<List<TResult>> PPBFBPALPGH(IReadOnlyList<PCMKCPNPCEK<TItemId>> AELEACAABJM, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class APKGFEAAHLF<TRequest, TResult> : MCOIJLFLNBO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> KIAGFDAEOLI(IEnumerable<TRequest> AIGPMLDMLPL, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CPIFJEGAPPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CPIFJEGAPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C14CF0", Offset = "0x3C138F0", VA = "0x183C14CF0")]
		internal TResult CHPHLNMMINE(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MOABCMBCABC : IAsyncStateMachine
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
		public APKGFEAAHLF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CPIFJEGAPPI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4499AB0", Offset = "0x44986B0", VA = "0x184499AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x449A9D0", Offset = "0x44995D0", VA = "0x18449A9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly KIAGFDAEOLI HCDINGMEINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> DMKIEMJDBGM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D46B60", Offset = "0x3D45760", VA = "0x183D46B60")]
	public APKGFEAAHLF(KIAGFDAEOLI HCDINGMEINK, [Optional] IEqualityComparer<TRequest> DMKIEMJDBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D46A10", Offset = "0x3D45610", VA = "0x183D46A10", Slot = "4")]
	[AsyncStateMachine(typeof(APKGFEAAHLF<, >.MOABCMBCABC))]
	public Task<List<TResult>> PPBFBPALPGH(IReadOnlyList<TRequest> AELEACAABJM, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MCOIJLFLNBO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PPBFBPALPGH(IReadOnlyList<TRequest> AELEACAABJM, CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class INLBJHNCNBB<TItemId, TResult> : MCOIJLFLNBO<MILOIFKNCCN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task ALECMNCFIIF(IReadOnlyDictionary<TItemId, MILOIFKNCCN<TItemId>.KFNJFNDAEME> AELEACAABJM, CancellationToken PPKBAEMFIMG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct OFBJHDGKAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public INLBJHNCNBB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<MILOIFKNCCN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x46544C0", Offset = "0x46530C0", VA = "0x1846544C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4654A50", Offset = "0x4653650", VA = "0x184654A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ALECMNCFIIF DPOMIJMNKNK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public INLBJHNCNBB(ALECMNCFIIF DPOMIJMNKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD740", Offset = "0x3EBC340", VA = "0x183EBD740", Slot = "4")]
	[AsyncStateMachine(typeof(INLBJHNCNBB<, >.OFBJHDGKAGL))]
	public Task<List<object>> PPBFBPALPGH(IReadOnlyList<MILOIFKNCCN<TItemId>> AELEACAABJM, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD2C0", Offset = "0x3EBBEC0", VA = "0x183EBD2C0")]
	private IReadOnlyDictionary<TItemId, MILOIFKNCCN<TItemId>.KFNJFNDAEME> BDPPGOLCBJB(IReadOnlyList<MILOIFKNCCN<TItemId>> NAAPJGKEHLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HOOPOKDCKGA<TItemId, TResult> : MCOIJLFLNBO<PCMKCPNPCEK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> OCNFOPCPMNA(Dictionary<TItemId, int> AELEACAABJM, CancellationToken PPKBAEMFIMG);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct NHHKCMAHMCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<PCMKCPNPCEK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public HOOPOKDCKGA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x44FDF30", Offset = "0x44FCB30", VA = "0x1844FDF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x44FEC40", Offset = "0x44FD840", VA = "0x1844FEC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OCNFOPCPMNA IMPANFLPKEP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public HOOPOKDCKGA(OCNFOPCPMNA HCDINGMEINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEF060", Offset = "0x3DEDC60", VA = "0x183DEF060", Slot = "4")]
	[AsyncStateMachine(typeof(HOOPOKDCKGA<, >.NHHKCMAHMCM))]
	public Task<List<TResult>> PPBFBPALPGH(IReadOnlyList<PCMKCPNPCEK<TItemId>> AELEACAABJM, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MMDCGOAOIGA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, JBBDCCJMFFN> KJIMGAJFABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> MDCHFPPBDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> IOICKJPIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> GLKMPJBGLNO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JBBDCCJMFFN> BMGDINDKALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> NMJABIPIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BGGODBIDJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E1990", Offset = "0x8E0590", VA = "0x1808E1990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4492AA0", Offset = "0x44916A0", VA = "0x184492AA0")]
	public MMDCGOAOIGA(Func<IEnumerable<T>> IOICKJPIJKL, Func<T, string> GLKMPJBGLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x44927D0", Offset = "0x44913D0", VA = "0x1844927D0")]
	public void LMJHDDPLKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4492740", Offset = "0x4491340", VA = "0x184492740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OEHPDGNEOGG<TItemId, TResult> : AAONPLCAIFH<PCMKCPNPCEK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3C29EE0", Offset = "0x3C28AE0", VA = "0x183C29EE0")]
	public OEHPDGNEOGG(MCOIJLFLNBO<PCMKCPNPCEK<TItemId>, TResult> NJPCDKENCPO, TimeSpan BHOCBPNICIJ, bool IOHLCIBHJBP, [Optional] DHHJACKFIBB BGBKPIMLCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x464D3C0", Offset = "0x464BFC0", VA = "0x18464D3C0")]
	public Task<TResult> MLDDPDNCJOD(TItemId NCMHANGAILD, int PGLOJBHLNAB, [Optional] CancellationToken PPKBAEMFIMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PCMKCPNPCEK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId BFEGEGIAHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int OMADBIHFCPK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x475B590", Offset = "0x475A190", VA = "0x18475B590")]
	public PCMKCPNPCEK(TItemId FIEAMBCBLON, int PGLOJBHLNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MHNIBCNPGNH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GECIONPEKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> OGCKIIIPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BCKMDCANJCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface KGPKFIHECDL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int GHPHBCIKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CILKEMMDKII<TParam>(TParam IIPLJLPCLBC);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NLFKPCMOFKL(Exception HEBIFBBBAHA);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DGCAOLKHNJK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class FEOBOHAGHMI<TResult> : KGPKFIHECDL, MHNIBCNPGNH<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> BIIFJEGEEHG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GECIONPEKPL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GHPHBCIKJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8E1AD0", Offset = "0x8E06D0", VA = "0x1808E1AD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> OGCKIIIPMEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3C11550", Offset = "0x3C10150", VA = "0x183C11550", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3C11610", Offset = "0x3C10210", VA = "0x183C11610")]
		public FEOBOHAGHMI(int MPMJMMICBBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A980", Offset = "0x2A79580", VA = "0x182A7A980", Slot = "5")]
		public bool CILKEMMDKII<TParam>(TParam IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C115B0", Offset = "0x3C101B0", VA = "0x183C115B0", Slot = "6")]
		public bool NLFKPCMOFKL(Exception HEBIFBBBAHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C114F0", Offset = "0x3C100F0", VA = "0x183C114F0", Slot = "7")]
		public bool DGCAOLKHNJK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string EPMFHFLHGFB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, KGPKFIHECDL> DABCINGJNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly PKIFKFHKNFJ BDACHOLMGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool FCNDLKJBAGE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7038DD0", Offset = "0x70379D0", VA = "0x187038DD0")]
	public BCKMDCANJCK([Optional] PKIFKFHKNFJ BDACHOLMGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7038AC0", Offset = "0x70376C0", VA = "0x187038AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28EEB90", Offset = "0x28ED790", VA = "0x1828EEB90")]
	public MHNIBCNPGNH<TResult> NDIEECBJCFH<TResult>(int NNMPJDJOFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28EE830", Offset = "0x28ED430", VA = "0x1828EE830")]
	public bool EMKMHEOENJF<TResult>(Guid FEHGEPPCEAL, TResult KKIOBLFFGJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70389A0", Offset = "0x70375A0", VA = "0x1870389A0")]
	private void CBEMAMJFCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7038AC0", Offset = "0x70376C0", VA = "0x187038AC0")]
	private void IOGPJFAKKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70386C0", Offset = "0x70372C0", VA = "0x1870386C0")]
	private void ADJHBMCHFDP(int MPMJMMICBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7038BD0", Offset = "0x70377D0", VA = "0x187038BD0")]
	private void KBAEMCGOGAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum GBOGDDPMFOC
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MILOIFKNCCN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KFNJFNDAEME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int DMEPIHFGNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OKLFAFIMHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int PLELOMDDIGA;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public KFNJFNDAEME()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId BFEGEGIAHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OMADBIHFCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public GBOGDDPMFOC IDFFKAMMPEM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10ED770", Offset = "0x10EC370", VA = "0x1810ED770")]
	public MILOIFKNCCN(TItemId FIEAMBCBLON, int PGLOJBHLNAB, GBOGDDPMFOC LNMFGKOJMJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ABHDFJLDMFA<TItemId, TResult> : AAONPLCAIFH<MILOIFKNCCN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5810", Offset = "0x3CE4410", VA = "0x183CE5810")]
	public ABHDFJLDMFA(MCOIJLFLNBO<MILOIFKNCCN<TItemId>, TResult> NJPCDKENCPO, TimeSpan BHOCBPNICIJ, [Optional] DHHJACKFIBB BGBKPIMLCOM)
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

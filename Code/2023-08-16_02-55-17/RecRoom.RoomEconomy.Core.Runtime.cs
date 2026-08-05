using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PBKIFCJOFHC<TItemId, TResult> : LJKBEOJPBEO<BJLCKHGNBAB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate Task<Dictionary<TItemId, TResult>> OBDGLMDHOMC(Dictionary<TItemId, int> BKLFKAMPCOO, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class LIMBNDKIEHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public LIMBNDKIEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29F5940", Offset = "0x29F4B40", VA = "0x1829F5940")]
		internal TResult GNIEBOHPKHH(BJLCKHGNBAB<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GCEBMEPHCHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public IReadOnlyList<BJLCKHGNBAB<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PBKIFCJOFHC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private LIMBNDKIEHE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Dictionary<TItemId, int> <batchedRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Dictionary<TItemId, TResult> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public GCEBMEPHCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x332D8D0", Offset = "0x332CAD0", VA = "0x18332D8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OBDGLMDHOMC PDDAGLIEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IEqualityComparer<TItemId> NNHMIGOGOIB;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x292A3D0", Offset = "0x29295D0", VA = "0x18292A3D0")]
	public PBKIFCJOFHC(OBDGLMDHOMC PDDAGLIEDCB, [Optional] IEqualityComparer<TItemId> NNHMIGOGOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x292A1D0", Offset = "0x29293D0", VA = "0x18292A1D0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PBKIFCJOFHC<, >.GCEBMEPHCHL))]
	public Task<List<TResult>> CALKMBAHGBI(IReadOnlyList<BJLCKHGNBAB<TItemId>> BKLFKAMPCOO, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface COJDLLMAMOL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Guid KFFEAPGHNGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Task<TResult> FDLDLFMHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IFLOEGOIJAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface GMCDDFNMDFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int LEBJMOBDPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LJEBADLCHCB(object NABCGCEIEGG);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JJCJEFNNKIF(Exception IPCCCBDDHCL);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KEEOKLGCFCC();
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class BCNBCIKMCHA<TResult> : GMCDDFNMDFI, COJDLLMAMOL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly TaskCompletionSource<TResult> HOKLKCIMMOI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid KFFEAPGHNGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x99B850", Offset = "0x99AA50", VA = "0x18099B850", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LEBJMOBDPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<TResult> FDLDLFMHPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1C468D0", Offset = "0x1C45AD0", VA = "0x181C468D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5081470", Offset = "0x5080670", VA = "0x185081470")]
		public BCNBCIKMCHA(int BDIKKDILDLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5081310", Offset = "0x5080510", VA = "0x185081310", Slot = "5")]
		public bool LJEBADLCHCB(object NABCGCEIEGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x23090D0", Offset = "0x23082D0", VA = "0x1823090D0", Slot = "6")]
		public bool JJCJEFNNKIF(Exception IPCCCBDDHCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2309100", Offset = "0x2308300", VA = "0x182309100", Slot = "7")]
		public bool KEEOKLGCFCC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string GLLCILNAFMA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Dictionary<Guid, GMCDDFNMDFI> LJNHNCNFPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IPKOILFAKHP NGAINMFFHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BJILEKPAFLN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F756D0", Offset = "0x6F748D0", VA = "0x186F756D0")]
	public IFLOEGOIJAD([Optional] IPKOILFAKHP NGAINMFFHPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F74FD0", Offset = "0x6F741D0", VA = "0x186F74FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2185BA0", Offset = "0x2184DA0", VA = "0x182185BA0")]
	public COJDLLMAMOL<TResult> COEHHMLNNLC<TResult>(int HEGJADCABAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F75580", Offset = "0x6F74780", VA = "0x186F75580")]
	public bool ILHKMNPKMDP(Guid OAOAFDNAJNM, object GAMJEJDMFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F74EB0", Offset = "0x6F740B0", VA = "0x186F74EB0")]
	private void CEBEIFKPOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F74FD0", Offset = "0x6F741D0", VA = "0x186F74FD0")]
	private void HAPBEDFMBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F752B0", Offset = "0x6F744B0", VA = "0x186F752B0")]
	private void FDIONCOAPGN(int BDIKKDILDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F750E0", Offset = "0x6F742E0", VA = "0x186F750E0")]
	private void ELHCKCLBKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JKDNGMEFMEJ<TRequest, TResult> : LJKBEOJPBEO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<List<TResult>> JNEFEMFLNDH(IEnumerable<TRequest> HENMBOELBIB, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GACFPEJAOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public GACFPEJAOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12894E0", Offset = "0x12886E0", VA = "0x1812894E0")]
		internal TResult GNIEBOHPKHH(TRequest request)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GBLMOKIBGHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JKDNGMEFMEJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private GACFPEJAOPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private List<TResult> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<TResult> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public GBLMOKIBGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x332CA80", Offset = "0x332BC80", VA = "0x18332CA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JNEFEMFLNDH PDDAGLIEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IEqualityComparer<TRequest> NNHMIGOGOIB;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x292A3D0", Offset = "0x29295D0", VA = "0x18292A3D0")]
	public JKDNGMEFMEJ(JNEFEMFLNDH PDDAGLIEDCB, [Optional] IEqualityComparer<TRequest> NNHMIGOGOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x292A1D0", Offset = "0x29293D0", VA = "0x18292A1D0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JKDNGMEFMEJ<, >.GBLMOKIBGHL))]
	public Task<List<TResult>> CALKMBAHGBI(IReadOnlyList<TRequest> BKLFKAMPCOO, CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LJKBEOJPBEO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> CALKMBAHGBI(IReadOnlyList<TRequest> BKLFKAMPCOO, CancellationToken MELLLMEKJLC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HHJPPDPLMFA<TItemId, TResult> : NDNFFKDLNCF<BJLCKHGNBAB<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C80", Offset = "0x20A3E80", VA = "0x1820A4C80")]
	public HHJPPDPLMFA(LJKBEOJPBEO<BJLCKHGNBAB<TItemId>, TResult> EKCOKCEPPCJ, TimeSpan CKPCIPKLIAK, [Optional] BHAAELJEGPN DCBIKOMLPDI, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] EOIMOEDCBGO JONNKNHFIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x20A4B50", Offset = "0x20A3D50", VA = "0x1820A4B50")]
	public Task<TResult> ICAGIALDCBK(TItemId JCEGKCPOPDM, int FOMJHFOGHKP, [Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NDNFFKDLNCF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly LJKBEOJPBEO<TRequest, TResult> EKCOKCEPPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly BHAAELJEGPN PAMAJMAJMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EOIMOEDCBGO JONNKNHFIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TRequest, TaskCompletionSource<TResult>> PLDBGCAPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected readonly ICBHNLMENNA<TRequest, TResult> IDJMBLDBMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly float CKPCIPKLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private float GPBEFKJCFNO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA92EC0", Offset = "0xA920C0", VA = "0x180A92EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x904E30", Offset = "0x904030", VA = "0x180904E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1C57FD0", Offset = "0x1C571D0", VA = "0x181C57FD0")]
	public NDNFFKDLNCF(LJKBEOJPBEO<TRequest, TResult> EKCOKCEPPCJ, TimeSpan CKPCIPKLIAK, [Optional] BHAAELJEGPN DCBIKOMLPDI, [Optional] PEMCPFGJHKJ DIFFCPFJEFJ, [Optional] EOIMOEDCBGO JONNKNHFIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C57CA0", Offset = "0x1C56EA0", VA = "0x181C57CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1C57D00", Offset = "0x1C56F00", VA = "0x181C57D00")]
	private MPEFECEHMLJ FLMPJFHDJID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1C57BA0", Offset = "0x1C56DA0", VA = "0x181C57BA0")]
	private Task<List<TResult>> CLAKFJFHFIN(IReadOnlyList<TRequest> BKLFKAMPCOO, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1C57E50", Offset = "0x1C57050", VA = "0x181C57E50")]
	public Task<TResult> ICAGIALDCBK(TRequest DMFMJBFFPPI, [Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1C57F10", Offset = "0x1C57110", VA = "0x181C57F10")]
	private float POANNEBGGBI()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BJLCKHGNBAB<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TItemId LIBNFFCILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int NNDMFDAMAOG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2E56990", Offset = "0x2E55B90", VA = "0x182E56990")]
	public BJLCKHGNBAB(TItemId KGPGCGMIAFC, int FOMJHFOGHKP)
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

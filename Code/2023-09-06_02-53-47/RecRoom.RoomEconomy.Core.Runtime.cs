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
public interface ADBNJEIMBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FPMMIFODJJB(TimeSpan HPJHHCLPOGE, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FLAFNIOPFPG : ADBNJEIMBEG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5BA0", Offset = "0x6FE41A0", VA = "0x186FE5BA0")]
	[HFALCAKMDCP(DGHGCOPCCJK.Root, BFPOMPMIJIJ.GameOnly)]
	private static void GBPEJJMEKGC(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[Preserve]
	public FLAFNIOPFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5B30", Offset = "0x6FE4130", VA = "0x186FE5B30", Slot = "4")]
	public Task FPMMIFODJJB(TimeSpan HPJHHCLPOGE, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FILLPNBOLJB<TItemId, TResult> : AMHPCCFMJOF<HPCDDBNEFEE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate Task<Dictionary<TItemId, TResult>> LDHJPGLPJBC(Dictionary<TItemId, int> OGIMNFBMPBJ, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KAOKOEIIOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public KAOKOEIIOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2540490", Offset = "0x253EA90", VA = "0x182540490")]
		internal TResult POHBONGNOAC(HPCDDBNEFEE<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HEKBBPOPABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public IReadOnlyList<HPCDDBNEFEE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public FILLPNBOLJB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private KAOKOEIIOPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Dictionary<TItemId, int> <batchedRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Dictionary<TItemId, TResult> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HEKBBPOPABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2187240", Offset = "0x2185840", VA = "0x182187240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LDHJPGLPJBC NOJEMBJMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IEqualityComparer<TItemId> OHDCMCANAGL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1CE26F0", Offset = "0x1CE0CF0", VA = "0x181CE26F0")]
	public FILLPNBOLJB(LDHJPGLPJBC NOJEMBJMKBN, [Optional] IEqualityComparer<TItemId> OHDCMCANAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE24F0", Offset = "0x1CE0AF0", VA = "0x181CE24F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FILLPNBOLJB<, >.HEKBBPOPABB))]
	public Task<List<TResult>> PIMPKFPBOHP(IReadOnlyList<HPCDDBNEFEE<TItemId>> OGIMNFBMPBJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GPEJMFHHEJA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Guid LMJILJKHGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Task<TResult> MOJAFMCPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DAMONLAHABJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface LCDNFIJFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int BDKMFABCHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JOEJCKEBJHP(object MOLEJFDINLH);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FBENNBEOCJI(Exception IAPFIFFPKCI);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EBJJHDMMMIA();
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private class BKLDEFIBINH<TResult> : LCDNFIJFMHO, GPEJMFHHEJA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly TaskCompletionSource<TResult> BFAMIJBLGJJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid LMJILJKHGHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x90BEC0", Offset = "0x90A4C0", VA = "0x18090BEC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BDKMFABCHFB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<TResult> MOJAFMCPENJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x24D8F10", Offset = "0x24D7510", VA = "0x1824D8F10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2522D50", Offset = "0x2521350", VA = "0x182522D50")]
		public BKLDEFIBINH(int EFBKCAIEGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2522BF0", Offset = "0x25211F0", VA = "0x182522BF0", Slot = "5")]
		public bool JOEJCKEBJHP(object MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2522A50", Offset = "0x2521050", VA = "0x182522A50", Slot = "6")]
		public bool FBENNBEOCJI(Exception IAPFIFFPKCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2522A20", Offset = "0x2521020", VA = "0x182522A20", Slot = "7")]
		public bool EBJJHDMMMIA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string BBHFEBMOCIE = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Dictionary<Guid, LCDNFIJFMHO> ALKCJBMACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly PFIGDBEHFBN NMOFKKCBBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool LDLCECIEDIO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5A60", Offset = "0x6FE4060", VA = "0x186FE5A60")]
	public DAMONLAHABJ([Optional] PFIGDBEHFBN NMOFKKCBBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5660", Offset = "0x6FE3C60", VA = "0x186FE5660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x243C170", Offset = "0x243A770", VA = "0x18243C170")]
	public GPEJMFHHEJA<TResult> ENHKPBMMDGB<TResult>(int NLDOCGEKLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5240", Offset = "0x6FE3840", VA = "0x186FE5240")]
	public bool AELJKJHNFBF(Guid BHHPEDGOGNA, object NKONLKNLFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5940", Offset = "0x6FE3F40", VA = "0x186FE5940")]
	private void JBPCAEMAAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5660", Offset = "0x6FE3C60", VA = "0x186FE5660")]
	private void JHEMBHKHBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5390", Offset = "0x6FE3990", VA = "0x186FE5390")]
	private void DBEBPMPDIIH(int EFBKCAIEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5770", Offset = "0x6FE3D70", VA = "0x186FE5770")]
	private void FPBHILGAFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IDKJBGCCFHA<TRequest, TResult> : AMHPCCFMJOF<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<List<TResult>> DEDFLBNFCNK(IEnumerable<TRequest> FCALCOKIPAL, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OKDADLNDOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public OKDADLNDOBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2180760", Offset = "0x217ED60", VA = "0x182180760")]
		internal TResult POHBONGNOAC(TRequest request)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OCCCOCPDKBG : IAsyncStateMachine
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
		public IDKJBGCCFHA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private OKDADLNDOBG <>8__1;

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

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public OCCCOCPDKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2F1B9E0", Offset = "0x2F19FE0", VA = "0x182F1B9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DEDFLBNFCNK NOJEMBJMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IEqualityComparer<TRequest> OHDCMCANAGL;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1CE26F0", Offset = "0x1CE0CF0", VA = "0x181CE26F0")]
	public IDKJBGCCFHA(DEDFLBNFCNK NOJEMBJMKBN, [Optional] IEqualityComparer<TRequest> OHDCMCANAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1CE24F0", Offset = "0x1CE0AF0", VA = "0x181CE24F0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDKJBGCCFHA<, >.OCCCOCPDKBG))]
	public Task<List<TResult>> PIMPKFPBOHP(IReadOnlyList<TRequest> OGIMNFBMPBJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AMHPCCFMJOF<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PIMPKFPBOHP(IReadOnlyList<TRequest> OGIMNFBMPBJ, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BKEFLIDDDHH<TItemId, TResult> : CKMNGPNFIOH<HPCDDBNEFEE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2522140", Offset = "0x2520740", VA = "0x182522140")]
	public BKEFLIDDDHH(AMHPCCFMJOF<HPCDDBNEFEE<TItemId>, TResult> KGMFLHHMJNA, TimeSpan IPOAADIKGLP, [Optional] ADBNJEIMBEG HNLHDDHHMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2521DD0", Offset = "0x25203D0", VA = "0x182521DD0")]
	public Task<TResult> LOKJIDFJBAE(TItemId BOMEFJIOGGM, int EBCIODLGAOM, [Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CKMNGPNFIOH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NFEGCKFAECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TRequest DFIAIEFKDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TaskCompletionSource<TResult> DALBDJFNOAO;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBEFA40", Offset = "0xBEE040", VA = "0x180BEFA40")]
		public NFEGCKFAECP(TRequest FEBOEFLLEJB, TaskCompletionSource<TResult> BDGEAAHMFOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FOHKLPENNCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CKMNGPNFIOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskCompletionSource<TResult> <taskCompletionSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TResult <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public FOHKLPENNCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x31CF880", Offset = "0x31CDE80", VA = "0x1831CF880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GNJLHJOBOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CKMNGPNFIOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GNJLHJOBOJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x33C8450", Offset = "0x33C6A50", VA = "0x1833C8450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class HFOECCFPEAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CKMNGPNFIOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public HFOECCFPEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x218A450", Offset = "0x2188A50", VA = "0x18218A450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DDAEJHCMNCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CKMNGPNFIOH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private List<TRequest> <requests>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private List<TResult> <results>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <count>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private List<TResult> <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <i>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Exception <ex>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <count>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int <i>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public DDAEJHCMNCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2DA9030", Offset = "0x2DA7630", VA = "0x182DA9030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly AMHPCCFMJOF<TRequest, TResult> KGMFLHHMJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly float IPOAADIKGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly ADBNJEIMBEG HNLHDDHHMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly List<NFEGCKFAECP> CGLGOEFKDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly CancellationTokenSource LPOPGKCEMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private CancellationTokenSource OANOBJDCMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Task AAAJIKFMBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private float PMOEAEONEIB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x128C5C0", Offset = "0x128ABC0", VA = "0x18128C5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xBE6AC0", Offset = "0xBE50C0", VA = "0x180BE6AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x29CE910", Offset = "0x29CCF10", VA = "0x1829CE910")]
	public CKMNGPNFIOH(AMHPCCFMJOF<TRequest, TResult> KGMFLHHMJNA, TimeSpan IPOAADIKGLP, [Optional] ADBNJEIMBEG HNLHDDHHMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29CDF50", Offset = "0x29CC550", VA = "0x1829CDF50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x29CE640", Offset = "0x29CCC40", VA = "0x1829CE640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMNGPNFIOH<, >.FOHKLPENNCB))]
	public Task<TResult> LOKJIDFJBAE(TRequest FEBOEFLLEJB, [Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29CE120", Offset = "0x29CC720", VA = "0x1829CE120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMNGPNFIOH<, >.GNJLHJOBOJF))]
	private Task GHCDMFPNAGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29CDDC0", Offset = "0x29CC3C0", VA = "0x1829CDDC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMNGPNFIOH<, >.HFOECCFPEAI))]
	private Task BFGKHDAFFIG(CancellationToken CCHMGHEGPCK, CancellationToken PKOPOMHHDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29CE270", Offset = "0x29CC870", VA = "0x1829CE270")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CKMNGPNFIOH<, >.DDAEJHCMNCC))]
	private Task IILHDEHAFHI(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29CE840", Offset = "0x29CCE40", VA = "0x1829CE840")]
	private TimeSpan NHBHMDMFIMF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29CE480", Offset = "0x29CCA80", VA = "0x1829CE480")]
	private Task<List<TResult>> JGGHDMHLGEE(IReadOnlyList<TRequest> OGIMNFBMPBJ, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29CE580", Offset = "0x29CCB80", VA = "0x1829CE580")]
	private float LBLGJAOHEOK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29CE3F0", Offset = "0x29CC9F0", VA = "0x1829CE3F0")]
	private void IOOLEADFIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HPCDDBNEFEE<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public TItemId BIANNPIBKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int HHMBIOJFGNF;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x297B6D0", Offset = "0x2979CD0", VA = "0x18297B6D0")]
	public HPCDDBNEFEE(TItemId GKJCMJBLOHI, int EBCIODLGAOM)
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

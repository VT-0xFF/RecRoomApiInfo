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
public class MJLABCNLGJB<TItemId, TResult> : ENMDDHKBGIF<EBIKIAGCOBG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate Task<Dictionary<TItemId, TResult>> NMOCKJDEFNE(Dictionary<TItemId, int> EECPPFPKBHF, CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DNNNFGFGHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DNNNFGFGHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A850", Offset = "0x2E29C50", VA = "0x182E2A850")]
		internal TResult IFPOIOKOOOD(EBIKIAGCOBG<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CNMDFPPBFPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public IReadOnlyList<EBIKIAGCOBG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MJLABCNLGJB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private DNNNFGFGHPJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public CNMDFPPBFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE440", Offset = "0x2BFD840", VA = "0x182BFE440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NMOCKJDEFNE DGLPGFJMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IEqualityComparer<TItemId> HFLKGIFCEEE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30C27A0", Offset = "0x30C1BA0", VA = "0x1830C27A0")]
	public MJLABCNLGJB(NMOCKJDEFNE DGLPGFJMOEA, [Optional] IEqualityComparer<TItemId> HFLKGIFCEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30C25A0", Offset = "0x30C19A0", VA = "0x1830C25A0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MJLABCNLGJB<, >.CNMDFPPBFPF))]
	public Task<List<TResult>> PMIHJAFGNFH(IReadOnlyList<EBIKIAGCOBG<TItemId>> EECPPFPKBHF, CancellationToken DNKHCCGNODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ICEJIFDPEAN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Guid ONHCDJCOOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Task<TResult> AOCAOJMHOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GEDJLNHJLDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface EAAOPJBADJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int PCLPLNPIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JKMNKCAACOJ(object KKIAKNLLHIO);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OPLJLHLGGPB(Exception MHKCFPODLCP);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FJFANIJDFGM();
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class NPJDHPFHOJN<TResult> : EAAOPJBADJC, ICEJIFDPEAN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly TaskCompletionSource<TResult> NAPIEOOPGJH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid ONHCDJCOOAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9CDA70", Offset = "0x9CCE70", VA = "0x1809CDA70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PCLPLNPIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<TResult> AOCAOJMHOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1F5EF90", Offset = "0x1F5E390", VA = "0x181F5EF90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAD20", Offset = "0x2AAA120", VA = "0x182AAAD20")]
		public NPJDHPFHOJN(int OAOCJDPFPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAAA20", Offset = "0x2AA9E20", VA = "0x182AAAA20", Slot = "5")]
		public bool JKMNKCAACOJ(object KKIAKNLLHIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAACF0", Offset = "0x2AAA0F0", VA = "0x182AAACF0", Slot = "6")]
		public bool OPLJLHLGGPB(Exception MHKCFPODLCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA9F0", Offset = "0x2AA9DF0", VA = "0x182AAA9F0", Slot = "7")]
		public bool FJFANIJDFGM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string CKNNCFANCIH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Dictionary<Guid, EAAOPJBADJC> FDPLIHMJKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NIOCKFMIOHA ONACNPMOHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BKJIOPNBNFE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA3200", Offset = "0x6FA2600", VA = "0x186FA3200")]
	public GEDJLNHJLDH([Optional] NIOCKFMIOHA ONACNPMOHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA29E0", Offset = "0x6FA1DE0", VA = "0x186FA29E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x19710B0", Offset = "0x19704B0", VA = "0x1819710B0")]
	public ICEJIFDPEAN<TResult> BIAHAEPBBGE<TResult>(int PMNPBNONHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2DE0", Offset = "0x6FA21E0", VA = "0x186FA2DE0")]
	public bool OJPMNMDKOJN(Guid ALNFNLPLEAH, object OHCLGKAJOMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2CC0", Offset = "0x6FA20C0", VA = "0x186FA2CC0")]
	private void JNIGFLNPKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6FA29E0", Offset = "0x6FA1DE0", VA = "0x186FA29E0")]
	private void OEEBOFEBIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2F30", Offset = "0x6FA2330", VA = "0x186FA2F30")]
	private void PLFKLHJIKPN(int OAOCJDPFPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2AF0", Offset = "0x6FA1EF0", VA = "0x186FA2AF0")]
	private void HKDBFGPBHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JDPGABMABPP<TRequest, TResult> : ENMDDHKBGIF<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<List<TResult>> PJKNLIBDDFA(IEnumerable<TRequest> KJDJBPFGAID, CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DOLDMCADMLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DOLDMCADMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEF1DA0", Offset = "0xEF11A0", VA = "0x180EF1DA0")]
		internal TResult IFPOIOKOOOD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FOKMLPBHKEH : IAsyncStateMachine
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
		public JDPGABMABPP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DOLDMCADMLJ <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public FOKMLPBHKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x374BA20", Offset = "0x374AE20", VA = "0x18374BA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly PJKNLIBDDFA DGLPGFJMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IEqualityComparer<TRequest> HFLKGIFCEEE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30C27A0", Offset = "0x30C1BA0", VA = "0x1830C27A0")]
	public JDPGABMABPP(PJKNLIBDDFA DGLPGFJMOEA, [Optional] IEqualityComparer<TRequest> HFLKGIFCEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30C25A0", Offset = "0x30C19A0", VA = "0x1830C25A0", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDPGABMABPP<, >.FOKMLPBHKEH))]
	public Task<List<TResult>> PMIHJAFGNFH(IReadOnlyList<TRequest> EECPPFPKBHF, CancellationToken DNKHCCGNODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ENMDDHKBGIF<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PMIHJAFGNFH(IReadOnlyList<TRequest> EECPPFPKBHF, CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EICACLIJABG<TItemId, TResult> : CDCAMDHMAOF<EBIKIAGCOBG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24F76F0", Offset = "0x24F6AF0", VA = "0x1824F76F0")]
	public EICACLIJABG(ENMDDHKBGIF<EBIKIAGCOBG<TItemId>, TResult> BBEHLHKCMAK, TimeSpan HMHDAMMEHDL, [Optional] FCHPHMFHDKK HPLLHNJFPGL, [Optional] PKBGBEDEGAH BEIHHMBEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E6E4C0", Offset = "0x2E6D8C0", VA = "0x182E6E4C0")]
	public Task<TResult> JPPHENBMNFD(TItemId KOFPKIJDAMC, int FPMMLGBKDCE, [Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CDCAMDHMAOF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly ENMDDHKBGIF<TRequest, TResult> BBEHLHKCMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly PKBGBEDEGAH BEIHHMBEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FCHPHMFHDKK DOCGCHOOAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TRequest, TaskCompletionSource<TResult>> JDBLGPEGMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	protected readonly LILHOFPBKEI<TRequest, TResult> IJAENJFLGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly float HMHDAMMEHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private float NMGIOGGPEPB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA2DB20", Offset = "0xA2CF20", VA = "0x180A2DB20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xF07F50", Offset = "0xF07350", VA = "0x180F07F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA890", Offset = "0x2CD9C90", VA = "0x182CDA890")]
	public CDCAMDHMAOF(ENMDDHKBGIF<TRequest, TResult> BBEHLHKCMAK, TimeSpan HMHDAMMEHDL, [Optional] FCHPHMFHDKK HPLLHNJFPGL, [Optional] PKBGBEDEGAH BEIHHMBEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA550", Offset = "0x2CD9950", VA = "0x182CDA550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA730", Offset = "0x2CD9B30", VA = "0x182CDA730")]
	private LJHFBCJIPCN KNIMOJCODKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA450", Offset = "0x2CD9850", VA = "0x182CDA450")]
	private Task<List<TResult>> DLMPIAEGKDC(IReadOnlyList<TRequest> EECPPFPKBHF, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA670", Offset = "0x2CD9A70", VA = "0x182CDA670")]
	public Task<TResult> JPPHENBMNFD(TRequest IPCJOMPDMMM, [Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2CDA5B0", Offset = "0x2CD99B0", VA = "0x182CDA5B0")]
	private float EJPGECCOCLK()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBIKIAGCOBG<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public TItemId CLOKNJDANCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int KJPNCAICBFH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D7F0", Offset = "0x2B2CBF0", VA = "0x182B2D7F0")]
	public EBIKIAGCOBG(TItemId MCCJMGNNEJL, int FPMMLGBKDCE)
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

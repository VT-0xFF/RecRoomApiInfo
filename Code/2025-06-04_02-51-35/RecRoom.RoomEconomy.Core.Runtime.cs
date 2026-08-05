using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KFEPJAFNPGM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JMBACJPJFDG(int BGDLHBIDHEH, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JMBACJPJFDG(TimeSpan IKMFBAFKION, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IFICLAEOBHD : KFEPJAFNPGM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x879A310", Offset = "0x8798B10", VA = "0x18879A310")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	[RecRoom.NoEngine.Common.Preserve]
	public IFICLAEOBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x879A380", Offset = "0x8798B80", VA = "0x18879A380", Slot = "4")]
	public Task JMBACJPJFDG(int BGDLHBIDHEH, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x879A3E0", Offset = "0x8798BE0", VA = "0x18879A3E0", Slot = "5")]
	public Task JMBACJPJFDG(TimeSpan IKMFBAFKION, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x879A440", Offset = "0x8798C40", VA = "0x18879A440", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GFJBLOPAEDE : NLANEPJLDDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JCDHKMBMPPM IGKOIJLIKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IPCFLDFGGNN<bool> FFCEDPKCJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IPCFLDFGGNN<bool> DOHNGGIKEKG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FHMLHLHLLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8799900", Offset = "0x8798100", VA = "0x188799900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ACFEJHEFAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87999C0", Offset = "0x87981C0", VA = "0x1887999C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8799950", Offset = "0x8798150", VA = "0x188799950")]
	[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
	internal static void GIPKHEKFDMP(OIKNHNBNAFI MBKOPLBCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8799A10", Offset = "0x8798210", VA = "0x188799A10")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFJBLOPAEDE([FAPODKMFODF(null)][NotNull] JCDHKMBMPPM IGKOIJLIKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OOMEBDIJJBB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct LJAFHBELDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest EEEOMIBHPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> FICAELDFOID;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
		public LJAFHBELDHE(TRequest FLPDPHNPDPK, TaskCompletionSource<TResult> LIGCMJIBDEP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HLJPPAGJMKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OOMEBDIJJBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4D26F20", Offset = "0x4D25720", VA = "0x184D26F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4BBA250", Offset = "0x4BB8A50", VA = "0x184BBA250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PCAEFMBLHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OOMEBDIJJBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x580FD80", Offset = "0x580E580", VA = "0x18580FD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5810170", Offset = "0x580E970", VA = "0x185810170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CCKJCLMEDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OOMEBDIJJBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6690EC0", Offset = "0x668F6C0", VA = "0x186690EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6691380", Offset = "0x668FB80", VA = "0x186691380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PEJPAGEMNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OOMEBDIJJBB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x58311D0", Offset = "0x582F9D0", VA = "0x1858311D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5832400", Offset = "0x5830C00", VA = "0x185832400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly EBAIKIJCKDL<TRequest, TResult> GGOFHHBKJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float BHCFGFBLNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KFEPJAFNPGM PBHONBJDMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool ACLFDJDAGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<LJAFHBELDHE> JMCFPJEHKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<LJAFHBELDHE> COFGIGCHPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GKFBJBJPPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource OPKDBGIMACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource NPAKFCFKFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task KKMOGOLCJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float NMPNFIJPKBJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JNLECKPDOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA2D510", Offset = "0xA2BD10", VA = "0x180A2D510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA2D500", Offset = "0xA2BD00", VA = "0x180A2D500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5767BF0", Offset = "0x57663F0", VA = "0x185767BF0")]
	public OOMEBDIJJBB(EBAIKIJCKDL<TRequest, TResult> GGOFHHBKJPP, TimeSpan BHCFGFBLNLA, bool ACLFDJDAGJL, [Optional] KFEPJAFNPGM PBHONBJDMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57672C0", Offset = "0x5765AC0", VA = "0x1857672C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57677A0", Offset = "0x5765FA0", VA = "0x1857677A0")]
	[AsyncStateMachine(typeof(OOMEBDIJJBB<, >.HLJPPAGJMKH))]
	public Task<TResult> IIBCMNEFKEE(TRequest FLPDPHNPDPK, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57678D0", Offset = "0x57660D0", VA = "0x1857678D0")]
	private void IIBCMNEFKEE(TRequest FLPDPHNPDPK, TaskCompletionSource<TResult> LIGCMJIBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57675C0", Offset = "0x5765DC0", VA = "0x1857675C0")]
	public Task GJILFPONKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57670C0", Offset = "0x57658C0", VA = "0x1857670C0")]
	[AsyncStateMachine(typeof(OOMEBDIJJBB<, >.PCAEFMBLHNH))]
	private Task BPAPGBBJNLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57671A0", Offset = "0x57659A0", VA = "0x1857671A0")]
	[AsyncStateMachine(typeof(OOMEBDIJJBB<, >.CCKJCLMEDAA))]
	private Task DPFEIKJIBDG(CancellationToken PFHLALPFOOC, CancellationToken GIMLCAOJPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5767970", Offset = "0x5766170", VA = "0x185767970")]
	[AsyncStateMachine(typeof(OOMEBDIJJBB<, >.PEJPAGEMNKO))]
	private Task LNLFOCGHKFJ(CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5767B10", Offset = "0x5766310", VA = "0x185767B10")]
	private TimeSpan PFGKGJJLOAM()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5767680", Offset = "0x5765E80", VA = "0x185767680")]
	private Task<List<TResult>> HJKGLJACEPM(IReadOnlyList<TRequest> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5767A70", Offset = "0x5766270", VA = "0x185767A70")]
	private float OGAEKCCJGJM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5767510", Offset = "0x5765D10", VA = "0x185767510")]
	private void FJPMJKFBDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AGHGMAJIFDM<TItemId, TResult> : EBAIKIJCKDL<EOMJEFKHENH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> FIIONDMMHOP(Dictionary<TItemId, int> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PEGDAENCBMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PEGDAENCBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5830D50", Offset = "0x582F550", VA = "0x185830D50")]
		internal TResult LDJEMDMHHLM(EOMJEFKHENH<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LHIDBPCCJDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<EOMJEFKHENH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AGHGMAJIFDM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private PEGDAENCBMH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x52FCC30", Offset = "0x52FB430", VA = "0x1852FCC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x52FDA20", Offset = "0x52FC220", VA = "0x1852FDA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly FIIONDMMHOP AIHFILKDDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> JPBEDJHBGMM;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D11C40", Offset = "0x4D10440", VA = "0x184D11C40")]
	public AGHGMAJIFDM(FIIONDMMHOP AIHFILKDDIG, [Optional] IEqualityComparer<TItemId> JPBEDJHBGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D11700", Offset = "0x4D0FF00", VA = "0x184D11700", Slot = "4")]
	[AsyncStateMachine(typeof(AGHGMAJIFDM<, >.LHIDBPCCJDK))]
	public Task<List<TResult>> NGMOGKOMJFN(IReadOnlyList<EOMJEFKHENH<TItemId>> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NKHMFABAJBE<TRequest, TResult> : EBAIKIJCKDL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> HLDDJDPBLAH(IEnumerable<TRequest> BOEAPDJBBNA, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LCCHNHJECMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public LCCHNHJECMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4BABE90", Offset = "0x4BAA690", VA = "0x184BABE90")]
		internal TResult LDJEMDMHHLM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LFIACJMFGML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NKHMFABAJBE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LCCHNHJECMM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x52D5CB0", Offset = "0x52D44B0", VA = "0x1852D5CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x52D6BB0", Offset = "0x52D53B0", VA = "0x1852D6BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HLDDJDPBLAH AIHFILKDDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> JPBEDJHBGMM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D11C40", Offset = "0x4D10440", VA = "0x184D11C40")]
	public NKHMFABAJBE(HLDDJDPBLAH AIHFILKDDIG, [Optional] IEqualityComparer<TRequest> JPBEDJHBGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x55D61D0", Offset = "0x55D49D0", VA = "0x1855D61D0", Slot = "4")]
	[AsyncStateMachine(typeof(NKHMFABAJBE<, >.LFIACJMFGML))]
	public Task<List<TResult>> NGMOGKOMJFN(IReadOnlyList<TRequest> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EBAIKIJCKDL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> NGMOGKOMJFN(IReadOnlyList<TRequest> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IEKMKFNFCKP<TItemId, TResult> : EBAIKIJCKDL<NEICIBEIMED<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task EFGIHOCGJJI(IReadOnlyDictionary<TItemId, NEICIBEIMED<TItemId>.PMJMCBGADOH> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MCLLKLCMNGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IEKMKFNFCKP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<NEICIBEIMED<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x552CE30", Offset = "0x552B630", VA = "0x18552CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x552D3B0", Offset = "0x552BBB0", VA = "0x18552D3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly EFGIHOCGJJI JGMHCMLPILA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public IEKMKFNFCKP(EFGIHOCGJJI JGMHCMLPILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F990", Offset = "0x4E6E190", VA = "0x184E6F990", Slot = "4")]
	[AsyncStateMachine(typeof(IEKMKFNFCKP<, >.MCLLKLCMNGD))]
	public Task<List<object>> NGMOGKOMJFN(IReadOnlyList<NEICIBEIMED<TItemId>> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F500", Offset = "0x4E6DD00", VA = "0x184E6F500")]
	private IReadOnlyDictionary<TItemId, NEICIBEIMED<TItemId>.PMJMCBGADOH> CJODIICMOAD(IReadOnlyList<NEICIBEIMED<TItemId>> BHINOOMPPEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EIOPHGBNLGM<TItemId, TResult> : EBAIKIJCKDL<EOMJEFKHENH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> IPBPHHLAJGF(Dictionary<TItemId, int> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct IJMILIHCHIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<EOMJEFKHENH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EIOPHGBNLGM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E83F70", Offset = "0x4E82770", VA = "0x184E83F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E859B0", Offset = "0x4E841B0", VA = "0x184E859B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly IPBPHHLAJGF HJHBILOGLBE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public EIOPHGBNLGM(IPBPHHLAJGF AIHFILKDDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46F20C0", Offset = "0x46F08C0", VA = "0x1846F20C0", Slot = "4")]
	[AsyncStateMachine(typeof(EIOPHGBNLGM<, >.IJMILIHCHIO))]
	public Task<List<TResult>> NGMOGKOMJFN(IReadOnlyList<EOMJEFKHENH<TItemId>> IGDPJPHPMIJ, CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LPCGKDLGGNA<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, FNJAKAHDIOH> OKIDGLFEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> GEEEBEHLPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> LJMAEMAEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> IPDIAEGCAJG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, FNJAKAHDIOH> MFPHOILAHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> FACFHFFBOBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IILPJFFCEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5358ED0", Offset = "0x53576D0", VA = "0x185358ED0")]
	public LPCGKDLGGNA(Func<IEnumerable<T>> LJMAEMAEKIF, Func<T, string> IPDIAEGCAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5358C00", Offset = "0x5357400", VA = "0x185358C00")]
	public void JNHFKCNMNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5358B70", Offset = "0x5357370", VA = "0x185358B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PFCEGMDDCAI<TItemId, TResult> : OOMEBDIJJBB<EOMJEFKHENH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5552D40", Offset = "0x5551540", VA = "0x185552D40")]
	public PFCEGMDDCAI(EBAIKIJCKDL<EOMJEFKHENH<TItemId>, TResult> GGOFHHBKJPP, TimeSpan BHCFGFBLNLA, bool ACLFDJDAGJL, [Optional] KFEPJAFNPGM PBHONBJDMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5832A60", Offset = "0x5831260", VA = "0x185832A60")]
	public Task<TResult> IIBCMNEFKEE(TItemId MNMCNOJCKAF, int LMIFGKAMFNG, [Optional] CancellationToken GMEAHOBHMAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EOMJEFKHENH<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId LJKIKBJHLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BNFLJGACAHE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4752A30", Offset = "0x4751230", VA = "0x184752A30")]
	public EOMJEFKHENH(TItemId OLOLBHBJOCA, int LMIFGKAMFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NDJLEHCHACN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid LNALCBHAJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> FKAHEBFALHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HNMGKCJHCKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface IGJAEHBDNFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int HDACOGCCPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MINDFIFBDIB<TParam>(TParam MGONBEDEDON);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MEHKMAJODAG(Exception PAPMAHJECNB);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KGCLPCIPGJC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class DILMAIELFOL<TResult> : IGJAEHBDNFD, NDJLEHCHACN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> LCCIIFAAPIC;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid LNALCBHAJBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int HDACOGCCPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> FKAHEBFALHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5596880", Offset = "0x5595080", VA = "0x185596880", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D088B0", Offset = "0x6D070B0", VA = "0x186D088B0")]
		public DILMAIELFOL(int JPPEJHMEPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1190", Offset = "0x3BDF990", VA = "0x183BE1190", Slot = "5")]
		public bool MINDFIFBDIB<TParam>(TParam MGONBEDEDON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D08850", Offset = "0x6D07050", VA = "0x186D08850", Slot = "6")]
		public bool MEHKMAJODAG(Exception PAPMAHJECNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D087F0", Offset = "0x6D06FF0", VA = "0x186D087F0", Slot = "7")]
		public bool KGCLPCIPGJC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string CJIDMBEAJKL = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, IGJAEHBDNFD> ADDJGNIMNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CAEONDNKLHG GHBGFCILEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool PCOBDNAFJLD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x879A210", Offset = "0x8798A10", VA = "0x18879A210")]
	public HNMGKCJHCKG([Optional] CAEONDNKLHG GHBGFCILEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8799B00", Offset = "0x8798300", VA = "0x188799B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B4F0", Offset = "0x3A09CF0", VA = "0x183A0B4F0")]
	public NDJLEHCHACN<TResult> AALABIICCDF<TResult>(int EBBOAPMFADE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A0B810", Offset = "0x3A0A010", VA = "0x183A0B810")]
	public bool CHGGLIFLOAK<TResult>(Guid GKMDGNFGEOO, TResult KJCFPPKBAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x879A0F0", Offset = "0x87988F0", VA = "0x18879A0F0")]
	private void MOMHBBHAKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8799B00", Offset = "0x8798300", VA = "0x188799B00")]
	private void JPNNPJPMGOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8799C10", Offset = "0x8798410", VA = "0x188799C10")]
	private void GEOCPFABDEM(int JPPEJHMEPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8799EF0", Offset = "0x87986F0", VA = "0x188799EF0")]
	private void GOAOFCHILCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum COCAFMDCAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NEICIBEIMED<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PMJMCBGADOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int EIIKPNHNKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int CHKIEJBPLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int GOHCJJOEFJN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PMJMCBGADOH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId LJKIKBJHLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BNFLJGACAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public COCAFMDCAGF EKBDHLKCIJK;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B950", Offset = "0x1F5A150", VA = "0x181F5B950")]
	public NEICIBEIMED(TItemId OLOLBHBJOCA, int LMIFGKAMFNG, COCAFMDCAGF BJNLPCOGDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AHPCIBDGACG<TItemId, TResult> : OOMEBDIJJBB<NEICIBEIMED<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4D22020", Offset = "0x4D20820", VA = "0x184D22020")]
	public AHPCIBDGACG(EBAIKIJCKDL<NEICIBEIMED<TItemId>, TResult> GGOFHHBKJPP, TimeSpan BHCFGFBLNLA, [Optional] KFEPJAFNPGM PBHONBJDMJA)
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

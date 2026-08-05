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
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBBNEHIAGAP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MBPLGAAADFD(int JGDFBMAFHCO, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MBPLGAAADFD(TimeSpan CBKGAPBAEDJ, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NMOOGPCDADD : CBBNEHIAGAP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BF10C0", Offset = "0x7BEFCC0", VA = "0x187BF10C0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void OPGDNJLIDJN(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	[RecRoom.NoEngine.Common.Preserve]
	public NMOOGPCDADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1060", Offset = "0x7BEFC60", VA = "0x187BF1060", Slot = "4")]
	public Task MBPLGAAADFD(int JGDFBMAFHCO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1000", Offset = "0x7BEFC00", VA = "0x187BF1000", Slot = "5")]
	public Task MBPLGAAADFD(TimeSpan CBKGAPBAEDJ, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF11C0", Offset = "0x7BEFDC0", VA = "0x187BF11C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DCJKFCPFEJD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct HMDJFEIELOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest NFJBIGODKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> CDICICOJJPF;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
		public HMDJFEIELOE(TRequest AGFMCIMDGME, TaskCompletionSource<TResult> LEFMCEKDBEO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OGABIOCGADL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DCJKFCPFEJD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A8C0", Offset = "0x4F794C0", VA = "0x184F7A8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x453A710", Offset = "0x4539310", VA = "0x18453A710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PFGEMMMBJHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DCJKFCPFEJD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5041E90", Offset = "0x5040A90", VA = "0x185041E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5042280", Offset = "0x5040E80", VA = "0x185042280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GNLIACODEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DCJKFCPFEJD<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4518990", Offset = "0x4517590", VA = "0x184518990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4518E50", Offset = "0x4517A50", VA = "0x184518E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LJMFELFPEOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DCJKFCPFEJD<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B3D460", Offset = "0x4B3C060", VA = "0x184B3D460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B3E690", Offset = "0x4B3D290", VA = "0x184B3E690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PIPOHEKKGIK<TRequest, TResult> OIOFGGCIIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float JBJBMIJMABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CBBNEHIAGAP GJMGGPBEKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool HCINHBGKMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<HMDJFEIELOE> BHMKFFEKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<HMDJFEIELOE> LLJLNDACNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool NLBPBGOJNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource BGGEJFANJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource EPPBGDFDFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task LFJBIBHPNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float PCMNKKDEBLI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LIANHAMAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x961460", Offset = "0x960060", VA = "0x180961460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x961510", Offset = "0x960110", VA = "0x180961510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62F79C0", Offset = "0x62F65C0", VA = "0x1862F79C0")]
	public DCJKFCPFEJD(PIPOHEKKGIK<TRequest, TResult> OIOFGGCIIPP, TimeSpan JBJBMIJMABG, bool HCINHBGKMHI, [Optional] CBBNEHIAGAP GJMGGPBEKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62F7060", Offset = "0x62F5C60", VA = "0x1862F7060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62F6F30", Offset = "0x62F5B30", VA = "0x1862F6F30")]
	[AsyncStateMachine(typeof(DCJKFCPFEJD<, >.OGABIOCGADL))]
	public Task<TResult> ACONDHDLGJH(TRequest AGFMCIMDGME, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62F6E90", Offset = "0x62F5A90", VA = "0x1862F6E90")]
	private void ACONDHDLGJH(TRequest AGFMCIMDGME, TaskCompletionSource<TResult> LEFMCEKDBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62F7770", Offset = "0x62F6370", VA = "0x1862F7770")]
	public Task NPFMIACPDHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62F73B0", Offset = "0x62F5FB0", VA = "0x1862F73B0")]
	[AsyncStateMachine(typeof(DCJKFCPFEJD<, >.PFGEMMMBJHC))]
	private Task HJCOELCIMHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62F7650", Offset = "0x62F6250", VA = "0x1862F7650")]
	[AsyncStateMachine(typeof(DCJKFCPFEJD<, >.GNLIACODEKO))]
	private Task NNFAFMHAKJN(CancellationToken LHHDIDNBOCD, CancellationToken FOCHEIAIHIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62F72B0", Offset = "0x62F5EB0", VA = "0x1862F72B0")]
	[AsyncStateMachine(typeof(DCJKFCPFEJD<, >.LJMFELFPEOE))]
	private Task FFCJKCGPHPH(CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62F78E0", Offset = "0x62F64E0", VA = "0x1862F78E0")]
	private TimeSpan PJFNLGFHOED()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62F7490", Offset = "0x62F6090", VA = "0x1862F7490")]
	private Task<List<TResult>> HKJOMLBPOKD(IReadOnlyList<TRequest> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62F75B0", Offset = "0x62F61B0", VA = "0x1862F75B0")]
	private float JPJAMGJJGEC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62F7830", Offset = "0x62F6430", VA = "0x1862F7830")]
	private void OPBMIJMAALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AFFICGLHFKN<TItemId, TResult> : PIPOHEKKGIK<HJJIKIDMHCL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> BMPALFCLOKH(Dictionary<TItemId, int> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IOCKBHPPJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IOCKBHPPJKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x47185A0", Offset = "0x47171A0", VA = "0x1847185A0")]
		internal TResult PGKECGLACOD(HJJIKIDMHCL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OHCDDFLLKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<HJJIKIDMHCL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AFFICGLHFKN<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private IOCKBHPPJKB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B7F0", Offset = "0x4F7A3F0", VA = "0x184F7B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F7C5E0", Offset = "0x4F7B1E0", VA = "0x184F7C5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BMPALFCLOKH ODJDPHCBOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> CFOLKBKPHDN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4663CC0", Offset = "0x46628C0", VA = "0x184663CC0")]
	public AFFICGLHFKN(BMPALFCLOKH ODJDPHCBOBE, [Optional] IEqualityComparer<TItemId> CFOLKBKPHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4663780", Offset = "0x4662380", VA = "0x184663780", Slot = "4")]
	[AsyncStateMachine(typeof(AFFICGLHFKN<, >.OHCDDFLLKCH))]
	public Task<List<TResult>> DFCINMAEKPB(IReadOnlyList<HJJIKIDMHCL<TItemId>> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JNFMAGPFEJD<TRequest, TResult> : PIPOHEKKGIK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> PLFDOCJNDCH(IEnumerable<TRequest> GKLFKCDDNAH, CancellationToken NAOIMKEDKEJ);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OFMMOGFMFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OFMMOGFMFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3FBBE80", Offset = "0x3FBAA80", VA = "0x183FBBE80")]
		internal TResult PGKECGLACOD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FMDPKPALJMB : IAsyncStateMachine
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
		public JNFMAGPFEJD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private OFMMOGFMFPN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4418BE0", Offset = "0x44177E0", VA = "0x184418BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4419AE0", Offset = "0x44186E0", VA = "0x184419AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PLFDOCJNDCH ODJDPHCBOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> CFOLKBKPHDN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4663CC0", Offset = "0x46628C0", VA = "0x184663CC0")]
	public JNFMAGPFEJD(PLFDOCJNDCH ODJDPHCBOBE, [Optional] IEqualityComparer<TRequest> CFOLKBKPHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4947AA0", Offset = "0x49466A0", VA = "0x184947AA0", Slot = "4")]
	[AsyncStateMachine(typeof(JNFMAGPFEJD<, >.FMDPKPALJMB))]
	public Task<List<TResult>> DFCINMAEKPB(IReadOnlyList<TRequest> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PIPOHEKKGIK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> DFCINMAEKPB(IReadOnlyList<TRequest> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MPJDHFEBIJJ<TItemId, TResult> : PIPOHEKKGIK<LFENPCJDKOI<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task AOBDIKGDFDJ(IReadOnlyDictionary<TItemId, LFENPCJDKOI<TItemId>.FHFLJMLCHJE> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct CICEFOIKKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MPJDHFEBIJJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<LFENPCJDKOI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0430", Offset = "0x5AAF030", VA = "0x185AB0430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB09B0", Offset = "0x5AAF5B0", VA = "0x185AB09B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly AOBDIKGDFDJ AJOLNDLMBDI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public MPJDHFEBIJJ(AOBDIKGDFDJ AJOLNDLMBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D98AB0", Offset = "0x4D976B0", VA = "0x184D98AB0", Slot = "4")]
	[AsyncStateMachine(typeof(MPJDHFEBIJJ<, >.CICEFOIKKEF))]
	public Task<List<object>> DFCINMAEKPB(IReadOnlyList<LFENPCJDKOI<TItemId>> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D98BF0", Offset = "0x4D977F0", VA = "0x184D98BF0")]
	private IReadOnlyDictionary<TItemId, LFENPCJDKOI<TItemId>.FHFLJMLCHJE> OJHEANIKNKP(IReadOnlyList<LFENPCJDKOI<TItemId>> ONICAHPKIOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ABJJECEBPBE<TItemId, TResult> : PIPOHEKKGIK<HJJIKIDMHCL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> OPEMMDMAAON(Dictionary<TItemId, int> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NAJIOCKDIIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<HJJIKIDMHCL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public ABJJECEBPBE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4DE50A0", Offset = "0x4DE3CA0", VA = "0x184DE50A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4DE6AE0", Offset = "0x4DE56E0", VA = "0x184DE6AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OPEMMDMAAON LFBIOOMPOID;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public ABJJECEBPBE(OPEMMDMAAON ODJDPHCBOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x453FF00", Offset = "0x453EB00", VA = "0x18453FF00", Slot = "4")]
	[AsyncStateMachine(typeof(ABJJECEBPBE<, >.NAJIOCKDIIJ))]
	public Task<List<TResult>> DFCINMAEKPB(IReadOnlyList<HJJIKIDMHCL<TItemId>> EIJFKPMEDAO, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HECHAHDAKKL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, JJHGKOMIDDI> PLCLHAKGNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> IGJADBFHABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> MDEALCBACDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> IOLIIIIOBJC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, JJHGKOMIDDI> GGNNEMILFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> BKPJMHNEKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KFHLFPGBPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB42EE0", Offset = "0xB41AE0", VA = "0x180B42EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x458C5D0", Offset = "0x458B1D0", VA = "0x18458C5D0")]
	public HECHAHDAKKL(Func<IEnumerable<T>> MDEALCBACDJ, Func<T, string> IOLIIIIOBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x458C300", Offset = "0x458AF00", VA = "0x18458C300")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x458C270", Offset = "0x458AE70", VA = "0x18458C270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BFAKJDJFCLI<TItemId, TResult> : DCJKFCPFEJD<HJJIKIDMHCL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4D85AD0", Offset = "0x4D846D0", VA = "0x184D85AD0")]
	public BFAKJDJFCLI(PIPOHEKKGIK<HJJIKIDMHCL<TItemId>, TResult> OIOFGGCIIPP, TimeSpan JBJBMIJMABG, bool HCINHBGKMHI, [Optional] CBBNEHIAGAP GJMGGPBEKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5801620", Offset = "0x5800220", VA = "0x185801620")]
	public Task<TResult> ACONDHDLGJH(TItemId NKANGPLHEGE, int JLCDBIJGLGB, [Optional] CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HJJIKIDMHCL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId JPBKDMKMBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int KEIEAKKOENG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x462CB70", Offset = "0x462B770", VA = "0x18462CB70")]
	public HJJIKIDMHCL(TItemId NDMNLGHHJKE, int JLCDBIJGLGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NBDENIGEIOF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GGHEGFOPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PNCEKDGNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DMJKLBEHNNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface JHOFHPBHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int POOCKDKJLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DPLLMLEEFDN<TParam>(TParam MPDLOLIOGJL);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KFDIDCJLEKI(Exception MKDAJBJBGPA);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool MLDEGEEACLE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class OIHFHMLCFIE<TResult> : JHOFHPBHCNH, NBDENIGEIOF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> IDGIFCDJBBC;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GGHEGFOPPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int POOCKDKJLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PNCEKDGNHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4DD8C20", Offset = "0x4DD7820", VA = "0x184DD8C20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DDA0", Offset = "0x4F7C9A0", VA = "0x184F7DDA0")]
		public OIHFHMLCFIE(int CPFHFNJOGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x37F3FB0", Offset = "0x37F2BB0", VA = "0x1837F3FB0", Slot = "5")]
		public bool DPLLMLEEFDN<TParam>(TParam MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DCE0", Offset = "0x4F7C8E0", VA = "0x184F7DCE0", Slot = "6")]
		public bool KFDIDCJLEKI(Exception MKDAJBJBGPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F7DD40", Offset = "0x4F7C940", VA = "0x184F7DD40", Slot = "7")]
		public bool MLDEGEEACLE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string MDPKLCJNHLH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, JHOFHPBHCNH> GELIJDEIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FJKILKHDGJP NJLKFKCGGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool KMEMLPJAFKF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0F00", Offset = "0x7BEFB00", VA = "0x187BF0F00")]
	public DMJKLBEHNNO([Optional] FJKILKHDGJP NJLKFKCGGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0BF0", Offset = "0x7BEF7F0", VA = "0x187BF0BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31AA250", Offset = "0x31A8E50", VA = "0x1831AA250")]
	public NBDENIGEIOF<TResult> GOLCPAENJNM<TResult>(int KLCAPNACFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31A9EE0", Offset = "0x31A8AE0", VA = "0x1831A9EE0")]
	public bool DBOKCOCPMMK<TResult>(Guid HBKGJHPGIDP, TResult HBANOBDOKBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BF07F0", Offset = "0x7BEF3F0", VA = "0x187BF07F0")]
	private void ABNGIEANCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0BF0", Offset = "0x7BEF7F0", VA = "0x187BF0BF0")]
	private void LHCEOBKBGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0910", Offset = "0x7BEF510", VA = "0x187BF0910")]
	private void BDAHODAGFOF(int CPFHFNJOGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0D00", Offset = "0x7BEF900", VA = "0x187BF0D00")]
	private void MLDBMBEOJDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DHEJBCFLFFF
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LFENPCJDKOI<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class FHFLJMLCHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int AMFGNMFLIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int MPCJKMDFAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int LGLGKFAHJAK;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public FHFLJMLCHJE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId JPBKDMKMBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int KEIEAKKOENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public DHEJBCFLFFF DKIOFIGDPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1BDD310", Offset = "0x1BDBF10", VA = "0x181BDD310")]
	public LFENPCJDKOI(TItemId NDMNLGHHJKE, int JLCDBIJGLGB, DHEJBCFLFFF BIKFHOMEEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LNHKIKOJIED<TItemId, TResult> : DCJKFCPFEJD<LFENPCJDKOI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4B4BFF0", Offset = "0x4B4ABF0", VA = "0x184B4BFF0")]
	public LNHKIKOJIED(PIPOHEKKGIK<LFENPCJDKOI<TItemId>, TResult> OIOFGGCIIPP, TimeSpan JBJBMIJMABG, [Optional] CBBNEHIAGAP GJMGGPBEKHH)
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

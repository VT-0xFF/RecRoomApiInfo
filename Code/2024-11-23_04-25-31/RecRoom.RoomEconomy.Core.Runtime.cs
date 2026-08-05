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
public interface CJCAEHNADAH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NNMKJKDLGKB(int GJBBLBBKJFO, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NNMKJKDLGKB(TimeSpan HPLOGOHEPGF, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FNLOAFOANGH : CJCAEHNADAH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74A72B0", Offset = "0x74A5CB0", VA = "0x1874A72B0")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	internal static void GHMBFHCIJHC(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNLOAFOANGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74A7410", Offset = "0x74A5E10", VA = "0x1874A7410", Slot = "4")]
	public Task NNMKJKDLGKB(int GJBBLBBKJFO, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74A73B0", Offset = "0x74A5DB0", VA = "0x1874A73B0", Slot = "5")]
	public Task NNMKJKDLGKB(TimeSpan HPLOGOHEPGF, CancellationToken PPLDCJFFMEP)
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
		[Cpp2IlInjected.Address(RVA = "0x74A7C90", Offset = "0x74A6690", VA = "0x1874A7C90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GCBPDPPNIPD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct KAJNMCGDDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest MNOLEKIGNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> JIOIMHCGPJI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE07750", Offset = "0xE06150", VA = "0x180E07750")]
		public KAJNMCGDDGA(TRequest PGCEOMNLPAE, TaskCompletionSource<TResult> CEEEEOELLLH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct DOJJEFLLDKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GCBPDPPNIPD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5C8E440", Offset = "0x5C8CE40", VA = "0x185C8E440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3B77720", Offset = "0x3B76120", VA = "0x183B77720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct GLLLJANDFML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GCBPDPPNIPD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4118430", Offset = "0x4116E30", VA = "0x184118430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4118820", Offset = "0x4117220", VA = "0x184118820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DBGNOOKECBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GCBPDPPNIPD<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5C70550", Offset = "0x5C6EF50", VA = "0x185C70550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5C70A10", Offset = "0x5C6F410", VA = "0x185C70A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NODKNNDCPBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GCBPDPPNIPD<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4954900", Offset = "0x4953300", VA = "0x184954900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4955B30", Offset = "0x4954530", VA = "0x184955B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KEKLEMGOPCH<TRequest, TResult> FLBCCPBMHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float IODCLGFLBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CJCAEHNADAH JIPHNMKEKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool KKLFDAGFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<KAJNMCGDDGA> FKKEBPGECKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<KAJNMCGDDGA> AMBKNGPIPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool CLJBMABFDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource ILOHINPBILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource DGANNADGKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DNAEJEGOCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float DNEIOLNJPOH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B00B0", Offset = "0x8AEAB0", VA = "0x1808B00B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B0110", Offset = "0x8AEB10", VA = "0x1808B0110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x40D5060", Offset = "0x40D3A60", VA = "0x1840D5060")]
	public GCBPDPPNIPD(KEKLEMGOPCH<TRequest, TResult> FLBCCPBMHMJ, TimeSpan IODCLGFLBMM, bool KKLFDAGFOKC, [Optional] CJCAEHNADAH JIPHNMKEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x40D4810", Offset = "0x40D3210", VA = "0x1840D4810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x40D4E90", Offset = "0x40D3890", VA = "0x1840D4E90")]
	[AsyncStateMachine(typeof(GCBPDPPNIPD<, >.DOJJEFLLDKM))]
	public Task<TResult> OKCDONDCCIN(TRequest PGCEOMNLPAE, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x40D4FC0", Offset = "0x40D39C0", VA = "0x1840D4FC0")]
	private void OKCDONDCCIN(TRequest PGCEOMNLPAE, TaskCompletionSource<TResult> CEEEEOELLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x40D4630", Offset = "0x40D3030", VA = "0x1840D4630")]
	public Task CIKKKOKEIAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40D4B40", Offset = "0x40D3540", VA = "0x1840D4B40")]
	[AsyncStateMachine(typeof(GCBPDPPNIPD<, >.GLLLJANDFML))]
	private Task HCIPDBACHKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40D4CD0", Offset = "0x40D36D0", VA = "0x1840D4CD0")]
	[AsyncStateMachine(typeof(GCBPDPPNIPD<, >.DBGNOOKECBC))]
	private Task INHOLKDMBOM(CancellationToken AFLLAMDDGNI, CancellationToken AOLPLPHJDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40D4530", Offset = "0x40D2F30", VA = "0x1840D4530")]
	[AsyncStateMachine(typeof(GCBPDPPNIPD<, >.NODKNNDCPBA))]
	private Task AACBIHDBPNG(CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40D4A60", Offset = "0x40D3460", VA = "0x1840D4A60")]
	private TimeSpan EAGINOBPAIH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x40D46F0", Offset = "0x40D30F0", VA = "0x1840D46F0")]
	private Task<List<TResult>> DGJGNBOLPPF(IReadOnlyList<TRequest> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40D4DF0", Offset = "0x40D37F0", VA = "0x1840D4DF0")]
	private float KPNLMCIKEAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40D4C20", Offset = "0x40D3620", VA = "0x1840D4C20")]
	private void ICIFGFICEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PKGJACNMEPP<TItemId, TResult> : KEKLEMGOPCH<JKMFCGOCDDN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> BIKFGKNEPNA(Dictionary<TItemId, int> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KAOJOHCPLNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KAOJOHCPLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x44EED00", Offset = "0x44ED700", VA = "0x1844EED00")]
		internal TResult HNLDAGBIFNK(JKMFCGOCDDN<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IJICBEMCLHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<JKMFCGOCDDN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PKGJACNMEPP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private KAOJOHCPLNN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4252310", Offset = "0x4250D10", VA = "0x184252310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4253100", Offset = "0x4251B00", VA = "0x184253100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BIKFGKNEPNA INLBKKHMMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> FNBJNOCPAIF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42585F0", Offset = "0x4256FF0", VA = "0x1842585F0")]
	public PKGJACNMEPP(BIKFGKNEPNA INLBKKHMMEB, [Optional] IEqualityComparer<TItemId> FNBJNOCPAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C400", Offset = "0x4B7AE00", VA = "0x184B7C400", Slot = "4")]
	[AsyncStateMachine(typeof(PKGJACNMEPP<, >.IJICBEMCLHC))]
	public Task<List<TResult>> HCPKEMOKEOI(IReadOnlyList<JKMFCGOCDDN<TItemId>> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IKPKHLAHFPE<TRequest, TResult> : KEKLEMGOPCH<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> JAILCJBLFOG(IEnumerable<TRequest> OAOLLDPGEIK, CancellationToken PPLDCJFFMEP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FPFGMPIENKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public FPFGMPIENKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F15C70", Offset = "0x3F14670", VA = "0x183F15C70")]
		internal TResult HNLDAGBIFNK(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NCFJCENDCKG : IAsyncStateMachine
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
		public IKPKHLAHFPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private FPFGMPIENKE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4911E10", Offset = "0x4910810", VA = "0x184911E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4912D10", Offset = "0x4911710", VA = "0x184912D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JAILCJBLFOG INLBKKHMMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> FNBJNOCPAIF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x42585F0", Offset = "0x4256FF0", VA = "0x1842585F0")]
	public IKPKHLAHFPE(JAILCJBLFOG INLBKKHMMEB, [Optional] IEqualityComparer<TRequest> FNBJNOCPAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42584A0", Offset = "0x4256EA0", VA = "0x1842584A0", Slot = "4")]
	[AsyncStateMachine(typeof(IKPKHLAHFPE<, >.NCFJCENDCKG))]
	public Task<List<TResult>> HCPKEMOKEOI(IReadOnlyList<TRequest> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KEKLEMGOPCH<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HCPKEMOKEOI(IReadOnlyList<TRequest> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JFHIPKFJDBE<TItemId, TResult> : KEKLEMGOPCH<EOAKDIEDPEE<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task JNDIBPJNIPI(IReadOnlyDictionary<TItemId, EOAKDIEDPEE<TItemId>.AHIGPBCMNCE> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct HMPLBKCKEHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JFHIPKFJDBE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<EOAKDIEDPEE<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4195710", Offset = "0x4194110", VA = "0x184195710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4195C90", Offset = "0x4194690", VA = "0x184195C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JNDIBPJNIPI NNMACIKKGNC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public JFHIPKFJDBE(JNDIBPJNIPI NNMACIKKGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x441DA00", Offset = "0x441C400", VA = "0x18441DA00", Slot = "4")]
	[AsyncStateMachine(typeof(JFHIPKFJDBE<, >.HMPLBKCKEHN))]
	public Task<List<object>> HCPKEMOKEOI(IReadOnlyList<EOAKDIEDPEE<TItemId>> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x441D560", Offset = "0x441BF60", VA = "0x18441D560")]
	private IReadOnlyDictionary<TItemId, EOAKDIEDPEE<TItemId>.AHIGPBCMNCE> HCBNLJAIHPK(IReadOnlyList<EOAKDIEDPEE<TItemId>> OIIJEMJGANN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PCGHAAFAJEA<TItemId, TResult> : KEKLEMGOPCH<JKMFCGOCDDN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> DKMFKOOMDKJ(Dictionary<TItemId, int> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct EHPKEBKJJHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<JKMFCGOCDDN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PCGHAAFAJEA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3B7C6C0", Offset = "0x3B7B0C0", VA = "0x183B7C6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3E0", Offset = "0x3B7BDE0", VA = "0x183B7D3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DKMFKOOMDKJ ALHLBCEELOB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public PCGHAAFAJEA(DKMFKOOMDKJ INLBKKHMMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4B55410", Offset = "0x4B53E10", VA = "0x184B55410", Slot = "4")]
	[AsyncStateMachine(typeof(PCGHAAFAJEA<, >.EHPKEBKJJHO))]
	public Task<List<TResult>> HCPKEMOKEOI(IReadOnlyList<JKMFCGOCDDN<TItemId>> LCNPNHIIBMK, CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LFPGDJDAHHE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, PHCGGPIMKIC> NGDHJDLJNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> HHLGDCDKGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> EMMMJKDHKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> CIJKACLDMLE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, PHCGGPIMKIC> LLLFKNMMBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> OKAKLLEKLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MLOHJJAMACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAAE210", Offset = "0xAACC10", VA = "0x180AAE210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4665380", Offset = "0x4663D80", VA = "0x184665380")]
	public LFPGDJDAHHE(Func<IEnumerable<T>> EMMMJKDHKGH, Func<T, string> CIJKACLDMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x46650B0", Offset = "0x4663AB0", VA = "0x1846650B0")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4665020", Offset = "0x4663A20", VA = "0x184665020", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NNGPDFFEHAK<TItemId, TResult> : GCBPDPPNIPD<JKMFCGOCDDN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40D3B10", Offset = "0x40D2510", VA = "0x1840D3B10")]
	public NNGPDFFEHAK(KEKLEMGOPCH<JKMFCGOCDDN<TItemId>, TResult> FLBCCPBMHMJ, TimeSpan IODCLGFLBMM, bool KKLFDAGFOKC, [Optional] CJCAEHNADAH JIPHNMKEKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x494D820", Offset = "0x494C220", VA = "0x18494D820")]
	public Task<TResult> OKCDONDCCIN(TItemId PNABAFEIDND, int DIKJGKCBPOL, [Optional] CancellationToken PPLDCJFFMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JKMFCGOCDDN<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId IOONDNPJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int KIOGBKEIFJC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x443C420", Offset = "0x443AE20", VA = "0x18443C420")]
	public JKMFCGOCDDN(TItemId NFIKDKPAGBO, int DIKJGKCBPOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ICPGCCMKPNI<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CJBBCHHPBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IOMOPDBBKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OGJEMNBOAMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface JHCLBCIAAOF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int LPDIBIGDKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ANAIHAEKHFO<TParam>(TParam PKCLPFEIPFH);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MGGEOFDMGAM(Exception PGCLCKNIGGB);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HKCHCHBCOON();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class GFDBJFIEMEB<TResult> : JHCLBCIAAOF, ICPGCCMKPNI<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> DDBCLGDDBCK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CJBBCHHPBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int LPDIBIGDKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9826F0", Offset = "0x9810F0", VA = "0x1809826F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IOMOPDBBKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x40E65F0", Offset = "0x40E4FF0", VA = "0x1840E65F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x40E66B0", Offset = "0x40E50B0", VA = "0x1840E66B0")]
		public GFDBJFIEMEB(int NFLBDFOJEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2E1F6B0", Offset = "0x2E1E0B0", VA = "0x182E1F6B0", Slot = "5")]
		public bool ANAIHAEKHFO<TParam>(TParam PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x40E6650", Offset = "0x40E5050", VA = "0x1840E6650", Slot = "6")]
		public bool MGGEOFDMGAM(Exception PGCLCKNIGGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40E6590", Offset = "0x40E4F90", VA = "0x1840E6590", Slot = "7")]
		public bool HKCHCHBCOON()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string NONEKDLEJMA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, JHCLBCIAAOF> PBGGIPIPBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly ECEEBMJJPLJ AMCAOGKBJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool IPAAGDPMIPC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74A7B90", Offset = "0x74A6590", VA = "0x1874A7B90")]
	public OGJEMNBOAMG([Optional] ECEEBMJJPLJ AMCAOGKBJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74A7590", Offset = "0x74A5F90", VA = "0x1874A7590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3079F70", Offset = "0x3078970", VA = "0x183079F70")]
	public ICPGCCMKPNI<TResult> PAAAOAIOFJO<TResult>(int IALAIKBADEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3079C00", Offset = "0x3078600", VA = "0x183079C00")]
	public bool MLBADMMBJDH<TResult>(Guid GGNKLHDGNDO, TResult KIBAOEBFCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74A7470", Offset = "0x74A5E70", VA = "0x1874A7470")]
	private void AEGEMJKNKCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74A7590", Offset = "0x74A5F90", VA = "0x1874A7590")]
	private void GPJBOBDMPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74A76A0", Offset = "0x74A60A0", VA = "0x1874A76A0")]
	private void EAIGAEBFLKD(int NFLBDFOJEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74A7990", Offset = "0x74A6390", VA = "0x1874A7990")]
	private void GFACMKPNDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NBMCLBFJBKD
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EOAKDIEDPEE<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AHIGPBCMNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int KBIDDLNFMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int IHNCEBODFNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int NEFDAPAHONI;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AHIGPBCMNCE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId IOONDNPJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int KIOGBKEIFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NBMCLBFJBKD GEFIMKAFECF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x177E170", Offset = "0x177CB70", VA = "0x18177E170")]
	public EOAKDIEDPEE(TItemId NFIKDKPAGBO, int DIKJGKCBPOL, NBMCLBFJBKD NEELBFFPDOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LEALPBKABOA<TItemId, TResult> : GCBPDPPNIPD<EOAKDIEDPEE<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4660BB0", Offset = "0x465F5B0", VA = "0x184660BB0")]
	public LEALPBKABOA(KEKLEMGOPCH<EOAKDIEDPEE<TItemId>, TResult> FLBCCPBMHMJ, TimeSpan IODCLGFLBMM, [Optional] CJCAEHNADAH JIPHNMKEKCK)
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

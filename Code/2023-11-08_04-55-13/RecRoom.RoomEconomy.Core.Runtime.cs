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
public interface NJHNNMMEIIF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PGMNGKNLJEE(TimeSpan HENDNFJJONG, CancellationToken ELPOPHCEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DMDIOKIIBIP : NJHNNMMEIIF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x639A2B0", Offset = "0x63990B0", VA = "0x18639A2B0")]
	[IBKPEPPEMNJ(INBBGMADPCI.Root, MIBJABCBNEH.GameOnly)]
	private static void KBMJKMKMJBP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	[Preserve]
	public DMDIOKIIBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x639A3B0", Offset = "0x63991B0", VA = "0x18639A3B0", Slot = "4")]
	public Task PGMNGKNLJEE(TimeSpan HENDNFJJONG, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IHBFEKAIBLL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId DPJKAABJADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int JOANFMCOENK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37557C0", Offset = "0x37545C0", VA = "0x1837557C0")]
	public IHBFEKAIBLL(TItemId PJBANAFHINM, int BIKONKGEBKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DLGBKANBMJD<TItemId, TResult> : OMMHLAKBCCO<IHBFEKAIBLL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA20B0", Offset = "0x3CA0EB0", VA = "0x183CA20B0")]
	public DLGBKANBMJD(DHCHHMHIHMG<IHBFEKAIBLL<TItemId>, TResult> KCBJCDKHBJP, TimeSpan JPHHALONKIH, [Optional] NJHNNMMEIIF MKABELFIEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA0F90", Offset = "0x4D9FD90", VA = "0x184DA0F90")]
	public Task<TResult> BAHKLFMJENK(TItemId GAMCILOFBAF, int BIKONKGEBKA, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OMMHLAKBCCO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct KININHMDBIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest MHIHCKODCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> LJPGLNNFNLJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
		public KININHMDBIM(TRequest MGDLKMJIAPA, TaskCompletionSource<TResult> MJMIBDGKDFM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DOEJBILAEEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OMMHLAKBCCO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1A60", Offset = "0x4DC0860", VA = "0x184DC1A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1FA0", Offset = "0x4DC0DA0", VA = "0x184DC1FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct NBGIMCDMDDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OMMHLAKBCCO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFAC0", Offset = "0x3CFE8C0", VA = "0x183CFFAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFE90", Offset = "0x3CFEC90", VA = "0x183CFFE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PJCGLCPOFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OMMHLAKBCCO<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3EF82D0", Offset = "0x3EF70D0", VA = "0x183EF82D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8770", Offset = "0x3EF7570", VA = "0x183EF8770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GCMKKAENGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public OMMHLAKBCCO<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x356A3B0", Offset = "0x35691B0", VA = "0x18356A3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x356B2F0", Offset = "0x356A0F0", VA = "0x18356B2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DHCHHMHIHMG<TRequest, TResult> KCBJCDKHBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float JPHHALONKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NJHNNMMEIIF MKABELFIEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<KININHMDBIM> ACLOOLAHNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource FIAGJLNNAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource GLGCOIMEPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task CDDCPBJONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float NDHDPMEOPEC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9E9BB0", Offset = "0x9E89B0", VA = "0x1809E9BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9E9BE0", Offset = "0x9E89E0", VA = "0x1809E9BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BEF0", Offset = "0x3E1ACF0", VA = "0x183E1BEF0")]
	public OMMHLAKBCCO(DHCHHMHIHMG<TRequest, TResult> KCBJCDKHBJP, TimeSpan JPHHALONKIH, [Optional] NJHNNMMEIIF MKABELFIEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B6D0", Offset = "0x3E1A4D0", VA = "0x183E1B6D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B4F0", Offset = "0x3E1A2F0", VA = "0x183E1B4F0")]
	[AsyncStateMachine(typeof(OMMHLAKBCCO<, >.DOEJBILAEEC))]
	public Task<TResult> BAHKLFMJENK(TRequest MGDLKMJIAPA, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B610", Offset = "0x3E1A410", VA = "0x183E1B610")]
	public Task DKOKFAFHNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B9F0", Offset = "0x3E1A7F0", VA = "0x183E1B9F0")]
	[AsyncStateMachine(typeof(OMMHLAKBCCO<, >.NBGIMCDMDDE))]
	private Task EPCPPJHLJGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BDD0", Offset = "0x3E1ABD0", VA = "0x183E1BDD0")]
	[AsyncStateMachine(typeof(OMMHLAKBCCO<, >.PJCGLCPOFOP))]
	private Task NHJGJJKKDJP(CancellationToken IAPOJAPMCCB, CancellationToken PJHMMAMHCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BAD0", Offset = "0x3E1A8D0", VA = "0x183E1BAD0")]
	[AsyncStateMachine(typeof(OMMHLAKBCCO<, >.GCMKKAENGBF))]
	private Task FCGICAFPAJD(CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BD00", Offset = "0x3E1AB00", VA = "0x183E1BD00")]
	private TimeSpan KFBOEFGOFFD()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B8E0", Offset = "0x3E1A6E0", VA = "0x183E1B8E0")]
	private Task<List<TResult>> EOPEOKMHHDL(IReadOnlyList<TRequest> HFFECNEPHHC, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BBD0", Offset = "0x3E1A9D0", VA = "0x183E1BBD0")]
	private float HFJNABGNLHG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BC70", Offset = "0x3E1AA70", VA = "0x183E1BC70")]
	private void JJMJEDGCMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EBIICBMKHCG<TItemId, TResult> : DHCHHMHIHMG<IHBFEKAIBLL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> EEHIMKMMPJH(Dictionary<TItemId, int> HFFECNEPHHC, CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DOBOFKAKDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public DOBOFKAKDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4DA8B80", Offset = "0x4DA7980", VA = "0x184DA8B80")]
		internal TResult GNOMODEDFKH(IHBFEKAIBLL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NGJJACDPNIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<IHBFEKAIBLL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public EBIICBMKHCG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DOBOFKAKDJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D129D0", Offset = "0x3D117D0", VA = "0x183D129D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D13720", Offset = "0x3D12520", VA = "0x183D13720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EEHIMKMMPJH DKEANAKFGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> POCKAPPDGKD;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30CE1B0", Offset = "0x30CCFB0", VA = "0x1830CE1B0")]
	public EBIICBMKHCG(EEHIMKMMPJH DKEANAKFGIK, [Optional] IEqualityComparer<TItemId> POCKAPPDGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30CE060", Offset = "0x30CCE60", VA = "0x1830CE060", Slot = "4")]
	[AsyncStateMachine(typeof(EBIICBMKHCG<, >.NGJJACDPNIC))]
	public Task<List<TResult>> MDAHJKIDMIG(IReadOnlyList<IHBFEKAIBLL<TItemId>> HFFECNEPHHC, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JBMABGDGCAK<TRequest, TResult> : DHCHHMHIHMG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> HBFMCNBDLBC(IEnumerable<TRequest> PEKGLIGJILL, CancellationToken ELPOPHCEGNN);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OELJHFCPOHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public OELJHFCPOHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x346C1B0", Offset = "0x346AFB0", VA = "0x18346C1B0")]
		internal TResult GNOMODEDFKH(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FPHHPCKPJLO : IAsyncStateMachine
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
		public JBMABGDGCAK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private OELJHFCPOHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34920B0", Offset = "0x3490EB0", VA = "0x1834920B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3492EE0", Offset = "0x3491CE0", VA = "0x183492EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HBFMCNBDLBC DKEANAKFGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> POCKAPPDGKD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30CE1B0", Offset = "0x30CCFB0", VA = "0x1830CE1B0")]
	public JBMABGDGCAK(HBFMCNBDLBC DKEANAKFGIK, [Optional] IEqualityComparer<TRequest> POCKAPPDGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x391CE20", Offset = "0x391BC20", VA = "0x18391CE20", Slot = "4")]
	[AsyncStateMachine(typeof(JBMABGDGCAK<, >.FPHHPCKPJLO))]
	public Task<List<TResult>> MDAHJKIDMIG(IReadOnlyList<TRequest> HFFECNEPHHC, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DHCHHMHIHMG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> MDAHJKIDMIG(IReadOnlyList<TRequest> HFFECNEPHHC, CancellationToken ELPOPHCEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KLFJIHDKILO<TItemId, TResult> : DHCHHMHIHMG<LEBFMNBEGBD<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task KCKEKHNEHPM(IReadOnlyDictionary<TItemId, LEBFMNBEGBD<TItemId>.CANOIOKMJDN> HFFECNEPHHC, CancellationToken ELPOPHCEGNN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct DHIMIKNAJHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public KLFJIHDKILO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IReadOnlyList<LEBFMNBEGBD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D812D0", Offset = "0x4D800D0", VA = "0x184D812D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4D81800", Offset = "0x4D80600", VA = "0x184D81800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KCKEKHNEHPM GDKNFPCGBPM;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public KLFJIHDKILO(KCKEKHNEHPM GDKNFPCGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A40B40", Offset = "0x3A3F940", VA = "0x183A40B40", Slot = "4")]
	[AsyncStateMachine(typeof(KLFJIHDKILO<, >.DHIMIKNAJHA))]
	public Task<List<object>> MDAHJKIDMIG(IReadOnlyList<LEBFMNBEGBD<TItemId>> HFFECNEPHHC, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A40C80", Offset = "0x3A3FA80", VA = "0x183A40C80")]
	private IReadOnlyDictionary<TItemId, LEBFMNBEGBD<TItemId>.CANOIOKMJDN> NJOOEJKBJCC(IReadOnlyList<LEBFMNBEGBD<TItemId>> HMKJHGNDHIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BLCPBNPJOKA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Dictionary<string, LLMJAGHJFMC> NENMKIDIGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private List<T> EEOHKOOKOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Func<IEnumerable<T>> EJKCGGKOHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Func<T, string> JILCKFBGGPL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LLMJAGHJFMC> LEPDIHKIJDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> BILMOKJAEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EGGPAAKNFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x863AB0", Offset = "0x8628B0", VA = "0x180863AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x45F84C0", Offset = "0x45F72C0", VA = "0x1845F84C0")]
	public BLCPBNPJOKA(Func<IEnumerable<T>> EJKCGGKOHAA, Func<T, string> JILCKFBGGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x45F8240", Offset = "0x45F7040", VA = "0x1845F8240")]
	public void KHHFOFCHJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GMIOOKCBBEL<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid CPNFIEDFLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> MAHDJPOJCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DDGOPLIOLBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface FAFJGAIFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int GIOAIEPJKNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JHEOPCOPPLE<TParam>(TParam PHPDIJICBJO);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KGADPHHLMFG(Exception HCEKMCLPHGI);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KOLEHMHLKIL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class KBIHIMACNJF<TResult> : FAFJGAIFHBB, GMIOOKCBBEL<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly TaskCompletionSource<TResult> MEFJIINLLLH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid CPNFIEDFLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GIOAIEPJKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> MAHDJPOJCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3A1D7F0", Offset = "0x3A1C5F0", VA = "0x183A1D7F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D830", Offset = "0x3A1C630", VA = "0x183A1D830")]
		public KBIHIMACNJF(int HHHPCKKLAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2382260", Offset = "0x2381060", VA = "0x182382260", Slot = "5")]
		public bool JHEOPCOPPLE<TParam>(TParam PHPDIJICBJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D770", Offset = "0x3A1C570", VA = "0x183A1D770", Slot = "6")]
		public bool KGADPHHLMFG(Exception HCEKMCLPHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D7B0", Offset = "0x3A1C5B0", VA = "0x183A1D7B0", Slot = "7")]
		public bool KOLEHMHLKIL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public const string NLOPLGJIMEK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Guid, FAFJGAIFHBB> CHJNKAGJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DIDBLGEOGJO DJCMOADGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool DKFKECGLKLK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x639A1E0", Offset = "0x6398FE0", VA = "0x18639A1E0")]
	public DDGOPLIOLBB([Optional] DIDBLGEOGJO DJCMOADGEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6399BE0", Offset = "0x63989E0", VA = "0x186399BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2351EF0", Offset = "0x2350CF0", VA = "0x182351EF0")]
	public GMIOOKCBBEL<TResult> HPACGJJPKMM<TResult>(int MBOCLLPBOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2351BC0", Offset = "0x23509C0", VA = "0x182351BC0")]
	public bool CDDDHOHJMGI<TResult>(Guid BBBIJFPJAJE, TResult OKONIBAEEBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6399AC0", Offset = "0x63988C0", VA = "0x186399AC0")]
	private void CECKOELKJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6399BE0", Offset = "0x63989E0", VA = "0x186399BE0")]
	private void GFCOCPDPGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6399CF0", Offset = "0x6398AF0", VA = "0x186399CF0")]
	private void HPMMCEJKJMO(int HHHPCKKLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6399FE0", Offset = "0x6398DE0", VA = "0x186399FE0")]
	private void LHANLMNBAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum NHGKENLMPGD
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LEBFMNBEGBD<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class CANOIOKMJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int KKIIPLEHDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int MIEBJBBBLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int DPHCIFMGAJL;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public CANOIOKMJDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId DPJKAABJADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int JOANFMCOENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public NHGKENLMPGD PBMPFJDCKPP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xDDA9D0", Offset = "0xDD97D0", VA = "0x180DDA9D0")]
	public LEBFMNBEGBD(TItemId PJBANAFHINM, int BIKONKGEBKA, NHGKENLMPGD KFIJLJLHGLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MMHIFPFNOEL<TItemId, TResult> : OMMHLAKBCCO<LEBFMNBEGBD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA20B0", Offset = "0x3CA0EB0", VA = "0x183CA20B0")]
	public MMHIFPFNOEL(DHCHHMHIHMG<LEBFMNBEGBD<TItemId>, TResult> KCBJCDKHBJP, TimeSpan JPHHALONKIH, [Optional] NJHNNMMEIIF MKABELFIEGL)
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

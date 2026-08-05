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
public interface IOKOPGFNFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MPINFDPDIHC(int NMLOIDHPKIA, CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MPINFDPDIHC(TimeSpan PKAHLAFKNJB, CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BGPCPNFNMPF : IOKOPGFNFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7303720", Offset = "0x7302320", VA = "0x187303720")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void PKCPHNKIBBJ(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BGPCPNFNMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7303660", Offset = "0x7302260", VA = "0x187303660", Slot = "4")]
	public Task MPINFDPDIHC(int NMLOIDHPKIA, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73036C0", Offset = "0x73022C0", VA = "0x1873036C0", Slot = "5")]
	public Task MPINFDPDIHC(TimeSpan PKAHLAFKNJB, CancellationToken CKKFHABGBNL)
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
		[Cpp2IlInjected.Address(RVA = "0x7304040", Offset = "0x7302C40", VA = "0x187304040", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MKKPPJBFGCF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct CIMNKFMCGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest DCHOHHNANFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> GLHDMNFJCLO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
		public CIMNKFMCGBP(TRequest IBNNNHFPFBF, TaskCompletionSource<TResult> HMHJMNCNKOH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct KAJNGIMAEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public MKKPPJBFGCF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x42A3D80", Offset = "0x42A2980", VA = "0x1842A3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6930", Offset = "0x3ED5530", VA = "0x183ED6930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JFNELOHHDPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MKKPPJBFGCF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x41E82C0", Offset = "0x41E6EC0", VA = "0x1841E82C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x41E86A0", Offset = "0x41E72A0", VA = "0x1841E86A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct FFGOMNPPPLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MKKPPJBFGCF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3DFD200", Offset = "0x3DFBE00", VA = "0x183DFD200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD6B0", Offset = "0x3DFC2B0", VA = "0x183DFD6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HCCDAFJHHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public MKKPPJBFGCF<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3F324D0", Offset = "0x3F310D0", VA = "0x183F324D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3F33660", Offset = "0x3F32260", VA = "0x183F33660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PGMPOLJCNBC<TRequest, TResult> LJLHAMLMHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float HLLCIODKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IOKOPGFNFBN FNCJFJENOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool LHGOPPFGHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<CIMNKFMCGBP> JJEINMGJNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<CIMNKFMCGBP> AADPAKHEMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool FLACEDKPHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource PCGDCJEEHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource JJLDCADPENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task AAPDIADMGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float PPOAMKHFJEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88C760", Offset = "0x88B360", VA = "0x18088C760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88C6E0", Offset = "0x88B2E0", VA = "0x18088C6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45C5300", Offset = "0x45C3F00", VA = "0x1845C5300")]
	public MKKPPJBFGCF(PGMPOLJCNBC<TRequest, TResult> LJLHAMLMHID, TimeSpan HLLCIODKPMB, bool LHGOPPFGHMD, [Optional] IOKOPGFNFBN FNCJFJENOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45C4B60", Offset = "0x45C3760", VA = "0x1845C4B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45C4FA0", Offset = "0x45C3BA0", VA = "0x1845C4FA0")]
	[AsyncStateMachine(typeof(MKKPPJBFGCF<, >.KAJNGIMAEBK))]
	public Task<TResult> NKPJGHDCJIK(TRequest IBNNNHFPFBF, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45C4F00", Offset = "0x45C3B00", VA = "0x1845C4F00")]
	private void NKPJGHDCJIK(TRequest IBNNNHFPFBF, TaskCompletionSource<TResult> HMHJMNCNKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45C4E40", Offset = "0x45C3A40", VA = "0x1845C4E40")]
	public Task KDHDMCFJFKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x45C4A90", Offset = "0x45C3690", VA = "0x1845C4A90")]
	[AsyncStateMachine(typeof(MKKPPJBFGCF<, >.JFNELOHHDPJ))]
	private Task DJHELHBBIIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x45C50C0", Offset = "0x45C3CC0", VA = "0x1845C50C0")]
	[AsyncStateMachine(typeof(MKKPPJBFGCF<, >.FFGOMNPPPLJ))]
	private Task OIDJGJKANEC(CancellationToken MEGJKNHCNDM, CancellationToken CFMCHIJKMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45C48F0", Offset = "0x45C34F0", VA = "0x1845C48F0")]
	[AsyncStateMachine(typeof(MKKPPJBFGCF<, >.HCCDAFJHHBD))]
	private Task DGBPHJCFIPI(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45C4810", Offset = "0x45C3410", VA = "0x1845C4810")]
	private TimeSpan CPDHHMLMIEN()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x45C51E0", Offset = "0x45C3DE0", VA = "0x1845C51E0")]
	private Task<List<TResult>> OOIEDAMKHCA(IReadOnlyList<TRequest> HODPFMBLMAN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45C4DA0", Offset = "0x45C39A0", VA = "0x1845C4DA0")]
	private float JJFCIENCNMI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45C49F0", Offset = "0x45C35F0", VA = "0x1845C49F0")]
	private void DIBBPACCPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AOLHIINEFID<TItemId, TResult> : PGMPOLJCNBC<OHBMLHDMMJO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> DANCHKKHAKI(Dictionary<TItemId, int> HODPFMBLMAN, CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GDINPDPLAHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GDINPDPLAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8AB0", Offset = "0x3ED76B0", VA = "0x183ED8AB0")]
		internal TResult NPCPGGIEAAK(OHBMLHDMMJO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LBONDIEIFMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<OHBMLHDMMJO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AOLHIINEFID<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private GDINPDPLAHG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4366CC0", Offset = "0x43658C0", VA = "0x184366CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4367A00", Offset = "0x4366600", VA = "0x184367A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DANCHKKHAKI HCJLPJNIFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> DMMDHIPDEFD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F22680", Offset = "0x3F21280", VA = "0x183F22680")]
	public AOLHIINEFID(DANCHKKHAKI HCJLPJNIFCD, [Optional] IEqualityComparer<TItemId> DMMDHIPDEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F22140", Offset = "0x3F20D40", VA = "0x183F22140", Slot = "4")]
	[AsyncStateMachine(typeof(AOLHIINEFID<, >.LBONDIEIFMK))]
	public Task<List<TResult>> INHNGFFGFHO(IReadOnlyList<OHBMLHDMMJO<TItemId>> HODPFMBLMAN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HJDBDEOEAHH<TRequest, TResult> : PGMPOLJCNBC<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> LFIFADCPHAD(IEnumerable<TRequest> PPCBBMNPGMD, CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KCFMDIJDMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KCFMDIJDMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3E07BF0", Offset = "0x3E067F0", VA = "0x183E07BF0")]
		internal TResult NPCPGGIEAAK(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct PDFLAOLNHFB : IAsyncStateMachine
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
		public HJDBDEOEAHH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private KCFMDIJDMFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x48817F0", Offset = "0x48803F0", VA = "0x1848817F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4882630", Offset = "0x4881230", VA = "0x184882630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LFIFADCPHAD HCJLPJNIFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> DMMDHIPDEFD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F22680", Offset = "0x3F21280", VA = "0x183F22680")]
	public HJDBDEOEAHH(LFIFADCPHAD HCJLPJNIFCD, [Optional] IEqualityComparer<TRequest> DMMDHIPDEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F44B50", Offset = "0x3F43750", VA = "0x183F44B50", Slot = "4")]
	[AsyncStateMachine(typeof(HJDBDEOEAHH<, >.PDFLAOLNHFB))]
	public Task<List<TResult>> INHNGFFGFHO(IReadOnlyList<TRequest> HODPFMBLMAN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PGMPOLJCNBC<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> INHNGFFGFHO(IReadOnlyList<TRequest> HODPFMBLMAN, CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DIIIMKHKEHC<TItemId, TResult> : PGMPOLJCNBC<KBGLOFNALNM<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task ELEAAANDNNK(IReadOnlyDictionary<TItemId, KBGLOFNALNM<TItemId>.CDCNBJACCIB> HODPFMBLMAN, CancellationToken CKKFHABGBNL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NDDALEDBPIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DIIIMKHKEHC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<KBGLOFNALNM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x464BF70", Offset = "0x464AB70", VA = "0x18464BF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x464C4C0", Offset = "0x464B0C0", VA = "0x18464C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ELEAAANDNNK GNGMAPGHMEF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public DIIIMKHKEHC(ELEAAANDNNK GNGMAPGHMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7BF0", Offset = "0x5AD67F0", VA = "0x185AD7BF0", Slot = "4")]
	[AsyncStateMachine(typeof(DIIIMKHKEHC<, >.NDDALEDBPIA))]
	public Task<List<object>> INHNGFFGFHO(IReadOnlyList<KBGLOFNALNM<TItemId>> HODPFMBLMAN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7770", Offset = "0x5AD6370", VA = "0x185AD7770")]
	private IReadOnlyDictionary<TItemId, KBGLOFNALNM<TItemId>.CDCNBJACCIB> BHFMIOHJIOD(IReadOnlyList<KBGLOFNALNM<TItemId>> PNAAJGBEBGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AEKDLKKEJAI<TItemId, TResult> : PGMPOLJCNBC<OHBMLHDMMJO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> FMAAADGKEHF(Dictionary<TItemId, int> HODPFMBLMAN, CancellationToken CKKFHABGBNL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct IHEFGOBDHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<OHBMLHDMMJO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AEKDLKKEJAI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x402ADF0", Offset = "0x40299F0", VA = "0x18402ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x402C790", Offset = "0x402B390", VA = "0x18402C790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FMAAADGKEHF HCGNOLAMPDD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public AEKDLKKEJAI(FMAAADGKEHF HCJLPJNIFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EA60F0", Offset = "0x3EA4CF0", VA = "0x183EA60F0", Slot = "4")]
	[AsyncStateMachine(typeof(AEKDLKKEJAI<, >.IHEFGOBDHJA))]
	public Task<List<TResult>> INHNGFFGFHO(IReadOnlyList<OHBMLHDMMJO<TItemId>> HODPFMBLMAN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FGJCMAFGGGM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, LGLIHOABELM> MNEBLLNGIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> DHOMGBEPBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> AOMKCAGECHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> KFMNNLGGMGH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, LGLIHOABELM> FHPCKJANNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> BHDDNPDJNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EDKKEHCAFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x921740", Offset = "0x920340", VA = "0x180921740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3E06560", Offset = "0x3E05160", VA = "0x183E06560")]
	public FGJCMAFGGGM(Func<IEnumerable<T>> AOMKCAGECHB, Func<T, string> KFMNNLGGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E062A0", Offset = "0x3E04EA0", VA = "0x183E062A0")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E06210", Offset = "0x3E04E10", VA = "0x183E06210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AOAMPPCCKFJ<TItemId, TResult> : MKKPPJBFGCF<OHBMLHDMMJO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F800", Offset = "0x3F1E400", VA = "0x183F1F800")]
	public AOAMPPCCKFJ(PGMPOLJCNBC<OHBMLHDMMJO<TItemId>, TResult> LJLHAMLMHID, TimeSpan HLLCIODKPMB, bool LHGOPPFGHMD, [Optional] IOKOPGFNFBN FNCJFJENOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3F1F350", Offset = "0x3F1DF50", VA = "0x183F1F350")]
	public Task<TResult> NKPJGHDCJIK(TItemId NONKDEOLPHL, int IFODNKOJDJK, [Optional] CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OHBMLHDMMJO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId HGFAEJLCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int AAGLCMJAKGB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x47A89E0", Offset = "0x47A75E0", VA = "0x1847A89E0")]
	public OHBMLHDMMJO(TItemId HKNGKNOKFAF, int IFODNKOJDJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DEDJFPKDBDH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid JEFIFOCEMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> HAMEGDEGNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PBOEONFNOEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface HEDBMCGOEML
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KMDBFJNJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CJGJEEMENMM<TParam>(TParam CABLCDOIFFL);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BDLEJECDANL(Exception EFPHLGHGCEN);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CHDLLANHPEF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class OADOAKGJIOK<TResult> : HEDBMCGOEML, DEDJFPKDBDH<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> IJDPKOGCIHP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid JEFIFOCEMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KMDBFJNJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> HAMEGDEGNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4629850", Offset = "0x4628450", VA = "0x184629850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4785DC0", Offset = "0x47849C0", VA = "0x184785DC0")]
		public OADOAKGJIOK(int DMAMNFOICIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2E8BAA0", Offset = "0x2E8A6A0", VA = "0x182E8BAA0", Slot = "5")]
		public bool CJGJEEMENMM<TParam>(TParam CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4785D20", Offset = "0x4784920", VA = "0x184785D20", Slot = "6")]
		public bool BDLEJECDANL(Exception EFPHLGHGCEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4785D70", Offset = "0x4784970", VA = "0x184785D70", Slot = "7")]
		public bool CHDLLANHPEF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string LJKGHJIDLJO = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, HEDBMCGOEML> NEKNAKFFGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly AAMDFIOALIP ABCLFMKCLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool OFLEAHDNCKG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7303F40", Offset = "0x7302B40", VA = "0x187303F40")]
	public PBOEONFNOEJ([Optional] AAMDFIOALIP ABCLFMKCLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7303A20", Offset = "0x7302620", VA = "0x187303A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2FD12B0", Offset = "0x2FCFEB0", VA = "0x182FD12B0")]
	public DEDJFPKDBDH<TResult> OBOINOOHHAJ<TResult>(int EIHIBGPAKEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0F40", Offset = "0x2FCFB40", VA = "0x182FD0F40")]
	public bool NIAHDLNCLAE<TResult>(Guid AECBMPLKMNA, TResult CMNKPAFMHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7303E20", Offset = "0x7302A20", VA = "0x187303E20")]
	private void JJKNAMGIPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7303A20", Offset = "0x7302620", VA = "0x187303A20")]
	private void HEDHOOEICIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7303B30", Offset = "0x7302730", VA = "0x187303B30")]
	private void EEPAGFLDNCG(int DMAMNFOICIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7303820", Offset = "0x7302420", VA = "0x187303820")]
	private void CMPOEKJHMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum ANAIAIONCCP
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KBGLOFNALNM<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class CDCNBJACCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int MCMKLANKIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int LEPIEFCDDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int CJLNNHDHICF;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CDCNBJACCIB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId HGFAEJLCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int AAGLCMJAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public ANAIAIONCCP MJGEJKHILEA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1552BE0", Offset = "0x15517E0", VA = "0x181552BE0")]
	public KBGLOFNALNM(TItemId HKNGKNOKFAF, int IFODNKOJDJK, ANAIAIONCCP DOHADELBNEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MIIGPCGPJCJ<TItemId, TResult> : MKKPPJBFGCF<KBGLOFNALNM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x45BF150", Offset = "0x45BDD50", VA = "0x1845BF150")]
	public MIIGPCGPJCJ(PGMPOLJCNBC<KBGLOFNALNM<TItemId>, TResult> LJLHAMLMHID, TimeSpan HLLCIODKPMB, [Optional] IOKOPGFNFBN FNCJFJENOAM)
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

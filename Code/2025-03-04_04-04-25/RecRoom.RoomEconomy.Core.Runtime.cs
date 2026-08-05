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
public interface CJMPOIBABDA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task POPBMCCAEMF(int COLOJIGPMOM, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task POPBMCCAEMF(TimeSpan KGHCAKHKIAJ, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GFLFKFGLKEJ : CJMPOIBABDA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DBE0", Offset = "0x7C6C1E0", VA = "0x187C6DBE0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFLFKFGLKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DCE0", Offset = "0x7C6C2E0", VA = "0x187C6DCE0", Slot = "4")]
	public Task POPBMCCAEMF(int COLOJIGPMOM, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DD40", Offset = "0x7C6C340", VA = "0x187C6DD40", Slot = "5")]
	public Task POPBMCCAEMF(TimeSpan KGHCAKHKIAJ, CancellationToken LAEIHJHNGEK)
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
		[Cpp2IlInjected.Address(RVA = "0x7C6DDA0", Offset = "0x7C6C3A0", VA = "0x187C6DDA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LAPALNJEJKM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct MCAKCLIIMDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest AICDCFGMFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> CKLPPHCDEHI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
		public MCAKCLIIMDI(TRequest NEMAHPGAGLG, TaskCompletionSource<TResult> MECOEADPMKH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct FPPKKNKMGCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LAPALNJEJKM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x443BD90", Offset = "0x443A390", VA = "0x18443BD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4076960", Offset = "0x4074F60", VA = "0x184076960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct DLDEABGGIOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LAPALNJEJKM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6325BD0", Offset = "0x63241D0", VA = "0x186325BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6325FB0", Offset = "0x63245B0", VA = "0x186325FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KLKAFEJHKJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LAPALNJEJKM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4AC2790", Offset = "0x4AC0D90", VA = "0x184AC2790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2C40", Offset = "0x4AC1240", VA = "0x184AC2C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FHCHFKHDOOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LAPALNJEJKM<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x44227E0", Offset = "0x4420DE0", VA = "0x1844227E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4423990", Offset = "0x4421F90", VA = "0x184423990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GFMOGOALIDH<TRequest, TResult> LMOIJNJAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float CNDOOMCNAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CJMPOIBABDA EPLBJILLFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool AKGAKLIPCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<MCAKCLIIMDI> CLLJDIKADBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<MCAKCLIIMDI> CAAHLNBAIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool CLCCHPKGLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource BLIIBHHFCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource NEPAOGCLCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task FLJCJLGLBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float NAMCDNGFNIA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x956CF0", Offset = "0x9552F0", VA = "0x180956CF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x956D80", Offset = "0x955380", VA = "0x180956D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BA45B0", Offset = "0x4BA2BB0", VA = "0x184BA45B0")]
	public LAPALNJEJKM(GFMOGOALIDH<TRequest, TResult> LMOIJNJAODD, TimeSpan CNDOOMCNAKC, bool AKGAKLIPCFK, [Optional] CJMPOIBABDA EPLBJILLFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3B90", Offset = "0x4BA2190", VA = "0x184BA3B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BA40B0", Offset = "0x4BA26B0", VA = "0x184BA40B0")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.FPPKKNKMGCJ))]
	public Task<TResult> LOFILBPFJOI(TRequest NEMAHPGAGLG, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BA41D0", Offset = "0x4BA27D0", VA = "0x184BA41D0")]
	private void LOFILBPFJOI(TRequest NEMAHPGAGLG, TaskCompletionSource<TResult> MECOEADPMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3FF0", Offset = "0x4BA25F0", VA = "0x184BA3FF0")]
	public Task JJMFAANPAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3AC0", Offset = "0x4BA20C0", VA = "0x184BA3AC0")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.DLDEABGGIOI))]
	private Task DDCNIKKPJKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4350", Offset = "0x4BA2950", VA = "0x184BA4350")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.KLKAFEJHKJC))]
	private Task OBJPBIONPHN(CancellationToken NLKPBBAKBKI, CancellationToken NAJBHKOBKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3DD0", Offset = "0x4BA23D0", VA = "0x184BA3DD0")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.FHCHFKHDOOM))]
	private Task EBNCHOOCHJH(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4270", Offset = "0x4BA2870", VA = "0x184BA4270")]
	private TimeSpan MKBDBDBDKKK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3ED0", Offset = "0x4BA24D0", VA = "0x184BA3ED0")]
	private Task<List<TResult>> HGNPLGCHILM(IReadOnlyList<TRequest> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4510", Offset = "0x4BA2B10", VA = "0x184BA4510")]
	private float PLGLELFDMND()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4470", Offset = "0x4BA2A70", VA = "0x184BA4470")]
	private void PKHDLIKLAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OMFLGBBBHEE<TItemId, TResult> : GFMOGOALIDH<GFFOCDCIACO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> COBFPBPNAIG(Dictionary<TItemId, int> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OBDBMKFPPOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public OBDBMKFPPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA280", Offset = "0x4FD8880", VA = "0x184FDA280")]
		internal TResult BCCGBFJBOMC(GFFOCDCIACO<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CNPMPEODABI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<GFFOCDCIACO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OMFLGBBBHEE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private OBDBMKFPPOK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C49200", Offset = "0x5C47800", VA = "0x185C49200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C49F60", Offset = "0x5C48560", VA = "0x185C49F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly COBFPBPNAIG AHDOFHCOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> BLMEGMHOING;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4786E80", Offset = "0x4785480", VA = "0x184786E80")]
	public OMFLGBBBHEE(COBFPBPNAIG AHDOFHCOFIK, [Optional] IEqualityComparer<TItemId> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5027880", Offset = "0x5025E80", VA = "0x185027880", Slot = "4")]
	[AsyncStateMachine(typeof(OMFLGBBBHEE<, >.CNPMPEODABI))]
	public Task<List<TResult>> JILCAIMIBGD(IReadOnlyList<GFFOCDCIACO<TItemId>> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ILABKJCCAOD<TRequest, TResult> : GFMOGOALIDH<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> PEOLKOHHPOF(IEnumerable<TRequest> FLBICDNHLHF, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class AKGDHFLGCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AKGDHFLGCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4439C90", Offset = "0x4438290", VA = "0x184439C90")]
		internal TResult BCCGBFJBOMC(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MPHBJMKOKNE : IAsyncStateMachine
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
		public ILABKJCCAOD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private AKGDHFLGCHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B8D0", Offset = "0x4E39ED0", VA = "0x184E3B8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E3C730", Offset = "0x4E3AD30", VA = "0x184E3C730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PEOLKOHHPOF AHDOFHCOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> BLMEGMHOING;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4786E80", Offset = "0x4785480", VA = "0x184786E80")]
	public ILABKJCCAOD(PEOLKOHHPOF AHDOFHCOFIK, [Optional] IEqualityComparer<TRequest> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4786D40", Offset = "0x4785340", VA = "0x184786D40", Slot = "4")]
	[AsyncStateMachine(typeof(ILABKJCCAOD<, >.MPHBJMKOKNE))]
	public Task<List<TResult>> JILCAIMIBGD(IReadOnlyList<TRequest> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GFMOGOALIDH<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JILCAIMIBGD(IReadOnlyList<TRequest> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PBKIKGELFIJ<TItemId, TResult> : GFMOGOALIDH<DACJAHFCMFN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task BDNIKAHDJCL(IReadOnlyDictionary<TItemId, DACJAHFCMFN<TItemId>.IDFJHDFDAFD> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NBGNJGPIIEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public PBKIKGELFIJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<DACJAHFCMFN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4E8A5A0", Offset = "0x4E88BA0", VA = "0x184E8A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4E8AB00", Offset = "0x4E89100", VA = "0x184E8AB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BDNIKAHDJCL JKFMJDHLCHI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public PBKIKGELFIJ(BDNIKAHDJCL JKFMJDHLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50D9C30", Offset = "0x50D8230", VA = "0x1850D9C30", Slot = "4")]
	[AsyncStateMachine(typeof(PBKIKGELFIJ<, >.NBGNJGPIIEA))]
	public Task<List<object>> JILCAIMIBGD(IReadOnlyList<DACJAHFCMFN<TItemId>> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x50D9D70", Offset = "0x50D8370", VA = "0x1850D9D70")]
	private IReadOnlyDictionary<TItemId, DACJAHFCMFN<TItemId>.IDFJHDFDAFD> NCEBBPNEBKP(IReadOnlyList<DACJAHFCMFN<TItemId>> IEGMNHCPACF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PALNCJEANLO<TItemId, TResult> : GFMOGOALIDH<GFFOCDCIACO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> HCBGCDFNHOK(Dictionary<TItemId, int> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct AHJBIEOAJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<GFFOCDCIACO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public PALNCJEANLO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x47D6830", Offset = "0x47D4E30", VA = "0x1847D6830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x47D81D0", Offset = "0x47D67D0", VA = "0x1847D81D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HCBGCDFNHOK KHPFLEBJFMK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public PALNCJEANLO(HCBGCDFNHOK AHDOFHCOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x50D9180", Offset = "0x50D7780", VA = "0x1850D9180", Slot = "4")]
	[AsyncStateMachine(typeof(PALNCJEANLO<, >.AHJBIEOAJGG))]
	public Task<List<TResult>> JILCAIMIBGD(IReadOnlyList<GFFOCDCIACO<TItemId>> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IMLBNLMIBBO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, OEKJFHFPCFG> HMJFJFFANNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> EPDFLLEGKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> JFKMPOMFIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> FAMLDEDJLBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OEKJFHFPCFG> AKOGGILLMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> CIKKEHPGMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ODACKNJNKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB44CD0", Offset = "0xB432D0", VA = "0x180B44CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4788AE0", Offset = "0x47870E0", VA = "0x184788AE0")]
	public IMLBNLMIBBO(Func<IEnumerable<T>> JFKMPOMFIOP, Func<T, string> FAMLDEDJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4788820", Offset = "0x4786E20", VA = "0x184788820")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4788790", Offset = "0x4786D90", VA = "0x184788790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NHMLGKKAPBH<TItemId, TResult> : LAPALNJEJKM<GFFOCDCIACO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x440A720", Offset = "0x4408D20", VA = "0x18440A720")]
	public NHMLGKKAPBH(GFMOGOALIDH<GFFOCDCIACO<TItemId>, TResult> LMOIJNJAODD, TimeSpan CNDOOMCNAKC, bool AKGAKLIPCFK, [Optional] CJMPOIBABDA EPLBJILLFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FF70", Offset = "0x4E9E570", VA = "0x184E9FF70")]
	public Task<TResult> LOFILBPFJOI(TItemId LKMGECEEGEE, int IAKJCHAJGGI, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GFFOCDCIACO<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId GKICPHKOPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int IDEDDCJANBJ;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x44E4860", Offset = "0x44E2E60", VA = "0x1844E4860")]
	public GFFOCDCIACO(TItemId GOBDDMLNCNK, int IAKJCHAJGGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GDPMHGJGDMD<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid FLJLEJEOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> EHPFBIIGNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BKCMCEPPHLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface KGNAABAFDBP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int JBJPDGHKPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DPILKNOGDNK<TParam>(TParam KBGCCIOIGBD);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IPNMOIHBHAC(Exception JNJDMGFBFDL);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DDEBDJBIMPL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class JMDAKCCHIFC<TResult> : KGNAABAFDBP, GDPMHGJGDMD<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> KDHLGIELGNK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid FLJLEJEOHHD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int JBJPDGHKPIL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> EHPFBIIGNKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x49D8AE0", Offset = "0x49D70E0", VA = "0x1849D8AE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x49D8B80", Offset = "0x49D7180", VA = "0x1849D8B80")]
		public JMDAKCCHIFC(int PENPJECGOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x358E4D0", Offset = "0x358CAD0", VA = "0x18358E4D0", Slot = "5")]
		public bool DPILKNOGDNK<TParam>(TParam KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x49D8B30", Offset = "0x49D7130", VA = "0x1849D8B30", Slot = "6")]
		public bool IPNMOIHBHAC(Exception JNJDMGFBFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49D8A90", Offset = "0x49D7090", VA = "0x1849D8A90", Slot = "7")]
		public bool DDEBDJBIMPL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string GGGEDKCEALA = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, KGNAABAFDBP> EIIELEBCGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IHHNFNMOFKD CBGBLGOPCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LKBKIBBNIJB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DAE0", Offset = "0x7C6C0E0", VA = "0x187C6DAE0")]
	public BKCMCEPPHLB([Optional] IHHNFNMOFKD CBGBLGOPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D3D0", Offset = "0x7C6B9D0", VA = "0x187C6D3D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3199E30", Offset = "0x3198430", VA = "0x183199E30")]
	public GDPMHGJGDMD<TResult> GCAAJPCGDPE<TResult>(int NFFIDMCMFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x319A150", Offset = "0x3198750", VA = "0x18319A150")]
	public bool MACANLPNCEF<TResult>(Guid EHMIFANHMPO, TResult BIEIOPPGBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D7C0", Offset = "0x7C6BDC0", VA = "0x187C6D7C0")]
	private void PPJIJFAKBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D3D0", Offset = "0x7C6B9D0", VA = "0x187C6D3D0")]
	private void IIDPCADCCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D4E0", Offset = "0x7C6BAE0", VA = "0x187C6D4E0")]
	private void EMPDENOCOFP(int PENPJECGOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D8E0", Offset = "0x7C6BEE0", VA = "0x187C6D8E0")]
	private void PPNBBDJPFPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum OPIEOHHLFPO
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DACJAHFCMFN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class IDFJHDFDAFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int EBPLHAKLHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int AIGDKOAJLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int ECGLBNOLBJA;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public IDFJHDFDAFD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId GKICPHKOPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int IDEDDCJANBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OPIEOHHLFPO NBHLLFPPFCE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C05BF0", Offset = "0x1C041F0", VA = "0x181C05BF0")]
	public DACJAHFCMFN(TItemId GOBDDMLNCNK, int IAKJCHAJGGI, OPIEOHHLFPO MBDLAJMBAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CFGAIIIFNDG<TItemId, TResult> : LAPALNJEJKM<DACJAHFCMFN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5A76340", Offset = "0x5A74940", VA = "0x185A76340")]
	public CFGAIIIFNDG(GFMOGOALIDH<DACJAHFCMFN<TItemId>, TResult> LMOIJNJAODD, TimeSpan CNDOOMCNAKC, [Optional] CJMPOIBABDA EPLBJILLFJM)
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

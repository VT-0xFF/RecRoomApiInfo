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
	[Cpp2IlInjected.Address(RVA = "0x7BC9550", Offset = "0x7BC8950", VA = "0x187BC9550")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFLFKFGLKEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9650", Offset = "0x7BC8A50", VA = "0x187BC9650", Slot = "4")]
	public Task POPBMCCAEMF(int COLOJIGPMOM, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC96B0", Offset = "0x7BC8AB0", VA = "0x187BC96B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC9710", Offset = "0x7BC8B10", VA = "0x187BC9710", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x43E21B0", Offset = "0x43E15B0", VA = "0x1843E21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4023CE0", Offset = "0x40230E0", VA = "0x184023CE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x62BDA60", Offset = "0x62BCE60", VA = "0x1862BDA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62BDE40", Offset = "0x62BD240", VA = "0x1862BDE40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A66630", Offset = "0x4A65A30", VA = "0x184A66630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4A66AE0", Offset = "0x4A65EE0", VA = "0x184A66AE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x43C93F0", Offset = "0x43C87F0", VA = "0x1843C93F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43CA5A0", Offset = "0x43C99A0", VA = "0x1843CA5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FCF0", Offset = "0x94F0F0", VA = "0x18094FCF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x94FD80", Offset = "0x94F180", VA = "0x18094FD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B477E0", Offset = "0x4B46BE0", VA = "0x184B477E0")]
	public LAPALNJEJKM(GFMOGOALIDH<TRequest, TResult> LMOIJNJAODD, TimeSpan CNDOOMCNAKC, bool AKGAKLIPCFK, [Optional] CJMPOIBABDA EPLBJILLFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B46DC0", Offset = "0x4B461C0", VA = "0x184B46DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B472E0", Offset = "0x4B466E0", VA = "0x184B472E0")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.FPPKKNKMGCJ))]
	public Task<TResult> LOFILBPFJOI(TRequest NEMAHPGAGLG, [Optional] CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B47400", Offset = "0x4B46800", VA = "0x184B47400")]
	private void LOFILBPFJOI(TRequest NEMAHPGAGLG, TaskCompletionSource<TResult> MECOEADPMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B47220", Offset = "0x4B46620", VA = "0x184B47220")]
	public Task JJMFAANPAHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B46CF0", Offset = "0x4B460F0", VA = "0x184B46CF0")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.DLDEABGGIOI))]
	private Task DDCNIKKPJKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B47580", Offset = "0x4B46980", VA = "0x184B47580")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.KLKAFEJHKJC))]
	private Task OBJPBIONPHN(CancellationToken NLKPBBAKBKI, CancellationToken NAJBHKOBKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B47000", Offset = "0x4B46400", VA = "0x184B47000")]
	[AsyncStateMachine(typeof(LAPALNJEJKM<, >.FHCHFKHDOOM))]
	private Task EBNCHOOCHJH(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B474A0", Offset = "0x4B468A0", VA = "0x184B474A0")]
	private TimeSpan MKBDBDBDKKK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B47100", Offset = "0x4B46500", VA = "0x184B47100")]
	private Task<List<TResult>> HGNPLGCHILM(IReadOnlyList<TRequest> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B47740", Offset = "0x4B46B40", VA = "0x184B47740")]
	private float PLGLELFDMND()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B476A0", Offset = "0x4B46AA0", VA = "0x184B476A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OBDBMKFPPOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B7C0", Offset = "0x4F7ABC0", VA = "0x184F7B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C10EF0", Offset = "0x5C102F0", VA = "0x185C10EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C11C50", Offset = "0x5C11050", VA = "0x185C11C50", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x472DAA0", Offset = "0x472CEA0", VA = "0x18472DAA0")]
	public OMFLGBBBHEE(COBFPBPNAIG AHDOFHCOFIK, [Optional] IEqualityComparer<TItemId> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8E90", Offset = "0x4FC8290", VA = "0x184FC8E90", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AKGDHFLGCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x43E00B0", Offset = "0x43DF4B0", VA = "0x1843E00B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DDDD90", Offset = "0x4DDD190", VA = "0x184DDDD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DDEBF0", Offset = "0x4DDDFF0", VA = "0x184DDEBF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x472DAA0", Offset = "0x472CEA0", VA = "0x18472DAA0")]
	public ILABKJCCAOD(PEOLKOHHPOF AHDOFHCOFIK, [Optional] IEqualityComparer<TRequest> BLMEGMHOING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x472D960", Offset = "0x472CD60", VA = "0x18472D960", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E1FF90", Offset = "0x4E1F390", VA = "0x184E1FF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4E204F0", Offset = "0x4E1F8F0", VA = "0x184E204F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BDNIKAHDJCL JKFMJDHLCHI;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public PBKIKGELFIJ(BDNIKAHDJCL JKFMJDHLCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x507B6B0", Offset = "0x507AAB0", VA = "0x18507B6B0", Slot = "4")]
	[AsyncStateMachine(typeof(PBKIKGELFIJ<, >.NBGNJGPIIEA))]
	public Task<List<object>> JILCAIMIBGD(IReadOnlyList<DACJAHFCMFN<TItemId>> MCKHCNKFJIH, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x507B7F0", Offset = "0x507ABF0", VA = "0x18507B7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x47A18C0", Offset = "0x47A0CC0", VA = "0x1847A18C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x47A3260", Offset = "0x47A2660", VA = "0x1847A3260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HCBGCDFNHOK KHPFLEBJFMK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public PALNCJEANLO(HCBGCDFNHOK AHDOFHCOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x506D490", Offset = "0x506C890", VA = "0x18506D490", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> CIKKEHPGMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ODACKNJNKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB39280", Offset = "0xB38680", VA = "0x180B39280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x472F700", Offset = "0x472EB00", VA = "0x18472F700")]
	public IMLBNLMIBBO(Func<IEnumerable<T>> JFKMPOMFIOP, Func<T, string> FAMLDEDJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x472F440", Offset = "0x472E840", VA = "0x18472F440")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x472F3B0", Offset = "0x472E7B0", VA = "0x18472F3B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NHMLGKKAPBH<TItemId, TResult> : LAPALNJEJKM<GFFOCDCIACO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x43B1270", Offset = "0x43B0670", VA = "0x1843B1270")]
	public NHMLGKKAPBH(GFMOGOALIDH<GFFOCDCIACO<TItemId>, TResult> LMOIJNJAODD, TimeSpan CNDOOMCNAKC, bool AKGAKLIPCFK, [Optional] CJMPOIBABDA EPLBJILLFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E35960", Offset = "0x4E34D60", VA = "0x184E35960")]
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
	[Cpp2IlInjected.Address(RVA = "0x448B1E0", Offset = "0x448A5E0", VA = "0x18448B1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x497D0B0", Offset = "0x497C4B0", VA = "0x18497D0B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x497D150", Offset = "0x497C550", VA = "0x18497D150")]
		public JMDAKCCHIFC(int PENPJECGOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x35585B0", Offset = "0x35579B0", VA = "0x1835585B0", Slot = "5")]
		public bool DPILKNOGDNK<TParam>(TParam KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x497D100", Offset = "0x497C500", VA = "0x18497D100", Slot = "6")]
		public bool IPNMOIHBHAC(Exception JNJDMGFBFDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x497D060", Offset = "0x497C460", VA = "0x18497D060", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BC9450", Offset = "0x7BC8850", VA = "0x187BC9450")]
	public BKCMCEPPHLB([Optional] IHHNFNMOFKD CBGBLGOPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8D40", Offset = "0x7BC8140", VA = "0x187BC8D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31534D0", Offset = "0x31528D0", VA = "0x1831534D0")]
	public GDPMHGJGDMD<TResult> GCAAJPCGDPE<TResult>(int NFFIDMCMFAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31537F0", Offset = "0x3152BF0", VA = "0x1831537F0")]
	public bool MACANLPNCEF<TResult>(Guid EHMIFANHMPO, TResult BIEIOPPGBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9130", Offset = "0x7BC8530", VA = "0x187BC9130")]
	private void PPJIJFAKBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8D40", Offset = "0x7BC8140", VA = "0x187BC8D40")]
	private void IIDPCADCCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BC8E50", Offset = "0x7BC8250", VA = "0x187BC8E50")]
	private void EMPDENOCOFP(int PENPJECGOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9250", Offset = "0x7BC8650", VA = "0x187BC9250")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BE5860", Offset = "0x1BE4C60", VA = "0x181BE5860")]
	public DACJAHFCMFN(TItemId GOBDDMLNCNK, int IAKJCHAJGGI, OPIEOHHLFPO MBDLAJMBAIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CFGAIIIFNDG<TItemId, TResult> : LAPALNJEJKM<DACJAHFCMFN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5A3D6C0", Offset = "0x5A3CAC0", VA = "0x185A3D6C0")]
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

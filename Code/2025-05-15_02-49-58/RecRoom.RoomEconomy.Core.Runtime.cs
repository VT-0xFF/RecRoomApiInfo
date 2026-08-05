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
public interface MOEBIEAOCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IDBDDKOHBNN(int JCNHGMDIBDN, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IDBDDKOHBNN(TimeSpan OGHFHNAFGCJ, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FNCFGJDMGKG : MOEBIEAOCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83E0340", Offset = "0x83DE940", VA = "0x1883E0340")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNCFGJDMGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83E02E0", Offset = "0x83DE8E0", VA = "0x1883E02E0", Slot = "4")]
	public Task IDBDDKOHBNN(int JCNHGMDIBDN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83E0280", Offset = "0x83DE880", VA = "0x1883E0280", Slot = "5")]
	public Task IDBDDKOHBNN(TimeSpan OGHFHNAFGCJ, CancellationToken CBJPDIFOEKF)
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
		[Cpp2IlInjected.Address(RVA = "0x83E0DC0", Offset = "0x83DF3C0", VA = "0x1883E0DC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IHMBCMLGKFP : OGPFHFAELNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KACBIJBMPOH FFOOIHKACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BANGNHDBEGD<bool> NKLOGBDLJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BANGNHDBEGD<bool> FJIPIELFPHK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANIAKHAAHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83E03B0", Offset = "0x83DE9B0", VA = "0x1883E03B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ENFCNIJJGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83E0470", Offset = "0x83DEA70", VA = "0x1883E0470", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83E0400", Offset = "0x83DEA00", VA = "0x1883E0400")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83E04C0", Offset = "0x83DEAC0", VA = "0x1883E04C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IHMBCMLGKFP([DJIFKCCBBND(null)][NotNull] KACBIJBMPOH FFOOIHKACEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FBFEDHLNICH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct KFLNINEBEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest NGOFJAKHGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> IBHLCEONLMD;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
		public KFLNINEBEFC(TRequest HOOJNAMGGBC, TaskCompletionSource<TResult> NDDCKHOMMDA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AMJFFJPDNBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FBFEDHLNICH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4D6F1E0", Offset = "0x4D6D7E0", VA = "0x184D6F1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x49D47E0", Offset = "0x49D2DE0", VA = "0x1849D47E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ODPEMBBDMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FBFEDHLNICH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x55269E0", Offset = "0x5524FE0", VA = "0x1855269E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5526DC0", Offset = "0x55253C0", VA = "0x185526DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CKJLKELOBCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FBFEDHLNICH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x67D2C80", Offset = "0x67D1280", VA = "0x1867D2C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67D3130", Offset = "0x67D1730", VA = "0x1867D3130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NMHDDJKHGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public FBFEDHLNICH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5413DF0", Offset = "0x54123F0", VA = "0x185413DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5414F80", Offset = "0x5413580", VA = "0x185414F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PCNABBENPFD<TRequest, TResult> PGJIOGDCGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float PCAICKIEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MOEBIEAOCEG FKMDHPHEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool PNJODEKCBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<KFLNINEBEFC> MJHPLEGPLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<KFLNINEBEFC> FKMEDFEOOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KKHJIBPMNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource GGCGFAEPDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource CKLJOOHLMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task NLBDNBEJJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float IBAJCEAGDPC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F32E0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F32C0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x498F7F0", Offset = "0x498DDF0", VA = "0x18498F7F0")]
	public FBFEDHLNICH(PCNABBENPFD<TRequest, TResult> PGJIOGDCGCO, TimeSpan PCAICKIEEGM, bool PNJODEKCBBL, [Optional] MOEBIEAOCEG FKMDHPHEEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x498F060", Offset = "0x498D660", VA = "0x18498F060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x498F3C0", Offset = "0x498D9C0", VA = "0x18498F3C0")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.AMJFFJPDNBC))]
	public Task<TResult> JBBPIHDMKLN(TRequest HOOJNAMGGBC, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x498F4E0", Offset = "0x498DAE0", VA = "0x18498F4E0")]
	private void JBBPIHDMKLN(TRequest HOOJNAMGGBC, TaskCompletionSource<TResult> NDDCKHOMMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x498F580", Offset = "0x498DB80", VA = "0x18498F580")]
	public Task JEAPMMFEINP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x498F640", Offset = "0x498DC40", VA = "0x18498F640")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.ODPEMBBDMBH))]
	private Task MJPFKGKOOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x498EE40", Offset = "0x498D440", VA = "0x18498EE40")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.CKJLKELOBCK))]
	private Task BIAPIGAOAMP(CancellationToken PKJDBMCJFJM, CancellationToken COLEMFADGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x498EF60", Offset = "0x498D560", VA = "0x18498EF60")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.NMHDDJKHGKE))]
	private Task DCCFLCFDBIO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x498F710", Offset = "0x498DD10", VA = "0x18498F710")]
	private TimeSpan ONEGILLCFGB()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x498F2A0", Offset = "0x498D8A0", VA = "0x18498F2A0")]
	private Task<List<TResult>> FLHABBJILLD(IReadOnlyList<TRequest> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x498ED00", Offset = "0x498D300", VA = "0x18498ED00")]
	private float AOHBFNOOOFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x498EDA0", Offset = "0x498D3A0", VA = "0x18498EDA0")]
	private void BIAPDLALAPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EHKELKJALNL<TItemId, TResult> : PCNABBENPFD<HPOHKOOPBKI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> HIACIFBDIKC(Dictionary<TItemId, int> NNFECOKKCKG, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IFHNIHPMGOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IFHNIHPMGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4C332A0", Offset = "0x4C318A0", VA = "0x184C332A0")]
		internal TResult PIICMOLPCNL(HPOHKOOPBKI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OLJGPPOCHLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<HPOHKOOPBKI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public EHKELKJALNL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IFHNIHPMGOI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5543A40", Offset = "0x5542040", VA = "0x185543A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5544780", Offset = "0x5542D80", VA = "0x185544780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HIACIFBDIKC BJCJNALNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> EFGNCEEFOAD;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x451CB90", Offset = "0x451B190", VA = "0x18451CB90")]
	public EHKELKJALNL(HIACIFBDIKC BJCJNALNHBF, [Optional] IEqualityComparer<TItemId> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x451C7A0", Offset = "0x451ADA0", VA = "0x18451C7A0", Slot = "4")]
	[AsyncStateMachine(typeof(EHKELKJALNL<, >.OLJGPPOCHLP))]
	public Task<List<TResult>> DAAOMPNEPEF(IReadOnlyList<HPOHKOOPBKI<TItemId>> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KJHCAFPDHLM<TRequest, TResult> : PCNABBENPFD<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> AFGMCEMNKFH(IEnumerable<TRequest> DOGFLLCGOCA, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CANJGFELHCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CANJGFELHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4B02080", Offset = "0x4B00680", VA = "0x184B02080")]
		internal TResult PIICMOLPCNL(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct NGODDJHIHLL : IAsyncStateMachine
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
		public KJHCAFPDHLM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CANJGFELHCG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x53ECB60", Offset = "0x53EB160", VA = "0x1853ECB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x53ED9A0", Offset = "0x53EBFA0", VA = "0x1853ED9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly AFGMCEMNKFH BJCJNALNHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> EFGNCEEFOAD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x451CB90", Offset = "0x451B190", VA = "0x18451CB90")]
	public KJHCAFPDHLM(AFGMCEMNKFH BJCJNALNHBF, [Optional] IEqualityComparer<TRequest> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x500DBF0", Offset = "0x500C1F0", VA = "0x18500DBF0", Slot = "4")]
	[AsyncStateMachine(typeof(KJHCAFPDHLM<, >.NGODDJHIHLL))]
	public Task<List<TResult>> DAAOMPNEPEF(IReadOnlyList<TRequest> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PCNABBENPFD<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> DAAOMPNEPEF(IReadOnlyList<TRequest> NNFECOKKCKG, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BDKGPJHPDOL<TItemId, TResult> : PCNABBENPFD<EHPLPEOGKBN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task HMAJOLIFHHM(IReadOnlyDictionary<TItemId, EHPLPEOGKBN<TItemId>.KJIFLMMAIJK> NNFECOKKCKG, CancellationToken CBJPDIFOEKF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LIGIKBFOPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BDKGPJHPDOL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<EHPLPEOGKBN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x514C180", Offset = "0x514A780", VA = "0x18514C180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x514C6D0", Offset = "0x514ACD0", VA = "0x18514C6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly HMAJOLIFHHM GBHNGBOCHBH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public BDKGPJHPDOL(HMAJOLIFHHM GBHNGBOCHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x614EE10", Offset = "0x614D410", VA = "0x18614EE10", Slot = "4")]
	[AsyncStateMachine(typeof(BDKGPJHPDOL<, >.LIGIKBFOPNM))]
	public Task<List<object>> DAAOMPNEPEF(IReadOnlyList<EHPLPEOGKBN<TItemId>> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x614E990", Offset = "0x614CF90", VA = "0x18614E990")]
	private IReadOnlyDictionary<TItemId, EHPLPEOGKBN<TItemId>.KJIFLMMAIJK> BPOPFHPPDKP(IReadOnlyList<EHPLPEOGKBN<TItemId>> JABDFAMEOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IMNELAJOCDM<TItemId, TResult> : PCNABBENPFD<HPOHKOOPBKI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> OEFLGHMHKNH(Dictionary<TItemId, int> NNFECOKKCKG, CancellationToken CBJPDIFOEKF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct GIGMPKFJAAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<HPOHKOOPBKI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IMNELAJOCDM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4ABE220", Offset = "0x4ABC820", VA = "0x184ABE220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4ABEEE0", Offset = "0x4ABD4E0", VA = "0x184ABEEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly OEFLGHMHKNH KEOBMNMAPFA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public IMNELAJOCDM(OEFLGHMHKNH BJCJNALNHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C45670", Offset = "0x4C43C70", VA = "0x184C45670", Slot = "4")]
	[AsyncStateMachine(typeof(IMNELAJOCDM<, >.GIGMPKFJAAG))]
	public Task<List<TResult>> DAAOMPNEPEF(IReadOnlyList<HPOHKOOPBKI<TItemId>> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JLGAJMLHNCE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, FDEEMEDLPLM> JIEJBDBAOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> DOHKLFLJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> LBFCAOCCLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> PLEFBDMKCIB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, FDEEMEDLPLM> ODEHIOCODOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> JFCNHHDBHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CLAPFKMPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E87D90", Offset = "0x4E86390", VA = "0x184E87D90")]
	public JLGAJMLHNCE(Func<IEnumerable<T>> LBFCAOCCLOP, Func<T, string> PLEFBDMKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E87AD0", Offset = "0x4E860D0", VA = "0x184E87AD0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E87A40", Offset = "0x4E86040", VA = "0x184E87A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KKGBNMJCPKC<TItemId, TResult> : FBFEDHLNICH<HPOHKOOPBKI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4B5BFB0", Offset = "0x4B5A5B0", VA = "0x184B5BFB0")]
	public KKGBNMJCPKC(PCNABBENPFD<HPOHKOOPBKI<TItemId>, TResult> PGJIOGDCGCO, TimeSpan PCAICKIEEGM, bool PNJODEKCBBL, [Optional] MOEBIEAOCEG FKMDHPHEEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5017740", Offset = "0x5015D40", VA = "0x185017740")]
	public Task<TResult> JBBPIHDMKLN(TItemId OEHHKNIGGMI, int GFNDILIHOFK, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HPOHKOOPBKI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId BEDCKOANOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BKBODBHPALJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4B79FB0", Offset = "0x4B785B0", VA = "0x184B79FB0")]
	public HPOHKOOPBKI(TItemId JPEKMHAKLEC, int GFNDILIHOFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MKNIMDIACEN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid EHBJDHPDJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> NENODKDFGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NJMKKGDLGCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface PJCHFLCAOKN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int BJLOALHHKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OBKKMNFLCHA<TParam>(TParam OHLIHBDBKCE);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DEEMNLAICIF(Exception GGOAKKKDCJN);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LLLHDDICFAO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class IFLCNIDFEFF<TResult> : PJCHFLCAOKN, MKNIMDIACEN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> LOEBJPCBENM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid EHBJDHPDJLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BJLOALHHKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> NENODKDFGBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4C33850", Offset = "0x4C31E50", VA = "0x184C33850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4C338F0", Offset = "0x4C31EF0", VA = "0x184C338F0")]
		public IFLCNIDFEFF(int DECFLFHNFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA110", Offset = "0x3DF8710", VA = "0x183DFA110", Slot = "5")]
		public bool OBKKMNFLCHA<TParam>(TParam OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4C33800", Offset = "0x4C31E00", VA = "0x184C33800", Slot = "6")]
		public bool DEEMNLAICIF(Exception GGOAKKKDCJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4C338A0", Offset = "0x4C31EA0", VA = "0x184C338A0", Slot = "7")]
		public bool LLLHDDICFAO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string JOGMKLJGKDO = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, PJCHFLCAOKN> BLFJHDKGCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly EMDJFKOPMFD CHNPEHBPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool LOHKGPNAKDG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x83E0CC0", Offset = "0x83DF2C0", VA = "0x1883E0CC0")]
	public NJMKKGDLGCI([Optional] EMDJFKOPMFD CHNPEHBPPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83E05B0", Offset = "0x83DEBB0", VA = "0x1883E05B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39B0E40", Offset = "0x39AF440", VA = "0x1839B0E40")]
	public MKNIMDIACEN<TResult> MODCJIMGOMA<TResult>(int AEMLHMAJELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x39B0AD0", Offset = "0x39AF0D0", VA = "0x1839B0AD0")]
	public bool ACEALMKGKHN<TResult>(Guid DHFBDLBBCGN, TResult OBOOAPELMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83E09A0", Offset = "0x83DEFA0", VA = "0x1883E09A0")]
	private void HNIDGKHGOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83E05B0", Offset = "0x83DEBB0", VA = "0x1883E05B0")]
	private void OLNHKPGNLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83E06C0", Offset = "0x83DECC0", VA = "0x1883E06C0")]
	private void EFJFMGEJFED(int DECFLFHNFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83E0AC0", Offset = "0x83DF0C0", VA = "0x1883E0AC0")]
	private void KIIGGPGAAFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum BGJMGNGDMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EHPLPEOGKBN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class KJIFLMMAIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int GJCJDGINPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int IGBJJCCOLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int PECIMABKJKN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KJIFLMMAIJK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId BEDCKOANOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BKBODBHPALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public BGJMGNGDMJJ CDPCPHOMCFB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E5ADB0", Offset = "0x1E593B0", VA = "0x181E5ADB0")]
	public EHPLPEOGKBN(TItemId JPEKMHAKLEC, int GFNDILIHOFK, BGJMGNGDMJJ NEKLMLONNIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MNMDCNJDIOP<TItemId, TResult> : FBFEDHLNICH<EHPLPEOGKBN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5376310", Offset = "0x5374910", VA = "0x185376310")]
	public MNMDCNJDIOP(PCNABBENPFD<EHPLPEOGKBN<TItemId>, TResult> PGJIOGDCGCO, TimeSpan PCAICKIEEGM, [Optional] MOEBIEAOCEG FKMDHPHEEPI)
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

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
	[Cpp2IlInjected.Address(RVA = "0x83FA080", Offset = "0x83F9080", VA = "0x1883FA080")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNCFGJDMGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83FA020", Offset = "0x83F9020", VA = "0x1883FA020", Slot = "4")]
	public Task IDBDDKOHBNN(int JCNHGMDIBDN, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83F9FC0", Offset = "0x83F8FC0", VA = "0x1883F9FC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x83FAB00", Offset = "0x83F9B00", VA = "0x1883FAB00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
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
		[Cpp2IlInjected.Address(RVA = "0x83FA0F0", Offset = "0x83F90F0", VA = "0x1883FA0F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ENFCNIJJGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83FA1B0", Offset = "0x83F91B0", VA = "0x1883FA1B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83FA140", Offset = "0x83F9140", VA = "0x1883FA140")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	internal static void OBMBKBPHDCG(AINJBKKEAIL NELIKBMJKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x83FA200", Offset = "0x83F9200", VA = "0x1883FA200")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAAD70", Offset = "0xAA9D70", VA = "0x180AAAD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D67770", Offset = "0x4D66770", VA = "0x184D67770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4995C70", Offset = "0x4994C70", VA = "0x184995C70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5511200", Offset = "0x5510200", VA = "0x185511200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x55115F0", Offset = "0x55105F0", VA = "0x1855115F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67E6DF0", Offset = "0x67E5DF0", VA = "0x1867E6DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67E72B0", Offset = "0x67E62B0", VA = "0x1867E72B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x53F5530", Offset = "0x53F4530", VA = "0x1853F5530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53F6750", Offset = "0x53F5750", VA = "0x1853F6750", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FACE0", Offset = "0x9F9CE0", VA = "0x1809FACE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9FACC0", Offset = "0x9F9CC0", VA = "0x1809FACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x49506E0", Offset = "0x494F6E0", VA = "0x1849506E0")]
	public FBFEDHLNICH(PCNABBENPFD<TRequest, TResult> PGJIOGDCGCO, TimeSpan PCAICKIEEGM, bool PNJODEKCBBL, [Optional] MOEBIEAOCEG FKMDHPHEEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x494FF30", Offset = "0x494EF30", VA = "0x18494FF30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4950290", Offset = "0x494F290", VA = "0x184950290")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.AMJFFJPDNBC))]
	public Task<TResult> JBBPIHDMKLN(TRequest HOOJNAMGGBC, [Optional] CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x49503C0", Offset = "0x494F3C0", VA = "0x1849503C0")]
	private void JBBPIHDMKLN(TRequest HOOJNAMGGBC, TaskCompletionSource<TResult> NDDCKHOMMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4950460", Offset = "0x494F460", VA = "0x184950460")]
	public Task JEAPMMFEINP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4950520", Offset = "0x494F520", VA = "0x184950520")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.ODPEMBBDMBH))]
	private Task MJPFKGKOOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x494FD10", Offset = "0x494ED10", VA = "0x18494FD10")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.CKJLKELOBCK))]
	private Task BIAPIGAOAMP(CancellationToken PKJDBMCJFJM, CancellationToken COLEMFADGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x494FE30", Offset = "0x494EE30", VA = "0x18494FE30")]
	[AsyncStateMachine(typeof(FBFEDHLNICH<, >.NMHDDJKHGKE))]
	private Task DCCFLCFDBIO(CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4950600", Offset = "0x494F600", VA = "0x184950600")]
	private TimeSpan ONEGILLCFGB()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4950170", Offset = "0x494F170", VA = "0x184950170")]
	private Task<List<TResult>> FLHABBJILLD(IReadOnlyList<TRequest> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x494FBD0", Offset = "0x494EBD0", VA = "0x18494FBD0")]
	private float AOHBFNOOOFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x494FC70", Offset = "0x494EC70", VA = "0x18494FC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public IFHNIHPMGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BFD520", Offset = "0x4BFC520", VA = "0x184BFD520")]
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
		[Cpp2IlInjected.Address(RVA = "0x552F060", Offset = "0x552E060", VA = "0x18552F060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x552FE30", Offset = "0x552EE30", VA = "0x18552FE30", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x44DBFA0", Offset = "0x44DAFA0", VA = "0x1844DBFA0")]
	public EHKELKJALNL(HIACIFBDIKC BJCJNALNHBF, [Optional] IEqualityComparer<TItemId> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44DBBB0", Offset = "0x44DABB0", VA = "0x1844DBBB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CANJGFELHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4AC7EA0", Offset = "0x4AC6EA0", VA = "0x184AC7EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x53BDEA0", Offset = "0x53BCEA0", VA = "0x1853BDEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x53BED80", Offset = "0x53BDD80", VA = "0x1853BED80", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x44DBFA0", Offset = "0x44DAFA0", VA = "0x1844DBFA0")]
	public KJHCAFPDHLM(AFGMCEMNKFH BJCJNALNHBF, [Optional] IEqualityComparer<TRequest> EFGNCEEFOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF090", Offset = "0x4FDE090", VA = "0x184FDF090", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x511CA00", Offset = "0x511BA00", VA = "0x18511CA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x511CF80", Offset = "0x511BF80", VA = "0x18511CF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly HMAJOLIFHHM GBHNGBOCHBH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public BDKGPJHPDOL(HMAJOLIFHHM GBHNGBOCHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61B9730", Offset = "0x61B8730", VA = "0x1861B9730", Slot = "4")]
	[AsyncStateMachine(typeof(BDKGPJHPDOL<, >.LIGIKBFOPNM))]
	public Task<List<object>> DAAOMPNEPEF(IReadOnlyList<EHPLPEOGKBN<TItemId>> NNFECOKKCKG, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61B92A0", Offset = "0x61B82A0", VA = "0x1861B92A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A82BB0", Offset = "0x4A81BB0", VA = "0x184A82BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4A838B0", Offset = "0x4A828B0", VA = "0x184A838B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly OEFLGHMHKNH KEOBMNMAPFA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public IMNELAJOCDM(OEFLGHMHKNH BJCJNALNHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4C11010", Offset = "0x4C10010", VA = "0x184C11010", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> JFCNHHDBHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CLAPFKMPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC64F60", Offset = "0xC63F60", VA = "0x180C64F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FDB0", Offset = "0x4E3EDB0", VA = "0x184E3FDB0")]
	public JLGAJMLHNCE(Func<IEnumerable<T>> LBFCAOCCLOP, Func<T, string> PLEFBDMKCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FAF0", Offset = "0x4E3EAF0", VA = "0x184E3FAF0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FA60", Offset = "0x4E3EA60", VA = "0x184E3FA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KKGBNMJCPKC<TItemId, TResult> : FBFEDHLNICH<HPOHKOOPBKI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4B02C80", Offset = "0x4B01C80", VA = "0x184B02C80")]
	public KKGBNMJCPKC(PCNABBENPFD<HPOHKOOPBKI<TItemId>, TResult> PGJIOGDCGCO, TimeSpan PCAICKIEEGM, bool PNJODEKCBBL, [Optional] MOEBIEAOCEG FKMDHPHEEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4FE6810", Offset = "0x4FE5810", VA = "0x184FE6810")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B23310", Offset = "0x4B22310", VA = "0x184B23310")]
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
			[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BFE050", Offset = "0x4BFD050", VA = "0x184BFE050", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE110", Offset = "0x4BFD110", VA = "0x184BFE110")]
		public IFLCNIDFEFF(int DECFLFHNFAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC870", Offset = "0x3CBB870", VA = "0x183CBC870", Slot = "5")]
		public bool OBKKMNFLCHA<TParam>(TParam OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4BFDFF0", Offset = "0x4BFCFF0", VA = "0x184BFDFF0", Slot = "6")]
		public bool DEEMNLAICIF(Exception GGOAKKKDCJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE0B0", Offset = "0x4BFD0B0", VA = "0x184BFE0B0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x83FAA00", Offset = "0x83F9A00", VA = "0x1883FAA00")]
	public NJMKKGDLGCI([Optional] EMDJFKOPMFD CHNPEHBPPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x83FA2F0", Offset = "0x83F92F0", VA = "0x1883FA2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39948A0", Offset = "0x39938A0", VA = "0x1839948A0")]
	public MKNIMDIACEN<TResult> MODCJIMGOMA<TResult>(int AEMLHMAJELK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3994530", Offset = "0x3993530", VA = "0x183994530")]
	public bool ACEALMKGKHN<TResult>(Guid DHFBDLBBCGN, TResult OBOOAPELMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x83FA6E0", Offset = "0x83F96E0", VA = "0x1883FA6E0")]
	private void HNIDGKHGOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x83FA2F0", Offset = "0x83F92F0", VA = "0x1883FA2F0")]
	private void OLNHKPGNLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83FA400", Offset = "0x83F9400", VA = "0x1883FA400")]
	private void EFJFMGEJFED(int DECFLFHNFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83FA800", Offset = "0x83F9800", VA = "0x1883FA800")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x1E44B60", Offset = "0x1E43B60", VA = "0x181E44B60")]
	public EHPLPEOGKBN(TItemId JPEKMHAKLEC, int GFNDILIHOFK, BGJMGNGDMJJ NEKLMLONNIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MNMDCNJDIOP<TItemId, TResult> : FBFEDHLNICH<EHPLPEOGKBN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5352F70", Offset = "0x5351F70", VA = "0x185352F70")]
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

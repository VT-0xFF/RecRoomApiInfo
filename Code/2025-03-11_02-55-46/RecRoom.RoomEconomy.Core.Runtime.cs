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
public interface LMMKJEHGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EFIOJDLHGKH(int POBDFFAOEKC, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EFIOJDLHGKH(TimeSpan DLANBOCFMOF, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class OFIIKDJBJIN : LMMKJEHGNKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B630", Offset = "0x7D4AA30", VA = "0x187D4B630")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	internal static void OOLIJHLPGJB(LEPFMCICNAK EOMAFKDOFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFIIKDJBJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B570", Offset = "0x7D4A970", VA = "0x187D4B570", Slot = "4")]
	public Task EFIOJDLHGKH(int POBDFFAOEKC, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B5D0", Offset = "0x7D4A9D0", VA = "0x187D4B5D0", Slot = "5")]
	public Task EFIOJDLHGKH(TimeSpan DLANBOCFMOF, CancellationToken MLAPMBKLAOF)
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
		[Cpp2IlInjected.Address(RVA = "0x7D4B720", Offset = "0x7D4AB20", VA = "0x187D4B720", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AABDLLMIFFN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct BDOEMHNAHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest FCJMDEBFNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> IBGJKBMKFNN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
		public BDOEMHNAHKP(TRequest NKKKCKHLGCJ, TaskCompletionSource<TResult> MCKEDAHELGN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct MBCHDIHNODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AABDLLMIFFN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4DF5860", Offset = "0x4DF4C60", VA = "0x184DF5860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x40E6880", Offset = "0x40E5C80", VA = "0x1840E6880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OIDHIEANACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AABDLLMIFFN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4FA76A0", Offset = "0x4FA6AA0", VA = "0x184FA76A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7A80", Offset = "0x4FA6E80", VA = "0x184FA7A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PEHIOKDENHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AABDLLMIFFN<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x508F1B0", Offset = "0x508E5B0", VA = "0x18508F1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x508F670", Offset = "0x508EA70", VA = "0x18508F670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct KMBCCIAKKMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AABDLLMIFFN<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4B3DA20", Offset = "0x4B3CE20", VA = "0x184B3DA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B3EBB0", Offset = "0x4B3DFB0", VA = "0x184B3EBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MDELAJCKJFG<TRequest, TResult> MJPDBFOPMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float LDNKFIFODIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LMMKJEHGNKJ IJCOMBPFOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool JHHNOGFEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<BDOEMHNAHKP> MAGMINNCIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<BDOEMHNAHKP> PCIFDGLBNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool MOPEHLBOIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource EIHCFFGCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource LPPBPFPMFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task JJNIGKKDJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float NFJBANCPDGA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DAOBNBLDNKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96E0A0", Offset = "0x96D4A0", VA = "0x18096E0A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96E1A0", Offset = "0x96D5A0", VA = "0x18096E1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4604590", Offset = "0x4603990", VA = "0x184604590")]
	public AABDLLMIFFN(MDELAJCKJFG<TRequest, TResult> MJPDBFOPMNI, TimeSpan LDNKFIFODIE, bool JHHNOGFEHOJ, [Optional] LMMKJEHGNKJ IJCOMBPFOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4603DA0", Offset = "0x46031A0", VA = "0x184603DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4604290", Offset = "0x4603690", VA = "0x184604290")]
	[AsyncStateMachine(typeof(AABDLLMIFFN<, >.MBCHDIHNODI))]
	public Task<TResult> JJCBNAONCFF(TRequest NKKKCKHLGCJ, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46043B0", Offset = "0x46037B0", VA = "0x1846043B0")]
	private void JJCBNAONCFF(TRequest NKKKCKHLGCJ, TaskCompletionSource<TResult> MCKEDAHELGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4603FE0", Offset = "0x46033E0", VA = "0x184603FE0")]
	public Task HJAMBMNFEKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46040A0", Offset = "0x46034A0", VA = "0x1846040A0")]
	[AsyncStateMachine(typeof(AABDLLMIFFN<, >.OIDHIEANACI))]
	private Task ININHMCKAIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4604170", Offset = "0x4603570", VA = "0x184604170")]
	[AsyncStateMachine(typeof(AABDLLMIFFN<, >.PEHIOKDENHK))]
	private Task IOJFHFCIAOH(CancellationToken JIDLKFFDCAN, CancellationToken ENDLAOIMPBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4603BC0", Offset = "0x4602FC0", VA = "0x184603BC0")]
	[AsyncStateMachine(typeof(AABDLLMIFFN<, >.KMBCCIAKKMD))]
	private Task CBGCCLEKDKI(CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4603CC0", Offset = "0x46030C0", VA = "0x184603CC0")]
	private TimeSpan DOJKBOLJFDG()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4603AA0", Offset = "0x4602EA0", VA = "0x184603AA0")]
	private Task<List<TResult>> BEHALDOJPEA(IReadOnlyList<TRequest> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x46044F0", Offset = "0x46038F0", VA = "0x1846044F0")]
	private float ONJPDFFLLCN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4604450", Offset = "0x4603850", VA = "0x184604450")]
	private void KBBDPLCLCIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JDMGCIJHGJL<TItemId, TResult> : MDELAJCKJFG<POOOKPNEGGN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> GMCNLKEJNPC(Dictionary<TItemId, int> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ICJJOKAFFOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ICJJOKAFFOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4802C70", Offset = "0x4802070", VA = "0x184802C70")]
		internal TResult KBNDNOJGIBM(POOOKPNEGGN<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ELJHOGACDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<POOOKPNEGGN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JDMGCIJHGJL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ICJJOKAFFOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x412C9F0", Offset = "0x412BDF0", VA = "0x18412C9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x412D730", Offset = "0x412CB30", VA = "0x18412D730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GMCNLKEJNPC LIBENIAMDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> HMLMHCLAIJJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x463C590", Offset = "0x463B990", VA = "0x18463C590")]
	public JDMGCIJHGJL(GMCNLKEJNPC LIBENIAMDEF, [Optional] IEqualityComparer<TItemId> HMLMHCLAIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4A09F10", Offset = "0x4A09310", VA = "0x184A09F10", Slot = "4")]
	[AsyncStateMachine(typeof(JDMGCIJHGJL<, >.ELJHOGACDJF))]
	public Task<List<TResult>> PHLEGJOLBEA(IReadOnlyList<POOOKPNEGGN<TItemId>> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AFOFJFAKODJ<TRequest, TResult> : MDELAJCKJFG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> JCGDMDHMNGC(IEnumerable<TRequest> CCJILNDGCIJ, CancellationToken MLAPMBKLAOF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class JPCAOACHBPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public JPCAOACHBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40E6BD0", Offset = "0x40E5FD0", VA = "0x1840E6BD0")]
		internal TResult KBNDNOJGIBM(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FBLBOMJEELC : IAsyncStateMachine
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
		public AFOFJFAKODJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private JPCAOACHBPE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x44E8E10", Offset = "0x44E8210", VA = "0x1844E8E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x44E9C50", Offset = "0x44E9050", VA = "0x1844E9C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JCGDMDHMNGC LIBENIAMDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> HMLMHCLAIJJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x463C590", Offset = "0x463B990", VA = "0x18463C590")]
	public AFOFJFAKODJ(JCGDMDHMNGC LIBENIAMDEF, [Optional] IEqualityComparer<TRequest> HMLMHCLAIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x463C450", Offset = "0x463B850", VA = "0x18463C450", Slot = "4")]
	[AsyncStateMachine(typeof(AFOFJFAKODJ<, >.FBLBOMJEELC))]
	public Task<List<TResult>> PHLEGJOLBEA(IReadOnlyList<TRequest> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MDELAJCKJFG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PHLEGJOLBEA(IReadOnlyList<TRequest> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GDMIAPCOBIH<TItemId, TResult> : MDELAJCKJFG<AFILBOCCAGO<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task DGLAEDGFOCE(IReadOnlyDictionary<TItemId, AFILBOCCAGO<TItemId>.HBNJHLKMHFO> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PACANGLBFLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GDMIAPCOBIH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<AFILBOCCAGO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5073E60", Offset = "0x5073260", VA = "0x185073E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50743B0", Offset = "0x50737B0", VA = "0x1850743B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly DGLAEDGFOCE GOMMNPGKODO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public GDMIAPCOBIH(DGLAEDGFOCE GOMMNPGKODO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4655270", Offset = "0x4654670", VA = "0x184655270", Slot = "4")]
	[AsyncStateMachine(typeof(GDMIAPCOBIH<, >.PACANGLBFLO))]
	public Task<List<object>> PHLEGJOLBEA(IReadOnlyList<AFILBOCCAGO<TItemId>> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4654DF0", Offset = "0x46541F0", VA = "0x184654DF0")]
	private IReadOnlyDictionary<TItemId, AFILBOCCAGO<TItemId>.HBNJHLKMHFO> HAKAFNCDKOB(IReadOnlyList<AFILBOCCAGO<TItemId>> JKCLNGHODNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HLDJJPGAILD<TItemId, TResult> : MDELAJCKJFG<POOOKPNEGGN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> FBJBFKOLJMF(Dictionary<TItemId, int> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct ICJAIGOKJNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<POOOKPNEGGN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public HLDJJPGAILD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4801250", Offset = "0x4800650", VA = "0x184801250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4802BD0", Offset = "0x4801FD0", VA = "0x184802BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly FBJBFKOLJMF NEBCEKGPLKN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public HLDJJPGAILD(FBJBFKOLJMF LIBENIAMDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4752040", Offset = "0x4751440", VA = "0x184752040", Slot = "4")]
	[AsyncStateMachine(typeof(HLDJJPGAILD<, >.ICJAIGOKJNE))]
	public Task<List<TResult>> PHLEGJOLBEA(IReadOnlyList<POOOKPNEGGN<TItemId>> GJIJACBJMBJ, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BNFBGDAGCJP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, BFNODLBAELJ> CPDEMLLDOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> PPGIMLKEIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> KAPAJPNHHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> ABAJMMEGMDP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, BFNODLBAELJ> PNCLDDBMHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KPKGLHBNOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EAIJOIGEJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB8DA00", Offset = "0xB8CE00", VA = "0x180B8DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D81F80", Offset = "0x5D81380", VA = "0x185D81F80")]
	public BNFBGDAGCJP(Func<IEnumerable<T>> KAPAJPNHHID, Func<T, string> ABAJMMEGMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D81CC0", Offset = "0x5D810C0", VA = "0x185D81CC0")]
	public void PCKKFECIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D81C30", Offset = "0x5D81030", VA = "0x185D81C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HGGMAGHADOP<TItemId, TResult> : AABDLLMIFFN<POOOKPNEGGN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47489E0", Offset = "0x4747DE0", VA = "0x1847489E0")]
	public HGGMAGHADOP(MDELAJCKJFG<POOOKPNEGGN<TItemId>, TResult> MJPDBFOPMNI, TimeSpan LDNKFIFODIE, bool JHHNOGFEHOJ, [Optional] LMMKJEHGNKJ IJCOMBPFOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4748850", Offset = "0x4747C50", VA = "0x184748850")]
	public Task<TResult> JJCBNAONCFF(TItemId MCNLCGLNHHO, int PNOHIDJABCO, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class POOOKPNEGGN<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId EJGEHGCBMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int GBDNHPJMLKL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50D9210", Offset = "0x50D8610", VA = "0x1850D9210")]
	public POOOKPNEGGN(TItemId KIBDOOPIGIB, int PNOHIDJABCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FNNCBHMAEGJ<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid IMMGPMKFLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> MFCJJENJALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BEANFDIMLFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface ODCLGJAACFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int PCEHIFFKIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NNPPGKHGJPD<TParam>(TParam PEBNJNGMMHE);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KPLNCMDLNIE(Exception HOGBKOGNANI);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IBFBFMAJNAP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class DEDIECNDPCD<TResult> : ODCLGJAACFI, FNNCBHMAEGJ<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> BIBGJEOCDEP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid IMMGPMKFLNF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PCEHIFFKIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAE5990", Offset = "0xAE4D90", VA = "0x180AE5990", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> MFCJJENJALG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E614B0", Offset = "0x4E608B0", VA = "0x184E614B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63E9C70", Offset = "0x63E9070", VA = "0x1863E9C70")]
		public DEDIECNDPCD(int APDBCJBAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x36D21B0", Offset = "0x36D15B0", VA = "0x1836D21B0", Slot = "5")]
		public bool NNPPGKHGJPD<TParam>(TParam PEBNJNGMMHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63E9C20", Offset = "0x63E9020", VA = "0x1863E9C20", Slot = "6")]
		public bool KPLNCMDLNIE(Exception HOGBKOGNANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63E9BD0", Offset = "0x63E8FD0", VA = "0x1863E9BD0", Slot = "7")]
		public bool IBFBFMAJNAP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string ADNJPMMCADJ = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, ODCLGJAACFI> AABDLJONIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KLIMFEJPPEP ELHEOEECLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool NFDOHABAOPI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B470", Offset = "0x7D4A870", VA = "0x187D4B470")]
	public BEANFDIMLFA([Optional] KLIMFEJPPEP ELHEOEECLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AD50", Offset = "0x7D4A150", VA = "0x187D4AD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31FD2C0", Offset = "0x31FC6C0", VA = "0x1831FD2C0")]
	public FNNCBHMAEGJ<TResult> IOFMHJJLFIN<TResult>(int CFGGALJIIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31FD5E0", Offset = "0x31FC9E0", VA = "0x1831FD5E0")]
	public bool PMNDFDMGDGF<TResult>(Guid PPLJPJJDEGE, TResult HOCIBOCHCFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B060", Offset = "0x7D4A460", VA = "0x187D4B060")]
	private void HMOOHCNKLDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AD50", Offset = "0x7D4A150", VA = "0x187D4AD50")]
	private void HNGADAMJMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B180", Offset = "0x7D4A580", VA = "0x187D4B180")]
	private void MCAEODNPDIG(int APDBCJBAAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AE60", Offset = "0x7D4A260", VA = "0x187D4AE60")]
	private void GICJPGHEMKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum OPKBENPJLOL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AFILBOCCAGO<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HBNJHLKMHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int JPDAPEECNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int JEBKKGNIJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int JAJLOGPFAEF;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HBNJHLKMHFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId EJGEHGCBMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int GBDNHPJMLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OPKBENPJLOL CHEOEBIHKAA;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C8DA00", Offset = "0x1C8CE00", VA = "0x181C8DA00")]
	public AFILBOCCAGO(TItemId KIBDOOPIGIB, int PNOHIDJABCO, OPKBENPJLOL IPKJFPCBFNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IFKGDINIODE<TItemId, TResult> : AABDLLMIFFN<AFILBOCCAGO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x480D330", Offset = "0x480C730", VA = "0x18480D330")]
	public IFKGDINIODE(MDELAJCKJFG<AFILBOCCAGO<TItemId>, TResult> MJPDBFOPMNI, TimeSpan LDNKFIFODIE, [Optional] LMMKJEHGNKJ IJCOMBPFOCJ)
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

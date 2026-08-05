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
public interface CDOCCMMOJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AGPEAJJAGBG(int LPPGHLCBJPB, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AGPEAJJAGBG(TimeSpan JDINLIMJMCA, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DOGDGKBOIMO : CDOCCMMOJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8458060", Offset = "0x8457260", VA = "0x188458060")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	internal static void LNFJKPHMEBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DOGDGKBOIMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8457FA0", Offset = "0x84571A0", VA = "0x188457FA0", Slot = "4")]
	public Task AGPEAJJAGBG(int LPPGHLCBJPB, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8458000", Offset = "0x8457200", VA = "0x188458000", Slot = "5")]
	public Task AGPEAJJAGBG(TimeSpan JDINLIMJMCA, CancellationToken HCELDNOKOAM)
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
		[Cpp2IlInjected.Address(RVA = "0x8458AE0", Offset = "0x8457CE0", VA = "0x188458AE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IFPHIFMFFCE : KPGBMPAOOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LJAINOGOHLC MEGIMJDPAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JMLCOCFOGNG<bool> PKCFOGMJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JMLCOCFOGNG<bool> MOENCDCHCMP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NJLLJDEKPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8458190", Offset = "0x8457390", VA = "0x188458190", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CGMKGAFIHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84580D0", Offset = "0x84572D0", VA = "0x1884580D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8458120", Offset = "0x8457320", VA = "0x188458120")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	internal static void LNFJKPHMEBL(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x84581E0", Offset = "0x84573E0", VA = "0x1884581E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IFPHIFMFFCE([ALHAHLCGLLK(null)][NotNull] LJAINOGOHLC MEGIMJDPAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHEKKHLIGKP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct JIJKOBONOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest JICLHBDIDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> KLNIDMEBNJA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
		public JIJKOBONOJK(TRequest MGALKMHOLCM, TaskCompletionSource<TResult> LFLCFNCNIIA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PCAONNMGEFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public HHEKKHLIGKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x56043C0", Offset = "0x56035C0", VA = "0x1856043C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4539580", Offset = "0x4538780", VA = "0x184539580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GLCHDEILKNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public HHEKKHLIGKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4A6FE70", Offset = "0x4A6F070", VA = "0x184A6FE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4A70250", Offset = "0x4A6F450", VA = "0x184A70250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KHJMEBCJLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HHEKKHLIGKP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5011C40", Offset = "0x5010E40", VA = "0x185011C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50120F0", Offset = "0x50112F0", VA = "0x1850120F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ENFMOCCMMLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public HHEKKHLIGKP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4541F70", Offset = "0x4541170", VA = "0x184541F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4543100", Offset = "0x4542300", VA = "0x184543100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LNDMLEEIJLL<TRequest, TResult> ADKGNGAGOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float KMHGOPHDCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CDOCCMMOJMJ BPANKJBCGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool FIMHLGFPHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<JIJKOBONOJK> KIIIEONLIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<JIJKOBONOJK> IEOKCBCCFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MANPFGFGPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource DHBIDKPEFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource FPGKHABIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task JKLIPFLLAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float JCGKJHHMEJF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BE0", Offset = "0x9F5DE0", VA = "0x1809F6BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F6CA0", Offset = "0x9F5EA0", VA = "0x1809F6CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B86020", Offset = "0x4B85220", VA = "0x184B86020")]
	public HHEKKHLIGKP(LNDMLEEIJLL<TRequest, TResult> ADKGNGAGOLB, TimeSpan KMHGOPHDCCP, bool FIMHLGFPHBO, [Optional] CDOCCMMOJMJ BPANKJBCGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B856C0", Offset = "0x4B848C0", VA = "0x184B856C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B85900", Offset = "0x4B84B00", VA = "0x184B85900")]
	[AsyncStateMachine(typeof(HHEKKHLIGKP<, >.PCAONNMGEFP))]
	public Task<TResult> EOIICEPODAK(TRequest MGALKMHOLCM, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B85A20", Offset = "0x4B84C20", VA = "0x184B85A20")]
	private void EOIICEPODAK(TRequest MGALKMHOLCM, TaskCompletionSource<TResult> LFLCFNCNIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B85600", Offset = "0x4B84800", VA = "0x184B85600")]
	public Task DIOFJBJEHMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B85530", Offset = "0x4B84730", VA = "0x184B85530")]
	[AsyncStateMachine(typeof(HHEKKHLIGKP<, >.GLCHDEILKNP))]
	private Task AJDELJBNECG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B85F00", Offset = "0x4B85100", VA = "0x184B85F00")]
	[AsyncStateMachine(typeof(HHEKKHLIGKP<, >.KHJMEBCJLEJ))]
	private Task MFAJCNHAEOL(CancellationToken PJAKLDIBKKP, CancellationToken MEIAIKLMOEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4B85BE0", Offset = "0x4B84DE0", VA = "0x184B85BE0")]
	[AsyncStateMachine(typeof(HHEKKHLIGKP<, >.ENFMOCCMMLI))]
	private Task HDONLNJNAGE(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B85CE0", Offset = "0x4B84EE0", VA = "0x184B85CE0")]
	private TimeSpan HGAKEAKLDFI()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B85AC0", Offset = "0x4B84CC0", VA = "0x184B85AC0")]
	private Task<List<TResult>> GFMEFEEJDFF(IReadOnlyList<TRequest> AMEPKMJHNEA, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4B85E60", Offset = "0x4B85060", VA = "0x184B85E60")]
	private float LLBAGEFNBCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B85DC0", Offset = "0x4B84FC0", VA = "0x184B85DC0")]
	private void LIEOGCHENEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IDKJNDCKADA<TItemId, TResult> : LNDMLEEIJLL<OPFNBMPDFJP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> MLNALOOLIEG(Dictionary<TItemId, int> AMEPKMJHNEA, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IGDAJLKGBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public IGDAJLKGBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4C7DB40", Offset = "0x4C7CD40", VA = "0x184C7DB40")]
		internal TResult LIGPBODIDFN(OPFNBMPDFJP<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HDEICELGOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<OPFNBMPDFJP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public IDKJNDCKADA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IGDAJLKGBLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B11290", Offset = "0x4B10490", VA = "0x184B11290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4B11FD0", Offset = "0x4B111D0", VA = "0x184B11FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MLNALOOLIEG JLOECHHDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> LEABKHICHOK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C716F0", Offset = "0x4C708F0", VA = "0x184C716F0")]
	public IDKJNDCKADA(MLNALOOLIEG JLOECHHDMNI, [Optional] IEqualityComparer<TItemId> LEABKHICHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C711B0", Offset = "0x4C703B0", VA = "0x184C711B0", Slot = "4")]
	[AsyncStateMachine(typeof(IDKJNDCKADA<, >.HDEICELGOCF))]
	public Task<List<TResult>> PHACDGBKCHK(IReadOnlyList<OPFNBMPDFJP<TItemId>> AMEPKMJHNEA, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CMHMFBAAMLO<TRequest, TResult> : LNDMLEEIJLL<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> FFIBHAMNJGA(IEnumerable<TRequest> GOFHHJFDBCC, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EAACGHHBEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public EAACGHHBEKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x451FB30", Offset = "0x451ED30", VA = "0x18451FB30")]
		internal TResult LIGPBODIDFN(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FFPCOEHKOMA : IAsyncStateMachine
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
		public CMHMFBAAMLO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EAACGHHBEKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x499BD20", Offset = "0x499AF20", VA = "0x18499BD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x499CB60", Offset = "0x499BD60", VA = "0x18499CB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly FFIBHAMNJGA JLOECHHDMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> LEABKHICHOK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C716F0", Offset = "0x4C708F0", VA = "0x184C716F0")]
	public CMHMFBAAMLO(FFIBHAMNJGA JLOECHHDMNI, [Optional] IEqualityComparer<TRequest> LEABKHICHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66306F0", Offset = "0x662F8F0", VA = "0x1866306F0", Slot = "4")]
	[AsyncStateMachine(typeof(CMHMFBAAMLO<, >.FFPCOEHKOMA))]
	public Task<List<TResult>> PHACDGBKCHK(IReadOnlyList<TRequest> AMEPKMJHNEA, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LNDMLEEIJLL<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PHACDGBKCHK(IReadOnlyList<TRequest> AMEPKMJHNEA, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ODMKACKBBJM<TItemId, TResult> : LNDMLEEIJLL<APNFIMEJLGO<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task FFFEGKIMDCJ(IReadOnlyDictionary<TItemId, APNFIMEJLGO<TItemId>.FCAKAKHIAFO> AMEPKMJHNEA, CancellationToken HCELDNOKOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct NGLBMPHBENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ODMKACKBBJM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<APNFIMEJLGO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x538CEA0", Offset = "0x538C0A0", VA = "0x18538CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x538D3F0", Offset = "0x538C5F0", VA = "0x18538D3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FFFEGKIMDCJ AGEOJHLGPBB;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public ODMKACKBBJM(FFFEGKIMDCJ AGEOJHLGPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x54C3390", Offset = "0x54C2590", VA = "0x1854C3390", Slot = "4")]
	[AsyncStateMachine(typeof(ODMKACKBBJM<, >.NGLBMPHBENH))]
	public Task<List<object>> PHACDGBKCHK(IReadOnlyList<APNFIMEJLGO<TItemId>> AMEPKMJHNEA, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x54C2F10", Offset = "0x54C2110", VA = "0x1854C2F10")]
	private IReadOnlyDictionary<TItemId, APNFIMEJLGO<TItemId>.FCAKAKHIAFO> NJBLDDHIJCO(IReadOnlyList<APNFIMEJLGO<TItemId>> MALFIAHGDIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EKBGHPBHOFB<TItemId, TResult> : LNDMLEEIJLL<OPFNBMPDFJP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> LLBCEFPOHEP(Dictionary<TItemId, int> AMEPKMJHNEA, CancellationToken HCELDNOKOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct NICCMNKNGFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<OPFNBMPDFJP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EKBGHPBHOFB<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5395350", Offset = "0x5394550", VA = "0x185395350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5396CD0", Offset = "0x5395ED0", VA = "0x185396CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LLBCEFPOHEP MMNBJJJIDIP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public EKBGHPBHOFB(LLBCEFPOHEP JLOECHHDMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4538F50", Offset = "0x4538150", VA = "0x184538F50", Slot = "4")]
	[AsyncStateMachine(typeof(EKBGHPBHOFB<, >.NICCMNKNGFN))]
	public Task<List<TResult>> PHACDGBKCHK(IReadOnlyList<OPFNBMPDFJP<TItemId>> AMEPKMJHNEA, CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ALGIJJEFIIB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, IENBLMBPDPG> MDKLMPHAOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> KBPBCAGFCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> DFMPDONBNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> HIICIHNICKP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, IENBLMBPDPG> LAMGHMPHIKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> AJHDANIONGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LFONMMOJKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AFC0", Offset = "0x4C8A1C0", VA = "0x184C8AFC0")]
	public ALGIJJEFIIB(Func<IEnumerable<T>> DFMPDONBNME, Func<T, string> HIICIHNICKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AD00", Offset = "0x4C89F00", VA = "0x184C8AD00")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4C8AC70", Offset = "0x4C89E70", VA = "0x184C8AC70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBEFFMFJOPA<TItemId, TResult> : HHEKKHLIGKP<OPFNBMPDFJP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9D60", Offset = "0x4AA8F60", VA = "0x184AA9D60")]
	public OBEFFMFJOPA(LNDMLEEIJLL<OPFNBMPDFJP<TItemId>, TResult> ADKGNGAGOLB, TimeSpan KMHGOPHDCCP, bool FIMHLGFPHBO, [Optional] CDOCCMMOJMJ BPANKJBCGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x54BDF20", Offset = "0x54BD120", VA = "0x1854BDF20")]
	public Task<TResult> EOIICEPODAK(TItemId AGBHGDFILGO, int BJDKEGOHCNL, [Optional] CancellationToken HCELDNOKOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OPFNBMPDFJP<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId LEIAKCBPPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int KBFCEOJMLKG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5549650", Offset = "0x5548850", VA = "0x185549650")]
	public OPFNBMPDFJP(TItemId PJEBGIFFKDF, int BJDKEGOHCNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NDLNLPNPPFP<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid MKPBDMFKODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> JCBPEABCHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PLAPKGFNKEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface LEKOKDFJBBC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int NOEBNEAFIJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NPOHBJGOICO<TParam>(TParam MLCDCHNOCFI);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OOPFMCCMLCD(Exception NHADLBPGDMN);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool OPODNDCAPCA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class KKCEEPFMPGL<TResult> : LEKOKDFJBBC, NDLNLPNPPFP<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> JDJHNJLLIGB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid MKPBDMFKODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NOEBNEAFIJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> JCBPEABCHPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5019100", Offset = "0x5018300", VA = "0x185019100", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x50191F0", Offset = "0x50183F0", VA = "0x1850191F0")]
		public KKCEEPFMPGL(int CCEMMBMOJPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3F71590", Offset = "0x3F70790", VA = "0x183F71590", Slot = "5")]
		public bool NPOHBJGOICO<TParam>(TParam MLCDCHNOCFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5019150", Offset = "0x5018350", VA = "0x185019150", Slot = "6")]
		public bool OOPFMCCMLCD(Exception NHADLBPGDMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50191A0", Offset = "0x50183A0", VA = "0x1850191A0", Slot = "7")]
		public bool OPODNDCAPCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string JPHGHJJHOOG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, LEKOKDFJBBC> HBDPHJIEHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BBHHAOJACAD KKKFDANPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool BPJDGEDAPOO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84589E0", Offset = "0x8457BE0", VA = "0x1884589E0")]
	public PLAPKGFNKEF([Optional] BBHHAOJACAD KKKFDANPFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84585F0", Offset = "0x84577F0", VA = "0x1884585F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3A189D0", Offset = "0x3A17BD0", VA = "0x183A189D0")]
	public NDLNLPNPPFP<TResult> GOPJDLMCGFO<TResult>(int FCOOONPKMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3A18CF0", Offset = "0x3A17EF0", VA = "0x183A18CF0")]
	public bool LLEHEGKPEGO<TResult>(Guid BOAAABDJCPH, TResult IGGKBIDIAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84582D0", Offset = "0x84574D0", VA = "0x1884582D0")]
	private void AILOMBLMDMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x84585F0", Offset = "0x84577F0", VA = "0x1884585F0")]
	private void CCCGFPMAMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8458700", Offset = "0x8457900", VA = "0x188458700")]
	private void MAILNLCFGKN(int CCEMMBMOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84583F0", Offset = "0x84575F0", VA = "0x1884583F0")]
	private void BAOEDHLLJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MJNFIHFELPI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class APNFIMEJLGO<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class FCAKAKHIAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int KLJINLGDDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int CCFFBCCKJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int MNAKIBONIMK;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FCAKAKHIAFO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId LEIAKCBPPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int KBFCEOJMLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public MJNFIHFELPI IEECADKBPAC;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E7B350", Offset = "0x1E7A550", VA = "0x181E7B350")]
	public APNFIMEJLGO(TItemId PJEBGIFFKDF, int BJDKEGOHCNL, MJNFIHFELPI LJMBANNFBIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KIHCKGNCPNC<TItemId, TResult> : HHEKKHLIGKP<APNFIMEJLGO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5015EF0", Offset = "0x50150F0", VA = "0x185015EF0")]
	public KIHCKGNCPNC(LNDMLEEIJLL<APNFIMEJLGO<TItemId>, TResult> ADKGNGAGOLB, TimeSpan KMHGOPHDCCP, [Optional] CDOCCMMOJMJ BPANKJBCGBK)
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

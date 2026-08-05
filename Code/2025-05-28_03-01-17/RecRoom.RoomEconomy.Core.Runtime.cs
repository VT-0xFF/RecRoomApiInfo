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
public interface AHHEJMOLFFP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AAPBEONKBIP(int LLOCNCJMJLB, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AAPBEONKBIP(TimeSpan JCIBHFEHKMA, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FGPDMADOBAL : AHHEJMOLFFP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x858CAB0", Offset = "0x858B8B0", VA = "0x18858CAB0")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FGPDMADOBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x858C9F0", Offset = "0x858B7F0", VA = "0x18858C9F0", Slot = "4")]
	public Task AAPBEONKBIP(int LLOCNCJMJLB, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x858CA50", Offset = "0x858B850", VA = "0x18858CA50", Slot = "5")]
	public Task AAPBEONKBIP(TimeSpan JCIBHFEHKMA, CancellationToken GHKBKDKNIOM)
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
		[Cpp2IlInjected.Address(RVA = "0x858D540", Offset = "0x858C340", VA = "0x18858D540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LJGNKCCBOGA : PPICFCDBONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PMEABDCOHMP BJBKIMGHCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CNECDEBEMPE<bool> MGJKLJJNODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CNECDEBEMPE<bool> JABBAENHOKB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LOICHNPALCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x858CB90", Offset = "0x858B990", VA = "0x18858CB90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LOGGKGAPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x858CBE0", Offset = "0x858B9E0", VA = "0x18858CBE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x858CB20", Offset = "0x858B920", VA = "0x18858CB20")]
	[ENKLKENGHAE.AANPNKKBMFF.ENPJKGAFAPD]
	internal static void BAEPNPABNEB(NAELDDAANND AHGNCOFKLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x858CC30", Offset = "0x858BA30", VA = "0x18858CC30")]
	[RecRoom.NoEngine.Common.Preserve]
	public LJGNKCCBOGA([LCNEJNNIOGA(null)][NotNull] PMEABDCOHMP BJBKIMGHCEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OBNDLCCPOIH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct BPOAGHHCIPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest GLABPHHLEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> AKOBDLGKHNC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		public BPOAGHHCIPF(TRequest OHDJLNAKLPC, TaskCompletionSource<TResult> BOKOJFIAMEK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NDHMGFFAHGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OBNDLCCPOIH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x547B360", Offset = "0x547A160", VA = "0x18547B360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4610AC0", Offset = "0x460F8C0", VA = "0x184610AC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PHLOOAABGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OBNDLCCPOIH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x57785D0", Offset = "0x57773D0", VA = "0x1857785D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57789B0", Offset = "0x57777B0", VA = "0x1857789B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OCAPHKLLDJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OBNDLCCPOIH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x55FB940", Offset = "0x55FA740", VA = "0x1855FB940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x55FBDF0", Offset = "0x55FABF0", VA = "0x1855FBDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OOFNHJJMFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OBNDLCCPOIH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5681F70", Offset = "0x5680D70", VA = "0x185681F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5683120", Offset = "0x5681F20", VA = "0x185683120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KLFPIFLLAGK<TRequest, TResult> CDNPODPCION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float HCJCHDDOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AHHEJMOLFFP IGKNFEPILID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool LKBEFHNIEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<BPOAGHHCIPF> PJBFCACMDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<BPOAGHHCIPF> JHECMLMOFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool FEELFJFMKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource AFBAFKKKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource FBDMCFBNKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task FCPALNIFNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float NEAEHNPPOBM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECE0", Offset = "0xA0DAE0", VA = "0x180A0ECE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBD0", Offset = "0xA0D9D0", VA = "0x180A0EBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x55FB480", Offset = "0x55FA280", VA = "0x1855FB480")]
	public OBNDLCCPOIH(KLFPIFLLAGK<TRequest, TResult> CDNPODPCION, TimeSpan HCJCHDDOICK, bool LKBEFHNIEIO, [Optional] AHHEJMOLFFP IGKNFEPILID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x55FAA30", Offset = "0x55F9830", VA = "0x1855FAA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x55FADD0", Offset = "0x55F9BD0", VA = "0x1855FADD0")]
	[AsyncStateMachine(typeof(OBNDLCCPOIH<, >.NDHMGFFAHGC))]
	public Task<TResult> GIEEGCILGBM(TRequest OHDJLNAKLPC, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x55FAD30", Offset = "0x55F9B30", VA = "0x1855FAD30")]
	private void GIEEGCILGBM(TRequest OHDJLNAKLPC, TaskCompletionSource<TResult> BOKOJFIAMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x55FAC70", Offset = "0x55F9A70", VA = "0x1855FAC70")]
	public Task FBOAIOKEDLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x55FB010", Offset = "0x55F9E10", VA = "0x1855FB010")]
	[AsyncStateMachine(typeof(OBNDLCCPOIH<, >.PHLOOAABGEH))]
	private Task JBNJHNKAOCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x55FAEF0", Offset = "0x55F9CF0", VA = "0x1855FAEF0")]
	[AsyncStateMachine(typeof(OBNDLCCPOIH<, >.OCAPHKLLDJF))]
	private Task HKOPPLKHDFF(CancellationToken MLBAFJMOIJI, CancellationToken MAAPHOBFAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x55FB0E0", Offset = "0x55F9EE0", VA = "0x1855FB0E0")]
	[AsyncStateMachine(typeof(OBNDLCCPOIH<, >.OOFNHJJMFKO))]
	private Task LDMHIEMBNEP(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x55FB3A0", Offset = "0x55FA1A0", VA = "0x1855FB3A0")]
	private TimeSpan PJPNPECKKLD()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55FB280", Offset = "0x55FA080", VA = "0x1855FB280")]
	private Task<List<TResult>> NLCOBLICNOE(IReadOnlyList<TRequest> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55FA990", Offset = "0x55F9790", VA = "0x1855FA990")]
	private float DPNOFFKFMGP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55FB1E0", Offset = "0x55F9FE0", VA = "0x1855FB1E0")]
	private void NKIFGNKLIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PBAJPEDBMNH<TItemId, TResult> : KLFPIFLLAGK<AAHAOANEADG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> BEAJJAJGCOK(Dictionary<TItemId, int> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AJKCNPPJDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AJKCNPPJDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1630", Offset = "0x4DC0430", VA = "0x184DC1630")]
		internal TResult AEPIIIDAIIE(AAHAOANEADG<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KEPEMEOEHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<AAHAOANEADG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PBAJPEDBMNH<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AJKCNPPJDMN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50A2B70", Offset = "0x50A1970", VA = "0x1850A2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50A38D0", Offset = "0x50A26D0", VA = "0x1850A38D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly BEAJJAJGCOK KACKHONCLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> EDPFJJMAPIB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D34780", Offset = "0x4D33580", VA = "0x184D34780")]
	public PBAJPEDBMNH(BEAJJAJGCOK KACKHONCLOO, [Optional] IEqualityComparer<TItemId> EDPFJJMAPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5733E90", Offset = "0x5732C90", VA = "0x185733E90", Slot = "4")]
	[AsyncStateMachine(typeof(PBAJPEDBMNH<, >.KEPEMEOEHNG))]
	public Task<List<TResult>> OLOFHBAICJE(IReadOnlyList<AAHAOANEADG<TItemId>> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IGJJMPKMAKP<TRequest, TResult> : KLFPIFLLAGK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> JBLMNBDNNKA(IEnumerable<TRequest> BJJOHONFGIJ, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FCMJMPIOIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FCMJMPIOIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x460E600", Offset = "0x460D400", VA = "0x18460E600")]
		internal TResult AEPIIIDAIIE(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JGFHBIEAOBK : IAsyncStateMachine
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
		public IGJJMPKMAKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FCMJMPIOIEJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4FA6240", Offset = "0x4FA5040", VA = "0x184FA6240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4FA70A0", Offset = "0x4FA5EA0", VA = "0x184FA70A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JBLMNBDNNKA KACKHONCLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> EDPFJJMAPIB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D34780", Offset = "0x4D33580", VA = "0x184D34780")]
	public IGJJMPKMAKP(JBLMNBDNNKA KACKHONCLOO, [Optional] IEqualityComparer<TRequest> EDPFJJMAPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D34640", Offset = "0x4D33440", VA = "0x184D34640", Slot = "4")]
	[AsyncStateMachine(typeof(IGJJMPKMAKP<, >.JGFHBIEAOBK))]
	public Task<List<TResult>> OLOFHBAICJE(IReadOnlyList<TRequest> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KLFPIFLLAGK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OLOFHBAICJE(IReadOnlyList<TRequest> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HCDKBGDLODM<TItemId, TResult> : KLFPIFLLAGK<ACDGJLCPDAD<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task OLJHGLJAEJC(IReadOnlyDictionary<TItemId, ACDGJLCPDAD<TItemId>.LFFAIFMDAGG> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct LMEDEIABLDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HCDKBGDLODM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<ACDGJLCPDAD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51AB2D0", Offset = "0x51AA0D0", VA = "0x1851AB2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51AB830", Offset = "0x51AA630", VA = "0x1851AB830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OLJHGLJAEJC KEIJEPKPOIN;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public HCDKBGDLODM(OLJHGLJAEJC KEIJEPKPOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C16F30", Offset = "0x4C15D30", VA = "0x184C16F30", Slot = "4")]
	[AsyncStateMachine(typeof(HCDKBGDLODM<, >.LMEDEIABLDO))]
	public Task<List<object>> OLOFHBAICJE(IReadOnlyList<ACDGJLCPDAD<TItemId>> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C16AB0", Offset = "0x4C158B0", VA = "0x184C16AB0")]
	private IReadOnlyDictionary<TItemId, ACDGJLCPDAD<TItemId>.LFFAIFMDAGG> OICGKIIDIFD(IReadOnlyList<ACDGJLCPDAD<TItemId>> OFGPPJECGMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FAHEACLLJJP<TItemId, TResult> : KLFPIFLLAGK<AAHAOANEADG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> LGOPPFJGHOE(Dictionary<TItemId, int> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct OADNOIPCFGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<AAHAOANEADG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FAHEACLLJJP<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x55F5FE0", Offset = "0x55F4DE0", VA = "0x1855F5FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x55F6CB0", Offset = "0x55F5AB0", VA = "0x1855F6CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly LGOPPFJGHOE CMJBHIIPFCD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public FAHEACLLJJP(LGOPPFJGHOE KACKHONCLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4A43470", Offset = "0x4A42270", VA = "0x184A43470", Slot = "4")]
	[AsyncStateMachine(typeof(FAHEACLLJJP<, >.OADNOIPCFGP))]
	public Task<List<TResult>> OLOFHBAICJE(IReadOnlyList<AAHAOANEADG<TItemId>> KKEOIEBPBPK, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class JGNPPLHOPHM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, FIBJHCAOCDK> PAANFIKIKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> DAOLJNCNMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> DNPINJFNNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> NEHOOBLEJIM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, FIBJHCAOCDK> OICFMNECHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> AKIKLKPMBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BCFMMGGCOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4FACBE0", Offset = "0x4FAB9E0", VA = "0x184FACBE0")]
	public JGNPPLHOPHM(Func<IEnumerable<T>> DNPINJFNNID, Func<T, string> NEHOOBLEJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC920", Offset = "0x4FAB720", VA = "0x184FAC920")]
	public void JPEBABACHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4FAC890", Offset = "0x4FAB690", VA = "0x184FAC890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PLJMKFFPMLI<TItemId, TResult> : OBNDLCCPOIH<AAHAOANEADG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4BA6A90", Offset = "0x4BA5890", VA = "0x184BA6A90")]
	public PLJMKFFPMLI(KLFPIFLLAGK<AAHAOANEADG<TItemId>, TResult> CDNPODPCION, TimeSpan HCJCHDDOICK, bool LKBEFHNIEIO, [Optional] AHHEJMOLFFP IGKNFEPILID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x578EAC0", Offset = "0x578D8C0", VA = "0x18578EAC0")]
	public Task<TResult> GIEEGCILGBM(TItemId MAKJJJECHHB, int CGKKBLKIKKA, [Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AAHAOANEADG<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId IBGIHIDLEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HEBHICMMGJO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4B5B010", Offset = "0x4B59E10", VA = "0x184B5B010")]
	public AAHAOANEADG(TItemId BPLOOBBHEML, int CGKKBLKIKKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface EJONOEPJPCA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid KAKAFMGMHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> HJFLOPKNCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LNMADGNMNID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface LKMCALAHAPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int MCMCKJJDPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MJEPIILCDDF<TParam>(TParam OAIIHELJHLG);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool KEDPJEDOFJE(Exception ANMGGEBBMLP);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AGNOAOILMJB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class GKCDGLLEOJF<TResult> : LKMCALAHAPK, EJONOEPJPCA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> FDNGACKNMLA;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid KAKAFMGMHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int MCMCKJJDPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> HJFLOPKNCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4BCFD90", Offset = "0x4BCEB90", VA = "0x184BCFD90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4BCFE30", Offset = "0x4BCEC30", VA = "0x184BCFE30")]
		public GKCDGLLEOJF(int NGIHBDBBCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3A78830", Offset = "0x3A77630", VA = "0x183A78830", Slot = "5")]
		public bool MJEPIILCDDF<TParam>(TParam OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4BCFDE0", Offset = "0x4BCEBE0", VA = "0x184BCFDE0", Slot = "6")]
		public bool KEDPJEDOFJE(Exception ANMGGEBBMLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4BCFD40", Offset = "0x4BCEB40", VA = "0x184BCFD40", Slot = "7")]
		public bool AGNOAOILMJB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string IMMNPICKMNB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, LKMCALAHAPK> BALEHLIBMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BLCMGFNDLHA BHNEIPEEIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool OFGGLEGEFLL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x858D440", Offset = "0x858C240", VA = "0x18858D440")]
	public LNMADGNMNID([Optional] BLCMGFNDLHA BHNEIPEEIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x858D010", Offset = "0x858BE10", VA = "0x18858D010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x39FD030", Offset = "0x39FBE30", VA = "0x1839FD030")]
	public EJONOEPJPCA<TResult> OKPGBPHHOJA<TResult>(int HFDOLPMCOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x39FCCC0", Offset = "0x39FBAC0", VA = "0x1839FCCC0")]
	public bool MEABFAMDCEO<TResult>(Guid LGNCELEMLNH, TResult BPINCJLADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x858D320", Offset = "0x858C120", VA = "0x18858D320")]
	private void LJFAGHPDOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x858D010", Offset = "0x858BE10", VA = "0x18858D010")]
	private void DBBGEIBGKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x858CD20", Offset = "0x858BB20", VA = "0x18858CD20")]
	private void DAPIIHAPGOF(int NGIHBDBBCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x858D120", Offset = "0x858BF20", VA = "0x18858D120")]
	private void IGNKMADJBOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum ODAGFCHNFGL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ACDGJLCPDAD<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class LFFAIFMDAGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int JBDECJBECCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int JCGJHFHNGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int IMLJJANFBOC;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LFFAIFMDAGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId IBGIHIDLEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HEBHICMMGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ODAGFCHNFGL BCPCKLFLFBI;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1ECDD40", Offset = "0x1ECCB40", VA = "0x181ECDD40")]
	public ACDGJLCPDAD(TItemId BPLOOBBHEML, int CGKKBLKIKKA, ODAGFCHNFGL EEDJPELJDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EJPABNDCFEC<TItemId, TResult> : OBNDLCCPOIH<ACDGJLCPDAD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x460DC00", Offset = "0x460CA00", VA = "0x18460DC00")]
	public EJPABNDCFEC(KLFPIFLLAGK<ACDGJLCPDAD<TItemId>, TResult> CDNPODPCION, TimeSpan HCJCHDDOICK, [Optional] AHHEJMOLFFP IGKNFEPILID)
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

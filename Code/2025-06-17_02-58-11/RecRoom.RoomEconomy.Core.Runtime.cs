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
public interface MJMPJPKPIBP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MMFMEMJKMAP(int EJDPCOEGOFN, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MMFMEMJKMAP(TimeSpan KNONOBLKCJJ, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class EAJJGENKOOJ : MJMPJPKPIBP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8553FB0", Offset = "0x85529B0", VA = "0x188553FB0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EAJJGENKOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8553EF0", Offset = "0x85528F0", VA = "0x188553EF0", Slot = "4")]
	public Task MMFMEMJKMAP(int EJDPCOEGOFN, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8553F50", Offset = "0x8552950", VA = "0x188553F50", Slot = "5")]
	public Task MMFMEMJKMAP(TimeSpan KNONOBLKCJJ, CancellationToken JKPNCAGHEDI)
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
		[Cpp2IlInjected.Address(RVA = "0x8554840", Offset = "0x8553240", VA = "0x188554840", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AAIIJKIAFEO : NMNCPFIAFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ACEKNKBAKIJ DFBGJGNOACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MHIKODPGGDA<bool> AMHHNMNKCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MHIKODPGGDA<bool> FOAEMCDLGDM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GMOAHAIIGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8553CF0", Offset = "0x85526F0", VA = "0x188553CF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GNFDFDFBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8553D40", Offset = "0x8552740", VA = "0x188553D40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8553D90", Offset = "0x8552790", VA = "0x188553D90")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	internal static void NBDHNJGHJEB(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8553E00", Offset = "0x8552800", VA = "0x188553E00")]
	[RecRoom.NoEngine.Common.Preserve]
	public AAIIJKIAFEO([CNHMBDDCGKB(null)][NotNull] ACEKNKBAKIJ DFBGJGNOACE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OIMIJLDNOEE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct BIOGNACBDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest NBCDMMPPPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> PNFDDGKPCNA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
		public BIOGNACBDGF(TRequest OHOKHLNBDDB, TaskCompletionSource<TResult> OCECEEDLDBF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AKOMDIKCAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public OIMIJLDNOEE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4F71280", Offset = "0x4F6FC80", VA = "0x184F71280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4B39CF0", Offset = "0x4B386F0", VA = "0x184B39CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HFFMANAPKJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public OIMIJLDNOEE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4CEC1A0", Offset = "0x4CEABA0", VA = "0x184CEC1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4CEC560", Offset = "0x4CEAF60", VA = "0x184CEC560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JKLCJLFMOGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OIMIJLDNOEE<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x50A01B0", Offset = "0x509EBB0", VA = "0x1850A01B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50A0640", Offset = "0x509F040", VA = "0x1850A0640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NKCLLPOPPGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OIMIJLDNOEE<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x550FCA0", Offset = "0x550E6A0", VA = "0x18550FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5510D10", Offset = "0x550F710", VA = "0x185510D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly OKAENKGLJBN<TRequest, TResult> OODMIFMAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float EKPLKDLIFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MJMPJPKPIBP NICMBEDLCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool HJKDJMFLABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<BIOGNACBDGF> PHJBEBKKPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<BIOGNACBDGF> PIHJKLNHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EHECKPHAGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource IKIBHMCMEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource POAHHNEDNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task PPPIGAFLJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float IBHHADEEEOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA17C10", Offset = "0xA16610", VA = "0x180A17C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA17BE0", Offset = "0xA165E0", VA = "0x180A17BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5665B40", Offset = "0x5664540", VA = "0x185665B40")]
	public OIMIJLDNOEE(OKAENKGLJBN<TRequest, TResult> OODMIFMAIIE, TimeSpan EKPLKDLIFNJ, bool HJKDJMFLABN, [Optional] MJMPJPKPIBP NICMBEDLCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5665360", Offset = "0x5663D60", VA = "0x185665360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x56655F0", Offset = "0x5663FF0", VA = "0x1856655F0")]
	[AsyncStateMachine(typeof(OIMIJLDNOEE<, >.AKOMDIKCAAJ))]
	public Task<TResult> HDHAMHBDDLI(TRequest OHOKHLNBDDB, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5665710", Offset = "0x5664110", VA = "0x185665710")]
	private void HDHAMHBDDLI(TRequest OHOKHLNBDDB, TaskCompletionSource<TResult> OCECEEDLDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5665790", Offset = "0x5664190", VA = "0x185665790")]
	public Task KAACLAOEOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5665970", Offset = "0x5664370", VA = "0x185665970")]
	[AsyncStateMachine(typeof(OIMIJLDNOEE<, >.HFFMANAPKJJ))]
	private Task PBPHKBGLPDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5665850", Offset = "0x5664250", VA = "0x185665850")]
	[AsyncStateMachine(typeof(OIMIJLDNOEE<, >.JKLCJLFMOGG))]
	private Task PBNFDJIIKGD(CancellationToken AFJANLMKIBK, CancellationToken PENIFFACKHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5665260", Offset = "0x5663C60", VA = "0x185665260")]
	[AsyncStateMachine(typeof(OIMIJLDNOEE<, >.NKCLLPOPPGN))]
	private Task CEJKFADIALH(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5665190", Offset = "0x5663B90", VA = "0x185665190")]
	private TimeSpan BGCPLCCFEAH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5665A40", Offset = "0x5664440", VA = "0x185665A40")]
	private Task<List<TResult>> PKGPACICGKL(IReadOnlyList<TRequest> CONHHEBAINP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x56650F0", Offset = "0x5663AF0", VA = "0x1856650F0")]
	private float ANLBAOHAPON()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5665560", Offset = "0x5663F60", VA = "0x185665560")]
	private void FKCFPOFCCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGDAENKKNAI<TItemId, TResult> : OKAENKGLJBN<FFMMBMMHPLN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> PIAHFMNDFHM(Dictionary<TItemId, int> CONHHEBAINP, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KEBFKOEEAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KEBFKOEEAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51B0010", Offset = "0x51AEA10", VA = "0x1851B0010")]
		internal TResult ONECCKPIEAN(FFMMBMMHPLN<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DPKILCIFHDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<FFMMBMMHPLN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JGDAENKKNAI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KEBFKOEEAFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x425FBB0", Offset = "0x425E5B0", VA = "0x18425FBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4260830", Offset = "0x425F230", VA = "0x184260830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly PIAHFMNDFHM NJPKLFCJJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> CHDLIFCANLJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A1C0", Offset = "0x4F78BC0", VA = "0x184F7A1C0")]
	public JGDAENKKNAI(PIAHFMNDFHM NJPKLFCJJNG, [Optional] IEqualityComparer<TItemId> CHDLIFCANLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x508FF90", Offset = "0x508E990", VA = "0x18508FF90", Slot = "4")]
	[AsyncStateMachine(typeof(JGDAENKKNAI<, >.DPKILCIFHDI))]
	public Task<List<TResult>> HLGLKBBDJGL(IReadOnlyList<FFMMBMMHPLN<TItemId>> CONHHEBAINP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AONMKDGJONK<TRequest, TResult> : OKAENKGLJBN<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> GAMKOHMNDIJ(IEnumerable<TRequest> OOIHDMPFMCG, CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KOIBIKEPFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KOIBIKEPFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4F71910", Offset = "0x4F70310", VA = "0x184F71910")]
		internal TResult ONECCKPIEAN(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MKAFILEGGNM : IAsyncStateMachine
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
		public AONMKDGJONK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private KOIBIKEPFEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54877C0", Offset = "0x54861C0", VA = "0x1854877C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5488510", Offset = "0x5486F10", VA = "0x185488510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GAMKOHMNDIJ NJPKLFCJJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> CHDLIFCANLJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A1C0", Offset = "0x4F78BC0", VA = "0x184F7A1C0")]
	public AONMKDGJONK(GAMKOHMNDIJ NJPKLFCJJNG, [Optional] IEqualityComparer<TRequest> CHDLIFCANLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F7A080", Offset = "0x4F78A80", VA = "0x184F7A080", Slot = "4")]
	[AsyncStateMachine(typeof(AONMKDGJONK<, >.MKAFILEGGNM))]
	public Task<List<TResult>> HLGLKBBDJGL(IReadOnlyList<TRequest> CONHHEBAINP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKAENKGLJBN<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> HLGLKBBDJGL(IReadOnlyList<TRequest> CONHHEBAINP, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BFHELIJMAMG<TItemId, TResult> : OKAENKGLJBN<AJAOMLCBLPD<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task OLCHMEJKAGG(IReadOnlyDictionary<TItemId, AJAOMLCBLPD<TItemId>.INLKLLJADEI> CONHHEBAINP, CancellationToken JKPNCAGHEDI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct OFPCDMPBBGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BFHELIJMAMG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<AJAOMLCBLPD<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x565CA30", Offset = "0x565B430", VA = "0x18565CA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x565CF20", Offset = "0x565B920", VA = "0x18565CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OLCHMEJKAGG DECHFLMKILL;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public BFHELIJMAMG(OLCHMEJKAGG DECHFLMKILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6035070", Offset = "0x6033A70", VA = "0x186035070", Slot = "4")]
	[AsyncStateMachine(typeof(BFHELIJMAMG<, >.OFPCDMPBBGF))]
	public Task<List<object>> HLGLKBBDJGL(IReadOnlyList<AJAOMLCBLPD<TItemId>> CONHHEBAINP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6034C10", Offset = "0x6033610", VA = "0x186034C10")]
	private IReadOnlyDictionary<TItemId, AJAOMLCBLPD<TItemId>.INLKLLJADEI> EFKPPLNJCMF(IReadOnlyList<AJAOMLCBLPD<TItemId>> KDCLPFDCILA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGNPNBCEHMG<TItemId, TResult> : OKAENKGLJBN<FFMMBMMHPLN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> NMKFBILIBAP(Dictionary<TItemId, int> CONHHEBAINP, CancellationToken JKPNCAGHEDI);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EBCEOAKPEOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<FFMMBMMHPLN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DGNPNBCEHMG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x46839D0", Offset = "0x46823D0", VA = "0x1846839D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4685210", Offset = "0x4683C10", VA = "0x184685210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NMKFBILIBAP KEFICONCNDP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public DGNPNBCEHMG(NMKFBILIBAP NJPKLFCJJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AEFEA0", Offset = "0x6AEE8A0", VA = "0x186AEFEA0", Slot = "4")]
	[AsyncStateMachine(typeof(DGNPNBCEHMG<, >.EBCEOAKPEOH))]
	public Task<List<TResult>> HLGLKBBDJGL(IReadOnlyList<FFMMBMMHPLN<TItemId>> CONHHEBAINP, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FLOHIJFJMKL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, BECPOFPPNAB> GLFFCHJMADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> JFGNLKHKIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> CPOHMCMLKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> EOLAGDMDGLL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, BECPOFPPNAB> HPGLIJJBGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> FABJFEEDGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DALHMGJECAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B59DF0", Offset = "0x4B587F0", VA = "0x184B59DF0")]
	public FLOHIJFJMKL(Func<IEnumerable<T>> CPOHMCMLKHH, Func<T, string> EOLAGDMDGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4B59BA0", Offset = "0x4B585A0", VA = "0x184B59BA0")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4B59B30", Offset = "0x4B58530", VA = "0x184B59B30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LOEDOOGMJDG<TItemId, TResult> : OIMIJLDNOEE<FFMMBMMHPLN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4B2F2D0", Offset = "0x4B2DCD0", VA = "0x184B2F2D0")]
	public LOEDOOGMJDG(OKAENKGLJBN<FFMMBMMHPLN<TItemId>, TResult> OODMIFMAIIE, TimeSpan EKPLKDLIFNJ, bool HJKDJMFLABN, [Optional] MJMPJPKPIBP NICMBEDLCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x52A07F0", Offset = "0x529F1F0", VA = "0x1852A07F0")]
	public Task<TResult> HDHAMHBDDLI(TItemId KJNEHANBOBO, int IHEMAOAJCIP, [Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FFMMBMMHPLN<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId JMNCCKOPLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int HIIHLOHGEFO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4B3B880", Offset = "0x4B3A280", VA = "0x184B3B880")]
	public FFMMBMMHPLN(TItemId FOLIMMBLOPB, int IHEMAOAJCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ADLHFOLOKCN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid NHEGPKBAFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> MHEKPFJIGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NIIHCNNBCPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface JKFAEAFBKAC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int IPMGELGFNDF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MLOOOBIKGPG<TParam>(TParam PCDAHJCDHHF);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool BNFCKHOLHIN(Exception AJLHKIHCGAH);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LIPGFMKMJCK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class EOEHCFPINGO<TResult> : JKFAEAFBKAC, ADLHFOLOKCN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> LMMMGOIHAIN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid NHEGPKBAFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IPMGELGFNDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> MHEKPFJIGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x46BACB0", Offset = "0x46B96B0", VA = "0x1846BACB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x46BACF0", Offset = "0x46B96F0", VA = "0x1846BACF0")]
		public EOEHCFPINGO(int GLAJFJBMBMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFB90", Offset = "0x3ECE590", VA = "0x183ECFB90", Slot = "5")]
		public bool MLOOOBIKGPG<TParam>(TParam PCDAHJCDHHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46BAC30", Offset = "0x46B9630", VA = "0x1846BAC30", Slot = "6")]
		public bool BNFCKHOLHIN(Exception AJLHKIHCGAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x46BAC70", Offset = "0x46B9670", VA = "0x1846BAC70", Slot = "7")]
		public bool LIPGFMKMJCK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string LPDBKBJHBNH = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, JKFAEAFBKAC> MBAAICMGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LMOAADIJJAJ PJMPKEPCEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool OAANHKPLLJE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8554740", Offset = "0x8553140", VA = "0x188554740")]
	public NIIHCNNBCPP([Optional] LMOAADIJJAJ PJMPKEPCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8554020", Offset = "0x8552A20", VA = "0x188554020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA100", Offset = "0x3BB8B00", VA = "0x183BBA100")]
	public ADLHFOLOKCN<TResult> NDGOLMADFKE<TResult>(int BHOINMHCMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9DD0", Offset = "0x3BB87D0", VA = "0x183BB9DD0")]
	public bool IAOJICOKLAB<TResult>(Guid CFNOFGNKICA, TResult MGJNMKLFKCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8554130", Offset = "0x8552B30", VA = "0x188554130")]
	private void EHELCBDHAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8554020", Offset = "0x8552A20", VA = "0x188554020")]
	private void MBAKHFANBOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8554450", Offset = "0x8552E50", VA = "0x188554450")]
	private void NMPDOHNEDJG(int GLAJFJBMBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8554250", Offset = "0x8552C50", VA = "0x188554250")]
	private void GJKLMOCFOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MOHNLOMBICB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AJAOMLCBLPD<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class INLKLLJADEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int EAGCAILPOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int CEIGFGONCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int ODIDGPIJKNC;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public INLKLLJADEI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId JMNCCKOPLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HIIHLOHGEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public MOHNLOMBICB PJAAKIMNCCJ;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1FCBD70", Offset = "0x1FCA770", VA = "0x181FCBD70")]
	public AJAOMLCBLPD(TItemId FOLIMMBLOPB, int IHEMAOAJCIP, MOHNLOMBICB CHCCOOMJKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CEILLGHJGBE<TItemId, TResult> : OIMIJLDNOEE<AJAOMLCBLPD<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x64BEBD0", Offset = "0x64BD5D0", VA = "0x1864BEBD0")]
	public CEILLGHJGBE(OKAENKGLJBN<AJAOMLCBLPD<TItemId>, TResult> OODMIFMAIIE, TimeSpan EKPLKDLIFNJ, [Optional] MJMPJPKPIBP NICMBEDLCJJ)
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

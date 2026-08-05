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
public interface KKJEIBBIMIP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HHGKMKBJGGK(int IOAFNJDHKOH, CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HHGKMKBJGGK(TimeSpan PKLFPAALCKD, CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NNNIJADOHOL : KKJEIBBIMIP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7073FE0", Offset = "0x70725E0", VA = "0x187073FE0")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	private static void IKLHHCEEFCF(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	[Preserve]
	public NNNIJADOHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7073F20", Offset = "0x7072520", VA = "0x187073F20", Slot = "4")]
	public Task HHGKMKBJGGK(int IOAFNJDHKOH, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7073F80", Offset = "0x7072580", VA = "0x187073F80", Slot = "5")]
	public Task HHGKMKBJGGK(TimeSpan PKLFPAALCKD, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BFIGJPMGEJO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct OABOELGDDBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest FDGENAOKLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> JAMGAFMLBPL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
		public OABOELGDDBB(TRequest EPDDNPCGMCI, TaskCompletionSource<TResult> GNOPBNMOHBK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HLDBEBNJBIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public BFIGJPMGEJO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4BD0", Offset = "0x3DA31D0", VA = "0x183DA4BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3856000", Offset = "0x3854600", VA = "0x183856000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct HFBEHMBPPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BFIGJPMGEJO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3D98A50", Offset = "0x3D97050", VA = "0x183D98A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D98E40", Offset = "0x3D97440", VA = "0x183D98E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JIJGDHICFOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BFIGJPMGEJO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4091B70", Offset = "0x4090170", VA = "0x184091B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4092030", Offset = "0x4090630", VA = "0x184092030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MNLAFFDFFAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BFIGJPMGEJO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x44F3D90", Offset = "0x44F2390", VA = "0x1844F3D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44F4FD0", Offset = "0x44F35D0", VA = "0x1844F4FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LBLKPOMLNEE<TRequest, TResult> EBHJPDCBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float FDPMHMNKDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly KKJEIBBIMIP OOOKGJHNOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool OKGGPOODFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<OABOELGDDBB> KCPJAGLKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<OABOELGDDBB> ENCBILJMGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool BOAMHIDGCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource DBFCDFNEHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource ENEDINCJNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task LKIKAKNCAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float LGLKKMAILDB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DBIJCBPOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x873620", Offset = "0x871C20", VA = "0x180873620")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x873510", Offset = "0x871B10", VA = "0x180873510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4EC93A0", Offset = "0x4EC79A0", VA = "0x184EC93A0")]
	public BFIGJPMGEJO(LBLKPOMLNEE<TRequest, TResult> EBHJPDCBJHC, TimeSpan FDPMHMNKDNM, bool OKGGPOODFEM, [Optional] KKJEIBBIMIP OOOKGJHNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8940", Offset = "0x4EC6F40", VA = "0x184EC8940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8D00", Offset = "0x4EC7300", VA = "0x184EC8D00")]
	[AsyncStateMachine(typeof(BFIGJPMGEJO<, >.HLDBEBNJBIF))]
	public Task<TResult> FMBDKFLNFLF(TRequest EPDDNPCGMCI, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8C60", Offset = "0x4EC7260", VA = "0x184EC8C60")]
	private void FMBDKFLNFLF(TRequest EPDDNPCGMCI, TaskCompletionSource<TResult> GNOPBNMOHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8880", Offset = "0x4EC6E80", VA = "0x184EC8880")]
	public Task BKPOLEHELPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8E30", Offset = "0x4EC7430", VA = "0x184EC8E30")]
	[AsyncStateMachine(typeof(BFIGJPMGEJO<, >.HFBEHMBPPMC))]
	private Task FPCFBKLIDAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8FB0", Offset = "0x4EC75B0", VA = "0x184EC8FB0")]
	[AsyncStateMachine(typeof(BFIGJPMGEJO<, >.JIJGDHICFOP))]
	private Task IJIMIDNEDMO(CancellationToken FKJMCDAHMFA, CancellationToken KEGKEKALBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4EC9180", Offset = "0x4EC7780", VA = "0x184EC9180")]
	[AsyncStateMachine(typeof(BFIGJPMGEJO<, >.MNLAFFDFFAG))]
	private Task KCCDMHJAPMD(CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8B80", Offset = "0x4EC7180", VA = "0x184EC8B80")]
	private TimeSpan FFHJNOHFLNH()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4EC9280", Offset = "0x4EC7880", VA = "0x184EC9280")]
	private Task<List<TResult>> KDCIEKKIFCD(IReadOnlyList<TRequest> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8F10", Offset = "0x4EC7510", VA = "0x184EC8F10")]
	private float HINDAMMAOAD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EC90D0", Offset = "0x4EC76D0", VA = "0x184EC90D0")]
	private void IMKKDPNIOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OJAMLPHHAAD<TItemId, TResult> : LBLKPOMLNEE<EIPGLHCGLLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> NFBACDCBONG(Dictionary<TItemId, int> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LFBKNLCLMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LFBKNLCLMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x42CB2D0", Offset = "0x42C98D0", VA = "0x1842CB2D0")]
		internal TResult ECGGNHIOJGE(EIPGLHCGLLK<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HFFGGALLEKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<EIPGLHCGLLK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OJAMLPHHAAD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private LFBKNLCLMGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D420", Offset = "0x3D9BA20", VA = "0x183D9D420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E230", Offset = "0x3D9C830", VA = "0x183D9E230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NFBACDCBONG EEPGMOPBCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> PAEANBLKLHD;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x385AAD0", Offset = "0x38590D0", VA = "0x18385AAD0")]
	public OJAMLPHHAAD(NFBACDCBONG EEPGMOPBCPG, [Optional] IEqualityComparer<TItemId> PAEANBLKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46DCE90", Offset = "0x46DB490", VA = "0x1846DCE90", Slot = "4")]
	[AsyncStateMachine(typeof(OJAMLPHHAAD<, >.HFFGGALLEKE))]
	public Task<List<TResult>> OCIEPBBDJKO(IReadOnlyList<EIPGLHCGLLK<TItemId>> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EDEKBJMFBGI<TRequest, TResult> : LBLKPOMLNEE<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> OMAIBCBAGNO(IEnumerable<TRequest> HMFDBEPGBMG, CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GHFKJEEHEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public GHFKJEEHEJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAAA0", Offset = "0x3CA90A0", VA = "0x183CAAAA0")]
		internal TResult ECGGNHIOJGE(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KHPEJPOJELN : IAsyncStateMachine
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
		public EDEKBJMFBGI<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private GHFKJEEHEJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41B4150", Offset = "0x41B2750", VA = "0x1841B4150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x41B5070", Offset = "0x41B3670", VA = "0x1841B5070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly OMAIBCBAGNO EEPGMOPBCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> PAEANBLKLHD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x385AAD0", Offset = "0x38590D0", VA = "0x18385AAD0")]
	public EDEKBJMFBGI(OMAIBCBAGNO EEPGMOPBCPG, [Optional] IEqualityComparer<TRequest> PAEANBLKLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x385A980", Offset = "0x3858F80", VA = "0x18385A980", Slot = "4")]
	[AsyncStateMachine(typeof(EDEKBJMFBGI<, >.KHPEJPOJELN))]
	public Task<List<TResult>> OCIEPBBDJKO(IReadOnlyList<TRequest> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LBLKPOMLNEE<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OCIEPBBDJKO(IReadOnlyList<TRequest> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JGLEAIBFION<TItemId, TResult> : LBLKPOMLNEE<NCDNIDCBONN<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task KCKBNNHDILO(IReadOnlyDictionary<TItemId, NCDNIDCBONN<TItemId>.JKLJCDLHMGH> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EBMHPEKHNDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public JGLEAIBFION<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<NCDNIDCBONN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x38554D0", Offset = "0x3853AD0", VA = "0x1838554D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3855A60", Offset = "0x3854060", VA = "0x183855A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KCKBNNHDILO EGHIDKBKPED;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public JGLEAIBFION(KCKBNNHDILO EGHIDKBKPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x408E910", Offset = "0x408CF10", VA = "0x18408E910", Slot = "4")]
	[AsyncStateMachine(typeof(JGLEAIBFION<, >.EBMHPEKHNDC))]
	public Task<List<object>> OCIEPBBDJKO(IReadOnlyList<NCDNIDCBONN<TItemId>> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x408E480", Offset = "0x408CA80", VA = "0x18408E480")]
	private IReadOnlyDictionary<TItemId, NCDNIDCBONN<TItemId>.JKLJCDLHMGH> KOHJEJGNPOP(IReadOnlyList<NCDNIDCBONN<TItemId>> KDGDJIKOOKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FNMGIAEFDJG<TItemId, TResult> : LBLKPOMLNEE<EIPGLHCGLLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> IOAGBCHAPHB(Dictionary<TItemId, int> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FELKDGEPGGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<EIPGLHCGLLK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FNMGIAEFDJG<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C11F00", Offset = "0x3C10500", VA = "0x183C11F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C13920", Offset = "0x3C11F20", VA = "0x183C13920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IOAGBCHAPHB IDOEHBJPMDA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public FNMGIAEFDJG(IOAGBCHAPHB EEPGMOPBCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C3BF60", Offset = "0x3C3A560", VA = "0x183C3BF60", Slot = "4")]
	[AsyncStateMachine(typeof(FNMGIAEFDJG<, >.FELKDGEPGGJ))]
	public Task<List<TResult>> OCIEPBBDJKO(IReadOnlyList<EIPGLHCGLLK<TItemId>> HCLIJPBLHOP, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PDHEKKKLIGD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, OJKMPFKGAPM> HAGAIIFDCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> JDCCPMNHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> HKFGOOHMEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> DPKONGMAIID;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OJKMPFKGAPM> JFFMMJAMHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FLHEHHGJNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KJJBHGBGNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F0910", Offset = "0x8EEF10", VA = "0x1808F0910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x479E750", Offset = "0x479CD50", VA = "0x18479E750")]
	public PDHEKKKLIGD(Func<IEnumerable<T>> HKFGOOHMEHK, Func<T, string> DPKONGMAIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x479E480", Offset = "0x479CA80", VA = "0x18479E480")]
	public void JPIODFAGAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x479E3F0", Offset = "0x479C9F0", VA = "0x18479E3F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LMKMIIDANBC<TItemId, TResult> : BFIGJPMGEJO<EIPGLHCGLLK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3E99210", Offset = "0x3E97810", VA = "0x183E99210")]
	public LMKMIIDANBC(LBLKPOMLNEE<EIPGLHCGLLK<TItemId>, TResult> EBHJPDCBJHC, TimeSpan FDPMHMNKDNM, bool OKGGPOODFEM, [Optional] KKJEIBBIMIP OOOKGJHNOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x42EB500", Offset = "0x42E9B00", VA = "0x1842EB500")]
	public Task<TResult> FMBDKFLNFLF(TItemId IBBDLGCDELM, int COCPBHGCIJL, [Optional] CancellationToken FIMAIPEFOAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EIPGLHCGLLK<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId IDPMEOFNBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int LBAAAJJICEE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3878BA0", Offset = "0x38771A0", VA = "0x183878BA0")]
	public EIPGLHCGLLK(TItemId NKDAJGAOHHE, int COCPBHGCIJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PHJKEOFAGFI<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid OHJOLIKHHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IPNLKMEKKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class COLMBPNFDKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface DAJCABDOJPF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int LPIJLDANCCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BCJHKGAEKKP<TParam>(TParam DMNGPNKHPKF);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PFHLGEKJBAI(Exception PAPBNEGEKNJ);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ONGJHJPMNMM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GEAPPIAEILP<TResult> : DAJCABDOJPF, PHJKEOFAGFI<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> MAJHLODNNLP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid OHJOLIKHHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA60", Offset = "0x8FA060", VA = "0x1808FBA60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int LPIJLDANCCF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IPNLKMEKKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3D089A0", Offset = "0x3D06FA0", VA = "0x183D089A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3D08AC0", Offset = "0x3D070C0", VA = "0x183D08AC0")]
		public GEAPPIAEILP(int OPCCJJONALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A17CA0", Offset = "0x2A162A0", VA = "0x182A17CA0", Slot = "5")]
		public bool BCJHKGAEKKP<TParam>(TParam DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D08A60", Offset = "0x3D07060", VA = "0x183D08A60", Slot = "6")]
		public bool PFHLGEKJBAI(Exception PAPBNEGEKNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D08A00", Offset = "0x3D07000", VA = "0x183D08A00", Slot = "7")]
		public bool ONGJHJPMNMM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string PNJIJHGBNBN = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, DAJCABDOJPF> HLFBNJIDGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly JMAAMACGMPD KJAEKHANLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool DINEGDJMHKL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7073E50", Offset = "0x7072450", VA = "0x187073E50")]
	public COLMBPNFDKO([Optional] JMAAMACGMPD KJAEKHANLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7073730", Offset = "0x7071D30", VA = "0x187073730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29BAC30", Offset = "0x29B9230", VA = "0x1829BAC30")]
	public PHJKEOFAGFI<TResult> PFFMLKONDBK<TResult>(int HEKIBLHANJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29BA8C0", Offset = "0x29B8EC0", VA = "0x1829BA8C0")]
	public bool NMMAGFBCBLM<TResult>(Guid CLCJCEEIPEM, TResult IAFCFGOKEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7073840", Offset = "0x7071E40", VA = "0x187073840")]
	private void EPFCPIFBNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7073730", Offset = "0x7071D30", VA = "0x187073730")]
	private void MDPLCOLDHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7073960", Offset = "0x7071F60", VA = "0x187073960")]
	private void IEFMKBPMIJH(int OPCCJJONALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7073C50", Offset = "0x7072250", VA = "0x187073C50")]
	private void JCBNEMBNAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BHGNPGGEDNI
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NCDNIDCBONN<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class JKLJCDLHMGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int EIJJCBODJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int GDCIEOLGPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int IPDOEECFOAN;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JKLJCDLHMGH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId IDPMEOFNBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int LBAAAJJICEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public BHGNPGGEDNI LMLOICJFAKB;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x10FE710", Offset = "0x10FCD10", VA = "0x1810FE710")]
	public NCDNIDCBONN(TItemId NKDAJGAOHHE, int COCPBHGCIJL, BHGNPGGEDNI MADFKNCBFBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LDABKGCMLOE<TItemId, TResult> : BFIGJPMGEJO<NCDNIDCBONN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42BA850", Offset = "0x42B8E50", VA = "0x1842BA850")]
	public LDABKGCMLOE(LBLKPOMLNEE<NCDNIDCBONN<TItemId>, TResult> EBHJPDCBJHC, TimeSpan FDPMHMNKDNM, [Optional] KKJEIBBIMIP OOOKGJHNOAB)
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

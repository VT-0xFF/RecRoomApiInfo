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
public interface KCDOBEOKNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LMJLBOLEHID(int KLKKMAIGHAC, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LMJLBOLEHID(TimeSpan JEFOFKADOPB, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LOIACAAKMII : KCDOBEOKNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9890", Offset = "0x8BC8690", VA = "0x188BC9890")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[RecRoom.NoEngine.Common.Preserve]
	public LOIACAAKMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9900", Offset = "0x8BC8700", VA = "0x188BC9900", Slot = "4")]
	public Task LMJLBOLEHID(int KLKKMAIGHAC, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9960", Offset = "0x8BC8760", VA = "0x188BC9960", Slot = "5")]
	public Task LMJLBOLEHID(TimeSpan JEFOFKADOPB, CancellationToken BKHGNHANFKK)
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
		[Cpp2IlInjected.Address(RVA = "0x8BC99C0", Offset = "0x8BC87C0", VA = "0x188BC99C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FNKKICABEKI : PBBGKBMLKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MKKINKKENIE OKICBOPLGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NHDNMMLDFPG<bool> HNPMGMHLDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NHDNMMLDFPG<bool> HGOKLBCJPIJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JMKGCFIAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8EE0", Offset = "0x8BC7CE0", VA = "0x188BC8EE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CJDPFEJLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BC8F30", Offset = "0x8BC7D30", VA = "0x188BC8F30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8E70", Offset = "0x8BC7C70", VA = "0x188BC8E70")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	internal static void DBCFEKMBJDE(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8BC8F80", Offset = "0x8BC7D80", VA = "0x188BC8F80")]
	[RecRoom.NoEngine.Common.Preserve]
	public FNKKICABEKI([POMNKOCGGBN(null)][NotNull] MKKINKKENIE OKICBOPLGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PMKLNEKKLGH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct FEJKOPLCKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest BLHHJFDNJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> GCPFIHGKAFE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
		public FEJKOPLCKPE(TRequest FGKGCIHOGKN, TaskCompletionSource<TResult> LHCEDHGBOJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JKJKJDJAPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PMKLNEKKLGH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x54B3A10", Offset = "0x54B2810", VA = "0x1854B3A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x452BCB0", Offset = "0x452AAB0", VA = "0x18452BCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct GKLGKKONOGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PMKLNEKKLGH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5006070", Offset = "0x5004E70", VA = "0x185006070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5006440", Offset = "0x5005240", VA = "0x185006440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct EODKCAGCKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PMKLNEKKLGH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4A7ADB0", Offset = "0x4A79BB0", VA = "0x184A7ADB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4A7B250", Offset = "0x4A7A050", VA = "0x184A7B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LHCEONDBJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PMKLNEKKLGH<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5686AE0", Offset = "0x56858E0", VA = "0x185686AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5687BE0", Offset = "0x56869E0", VA = "0x185687BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly EDDHMKHNMGO<TRequest, TResult> DCFIKHJGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float EIOMDGEMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KCDOBEOKNFA JBGDKEJCOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool IGBCEAGPMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<FEJKOPLCKPE> HNJPMJPGMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<FEJKOPLCKPE> FOLDNIFFFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EBMBNGIGBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource HPEEPHFKMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource CKEABHAEOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task BBHIGDIPPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float ACMDDMEAJEJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA98D30", Offset = "0xA97B30", VA = "0x180A98D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA98B50", Offset = "0xA97950", VA = "0x180A98B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FC90", Offset = "0x5C0EA90", VA = "0x185C0FC90")]
	public PMKLNEKKLGH(EDDHMKHNMGO<TRequest, TResult> DCFIKHJGEIB, TimeSpan EIOMDGEMACB, bool IGBCEAGPMJJ, [Optional] KCDOBEOKNFA JBGDKEJCOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F2D0", Offset = "0x5C0E0D0", VA = "0x185C0F2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F6C0", Offset = "0x5C0E4C0", VA = "0x185C0F6C0")]
	[AsyncStateMachine(typeof(PMKLNEKKLGH<, >.JKJKJDJAPLE))]
	public Task<TResult> GKLCKCDKGAG(TRequest FGKGCIHOGKN, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F7E0", Offset = "0x5C0E5E0", VA = "0x185C0F7E0")]
	private void GKLCKCDKGAG(TRequest FGKGCIHOGKN, TaskCompletionSource<TResult> LHCEDHGBOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F600", Offset = "0x5C0E400", VA = "0x185C0F600")]
	public Task EMIHGEKKOBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F1F0", Offset = "0x5C0DFF0", VA = "0x185C0F1F0")]
	[AsyncStateMachine(typeof(PMKLNEKKLGH<, >.GKLGKKONOGG))]
	private Task DBPDFMNIKNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F870", Offset = "0x5C0E670", VA = "0x185C0F870")]
	[AsyncStateMachine(typeof(PMKLNEKKLGH<, >.EODKCAGCKFC))]
	private Task KHEKPLFFNEI(CancellationToken JAFNLCKOMDB, CancellationToken JAHCFIKLAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F990", Offset = "0x5C0E790", VA = "0x185C0F990")]
	[AsyncStateMachine(typeof(PMKLNEKKLGH<, >.LHCEONDBJCC))]
	private Task LCIJPOFNAKE(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FBC0", Offset = "0x5C0E9C0", VA = "0x185C0FBC0")]
	private TimeSpan PLKFHLAKKEL()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F4F0", Offset = "0x5C0E2F0", VA = "0x185C0F4F0")]
	private Task<List<TResult>> EFLPAJANPOP(IReadOnlyList<TRequest> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FA90", Offset = "0x5C0E890", VA = "0x185C0FA90")]
	private float LLJMAOJMLFO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FB30", Offset = "0x5C0E930", VA = "0x185C0FB30")]
	private void NKIKGNPBLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JBMAICDENLO<TItemId, TResult> : EDDHMKHNMGO<AACMMOKMMHI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> MBBBABAPHIL(Dictionary<TItemId, int> JJPHDMFIAJE, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GILFEBOFICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GILFEBOFICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA0B0", Offset = "0x4FF8EB0", VA = "0x184FFA0B0")]
		internal TResult LPJAOMNGDPN(AACMMOKMMHI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BHPAPEPKPJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<AACMMOKMMHI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JBMAICDENLO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private GILFEBOFICA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB500", Offset = "0x66EA300", VA = "0x1866EB500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x66EC230", Offset = "0x66EB030", VA = "0x1866EC230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly MBBBABAPHIL IGPNMNBJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> IFGHMFNGBPM;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x545AA40", Offset = "0x5459840", VA = "0x18545AA40")]
	public JBMAICDENLO(MBBBABAPHIL IGPNMNBJDAK, [Optional] IEqualityComparer<TItemId> IFGHMFNGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x545A500", Offset = "0x5459300", VA = "0x18545A500", Slot = "4")]
	[AsyncStateMachine(typeof(JBMAICDENLO<, >.BHPAPEPKPJG))]
	public Task<List<TResult>> PDKOKEBMDFN(IReadOnlyList<AACMMOKMMHI<TItemId>> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LKJBNGEIAOG<TRequest, TResult> : EDDHMKHNMGO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> ONJEPAKPFLA(IEnumerable<TRequest> PIDHDCCPHMO, CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class INDMPLICOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public INDMPLICOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x45B48F0", Offset = "0x45B36F0", VA = "0x1845B48F0")]
		internal TResult LPJAOMNGDPN(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct ADIENIIBEEB : IAsyncStateMachine
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
		public LKJBNGEIAOG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private INDMPLICOGJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5193D00", Offset = "0x5192B00", VA = "0x185193D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5194B10", Offset = "0x5193910", VA = "0x185194B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ONJEPAKPFLA IGPNMNBJDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> IFGHMFNGBPM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x545AA40", Offset = "0x5459840", VA = "0x18545AA40")]
	public LKJBNGEIAOG(ONJEPAKPFLA IGPNMNBJDAK, [Optional] IEqualityComparer<TRequest> IFGHMFNGBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5699280", Offset = "0x5698080", VA = "0x185699280", Slot = "4")]
	[AsyncStateMachine(typeof(LKJBNGEIAOG<, >.ADIENIIBEEB))]
	public Task<List<TResult>> PDKOKEBMDFN(IReadOnlyList<TRequest> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EDDHMKHNMGO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> PDKOKEBMDFN(IReadOnlyList<TRequest> JJPHDMFIAJE, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BFIAFHJIHPE<TItemId, TResult> : EDDHMKHNMGO<KKLLCJDDJIA<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task JIBFGLOPIFM(IReadOnlyDictionary<TItemId, KKLLCJDDJIA<TItemId>.HMJODMNJNKG> JJPHDMFIAJE, CancellationToken BKHGNHANFKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MFEJBHLDAGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BFIAFHJIHPE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<KKLLCJDDJIA<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x58A69F0", Offset = "0x58A57F0", VA = "0x1858A69F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x58A6F20", Offset = "0x58A5D20", VA = "0x1858A6F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JIBFGLOPIFM FADKLFHGKPO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public BFIAFHJIHPE(JIBFGLOPIFM FADKLFHGKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66E85F0", Offset = "0x66E73F0", VA = "0x1866E85F0", Slot = "4")]
	[AsyncStateMachine(typeof(BFIAFHJIHPE<, >.MFEJBHLDAGD))]
	public Task<List<object>> PDKOKEBMDFN(IReadOnlyList<KKLLCJDDJIA<TItemId>> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66E8160", Offset = "0x66E6F60", VA = "0x1866E8160")]
	private IReadOnlyDictionary<TItemId, KKLLCJDDJIA<TItemId>.HMJODMNJNKG> GEHNOOBIOAF(IReadOnlyList<KKLLCJDDJIA<TItemId>> PEOLFNIMCCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNGFLMAAEBC<TItemId, TResult> : EDDHMKHNMGO<AACMMOKMMHI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> PBCOKGBECMB(Dictionary<TItemId, int> JJPHDMFIAJE, CancellationToken BKHGNHANFKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct EFLLKNNCEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<AACMMOKMMHI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BNGFLMAAEBC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4A54270", Offset = "0x4A53070", VA = "0x184A54270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4A55B70", Offset = "0x4A54970", VA = "0x184A55B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly PBCOKGBECMB CCENPDJCKMG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public BNGFLMAAEBC(PBCOKGBECMB IGPNMNBJDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68CD810", Offset = "0x68CC610", VA = "0x1868CD810", Slot = "4")]
	[AsyncStateMachine(typeof(BNGFLMAAEBC<, >.EFLLKNNCEAH))]
	public Task<List<TResult>> PDKOKEBMDFN(IReadOnlyList<AACMMOKMMHI<TItemId>> JJPHDMFIAJE, CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LHFAOJLIFFB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, ELPCOELKDGJ> CMCKCNJJKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> GKMMCBGMPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> HLJPPCCNANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> BCCDPGJDDGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, ELPCOELKDGJ> AEHNELAEEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> IHMMIKMHMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BOJGDCEMFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAE69E0", Offset = "0xAE57E0", VA = "0x180AE69E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5689E30", Offset = "0x5688C30", VA = "0x185689E30")]
	public LHFAOJLIFFB(Func<IEnumerable<T>> HLJPPCCNANI, Func<T, string> BCCDPGJDDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5689B40", Offset = "0x5688940", VA = "0x185689B40")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5689DC0", Offset = "0x5688BC0", VA = "0x185689DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NBHGHIGJPON<TItemId, TResult> : PMKLNEKKLGH<AACMMOKMMHI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4537170", Offset = "0x4535F70", VA = "0x184537170")]
	public NBHGHIGJPON(EDDHMKHNMGO<AACMMOKMMHI<TItemId>, TResult> DCFIKHJGEIB, TimeSpan EIOMDGEMACB, bool IGBCEAGPMJJ, [Optional] KCDOBEOKNFA JBGDKEJCOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5963140", Offset = "0x5961F40", VA = "0x185963140")]
	public Task<TResult> GKLCKCDKGAG(TItemId OPGJHIOADCK, int EBABNKEEAMD, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AACMMOKMMHI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId EAEOCAGCOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int IIIOIIELAKD;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x518C570", Offset = "0x518B370", VA = "0x18518C570")]
	public AACMMOKMMHI(TItemId NNHDOHLBMKN, int EBABNKEEAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ELNGDMDCDPF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid NOAOIACHJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> KBIGCNGAGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LJPHCNLDGIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface CGBPIBDHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int EEIBDCAMKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CFNEDOBFELP<TParam>(TParam HGMAIPELJHM);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ONDBMDOJBFO(Exception DNLEOFNAGNA);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ICHJIJHGMBH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class AEBKAMBBJPO<TResult> : CGBPIBDHJHD, ELNGDMDCDPF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> CFGBMPECECB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid NOAOIACHJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int EEIBDCAMKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> KBIGCNGAGGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5197960", Offset = "0x5196760", VA = "0x185197960", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5197A20", Offset = "0x5196820", VA = "0x185197A20")]
		public AEBKAMBBJPO(int IDDNMENKNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3222BE0", Offset = "0x32219E0", VA = "0x183222BE0", Slot = "5")]
		public bool CFNEDOBFELP<TParam>(TParam HGMAIPELJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x51979E0", Offset = "0x51967E0", VA = "0x1851979E0", Slot = "6")]
		public bool ONDBMDOJBFO(Exception DNLEOFNAGNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x51979A0", Offset = "0x51967A0", VA = "0x1851979A0", Slot = "7")]
		public bool ICHJIJHGMBH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string GMAJMECGMID = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, CGBPIBDHJHD> GCEDAIJLDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IJPADAEDIMJ FKKMEMLCBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool IFHDPNBCHME;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9790", Offset = "0x8BC8590", VA = "0x188BC9790")]
	public LJPHCNLDGIM([Optional] IJPADAEDIMJ FKKMEMLCBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9360", Offset = "0x8BC8160", VA = "0x188BC9360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA630", Offset = "0x3DD9430", VA = "0x183DDA630")]
	public ELNGDMDCDPF<TResult> ICLHAAGLOBH<TResult>(int HDFPHKEAMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA8D0", Offset = "0x3DD96D0", VA = "0x183DDA8D0")]
	public bool IOOFABJGBED<TResult>(Guid ECLLBKCDLFA, TResult MOBFLOHJOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9470", Offset = "0x8BC8270", VA = "0x188BC9470")]
	private void DBDLJHFIIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9360", Offset = "0x8BC8160", VA = "0x188BC9360")]
	private void DANBPNBPCJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9070", Offset = "0x8BC7E70", VA = "0x188BC9070")]
	private void BBDJMIKLJLB(int IDDNMENKNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9590", Offset = "0x8BC8390", VA = "0x188BC9590")]
	private void OGGCMNOHIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum PENBEPLOMPG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KKLLCJDDJIA<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HMJODMNJNKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int EILHHDLHKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int KEJPEPCCGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int FPJEGOCNFKG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HMJODMNJNKG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId EAEOCAGCOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int IIIOIIELAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public PENBEPLOMPG DGNOPKPAMJI;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2168F90", Offset = "0x2167D90", VA = "0x182168F90")]
	public KKLLCJDDJIA(TItemId NNHDOHLBMKN, int EBABNKEEAMD, PENBEPLOMPG MKPEOGPFEFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GAACCLIJPFF<TItemId, TResult> : PMKLNEKKLGH<KKLLCJDDJIA<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4FBC210", Offset = "0x4FBB010", VA = "0x184FBC210")]
	public GAACCLIJPFF(EDDHMKHNMGO<KKLLCJDDJIA<TItemId>, TResult> DCFIKHJGEIB, TimeSpan EIOMDGEMACB, [Optional] KCDOBEOKNFA JBGDKEJCOFK)
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

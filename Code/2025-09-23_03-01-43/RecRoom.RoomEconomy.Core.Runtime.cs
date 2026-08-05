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
public interface DNLMIGCBEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLOFEPHDLID(int OGAKHLCKCFG, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LLOFEPHDLID(TimeSpan DELFBDBODAO, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KKJDIEDCHFB : DNLMIGCBEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8D5D0D0", Offset = "0x8D5B6D0", VA = "0x188D5D0D0")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKJDIEDCHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8D5D140", Offset = "0x8D5B740", VA = "0x188D5D140", Slot = "4")]
	public Task LLOFEPHDLID(int OGAKHLCKCFG, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8D5D1A0", Offset = "0x8D5B7A0", VA = "0x188D5D1A0", Slot = "5")]
	public Task LLOFEPHDLID(TimeSpan DELFBDBODAO, CancellationToken PJCIHHKJKBP)
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
		[Cpp2IlInjected.Address(RVA = "0x8D5D200", Offset = "0x8D5B800", VA = "0x188D5D200", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFOFCAEHMCN : BKIFCIKINLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CKPHPANFDFP BDKJPMBBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EFPHEEEIEEN<bool> CKEHBENPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EFPHEEEIEEN<bool> IEOBCFHPKFN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GIDCHNOGIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CED0", Offset = "0x8D5B4D0", VA = "0x188D5CED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LELMCCCNFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CF90", Offset = "0x8D5B590", VA = "0x188D5CF90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8D5CF20", Offset = "0x8D5B520", VA = "0x188D5CF20")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	internal static void KHFEDOGILIL(NMNJFHODGJA JBBCAANONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8D5CFE0", Offset = "0x8D5B5E0", VA = "0x188D5CFE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFOFCAEHMCN([EDHLHMEHMKO(null)][NotNull] CKPHPANFDFP BDKJPMBBPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JKLLOLEKNFL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct MHIGKPPAFBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TRequest DJDLJHOEPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TaskCompletionSource<TResult> HIEJMMKGJPH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
		public MHIGKPPAFBN(TRequest KOKMGKHMMEE, TaskCompletionSource<TResult> HCLIHOMOOMM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CHLOFMFHNDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JKLLOLEKNFL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F89EA0", Offset = "0x6F884A0", VA = "0x186F89EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x46310A0", Offset = "0x462F6A0", VA = "0x1846310A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HGLGJJBEFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JKLLOLEKNFL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5162EA0", Offset = "0x51614A0", VA = "0x185162EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5163270", Offset = "0x5161870", VA = "0x185163270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IDEKNNIFCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JKLLOLEKNFL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x525B140", Offset = "0x5259740", VA = "0x18525B140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x525B5E0", Offset = "0x5259BE0", VA = "0x18525B5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OCBJICBAMOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JKLLOLEKNFL<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5B988E0", Offset = "0x5B96EE0", VA = "0x185B988E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B99A00", Offset = "0x5B98000", VA = "0x185B99A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DOHAOLLPCEF<TRequest, TResult> FMMHOMEAHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly float BDHIAEAFJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DNLMIGCBEIM LIKEKMCHKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly bool BCOMHAPIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly List<MHIGKPPAFBN> AAKIGPAAHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly List<MHIGKPPAFBN> DALEFAJBOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool JOMCPLJEKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource BFFKAAOFENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource MNLCDPBKBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task JKAKBPMPDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float MEAFECCOAEO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA5580", Offset = "0xAA3B80", VA = "0x180AA5580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA55D0", Offset = "0xAA3BD0", VA = "0x180AA55D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x54EB260", Offset = "0x54E9860", VA = "0x1854EB260")]
	public JKLLOLEKNFL(DOHAOLLPCEF<TRequest, TResult> FMMHOMEAHGO, TimeSpan BDHIAEAFJFA, bool BCOMHAPIKLO, [Optional] DNLMIGCBEIM LIKEKMCHKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x54EAC20", Offset = "0x54E9220", VA = "0x1854EAC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x54EA850", Offset = "0x54E8E50", VA = "0x1854EA850")]
	[AsyncStateMachine(typeof(JKLLOLEKNFL<, >.CHLOFMFHNDF))]
	public Task<TResult> AJDKHGEFNAH(TRequest KOKMGKHMMEE, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x54EA7C0", Offset = "0x54E8DC0", VA = "0x1854EA7C0")]
	private void AJDKHGEFNAH(TRequest KOKMGKHMMEE, TaskCompletionSource<TResult> HCLIHOMOOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x54EAED0", Offset = "0x54E94D0", VA = "0x1854EAED0")]
	public Task JHEHCJGBNOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x54EB180", Offset = "0x54E9780", VA = "0x1854EB180")]
	[AsyncStateMachine(typeof(JKLLOLEKNFL<, >.HGLGJJBEFIE))]
	private Task PGBIOPAOGPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x54EB060", Offset = "0x54E9660", VA = "0x1854EB060")]
	[AsyncStateMachine(typeof(JKLLOLEKNFL<, >.IDEKNNIFCDH))]
	private Task OEMKLEEHOIB(CancellationToken CNACCENKOAL, CancellationToken EAGLLIHGAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x54EAB20", Offset = "0x54E9120", VA = "0x1854EAB20")]
	[AsyncStateMachine(typeof(JKLLOLEKNFL<, >.OCBJICBAMOH))]
	private Task DMAGFEOENFO(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x54EAF90", Offset = "0x54E9590", VA = "0x1854EAF90")]
	private TimeSpan LOGGDCGNMPF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54EA970", Offset = "0x54E8F70", VA = "0x1854EA970")]
	private Task<List<TResult>> AOGBKKDHMGM(IReadOnlyList<TRequest> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x54EAA80", Offset = "0x54E9080", VA = "0x1854EAA80")]
	private float DIHNIAHJDPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54EAE40", Offset = "0x54E9440", VA = "0x1854EAE40")]
	private void HNMOLIADBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGMPLOEBNDE<TItemId, TResult> : DOHAOLLPCEF<NIAMOINKFBN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> KOMLOMJAFEC(Dictionary<TItemId, int> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NABHKAKDIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NABHKAKDIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5A68B40", Offset = "0x5A67140", VA = "0x185A68B40")]
		internal TResult HLKPKPNEEHA(NIAMOINKFBN<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KHHIEBOFLDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public IReadOnlyList<NIAMOINKFBN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JGMPLOEBNDE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NABHKAKDIJG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x56766F0", Offset = "0x5674CF0", VA = "0x1856766F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5677440", Offset = "0x5675A40", VA = "0x185677440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly KOMLOMJAFEC IHJLMKJCODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly IEqualityComparer<TItemId> HPIFCOACPPF;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52A81E0", Offset = "0x52A67E0", VA = "0x1852A81E0")]
	public JGMPLOEBNDE(KOMLOMJAFEC IHJLMKJCODF, [Optional] IEqualityComparer<TItemId> HPIFCOACPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x54C2E40", Offset = "0x54C1440", VA = "0x1854C2E40", Slot = "4")]
	[AsyncStateMachine(typeof(JGMPLOEBNDE<, >.KHHIEBOFLDE))]
	public Task<List<TResult>> FHIBACLBLDK(IReadOnlyList<NIAMOINKFBN<TItemId>> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IOHONIPDFKF<TRequest, TResult> : DOHAOLLPCEF<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> EJLGDCPIEBB(IEnumerable<TRequest> NPCGIBIOHAD, CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class CHGBCENKENP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CHGBCENKENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x46494C0", Offset = "0x4647AC0", VA = "0x1846494C0")]
		internal TResult HLKPKPNEEHA(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct JDIKKAHNJCO : IAsyncStateMachine
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
		public IOHONIPDFKF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CHGBCENKENP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54B9D30", Offset = "0x54B8330", VA = "0x1854B9D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x54BAB60", Offset = "0x54B9160", VA = "0x1854BAB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly EJLGDCPIEBB IHJLMKJCODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly IEqualityComparer<TRequest> HPIFCOACPPF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x52A81E0", Offset = "0x52A67E0", VA = "0x1852A81E0")]
	public IOHONIPDFKF(EJLGDCPIEBB IHJLMKJCODF, [Optional] IEqualityComparer<TRequest> HPIFCOACPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x52A8090", Offset = "0x52A6690", VA = "0x1852A8090", Slot = "4")]
	[AsyncStateMachine(typeof(IOHONIPDFKF<, >.JDIKKAHNJCO))]
	public Task<List<TResult>> FHIBACLBLDK(IReadOnlyList<TRequest> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DOHAOLLPCEF<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> FHIBACLBLDK(IReadOnlyList<TRequest> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EEOGLHMDAJD<TItemId, TResult> : DOHAOLLPCEF<CDGPHFBMJAK<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate Task OGLJJBPDOBC(IReadOnlyDictionary<TItemId, CDGPHFBMJAK<TItemId>.IOAAJONDLEJ> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MLFPHDHEDPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EEOGLHMDAJD<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<CDGPHFBMJAK<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5A1BBD0", Offset = "0x5A1A1D0", VA = "0x185A1BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C100", Offset = "0x5A1A700", VA = "0x185A1C100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OGLJJBPDOBC NPJJBOPICNA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public EEOGLHMDAJD(OGLJJBPDOBC NPJJBOPICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4B32E20", Offset = "0x4B31420", VA = "0x184B32E20", Slot = "4")]
	[AsyncStateMachine(typeof(EEOGLHMDAJD<, >.MLFPHDHEDPA))]
	public Task<List<object>> FHIBACLBLDK(IReadOnlyList<CDGPHFBMJAK<TItemId>> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B32F60", Offset = "0x4B31560", VA = "0x184B32F60")]
	private IReadOnlyDictionary<TItemId, CDGPHFBMJAK<TItemId>.IOAAJONDLEJ> LCONHBPELON(IReadOnlyList<CDGPHFBMJAK<TItemId>> FNOKOKELDFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CMMDHJPGKEE<TItemId, TResult> : DOHAOLLPCEF<NIAMOINKFBN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate Task<Dictionary<TItemId, TResult>> GMLMMIMIHPB(Dictionary<TItemId, int> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct JMGHFDKIECJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IReadOnlyList<NIAMOINKFBN<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CMMDHJPGKEE<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x54FD890", Offset = "0x54FBE90", VA = "0x1854FD890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x54FF190", Offset = "0x54FD790", VA = "0x1854FF190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly GMLMMIMIHPB HOKJNLAFBMM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public CMMDHJPGKEE(GMLMMIMIHPB IHJLMKJCODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x702D0C0", Offset = "0x702B6C0", VA = "0x18702D0C0", Slot = "4")]
	[AsyncStateMachine(typeof(CMMDHJPGKEE<, >.JMGHFDKIECJ))]
	public Task<List<TResult>> FHIBACLBLDK(IReadOnlyList<NIAMOINKFBN<TItemId>> IMIEBDIIGMK, CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HGMDDLIBIOL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Dictionary<string, BBGBKPDDAHI> EGEGHIJABJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<T> KPHFDCFHKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private Func<IEnumerable<T>> KIGFKPEOLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private Func<T, string> CICGDHLDBGI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<string, BBGBKPDDAHI> OIIOPLDMODP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<T> INOICBACEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NODMPDGOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51635C0", Offset = "0x5161BC0", VA = "0x1851635C0")]
	public HGMDDLIBIOL(Func<IEnumerable<T>> KIGFKPEOLDN, Func<T, string> CICGDHLDBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5163340", Offset = "0x5161940", VA = "0x185163340")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51632D0", Offset = "0x51618D0", VA = "0x1851632D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GGMAPPNKLCP<TItemId, TResult> : JKLLOLEKNFL<NIAMOINKFBN<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50ACE00", Offset = "0x50AB400", VA = "0x1850ACE00")]
	public GGMAPPNKLCP(DOHAOLLPCEF<NIAMOINKFBN<TItemId>, TResult> FMMHOMEAHGO, TimeSpan BDHIAEAFJFA, bool BCOMHAPIKLO, [Optional] DNLMIGCBEIM LIKEKMCHKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x50F2800", Offset = "0x50F0E00", VA = "0x1850F2800")]
	public Task<TResult> AJDKHGEFNAH(TItemId HAELBKGFDIJ, int CJHNGJDMKKM, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NIAMOINKFBN<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public TItemId PMDKEPHHPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BICOFIPDIII;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A873F0", Offset = "0x5A859F0", VA = "0x185A873F0")]
	public NIAMOINKFBN(TItemId KJFLPEAFAHF, int CJHNGJDMKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface MGJFONGADMM<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Guid NJMGOHKHIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Task<TResult> AMJAFCCCCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ABMKCEAPLOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private interface PMBPBMEKFCD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		int PHHEDFPIBEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NLJLNFAOFPJ<TParam>(TParam KOPHBHGIACG);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NKBFLIJODDK(Exception MFJLILBLNGK);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NOADHNHCLKD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private class BNHOKMOFAAF<TResult> : PMBPBMEKFCD, MGJFONGADMM<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly TaskCompletionSource<TResult> OHMKJGBLDPI;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Guid NJMGOHKHIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int PHHEDFPIBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Task<TResult> AMJAFCCCCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5A5F7B0", Offset = "0x5A5DDB0", VA = "0x185A5F7B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD400", Offset = "0x6BCBA00", VA = "0x186BCD400")]
		public BNHOKMOFAAF(int EOPFIGJCLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3F32090", Offset = "0x3F30690", VA = "0x183F32090", Slot = "5")]
		public bool NLJLNFAOFPJ<TParam>(TParam KOPHBHGIACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD380", Offset = "0x6BCB980", VA = "0x186BCD380", Slot = "6")]
		public bool NKBFLIJODDK(Exception MFJLILBLNGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BCD3C0", Offset = "0x6BCB9C0", VA = "0x186BCD3C0", Slot = "7")]
		public bool NOADHNHCLKD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const string EPJACJOCECI = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<Guid, PMBPBMEKFCD> NLPDCKLADBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BLNFFCEJHPB MGCKCEBPNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool PHJGKLDFCPA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8D5CDD0", Offset = "0x8D5B3D0", VA = "0x188D5CDD0")]
	public ABMKCEAPLOF([Optional] BLNFFCEJHPB MGCKCEBPNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D5C6B0", Offset = "0x8D5ACB0", VA = "0x188D5C6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x32CFA70", Offset = "0x32CE070", VA = "0x1832CFA70")]
	public MGJFONGADMM<TResult> BEOEAIKJGCC<TResult>(int CCEEPILLHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32CFD10", Offset = "0x32CE310", VA = "0x1832CFD10")]
	public bool FJJDGGMKMHE<TResult>(Guid KBIKPAMBBCL, TResult FAKHJBCPGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8D5CAB0", Offset = "0x8D5B0B0", VA = "0x188D5CAB0")]
	private void OBOHEKMAIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8D5C6B0", Offset = "0x8D5ACB0", VA = "0x188D5C6B0")]
	private void MMINPOCMMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8D5C7C0", Offset = "0x8D5ADC0", VA = "0x188D5C7C0")]
	private void KCCLEBKOKNN(int EOPFIGJCLAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8D5CBD0", Offset = "0x8D5B1D0", VA = "0x188D5CBD0")]
	private void PJBLEOKDDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KDNBDKFDELH
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CDGPHFBMJAK<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class IOAAJONDLEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int GJIOIMOOHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int NILNKIGCFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int DNNEPFMIOJM;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public IOAAJONDLEJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public TItemId PMDKEPHHPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BICOFIPDIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public KDNBDKFDELH KOOACNAHBON;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x21D6820", Offset = "0x21D4E20", VA = "0x1821D6820")]
	public CDGPHFBMJAK(TItemId KJFLPEAFAHF, int CJHNGJDMKKM, KDNBDKFDELH NGOJMGCIOHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AEHNHAJPGGP<TItemId, TResult> : JKLLOLEKNFL<CDGPHFBMJAK<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x540A670", Offset = "0x5408C70", VA = "0x18540A670")]
	public AEHNHAJPGGP(DOHAOLLPCEF<CDGPHFBMJAK<TItemId>, TResult> FMMHOMEAHGO, TimeSpan BDHIAEAFJFA, [Optional] DNLMIGCBEIM LIKEKMCHKOI)
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

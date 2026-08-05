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
public interface OEDFMHHPAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MBAEKJLEPBC(int BGBBFMBMDMM, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MBAEKJLEPBC(TimeSpan FJOLAKJBFEA, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DHJGMAKIBCO : OEDFMHHPAEH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F33140", Offset = "0x6F31D40", VA = "0x186F33140")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.GameOnly)]
	private static void JAPOJOAJPPN(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	[Preserve]
	public DHJGMAKIBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F33230", Offset = "0x6F31E30", VA = "0x186F33230", Slot = "4")]
	public Task MBAEKJLEPBC(int BGBBFMBMDMM, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F33290", Offset = "0x6F31E90", VA = "0x186F33290", Slot = "5")]
	public Task MBAEKJLEPBC(TimeSpan FJOLAKJBFEA, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OLDGMPHPPBO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct LCKFEOIEACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest OGMGOFGAPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> ANEDJODEHMN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
		public LCKFEOIEACA(TRequest CLBGLGJCBEB, TaskCompletionSource<TResult> LDHFNFOBHGO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FECPFOAAIJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public OLDGMPHPPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3B96C70", Offset = "0x3B95870", VA = "0x183B96C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B971D0", Offset = "0x3B95DD0", VA = "0x183B971D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IEGIGOOMNFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public OLDGMPHPPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E24E40", Offset = "0x3E23A40", VA = "0x183E24E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E25220", Offset = "0x3E23E20", VA = "0x183E25220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BKLDIGEOLBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OLDGMPHPPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4E5FA80", Offset = "0x4E5E680", VA = "0x184E5FA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4E5FF30", Offset = "0x4E5EB30", VA = "0x184E5FF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct DJENJFFNODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OLDGMPHPPBO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x57DCF90", Offset = "0x57DBB90", VA = "0x1857DCF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x57DDFA0", Offset = "0x57DCBA0", VA = "0x1857DDFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DFCBKCJNNJG<TRequest, TResult> DIKFOEAJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float LELJOJDGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OEDFMHHPAEH JBDGBIMPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<LCKFEOIEACA> BAGHCONHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource FMCMEFFIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource JKIBCMIBPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task OKGHNNDGFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float GFJEDDFDGKO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC418F0", Offset = "0xC404F0", VA = "0x180C418F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC418E0", Offset = "0xC404E0", VA = "0x180C418E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45BF100", Offset = "0x45BDD00", VA = "0x1845BF100")]
	public OLDGMPHPPBO(DFCBKCJNNJG<TRequest, TResult> DIKFOEAJGIK, TimeSpan LELJOJDGAJG, [Optional] OEDFMHHPAEH JBDGBIMPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x45BE8B0", Offset = "0x45BD4B0", VA = "0x1845BE8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x45BEDA0", Offset = "0x45BD9A0", VA = "0x1845BEDA0")]
	[AsyncStateMachine(typeof(OLDGMPHPPBO<, >.FECPFOAAIJG))]
	public Task<TResult> LCFJNLGKEEK(TRequest CLBGLGJCBEB, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x45BE6D0", Offset = "0x45BD2D0", VA = "0x1845BE6D0")]
	public Task BHGHIJEDBOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x45BEBF0", Offset = "0x45BD7F0", VA = "0x1845BEBF0")]
	[AsyncStateMachine(typeof(OLDGMPHPPBO<, >.IEGIGOOMNFK))]
	private Task HLOJHBKNIHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x45BEAD0", Offset = "0x45BD6D0", VA = "0x1845BEAD0")]
	[AsyncStateMachine(typeof(OLDGMPHPPBO<, >.BKLDIGEOLBK))]
	private Task EOKHCGPLLGF(CancellationToken MFNPNFNALBD, CancellationToken FDNANFOKIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45BF000", Offset = "0x45BDC00", VA = "0x1845BF000")]
	[AsyncStateMachine(typeof(OLDGMPHPPBO<, >.DJENJFFNODF))]
	private Task PCLCEEMNNJL(CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x45BECC0", Offset = "0x45BD8C0", VA = "0x1845BECC0")]
	private TimeSpan JHKPHPKLKAI()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x45BE790", Offset = "0x45BD390", VA = "0x1845BE790")]
	private Task<List<TResult>> DJLJFBFFHLC(IReadOnlyList<TRequest> KNDHKFBIBCF, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45BEF60", Offset = "0x45BDB60", VA = "0x1845BEF60")]
	private float NDPMHNNLIKP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45BEEC0", Offset = "0x45BDAC0", VA = "0x1845BEEC0")]
	private void LCJOHMPLHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LGFDHJIIFCI<TItemId, TResult> : DFCBKCJNNJG<FNEAFJMAMMP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> GDILGBGGFFO(Dictionary<TItemId, int> KNDHKFBIBCF, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MHGIJDGPAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MHGIJDGPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x43F91B0", Offset = "0x43F7DB0", VA = "0x1843F91B0")]
		internal TResult PGJNEPLJOHO(FNEAFJMAMMP<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CLNAMMJODPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<FNEAFJMAMMP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LGFDHJIIFCI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MHGIJDGPAFG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x53769F0", Offset = "0x53755F0", VA = "0x1853769F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5377750", Offset = "0x5376350", VA = "0x185377750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly GDILGBGGFFO DOPLEOLABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> DPJNHLBPBGL;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41F6890", Offset = "0x41F5490", VA = "0x1841F6890")]
	public LGFDHJIIFCI(GDILGBGGFFO DOPLEOLABDN, [Optional] IEqualityComparer<TItemId> DPJNHLBPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41F6740", Offset = "0x41F5340", VA = "0x1841F6740", Slot = "4")]
	[AsyncStateMachine(typeof(LGFDHJIIFCI<, >.CLNAMMJODPN))]
	public Task<List<TResult>> KNGKNNHEEFL(IReadOnlyList<FNEAFJMAMMP<TItemId>> KNDHKFBIBCF, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKFFBPHNGMH<TRequest, TResult> : DFCBKCJNNJG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> DJCOAHPEGLO(IEnumerable<TRequest> LAJEGKNFMCP, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class ODMPPKLCBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ODMPPKLCBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C683A0", Offset = "0x3C66FA0", VA = "0x183C683A0")]
		internal TResult PGJNEPLJOHO(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JDFKAFMMDBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CKFFBPHNGMH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ODMPPKLCBFE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4017DF0", Offset = "0x40169F0", VA = "0x184017DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4018C50", Offset = "0x4017850", VA = "0x184018C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DJCOAHPEGLO DOPLEOLABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> DPJNHLBPBGL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x41F6890", Offset = "0x41F5490", VA = "0x1841F6890")]
	public CKFFBPHNGMH(DJCOAHPEGLO DOPLEOLABDN, [Optional] IEqualityComparer<TRequest> DPJNHLBPBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x529E010", Offset = "0x529CC10", VA = "0x18529E010", Slot = "4")]
	[AsyncStateMachine(typeof(CKFFBPHNGMH<, >.JDFKAFMMDBH))]
	public Task<List<TResult>> KNGKNNHEEFL(IReadOnlyList<TRequest> KNDHKFBIBCF, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DFCBKCJNNJG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> KNGKNNHEEFL(IReadOnlyList<TRequest> KNDHKFBIBCF, CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JMNOIFPOHCA<TItemId, TResult> : DFCBKCJNNJG<JFFMIIKILOO<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task JOBBHLLDGAA(IReadOnlyDictionary<TItemId, JFFMIIKILOO<TItemId>.NNDDLCFLDGL> KNDHKFBIBCF, CancellationToken MPLCHGMFENA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct EEDOAOIJONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public JMNOIFPOHCA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<JFFMIIKILOO<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x37B2C80", Offset = "0x37B1880", VA = "0x1837B2C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x37B31E0", Offset = "0x37B1DE0", VA = "0x1837B31E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JOBBHLLDGAA PPNEGIFLJJF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public JMNOIFPOHCA(JOBBHLLDGAA PPNEGIFLJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4076940", Offset = "0x4075540", VA = "0x184076940", Slot = "4")]
	[AsyncStateMachine(typeof(JMNOIFPOHCA<, >.EEDOAOIJONH))]
	public Task<List<object>> KNGKNNHEEFL(IReadOnlyList<JFFMIIKILOO<TItemId>> KNDHKFBIBCF, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40764D0", Offset = "0x40750D0", VA = "0x1840764D0")]
	private IReadOnlyDictionary<TItemId, JFFMIIKILOO<TItemId>.NNDDLCFLDGL> KEBMMLAFNBP(IReadOnlyList<JFFMIIKILOO<TItemId>> AJPCCJOCJAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GJAIPMOKGAJ<TItemId, TResult> : DFCBKCJNNJG<FNEAFJMAMMP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> ELBFLOIOBDI(Dictionary<TItemId, int> KNDHKFBIBCF, CancellationToken MPLCHGMFENA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KGHBIFAGAOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<FNEAFJMAMMP<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public GJAIPMOKGAJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x414B880", Offset = "0x414A480", VA = "0x18414B880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x414C540", Offset = "0x414B140", VA = "0x18414C540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ELBFLOIOBDI JJJMNCPBNAF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public GJAIPMOKGAJ(ELBFLOIOBDI DOPLEOLABDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA6EC0", Offset = "0x3CA5AC0", VA = "0x183CA6EC0", Slot = "4")]
	[AsyncStateMachine(typeof(GJAIPMOKGAJ<, >.KGHBIFAGAOF))]
	public Task<List<TResult>> KNGKNNHEEFL(IReadOnlyList<FNEAFJMAMMP<TItemId>> KNDHKFBIBCF, CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PKHKIEILJGB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, EJFDDCNOMKE> KKFABGMDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> OFPICJJPKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> OHKENNDDMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> HFHOLKCHCKI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, EJFDDCNOMKE> JEPDEBGDLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> DHFIKDLLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DILMMEJAEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9C0", Offset = "0x8B95C0", VA = "0x1808BA9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4779240", Offset = "0x4777E40", VA = "0x184779240")]
	public PKHKIEILJGB(Func<IEnumerable<T>> OHKENNDDMNM, Func<T, string> HFHOLKCHCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4778F80", Offset = "0x4777B80", VA = "0x184778F80")]
	public void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4778EF0", Offset = "0x4777AF0", VA = "0x184778EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HDFEPOMLEIO<TItemId, TResult> : OLDGMPHPPBO<FNEAFJMAMMP<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3806530", Offset = "0x3805130", VA = "0x183806530")]
	public HDFEPOMLEIO(DFCBKCJNNJG<FNEAFJMAMMP<TItemId>, TResult> DIKFOEAJGIK, TimeSpan LELJOJDGAJG, [Optional] OEDFMHHPAEH JBDGBIMPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D242C0", Offset = "0x3D22EC0", VA = "0x183D242C0")]
	public Task<TResult> LCFJNLGKEEK(TItemId DPHIOKCFMFC, int NEFBLEELBHL, [Optional] CancellationToken MPLCHGMFENA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FNEAFJMAMMP<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId GJGGDAACDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int MHNGMJKHICJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2CF0", Offset = "0x3BD18F0", VA = "0x183BD2CF0")]
	public FNEAFJMAMMP(TItemId MAIKDEFIPIK, int NEFBLEELBHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JGHHPMKFCNF<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid JIMBGNGJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> PEBBJOKIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class BEICMLBDMJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface PHOPFFIDOPH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int ACJMNGLGCBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MFKGMIEKGCH<TParam>(TParam GLMEMJNJKAN);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LFNNBBIPNEO(Exception INCJNHFIGKH);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool HIPNEIIDPKB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class HEIFENIMKMJ<TResult> : PHOPFFIDOPH, JGHHPMKFCNF<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> CNBGHAGBAKF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid JIMBGNGJJOB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int ACJMNGLGCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> PEBBJOKIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3D305C0", Offset = "0x3D2F1C0", VA = "0x183D305C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D306B0", Offset = "0x3D2F2B0", VA = "0x183D306B0")]
		public HEIFENIMKMJ(int MDADDLMCGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2814D50", Offset = "0x2813950", VA = "0x182814D50", Slot = "5")]
		public bool MFKGMIEKGCH<TParam>(TParam GLMEMJNJKAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3D30660", Offset = "0x3D2F260", VA = "0x183D30660", Slot = "6")]
		public bool LFNNBBIPNEO(Exception INCJNHFIGKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D30610", Offset = "0x3D2F210", VA = "0x183D30610", Slot = "7")]
		public bool HIPNEIIDPKB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string FMBAMEBJEEJ = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, PHOPFFIDOPH> KNNOPALKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BKGBPBCEHFE PJICJBNNMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool JJIPNEMBDOI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F33070", Offset = "0x6F31C70", VA = "0x186F33070")]
	public BEICMLBDMJJ([Optional] BKGBPBCEHFE PJICJBNNMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E40", Offset = "0x6F31A40", VA = "0x186F32E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2883B40", Offset = "0x2882740", VA = "0x182883B40")]
	public JGHHPMKFCNF<TResult> LOJHEFDPPFI<TResult>(int OBPJPKFLGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28837D0", Offset = "0x28823D0", VA = "0x1828837D0")]
	public bool CHPABFLBDAL<TResult>(Guid AMMGFMLLGCP, TResult JFBAIGMLPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F32F50", Offset = "0x6F31B50", VA = "0x186F32F50")]
	private void IJECBDDAPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F32E40", Offset = "0x6F31A40", VA = "0x186F32E40")]
	private void PADBPFINPKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F32B60", Offset = "0x6F31760", VA = "0x186F32B60")]
	private void BJKNGPKFNHI(int MDADDLMCGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F32960", Offset = "0x6F31560", VA = "0x186F32960")]
	private void BGBPIHGNNDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum POANCHEDHEL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JFFMIIKILOO<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class NNDDLCFLDGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int FFDMJGJDEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int OCELELDODCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int BNPINFMEIKA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NNDDLCFLDGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId GJGGDAACDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int MHNGMJKHICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public POANCHEDHEL IPIJKGMPMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x10C28A0", Offset = "0x10C14A0", VA = "0x1810C28A0")]
	public JFFMIIKILOO(TItemId MAIKDEFIPIK, int NEFBLEELBHL, POANCHEDHEL OGOLDJHPDFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EKDJJCHDMEA<TItemId, TResult> : OLDGMPHPPBO<JFFMIIKILOO<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3806530", Offset = "0x3805130", VA = "0x183806530")]
	public EKDJJCHDMEA(DFCBKCJNNJG<JFFMIIKILOO<TItemId>, TResult> DIKFOEAJGIK, TimeSpan LELJOJDGAJG, [Optional] OEDFMHHPAEH JBDGBIMPHLN)
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

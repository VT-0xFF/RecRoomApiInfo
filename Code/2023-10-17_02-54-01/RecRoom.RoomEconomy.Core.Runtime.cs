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
public interface JKAJPBDOKIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MADNADHGNJK(TimeSpan JPBJIDBLHPK, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MMFGHFPCCIF : JKAJPBDOKIO
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6238DF0", Offset = "0x62375F0", VA = "0x186238DF0")]
	[NJKKEFDLCAD(CEDKDBJGKHF.Root, AFMDLPKJFNK.GameOnly)]
	private static void DIEHNCAGMLG(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	[Preserve]
	public MMFGHFPCCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6238EF0", Offset = "0x62376F0", VA = "0x186238EF0", Slot = "4")]
	public Task MADNADHGNJK(TimeSpan JPBJIDBLHPK, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AINCPGBHGOL<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId FBBHLIJFNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int CPMJACKOGIF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351D1E0", VA = "0x18351E9E0")]
	public AINCPGBHGOL(TItemId BOJBMGIELFK, int BIJJKKCJEJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GOFIMAPOKLP<TItemId, TResult> : EKCNMDOCMJF<AINCPGBHGOL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3505AA0", Offset = "0x35042A0", VA = "0x183505AA0")]
	public GOFIMAPOKLP(CCLEMELLKGI<AINCPGBHGOL<TItemId>, TResult> NHNFJFDPLGM, TimeSpan DGPPADEHNOC, [Optional] JKAJPBDOKIO CAFICNMOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3505940", Offset = "0x3504140", VA = "0x183505940")]
	public Task<TResult> CGAODEEIAFC(TItemId OHPCNPKOLBJ, int BIJJKKCJEJB, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EKCNMDOCMJF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct JJOAMFBNHJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest FHGPLMACHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> BKHHJKBGFML;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3540", Offset = "0x7F1D40", VA = "0x1807F3540")]
		public JJOAMFBNHJL(TRequest LJEEHJLDFLC, TaskCompletionSource<TResult> PBJEENFPOAA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MDNHHCEIKGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EKCNMDOCMJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAE60", Offset = "0x3AE9660", VA = "0x183AEAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB360", Offset = "0x3AE9B60", VA = "0x183AEB360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PKEPNJIAJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public EKCNMDOCMJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9C60", Offset = "0x3DB8460", VA = "0x183DB9C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA030", Offset = "0x3DB8830", VA = "0x183DBA030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OJPLAKGBHKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public EKCNMDOCMJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA4C0", Offset = "0x3CE8CC0", VA = "0x183CEA4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CEA960", Offset = "0x3CE9160", VA = "0x183CEA960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BGLPBKHIDNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public EKCNMDOCMJF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private List<TaskCompletionSource<TResult>> <taskCompletionSources>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x43F31B0", Offset = "0x43F19B0", VA = "0x1843F31B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x43F40F0", Offset = "0x43F28F0", VA = "0x1843F40F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CCLEMELLKGI<TRequest, TResult> NHNFJFDPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float DGPPADEHNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JKAJPBDOKIO CAFICNMOOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<JJOAMFBNHJL> DNNFAIHNCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource HDBHINOJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource LCJIKLJELLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task EAFODIFJCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float HLGMHEKJFFG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x990400", Offset = "0x98EC00", VA = "0x180990400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x990420", Offset = "0x98EC20", VA = "0x180990420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3075160", Offset = "0x3073960", VA = "0x183075160")]
	public EKCNMDOCMJF(CCLEMELLKGI<TRequest, TResult> NHNFJFDPLGM, TimeSpan DGPPADEHNOC, [Optional] JKAJPBDOKIO CAFICNMOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x30749A0", Offset = "0x30731A0", VA = "0x1830749A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3074880", Offset = "0x3073080", VA = "0x183074880")]
	[AsyncStateMachine(typeof(EKCNMDOCMJF<, >.MDNHHCEIKGF))]
	public Task<TResult> CGAODEEIAFC(TRequest LJEEHJLDFLC, [Optional] CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x30750A0", Offset = "0x30738A0", VA = "0x1830750A0")]
	public Task OHIPILEFPKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3074C50", Offset = "0x3073450", VA = "0x183074C50")]
	[AsyncStateMachine(typeof(EKCNMDOCMJF<, >.PKEPNJIAJOJ))]
	private Task GEEBEIKJCEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3074760", Offset = "0x3072F60", VA = "0x183074760")]
	[AsyncStateMachine(typeof(EKCNMDOCMJF<, >.OJPLAKGBHKP))]
	private Task CDFMDLICADM(CancellationToken MJNIHHDLIPK, CancellationToken BGFEKADNIDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3074FA0", Offset = "0x30737A0", VA = "0x183074FA0")]
	[AsyncStateMachine(typeof(EKCNMDOCMJF<, >.BGLPBKHIDNC))]
	private Task LIHNPFMJOIP(CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3074D30", Offset = "0x3073530", VA = "0x183074D30")]
	private TimeSpan HAIEJOMFODB()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3074E90", Offset = "0x3073690", VA = "0x183074E90")]
	private Task<List<TResult>> IBJPKJCCIGN(IReadOnlyList<TRequest> EKIKDOJOMMA, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3074BB0", Offset = "0x30733B0", VA = "0x183074BB0")]
	private float GCHLLANKBNI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3074E00", Offset = "0x3073600", VA = "0x183074E00")]
	private void HFDBPLNDPDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GKLCELCECJA<TItemId, TResult> : CCLEMELLKGI<AINCPGBHGOL<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> HIPCNBJFJIN(Dictionary<TItemId, int> EKIKDOJOMMA, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OHJGPNJPFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OHJGPNJPFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8170", Offset = "0x3CD6970", VA = "0x183CD8170")]
		internal TResult DBKFGNNIHMP(AINCPGBHGOL<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct LMCFGFGOIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<AINCPGBHGOL<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GKLCELCECJA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private OHJGPNJPFME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3925D20", Offset = "0x3924520", VA = "0x183925D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3926A70", Offset = "0x3925270", VA = "0x183926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HIPCNBJFJIN BBHKAJDDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> HAFCFDDDOOP;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30574F0", Offset = "0x3055CF0", VA = "0x1830574F0")]
	public GKLCELCECJA(HIPCNBJFJIN BBHKAJDDJPO, [Optional] IEqualityComparer<TItemId> HAFCFDDDOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34EC470", Offset = "0x34EAC70", VA = "0x1834EC470", Slot = "4")]
	[AsyncStateMachine(typeof(GKLCELCECJA<, >.LMCFGFGOIGG))]
	public Task<List<TResult>> AKJAIDFPBKO(IReadOnlyList<AINCPGBHGOL<TItemId>> EKIKDOJOMMA, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ECMECKPLHCA<TRequest, TResult> : CCLEMELLKGI<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> MHIBHMIJBGD(IEnumerable<TRequest> PENBIDLJKML, CancellationToken EHCFBFBFEDH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class MDFACAHLLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MDFACAHLLIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3069F70", Offset = "0x3068770", VA = "0x183069F70")]
		internal TResult DBKFGNNIHMP(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct NELKLEMFFEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IReadOnlyList<TRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public ECMECKPLHCA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private MDFACAHLLIC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF9A0", Offset = "0x3BAE1A0", VA = "0x183BAF9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3BB07D0", Offset = "0x3BAEFD0", VA = "0x183BB07D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MHIBHMIJBGD BBHKAJDDJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> HAFCFDDDOOP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x30574F0", Offset = "0x3055CF0", VA = "0x1830574F0")]
	public ECMECKPLHCA(MHIBHMIJBGD BBHKAJDDJPO, [Optional] IEqualityComparer<TRequest> HAFCFDDDOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30573A0", Offset = "0x3055BA0", VA = "0x1830573A0", Slot = "4")]
	[AsyncStateMachine(typeof(ECMECKPLHCA<, >.NELKLEMFFEO))]
	public Task<List<TResult>> AKJAIDFPBKO(IReadOnlyList<TRequest> EKIKDOJOMMA, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CCLEMELLKGI<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> AKJAIDFPBKO(IReadOnlyList<TRequest> EKIKDOJOMMA, CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GMEEGILEOJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Dictionary<string, NEJBAEMJEJI> KABKCABGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private List<T> OCKMILFKDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Func<IEnumerable<T>> JGAPADMGNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private Func<T, string> IEILOINFOKJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, NEJBAEMJEJI> MJKFOFNKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> LEPNBHGKCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PIJJLLLIGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80C0E0", Offset = "0x80A8E0", VA = "0x18080C0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3502490", Offset = "0x3500C90", VA = "0x183502490")]
	public GMEEGILEOJK(Func<IEnumerable<T>> JGAPADMGNMP, Func<T, string> IEILOINFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3502210", Offset = "0x3500A10", VA = "0x183502210")]
	public void IDAKBLNHKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EAJBEFBJLFH<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid DEPMDGOGFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> MFGAFCHJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OBJPGCCFKHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface MNDGMOAOALK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int NJOAFLJOCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OKCGFCMGLKN<TParam>(TParam FKKGMPDEPMA);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool MDEPELKEAEA(Exception KHOFKDAGHHN);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AKDKOKIGLCM();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class FAGCFKAGGMO<TResult> : MNDGMOAOALK, EAJBEFBJLFH<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly TaskCompletionSource<TResult> LPGJFJPDIDO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid DEPMDGOGFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int NJOAFLJOCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> MFGAFCHJCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x309E890", Offset = "0x309D090", VA = "0x18309E890", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x33ECE20", Offset = "0x33EB620", VA = "0x1833ECE20")]
		public FAGCFKAGGMO(int NHGKBDEKAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2158AE0", Offset = "0x21572E0", VA = "0x182158AE0", Slot = "5")]
		public bool OKCGFCMGLKN<TParam>(TParam FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x33ECDE0", Offset = "0x33EB5E0", VA = "0x1833ECDE0", Slot = "6")]
		public bool MDEPELKEAEA(Exception KHOFKDAGHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x33ECDA0", Offset = "0x33EB5A0", VA = "0x1833ECDA0", Slot = "7")]
		public bool AKDKOKIGLCM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public const string HMBOPHDLPHB = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly Dictionary<Guid, MNDGMOAOALK> KDONADJHADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly FHOALPAIEGP MOCIIBGHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool DPNACKLOKBK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6239670", Offset = "0x6237E70", VA = "0x186239670")]
	public OBJPGCCFKHC([Optional] FHOALPAIEGP MOCIIBGHCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6239070", Offset = "0x6237870", VA = "0x186239070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x24D5BD0", Offset = "0x24D43D0", VA = "0x1824D5BD0")]
	public EAJBEFBJLFH<TResult> LCFKDOAADKK<TResult>(int FDBHAPMGDOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x24D58A0", Offset = "0x24D40A0", VA = "0x1824D58A0")]
	public bool DNMPOODHDEO<TResult>(Guid BACFDICONIG, TResult KMHAEDONIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6238F50", Offset = "0x6237750", VA = "0x186238F50")]
	private void BGCBFFCPBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6239070", Offset = "0x6237870", VA = "0x186239070")]
	private void MDHDOKDKBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6239180", Offset = "0x6237980", VA = "0x186239180")]
	private void JHPNIJOOJAJ(int NHGKBDEKAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6239470", Offset = "0x6237C70", VA = "0x186239470")]
	private void PMKLAKANKPD()
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

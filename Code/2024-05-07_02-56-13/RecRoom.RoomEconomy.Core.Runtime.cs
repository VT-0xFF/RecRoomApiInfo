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
public interface CHONIMMCEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GCIEOODGKBB(int JADAPJGFJDM, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GCIEOODGKBB(TimeSpan FHPDAIHLKCN, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MFDNGMEGALG : CHONIMMCEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67D62A0", Offset = "0x67D54A0", VA = "0x1867D62A0")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	private static void NGACIPHKJFL(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	[Preserve]
	public MFDNGMEGALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67D61E0", Offset = "0x67D53E0", VA = "0x1867D61E0", Slot = "4")]
	public Task GCIEOODGKBB(int JADAPJGFJDM, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67D6240", Offset = "0x67D5440", VA = "0x1867D6240", Slot = "5")]
	public Task GCIEOODGKBB(TimeSpan FHPDAIHLKCN, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NAMOMHNGCBN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct GOOHMOMMGCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TRequest OAJPLADHDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TaskCompletionSource<TResult> DGABOMPDCKG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
		public GOOHMOMMGCH(TRequest AIJPHINHCJO, TaskCompletionSource<TResult> AFOILHIOOGC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FJAINOOLHAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public NAMOMHNGCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3803E00", Offset = "0x3803000", VA = "0x183803E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3804300", Offset = "0x3803500", VA = "0x183804300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct OLKFBDHDBNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NAMOMHNGCBN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x41B4B60", Offset = "0x41B3D60", VA = "0x1841B4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41B4F20", Offset = "0x41B4120", VA = "0x1841B4F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct HKPIHFAMKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NAMOMHNGCBN<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x39801F0", Offset = "0x397F3F0", VA = "0x1839801F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3980690", Offset = "0x397F890", VA = "0x183980690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CPNPHAOKHBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NAMOMHNGCBN<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x4C43330", Offset = "0x4C42530", VA = "0x184C43330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4C441B0", Offset = "0x4C433B0", VA = "0x184C441B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CHGIKILFFKF<TRequest, TResult> PDJLLIPDOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float ANMLCGGNDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CHONIMMCEHO JJMMJKKPFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly List<GOOHMOMMGCH> NFFCNGAENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource HKFEMAAMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource OMKJKODFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task DOCOEFNOCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private float INEKDIGHGIB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CBEJMOMNALI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB0A2E0", Offset = "0xB094E0", VA = "0x180B0A2E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB0A200", Offset = "0xB09400", VA = "0x180B0A200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6870", Offset = "0x3FE5A70", VA = "0x183FE6870")]
	public NAMOMHNGCBN(CHGIKILFFKF<TRequest, TResult> PDJLLIPDOBE, TimeSpan ANMLCGGNDDO, [Optional] CHONIMMCEHO JJMMJKKPFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6070", Offset = "0x3FE5270", VA = "0x183FE6070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5EB0", Offset = "0x3FE50B0", VA = "0x183FE5EB0")]
	[AsyncStateMachine(typeof(NAMOMHNGCBN<, >.FJAINOOLHAJ))]
	public Task<TResult> BBCBADJOKHF(TRequest AIJPHINHCJO, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3FE64C0", Offset = "0x3FE56C0", VA = "0x183FE64C0")]
	public Task JLFCLEAOOLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6360", Offset = "0x3FE5560", VA = "0x183FE6360")]
	[AsyncStateMachine(typeof(NAMOMHNGCBN<, >.OLKFBDHDBNF))]
	private Task GOHJIMPEPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6650", Offset = "0x3FE5850", VA = "0x183FE6650")]
	[AsyncStateMachine(typeof(NAMOMHNGCBN<, >.HKPIHFAMKJI))]
	private Task MBMOHKDJPEH(CancellationToken HHLBFLAPLBG, CancellationToken EHDHLDGFEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6770", Offset = "0x3FE5970", VA = "0x183FE6770")]
	[AsyncStateMachine(typeof(NAMOMHNGCBN<, >.CPNPHAOKHBO))]
	private Task OAILNDOPJAG(CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6580", Offset = "0x3FE5780", VA = "0x183FE6580")]
	private TimeSpan KMBCHCKNCJF()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6260", Offset = "0x3FE5460", VA = "0x183FE6260")]
	private Task<List<TResult>> FAHOOADPEFA(IReadOnlyList<TRequest> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5FD0", Offset = "0x3FE51D0", VA = "0x183FE5FD0")]
	private float DLGHFKKPMPD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3FE6430", Offset = "0x3FE5630", VA = "0x183FE6430")]
	private void HPOOIHGJDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HMCJCPABGFJ<TItemId, TResult> : CHGIKILFFKF<OMMGKAHFMLC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> AICGHNGKCIP(Dictionary<TItemId, int> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OFMPCFFAFGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public OFMPCFFAFGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4180E10", Offset = "0x4180010", VA = "0x184180E10")]
		internal TResult GNKFBBPFEIP(OMMGKAHFMLC<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MGOELHJJECO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public IReadOnlyList<OMMGKAHFMLC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public HMCJCPABGFJ<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private OFMPCFFAFGA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F5BF60", Offset = "0x3F5B160", VA = "0x183F5BF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F5CBE0", Offset = "0x3F5BDE0", VA = "0x183F5CBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly AICGHNGKCIP JACGFEMMFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly IEqualityComparer<TItemId> FDCJDIIBDAL;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x39226B0", Offset = "0x39218B0", VA = "0x1839226B0")]
	public HMCJCPABGFJ(AICGHNGKCIP JACGFEMMFOO, [Optional] IEqualityComparer<TItemId> FDCJDIIBDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3984B70", Offset = "0x3983D70", VA = "0x183984B70", Slot = "4")]
	[AsyncStateMachine(typeof(HMCJCPABGFJ<, >.MGOELHJJECO))]
	public Task<List<TResult>> BPFMBJDHKHG(IReadOnlyList<OMMGKAHFMLC<TItemId>> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HHHMNFFAHGL<TRequest, TResult> : CHGIKILFFKF<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> MFIBAIAAHNH(IEnumerable<TRequest> DJCOKOPMKGA, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PCAONJJKCKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PCAONJJKCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3815B40", Offset = "0x3814D40", VA = "0x183815B40")]
		internal TResult GNKFBBPFEIP(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct MAOCADDOGBC : IAsyncStateMachine
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
		public HHHMNFFAHGL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private PCAONJJKCKC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F43150", Offset = "0x3F42350", VA = "0x183F43150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F43EA0", Offset = "0x3F430A0", VA = "0x183F43EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MFIBAIAAHNH JACGFEMMFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IEqualityComparer<TRequest> FDCJDIIBDAL;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39226B0", Offset = "0x39218B0", VA = "0x1839226B0")]
	public HHHMNFFAHGL(MFIBAIAAHNH JACGFEMMFOO, [Optional] IEqualityComparer<TRequest> FDCJDIIBDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3922570", Offset = "0x3921770", VA = "0x183922570", Slot = "4")]
	[AsyncStateMachine(typeof(HHHMNFFAHGL<, >.MAOCADDOGBC))]
	public Task<List<TResult>> BPFMBJDHKHG(IReadOnlyList<TRequest> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CHGIKILFFKF<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> BPFMBJDHKHG(IReadOnlyList<TRequest> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class POOOAPDGEKC<TItemId, TResult> : CHGIKILFFKF<MAEBBEOEKOC<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task ELHMJDFAMLI(IReadOnlyDictionary<TItemId, MAEBBEOEKOC<TItemId>.HDBMNOEPDOI> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct JJPFMEEDMGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public POOOAPDGEKC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IReadOnlyList<MAEBBEOEKOC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3C22DC0", Offset = "0x3C21FC0", VA = "0x183C22DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3C232B0", Offset = "0x3C224B0", VA = "0x183C232B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ELHMJDFAMLI GMLFJOGEMKL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public POOOAPDGEKC(ELHMJDFAMLI GMLFJOGEMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x427C4C0", Offset = "0x427B6C0", VA = "0x18427C4C0", Slot = "4")]
	[AsyncStateMachine(typeof(POOOAPDGEKC<, >.JJPFMEEDMGP))]
	public Task<List<object>> BPFMBJDHKHG(IReadOnlyList<MAEBBEOEKOC<TItemId>> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x427C600", Offset = "0x427B800", VA = "0x18427C600")]
	private IReadOnlyDictionary<TItemId, MAEBBEOEKOC<TItemId>.HDBMNOEPDOI> IHKMFCPFGJG(IReadOnlyList<MAEBBEOEKOC<TItemId>> BJOBGMICEEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HJHHLJAFFEK<TItemId, TResult> : CHGIKILFFKF<OMMGKAHFMLC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> IAEINEOEMFJ(Dictionary<TItemId, int> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct KJGHGELLNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<OMMGKAHFMLC<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public HJHHLJAFFEK<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C96E40", Offset = "0x3C96040", VA = "0x183C96E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C98660", Offset = "0x3C97860", VA = "0x183C98660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IAEINEOEMFJ LOHGNBGMBFC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public HJHHLJAFFEK(IAEINEOEMFJ JACGFEMMFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x397D720", Offset = "0x397C920", VA = "0x18397D720", Slot = "4")]
	[AsyncStateMachine(typeof(HJHHLJAFFEK<, >.KJGHGELLNCH))]
	public Task<List<TResult>> BPFMBJDHKHG(IReadOnlyList<OMMGKAHFMLC<TItemId>> EKFGLAKJDMD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CKINALILFNL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, GNJHHMGGNHB> FMBDJDMPDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> KGINDIIAEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> FLDNHJFEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> PDBDPGCFHEF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GNJHHMGGNHB> GOJEENAOFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> PBDOFJDHNGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CCEOPFAIFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x822030", Offset = "0x821230", VA = "0x180822030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4C397F0", Offset = "0x4C389F0", VA = "0x184C397F0")]
	public CKINALILFNL(Func<IEnumerable<T>> FLDNHJFEAHA, Func<T, string> PDBDPGCFHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4C395A0", Offset = "0x4C387A0", VA = "0x184C395A0")]
	public void GKEPGFOADJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4C39530", Offset = "0x4C38730", VA = "0x184C39530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PCGCEOAGLPG<TItemId, TResult> : NAMOMHNGCBN<OMMGKAHFMLC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3FE7830", Offset = "0x3FE6A30", VA = "0x183FE7830")]
	public PCGCEOAGLPG(CHGIKILFFKF<OMMGKAHFMLC<TItemId>, TResult> PDJLLIPDOBE, TimeSpan ANMLCGGNDDO, [Optional] CHONIMMCEHO JJMMJKKPFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x425CFC0", Offset = "0x425C1C0", VA = "0x18425CFC0")]
	public Task<TResult> BBCBADJOKHF(TItemId GOBGGNLGONA, int FNNPIHCMBNJ, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OMMGKAHFMLC<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public TItemId DBJJIEJGDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int PMNFBEPNFJA;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x41C88A0", Offset = "0x41C7AA0", VA = "0x1841C88A0")]
	public OMMGKAHFMLC(TItemId NOMPOCCHJGN, int FNNPIHCMBNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FLNKDDCGAHK<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid BLNCNJHFIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> CLIFNBHGGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KIBNFFJNHHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface MNEIMLNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int IODNPKOJMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JFJFINENPLG<TParam>(TParam NICEPFIEJED);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DPGGGKKJDIP(Exception HBHCJPCIBAB);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LIIHFGKIDIP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class LPNJKBEAFAK<TResult> : MNEIMLNICPJ, FLNKDDCGAHK<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly TaskCompletionSource<TResult> MECAMIGLBGF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid BLNCNJHFIFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IODNPKOJMAN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> CLIFNBHGGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3D952A0", Offset = "0x3D944A0", VA = "0x183D952A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D95320", Offset = "0x3D94520", VA = "0x183D95320")]
		public LPNJKBEAFAK(int HIMIKOKNGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2583A00", Offset = "0x2582C00", VA = "0x182583A00", Slot = "5")]
		public bool JFJFINENPLG<TParam>(TParam NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3D95260", Offset = "0x3D94460", VA = "0x183D95260", Slot = "6")]
		public bool DPGGGKKJDIP(Exception HBHCJPCIBAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D952E0", Offset = "0x3D944E0", VA = "0x183D952E0", Slot = "7")]
		public bool LIIHFGKIDIP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const string CMLKJLJLEBK = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Dictionary<Guid, MNEIMLNICPJ> HEAMBPHNLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HGAPDLKMOEA FNFMBAJKACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool IFMGLKFIDBE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67D6110", Offset = "0x67D5310", VA = "0x1867D6110")]
	public KIBNFFJNHHK([Optional] HGAPDLKMOEA FNFMBAJKACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67D5EE0", Offset = "0x67D50E0", VA = "0x1867D5EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2978660", Offset = "0x2977860", VA = "0x182978660")]
	public FLNKDDCGAHK<TResult> BEKDJJODKLM<TResult>(int EBPHANDGOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2978900", Offset = "0x2977B00", VA = "0x182978900")]
	public bool HPHLNAEFIDF<TResult>(Guid FNMGFNFDGKE, TResult HCIDHCBMOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67D5FF0", Offset = "0x67D51F0", VA = "0x1867D5FF0")]
	private void EJHDPAGGPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67D5EE0", Offset = "0x67D50E0", VA = "0x1867D5EE0")]
	private void GCPJIOEOKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67D59F0", Offset = "0x67D4BF0", VA = "0x1867D59F0")]
	private void CIGAGEOIEIF(int HIMIKOKNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67D5CE0", Offset = "0x67D4EE0", VA = "0x1867D5CE0")]
	private void COEGNEOINAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum KBGKCNAFMOD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MAEBBEOEKOC<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class HDBMNOEPDOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int HMMNHIDDICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int FDOIJGNLPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int PNKPEANKNGL;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HDBMNOEPDOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public TItemId DBJJIEJGDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int PMNFBEPNFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public KBGKCNAFMOD CPILCLMNOLD;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xED5F60", Offset = "0xED5160", VA = "0x180ED5F60")]
	public MAEBBEOEKOC(TItemId NOMPOCCHJGN, int FNNPIHCMBNJ, KBGKCNAFMOD GBHPBJPAFFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CCMMBLFKMGA<TItemId, TResult> : NAMOMHNGCBN<MAEBBEOEKOC<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3FE7830", Offset = "0x3FE6A30", VA = "0x183FE7830")]
	public CCMMBLFKMGA(CHGIKILFFKF<MAEBBEOEKOC<TItemId>, TResult> PDJLLIPDOBE, TimeSpan ANMLCGGNDDO, [Optional] CHONIMMCEHO JJMMJKKPFLG)
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

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
public interface JCANKALNJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DPFNMEOKEKC(TimeSpan EOEJBJEEDAK, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JCOLKGEIINE : JCANKALNJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61F0DE0", Offset = "0x61EFBE0", VA = "0x1861F0DE0")]
	[DJDJPHIPNFL(KHJICKDGEOE.Root, IEJLPKKICHC.GameOnly)]
	private static void AIJFPABKFOK(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	[Preserve]
	public JCOLKGEIINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61F0EE0", Offset = "0x61EFCE0", VA = "0x1861F0EE0", Slot = "4")]
	public Task DPFNMEOKEKC(TimeSpan EOEJBJEEDAK, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HOIJBODBDFI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TItemId OAJMPOGCPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int FKMAKKLPPNP;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x35ED3D0", Offset = "0x35EC1D0", VA = "0x1835ED3D0")]
	public HOIJBODBDFI(TItemId ANFHIJCDLPI, int CIMPJDJAJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FKPPMACLDNM<TItemId, TResult> : DADOEGGBOAK<HOIJBODBDFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x304E510", Offset = "0x304D310", VA = "0x18304E510")]
	public FKPPMACLDNM(OMLHOHCLMIK<HOIJBODBDFI<TItemId>, TResult> HHFJGDCJHNK, TimeSpan HJLGNHEILED, [Optional] JCANKALNJNB GPGIINFNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x33BE280", Offset = "0x33BD080", VA = "0x1833BE280")]
	public Task<TResult> NPKABFEIKJB(TItemId GMOPMNAPKBE, int CIMPJDJAJLE, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DADOEGGBOAK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct IEFEANOAOLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public TRequest CAHADJIDPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TaskCompletionSource<TResult> GMFHHGOJENL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8680", Offset = "0x7E7480", VA = "0x1807E8680")]
		public IEFEANOAOLF(TRequest BHMKONDNBED, TaskCompletionSource<TResult> JFBLGHIEAAF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NAAJFNNBEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DADOEGGBOAK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCEB80", Offset = "0x3BCD980", VA = "0x183BCEB80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF080", Offset = "0x3BCDE80", VA = "0x183BCF080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AOFPHAHNODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DADOEGGBOAK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36E9C80", Offset = "0x36E8A80", VA = "0x1836E9C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x36EA050", Offset = "0x36E8E50", VA = "0x1836EA050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct PCFHDADHFNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DADOEGGBOAK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3D8EA80", Offset = "0x3D8D880", VA = "0x183D8EA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EF20", Offset = "0x3D8DD20", VA = "0x183D8EF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EHNEPFHHAHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DADOEGGBOAK<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3031D10", Offset = "0x3030B10", VA = "0x183031D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3032C50", Offset = "0x3031A50", VA = "0x183032C50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OMLHOHCLMIK<TRequest, TResult> HHFJGDCJHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly float HJLGNHEILED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JCANKALNJNB GPGIINFNDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<IEFEANOAOLF> HPENABFIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CancellationTokenSource JCFGJEGFMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CancellationTokenSource NIMFJKPDPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Task BAPEDHEKEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float NDMHMFKBHLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x999850", Offset = "0x998650", VA = "0x180999850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x999800", Offset = "0x998600", VA = "0x180999800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4C40450", Offset = "0x4C3F250", VA = "0x184C40450")]
	public DADOEGGBOAK(OMLHOHCLMIK<TRequest, TResult> HHFJGDCJHNK, TimeSpan HJLGNHEILED, [Optional] JCANKALNJNB GPGIINFNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FD00", Offset = "0x4C3EB00", VA = "0x184C3FD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4C40210", Offset = "0x4C3F010", VA = "0x184C40210")]
	[AsyncStateMachine(typeof(DADOEGGBOAK<, >.NAAJFNNBEDP))]
	public Task<TResult> NPKABFEIKJB(TRequest BHMKONDNBED, [Optional] CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FB30", Offset = "0x4C3E930", VA = "0x184C3FB30")]
	public Task CCJNBKKHNAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FA50", Offset = "0x4C3E850", VA = "0x184C3FA50")]
	[AsyncStateMachine(typeof(DADOEGGBOAK<, >.AOFPHAHNODI))]
	private Task APPKAOGJMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4C40330", Offset = "0x4C3F130", VA = "0x184C40330")]
	[AsyncStateMachine(typeof(DADOEGGBOAK<, >.PCFHDADHFNN))]
	private Task OKJIIFCJGGK(CancellationToken BIOHPJOIIFL, CancellationToken MNNBPBBBFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FF10", Offset = "0x4C3ED10", VA = "0x184C3FF10")]
	[AsyncStateMachine(typeof(DADOEGGBOAK<, >.EHNEPFHHAHH))]
	private Task GBDMOHAMBJB(CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C40140", Offset = "0x4C3EF40", VA = "0x184C40140")]
	private TimeSpan MMDINOCNBNE()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C3FBF0", Offset = "0x4C3E9F0", VA = "0x184C3FBF0")]
	private Task<List<TResult>> DOMABMMEFFO(IReadOnlyList<TRequest> FMNLMEECNNN, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C40010", Offset = "0x4C3EE10", VA = "0x184C40010")]
	private float JKNGDCHMEMB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4C400B0", Offset = "0x4C3EEB0", VA = "0x184C400B0")]
	private void KCMHIEKLPND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LEJHNHMLDEC<TItemId, TResult> : OMLHOHCLMIK<HOIJBODBDFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate Task<Dictionary<TItemId, TResult>> EKKEABLIKBD(Dictionary<TItemId, int> FMNLMEECNNN, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JJLPLAIFAJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JJLPLAIFAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3857080", Offset = "0x3855E80", VA = "0x183857080")]
		internal TResult ELMFOFBAPIL(HOIJBODBDFI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DMMFLGGOBEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public IReadOnlyList<HOIJBODBDFI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public LEJHNHMLDEC<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private JJLPLAIFAJN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4C96AB0", Offset = "0x4C958B0", VA = "0x184C96AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4C97800", Offset = "0x4C96600", VA = "0x184C97800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly EKKEABLIKBD BOJKKOPDFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IEqualityComparer<TItemId> GKEGMLFBEMI;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x353B8D0", Offset = "0x353A6D0", VA = "0x18353B8D0")]
	public LEJHNHMLDEC(EKKEABLIKBD BOJKKOPDFAK, [Optional] IEqualityComparer<TItemId> GKEGMLFBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x397B1F0", Offset = "0x3979FF0", VA = "0x18397B1F0", Slot = "4")]
	[AsyncStateMachine(typeof(LEJHNHMLDEC<, >.DMMFLGGOBEB))]
	public Task<List<TResult>> OIAOBCBGLNP(IReadOnlyList<HOIJBODBDFI<TItemId>> FMNLMEECNNN, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LIKHBENNIFH<TRequest, TResult> : OMLHOHCLMIK<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate Task<List<TResult>> KAPMGBPELIJ(IEnumerable<TRequest> EMNBDONELCI, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FKHIJCDPKEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FKHIJCDPKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x33BCE50", Offset = "0x33BBC50", VA = "0x1833BCE50")]
		internal TResult ELMFOFBAPIL(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct OMKKKKBEKBL : IAsyncStateMachine
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
		public LIKHBENNIFH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private FKHIJCDPKEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6FA0", Offset = "0x3CE5DA0", VA = "0x183CE6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7DD0", Offset = "0x3CE6BD0", VA = "0x183CE7DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KAPMGBPELIJ BOJKKOPDFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IEqualityComparer<TRequest> GKEGMLFBEMI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x353B8D0", Offset = "0x353A6D0", VA = "0x18353B8D0")]
	public LIKHBENNIFH(KAPMGBPELIJ BOJKKOPDFAK, [Optional] IEqualityComparer<TRequest> GKEGMLFBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x39902B0", Offset = "0x398F0B0", VA = "0x1839902B0", Slot = "4")]
	[AsyncStateMachine(typeof(LIKHBENNIFH<, >.OMKKKKBEKBL))]
	public Task<List<TResult>> OIAOBCBGLNP(IReadOnlyList<TRequest> FMNLMEECNNN, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GNJNAKJEJIA<TItemId, TResult> : OMLHOHCLMIK<HOIJBODBDFI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task KAICHPGKBJE(Dictionary<TItemId, int> FMNLMEECNNN, CancellationToken BCCDJHNACKO);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct MAEFDGICJCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IReadOnlyList<HOIJBODBDFI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public GNJNAKJEJIA<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3B52A00", Offset = "0x3B51800", VA = "0x183B52A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3B53730", Offset = "0x3B52530", VA = "0x183B53730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KAICHPGKBJE BOJKKOPDFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IEqualityComparer<TItemId> GKEGMLFBEMI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x353B8D0", Offset = "0x353A6D0", VA = "0x18353B8D0")]
	public GNJNAKJEJIA(KAICHPGKBJE BOJKKOPDFAK, [Optional] IEqualityComparer<TItemId> GKEGMLFBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x353B790", Offset = "0x353A590", VA = "0x18353B790", Slot = "4")]
	[AsyncStateMachine(typeof(GNJNAKJEJIA<, >.MAEFDGICJCP))]
	public Task<List<TResult>> OIAOBCBGLNP(IReadOnlyList<HOIJBODBDFI<TItemId>> FMNLMEECNNN, CancellationToken BCCDJHNACKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OMLHOHCLMIK<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> OIAOBCBGLNP(IReadOnlyList<TRequest> FMNLMEECNNN, CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JMMFMBGPMAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Dictionary<string, NMLCLDAMLCH> CLLLIHCHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<T> NGGJMDDOKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Func<IEnumerable<T>> IEGGLBHFHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private Func<T, string> GOMIBCPEGPB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, NMLCLDAMLCH> AOGHLFCCJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> IGMDOMOJEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JMNEKPHIACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x806B50", Offset = "0x805950", VA = "0x180806B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3860870", Offset = "0x385F670", VA = "0x183860870")]
	public JMMFMBGPMAB(Func<IEnumerable<T>> IEGGLBHFHMC, Func<T, string> GOMIBCPEGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x38605F0", Offset = "0x385F3F0", VA = "0x1838605F0")]
	public void NCDLFODJGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface KCOAEFKDIGE<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid LLNDMFMBIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> JJOLGFOGMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GBKDMLIGKCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private interface HDENHKMNDHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int GJOHILIPJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DNANGEDOIAG<TParam>(TParam POACLGOFKAJ);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ENGAOLCDDEF(Exception KHAMCNNBIHA);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GAHONGKKKAD();
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private class JLHCLLPOINL<TResult> : HDENHKMNDHM, KCOAEFKDIGE<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TaskCompletionSource<TResult> AIJCFMOLNKB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid LLNDMFMBIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GJOHILIPJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> JJOLGFOGMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x385C3E0", Offset = "0x385B1E0", VA = "0x18385C3E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x385C4A0", Offset = "0x385B2A0", VA = "0x18385C4A0")]
		public JLHCLLPOINL(int ILEENJNMMIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x22AB8E0", Offset = "0x22AA6E0", VA = "0x1822AB8E0", Slot = "5")]
		public bool DNANGEDOIAG<TParam>(TParam POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x385C420", Offset = "0x385B220", VA = "0x18385C420", Slot = "6")]
		public bool ENGAOLCDDEF(Exception KHAMCNNBIHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x385C460", Offset = "0x385B260", VA = "0x18385C460", Slot = "7")]
		public bool GAHONGKKKAD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const string GEKMAHDHIKG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<Guid, HDENHKMNDHM> JOAOGKPMKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly COCDEEBGCML MBLMJGMGOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool EIENAJCLNNM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61F0D10", Offset = "0x61EFB10", VA = "0x1861F0D10")]
	public GBKDMLIGKCE([Optional] COCDEEBGCML MBLMJGMGOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61F0AE0", Offset = "0x61EF8E0", VA = "0x1861F0AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23991B0", Offset = "0x2397FB0", VA = "0x1823991B0")]
	public KCOAEFKDIGE<TResult> PICHMOLBAKP<TResult>(int LOMBFIHNPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2399450", Offset = "0x2398250", VA = "0x182399450")]
	public bool PKMFEOCNAKK<TResult>(Guid ODNBBNPINDD, TResult CGIMAKAECOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61F0BF0", Offset = "0x61EF9F0", VA = "0x1861F0BF0")]
	private void GIIPOIHFKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61F0AE0", Offset = "0x61EF8E0", VA = "0x1861F0AE0")]
	private void EHLCLNNENKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61F05F0", Offset = "0x61EF3F0", VA = "0x1861F05F0")]
	private void ALPEHDDLMDM(int ILEENJNMMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61F08E0", Offset = "0x61EF6E0", VA = "0x1861F08E0")]
	private void BCMGMBJNHJC()
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

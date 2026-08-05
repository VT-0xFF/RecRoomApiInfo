using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CNOJNJOOBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EGJLEFAKPJA(int EENHNPNMOPD, CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EGJLEFAKPJA(TimeSpan AJIJGOHMADP, CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BKDNGLLIDIL : CNOJNJOOBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7230420", Offset = "0x722EE20", VA = "0x187230420")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	internal static void FIDEIEBMMOH(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKDNGLLIDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7230360", Offset = "0x722ED60", VA = "0x187230360", Slot = "4")]
	public Task EGJLEFAKPJA(int EENHNPNMOPD, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72303C0", Offset = "0x722EDC0", VA = "0x1872303C0", Slot = "5")]
	public Task EGJLEFAKPJA(TimeSpan AJIJGOHMADP, CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
namespace _AssemblyRegistry.RecRoom_RoomEconomy_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7230D30", Offset = "0x722F730", VA = "0x187230D30", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JHJOMLDPJMD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private struct FFDIPJJEAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest NIHHGHLONIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> JKCAFBCNIKN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
		public FFDIPJJEAEM(TRequest IHHJPAMNDBP, TaskCompletionSource<TResult> MGJCJEDJLDK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct BHNIEBJMOMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public JHJOMLDPJMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5048DD0", Offset = "0x50477D0", VA = "0x185048DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0470", Offset = "0x3DDEE70", VA = "0x183DE0470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct IPIGLLOIJGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JHJOMLDPJMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4039FE0", Offset = "0x40389E0", VA = "0x184039FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x403A3D0", Offset = "0x4038DD0", VA = "0x18403A3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JCOAJLMPHEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JHJOMLDPJMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken taskDelayCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationToken outgoingRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x42013F0", Offset = "0x41FFDF0", VA = "0x1842013F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x42018B0", Offset = "0x42002B0", VA = "0x1842018B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct ALIMELDEPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JHJOMLDPJMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private List<TRequest> <requests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7F10", Offset = "0x3DE6910", VA = "0x183DE7F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3DE9130", Offset = "0x3DE7B30", VA = "0x183DE9130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KNKFODKELGG<TRequest, TResult> NALFOJPGCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float OFENHMGDJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CNOJNJOOBAH OPLBNAMMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool ABHKCCKLNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<FFDIPJJEAEM> EIKPHJLMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<FFDIPJJEAEM> LHNADGDNOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool LABCIBIPEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource IMNNFPIJFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource HLKBHCGCAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task DFENNLOFHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float MACLAFJAGFL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DLOJNDBBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x891550", Offset = "0x88FF50", VA = "0x180891550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x891650", Offset = "0x890050", VA = "0x180891650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x42151F0", Offset = "0x4213BF0", VA = "0x1842151F0")]
	public JHJOMLDPJMD(KNKFODKELGG<TRequest, TResult> NALFOJPGCJH, TimeSpan OFENHMGDJNH, bool ABHKCCKLNFE, [Optional] CNOJNJOOBAH OPLBNAMMKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4214B40", Offset = "0x4213540", VA = "0x184214B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4214770", Offset = "0x4213170", VA = "0x184214770")]
	[AsyncStateMachine(typeof(JHJOMLDPJMD<, >.BHNIEBJMOMM))]
	public Task<TResult> AEHNIIFEHBG(TRequest IHHJPAMNDBP, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x42146D0", Offset = "0x42130D0", VA = "0x1842146D0")]
	private void AEHNIIFEHBG(TRequest IHHJPAMNDBP, TaskCompletionSource<TResult> MGJCJEDJLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4214EA0", Offset = "0x42138A0", VA = "0x184214EA0")]
	public Task KDOCCHPLCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4214F60", Offset = "0x4213960", VA = "0x184214F60")]
	[AsyncStateMachine(typeof(JHJOMLDPJMD<, >.IPIGLLOIJGD))]
	private Task KPDHGHECKLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4214D80", Offset = "0x4213780", VA = "0x184214D80")]
	[AsyncStateMachine(typeof(JHJOMLDPJMD<, >.JCOAJLMPHEO))]
	private Task HHMAEMKHIFJ(CancellationToken OEICJFMGIPN, CancellationToken IFPKBKENCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4215040", Offset = "0x4213A40", VA = "0x184215040")]
	[AsyncStateMachine(typeof(JHJOMLDPJMD<, >.ALIMELDEPNM))]
	private Task LPNAPMDBDNF(CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4214A60", Offset = "0x4213460", VA = "0x184214A60")]
	private TimeSpan DKAFOGJMGLK()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4214940", Offset = "0x4213340", VA = "0x184214940")]
	private Task<List<TResult>> BJMNGOCKNBE(IReadOnlyList<TRequest> HEFPMFFDCHB, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42148A0", Offset = "0x42132A0", VA = "0x1842148A0")]
	private float BINGOGIMJNA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4215140", Offset = "0x4213B40", VA = "0x184215140")]
	private void ODGEGBFCBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BNHJOBDMJMI<TItemId, TResult> : KNKFODKELGG<DLAOBKBALKM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate Task<Dictionary<TItemId, TResult>> LKPKHNCGBHC(Dictionary<TItemId, int> HEFPMFFDCHB, CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IIMGKOKPJJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IIMGKOKPJJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40158E0", Offset = "0x40142E0", VA = "0x1840158E0")]
		internal TResult KGBKNGBFFKD(DLAOBKBALKM<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BCICJJKGPKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<DLAOBKBALKM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BNHJOBDMJMI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private IIMGKOKPJJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5000AC0", Offset = "0x4FFF4C0", VA = "0x185000AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x50018B0", Offset = "0x50002B0", VA = "0x1850018B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly LKPKHNCGBHC HMLEGNLOHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> MFGCOCEIJOG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F979D0", Offset = "0x3F963D0", VA = "0x183F979D0")]
	public BNHJOBDMJMI(LKPKHNCGBHC HMLEGNLOHAK, [Optional] IEqualityComparer<TItemId> MFGCOCEIJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x506A460", Offset = "0x5068E60", VA = "0x18506A460", Slot = "4")]
	[AsyncStateMachine(typeof(BNHJOBDMJMI<, >.BCICJJKGPKF))]
	public Task<List<TResult>> JIEPAIGOMCC(IReadOnlyList<DLAOBKBALKM<TItemId>> HEFPMFFDCHB, CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ICHJNJJEGEC<TRequest, TResult> : KNKFODKELGG<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate Task<List<TResult>> CEKAGBMHBGH(IEnumerable<TRequest> NPKDLCGEAOH, CancellationToken OGJIGALEPCA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class LAANJCHMIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LAANJCHMIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2CE80", Offset = "0x3D2B880", VA = "0x183D2CE80")]
		internal TResult KGBKNGBFFKD(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct JAINIJLLPLF : IAsyncStateMachine
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
		public ICHJNJJEGEC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private LAANJCHMIDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41F6240", Offset = "0x41F4C40", VA = "0x1841F6240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x41F7140", Offset = "0x41F5B40", VA = "0x1841F7140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CEKAGBMHBGH HMLEGNLOHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> MFGCOCEIJOG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F979D0", Offset = "0x3F963D0", VA = "0x183F979D0")]
	public ICHJNJJEGEC(CEKAGBMHBGH HMLEGNLOHAK, [Optional] IEqualityComparer<TRequest> MFGCOCEIJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F97880", Offset = "0x3F96280", VA = "0x183F97880", Slot = "4")]
	[AsyncStateMachine(typeof(ICHJNJJEGEC<, >.JAINIJLLPLF))]
	public Task<List<TResult>> JIEPAIGOMCC(IReadOnlyList<TRequest> HEFPMFFDCHB, CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KNKFODKELGG<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> JIEPAIGOMCC(IReadOnlyList<TRequest> HEFPMFFDCHB, CancellationToken OGJIGALEPCA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CGNLBIBHBKL<TItemId, TResult> : KNKFODKELGG<HDCIGKENEKH<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate Task OLMCFJOALDE(IReadOnlyDictionary<TItemId, HDCIGKENEKH<TItemId>.ECAIKDGBAJL> HEFPMFFDCHB, CancellationToken OGJIGALEPCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct ENDDFNEAIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CGNLBIBHBKL<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<HDCIGKENEKH<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x39AAED0", Offset = "0x39A98D0", VA = "0x1839AAED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x39AB450", Offset = "0x39A9E50", VA = "0x1839AB450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OLMCFJOALDE FBEPNBCEAPP;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public CGNLBIBHBKL(OLMCFJOALDE FBEPNBCEAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x54386C0", Offset = "0x54370C0", VA = "0x1854386C0", Slot = "4")]
	[AsyncStateMachine(typeof(CGNLBIBHBKL<, >.ENDDFNEAIGN))]
	public Task<List<object>> JIEPAIGOMCC(IReadOnlyList<HDCIGKENEKH<TItemId>> HEFPMFFDCHB, CancellationToken OGJIGALEPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5438800", Offset = "0x5437200", VA = "0x185438800")]
	private IReadOnlyDictionary<TItemId, HDCIGKENEKH<TItemId>.ECAIKDGBAJL> KFIJKFJODCM(IReadOnlyList<HDCIGKENEKH<TItemId>> APNCKMEIMOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JCJAKDADDPO<TItemId, TResult> : KNKFODKELGG<DLAOBKBALKM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate Task<Dictionary<TItemId, TResult>> JGBLECMPCIC(Dictionary<TItemId, int> HEFPMFFDCHB, CancellationToken OGJIGALEPCA);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct KBKLAEDHEGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<DLAOBKBALKM<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public JCJAKDADDPO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x42F19E0", Offset = "0x42F03E0", VA = "0x1842F19E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x42F3400", Offset = "0x42F1E00", VA = "0x1842F3400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly JGBLECMPCIC EJFCHCIDBCF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public JCJAKDADDPO(JGBLECMPCIC HMLEGNLOHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41FE550", Offset = "0x41FCF50", VA = "0x1841FE550", Slot = "4")]
	[AsyncStateMachine(typeof(JCJAKDADDPO<, >.KBKLAEDHEGG))]
	public Task<List<TResult>> JIEPAIGOMCC(IReadOnlyList<DLAOBKBALKM<TItemId>> HEFPMFFDCHB, CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FFKIBKKADFL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, GOLDOKHMCBL> IBIMMCMIFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> JEPAKHLOOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> MEJLMJJLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> GPDHMEBMOBB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, GOLDOKHMCBL> EPNLMCKNEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> KHGGIIJGFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NBGPLPPOFFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x918C60", VA = "0x18091A260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3D427E0", Offset = "0x3D411E0", VA = "0x183D427E0")]
	public FFKIBKKADFL(Func<IEnumerable<T>> MEJLMJJLHKG, Func<T, string> GPDHMEBMOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3D42480", Offset = "0x3D40E80", VA = "0x183D42480")]
	public void DBMELBLEALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D42750", Offset = "0x3D41150", VA = "0x183D42750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LCIFDDKIIJO<TItemId, TResult> : JHJOMLDPJMD<DLAOBKBALKM<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x396A430", Offset = "0x3968E30", VA = "0x18396A430")]
	public LCIFDDKIIJO(KNKFODKELGG<DLAOBKBALKM<TItemId>, TResult> NALFOJPGCJH, TimeSpan OFENHMGDJNH, bool ABHKCCKLNFE, [Optional] CNOJNJOOBAH OPLBNAMMKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x441C9E0", Offset = "0x441B3E0", VA = "0x18441C9E0")]
	public Task<TResult> AEHNIIFEHBG(TItemId JODEIIFHAPK, int CBMKMKAFNOB, [Optional] CancellationToken OGJIGALEPCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DLAOBKBALKM<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId CDFEJPOKNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int NKENPOCICON;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A6AEE0", Offset = "0x5A698E0", VA = "0x185A6AEE0")]
	public DLAOBKBALKM(TItemId KLIDJGNPIFF, int CBMKMKAFNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IICMJNHDNHA<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid HLBMNBDIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> IGJEEIONCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JPFBHJCPAKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private interface MPNLHBIHJIN
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int KBNECMAENLL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool EFMNDDFCOIE<TParam>(TParam CLMKDBDPNNH);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DHIIPGICHHA(Exception DCGMDLPABHJ);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FPPJMFMPGBM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class IPLHMMJDJBF<TResult> : MPNLHBIHJIN, IICMJNHDNHA<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> LEENFLIPNGA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid HLBMNBDIHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int KBNECMAENLL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> IGJEEIONCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x403A4F0", Offset = "0x4038EF0", VA = "0x18403A4F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x403A550", Offset = "0x4038F50", VA = "0x18403A550")]
		public IPLHMMJDJBF(int OODFACIMBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2C9B4C0", Offset = "0x2C99EC0", VA = "0x182C9B4C0", Slot = "5")]
		public bool EFMNDDFCOIE<TParam>(TParam CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x403A430", Offset = "0x4038E30", VA = "0x18403A430", Slot = "6")]
		public bool DHIIPGICHHA(Exception DCGMDLPABHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x403A490", Offset = "0x4038E90", VA = "0x18403A490", Slot = "7")]
		public bool FPPJMFMPGBM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string GLKENMFOILC = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, MPNLHBIHJIN> JCHHEIIGOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly COACLAJFNPB FHDDPKDLDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HIJOAHMKKGP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7230C30", Offset = "0x722F630", VA = "0x187230C30")]
	public JPFBHJCPAKC([Optional] COACLAJFNPB FHDDPKDLDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7230640", Offset = "0x722F040", VA = "0x187230640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF680", Offset = "0x2CFE080", VA = "0x182CFF680")]
	public IICMJNHDNHA<TResult> MAFKCAJNDBL<TResult>(int BKNFLCAOHKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF9A0", Offset = "0x2CFE3A0", VA = "0x182CFF9A0")]
	public bool PBDMNNPGEJB<TResult>(Guid LDAHMGICCPK, TResult DFEFBOIIPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7230520", Offset = "0x722EF20", VA = "0x187230520")]
	private void BJACCOPOLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7230640", Offset = "0x722F040", VA = "0x187230640")]
	private void MGBFBPCAPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7230750", Offset = "0x722F150", VA = "0x187230750")]
	private void HJENJIPEIJK(int OODFACIMBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7230A30", Offset = "0x722F430", VA = "0x187230A30")]
	private void ICFMFGFFKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum NEAABADNHFK
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HDCIGKENEKH<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ECAIKDGBAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int PCJIBHKCLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int OKHADAANKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int FHDIJNABHDJ;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ECAIKDGBAJL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId CDFEJPOKNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int NKENPOCICON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NEAABADNHFK BBLGOMAOPFJ;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x15232D0", Offset = "0x1521CD0", VA = "0x1815232D0")]
	public HDCIGKENEKH(TItemId KLIDJGNPIFF, int CBMKMKAFNOB, NEAABADNHFK NHGOKBHHHPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FGNONLGABKJ<TItemId, TResult> : JHJOMLDPJMD<HDCIGKENEKH<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3D4BE30", Offset = "0x3D4A830", VA = "0x183D4BE30")]
	public FGNONLGABKJ(KNKFODKELGG<HDCIGKENEKH<TItemId>, TResult> NALFOJPGCJH, TimeSpan OFENHMGDJNH, [Optional] CNOJNJOOBAH OPLBNAMMKKJ)
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

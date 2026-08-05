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
public interface PEFLMPELGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OECIFOABINH(int KKCNFMMHFNA, CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OECIFOABINH(TimeSpan DHDEFPCFNIH, CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NJCCHPGHCNG : PEFLMPELGOE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F050", Offset = "0x6F5E450", VA = "0x186F5F050")]
	[EAMANMFIEOM(LALOBMMKLJJ.Root, NBICBCAKHEI.GameOnly)]
	private static void LJKJKOBPKLH(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	[Preserve]
	public NJCCHPGHCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F1B0", Offset = "0x6F5E5B0", VA = "0x186F5F1B0", Slot = "4")]
	public Task OECIFOABINH(int KKCNFMMHFNA, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F5F150", Offset = "0x6F5E550", VA = "0x186F5F150", Slot = "5")]
	public Task OECIFOABINH(TimeSpan DHDEFPCFNIH, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CIMGPMECDKP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private struct PBGAACLCFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public TRequest JOPNHEIGKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TaskCompletionSource<TResult> LMANALALLFK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
		public PBGAACLCFMK(TRequest BNAGIPDFDCE, TaskCompletionSource<TResult> HJBBEHMCLOD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NJIPOGLIFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public CIMGPMECDKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x452AF40", Offset = "0x452A340", VA = "0x18452AF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF940", Offset = "0x3CDED40", VA = "0x183CDF940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct CNDLMHILCFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CIMGPMECDKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x503A740", Offset = "0x5039B40", VA = "0x18503A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x503AB20", Offset = "0x5039F20", VA = "0x18503AB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FHGIKFAEIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CIMGPMECDKP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x3C1E330", Offset = "0x3C1D730", VA = "0x183C1E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E7F0", Offset = "0x3C1DBF0", VA = "0x183C1E7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NAOEPCPGEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CIMGPMECDKP<TRequest, TResult> <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x44E2490", Offset = "0x44E1890", VA = "0x1844E2490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44E3640", Offset = "0x44E2A40", VA = "0x1844E3640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BHEKOFHINPO<TRequest, TResult> BBAMNAOIDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly float IGFBPGNLKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly PEFLMPELGOE HIAKFGMPMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly bool EEOBEDAGOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<PBGAACLCFMK> JBAMKHNAHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly List<PBGAACLCFMK> FDMCEBMBMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private bool EJEJNFOKBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CancellationTokenSource LCBFHBDFDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CancellationTokenSource FIPLDHIJACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Task PBAOJMAOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private float CABPLLMJCOM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ENEMNHNNKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x859270", Offset = "0x858670", VA = "0x180859270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8591B0", Offset = "0x8585B0", VA = "0x1808591B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5030210", Offset = "0x502F610", VA = "0x185030210")]
	public CIMGPMECDKP(BHEKOFHINPO<TRequest, TResult> BBAMNAOIDEA, TimeSpan IGFBPGNLKOB, bool EEOBEDAGOPM, [Optional] PEFLMPELGOE HIAKFGMPMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x502F980", Offset = "0x502ED80", VA = "0x18502F980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x502FED0", Offset = "0x502F2D0", VA = "0x18502FED0")]
	[AsyncStateMachine(typeof(CIMGPMECDKP<, >.NJIPOGLIFAN))]
	public Task<TResult> NFDPOCKPJKJ(TRequest BNAGIPDFDCE, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x502FE30", Offset = "0x502F230", VA = "0x18502FE30")]
	private void NFDPOCKPJKJ(TRequest BNAGIPDFDCE, TaskCompletionSource<TResult> HJBBEHMCLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x502F7E0", Offset = "0x502EBE0", VA = "0x18502F7E0")]
	public Task CPGABHMMOBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x502FD60", Offset = "0x502F160", VA = "0x18502FD60")]
	[AsyncStateMachine(typeof(CIMGPMECDKP<, >.CNDLMHILCFE))]
	private Task LDGBOFFAJOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x502FFF0", Offset = "0x502F3F0", VA = "0x18502FFF0")]
	[AsyncStateMachine(typeof(CIMGPMECDKP<, >.FHGIKFAEIEJ))]
	private Task NLGCINDHNIG(CancellationToken PJKHNJFLLKB, CancellationToken AJBPKHLFEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5030110", Offset = "0x502F510", VA = "0x185030110")]
	[AsyncStateMachine(typeof(CIMGPMECDKP<, >.NAOEPCPGEAJ))]
	private Task PGFEDFDKKML(CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x502F8A0", Offset = "0x502ECA0", VA = "0x18502F8A0")]
	private TimeSpan DKPAOGEIJMG()
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x502FC40", Offset = "0x502F040", VA = "0x18502FC40")]
	private Task<List<TResult>> HCHFCKMDPCL(IReadOnlyList<TRequest> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x502FBA0", Offset = "0x502EFA0", VA = "0x18502FBA0")]
	private float EBJMFMGLFCO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x502F740", Offset = "0x502EB40", VA = "0x18502F740")]
	private void BBGGDPJNEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GFCIMKHNFDI<TItemId, TResult> : BHEKOFHINPO<HINCOBONIAI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task<Dictionary<TItemId, TResult>> IKNAIBJEEAA(Dictionary<TItemId, int> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LCDKICAOPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public Dictionary<TItemId, TResult> results;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public LCDKICAOPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x422A340", Offset = "0x4229740", VA = "0x18422A340")]
		internal TResult GNGFNAAPMKJ(HINCOBONIAI<TItemId> r)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BBGOLELINFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IReadOnlyList<HINCOBONIAI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GFCIMKHNFDI<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private LCDKICAOPCF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4E83540", Offset = "0x4E82940", VA = "0x184E83540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4E842A0", Offset = "0x4E836A0", VA = "0x184E842A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly IKNAIBJEEAA OLODJONLLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly IEqualityComparer<TItemId> BDPKNEMBHED;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D03070", Offset = "0x3D02470", VA = "0x183D03070")]
	public GFCIMKHNFDI(IKNAIBJEEAA OLODJONLLIC, [Optional] IEqualityComparer<TItemId> BDPKNEMBHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D02F20", Offset = "0x3D02320", VA = "0x183D02F20", Slot = "4")]
	[AsyncStateMachine(typeof(GFCIMKHNFDI<, >.BBGOLELINFE))]
	public Task<List<TResult>> ALADPHCACCJ(IReadOnlyList<HINCOBONIAI<TItemId>> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MDDLBALKCAK<TRequest, TResult> : BHEKOFHINPO<TRequest, TResult> where TRequest : IEquatable<TRequest>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<List<TResult>> PDJHHIPEGID(IEnumerable<TRequest> JPDAPDOGCLE, CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PMPHLGNGGIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Dictionary<TRequest, TResult> requestResponseMap;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PMPHLGNGGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D65580", Offset = "0x3D64980", VA = "0x183D65580")]
		internal TResult GNGFNAAPMKJ(TRequest request)
		{
			return (TResult)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct DEMJPPDACCH : IAsyncStateMachine
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
		public MDDLBALKCAK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PMPHLGNGGIE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<TRequest> <distinctRequests>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<List<TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5788A40", Offset = "0x5787E40", VA = "0x185788A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57898A0", Offset = "0x5788CA0", VA = "0x1857898A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PDJHHIPEGID OLODJONLLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IEqualityComparer<TRequest> BDPKNEMBHED;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D03070", Offset = "0x3D02470", VA = "0x183D03070")]
	public MDDLBALKCAK(PDJHHIPEGID OLODJONLLIC, [Optional] IEqualityComparer<TRequest> BDPKNEMBHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x442AE50", Offset = "0x442A250", VA = "0x18442AE50", Slot = "4")]
	[AsyncStateMachine(typeof(MDDLBALKCAK<, >.DEMJPPDACCH))]
	public Task<List<TResult>> ALADPHCACCJ(IReadOnlyList<TRequest> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BHEKOFHINPO<TRequest, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<TResult>> ALADPHCACCJ(IReadOnlyList<TRequest> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MLFPJCDDOIM<TItemId, TResult> : BHEKOFHINPO<NFBNKGCNBMG<TItemId>, object> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public delegate Task JDHAIFBMKCC(IReadOnlyDictionary<TItemId, NFBNKGCNBMG<TItemId>.PAOOJOHGPEC> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private struct IMJHKEBOPKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<List<object>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public MLFPJCDDOIM<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IReadOnlyList<NFBNKGCNBMG<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E75B00", Offset = "0x3E74F00", VA = "0x183E75B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E76060", Offset = "0x3E75460", VA = "0x183E76060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JDHAIFBMKCC FJJCKAAMMCD;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public MLFPJCDDOIM(JDHAIFBMKCC FJJCKAAMMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4458760", Offset = "0x4457B60", VA = "0x184458760", Slot = "4")]
	[AsyncStateMachine(typeof(MLFPJCDDOIM<, >.IMJHKEBOPKK))]
	public Task<List<object>> ALADPHCACCJ(IReadOnlyList<NFBNKGCNBMG<TItemId>> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x44588A0", Offset = "0x4457CA0", VA = "0x1844588A0")]
	private IReadOnlyDictionary<TItemId, NFBNKGCNBMG<TItemId>.PAOOJOHGPEC> JHDICFBIEAD(IReadOnlyList<NFBNKGCNBMG<TItemId>> EBIBIDFCOBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GEJCPENALAO<TItemId, TResult> : BHEKOFHINPO<HINCOBONIAI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate Task<Dictionary<TItemId, TResult>> DJFDAALGINM(Dictionary<TItemId, int> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JKHJAMCLPFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IReadOnlyList<HINCOBONIAI<TItemId>> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GEJCPENALAO<TItemId, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Dictionary<TItemId, TResult>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x406BC10", Offset = "0x406B010", VA = "0x18406BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x406C8D0", Offset = "0x406BCD0", VA = "0x18406C8D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly DJFDAALGINM CJLOJCHDJOJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	public GEJCPENALAO(DJFDAALGINM OLODJONLLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D00D40", Offset = "0x3D00140", VA = "0x183D00D40", Slot = "4")]
	[AsyncStateMachine(typeof(GEJCPENALAO<, >.JKHJAMCLPFL))]
	public Task<List<TResult>> ALADPHCACCJ(IReadOnlyList<HINCOBONIAI<TItemId>> KJMCMJNCLEC, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PMCCOLFCNKE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, OLJDNHLONJI> IKJPBMLGMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<T> NKJBPIALLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private Func<IEnumerable<T>> NCJIEPOHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private Func<T, string> NJJCIPFNENF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<string, OLJDNHLONJI> DGCNOPEILGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<T> FGGJLNPEMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CFBAKHDKCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x986F90", Offset = "0x986390", VA = "0x180986F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47F0CE0", Offset = "0x47F00E0", VA = "0x1847F0CE0")]
	public PMCCOLFCNKE(Func<IEnumerable<T>> NCJIEPOHKGM, Func<T, string> NJJCIPFNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47F0990", Offset = "0x47EFD90", VA = "0x1847F0990")]
	public void DKKALNJCGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x47F0C50", Offset = "0x47F0050", VA = "0x1847F0C50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HGFDJHCMGDN<TItemId, TResult> : CIMGPMECDKP<HINCOBONIAI<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3835890", Offset = "0x3834C90", VA = "0x183835890")]
	public HGFDJHCMGDN(BHEKOFHINPO<HINCOBONIAI<TItemId>, TResult> BBAMNAOIDEA, TimeSpan IGFBPGNLKOB, bool EEOBEDAGOPM, [Optional] PEFLMPELGOE HIAKFGMPMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D59910", Offset = "0x3D58D10", VA = "0x183D59910")]
	public Task<TResult> NFDPOCKPJKJ(TItemId PEDCMDADFIN, int DBKDHFIFEPD, [Optional] CancellationToken GNJJGEHBGKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HINCOBONIAI<TItemId> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public TItemId CCLPJHGEGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int KLOLBJOJCHH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3D60850", Offset = "0x3D5FC50", VA = "0x183D60850")]
	public HINCOBONIAI(TItemId KJANOKPDCLJ, int DBKDHFIFEPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HMNMIOGHHEN<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Guid GIFPKFCIDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Task<TResult> JBOOKIDJAEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EEBCOCLABFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private interface PLIBIKFADJD
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int BIDMOHBLJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool POBOGECOLIM<TParam>(TParam OBEEJPGJPFD);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool NCEFDGAOPCD(Exception AGGBGAFAKGH);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EKGDOOAHDAA();
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GPIOIHJHGGP<TResult> : PLIBIKFADJD, HMNMIOGHHEN<TResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly TaskCompletionSource<TResult> JNFGPOOOADO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid GIFPKFCIDOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B50", Offset = "0x99FF50", VA = "0x1809A0B50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int BIDMOHBLJDK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Task<TResult> JBOOKIDJAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3D28C90", Offset = "0x3D28090", VA = "0x183D28C90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3D28D30", Offset = "0x3D28130", VA = "0x183D28D30")]
		public GPIOIHJHGGP(int JLJPGMAFGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29C7E50", Offset = "0x29C7250", VA = "0x1829C7E50", Slot = "5")]
		public bool POBOGECOLIM<TParam>(TParam OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D28CE0", Offset = "0x3D280E0", VA = "0x183D28CE0", Slot = "6")]
		public bool NCEFDGAOPCD(Exception AGGBGAFAKGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D28C40", Offset = "0x3D28040", VA = "0x183D28C40", Slot = "7")]
		public bool EKGDOOAHDAA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public const string KPDGGLHFMJG = "Remote player disconnected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Dictionary<Guid, PLIBIKFADJD> JCEKBOBEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly HNFJGBBGMEF HILMCCKDMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool LNAHFDPHHLA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EF80", Offset = "0x6F5E380", VA = "0x186F5EF80")]
	public EEBCOCLABFO([Optional] HNFJGBBGMEF HILMCCKDMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ED50", Offset = "0x6F5E150", VA = "0x186F5ED50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29B4720", Offset = "0x29B3B20", VA = "0x1829B4720")]
	public HMNMIOGHHEN<TResult> MHDJPDDBKAJ<TResult>(int KCMFFNANJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29B43B0", Offset = "0x29B37B0", VA = "0x1829B43B0")]
	public bool JFGADDEDKCA<TResult>(Guid CLFBIAHMHDO, TResult LLANANCGECL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EE60", Offset = "0x6F5E260", VA = "0x186F5EE60")]
	private void PGPMBOEPAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F5ED50", Offset = "0x6F5E150", VA = "0x186F5ED50")]
	private void JNIGEKCKCJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F5EA60", Offset = "0x6F5DE60", VA = "0x186F5EA60")]
	private void DPLCEDEPKBC(int JLJPGMAFGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E860", Offset = "0x6F5DC60", VA = "0x186F5E860")]
	private void CCLDKBFGMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum EPICEBJLNIH
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	EQUIPMENT_SLOTS,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CV2_USE_INVENTORY_ITEM,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_INVENTORY_RRUI
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NFBNKGCNBMG<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PAOOJOHGPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int KBJNKNKIMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int KDEGJFBINKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int JGKJKEPNLCC;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PAOOJOHGPEC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public TItemId CCLPJHGEGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int KLOLBJOJCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EPICEBJLNIH BAGPMMOAKMM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x128AEB0", Offset = "0x128A2B0", VA = "0x18128AEB0")]
	public NFBNKGCNBMG(TItemId KJANOKPDCLJ, int DBKDHFIFEPD, EPICEBJLNIH LMADGEINEAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OIPEHCKKIKB<TItemId, TResult> : CIMGPMECDKP<NFBNKGCNBMG<TItemId>, TResult> where TItemId : IEquatable<TItemId>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x469ADB0", Offset = "0x469A1B0", VA = "0x18469ADB0")]
	public OIPEHCKKIKB(BHEKOFHINPO<NFBNKGCNBMG<TItemId>, TResult> BBAMNAOIDEA, TimeSpan IGFBPGNLKOB, [Optional] PEFLMPELGOE HIAKFGMPMBG)
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

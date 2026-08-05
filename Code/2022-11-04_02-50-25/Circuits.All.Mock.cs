using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam> where TActionReceiver : global::OLIPMPCIIFP<TAction, Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>>> where TActionDeps : global::CHDPELCAKDP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FIMKHFEKNEA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FIMKHFEKNEA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x20180F0", Offset = "0x20174F0", VA = "0x1820180F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		public FIMKHFEKNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2DA7E40", Offset = "0x2DA7240", VA = "0x182DA7E40")]
		[AsyncStateMachine(typeof(global::ELPBBPDFOPE<, , , , , >.FIMKHFEKNEA.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LCFKANIOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::JNODMCDPIFF<ACIDJCBOKLO>, global::JNODMCDPIFF<GOGPGCBJKPB>> DCJGIOIGKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::JNODMCDPIFF<ACIDJCBOKLO>> BGLKECAGLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::NHPIDFCKLDI<int> KLNCMJAEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::JNODMCDPIFF<POLGLFONENJ> ActorId, global::JNODMCDPIFF<LJKPAHHIEAK> RequestId, TAction Action)> MILGGLOGION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool FAAHDNPOINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> KDMBBDDOJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::CKEPMJOPFJA<GEDMPKHKLII, global::JNODMCDPIFF<POLGLFONENJ>, TRpcParam, TRpcReceiver, global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MNMNKPJBIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LGFECKNOKAH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool KOPOPAOKICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FD0660", Offset = "0x2FCFA60", VA = "0x182FD0660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::JNODMCDPIFF<POLGLFONENJ> OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2FD0570", Offset = "0x2FCF970", VA = "0x182FD0570")]
		get
		{
			return default(global::JNODMCDPIFF<POLGLFONENJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0C70", Offset = "0x2FD0070", VA = "0x182FD0C70")]
	private ELPBBPDFOPE(global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LFLGCLEIAAH, global::CKEPMJOPFJA<GEDMPKHKLII, global::JNODMCDPIFF<POLGLFONENJ>, TRpcParam, TRpcReceiver, global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BPKMGIJIABM, global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABEFGAKPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0540", Offset = "0x2FCF940", VA = "0x182FD0540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FD01A0", Offset = "0x2FCF5A0", VA = "0x182FD01A0")]
	internal static global::ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AJMCJLMMDDK(global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LFLGCLEIAAH, global::CKEPMJOPFJA<GEDMPKHKLII, global::JNODMCDPIFF<POLGLFONENJ>, TRpcParam, TRpcReceiver, global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BPKMGIJIABM, global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CABEFGAKPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D90750", Offset = "0x2D8FB50", VA = "0x182D90750")]
	public global::JNODMCDPIFF<GOGPGCBJKPB> OBBBLHHDDDK()
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FD04A0", Offset = "0x2FCF8A0", VA = "0x182FD04A0")]
	internal global::JNODMCDPIFF<GOGPGCBJKPB> CPLIAOCFDNF(global::JNODMCDPIFF<ACIDJCBOKLO> FBDAFGPAOAL, in GEDMPKHKLII HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FD09C0", Offset = "0x2FCFDC0", VA = "0x182FD09C0")]
	internal void HKMALMGMBIA(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FD05D0", Offset = "0x2FCF9D0", VA = "0x182FD05D0")]
	internal void ECKPGAHEIDF(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FD08A0", Offset = "0x2FCFCA0", VA = "0x182FD08A0")]
	internal void GPJMFGBEPFE(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0AA0", Offset = "0x2FCFEA0", VA = "0x182FD0AA0")]
	internal void LHENOMJMKNM(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0900", Offset = "0x2FCFD00", VA = "0x182FD0900")]
	internal void HBDKHCNJJJK(global::JNODMCDPIFF<ADLHIFAEJNM> AONODCFFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0280", Offset = "0x2FCF680", VA = "0x182FD0280")]
	public global::JNODMCDPIFF<GOGPGCBJKPB> AMAKGLPMHPD(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0C40", Offset = "0x2FD0040", VA = "0x182FD0C40")]
	public void PNOOLIOJPCM(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FD05A0", Offset = "0x2FCF9A0", VA = "0x182FD05A0")]
	public void ECEAPHGKGHH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0630", Offset = "0x2FCFA30", VA = "0x182FD0630")]
	public void EOOIHAJHKIH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0C10", Offset = "0x2FD0010", VA = "0x182FD0C10")]
	public void MOADBGANELG(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0B70", Offset = "0x2FCFF70", VA = "0x182FD0B70")]
	public void MEIMACBAPJG(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in TRpcReceiver FOEBBFDCJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0B40", Offset = "0x2FCFF40", VA = "0x182FD0B40")]
	public global::JNODMCDPIFF<POLGLFONENJ> LPHHBBBPPJH(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<POLGLFONENJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0BD0", Offset = "0x2FCFFD0", VA = "0x182FD0BD0")]
	public bool MLJLOBGANDL(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, global::JNODMCDPIFF<POLGLFONENJ> DNBOIJPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0A40", Offset = "0x2FCFE40", VA = "0x182FD0A40")]
	public global::JNODMCDPIFF<ADLHIFAEJNM> IJFFFBOOPOB(global::JNODMCDPIFF<GOGPGCBJKPB> HKFNIHLBEHC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) FMOFDIPGIHC)
	{
		return default(global::JNODMCDPIFF<ADLHIFAEJNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FD02E0", Offset = "0x2FCF6E0", VA = "0x182FD02E0")]
	public void ANDPCLLPNNG(global::JNODMCDPIFF<ADLHIFAEJNM> NLIGLMCBGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0BA0", Offset = "0x2FCFFA0", VA = "0x182FD0BA0")]
	public void MELIKPHLCGH(global::JNODMCDPIFF<ADLHIFAEJNM> NLIGLMCBGKJ, in TSyncFieldValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2FD06D0", Offset = "0x2FCFAD0", VA = "0x182FD06D0")]
	public Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> GABCAHGBCNE(in TAction PADKGNIPPLI, bool JFECAICJEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0A70", Offset = "0x2FCFE70", VA = "0x182FD0A70")]
	public void JILJOBPIAPE(in TActionReceiver KLHHBJEIAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2FD0310", Offset = "0x2FCF710", VA = "0x182FD0310")]
	public void BEAFJEOGIOP(global::JNODMCDPIFF<POLGLFONENJ> KOLHFJMEBIH, global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, in TAction PADKGNIPPLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::DGLJMMOCNPC<GEDMPKHKLII, global::JNODMCDPIFF<POLGLFONENJ>, TRpcParam, global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::NGGFJDMHNCG<TAction> where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam> where TActionReceiver : global::OLIPMPCIIFP<TAction, Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>>> where TActionDeps : global::CHDPELCAKDP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::ENACNAKEABA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IEOADJHNFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::JNODMCDPIFF<POLGLFONENJ> LEENNDGGGGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::JNODMCDPIFF<POLGLFONENJ> OLILMDOIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "4")]
		get
		{
			return default(global::JNODMCDPIFF<POLGLFONENJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::JNODMCDPIFF<POLGLFONENJ> JCKNHINNLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "14")]
		get
		{
			return default(global::JNODMCDPIFF<POLGLFONENJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42D7E20", Offset = "0x42D7220", VA = "0x1842D7E20")]
	private KBOBAAIODGJ(global::ENACNAKEABA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PDOEMANMJBJ, global::JNODMCDPIFF<POLGLFONENJ> FBDAFGPAOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x42D7770", Offset = "0x42D6B70", VA = "0x1842D7770")]
	public static global::KBOBAAIODGJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AJMCJLMMDDK(global::JNODMCDPIFF<POLGLFONENJ> FBDAFGPAOAL, global::ENACNAKEABA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PDOEMANMJBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x42D7DA0", Offset = "0x42D71A0", VA = "0x1842D7DA0")]
	public global::JNODMCDPIFF<GOGPGCBJKPB> OBBBLHHDDDK()
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x42D7DE0", Offset = "0x42D71E0", VA = "0x1842D7DE0")]
	public void PNOOLIOJPCM(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x42D7900", Offset = "0x42D6D00", VA = "0x1842D7900")]
	public void ECEAPHGKGHH(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x42D7980", Offset = "0x42D6D80", VA = "0x1842D7980")]
	public void EOOIHAJHKIH(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42D7CF0", Offset = "0x42D70F0", VA = "0x1842D7CF0")]
	public void MOADBGANELG(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x42D7C20", Offset = "0x42D7020", VA = "0x1842D7C20")]
	public global::JNODMCDPIFF<POLGLFONENJ> LPHHBBBPPJH(in GEDMPKHKLII HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<POLGLFONENJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42D7C60", Offset = "0x42D7060", VA = "0x1842D7C60")]
	public bool MLJLOBGANDL(in GEDMPKHKLII HKFNIHLBEHC, global::JNODMCDPIFF<POLGLFONENJ> DNBOIJPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x42D7AB0", Offset = "0x42D6EB0", VA = "0x1842D7AB0")]
	public global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> IJFFFBOOPOB(global::JNODMCDPIFF<ADLHIFAEJNM> AONODCFFDGE, in GEDMPKHKLII HOEKGJHOPIH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) FMOFDIPGIHC)
	{
		return default(global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42D7840", Offset = "0x42D6C40", VA = "0x1842D7840")]
	public void ANDPCLLPNNG(in global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42D7A00", Offset = "0x42D6E00", VA = "0x1842D7A00")]
	public void FAGOKJCPANL(in global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> NLIGLMCBGKJ, in TSyncFieldValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x344D520", Offset = "0x344C920", VA = "0x18344D520", Slot = "15")]
	public void GDHILLOHCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42D7A70", Offset = "0x42D6E70", VA = "0x1842D7A70")]
	public void GABCAHGBCNE(global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, in TAction PADKGNIPPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42D78A0", Offset = "0x42D6CA0", VA = "0x1842D78A0", Slot = "5")]
	private void CLIBAHKJCNM(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42D7D70", Offset = "0x42D7170", VA = "0x1842D7D70", Slot = "6")]
	private void NEBIDABACNO(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28DB300", Offset = "0x28DA700", VA = "0x1828DB300", Slot = "7")]
	private void GMHLHGLJONL(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x42D7B80", Offset = "0x42D6F80", VA = "0x1842D7B80", Slot = "8")]
	private void JJCLMMCJDFK(in GEDMPKHKLII HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x42D7740", Offset = "0x42D6B40", VA = "0x1842D7740", Slot = "9")]
	private global::JNODMCDPIFF<POLGLFONENJ> AGGPDHMLGJB(in GEDMPKHKLII HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<POLGLFONENJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x42D7710", Offset = "0x42D6B10", VA = "0x1842D7710", Slot = "10")]
	private bool ADPGIILIDFB(in GEDMPKHKLII HKFNIHLBEHC, global::JNODMCDPIFF<POLGLFONENJ> DNBOIJPFOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42D7BB0", Offset = "0x42D6FB0", VA = "0x1842D7BB0", Slot = "11")]
	private global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> LCEGEJGDDID(global::JNODMCDPIFF<ADLHIFAEJNM> FBDAFGPAOAL, in GEDMPKHKLII HKFNIHLBEHC, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) FMOFDIPGIHC)
	{
		return default(global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28DAB20", Offset = "0x28D9F20", VA = "0x1828DAB20", Slot = "12")]
	private void KIJOPFDOHDI(in global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42D78D0", Offset = "0x42D6CD0", VA = "0x1842D78D0", Slot = "13")]
	private void DDOGIBHLJKM(in global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> NLIGLMCBGKJ, in TSyncFieldValue PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCAA0", Offset = "0x2CBBEA0", VA = "0x182CBCAA0", Slot = "16")]
	private void LBMIOHFLFND(global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, in TAction PADKGNIPPLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ENACNAKEABA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BMAPKMGAHFN<TRpcParam> where TActionReceiver : global::OLIPMPCIIFP<TAction, Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>>> where TActionDeps : global::CHDPELCAKDP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::JNODMCDPIFF<POLGLFONENJ> NIJGILCBHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::NNCPNHLELOH<ACIDJCBOKLO, global::CABMOHKFNNH<POLGLFONENJ>> NDIDAAGKHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::BKPNCCAPPDB<POLGLFONENJ, TSyncFieldValue>> JHOFONIAPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::AIFCFPMGHMF<POLGLFONENJ, global::ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CNGPHEGOGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps GEOPKNEOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::JNODMCDPIFF<POLGLFONENJ> ActorId, global::JNODMCDPIFF<LJKPAHHIEAK> RequestId, TAction Action)> DPNNGGBJEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? FCAOGLJJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? ONFFHAJAFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::JNODMCDPIFF<POLGLFONENJ> ActorId, global::JNODMCDPIFF<LJKPAHHIEAK> RequestId, TAction Action)> KGEFLLELHBM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::JNODMCDPIFF<POLGLFONENJ> HCGONMEMPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040")]
		get
		{
			return default(global::JNODMCDPIFF<POLGLFONENJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x40B7870", Offset = "0x40B6C70", VA = "0x1840B7870")]
	protected ENACNAKEABA(TActionDeps JFFIIBEPFIL, int? AJMDBBBCNDH, int? CPCFFCAMJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x40B5090", Offset = "0x40B4490", VA = "0x1840B5090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40B5A30", Offset = "0x40B4E30", VA = "0x1840B5A30")]
	public global::ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EIJIDEPPJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40B7570", Offset = "0x40B6970", VA = "0x1840B7570")]
	internal global::JNODMCDPIFF<GOGPGCBJKPB> OBBBLHHDDDK(global::JNODMCDPIFF<POLGLFONENJ> GGOBOPOBKJN)
	{
		return default(global::JNODMCDPIFF<GOGPGCBJKPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x40B7320", Offset = "0x40B6720", VA = "0x1840B7320")]
	internal void NPMHDFIHKNN(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x40B70B0", Offset = "0x40B64B0", VA = "0x1840B70B0")]
	internal global::JNODMCDPIFF<POLGLFONENJ> LPHHBBBPPJH(global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC)
	{
		return default(global::JNODMCDPIFF<POLGLFONENJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x40B4F10", Offset = "0x40B4310", VA = "0x1840B4F10")]
	internal void BGKJPIGANCO(global::JNODMCDPIFF<POLGLFONENJ> AGJJKLDLGPF, global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x40B6D10", Offset = "0x40B6110", VA = "0x1840B6D10")]
	internal void GDDCBBEBOLG(global::JNODMCDPIFF<POLGLFONENJ> CMKLDNCOPLP, global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x40B7100", Offset = "0x40B6500", VA = "0x1840B7100")]
	internal void MGFHGNODJBH(global::JNODMCDPIFF<POLGLFONENJ> AGJJKLDLGPF, global::JNODMCDPIFF<ACIDJCBOKLO> HKFNIHLBEHC, in TRpcParam FMOFDIPGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x40B66E0", Offset = "0x40B5AE0", VA = "0x1840B66E0")]
	internal global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue> EPKBNLGKDPJ(global::JNODMCDPIFF<POLGLFONENJ> FHALMONLABC, global::JNODMCDPIFF<ADLHIFAEJNM> AONODCFFDGE, string MPIADBGKNBD, in TSyncFieldValue PKODKJLGOIN, Action EGLKIOCIBPB, Action<object> KJKIKKPBMAB, Func<bool> HHNAMBDJODA)
	{
		return default(global::PPECCOFBANI<POLGLFONENJ, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x40B4FA0", Offset = "0x40B43A0", VA = "0x1840B4FA0")]
	internal void CPDEPNJNHND(global::JNODMCDPIFF<POLGLFONENJ> FHALMONLABC, string MPIADBGKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40B6DC0", Offset = "0x40B61C0", VA = "0x1840B6DC0")]
	internal void HBDKHCNJJJK(global::BKPNCCAPPDB<POLGLFONENJ, TSyncFieldValue> AONODCFFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x40B6D80", Offset = "0x40B6180", VA = "0x1840B6D80")]
	internal void GDHILLOHCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x40B6880", Offset = "0x40B5C80", VA = "0x1840B6880")]
	internal void GABCAHGBCNE(global::JNODMCDPIFF<POLGLFONENJ> KOLHFJMEBIH, global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, in TAction PADKGNIPPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40B6FE0", Offset = "0x40B63E0", VA = "0x1840B6FE0")]
	[CompilerGenerated]
	private global::ELPBBPDFOPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> LDCIOJFMONL(global::JNODMCDPIFF<POLGLFONENJ> MNFPICODELG)
	{
		return null;
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

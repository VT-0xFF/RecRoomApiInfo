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
public sealed class DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::GKPLEBPLOGB<TRpcParam> where TActionReceiver : global::OEBPAGLKOIL<TAction, Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>>> where TActionDeps : global::PFJAIGGCIOO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DONHEMCLOOO
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
			public DONHEMCLOOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x261AE40", Offset = "0x2619A40", VA = "0x18261AE40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public DONHEMCLOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF2B0", Offset = "0x2FCDEB0", VA = "0x182FCF2B0")]
		[AsyncStateMachine(typeof(global::DIKGNNGMGOM<, , , , , >.DONHEMCLOOO.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KGBPPPCHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::JMEFGJDEPFN<ILHHHNOFMAJ>, global::JMEFGJDEPFN<OIMKLGODNPA>> GFOHHNJFDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::JMEFGJDEPFN<ILHHHNOFMAJ>> FNCKCLICBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::FLKGEODDKIO<int> OLCCKFPBJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::JMEFGJDEPFN<KPJMGPLJJBE> ActorId, global::JMEFGJDEPFN<POLNMNHKKHA> RequestId, TAction Action)> HJGHIHAOPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MKCAHLGDFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> LMCJKFODOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::MPIGHCHDOAJ<IGCELJGFBDO, global::JMEFGJDEPFN<KPJMGPLJJBE>, TRpcParam, TRpcReceiver, global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BEBNIFLPCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PCLNEIAFJOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool FBKHKNHPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1E60", Offset = "0x2FC0A60", VA = "0x182FC1E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::JMEFGJDEPFN<KPJMGPLJJBE> LGHLKNLHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2FC1CF0", Offset = "0x2FC08F0", VA = "0x182FC1CF0")]
		get
		{
			return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2520", Offset = "0x2FC1120", VA = "0x182FC2520")]
	private DIKGNNGMGOM(global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GCFJADAOFIH, global::MPIGHCHDOAJ<IGCELJGFBDO, global::JMEFGJDEPFN<KPJMGPLJJBE>, TRpcParam, TRpcReceiver, global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> KCLHHGFEBCE, global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ICJCPONJKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1CC0", Offset = "0x2FC08C0", VA = "0x182FC1CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1D50", Offset = "0x2FC0950", VA = "0x182FC1D50")]
	internal static global::DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GADFBDMBHED(global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GCFJADAOFIH, global::MPIGHCHDOAJ<IGCELJGFBDO, global::JMEFGJDEPFN<KPJMGPLJJBE>, TRpcParam, TRpcReceiver, global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> KCLHHGFEBCE, global::PHMFOENONIN<TAction, TActionReceiver, TActionDeps, global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ICJCPONJKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1FD0", Offset = "0x2FC0BD0", VA = "0x182FC1FD0")]
	public global::JMEFGJDEPFN<OIMKLGODNPA> IGAPHANHOAF()
	{
		return default(global::JMEFGJDEPFN<OIMKLGODNPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FC23E0", Offset = "0x2FC0FE0", VA = "0x182FC23E0")]
	internal global::JMEFGJDEPFN<OIMKLGODNPA> NPBAPFNABKC(global::JMEFGJDEPFN<ILHHHNOFMAJ> BEAOEMMHBNI, in IGCELJGFBDO AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<OIMKLGODNPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1AB0", Offset = "0x2FC06B0", VA = "0x182FC1AB0")]
	internal void ALINPKPFFLC(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2000", Offset = "0x2FC0C00", VA = "0x182FC2000")]
	internal void IIGAKMPEODA(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1A50", Offset = "0x2FC0650", VA = "0x182FC1A50")]
	internal void ACKBCLKFBGK(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2480", Offset = "0x2FC1080", VA = "0x182FC2480")]
	internal void OMHMNGPPDON(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC22C0", Offset = "0x2FC0EC0", VA = "0x182FC22C0")]
	internal void MBJPLKGJNPG(global::JMEFGJDEPFN<NPHBIPFBGKJ> BDMBPBOBNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1F10", Offset = "0x2FC0B10", VA = "0x182FC1F10")]
	public global::JMEFGJDEPFN<OIMKLGODNPA> GOLMLDGNPEK(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<OIMKLGODNPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1D20", Offset = "0x2FC0920", VA = "0x182FC1D20")]
	public void FPCKNEPJKLD(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2380", Offset = "0x2FC0F80", VA = "0x182FC2380")]
	public void NBICJMFIEHB(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2060", Offset = "0x2FC0C60", VA = "0x182FC2060")]
	public void KAEPINDNKPE(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2FC23B0", Offset = "0x2FC0FB0", VA = "0x182FC23B0")]
	public void NECFPMKMFDO(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1E30", Offset = "0x2FC0A30", VA = "0x182FC1E30")]
	public void GBKFEAPPGEI(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in TRpcReceiver HNHFMAADOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1F70", Offset = "0x2FC0B70", VA = "0x182FC1F70")]
	public global::JMEFGJDEPFN<KPJMGPLJJBE> HFLOFEPPGPC(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1ED0", Offset = "0x2FC0AD0", VA = "0x182FC1ED0")]
	public bool GJHMPNCLFLE(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, global::JMEFGJDEPFN<KPJMGPLJJBE> PFAOCLAGBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2090", Offset = "0x2FC0C90", VA = "0x182FC2090")]
	public global::JMEFGJDEPFN<NPHBIPFBGKJ> KBIHOKECCPL(global::JMEFGJDEPFN<OIMKLGODNPA> AOEMDAGAALP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IHJLHGLAGGE)
	{
		return default(global::JMEFGJDEPFN<NPHBIPFBGKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2FC20C0", Offset = "0x2FC0CC0", VA = "0x182FC20C0")]
	public void LPDLEAGENIG(global::JMEFGJDEPFN<NPHBIPFBGKJ> EGDCLFHHIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1FA0", Offset = "0x2FC0BA0", VA = "0x182FC1FA0")]
	public void HPKHPAOHOJK(global::JMEFGJDEPFN<NPHBIPFBGKJ> EGDCLFHHIFC, in TSyncFieldValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2FC20F0", Offset = "0x2FC0CF0", VA = "0x182FC20F0")]
	public Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>> LPONECAHMDM(in TAction MNJNLIAKBME, bool CNDJAFLGADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1A20", Offset = "0x2FC0620", VA = "0x182FC1A20")]
	public void ACHOBBBJGHJ(in TActionReceiver DGNKOMAPBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2FC1B30", Offset = "0x2FC0730", VA = "0x182FC1B30")]
	public void DMONAEFNPIF(global::JMEFGJDEPFN<KPJMGPLJJBE> EAIIKDHHCAH, global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, in TAction MNJNLIAKBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::NLJBCIFPAJK<IGCELJGFBDO, global::JMEFGJDEPFN<KPJMGPLJJBE>, TRpcParam, global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::EGEPPKFBOAB<TAction> where TRpcReceiver : global::GKPLEBPLOGB<TRpcParam> where TActionReceiver : global::OEBPAGLKOIL<TAction, Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>>> where TActionDeps : global::PFJAIGGCIOO<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::CFGADDKOAFB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PGFFDOPHBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::JMEFGJDEPFN<KPJMGPLJJBE> MKLDPKFCFAJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::JMEFGJDEPFN<KPJMGPLJJBE> LGHLKNLHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080", Slot = "4")]
		get
		{
			return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::JMEFGJDEPFN<KPJMGPLJJBE> LMNAIFOJHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B7080", Offset = "0x6B5C80", VA = "0x1806B7080", Slot = "14")]
		get
		{
			return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30F6590", Offset = "0x30F5190", VA = "0x1830F6590")]
	private COMBEJKDHJO(global::CFGADDKOAFB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EJKFDMBLCHC, global::JMEFGJDEPFN<KPJMGPLJJBE> BEAOEMMHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30F5F20", Offset = "0x30F4B20", VA = "0x1830F5F20")]
	public static global::COMBEJKDHJO<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GADFBDMBHED(global::JMEFGJDEPFN<KPJMGPLJJBE> BEAOEMMHBNI, global::CFGADDKOAFB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EJKFDMBLCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x30F61D0", Offset = "0x30F4DD0", VA = "0x1830F61D0")]
	public global::JMEFGJDEPFN<OIMKLGODNPA> IGAPHANHOAF()
	{
		return default(global::JMEFGJDEPFN<OIMKLGODNPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30F5EE0", Offset = "0x30F4AE0", VA = "0x1830F5EE0")]
	public void FPCKNEPJKLD(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x30F6430", Offset = "0x30F5030", VA = "0x1830F6430")]
	public void NBICJMFIEHB(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30F6240", Offset = "0x30F4E40", VA = "0x1830F6240")]
	public void KAEPINDNKPE(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x30F64B0", Offset = "0x30F50B0", VA = "0x1830F64B0")]
	public void NECFPMKMFDO(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30F6160", Offset = "0x30F4D60", VA = "0x1830F6160")]
	public global::JMEFGJDEPFN<KPJMGPLJJBE> HFLOFEPPGPC(in IGCELJGFBDO AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x30F6060", Offset = "0x30F4C60", VA = "0x1830F6060")]
	public bool GJHMPNCLFLE(in IGCELJGFBDO AOEMDAGAALP, global::JMEFGJDEPFN<KPJMGPLJJBE> PFAOCLAGBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30F62C0", Offset = "0x30F4EC0", VA = "0x1830F62C0")]
	public global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> KBIHOKECCPL(global::JMEFGJDEPFN<NPHBIPFBGKJ> BDMBPBOBNDI, in IGCELJGFBDO DGKCGFAKKDB, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IHJLHGLAGGE)
	{
		return default(global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x30F6390", Offset = "0x30F4F90", VA = "0x1830F6390")]
	public void LPDLEAGENIG(in global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30F60F0", Offset = "0x30F4CF0", VA = "0x1830F60F0")]
	public void GNIOFONIGIE(in global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> EGDCLFHHIFC, in TSyncFieldValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x30F61A0", Offset = "0x30F4DA0", VA = "0x1830F61A0", Slot = "15")]
	public void HHGNEKDGIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x30F63F0", Offset = "0x30F4FF0", VA = "0x1830F63F0")]
	public void LPONECAHMDM(global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, in TAction MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x30F5E20", Offset = "0x30F4A20", VA = "0x1830F5E20", Slot = "5")]
	private void BHGFBIGLDCC(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x30F5E50", Offset = "0x30F4A50", VA = "0x1830F5E50", Slot = "6")]
	private void BLJBLFMOJFN(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x30F6210", Offset = "0x30F4E10", VA = "0x1830F6210", Slot = "7")]
	private void JPADLFIOFML(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x30F6560", Offset = "0x30F5160", VA = "0x1830F6560", Slot = "8")]
	private void PBLJPLPBHCB(in IGCELJGFBDO AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x30F5DF0", Offset = "0x30F49F0", VA = "0x1830F5DF0", Slot = "9")]
	private global::JMEFGJDEPFN<KPJMGPLJJBE> AEGEHAIIFCC(in IGCELJGFBDO AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x30F6530", Offset = "0x30F5130", VA = "0x1830F6530", Slot = "10")]
	private bool OBHACJPFOLK(in IGCELJGFBDO AOEMDAGAALP, global::JMEFGJDEPFN<KPJMGPLJJBE> PFAOCLAGBIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x30F5FF0", Offset = "0x30F4BF0", VA = "0x1830F5FF0", Slot = "11")]
	private global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> GFEKCEJBAJJ(global::JMEFGJDEPFN<NPHBIPFBGKJ> BEAOEMMHBNI, in IGCELJGFBDO AOEMDAGAALP, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) IHJLHGLAGGE)
	{
		return default(global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FC41F0", Offset = "0x2FC2DF0", VA = "0x182FC41F0", Slot = "12")]
	private void DAPEIABMDHI(in global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30F5E80", Offset = "0x30F4A80", VA = "0x1830F5E80", Slot = "13")]
	private void FBLHKCEPBFI(in global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> EGDCLFHHIFC, in TSyncFieldValue NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x30F5EB0", Offset = "0x30F4AB0", VA = "0x1830F5EB0", Slot = "16")]
	private void FJHCCFOIALO(global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, in TAction MNJNLIAKBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CFGADDKOAFB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::GKPLEBPLOGB<TRpcParam> where TActionReceiver : global::OEBPAGLKOIL<TAction, Task<global::DGDFIFNFPJI<object, DLGHCKKHLGP>>> where TActionDeps : global::PFJAIGGCIOO<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::JMEFGJDEPFN<KPJMGPLJJBE> DMKGHOGFONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::LMKKKGFGOHE<ILHHHNOFMAJ, global::IFNPGDPIIOK<KPJMGPLJJBE>> JCLPNIOCECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::BPIAHOPMALN<KPJMGPLJJBE, TSyncFieldValue>> DPGKLEENGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::IAIGMMNCOCA<KPJMGPLJJBE, global::DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LNKPABKEKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps MLAJOFLMBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::JMEFGJDEPFN<KPJMGPLJJBE> ActorId, global::JMEFGJDEPFN<POLNMNHKKHA> RequestId, TAction Action)> ADFKLAJBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? AFDPANPJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? FCBCPOFOLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::JMEFGJDEPFN<KPJMGPLJJBE> ActorId, global::JMEFGJDEPFN<POLNMNHKKHA> RequestId, TAction Action)> FBBKEAPLFNI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::JMEFGJDEPFN<KPJMGPLJJBE> NEHDMJAOKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060")]
		get
		{
			return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x30E46D0", Offset = "0x30E32D0", VA = "0x1830E46D0")]
	protected CFGADDKOAFB(TActionDeps CEBALFFNLCH, int? LBGHNJCFGHF, int? PFKOEOEKFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30E2380", Offset = "0x30E0F80", VA = "0x1830E2380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30E3A20", Offset = "0x30E2620", VA = "0x1830E3A20")]
	public global::DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MDKJOKCKOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30E2EA0", Offset = "0x30E1AA0", VA = "0x1830E2EA0")]
	internal global::JMEFGJDEPFN<OIMKLGODNPA> IGAPHANHOAF(global::JMEFGJDEPFN<KPJMGPLJJBE> EFFGDOPLFKN)
	{
		return default(global::JMEFGJDEPFN<OIMKLGODNPA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30E2130", Offset = "0x30E0D30", VA = "0x1830E2130")]
	internal void CMEJNNPKBOP(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30E2E10", Offset = "0x30E1A10", VA = "0x1830E2E10")]
	internal global::JMEFGJDEPFN<KPJMGPLJJBE> HFLOFEPPGPC(global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP)
	{
		return default(global::JMEFGJDEPFN<KPJMGPLJJBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30E3270", Offset = "0x30E1E70", VA = "0x1830E3270")]
	internal void JLEALNCLOOD(global::JMEFGJDEPFN<KPJMGPLJJBE> GKFNLNDEDBN, global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x30E3300", Offset = "0x30E1F00", VA = "0x1830E3300")]
	internal void LCNBDHHKKHL(global::JMEFGJDEPFN<KPJMGPLJJBE> HNCGHNJOAKF, global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30E1D70", Offset = "0x30E0970", VA = "0x1830E1D70")]
	internal void BGEIFDICKDO(global::JMEFGJDEPFN<KPJMGPLJJBE> GKFNLNDEDBN, global::JMEFGJDEPFN<ILHHHNOFMAJ> AOEMDAGAALP, in TRpcParam IHJLHGLAGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x30E1F90", Offset = "0x30E0B90", VA = "0x1830E1F90")]
	internal global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue> BIKHIPMNOND(global::JMEFGJDEPFN<KPJMGPLJJBE> CMFKAELPLOO, global::JMEFGJDEPFN<NPHBIPFBGKJ> BDMBPBOBNDI, string NANBEBOOGPM, in TSyncFieldValue NENFOEKGNGK, Action JGLIBPMCCNL, Action<object> KJKGFGLKBFB, Func<bool> IHCDDKEHPLK)
	{
		return default(global::CALEIIBGONN<KPJMGPLJJBE, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x30E2D20", Offset = "0x30E1920", VA = "0x1830E2D20")]
	internal void FAEIKOBCNBG(global::JMEFGJDEPFN<KPJMGPLJJBE> CMFKAELPLOO, string NANBEBOOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x30E3800", Offset = "0x30E2400", VA = "0x1830E3800")]
	internal void MBJPLKGJNPG(global::BPIAHOPMALN<KPJMGPLJJBE, TSyncFieldValue> BDMBPBOBNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x30E2E60", Offset = "0x30E1A60", VA = "0x1830E2E60")]
	internal void HHGNEKDGIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x30E3370", Offset = "0x30E1F70", VA = "0x1830E3370")]
	internal void LPONECAHMDM(global::JMEFGJDEPFN<KPJMGPLJJBE> EAIIKDHHCAH, global::JMEFGJDEPFN<POLNMNHKKHA> JLCECPGLFFH, in TAction MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x30E31A0", Offset = "0x30E1DA0", VA = "0x1830E31A0")]
	[CompilerGenerated]
	private global::DIKGNNGMGOM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JDFAGMHCDNP(global::JMEFGJDEPFN<KPJMGPLJJBE> GMFEEMADEGG)
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

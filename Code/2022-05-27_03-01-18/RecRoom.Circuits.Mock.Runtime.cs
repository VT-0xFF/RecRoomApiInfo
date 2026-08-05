using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct AINBIGGIEKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable, global::APDPNOFPOLB<global::JIJCDEFKIBB<EIIDBGPEGBB>, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::JIJCDEFKIBB<ADJCAKHFMDL>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::DIKDCIOLEEN<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>, TActionReceiver> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam> where TActionReceiver : global::GCCGPNAOPPH<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>> where TActionDeps : global::KLIDNCPFLJP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JBIMODEMIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public JBIMODEMIKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PLAILCIGNFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PLAILCIGNFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TaskAwaiter<global::COPPIENFOJP<object, GIGPDIEHPEM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3A12AB0", Offset = "0x3A11AB0", VA = "0x183A12AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5A9460", Offset = "0x5A8460", VA = "0x1805A9460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::COPPIENFOJP<object, GIGPDIEHPEM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JBIMODEMIKB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public PLAILCIGNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3A129A0", Offset = "0x3A119A0", VA = "0x183A129A0")]
		[AsyncStateMachine(typeof(global::EDNBHGMFDCB<, , , , , >.PLAILCIGNFE.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OPDJBDGEAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::JIJCDEFKIBB<AINBIGGIEKH>, global::JIJCDEFKIBB<EIIDBGPEGBB>> BDNLLGJDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::JIJCDEFKIBB<AINBIGGIEKH>> ELLHLHDCJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::MAAAINCIPAK<int> OLNDEPJOOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::JIJCDEFKIBB<FOOOECCBPJE> ActorId, global::JIJCDEFKIBB<HNMDOHCOCOP> RequestId, TAction Action)> HCDDHJNLFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool APMBJHCGGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> OACNDCDOFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::KCEOEKIAPNP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::NJDMJLBGKBG<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> CBENMNFKCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> IMAOBHHCNPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool HBMGKKEHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3A06370", Offset = "0x3A05370", VA = "0x183A06370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A066C0", Offset = "0x3A056C0", VA = "0x183A066C0", Slot = "5")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A06930", Offset = "0x3A05930", VA = "0x183A06930")]
	protected EDNBHGMFDCB(global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BPGHHPMNGIK, global::KCEOEKIAPNP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::NJDMJLBGKBG<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OBENFPAHMII, global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNGJLMLBKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xD08B10", Offset = "0xD07B10", VA = "0x180D08B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A05D20", Offset = "0x3A04D20", VA = "0x183A05D20")]
	public static global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CIAOGEOFBKG(global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BPGHHPMNGIK, global::KCEOEKIAPNP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::NJDMJLBGKBG<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OBENFPAHMII, global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNGJLMLBKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C4C50", Offset = "0x8C3C50", VA = "0x1808C4C50")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK()
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A061A0", Offset = "0x3A051A0", VA = "0x183A061A0")]
	internal global::JIJCDEFKIBB<EIIDBGPEGBB> HEILDHMCAML(in global::JIJCDEFKIBB<AINBIGGIEKH> IAKMMHHICJO, in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A06810", Offset = "0x3A05810", VA = "0x183A06810")]
	internal void OLEJHJEIIJO(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A06720", Offset = "0x3A05720", VA = "0x183A06720")]
	internal void NBOFNOBAJDL(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A06110", Offset = "0x3A05110", VA = "0x183A06110")]
	internal void GBOEFIGCLMA(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A062A0", Offset = "0x3A052A0", VA = "0x183A062A0")]
	internal void JHKGIIIALFC(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A06600", Offset = "0x3A05600", VA = "0x183A06600")]
	internal void LIELNFHIMIA(in global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A06780", Offset = "0x3A05780", VA = "0x183A06780")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NMFPDKBKOEC(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A065D0", Offset = "0x3A055D0", VA = "0x183A065D0")]
	public void KLLPJKELLIA(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A05E90", Offset = "0x3A04E90", VA = "0x183A05E90")]
	public void EGGAAPGMCEI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A05EF0", Offset = "0x3A04EF0", VA = "0x183A05EF0")]
	public void EKBGGIAHPGB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A05E60", Offset = "0x3A04E60", VA = "0x183A05E60")]
	public void DMEHNAIEAJF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A06900", Offset = "0x3A05900", VA = "0x183A06900")]
	public void PEGLFJKHLDO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A05E00", Offset = "0x3A04E00", VA = "0x183A05E00")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3A067E0", Offset = "0x3A057E0", VA = "0x183A067E0")]
	public bool OJEBBMDJDNN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3A066F0", Offset = "0x3A056F0", VA = "0x183A066F0")]
	public global::JIJCDEFKIBB<ADJCAKHFMDL> MKKIIHMLFCJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A05C60", Offset = "0x3A04C60", VA = "0x183A05C60")]
	public void AECFGMPHHIB(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A05CC0", Offset = "0x3A04CC0", VA = "0x183A05CC0")]
	public void BCAIIKHABBD(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A063D0", Offset = "0x3A053D0", VA = "0x183A063D0")]
	public Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> KFGPCGOPNEJ(in TAction BKCLKIJOKLP, bool GNMNBNFPAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A05F20", Offset = "0x3A04F20", VA = "0x183A05F20")]
	public void FCDBIJHHPEM(in TActionReceiver NEDAGCALOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A05F50", Offset = "0x3A04F50", VA = "0x183A05F50")]
	public void FFNBNIMAOLF(in global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A060E0", Offset = "0x3A050E0", VA = "0x183A060E0", Slot = "6")]
	private void FPMCFEKACCM(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A05EC0", Offset = "0x3A04EC0", VA = "0x183A05EC0", Slot = "7")]
	private void EJKOEEMCIGL(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A068D0", Offset = "0x3A058D0", VA = "0x183A068D0", Slot = "8")]
	private void PCDKPJKBJOP(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A06340", Offset = "0x3A05340", VA = "0x183A06340", Slot = "9")]
	private void JICFDNANLLF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A05CF0", Offset = "0x3A04CF0", VA = "0x183A05CF0", Slot = "10")]
	private void BCBNGAFFLIC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A05C90", Offset = "0x3A04C90", VA = "0x183A05C90", Slot = "11")]
	private global::JIJCDEFKIBB<FOOOECCBPJE> ANKJJGBCHIJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A068A0", Offset = "0x3A058A0", VA = "0x183A068A0", Slot = "12")]
	private bool OMKLMAJMOGF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A06240", Offset = "0x3A05240", VA = "0x183A06240", Slot = "13")]
	private global::JIJCDEFKIBB<ADJCAKHFMDL> IGMHJABIPKJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A05E30", Offset = "0x3A04E30", VA = "0x183A05E30", Slot = "14")]
	private void CMJJNFGGIKO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A06270", Offset = "0x3A05270", VA = "0x183A06270", Slot = "15")]
	private void IKBCLMIFMBO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A06170", Offset = "0x3A05170", VA = "0x183A06170", Slot = "16")]
	private Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> HBCCPLECAFG(in TAction BKCLKIJOKLP, bool GNMNBNFPAII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::MPPGNEBLOLP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, global::NJDMJLBGKBG<TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::NLAKMDDABME<TAction> where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam> where TActionReceiver : global::GCCGPNAOPPH<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>> where TActionDeps : global::KLIDNCPFLJP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NJONPHFOIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::JIJCDEFKIBB<FOOOECCBPJE> BOBJBBKGFBC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5AA180", Offset = "0x5A9180", VA = "0x1805AA180", Slot = "4")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> FIKMAKNIACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5AA180", Offset = "0x5A9180", VA = "0x1805AA180", Slot = "14")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x389C8F0", Offset = "0x389B8F0", VA = "0x18389C8F0")]
	private BCNGGJEOPCM(global::MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> INENLDCAHJL, in global::JIJCDEFKIBB<FOOOECCBPJE> IAKMMHHICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x389C2A0", Offset = "0x389B2A0", VA = "0x18389C2A0")]
	public static global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CIAOGEOFBKG(in global::JIJCDEFKIBB<FOOOECCBPJE> IAKMMHHICJO, global::MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> INENLDCAHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x389C810", Offset = "0x389B810", VA = "0x18389C810")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK()
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x389C650", Offset = "0x389B650", VA = "0x18389C650")]
	public void KLLPJKELLIA(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x389C4F0", Offset = "0x389B4F0", VA = "0x18389C4F0")]
	public void EGGAAPGMCEI(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x389C580", Offset = "0x389B580", VA = "0x18389C580")]
	public void EKBGGIAHPGB(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x389C410", Offset = "0x389B410", VA = "0x18389C410")]
	public void DMEHNAIEAJF(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x389C370", Offset = "0x389B370", VA = "0x18389C370")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x389C850", Offset = "0x389B850", VA = "0x18389C850")]
	public bool OJEBBMDJDNN(in NHIOHAOCPED FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x389C730", Offset = "0x389B730", VA = "0x18389C730")]
	public global::NJDMJLBGKBG<TSyncFieldValue> MKKIIHMLFCJ(in global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK, in NHIOHAOCPED KJDKGIBIDOI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x389C1B0", Offset = "0x389B1B0", VA = "0x18389C1B0")]
	public void AECFGMPHHIB(in global::NJDMJLBGKBG<TSyncFieldValue> JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x389C690", Offset = "0x389B690", VA = "0x18389C690")]
	public void LIPLEJHNLCB(in global::NJDMJLBGKBG<TSyncFieldValue> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3563890", Offset = "0x3562890", VA = "0x183563890", Slot = "15")]
	public void KIKECHNMBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x389C610", Offset = "0x389B610", VA = "0x18389C610")]
	public void KFGPCGOPNEJ(in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x389C270", Offset = "0x389B270", VA = "0x18389C270", Slot = "5")]
	private void BENGBICDHLI(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x389C240", Offset = "0x389B240", VA = "0x18389C240", Slot = "6")]
	private void AMNNBJLGJJC(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30F2090", Offset = "0x30F1090", VA = "0x1830F2090", Slot = "7")]
	private void MLFLNAFCPAE(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x389C490", Offset = "0x389B490", VA = "0x18389C490", Slot = "8")]
	private void DOCDOACGBDN(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x389C210", Offset = "0x389B210", VA = "0x18389C210", Slot = "9")]
	private global::JIJCDEFKIBB<FOOOECCBPJE> AJLFBNOLEIJ(in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1403290", Offset = "0x1402290", VA = "0x181403290", Slot = "10")]
	private bool DBKNFNPAIKA(in NHIOHAOCPED FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x389C3A0", Offset = "0x389B3A0", VA = "0x18389C3A0", Slot = "11")]
	private global::NJDMJLBGKBG<TSyncFieldValue> CLLHBKFOEDI(in global::JIJCDEFKIBB<ADJCAKHFMDL> DNNJPGCJGFN, in NHIOHAOCPED FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x389C700", Offset = "0x389B700", VA = "0x18389C700", Slot = "12")]
	private void MJNOENCEDND(in global::NJDMJLBGKBG<TSyncFieldValue> JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x14033B0", Offset = "0x14023B0", VA = "0x1814033B0", Slot = "13")]
	private void BHCKLJJAMND(in global::NJDMJLBGKBG<TSyncFieldValue> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x389C4C0", Offset = "0x389B4C0", VA = "0x18389C4C0", Slot = "16")]
	private void EFCMOCEIDGF(in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::FAAGOCCAKGC<TRpcParam> where TActionReceiver : global::GCCGPNAOPPH<TAction, Task<global::COPPIENFOJP<object, GIGPDIEHPEM>>> where TActionDeps : global::KLIDNCPFLJP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::JIJCDEFKIBB<FOOOECCBPJE> JBCOHHLJGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::LPGDOIMMPJG<AINBIGGIEKH, FLFBIMKCMGD> ONBGCJBPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<string, global::OENJNNGNIIO<TSyncFieldValue>> KCFAKOKGMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly global::MAPNOOOKBNF<FOOOECCBPJE, global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MJGBDJLHBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TActionDeps DGJMHNBPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly List<(global::JIJCDEFKIBB<FOOOECCBPJE> ActorId, global::JIJCDEFKIBB<HNMDOHCOCOP> RequestId, TAction Action)> NPONOHPEFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? BHELHLMBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly int? JOIHKELBOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Queue<(global::JIJCDEFKIBB<FOOOECCBPJE> ActorId, global::JIJCDEFKIBB<HNMDOHCOCOP> RequestId, TAction Action)> COFGIOJFHPC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::JIJCDEFKIBB<FOOOECCBPJE> NLLFFKDCMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5A9980", Offset = "0x5A8980", VA = "0x1805A9980")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3861830", Offset = "0x3860830", VA = "0x183861830")]
	protected MPJGCJNKBMJ(TActionDeps ELNLDKFLDHC, int? FGOLMPKJGGM, int? BOFGHPAOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3860190", Offset = "0x385F190", VA = "0x183860190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3860AB0", Offset = "0x385FAB0", VA = "0x183860AB0")]
	public global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KPIDAJNGINK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38614A0", Offset = "0x38604A0", VA = "0x1838614A0")]
	internal global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK(in global::JIJCDEFKIBB<FOOOECCBPJE> EEFFNIFFEGB)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x385FD50", Offset = "0x385ED50", VA = "0x18385FD50")]
	internal void CDANPMFEOKF(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3860130", Offset = "0x385F130", VA = "0x183860130")]
	internal global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x385FF00", Offset = "0x385EF00", VA = "0x18385FF00")]
	internal void CHJAMOGCBNJ(in global::JIJCDEFKIBB<FOOOECCBPJE> IAMNHCHAEGD, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3861190", Offset = "0x3860190", VA = "0x183861190")]
	internal void MLGDILENALK(in global::JIJCDEFKIBB<FOOOECCBPJE> OMLDPEFLBFK, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3861210", Offset = "0x3860210", VA = "0x183861210")]
	internal void NKEMPAIILAP(in global::JIJCDEFKIBB<FOOOECCBPJE> IAMNHCHAEGD, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x385FF90", Offset = "0x385EF90", VA = "0x18385FF90")]
	internal global::NJDMJLBGKBG<TSyncFieldValue> CHKAFEKNPID(global::JIJCDEFKIBB<FOOOECCBPJE> EKLMLCMCLFI, global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK, string MKDJIBNCKNC, in TSyncFieldValue MPHFKGJNMOK, Action HKHGMJEBNHA, Action<object> NEIILOKKBPO, Func<bool> JBKECHDOJJE)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3860440", Offset = "0x385F440", VA = "0x183860440")]
	internal void HCEIHBOKCPE(global::JIJCDEFKIBB<FOOOECCBPJE> EKLMLCMCLFI, string MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3860F40", Offset = "0x385FF40", VA = "0x183860F40")]
	internal void LIELNFHIMIA(global::OENJNNGNIIO<TSyncFieldValue> CGIIFGOPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3860A80", Offset = "0x385FA80", VA = "0x183860A80")]
	internal void KIKECHNMBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3860530", Offset = "0x385F530", VA = "0x183860530")]
	internal void KFGPCGOPNEJ(in global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x385FC80", Offset = "0x385EC80", VA = "0x18385FC80")]
	[CompilerGenerated]
	private global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AGGOEAAEEMB(in global::JIJCDEFKIBB<FOOOECCBPJE> GHCLOAGCOKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NHIOHAOCPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly global::JIJCDEFKIBB<AINBIGGIEKH> HPONHIJEDLB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x18F9410", Offset = "0x18F8410", VA = "0x1818F9410")]
	private NHIOHAOCPED(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5598D0", Offset = "0x5588D0", VA = "0x1805598D0")]
	public static NHIOHAOCPED CIAOGEOFBKG(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
		return default(NHIOHAOCPED);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FLFBIMKCMGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> IAPGACBIOBM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x18F9410", Offset = "0x18F8410", VA = "0x1818F9410")]
	private FLFBIMKCMGD(in global::JIJCDEFKIBB<FOOOECCBPJE> EEFFNIFFEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5598D0", Offset = "0x5588D0", VA = "0x1805598D0")]
	public static FLFBIMKCMGD CIAOGEOFBKG(in global::JIJCDEFKIBB<FOOOECCBPJE> EEFFNIFFEGB)
	{
		return default(FLFBIMKCMGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct NJDMJLBGKBG<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly BIJHJKPHMII CLGGEALLAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly global::OENJNNGNIIO<TSyncFieldValue> HJGDMIGDJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Action LPINCBEPDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Action<object> AANEIIKPJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Func<bool> ILAKAJOKCFJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40A4FC0", Offset = "0x40A3FC0", VA = "0x1840A4FC0")]
	private NJDMJLBGKBG(BIJHJKPHMII FJGKHJDIAEI, global::OENJNNGNIIO<TSyncFieldValue> BNBCHHDKBBF, Action HKHGMJEBNHA, Action<object> NEIILOKKBPO, Func<bool> JBKECHDOJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40A4E60", Offset = "0x40A3E60", VA = "0x1840A4E60")]
	public static global::NJDMJLBGKBG<TSyncFieldValue> CIAOGEOFBKG(global::OENJNNGNIIO<TSyncFieldValue> BNBCHHDKBBF, Action HKHGMJEBNHA, Action<object> NEIILOKKBPO, Func<bool> JBKECHDOJJE)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OENJNNGNIIO<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly string FJPMPBHLOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TSyncFieldValue NLLJAAOBNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly Dictionary<global::JIJCDEFKIBB<FOOOECCBPJE>, global::JIJCDEFKIBB<ADJCAKHFMDL>> KIDBKCJIAFN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F47140", Offset = "0x3F46140", VA = "0x183F47140")]
	private OENJNNGNIIO(string MKDJIBNCKNC, in TSyncFieldValue MPHFKGJNMOK, Dictionary<global::JIJCDEFKIBB<FOOOECCBPJE>, global::JIJCDEFKIBB<ADJCAKHFMDL>> LLEDBMKKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F47020", Offset = "0x3F46020", VA = "0x183F47020")]
	public static global::OENJNNGNIIO<TSyncFieldValue> CIAOGEOFBKG(string MKDJIBNCKNC, in TSyncFieldValue MPHFKGJNMOK)
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

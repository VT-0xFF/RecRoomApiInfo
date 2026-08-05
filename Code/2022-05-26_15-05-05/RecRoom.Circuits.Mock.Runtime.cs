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
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
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
			[Cpp2IlInjected.Address(RVA = "0x34B4D90", Offset = "0x34B3390", VA = "0x1834B4D90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public PLAILCIGNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x34B4C80", Offset = "0x34B3280", VA = "0x1834B4C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x34A8650", Offset = "0x34A6C50", VA = "0x1834A8650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34A89A0", Offset = "0x34A6FA0", VA = "0x1834A89A0", Slot = "5")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x34A8C10", Offset = "0x34A7210", VA = "0x1834A8C10")]
	protected EDNBHGMFDCB(global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BPGHHPMNGIK, global::KCEOEKIAPNP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::NJDMJLBGKBG<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OBENFPAHMII, global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNGJLMLBKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3080560", Offset = "0x307EB60", VA = "0x183080560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34A8000", Offset = "0x34A6600", VA = "0x1834A8000")]
	public static global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CIAOGEOFBKG(global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BPGHHPMNGIK, global::KCEOEKIAPNP<NHIOHAOCPED, global::JIJCDEFKIBB<FOOOECCBPJE>, TRpcParam, TRpcReceiver, global::NJDMJLBGKBG<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> OBENFPAHMII, global::BPAEAECMIMP<TAction, TActionReceiver, TActionDeps, global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNGJLMLBKPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20B65D0", Offset = "0x20B4BD0", VA = "0x1820B65D0")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK()
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34A8480", Offset = "0x34A6A80", VA = "0x1834A8480")]
	internal global::JIJCDEFKIBB<EIIDBGPEGBB> HEILDHMCAML(in global::JIJCDEFKIBB<AINBIGGIEKH> IAKMMHHICJO, in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34A8AF0", Offset = "0x34A70F0", VA = "0x1834A8AF0")]
	internal void OLEJHJEIIJO(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34A8A00", Offset = "0x34A7000", VA = "0x1834A8A00")]
	internal void NBOFNOBAJDL(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34A83F0", Offset = "0x34A69F0", VA = "0x1834A83F0")]
	internal void GBOEFIGCLMA(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34A8580", Offset = "0x34A6B80", VA = "0x1834A8580")]
	internal void JHKGIIIALFC(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34A88E0", Offset = "0x34A6EE0", VA = "0x1834A88E0")]
	internal void LIELNFHIMIA(in global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34A8A60", Offset = "0x34A7060", VA = "0x1834A8A60")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NMFPDKBKOEC(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x34A88B0", Offset = "0x34A6EB0", VA = "0x1834A88B0")]
	public void KLLPJKELLIA(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34A8170", Offset = "0x34A6770", VA = "0x1834A8170")]
	public void EGGAAPGMCEI(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34A81D0", Offset = "0x34A67D0", VA = "0x1834A81D0")]
	public void EKBGGIAHPGB(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34A8140", Offset = "0x34A6740", VA = "0x1834A8140")]
	public void DMEHNAIEAJF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x34A8BE0", Offset = "0x34A71E0", VA = "0x1834A8BE0")]
	public void PEGLFJKHLDO(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34A80E0", Offset = "0x34A66E0", VA = "0x1834A80E0")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34A8AC0", Offset = "0x34A70C0", VA = "0x1834A8AC0")]
	public bool OJEBBMDJDNN(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34A89D0", Offset = "0x34A6FD0", VA = "0x1834A89D0")]
	public global::JIJCDEFKIBB<ADJCAKHFMDL> MKKIIHMLFCJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34A7F40", Offset = "0x34A6540", VA = "0x1834A7F40")]
	public void AECFGMPHHIB(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34A7FA0", Offset = "0x34A65A0", VA = "0x1834A7FA0")]
	public void BCAIIKHABBD(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34A86B0", Offset = "0x34A6CB0", VA = "0x1834A86B0")]
	public Task<global::COPPIENFOJP<object, GIGPDIEHPEM>> KFGPCGOPNEJ(in TAction BKCLKIJOKLP, bool GNMNBNFPAII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x34A8200", Offset = "0x34A6800", VA = "0x1834A8200")]
	public void FCDBIJHHPEM(in TActionReceiver NEDAGCALOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x34A8230", Offset = "0x34A6830", VA = "0x1834A8230")]
	public void FFNBNIMAOLF(in global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x34A83C0", Offset = "0x34A69C0", VA = "0x1834A83C0", Slot = "6")]
	private void FPMCFEKACCM(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x34A81A0", Offset = "0x34A67A0", VA = "0x1834A81A0", Slot = "7")]
	private void EJKOEEMCIGL(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x34A8BB0", Offset = "0x34A71B0", VA = "0x1834A8BB0", Slot = "8")]
	private void PCDKPJKBJOP(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x34A8620", Offset = "0x34A6C20", VA = "0x1834A8620", Slot = "9")]
	private void JICFDNANLLF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34A7FD0", Offset = "0x34A65D0", VA = "0x1834A7FD0", Slot = "10")]
	private void BCBNGAFFLIC(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in TRpcReceiver OPNHBKMFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x34A7F70", Offset = "0x34A6570", VA = "0x1834A7F70", Slot = "11")]
	private global::JIJCDEFKIBB<FOOOECCBPJE> ANKJJGBCHIJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x34A8B80", Offset = "0x34A7180", VA = "0x1834A8B80", Slot = "12")]
	private bool OMKLMAJMOGF(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x34A8520", Offset = "0x34A6B20", VA = "0x1834A8520", Slot = "13")]
	private global::JIJCDEFKIBB<ADJCAKHFMDL> IGMHJABIPKJ(in global::JIJCDEFKIBB<EIIDBGPEGBB> FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::JIJCDEFKIBB<ADJCAKHFMDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x34A8110", Offset = "0x34A6710", VA = "0x1834A8110", Slot = "14")]
	private void CMJJNFGGIKO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x34A8550", Offset = "0x34A6B50", VA = "0x1834A8550", Slot = "15")]
	private void IKBCLMIFMBO(in global::JIJCDEFKIBB<ADJCAKHFMDL> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x34A8450", Offset = "0x34A6A50", VA = "0x1834A8450", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EC670", Offset = "0x5EAC70", VA = "0x1805EC670", Slot = "4")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> FIKMAKNIACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EC670", Offset = "0x5EAC70", VA = "0x1805EC670", Slot = "14")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2695880", Offset = "0x2693E80", VA = "0x182695880")]
	private BCNGGJEOPCM(global::MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> INENLDCAHJL, in global::JIJCDEFKIBB<FOOOECCBPJE> IAKMMHHICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x26951A0", Offset = "0x26937A0", VA = "0x1826951A0")]
	public static global::BCNGGJEOPCM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CIAOGEOFBKG(in global::JIJCDEFKIBB<FOOOECCBPJE> IAKMMHHICJO, global::MPJGCJNKBMJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> INENLDCAHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26957A0", Offset = "0x2693DA0", VA = "0x1826957A0")]
	public global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK()
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26955B0", Offset = "0x2693BB0", VA = "0x1826955B0")]
	public void KLLPJKELLIA(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2695420", Offset = "0x2693A20", VA = "0x182695420")]
	public void EGGAAPGMCEI(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26954B0", Offset = "0x2693AB0", VA = "0x1826954B0")]
	public void EKBGGIAHPGB(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2695340", Offset = "0x2693940", VA = "0x182695340")]
	public void DMEHNAIEAJF(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2695270", Offset = "0x2693870", VA = "0x182695270")]
	public global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26957E0", Offset = "0x2693DE0", VA = "0x1826957E0")]
	public bool OJEBBMDJDNN(in NHIOHAOCPED FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2695690", Offset = "0x2693C90", VA = "0x182695690")]
	public global::NJDMJLBGKBG<TSyncFieldValue> MKKIIHMLFCJ(in global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK, in NHIOHAOCPED KJDKGIBIDOI, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2695080", Offset = "0x2693680", VA = "0x182695080")]
	public void AECFGMPHHIB(in global::NJDMJLBGKBG<TSyncFieldValue> JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26955F0", Offset = "0x2693BF0", VA = "0x1826955F0")]
	public void LIPLEJHNLCB(in global::NJDMJLBGKBG<TSyncFieldValue> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2695580", Offset = "0x2693B80", VA = "0x182695580", Slot = "15")]
	public void KIKECHNMBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2695540", Offset = "0x2693B40", VA = "0x182695540")]
	public void KFGPCGOPNEJ(in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2695140", Offset = "0x2693740", VA = "0x182695140", Slot = "5")]
	private void BENGBICDHLI(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2695110", Offset = "0x2693710", VA = "0x182695110", Slot = "6")]
	private void AMNNBJLGJJC(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2695770", Offset = "0x2693D70", VA = "0x182695770", Slot = "7")]
	private void MLFLNAFCPAE(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26953C0", Offset = "0x26939C0", VA = "0x1826953C0", Slot = "8")]
	private void DOCDOACGBDN(in NHIOHAOCPED FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26950E0", Offset = "0x26936E0", VA = "0x1826950E0", Slot = "9")]
	private global::JIJCDEFKIBB<FOOOECCBPJE> AJLFBNOLEIJ(in NHIOHAOCPED FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2695310", Offset = "0x2693910", VA = "0x182695310", Slot = "10")]
	private bool DBKNFNPAIKA(in NHIOHAOCPED FIEDOLNFNLH, in global::JIJCDEFKIBB<FOOOECCBPJE> JLDONLICNFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x26952A0", Offset = "0x26938A0", VA = "0x1826952A0", Slot = "11")]
	private global::NJDMJLBGKBG<TSyncFieldValue> CLLHBKFOEDI(in global::JIJCDEFKIBB<ADJCAKHFMDL> DNNJPGCJGFN, in NHIOHAOCPED FIEDOLNFNLH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) JIGKFMMLBHO)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2695660", Offset = "0x2693C60", VA = "0x182695660", Slot = "12")]
	private void MJNOENCEDND(in global::NJDMJLBGKBG<TSyncFieldValue> JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2695170", Offset = "0x2693770", VA = "0x182695170", Slot = "13")]
	private void BHCKLJJAMND(in global::NJDMJLBGKBG<TSyncFieldValue> OMOCMDDIDHA, in TSyncFieldValue MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26953F0", Offset = "0x26939F0", VA = "0x1826953F0", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0")]
		get
		{
			return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31568B0", Offset = "0x3154EB0", VA = "0x1831568B0")]
	protected MPJGCJNKBMJ(TActionDeps ELNLDKFLDHC, int? FGOLMPKJGGM, int? BOFGHPAOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3155210", Offset = "0x3153810", VA = "0x183155210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3155B30", Offset = "0x3154130", VA = "0x183155B30")]
	public global::EDNBHGMFDCB<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KPIDAJNGINK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3156520", Offset = "0x3154B20", VA = "0x183156520")]
	internal global::JIJCDEFKIBB<EIIDBGPEGBB> NKIIBPIDICK(in global::JIJCDEFKIBB<FOOOECCBPJE> EEFFNIFFEGB)
	{
		return default(global::JIJCDEFKIBB<EIIDBGPEGBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3154DD0", Offset = "0x31533D0", VA = "0x183154DD0")]
	internal void CDANPMFEOKF(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31551B0", Offset = "0x31537B0", VA = "0x1831551B0")]
	internal global::JIJCDEFKIBB<FOOOECCBPJE> CJPELNDHGMF(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
		return default(global::JIJCDEFKIBB<FOOOECCBPJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3154F80", Offset = "0x3153580", VA = "0x183154F80")]
	internal void CHJAMOGCBNJ(in global::JIJCDEFKIBB<FOOOECCBPJE> IAMNHCHAEGD, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3156210", Offset = "0x3154810", VA = "0x183156210")]
	internal void MLGDILENALK(in global::JIJCDEFKIBB<FOOOECCBPJE> OMLDPEFLBFK, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3156290", Offset = "0x3154890", VA = "0x183156290")]
	internal void NKEMPAIILAP(in global::JIJCDEFKIBB<FOOOECCBPJE> IAMNHCHAEGD, in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH, in TRpcParam JIGKFMMLBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3155010", Offset = "0x3153610", VA = "0x183155010")]
	internal global::NJDMJLBGKBG<TSyncFieldValue> CHKAFEKNPID(global::JIJCDEFKIBB<FOOOECCBPJE> EKLMLCMCLFI, global::JIJCDEFKIBB<ADJCAKHFMDL> CGIIFGOPDLK, string MKDJIBNCKNC, in TSyncFieldValue MPHFKGJNMOK, Action HKHGMJEBNHA, Action<object> NEIILOKKBPO, Func<bool> JBKECHDOJJE)
	{
		return default(global::NJDMJLBGKBG<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x31554C0", Offset = "0x3153AC0", VA = "0x1831554C0")]
	internal void HCEIHBOKCPE(global::JIJCDEFKIBB<FOOOECCBPJE> EKLMLCMCLFI, string MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3155FC0", Offset = "0x31545C0", VA = "0x183155FC0")]
	internal void LIELNFHIMIA(global::OENJNNGNIIO<TSyncFieldValue> CGIIFGOPDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3155B00", Offset = "0x3154100", VA = "0x183155B00")]
	internal void KIKECHNMBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x31555B0", Offset = "0x3153BB0", VA = "0x1831555B0")]
	internal void KFGPCGOPNEJ(in global::JIJCDEFKIBB<FOOOECCBPJE> PLFEGFLMJIJ, in global::JIJCDEFKIBB<HNMDOHCOCOP> MJHHNBMJNKB, in TAction BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3154D00", Offset = "0x3153300", VA = "0x183154D00")]
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
	[Cpp2IlInjected.Address(RVA = "0xB07890", Offset = "0xB05E90", VA = "0x180B07890")]
	private NHIOHAOCPED(in global::JIJCDEFKIBB<AINBIGGIEKH> FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460")]
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
	[Cpp2IlInjected.Address(RVA = "0xB07890", Offset = "0xB05E90", VA = "0x180B07890")]
	private FLFBIMKCMGD(in global::JIJCDEFKIBB<FOOOECCBPJE> EEFFNIFFEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D1460", Offset = "0x7CFA60", VA = "0x1807D1460")]
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
	[Cpp2IlInjected.Address(RVA = "0x34349D0", Offset = "0x3432FD0", VA = "0x1834349D0")]
	private NJDMJLBGKBG(BIJHJKPHMII FJGKHJDIAEI, global::OENJNNGNIIO<TSyncFieldValue> BNBCHHDKBBF, Action HKHGMJEBNHA, Action<object> NEIILOKKBPO, Func<bool> JBKECHDOJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3434870", Offset = "0x3432E70", VA = "0x183434870")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DD71F0", Offset = "0x3DD57F0", VA = "0x183DD71F0")]
	private OENJNNGNIIO(string MKDJIBNCKNC, in TSyncFieldValue MPHFKGJNMOK, Dictionary<global::JIJCDEFKIBB<FOOOECCBPJE>, global::JIJCDEFKIBB<ADJCAKHFMDL>> LLEDBMKKMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD70D0", Offset = "0x3DD56D0", VA = "0x183DD70D0")]
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

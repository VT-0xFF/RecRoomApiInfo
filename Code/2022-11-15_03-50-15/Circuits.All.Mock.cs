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
public sealed class KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam> where TActionReceiver : global::DBENPCMHIAF<TAction, Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>>> where TActionDeps : global::ABBMOOBKCLK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FIHLLKOEHFJ
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
			public FIHLLKOEHFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x162AC40", Offset = "0x1629640", VA = "0x18162AC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public FIHLLKOEHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1DD67F0", Offset = "0x1DD51F0", VA = "0x181DD67F0")]
		[AsyncStateMachine(typeof(global::KFOBGGGJMIG<, , , , , >.FIHLLKOEHFJ.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CALHALNNKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::MILDMIBLDIO<NEBJCMEIODB>, global::MILDMIBLDIO<JAIHIEKEHOM>> IANLHMDNGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::MILDMIBLDIO<NEBJCMEIODB>> MEAAPAEILAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::EMINNCDMFKM<int> AHKNOALEMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::MILDMIBLDIO<FCOAMEIJFML> ActorId, global::MILDMIBLDIO<HHLNMPACLPP> RequestId, TAction Action)> DKNEIHBKBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool IEJMPPIMAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> JLLMCCPPNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::KJLOFFLDEGK<JMKGFPKIMJO, global::MILDMIBLDIO<FCOAMEIJFML>, TRpcParam, TRpcReceiver, global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PEAMOHJIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> AFONDIMOOHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool FLBPDOHNGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2417C70", Offset = "0x2416670", VA = "0x182417C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::MILDMIBLDIO<FCOAMEIJFML> CEOCLGGEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2417A90", Offset = "0x2416490", VA = "0x182417A90")]
		get
		{
			return default(global::MILDMIBLDIO<FCOAMEIJFML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2418530", Offset = "0x2416F30", VA = "0x182418530")]
	private KFOBGGGJMIG(global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MOAJGIGLIIO, global::KJLOFFLDEGK<JMKGFPKIMJO, global::MILDMIBLDIO<FCOAMEIJFML>, TRpcParam, TRpcReceiver, global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PNJPDJKFCAN, global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNJBNHCJGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2417B50", Offset = "0x2416550", VA = "0x182417B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2418230", Offset = "0x2416C30", VA = "0x182418230")]
	internal static global::KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NDGDIJBCNJC(global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MOAJGIGLIIO, global::KJLOFFLDEGK<JMKGFPKIMJO, global::MILDMIBLDIO<FCOAMEIJFML>, TRpcParam, TRpcReceiver, global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PNJPDJKFCAN, global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BNJBNHCJGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2417A60", Offset = "0x2416460", VA = "0x182417A60")]
	public global::MILDMIBLDIO<JAIHIEKEHOM> ADHCIKIHOJE()
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24183E0", Offset = "0x2416DE0", VA = "0x1824183E0")]
	internal global::MILDMIBLDIO<JAIHIEKEHOM> PGJBPFFCFFA(global::MILDMIBLDIO<NEBJCMEIODB> ENFGKNDHLNI, in JMKGFPKIMJO PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24184B0", Offset = "0x2416EB0", VA = "0x1824184B0")]
	internal void PINOPEBINLM(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2417C10", Offset = "0x2416610", VA = "0x182417C10")]
	internal void GBDCMGKPPLC(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24180A0", Offset = "0x2416AA0", VA = "0x1824180A0")]
	internal void JMJEPGOKINF(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2418310", Offset = "0x2416D10", VA = "0x182418310")]
	internal void NMNMCHGCIIA(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2418100", Offset = "0x2416B00", VA = "0x182418100")]
	internal void KOHCPKJEBEL(global::MILDMIBLDIO<FAPEGLKNBBF> OPHCOPAJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2417AF0", Offset = "0x24164F0", VA = "0x182417AF0")]
	public global::MILDMIBLDIO<JAIHIEKEHOM> CNJGFNNPPEO(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2417B80", Offset = "0x2416580", VA = "0x182417B80")]
	public void EAEAJBGPKDB(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24183B0", Offset = "0x2416DB0", VA = "0x1824183B0")]
	public void OEGMLIJDIGC(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2417BB0", Offset = "0x24165B0", VA = "0x182417BB0")]
	public void EOJCOOEOEEE(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2418070", Offset = "0x2416A70", VA = "0x182418070")]
	public void JCMOHOCAJMD(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2418040", Offset = "0x2416A40", VA = "0x182418040")]
	public void JAHFAOMDJCL(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in TRpcReceiver EOHIKAPDMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2417A30", Offset = "0x2416430", VA = "0x182417A30")]
	public global::MILDMIBLDIO<FCOAMEIJFML> ACLKABFCJIG(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<FCOAMEIJFML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24181C0", Offset = "0x2416BC0", VA = "0x1824181C0")]
	public bool LFCPNKNNIPH(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, global::MILDMIBLDIO<FCOAMEIJFML> IBALNAIHOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2418200", Offset = "0x2416C00", VA = "0x182418200")]
	public global::MILDMIBLDIO<FAPEGLKNBBF> MKLGEOOCGDM(global::MILDMIBLDIO<JAIHIEKEHOM> PDHKCBEBPNG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HOCPDJAJOIH)
	{
		return default(global::MILDMIBLDIO<FAPEGLKNBBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2417AC0", Offset = "0x24164C0", VA = "0x182417AC0")]
	public void BFFFKFHGBKK(global::MILDMIBLDIO<FAPEGLKNBBF> FELFGFPIGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2418480", Offset = "0x2416E80", VA = "0x182418480")]
	public void PIGDDNAIOFI(global::MILDMIBLDIO<FAPEGLKNBBF> FELFGFPIGEP, in TSyncFieldValue NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2417CE0", Offset = "0x24166E0", VA = "0x182417CE0")]
	public Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>> HFNIJIKBPGA(in TAction LBPAPOGAAHD, bool NKBCABNHNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2417BE0", Offset = "0x24165E0", VA = "0x182417BE0")]
	public void FONMENFDCIP(in TActionReceiver FMKMDNEMGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2417EB0", Offset = "0x24168B0", VA = "0x182417EB0")]
	public void HLAKBDJNNAP(global::MILDMIBLDIO<FCOAMEIJFML> NAPNJBCBGJA, global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, in TAction LBPAPOGAAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::MBJOFPMJNMO<JMKGFPKIMJO, global::MILDMIBLDIO<FCOAMEIJFML>, TRpcParam, global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::DKCCKCPKBCP<TAction> where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam> where TActionReceiver : global::DBENPCMHIAF<TAction, Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>>> where TActionDeps : global::ABBMOOBKCLK<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::DLIOOGOBHPP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IJAOMDGPAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::MILDMIBLDIO<FCOAMEIJFML> DAEPNGIGOBG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::MILDMIBLDIO<FCOAMEIJFML> CEOCLGGEKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70", Slot = "4")]
		get
		{
			return default(global::MILDMIBLDIO<FCOAMEIJFML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::MILDMIBLDIO<FCOAMEIJFML> KFACOOCDCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70", Slot = "14")]
		get
		{
			return default(global::MILDMIBLDIO<FCOAMEIJFML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x23C5F10", Offset = "0x23C4910", VA = "0x1823C5F10")]
	private HGMOJNFBKBN(global::DLIOOGOBHPP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NBKJPJPMJNL, global::MILDMIBLDIO<FCOAMEIJFML> ENFGKNDHLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x23C5CC0", Offset = "0x23C46C0", VA = "0x1823C5CC0")]
	public static global::HGMOJNFBKBN<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NDGDIJBCNJC(global::MILDMIBLDIO<FCOAMEIJFML> ENFGKNDHLNI, global::DLIOOGOBHPP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NBKJPJPMJNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23C57E0", Offset = "0x23C41E0", VA = "0x1823C57E0")]
	public global::MILDMIBLDIO<JAIHIEKEHOM> ADHCIKIHOJE()
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x23C5880", Offset = "0x23C4280", VA = "0x1823C5880")]
	public void EAEAJBGPKDB(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x23C5D90", Offset = "0x23C4790", VA = "0x1823C5D90")]
	public void OEGMLIJDIGC(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23C5930", Offset = "0x23C4330", VA = "0x1823C5930")]
	public void EOJCOOEOEEE(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x23C5AB0", Offset = "0x23C44B0", VA = "0x1823C5AB0")]
	public void JCMOHOCAJMD(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x23C57A0", Offset = "0x23C41A0", VA = "0x1823C57A0")]
	public global::MILDMIBLDIO<FCOAMEIJFML> ACLKABFCJIG(in JMKGFPKIMJO PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<FCOAMEIJFML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23C5B30", Offset = "0x23C4530", VA = "0x1823C5B30")]
	public bool LFCPNKNNIPH(in JMKGFPKIMJO PDHKCBEBPNG, global::MILDMIBLDIO<FCOAMEIJFML> IBALNAIHOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23C5BF0", Offset = "0x23C45F0", VA = "0x1823C5BF0")]
	public global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> MKLGEOOCGDM(global::MILDMIBLDIO<FAPEGLKNBBF> OPHCOPAJHLF, in JMKGFPKIMJO FFJJMLKNOBA, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HOCPDJAJOIH)
	{
		return default(global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x23C5820", Offset = "0x23C4220", VA = "0x1823C5820")]
	public void BFFFKFHGBKK(in global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x23C58C0", Offset = "0x23C42C0", VA = "0x1823C58C0")]
	public void EBJNCLPJHBO(in global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> FELFGFPIGEP, in TSyncFieldValue NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x23C5A50", Offset = "0x23C4450", VA = "0x1823C5A50", Slot = "15")]
	public void HMCGGAGODJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x23C59E0", Offset = "0x23C43E0", VA = "0x1823C59E0")]
	public void HFNIJIKBPGA(global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, in TAction LBPAPOGAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x23C5EE0", Offset = "0x23C48E0", VA = "0x1823C5EE0", Slot = "5")]
	private void PPNBFMBGJGD(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x23C5BC0", Offset = "0x23C45C0", VA = "0x1823C5BC0", Slot = "6")]
	private void MHLKCIGPHIP(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x23C5A20", Offset = "0x23C4420", VA = "0x1823C5A20", Slot = "7")]
	private void HIELNFOIEMD(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x23C5EB0", Offset = "0x23C48B0", VA = "0x1823C5EB0", Slot = "8")]
	private void PAFLOAIEPFI(in JMKGFPKIMJO PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23C5E10", Offset = "0x23C4810", VA = "0x1823C5E10", Slot = "9")]
	private global::MILDMIBLDIO<FCOAMEIJFML> OEJBFPKPHLJ(in JMKGFPKIMJO PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<FCOAMEIJFML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x23C5A80", Offset = "0x23C4480", VA = "0x1823C5A80", Slot = "10")]
	private bool JBIFHBMPJCI(in JMKGFPKIMJO PDHKCBEBPNG, global::MILDMIBLDIO<FCOAMEIJFML> IBALNAIHOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x23C5E40", Offset = "0x23C4840", VA = "0x1823C5E40", Slot = "11")]
	private global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> OIMOCDMPNBN(global::MILDMIBLDIO<FAPEGLKNBBF> ENFGKNDHLNI, in JMKGFPKIMJO PDHKCBEBPNG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) HOCPDJAJOIH)
	{
		return default(global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B54E90", Offset = "0x1B53890", VA = "0x181B54E90", Slot = "12")]
	private void JKGMIKIFBCO(in global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x23C59B0", Offset = "0x23C43B0", VA = "0x1823C59B0", Slot = "13")]
	private void FLHNPGHKGEI(in global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> FELFGFPIGEP, in TSyncFieldValue NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20EE8E0", Offset = "0x20ED2E0", VA = "0x1820EE8E0", Slot = "16")]
	private void BHGHEAFEIEB(global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, in TAction LBPAPOGAAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DLIOOGOBHPP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::BNCHMDKHKLM<TRpcParam> where TActionReceiver : global::DBENPCMHIAF<TAction, Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>>> where TActionDeps : global::ABBMOOBKCLK<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::MILDMIBLDIO<FCOAMEIJFML> KCLMBNFMKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::GEJFNEKJJOI<NEBJCMEIODB, global::EMGDIJMFEID<FCOAMEIJFML>> KMMGAFMHKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::IMLEBEMHBNG<FCOAMEIJFML, TSyncFieldValue>> NDDMHIHAKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::BMJMMMBJNHF<FCOAMEIJFML, global::KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HOOGANLIIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps JKPFCPNNCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::MILDMIBLDIO<FCOAMEIJFML> ActorId, global::MILDMIBLDIO<HHLNMPACLPP> RequestId, TAction Action)> FJFPMCNAIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? IDKHKKIILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? ICGMFHEGDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::MILDMIBLDIO<FCOAMEIJFML> ActorId, global::MILDMIBLDIO<HHLNMPACLPP> RequestId, TAction Action)> IKCBJGBFPLN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::MILDMIBLDIO<FCOAMEIJFML> FAOPLCFJCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
		get
		{
			return default(global::MILDMIBLDIO<FCOAMEIJFML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3578480", Offset = "0x3576E80", VA = "0x183578480")]
	protected DLIOOGOBHPP(TActionDeps CILIGPIAHLD, int? BIDKNHEECMI, int? PLFHDHFGDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3576B90", Offset = "0x3575590", VA = "0x183576B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3575E70", Offset = "0x3574870", VA = "0x183575E70")]
	public global::KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CLPHFMLHIOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3575B70", Offset = "0x3574570", VA = "0x183575B70")]
	internal global::MILDMIBLDIO<JAIHIEKEHOM> ADHCIKIHOJE(global::MILDMIBLDIO<FCOAMEIJFML> IOILBGIEEFJ)
	{
		return default(global::MILDMIBLDIO<JAIHIEKEHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3577530", Offset = "0x3575F30", VA = "0x183577530")]
	internal void FEKMLJKHEGB(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3575B20", Offset = "0x3574520", VA = "0x183575B20")]
	internal global::MILDMIBLDIO<FCOAMEIJFML> ACLKABFCJIG(global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG)
	{
		return default(global::MILDMIBLDIO<FCOAMEIJFML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3578250", Offset = "0x3576C50", VA = "0x183578250")]
	internal void PNDMIEFLDPN(global::MILDMIBLDIO<FCOAMEIJFML> IDIEPMOAFEJ, global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3576B20", Offset = "0x3575520", VA = "0x183576B20")]
	internal void DJAFDMNJCHO(global::MILDMIBLDIO<FCOAMEIJFML> CCGAHFILEBA, global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3577870", Offset = "0x3576270", VA = "0x183577870")]
	internal void GNANBENJIJC(global::MILDMIBLDIO<FCOAMEIJFML> IDIEPMOAFEJ, global::MILDMIBLDIO<NEBJCMEIODB> PDHKCBEBPNG, in TRpcParam HOCPDJAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35782E0", Offset = "0x3576CE0", VA = "0x1835782E0")]
	internal global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue> PNKNIFAGMEB(global::MILDMIBLDIO<FCOAMEIJFML> NOLEIAJMJHA, global::MILDMIBLDIO<FAPEGLKNBBF> OPHCOPAJHLF, string KFEMFMGCJPM, in TSyncFieldValue NKJMIDIDBOE, Action MLFGBBGKHEO, Action<object> POKEEFCMCGF, Func<bool> MEHNBGEMMNH)
	{
		return default(global::HPFKIGIMGDN<FCOAMEIJFML, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3577780", Offset = "0x3576180", VA = "0x183577780")]
	internal void FHHGONBBBFP(global::MILDMIBLDIO<FCOAMEIJFML> NOLEIAJMJHA, string KFEMFMGCJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3578030", Offset = "0x3576A30", VA = "0x183578030")]
	internal void KOHCPKJEBEL(global::IMLEBEMHBNG<FCOAMEIJFML, TSyncFieldValue> OPHCOPAJHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3577F20", Offset = "0x3576920", VA = "0x183577F20")]
	internal void HMCGGAGODJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3577A90", Offset = "0x3576490", VA = "0x183577A90")]
	internal void HFNIJIKBPGA(global::MILDMIBLDIO<FCOAMEIJFML> NAPNJBCBGJA, global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, in TAction LBPAPOGAAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3577F60", Offset = "0x3576960", VA = "0x183577F60")]
	[CompilerGenerated]
	private global::KFOBGGGJMIG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KNPOHOFPCHC(global::MILDMIBLDIO<FCOAMEIJFML> BAJDIMGNPAL)
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

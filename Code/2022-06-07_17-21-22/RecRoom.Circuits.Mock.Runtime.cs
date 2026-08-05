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
public readonly struct OGKLMGNKPCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable, global::DNEHNNINBHD<global::EMJMCNHDCKE<DPFCNHBBOCD>, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::EMJMCNHDCKE<DELFKKIBLAM>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::KPPFLOLLHAM<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>, TActionReceiver> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam> where TActionReceiver : global::GAECGMPHMKD<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>> where TActionDeps : global::NDGMIODNGAD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class NBMHJMFECPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public NBMHJMFECPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class DLJGJHFHOLN
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
			public DLJGJHFHOLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private TaskAwaiter<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x37BF580", Offset = "0x37BDD80", VA = "0x1837BF580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NBMHJMFECPP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public DLJGJHFHOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37B4500", Offset = "0x37B2D00", VA = "0x1837B4500")]
		[AsyncStateMachine(typeof(global::PKKKCEGMINJ<, , , , , >.DLJGJHFHOLN.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EGAGNOCKMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::EMJMCNHDCKE<OGKLMGNKPCE>, global::EMJMCNHDCKE<DPFCNHBBOCD>> EKBHBKDFOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::EMJMCNHDCKE<OGKLMGNKPCE>> DDPBLFDMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::CDLIANONNJA<int> PMBLCMOMMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::EMJMCNHDCKE<NMDMCNKPNFB> ActorId, global::EMJMCNHDCKE<PLMPGGHOKJJ> RequestId, TAction Action)> PPLOHNHOCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool CGGBDPLNDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> LIDACLFMALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::PCLDILJGFEK<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::MMPHMPGHOKJ<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DONPALAKIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JBJGHOGKIPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool BJJILFFPJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x37BE6A0", Offset = "0x37BCEA0", VA = "0x1837BE6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> OJNPAMCAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37BE160", Offset = "0x37BC960", VA = "0x1837BE160", Slot = "5")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37BE890", Offset = "0x37BD090", VA = "0x1837BE890")]
	protected PKKKCEGMINJ(global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KBKIMKGOABO, global::PCLDILJGFEK<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::MMPHMPGHOKJ<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MMMHKGLPGIB, global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ECGJGPDGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37BDFB0", Offset = "0x37BC7B0", VA = "0x1837BDFB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37BDC80", Offset = "0x37BC480", VA = "0x1837BDC80")]
	public static global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BAPHMNFAJJN(global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KBKIMKGOABO, global::PCLDILJGFEK<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::MMPHMPGHOKJ<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MMMHKGLPGIB, global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ECGJGPDGCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D982D0", Offset = "0x1D96AD0", VA = "0x181D982D0")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD()
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37BE700", Offset = "0x37BCF00", VA = "0x1837BE700")]
	internal global::EMJMCNHDCKE<DPFCNHBBOCD> MCGFPDIEJKL(in global::EMJMCNHDCKE<OGKLMGNKPCE> DDEJHPOCOHL, in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37BDE90", Offset = "0x37BC690", VA = "0x1837BDE90")]
	internal void DBKLCIGLFGJ(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37BE0D0", Offset = "0x37BC8D0", VA = "0x1837BE0D0")]
	internal void GGDIHJGNLLG(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37BDFE0", Offset = "0x37BC7E0", VA = "0x1837BDFE0")]
	internal void FCMICMMMHND(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37BDD60", Offset = "0x37BC560", VA = "0x1837BDD60")]
	internal void BPJEAMMMPAA(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37BE1C0", Offset = "0x37BC9C0", VA = "0x1837BE1C0")]
	internal void HMPDPEKJMNP(in global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37BE040", Offset = "0x37BC840", VA = "0x1837BE040")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> FHAPDFJNACC(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37BDE60", Offset = "0x37BC660", VA = "0x1837BDE60")]
	public void DADCAKCGKPB(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37BE2B0", Offset = "0x37BCAB0", VA = "0x1837BE2B0")]
	public void IDJIOJMGDCK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37BE190", Offset = "0x37BC990", VA = "0x1837BE190")]
	public void HIELBEHCMGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37BDF80", Offset = "0x37BC780", VA = "0x1837BDF80")]
	public void DNPKHOCLBPE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37BE280", Offset = "0x37BCA80", VA = "0x1837BE280")]
	public void IDHBDFCGOBH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37BDE30", Offset = "0x37BC630", VA = "0x1837BDE30")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37BDC50", Offset = "0x37BC450", VA = "0x1837BDC50")]
	public bool ALIKBNAPGDC(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x37BDE00", Offset = "0x37BC600", VA = "0x1837BDE00")]
	public global::EMJMCNHDCKE<DELFKKIBLAM> CMDMBCIEPCM(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37BDF20", Offset = "0x37BC720", VA = "0x1837BDF20")]
	public void DHNLGKCMPLN(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37BE7A0", Offset = "0x37BCFA0", VA = "0x1837BE7A0")]
	public void MHIFOHEJNJK(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37BE310", Offset = "0x37BCB10", VA = "0x1837BE310")]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> JIHHCIBGKMI(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37BE860", Offset = "0x37BD060", VA = "0x1837BE860")]
	public void PFFFOIAADML(in TActionReceiver IJPJNFBCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37BE510", Offset = "0x37BCD10", VA = "0x1837BE510")]
	public void KCJDPCGOHPH(in global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37BDF50", Offset = "0x37BC750", VA = "0x1837BDF50", Slot = "6")]
	private void DJLOPCAJCAJ(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x37BE0A0", Offset = "0x37BC8A0", VA = "0x1837BE0A0", Slot = "7")]
	private void GFMJKIBMPBP(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x37BE800", Offset = "0x37BD000", VA = "0x1837BE800", Slot = "8")]
	private void NKHLHGFGINA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37BE2E0", Offset = "0x37BCAE0", VA = "0x1837BE2E0", Slot = "9")]
	private void JFOEPCPIDDK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3764B30", Offset = "0x3763330", VA = "0x183764B30", Slot = "10")]
	private void JFOKJFKNFBA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37BE130", Offset = "0x37BC930", VA = "0x1837BE130", Slot = "11")]
	private global::EMJMCNHDCKE<NMDMCNKPNFB> GNMBEFPGMLE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3765090", Offset = "0x3763890", VA = "0x183765090", Slot = "12")]
	private bool FFKEANBIJPG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37650C0", Offset = "0x37638C0", VA = "0x1837650C0", Slot = "13")]
	private global::EMJMCNHDCKE<DELFKKIBLAM> PLIEKADJCDN(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37BE7D0", Offset = "0x37BCFD0", VA = "0x1837BE7D0", Slot = "14")]
	private void MLHBJPOJILE(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37BE830", Offset = "0x37BD030", VA = "0x1837BE830", Slot = "15")]
	private void PAMLDCMEAPB(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37634F0", Offset = "0x3761CF0", VA = "0x1837634F0", Slot = "16")]
	private Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> EEIIPBBMIHC(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::HKPIAGMHDBH<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, global::MMPHMPGHOKJ<TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::LHFKLJDBOMN<TAction> where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam> where TActionReceiver : global::GAECGMPHMKD<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>> where TActionDeps : global::NDGMIODNGAD<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EKBKHJOENPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly global::EMJMCNHDCKE<NMDMCNKPNFB> PKIBKKEAKJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> OJNPAMCAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED670", Offset = "0x5EBE70", VA = "0x1805ED670", Slot = "4")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> AEGNGGMAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5ED670", Offset = "0x5EBE70", VA = "0x1805ED670", Slot = "14")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3974B50", Offset = "0x3973350", VA = "0x183974B50")]
	private NFPPDGNBKLA(global::OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JGBLAEIFCCP, in global::EMJMCNHDCKE<NMDMCNKPNFB> DDEJHPOCOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x39744E0", Offset = "0x3972CE0", VA = "0x1839744E0")]
	public static global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BAPHMNFAJJN(in global::EMJMCNHDCKE<NMDMCNKPNFB> DDEJHPOCOHL, global::OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JGBLAEIFCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3974840", Offset = "0x3973040", VA = "0x183974840")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD()
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x39746F0", Offset = "0x3972EF0", VA = "0x1839746F0")]
	public void DADCAKCGKPB(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3974940", Offset = "0x3973140", VA = "0x183974940")]
	public void IDJIOJMGDCK(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3974880", Offset = "0x3973080", VA = "0x183974880")]
	public void HIELBEHCMGI(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x39747C0", Offset = "0x3972FC0", VA = "0x1839747C0")]
	public void DNPKHOCLBPE(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A03510", Offset = "0x2A01D10", VA = "0x182A03510")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3974440", Offset = "0x3972C40", VA = "0x183974440")]
	public bool ALIKBNAPGDC(in OABODKHHPND OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x39745E0", Offset = "0x3972DE0", VA = "0x1839745E0")]
	public global::MMPHMPGHOKJ<TSyncFieldValue> CMDMBCIEPCM(in global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO, in OABODKHHPND MBKAIJKLCJG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3974760", Offset = "0x3972F60", VA = "0x183974760")]
	public void DHNLGKCMPLN(in global::MMPHMPGHOKJ<TSyncFieldValue> GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3974A40", Offset = "0x3973240", VA = "0x183974A40")]
	public void LOJJMNNDKHC(in global::MMPHMPGHOKJ<TSyncFieldValue> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2828000", Offset = "0x2826800", VA = "0x182828000", Slot = "15")]
	public void NLCGHLEDMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3974A00", Offset = "0x3973200", VA = "0x183974A00")]
	public void JIHHCIBGKMI(in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39746C0", Offset = "0x3972EC0", VA = "0x1839746C0", Slot = "5")]
	private void CPLNPCGJNGD(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3974730", Offset = "0x3972F30", VA = "0x183974730", Slot = "6")]
	private void DAKIJJHOIDO(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33689B0", Offset = "0x33671B0", VA = "0x1833689B0", Slot = "7")]
	private void BOCDLHMHGKJ(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3974B20", Offset = "0x3973320", VA = "0x183974B20", Slot = "8")]
	private void POGLHNJMFPA(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD0F0", Offset = "0x2BCB8F0", VA = "0x182BCD0F0", Slot = "9")]
	private global::EMJMCNHDCKE<NMDMCNKPNFB> LHPJMAGNKGF(in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3974910", Offset = "0x3973110", VA = "0x183974910", Slot = "10")]
	private bool HNDODIFCBND(in OABODKHHPND OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3974AB0", Offset = "0x39732B0", VA = "0x183974AB0", Slot = "11")]
	private global::MMPHMPGHOKJ<TSyncFieldValue> OJLOMNKKLOD(in global::EMJMCNHDCKE<DELFKKIBLAM> CPDLKGDIAIE, in OABODKHHPND OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x33684A0", Offset = "0x3366CA0", VA = "0x1833684A0", Slot = "12")]
	private void EHDPCLANLBE(in global::MMPHMPGHOKJ<TSyncFieldValue> GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39745B0", Offset = "0x3972DB0", VA = "0x1839745B0", Slot = "13")]
	private void BLIBJLDOMBK(in global::MMPHMPGHOKJ<TSyncFieldValue> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39749D0", Offset = "0x39731D0", VA = "0x1839749D0", Slot = "16")]
	private void JEHDKMOMJJO(in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::OJKCAJDJHEE<TRpcParam> where TActionReceiver : global::GAECGMPHMKD<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>> where TActionDeps : global::NDGMIODNGAD<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::EMJMCNHDCKE<NMDMCNKPNFB> OEGOJBKLHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly global::OIHNBCCIFCF<OGKLMGNKPCE, GCNJGEAOHKJ> EPNICPMCIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly Dictionary<string, global::HJIOFJGJNKM<TSyncFieldValue>> JECNGIHAPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly global::PPELPABBAKM<NMDMCNKPNFB, global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HNHIAKDMOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly TActionDeps FAIEFDDOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly List<(global::EMJMCNHDCKE<NMDMCNKPNFB> ActorId, global::EMJMCNHDCKE<PLMPGGHOKJJ> RequestId, TAction Action)> JDOIDIJMNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? GGDLBCANCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly int? LHAPABAEABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Queue<(global::EMJMCNHDCKE<NMDMCNKPNFB> ActorId, global::EMJMCNHDCKE<PLMPGGHOKJJ> RequestId, TAction Action)> KNDKJEEBPGH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::EMJMCNHDCKE<NMDMCNKPNFB> KLFGPABCHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x561ED0", Offset = "0x5606D0", VA = "0x180561ED0")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D90380", Offset = "0x3D8EB80", VA = "0x183D90380")]
	protected OCKCPJAALBM(TActionDeps FJILLBNHCBL, int? JCFDBPBLFGB, int? HHGIIBOJJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D8EFD0", Offset = "0x3D8D7D0", VA = "0x183D8EFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E7D0", Offset = "0x3D8CFD0", VA = "0x183D8E7D0")]
	public global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AEFHJKILAOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F280", Offset = "0x3D8DA80", VA = "0x183D8F280")]
	internal global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD(in global::EMJMCNHDCKE<NMDMCNKPNFB> JNMALFDPBKC)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D90020", Offset = "0x3D8E820", VA = "0x183D90020")]
	internal void LKHDCLIABGI(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8EF70", Offset = "0x3D8D770", VA = "0x183D8EF70")]
	internal global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3D901D0", Offset = "0x3D8E9D0", VA = "0x183D901D0")]
	internal void LPLMCFOBEKH(in global::EMJMCNHDCKE<NMDMCNKPNFB> FNPNGBOAILE, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D8EEF0", Offset = "0x3D8D6F0", VA = "0x183D8EEF0")]
	internal void CMLEPADGGPD(in global::EMJMCNHDCKE<NMDMCNKPNFB> ACAAKHEPLLO, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3D8EC60", Offset = "0x3D8D460", VA = "0x183D8EC60")]
	internal void AIBEPPOOMDH(in global::EMJMCNHDCKE<NMDMCNKPNFB> FNPNGBOAILE, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F610", Offset = "0x3D8DE10", VA = "0x183D8F610")]
	internal global::MMPHMPGHOKJ<TSyncFieldValue> HKJIKBCCBHG(global::EMJMCNHDCKE<NMDMCNKPNFB> PFCNOFGOOKL, global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO, string BJKKIOODGOA, in TSyncFieldValue MFBIHMKFNKA, Action IJOJDDBGAPC, Action<object> EBEBMLKJAAI, Func<bool> DMDBPADHEMF)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D90260", Offset = "0x3D8EA60", VA = "0x183D90260")]
	internal void MHJAPJPIOJB(global::EMJMCNHDCKE<NMDMCNKPNFB> PFCNOFGOOKL, string BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F7B0", Offset = "0x3D8DFB0", VA = "0x183D8F7B0")]
	internal void HMPDPEKJMNP(global::HJIOFJGJNKM<TSyncFieldValue> CFNAJEGKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D90350", Offset = "0x3D8EB50", VA = "0x183D90350")]
	internal void NLCGHLEDMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FAD0", Offset = "0x3D8E2D0", VA = "0x183D8FAD0")]
	internal void JIHHCIBGKMI(in global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D8FA00", Offset = "0x3D8E200", VA = "0x183D8FA00")]
	[CompilerGenerated]
	private global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HOJAIAJAOKH(in global::EMJMCNHDCKE<NMDMCNKPNFB> AJDEBLNHGCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct OABODKHHPND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly global::EMJMCNHDCKE<OGKLMGNKPCE> BGNDHHCHOJF;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA94F10", Offset = "0xA93710", VA = "0x180A94F10")]
	private OABODKHHPND(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0")]
	public static OABODKHHPND BAPHMNFAJJN(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
		return default(OABODKHHPND);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GCNJGEAOHKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> FKBDABMEBMD;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA94F10", Offset = "0xA93710", VA = "0x180A94F10")]
	private GCNJGEAOHKJ(in global::EMJMCNHDCKE<NMDMCNKPNFB> JNMALFDPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7961F0", Offset = "0x7949F0", VA = "0x1807961F0")]
	public static GCNJGEAOHKJ BAPHMNFAJJN(in global::EMJMCNHDCKE<NMDMCNKPNFB> JNMALFDPBKC)
	{
		return default(GCNJGEAOHKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct MMPHMPGHOKJ<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly AHCBFGLNCFM HECFJOEMIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly global::HJIOFJGJNKM<TSyncFieldValue> DIAFOOPBEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly Action OMIHHIBIBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly Action<object> FAAFFMCBKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly Func<bool> CPFNNLCOCJM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x218A120", Offset = "0x2188920", VA = "0x18218A120")]
	private MMPHMPGHOKJ(AHCBFGLNCFM NMJANEIJHMJ, global::HJIOFJGJNKM<TSyncFieldValue> LEDIBAMHBPM, Action IJOJDDBGAPC, Action<object> EBEBMLKJAAI, Func<bool> DMDBPADHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2189FC0", Offset = "0x21887C0", VA = "0x182189FC0")]
	public static global::MMPHMPGHOKJ<TSyncFieldValue> BAPHMNFAJJN(global::HJIOFJGJNKM<TSyncFieldValue> LEDIBAMHBPM, Action IJOJDDBGAPC, Action<object> EBEBMLKJAAI, Func<bool> DMDBPADHEMF)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class HJIOFJGJNKM<TSyncFieldValue>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly string LOKNCHMIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public TSyncFieldValue CIFMBHMEFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly Dictionary<global::EMJMCNHDCKE<NMDMCNKPNFB>, global::EMJMCNHDCKE<DELFKKIBLAM>> ADHEHAAKMFP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x36767A0", Offset = "0x3674FA0", VA = "0x1836767A0")]
	private HJIOFJGJNKM(string BJKKIOODGOA, in TSyncFieldValue MFBIHMKFNKA, Dictionary<global::EMJMCNHDCKE<NMDMCNKPNFB>, global::EMJMCNHDCKE<DELFKKIBLAM>> IGADPBBKCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3676680", Offset = "0x3674E80", VA = "0x183676680")]
	public static global::HJIOFJGJNKM<TSyncFieldValue> BAPHMNFAJJN(string BJKKIOODGOA, in TSyncFieldValue MFBIHMKFNKA)
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

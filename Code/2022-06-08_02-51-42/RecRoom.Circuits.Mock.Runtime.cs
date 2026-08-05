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
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
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
			[Cpp2IlInjected.Address(RVA = "0x320AD00", Offset = "0x3209D00", VA = "0x18320AD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CB9D0", Offset = "0x5CA9D0", VA = "0x1805CB9D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		public DLJGJHFHOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x31F71B0", Offset = "0x31F61B0", VA = "0x1831F71B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x320A4D0", Offset = "0x32094D0", VA = "0x18320A4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> OJNPAMCAAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3209F90", Offset = "0x3208F90", VA = "0x183209F90", Slot = "5")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x320A6C0", Offset = "0x32096C0", VA = "0x18320A6C0")]
	protected PKKKCEGMINJ(global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KBKIMKGOABO, global::PCLDILJGFEK<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::MMPHMPGHOKJ<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MMMHKGLPGIB, global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ECGJGPDGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D94ED0", Offset = "0x1D93ED0", VA = "0x181D94ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3209AE0", Offset = "0x3208AE0", VA = "0x183209AE0")]
	public static global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BAPHMNFAJJN(global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> KBKIMKGOABO, global::PCLDILJGFEK<OABODKHHPND, global::EMJMCNHDCKE<NMDMCNKPNFB>, TRpcParam, TRpcReceiver, global::MMPHMPGHOKJ<TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> MMMHKGLPGIB, global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> ECGJGPDGCND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16FAE50", Offset = "0x16F9E50", VA = "0x1816FAE50")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD()
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x320A530", Offset = "0x3209530", VA = "0x18320A530")]
	internal global::EMJMCNHDCKE<DPFCNHBBOCD> MCGFPDIEJKL(in global::EMJMCNHDCKE<OGKLMGNKPCE> DDEJHPOCOHL, in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3209CF0", Offset = "0x3208CF0", VA = "0x183209CF0")]
	internal void DBKLCIGLFGJ(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3209F00", Offset = "0x3208F00", VA = "0x183209F00")]
	internal void GGDIHJGNLLG(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3209E10", Offset = "0x3208E10", VA = "0x183209E10")]
	internal void FCMICMMMHND(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3209BC0", Offset = "0x3208BC0", VA = "0x183209BC0")]
	internal void BPJEAMMMPAA(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3209FF0", Offset = "0x3208FF0", VA = "0x183209FF0")]
	internal void HMPDPEKJMNP(in global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3209E70", Offset = "0x3208E70", VA = "0x183209E70")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> FHAPDFJNACC(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3209CC0", Offset = "0x3208CC0", VA = "0x183209CC0")]
	public void DADCAKCGKPB(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x320A0E0", Offset = "0x32090E0", VA = "0x18320A0E0")]
	public void IDJIOJMGDCK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3209FC0", Offset = "0x3208FC0", VA = "0x183209FC0")]
	public void HIELBEHCMGI(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3209DE0", Offset = "0x3208DE0", VA = "0x183209DE0")]
	public void DNPKHOCLBPE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x320A0B0", Offset = "0x32090B0", VA = "0x18320A0B0")]
	public void IDHBDFCGOBH(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3209C90", Offset = "0x3208C90", VA = "0x183209C90")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3209AB0", Offset = "0x3208AB0", VA = "0x183209AB0")]
	public bool ALIKBNAPGDC(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3209C60", Offset = "0x3208C60", VA = "0x183209C60")]
	public global::EMJMCNHDCKE<DELFKKIBLAM> CMDMBCIEPCM(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3209D80", Offset = "0x3208D80", VA = "0x183209D80")]
	public void DHNLGKCMPLN(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x320A5D0", Offset = "0x32095D0", VA = "0x18320A5D0")]
	public void MHIFOHEJNJK(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x320A140", Offset = "0x3209140", VA = "0x18320A140")]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> JIHHCIBGKMI(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x320A690", Offset = "0x3209690", VA = "0x18320A690")]
	public void PFFFOIAADML(in TActionReceiver IJPJNFBCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x320A340", Offset = "0x3209340", VA = "0x18320A340")]
	public void KCJDPCGOHPH(in global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3209DB0", Offset = "0x3208DB0", VA = "0x183209DB0", Slot = "6")]
	private void DJLOPCAJCAJ(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3209ED0", Offset = "0x3208ED0", VA = "0x183209ED0", Slot = "7")]
	private void GFMJKIBMPBP(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x320A630", Offset = "0x3209630", VA = "0x18320A630", Slot = "8")]
	private void NKHLHGFGINA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x320A110", Offset = "0x3209110", VA = "0x18320A110", Slot = "9")]
	private void JFOEPCPIDDK(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3202AF0", Offset = "0x3201AF0", VA = "0x183202AF0", Slot = "10")]
	private void JFOKJFKNFBA(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in TRpcReceiver BDKGCACCINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3209F60", Offset = "0x3208F60", VA = "0x183209F60", Slot = "11")]
	private global::EMJMCNHDCKE<NMDMCNKPNFB> GNMBEFPGMLE(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3203050", Offset = "0x3202050", VA = "0x183203050", Slot = "12")]
	private bool FFKEANBIJPG(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3203080", Offset = "0x3202080", VA = "0x183203080", Slot = "13")]
	private global::EMJMCNHDCKE<DELFKKIBLAM> PLIEKADJCDN(in global::EMJMCNHDCKE<DPFCNHBBOCD> OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::EMJMCNHDCKE<DELFKKIBLAM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x320A600", Offset = "0x3209600", VA = "0x18320A600", Slot = "14")]
	private void MLHBJPOJILE(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x320A660", Offset = "0x3209660", VA = "0x18320A660", Slot = "15")]
	private void PAMLDCMEAPB(in global::EMJMCNHDCKE<DELFKKIBLAM> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3201330", Offset = "0x3200330", VA = "0x183201330", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BBD70", Offset = "0x5BAD70", VA = "0x1805BBD70", Slot = "4")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> AEGNGGMAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5BBD70", Offset = "0x5BAD70", VA = "0x1805BBD70", Slot = "14")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x36A5FE0", Offset = "0x36A4FE0", VA = "0x1836A5FE0")]
	private NFPPDGNBKLA(global::OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JGBLAEIFCCP, in global::EMJMCNHDCKE<NMDMCNKPNFB> DDEJHPOCOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x36A59D0", Offset = "0x36A49D0", VA = "0x1836A59D0")]
	public static global::NFPPDGNBKLA<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BAPHMNFAJJN(in global::EMJMCNHDCKE<NMDMCNKPNFB> DDEJHPOCOHL, global::OCKCPJAALBM<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> JGBLAEIFCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x36A5D00", Offset = "0x36A4D00", VA = "0x1836A5D00")]
	public global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD()
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x36A5BB0", Offset = "0x36A4BB0", VA = "0x1836A5BB0")]
	public void DADCAKCGKPB(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x36A5DD0", Offset = "0x36A4DD0", VA = "0x1836A5DD0")]
	public void IDJIOJMGDCK(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x36A5D40", Offset = "0x36A4D40", VA = "0x1836A5D40")]
	public void HIELBEHCMGI(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x36A5C80", Offset = "0x36A4C80", VA = "0x1836A5C80")]
	public void DNPKHOCLBPE(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x22DB4C0", Offset = "0x22DA4C0", VA = "0x1822DB4C0")]
	public global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x36A5930", Offset = "0x36A4930", VA = "0x1836A5930")]
	public bool ALIKBNAPGDC(in OABODKHHPND OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x36A5AA0", Offset = "0x36A4AA0", VA = "0x1836A5AA0")]
	public global::MMPHMPGHOKJ<TSyncFieldValue> CMDMBCIEPCM(in global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO, in OABODKHHPND MBKAIJKLCJG, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x36A5C20", Offset = "0x36A4C20", VA = "0x1836A5C20")]
	public void DHNLGKCMPLN(in global::MMPHMPGHOKJ<TSyncFieldValue> GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x36A5ED0", Offset = "0x36A4ED0", VA = "0x1836A5ED0")]
	public void LOJJMNNDKHC(in global::MMPHMPGHOKJ<TSyncFieldValue> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x23E14D0", Offset = "0x23E04D0", VA = "0x1823E14D0", Slot = "15")]
	public void NLCGHLEDMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36A5E90", Offset = "0x36A4E90", VA = "0x1836A5E90")]
	public void JIHHCIBGKMI(in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36A5B80", Offset = "0x36A4B80", VA = "0x1836A5B80", Slot = "5")]
	private void CPLNPCGJNGD(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36A5BF0", Offset = "0x36A4BF0", VA = "0x1836A5BF0", Slot = "6")]
	private void DAKIJJHOIDO(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1C46E10", Offset = "0x1C45E10", VA = "0x181C46E10", Slot = "7")]
	private void BOCDLHMHGKJ(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36A5FB0", Offset = "0x36A4FB0", VA = "0x1836A5FB0", Slot = "8")]
	private void POGLHNJMFPA(in OABODKHHPND OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2440", Offset = "0x1FE1440", VA = "0x181FE2440", Slot = "9")]
	private global::EMJMCNHDCKE<NMDMCNKPNFB> LHPJMAGNKGF(in OABODKHHPND OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B95480", Offset = "0x2B94480", VA = "0x182B95480", Slot = "10")]
	private bool HNDODIFCBND(in OABODKHHPND OMILIKJDDEJ, in global::EMJMCNHDCKE<NMDMCNKPNFB> IEBNODEBKJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x36A5F40", Offset = "0x36A4F40", VA = "0x1836A5F40", Slot = "11")]
	private global::MMPHMPGHOKJ<TSyncFieldValue> OJLOMNKKLOD(in global::EMJMCNHDCKE<DELFKKIBLAM> CPDLKGDIAIE, in OABODKHHPND OMILIKJDDEJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) GLCBACNALCL)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1C46870", Offset = "0x1C45870", VA = "0x181C46870", Slot = "12")]
	private void EHDPCLANLBE(in global::MMPHMPGHOKJ<TSyncFieldValue> GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B95210", Offset = "0x2B94210", VA = "0x182B95210", Slot = "13")]
	private void BLIBJLDOMBK(in global::MMPHMPGHOKJ<TSyncFieldValue> NMHIOKDOGND, in TSyncFieldValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x36A5E60", Offset = "0x36A4E60", VA = "0x1836A5E60", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770")]
		get
		{
			return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AFB0", Offset = "0x3B99FB0", VA = "0x183B9AFB0")]
	protected OCKCPJAALBM(TActionDeps FJILLBNHCBL, int? JCFDBPBLFGB, int? HHGIIBOJJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B99C00", Offset = "0x3B98C00", VA = "0x183B99C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B99400", Offset = "0x3B98400", VA = "0x183B99400")]
	public global::PKKKCEGMINJ<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> AEFHJKILAOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B99EB0", Offset = "0x3B98EB0", VA = "0x183B99EB0")]
	internal global::EMJMCNHDCKE<DPFCNHBBOCD> HDOFMLABHBD(in global::EMJMCNHDCKE<NMDMCNKPNFB> JNMALFDPBKC)
	{
		return default(global::EMJMCNHDCKE<DPFCNHBBOCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AC50", Offset = "0x3B99C50", VA = "0x183B9AC50")]
	internal void LKHDCLIABGI(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B99BA0", Offset = "0x3B98BA0", VA = "0x183B99BA0")]
	internal global::EMJMCNHDCKE<NMDMCNKPNFB> CPDHBBCLICO(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
		return default(global::EMJMCNHDCKE<NMDMCNKPNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AE00", Offset = "0x3B99E00", VA = "0x183B9AE00")]
	internal void LPLMCFOBEKH(in global::EMJMCNHDCKE<NMDMCNKPNFB> FNPNGBOAILE, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B99B20", Offset = "0x3B98B20", VA = "0x183B99B20")]
	internal void CMLEPADGGPD(in global::EMJMCNHDCKE<NMDMCNKPNFB> ACAAKHEPLLO, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B99890", Offset = "0x3B98890", VA = "0x183B99890")]
	internal void AIBEPPOOMDH(in global::EMJMCNHDCKE<NMDMCNKPNFB> FNPNGBOAILE, in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ, in TRpcParam GLCBACNALCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A240", Offset = "0x3B99240", VA = "0x183B9A240")]
	internal global::MMPHMPGHOKJ<TSyncFieldValue> HKJIKBCCBHG(global::EMJMCNHDCKE<NMDMCNKPNFB> PFCNOFGOOKL, global::EMJMCNHDCKE<DELFKKIBLAM> CFNAJEGKJIO, string BJKKIOODGOA, in TSyncFieldValue MFBIHMKFNKA, Action IJOJDDBGAPC, Action<object> EBEBMLKJAAI, Func<bool> DMDBPADHEMF)
	{
		return default(global::MMPHMPGHOKJ<TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AE90", Offset = "0x3B99E90", VA = "0x183B9AE90")]
	internal void MHJAPJPIOJB(global::EMJMCNHDCKE<NMDMCNKPNFB> PFCNOFGOOKL, string BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A3E0", Offset = "0x3B993E0", VA = "0x183B9A3E0")]
	internal void HMPDPEKJMNP(global::HJIOFJGJNKM<TSyncFieldValue> CFNAJEGKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AF80", Offset = "0x3B99F80", VA = "0x183B9AF80")]
	internal void NLCGHLEDMME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A700", Offset = "0x3B99700", VA = "0x183B9A700")]
	internal void JIHHCIBGKMI(in global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A630", Offset = "0x3B99630", VA = "0x183B9A630")]
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
	[Cpp2IlInjected.Address(RVA = "0x38BDB10", Offset = "0x38BCB10", VA = "0x1838BDB10")]
	private OABODKHHPND(in global::EMJMCNHDCKE<OGKLMGNKPCE> OMILIKJDDEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x38BDB10", Offset = "0x38BCB10", VA = "0x1838BDB10")]
	private GCNJGEAOHKJ(in global::EMJMCNHDCKE<NMDMCNKPNFB> JNMALFDPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5BBD80", Offset = "0x5BAD80", VA = "0x1805BBD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A76540", Offset = "0x1A75540", VA = "0x181A76540")]
	private MMPHMPGHOKJ(AHCBFGLNCFM NMJANEIJHMJ, global::HJIOFJGJNKM<TSyncFieldValue> LEDIBAMHBPM, Action IJOJDDBGAPC, Action<object> EBEBMLKJAAI, Func<bool> DMDBPADHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1A763E0", Offset = "0x1A753E0", VA = "0x181A763E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3190FA0", Offset = "0x318FFA0", VA = "0x183190FA0")]
	private HJIOFJGJNKM(string BJKKIOODGOA, in TSyncFieldValue MFBIHMKFNKA, Dictionary<global::EMJMCNHDCKE<NMDMCNKPNFB>, global::EMJMCNHDCKE<DELFKKIBLAM>> IGADPBBKCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3190E80", Offset = "0x318FE80", VA = "0x183190E80")]
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

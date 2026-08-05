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
public sealed class NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::KDFDAPFIOAN<TRpcParam> where TActionReceiver : global::AABNGPLOKLH<TAction, Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>>> where TActionDeps : global::NCFBPLNMKCK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DMAEMBJGPKL
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
			public DMAEMBJGPKL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1200", Offset = "0x1FA0600", VA = "0x181FA1200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public DMAEMBJGPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3581840", Offset = "0x3580C40", VA = "0x183581840")]
		[AsyncStateMachine(typeof(global::NDDKAMJPNEG<, , , , , >.DMAEMBJGPKL.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> PLDEBFMNDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::LMIAKNHHCGP<DFNHGAMEFLE>, global::LMIAKNHHCGP<CFLHDILNHBD>> GAAECEIPNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::LMIAKNHHCGP<DFNHGAMEFLE>> ILAPBFCFMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::CANFHBMAPOB<int> APHDPGLBFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::LMIAKNHHCGP<ODBEPGLKHGD> ActorId, global::LMIAKNHHCGP<JJMABODIBOK> RequestId, TAction Action)> JBALPHMGDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool GHOFLDHAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> IAGLIMINLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::FPKENKKFJGF<HDIFPIPOAPI, global::LMIAKNHHCGP<ODBEPGLKHGD>, TRpcParam, TRpcReceiver, global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> BFPKKHOFEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> AKEIFLONOBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool ANNIMBEPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3426340", Offset = "0x3425740", VA = "0x183426340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::LMIAKNHHCGP<ODBEPGLKHGD> DHBHJHKBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3425EC0", Offset = "0x34252C0", VA = "0x183425EC0")]
		get
		{
			return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3426510", Offset = "0x3425910", VA = "0x183426510")]
	private NDDKAMJPNEG(global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MHCCDFMDJCL, global::FPKENKKFJGF<HDIFPIPOAPI, global::LMIAKNHHCGP<ODBEPGLKHGD>, TRpcParam, TRpcReceiver, global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PNJEPDLIDBL, global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FKEMGEINAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3425E90", Offset = "0x3425290", VA = "0x183425E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3426180", Offset = "0x3425580", VA = "0x183426180")]
	internal static global::NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IKMCJIAOBME(global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MHCCDFMDJCL, global::FPKENKKFJGF<HDIFPIPOAPI, global::LMIAKNHHCGP<ODBEPGLKHGD>, TRpcParam, TRpcReceiver, global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PNJEPDLIDBL, global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> FKEMGEINAMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2399080", Offset = "0x2398480", VA = "0x182399080")]
	public global::LMIAKNHHCGP<CFLHDILNHBD> BABHAACABFD()
	{
		return default(global::LMIAKNHHCGP<CFLHDILNHBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3425EF0", Offset = "0x34252F0", VA = "0x183425EF0")]
	internal global::LMIAKNHHCGP<CFLHDILNHBD> EKLKKBHNHIK(global::LMIAKNHHCGP<DFNHGAMEFLE> KDFBMFGPICB, in HDIFPIPOAPI JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<CFLHDILNHBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x34262C0", Offset = "0x34256C0", VA = "0x1834262C0")]
	internal void LEKJMGJPMOE(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3426080", Offset = "0x3425480", VA = "0x183426080")]
	internal void FNODIDOEMAE(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34263B0", Offset = "0x34257B0", VA = "0x1834263B0")]
	internal void LHEOAOIPDEH(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x34260E0", Offset = "0x34254E0", VA = "0x1834260E0")]
	internal void GOAAKGMDIBD(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3425A40", Offset = "0x3424E40", VA = "0x183425A40")]
	internal void ALFHGPHFHAK(global::LMIAKNHHCGP<MKLFGIECNKD> JFADLBDFOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3425FF0", Offset = "0x34253F0", VA = "0x183425FF0")]
	public global::LMIAKNHHCGP<CFLHDILNHBD> FGFJLNCLNLI(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<CFLHDILNHBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3426410", Offset = "0x3425810", VA = "0x183426410")]
	public void MBGHCOOPEIB(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3425F90", Offset = "0x3425390", VA = "0x183425F90")]
	public void EOCGJKNILDH(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3426440", Offset = "0x3425840", VA = "0x183426440")]
	public void MLFBOHPFAEO(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3425B00", Offset = "0x3424F00", VA = "0x183425B00")]
	public void BBPMNJILNNI(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3426050", Offset = "0x3425450", VA = "0x183426050")]
	public void FNDJAGOABJN(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in TRpcReceiver ANOMBFKFIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34264E0", Offset = "0x34258E0", VA = "0x1834264E0")]
	public global::LMIAKNHHCGP<ODBEPGLKHGD> PGCLGFPFJPH(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34264A0", Offset = "0x34258A0", VA = "0x1834264A0")]
	public bool OIGECCDMAGD(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, global::LMIAKNHHCGP<ODBEPGLKHGD> BDABNBDENHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3426290", Offset = "0x3425690", VA = "0x183426290")]
	public global::LMIAKNHHCGP<MKLFGIECNKD> JMMBOEOMJJO(global::LMIAKNHHCGP<CFLHDILNHBD> JLBINKLPHKJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CDDIFFKMAEP)
	{
		return default(global::LMIAKNHHCGP<MKLFGIECNKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3426260", Offset = "0x3425660", VA = "0x183426260")]
	public void JHBMNCGOLGO(global::LMIAKNHHCGP<MKLFGIECNKD> FGIJCNHNNLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3425FC0", Offset = "0x34253C0", VA = "0x183425FC0")]
	public void FDCEBKPMJHB(global::LMIAKNHHCGP<MKLFGIECNKD> FGIJCNHNNLF, in TSyncFieldValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3425CC0", Offset = "0x34250C0", VA = "0x183425CC0")]
	public Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> DJLELEIHCDE(in TAction LECDCDLGAEL, bool CEBNHKMBPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3426470", Offset = "0x3425870", VA = "0x183426470")]
	public void OGHKFEKCPGH(in TActionReceiver GBNOGDCDLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3425B30", Offset = "0x3424F30", VA = "0x183425B30")]
	public void BIMLJAEDILG(global::LMIAKNHHCGP<ODBEPGLKHGD> NKDDBGPFFOL, global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, in TAction LECDCDLGAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::DJGMFMBGPGC<HDIFPIPOAPI, global::LMIAKNHHCGP<ODBEPGLKHGD>, TRpcParam, global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::JMJHCBMNBBH<TAction> where TRpcReceiver : global::KDFDAPFIOAN<TRpcParam> where TActionReceiver : global::AABNGPLOKLH<TAction, Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>>> where TActionDeps : global::NCFBPLNMKCK<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::KCEAGPKIJHP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> OLLHODBKBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::LMIAKNHHCGP<ODBEPGLKHGD> EECEAINLLIP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::LMIAKNHHCGP<ODBEPGLKHGD> DHBHJHKBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0", Slot = "4")]
		get
		{
			return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::LMIAKNHHCGP<ODBEPGLKHGD> ENGBNKNNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0", Slot = "14")]
		get
		{
			return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29D36C0", Offset = "0x29D2AC0", VA = "0x1829D36C0")]
	private MMODJAEHDAH(global::KCEAGPKIJHP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BNLKMICELID, global::LMIAKNHHCGP<ODBEPGLKHGD> KDFBMFGPICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29D3270", Offset = "0x29D2670", VA = "0x1829D3270")]
	public static global::MMODJAEHDAH<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> IKMCJIAOBME(global::LMIAKNHHCGP<ODBEPGLKHGD> KDFBMFGPICB, global::KCEAGPKIJHP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> BNLKMICELID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29D2EF0", Offset = "0x29D22F0", VA = "0x1829D2EF0")]
	public global::LMIAKNHHCGP<CFLHDILNHBD> BABHAACABFD()
	{
		return default(global::LMIAKNHHCGP<CFLHDILNHBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29D3500", Offset = "0x29D2900", VA = "0x1829D3500")]
	public void MBGHCOOPEIB(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29D3160", Offset = "0x29D2560", VA = "0x1829D3160")]
	public void EOCGJKNILDH(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29D3540", Offset = "0x29D2940", VA = "0x1829D3540")]
	public void MLFBOHPFAEO(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29D2F60", Offset = "0x29D2360", VA = "0x1829D2F60")]
	public void BBPMNJILNNI(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29D3680", Offset = "0x29D2A80", VA = "0x1829D3680")]
	public global::LMIAKNHHCGP<ODBEPGLKHGD> PGCLGFPFJPH(in HDIFPIPOAPI JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29D35F0", Offset = "0x29D29F0", VA = "0x1829D35F0")]
	public bool OIGECCDMAGD(in HDIFPIPOAPI JLBINKLPHKJ, global::LMIAKNHHCGP<ODBEPGLKHGD> BDABNBDENHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29D33A0", Offset = "0x29D27A0", VA = "0x1829D33A0")]
	public global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> JMMBOEOMJJO(global::LMIAKNHHCGP<MKLFGIECNKD> JFADLBDFOPO, in HDIFPIPOAPI FAHGJOEFBKN, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CDDIFFKMAEP)
	{
		return default(global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29D3340", Offset = "0x29D2740", VA = "0x1829D3340")]
	public void JHBMNCGOLGO(in global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x29D30B0", Offset = "0x29D24B0", VA = "0x1829D30B0")]
	public void DELKAOAKPKL(in global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> FGIJCNHNNLF, in TSyncFieldValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29D35C0", Offset = "0x29D29C0", VA = "0x1829D35C0", Slot = "15")]
	public void NDBHNBBADIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29D3120", Offset = "0x29D2520", VA = "0x1829D3120")]
	public void DJLELEIHCDE(global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, in TAction LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29D2F30", Offset = "0x29D2330", VA = "0x1829D2F30", Slot = "5")]
	private void BAKKHJKPCKH(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x29D3240", Offset = "0x29D2640", VA = "0x1829D3240", Slot = "6")]
	private void HJALKNJIGFD(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29D3210", Offset = "0x29D2610", VA = "0x1829D3210", Slot = "7")]
	private void FPIKPPCOPOG(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29D34A0", Offset = "0x29D28A0", VA = "0x1829D34A0", Slot = "8")]
	private void LDGPOHBDKJE(in HDIFPIPOAPI JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29D31E0", Offset = "0x29D25E0", VA = "0x1829D31E0", Slot = "9")]
	private global::LMIAKNHHCGP<ODBEPGLKHGD> EPHMPLEHCEH(in HDIFPIPOAPI JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29D3080", Offset = "0x29D2480", VA = "0x1829D3080", Slot = "10")]
	private bool COBACBCFIFI(in HDIFPIPOAPI JLBINKLPHKJ, global::LMIAKNHHCGP<ODBEPGLKHGD> BDABNBDENHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29D3010", Offset = "0x29D2410", VA = "0x1829D3010", Slot = "11")]
	private global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> BLFAPEDAMNP(global::LMIAKNHHCGP<MKLFGIECNKD> KDFBMFGPICB, in HDIFPIPOAPI JLBINKLPHKJ, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) CDDIFFKMAEP)
	{
		return default(global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29D3470", Offset = "0x29D2870", VA = "0x1829D3470", Slot = "12")]
	private void KHEOKGGABIL(in global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29D2FE0", Offset = "0x29D23E0", VA = "0x1829D2FE0", Slot = "13")]
	private void BGDHMBGMICK(in global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> FGIJCNHNNLF, in TSyncFieldValue IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29D34D0", Offset = "0x29D28D0", VA = "0x1829D34D0", Slot = "16")]
	private void LDPCIKNLCIP(global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, in TAction LECDCDLGAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KCEAGPKIJHP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::KDFDAPFIOAN<TRpcParam> where TActionReceiver : global::AABNGPLOKLH<TAction, Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>>> where TActionDeps : global::NCFBPLNMKCK<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::LMIAKNHHCGP<ODBEPGLKHGD> INAGBFIPHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::LLIOPAABGGA<DFNHGAMEFLE, global::OBAKLHEPMBD<ODBEPGLKHGD>> NLPFFMAPKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::PNACIKFPLGJ<ODBEPGLKHGD, TSyncFieldValue>> LCMOKKLEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::BNNCFALLICC<ODBEPGLKHGD, global::NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> DLDKLGFIJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps JMBFHBPILCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::LMIAKNHHCGP<ODBEPGLKHGD> ActorId, global::LMIAKNHHCGP<JJMABODIBOK> RequestId, TAction Action)> PABFOKIGOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? CLIFEICIAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? DMMBGIBLPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::LMIAKNHHCGP<ODBEPGLKHGD> ActorId, global::LMIAKNHHCGP<JJMABODIBOK> RequestId, TAction Action)> DOBJBBJPFLP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::LMIAKNHHCGP<ODBEPGLKHGD> IFFJGDDGCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		get
		{
			return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x337FCF0", Offset = "0x337F0F0", VA = "0x18337FCF0")]
	protected KCEAGPKIJHP(TActionDeps GIGCJOPCKEH, int? BGKDNKEIGCP, int? PMAJJIAHEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x337DF60", Offset = "0x337D360", VA = "0x18337DF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x337E9D0", Offset = "0x337DDD0", VA = "0x18337E9D0")]
	public global::NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> EIBPKMLOBCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x337D5B0", Offset = "0x337C9B0", VA = "0x18337D5B0")]
	internal global::LMIAKNHHCGP<CFLHDILNHBD> BABHAACABFD(global::LMIAKNHHCGP<ODBEPGLKHGD> PFLNECCPPLB)
	{
		return default(global::LMIAKNHHCGP<CFLHDILNHBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x337F680", Offset = "0x337EA80", VA = "0x18337F680")]
	internal void FABELEMAPJD(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x337FCA0", Offset = "0x337F0A0", VA = "0x18337FCA0")]
	internal global::LMIAKNHHCGP<ODBEPGLKHGD> PGCLGFPFJPH(global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ)
	{
		return default(global::LMIAKNHHCGP<ODBEPGLKHGD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x337FC10", Offset = "0x337F010", VA = "0x18337FC10")]
	internal void PCKLDCLBMBG(global::LMIAKNHHCGP<ODBEPGLKHGD> JJOIPIKMJOE, global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x337FB60", Offset = "0x337EF60", VA = "0x18337FB60")]
	internal void LPLDNNAOAHN(global::LMIAKNHHCGP<ODBEPGLKHGD> FOGHEDJHMBJ, global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x337DD40", Offset = "0x337D140", VA = "0x18337DD40")]
	internal void DLNGENPFGPM(global::LMIAKNHHCGP<ODBEPGLKHGD> JJOIPIKMJOE, global::LMIAKNHHCGP<DFNHGAMEFLE> JLBINKLPHKJ, in TRpcParam CDDIFFKMAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x337F8D0", Offset = "0x337ECD0", VA = "0x18337F8D0")]
	internal global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue> GNOPDKNNBHC(global::LMIAKNHHCGP<ODBEPGLKHGD> ACJGDEFIMCG, global::LMIAKNHHCGP<MKLFGIECNKD> JFADLBDFOPO, string FOJIGKKHICE, in TSyncFieldValue IGDJJEECDAF, Action MCFINHLOBAO, Action<object> LFPEJPHDKEN, Func<bool> BFJHCMHEJID)
	{
		return default(global::KBDIKBNIJEL<ODBEPGLKHGD, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x337FA70", Offset = "0x337EE70", VA = "0x18337FA70")]
	internal void HHNKJJEILPN(global::LMIAKNHHCGP<ODBEPGLKHGD> ACJGDEFIMCG, string FOJIGKKHICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x337D390", Offset = "0x337C790", VA = "0x18337D390")]
	internal void ALFHGPHFHAK(global::PNACIKFPLGJ<ODBEPGLKHGD, TSyncFieldValue> JFADLBDFOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x337FBD0", Offset = "0x337EFD0", VA = "0x18337FBD0")]
	internal void NDBHNBBADIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x337D8B0", Offset = "0x337CCB0", VA = "0x18337D8B0")]
	internal void DJLELEIHCDE(global::LMIAKNHHCGP<ODBEPGLKHGD> NKDDBGPFFOL, global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, in TAction LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x337E900", Offset = "0x337DD00", VA = "0x18337E900")]
	[CompilerGenerated]
	private global::NDDKAMJPNEG<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> ECEGHGINJKM(global::LMIAKNHHCGP<ODBEPGLKHGD> PIPANIDKOIL)
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

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
public sealed class ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::AMNPIGEJBPJ<TRpcParam> where TActionReceiver : global::IAHDNKIBGIG<TAction, Task<global::CIOEKKBILIB<object, LEGBELBGIHF>>> where TActionDeps : global::AFCMNEINPLP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NIHIFBFAJMF
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
			public NIHIFBFAJMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30546F0", Offset = "0x30534F0", VA = "0x1830546F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public NIHIFBFAJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x42A4DA0", Offset = "0x42A3BA0", VA = "0x1842A4DA0")]
		[AsyncStateMachine(typeof(global::ONOEACAJLPE<, , , , , >.NIHIFBFAJMF.<<SendActionToAll>b__0>d))]
		internal Task <SendActionToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> HOKAKDDBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<global::HAFOMODBANL<IJCADLFPDJL>, global::HAFOMODBANL<HFAJALODOLA>> ACMJLMCMNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HashSet<global::HAFOMODBANL<IJCADLFPDJL>> GCDABJDAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private global::GEAFEOEEKFP<int> MKCLDLKHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly List<(global::HAFOMODBANL<DDPCMMGPIMK> ActorId, global::HAFOMODBANL<NKJHJCIIFAD> RequestId, TAction Action)> FNACCJHGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool FJNBHMNKKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly List<Func<Task>> FLBNBMPHMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly global::DGENCMLNGOE<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHAOFGGOBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> NICELCKHDOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool HGKCMPJJACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x39D8240", Offset = "0x39D7040", VA = "0x1839D8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::HAFOMODBANL<DDPCMMGPIMK> HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39D8410", Offset = "0x39D7210", VA = "0x1839D8410")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39D8530", Offset = "0x39D7330", VA = "0x1839D8530")]
	private ONOEACAJLPE(global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GODJKHDKJCI, global::DGENCMLNGOE<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HNCGHHFOFCO, global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LILMKLJEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x39D7C40", Offset = "0x39D6A40", VA = "0x1839D7C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39D7B60", Offset = "0x39D6960", VA = "0x1839D7B60")]
	internal static global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DHGKFEMNGCO(global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GODJKHDKJCI, global::DGENCMLNGOE<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HNCGHHFOFCO, global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LILMKLJEHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3904DA0", Offset = "0x3903BA0", VA = "0x183904DA0")]
	public global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG()
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39D81A0", Offset = "0x39D6FA0", VA = "0x1839D81A0")]
	internal global::HAFOMODBANL<HFAJALODOLA> KJHHKOEAIJE(global::HAFOMODBANL<IJCADLFPDJL> KCHLIHHPAKF, in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x39D7DC0", Offset = "0x39D6BC0", VA = "0x1839D7DC0")]
	internal void IJILNBHOPJG(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x39D7B00", Offset = "0x39D6900", VA = "0x1839D7B00")]
	internal void CGOHJINCDNA(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x39D84D0", Offset = "0x39D72D0", VA = "0x1839D84D0")]
	internal void PGCPNOHCPIH(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39D7A60", Offset = "0x39D6860", VA = "0x1839D7A60")]
	internal void BGPPOHJCADK(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x39D7D00", Offset = "0x39D6B00", VA = "0x1839D7D00")]
	internal void IABDJHOJGPB(global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x39D8350", Offset = "0x39D7150", VA = "0x1839D8350")]
	public global::HAFOMODBANL<HFAJALODOLA> MKAONBHDAFM(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x39D7CD0", Offset = "0x39D6AD0", VA = "0x1839D7CD0")]
	public void GJPEKEALKBJ(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x39D84A0", Offset = "0x39D72A0", VA = "0x1839D84A0")]
	public void PDPFPLGLIDL(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x39D8470", Offset = "0x39D7270", VA = "0x1839D8470")]
	public void PCMGIAJIDPO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39D7CA0", Offset = "0x39D6AA0", VA = "0x1839D7CA0")]
	public void FNFGOBDAGGC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39D7C70", Offset = "0x39D6A70", VA = "0x1839D7C70")]
	public void FJHCCKMJCEC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcReceiver HPADJEKKMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39D8440", Offset = "0x39D7240", VA = "0x1839D8440")]
	public global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39D82E0", Offset = "0x39D70E0", VA = "0x1839D82E0")]
	public bool LBBNCCJCAGO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x39D8320", Offset = "0x39D7120", VA = "0x1839D8320")]
	public global::HAFOMODBANL<FMDBECBHJLC> MCHPBBCBBNP(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::HAFOMODBANL<FMDBECBHJLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x39D83E0", Offset = "0x39D71E0", VA = "0x1839D83E0")]
	public void NPPHNFMOHJC(global::HAFOMODBANL<FMDBECBHJLC> HFNDODGNHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x39D83B0", Offset = "0x39D71B0", VA = "0x1839D83B0")]
	public void MLEIHHHMOKD(global::HAFOMODBANL<FMDBECBHJLC> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39D7FD0", Offset = "0x39D6DD0", VA = "0x1839D7FD0")]
	public Task<global::CIOEKKBILIB<object, LEGBELBGIHF>> KFKGJNNCGKG(in TAction KNOLDLABLMF, bool PEPLEKBABLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x39D82B0", Offset = "0x39D70B0", VA = "0x1839D82B0")]
	public void LAJECDENEHN(in TActionReceiver LMMAFFJKAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x39D7E40", Offset = "0x39D6C40", VA = "0x1839D7E40")]
	public void JBMEPBLDKNH(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::GGJLHCMJCPI<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::OKEDILOCCCN<TAction> where TRpcReceiver : global::AMNPIGEJBPJ<TRpcParam> where TActionReceiver : global::IAHDNKIBGIG<TAction, Task<global::CIOEKKBILIB<object, LEGBELBGIHF>>> where TActionDeps : global::AFCMNEINPLP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly global::OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> NEJCDINMFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly global::HAFOMODBANL<DDPCMMGPIMK> APAEHLDIFLI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public global::HAFOMODBANL<DDPCMMGPIMK> HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60", Slot = "4")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::HAFOMODBANL<DDPCMMGPIMK> DLFHHMDEMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60", Slot = "14")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ODJEEOJMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x418CD60", Offset = "0x418BB60", VA = "0x18418CD60")]
	private APMKKFDDHLP(global::OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CKKLKHDKCPG, global::HAFOMODBANL<DDPCMMGPIMK> KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x418C6E0", Offset = "0x418B4E0", VA = "0x18418C6E0")]
	public static global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DHGKFEMNGCO(global::HAFOMODBANL<DDPCMMGPIMK> KCHLIHHPAKF, global::OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CKKLKHDKCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x418CA10", Offset = "0x418B810", VA = "0x18418CA10")]
	public global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG()
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x418C8C0", Offset = "0x418B6C0", VA = "0x18418C8C0")]
	public void GJPEKEALKBJ(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x418CCE0", Offset = "0x418BAE0", VA = "0x18418CCE0")]
	public void PDPFPLGLIDL(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x418CC60", Offset = "0x418BA60", VA = "0x18418CC60")]
	public void PCMGIAJIDPO(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x418C7E0", Offset = "0x418B5E0", VA = "0x18418C7E0")]
	public void FNFGOBDAGGC(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x418CC20", Offset = "0x418BA20", VA = "0x18418CC20")]
	public global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x418C980", Offset = "0x418B780", VA = "0x18418C980")]
	public bool LBBNCCJCAGO(in OPJLLMCGNEN GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x418CA50", Offset = "0x418B850", VA = "0x18418CA50")]
	public global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> MCHPBBCBBNP(global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ, in OPJLLMCGNEN GJBHFPJIHBB, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x418CB90", Offset = "0x418B990", VA = "0x18418CB90")]
	public void NPPHNFMOHJC(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x418C610", Offset = "0x418B410", VA = "0x18418C610")]
	public void BDNPPCDJACD(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x418C890", Offset = "0x418B690", VA = "0x18418C890", Slot = "15")]
	public void GFAAKKIDEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x418C930", Offset = "0x418B730", VA = "0x18418C930", Slot = "16")]
	public void KFKGJNNCGKG(global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x418C5E0", Offset = "0x418B3E0", VA = "0x18418C5E0", Slot = "5")]
	private void ANKFOMCOIPI(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x418C900", Offset = "0x418B700", VA = "0x18418C900", Slot = "6")]
	private void GLLPILFCEKE(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x418C860", Offset = "0x418B660", VA = "0x18418C860", Slot = "7")]
	private void GAONIOPMJKM(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x418C680", Offset = "0x418B480", VA = "0x18418C680", Slot = "8")]
	private void BIAHGKEIGMN(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x418C7B0", Offset = "0x418B5B0", VA = "0x18418C7B0", Slot = "9")]
	private global::HAFOMODBANL<DDPCMMGPIMK> EPCLKGFJKFA(in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x418C6B0", Offset = "0x418B4B0", VA = "0x18418C6B0", Slot = "10")]
	private bool CJPJMOEBCOF(in OPJLLMCGNEN GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x418CB20", Offset = "0x418B920", VA = "0x18418CB20", Slot = "11")]
	private global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> NDJBODHLHLB(global::HAFOMODBANL<FMDBECBHJLC> KCHLIHHPAKF, in OPJLLMCGNEN GKCPJCKCENH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x40E5EB0", Offset = "0x40E4CB0", VA = "0x1840E5EB0", Slot = "12")]
	private void MECMIGDCCBH(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x418CBF0", Offset = "0x418B9F0", VA = "0x18418CBF0", Slot = "13")]
	private void OOGOCIFMLLC(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::AMNPIGEJBPJ<TRpcParam> where TActionReceiver : global::IAHDNKIBGIG<TAction, Task<global::CIOEKKBILIB<object, LEGBELBGIHF>>> where TActionDeps : global::AFCMNEINPLP<TAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::HAFOMODBANL<DDPCMMGPIMK> DKALGKCJKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private global::FDBKMKENHNE<IJCADLFPDJL, global::OKBJOHAADEI<DDPCMMGPIMK>> EBLKFEOCDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Dictionary<string, global::PAANOFDCJBI<DDPCMMGPIMK, TSyncFieldValue>> APLDHMMPFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private global::MMLKMDEBCHO<DDPCMMGPIMK, global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> PLNFFIIICOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly TActionDeps MGBBCGPFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly List<(global::HAFOMODBANL<DDPCMMGPIMK> ActorId, global::HAFOMODBANL<NKJHJCIIFAD> RequestId, TAction Action)> CJPMJBFGGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int? MJNHGHBJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly int? FMKHAALHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Queue<(global::HAFOMODBANL<DDPCMMGPIMK> ActorId, global::HAFOMODBANL<NKJHJCIIFAD> RequestId, TAction Action)> KAMKABFHJHM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal global::HAFOMODBANL<DDPCMMGPIMK> CHOEDOPGMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x39C7370", Offset = "0x39C6170", VA = "0x1839C7370")]
	protected OIJIEFFCPPF(TActionDeps OGGGDKHOPFL, int? EMDMKLEPAGN, int? BJPCHODLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x39C4A10", Offset = "0x39C3810", VA = "0x1839C4A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x39C57E0", Offset = "0x39C45E0", VA = "0x1839C57E0")]
	public global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GJLPNLKLOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x39C6EC0", Offset = "0x39C5CC0", VA = "0x1839C6EC0")]
	internal global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG(global::HAFOMODBANL<DDPCMMGPIMK> KNBHBEFNIKP)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x39C5550", Offset = "0x39C4350", VA = "0x1839C5550")]
	internal void EBHJJJFMEDM(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39C7320", Offset = "0x39C6120", VA = "0x1839C7320")]
	internal global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x39C66B0", Offset = "0x39C54B0", VA = "0x1839C66B0")]
	internal void JPJJGNICOPJ(global::HAFOMODBANL<DDPCMMGPIMK> MOCAOPGHNFG, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x39C71C0", Offset = "0x39C5FC0", VA = "0x1839C71C0")]
	internal void NMLBPLFOOGJ(global::HAFOMODBANL<DDPCMMGPIMK> NNNEFLKDEIO, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x39C6740", Offset = "0x39C5540", VA = "0x1839C6740")]
	internal void KAKDIGCNPGA(global::HAFOMODBANL<DDPCMMGPIMK> MOCAOPGHNFG, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39C53B0", Offset = "0x39C41B0", VA = "0x1839C53B0")]
	internal global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> EBACOPLIOKA(global::HAFOMODBANL<DDPCMMGPIMK> GEFLFJMFGKN, global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ, string PIIJMEAKDGO, in TSyncFieldValue DFEOJBAFBHE, Action KDDLOKAHKOL, Action<object> AJCMFJGNKNF, Func<bool> MABEBILHBBO)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39C7230", Offset = "0x39C6030", VA = "0x1839C7230")]
	internal void ONEOEGILGKG(global::HAFOMODBANL<DDPCMMGPIMK> GEFLFJMFGKN, string PIIJMEAKDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39C6490", Offset = "0x39C5290", VA = "0x1839C6490")]
	internal void IABDJHOJGPB(global::PAANOFDCJBI<DDPCMMGPIMK, TSyncFieldValue> BNIDIHAAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39C57A0", Offset = "0x39C45A0", VA = "0x1839C57A0")]
	internal void GFAAKKIDEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39C6960", Offset = "0x39C5760", VA = "0x1839C6960")]
	internal void KFKGJNNCGKG(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39C6DF0", Offset = "0x39C5BF0", VA = "0x1839C6DF0")]
	[CompilerGenerated]
	private global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MABFMKCGPHH(global::HAFOMODBANL<DDPCMMGPIMK> ADBNJMNDLGL)
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

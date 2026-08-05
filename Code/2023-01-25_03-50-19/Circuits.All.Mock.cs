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
public sealed class ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::JKLDHEKFGED<TRpcParam> where TActionReceiver : global::KIHDJDJEGJE<TAction, Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>>> where TActionDeps : global::AFCMNEINPLP<TAction>
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
			private TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private TaskAwaiter<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E56140", Offset = "0x1E55140", VA = "0x181E56140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
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
		public TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public NIHIFBFAJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x32A06F0", Offset = "0x329F6F0", VA = "0x1832A06F0")]
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
	private readonly global::FNNABALAEAH<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> JHAOFGGOBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> NICELCKHDOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool HGKCMPJJACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2601C50", Offset = "0x2600C50", VA = "0x182601C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public global::HAFOMODBANL<DDPCMMGPIMK> HODLJMGJDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2601E20", Offset = "0x2600E20", VA = "0x182601E20")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2601F40", Offset = "0x2600F40", VA = "0x182601F40")]
	private ONOEACAJLPE(global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GODJKHDKJCI, global::FNNABALAEAH<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HNCGHHFOFCO, global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LILMKLJEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2601650", Offset = "0x2600650", VA = "0x182601650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2601570", Offset = "0x2600570", VA = "0x182601570")]
	internal static global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DHGKFEMNGCO(global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GODJKHDKJCI, global::FNNABALAEAH<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, TRpcReceiver, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue), TSyncFieldValue, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> HNCGHHFOFCO, global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps>> LILMKLJEHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2005C10", Offset = "0x2004C10", VA = "0x182005C10")]
	public global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG()
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2601BB0", Offset = "0x2600BB0", VA = "0x182601BB0")]
	internal global::HAFOMODBANL<HFAJALODOLA> KJHHKOEAIJE(global::HAFOMODBANL<IJCADLFPDJL> KCHLIHHPAKF, in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26017D0", Offset = "0x26007D0", VA = "0x1826017D0")]
	internal void IJILNBHOPJG(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2601510", Offset = "0x2600510", VA = "0x182601510")]
	internal void CGOHJINCDNA(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2601EE0", Offset = "0x2600EE0", VA = "0x182601EE0")]
	internal void PGCPNOHCPIH(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2601470", Offset = "0x2600470", VA = "0x182601470")]
	internal void BGPPOHJCADK(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2601710", Offset = "0x2600710", VA = "0x182601710")]
	internal void IABDJHOJGPB(global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2601D60", Offset = "0x2600D60", VA = "0x182601D60")]
	public global::HAFOMODBANL<HFAJALODOLA> MKAONBHDAFM(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26016E0", Offset = "0x26006E0", VA = "0x1826016E0")]
	public void GJPEKEALKBJ(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2601EB0", Offset = "0x2600EB0", VA = "0x182601EB0")]
	public void PDPFPLGLIDL(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2601E80", Offset = "0x2600E80", VA = "0x182601E80")]
	public void PCMGIAJIDPO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26016B0", Offset = "0x26006B0", VA = "0x1826016B0")]
	public void FNFGOBDAGGC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2601680", Offset = "0x2600680", VA = "0x182601680")]
	public void FJHCCKMJCEC(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in TRpcReceiver HPADJEKKMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2601E50", Offset = "0x2600E50", VA = "0x182601E50")]
	public global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2601CF0", Offset = "0x2600CF0", VA = "0x182601CF0")]
	public bool LBBNCCJCAGO(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2601D30", Offset = "0x2600D30", VA = "0x182601D30")]
	public global::HAFOMODBANL<FMDBECBHJLC> MCHPBBCBBNP(global::HAFOMODBANL<HFAJALODOLA> GKCPJCKCENH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::HAFOMODBANL<FMDBECBHJLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2601DF0", Offset = "0x2600DF0", VA = "0x182601DF0")]
	public void NPPHNFMOHJC(global::HAFOMODBANL<FMDBECBHJLC> HFNDODGNHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2601DC0", Offset = "0x2600DC0", VA = "0x182601DC0")]
	public void MLEIHHHMOKD(global::HAFOMODBANL<FMDBECBHJLC> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26019E0", Offset = "0x26009E0", VA = "0x1826019E0")]
	public Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>> KFKGJNNCGKG(in TAction KNOLDLABLMF, bool PEPLEKBABLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2601CC0", Offset = "0x2600CC0", VA = "0x182601CC0")]
	public void LAJECDENEHN(in TActionReceiver LMMAFFJKAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2601850", Offset = "0x2600850", VA = "0x182601850")]
	public void JBMEPBLDKNH(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal sealed class APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : global::GGJLHCMJCPI<OPJLLMCGNEN, global::HAFOMODBANL<DDPCMMGPIMK>, TRpcParam, global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>, (string, TSyncFieldValue, Action, Action<object>, Func<bool>), TSyncFieldValue>, global::OKEDILOCCCN<TAction> where TRpcReceiver : global::JKLDHEKFGED<TRpcParam> where TActionReceiver : global::KIHDJDJEGJE<TAction, Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>>> where TActionDeps : global::AFCMNEINPLP<TAction>
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
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0", Slot = "4")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public global::HAFOMODBANL<DDPCMMGPIMK> DLFHHMDEMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD0", Offset = "0x67EBD0", VA = "0x18067FBD0", Slot = "14")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F96000", Offset = "0x2F95000", VA = "0x182F96000")]
	private APMKKFDDHLP(global::OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CKKLKHDKCPG, global::HAFOMODBANL<DDPCMMGPIMK> KCHLIHHPAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F95990", Offset = "0x2F94990", VA = "0x182F95990")]
	public static global::APMKKFDDHLP<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> DHGKFEMNGCO(global::HAFOMODBANL<DDPCMMGPIMK> KCHLIHHPAKF, global::OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> CKKLKHDKCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2F95CB0", Offset = "0x2F94CB0", VA = "0x182F95CB0")]
	public global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG()
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2F95B70", Offset = "0x2F94B70", VA = "0x182F95B70")]
	public void GJPEKEALKBJ(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2F95F80", Offset = "0x2F94F80", VA = "0x182F95F80")]
	public void PDPFPLGLIDL(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2F95F00", Offset = "0x2F94F00", VA = "0x182F95F00")]
	public void PCMGIAJIDPO(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2F95A90", Offset = "0x2F94A90", VA = "0x182F95A90")]
	public void FNFGOBDAGGC(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2F95EC0", Offset = "0x2F94EC0", VA = "0x182F95EC0")]
	public global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2F95C20", Offset = "0x2F94C20", VA = "0x182F95C20")]
	public bool LBBNCCJCAGO(in OPJLLMCGNEN GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2F95CF0", Offset = "0x2F94CF0", VA = "0x182F95CF0")]
	public global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> MCHPBBCBBNP(global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ, in OPJLLMCGNEN GJBHFPJIHBB, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2F95E30", Offset = "0x2F94E30", VA = "0x182F95E30")]
	public void NPPHNFMOHJC(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F958C0", Offset = "0x2F948C0", VA = "0x182F958C0")]
	public void BDNPPCDJACD(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2F95B40", Offset = "0x2F94B40", VA = "0x182F95B40", Slot = "15")]
	public void GFAAKKIDEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2F95BE0", Offset = "0x2F94BE0", VA = "0x182F95BE0")]
	public void KFKGJNNCGKG(global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2F95890", Offset = "0x2F94890", VA = "0x182F95890", Slot = "5")]
	private void ANKFOMCOIPI(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2F95BB0", Offset = "0x2F94BB0", VA = "0x182F95BB0", Slot = "6")]
	private void GLLPILFCEKE(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2F95B10", Offset = "0x2F94B10", VA = "0x182F95B10", Slot = "7")]
	private void GAONIOPMJKM(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2F95930", Offset = "0x2F94930", VA = "0x182F95930", Slot = "8")]
	private void BIAHGKEIGMN(in OPJLLMCGNEN GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2F95A60", Offset = "0x2F94A60", VA = "0x182F95A60", Slot = "9")]
	private global::HAFOMODBANL<DDPCMMGPIMK> EPCLKGFJKFA(in OPJLLMCGNEN GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2F95960", Offset = "0x2F94960", VA = "0x182F95960", Slot = "10")]
	private bool CJPJMOEBCOF(in OPJLLMCGNEN GKCPJCKCENH, global::HAFOMODBANL<DDPCMMGPIMK> JMJDGCPGKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2F95DC0", Offset = "0x2F94DC0", VA = "0x182F95DC0", Slot = "11")]
	private global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> NDJBODHLHLB(global::HAFOMODBANL<FMDBECBHJLC> KCHLIHHPAKF, in OPJLLMCGNEN GKCPJCKCENH, in (string Key, TSyncFieldValue Value, Action Callback, Action<object> OnCachedValueSet, Func<bool> EqualsDefaultValue) ONHHPHCFHJN)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2F1A4B0", Offset = "0x2F194B0", VA = "0x182F1A4B0", Slot = "12")]
	private void MECMIGDCCBH(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2F95E90", Offset = "0x2F94E90", VA = "0x182F95E90", Slot = "13")]
	private void OOGOCIFMLLC(in global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> HFNDODGNHIE, in TSyncFieldValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x23980B0", Offset = "0x23970B0", VA = "0x1823980B0", Slot = "16")]
	private void DHGCPKAACIA(global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OIJIEFFCPPF<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> : IDisposable where TRpcReceiver : global::JKLDHEKFGED<TRpcParam> where TActionReceiver : global::KIHDJDJEGJE<TAction, Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>>> where TActionDeps : global::AFCMNEINPLP<TAction>
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

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal global::HAFOMODBANL<DDPCMMGPIMK> CHOEDOPGMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
		get
		{
			return default(global::HAFOMODBANL<DDPCMMGPIMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25F0570", Offset = "0x25EF570", VA = "0x1825F0570")]
	protected OIJIEFFCPPF(TActionDeps OGGGDKHOPFL, int? EMDMKLEPAGN, int? BJPCHODLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25EDC10", Offset = "0x25ECC10", VA = "0x1825EDC10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25EE9E0", Offset = "0x25ED9E0", VA = "0x1825EE9E0")]
	public global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> GJLPNLKLOFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25EFFF0", Offset = "0x25EEFF0", VA = "0x1825EFFF0")]
	internal global::HAFOMODBANL<HFAJALODOLA> MAOGCBOADMG(global::HAFOMODBANL<DDPCMMGPIMK> KNBHBEFNIKP)
	{
		return default(global::HAFOMODBANL<HFAJALODOLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25EE750", Offset = "0x25ED750", VA = "0x1825EE750")]
	internal void EBHJJJFMEDM(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25F0520", Offset = "0x25EF520", VA = "0x1825F0520")]
	internal global::HAFOMODBANL<DDPCMMGPIMK> PBLFLBMGLHI(global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH)
	{
		return default(global::HAFOMODBANL<DDPCMMGPIMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25EF8B0", Offset = "0x25EE8B0", VA = "0x1825EF8B0")]
	internal void JPJJGNICOPJ(global::HAFOMODBANL<DDPCMMGPIMK> MOCAOPGHNFG, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25F03C0", Offset = "0x25EF3C0", VA = "0x1825F03C0")]
	internal void NMLBPLFOOGJ(global::HAFOMODBANL<DDPCMMGPIMK> NNNEFLKDEIO, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25EF940", Offset = "0x25EE940", VA = "0x1825EF940")]
	internal void KAKDIGCNPGA(global::HAFOMODBANL<DDPCMMGPIMK> MOCAOPGHNFG, global::HAFOMODBANL<IJCADLFPDJL> GKCPJCKCENH, in TRpcParam ONHHPHCFHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25EE5B0", Offset = "0x25ED5B0", VA = "0x1825EE5B0")]
	internal global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue> EBACOPLIOKA(global::HAFOMODBANL<DDPCMMGPIMK> GEFLFJMFGKN, global::HAFOMODBANL<FMDBECBHJLC> BNIDIHAAOAJ, string PIIJMEAKDGO, in TSyncFieldValue DFEOJBAFBHE, Action KDDLOKAHKOL, Action<object> AJCMFJGNKNF, Func<bool> MABEBILHBBO)
	{
		return default(global::JPFKEEKHCHO<DDPCMMGPIMK, TSyncFieldValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25F0430", Offset = "0x25EF430", VA = "0x1825F0430")]
	internal void ONEOEGILGKG(global::HAFOMODBANL<DDPCMMGPIMK> GEFLFJMFGKN, string PIIJMEAKDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25EF690", Offset = "0x25EE690", VA = "0x1825EF690")]
	internal void IABDJHOJGPB(global::PAANOFDCJBI<DDPCMMGPIMK, TSyncFieldValue> BNIDIHAAOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x25EE9A0", Offset = "0x25ED9A0", VA = "0x1825EE9A0")]
	internal void GFAAKKIDEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x25EFB60", Offset = "0x25EEB60", VA = "0x1825EFB60")]
	internal void KFKGJNNCGKG(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x25F02F0", Offset = "0x25EF2F0", VA = "0x1825F02F0")]
	[CompilerGenerated]
	private global::ONOEACAJLPE<TRpcParam, TRpcReceiver, TSyncFieldValue, TAction, TActionReceiver, TActionDeps> MBDNLCCGICG(global::HAFOMODBANL<DDPCMMGPIMK> ADBNJMNDLGL)
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

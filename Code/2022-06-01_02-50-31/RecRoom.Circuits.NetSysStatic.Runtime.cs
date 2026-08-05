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
public interface LLAGNHGGBGM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ILCILFIKNNJ(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction OGHJBNMDHMI(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction NLMMKKLINFJ(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> HDMIKEAKACH(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CDKIAONDCBD(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LGAAGLFNLIG(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KMIMCOEPPEL(in TAction APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KEPGBKCLDKF(in TAction APBFEHIGAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BDGKJIBINMJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::ACAPOMDGPAA<LPKMDKCOBLF> BBAHDCPGGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFJMJKHECPM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHHMJIGOIHB(in global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, in TAction APBFEHIGAIL);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct LPKMDKCOBLF
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GGPGFFFAEAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> : global::EEBKPMLCADJ<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>, TActionReceiver> where TActionReceiver : global::HFFCJGBPKDN<TAction, Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>> where TActionDeps : global::LLAGNHGGBGM<TAction> where TNetSysStaticDeps : global::BDGKJIBINMJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface NIAOGJPDKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KMBHMEBDMCA(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BNEIDBOLNNL();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::CNDNOOJLCIN<object, EBPLJBHNMKN> FGIAJJPFDBF();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IAJALIPNOFF(Exception KILOBDNKPDP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class NGHDBFNBOFB : NIAOGJPDKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> DBAAGPKKHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> AFGBEBFMMMN;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3341F50", Offset = "0x3340950", VA = "0x183341F50")]
		private NGHDBFNBOFB(TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> JCMJCOJJJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3341760", Offset = "0x3340160", VA = "0x183341760")]
		public static NGHDBFNBOFB IHEMFNLEEFI(TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> JCMJCOJJJBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3341EF0", Offset = "0x33408F0", VA = "0x183341EF0")]
		public void KMBHMEBDMCA(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3341D30", Offset = "0x3340730", VA = "0x183341D30", Slot = "5")]
		public void BNEIDBOLNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3341DF0", Offset = "0x33407F0", VA = "0x183341DF0", Slot = "6")]
		public global::CNDNOOJLCIN<object, EBPLJBHNMKN> FGIAJJPFDBF()
		{
			return default(global::CNDNOOJLCIN<object, EBPLJBHNMKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3341E90", Offset = "0x3340890", VA = "0x183341E90", Slot = "7")]
		public void IAJALIPNOFF(Exception KILOBDNKPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x33358C0", Offset = "0x33342C0", VA = "0x1833358C0", Slot = "4")]
		private void LNPNJDLMKAF(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class LADIMKKPPJI : NIAOGJPDKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> DBAAGPKKHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::CNDNOOJLCIN<object, EBPLJBHNMKN> EOFFKAJADCA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1202180", Offset = "0x1200B80", VA = "0x181202180")]
		private LADIMKKPPJI(TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> JCMJCOJJJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3341760", Offset = "0x3340160", VA = "0x183341760")]
		public static LADIMKKPPJI IHEMFNLEEFI(TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> JCMJCOJJJBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B50", Offset = "0x28D2550", VA = "0x1828D3B50")]
		public void KMBHMEBDMCA(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33416A0", Offset = "0x33400A0", VA = "0x1833416A0", Slot = "5")]
		public void BNEIDBOLNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x577CC0", Offset = "0x5766C0", VA = "0x180577CC0", Slot = "6")]
		public global::CNDNOOJLCIN<object, EBPLJBHNMKN> FGIAJJPFDBF()
		{
			return default(global::CNDNOOJLCIN<object, EBPLJBHNMKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3341700", Offset = "0x3340100", VA = "0x183341700", Slot = "7")]
		public void IAJALIPNOFF(Exception KILOBDNKPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x33358C0", Offset = "0x33342C0", VA = "0x1833358C0", Slot = "4")]
		private void LNPNJDLMKAF(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class FDMFALPMPDP : NIAOGJPDKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> AFGBEBFMMMN;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3335E60", Offset = "0x3334860", VA = "0x183335E60")]
		private FDMFALPMPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3335800", Offset = "0x3334200", VA = "0x183335800")]
		public static FDMFALPMPDP IHEMFNLEEFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3335E00", Offset = "0x3334800", VA = "0x183335E00")]
		public void KMBHMEBDMCA(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		public void BNEIDBOLNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3335DA0", Offset = "0x33347A0", VA = "0x183335DA0", Slot = "6")]
		public global::CNDNOOJLCIN<object, EBPLJBHNMKN> FGIAJJPFDBF()
		{
			return default(global::CNDNOOJLCIN<object, EBPLJBHNMKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
		public void IAJALIPNOFF(Exception KILOBDNKPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x33358C0", Offset = "0x33342C0", VA = "0x1833358C0", Slot = "4")]
		private void LNPNJDLMKAF(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CADIGPENECN : NIAOGJPDKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::CNDNOOJLCIN<object, EBPLJBHNMKN> EOFFKAJADCA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		private CADIGPENECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3335800", Offset = "0x3334200", VA = "0x183335800")]
		public static CADIGPENECN IHEMFNLEEFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xC5D430", Offset = "0xC5BE30", VA = "0x180C5D430")]
		public void KMBHMEBDMCA(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		public void BNEIDBOLNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6043C0", Offset = "0x602DC0", VA = "0x1806043C0", Slot = "6")]
		public global::CNDNOOJLCIN<object, EBPLJBHNMKN> FGIAJJPFDBF()
		{
			return default(global::CNDNOOJLCIN<object, EBPLJBHNMKN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "7")]
		public void IAJALIPNOFF(Exception KILOBDNKPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33358C0", Offset = "0x33342C0", VA = "0x1833358C0", Slot = "4")]
		private void LNPNJDLMKAF(in global::CNDNOOJLCIN<object, EBPLJBHNMKN> HEMKPPOPDKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct CFDEJBKJBFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::ACAPOMDGPAA<LPKMDKCOBLF> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::ACAPOMDGPAA<GGPGFFFAEAI> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x33358F0", Offset = "0x33342F0", VA = "0x1833358F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3335B20", Offset = "0x3334520", VA = "0x183335B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NJCIMBCAKFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::ACAPOMDGPAA<LPKMDKCOBLF> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::ACAPOMDGPAA<GGPGFFFAEAI> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NIAOGJPDKBB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3341FE0", Offset = "0x33409E0", VA = "0x183341FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3342770", Offset = "0x3341170", VA = "0x183342770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OEGEENLHGDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NIAOGJPDKBB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NIAOGJPDKBB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x33427C0", Offset = "0x33411C0", VA = "0x1833427C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x834B50", Offset = "0x833550", VA = "0x180834B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver LBOKNOIKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps MGKNOONMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TNetSysStaticDeps EEFJMFPOLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int MIIMCNGPHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int EBDMDFHNFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::ACAPOMDGPAA<GGPGFFFAEAI>, TaskCompletionSource<global::CNDNOOJLCIN<object, EBPLJBHNMKN>>> MOJPFGMHGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::LHPKJCIILOB<GGPGFFFAEAI> KBAPBFHACDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool OIPKGJODMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int EHJPOGPMCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task HLGOKEBNCMK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3338070", Offset = "0x3336A70", VA = "0x183338070")]
	protected GCGOJBGLOCC(TActionDeps ELGHPOOBFNO, TNetSysStaticDeps NGGMPLLEMFA, int GJLJCALNDOH, int JCABPMMPKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3337AE0", Offset = "0x33364E0", VA = "0x183337AE0")]
	public static global::GCGOJBGLOCC<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> IHEMFNLEEFI(TActionDeps ELGHPOOBFNO, TNetSysStaticDeps NGGMPLLEMFA, [Optional] int? GJLJCALNDOH, [Optional] int? JCABPMMPKDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3337D60", Offset = "0x3336760", VA = "0x183337D60")]
	public Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> MHHMJIGOIHB(in TAction APBFEHIGAIL, bool LJIIOCMODBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3338060", Offset = "0x3336A60", VA = "0x183338060")]
	public void NDGNENBHONJ(in TActionReceiver NMJEEJIPCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x33376C0", Offset = "0x33360C0", VA = "0x1833376C0")]
	[AsyncStateMachine(typeof(global::GCGOJBGLOCC<, , , >.CFDEJBKJBFM))]
	public Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> CNNKOOJIBIC(global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, TAction APBFEHIGAIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3337810", Offset = "0x3336210", VA = "0x183337810")]
	[AsyncStateMachine(typeof(global::GCGOJBGLOCC<, , , >.NJCIMBCAKFM))]
	private Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> FBNDPNILHMA(global::ACAPOMDGPAA<LPKMDKCOBLF> MFEJPJDDMMA, global::ACAPOMDGPAA<GGPGFFFAEAI> CEIPHPMCIKF, TAction APBFEHIGAIL, Task LOMGKKHGCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3337C10", Offset = "0x3336610", VA = "0x183337C10")]
	[AsyncStateMachine(typeof(global::GCGOJBGLOCC<, , , >.OEGEENLHGDI))]
	private Task LFDICOCDGOP(TAction APBFEHIGAIL, NIAOGJPDKBB GFMCDJMCECN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3337960", Offset = "0x3336360", VA = "0x183337960")]
	private void HHJEINFMFNC(TAction APBFEHIGAIL, bool KLOIFPBCEND, bool HEJPMDFBPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29D69D0", Offset = "0x29D53D0", VA = "0x1829D69D0", Slot = "4")]
	private Task<global::CNDNOOJLCIN<object, EBPLJBHNMKN>> NGPFDLPFJBM(in TAction APBFEHIGAIL, bool LJIIOCMODBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class EFKGLGPDDGH : EBPLJBHNMKN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D8BD60", Offset = "0x4D8A760", VA = "0x184D8BD60", Slot = "4")]
	public override string OHAAAAAABNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A19250", Offset = "0x2A17C50", VA = "0x182A19250")]
	private EFKGLGPDDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2623B60", Offset = "0x2622560", VA = "0x182623B60")]
	public static global::CNDNOOJLCIN<TOk, EBPLJBHNMKN> IHEMFNLEEFI<TOk>()
	{
		return default(global::CNDNOOJLCIN<TOk, EBPLJBHNMKN>);
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

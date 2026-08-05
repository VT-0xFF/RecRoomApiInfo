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
public interface KMIKANMOBPI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PECMHPOBMFM(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction EDKONLPIBOO(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction MOEHGMKCDFL(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> MOLGPJKKGDG(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHNCJNBIPIN(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CCHOAGPEOMK(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PJEDBEKHKFF(in TAction HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OBEDAPFHNNE(in TAction HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BLBGGIEBNDI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::NAIGPHDKDMM<OLAFPGDKDFA> NKFEFDJMJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDADOLLGEMG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBBNENBOLHO(in global::NAIGPHDKDMM<EOEPNCFGKHL> PLGIOFIFKAF, in TAction HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class OLAFPGDKDFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class EOEPNCFGKHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BKBOAGEEKID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::NBAJOFBNDNI<TAction, Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>>, TActionReceiver> where TActionReceiver : global::CGJKJIIAIOL<TAction, Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>>> where TActionDeps : global::KMIKANMOBPI<TAction> where TStaticNetSysDeps : global::BLBGGIEBNDI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface JKFLBCBBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ICDFIJGJKPI(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GHOBBEJEFHD();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::JBJLEIEDEDK<object, LPBJPNFEEEO> DIPADEMBDCB();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NBHHEBFNMLE(Exception PIDHAAOEIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class GFEIODCLOLH : JKFLBCBBKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> ECJJFJDELCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> NBMOAPMIIDI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37C0380", Offset = "0x37BF380", VA = "0x1837C0380")]
		private GFEIODCLOLH(TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> IIKFHKAKJBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37C0250", Offset = "0x37BF250", VA = "0x1837C0250")]
		public static GFEIODCLOLH JAJKAINKHFL(TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> IIKFHKAKJBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x37C01F0", Offset = "0x37BF1F0", VA = "0x1837C01F0")]
		public void ICDFIJGJKPI(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37C0130", Offset = "0x37BF130", VA = "0x1837C0130", Slot = "5")]
		public void GHOBBEJEFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x37C0090", Offset = "0x37BF090", VA = "0x1837C0090", Slot = "6")]
		public global::JBJLEIEDEDK<object, LPBJPNFEEEO> DIPADEMBDCB()
		{
			return default(global::JBJLEIEDEDK<object, LPBJPNFEEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x37C0320", Offset = "0x37BF320", VA = "0x1837C0320", Slot = "7")]
		public void NBHHEBFNMLE(Exception PIDHAAOEIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37BF390", Offset = "0x37BE390", VA = "0x1837BF390", Slot = "4")]
		private void CHGKLJEEHDC(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class KJPMJPCEEPP : JKFLBCBBKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> ECJJFJDELCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::JBJLEIEDEDK<object, LPBJPNFEEEO> GFNJINPPCCA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
		private KJPMJPCEEPP(TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> IIKFHKAKJBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37C0250", Offset = "0x37BF250", VA = "0x1837C0250")]
		public static KJPMJPCEEPP JAJKAINKHFL(TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> IIKFHKAKJBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x22EC1D0", Offset = "0x22EB1D0", VA = "0x1822EC1D0")]
		public void ICDFIJGJKPI(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37C91A0", Offset = "0x37C81A0", VA = "0x1837C91A0", Slot = "5")]
		public void GHOBBEJEFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x58E000", Offset = "0x58D000", VA = "0x18058E000", Slot = "6")]
		public global::JBJLEIEDEDK<object, LPBJPNFEEEO> DIPADEMBDCB()
		{
			return default(global::JBJLEIEDEDK<object, LPBJPNFEEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x37C9200", Offset = "0x37C8200", VA = "0x1837C9200", Slot = "7")]
		public void NBHHEBFNMLE(Exception PIDHAAOEIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37BF390", Offset = "0x37BE390", VA = "0x1837BF390", Slot = "4")]
		private void CHGKLJEEHDC(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class CBEPKLMCFLA : JKFLBCBBKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> NBMOAPMIIDI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x37BF540", Offset = "0x37BE540", VA = "0x1837BF540")]
		private CBEPKLMCFLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37BF480", Offset = "0x37BE480", VA = "0x1837BF480")]
		public static CBEPKLMCFLA JAJKAINKHFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x37BF420", Offset = "0x37BE420", VA = "0x1837BF420")]
		public void ICDFIJGJKPI(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		public void GHOBBEJEFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37BF3C0", Offset = "0x37BE3C0", VA = "0x1837BF3C0", Slot = "6")]
		public global::JBJLEIEDEDK<object, LPBJPNFEEEO> DIPADEMBDCB()
		{
			return default(global::JBJLEIEDEDK<object, LPBJPNFEEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		public void NBHHEBFNMLE(Exception PIDHAAOEIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37BF390", Offset = "0x37BE390", VA = "0x1837BF390", Slot = "4")]
		private void CHGKLJEEHDC(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class GHFDPFGHBED : JKFLBCBBKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::JBJLEIEDEDK<object, LPBJPNFEEEO> GFNJINPPCCA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		private GHFDPFGHBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37BF480", Offset = "0x37BE480", VA = "0x1837BF480")]
		public static GHFDPFGHBED JAJKAINKHFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x11557A0", Offset = "0x11547A0", VA = "0x1811557A0")]
		public void ICDFIJGJKPI(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		public void GHOBBEJEFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89E740", Offset = "0x89D740", VA = "0x18089E740", Slot = "6")]
		public global::JBJLEIEDEDK<object, LPBJPNFEEEO> DIPADEMBDCB()
		{
			return default(global::JBJLEIEDEDK<object, LPBJPNFEEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		public void NBHHEBFNMLE(Exception PIDHAAOEIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37BF390", Offset = "0x37BE390", VA = "0x1837BF390", Slot = "4")]
		private void CHGKLJEEHDC(in global::JBJLEIEDEDK<object, LPBJPNFEEEO> CLNIDHLHIFO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct LCBDOPAFLHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::BKBOAGEEKID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::NAIGPHDKDMM<OLAFPGDKDFA> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::NAIGPHDKDMM<EOEPNCFGKHL> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37C9260", Offset = "0x37C8260", VA = "0x1837C9260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37C9490", Offset = "0x37C8490", VA = "0x1837C9490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IGHAICAIMCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::BKBOAGEEKID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::NAIGPHDKDMM<OLAFPGDKDFA> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::NAIGPHDKDMM<EOEPNCFGKHL> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JKFLBCBBKCC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x37C89C0", Offset = "0x37C79C0", VA = "0x1837C89C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C9150", Offset = "0x37C8150", VA = "0x1837C9150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LLGABGBEMMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::BKBOAGEEKID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public JKFLBCBBKCC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JKFLBCBBKCC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C94E0", Offset = "0x37C84E0", VA = "0x1837C94E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EEFE0", Offset = "0x7EDFE0", VA = "0x1807EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver BDOEEGOKFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps MPDJMGKDBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps HIHFDLBLGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int GEECKHIDBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int JODMKOBGBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::NAIGPHDKDMM<EOEPNCFGKHL>, TaskCompletionSource<global::JBJLEIEDEDK<object, LPBJPNFEEEO>>> NCGLDGKCAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::BHHKKCANDBE<EOEPNCFGKHL> OIONNGAICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool ENKCDPBOCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OMNNHAKCIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task COMDDHPCCKI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37BB9F0", Offset = "0x37BA9F0", VA = "0x1837BB9F0")]
	protected BKBOAGEEKID(TActionDeps FHOACOMCGNM, TStaticNetSysDeps JPINCDBFPCK, int CPBPFCOFALG, int EKFMIDENJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37BB5E0", Offset = "0x37BA5E0", VA = "0x1837BB5E0")]
	public static global::BKBOAGEEKID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> JAJKAINKHFL(TActionDeps FHOACOMCGNM, TStaticNetSysDeps JPINCDBFPCK, [Optional] int? CPBPFCOFALG, [Optional] int? EKFMIDENJLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37BB170", Offset = "0x37BA170", VA = "0x1837BB170")]
	public Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> FBBNENBOLHO(in TAction HCHPGKLEJDC, bool ADKLIGOFHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x37BB860", Offset = "0x37BA860", VA = "0x1837BB860")]
	public void KKNKICFJGIF(in TActionReceiver NHCEOFEONHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x37BB490", Offset = "0x37BA490", VA = "0x1837BB490")]
	[AsyncStateMachine(typeof(global::BKBOAGEEKID<, , , >.LCBDOPAFLHH))]
	public Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> FPPNHEMFEEF(global::NAIGPHDKDMM<OLAFPGDKDFA> NOMLJBFLBIA, global::NAIGPHDKDMM<EOEPNCFGKHL> PLGIOFIFKAF, TAction HCHPGKLEJDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37BB710", Offset = "0x37BA710", VA = "0x1837BB710")]
	[AsyncStateMachine(typeof(global::BKBOAGEEKID<, , , >.IGHAICAIMCD))]
	private Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> KFHKABMPKEG(global::NAIGPHDKDMM<OLAFPGDKDFA> NOMLJBFLBIA, global::NAIGPHDKDMM<EOEPNCFGKHL> PLGIOFIFKAF, TAction HCHPGKLEJDC, Task ACICBFLAAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37BB020", Offset = "0x37BA020", VA = "0x1837BB020")]
	[AsyncStateMachine(typeof(global::BKBOAGEEKID<, , , >.LLGABGBEMMC))]
	private Task ECIFNJPDMDD(TAction HCHPGKLEJDC, JKFLBCBBKCC NIIGIBNKLGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x37BB870", Offset = "0x37BA870", VA = "0x1837BB870")]
	private void OOOFEEAJLEC(TAction HCHPGKLEJDC, bool PFCNPNFKDJI, bool KDIGMIIHPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36FDC00", Offset = "0x36FCC00", VA = "0x1836FDC00", Slot = "4")]
	private Task<global::JBJLEIEDEDK<object, LPBJPNFEEEO>> KOAAAAHPAIF(in TAction HCHPGKLEJDC, bool ADKLIGOFHHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class HBJPCEEOLOG : LPBJPNFEEEO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xDDEA70", Offset = "0xDDDA70", VA = "0x180DDEA70", Slot = "4")]
	public override string OCOCCHOJEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xDDEAA0", Offset = "0xDDDAA0", VA = "0x180DDEAA0")]
	private HBJPCEEOLOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5C20", Offset = "0x1FD4C20", VA = "0x181FD5C20")]
	public static global::JBJLEIEDEDK<TOk, LPBJPNFEEEO> JAJKAINKHFL<TOk>()
	{
		return default(global::JBJLEIEDEDK<TOk, LPBJPNFEEEO>);
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

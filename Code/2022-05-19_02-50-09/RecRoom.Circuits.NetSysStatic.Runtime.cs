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
public interface CJFJIFDKMJF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FAKMAOCHJOD(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction JKJEGMECCGL(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction AAJABBGFGEB(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> JEPLCJCODEA(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJBMLCFABOK(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDACGEGEBAE(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBJOHHPBKFL(in TAction LKFICPAOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DOMCFIDLOFJ(in TAction LKFICPAOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CAOCKBGGEFF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::NIIAMMJDGBF<LAIHPLCBCID> NMECKOLAGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPFLKAIKADB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJOHLCJAPOM(in global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, in TAction LKFICPAOGAF);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct LAIHPLCBCID
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ILPDIEMIAFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> : global::IAJNAKGDMGK<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>, TActionReceiver> where TActionReceiver : global::AHGIFHHEOPA<TAction, Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>>> where TActionDeps : global::CJFJIFDKMJF<TAction> where TNetSysStaticDeps : global::CAOCKBGGEFF<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface LNNGDDNLLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IIOKBMEOKBC(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GHDBPAKDCHE();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::FHODMMLKDCI<object, IJNOAGNJEPI> DIOIHADBNDF();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GCJPHCJIMOH(Exception OFOCFFBMPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class AGMJCKKCOCC : LNNGDDNLLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> BAALIBCEIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::FHODMMLKDCI<object, IJNOAGNJEPI>> DGBMGNGEHII;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3964350", Offset = "0x3962F50", VA = "0x183964350")]
		private AGMJCKKCOCC(TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> COBJOIOPADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x39640D0", Offset = "0x3962CD0", VA = "0x1839640D0")]
		public static AGMJCKKCOCC EEJCKKCGPGE(TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> COBJOIOPADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x39642C0", Offset = "0x3962EC0", VA = "0x1839642C0")]
		public void IIOKBMEOKBC(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3964200", Offset = "0x3962E00", VA = "0x183964200", Slot = "5")]
		public void GHDBPAKDCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3964030", Offset = "0x3962C30", VA = "0x183964030", Slot = "6")]
		public global::FHODMMLKDCI<object, IJNOAGNJEPI> DIOIHADBNDF()
		{
			return default(global::FHODMMLKDCI<object, IJNOAGNJEPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39641A0", Offset = "0x3962DA0", VA = "0x1839641A0", Slot = "7")]
		public void GCJPHCJIMOH(Exception OFOCFFBMPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3964320", Offset = "0x3962F20", VA = "0x183964320", Slot = "4")]
		private void NMJAJCOPPBK(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class EKLOCPEPGMK : LNNGDDNLLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> BAALIBCEIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::FHODMMLKDCI<object, IJNOAGNJEPI> JHDAILCAJEG;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
		private EKLOCPEPGMK(TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> COBJOIOPADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39640D0", Offset = "0x3962CD0", VA = "0x1839640D0")]
		public static EKLOCPEPGMK EEJCKKCGPGE(TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>> COBJOIOPADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3616FC0", Offset = "0x3615BC0", VA = "0x183616FC0")]
		public void IIOKBMEOKBC(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3964D60", Offset = "0x3963960", VA = "0x183964D60", Slot = "5")]
		public void GHDBPAKDCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x577CC0", Offset = "0x5768C0", VA = "0x180577CC0", Slot = "6")]
		public global::FHODMMLKDCI<object, IJNOAGNJEPI> DIOIHADBNDF()
		{
			return default(global::FHODMMLKDCI<object, IJNOAGNJEPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3964D00", Offset = "0x3963900", VA = "0x183964D00", Slot = "7")]
		public void GCJPHCJIMOH(Exception OFOCFFBMPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3964320", Offset = "0x3962F20", VA = "0x183964320", Slot = "4")]
		private void NMJAJCOPPBK(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class IFFGKLELANI : LNNGDDNLLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::FHODMMLKDCI<object, IJNOAGNJEPI>> DGBMGNGEHII;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3965020", Offset = "0x3963C20", VA = "0x183965020")]
		private IFFGKLELANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3964F00", Offset = "0x3963B00", VA = "0x183964F00")]
		public static IFFGKLELANI EEJCKKCGPGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3964FC0", Offset = "0x3963BC0", VA = "0x183964FC0")]
		public void IIOKBMEOKBC(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		public void GHDBPAKDCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3964EA0", Offset = "0x3963AA0", VA = "0x183964EA0", Slot = "6")]
		public global::FHODMMLKDCI<object, IJNOAGNJEPI> DIOIHADBNDF()
		{
			return default(global::FHODMMLKDCI<object, IJNOAGNJEPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
		public void GCJPHCJIMOH(Exception OFOCFFBMPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3964320", Offset = "0x3962F20", VA = "0x183964320", Slot = "4")]
		private void NMJAJCOPPBK(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class KBHMIFCHOKA : LNNGDDNLLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::FHODMMLKDCI<object, IJNOAGNJEPI> JHDAILCAJEG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
		private KBHMIFCHOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3964F00", Offset = "0x3963B00", VA = "0x183964F00")]
		public static KBHMIFCHOKA EEJCKKCGPGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xD2E440", Offset = "0xD2D040", VA = "0x180D2E440")]
		public void IIOKBMEOKBC(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
		public void GHDBPAKDCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60B9A0", Offset = "0x60A5A0", VA = "0x18060B9A0", Slot = "6")]
		public global::FHODMMLKDCI<object, IJNOAGNJEPI> DIOIHADBNDF()
		{
			return default(global::FHODMMLKDCI<object, IJNOAGNJEPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "7")]
		public void GCJPHCJIMOH(Exception OFOCFFBMPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3964320", Offset = "0x3962F20", VA = "0x183964320", Slot = "4")]
		private void NMJAJCOPPBK(in global::FHODMMLKDCI<object, IJNOAGNJEPI> JAGEKFPDBNG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PFKFHIBCOGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::NIIAMMJDGBF<LAIHPLCBCID> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::NIIAMMJDGBF<ILPDIEMIAFN> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x397B710", Offset = "0x397A310", VA = "0x18397B710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x397B940", Offset = "0x397A540", VA = "0x18397B940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OKJFBPKFNDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::NIIAMMJDGBF<LAIHPLCBCID> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::NIIAMMJDGBF<ILPDIEMIAFN> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LNNGDDNLLDM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x397AF30", Offset = "0x3979B30", VA = "0x18397AF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x397B6C0", Offset = "0x397A2C0", VA = "0x18397B6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AAJEGCJNIMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LNNGDDNLLDM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LNNGDDNLLDM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::FHODMMLKDCI<object, IJNOAGNJEPI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3963190", Offset = "0x3961D90", VA = "0x183963190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77BFA0", Offset = "0x77ABA0", VA = "0x18077BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver BGHOLDFJJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps EKHOPPEIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TNetSysStaticDeps KHCNIOIPCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int HMOLJDLBPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int OINCEEICLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::NIIAMMJDGBF<ILPDIEMIAFN>, TaskCompletionSource<global::FHODMMLKDCI<object, IJNOAGNJEPI>>> DLCLIAPPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::MNOJPIOMNMH<ILPDIEMIAFN> FBDJHKJHCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool BCOOBKKLBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int HCIDLILLPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task LCCHDEJCKNG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3974570", Offset = "0x3973170", VA = "0x183974570")]
	protected MIIEDBEEEIH(TActionDeps DIFHAMJOHML, TNetSysStaticDeps OLMBMIODFOK, int LPCCCAFCMOC, int JOOJICHPOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3973D10", Offset = "0x3972910", VA = "0x183973D10")]
	public static global::MIIEDBEEEIH<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> EEJCKKCGPGE(TActionDeps DIFHAMJOHML, TNetSysStaticDeps OLMBMIODFOK, [Optional] int? LPCCCAFCMOC, [Optional] int? JOOJICHPOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3974270", Offset = "0x3972E70", VA = "0x183974270")]
	public Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> PJOHLCJAPOM(in TAction LKFICPAOGAF, bool PKEKOJOLKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3973F90", Offset = "0x3972B90", VA = "0x183973F90")]
	public void KMMEILOANOG(in TActionReceiver PFKFCIMCCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3974120", Offset = "0x3972D20", VA = "0x183974120")]
	[AsyncStateMachine(typeof(global::MIIEDBEEEIH<, , , >.PFKFHIBCOGN))]
	public Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> OEGJEPEDMHG(global::NIIAMMJDGBF<LAIHPLCBCID> GKPALPCHPGC, global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, TAction LKFICPAOGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3973E40", Offset = "0x3972A40", VA = "0x183973E40")]
	[AsyncStateMachine(typeof(global::MIIEDBEEEIH<, , , >.OKJFBPKFNDG))]
	private Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> HGEDCJPKGEJ(global::NIIAMMJDGBF<LAIHPLCBCID> GKPALPCHPGC, global::NIIAMMJDGBF<ILPDIEMIAFN> LOPJAFGHKAB, TAction LKFICPAOGAF, Task CHIDJKJMFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3973BC0", Offset = "0x39727C0", VA = "0x183973BC0")]
	[AsyncStateMachine(typeof(global::MIIEDBEEEIH<, , , >.AAJEGCJNIMM))]
	private Task CICJCEONAFK(TAction LKFICPAOGAF, LNNGDDNLLDM EIKNEDFODEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3973FA0", Offset = "0x3972BA0", VA = "0x183973FA0")]
	private void LNCMDECNIAB(TAction LKFICPAOGAF, bool DPFLLBGIJFC, bool HHEGDFNGGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xEEB490", Offset = "0xEEA090", VA = "0x180EEB490", Slot = "4")]
	private Task<global::FHODMMLKDCI<object, IJNOAGNJEPI>> JCJHMHCNCPA(in TAction LKFICPAOGAF, bool PKEKOJOLKLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class JPJLJNLCHFL : IJNOAGNJEPI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x17EEA50", Offset = "0x17ED650", VA = "0x1817EEA50", Slot = "4")]
	public override string MFLNIBFKCPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x17D3B00", Offset = "0x17D2700", VA = "0x1817D3B00")]
	private JPJLJNLCHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28A3E70", Offset = "0x28A2A70", VA = "0x1828A3E70")]
	public static global::FHODMMLKDCI<TOk, IJNOAGNJEPI> EEJCKKCGPGE<TOk>()
	{
		return default(global::FHODMMLKDCI<TOk, IJNOAGNJEPI>);
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

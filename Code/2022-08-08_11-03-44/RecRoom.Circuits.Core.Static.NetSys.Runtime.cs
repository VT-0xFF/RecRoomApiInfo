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
public interface FPIILGPLKMM<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PBFKLFDPMCB(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction OIEADDJNAJF(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction KIHMOJAFPGI(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> FIMADEONOJK(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCIMEOAGBAA(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KMLOAOPEKOH(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGHPMEPCHOB(in TAction BBNMGAFNKKA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OJBFPODIFEG(in TAction BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PNALEMKGDEN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::DCHMGJIDBKL<NCCOFOHMJND> JIHCHIFLNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIAFDPAADAG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFGHCHHLFJG(in global::DCHMGJIDBKL<MJODHJHFNDC> NCGBBOGNEFK, in TAction BBNMGAFNKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NCCOFOHMJND
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MJODHJHFNDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LDMBAILANKG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::NAMOCKKDOKA<TAction, Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>>, TActionReceiver> where TActionReceiver : global::BFFNDBLDCBK<TAction, Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>>> where TActionDeps : global::FPIILGPLKMM<TAction> where TStaticNetSysDeps : global::PNALEMKGDEN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface ONKHCKFNMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CLBJKDPCNFN(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IOPEGNGMIMJ();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::CBPCPHCNNGD<object, MNEDAJBNPNI> IIBIBMABOOG();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LEDLGAKCALP(Exception IEBKBOEFGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class GHJNAOAAECL : ONKHCKFNMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> HPIELNBABLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> IHJIJHJNBJE;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27B7B10", Offset = "0x27B6B10", VA = "0x1827B7B10")]
		private GHJNAOAAECL(TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> FFAPFGAHCHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x27B6E20", Offset = "0x27B5E20", VA = "0x1827B6E20")]
		public static GHJNAOAAECL NEPKDIDOCIM(TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> FFAPFGAHCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27B78F0", Offset = "0x27B68F0", VA = "0x1827B78F0")]
		public void CLBJKDPCNFN(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27B79F0", Offset = "0x27B69F0", VA = "0x1827B79F0", Slot = "5")]
		public void IOPEGNGMIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27B7950", Offset = "0x27B6950", VA = "0x1827B7950", Slot = "6")]
		public global::CBPCPHCNNGD<object, MNEDAJBNPNI> IIBIBMABOOG()
		{
			return default(global::CBPCPHCNNGD<object, MNEDAJBNPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27B7AB0", Offset = "0x27B6AB0", VA = "0x1827B7AB0", Slot = "7")]
		public void LEDLGAKCALP(Exception IEBKBOEFGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D30", Offset = "0x27B5D30", VA = "0x1827B6D30", Slot = "4")]
		private void GDAPEBCMBDG(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class CEHFKIMAGAE : ONKHCKFNMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> HPIELNBABLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::CBPCPHCNNGD<object, MNEDAJBNPNI> PCBKNODHAFL;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
		private CEHFKIMAGAE(TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> FFAPFGAHCHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x27B6E20", Offset = "0x27B5E20", VA = "0x1827B6E20")]
		public static CEHFKIMAGAE NEPKDIDOCIM(TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> FFAPFGAHCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x25E3A00", Offset = "0x25E2A00", VA = "0x1825E3A00")]
		public void CLBJKDPCNFN(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D60", Offset = "0x27B5D60", VA = "0x1827B6D60", Slot = "5")]
		public void IOPEGNGMIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E6000", Offset = "0x5E5000", VA = "0x1805E6000", Slot = "6")]
		public global::CBPCPHCNNGD<object, MNEDAJBNPNI> IIBIBMABOOG()
		{
			return default(global::CBPCPHCNNGD<object, MNEDAJBNPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x27B6DC0", Offset = "0x27B5DC0", VA = "0x1827B6DC0", Slot = "7")]
		public void LEDLGAKCALP(Exception IEBKBOEFGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D30", Offset = "0x27B5D30", VA = "0x1827B6D30", Slot = "4")]
		private void GDAPEBCMBDG(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class MECIDPGOFEP : ONKHCKFNMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> IHJIJHJNBJE;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27C24F0", Offset = "0x27C14F0", VA = "0x1827C24F0")]
		private MECIDPGOFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x27C2430", Offset = "0x27C1430", VA = "0x1827C2430")]
		public static MECIDPGOFEP NEPKDIDOCIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x27C2370", Offset = "0x27C1370", VA = "0x1827C2370")]
		public void CLBJKDPCNFN(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		public void IOPEGNGMIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x27C23D0", Offset = "0x27C13D0", VA = "0x1827C23D0", Slot = "6")]
		public global::CBPCPHCNNGD<object, MNEDAJBNPNI> IIBIBMABOOG()
		{
			return default(global::CBPCPHCNNGD<object, MNEDAJBNPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		public void LEDLGAKCALP(Exception IEBKBOEFGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D30", Offset = "0x27B5D30", VA = "0x1827B6D30", Slot = "4")]
		private void GDAPEBCMBDG(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class POFMDPDAIHC : ONKHCKFNMNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::CBPCPHCNNGD<object, MNEDAJBNPNI> PCBKNODHAFL;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
		private POFMDPDAIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27C2430", Offset = "0x27C1430", VA = "0x1827C2430")]
		public static POFMDPDAIHC NEPKDIDOCIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xFA30B0", Offset = "0xFA20B0", VA = "0x180FA30B0")]
		public void CLBJKDPCNFN(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
		public void IOPEGNGMIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A40", Offset = "0x8F5A40", VA = "0x1808F6A40", Slot = "6")]
		public global::CBPCPHCNNGD<object, MNEDAJBNPNI> IIBIBMABOOG()
		{
			return default(global::CBPCPHCNNGD<object, MNEDAJBNPNI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "7")]
		public void LEDLGAKCALP(Exception IEBKBOEFGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D30", Offset = "0x27B5D30", VA = "0x1827B6D30", Slot = "4")]
		private void GDAPEBCMBDG(in global::CBPCPHCNNGD<object, MNEDAJBNPNI> HCBFPGACPND)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PGMMNFJLING : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::LDMBAILANKG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::DCHMGJIDBKL<NCCOFOHMJND> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::DCHMGJIDBKL<MJODHJHFNDC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27C3D60", Offset = "0x27C2D60", VA = "0x1827C3D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27C3F90", Offset = "0x27C2F90", VA = "0x1827C3F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EGCGGDBMEMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::LDMBAILANKG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::DCHMGJIDBKL<NCCOFOHMJND> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::DCHMGJIDBKL<MJODHJHFNDC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ONKHCKFNMNJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x27B6EF0", Offset = "0x27B5EF0", VA = "0x1827B6EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x27B7680", Offset = "0x27B6680", VA = "0x1827B7680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PGGMDNGNEGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::LDMBAILANKG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ONKHCKFNMNJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ONKHCKFNMNJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x27C33C0", Offset = "0x27C23C0", VA = "0x1827C33C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x8462E0", VA = "0x1808472E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver IAKBHAJHPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps AAGOPDLCIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps AODKKGJMKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int FCJBFCKIFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int IFHKAAPBBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::DCHMGJIDBKL<MJODHJHFNDC>, TaskCompletionSource<global::CBPCPHCNNGD<object, MNEDAJBNPNI>>> JLKIGIIOOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::CONPKHHMOPG<MJODHJHFNDC> HCFJDEKCPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool OGMKDKIAMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int DILFGPNOEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task GIPHGJKFLNP;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27BEBC0", Offset = "0x27BDBC0", VA = "0x1827BEBC0")]
	protected LDMBAILANKG(TActionDeps EAKKEFDIHJC, TStaticNetSysDeps IECDEHGCLPD, int EMGJHJEJLNP, int IBGFMIDHJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27BE940", Offset = "0x27BD940", VA = "0x1827BE940")]
	public static global::LDMBAILANKG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> NEPKDIDOCIM(TActionDeps EAKKEFDIHJC, TStaticNetSysDeps IECDEHGCLPD, [Optional] int? EMGJHJEJLNP, [Optional] int? IBGFMIDHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27BE610", Offset = "0x27BD610", VA = "0x1827BE610")]
	public Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> LFGHCHHLFJG(in TAction BBNMGAFNKKA, bool NKBBMBINAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27BE360", Offset = "0x27BD360", VA = "0x1827BE360")]
	public void EJHIFIGAHEF(in TActionReceiver FIDBIICPHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27BEA70", Offset = "0x27BDA70", VA = "0x1827BEA70")]
	[AsyncStateMachine(typeof(global::LDMBAILANKG<, , , >.PGMMNFJLING))]
	public Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> OCBGPHLLHGM(global::DCHMGJIDBKL<NCCOFOHMJND> DAFFLDMGCDH, global::DCHMGJIDBKL<MJODHJHFNDC> NCGBBOGNEFK, TAction BBNMGAFNKKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27BE370", Offset = "0x27BD370", VA = "0x1827BE370")]
	[AsyncStateMachine(typeof(global::LDMBAILANKG<, , , >.EGCGGDBMEMA))]
	private Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> FOHJHEDFJPB(global::DCHMGJIDBKL<NCCOFOHMJND> DAFFLDMGCDH, global::DCHMGJIDBKL<MJODHJHFNDC> NCGBBOGNEFK, TAction BBNMGAFNKKA, Task KDODFJFMLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27BE4C0", Offset = "0x27BD4C0", VA = "0x1827BE4C0")]
	[AsyncStateMachine(typeof(global::LDMBAILANKG<, , , >.PGGMDNGNEGF))]
	private Task IOJEJIJBKCP(TAction BBNMGAFNKKA, ONKHCKFNMNJ JNLOEFEDAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27BE1E0", Offset = "0x27BD1E0", VA = "0x1827BE1E0")]
	private void EALLBJLAFGP(TAction BBNMGAFNKKA, bool AEHFKIPGFFO, bool EEDPCGJFKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27BE910", Offset = "0x27BD910", VA = "0x1827BE910", Slot = "4")]
	private Task<global::CBPCPHCNNGD<object, MNEDAJBNPNI>> NENMANDOJKC(in TAction BBNMGAFNKKA, bool NKBBMBINAAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DOAGGEIHKGE : MNEDAJBNPNI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE55EA0", Offset = "0xE54EA0", VA = "0x180E55EA0", Slot = "4")]
	public override string EGAJHLFBPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE55ED0", Offset = "0xE54ED0", VA = "0x180E55ED0")]
	private DOAGGEIHKGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2382450", Offset = "0x2381450", VA = "0x182382450")]
	public static global::CBPCPHCNNGD<TOk, MNEDAJBNPNI> NEPKDIDOCIM<TOk>()
	{
		return default(global::CBPCPHCNNGD<TOk, MNEDAJBNPNI>);
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

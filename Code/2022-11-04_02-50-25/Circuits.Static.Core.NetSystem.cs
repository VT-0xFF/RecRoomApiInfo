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
public interface CHDPELCAKDP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MFPHBMOMFNA(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction APDEOAFMAGE(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction PFCIKBIJGIC(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> NLEHLOFJAHO(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool POMIBEBKPFA(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OHLGPFICMIF(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MKFIEILIHKH(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HMEDJCFIMJO(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MMEALGLKEOL(in TAction PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NGGFJDMHNCG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::JNODMCDPIFF<POLGLFONENJ> JCKNHINNLKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDHILLOHCHK();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GABCAHGBCNE(global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, in TAction PADKGNIPPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OLIPMPCIIFP<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult BEAFJEOGIOP(in TAction PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] EPBGLJJOMJA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DFNMNCKBNFK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NEJFKNJELPO(TPartialSnapshot GAFMGMBMJKI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot CIPJEOAIBBM(TPartialSnapshot[] KBKMIOLBNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class POLGLFONENJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LJKPAHHIEAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::OLIPMPCIIFP<TAction, Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>>> where TActionDeps : global::CHDPELCAKDP<TAction> where TStaticNetSysDeps : global::NGGFJDMHNCG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface PEFLELLEADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AOEGMHFDIKN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MDAIOFHOEFC();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::EMJKJMHNAHC<object, JFEOKEIGAEM> NIPGBLMGDCN();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HKLFLJLEEMO(Exception HAFLEMDJHOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class IMBCLMKJDHM : PEFLELLEADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> AIFJAMLOLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> FOFAEAJADHL;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14288D0", Offset = "0x1427CD0", VA = "0x1814288D0")]
		private IMBCLMKJDHM(TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> KHPGKCLMKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1428580", Offset = "0x1427980", VA = "0x181428580")]
		public static IMBCLMKJDHM AJMCJLMMDDK(TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> KHPGKCLMKEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1428650", Offset = "0x1427A50", VA = "0x181428650")]
		public void AOEGMHFDIKN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1428740", Offset = "0x1427B40", VA = "0x181428740", Slot = "5")]
		public void MDAIOFHOEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1428820", Offset = "0x1427C20", VA = "0x181428820", Slot = "6")]
		public global::EMJKJMHNAHC<object, JFEOKEIGAEM> NIPGBLMGDCN()
		{
			return default(global::EMJKJMHNAHC<object, JFEOKEIGAEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14286E0", Offset = "0x1427AE0", VA = "0x1814286E0", Slot = "7")]
		public void HKLFLJLEEMO(Exception HAFLEMDJHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14286B0", Offset = "0x1427AB0", VA = "0x1814286B0", Slot = "4")]
		private void EHAOBNNGHPN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class BCGAFDNHNLK : PEFLELLEADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> AIFJAMLOLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::EMJKJMHNAHC<object, JFEOKEIGAEM> NKBMJAOOANJ;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2180DB0", Offset = "0x21801B0", VA = "0x182180DB0")]
		private BCGAFDNHNLK(TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> KHPGKCLMKEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1428580", Offset = "0x1427980", VA = "0x181428580")]
		public static BCGAFDNHNLK AJMCJLMMDDK(TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> KHPGKCLMKEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB3B0", Offset = "0x2CAA7B0", VA = "0x182CAB3B0")]
		public void AOEGMHFDIKN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB430", Offset = "0x2CAA830", VA = "0x182CAB430", Slot = "5")]
		public void MDAIOFHOEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68E040", Offset = "0x68D440", VA = "0x18068E040", Slot = "6")]
		public global::EMJKJMHNAHC<object, JFEOKEIGAEM> NIPGBLMGDCN()
		{
			return default(global::EMJKJMHNAHC<object, JFEOKEIGAEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB3D0", Offset = "0x2CAA7D0", VA = "0x182CAB3D0", Slot = "7")]
		public void HKLFLJLEEMO(Exception HAFLEMDJHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x14286B0", Offset = "0x1427AB0", VA = "0x1814286B0", Slot = "4")]
		private void EHAOBNNGHPN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class CODCLMHPMJB : PEFLELLEADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> FOFAEAJADHL;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2767300", Offset = "0x2766700", VA = "0x182767300")]
		private CODCLMHPMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2767180", Offset = "0x2766580", VA = "0x182767180")]
		public static CODCLMHPMJB AJMCJLMMDDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2767240", Offset = "0x2766640", VA = "0x182767240")]
		public void AOEGMHFDIKN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		public void MDAIOFHOEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27672A0", Offset = "0x27666A0", VA = "0x1827672A0", Slot = "6")]
		public global::EMJKJMHNAHC<object, JFEOKEIGAEM> NIPGBLMGDCN()
		{
			return default(global::EMJKJMHNAHC<object, JFEOKEIGAEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		public void HKLFLJLEEMO(Exception HAFLEMDJHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x14286B0", Offset = "0x1427AB0", VA = "0x1814286B0", Slot = "4")]
		private void EHAOBNNGHPN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NEHMEFLLKFB : PEFLELLEADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::EMJKJMHNAHC<object, JFEOKEIGAEM> NKBMJAOOANJ;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x111EA00", Offset = "0x111DE00", VA = "0x18111EA00")]
		private NEHMEFLLKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2767180", Offset = "0x2766580", VA = "0x182767180")]
		public static NEHMEFLLKFB AJMCJLMMDDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x11D1EA0", Offset = "0x11D12A0", VA = "0x1811D1EA0")]
		public void AOEGMHFDIKN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
		public void MDAIOFHOEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD9AD10", Offset = "0xD9A110", VA = "0x180D9AD10", Slot = "6")]
		public global::EMJKJMHNAHC<object, JFEOKEIGAEM> NIPGBLMGDCN()
		{
			return default(global::EMJKJMHNAHC<object, JFEOKEIGAEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
		public void HKLFLJLEEMO(Exception HAFLEMDJHOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x14286B0", Offset = "0x1427AB0", VA = "0x1814286B0", Slot = "4")]
		private void EHAOBNNGHPN(in global::EMJKJMHNAHC<object, JFEOKEIGAEM> HNCBGLIPCEM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IKCFIPJBFIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::JNODMCDPIFF<POLGLFONENJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::JNODMCDPIFF<LJKPAHHIEAK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1422850", Offset = "0x1421C50", VA = "0x181422850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1422B00", Offset = "0x1421F00", VA = "0x181422B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LEAAODPFMLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JNODMCDPIFF<POLGLFONENJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::JNODMCDPIFF<LJKPAHHIEAK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PEFLELLEADJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1ED3DD0", Offset = "0x1ED31D0", VA = "0x181ED3DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1ED45D0", Offset = "0x1ED39D0", VA = "0x181ED45D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct EAGHCNNEKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PEFLELLEADJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PEFLELLEADJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x28B54E0", Offset = "0x28B48E0", VA = "0x1828B54E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x675320", Offset = "0x674720", VA = "0x180675320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver EKCHEBCDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps GEOPKNEOFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps AFIKEMNMDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int FCAOGLJJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ONFFHAJAFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::JNODMCDPIFF<LJKPAHHIEAK>, TaskCompletionSource<global::EMJKJMHNAHC<object, JFEOKEIGAEM>>> MJKPEHDFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::CIJKLNILEON<LJKPAHHIEAK> AFNLPPEIJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool PPNICJFAKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int NPCKNOPNPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task DLFOKDGEKIO;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28B6EB0", Offset = "0x28B62B0", VA = "0x1828B6EB0")]
	protected EALKLKIFFCK(TActionDeps JFFIIBEPFIL, TStaticNetSysDeps CJMFKJOIHGI, int AJMDBBBCNDH, int CPCFFCAMJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x28B6460", Offset = "0x28B5860", VA = "0x1828B6460")]
	public static global::EALKLKIFFCK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> AJMCJLMMDDK(TActionDeps JFFIIBEPFIL, TStaticNetSysDeps CJMFKJOIHGI, [Optional] int? AJMDBBBCNDH, [Optional] int? CPCFFCAMJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28B6A20", Offset = "0x28B5E20", VA = "0x1828B6A20")]
	public Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> GABCAHGBCNE(in TAction PADKGNIPPLI, bool JFECAICJEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28B6EA0", Offset = "0x28B62A0", VA = "0x1828B6EA0")]
	public void JILJOBPIAPE(in TActionReceiver KLHHBJEIAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28B65A0", Offset = "0x28B59A0", VA = "0x1828B65A0")]
	[AsyncStateMachine(typeof(global::EALKLKIFFCK<, , , >.IKCFIPJBFIE))]
	public Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> BEAFJEOGIOP(global::JNODMCDPIFF<POLGLFONENJ> KOLHFJMEBIH, global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, TAction PADKGNIPPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28B6D30", Offset = "0x28B6130", VA = "0x1828B6D30")]
	[AsyncStateMachine(typeof(global::EALKLKIFFCK<, , , >.LEAAODPFMLG))]
	private Task<global::EMJKJMHNAHC<object, JFEOKEIGAEM>> HCNIEEEOGGP(global::JNODMCDPIFF<POLGLFONENJ> KOLHFJMEBIH, global::JNODMCDPIFF<LJKPAHHIEAK> LADEHDCBEKA, TAction PADKGNIPPLI, Task ACCJDNEINBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28B68E0", Offset = "0x28B5CE0", VA = "0x1828B68E0")]
	[AsyncStateMachine(typeof(global::EALKLKIFFCK<, , , >.EAGHCNNEKCD))]
	private Task FODIPEOHDLD(TAction PADKGNIPPLI, PEFLELLEADJ BCKELOJFINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28B6700", Offset = "0x28B5B00", VA = "0x1828B6700")]
	private void CAOMNGJEIND(TAction PADKGNIPPLI, bool FNHPFOHCCPC, bool LJNHICLAFHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JMFDNADMBKJ<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::DFNMNCKBNFK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] DBPAACPIJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int LCCMDPPFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps LCFKANIOINC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D266F0", Offset = "0x2D25AF0", VA = "0x182D266F0")]
	internal JMFDNADMBKJ(TPartialSnapshot[] JPAGALEEDGP, int NHHLIIMALMG, TDeps LFLGCLEIAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D26170", Offset = "0x2D25570", VA = "0x182D26170")]
	public global::NHPIDFCKLDI<TFullSnapshot> BJHDMGBMBJC(TPartialSnapshot GAFMGMBMJKI)
	{
		return default(global::NHPIDFCKLDI<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D265F0", Offset = "0x2D259F0", VA = "0x182D265F0")]
	public bool IDLIEHGKHBK(TPartialSnapshot GAFMGMBMJKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2D26110", Offset = "0x2D25510", VA = "0x182D26110")]
	public static global::JMFDNADMBKJ<TPartialSnapshot, TFullSnapshot, TDeps> AJMCJLMMDDK(TDeps LFLGCLEIAAH)
	{
		return default(global::JMFDNADMBKJ<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MOIONKNFGIC : JFEOKEIGAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xF6F3A0", Offset = "0xF6E7A0", VA = "0x180F6F3A0", Slot = "5")]
	public override string MBOPCLKAOCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xF6F3D0", Offset = "0xF6E7D0", VA = "0x180F6F3D0")]
	public MOIONKNFGIC()
	{
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

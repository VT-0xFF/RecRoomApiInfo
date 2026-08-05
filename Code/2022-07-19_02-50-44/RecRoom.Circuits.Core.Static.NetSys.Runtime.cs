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
public interface LBLNKFCHCBO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CBBDFIBEFDI(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction HBANLFDJFCF(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction FMCBDFNBHFH(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> NMNADEBAEBD(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KFNFCMMJLJI(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFNLJAPLJHA(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CAPKHOFFIBE(in TAction KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NGBHPDECLFG(in TAction KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DNHOJFJJNHG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::JPAPJNLNBDM<GCBHMFAJGAB> EJPOJLGEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAKCFJPPAJJ();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJLEAHNCHKF(in global::JPAPJNLNBDM<PNNIADHJCGK> DEFBCFDDMOH, in TAction KAIJPPOLHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GCBHMFAJGAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class PNNIADHJCGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LDJAOOGJBPI<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::PDHLLAFBAFL<TAction, Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>>, TActionReceiver> where TActionReceiver : global::ECBKJDANLKI<TAction, Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>>> where TActionDeps : global::LBLNKFCHCBO<TAction> where TStaticNetSysDeps : global::DNHOJFJJNHG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface BFDCEOBJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EHPMKBHDHIH(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FEHKIHHIHDL();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::GKGLDIOCNEG<object, EFGELJPFJOA> PIBNKBIEMIC();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FNCCDJLMPNM(Exception DAEKODHMJFN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class PKHIPOIDMJB : BFDCEOBJBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> PHKPBAFGCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::GKGLDIOCNEG<object, EFGELJPFJOA>> LODJMOALHIB;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x31988B0", Offset = "0x31978B0", VA = "0x1831988B0")]
		private PKHIPOIDMJB(TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> KINOKAGEMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3183A20", Offset = "0x3182A20", VA = "0x183183A20")]
		public static PKHIPOIDMJB PFJGPKGHGPI(TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> KINOKAGEMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3198690", Offset = "0x3197690", VA = "0x183198690")]
		public void EHPMKBHDHIH(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x31986F0", Offset = "0x31976F0", VA = "0x1831986F0", Slot = "5")]
		public void FEHKIHHIHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3198810", Offset = "0x3197810", VA = "0x183198810", Slot = "6")]
		public global::GKGLDIOCNEG<object, EFGELJPFJOA> PIBNKBIEMIC()
		{
			return default(global::GKGLDIOCNEG<object, EFGELJPFJOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x31987B0", Offset = "0x31977B0", VA = "0x1831987B0", Slot = "7")]
		public void FNCCDJLMPNM(Exception DAEKODHMJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3183930", Offset = "0x3182930", VA = "0x183183930", Slot = "4")]
		private void ANKIFNHMANL(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class BDDBDPFLHMF : BFDCEOBJBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> PHKPBAFGCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::GKGLDIOCNEG<object, EFGELJPFJOA> CAODPPODIGC;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x214B810", Offset = "0x214A810", VA = "0x18214B810")]
		private BDDBDPFLHMF(TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> KINOKAGEMLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3183A20", Offset = "0x3182A20", VA = "0x183183A20")]
		public static BDDBDPFLHMF PFJGPKGHGPI(TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>> KINOKAGEMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC060", Offset = "0x2ABB060", VA = "0x182ABC060")]
		public void EHPMKBHDHIH(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3183960", Offset = "0x3182960", VA = "0x183183960", Slot = "5")]
		public void FEHKIHHIHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x58D000", Offset = "0x58C000", VA = "0x18058D000", Slot = "6")]
		public global::GKGLDIOCNEG<object, EFGELJPFJOA> PIBNKBIEMIC()
		{
			return default(global::GKGLDIOCNEG<object, EFGELJPFJOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x31839C0", Offset = "0x31829C0", VA = "0x1831839C0", Slot = "7")]
		public void FNCCDJLMPNM(Exception DAEKODHMJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3183930", Offset = "0x3182930", VA = "0x183183930", Slot = "4")]
		private void ANKIFNHMANL(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class KEGNJNEONNK : BFDCEOBJBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::GKGLDIOCNEG<object, EFGELJPFJOA>> LODJMOALHIB;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3186D60", Offset = "0x3185D60", VA = "0x183186D60")]
		private KEGNJNEONNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3186BE0", Offset = "0x3185BE0", VA = "0x183186BE0")]
		public static KEGNJNEONNK PFJGPKGHGPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3186CA0", Offset = "0x3185CA0", VA = "0x183186CA0")]
		public void EHPMKBHDHIH(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		public void FEHKIHHIHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3186D00", Offset = "0x3185D00", VA = "0x183186D00", Slot = "6")]
		public global::GKGLDIOCNEG<object, EFGELJPFJOA> PIBNKBIEMIC()
		{
			return default(global::GKGLDIOCNEG<object, EFGELJPFJOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		public void FNCCDJLMPNM(Exception DAEKODHMJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3183930", Offset = "0x3182930", VA = "0x183183930", Slot = "4")]
		private void ANKIFNHMANL(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JMHGNPJPFPN : BFDCEOBJBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::GKGLDIOCNEG<object, EFGELJPFJOA> CAODPPODIGC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		private JMHGNPJPFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3186BE0", Offset = "0x3185BE0", VA = "0x183186BE0")]
		public static JMHGNPJPFPN PFJGPKGHGPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x195ABE0", Offset = "0x1959BE0", VA = "0x18195ABE0")]
		public void EHPMKBHDHIH(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		public void FEHKIHHIHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89D740", Offset = "0x89C740", VA = "0x18089D740", Slot = "6")]
		public global::GKGLDIOCNEG<object, EFGELJPFJOA> PIBNKBIEMIC()
		{
			return default(global::GKGLDIOCNEG<object, EFGELJPFJOA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "7")]
		public void FNCCDJLMPNM(Exception DAEKODHMJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3183930", Offset = "0x3182930", VA = "0x183183930", Slot = "4")]
		private void ANKIFNHMANL(in global::GKGLDIOCNEG<object, EFGELJPFJOA> IMDEFJLGKKO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NOFGBHPNMDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::GKGLDIOCNEG<object, EFGELJPFJOA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::LDJAOOGJBPI<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::JPAPJNLNBDM<GCBHMFAJGAB> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::JPAPJNLNBDM<PNNIADHJCGK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::GKGLDIOCNEG<object, EFGELJPFJOA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3196D20", Offset = "0x3195D20", VA = "0x183196D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3196F50", Offset = "0x3195F50", VA = "0x183196F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PIKHEEIDDGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::GKGLDIOCNEG<object, EFGELJPFJOA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::LDJAOOGJBPI<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JPAPJNLNBDM<GCBHMFAJGAB> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::JPAPJNLNBDM<PNNIADHJCGK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BFDCEOBJBMG <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x31970A0", Offset = "0x31960A0", VA = "0x1831970A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3197830", Offset = "0x3196830", VA = "0x183197830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct BJACIOAGLAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::LDJAOOGJBPI<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BFDCEOBJBMG completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BFDCEOBJBMG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::GKGLDIOCNEG<object, EFGELJPFJOA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3183AF0", Offset = "0x3182AF0", VA = "0x183183AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver ELGAJPEOKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps DLNBCFJNPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps PHKEJFJIDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int GCMDPFKCOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ACAELENMDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::JPAPJNLNBDM<PNNIADHJCGK>, TaskCompletionSource<global::GKGLDIOCNEG<object, EFGELJPFJOA>>> JGABJCNNAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::HHPNFFNHABO<PNNIADHJCGK> MNHACMEKGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool CAMLGJIOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int COEMOAAIIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PCMMBGBJDCL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x318C870", Offset = "0x318B870", VA = "0x18318C870")]
	protected LDJAOOGJBPI(TActionDeps NBOGLGPBKNK, TStaticNetSysDeps KIMLDAIGELI, int EJCJBNBKJHE, int JGGNKCDNPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x318C740", Offset = "0x318B740", VA = "0x18318C740")]
	public static global::LDJAOOGJBPI<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> PFJGPKGHGPI(TActionDeps NBOGLGPBKNK, TStaticNetSysDeps KIMLDAIGELI, [Optional] int? EJCJBNBKJHE, [Optional] int? JGGNKCDNPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x318C2B0", Offset = "0x318B2B0", VA = "0x18318C2B0")]
	public Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>> FJLEAHNCHKF(in TAction KAIJPPOLHDF, bool LJIHFKMFBDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x318C730", Offset = "0x318B730", VA = "0x18318C730")]
	public void NEKDONGNBMM(in TActionReceiver NPOLNLDOBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x318C160", Offset = "0x318B160", VA = "0x18318C160")]
	[AsyncStateMachine(typeof(global::LDJAOOGJBPI<, , , >.NOFGBHPNMDH))]
	public Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>> ELLBPCEKFPB(global::JPAPJNLNBDM<GCBHMFAJGAB> IFLPJKFKLOO, global::JPAPJNLNBDM<PNNIADHJCGK> DEFBCFDDMOH, TAction KAIJPPOLHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x318C010", Offset = "0x318B010", VA = "0x18318C010")]
	[AsyncStateMachine(typeof(global::LDJAOOGJBPI<, , , >.PIKHEEIDDGG))]
	private Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>> DPGAKCDKLMG(global::JPAPJNLNBDM<GCBHMFAJGAB> IFLPJKFKLOO, global::JPAPJNLNBDM<PNNIADHJCGK> DEFBCFDDMOH, TAction KAIJPPOLHDF, Task PHLOOGLIMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x318BEC0", Offset = "0x318AEC0", VA = "0x18318BEC0")]
	[AsyncStateMachine(typeof(global::LDJAOOGJBPI<, , , >.BJACIOAGLAG))]
	private Task DFAAECBKOFA(TAction KAIJPPOLHDF, BFDCEOBJBMG AEDCECGPMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x318C5B0", Offset = "0x318B5B0", VA = "0x18318C5B0")]
	private void NCBECNPGNMG(TAction KAIJPPOLHDF, bool NOFHFLKMBKD, bool KOJGDLGAGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x214A270", Offset = "0x2149270", VA = "0x18214A270", Slot = "4")]
	private Task<global::GKGLDIOCNEG<object, EFGELJPFJOA>> LLILDCMFJCB(in TAction KAIJPPOLHDF, bool LJIHFKMFBDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class NKLOGEPHIKF : EFGELJPFJOA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5218190", Offset = "0x5217190", VA = "0x185218190", Slot = "4")]
	public override string LIPFFLJHLPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD22A0", Offset = "0x1DD12A0", VA = "0x181DD22A0")]
	private NKLOGEPHIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7AB50", Offset = "0x1D79B50", VA = "0x181D7AB50")]
	public static global::GKGLDIOCNEG<TOk, EFGELJPFJOA> PFJGPKGHGPI<TOk>()
	{
		return default(global::GKGLDIOCNEG<TOk, EFGELJPFJOA>);
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

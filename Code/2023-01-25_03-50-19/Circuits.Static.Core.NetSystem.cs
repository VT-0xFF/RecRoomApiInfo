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
public interface AFCMNEINPLP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BPLLEAIFALN(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction IJFNOECNKAG(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction EBDOMMJPIAP(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> AEMHJCJJJBG(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHHAKJKFOME(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ICLJDDDNBPP(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PHMNCNNMNIG(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DMLDKEKHLAJ(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FKMGONCEBAI(in TAction KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKEDILOCCCN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::HAFOMODBANL<DDPCMMGPIMK> DLFHHMDEMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFAAKKIDEIA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFKGJNNCGKG(global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, in TAction KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIHDJDJEGJE<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult JBMEPBLDKNH(in TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] DFBJEKKCMLF();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HBLECACADCK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GFPENJMDPGA(TPartialSnapshot BINHEDAEFFC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot NABHOAGPIHE(TPartialSnapshot[] OJMOIOMDLLO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class DDPCMMGPIMK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NKJHJCIIFAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::KIHDJDJEGJE<TAction, Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>>> where TActionDeps : global::AFCMNEINPLP<TAction> where TStaticNetSysDeps : global::OKEDILOCCCN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface NDIBENEHBON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BHINFNEOFAA(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBADGPBOPKB();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::CIOEKKBILIB<object, AAHLPJGCFPM> FFILGAEEKJJ();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PNABAPFFCHN(Exception ILBPMKLBBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class GCMLEKGNAEE : NDIBENEHBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> LHBEFEOABNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::CIOEKKBILIB<object, AAHLPJGCFPM>> FJDBNJBNGJH;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x39E76A0", Offset = "0x39E66A0", VA = "0x1839E76A0")]
		private GCMLEKGNAEE(TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> HNEOJOBAEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2012C40", Offset = "0x2011C40", VA = "0x182012C40")]
		public static GCMLEKGNAEE DHGKFEMNGCO(TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> HNEOJOBAEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39E7450", Offset = "0x39E6450", VA = "0x1839E7450")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x39E74B0", Offset = "0x39E64B0", VA = "0x1839E74B0", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x39E7590", Offset = "0x39E6590", VA = "0x1839E7590", Slot = "6")]
		public global::CIOEKKBILIB<object, AAHLPJGCFPM> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, AAHLPJGCFPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39E7640", Offset = "0x39E6640", VA = "0x1839E7640", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2014CE0", Offset = "0x2013CE0", VA = "0x182014CE0", Slot = "4")]
		private void KIAEPILJFPJ(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class HEBLLBJDEHM : NDIBENEHBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> LHBEFEOABNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::CIOEKKBILIB<object, AAHLPJGCFPM> ABBPPNDDPGO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E22D40", Offset = "0x1E21D40", VA = "0x181E22D40")]
		private HEBLLBJDEHM(TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> HNEOJOBAEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2012C40", Offset = "0x2011C40", VA = "0x182012C40")]
		public static HEBLLBJDEHM DHGKFEMNGCO(TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>> HNEOJOBAEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DDB0", Offset = "0x2A7CDB0", VA = "0x182A7DDB0")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31803A0", Offset = "0x317F3A0", VA = "0x1831803A0", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69F040", Offset = "0x69E040", VA = "0x18069F040", Slot = "6")]
		public global::CIOEKKBILIB<object, AAHLPJGCFPM> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, AAHLPJGCFPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3180400", Offset = "0x317F400", VA = "0x183180400", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2014CE0", Offset = "0x2013CE0", VA = "0x182014CE0", Slot = "4")]
		private void KIAEPILJFPJ(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class DOMAEDHFNPD : NDIBENEHBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::CIOEKKBILIB<object, AAHLPJGCFPM>> FJDBNJBNGJH;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4780", Offset = "0x28E3780", VA = "0x1828E4780")]
		private DOMAEDHFNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2014C20", Offset = "0x2013C20", VA = "0x182014C20")]
		public static DOMAEDHFNPD DHGKFEMNGCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28E46C0", Offset = "0x28E36C0", VA = "0x1828E46C0")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28E4720", Offset = "0x28E3720", VA = "0x1828E4720", Slot = "6")]
		public global::CIOEKKBILIB<object, AAHLPJGCFPM> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, AAHLPJGCFPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2014CE0", Offset = "0x2013CE0", VA = "0x182014CE0", Slot = "4")]
		private void KIAEPILJFPJ(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EOFLFAMDHPE : NDIBENEHBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::CIOEKKBILIB<object, AAHLPJGCFPM> ABBPPNDDPGO;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		private EOFLFAMDHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2014C20", Offset = "0x2013C20", VA = "0x182014C20")]
		public static EOFLFAMDHPE DHGKFEMNGCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2014C00", Offset = "0x2013C00", VA = "0x182014C00")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xC39000", Offset = "0xC38000", VA = "0x180C39000", Slot = "6")]
		public global::CIOEKKBILIB<object, AAHLPJGCFPM> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, AAHLPJGCFPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2014CE0", Offset = "0x2013CE0", VA = "0x182014CE0", Slot = "4")]
		private void KIAEPILJFPJ(in global::CIOEKKBILIB<object, AAHLPJGCFPM> MMPEAFKIOCN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EHNDEMCCPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::HAFOMODBANL<DDPCMMGPIMK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::HAFOMODBANL<NKJHJCIIFAD> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2004F40", Offset = "0x2003F40", VA = "0x182004F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20051F0", Offset = "0x20041F0", VA = "0x1820051F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FKHIGEHEBCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::HAFOMODBANL<DDPCMMGPIMK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::HAFOMODBANL<NKJHJCIIFAD> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NDIBENEHBON <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6350", Offset = "0x2DF5350", VA = "0x182DF6350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6BA0", Offset = "0x2DF5BA0", VA = "0x182DF6BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GEIAJLIHEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NDIBENEHBON completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NDIBENEHBON <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::CIOEKKBILIB<object, AAHLPJGCFPM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2842690", Offset = "0x2841690", VA = "0x182842690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x686320", Offset = "0x685320", VA = "0x180686320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver BFPAOFJOFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps MGBBCGPFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps NBOLKHGHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int MJNHGHBJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int FMKHAALHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::HAFOMODBANL<NKJHJCIIFAD>, TaskCompletionSource<global::CIOEKKBILIB<object, AAHLPJGCFPM>>> NBAHOHCCHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::EMAHPJPPGJJ<NKJHJCIIFAD> IKCEJBOKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BJLMKMPKCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task AHBDJMPIJME;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HGIAHGCOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x721CE0", Offset = "0x720CE0", VA = "0x180721CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x722490", Offset = "0x721490", VA = "0x180722490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x272CFF0", Offset = "0x272BFF0", VA = "0x18272CFF0")]
	protected ECMLGMEJJHG(TActionDeps OGGGDKHOPFL, TStaticNetSysDeps DMLAPEAJMPI, int EMDMKLEPAGN, int BJPCHODLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x272C6F0", Offset = "0x272B6F0", VA = "0x18272C6F0")]
	public static global::ECMLGMEJJHG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> DHGKFEMNGCO(TActionDeps OGGGDKHOPFL, TStaticNetSysDeps DMLAPEAJMPI, [Optional] int? EMDMKLEPAGN, [Optional] int? BJPCHODLDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x272CAD0", Offset = "0x272BAD0", VA = "0x18272CAD0")]
	public Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>> KFKGJNNCGKG(in TAction KNOLDLABLMF, bool PEPLEKBABLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x272CDE0", Offset = "0x272BDE0", VA = "0x18272CDE0")]
	public void LAJECDENEHN(in TActionReceiver LMMAFFJKAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x272C970", Offset = "0x272B970", VA = "0x18272C970")]
	[AsyncStateMachine(typeof(global::ECMLGMEJJHG<, , , >.EHNDEMCCPMD))]
	public Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>> JBMEPBLDKNH(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x272C580", Offset = "0x272B580", VA = "0x18272C580")]
	[AsyncStateMachine(typeof(global::ECMLGMEJJHG<, , , >.FKHIGEHEBCL))]
	private Task<global::CIOEKKBILIB<object, AAHLPJGCFPM>> BLLPNKEGMBC(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF, Task JCNCOIHLMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x272C830", Offset = "0x272B830", VA = "0x18272C830")]
	[AsyncStateMachine(typeof(global::ECMLGMEJJHG<, , , >.GEIAJLIHEAN))]
	private Task FNKOENDAOPA(TAction KNOLDLABLMF, NDIBENEHBON CDJBMOIECDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x272CDF0", Offset = "0x272BDF0", VA = "0x18272CDF0")]
	private void MGLHGCCDAEH(TAction KNOLDLABLMF, bool GAPGIFMINAL, bool KOJCANEGMMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::HBLECACADCK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] KLJAGMOGELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int PBAMPLNOMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps HOKAKDDBBJK;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2E47BE0", Offset = "0x2E46BE0", VA = "0x182E47BE0")]
	internal HONDBPJHLDA(TPartialSnapshot[] OHKHJIDFBNC, int CPKANIFAHNN, TDeps GODJKHDKJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2E47660", Offset = "0x2E46660", VA = "0x182E47660")]
	public global::GEAFEOEEKFP<TFullSnapshot> JOFMPBCGHFF(TPartialSnapshot BINHEDAEFFC)
	{
		return default(global::GEAFEOEEKFP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E47B90", Offset = "0x2E46B90", VA = "0x182E47B90")]
	public bool OAPHIJHHCEF(TPartialSnapshot BINHEDAEFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E47600", Offset = "0x2E46600", VA = "0x182E47600")]
	public static global::HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps> DHGKFEMNGCO(TDeps GODJKHDKJCI)
	{
		return default(global::HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MLDJCOEKOLB : AAHLPJGCFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6127830", Offset = "0x6126830", VA = "0x186127830", Slot = "5")]
	public override string HDMGCOABJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C18D90", Offset = "0x2C17D90", VA = "0x182C18D90")]
	public MLDJCOEKOLB()
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

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
	int BPLLEAIFALN(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction IJFNOECNKAG(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction EBDOMMJPIAP(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> AEMHJCJJJBG(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHHAKJKFOME(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ICLJDDDNBPP(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PHMNCNNMNIG(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DMLDKEKHLAJ(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FKMGONCEBAI(TAction KNOLDLABLMF);
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

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ODJEEOJMCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFAAKKIDEIA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFKGJNNCGKG(global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HBLECACADCK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GFPENJMDPGA(in TPartialSnapshot BINHEDAEFFC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot NABHOAGPIHE(TPartialSnapshot[] OJMOIOMDLLO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IAHDNKIBGIG<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult JBMEPBLDKNH(TAction KNOLDLABLMF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] DFBJEKKCMLF();
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
public struct HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::HBLECACADCK<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TPartialSnapshot[] KLJAGMOGELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private int PBAMPLNOMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private TDeps HOKAKDDBBJK;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50907B0", Offset = "0x508F5B0", VA = "0x1850907B0")]
	internal HONDBPJHLDA(TPartialSnapshot[] OHKHJIDFBNC, int CPKANIFAHNN, TDeps GODJKHDKJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5090240", Offset = "0x508F040", VA = "0x185090240")]
	public global::GEAFEOEEKFP<TFullSnapshot> JOFMPBCGHFF(TPartialSnapshot BINHEDAEFFC)
	{
		return default(global::GEAFEOEEKFP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5090760", Offset = "0x508F560", VA = "0x185090760")]
	public bool OAPHIJHHCEF(TPartialSnapshot BINHEDAEFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50901E0", Offset = "0x508EFE0", VA = "0x1850901E0")]
	public static global::HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps> DHGKFEMNGCO(TDeps GODJKHDKJCI)
	{
		return default(global::HONDBPJHLDA<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MLDJCOEKOLB : LEGBELBGIHF
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2277230", Offset = "0x2276030", VA = "0x182277230", Slot = "5")]
	public override string HDMGCOABJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2277260", Offset = "0x2276060", VA = "0x182277260")]
	public MLDJCOEKOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AICJKIIDADG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::IAHDNKIBGIG<TAction, Task<global::CIOEKKBILIB<object, LEGBELBGIHF>>> where TActionDeps : global::AFCMNEINPLP<TAction> where TStaticNetSysDeps : global::OKEDILOCCCN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private interface CGFJJIKEOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BHINFNEOFAA(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBADGPBOPKB();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::CIOEKKBILIB<object, LEGBELBGIHF> FFILGAEEKJJ();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PNABAPFFCHN(Exception ILBPMKLBBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IJFDPGHOBCO : CGFJJIKEOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> LHBEFEOABNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::CIOEKKBILIB<object, AAHLPJGCFPM>> FJDBNJBNGJH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x366D120", Offset = "0x366BF20", VA = "0x18366D120")]
		private IJFDPGHOBCO(TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> HNEOJOBAEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF160", Offset = "0x2CCDF60", VA = "0x182CCF160")]
		public static IJFDPGHOBCO DHGKFEMNGCO(TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> HNEOJOBAEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x366CE90", Offset = "0x366BC90", VA = "0x18366CE90")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x366CF30", Offset = "0x366BD30", VA = "0x18366CF30", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x366D010", Offset = "0x366BE10", VA = "0x18366D010", Slot = "6")]
		public global::CIOEKKBILIB<object, LEGBELBGIHF> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, LEGBELBGIHF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x366D0C0", Offset = "0x366BEC0", VA = "0x18366D0C0", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FAD0", Offset = "0x2E6E8D0", VA = "0x182E6FAD0", Slot = "4")]
		private void FDIEHHCAHOH(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class LCAOCINIGMA : CGFJJIKEOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> LHBEFEOABNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::CIOEKKBILIB<object, LEGBELBGIHF> ABBPPNDDPGO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
		private LCAOCINIGMA(TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> HNEOJOBAEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2CCF160", Offset = "0x2CCDF60", VA = "0x182CCF160")]
		public static LCAOCINIGMA DHGKFEMNGCO(TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>> HNEOJOBAEGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xACF570", Offset = "0xACE370", VA = "0x180ACF570")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FA70", Offset = "0x2E6E870", VA = "0x182E6FA70", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9FCE90", Offset = "0x9FBC90", VA = "0x1809FCE90", Slot = "6")]
		public global::CIOEKKBILIB<object, LEGBELBGIHF> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, LEGBELBGIHF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FB00", Offset = "0x2E6E900", VA = "0x182E6FB00", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FAD0", Offset = "0x2E6E8D0", VA = "0x182E6FAD0", Slot = "4")]
		private void FDIEHHCAHOH(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class OFKPNDJPFDI : CGFJJIKEOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::CIOEKKBILIB<object, LEGBELBGIHF>> FJDBNJBNGJH;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3370", Offset = "0x3BD2170", VA = "0x183BD3370")]
		private OFKPNDJPFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3250", Offset = "0x3BD2050", VA = "0x183BD3250")]
		public static OFKPNDJPFDI DHGKFEMNGCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BD31F0", Offset = "0x3BD1FF0", VA = "0x183BD31F0")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3310", Offset = "0x3BD2110", VA = "0x183BD3310", Slot = "6")]
		public global::CIOEKKBILIB<object, LEGBELBGIHF> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, LEGBELBGIHF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FAD0", Offset = "0x2E6E8D0", VA = "0x182E6FAD0", Slot = "4")]
		private void FDIEHHCAHOH(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class MELIPIDIIKM : CGFJJIKEOPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::CIOEKKBILIB<object, LEGBELBGIHF> ABBPPNDDPGO;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		private MELIPIDIIKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD3250", Offset = "0x3BD2050", VA = "0x183BD3250")]
		public static MELIPIDIIKM DHGKFEMNGCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF2C0", Offset = "0x9EE0C0", VA = "0x1809EF2C0")]
		public void BHINFNEOFAA(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		public void DBADGPBOPKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710", Slot = "6")]
		public global::CIOEKKBILIB<object, LEGBELBGIHF> FFILGAEEKJJ()
		{
			return default(global::CIOEKKBILIB<object, LEGBELBGIHF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		public void PNABAPFFCHN(Exception ILBPMKLBBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FAD0", Offset = "0x2E6E8D0", VA = "0x182E6FAD0", Slot = "4")]
		private void FDIEHHCAHOH(in global::CIOEKKBILIB<object, LEGBELBGIHF> MMPEAFKIOCN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OMGKLCDJFPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::HAFOMODBANL<DDPCMMGPIMK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::HAFOMODBANL<NKJHJCIIFAD> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x39D5650", Offset = "0x39D4450", VA = "0x1839D5650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39D5900", Offset = "0x39D4700", VA = "0x1839D5900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DLLPOABOOLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::HAFOMODBANL<DDPCMMGPIMK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::HAFOMODBANL<NKJHJCIIFAD> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CGFJJIKEOPL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3360", Offset = "0x3AB2160", VA = "0x183AB3360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3D20", Offset = "0x3AB2B20", VA = "0x183AB3D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BPEHBLBIGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CGFJJIKEOPL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private CGFJJIKEOPL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::CIOEKKBILIB<object, LEGBELBGIHF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x48A5290", Offset = "0x48A4090", VA = "0x1848A5290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver BFPAOFJOFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps MGBBCGPFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps NBOLKHGHFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int MJNHGHBJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int FMKHAALHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::HAFOMODBANL<NKJHJCIIFAD>, TaskCompletionSource<global::CIOEKKBILIB<object, LEGBELBGIHF>>> NBAHOHCCHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::EMAHPJPPGJJ<NKJHJCIIFAD> IKCEJBOKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int BJLMKMPKCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task AHBDJMPIJME;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HGIAHGCOGKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD4AFE0", Offset = "0xD49DE0", VA = "0x180D4AFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85DCE0", Offset = "0x85CAE0", VA = "0x18085DCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8380", Offset = "0x3FF7180", VA = "0x183FF8380")]
	protected AICJKIIDADG(TActionDeps OGGGDKHOPFL, TStaticNetSysDeps DMLAPEAJMPI, int EMDMKLEPAGN, int BJPCHODLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7AC0", Offset = "0x3FF68C0", VA = "0x183FF7AC0")]
	public static global::AICJKIIDADG<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> DHGKFEMNGCO(TActionDeps OGGGDKHOPFL, TStaticNetSysDeps DMLAPEAJMPI, [Optional] int? EMDMKLEPAGN, [Optional] int? BJPCHODLDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7EA0", Offset = "0x3FF6CA0", VA = "0x183FF7EA0")]
	public Task<global::CIOEKKBILIB<object, LEGBELBGIHF>> KFKGJNNCGKG(in TAction KNOLDLABLMF, bool PEPLEKBABLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8160", Offset = "0x3FF6F60", VA = "0x183FF8160")]
	public void LAJECDENEHN(in TActionReceiver LMMAFFJKAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7D40", Offset = "0x3FF6B40", VA = "0x183FF7D40")]
	[AsyncStateMachine(typeof(global::AICJKIIDADG<, , , >.OMGKLCDJFPG))]
	public Task<global::CIOEKKBILIB<object, LEGBELBGIHF>> JBMEPBLDKNH(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7950", Offset = "0x3FF6750", VA = "0x183FF7950")]
	[AsyncStateMachine(typeof(global::AICJKIIDADG<, , , >.DLLPOABOOLE))]
	private Task<global::CIOEKKBILIB<object, LEGBELBGIHF>> BLLPNKEGMBC(global::HAFOMODBANL<DDPCMMGPIMK> NMIOFDCBLLN, global::HAFOMODBANL<NKJHJCIIFAD> GHJCGFEINCI, TAction KNOLDLABLMF, Task JCNCOIHLMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7C00", Offset = "0x3FF6A00", VA = "0x183FF7C00")]
	[AsyncStateMachine(typeof(global::AICJKIIDADG<, , , >.BPEHBLBIGBB))]
	private Task FNKOENDAOPA(TAction KNOLDLABLMF, CGFJJIKEOPL CDJBMOIECDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3FF8170", Offset = "0x3FF6F70", VA = "0x183FF8170")]
	private void MGLHGCCDAEH(TAction KNOLDLABLMF, bool GAPGIFMINAL, bool KOJCANEGMMP)
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

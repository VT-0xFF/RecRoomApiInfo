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
public interface NCFBPLNMKCK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HICOJNHCKLB(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction PJFLAGKFNMF(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction GGJMNKPONIA(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> JFFOFIHIHNM(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DADFBEIBFCP(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEJCLNHCIBD(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EILMCLMJMAI(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HMGPCPDIJHH(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OJNLKOBLJFE(in TAction LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JMJHCBMNBBH<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::LMIAKNHHCGP<ODBEPGLKHGD> ENGBNKNNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDBHNBBADIL();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJLELEIHCDE(global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, in TAction LECDCDLGAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AABNGPLOKLH<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult BIMLJAEDILG(in TAction LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] NINJBGMKFNL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NILNICKFDMM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NEKNJCCCBNM(TPartialSnapshot BLOPFIJCPCC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot IKGEPBDLFDF(TPartialSnapshot[] CGJPHOPPDPG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ODBEPGLKHGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JJMABODIBOK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::AABNGPLOKLH<TAction, Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>>> where TActionDeps : global::NCFBPLNMKCK<TAction> where TStaticNetSysDeps : global::JMJHCBMNBBH<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface GIHNCIKJKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FNBHPCMKHCB(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NOLBCNOMLBK();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::BFOGDGGAJLJ<object, DJBJKBPDGID> FOAIPFFCNID();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MJKAAKOMCAJ(Exception DLEJGHMKMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class KPNMMMIOKHF : GIHNCIKJKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> PEKFODBHPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> OMGKHNNIPNM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x296ED20", Offset = "0x296E120", VA = "0x18296ED20")]
		private KPNMMMIOKHF(TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> LBIOFAMEJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x27802D0", Offset = "0x277F6D0", VA = "0x1827802D0")]
		public static KPNMMMIOKHF IKMCJIAOBME(TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> LBIOFAMEJGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x296EAD0", Offset = "0x296DED0", VA = "0x18296EAD0")]
		public void FNBHPCMKHCB(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x296EC40", Offset = "0x296E040", VA = "0x18296EC40", Slot = "5")]
		public void NOLBCNOMLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x296EB30", Offset = "0x296DF30", VA = "0x18296EB30", Slot = "6")]
		public global::BFOGDGGAJLJ<object, DJBJKBPDGID> FOAIPFFCNID()
		{
			return default(global::BFOGDGGAJLJ<object, DJBJKBPDGID>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x296EBE0", Offset = "0x296DFE0", VA = "0x18296EBE0", Slot = "7")]
		public void MJKAAKOMCAJ(Exception DLEJGHMKMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x251E6E0", Offset = "0x251DAE0", VA = "0x18251E6E0", Slot = "4")]
		private void BIOEHGHPJNF(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class ECOBBGKAMNA : GIHNCIKJKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> PEKFODBHPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BFOGDGGAJLJ<object, DJBJKBPDGID> ACKJNCOFIDL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1D528D0", Offset = "0x1D51CD0", VA = "0x181D528D0")]
		private ECOBBGKAMNA(TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> LBIOFAMEJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x27802D0", Offset = "0x277F6D0", VA = "0x1827802D0")]
		public static ECOBBGKAMNA IKMCJIAOBME(TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> LBIOFAMEJGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B93D30", Offset = "0x2B93130", VA = "0x182B93D30")]
		public void FNBHPCMKHCB(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D165A0", Offset = "0x3D159A0", VA = "0x183D165A0", Slot = "5")]
		public void NOLBCNOMLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "6")]
		public global::BFOGDGGAJLJ<object, DJBJKBPDGID> FOAIPFFCNID()
		{
			return default(global::BFOGDGGAJLJ<object, DJBJKBPDGID>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D16540", Offset = "0x3D15940", VA = "0x183D16540", Slot = "7")]
		public void MJKAAKOMCAJ(Exception DLEJGHMKMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x251E6E0", Offset = "0x251DAE0", VA = "0x18251E6E0", Slot = "4")]
		private void BIOEHGHPJNF(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class LOCLCEBDIMC : GIHNCIKJKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> OMGKHNNIPNM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x309B830", Offset = "0x309AC30", VA = "0x18309B830")]
		private LOCLCEBDIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x25D92D0", Offset = "0x25D86D0", VA = "0x1825D92D0")]
		public static LOCLCEBDIMC IKMCJIAOBME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x309B770", Offset = "0x309AB70", VA = "0x18309B770")]
		public void FNBHPCMKHCB(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void NOLBCNOMLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x309B7D0", Offset = "0x309ABD0", VA = "0x18309B7D0", Slot = "6")]
		public global::BFOGDGGAJLJ<object, DJBJKBPDGID> FOAIPFFCNID()
		{
			return default(global::BFOGDGGAJLJ<object, DJBJKBPDGID>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		public void MJKAAKOMCAJ(Exception DLEJGHMKMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x251E6E0", Offset = "0x251DAE0", VA = "0x18251E6E0", Slot = "4")]
		private void BIOEHGHPJNF(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class FONJFLMBHNC : GIHNCIKJKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::BFOGDGGAJLJ<object, DJBJKBPDGID> ACKJNCOFIDL;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		private FONJFLMBHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x25D92D0", Offset = "0x25D86D0", VA = "0x1825D92D0")]
		public static FONJFLMBHNC IKMCJIAOBME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x19D3B80", Offset = "0x19D2F80", VA = "0x1819D3B80")]
		public void FNBHPCMKHCB(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void NOLBCNOMLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780", Slot = "6")]
		public global::BFOGDGGAJLJ<object, DJBJKBPDGID> FOAIPFFCNID()
		{
			return default(global::BFOGDGGAJLJ<object, DJBJKBPDGID>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		public void MJKAAKOMCAJ(Exception DLEJGHMKMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x251E6E0", Offset = "0x251DAE0", VA = "0x18251E6E0", Slot = "4")]
		private void BIOEHGHPJNF(in global::BFOGDGGAJLJ<object, DJBJKBPDGID> MHKNFNJAIIH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct AIIJKKPKFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::LMIAKNHHCGP<ODBEPGLKHGD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::LMIAKNHHCGP<JJMABODIBOK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38C3E50", Offset = "0x38C3250", VA = "0x1838C3E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x38C4100", Offset = "0x38C3500", VA = "0x1838C4100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ECIGHBIEFCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::LMIAKNHHCGP<ODBEPGLKHGD> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::LMIAKNHHCGP<JJMABODIBOK> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GIHNCIKJKLF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x319FF70", Offset = "0x319F370", VA = "0x18319FF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x31A07C0", Offset = "0x319FBC0", VA = "0x1831A07C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JJOOALKNBMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public GIHNCIKJKLF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GIHNCIKJKLF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x20AE510", Offset = "0x20AD910", VA = "0x1820AE510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver OBJJCPMNHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps JMBFHBPILCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps PEJCJOCCIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int CLIFEICIAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int DMMBGIBLPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::LMIAKNHHCGP<JJMABODIBOK>, TaskCompletionSource<global::BFOGDGGAJLJ<object, DJBJKBPDGID>>> ECFIGEDFIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::BKAONPOBOPL<JJMABODIBOK> GFNFPLEBNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int CAJOPLKMELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task LDGFPIBNDBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LAKBKNGLPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71BCE0", Offset = "0x71B0E0", VA = "0x18071BCE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71C490", Offset = "0x71B890", VA = "0x18071C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B550", Offset = "0x2F8A950", VA = "0x182F8B550")]
	protected NBDFLKHKIAD(TActionDeps GIGCJOPCKEH, TStaticNetSysDeps FBMFMPAOAFO, int BGKDNKEIGCP, int PMAJJIAHEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B0C0", Offset = "0x2F8A4C0", VA = "0x182F8B0C0")]
	public static global::NBDFLKHKIAD<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> IKMCJIAOBME(TActionDeps GIGCJOPCKEH, TStaticNetSysDeps FBMFMPAOAFO, [Optional] int? BGKDNKEIGCP, [Optional] int? PMAJJIAHEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AC40", Offset = "0x2F8A040", VA = "0x182F8AC40")]
	public Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> DJLELEIHCDE(in TAction LECDCDLGAEL, bool CEBNHKMBPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B340", Offset = "0x2F8A740", VA = "0x182F8B340")]
	public void OGHKFEKCPGH(in TActionReceiver GBNOGDCDLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AAE0", Offset = "0x2F89EE0", VA = "0x182F8AAE0")]
	[AsyncStateMachine(typeof(global::NBDFLKHKIAD<, , , >.AIIJKKPKFBD))]
	public Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> BIMLJAEDILG(global::LMIAKNHHCGP<ODBEPGLKHGD> NKDDBGPFFOL, global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, TAction LECDCDLGAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AF50", Offset = "0x2F8A350", VA = "0x182F8AF50")]
	[AsyncStateMachine(typeof(global::NBDFLKHKIAD<, , , >.ECIGHBIEFCM))]
	private Task<global::BFOGDGGAJLJ<object, DJBJKBPDGID>> DOGNJDHDAEM(global::LMIAKNHHCGP<ODBEPGLKHGD> NKDDBGPFFOL, global::LMIAKNHHCGP<JJMABODIBOK> BCALFIAJEJK, TAction LECDCDLGAEL, Task CFIENNBHCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B200", Offset = "0x2F8A600", VA = "0x182F8B200")]
	[AsyncStateMachine(typeof(global::NBDFLKHKIAD<, , , >.JJOOALKNBMC))]
	private Task KJEKDEFKPCP(TAction LECDCDLGAEL, GIHNCIKJKLF LMODENCCPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F8B350", Offset = "0x2F8A750", VA = "0x182F8B350")]
	private void OJJPJEBHGIF(TAction LECDCDLGAEL, bool ADCDNNBFCKP, bool JOHDPHDIMAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KMCAHJLCEFA<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::NILNICKFDMM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] HKHFJGIAEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int PFJIDMIDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps PLDEBFMNDPG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x296A0D0", Offset = "0x29694D0", VA = "0x18296A0D0")]
	internal KMCAHJLCEFA(TPartialSnapshot[] LJCEGMODFOC, int DMIGOFEEDIF, TDeps MHCCDFMDJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2969C00", Offset = "0x2969000", VA = "0x182969C00")]
	public global::CANFHBMAPOB<TFullSnapshot> PFPECDLMAKN(TPartialSnapshot BLOPFIJCPCC)
	{
		return default(global::CANFHBMAPOB<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2969A30", Offset = "0x2968E30", VA = "0x182969A30")]
	public bool FENCNHBHMNN(TPartialSnapshot BLOPFIJCPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2969B30", Offset = "0x2968F30", VA = "0x182969B30")]
	public static global::KMCAHJLCEFA<TPartialSnapshot, TFullSnapshot, TDeps> IKMCJIAOBME(TDeps MHCCDFMDJCL)
	{
		return default(global::KMCAHJLCEFA<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FDHIBDFIHCK : DJBJKBPDGID
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xF729E0", Offset = "0xF71DE0", VA = "0x180F729E0", Slot = "5")]
	public override string FFDKGCBGJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xF72A10", Offset = "0xF71E10", VA = "0x180F72A10")]
	public FDHIBDFIHCK()
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

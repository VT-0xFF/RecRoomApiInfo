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
public interface GPPMOJODBHI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ALEINJJFECJ(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction CKCBEBMKBAJ(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction NPHPBGPICJP(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> JIHJPODEICC(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GCNGEIKKHON(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FDMDBDPEANL(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GEFINBJACEI(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BJNGKJFLEEH(in TAction NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FMFNKLLFHLM(in TAction NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JLBKIEPCJAG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::PANCFOBAJCC<LDBOMFHAOKE> OLKCIPOCJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEBNLMHHBNK();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFKEDGNJONE(in global::PANCFOBAJCC<MHIAMPBLGNJ> EKAJLPLOKDN, in TAction NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MAAGEDNFJGO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JEDGDNOCPEI(TPartialSnapshot KGHGLNGPCIG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot FJCFMCCIPIE(TPartialSnapshot[] MIOMOAHLNIO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LDBOMFHAOKE
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MHIAMPBLGNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::DFHOJKFINBC<TAction, Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>>, TActionReceiver> where TActionReceiver : global::JMPNMDBPCCF<TAction, Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>>> where TActionDeps : global::GPPMOJODBHI<TAction> where TStaticNetSysDeps : global::JLBKIEPCJAG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private interface PIPNKFGCECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EEONDELGNDL();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NKDIKFAJAFI(Exception OMAAJIFLBJK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class AGOAAFADIKH : PIPNKFGCECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> LKPAONHNFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::OANJAMKPOEA<object, LNLCMCKKKGI>> BKNECCKDCBL;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x26E0020", Offset = "0x26DF020", VA = "0x1826E0020")]
		private AGOAAFADIKH(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x26DF460", Offset = "0x26DE460", VA = "0x1826DF460")]
		public static AGOAAFADIKH AKMEFLONJDG(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26DFDD0", Offset = "0x26DEDD0", VA = "0x1826DFDD0")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x26DFE30", Offset = "0x26DEE30", VA = "0x1826DFE30", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x26DFF10", Offset = "0x26DEF10", VA = "0x1826DFF10", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x26DFFC0", Offset = "0x26DEFC0", VA = "0x1826DFFC0", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x204D850", Offset = "0x204C850", VA = "0x18204D850", Slot = "4")]
		private void POAEGGGHKDN(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class HPICMMNBHDP : PIPNKFGCECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> LKPAONHNFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::OANJAMKPOEA<object, LNLCMCKKKGI> LGHNDBHIOFL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9BB0", Offset = "0x1BB8BB0", VA = "0x181BB9BB0")]
		private HPICMMNBHDP(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x26DF460", Offset = "0x26DE460", VA = "0x1826DF460")]
		public static HPICMMNBHDP AKMEFLONJDG(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CF73E0", Offset = "0x2CF63E0", VA = "0x182CF73E0")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4AEB320", Offset = "0x4AEA320", VA = "0x184AEB320", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4AEB380", Offset = "0x4AEA380", VA = "0x184AEB380", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x204D850", Offset = "0x204C850", VA = "0x18204D850", Slot = "4")]
		private void POAEGGGHKDN(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CDFHOLMAHLF : PIPNKFGCECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::OANJAMKPOEA<object, LNLCMCKKKGI>> BKNECCKDCBL;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x35C1510", Offset = "0x35C0510", VA = "0x1835C1510")]
		private CDFHOLMAHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x204D790", Offset = "0x204C790", VA = "0x18204D790")]
		public static CDFHOLMAHLF AKMEFLONJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35C1450", Offset = "0x35C0450", VA = "0x1835C1450")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x35C14B0", Offset = "0x35C04B0", VA = "0x1835C14B0", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x204D850", Offset = "0x204C850", VA = "0x18204D850", Slot = "4")]
		private void POAEGGGHKDN(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class EGIKOIOMNNG : PIPNKFGCECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::OANJAMKPOEA<object, LNLCMCKKKGI> LGHNDBHIOFL;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		private EGIKOIOMNNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x204D790", Offset = "0x204C790", VA = "0x18204D790")]
		public static EGIKOIOMNNG AKMEFLONJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A4F6F0", Offset = "0x1A4E6F0", VA = "0x181A4F6F0")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x204D850", Offset = "0x204C850", VA = "0x18204D850", Slot = "4")]
		private void POAEGGGHKDN(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KGNMHPKMJPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::OANJAMKPOEA<object, LNLCMCKKKGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::PANCFOBAJCC<LDBOMFHAOKE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::PANCFOBAJCC<MHIAMPBLGNJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::OANJAMKPOEA<object, LNLCMCKKKGI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2900E10", Offset = "0x28FFE10", VA = "0x182900E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x29010C0", Offset = "0x29000C0", VA = "0x1829010C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MCHHEOPDIFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::OANJAMKPOEA<object, LNLCMCKKKGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::PANCFOBAJCC<LDBOMFHAOKE> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::PANCFOBAJCC<MHIAMPBLGNJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private PIPNKFGCECN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3E438F0", Offset = "0x3E428F0", VA = "0x183E438F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3E440F0", Offset = "0x3E430F0", VA = "0x183E440F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HMJKBOBPODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PIPNKFGCECN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PIPNKFGCECN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::OANJAMKPOEA<object, LNLCMCKKKGI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2407100", Offset = "0x2406100", VA = "0x182407100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver PLCPGKIHLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps INMLBBLHMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps ICCIKDFIKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int GOPMDCNFKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int HGKFPBIPOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::PANCFOBAJCC<MHIAMPBLGNJ>, TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>>> IJBAKKFOKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::DMEAPNEOEDP<MHIAMPBLGNJ> IGBOJEIHACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool CEDDDPEGHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int OODBIBAPLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task KNMKADMGNNN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2368C70", Offset = "0x2367C70", VA = "0x182368C70")]
	protected NDGFNIGIHGO(TActionDeps DAFIEDPDEGD, TStaticNetSysDeps LNHKPHCIMPM, int BHBICMHPFJF, int FCJDKJGPFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x23681E0", Offset = "0x23671E0", VA = "0x1823681E0")]
	public static global::NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> AKMEFLONJDG(TActionDeps DAFIEDPDEGD, TStaticNetSysDeps LNHKPHCIMPM, [Optional] int? BHBICMHPFJF, [Optional] int? FCJDKJGPFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2368950", Offset = "0x2367950", VA = "0x182368950")]
	public Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> KFKEDGNJONE(in TAction NCHNGIGODJK, bool NLNBBGLNEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2368800", Offset = "0x2367800", VA = "0x182368800")]
	public void JKLPICIFKBM(in TActionReceiver ACMNBNBMOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2368490", Offset = "0x2367490", VA = "0x182368490")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.KGNMHPKMJPC))]
	public Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> HLJJAHMIGFG(global::PANCFOBAJCC<LDBOMFHAOKE> OBCKDJNBOCN, global::PANCFOBAJCC<MHIAMPBLGNJ> EKAJLPLOKDN, TAction NCHNGIGODJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2368320", Offset = "0x2367320", VA = "0x182368320")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.MCHHEOPDIFJ))]
	private Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> GGICCJKCFOF(global::PANCFOBAJCC<LDBOMFHAOKE> OBCKDJNBOCN, global::PANCFOBAJCC<MHIAMPBLGNJ> EKAJLPLOKDN, TAction NCHNGIGODJK, Task BHKMIKBIDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2368810", Offset = "0x2367810", VA = "0x182368810")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.HMJKBOBPODI))]
	private Task KDGNJIFOCMO(TAction NCHNGIGODJK, PIPNKFGCECN HFHMHBAANAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2368620", Offset = "0x2367620", VA = "0x182368620")]
	private void JFFNHMFLIPG(TAction NCHNGIGODJK, bool HNJJMHJGMIO, bool OAMCKENKAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x23685F0", Offset = "0x23675F0", VA = "0x1823685F0", Slot = "4")]
	private Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> JCFNIHDMFJP(in TAction NCHNGIGODJK, bool NLNBBGLNEDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MPGNFMIGLHG<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::MAAGEDNFJGO<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] GBPNDHDKFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int JGEFANKGJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps EGEILAHLDAM;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A239C0", Offset = "0x2A229C0", VA = "0x182A239C0")]
	internal MPGNFMIGLHG(TPartialSnapshot[] MBFNPMLDLLC, int MELNEHHNDPC, TDeps CFKGJGPDLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A236B0", Offset = "0x2A226B0", VA = "0x182A236B0")]
	public global::GPLGLIHNGLH<TFullSnapshot> EJLAAHADDHH(TPartialSnapshot KGHGLNGPCIG)
	{
		return default(global::GPLGLIHNGLH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A23880", Offset = "0x2A22880", VA = "0x182A23880")]
	public bool POLMNBAJFIM(TPartialSnapshot KGHGLNGPCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A23330", Offset = "0x2A22330", VA = "0x182A23330")]
	public static global::MPGNFMIGLHG<TPartialSnapshot, TFullSnapshot, TDeps> AKMEFLONJDG(TDeps CFKGJGPDLPN)
	{
		return default(global::MPGNFMIGLHG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OMELGALIFBO : LNLCMCKKKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D7B0", Offset = "0x5E4C7B0", VA = "0x185E4D7B0", Slot = "5")]
	public override string HNGOLGDHNPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F480", Offset = "0x2E9E480", VA = "0x182E9F480")]
	public OMELGALIFBO()
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

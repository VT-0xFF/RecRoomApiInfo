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
		[Cpp2IlInjected.Address(RVA = "0x35E8EB0", Offset = "0x35E76B0", VA = "0x1835E8EB0")]
		private AGOAAFADIKH(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35E82F0", Offset = "0x35E6AF0", VA = "0x1835E82F0")]
		public static AGOAAFADIKH AKMEFLONJDG(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35E8C60", Offset = "0x35E7460", VA = "0x1835E8C60")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35E8CC0", Offset = "0x35E74C0", VA = "0x1835E8CC0", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x35E8DA0", Offset = "0x35E75A0", VA = "0x1835E8DA0", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x35E8E50", Offset = "0x35E7650", VA = "0x1835E8E50", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFC70", Offset = "0x2FBE470", VA = "0x182FBFC70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
		private HPICMMNBHDP(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x35E82F0", Offset = "0x35E6AF0", VA = "0x1835E82F0")]
		public static HPICMMNBHDP AKMEFLONJDG(TaskCompletionSource<global::OANJAMKPOEA<object, LNLCMCKKKGI>> IDNIBNDDCDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FC820", VA = "0x1808FE020")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AE40", Offset = "0x4E99640", VA = "0x184E9AE40", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AEA0", Offset = "0x4E996A0", VA = "0x184E9AEA0", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFC70", Offset = "0x2FBE470", VA = "0x182FBFC70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x40F5B40", Offset = "0x40F4340", VA = "0x1840F5B40")]
		private CDFHOLMAHLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFBB0", Offset = "0x2FBE3B0", VA = "0x182FBFBB0")]
		public static CDFHOLMAHLF AKMEFLONJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40F5A80", Offset = "0x40F4280", VA = "0x1840F5A80")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40F5AE0", Offset = "0x40F42E0", VA = "0x1840F5AE0", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFC70", Offset = "0x2FBE470", VA = "0x182FBFC70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		private EGIKOIOMNNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFBB0", Offset = "0x2FBE3B0", VA = "0x182FBFBB0")]
		public static EGIKOIOMNNG AKMEFLONJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E9760", Offset = "0x7E7F60", VA = "0x1807E9760")]
		public void BHALIIINNIP(in global::OANJAMKPOEA<object, LNLCMCKKKGI> BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		public void EEONDELGNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0", Slot = "6")]
		public global::OANJAMKPOEA<object, LNLCMCKKKGI> IBONNOLBCDF()
		{
			return default(global::OANJAMKPOEA<object, LNLCMCKKKGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		public void NKDIKFAJAFI(Exception OMAAJIFLBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2FBFC70", Offset = "0x2FBE470", VA = "0x182FBFC70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x37C9680", Offset = "0x37C7E80", VA = "0x1837C9680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C9930", Offset = "0x37C8130", VA = "0x1837C9930", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4622870", Offset = "0x4621070", VA = "0x184622870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4623070", Offset = "0x4621870", VA = "0x184623070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x33783C0", Offset = "0x3376BC0", VA = "0x1833783C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x32DA100", Offset = "0x32D8900", VA = "0x1832DA100")]
	protected NDGFNIGIHGO(TActionDeps DAFIEDPDEGD, TStaticNetSysDeps LNHKPHCIMPM, int BHBICMHPFJF, int FCJDKJGPFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x32D9670", Offset = "0x32D7E70", VA = "0x1832D9670")]
	public static global::NDGFNIGIHGO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> AKMEFLONJDG(TActionDeps DAFIEDPDEGD, TStaticNetSysDeps LNHKPHCIMPM, [Optional] int? BHBICMHPFJF, [Optional] int? FCJDKJGPFGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32D9DE0", Offset = "0x32D85E0", VA = "0x1832D9DE0")]
	public Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> KFKEDGNJONE(in TAction NCHNGIGODJK, bool NLNBBGLNEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32D9C90", Offset = "0x32D8490", VA = "0x1832D9C90")]
	public void JKLPICIFKBM(in TActionReceiver ACMNBNBMOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32D9920", Offset = "0x32D8120", VA = "0x1832D9920")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.KGNMHPKMJPC))]
	public Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> HLJJAHMIGFG(global::PANCFOBAJCC<LDBOMFHAOKE> OBCKDJNBOCN, global::PANCFOBAJCC<MHIAMPBLGNJ> EKAJLPLOKDN, TAction NCHNGIGODJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32D97B0", Offset = "0x32D7FB0", VA = "0x1832D97B0")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.MCHHEOPDIFJ))]
	private Task<global::OANJAMKPOEA<object, LNLCMCKKKGI>> GGICCJKCFOF(global::PANCFOBAJCC<LDBOMFHAOKE> OBCKDJNBOCN, global::PANCFOBAJCC<MHIAMPBLGNJ> EKAJLPLOKDN, TAction NCHNGIGODJK, Task BHKMIKBIDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32D9CA0", Offset = "0x32D84A0", VA = "0x1832D9CA0")]
	[AsyncStateMachine(typeof(global::NDGFNIGIHGO<, , , >.HMJKBOBPODI))]
	private Task KDGNJIFOCMO(TAction NCHNGIGODJK, PIPNKFGCECN HFHMHBAANAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x32D9AB0", Offset = "0x32D82B0", VA = "0x1832D9AB0")]
	private void JFFNHMFLIPG(TAction NCHNGIGODJK, bool HNJJMHJGMIO, bool OAMCKENKAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32D9A80", Offset = "0x32D8280", VA = "0x1832D9A80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x125D400", Offset = "0x125BC00", VA = "0x18125D400")]
	internal MPGNFMIGLHG(TPartialSnapshot[] MBFNPMLDLLC, int MELNEHHNDPC, TDeps CFKGJGPDLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x388B2C0", Offset = "0x3889AC0", VA = "0x18388B2C0")]
	public global::GPLGLIHNGLH<TFullSnapshot> EJLAAHADDHH(TPartialSnapshot KGHGLNGPCIG)
	{
		return default(global::GPLGLIHNGLH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x388B490", Offset = "0x3889C90", VA = "0x18388B490")]
	public bool POLMNBAJFIM(TPartialSnapshot KGHGLNGPCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x388AF40", Offset = "0x3889740", VA = "0x18388AF40")]
	public static global::MPGNFMIGLHG<TPartialSnapshot, TFullSnapshot, TDeps> AKMEFLONJDG(TDeps CFKGJGPDLPN)
	{
		return default(global::MPGNFMIGLHG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OMELGALIFBO : LNLCMCKKKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1ED64E0", Offset = "0x1ED4CE0", VA = "0x181ED64E0", Slot = "5")]
	public override string HNGOLGDHNPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C54100", Offset = "0x1C52900", VA = "0x181C54100")]
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

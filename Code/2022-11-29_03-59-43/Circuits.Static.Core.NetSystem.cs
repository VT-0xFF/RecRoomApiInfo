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
public interface DGDJOLLFMAJ<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IFGNCGJEMNE(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction GGNFHGABMDE(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction KJKCOGIOGFJ(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> FALCMNKNJLG(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEBLJCGHAKN(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AOHILJMBEHO(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NFHGHLCOHEC(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LBKICDEEGBH(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GBLNLNIMPMN(in TAction KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFPNJANAJPP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::IBGINLNKKBK<BAALOOHBPAF> ENMPOMDJDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KALEDNEOMMN();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJNEKOOMBGN(global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, in TAction KDJGJCHCIKK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EFPEKFLCOKL<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult EPLGEBJLJFE(in TAction KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] DLPOAKDJMAP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLOLDJBCHOA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LAGILPOBPLP(TPartialSnapshot DIJOHCIEBMD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot EEMHFECDDNI(TPartialSnapshot[] NMDLAEGHMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BAALOOHBPAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class AHNKBHOFMFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::EFPEKFLCOKL<TAction, Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>>> where TActionDeps : global::DGDJOLLFMAJ<TAction> where TStaticNetSysDeps : global::IFPNJANAJPP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface DHDINHLADJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GHBFLNKOHDD(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KKLHHDOFCBI();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::EMFHPGMFAOO<object, BMIGOOHOEBL> APFKOBPJDGN();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MNCKIACDIDJ(Exception FFCMPANFFDB);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class AKMGHIFHKCA : DHDINHLADJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> ABMECEBGNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> FGKIPBMNGCD;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2D30", Offset = "0x3BA1930", VA = "0x183BA2D30")]
		private AKMGHIFHKCA(TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> MNFMHMPJMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2DDF5C0", Offset = "0x2DDE1C0", VA = "0x182DDF5C0")]
		public static AKMGHIFHKCA KCNAIILPDFM(TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> MNFMHMPJMCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2B90", Offset = "0x3BA1790", VA = "0x183BA2B90")]
		public void GHBFLNKOHDD(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2BF0", Offset = "0x3BA17F0", VA = "0x183BA2BF0", Slot = "5")]
		public void KKLHHDOFCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2AE0", Offset = "0x3BA16E0", VA = "0x183BA2AE0", Slot = "6")]
		public global::EMFHPGMFAOO<object, BMIGOOHOEBL> APFKOBPJDGN()
		{
			return default(global::EMFHPGMFAOO<object, BMIGOOHOEBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2CD0", Offset = "0x3BA18D0", VA = "0x183BA2CD0", Slot = "7")]
		public void MNCKIACDIDJ(Exception FFCMPANFFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22781C0", Offset = "0x2276DC0", VA = "0x1822781C0", Slot = "4")]
		private void KMLGAOPBFHE(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class EHCNLEBCMFI : DHDINHLADJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> ABMECEBGNHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::EMFHPGMFAOO<object, BMIGOOHOEBL> LACFHBAOLCK;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17F46E0", Offset = "0x17F32E0", VA = "0x1817F46E0")]
		private EHCNLEBCMFI(TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> MNFMHMPJMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DDF5C0", Offset = "0x2DDE1C0", VA = "0x182DDF5C0")]
		public static EHCNLEBCMFI KCNAIILPDFM(TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> MNFMHMPJMCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA500", Offset = "0x2DF9100", VA = "0x182DFA500")]
		public void GHBFLNKOHDD(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA520", Offset = "0x2DF9120", VA = "0x182DFA520", Slot = "5")]
		public void KKLHHDOFCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "6")]
		public global::EMFHPGMFAOO<object, BMIGOOHOEBL> APFKOBPJDGN()
		{
			return default(global::EMFHPGMFAOO<object, BMIGOOHOEBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA580", Offset = "0x2DF9180", VA = "0x182DFA580", Slot = "7")]
		public void MNCKIACDIDJ(Exception FFCMPANFFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x22781C0", Offset = "0x2276DC0", VA = "0x1822781C0", Slot = "4")]
		private void KMLGAOPBFHE(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class OGDGMDPFMHF : DHDINHLADJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> FGKIPBMNGCD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x27F14E0", Offset = "0x27F00E0", VA = "0x1827F14E0")]
		private OGDGMDPFMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x27F1420", Offset = "0x27F0020", VA = "0x1827F1420")]
		public static OGDGMDPFMHF KCNAIILPDFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27F13C0", Offset = "0x27EFFC0", VA = "0x1827F13C0")]
		public void GHBFLNKOHDD(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void KKLHHDOFCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x27F1360", Offset = "0x27EFF60", VA = "0x1827F1360", Slot = "6")]
		public global::EMFHPGMFAOO<object, BMIGOOHOEBL> APFKOBPJDGN()
		{
			return default(global::EMFHPGMFAOO<object, BMIGOOHOEBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		public void MNCKIACDIDJ(Exception FFCMPANFFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22781C0", Offset = "0x2276DC0", VA = "0x1822781C0", Slot = "4")]
		private void KMLGAOPBFHE(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DBBNOCJECOA : DHDINHLADJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::EMFHPGMFAOO<object, BMIGOOHOEBL> LACFHBAOLCK;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		private DBBNOCJECOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27F1420", Offset = "0x27F0020", VA = "0x1827F1420")]
		public static DBBNOCJECOA KCNAIILPDFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DF2230", Offset = "0x1DF0E30", VA = "0x181DF2230")]
		public void GHBFLNKOHDD(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void KKLHHDOFCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10", Slot = "6")]
		public global::EMFHPGMFAOO<object, BMIGOOHOEBL> APFKOBPJDGN()
		{
			return default(global::EMFHPGMFAOO<object, BMIGOOHOEBL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		public void MNCKIACDIDJ(Exception FFCMPANFFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x22781C0", Offset = "0x2276DC0", VA = "0x1822781C0", Slot = "4")]
		private void KMLGAOPBFHE(in global::EMFHPGMFAOO<object, BMIGOOHOEBL> BMBFIGGJLDD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GIBEHMKALAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::IBGINLNKKBK<BAALOOHBPAF> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::IBGINLNKKBK<AHNKBHOFMFL> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x339CC70", Offset = "0x339B870", VA = "0x18339CC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x339CF20", Offset = "0x339BB20", VA = "0x18339CF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HAFMAIJECJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::IBGINLNKKBK<BAALOOHBPAF> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::IBGINLNKKBK<AHNKBHOFMFL> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DHDINHLADJN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B945D0", Offset = "0x3B931D0", VA = "0x183B945D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B94E20", Offset = "0x3B93A20", VA = "0x183B94E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BIFDFIMMHMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DHDINHLADJN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DHDINHLADJN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2881B20", Offset = "0x2880720", VA = "0x182881B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver EPBDPAPLDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps MKOHEBIEOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps KEHNJCPDKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int NAJCEOHIDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int OKPCLLEGBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::IBGINLNKKBK<AHNKBHOFMFL>, TaskCompletionSource<global::EMFHPGMFAOO<object, BMIGOOHOEBL>>> HIDMMDGIFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::FOPPJJKIBKA<AHNKBHOFMFL> NIDLPPFEIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int IAOBLMGJKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task CPKLONLEMNP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OEOHPCABMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71ACE0", Offset = "0x7198E0", VA = "0x18071ACE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71B490", Offset = "0x71A090", VA = "0x18071B490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B9DB00", Offset = "0x3B9C700", VA = "0x183B9DB00")]
	protected AKCAFHBCPKO(TActionDeps IFKAMKEANKJ, TStaticNetSysDeps OEJKOECMGEE, int AKAMMNLMNAB, int AEHOCNEAIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D200", Offset = "0x3B9BE00", VA = "0x183B9D200")]
	public static global::AKCAFHBCPKO<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> KCNAIILPDFM(TActionDeps IFKAMKEANKJ, TStaticNetSysDeps OEJKOECMGEE, [Optional] int? AKAMMNLMNAB, [Optional] int? AEHOCNEAIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D480", Offset = "0x3B9C080", VA = "0x183B9D480")]
	public Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> KJNEKOOMBGN(in TAction KDJGJCHCIKK, bool KICHIDDLKHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D090", Offset = "0x3B9BC90", VA = "0x183B9D090")]
	public void CKFFNBPFDNB(in TActionReceiver ELHGAKMGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D0A0", Offset = "0x3B9BCA0", VA = "0x183B9D0A0")]
	[AsyncStateMachine(typeof(global::AKCAFHBCPKO<, , , >.GIBEHMKALAC))]
	public Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> EPLGEBJLJFE(global::IBGINLNKKBK<BAALOOHBPAF> KOKPOEFBIML, global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, TAction KDJGJCHCIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D990", Offset = "0x3B9C590", VA = "0x183B9D990")]
	[AsyncStateMachine(typeof(global::AKCAFHBCPKO<, , , >.HAFMAIJECJM))]
	private Task<global::EMFHPGMFAOO<object, BMIGOOHOEBL>> MBMDGDMKNIJ(global::IBGINLNKKBK<BAALOOHBPAF> KOKPOEFBIML, global::IBGINLNKKBK<AHNKBHOFMFL> LJHJJDLEMKE, TAction KDJGJCHCIKK, Task LFNDCOBHJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D340", Offset = "0x3B9BF40", VA = "0x183B9D340")]
	[AsyncStateMachine(typeof(global::AKCAFHBCPKO<, , , >.BIFDFIMMHMN))]
	private Task KHECJIGICCE(TAction KDJGJCHCIKK, DHDINHLADJN IOIOALGJNGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B9D790", Offset = "0x3B9C390", VA = "0x183B9D790")]
	private void LKFGCOIPIFO(TAction KDJGJCHCIKK, bool CBPPNLMBAGG, bool DNGDKCFONKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ELMNNGKJALM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::BLOLDJBCHOA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] OECMIHNENGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int AIPFHOOALLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps DPDFKNGGDCM;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x48E4340", Offset = "0x48E2F40", VA = "0x1848E4340")]
	internal ELMNNGKJALM(TPartialSnapshot[] BDLHABLFMCM, int LFCKMELNBPP, TDeps HKPDNJBMEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48E3CF0", Offset = "0x48E28F0", VA = "0x1848E3CF0")]
	public global::NIBGAACNLKK<TFullSnapshot> EPHIPPKNOJC(TPartialSnapshot DIJOHCIEBMD)
	{
		return default(global::NIBGAACNLKK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48E42F0", Offset = "0x48E2EF0", VA = "0x1848E42F0")]
	public bool MKGKPCAEIAE(TPartialSnapshot DIJOHCIEBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x48E41E0", Offset = "0x48E2DE0", VA = "0x1848E41E0")]
	public static global::ELMNNGKJALM<TPartialSnapshot, TFullSnapshot, TDeps> KCNAIILPDFM(TDeps HKPDNJBMEMK)
	{
		return default(global::ELMNNGKJALM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NOPOOGLLCBD : BMIGOOHOEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xF91F30", Offset = "0xF90B30", VA = "0x180F91F30", Slot = "5")]
	public override string GFOMHDPEHDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xF91F60", Offset = "0xF90B60", VA = "0x180F91F60")]
	public NOPOOGLLCBD()
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

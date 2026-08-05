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
public struct MHCFONGEKFO<TPartialAction, TFullAction, TDeps> where TDeps : NPKGIMHOMIO.AOIFAHAKPLN<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] ADDPLCAEBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int FOHFDHEPLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KAIABCGDPPN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D54D90", Offset = "0x3D54190", VA = "0x183D54D90")]
	internal MHCFONGEKFO(TPartialAction[] AOCJKDHPHII, int GIHKHECGJBP, TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D54CE0", Offset = "0x3D540E0", VA = "0x183D54CE0")]
	public static MHCFONGEKFO<TPartialAction, TFullAction, TDeps> JKJFENIAMEL(TDeps NFFMMJBNJIB)
	{
		return default(MHCFONGEKFO<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NPKGIMHOMIO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AOIFAHAKPLN<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LEBDJEOHJEM([In] TPartialAction DCPHEKAKJLP);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JJIDHPKBEDI(TPartialAction[] JKCGKOKJMJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2770970", Offset = "0x276FD70", VA = "0x182770970")]
	public static IKGCKHLMHFG<TFullAction> POIKAEFEICL<TFullAction, TPartialAction, TDeps>(this MHCFONGEKFO<TPartialAction, TFullAction, TDeps> NHHBAHIFHJK, TPartialAction DCPHEKAKJLP) where TDeps : AOIFAHAKPLN<TPartialAction, TFullAction>
	{
		return default(IKGCKHLMHFG<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : EFNNPLBKPNO.BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] EGMCEHOEOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int INNDEJANOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KAIABCGDPPN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D54D40", Offset = "0x3D54140", VA = "0x183D54D40")]
	internal BOENFDIPHIP(TPartialSnapshot[] GCCFNJKCLMM, int GGJLJMLOOLO, TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D54C70", Offset = "0x3D54070", VA = "0x183D54C70")]
	public static BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> JKJFENIAMEL(TDeps NFFMMJBNJIB)
	{
		return default(BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EFNNPLBKPNO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GMAGHOJLIEF([In] TPartialSnapshot JHPHLKJCBPC);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot BDKDDDIGMIL(TPartialSnapshot[] OHCCAHIAAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x25091B0", Offset = "0x25085B0", VA = "0x1825091B0")]
	public static IKGCKHLMHFG<TFullSnapshot> POIKAEFEICL<TFullSnapshot, TPartialSnapshot, TDeps>(this BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> NHHBAHIFHJK, TPartialSnapshot JHPHLKJCBPC) where TDeps : BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(IKGCKHLMHFG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2508F50", Offset = "0x2508350", VA = "0x182508F50")]
	public static bool JIPIILMIIIH<TPartialSnapshot, TFullSnapshot, TDeps>(this BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> NHHBAHIFHJK, TPartialSnapshot JHPHLKJCBPC) where TDeps : BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PNDCBOIKHJJ : BDPIDPDHGEO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D616E0", Offset = "0x1D60AE0", VA = "0x181D616E0", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D61710", Offset = "0x1D60B10", VA = "0x181D61710")]
	public PNDCBOIKHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FPMPGDCBBDF.FDCLCOJALAB<TAction, TNetSys> where TReceiverDeps : FPMPGDCBBDF.MOBDFAAEHLA<TMActor, TAction, TReceiver> where TRootDeps : FPMPGDCBBDF.NACJJFJBGGB<TMRequest, TMActor, TAction, TRoot> where TDeps : FPMPGDCBBDF.FGJHGOGDJNC<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface BJCNKLODJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PALIEJHBKHE();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HALKGLMFEML(Exception MEIELCKPCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class KIAAMPGGLOK : BJCNKLODJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> CJBAMHGFALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<KKHLNMGODKL<object, PKFDKDKJAIE>> EFIHADIBOHD;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A71B50", Offset = "0x3A70F50", VA = "0x183A71B50")]
		private KIAAMPGGLOK(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x378ADD0", Offset = "0x378A1D0", VA = "0x18378ADD0")]
		public static KIAAMPGGLOK JKJFENIAMEL(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3A71690", Offset = "0x3A70A90", VA = "0x183A71690")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3A718F0", Offset = "0x3A70CF0", VA = "0x183A718F0", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A71840", Offset = "0x3A70C40", VA = "0x183A71840", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3A71530", Offset = "0x3A70930", VA = "0x183A71530", Slot = "7")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x36A0870", Offset = "0x369FC70", VA = "0x1836A0870", Slot = "4")]
		private void KFCINLDJIMK([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class PAKCMOGNGNK : BJCNKLODJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> CJBAMHGFALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KKHLNMGODKL<object, MPIKAEBOCFI> EOIKPMAPCBO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
		private PAKCMOGNGNK(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x378ADD0", Offset = "0x378A1D0", VA = "0x18378ADD0")]
		public static PAKCMOGNGNK JKJFENIAMEL(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x379EA00", Offset = "0x379DE00", VA = "0x18379EA00")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3F82FA0", Offset = "0x3F823A0", VA = "0x183F82FA0", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F82EE0", Offset = "0x3F822E0", VA = "0x183F82EE0", Slot = "7")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x36A0870", Offset = "0x369FC70", VA = "0x1836A0870", Slot = "4")]
		private void KFCINLDJIMK([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class PFHMPKMHPJO : BJCNKLODJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<KKHLNMGODKL<object, MPIKAEBOCFI>> EFIHADIBOHD;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3790", Offset = "0x3FA2B90", VA = "0x183FA3790")]
		private PFHMPKMHPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x36A07B0", Offset = "0x369FBB0", VA = "0x1836A07B0")]
		public static PFHMPKMHPJO JKJFENIAMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3570", Offset = "0x3FA2970", VA = "0x183FA3570")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3FA36A0", Offset = "0x3FA2AA0", VA = "0x183FA36A0", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3400", Offset = "0x3FA2800", VA = "0x183FA3400", Slot = "7")]
		[AOICGJECGOP("This may be terminal and should probably do more than discarding the exception.")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x36A0870", Offset = "0x369FC70", VA = "0x1836A0870", Slot = "4")]
		private void KFCINLDJIMK([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GPAAFNDLPDP : BJCNKLODJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KKHLNMGODKL<object, MPIKAEBOCFI> EOIKPMAPCBO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		private GPAAFNDLPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x36A07B0", Offset = "0x369FBB0", VA = "0x1836A07B0")]
		public static GPAAFNDLPDP JKJFENIAMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x144DBA0", Offset = "0x144CFA0", VA = "0x18144DBA0")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36A0710", Offset = "0x369FB10", VA = "0x1836A0710", Slot = "7")]
		[AOICGJECGOP("This may be terminal and should probably do more than discarding the exception.")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x36A0870", Offset = "0x369FC70", VA = "0x1836A0870", Slot = "4")]
		private void KFCINLDJIMK([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NGEADFIPJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JLGMECJOLDI<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCEB0", Offset = "0x3DFC2B0", VA = "0x183DFCEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD490", Offset = "0x3DFC890", VA = "0x183DFD490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LIDCLPDDJGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JLGMECJOLDI<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B5BF60", Offset = "0x3B5B360", VA = "0x183B5BF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C3A0", Offset = "0x3B5B7A0", VA = "0x183B5C3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ICHFAKPKHEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JLGMECJOLDI<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JLGMECJOLDI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3794960", Offset = "0x3793D60", VA = "0x183794960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3795080", Offset = "0x3794480", VA = "0x183795080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ONHKAHIOJBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<KKHLNMGODKL<object, MPIKAEBOCFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JLGMECJOLDI<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JLGMECJOLDI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private BJCNKLODJAC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDEB0", Offset = "0x3EFD2B0", VA = "0x183EFDEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF7A0", Offset = "0x3EFEBA0", VA = "0x183EFF7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EJGOKBNDDGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::CCJHKBNKADE<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BJCNKLODJAC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BJCNKLODJAC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<KKHLNMGODKL<object, MPIKAEBOCFI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x31FFA40", Offset = "0x31FEE40", VA = "0x1831FFA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3203700", Offset = "0x3202B00", VA = "0x183203700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KAIABCGDPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<JLGMECJOLDI<TMRequest>, TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>>> NNLILJCFNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GCEFEFNCJOA<TMRequest> GFPFMCIHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int IJOFILPPMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task JELNJCAALMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps IAIKLDNDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4868530", Offset = "0x4867930", VA = "0x184868530")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NHPAOEBEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4868EE0", Offset = "0x48682E0", VA = "0x184868EE0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HBNKMLFHNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4868F90", Offset = "0x4868390", VA = "0x184868F90")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DJIINHDMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD1EF00", Offset = "0xD1E300", VA = "0x180D1EF00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11038D0", Offset = "0x1102CD0", VA = "0x1811038D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PDBHIODPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD21870", Offset = "0xD20C70", VA = "0x180D21870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C39F70", Offset = "0x1C39370", VA = "0x181C39F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FELPBCCJIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7A7080", Offset = "0x7A6480", VA = "0x1807A7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x48696F0", Offset = "0x4868AF0", VA = "0x1848696F0")]
	public CCJHKBNKADE(TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4867FE0", Offset = "0x48673E0", VA = "0x184867FE0")]
	public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> BEAOIOPPJBO(TRoot LMAHFBOHCNI, TNetSys MBDMOHOEKJI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction MCLCEMNNOFC, bool HPOBNPKLCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4867D20", Offset = "0x4867120", VA = "0x184867D20")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.NGEADFIPJDB))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> BEAOIOPPJBO(TRoot LMAHFBOHCNI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x48678A0", Offset = "0x4866CA0", VA = "0x1848678A0")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.LIDCLPDDJGP))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AJJJGELCNJJ(TRoot LMAHFBOHCNI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction[] BDOEJBMENLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4868580", Offset = "0x4867980", VA = "0x184868580")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.ICHFAKPKHEL))]
	public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> DOAIANMJEDP(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, JLGMECJOLDI<TMActor> CLELCJOIPLD, JLGMECJOLDI<TMRequest> GHGHPMALHMN, TAction MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4869290", Offset = "0x4868690", VA = "0x184869290")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.ONHKAHIOJBH))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> LHGGBMPGAOI(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, JLGMECJOLDI<TMActor> CLELCJOIPLD, JLGMECJOLDI<TMRequest> GHGHPMALHMN, TAction MCLCEMNNOFC, Task LFEOFLJBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4868FE0", Offset = "0x48683E0", VA = "0x184868FE0")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.EJGOKBNDDGM))]
	private Task KJKEHOJOLHB(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, TAction MCLCEMNNOFC, BJCNKLODJAC NMNOBDLLAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4868870", Offset = "0x4867C70", VA = "0x184868870")]
	private void GCBMLIBENMB(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction MCLCEMNNOFC, bool NNAGHHGFIII, bool PGBNGCPKEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FPMPGDCBBDF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FDCLCOJALAB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EDGFDJAOCDF(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction KLEBHHEFNHE(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HABHPEHAJMD(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> JHDGFOGGJND(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MGBFOKMFIPH(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC, int FLNOFAHKHFK);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CCCOKCGNEGO(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KFGNEKCHDAF(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NDGCCALPIHJ(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GPAAHBIPCMK(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OHGKELAKELP(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool JEMBIMNAJFM(TNetSys JMAMNEHEBBI, TAction MCLCEMNNOFC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FGJHGOGDJNC<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps IAIKLDNDFPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HBNKMLFHNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps NHPAOEBEJBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MOBDFAAEHLA<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JLGMECJOLDI<TMActor> JBPEFEKEIIC(TReceiver KEHMNIODKBI);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KKHLNMGODKL<object, MPIKAEBOCFI>> DOAIANMJEDP(TReceiver KEHMNIODKBI, TAction MCLCEMNNOFC);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LBBCAJIKAOF(TReceiver KEHMNIODKBI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NACJJFJBGGB<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PKAHIOOILJG(TRoot LMAHFBOHCNI);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FCIPBHBKEHE(TRoot LMAHFBOHCNI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int IJGMBDLCHKI(TRoot LMAHFBOHCNI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int HDFJOOFMMGG(TRoot LMAHFBOHCNI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JCJHJBLLJFM(TRoot LMAHFBOHCNI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task BEAOIOPPJBO(TRoot LMAHFBOHCNI, JLGMECJOLDI<TMActor> CLELCJOIPLD, JLGMECJOLDI<TMRequest> GHGHPMALHMN, TAction MCLCEMNNOFC, bool JAPIBDEKPPG = true);
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

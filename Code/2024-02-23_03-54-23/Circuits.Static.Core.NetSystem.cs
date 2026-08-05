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
	[Cpp2IlInjected.Address(RVA = "0x3D9AF30", Offset = "0x3D99930", VA = "0x183D9AF30")]
	internal MHCFONGEKFO(TPartialAction[] AOCJKDHPHII, int GIHKHECGJBP, TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D9AE80", Offset = "0x3D99880", VA = "0x183D9AE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x27C6A20", Offset = "0x27C5420", VA = "0x1827C6A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D9AEE0", Offset = "0x3D998E0", VA = "0x183D9AEE0")]
	internal BOENFDIPHIP(TPartialSnapshot[] GCCFNJKCLMM, int GGJLJMLOOLO, TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D9AE10", Offset = "0x3D99810", VA = "0x183D9AE10")]
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
	[Cpp2IlInjected.Address(RVA = "0x255B310", Offset = "0x2559D10", VA = "0x18255B310")]
	public static IKGCKHLMHFG<TFullSnapshot> POIKAEFEICL<TFullSnapshot, TPartialSnapshot, TDeps>(this BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> NHHBAHIFHJK, TPartialSnapshot JHPHLKJCBPC) where TDeps : BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(IKGCKHLMHFG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x255B0B0", Offset = "0x2559AB0", VA = "0x18255B0B0")]
	public static bool JIPIILMIIIH<TPartialSnapshot, TFullSnapshot, TDeps>(this BOENFDIPHIP<TPartialSnapshot, TFullSnapshot, TDeps> NHHBAHIFHJK, TPartialSnapshot JHPHLKJCBPC) where TDeps : BHFMHOLMGDJ<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class PNDCBOIKHJJ : BDPIDPDHGEO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CE20", Offset = "0x1D7B820", VA = "0x181D7CE20", Slot = "7")]
	public override string GMMJBFEOGBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D7CE50", Offset = "0x1D7B850", VA = "0x181D7CE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A9CFC0", Offset = "0x3A9B9C0", VA = "0x183A9CFC0")]
		private KIAAMPGGLOK(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37C4220", Offset = "0x37C2C20", VA = "0x1837C4220")]
		public static KIAAMPGGLOK JKJFENIAMEL(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CB00", Offset = "0x3A9B500", VA = "0x183A9CB00")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CD60", Offset = "0x3A9B760", VA = "0x183A9CD60", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CCB0", Offset = "0x3A9B6B0", VA = "0x183A9CCB0", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3A9C9A0", Offset = "0x3A9B3A0", VA = "0x183A9C9A0", Slot = "7")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7C0", Offset = "0x36BD1C0", VA = "0x1836BE7C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
		private PAKCMOGNGNK(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37C4220", Offset = "0x37C2C20", VA = "0x1837C4220")]
		public static PAKCMOGNGNK JKJFENIAMEL(TaskCompletionSource<KKHLNMGODKL<object, MPIKAEBOCFI>> NMFGNBBCHDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37D7CF0", Offset = "0x37D66F0", VA = "0x1837D7CF0")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9F70", Offset = "0x3FB8970", VA = "0x183FB9F70", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA29FA0", Offset = "0xA289A0", VA = "0x180A29FA0", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9EB0", Offset = "0x3FB88B0", VA = "0x183FB9EB0", Slot = "7")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7C0", Offset = "0x36BD1C0", VA = "0x1836BE7C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FDA760", Offset = "0x3FD9160", VA = "0x183FDA760")]
		private PFHMPKMHPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x36BE700", Offset = "0x36BD100", VA = "0x1836BE700")]
		public static PFHMPKMHPJO JKJFENIAMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA540", Offset = "0x3FD8F40", VA = "0x183FDA540")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA670", Offset = "0x3FD9070", VA = "0x183FDA670", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3FDA3D0", Offset = "0x3FD8DD0", VA = "0x183FDA3D0", Slot = "7")]
		[AOICGJECGOP("This may be terminal and should probably do more than discarding the exception.")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7C0", Offset = "0x36BD1C0", VA = "0x1836BE7C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		private GPAAFNDLPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x36BE700", Offset = "0x36BD100", VA = "0x1836BE700")]
		public static GPAAFNDLPDP JKJFENIAMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1462A80", Offset = "0x1461480", VA = "0x181462A80")]
		public void IJKOIOGIBDI([In] KKHLNMGODKL<object, MPIKAEBOCFI> MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public void PALIEJHBKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0", Slot = "6")]
		public KKHLNMGODKL<object, MPIKAEBOCFI> OOMEDGNPLIE()
		{
			return default(KKHLNMGODKL<object, MPIKAEBOCFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36BE660", Offset = "0x36BD060", VA = "0x1836BE660", Slot = "7")]
		[AOICGJECGOP("This may be terminal and should probably do more than discarding the exception.")]
		public void HALKGLMFEML(Exception MEIELCKPCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7C0", Offset = "0x36BD1C0", VA = "0x1836BE7C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E333B0", Offset = "0x3E31DB0", VA = "0x183E333B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E33990", Offset = "0x3E32390", VA = "0x183E33990", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B8BC10", Offset = "0x3B8A610", VA = "0x183B8BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C050", Offset = "0x3B8AA50", VA = "0x183B8C050", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x37CDD20", Offset = "0x37CC720", VA = "0x1837CDD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37CE440", Offset = "0x37CCE40", VA = "0x1837CE440", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F32C80", Offset = "0x3F31680", VA = "0x183F32C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3F34570", Offset = "0x3F32F70", VA = "0x183F34570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x322F2A0", Offset = "0x322DCA0", VA = "0x18322F2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3232F60", Offset = "0x3231960", VA = "0x183232F60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x485A860", Offset = "0x4859260", VA = "0x18485A860")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NHPAOEBEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x485B210", Offset = "0x4859C10", VA = "0x18485B210")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HBNKMLFHNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x485B2C0", Offset = "0x4859CC0", VA = "0x18485B2C0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DJIINHDMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD27B40", Offset = "0xD26540", VA = "0x180D27B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1115040", Offset = "0x1113A40", VA = "0x181115040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PDBHIODPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD2A4B0", Offset = "0xD28EB0", VA = "0x180D2A4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C53C40", Offset = "0x1C52640", VA = "0x181C53C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FELPBCCJIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B1080", Offset = "0x7AFA80", VA = "0x1807B1080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x485BA20", Offset = "0x485A420", VA = "0x18485BA20")]
	public CCJHKBNKADE(TDeps NFFMMJBNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x485A310", Offset = "0x4858D10", VA = "0x18485A310")]
	public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> BEAOIOPPJBO(TRoot LMAHFBOHCNI, TNetSys MBDMOHOEKJI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction MCLCEMNNOFC, bool HPOBNPKLCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x485A050", Offset = "0x4858A50", VA = "0x18485A050")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.NGEADFIPJDB))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> BEAOIOPPJBO(TRoot LMAHFBOHCNI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4859BD0", Offset = "0x48585D0", VA = "0x184859BD0")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.LIDCLPDDJGP))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> AJJJGELCNJJ(TRoot LMAHFBOHCNI, JLGMECJOLDI<TMActor> CLELCJOIPLD, TAction[] BDOEJBMENLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x485A8B0", Offset = "0x48592B0", VA = "0x18485A8B0")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.ICHFAKPKHEL))]
	public Task<KKHLNMGODKL<object, MPIKAEBOCFI>> DOAIANMJEDP(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, JLGMECJOLDI<TMActor> CLELCJOIPLD, JLGMECJOLDI<TMRequest> GHGHPMALHMN, TAction MCLCEMNNOFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x485B5C0", Offset = "0x4859FC0", VA = "0x18485B5C0")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.ONHKAHIOJBH))]
	private Task<KKHLNMGODKL<object, MPIKAEBOCFI>> LHGGBMPGAOI(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, JLGMECJOLDI<TMActor> CLELCJOIPLD, JLGMECJOLDI<TMRequest> GHGHPMALHMN, TAction MCLCEMNNOFC, Task LFEOFLJBOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x485B310", Offset = "0x4859D10", VA = "0x18485B310")]
	[AsyncStateMachine(typeof(global::CCJHKBNKADE<, , , , , , , , , >.EJGOKBNDDGM))]
	private Task KJKEHOJOLHB(TRoot LMAHFBOHCNI, TNetSys MKLMOODDIMI, TReceiver KEHMNIODKBI, TAction MCLCEMNNOFC, BJCNKLODJAC NMNOBDLLAJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x485ABA0", Offset = "0x48595A0", VA = "0x18485ABA0")]
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

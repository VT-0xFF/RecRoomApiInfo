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
public struct HNJJLFJMJMI<TPartialAction, TFullAction, TDeps> where TDeps : NIGDKLBMHAH.JJECJNEHMNO<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] BEKMBMJDAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int KKHOILNGGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps IDCMPNFONAH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3988EA0", Offset = "0x39880A0", VA = "0x183988EA0")]
	internal HNJJLFJMJMI(TPartialAction[] EGAKDAJOGCC, int OPIMLHJGEGB, TDeps OAENIJAKBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3988DF0", Offset = "0x3987FF0", VA = "0x183988DF0")]
	public static HNJJLFJMJMI<TPartialAction, TFullAction, TDeps> DHBNKMCPKNO(TDeps OAENIJAKBHE)
	{
		return default(HNJJLFJMJMI<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIGDKLBMHAH
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JJECJNEHMNO<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KCLEIDIEAFC([In] TPartialAction DDDCAKNMCLD);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JEHBFCLIKLL(TPartialAction[] FJPJEJAECKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28AEE10", Offset = "0x28AE010", VA = "0x1828AEE10")]
	public static DIGJANEAKHC<TFullAction> PFINIDEHIHN<TFullAction, TPartialAction, TDeps>(this HNJJLFJMJMI<TPartialAction, TFullAction, TDeps> AOFIGDLFNLH, TPartialAction DDDCAKNMCLD) where TDeps : JJECJNEHMNO<TPartialAction, TFullAction>
	{
		return default(DIGJANEAKHC<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OGHBCKLAJFC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HNPGLGMOFCE.KHEHBCHHPAI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] DCMLLBEEODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int DKBGCFMMIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps IDCMPNFONAH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3988E60", Offset = "0x3988060", VA = "0x183988E60")]
	internal OGHBCKLAJFC(TPartialSnapshot[] IAGCDCPHCBB, int LMCECBGBBOB, TDeps OAENIJAKBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3988D90", Offset = "0x3987F90", VA = "0x183988D90")]
	public static OGHBCKLAJFC<TPartialSnapshot, TFullSnapshot, TDeps> DHBNKMCPKNO(TDeps OAENIJAKBHE)
	{
		return default(OGHBCKLAJFC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HNPGLGMOFCE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KHEHBCHHPAI<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GHLLLNFBPHN([In] TPartialSnapshot ALILPODFOKH);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot MOGDHAFMNKG(TPartialSnapshot[] NPHOLDKMBHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28AECB0", Offset = "0x28ADEB0", VA = "0x1828AECB0")]
	public static DIGJANEAKHC<TFullSnapshot> PFINIDEHIHN<TFullSnapshot, TPartialSnapshot, TDeps>(this OGHBCKLAJFC<TPartialSnapshot, TFullSnapshot, TDeps> AOFIGDLFNLH, TPartialSnapshot ALILPODFOKH) where TDeps : KHEHBCHHPAI<TPartialSnapshot, TFullSnapshot>
	{
		return default(DIGJANEAKHC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28AEB60", Offset = "0x28ADD60", VA = "0x1828AEB60")]
	public static bool BAMEINKBOLA<TPartialSnapshot, TFullSnapshot, TDeps>(this OGHBCKLAJFC<TPartialSnapshot, TFullSnapshot, TDeps> AOFIGDLFNLH, TPartialSnapshot ALILPODFOKH) where TDeps : KHEHBCHHPAI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class AONNFDFBMIP : HINLGFGENCJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD70", Offset = "0x1E1BF70", VA = "0x181E1CD70", Slot = "7")]
	public override string OFOGPFNLIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CDA0", Offset = "0x1E1BFA0", VA = "0x181E1CDA0")]
	public AONNFDFBMIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FFJBPGDBKED.PEEMLKGMIGO<TAction, TNetSys> where TReceiverDeps : FFJBPGDBKED.MNAOPLHOPPL<TAction, TReceiver> where TRootDeps : FFJBPGDBKED.DDJCFJNKJKO<TMRequest, TAction, TRoot> where TDeps : FFJBPGDBKED.ILCBDCEGLJI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface NMMDPNGJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DMJGOBOGNBK([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FEOPKOHFCJF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OAAHAKNOJDO<object, AHFOEFCGOPM> CDHPLBMMAJH();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JACPLLEOGOF(Exception ABPIAOIFKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class MGPLFOFCPBK : NMMDPNGJJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> NKEFOEIHDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<OAAHAKNOJDO<object, GJOBCCNBLIC>> CABHHBIIHOE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F19C50", Offset = "0x3F18E50", VA = "0x183F19C50")]
		private MGPLFOFCPBK(TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> IEGPAPMANBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3778AA0", Offset = "0x3777CA0", VA = "0x183778AA0")]
		public static MGPLFOFCPBK DHBNKMCPKNO(TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> IEGPAPMANBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F19830", Offset = "0x3F18A30", VA = "0x183F19830")]
		public void DMJGOBOGNBK([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F19930", Offset = "0x3F18B30", VA = "0x183F19930", Slot = "5")]
		public void FEOPKOHFCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F19680", Offset = "0x3F18880", VA = "0x183F19680", Slot = "6")]
		public OAAHAKNOJDO<object, AHFOEFCGOPM> CDHPLBMMAJH()
		{
			return default(OAAHAKNOJDO<object, AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F19B50", Offset = "0x3F18D50", VA = "0x183F19B50", Slot = "7")]
		public void JACPLLEOGOF(Exception ABPIAOIFKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3778D00", Offset = "0x3777F00", VA = "0x183778D00", Slot = "4")]
		private void JKMNGBKOGFO([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class FGANNOJCCIC : NMMDPNGJJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> NKEFOEIHDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OAAHAKNOJDO<object, AHFOEFCGOPM> DJLNBIADEFF;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
		private FGANNOJCCIC(TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> IEGPAPMANBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3778AA0", Offset = "0x3777CA0", VA = "0x183778AA0")]
		public static FGANNOJCCIC DHBNKMCPKNO(TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> IEGPAPMANBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3778B60", Offset = "0x3777D60", VA = "0x183778B60")]
		public void DMJGOBOGNBK([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3778B80", Offset = "0x3777D80", VA = "0x183778B80", Slot = "5")]
		public void FEOPKOHFCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0", Slot = "6")]
		public OAAHAKNOJDO<object, AHFOEFCGOPM> CDHPLBMMAJH()
		{
			return default(OAAHAKNOJDO<object, AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3778C40", Offset = "0x3777E40", VA = "0x183778C40", Slot = "7")]
		public void JACPLLEOGOF(Exception ABPIAOIFKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3778D00", Offset = "0x3777F00", VA = "0x183778D00", Slot = "4")]
		private void JKMNGBKOGFO([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class MGICPPHGOON : NMMDPNGJJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<OAAHAKNOJDO<object, AHFOEFCGOPM>> CABHHBIIHOE;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F151C0", Offset = "0x3F143C0", VA = "0x183F151C0")]
		private MGICPPHGOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F14E40", Offset = "0x3F14040", VA = "0x183F14E40")]
		public static MGICPPHGOON DHBNKMCPKNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3F14EF0", Offset = "0x3F140F0", VA = "0x183F14EF0")]
		public void DMJGOBOGNBK([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void FEOPKOHFCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F14D80", Offset = "0x3F13F80", VA = "0x183F14D80", Slot = "6")]
		public OAAHAKNOJDO<object, AHFOEFCGOPM> CDHPLBMMAJH()
		{
			return default(OAAHAKNOJDO<object, AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3F15090", Offset = "0x3F14290", VA = "0x183F15090", Slot = "7")]
		[OGJCPCCKFOF("This may be terminal and should probably do more than discarding the exception.")]
		public void JACPLLEOGOF(Exception ABPIAOIFKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3778D00", Offset = "0x3777F00", VA = "0x183778D00", Slot = "4")]
		private void JKMNGBKOGFO([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class CJPCAIKPJCM : NMMDPNGJJMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OAAHAKNOJDO<object, AHFOEFCGOPM> DJLNBIADEFF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		private CJPCAIKPJCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3F14E40", Offset = "0x3F14040", VA = "0x183F14E40")]
		public static CJPCAIKPJCM DHBNKMCPKNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1543AB0", Offset = "0x1542CB0", VA = "0x181543AB0")]
		public void DMJGOBOGNBK([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void FEOPKOHFCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0", Slot = "6")]
		public OAAHAKNOJDO<object, AHFOEFCGOPM> CDHPLBMMAJH()
		{
			return default(OAAHAKNOJDO<object, AHFOEFCGOPM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A23970", Offset = "0x4A22B70", VA = "0x184A23970", Slot = "7")]
		[OGJCPCCKFOF("This may be terminal and should probably do more than discarding the exception.")]
		public void JACPLLEOGOF(Exception ABPIAOIFKLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3778D00", Offset = "0x3777F00", VA = "0x183778D00", Slot = "4")]
		private void JKMNGBKOGFO([In] OAAHAKNOJDO<object, AHFOEFCGOPM> IFJGEIAONPI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MJEINLDJBPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KHCIOCBLCGC<PDFIKAKPMHI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F29800", Offset = "0x3F28A00", VA = "0x183F29800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F29CB0", Offset = "0x3F28EB0", VA = "0x183F29CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GEBGEFMLOKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KHCIOCBLCGC<PDFIKAKPMHI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x385A740", Offset = "0x3859940", VA = "0x18385A740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x385AB70", Offset = "0x3859D70", VA = "0x18385AB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DFMNJIKGGPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public KHCIOCBLCGC<PDFIKAKPMHI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public KHCIOCBLCGC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5090130", Offset = "0x508F330", VA = "0x185090130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5090480", Offset = "0x508F680", VA = "0x185090480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NNICALNAPCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KHCIOCBLCGC<PDFIKAKPMHI> senderId;

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
		public KHCIOCBLCGC<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private NMMDPNGJJMA <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x400B6E0", Offset = "0x400A8E0", VA = "0x18400B6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x400CF00", Offset = "0x400C100", VA = "0x18400CF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NALHAJCBNEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FEMCAAGCAOM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public NMMDPNGJJMA completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NMMDPNGJJMA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<OAAHAKNOJDO<object, AHFOEFCGOPM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3FB03C0", Offset = "0x3FAF5C0", VA = "0x183FB03C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3EB0", Offset = "0x3FB30B0", VA = "0x183FB3EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps IDCMPNFONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<KHCIOCBLCGC<TMRequest>, TaskCompletionSource<OAAHAKNOJDO<object, AHFOEFCGOPM>>> HKGFHPMCAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ENIDGGDBPIM<TMRequest> DIIFPBJMHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int KAEPAFIDIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task LNOJFALPBNI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps DBEPDOFFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3774190", Offset = "0x3773390", VA = "0x183774190")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps IDBHGHCHONH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37737B0", Offset = "0x37729B0", VA = "0x1837737B0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HNKNMHMKMJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3773E50", Offset = "0x3773050", VA = "0x183773E50")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MMODPDFAPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDEE220", Offset = "0xDED420", VA = "0x180DEE220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11D4A50", Offset = "0x11D3C50", VA = "0x1811D4A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OOODGEONOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDDED20", Offset = "0xDDDF20", VA = "0x180DDED20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7E80", Offset = "0x1CE7080", VA = "0x181CE7E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GJEFGCAEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3774610", Offset = "0x3773810", VA = "0x183774610")]
	public FEMCAAGCAOM(TDeps OAENIJAKBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37731A0", Offset = "0x37723A0", VA = "0x1837731A0")]
	public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> AIPPPMPJODJ(TRoot MFIBAFBMCBA, TNetSys CFNGMCCIOHJ, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, TAction OFOIHENMFDE, bool DMBCFIFLHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3772EE0", Offset = "0x37720E0", VA = "0x183772EE0")]
	[AsyncStateMachine(typeof(FEMCAAGCAOM<, , , , , , , , >.MJEINLDJBPL))]
	private Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> AIPPPMPJODJ(TRoot MFIBAFBMCBA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, TAction OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37728A0", Offset = "0x3771AA0", VA = "0x1837728A0")]
	[AsyncStateMachine(typeof(FEMCAAGCAOM<, , , , , , , , >.GEBGEFMLOKO))]
	private Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> AINMIGBGAOD(TRoot MFIBAFBMCBA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, TAction[] PGBGGHKPAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x37735F0", Offset = "0x37727F0", VA = "0x1837735F0")]
	[AsyncStateMachine(typeof(FEMCAAGCAOM<, , , , , , , , >.DFMNJIKGGPN))]
	public Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> DLGPBLIMLGJ(TRoot MFIBAFBMCBA, TNetSys GCPJMIDBBLE, TReceiver INAHCHDLNPA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, KHCIOCBLCGC<TMRequest> GBIOFCEABIN, TAction OFOIHENMFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3774010", Offset = "0x3773210", VA = "0x183774010")]
	[AsyncStateMachine(typeof(FEMCAAGCAOM<, , , , , , , , >.NNICALNAPCP))]
	private Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> JGCAIBMBJKM(TRoot MFIBAFBMCBA, TNetSys GCPJMIDBBLE, TReceiver INAHCHDLNPA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, KHCIOCBLCGC<TMRequest> GBIOFCEABIN, TAction OFOIHENMFDE, Task IDMOPKCPOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3774370", Offset = "0x3773570", VA = "0x183774370")]
	[AsyncStateMachine(typeof(FEMCAAGCAOM<, , , , , , , , >.NALHAJCBNEO))]
	private Task PAPIIEHHLJD(TRoot MFIBAFBMCBA, TNetSys GCPJMIDBBLE, TReceiver INAHCHDLNPA, TAction OFOIHENMFDE, NMMDPNGJJMA NLJBAOEIEFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3773B40", Offset = "0x3772D40", VA = "0x183773B40")]
	private void GMFOHAGACBC(TRoot MFIBAFBMCBA, TNetSys GCPJMIDBBLE, TReceiver INAHCHDLNPA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, TAction OFOIHENMFDE, bool KPDODNOIBIL, bool OIGEJAAHNBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FFJBPGDBKED
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PEEMLKGMIGO<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OJHNOKBLPEJ(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction APLPFEBIBGA(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction NFHJKCOMJNH(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BMCEFPOMAKG(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] NLAJODKCOKE(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE, int AGHGAGHMJLM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GGBJNDFFPPD(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MOJNNLDHDGD(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool FMCGAHPEFMN(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ALMCNFBEBGK(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AMLDEKGPJIH(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GAPGCLOCDPF(TNetSys OMHJAKBKALO, TAction OFOIHENMFDE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ILCBDCEGLJI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps DBEPDOFFEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HNKNMHMKMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps IDBHGHCHONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MNAOPLHOPPL<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KHCIOCBLCGC<PDFIKAKPMHI> PAGLKDJPLKP(TReceiver INAHCHDLNPA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OAAHAKNOJDO<object, AHFOEFCGOPM>> DLGPBLIMLGJ(TReceiver INAHCHDLNPA, TAction OFOIHENMFDE);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] MMCPEIHNFFL(TReceiver INAHCHDLNPA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DDJCFJNKJKO<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DEJHAJDKALC(TRoot MFIBAFBMCBA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HOEBGAJBHEH(TRoot MFIBAFBMCBA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KPHNDGHCEPB(TRoot MFIBAFBMCBA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MEFAIFKMNKD(TRoot MFIBAFBMCBA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IDHLCMCGCJJ(TRoot MFIBAFBMCBA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task AIPPPMPJODJ(TRoot MFIBAFBMCBA, KHCIOCBLCGC<PDFIKAKPMHI> CHODFAOIHKC, KHCIOCBLCGC<TMRequest> GBIOFCEABIN, TAction OFOIHENMFDE, bool HFDALAJHODE = true);
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

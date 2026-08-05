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
public struct PFBFHIDFNAG<TPartialAction, TFullAction, TDeps> where TDeps : FPGFHMMKIBI.MLFDMHODIDF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] DCHMLJHPMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int HFIBFGDNOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps ADEFBBLCDGG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x35EA260", Offset = "0x35E9260", VA = "0x1835EA260")]
	internal PFBFHIDFNAG(TPartialAction[] FCMKDABLKPD, int FOMKBJHCGJB, TDeps AKMCMCJGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35EA1B0", Offset = "0x35E91B0", VA = "0x1835EA1B0")]
	public static PFBFHIDFNAG<TPartialAction, TFullAction, TDeps> ANBAJJBGINK(TDeps AKMCMCJGOCI)
	{
		return default(PFBFHIDFNAG<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FPGFHMMKIBI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MLFDMHODIDF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int APKOJJBPCEE([In] TPartialAction ODICBNIOJFC);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KNAHBLGPEFE(TPartialAction[] BCHKPIFIPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24DF8C0", Offset = "0x24DE8C0", VA = "0x1824DF8C0")]
	public static JHBPOKMHNNP<TFullAction> EDPMFLBHFKJ<TFullAction, TPartialAction, TDeps>(this PFBFHIDFNAG<TPartialAction, TFullAction, TDeps> IEOMMHOPOKN, TPartialAction ODICBNIOJFC) where TDeps : MLFDMHODIDF<TPartialAction, TFullAction>
	{
		return default(JHBPOKMHNNP<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HDICBJOOEOO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : ONCMNPCLFOA.LKCPJDHDDBM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] IKLFDMABCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int GPMMOIBBFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps ADEFBBLCDGG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35EA260", Offset = "0x35E9260", VA = "0x1835EA260")]
	internal HDICBJOOEOO(TPartialSnapshot[] DMJMCNMMMCI, int HGIJFMGNFAP, TDeps AKMCMCJGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35EA1B0", Offset = "0x35E91B0", VA = "0x1835EA1B0")]
	public static HDICBJOOEOO<TPartialSnapshot, TFullSnapshot, TDeps> ANBAJJBGINK(TDeps AKMCMCJGOCI)
	{
		return default(HDICBJOOEOO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ONCMNPCLFOA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LKCPJDHDDBM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KLGAEPKLMKN([In] TPartialSnapshot DAAILJICCPM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LMDGCPCCNLE(TPartialSnapshot[] DDEJLHMABFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26370F0", Offset = "0x26360F0", VA = "0x1826370F0")]
	public static JHBPOKMHNNP<TFullSnapshot> EDPMFLBHFKJ<TFullSnapshot, TPartialSnapshot, TDeps>(this HDICBJOOEOO<TPartialSnapshot, TFullSnapshot, TDeps> IEOMMHOPOKN, TPartialSnapshot DAAILJICCPM) where TDeps : LKCPJDHDDBM<TPartialSnapshot, TFullSnapshot>
	{
		return default(JHBPOKMHNNP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2636FA0", Offset = "0x2635FA0", VA = "0x182636FA0")]
	public static bool EDODAKJLHIM<TPartialSnapshot, TFullSnapshot, TDeps>(this HDICBJOOEOO<TPartialSnapshot, TFullSnapshot, TDeps> IEOMMHOPOKN, TPartialSnapshot DAAILJICCPM) where TDeps : LKCPJDHDDBM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CGGOAAILPLG : GIOJECGONFO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CBD330", Offset = "0x1CBC330", VA = "0x181CBD330", Slot = "7")]
	public override string FNCBJKOJOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CBD360", Offset = "0x1CBC360", VA = "0x181CBD360")]
	public CGGOAAILPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HHFJEOEENFP.KNGIIJIGGNA<TAction, TNetSys> where TReceiverDeps : HHFJEOEENFP.EMBMCOBBFDJ<TMActor, TAction, TReceiver> where TRootDeps : HHFJEOEENFP.HKKINGOBGFB<TMRequest, TMActor, TAction, TRoot> where TDeps : HHFJEOEENFP.OLLJDOHPNIE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface HOOHDCDEABC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MKGJKNJIOBJ([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HFPFCHNOIDF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CJDJPCEAKND<object, ONNOIFLMODG> CHDFNLPBNJH();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GPGDHIHIBLD(Exception GDBKEDNPKDC);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class FOFNKLNCHBC : HOOHDCDEABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> NMLHEMGOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<CJDJPCEAKND<object, JBBODHKIFJN>> NNHNNHDKFDH;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3473A80", Offset = "0x3472A80", VA = "0x183473A80")]
		private FOFNKLNCHBC(TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> JHNAGPPLNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34733D0", Offset = "0x34723D0", VA = "0x1834733D0")]
		public static FOFNKLNCHBC ANBAJJBGINK(TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> JHNAGPPLNOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3473980", Offset = "0x3472980", VA = "0x183473980")]
		public void MKGJKNJIOBJ([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34736C0", Offset = "0x34726C0", VA = "0x1834736C0", Slot = "5")]
		public void HFPFCHNOIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3473550", Offset = "0x3472550", VA = "0x183473550", Slot = "6")]
		public CJDJPCEAKND<object, ONNOIFLMODG> CHDFNLPBNJH()
		{
			return default(CJDJPCEAKND<object, ONNOIFLMODG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3473600", Offset = "0x3472600", VA = "0x183473600", Slot = "7")]
		public void GPGDHIHIBLD(Exception GDBKEDNPKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x30F24F0", Offset = "0x30F14F0", VA = "0x1830F24F0", Slot = "4")]
		private void HOIAKJACAAA([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class PMFECMDECOE : HOOHDCDEABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> NMLHEMGOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CJDJPCEAKND<object, ONNOIFLMODG> PJPGDNIPBMO;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
		private PMFECMDECOE(TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> JHNAGPPLNOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34733D0", Offset = "0x34723D0", VA = "0x1834733D0")]
		public static PMFECMDECOE ANBAJJBGINK(TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> JHNAGPPLNOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37210A0", Offset = "0x37200A0", VA = "0x1837210A0")]
		public void MKGJKNJIOBJ([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAF10", Offset = "0x3EC9F10", VA = "0x183ECAF10", Slot = "5")]
		public void HFPFCHNOIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C95B0", Offset = "0x9C85B0", VA = "0x1809C95B0", Slot = "6")]
		public CJDJPCEAKND<object, ONNOIFLMODG> CHDFNLPBNJH()
		{
			return default(CJDJPCEAKND<object, ONNOIFLMODG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAE50", Offset = "0x3EC9E50", VA = "0x183ECAE50", Slot = "7")]
		public void GPGDHIHIBLD(Exception GDBKEDNPKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x30F24F0", Offset = "0x30F14F0", VA = "0x1830F24F0", Slot = "4")]
		private void HOIAKJACAAA([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class CCJPKJMNNPK : HOOHDCDEABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<CJDJPCEAKND<object, ONNOIFLMODG>> NNHNNHDKFDH;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x47F1740", Offset = "0x47F0740", VA = "0x1847F1740")]
		private CCJPKJMNNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x371A3E0", Offset = "0x37193E0", VA = "0x18371A3E0")]
		public static CCJPKJMNNPK ANBAJJBGINK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x47F1510", Offset = "0x47F0510", VA = "0x1847F1510")]
		public void MKGJKNJIOBJ([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		public void HFPFCHNOIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x47F13B0", Offset = "0x47F03B0", VA = "0x1847F13B0", Slot = "6")]
		public CJDJPCEAKND<object, ONNOIFLMODG> CHDFNLPBNJH()
		{
			return default(CJDJPCEAKND<object, ONNOIFLMODG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47F14C0", Offset = "0x47F04C0", VA = "0x1847F14C0", Slot = "7")]
		[CGBJKNJKFOC("This may be terminal and should probably do more than discarding the exception.")]
		public void GPGDHIHIBLD(Exception GDBKEDNPKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x30F24F0", Offset = "0x30F14F0", VA = "0x1830F24F0", Slot = "4")]
		private void HOIAKJACAAA([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class IABELHGDNKB : HOOHDCDEABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CJDJPCEAKND<object, ONNOIFLMODG> PJPGDNIPBMO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		private IABELHGDNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x371A3E0", Offset = "0x37193E0", VA = "0x18371A3E0")]
		public static IABELHGDNKB ANBAJJBGINK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x371A540", Offset = "0x3719540", VA = "0x18371A540")]
		public void MKGJKNJIOBJ([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		public void HFPFCHNOIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAF06A0", Offset = "0xAEF6A0", VA = "0x180AF06A0", Slot = "6")]
		public CJDJPCEAKND<object, ONNOIFLMODG> CHDFNLPBNJH()
		{
			return default(CJDJPCEAKND<object, ONNOIFLMODG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x371A4A0", Offset = "0x37194A0", VA = "0x18371A4A0", Slot = "7")]
		[CGBJKNJKFOC("This may be terminal and should probably do more than discarding the exception.")]
		public void GPGDHIHIBLD(Exception GDBKEDNPKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x30F24F0", Offset = "0x30F14F0", VA = "0x1830F24F0", Slot = "4")]
		private void HOIAKJACAAA([In] CJDJPCEAKND<object, ONNOIFLMODG> BBMBCGDLBEE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NGOFBMGBJGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<object, ONNOIFLMODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GPIHCBBBGNP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CJDJPCEAKND<object, ONNOIFLMODG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A480", Offset = "0x3D19480", VA = "0x183D1A480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A950", Offset = "0x3D19950", VA = "0x183D1A950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JKAIJFPIEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<object, ONNOIFLMODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GPIHCBBBGNP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<CJDJPCEAKND<object, ONNOIFLMODG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38F0730", Offset = "0x38EF730", VA = "0x1838F0730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x38F0B70", Offset = "0x38EFB70", VA = "0x1838F0B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct FGFOFFKPAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<object, ONNOIFLMODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GPIHCBBBGNP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GPIHCBBBGNP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CJDJPCEAKND<object, ONNOIFLMODG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x345BB50", Offset = "0x345AB50", VA = "0x18345BB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x345C270", Offset = "0x345B270", VA = "0x18345C270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DKCMNBGLKLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<CJDJPCEAKND<object, ONNOIFLMODG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GPIHCBBBGNP<TMActor> senderId;

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
		public GPIHCBBBGNP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private HOOHDCDEABC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DBF3E0", Offset = "0x4DBE3E0", VA = "0x184DBF3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4DC0CD0", Offset = "0x4DBFCD0", VA = "0x184DC0CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BCJNGBJLIOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::GKFDJHPIHDN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HOOHDCDEABC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private HOOHDCDEABC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CJDJPCEAKND<object, ONNOIFLMODG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x452D3A0", Offset = "0x452C3A0", VA = "0x18452D3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x452F150", Offset = "0x452E150", VA = "0x18452F150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps ADEFBBLCDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<GPIHCBBBGNP<TMRequest>, TaskCompletionSource<CJDJPCEAKND<object, ONNOIFLMODG>>> JBCPAIHFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GKNLOHPIBAL<TMRequest> ABOKPAHPDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int AJJOFKEOIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GMNHNFHPNLJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps IKJJKDCDBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3586EF0", Offset = "0x3585EF0", VA = "0x183586EF0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps KHDNMLPMCFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3586840", Offset = "0x3585840", VA = "0x183586840")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps NILHGFGGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3586E70", Offset = "0x3585E70", VA = "0x183586E70")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ALANOJDMJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10962A0", Offset = "0x10952A0", VA = "0x1810962A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10962B0", Offset = "0x10952B0", VA = "0x1810962B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BIPAOPKIKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BA7F50", Offset = "0x1BA6F50", VA = "0x181BA7F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BA8230", Offset = "0x1BA7230", VA = "0x181BA8230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HGIHPMIADOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7786E0", Offset = "0x7776E0", VA = "0x1807786E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3587080", Offset = "0x3586080", VA = "0x183587080")]
	public GKFDJHPIHDN(TDeps AKMCMCJGOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3585F10", Offset = "0x3584F10", VA = "0x183585F10")]
	public Task<CJDJPCEAKND<object, ONNOIFLMODG>> CDCCJOBLJLI(TRoot GLACNLFCFNI, TNetSys KMEACDODHND, GPIHCBBBGNP<TMActor> LCFOPBENPPI, TAction NFDFJOBAEPD, bool GILPEKCPBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3585DB0", Offset = "0x3584DB0", VA = "0x183585DB0")]
	[AsyncStateMachine(typeof(global::GKFDJHPIHDN<, , , , , , , , , >.NGOFBMGBJGH))]
	private Task<CJDJPCEAKND<object, ONNOIFLMODG>> CDCCJOBLJLI(TRoot GLACNLFCFNI, GPIHCBBBGNP<TMActor> LCFOPBENPPI, TAction NFDFJOBAEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3586CC0", Offset = "0x3585CC0", VA = "0x183586CC0")]
	[AsyncStateMachine(typeof(global::GKFDJHPIHDN<, , , , , , , , , >.JKAIJFPIEKD))]
	private Task<CJDJPCEAKND<object, ONNOIFLMODG>> KPBEFLEBMNA(TRoot GLACNLFCFNI, GPIHCBBBGNP<TMActor> LCFOPBENPPI, TAction[] AMGIECCMHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35869F0", Offset = "0x35859F0", VA = "0x1835869F0")]
	[AsyncStateMachine(typeof(global::GKFDJHPIHDN<, , , , , , , , , >.FGFOFFKPAAM))]
	public Task<CJDJPCEAKND<object, ONNOIFLMODG>> GGJANGLOGGP(TRoot GLACNLFCFNI, TNetSys PPBMEECIGGJ, TReceiver HGHAJEHCOAJ, GPIHCBBBGNP<TMActor> LCFOPBENPPI, GPIHCBBBGNP<TMRequest> PPPHBEILEFD, TAction NFDFJOBAEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35863C0", Offset = "0x35853C0", VA = "0x1835863C0")]
	[AsyncStateMachine(typeof(global::GKFDJHPIHDN<, , , , , , , , , >.DKCMNBGLKLN))]
	private Task<CJDJPCEAKND<object, ONNOIFLMODG>> CDFFAIDNOHP(TRoot GLACNLFCFNI, TNetSys PPBMEECIGGJ, TReceiver HGHAJEHCOAJ, GPIHCBBBGNP<TMActor> LCFOPBENPPI, GPIHCBBBGNP<TMRequest> PPPHBEILEFD, TAction NFDFJOBAEPD, Task FPGEIJCDLCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35866A0", Offset = "0x35856A0", VA = "0x1835866A0")]
	[AsyncStateMachine(typeof(global::GKFDJHPIHDN<, , , , , , , , , >.BCJNGBJLIOB))]
	private Task CIODHFAHHKM(TRoot GLACNLFCFNI, TNetSys PPBMEECIGGJ, TReceiver HGHAJEHCOAJ, TAction NFDFJOBAEPD, HOOHDCDEABC BPJHBCIINKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3585450", Offset = "0x3584450", VA = "0x183585450")]
	private void ANNBGKDIALB(TRoot GLACNLFCFNI, TNetSys PPBMEECIGGJ, TReceiver HGHAJEHCOAJ, GPIHCBBBGNP<TMActor> LCFOPBENPPI, TAction NFDFJOBAEPD, bool MPOAPHOMMIM, bool AMHNLBKKOEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HHFJEOEENFP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KNGIIJIGGNA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HADPANMIFCE(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction DBNLNHKGAMN(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction EMHCCLIENFF(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HOJBDFJKAOD(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] HOGMHFNEGHL(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD, int LLFCHIACKOA);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BHPHKEKJNBE(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool AHEJJOFABCI(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KJLFMDBBLKO(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BEOKOJOAHCL(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JEIKBNNIJAM(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool MKIJLPNHDBE(TNetSys AKHBPPCMFBI, TAction NFDFJOBAEPD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface OLLJDOHPNIE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps IKJJKDCDBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps NILHGFGGCDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps KHDNMLPMCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EMBMCOBBFDJ<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GPIHCBBBGNP<TMActor> FPFHKPELEHJ(TReceiver HGHAJEHCOAJ);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CJDJPCEAKND<object, ONNOIFLMODG>> GGJANGLOGGP(TReceiver HGHAJEHCOAJ, TAction NFDFJOBAEPD);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HNEPPABGMDC(TReceiver HGHAJEHCOAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HKKINGOBGFB<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FJOBJDDCDOD(TRoot GLACNLFCFNI);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MGMHJMCJHCC(TRoot GLACNLFCFNI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BMNFKNHAIGH(TRoot GLACNLFCFNI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BEFAGMMFKID(TRoot GLACNLFCFNI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HCNBFDHFPMJ(TRoot GLACNLFCFNI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task CDCCJOBLJLI(TRoot GLACNLFCFNI, GPIHCBBBGNP<TMActor> LCFOPBENPPI, GPIHCBBBGNP<TMRequest> PPPHBEILEFD, TAction NFDFJOBAEPD, bool JJAJOOGPBHM = true);
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

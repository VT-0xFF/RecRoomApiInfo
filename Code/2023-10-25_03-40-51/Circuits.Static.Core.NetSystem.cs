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
public struct DDLAMCIHJCE<TPartialAction, TFullAction, TDeps> where TDeps : OADKENHJMLB.FFEGHELEAAA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] ELPHOEDAPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int NBFJOKKDNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps JFMOPJMOHHN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x383C7E0", Offset = "0x383B5E0", VA = "0x18383C7E0")]
	internal DDLAMCIHJCE(TPartialAction[] OPLJILFPMHB, int DEKBHACELDK, TDeps BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x383C730", Offset = "0x383B530", VA = "0x18383C730")]
	public static DDLAMCIHJCE<TPartialAction, TFullAction, TDeps> IGHHFGMBDIH(TDeps BLNNMOCCDKN)
	{
		return default(DDLAMCIHJCE<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OADKENHJMLB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FFEGHELEAAA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JGDNPMOJPCD([In] TPartialAction LNFGBLILICO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction AEHACJHLLHL(TPartialAction[] DIDGBLGHBKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21E7600", Offset = "0x21E6400", VA = "0x1821E7600")]
	public static KBGKJDMAFMA<TFullAction> EAAKIHNMNLP<TFullAction, TPartialAction, TDeps>(this DDLAMCIHJCE<TPartialAction, TFullAction, TDeps> PECKHAMCEFO, TPartialAction LNFGBLILICO) where TDeps : FFEGHELEAAA<TPartialAction, TFullAction>
	{
		return default(KBGKJDMAFMA<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JDNLCFDCDAO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CDMNJBBHEAO.CFEDBJHDNCN<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] KNFJDLLPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int OMLAIBNGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps JFMOPJMOHHN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x383C7A0", Offset = "0x383B5A0", VA = "0x18383C7A0")]
	internal JDNLCFDCDAO(TPartialSnapshot[] APDDBICDJDM, int MGKGFPJMDED, TDeps BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x383C6D0", Offset = "0x383B4D0", VA = "0x18383C6D0")]
	public static JDNLCFDCDAO<TPartialSnapshot, TFullSnapshot, TDeps> IGHHFGMBDIH(TDeps BLNNMOCCDKN)
	{
		return default(JDNLCFDCDAO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CDMNJBBHEAO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CFEDBJHDNCN<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KNNGIGDIMPF([In] TPartialSnapshot DGANMHKCJDP);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot HFOKPDFLFJO(TPartialSnapshot[] INPENLJHBIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21E74A0", Offset = "0x21E62A0", VA = "0x1821E74A0")]
	public static KBGKJDMAFMA<TFullSnapshot> EAAKIHNMNLP<TFullSnapshot, TPartialSnapshot, TDeps>(this JDNLCFDCDAO<TPartialSnapshot, TFullSnapshot, TDeps> PECKHAMCEFO, TPartialSnapshot DGANMHKCJDP) where TDeps : CFEDBJHDNCN<TPartialSnapshot, TFullSnapshot>
	{
		return default(KBGKJDMAFMA<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x21E7350", Offset = "0x21E6150", VA = "0x1821E7350")]
	public static bool DADFNJAEKAJ<TPartialSnapshot, TFullSnapshot, TDeps>(this JDNLCFDCDAO<TPartialSnapshot, TFullSnapshot, TDeps> PECKHAMCEFO, TPartialSnapshot DGANMHKCJDP) where TDeps : CFEDBJHDNCN<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class LONFOGKJOGP : BKLKNEGKHFP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C688D0", Offset = "0x1C676D0", VA = "0x181C688D0", Slot = "7")]
	public override string KJDIEKJIOOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C68900", Offset = "0x1C67700", VA = "0x181C68900")]
	public LONFOGKJOGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HMGKHEHIGFD.PHKBAOLPJNP<TAction, TNetSys> where TReceiverDeps : HMGKHEHIGFD.LFCOLNFHGMI<TMActor, TAction, TReceiver> where TRootDeps : HMGKHEHIGFD.GOKJAABDBPC<TMRequest, TMActor, TAction, TRoot> where TDeps : HMGKHEHIGFD.ODIGCPAFPMH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface IGFJLKFGFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void POHJEPGFIIM([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FKCHIDOBEAK();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FEBPNEDDNDE<object, KBBJHNEEOGJ> PHHCONFFBHH();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HHNDPFPCKEJ(Exception GLNCBNFNGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class OPLHNABAAKD : IGFJLKFGFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> IJGLIOIDCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<FEBPNEDDNDE<object, NEBNMHPBDBO>> ICKBKHMDECL;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CECAB0", Offset = "0x3CEB8B0", VA = "0x183CECAB0")]
		private OPLHNABAAKD(TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> AIJCFMOLNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34B5C00", Offset = "0x34B4A00", VA = "0x1834B5C00")]
		public static OPLHNABAAKD IGHHFGMBDIH(TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> AIJCFMOLNKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC9B0", Offset = "0x3CEB7B0", VA = "0x183CEC9B0")]
		public void POHJEPGFIIM([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC4D0", Offset = "0x3CEB2D0", VA = "0x183CEC4D0", Slot = "5")]
		public void FKCHIDOBEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC750", Offset = "0x3CEB550", VA = "0x183CEC750", Slot = "6")]
		public FEBPNEDDNDE<object, KBBJHNEEOGJ> PHHCONFFBHH()
		{
			return default(FEBPNEDDNDE<object, KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC6F0", Offset = "0x3CEB4F0", VA = "0x183CEC6F0", Slot = "7")]
		public void HHNDPFPCKEJ(Exception GLNCBNFNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3448F60", Offset = "0x3447D60", VA = "0x183448F60", Slot = "4")]
		private void KPOCLACMHIC([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class CDDFJEDJBHG : IGFJLKFGFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> IJGLIOIDCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private FEBPNEDDNDE<object, KBBJHNEEOGJ> EHCCCBJCAGK;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
		private CDDFJEDJBHG(TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> AIJCFMOLNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34B5C00", Offset = "0x34B4A00", VA = "0x1834B5C00")]
		public static CDDFJEDJBHG IGHHFGMBDIH(TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> AIJCFMOLNKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2300", Offset = "0x3DE1100", VA = "0x183DE2300")]
		public void POHJEPGFIIM([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x477FA20", Offset = "0x477E820", VA = "0x18477FA20", Slot = "5")]
		public void FKCHIDOBEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "6")]
		public FEBPNEDDNDE<object, KBBJHNEEOGJ> PHHCONFFBHH()
		{
			return default(FEBPNEDDNDE<object, KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x477FAE0", Offset = "0x477E8E0", VA = "0x18477FAE0", Slot = "7")]
		public void HHNDPFPCKEJ(Exception GLNCBNFNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3448F60", Offset = "0x3447D60", VA = "0x183448F60", Slot = "4")]
		private void KPOCLACMHIC([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AEOEBABOBOL : IGFJLKFGFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<FEBPNEDDNDE<object, KBBJHNEEOGJ>> ICKBKHMDECL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3449270", Offset = "0x3448070", VA = "0x183449270")]
		private AEOEBABOBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3448EA0", Offset = "0x3447CA0", VA = "0x183448EA0")]
		public static AEOEBABOBOL IGHHFGMBDIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3449040", Offset = "0x3447E40", VA = "0x183449040")]
		public void POHJEPGFIIM([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void FKCHIDOBEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3448F80", Offset = "0x3447D80", VA = "0x183448F80", Slot = "6")]
		public FEBPNEDDNDE<object, KBBJHNEEOGJ> PHHCONFFBHH()
		{
			return default(FEBPNEDDNDE<object, KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		public void HHNDPFPCKEJ(Exception GLNCBNFNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3448F60", Offset = "0x3447D60", VA = "0x183448F60", Slot = "4")]
		private void KPOCLACMHIC([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MDLPONOLCLP : IGFJLKFGFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FEBPNEDDNDE<object, KBBJHNEEOGJ> EHCCCBJCAGK;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private MDLPONOLCLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3448EA0", Offset = "0x3447CA0", VA = "0x183448EA0")]
		public static MDLPONOLCLP IGHHFGMBDIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B890", Offset = "0x3B5A690", VA = "0x183B5B890")]
		public void POHJEPGFIIM([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void FKCHIDOBEAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90", Slot = "6")]
		public FEBPNEDDNDE<object, KBBJHNEEOGJ> PHHCONFFBHH()
		{
			return default(FEBPNEDDNDE<object, KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		public void HHNDPFPCKEJ(Exception GLNCBNFNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3448F60", Offset = "0x3447D60", VA = "0x183448F60", Slot = "4")]
		private void KPOCLACMHIC([In] FEBPNEDDNDE<object, KBBJHNEEOGJ> CGIMAKAECOA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GJIOCHOHDGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GDGHOPABCBJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3526C70", Offset = "0x3525A70", VA = "0x183526C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x35276B0", Offset = "0x35264B0", VA = "0x1835276B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PEPLIFGBOLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GDGHOPABCBJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D96E20", Offset = "0x3D95C20", VA = "0x183D96E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D97260", Offset = "0x3D96060", VA = "0x183D97260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LEGIFECHJCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GDGHOPABCBJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GDGHOPABCBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x397AA60", Offset = "0x3979860", VA = "0x18397AA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x397B110", Offset = "0x3979F10", VA = "0x18397B110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PGENJMLKIMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GDGHOPABCBJ<TMActor> senderId;

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
		public GDGHOPABCBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IGFJLKFGFNA <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1AF0", Offset = "0x3DB08F0", VA = "0x183DB1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DB3380", Offset = "0x3DB2180", VA = "0x183DB3380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IHAKFEOHAGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::HINHEIPKFKJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public IGFJLKFGFNA completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IGFJLKFGFNA <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36996A0", Offset = "0x36984A0", VA = "0x1836996A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x369B3F0", Offset = "0x369A1F0", VA = "0x18369B3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps JFMOPJMOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<GDGHOPABCBJ<TMRequest>, TaskCompletionSource<FEBPNEDDNDE<object, KBBJHNEEOGJ>>> HOFLKKFKIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private IFMEPOKENDD<TMRequest> MCBMDPANIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int GDPKEKGOGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task DOFLIKNALEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps OKJGEBNEGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35DF690", Offset = "0x35DE490", VA = "0x1835DF690")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps BKOKLGNFGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35DEB60", Offset = "0x35DD960", VA = "0x1835DEB60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DBBPNCHOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35DEAE0", Offset = "0x35DD8E0", VA = "0x1835DEAE0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JNEDDFNOGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1027DB0", Offset = "0x1026BB0", VA = "0x181027DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1027DC0", Offset = "0x1026BC0", VA = "0x181027DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LCHCBGEIAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B540F0", Offset = "0x1B52EF0", VA = "0x181B540F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B543D0", Offset = "0x1B531D0", VA = "0x181B543D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJBFJPCEIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x763850", Offset = "0x762650", VA = "0x180763850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35E0730", Offset = "0x35DF530", VA = "0x1835E0730")]
	public HINHEIPKFKJ(TDeps BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35DF0B0", Offset = "0x35DDEB0", VA = "0x1835DF0B0")]
	public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> EONLDLGMDEH(TRoot PHNFANHCONA, TNetSys GGNCHECHHDN, GDGHOPABCBJ<TMActor> IIHCNNANOLD, TAction IPGJPNDBCJD, bool FJENGJGFNLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35DF530", Offset = "0x35DE330", VA = "0x1835DF530")]
	[AsyncStateMachine(typeof(global::HINHEIPKFKJ<, , , , , , , , , >.GJIOCHOHDGE))]
	private Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> EONLDLGMDEH(TRoot PHNFANHCONA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, TAction IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35DE930", Offset = "0x35DD730", VA = "0x1835DE930")]
	[AsyncStateMachine(typeof(global::HINHEIPKFKJ<, , , , , , , , , >.PEPLIFGBOLN))]
	private Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> AOPHJDFAHGD(TRoot PHNFANHCONA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, TAction[] JHODOBKGEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35DF710", Offset = "0x35DE510", VA = "0x1835DF710")]
	[AsyncStateMachine(typeof(global::HINHEIPKFKJ<, , , , , , , , , >.LEGIFECHJCO))]
	public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> LFLAAMHHBDH(TRoot PHNFANHCONA, TNetSys IPGBAAIHHLP, TReceiver ELGGIPNHKGA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, GDGHOPABCBJ<TMRequest> CFNCLHKMJJM, TAction IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35E0010", Offset = "0x35DEE10", VA = "0x1835E0010")]
	[AsyncStateMachine(typeof(global::HINHEIPKFKJ<, , , , , , , , , >.PGENJMLKIMI))]
	private Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> ODDBBMDPOMK(TRoot PHNFANHCONA, TNetSys IPGBAAIHHLP, TReceiver ELGGIPNHKGA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, GDGHOPABCBJ<TMRequest> CFNCLHKMJJM, TAction IPGJPNDBCJD, Task BLJBKADPJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35E0320", Offset = "0x35DF120", VA = "0x1835E0320")]
	[AsyncStateMachine(typeof(global::HINHEIPKFKJ<, , , , , , , , , >.IHAKFEOHAGJ))]
	private Task PCOOAGDEJPE(TRoot PHNFANHCONA, TNetSys IPGBAAIHHLP, TReceiver ELGGIPNHKGA, TAction IPGJPNDBCJD, IGFJLKFGFNA PMDLDANCHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35DFD70", Offset = "0x35DEB70", VA = "0x1835DFD70")]
	private void NNAHNNIHGCA(TRoot PHNFANHCONA, TNetSys IPGBAAIHHLP, TReceiver ELGGIPNHKGA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, TAction IPGJPNDBCJD, bool ONJHDDGLGEF, bool APJEOPHGLIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HMGKHEHIGFD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PHKBAOLPJNP<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HBLGMPAIBLF(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MCKCMOGGBAM(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HNDCCDOICNC(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PPMKNGJPNNH(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] FKNKGMNPEJH(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD, int FBDOBGDGKFA);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PHOGBPHMCPH(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OJHCLJFBOKL(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool AGCJDMFFHIF(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PLKJEIKICLF(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FALFFMMHGDH(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PBCGNGHJMJJ(TNetSys BAJKCAFEDPA, TAction IPGJPNDBCJD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ODIGCPAFPMH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps OKJGEBNEGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DBBPNCHOJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps BKOKLGNFGPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LFCOLNFHGMI<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GDGHOPABCBJ<TMActor> KFCHLNGGHEL(TReceiver ELGGIPNHKGA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> LFLAAMHHBDH(TReceiver ELGGIPNHKGA, TAction IPGJPNDBCJD);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] GGIEGLPJIFN(TReceiver ELGGIPNHKGA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GOKJAABDBPC<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HKFFGDBAFKL(TRoot PHNFANHCONA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EKNIHAMIPPC(TRoot PHNFANHCONA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int CPELBMKANIH(TRoot PHNFANHCONA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int AACBJCPIBPC(TRoot PHNFANHCONA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FIBDANGPJPI(TRoot PHNFANHCONA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task EONLDLGMDEH(TRoot PHNFANHCONA, GDGHOPABCBJ<TMActor> IIHCNNANOLD, GDGHOPABCBJ<TMRequest> CFNCLHKMJJM, TAction IPGJPNDBCJD, bool OCANFINBGJK = true);
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

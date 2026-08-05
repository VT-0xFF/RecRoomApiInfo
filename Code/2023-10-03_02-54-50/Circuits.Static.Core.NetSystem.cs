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
public struct ALDLPFHPKFF<TPartialAction, TFullAction, TDeps> where TDeps : OMDAPEPHDAL.BGPHAMEBOKA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] EKKGIGNANIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int NHHHBCNLHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps CIFIMLEEDNI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x36C1CE0", Offset = "0x36C04E0", VA = "0x1836C1CE0")]
	internal ALDLPFHPKFF(TPartialAction[] GKOCFPOPBOJ, int CADNCBECDLE, TDeps AGOMFIAFNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36C1BD0", Offset = "0x36C03D0", VA = "0x1836C1BD0")]
	public static ALDLPFHPKFF<TPartialAction, TFullAction, TDeps> MJLGMKKAMEE(TDeps AGOMFIAFNMP)
	{
		return default(ALDLPFHPKFF<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OMDAPEPHDAL
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface BGPHAMEBOKA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EOCEADCJHCF([In] TPartialAction POALPLIHMGO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction GPDMKBBHNEH(TPartialAction[] CGBMOCJDLLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2374ED0", Offset = "0x23736D0", VA = "0x182374ED0")]
	public static OCIMHDHLOGG<TFullAction> FFDMKJFMGIG<TFullAction, TPartialAction, TDeps>(this ALDLPFHPKFF<TPartialAction, TFullAction, TDeps> CLEGCKJMIEA, TPartialAction POALPLIHMGO) where TDeps : BGPHAMEBOKA<TPartialAction, TFullAction>
	{
		return default(OCIMHDHLOGG<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CIGOKEOJPGP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : FLJKIHIBLEJ.BAFKPHICPON<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] NNKAFIIMIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int LFBPPEADJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps CIFIMLEEDNI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36C1CA0", Offset = "0x36C04A0", VA = "0x1836C1CA0")]
	internal CIGOKEOJPGP(TPartialSnapshot[] JAPFAIKFEGP, int PNABMOONPFL, TDeps AGOMFIAFNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36C1C40", Offset = "0x36C0440", VA = "0x1836C1C40")]
	public static CIGOKEOJPGP<TPartialSnapshot, TFullSnapshot, TDeps> MJLGMKKAMEE(TDeps AGOMFIAFNMP)
	{
		return default(CIGOKEOJPGP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FLJKIHIBLEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BAFKPHICPON<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HDBPPIELGOA([In] TPartialSnapshot BANJCNJDNCH);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LNDOHCNGGML(TPartialSnapshot[] IGLJPOPPMPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2374D70", Offset = "0x2373570", VA = "0x182374D70")]
	public static OCIMHDHLOGG<TFullSnapshot> FFDMKJFMGIG<TFullSnapshot, TPartialSnapshot, TDeps>(this CIGOKEOJPGP<TPartialSnapshot, TFullSnapshot, TDeps> CLEGCKJMIEA, TPartialSnapshot BANJCNJDNCH) where TDeps : BAFKPHICPON<TPartialSnapshot, TFullSnapshot>
	{
		return default(OCIMHDHLOGG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2375120", Offset = "0x2373920", VA = "0x182375120")]
	public static bool PDIFDKDONBG<TPartialSnapshot, TFullSnapshot, TDeps>(this CIGOKEOJPGP<TPartialSnapshot, TFullSnapshot, TDeps> CLEGCKJMIEA, TPartialSnapshot BANJCNJDNCH) where TDeps : BAFKPHICPON<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class OIGCHCLCINJ : CDMBCFNGLDJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C39610", Offset = "0x1C37E10", VA = "0x181C39610", Slot = "7")]
	public override string GLHFGNJEPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C39640", Offset = "0x1C37E40", VA = "0x181C39640")]
	public OIGCHCLCINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : DGJEGJENEGF.NOOEAODELNO<TAction, TNetSys> where TReceiverDeps : DGJEGJENEGF.JCAJICDFIBN<TMActor, TAction, TReceiver> where TRootDeps : DGJEGJENEGF.CBLNEGPOMCF<TMRequest, TMActor, TAction, TRoot> where TDeps : DGJEGJENEGF.NDEEKMLKPBD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface CKEBEHHBLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LGKOJECNIFH([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FPDMIJAGJFO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ENHODGJKDIF<object, HFHKAILBFCH> GPBJIIOCDPD();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FOIDBOKNGGL(Exception DCJGKNPOAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class MJIDGMLDLIG : CKEBEHHBLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> CDCHIBCJIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<ENHODGJKDIF<object, OPCAMIHAIIG>> GBAAPKCCIEK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD720", Offset = "0x3BBBF20", VA = "0x183BBD720")]
		private MJIDGMLDLIG(TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> NAACIMLIADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3398DE0", Offset = "0x33975E0", VA = "0x183398DE0")]
		public static MJIDGMLDLIG MJLGMKKAMEE(TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> NAACIMLIADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD520", Offset = "0x3BBBD20", VA = "0x183BBD520")]
		public void LGKOJECNIFH([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD200", Offset = "0x3BBBA00", VA = "0x183BBD200", Slot = "5")]
		public void FPDMIJAGJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD3C0", Offset = "0x3BBBBC0", VA = "0x183BBD3C0", Slot = "6")]
		public ENHODGJKDIF<object, HFHKAILBFCH> GPBJIIOCDPD()
		{
			return default(ENHODGJKDIF<object, HFHKAILBFCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3BBD140", Offset = "0x3BBB940", VA = "0x183BBD140", Slot = "7")]
		public void FOIDBOKNGGL(Exception DCJGKNPOAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x35084A0", Offset = "0x3506CA0", VA = "0x1835084A0", Slot = "4")]
		private void LOFMKKHNCHA([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class HBBPAGOPIEN : CKEBEHHBLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> CDCHIBCJIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ENHODGJKDIF<object, HFHKAILBFCH> GENJFCGCPCI;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
		private HBBPAGOPIEN(TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> NAACIMLIADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3398DE0", Offset = "0x33975E0", VA = "0x183398DE0")]
		public static HBBPAGOPIEN MJLGMKKAMEE(TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> NAACIMLIADP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3508480", Offset = "0x3506C80", VA = "0x183508480")]
		public void LGKOJECNIFH([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x35083C0", Offset = "0x3506BC0", VA = "0x1835083C0", Slot = "5")]
		public void FPDMIJAGJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x954C10", Offset = "0x953410", VA = "0x180954C10", Slot = "6")]
		public ENHODGJKDIF<object, HFHKAILBFCH> GPBJIIOCDPD()
		{
			return default(ENHODGJKDIF<object, HFHKAILBFCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3508360", Offset = "0x3506B60", VA = "0x183508360", Slot = "7")]
		public void FOIDBOKNGGL(Exception DCJGKNPOAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x35084A0", Offset = "0x3506CA0", VA = "0x1835084A0", Slot = "4")]
		private void LOFMKKHNCHA([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DPACGDBDPDK : CKEBEHHBLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<ENHODGJKDIF<object, HFHKAILBFCH>> GBAAPKCCIEK;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4CEB480", Offset = "0x4CE9C80", VA = "0x184CEB480")]
		private DPACGDBDPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x390F6B0", Offset = "0x390DEB0", VA = "0x18390F6B0")]
		public static DPACGDBDPDK MJLGMKKAMEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4CEB320", Offset = "0x4CE9B20", VA = "0x184CEB320")]
		public void LGKOJECNIFH([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		public void FPDMIJAGJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4CEB190", Offset = "0x4CE9990", VA = "0x184CEB190", Slot = "6")]
		public ENHODGJKDIF<object, HFHKAILBFCH> GPBJIIOCDPD()
		{
			return default(ENHODGJKDIF<object, HFHKAILBFCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		public void FOIDBOKNGGL(Exception DCJGKNPOAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35084A0", Offset = "0x3506CA0", VA = "0x1835084A0", Slot = "4")]
		private void LOFMKKHNCHA([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KPEBFNMLIEE : CKEBEHHBLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ENHODGJKDIF<object, HFHKAILBFCH> GENJFCGCPCI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		private KPEBFNMLIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x390F6B0", Offset = "0x390DEB0", VA = "0x18390F6B0")]
		public static KPEBFNMLIEE MJLGMKKAMEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x390F690", Offset = "0x390DE90", VA = "0x18390F690")]
		public void LGKOJECNIFH([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		public void FPDMIJAGJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070", Slot = "6")]
		public ENHODGJKDIF<object, HFHKAILBFCH> GPBJIIOCDPD()
		{
			return default(ENHODGJKDIF<object, HFHKAILBFCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		public void FOIDBOKNGGL(Exception DCJGKNPOAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35084A0", Offset = "0x3506CA0", VA = "0x1835084A0", Slot = "4")]
		private void LOFMKKHNCHA([In] ENHODGJKDIF<object, HFHKAILBFCH> PGNGICAKGGE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EAKONOGKJOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<object, HFHKAILBFCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DDFBADMIKFJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<ENHODGJKDIF<object, HFHKAILBFCH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD2B0", Offset = "0x2FDBAB0", VA = "0x182FDD2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDD7F0", Offset = "0x2FDBFF0", VA = "0x182FDD7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MABPGDHFIKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<object, HFHKAILBFCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DDFBADMIKFJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<ENHODGJKDIF<object, HFHKAILBFCH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B94BB0", Offset = "0x3B933B0", VA = "0x183B94BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B95430", Offset = "0x3B93C30", VA = "0x183B95430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PPFEECMGAEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<object, HFHKAILBFCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public DDFBADMIKFJ<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public DDFBADMIKFJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<ENHODGJKDIF<object, HFHKAILBFCH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E99940", Offset = "0x3E98140", VA = "0x183E99940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E99D10", Offset = "0x3E98510", VA = "0x183E99D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KMGBDLCOONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<ENHODGJKDIF<object, HFHKAILBFCH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DDFBADMIKFJ<TMActor> senderId;

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
		public DDFBADMIKFJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private CKEBEHHBLLM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38EA1F0", Offset = "0x38E89F0", VA = "0x1838EA1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x38EBB50", Offset = "0x38EA350", VA = "0x1838EBB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CFKMDINCPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::AHIAICAPCPJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public CKEBEHHBLLM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CKEBEHHBLLM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<ENHODGJKDIF<object, HFHKAILBFCH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4A54950", Offset = "0x4A53150", VA = "0x184A54950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4A566A0", Offset = "0x4A54EA0", VA = "0x184A566A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps CIFIMLEEDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<DDFBADMIKFJ<TMRequest>, TaskCompletionSource<ENHODGJKDIF<object, HFHKAILBFCH>>> KOHFCFFGLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private IBPDFFJDFLH<TMRequest> CKFGGCKLFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int LOPGDGBJPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task MICMCNHEELP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps HCJOLJIHAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x35A47C0", Offset = "0x35A2FC0", VA = "0x1835A47C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps OPDKAHJHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35A2D70", Offset = "0x35A1570", VA = "0x1835A2D70")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps JAPCMFIAMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35A2CF0", Offset = "0x35A14F0", VA = "0x1835A2CF0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BDAEHLANNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1008680", Offset = "0x1006E80", VA = "0x181008680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1008690", Offset = "0x1006E90", VA = "0x181008690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ACFABFAOFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B284D0", Offset = "0x1B26CD0", VA = "0x181B284D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B287B0", Offset = "0x1B26FB0", VA = "0x181B287B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LKDNGOIDJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x35A4C50", Offset = "0x35A3450", VA = "0x1835A4C50")]
	public AHIAICAPCPJ(TDeps AGOMFIAFNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x35A44A0", Offset = "0x35A2CA0", VA = "0x1835A44A0")]
	public Task<ENHODGJKDIF<object, HFHKAILBFCH>> MJEEMDEKOJK(TRoot KLOAHFNCDKG, TNetSys IFMJMOHOLCJ, DDFBADMIKFJ<TMActor> ANKECHDDAPB, TAction POMIBLHGGHJ, bool LEINELKJOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x35A3CC0", Offset = "0x35A24C0", VA = "0x1835A3CC0")]
	[AsyncStateMachine(typeof(global::AHIAICAPCPJ<, , , , , , , , , >.EAKONOGKJOL))]
	private Task<ENHODGJKDIF<object, HFHKAILBFCH>> MJEEMDEKOJK(TRoot KLOAHFNCDKG, DDFBADMIKFJ<TMActor> ANKECHDDAPB, TAction POMIBLHGGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x35A3100", Offset = "0x35A1900", VA = "0x1835A3100")]
	[AsyncStateMachine(typeof(global::AHIAICAPCPJ<, , , , , , , , , >.MABPGDHFIKP))]
	private Task<ENHODGJKDIF<object, HFHKAILBFCH>> IIKMCBFAIJA(TRoot KLOAHFNCDKG, DDFBADMIKFJ<TMActor> ANKECHDDAPB, TAction[] NOHMOHNCMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35A3B50", Offset = "0x35A2350", VA = "0x1835A3B50")]
	[AsyncStateMachine(typeof(global::AHIAICAPCPJ<, , , , , , , , , >.PPFEECMGAEL))]
	public Task<ENHODGJKDIF<object, HFHKAILBFCH>> LNEDEOJBDEM(TRoot KLOAHFNCDKG, TNetSys BJACCIOOOJG, TReceiver PFENHEANOBF, DDFBADMIKFJ<TMActor> ANKECHDDAPB, DDFBADMIKFJ<TMRequest> JFMEGIGPCCP, TAction POMIBLHGGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35A2DF0", Offset = "0x35A15F0", VA = "0x1835A2DF0")]
	[AsyncStateMachine(typeof(global::AHIAICAPCPJ<, , , , , , , , , >.KMGBDLCOONL))]
	private Task<ENHODGJKDIF<object, HFHKAILBFCH>> COBEKMJGIMB(TRoot KLOAHFNCDKG, TNetSys BJACCIOOOJG, TReceiver PFENHEANOBF, DDFBADMIKFJ<TMActor> ANKECHDDAPB, DDFBADMIKFJ<TMRequest> JFMEGIGPCCP, TAction POMIBLHGGHJ, Task EGMDDGJJLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35A4840", Offset = "0x35A3040", VA = "0x1835A4840")]
	[AsyncStateMachine(typeof(global::AHIAICAPCPJ<, , , , , , , , , >.CFKMDINCPAC))]
	private Task OMDHHGBNHEH(TRoot KLOAHFNCDKG, TNetSys BJACCIOOOJG, TReceiver PFENHEANOBF, TAction POMIBLHGGHJ, CKEBEHHBLLM MDDBJIFKGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x35A33C0", Offset = "0x35A1BC0", VA = "0x1835A33C0")]
	private void KMNCLIHMOAL(TRoot KLOAHFNCDKG, TNetSys BJACCIOOOJG, TReceiver PFENHEANOBF, DDFBADMIKFJ<TMActor> ANKECHDDAPB, TAction POMIBLHGGHJ, bool EHDJFGCMDIA, bool FGLAFKAMNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DGJEGJENEGF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface NOOEAODELNO<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JFPHFLIOLLB(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MINOCBBJJHC(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HCDKIDCLDKE(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PDLBJJJNAGD(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] PGGMFCCKKCK(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ, int CMPNOOLEHEM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MLNMBJEOGDB(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EIDGPNNCKGP(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KPODDABDEEH(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CJGIDEHHIIJ(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HEPLMMFIBJF(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IKCCMOMNPPI(TNetSys FCEDLNJHNBH, TAction POMIBLHGGHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NDEEKMLKPBD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps HCJOLJIHAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps JAPCMFIAMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps OPDKAHJHHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JCAJICDFIBN<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DDFBADMIKFJ<TMActor> ELGBGONBJEG(TReceiver PFENHEANOBF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<ENHODGJKDIF<object, HFHKAILBFCH>> LNEDEOJBDEM(TReceiver PFENHEANOBF, TAction POMIBLHGGHJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] NMBLNOCEMFO(TReceiver PFENHEANOBF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CBLNEGPOMCF<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LOIJNOLEOEC(TRoot KLOAHFNCDKG);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NCHHPOCBEIO(TRoot KLOAHFNCDKG);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GPCDKDHJOLG(TRoot KLOAHFNCDKG);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int IBFFDILHFCO(TRoot KLOAHFNCDKG);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GDCHOLLPJGB(TRoot KLOAHFNCDKG);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task MJEEMDEKOJK(TRoot KLOAHFNCDKG, DDFBADMIKFJ<TMActor> ANKECHDDAPB, DDFBADMIKFJ<TMRequest> JFMEGIGPCCP, TAction POMIBLHGGHJ, bool FGMIJIBKECP = true);
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

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
public struct LLIPKPBCPLI<TPartialAction, TFullAction, TDeps> where TDeps : PKAIMHODDCO.HAEGCKHILNE<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] HMOHPOHLEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int MCJANFDJMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PHADKJKPPMM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3237700", Offset = "0x3236500", VA = "0x183237700")]
	internal LLIPKPBCPLI(TPartialAction[] KFJPLKDFHJB, int GNHNKFPCDDI, TDeps DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3237650", Offset = "0x3236450", VA = "0x183237650")]
	public static LLIPKPBCPLI<TPartialAction, TFullAction, TDeps> KJKFMOENPNA(TDeps DNHMNAAINOD)
	{
		return default(LLIPKPBCPLI<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PKAIMHODDCO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface HAEGCKHILNE<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NOPDJDDPBDG([In] TPartialAction EAIOLMFLELM);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction EKFLGFEDBDN(TPartialAction[] ILBNIEAOPFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x286AE00", Offset = "0x2869C00", VA = "0x18286AE00")]
	public static OPMELBICLMG<TFullAction> AOGIILPEGBH<TFullAction, TPartialAction, TDeps>(this LLIPKPBCPLI<TPartialAction, TFullAction, TDeps> CNFBJPGPBBJ, TPartialAction EAIOLMFLELM) where TDeps : HAEGCKHILNE<TPartialAction, TFullAction>
	{
		return default(OPMELBICLMG<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EEILBGBOGBI<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : JEFICHODDCG.MHIHLOLKPCI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] MJPGHHMIMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FJHKLDJAFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps PHADKJKPPMM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32376B0", Offset = "0x32364B0", VA = "0x1832376B0")]
	internal EEILBGBOGBI(TPartialSnapshot[] DFELGGMNHLO, int MDEIDAFFPEI, TDeps DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32375E0", Offset = "0x32363E0", VA = "0x1832375E0")]
	public static EEILBGBOGBI<TPartialSnapshot, TFullSnapshot, TDeps> KJKFMOENPNA(TDeps DNHMNAAINOD)
	{
		return default(EEILBGBOGBI<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JEFICHODDCG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MHIHLOLKPCI<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AMAPEHNFPKI([In] TPartialSnapshot ACOBJJDLFLM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot FDJJMEFHKLE(TPartialSnapshot[] KJBCBNAMOBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27591C0", Offset = "0x2757FC0", VA = "0x1827591C0")]
	public static OPMELBICLMG<TFullSnapshot> AOGIILPEGBH<TFullSnapshot, TPartialSnapshot, TDeps>(this EEILBGBOGBI<TPartialSnapshot, TFullSnapshot, TDeps> CNFBJPGPBBJ, TPartialSnapshot ACOBJJDLFLM) where TDeps : MHIHLOLKPCI<TPartialSnapshot, TFullSnapshot>
	{
		return default(OPMELBICLMG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2759460", Offset = "0x2758260", VA = "0x182759460")]
	public static bool EAPCPKKPIAL<TPartialSnapshot, TFullSnapshot, TDeps>(this EEILBGBOGBI<TPartialSnapshot, TFullSnapshot, TDeps> CNFBJPGPBBJ, TPartialSnapshot ACOBJJDLFLM) where TDeps : MHIHLOLKPCI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class NFDCCANJOPJ : AGGGGDAGIKE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D95100", Offset = "0x1D93F00", VA = "0x181D95100", Slot = "7")]
	public override string EMIBBFOKDML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D95130", Offset = "0x1D93F30", VA = "0x181D95130")]
	public NFDCCANJOPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : EIHKPAGLLNA.JLPNDCOHBJC<TAction, TNetSys> where TReceiverDeps : EIHKPAGLLNA.ECNBCHMOLIL<TMActor, TAction, TReceiver> where TRootDeps : EIHKPAGLLNA.GAHCPAAJKJD<TMRequest, TMActor, TAction, TRoot> where TDeps : EIHKPAGLLNA.LNCOFEJOBDB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface CIHEECLDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BNEHJHFACBH([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LNMIIMCDJFL();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FBEPHKHKLJE<object, BEPKJMJJJMM> ONEPAMEPHGM();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OOLMDOCJPHM(Exception PIJHOBKPGID);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class DMPNCNAGCDI : CIHEECLDPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> PNNIACGPGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<FBEPHKHKLJE<object, LNKCFDGMPAP>> GDEJNMCFNJK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4F4F230", Offset = "0x4F4E030", VA = "0x184F4F230")]
		private DMPNCNAGCDI(TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> NEJMAEGMNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x36BB580", Offset = "0x36BA380", VA = "0x1836BB580")]
		public static DMPNCNAGCDI KJKFMOENPNA(TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> NEJMAEGMNEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4F4ED50", Offset = "0x4F4DB50", VA = "0x184F4ED50")]
		public void BNEHJHFACBH([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4F4EE50", Offset = "0x4F4DC50", VA = "0x184F4EE50", Slot = "5")]
		public void LNMIIMCDJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4F4F0C0", Offset = "0x4F4DEC0", VA = "0x184F4F0C0", Slot = "6")]
		public FBEPHKHKLJE<object, BEPKJMJJJMM> ONEPAMEPHGM()
		{
			return default(FBEPHKHKLJE<object, BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4F4F170", Offset = "0x4F4DF70", VA = "0x184F4F170", Slot = "7")]
		public void OOLMDOCJPHM(Exception PIJHOBKPGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x323B970", Offset = "0x323A770", VA = "0x18323B970", Slot = "4")]
		private void MGDHOJGONEJ([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class LJBEGABDEPC : CIHEECLDPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> PNNIACGPGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private FBEPHKHKLJE<object, BEPKJMJJJMM> PCPBBODAONI;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
		private LJBEGABDEPC(TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> NEJMAEGMNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x36BB580", Offset = "0x36BA380", VA = "0x1836BB580")]
		public static LJBEGABDEPC KJKFMOENPNA(TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> NEJMAEGMNEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x36735E0", Offset = "0x36723E0", VA = "0x1836735E0")]
		public void BNEHJHFACBH([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF7230", Offset = "0x3BF6030", VA = "0x183BF7230", Slot = "5")]
		public void LNMIIMCDJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00", Slot = "6")]
		public FBEPHKHKLJE<object, BEPKJMJJJMM> ONEPAMEPHGM()
		{
			return default(FBEPHKHKLJE<object, BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF72F0", Offset = "0x3BF60F0", VA = "0x183BF72F0", Slot = "7")]
		public void OOLMDOCJPHM(Exception PIJHOBKPGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x323B970", Offset = "0x323A770", VA = "0x18323B970", Slot = "4")]
		private void MGDHOJGONEJ([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class ANMOFNOGCJO : CIHEECLDPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<FBEPHKHKLJE<object, BEPKJMJJJMM>> GDEJNMCFNJK;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3739240", Offset = "0x3738040", VA = "0x183739240")]
		private ANMOFNOGCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x323B8B0", Offset = "0x323A6B0", VA = "0x18323B8B0")]
		public static ANMOFNOGCJO KJKFMOENPNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3738F80", Offset = "0x3737D80", VA = "0x183738F80")]
		public void BNEHJHFACBH([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void LNMIIMCDJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37390B0", Offset = "0x3737EB0", VA = "0x1837390B0", Slot = "6")]
		public FBEPHKHKLJE<object, BEPKJMJJJMM> ONEPAMEPHGM()
		{
			return default(FBEPHKHKLJE<object, BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3739110", Offset = "0x3737F10", VA = "0x183739110", Slot = "7")]
		[MFKPHBEGHNM("This may be terminal and should probably do more than discarding the exception.")]
		public void OOLMDOCJPHM(Exception PIJHOBKPGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x323B970", Offset = "0x323A770", VA = "0x18323B970", Slot = "4")]
		private void MGDHOJGONEJ([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class EGAPPNHBBOO : CIHEECLDPHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FBEPHKHKLJE<object, BEPKJMJJJMM> PCPBBODAONI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private EGAPPNHBBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x323B8B0", Offset = "0x323A6B0", VA = "0x18323B8B0")]
		public static EGAPPNHBBOO KJKFMOENPNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x148C700", Offset = "0x148B500", VA = "0x18148C700")]
		public void BNEHJHFACBH([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void LNMIIMCDJFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440", Slot = "6")]
		public FBEPHKHKLJE<object, BEPKJMJJJMM> ONEPAMEPHGM()
		{
			return default(FBEPHKHKLJE<object, BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x323B990", Offset = "0x323A790", VA = "0x18323B990", Slot = "7")]
		[MFKPHBEGHNM("This may be terminal and should probably do more than discarding the exception.")]
		public void OOLMDOCJPHM(Exception PIJHOBKPGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x323B970", Offset = "0x323A770", VA = "0x18323B970", Slot = "4")]
		private void MGDHOJGONEJ([In] FBEPHKHKLJE<object, BEPKJMJJJMM> BGCCPJGDEGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NEIDFPILBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HIGDJMOGOKB<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E630B0", Offset = "0x3E61EB0", VA = "0x183E630B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E63B60", Offset = "0x3E62960", VA = "0x183E63B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HKNFNDDABAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HIGDJMOGOKB<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x37A8200", Offset = "0x37A7000", VA = "0x1837A8200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37A8AF0", Offset = "0x37A78F0", VA = "0x1837A8AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct COKNCNMLPLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HIGDJMOGOKB<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public HIGDJMOGOKB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FD40", Offset = "0x4A5EB40", VA = "0x184A5FD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4A603F0", Offset = "0x4A5F1F0", VA = "0x184A603F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CABMINBJIBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HIGDJMOGOKB<TMActor> senderId;

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
		public HIGDJMOGOKB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private CIHEECLDPHB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4975930", Offset = "0x4974730", VA = "0x184975930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4976560", Offset = "0x4975360", VA = "0x184976560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ADNAOCMCMKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::EAPGJOMMBBA<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public CIHEECLDPHB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CIHEECLDPHB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3670B00", Offset = "0x366F900", VA = "0x183670B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36728B0", Offset = "0x36716B0", VA = "0x1836728B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps PHADKJKPPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<HIGDJMOGOKB<TMRequest>, TaskCompletionSource<FBEPHKHKLJE<object, BEPKJMJJJMM>>> POCHMBCCCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GHAMJMIFDJK<TMRequest> PKJMKAIIOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int DAFHJEHIJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task BIHICDADODK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LOIPLCCKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x321D7E0", Offset = "0x321C5E0", VA = "0x18321D7E0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps OMHPEKOEPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x321DED0", Offset = "0x321CCD0", VA = "0x18321DED0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HNCGJMIGGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x321D4B0", Offset = "0x321C2B0", VA = "0x18321D4B0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HIBIMOHNFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD390A0", Offset = "0xD37EA0", VA = "0x180D390A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1124B80", Offset = "0x1123980", VA = "0x181124B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GJHOPNNNBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD38170", Offset = "0xD36F70", VA = "0x180D38170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C6A360", Offset = "0x1C69160", VA = "0x181C6A360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BCFMFCMFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E00", Offset = "0x7B2C00", VA = "0x1807B3E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x321ECF0", Offset = "0x321DAF0", VA = "0x18321ECF0")]
	public EAPGJOMMBBA(TDeps DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x321E710", Offset = "0x321D510", VA = "0x18321E710")]
	public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> PDCOEDCDPKH(TRoot ADCDJFADKCK, TNetSys KLOCDIDNDGI, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, TAction ENHEBPDFNME, bool JEBBEOLHMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x321EA30", Offset = "0x321D830", VA = "0x18321EA30")]
	[AsyncStateMachine(typeof(global::EAPGJOMMBBA<, , , , , , , , , >.NEIDFPILBOF))]
	private Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> PDCOEDCDPKH(TRoot ADCDJFADKCK, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, TAction ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x321CF00", Offset = "0x321BD00", VA = "0x18321CF00")]
	[AsyncStateMachine(typeof(global::EAPGJOMMBBA<, , , , , , , , , >.HKNFNDDABAP))]
	private Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> BNFNCDLHEIJ(TRoot ADCDJFADKCK, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, TAction[] IDENKDINEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x321D1C0", Offset = "0x321BFC0", VA = "0x18321D1C0")]
	[AsyncStateMachine(typeof(global::EAPGJOMMBBA<, , , , , , , , , >.COKNCNMLPLN))]
	public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> DCICANPEFKC(TRoot ADCDJFADKCK, TNetSys OPCBKILNAMH, TReceiver KKEOLOLGJJJ, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, HIGDJMOGOKB<TMRequest> LOBIOCHCPEE, TAction ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x321E0E0", Offset = "0x321CEE0", VA = "0x18321E0E0")]
	[AsyncStateMachine(typeof(global::EAPGJOMMBBA<, , , , , , , , , >.CABMINBJIBF))]
	private Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> OIMFKAJCLGG(TRoot ADCDJFADKCK, TNetSys OPCBKILNAMH, TReceiver KKEOLOLGJJJ, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, HIGDJMOGOKB<TMRequest> LOBIOCHCPEE, TAction ENHEBPDFNME, Task AFAILOJJGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x321D690", Offset = "0x321C490", VA = "0x18321D690")]
	[AsyncStateMachine(typeof(global::EAPGJOMMBBA<, , , , , , , , , >.ADNAOCMCMKB))]
	private Task GEOPNPHKNMP(TRoot ADCDJFADKCK, TNetSys OPCBKILNAMH, TReceiver KKEOLOLGJJJ, TAction ENHEBPDFNME, CIHEECLDPHB GCPBGIIBICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x321DBF0", Offset = "0x321C9F0", VA = "0x18321DBF0")]
	private void NLALMKPCBIG(TRoot ADCDJFADKCK, TNetSys OPCBKILNAMH, TReceiver KKEOLOLGJJJ, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, TAction ENHEBPDFNME, bool JBDEBCPDNFB, bool LEMJKJLGHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EIHKPAGLLNA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface JLPNDCOHBJC<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OFEJEBIOLGL(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JANGOONHHML(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DOGAAPLKLMF(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HLMIPHGIKEB(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BCMNPIONNHK(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME, int BCEIOMIMEGF);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DKPBGHDBCCE(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GOCFJMGOJPP(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EGNOCJNJOEK(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool INDOAAOCEPK(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FPOGCOIBPOC(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EAKBFDNMPOA(TNetSys OCMODBFFHKK, TAction ENHEBPDFNME);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface LNCOFEJOBDB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LOIPLCCKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HNCGJMIGGNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps OMHPEKOEPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ECNBCHMOLIL<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HIGDJMOGOKB<TMActor> AGJKOHOLKPN(TReceiver KKEOLOLGJJJ);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> DCICANPEFKC(TReceiver KKEOLOLGJJJ, TAction ENHEBPDFNME);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] EKIPGNNFKFC(TReceiver KKEOLOLGJJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GAHCPAAJKJD<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MGBGIAEDOHF(TRoot ADCDJFADKCK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EJDLOGENKLB(TRoot ADCDJFADKCK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LOCDLBJNBJI(TRoot ADCDJFADKCK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DCNPDCGBPEJ(TRoot ADCDJFADKCK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MLINACCPCAF(TRoot ADCDJFADKCK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task PDCOEDCDPKH(TRoot ADCDJFADKCK, HIGDJMOGOKB<TMActor> NGBMJIKJPPO, HIGDJMOGOKB<TMRequest> LOBIOCHCPEE, TAction ENHEBPDFNME, bool PFAFHKGNBMB = true);
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

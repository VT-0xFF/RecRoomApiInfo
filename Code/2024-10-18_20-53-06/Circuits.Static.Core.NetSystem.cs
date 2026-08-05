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
public struct CBAIEIGKPCP<TPartialAction, TFullAction, TDeps> where TDeps : GPBPGJCPKOO.GAIIFKOKBCE<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] EJPHNOKMINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int FHGEOMBNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5233330", Offset = "0x5232730", VA = "0x185233330")]
	internal CBAIEIGKPCP(TPartialAction[] BIEJLOBMGFA, int DAFIEHNAMMK, TDeps CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52332D0", Offset = "0x52326D0", VA = "0x1852332D0")]
	public static CBAIEIGKPCP<TPartialAction, TFullAction, TDeps> AHLALEPNKFA(TDeps CLOGBAKPPIL)
	{
		return default(CBAIEIGKPCP<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GPBPGJCPKOO
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface GAIIFKOKBCE<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AGGECPHIGGG([In] TPartialAction GNDDBJBMHHD);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction OHCMCDMKKBP(TPartialAction[] AJHFECKAAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A240", Offset = "0x2E69640", VA = "0x182E6A240")]
	public static EAJEDGEMDCE<TFullAction> ACFMPKAPKOO<TFullAction, TPartialAction, TDeps>(this CBAIEIGKPCP<TPartialAction, TFullAction, TDeps> MCPMOAEEEOJ, TPartialAction GNDDBJBMHHD) where TDeps : GAIIFKOKBCE<TPartialAction, TFullAction>
	{
		return default(EAJEDGEMDCE<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BELAPMCBOKP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LEMJDLOICAM.OKLIKLBMCDI<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] IBNBAAADCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int BADHBGLNJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5233330", Offset = "0x5232730", VA = "0x185233330")]
	internal BELAPMCBOKP(TPartialSnapshot[] GBNCDGNMKAG, int AJGFNICNJCM, TDeps CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x52332D0", Offset = "0x52326D0", VA = "0x1852332D0")]
	public static BELAPMCBOKP<TPartialSnapshot, TFullSnapshot, TDeps> AHLALEPNKFA(TDeps CLOGBAKPPIL)
	{
		return default(BELAPMCBOKP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LEMJDLOICAM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OKLIKLBMCDI<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ONEIGPCHNNA([In] TPartialSnapshot HAABFCKEKOG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot MKDCOGBPKLN(TPartialSnapshot[] BOJJJFHFAMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F040B0", Offset = "0x2F034B0", VA = "0x182F040B0")]
	public static EAJEDGEMDCE<TFullSnapshot> ACFMPKAPKOO<TFullSnapshot, TPartialSnapshot, TDeps>(this BELAPMCBOKP<TPartialSnapshot, TFullSnapshot, TDeps> MCPMOAEEEOJ, TPartialSnapshot HAABFCKEKOG) where TDeps : OKLIKLBMCDI<TPartialSnapshot, TFullSnapshot>
	{
		return default(EAJEDGEMDCE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2F04230", Offset = "0x2F03630", VA = "0x182F04230")]
	public static bool BANLIBLDGPE<TPartialSnapshot, TFullSnapshot, TDeps>(this BELAPMCBOKP<TPartialSnapshot, TFullSnapshot, TDeps> MCPMOAEEEOJ, TPartialSnapshot HAABFCKEKOG) where TDeps : OKLIKLBMCDI<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HLMHOOJHEHK : JLINDJLDKOH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2244760", Offset = "0x2243B60", VA = "0x182244760", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2244790", Offset = "0x2243B90", VA = "0x182244790")]
	public HLMHOOJHEHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : NIKOONMOAJF.ICNHBGLMIHJ<TAction, TNetSys> where TReceiverDeps : NIKOONMOAJF.APKLBBFFAHB<TAction, TReceiver> where TRootDeps : NIKOONMOAJF.EGKEDKLKHDM<TMRequest, TAction, TRoot> where TDeps : NIKOONMOAJF.ELCNMFNPKMH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface JNIBDAGFEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OEOHFNAAGPL([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MNGGKCNDEDM();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LMFFMMPMNDB<object, FOPCNMINEGF> FOAKEJNBKMO();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FOENDCKJLGH(Exception DMFMNMKKLLI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class KAENFCAFCDN : JNIBDAGFEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> ODNDMNBDGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<LMFFMMPMNDB<object, HGFLKMEKLGL>> IHJKIPONAOK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x44F79E0", Offset = "0x44F6DE0", VA = "0x1844F79E0")]
		private KAENFCAFCDN(TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> HLBKIOANHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x44F7240", Offset = "0x44F6640", VA = "0x1844F7240")]
		public static KAENFCAFCDN AHLALEPNKFA(TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> HLBKIOANHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44F7820", Offset = "0x44F6C20", VA = "0x1844F7820")]
		public void OEOHFNAAGPL([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x44F7540", Offset = "0x44F6940", VA = "0x1844F7540", Slot = "5")]
		public void MNGGKCNDEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x44F7320", Offset = "0x44F6720", VA = "0x1844F7320", Slot = "6")]
		public LMFFMMPMNDB<object, FOPCNMINEGF> FOAKEJNBKMO()
		{
			return default(LMFFMMPMNDB<object, FOPCNMINEGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44F7480", Offset = "0x44F6880", VA = "0x1844F7480", Slot = "7")]
		public void FOENDCKJLGH(Exception DMFMNMKKLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x40918E0", Offset = "0x4090CE0", VA = "0x1840918E0", Slot = "4")]
		private void ACLPAAFMGLD([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class MLDNENKMBLF : JNIBDAGFEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> ODNDMNBDGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LMFFMMPMNDB<object, FOPCNMINEGF> CGJJDKIIBMM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
		private MLDNENKMBLF(TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> HLBKIOANHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x44F7240", Offset = "0x44F6640", VA = "0x1844F7240")]
		public static MLDNENKMBLF AHLALEPNKFA(TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> HLBKIOANHNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x441E2C0", Offset = "0x441D6C0", VA = "0x18441E2C0")]
		public void OEOHFNAAGPL([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4815DE0", Offset = "0x48151E0", VA = "0x184815DE0", Slot = "5")]
		public void MNGGKCNDEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9220B0", Offset = "0x9214B0", VA = "0x1809220B0", Slot = "6")]
		public LMFFMMPMNDB<object, FOPCNMINEGF> FOAKEJNBKMO()
		{
			return default(LMFFMMPMNDB<object, FOPCNMINEGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4815D80", Offset = "0x4815180", VA = "0x184815D80", Slot = "7")]
		public void FOENDCKJLGH(Exception DMFMNMKKLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40918E0", Offset = "0x4090CE0", VA = "0x1840918E0", Slot = "4")]
		private void ACLPAAFMGLD([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class GFGDLDDLPFF : JNIBDAGFEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<LMFFMMPMNDB<object, FOPCNMINEGF>> IHJKIPONAOK;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4091D10", Offset = "0x4091110", VA = "0x184091D10")]
		private GFGDLDDLPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4091920", Offset = "0x4090D20", VA = "0x184091920")]
		public static GFGDLDDLPFF AHLALEPNKFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4091B50", Offset = "0x4090F50", VA = "0x184091B50")]
		public void OEOHFNAAGPL([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void MNGGKCNDEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4091A50", Offset = "0x4090E50", VA = "0x184091A50", Slot = "6")]
		public LMFFMMPMNDB<object, FOPCNMINEGF> FOAKEJNBKMO()
		{
			return default(LMFFMMPMNDB<object, FOPCNMINEGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4091AB0", Offset = "0x4090EB0", VA = "0x184091AB0", Slot = "7")]
		[ALGEIKMJAHG("This may be terminal and should probably do more than discarding the exception.")]
		public void FOENDCKJLGH(Exception DMFMNMKKLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x40918E0", Offset = "0x4090CE0", VA = "0x1840918E0", Slot = "4")]
		private void ACLPAAFMGLD([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class NNIDICEBNBO : JNIBDAGFEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LMFFMMPMNDB<object, FOPCNMINEGF> CGJJDKIIBMM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		private NNIDICEBNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4091920", Offset = "0x4090D20", VA = "0x184091920")]
		public static NNIDICEBNBO AHLALEPNKFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1BD5CF0", Offset = "0x1BD50F0", VA = "0x181BD5CF0")]
		public void OEOHFNAAGPL([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void MNGGKCNDEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260", Slot = "6")]
		public LMFFMMPMNDB<object, FOPCNMINEGF> FOAKEJNBKMO()
		{
			return default(LMFFMMPMNDB<object, FOPCNMINEGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4910400", Offset = "0x490F800", VA = "0x184910400", Slot = "7")]
		[ALGEIKMJAHG("This may be terminal and should probably do more than discarding the exception.")]
		public void FOENDCKJLGH(Exception DMFMNMKKLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40918E0", Offset = "0x4090CE0", VA = "0x1840918E0", Slot = "4")]
		private void ACLPAAFMGLD([In] LMFFMMPMNDB<object, FOPCNMINEGF> IPNDOKDOGDG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JEFEGEKLIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MIEEFIOIIBN<ANIPNONNBFB> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44153E0", Offset = "0x44147E0", VA = "0x1844153E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4415E90", Offset = "0x4415290", VA = "0x184415E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CMLKLEIMMFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MIEEFIOIIBN<ANIPNONNBFB> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5A75510", Offset = "0x5A74910", VA = "0x185A75510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5A75E80", Offset = "0x5A75280", VA = "0x185A75E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BLBOHCNEACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public MIEEFIOIIBN<ANIPNONNBFB> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MIEEFIOIIBN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5274EA0", Offset = "0x52742A0", VA = "0x185274EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5275570", Offset = "0x5274970", VA = "0x185275570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NAGHFHDGEDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<LMFFMMPMNDB<object, FOPCNMINEGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public MIEEFIOIIBN<ANIPNONNBFB> senderId;

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
		public MIEEFIOIIBN<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JNIBDAGFEOP <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48B39D0", Offset = "0x48B2DD0", VA = "0x1848B39D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x48B4670", Offset = "0x48B3A70", VA = "0x1848B4670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct BCBEFOKNEEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public KGEBABLNADM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JNIBDAGFEOP completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JNIBDAGFEOP <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<LMFFMMPMNDB<object, FOPCNMINEGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5224240", Offset = "0x5223640", VA = "0x185224240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5228270", Offset = "0x5227670", VA = "0x185228270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<MIEEFIOIIBN<TMRequest>, TaskCompletionSource<LMFFMMPMNDB<object, FOPCNMINEGF>>> LDAIPBEMIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KFFFFCMBIDA<TMRequest> EHLPIJKBDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int PCOJEBJBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task BLIICGNLIBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps NLPCBCNPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4503150", Offset = "0x4502550", VA = "0x184503150")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps DGGMOKPDJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x45031D0", Offset = "0x45025D0", VA = "0x1845031D0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps CPDGMKEEMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4504360", Offset = "0x4503760", VA = "0x184504360")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HEJOBDJFJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xBE34E0", Offset = "0xBE28E0", VA = "0x180BE34E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x18183C0", Offset = "0x18177C0", VA = "0x1818183C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BFKJKFLEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x123E310", Offset = "0x123D710", VA = "0x18123E310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x20E9F70", Offset = "0x20E9370", VA = "0x1820E9F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EIEHKBPFDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A30", Offset = "0x8A7E30", VA = "0x1808A8A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4505230", Offset = "0x4504630", VA = "0x184505230")]
	public KGEBABLNADM(TDeps CLOGBAKPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4503920", Offset = "0x4502D20", VA = "0x184503920")]
	public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> GBHBCFEKDOP(TRoot KCFGMPGPMFA, TNetSys FPBGAOLOPAP, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, TAction HJOAJFDFEDM, bool BFNNDCCPMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4504200", Offset = "0x4503600", VA = "0x184504200")]
	[AsyncStateMachine(typeof(KGEBABLNADM<, , , , , , , , >.JEFEGEKLIAC))]
	private Task<LMFFMMPMNDB<object, FOPCNMINEGF>> GBHBCFEKDOP(TRoot KCFGMPGPMFA, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, TAction HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4504F40", Offset = "0x4504340", VA = "0x184504F40")]
	[AsyncStateMachine(typeof(KGEBABLNADM<, , , , , , , , >.CMLKLEIMMFC))]
	private Task<LMFFMMPMNDB<object, FOPCNMINEGF>> KGPHAHOJFPI(TRoot KCFGMPGPMFA, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, TAction[] DKIHKOGIAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4504AF0", Offset = "0x4503EF0", VA = "0x184504AF0")]
	[AsyncStateMachine(typeof(KGEBABLNADM<, , , , , , , , >.BLBOHCNEACE))]
	public Task<LMFFMMPMNDB<object, FOPCNMINEGF>> KCNNBCILLCB(TRoot KCFGMPGPMFA, TNetSys IOKBFHEHLFA, TReceiver JEMODPNNLCP, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, MIEEFIOIIBN<TMRequest> HGKHECLJGIA, TAction HJOAJFDFEDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4503640", Offset = "0x4502A40", VA = "0x184503640")]
	[AsyncStateMachine(typeof(KGEBABLNADM<, , , , , , , , >.NAGHFHDGEDD))]
	private Task<LMFFMMPMNDB<object, FOPCNMINEGF>> FCGMDMLINMJ(TRoot KCFGMPGPMFA, TNetSys IOKBFHEHLFA, TReceiver JEMODPNNLCP, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, MIEEFIOIIBN<TMRequest> HGKHECLJGIA, TAction HJOAJFDFEDM, Task IAEKKGAPPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4503200", Offset = "0x4502600", VA = "0x184503200")]
	[AsyncStateMachine(typeof(KGEBABLNADM<, , , , , , , , >.BCBEFOKNEEN))]
	private Task EGFLBOKPOJA(TRoot KCFGMPGPMFA, TNetSys IOKBFHEHLFA, TReceiver JEMODPNNLCP, TAction HJOAJFDFEDM, JNIBDAGFEOP HEMMPGNHCBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45043E0", Offset = "0x45037E0", VA = "0x1845043E0")]
	private void KBIIOPLENJH(TRoot KCFGMPGPMFA, TNetSys IOKBFHEHLFA, TReceiver JEMODPNNLCP, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, TAction HJOAJFDFEDM, bool BOAPOCLMNGF, bool IHMDKMLIGEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NIKOONMOAJF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ICNHBGLMIHJ<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NEOMMKEBKEC(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction JGOOEELCIFP(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction IGLCKKGFCED(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> LDBIJEMNHHL(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] ECONEAMDMKC(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM, int DHFMLFCFGAK);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NEDMOBGJPLL(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CILFHPFLMDF(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HCIALIIDAEI(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DPEOMGLALMG(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MIFPKEDGIFN(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool PHFOJINJPPA(TNetSys FPEPFKAIIIG, TAction HJOAJFDFEDM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ELCNMFNPKMH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps NLPCBCNPCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps CPDGMKEEMLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps DGGMOKPDJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface APKLBBFFAHB<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MIEEFIOIIBN<ANIPNONNBFB> FBMPALHGHIN(TReceiver JEMODPNNLCP);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LMFFMMPMNDB<object, FOPCNMINEGF>> KCNNBCILLCB(TReceiver JEMODPNNLCP, TAction HJOAJFDFEDM);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HFPKONJACIJ(TReceiver JEMODPNNLCP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EGKEDKLKHDM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HJCLGDEAKFJ(TRoot KCFGMPGPMFA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HBNJGJIHCHC(TRoot KCFGMPGPMFA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BPGHHALNKKP(TRoot KCFGMPGPMFA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ICAKOMDINHD(TRoot KCFGMPGPMFA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PBKNIDJNJNO(TRoot KCFGMPGPMFA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task GBHBCFEKDOP(TRoot KCFGMPGPMFA, MIEEFIOIIBN<ANIPNONNBFB> GBMMGNPMANI, MIEEFIOIIBN<TMRequest> HGKHECLJGIA, TAction HJOAJFDFEDM, bool GEFHCGIJGEE = true);
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

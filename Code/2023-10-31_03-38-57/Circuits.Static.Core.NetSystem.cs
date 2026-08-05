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
public struct IPHOJHGKIJN<TPartialAction, TFullAction, TDeps> where TDeps : IFIFEMDCIPB.ONHHKAOEFOG<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] NPPILCMNLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int NGJMCAFJPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps CKJHGMFLIJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E30", Offset = "0x33D9230", VA = "0x1833D9E30")]
	internal IPHOJHGKIJN(TPartialAction[] IAJALCPKFCB, int OIMHBIKPBHP, TDeps PGFIMHKNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x33D9DD0", Offset = "0x33D91D0", VA = "0x1833D9DD0")]
	public static IPHOJHGKIJN<TPartialAction, TFullAction, TDeps> LJCGEPFBFCG(TDeps PGFIMHKNEFE)
	{
		return default(IPHOJHGKIJN<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IFIFEMDCIPB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ONHHKAOEFOG<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BANBJEPDIFP([In] TPartialAction PEACBGIHHOO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction HIJLGLMBHCK(TPartialAction[] ALDBFOINMGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23CF130", Offset = "0x23CE530", VA = "0x1823CF130")]
	public static GBADDJOKMAC<TFullAction> ADLCGHJMIHN<TFullAction, TPartialAction, TDeps>(this IPHOJHGKIJN<TPartialAction, TFullAction, TDeps> LDMHFMNLDHG, TPartialAction PEACBGIHHOO) where TDeps : ONHHKAOEFOG<TPartialAction, TFullAction>
	{
		return default(GBADDJOKMAC<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FIFNEDCEDEM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CALMLOFLDMH.JDDLJBPMMPA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] EFLMMLMCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int JOAEJENHCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps CKJHGMFLIJD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x33D9E30", Offset = "0x33D9230", VA = "0x1833D9E30")]
	internal FIFNEDCEDEM(TPartialSnapshot[] KODEHIBJNKD, int PHJNNJCGCAG, TDeps PGFIMHKNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x33D9DD0", Offset = "0x33D91D0", VA = "0x1833D9DD0")]
	public static FIFNEDCEDEM<TPartialSnapshot, TFullSnapshot, TDeps> LJCGEPFBFCG(TDeps PGFIMHKNEFE)
	{
		return default(FIFNEDCEDEM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CALMLOFLDMH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JDDLJBPMMPA<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NKGJFPPCEHC([In] TPartialSnapshot NFMBNOJOOMJ);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot GONAANEPCLF(TPartialSnapshot[] AODGBFFBMCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2201270", Offset = "0x2200670", VA = "0x182201270")]
	public static GBADDJOKMAC<TFullSnapshot> ADLCGHJMIHN<TFullSnapshot, TPartialSnapshot, TDeps>(this FIFNEDCEDEM<TPartialSnapshot, TFullSnapshot, TDeps> LDMHFMNLDHG, TPartialSnapshot NFMBNOJOOMJ) where TDeps : JDDLJBPMMPA<TPartialSnapshot, TFullSnapshot>
	{
		return default(GBADDJOKMAC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2201620", Offset = "0x2200A20", VA = "0x182201620")]
	public static bool GEDHLJNKNFO<TPartialSnapshot, TFullSnapshot, TDeps>(this FIFNEDCEDEM<TPartialSnapshot, TFullSnapshot, TDeps> LDMHFMNLDHG, TPartialSnapshot NFMBNOJOOMJ) where TDeps : JDDLJBPMMPA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GCLPIJPELOB : ECGJNMBGCNE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C67960", Offset = "0x1C66D60", VA = "0x181C67960", Slot = "7")]
	public override string NKDBAIBOPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C67990", Offset = "0x1C66D90", VA = "0x181C67990")]
	public GCLPIJPELOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BNELHMHMPOP.DICGDEEHBPC<TAction, TNetSys> where TReceiverDeps : BNELHMHMPOP.HBNLLALNGAF<TMActor, TAction, TReceiver> where TRootDeps : BNELHMHMPOP.AJMPCMBIGGC<TMRequest, TMActor, TAction, TRoot> where TDeps : BNELHMHMPOP.BBJCCMGICLI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface AFEGOEKLEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BKKJEPCPAFL([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KOMINMMAECN();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KJFLOMPEKGD<object, FILGPPIJBDI> JKEOJEOIOGL();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EENOGHPGEGO(Exception APLJIBADEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class HDECGKDFMCN : AFEGOEKLEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> ANGIOMIOHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<KJFLOMPEKGD<object, LPKMENFOOAC>> POILMDCCCDI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x35357E0", Offset = "0x3534BE0", VA = "0x1835357E0")]
		private HDECGKDFMCN(TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> OAONCJDELIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x303D150", Offset = "0x303C550", VA = "0x18303D150")]
		public static HDECGKDFMCN LJCGEPFBFCG(TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> OAONCJDELIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3535160", Offset = "0x3534560", VA = "0x183535160")]
		public void BKKJEPCPAFL([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3535660", Offset = "0x3534A60", VA = "0x183535660", Slot = "5")]
		public void KOMINMMAECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3535420", Offset = "0x3534820", VA = "0x183535420", Slot = "6")]
		public KJFLOMPEKGD<object, FILGPPIJBDI> JKEOJEOIOGL()
		{
			return default(KJFLOMPEKGD<object, FILGPPIJBDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3535360", Offset = "0x3534760", VA = "0x183535360", Slot = "7")]
		public void EENOGHPGEGO(Exception APLJIBADEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3501130", Offset = "0x3500530", VA = "0x183501130", Slot = "4")]
		private void LKIJJNKODPE([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class OCEACNGGIOP : AFEGOEKLEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> ANGIOMIOHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KJFLOMPEKGD<object, FILGPPIJBDI> IKIMFFFGOMB;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
		private OCEACNGGIOP(TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> OAONCJDELIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x303D150", Offset = "0x303C550", VA = "0x18303D150")]
		public static OCEACNGGIOP LJCGEPFBFCG(TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> OAONCJDELIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x34A46D0", Offset = "0x34A3AD0", VA = "0x1834A46D0")]
		public void BKKJEPCPAFL([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CDDAA0", Offset = "0x3CDCEA0", VA = "0x183CDDAA0", Slot = "5")]
		public void KOMINMMAECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320", Slot = "6")]
		public KJFLOMPEKGD<object, FILGPPIJBDI> JKEOJEOIOGL()
		{
			return default(KJFLOMPEKGD<object, FILGPPIJBDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CDD9E0", Offset = "0x3CDCDE0", VA = "0x183CDD9E0", Slot = "7")]
		public void EENOGHPGEGO(Exception APLJIBADEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3501130", Offset = "0x3500530", VA = "0x183501130", Slot = "4")]
		private void LKIJJNKODPE([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class CGGDNPPNIJN : AFEGOEKLEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<KJFLOMPEKGD<object, FILGPPIJBDI>> POILMDCCCDI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4ABD970", Offset = "0x4ABCD70", VA = "0x184ABD970")]
		private CGGDNPPNIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3501070", Offset = "0x3500470", VA = "0x183501070")]
		public static CGGDNPPNIJN LJCGEPFBFCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4ABD7E0", Offset = "0x4ABCBE0", VA = "0x184ABD7E0")]
		public void BKKJEPCPAFL([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void KOMINMMAECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4ABD8B0", Offset = "0x4ABCCB0", VA = "0x184ABD8B0", Slot = "6")]
		public KJFLOMPEKGD<object, FILGPPIJBDI> JKEOJEOIOGL()
		{
			return default(KJFLOMPEKGD<object, FILGPPIJBDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		public void EENOGHPGEGO(Exception APLJIBADEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3501130", Offset = "0x3500530", VA = "0x183501130", Slot = "4")]
		private void LKIJJNKODPE([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GOPOFFNLDAD : AFEGOEKLEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KJFLOMPEKGD<object, FILGPPIJBDI> IKIMFFFGOMB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		private GOPOFFNLDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3501070", Offset = "0x3500470", VA = "0x183501070")]
		public static GOPOFFNLDAD LJCGEPFBFCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3501050", Offset = "0x3500450", VA = "0x183501050")]
		public void BKKJEPCPAFL([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void KOMINMMAECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400", Slot = "6")]
		public KJFLOMPEKGD<object, FILGPPIJBDI> JKEOJEOIOGL()
		{
			return default(KJFLOMPEKGD<object, FILGPPIJBDI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		public void EENOGHPGEGO(Exception APLJIBADEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3501130", Offset = "0x3500530", VA = "0x183501130", Slot = "4")]
		private void LKIJJNKODPE([In] KJFLOMPEKGD<object, FILGPPIJBDI> KNLODAPAGGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JKNABMFCMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<KJFLOMPEKGD<object, FILGPPIJBDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public LGLECKELCKH<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<KJFLOMPEKGD<object, FILGPPIJBDI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3859760", Offset = "0x3858B60", VA = "0x183859760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3859CA0", Offset = "0x38590A0", VA = "0x183859CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CIEKBKALPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<KJFLOMPEKGD<object, FILGPPIJBDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LGLECKELCKH<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<KJFLOMPEKGD<object, FILGPPIJBDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4ADBCF0", Offset = "0x4ADB0F0", VA = "0x184ADBCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4ADC5E0", Offset = "0x4ADB9E0", VA = "0x184ADC5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct KIDCNALBKLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<KJFLOMPEKGD<object, FILGPPIJBDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public LGLECKELCKH<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public LGLECKELCKH<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<KJFLOMPEKGD<object, FILGPPIJBDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38DEA20", Offset = "0x38DDE20", VA = "0x1838DEA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38DED80", Offset = "0x38DE180", VA = "0x1838DED80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BKMHLLLHHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<KJFLOMPEKGD<object, FILGPPIJBDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LGLECKELCKH<TMActor> senderId;

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
		public LGLECKELCKH<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AFEGOEKLEGF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x484C490", Offset = "0x484B890", VA = "0x18484C490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x484D0C0", Offset = "0x484C4C0", VA = "0x18484D0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ONFODDLOHOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::INCPCEBGKFN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AFEGOEKLEGF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AFEGOEKLEGF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<KJFLOMPEKGD<object, FILGPPIJBDI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D03C00", Offset = "0x3D03000", VA = "0x183D03C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D05950", Offset = "0x3D04D50", VA = "0x183D05950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps CKJHGMFLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<LGLECKELCKH<TMRequest>, TaskCompletionSource<KJFLOMPEKGD<object, FILGPPIJBDI>>> KLPMJFCJEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EGDIIDBJOPO<TMRequest> MCNHNNPKIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EANKPFJCMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task MDKLHJJDOEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LELDENNIHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x368CFF0", Offset = "0x368C3F0", VA = "0x18368CFF0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EIGAHLGIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x368CF70", Offset = "0x368C370", VA = "0x18368CF70")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps CKEINHNNLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x368CEF0", Offset = "0x368C2F0", VA = "0x18368CEF0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NNMOCAFNDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1026DB0", Offset = "0x10261B0", VA = "0x181026DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1026DC0", Offset = "0x10261C0", VA = "0x181026DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HEOECOIPDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B53180", Offset = "0x1B52580", VA = "0x181B53180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B53460", Offset = "0x1B52860", VA = "0x181B53460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HHFLLGOLLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x766ED0", Offset = "0x7662D0", VA = "0x180766ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x368DE80", Offset = "0x368D280", VA = "0x18368DE80")]
	public INCPCEBGKFN(TDeps PGFIMHKNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x368D590", Offset = "0x368C990", VA = "0x18368D590")]
	public Task<KJFLOMPEKGD<object, FILGPPIJBDI>> NPHMKDJMKEM(TRoot OGEFIHKILIO, TNetSys ALFBJALGOAK, LGLECKELCKH<TMActor> LGLKDKGOADO, TAction GMCEKENFDDF, bool IFFHAOOICGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x368D8B0", Offset = "0x368CCB0", VA = "0x18368D8B0")]
	[AsyncStateMachine(typeof(global::INCPCEBGKFN<, , , , , , , , , >.JKNABMFCMBI))]
	private Task<KJFLOMPEKGD<object, FILGPPIJBDI>> NPHMKDJMKEM(TRoot OGEFIHKILIO, LGLECKELCKH<TMActor> LGLKDKGOADO, TAction GMCEKENFDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x368C330", Offset = "0x368B730", VA = "0x18368C330")]
	[AsyncStateMachine(typeof(global::INCPCEBGKFN<, , , , , , , , , >.CIEKBKALPFF))]
	private Task<KJFLOMPEKGD<object, FILGPPIJBDI>> BGIHBCPLIMC(TRoot OGEFIHKILIO, LGLECKELCKH<TMActor> LGLKDKGOADO, TAction[] BPBMPAAJLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x368C770", Offset = "0x368BB70", VA = "0x18368C770")]
	[AsyncStateMachine(typeof(global::INCPCEBGKFN<, , , , , , , , , >.KIDCNALBKLJ))]
	public Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HHNHAHAPEKG(TRoot OGEFIHKILIO, TNetSys GKCOBAHFNOK, TReceiver CEICCLOGOBN, LGLECKELCKH<TMActor> LGLKDKGOADO, LGLECKELCKH<TMRequest> IJDIEEMOCHO, TAction GMCEKENFDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x368DD00", Offset = "0x368D100", VA = "0x18368DD00")]
	[AsyncStateMachine(typeof(global::INCPCEBGKFN<, , , , , , , , , >.BKMHLLLHHCI))]
	private Task<KJFLOMPEKGD<object, FILGPPIJBDI>> OIPADJFDDMP(TRoot OGEFIHKILIO, TNetSys GKCOBAHFNOK, TReceiver CEICCLOGOBN, LGLECKELCKH<TMActor> LGLKDKGOADO, LGLECKELCKH<TMRequest> IJDIEEMOCHO, TAction GMCEKENFDDF, Task PCDGOKINMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x368C1E0", Offset = "0x368B5E0", VA = "0x18368C1E0")]
	[AsyncStateMachine(typeof(global::INCPCEBGKFN<, , , , , , , , , >.ONFODDLOHOB))]
	private Task BBCLGGPBKHJ(TRoot OGEFIHKILIO, TNetSys GKCOBAHFNOK, TReceiver CEICCLOGOBN, TAction GMCEKENFDDF, AFEGOEKLEGF LEBLLFBPNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x368CC50", Offset = "0x368C050", VA = "0x18368CC50")]
	private void JACBCLGODDN(TRoot OGEFIHKILIO, TNetSys GKCOBAHFNOK, TReceiver CEICCLOGOBN, LGLECKELCKH<TMActor> LGLKDKGOADO, TAction GMCEKENFDDF, bool KMILJCDLLBC, bool CCPAKJMMBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BNELHMHMPOP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DICGDEEHBPC<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EANIDHOAAOF(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction KAKGGHIKOBA(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction LNIAIFGKPPD(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ELMJCKBGIKP(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] NAMLAAHFMAH(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF, int ANPOGHHNKIA);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MKOKAMJIJDK(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DCGAAOPMCFE(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GGIFHGLKMMH(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool NILLMFFFEJK(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ADNADNNPMBN(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GDEBHEIEDCC(TNetSys GLHKMBBOAML, TAction GMCEKENFDDF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BBJCCMGICLI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LELDENNIHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps CKEINHNNLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EIGAHLGIDHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HBNLLALNGAF<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LGLECKELCKH<TMActor> ADEHPIPIBLO(TReceiver CEICCLOGOBN);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KJFLOMPEKGD<object, FILGPPIJBDI>> HHNHAHAPEKG(TReceiver CEICCLOGOBN, TAction GMCEKENFDDF);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LOMMAHNGPHF(TReceiver CEICCLOGOBN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface AJMPCMBIGGC<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DADAKJJBBAB(TRoot OGEFIHKILIO);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DAACIJHBJFP(TRoot OGEFIHKILIO);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int IDHCGOPEDBL(TRoot OGEFIHKILIO);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int APDLAGOEEMH(TRoot OGEFIHKILIO);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BIHEHDOHICJ(TRoot OGEFIHKILIO);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task NPHMKDJMKEM(TRoot OGEFIHKILIO, LGLECKELCKH<TMActor> LGLKDKGOADO, LGLECKELCKH<TMRequest> IJDIEEMOCHO, TAction GMCEKENFDDF, bool KJMDKAFMBHO = true);
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

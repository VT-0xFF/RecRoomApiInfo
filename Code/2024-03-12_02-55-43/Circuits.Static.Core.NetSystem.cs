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
public struct FLPFBEBLEAM<TPartialAction, TFullAction, TDeps> where TDeps : PIKGCDFDGJH.LIBDEDBELGC<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] CMJFMKMGGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PMPMGNIEBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps CCPNGOJFLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3654F20", Offset = "0x3654120", VA = "0x183654F20")]
	internal FLPFBEBLEAM(TPartialAction[] GBPAALLANEI, int DLHJGCEACPG, TDeps ECDJFINNJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3654E70", Offset = "0x3654070", VA = "0x183654E70")]
	public static FLPFBEBLEAM<TPartialAction, TFullAction, TDeps> GOMGEEBODDD(TDeps ECDJFINNJIE)
	{
		return default(FLPFBEBLEAM<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PIKGCDFDGJH
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LIBDEDBELGC<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BPMOHKEBPCE([In] TPartialAction FMJAMFMABFO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JDMDMDEAMFC(TPartialAction[] AJLCLDLIAKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28F6650", Offset = "0x28F5850", VA = "0x1828F6650")]
	public static CKBGFGHPBIC<TFullAction> EJNBFDNPMIC<TFullAction, TPartialAction, TDeps>(this FLPFBEBLEAM<TPartialAction, TFullAction, TDeps> KPBGCHDNDLM, TPartialAction FMJAMFMABFO) where TDeps : LIBDEDBELGC<TPartialAction, TFullAction>
	{
		return default(CKBGFGHPBIC<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IOGAOHEMBEF<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : ADDBHHMMMCO.AFHDNLBNPII<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] CCBAFBFLGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int PKKABJCDMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps CCPNGOJFLHJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3654F20", Offset = "0x3654120", VA = "0x183654F20")]
	internal IOGAOHEMBEF(TPartialSnapshot[] INKDMHAFEAD, int PBKMFJMGOLB, TDeps ECDJFINNJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3654E70", Offset = "0x3654070", VA = "0x183654E70")]
	public static IOGAOHEMBEF<TPartialSnapshot, TFullSnapshot, TDeps> GOMGEEBODDD(TDeps ECDJFINNJIE)
	{
		return default(IOGAOHEMBEF<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ADDBHHMMMCO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface AFHDNLBNPII<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HKCLPDEINJL([In] TPartialSnapshot CDNNJLDLIEI);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot DEBJMGHLPAA(TPartialSnapshot[] LJIBOAGGPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E040", Offset = "0x2D4D240", VA = "0x182D4E040")]
	public static CKBGFGHPBIC<TFullSnapshot> EJNBFDNPMIC<TFullSnapshot, TPartialSnapshot, TDeps>(this IOGAOHEMBEF<TPartialSnapshot, TFullSnapshot, TDeps> KPBGCHDNDLM, TPartialSnapshot CDNNJLDLIEI) where TDeps : AFHDNLBNPII<TPartialSnapshot, TFullSnapshot>
	{
		return default(CKBGFGHPBIC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D4DEF0", Offset = "0x2D4D0F0", VA = "0x182D4DEF0")]
	public static bool BMEJCHOBPMI<TPartialSnapshot, TFullSnapshot, TDeps>(this IOGAOHEMBEF<TPartialSnapshot, TFullSnapshot, TDeps> KPBGCHDNDLM, TPartialSnapshot CDNNJLDLIEI) where TDeps : AFHDNLBNPII<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IOEACOLFKNI : DLKKNPCBHBE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD06F0", Offset = "0x1DCF8F0", VA = "0x181DD06F0", Slot = "7")]
	public override string OKCJCMAJCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0720", Offset = "0x1DCF920", VA = "0x181DD0720")]
	public IOEACOLFKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HBOOKNPCBKB.OFADBMBLIMP<TAction, TNetSys> where TReceiverDeps : HBOOKNPCBKB.EHLOEBPABHB<TMActor, TAction, TReceiver> where TRootDeps : HBOOKNPCBKB.BHCPAJDMKFE<TMRequest, TMActor, TAction, TRoot> where TDeps : HBOOKNPCBKB.MIFDPELDPDO<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface JKPMNNMKMII
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NHNMCEAJGDK([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NNCHBADHCBF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BLNBDNPDEEM<object, NGDCAOKOLMO> LMPMNHOHJBJ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AOJBDNBLOKB(Exception PHKDDEHKOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class DJOEJBCDMLF : JKPMNNMKMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> FADJKCKNIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<BLNBDNPDEEM<object, CHOGLKODFOC>> KAPHMNGNEKG;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x507D1C0", Offset = "0x507C3C0", VA = "0x18507D1C0")]
		private DJOEJBCDMLF(TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> IAIONEHGECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3705230", Offset = "0x3704430", VA = "0x183705230")]
		public static DJOEJBCDMLF GOMGEEBODDD(TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> IAIONEHGECN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x507CF00", Offset = "0x507C100", VA = "0x18507CF00")]
		public void NHNMCEAJGDK([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x507D000", Offset = "0x507C200", VA = "0x18507D000", Slot = "5")]
		public void NNCHBADHCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x507CCA0", Offset = "0x507BEA0", VA = "0x18507CCA0", Slot = "6")]
		public BLNBDNPDEEM<object, NGDCAOKOLMO> LMPMNHOHJBJ()
		{
			return default(BLNBDNPDEEM<object, NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x507CBE0", Offset = "0x507BDE0", VA = "0x18507CBE0", Slot = "7")]
		public void AOJBDNBLOKB(Exception PHKDDEHKOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37682C0", Offset = "0x37674C0", VA = "0x1837682C0", Slot = "4")]
		private void AEBMFDIFCPA([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class KGCCEIIDLEH : JKPMNNMKMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> FADJKCKNIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BLNBDNPDEEM<object, NGDCAOKOLMO> MEPDKPCMMPJ;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
		private KGCCEIIDLEH(TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> IAIONEHGECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3705230", Offset = "0x3704430", VA = "0x183705230")]
		public static KGCCEIIDLEH GOMGEEBODDD(TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> IAIONEHGECN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x37246E0", Offset = "0x37238E0", VA = "0x1837246E0")]
		public void NHNMCEAJGDK([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C490", Offset = "0x3B5B690", VA = "0x183B5C490", Slot = "5")]
		public void NNCHBADHCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE2150", Offset = "0xAE1350", VA = "0x180AE2150", Slot = "6")]
		public BLNBDNPDEEM<object, NGDCAOKOLMO> LMPMNHOHJBJ()
		{
			return default(BLNBDNPDEEM<object, NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C430", Offset = "0x3B5B630", VA = "0x183B5C430", Slot = "7")]
		public void AOJBDNBLOKB(Exception PHKDDEHKOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37682C0", Offset = "0x37674C0", VA = "0x1837682C0", Slot = "4")]
		private void AEBMFDIFCPA([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class GPHHFKMODBH : JKPMNNMKMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<BLNBDNPDEEM<object, NGDCAOKOLMO>> KAPHMNGNEKG;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37686A0", Offset = "0x37678A0", VA = "0x1837686A0")]
		private GPHHFKMODBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3768380", Offset = "0x3767580", VA = "0x183768380")]
		public static GPHHFKMODBH GOMGEEBODDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37685D0", Offset = "0x37677D0", VA = "0x1837685D0")]
		public void NHNMCEAJGDK([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void NNCHBADHCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37684A0", Offset = "0x37676A0", VA = "0x1837684A0", Slot = "6")]
		public BLNBDNPDEEM<object, NGDCAOKOLMO> LMPMNHOHJBJ()
		{
			return default(BLNBDNPDEEM<object, NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37682E0", Offset = "0x37674E0", VA = "0x1837682E0", Slot = "7")]
		[MNMOIINOFAC("This may be terminal and should probably do more than discarding the exception.")]
		public void AOJBDNBLOKB(Exception PHKDDEHKOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37682C0", Offset = "0x37674C0", VA = "0x1837682C0", Slot = "4")]
		private void AEBMFDIFCPA([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DCGADDHCMAC : JKPMNNMKMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BLNBDNPDEEM<object, NGDCAOKOLMO> MEPDKPCMMPJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		private DCGADDHCMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3768380", Offset = "0x3767580", VA = "0x183768380")]
		public static DCGADDHCMAC GOMGEEBODDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x15222A0", Offset = "0x15214A0", VA = "0x1815222A0")]
		public void NHNMCEAJGDK([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void NNCHBADHCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0", Slot = "6")]
		public BLNBDNPDEEM<object, NGDCAOKOLMO> LMPMNHOHJBJ()
		{
			return default(BLNBDNPDEEM<object, NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5064D00", Offset = "0x5063F00", VA = "0x185064D00", Slot = "7")]
		[MNMOIINOFAC("This may be terminal and should probably do more than discarding the exception.")]
		public void AOJBDNBLOKB(Exception PHKDDEHKOGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37682C0", Offset = "0x37674C0", VA = "0x1837682C0", Slot = "4")]
		private void AEBMFDIFCPA([In] BLNBDNPDEEM<object, NGDCAOKOLMO> JKJJELABMHK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EEIMAPDIBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IJMPLGOCAIG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x32AF430", Offset = "0x32AE630", VA = "0x1832AF430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x32AF9A0", Offset = "0x32AEBA0", VA = "0x1832AF9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CPLNICNPOKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IJMPLGOCAIG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4ACC760", Offset = "0x4ACB960", VA = "0x184ACC760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4ACCBA0", Offset = "0x4ACBDA0", VA = "0x184ACCBA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HOOMJJBBAEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public IJMPLGOCAIG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public IJMPLGOCAIG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3807020", Offset = "0x3806220", VA = "0x183807020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38073E0", Offset = "0x38065E0", VA = "0x1838073E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct PGHLDGHOAJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public IJMPLGOCAIG<TMActor> senderId;

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
		public IJMPLGOCAIG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JKPMNNMKMII <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4132350", Offset = "0x4131550", VA = "0x184132350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41330F0", Offset = "0x41322F0", VA = "0x1841330F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LACHACGGJEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::LLIFEAGHOKC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JKPMNNMKMII completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JKPMNNMKMII <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C025C0", Offset = "0x3C017C0", VA = "0x183C025C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C04590", Offset = "0x3C03790", VA = "0x183C04590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps CCPNGOJFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<IJMPLGOCAIG<TMRequest>, TaskCompletionSource<BLNBDNPDEEM<object, NGDCAOKOLMO>>> EIIFLHPJJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GFLGPHDCOPF<TMRequest> LHHEEAPEEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int HGOJEAFIHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task IJIMOJJJHIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps PIOPLCOKIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E8D0", Offset = "0x3C9DAD0", VA = "0x183C9E8D0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps KLOGOOCBEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DA60", Offset = "0x3C9CC60", VA = "0x183C9DA60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps OIGDGNOLBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E950", Offset = "0x3C9DB50", VA = "0x183C9E950")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KFOECJEEJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDCA810", Offset = "0xDC9A10", VA = "0x180DCA810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11BCB40", Offset = "0x11BBD40", VA = "0x1811BCB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CGPPCBGFOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDE1DF0", Offset = "0xDE0FF0", VA = "0x180DE1DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CA0A30", Offset = "0x1C9FC30", VA = "0x181CA0A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DMLDHCHGEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5B0", Offset = "0x7BE7B0", VA = "0x1807BF5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C9FA10", Offset = "0x3C9EC10", VA = "0x183C9FA10")]
	public LLIFEAGHOKC(TDeps ECDJFINNJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E220", Offset = "0x3C9D420", VA = "0x183C9E220")]
	public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> HLKHBEKMGDB(TRoot EAMCHADGEIB, TNetSys ELHBABNFJOD, IJMPLGOCAIG<TMActor> BLGJELAEOIB, TAction CEBHNDLCHED, bool CECOGGPIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C9E740", Offset = "0x3C9D940", VA = "0x183C9E740")]
	[AsyncStateMachine(typeof(global::LLIFEAGHOKC<, , , , , , , , , >.EEIMAPDIBBF))]
	private Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> HLKHBEKMGDB(TRoot EAMCHADGEIB, IJMPLGOCAIG<TMActor> BLGJELAEOIB, TAction CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DAE0", Offset = "0x3C9CCE0", VA = "0x183C9DAE0")]
	[AsyncStateMachine(typeof(global::LLIFEAGHOKC<, , , , , , , , , >.CPLNICNPOKC))]
	private Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> DJIJCHJNAGO(TRoot EAMCHADGEIB, IJMPLGOCAIG<TMActor> BLGJELAEOIB, TAction[] GEPECELMEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EE20", Offset = "0x3C9E020", VA = "0x183C9EE20")]
	[AsyncStateMachine(typeof(global::LLIFEAGHOKC<, , , , , , , , , >.HOOMJJBBAEL))]
	public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> OCDIAEAKAFO(TRoot EAMCHADGEIB, TNetSys FBCOKLFILGP, TReceiver CJEFKAMCPLH, IJMPLGOCAIG<TMActor> BLGJELAEOIB, IJMPLGOCAIG<TMRequest> APOANJNPLOP, TAction CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EB20", Offset = "0x3C9DD20", VA = "0x183C9EB20")]
	[AsyncStateMachine(typeof(global::LLIFEAGHOKC<, , , , , , , , , >.PGHLDGHOAJH))]
	private Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> NKAJEEMHHIA(TRoot EAMCHADGEIB, TNetSys FBCOKLFILGP, TReceiver CJEFKAMCPLH, IJMPLGOCAIG<TMActor> BLGJELAEOIB, IJMPLGOCAIG<TMRequest> APOANJNPLOP, TAction CEBHNDLCHED, Task APIBNEICNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EFA0", Offset = "0x3C9E1A0", VA = "0x183C9EFA0")]
	[AsyncStateMachine(typeof(global::LLIFEAGHOKC<, , , , , , , , , >.LACHACGGJEH))]
	private Task OHECKBNFPGO(TRoot EAMCHADGEIB, TNetSys FBCOKLFILGP, TReceiver CJEFKAMCPLH, TAction CEBHNDLCHED, JKPMNNMKMII IOGMPOBJEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F530", Offset = "0x3C9E730", VA = "0x183C9F530")]
	private void PIPFAOIHMLA(TRoot EAMCHADGEIB, TNetSys FBCOKLFILGP, TReceiver CJEFKAMCPLH, IJMPLGOCAIG<TMActor> BLGJELAEOIB, TAction CEBHNDLCHED, bool HBKHIEONMEG, bool PBCLJIBNLMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HBOOKNPCBKB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface OFADBMBLIMP<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JOKALODLPNF(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction DELJDJGAMAJ(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction KOEFONIFEGC(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HFMJOIOGGAB(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] PKKNOKKLNNF(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED, int MBAAJBKDENI);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ECIPFGIEPGM(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KHPIBMIJJLJ(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HLECOAOMNDP(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool MHIBOJHJMIA(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool LCCAFPEMDMO(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EIILNPONNIL(TNetSys DLMEIBGFBFB, TAction CEBHNDLCHED);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface MIFDPELDPDO<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps PIOPLCOKIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps OIGDGNOLBMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps KLOGOOCBEIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EHLOEBPABHB<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IJMPLGOCAIG<TMActor> DOMPLANOFHO(TReceiver CJEFKAMCPLH);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> OCDIAEAKAFO(TReceiver CJEFKAMCPLH, TAction CEBHNDLCHED);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LLOLPDDIHGL(TReceiver CJEFKAMCPLH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BHCPAJDMKFE<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OHFJLABFNDA(TRoot EAMCHADGEIB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JDGKJDLJPMF(TRoot EAMCHADGEIB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int PAADPHCHKDL(TRoot EAMCHADGEIB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int HJPAOAFJPEJ(TRoot EAMCHADGEIB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ODEKGBEKLJB(TRoot EAMCHADGEIB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task HLKHBEKMGDB(TRoot EAMCHADGEIB, IJMPLGOCAIG<TMActor> BLGJELAEOIB, IJMPLGOCAIG<TMRequest> APOANJNPLOP, TAction CEBHNDLCHED, bool GKDKGKMEALO = true);
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

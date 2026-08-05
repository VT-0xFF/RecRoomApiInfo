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
public struct BNPIKMMAJOO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : MJMEIPOBOGC.CHNCJDCNKNF<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] OOMDANENBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int GCPPMLOLBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GOBIMGKDLNH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20B9490", Offset = "0x20B8890", VA = "0x1820B9490")]
	internal BNPIKMMAJOO(TPartialSnapshot[] HAEFAANFHBF, int BFGLMFGGIKJ, TDeps AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x20B93C0", Offset = "0x20B87C0", VA = "0x1820B93C0")]
	public static global::BNPIKMMAJOO<TPartialSnapshot, TFullSnapshot, TDeps> GILBACJLDCL(TDeps AAKNFDLFILB)
	{
		return default(global::BNPIKMMAJOO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MJMEIPOBOGC
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface CHNCJDCNKNF<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PMHEDENKGFH(in TPartialSnapshot IJJBPPLAHAN);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot JCCDEIHGIOG(TPartialSnapshot[] LFOPEDHNCHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23CC960", Offset = "0x23CBD60", VA = "0x1823CC960")]
	public static global::DBEIBEIIMCM<TFullSnapshot> BIBGEDNNKEM<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::BNPIKMMAJOO<TPartialSnapshot, TFullSnapshot, TDeps> INHKNJBCCPD, TPartialSnapshot IJJBPPLAHAN) where TDeps : CHNCJDCNKNF<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::DBEIBEIIMCM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23CCCB0", Offset = "0x23CC0B0", VA = "0x1823CCCB0")]
	public static bool DHMBLENHFBH<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::BNPIKMMAJOO<TPartialSnapshot, TFullSnapshot, TDeps> INHKNJBCCPD, TPartialSnapshot IJJBPPLAHAN) where TDeps : CHNCJDCNKNF<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OLEDAFDHNKB : GGEPPPFEGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xCD6960", Offset = "0xCD5D60", VA = "0x180CD6960", Slot = "7")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xCD6990", Offset = "0xCD5D90", VA = "0x180CD6990")]
	public OLEDAFDHNKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JPDJBNKJMCH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PBCNENPJKDN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MNDCOKAFGGA(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction LFFJHFKLIAN(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction FHNFHBONFAB(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> KOOJLAHKMGO(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool FEBGOMHPABA(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ONBBCLFGDPP(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DFNOPCCAIOM(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GBGGELEILCE(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool APPGLMGPOJC(TNetSys BKDGMDFNOLF, TAction DAAMKALKLMO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface JCPMFJOBFCH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TActionDeps OFANBDMICLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		TReceiverDeps EJOFPOMCGGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TRootDeps BHFLIBMFJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CFGDEFHNCGE<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		global::BLPHOENPIDB<TMActor> EGHIKFINOFF(TReceiver ELFHKLDIPNL);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> APAFNGNGKIG(TReceiver ELFHKLDIPNL, TAction DAAMKALKLMO);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] APCMCHNICFL(TReceiver ELFHKLDIPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PJENHCBBMDD<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KMBKOIDLAMO(TRoot EAGPPNPHOBG);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CCPLFJEPBAE(TRoot EAGPPNPHOBG);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KCAEOGOLPJM(TRoot EAGPPNPHOBG);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void POFNNDBGBCF(TRoot EAGPPNPHOBG);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task CMHCFDHKLDM(TRoot EAGPPNPHOBG, global::BLPHOENPIDB<TMActor> EJDEEFFNGFA, global::BLPHOENPIDB<TMRequest> EAIJJIKGJEE, TAction DAAMKALKLMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NJMAFPGIFKO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JPDJBNKJMCH.PBCNENPJKDN<TAction, TNetSys> where TReceiverDeps : JPDJBNKJMCH.CFGDEFHNCGE<TMActor, TAction, TReceiver> where TRootDeps : JPDJBNKJMCH.PJENHCBBMDD<TMRequest, TMActor, TAction, TRoot> where TDeps : JPDJBNKJMCH.JCPMFJOBFCH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface GHAAFELEDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NBKDNIIPDFD(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NAOAMBHPHHE();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::LFBADEDAHHF<object, KIHHJLOCPGF> GCCHLCKJBAN();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BNDDHJPPAFN(Exception MEIDENAJCEE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class MHFKBFIDPKM : GHAAFELEDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DAFNBDEOFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<global::LFBADEDAHHF<object, PAMMHIBIBOL>> MCBBNECFJNG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2B23B60", Offset = "0x2B22F60", VA = "0x182B23B60")]
		private MHFKBFIDPKM(TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DCNKOIIOILA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2237650", Offset = "0x2236A50", VA = "0x182237650")]
		public static MHFKBFIDPKM GILBACJLDCL(TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DCNKOIIOILA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2B23980", Offset = "0x2B22D80", VA = "0x182B23980")]
		public void NBKDNIIPDFD(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B237C0", Offset = "0x2B22BC0", VA = "0x182B237C0", Slot = "5")]
		public void NAOAMBHPHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B23660", Offset = "0x2B22A60", VA = "0x182B23660", Slot = "6")]
		public global::LFBADEDAHHF<object, KIHHJLOCPGF> GCCHLCKJBAN()
		{
			return default(global::LFBADEDAHHF<object, KIHHJLOCPGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B23570", Offset = "0x2B22970", VA = "0x182B23570", Slot = "7")]
		public void BNDDHJPPAFN(Exception MEIDENAJCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2B23630", Offset = "0x2B22A30", VA = "0x182B23630", Slot = "4")]
		private void FCIKOIOMDNG(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KKJMCEJKIJK : GHAAFELEDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DAFNBDEOFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private global::LFBADEDAHHF<object, KIHHJLOCPGF> JLPMGEICFKL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1622680", Offset = "0x1621A80", VA = "0x181622680")]
		private KKJMCEJKIJK(TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DCNKOIIOILA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2237650", Offset = "0x2236A50", VA = "0x182237650")]
		public static KKJMCEJKIJK GILBACJLDCL(TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>> DCNKOIIOILA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x26E3850", Offset = "0x26E2C50", VA = "0x1826E3850")]
		public void NBKDNIIPDFD(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3398C00", Offset = "0x3398000", VA = "0x183398C00", Slot = "5")]
		public void NAOAMBHPHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x735A00", Offset = "0x734E00", VA = "0x180735A00", Slot = "6")]
		public global::LFBADEDAHHF<object, KIHHJLOCPGF> GCCHLCKJBAN()
		{
			return default(global::LFBADEDAHHF<object, KIHHJLOCPGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3398B40", Offset = "0x3397F40", VA = "0x183398B40", Slot = "7")]
		public void BNDDHJPPAFN(Exception MEIDENAJCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B23630", Offset = "0x2B22A30", VA = "0x182B23630", Slot = "4")]
		private void FCIKOIOMDNG(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class DPMIAOMHHHB : GHAAFELEDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<global::LFBADEDAHHF<object, KIHHJLOCPGF>> MCBBNECFJNG;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x314FE20", Offset = "0x314F220", VA = "0x18314FE20")]
		private DPMIAOMHHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x314FCA0", Offset = "0x314F0A0", VA = "0x18314FCA0")]
		public static DPMIAOMHHHB GILBACJLDCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x314FDC0", Offset = "0x314F1C0", VA = "0x18314FDC0")]
		public void NBKDNIIPDFD(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void NAOAMBHPHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x314FC40", Offset = "0x314F040", VA = "0x18314FC40", Slot = "6")]
		public global::LFBADEDAHHF<object, KIHHJLOCPGF> GCCHLCKJBAN()
		{
			return default(global::LFBADEDAHHF<object, KIHHJLOCPGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		public void BNDDHJPPAFN(Exception MEIDENAJCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B23630", Offset = "0x2B22A30", VA = "0x182B23630", Slot = "4")]
		private void FCIKOIOMDNG(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class LADNGCDHEGB : GHAAFELEDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::LFBADEDAHHF<object, KIHHJLOCPGF> JLPMGEICFKL;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xEBFBE0", Offset = "0xEBEFE0", VA = "0x180EBFBE0")]
		private LADNGCDHEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x314FCA0", Offset = "0x314F0A0", VA = "0x18314FCA0")]
		public static LADNGCDHEGB GILBACJLDCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x19B0DD0", Offset = "0x19B01D0", VA = "0x1819B0DD0")]
		public void NBKDNIIPDFD(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		public void NAOAMBHPHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9F0", Offset = "0xA3DDF0", VA = "0x180A3E9F0", Slot = "6")]
		public global::LFBADEDAHHF<object, KIHHJLOCPGF> GCCHLCKJBAN()
		{
			return default(global::LFBADEDAHHF<object, KIHHJLOCPGF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "7")]
		public void BNDDHJPPAFN(Exception MEIDENAJCEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2B23630", Offset = "0x2B22A30", VA = "0x182B23630", Slot = "4")]
		private void FCIKOIOMDNG(in global::LFBADEDAHHF<object, KIHHJLOCPGF> JGINNNKFHFP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CNAJOFOEECN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public global::NJMAFPGIFKO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::BLPHOENPIDB<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::BLPHOENPIDB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x259C120", Offset = "0x259B520", VA = "0x18259C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x259C460", Offset = "0x259B860", VA = "0x18259C460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct DIKHGMOLAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::NJMAFPGIFKO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::BLPHOENPIDB<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public global::BLPHOENPIDB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GHAAFELEDDM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x29AACC0", Offset = "0x29AA0C0", VA = "0x1829AACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x29AC400", Offset = "0x29AB800", VA = "0x1829AC400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FFIOBHCFLLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public global::NJMAFPGIFKO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GHAAFELEDDM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GHAAFELEDDM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x242E690", Offset = "0x242DA90", VA = "0x18242E690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct ALLMHHGCHJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task sendTask_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> tcsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x37026A0", Offset = "0x3701AA0", VA = "0x1837026A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x37028C0", Offset = "0x3701CC0", VA = "0x1837028C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly TDeps GOBIMGKDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<global::BLPHOENPIDB<TMRequest>, TaskCompletionSource<global::LFBADEDAHHF<object, KIHHJLOCPGF>>> NADKBEDFMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private global::GIHLNGAFBMK<TMRequest> IMHCACJANEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int CLNAPDNJKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task NOFABFEDMIA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TActionDeps OFANBDMICLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x349EDD0", Offset = "0x349E1D0", VA = "0x18349EDD0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private TRootDeps BHFLIBMFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x349EDD0", Offset = "0x349E1D0", VA = "0x18349EDD0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private TReceiverDeps EJOFPOMCGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x349EDD0", Offset = "0x349E1D0", VA = "0x18349EDD0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AHGNANOEDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CB0", Offset = "0x7D70B0", VA = "0x1807D7CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1771100", Offset = "0x1770500", VA = "0x181771100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BFOKMBIFHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x736B90", Offset = "0x735F90", VA = "0x180736B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x349FD80", Offset = "0x349F180", VA = "0x18349FD80")]
	public NJMAFPGIFKO(TDeps AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x349E760", Offset = "0x349DB60", VA = "0x18349E760")]
	public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> CMHCFDHKLDM(TRoot EAGPPNPHOBG, TNetSys IJEGDHBMMAI, global::BLPHOENPIDB<TMActor> EJDEEFFNGFA, TAction DAAMKALKLMO, bool JMJEEBADCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x349E5D0", Offset = "0x349D9D0", VA = "0x18349E5D0")]
	[AsyncStateMachine(typeof(global::NJMAFPGIFKO<, , , , , , , , , >.CNAJOFOEECN))]
	public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> APAFNGNGKIG(TRoot EAGPPNPHOBG, TNetSys FMNICCCPHDN, TReceiver ELFHKLDIPNL, global::BLPHOENPIDB<TMActor> EJDEEFFNGFA, global::BLPHOENPIDB<TMRequest> EAIJJIKGJEE, TAction DAAMKALKLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x349F7E0", Offset = "0x349EBE0", VA = "0x18349F7E0")]
	[AsyncStateMachine(typeof(global::NJMAFPGIFKO<, , , , , , , , , >.DIKHGMOLAIL))]
	private Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> NMMJIPEENFH(TRoot EAGPPNPHOBG, TNetSys FMNICCCPHDN, TReceiver ELFHKLDIPNL, global::BLPHOENPIDB<TMActor> EJDEEFFNGFA, global::BLPHOENPIDB<TMRequest> EAIJJIKGJEE, TAction DAAMKALKLMO, Task HPHFEGCMCLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x349F980", Offset = "0x349ED80", VA = "0x18349F980")]
	[AsyncStateMachine(typeof(global::NJMAFPGIFKO<, , , , , , , , , >.FFIOBHCFLLL))]
	private Task NPMOOJIBJCM(TRoot EAGPPNPHOBG, TNetSys FMNICCCPHDN, TReceiver ELFHKLDIPNL, TAction DAAMKALKLMO, GHAAFELEDDM NAKKIHHGCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x349F120", Offset = "0x349E520", VA = "0x18349F120")]
	private void HKANHDBOPHE(TRoot EAGPPNPHOBG, TNetSys FMNICCCPHDN, TReceiver ELFHKLDIPNL, global::BLPHOENPIDB<TMActor> EJDEEFFNGFA, TAction DAAMKALKLMO, bool BJCPBLLFPNP, bool DKIFEPCAEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x349F310", Offset = "0x349E710", VA = "0x18349F310")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(global::NJMAFPGIFKO<, , , , , , , , , >.ALLMHHGCHJH))]
	internal static Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> IIJDHJDNDAB(Task MPLFLKLBGGM, Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> PKCDJEJDLDB)
	{
		return null;
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

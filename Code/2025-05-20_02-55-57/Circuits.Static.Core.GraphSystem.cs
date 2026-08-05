using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27E2400", Offset = "0x27E1600", VA = "0x1827E2400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IAHMOLGLNLG : IEnumerator<CAHHBAHBJJE>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DHEEBEEFOLH<KLMHALNMEAA>.ENAECCMOOGC MAAMCMCOEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> JHIDFNKBEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE BPDPIAFECCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool GCHAEMKODBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CAHHBAHBJJE HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27DF880", Offset = "0x27DEA80", VA = "0x1827DF880", Slot = "4")]
		get
		{
			return default(CAHHBAHBJJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27DF7C0", Offset = "0x27DE9C0", VA = "0x1827DF7C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27DF810", Offset = "0x27DEA10", VA = "0x1827DF810")]
	internal IAHMOLGLNLG([In] DHEEBEEFOLH<KLMHALNMEAA>.ENAECCMOOGC LCOMGGHAAMG, [In] KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> LAJJGIDJJHM, [In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE OONOMPMIEOH, bool KNBHLCHNIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27DF5C0", Offset = "0x27DE7C0", VA = "0x1827DF5C0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x27DF780", Offset = "0x27DE980", VA = "0x1827DF780", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27DF550", Offset = "0x27DE750", VA = "0x1827DF550", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IABDJEAOBEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LEHBKJGNPOI ONILPOBLBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MNNOLNDILAM OHEOGGDLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LIKOAJLIPDC KNMNMIMFJFG;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27DF470", Offset = "0x27DE670", VA = "0x1827DF470")]
	internal IABDJEAOBEO([In] LEHBKJGNPOI ADHCKOGOIAC, [In] MNNOLNDILAM GNFKEPNJCEC, [In] LIKOAJLIPDC BJHIMBLJFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27DEE90", Offset = "0x27DE090", VA = "0x1827DEE90")]
	public static IABDJEAOBEO OIKMHICCLEP()
	{
		return default(IABDJEAOBEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27DCA40", Offset = "0x27DBC40", VA = "0x1827DCA40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27DC500", Offset = "0x27DB700", VA = "0x1827DC500")]
	public readonly CLKBMAMAHOE CEBCPPBDNIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27DE2C0", Offset = "0x27DD4C0", VA = "0x1827DE2C0")]
	public void LDNCKMPNPAH(JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27DF200", Offset = "0x27DE400", VA = "0x1827DF200")]
	public JFIBBLJIDCN<PFJDLPPNNBM> PAIFAAOAMKK(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27DECE0", Offset = "0x27DDEE0", VA = "0x1827DECE0")]
	public JFIBBLJIDCN<PKEJDDGKOJK> NPDOBOBOGMK()
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27DCA70", Offset = "0x27DBC70", VA = "0x1827DCA70")]
	public JFIBBLJIDCN<KLMHALNMEAA> EFJBNCPAHLK(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27DDE90", Offset = "0x27DD090", VA = "0x1827DDE90")]
	public readonly bool KMJELHIMPPE(JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27DE180", Offset = "0x27DD380", VA = "0x1827DE180")]
	public readonly MAIDBPOBJJB<CAHHBAHBJJE, IAHMOLGLNLG> LADALHJADCD()
	{
		return default(MAIDBPOBJJB<CAHHBAHBJJE, IAHMOLGLNLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27DF330", Offset = "0x27DE530", VA = "0x1827DF330")]
	public readonly IAHMOLGLNLG PLCHMDANMKH()
	{
		return default(IAHMOLGLNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27DCC60", Offset = "0x27DBE60", VA = "0x1827DCC60")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, DHEEBEEFOLH<PFJDLPPNNBM>.ENAECCMOOGC> EOCPKFCLKJM()
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, DHEEBEEFOLH<PFJDLPPNNBM>.ENAECCMOOGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27DDA90", Offset = "0x27DCC90", VA = "0x1827DDA90")]
	public readonly JFIBBLJIDCN<PFJDLPPNNBM> JMHIGMDNMNC(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED, int HIILHOHJDGC)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27DF3E0", Offset = "0x27DE5E0", VA = "0x1827DF3E0")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<FAIOCFLCPBP>, DIEDADNLJBK<FAIOCFLCPBP>> PLCHOLBBLLM(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<FAIOCFLCPBP>, DIEDADNLJBK<FAIOCFLCPBP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27DD170", Offset = "0x27DC370", VA = "0x1827DD170")]
	public readonly DIEDADNLJBK<FAIOCFLCPBP> GJIGLLMBBKI(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(DIEDADNLJBK<FAIOCFLCPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27DCB10", Offset = "0x27DBD10", VA = "0x1827DCB10")]
	public readonly JFIBBLJIDCN<PFJDLPPNNBM> EGMHMOKJIAL(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<FAIOCFLCPBP> HIILHOHJDGC)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27DC340", Offset = "0x27DB540", VA = "0x1827DC340")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, FNGMOIFMICG> AKJIFJOAJFL(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, FNGMOIFMICG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27DCCD0", Offset = "0x27DBED0", VA = "0x1827DCCD0")]
	public readonly FNGMOIFMICG EPAPPDFDBIH(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(FNGMOIFMICG);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x27DD2F0", Offset = "0x27DC4F0", VA = "0x1827DD2F0")]
	public readonly JKJCKGDOPOJ<JFIBBLJIDCN<PFJDLPPNNBM>, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE> HNFIMGGLLOJ(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(JKJCKGDOPOJ<JFIBBLJIDCN<PFJDLPPNNBM>, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27DEDE0", Offset = "0x27DDFE0", VA = "0x1827DEDE0")]
	public readonly PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE OBEFHKOJGGI(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x27DCBB0", Offset = "0x27DBDB0", VA = "0x1827DCBB0")]
	public readonly JKJCKGDOPOJ<JFIBBLJIDCN<PFJDLPPNNBM>, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE> ENEOHNEBEKG(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(JKJCKGDOPOJ<JFIBBLJIDCN<PFJDLPPNNBM>, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x27DDBA0", Offset = "0x27DCDA0", VA = "0x1827DDBA0")]
	public readonly PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE KCDIIDJGFIO(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27DC850", Offset = "0x27DBA50", VA = "0x1827DC850")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<PKEJDDGKOJK>, HICACOKIMFO> DLPGPNBIPGH(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<PKEJDDGKOJK>, HICACOKIMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD20", Offset = "0x27DCF20", VA = "0x1827DDD20")]
	public readonly HICACOKIMFO KKGCFECHNIG(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(HICACOKIMFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27DDE20", Offset = "0x27DD020", VA = "0x1827DDE20")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<PKEJDDGKOJK>, DHEEBEEFOLH<PKEJDDGKOJK>.ENAECCMOOGC> KMCMOLCDOBM()
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<PKEJDDGKOJK>, DHEEBEEFOLH<PKEJDDGKOJK>.ENAECCMOOGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27DE110", Offset = "0x27DD310", VA = "0x1827DE110")]
	public readonly DHEEBEEFOLH<PKEJDDGKOJK>.ENAECCMOOGC KPFAJGJEBDC()
	{
		return default(DHEEBEEFOLH<PKEJDDGKOJK>.ENAECCMOOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27DCFE0", Offset = "0x27DC1E0", VA = "0x1827DCFE0")]
	public readonly int GILLIDBBICA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27DE630", Offset = "0x27DD830", VA = "0x1827DE630")]
	public readonly int LLOEEDJNDIL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27DDCA0", Offset = "0x27DCEA0", VA = "0x1827DDCA0")]
	public readonly int KGENGACLIIF(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27DCE60", Offset = "0x27DC060", VA = "0x1827DCE60")]
	public readonly int GAIJBIPDDMA(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27DC4C0", Offset = "0x27DB6C0", VA = "0x1827DC4C0")]
	public readonly int CCIJOAAKIPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27DF2F0", Offset = "0x27DE4F0", VA = "0x1827DF2F0")]
	public readonly int PDPNFPLNLAH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27DD1D0", Offset = "0x27DC3D0", VA = "0x1827DD1D0")]
	public readonly int GPAIDNGOHAO(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27DD450", Offset = "0x27DC650", VA = "0x1827DD450")]
	public readonly int IOLPKOAIPIP(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27DE020", Offset = "0x27DD220", VA = "0x1827DE020")]
	public readonly JFIBBLJIDCN<KLMHALNMEAA> KMMBJFNOJNN(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD, int ACPHKIIOJAK)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27DC9B0", Offset = "0x27DBBB0", VA = "0x1827DC9B0")]
	public readonly MAIDBPOBJJB<JFIBBLJIDCN<EJFMCNHIBMC>, DIEDADNLJBK<EJFMCNHIBMC>> DOLCMEHLOHK(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<EJFMCNHIBMC>, DIEDADNLJBK<EJFMCNHIBMC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27DE890", Offset = "0x27DDA90", VA = "0x1827DE890")]
	public readonly DIEDADNLJBK<EJFMCNHIBMC> NAHAOOMJCCI(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(DIEDADNLJBK<EJFMCNHIBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x27DCDC0", Offset = "0x27DBFC0", VA = "0x1827DCDC0")]
	public readonly JFIBBLJIDCN<KLMHALNMEAA> FHIDLGLPGII(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<EJFMCNHIBMC> ACPHKIIOJAK)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27DD250", Offset = "0x27DC450", VA = "0x1827DD250")]
	public readonly JKJCKGDOPOJ<JFIBBLJIDCN<KLMHALNMEAA>, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE> HGHNKELPJOE(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(JKJCKGDOPOJ<JFIBBLJIDCN<KLMHALNMEAA>, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x27DC6B0", Offset = "0x27DB8B0", VA = "0x1827DC6B0")]
	public readonly PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE CGKLHPPJHFJ(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27DE670", Offset = "0x27DD870", VA = "0x1827DE670")]
	public readonly EJOJBDDLPNB MFACHBEBDPJ(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(EJOJBDDLPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x27DDB30", Offset = "0x27DCD30", VA = "0x1827DDB30")]
	public readonly DHEEBEEFOLH<KLMHALNMEAA>.ENAECCMOOGC JNPCGPNIBMK()
	{
		return default(DHEEBEEFOLH<KLMHALNMEAA>.ENAECCMOOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27DE760", Offset = "0x27DD960", VA = "0x1827DE760")]
	public readonly JKJCKGDOPOJ<JFIBBLJIDCN<KLMHALNMEAA>, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE> MGLFKJKLABJ(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(JKJCKGDOPOJ<JFIBBLJIDCN<KLMHALNMEAA>, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x27DD3A0", Offset = "0x27DC5A0", VA = "0x1827DD3A0")]
	public readonly PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE IKMGCMNABIM(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x27DE810", Offset = "0x27DDA10", VA = "0x1827DE810")]
	public readonly JFIBBLJIDCN<PKEJDDGKOJK> MOPDPFMCDGM(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27DC420", Offset = "0x27DB620", VA = "0x1827DC420")]
	public readonly JFIBBLJIDCN<PKEJDDGKOJK> BKBMFCJLEIE(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27DE0C0", Offset = "0x27DD2C0", VA = "0x1827DE0C0")]
	public readonly bool KOGAAEPHLJB(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27DE8F0", Offset = "0x27DDAF0", VA = "0x1827DE8F0")]
	public JFIBBLJIDCN<PFJDLPPNNBM> NHFFICLCOIN(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<FAIOCFLCPBP> HIILHOHJDGC)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27DE9B0", Offset = "0x27DDBB0", VA = "0x1827DE9B0")]
	public JFIBBLJIDCN<KLMHALNMEAA> NHGDMMGDLBB(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<EJFMCNHIBMC> ACPHKIIOJAK)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27DC4A0", Offset = "0x27DB6A0", VA = "0x1827DC4A0")]
	public readonly bool CAMINFNDBDH(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27DC400", Offset = "0x27DB600", VA = "0x1827DC400")]
	public readonly bool AOALNLBDLBF(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27DCEE0", Offset = "0x27DC0E0", VA = "0x1827DCEE0")]
	public void GGLAMBEPCKE(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<FAIOCFLCPBP> AGBNINMJKHA, JFIBBLJIDCN<FAIOCFLCPBP> MEGIFHDDCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27DC5B0", Offset = "0x27DB7B0", VA = "0x1827DC5B0")]
	public void CFEGJCJMKLP(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<EJFMCNHIBMC> LGKLODNELNM, JFIBBLJIDCN<EJFMCNHIBMC> JPENFMLNLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27DDC50", Offset = "0x27DCE50", VA = "0x1827DDC50")]
	public readonly bool KDKEAAHKIAC(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27DF2A0", Offset = "0x27DE4A0", VA = "0x1827DF2A0")]
	public readonly bool PDMPGNINLPG(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27DC750", Offset = "0x27DB950", VA = "0x1827DC750")]
	public void DGHPHIFCDNN(JFIBBLJIDCN<KLMHALNMEAA> KHHBPMLEJLG, JFIBBLJIDCN<PFJDLPPNNBM> FMIMEMJAMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27DEA70", Offset = "0x27DDC70", VA = "0x1827DEA70")]
	public void NNPFKBFFGAM(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27DD4D0", Offset = "0x27DC6D0", VA = "0x1827DD4D0")]
	public void JFJELMEFNHD(JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27DE3C0", Offset = "0x27DD5C0", VA = "0x1827DE3C0")]
	public void LIPFGLHJADE(JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class IFIMMFJHLKM
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static DHEEBEEFOLH<PFJDLPPNNBM> MLKPHKLKHHK([In] this IABDJEAOBEO CEENCLMGJAM)
	{
		return default(DHEEBEEFOLH<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x27DF920", Offset = "0x27DEB20", VA = "0x1827DF920")]
	public static DHEEBEEFOLH<KLMHALNMEAA> NLBNMFBPOJH([In] this IABDJEAOBEO CEENCLMGJAM)
	{
		return default(DHEEBEEFOLH<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x27DF910", Offset = "0x27DEB10", VA = "0x1827DF910")]
	public static DHEEBEEFOLH<PKEJDDGKOJK> EEIAMFEKEMM([In] this IABDJEAOBEO CEENCLMGJAM)
	{
		return default(DHEEBEEFOLH<PKEJDDGKOJK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct LEHBKJGNPOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public DHEEBEEFOLH<PFJDLPPNNBM> CNIDAMELIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<PKEJDDGKOJK>> NGEKJCOPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public KGAPBMDBEOB<PFJDLPPNNBM, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> MJMFHHNIGAH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27E1020", Offset = "0x27E0220", VA = "0x1827E1020")]
	public LEHBKJGNPOI([In] DHEEBEEFOLH<PFJDLPPNNBM> GOFHHJFDBCC, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<PKEJDDGKOJK>> BJHIMBLJFFE, [In] KGAPBMDBEOB<PFJDLPPNNBM, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> GNFKEPNJCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x27E0E80", Offset = "0x27E0080", VA = "0x1827E0E80")]
	public static LEHBKJGNPOI OIKMHICCLEP()
	{
		return default(LEHBKJGNPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x27E0AA0", Offset = "0x27DFCA0", VA = "0x1827E0AA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x27E07F0", Offset = "0x27DF9F0", VA = "0x1827E07F0")]
	public readonly IODGKPICJDF CEBCPPBDNIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x27E0F60", Offset = "0x27E0160", VA = "0x1827E0F60")]
	public JFIBBLJIDCN<PFJDLPPNNBM> OPFHKGILNAI(JFIBBLJIDCN<PKEJDDGKOJK> GCEDHPINDAM)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27E0C40", Offset = "0x27DFE40", VA = "0x1827E0C40")]
	public void EFCGIOJACBM(JFIBBLJIDCN<PFJDLPPNNBM> MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27E0D20", Offset = "0x27DFF20", VA = "0x1827E0D20")]
	[CompilerGenerated]
	internal static BBFEBPPKAMH NJADPOJKHJB([In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FNGMOIFMICG : IEnumerator<JFIBBLJIDCN<PFJDLPPNNBM>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE MAAMCMCOEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE DDJLCAABFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> GPJKMHDMFKG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JFIBBLJIDCN<PFJDLPPNNBM> HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x27DBEE0", Offset = "0x27DB0E0", VA = "0x1827DBEE0", Slot = "4")]
		get
		{
			return default(JFIBBLJIDCN<PFJDLPPNNBM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x27DBE70", Offset = "0x27DB070", VA = "0x1827DBE70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27DBBD0", Offset = "0x27DADD0", VA = "0x1827DBBD0")]
	internal FNGMOIFMICG([In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE LCOMGGHAAMG, [In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE CPPNICAHEMI, [In] KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> KKPCALOIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27DBCD0", Offset = "0x27DAED0", VA = "0x1827DBCD0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27DBE10", Offset = "0x27DB010", VA = "0x1827DBE10", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27DBC70", Offset = "0x27DAE70", VA = "0x1827DBC70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct LIKOAJLIPDC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public DHEEBEEFOLH<PKEJDDGKOJK> CNIDAMELIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KGAPBMDBEOB<PKEJDDGKOJK, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> JNHHIFHAOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public KGAPBMDBEOB<PKEJDDGKOJK, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> MJMFHHNIGAH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1020", Offset = "0x27E0220", VA = "0x1827E1020")]
	public LIKOAJLIPDC([In] DHEEBEEFOLH<PKEJDDGKOJK> GOFHHJFDBCC, [In] KGAPBMDBEOB<PKEJDDGKOJK, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> ADHCKOGOIAC, [In] KGAPBMDBEOB<PKEJDDGKOJK, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> GNFKEPNJCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27E1A40", Offset = "0x27E0C40", VA = "0x1827E1A40")]
	public static LIKOAJLIPDC OIKMHICCLEP()
	{
		return default(LIKOAJLIPDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27E1370", Offset = "0x27E0570", VA = "0x1827E1370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27E1090", Offset = "0x27E0290", VA = "0x1827E1090")]
	public readonly GCMCHBNGJEP CEBCPPBDNIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27E1B20", Offset = "0x27E0D20", VA = "0x1827E1B20")]
	public JFIBBLJIDCN<PKEJDDGKOJK> OPFHKGILNAI([In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> ADHCKOGOIAC, [In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> GNFKEPNJCEC)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27E1640", Offset = "0x27E0840", VA = "0x1827E1640")]
	public void EFCGIOJACBM(JFIBBLJIDCN<PKEJDDGKOJK> MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x27E1780", Offset = "0x27E0980", VA = "0x1827E1780")]
	[CompilerGenerated]
	internal static JNOKPGAEHBL HEINDNFGGOO([In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27E18E0", Offset = "0x27E0AE0", VA = "0x1827E18E0")]
	[CompilerGenerated]
	internal static EEENJOPDGLJ LJDCFDCFEAJ([In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HICACOKIMFO : IEnumerator<JFIBBLJIDCN<PKEJDDGKOJK>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private FNGMOIFMICG GEFJOENNENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<PKEJDDGKOJK>> DBBKAOMKPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private EJOJBDDLPNB DKGOOEBCHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<PKEJDDGKOJK>> KJIFCAJFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool MJAJDFKGPOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly JFIBBLJIDCN<PKEJDDGKOJK> HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x27DC1C0", Offset = "0x27DB3C0", VA = "0x1827DC1C0", Slot = "4")]
		get
		{
			return default(JFIBBLJIDCN<PKEJDDGKOJK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27DC0C0", Offset = "0x27DB2C0", VA = "0x1827DC0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27DC110", Offset = "0x27DB310", VA = "0x1827DC110")]
	internal HICACOKIMFO([In] FNGMOIFMICG MHLKDOJDLIG, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<PKEJDDGKOJK>> GEAIDNOFPEJ, [In] EJOJBDDLPNB NICKAPKLGEA, [In] KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<PKEJDDGKOJK>> ECHLIOHLAKM, bool KLAKJPAALHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27DBFC0", Offset = "0x27DB1C0", VA = "0x1827DBFC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27DC010", Offset = "0x27DB210", VA = "0x1827DC010", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27DBF20", Offset = "0x27DB120", VA = "0x1827DBF20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct MNNOLNDILAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DHEEBEEFOLH<KLMHALNMEAA> CNIDAMELIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<PKEJDDGKOJK>> NGEKJCOPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> JNHHIFHAOEP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27E1020", Offset = "0x27E0220", VA = "0x1827E1020")]
	public MNNOLNDILAM([In] DHEEBEEFOLH<KLMHALNMEAA> GOFHHJFDBCC, [In] KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<PKEJDDGKOJK>> BJHIMBLJFFE, [In] KGAPBMDBEOB<KLMHALNMEAA, PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>> ADHCKOGOIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27E2260", Offset = "0x27E1460", VA = "0x1827E2260")]
	public static MNNOLNDILAM OIKMHICCLEP()
	{
		return default(MNNOLNDILAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27E1E80", Offset = "0x27E1080", VA = "0x1827E1E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27E1BD0", Offset = "0x27E0DD0", VA = "0x1827E1BD0")]
	public readonly FGINKOKPILJ CEBCPPBDNIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27E2340", Offset = "0x27E1540", VA = "0x1827E2340")]
	public JFIBBLJIDCN<KLMHALNMEAA> OPFHKGILNAI(JFIBBLJIDCN<PKEJDDGKOJK> GCEDHPINDAM)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27E2020", Offset = "0x27E1220", VA = "0x1827E2020")]
	public void EFCGIOJACBM(JFIBBLJIDCN<KLMHALNMEAA> MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27E2100", Offset = "0x27E1300", VA = "0x1827E2100")]
	[CompilerGenerated]
	internal static BKICFBACFKA ODFCAMKADOA([In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EJOJBDDLPNB : IEnumerator<JFIBBLJIDCN<KLMHALNMEAA>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE MBBNAEFGKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE IIEDCBIKBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KGAPBMDBEOB<PFJDLPPNNBM, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> NBDIAIIFMAC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JFIBBLJIDCN<KLMHALNMEAA> HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x27DBC30", Offset = "0x27DAE30", VA = "0x1827DBC30", Slot = "4")]
		get
		{
			return default(JFIBBLJIDCN<KLMHALNMEAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x27DBB60", Offset = "0x27DAD60", VA = "0x1827DBB60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27DBBD0", Offset = "0x27DADD0", VA = "0x1827DBBD0")]
	internal EJOJBDDLPNB([In] PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>.KDONGFBHLCE PAENIKNGFJK, [In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>.KDONGFBHLCE NHFCAJEMJGC, [In] KGAPBMDBEOB<PFJDLPPNNBM, PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>> ADENNAFKMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27DB9C0", Offset = "0x27DABC0", VA = "0x1827DB9C0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27DBB00", Offset = "0x27DAD00", VA = "0x1827DBB00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27DB960", Offset = "0x27DAB60", VA = "0x1827DB960", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class BLHHAPOAIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27DB2D0", Offset = "0x27DA4D0", VA = "0x1827DB2D0")]
	public static LIKOAJLIPDC JKAINKAKBPB(this GCMCHBNGJEP CEENCLMGJAM)
	{
		return default(LIKOAJLIPDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27DB1C0", Offset = "0x27DA3C0", VA = "0x1827DB1C0")]
	public static void EFCGIOJACBM(this GCMCHBNGJEP CEENCLMGJAM, int MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x27DAFB0", Offset = "0x27DA1B0", VA = "0x1827DAFB0")]
	[CompilerGenerated]
	internal static PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> BFLHPLKPDCA(JNOKPGAEHBL CEENCLMGJAM)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x27DB750", Offset = "0x27DA950", VA = "0x1827DB750")]
	[CompilerGenerated]
	internal static PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> KMDCJAKFMKP(EEENJOPDGLJ CEENCLMGJAM)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ODFJCFLOALG
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27E30E0", Offset = "0x27E22E0", VA = "0x1827E30E0")]
	public static IABDJEAOBEO JKAINKAKBPB(this CLKBMAMAHOE CEENCLMGJAM)
	{
		return default(IABDJEAOBEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x27E24F0", Offset = "0x27E16F0", VA = "0x1827E24F0")]
	public static JFIBBLJIDCN<PFJDLPPNNBM> EGMHMOKJIAL(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<FAIOCFLCPBP> HIILHOHJDGC)
	{
		return default(JFIBBLJIDCN<PFJDLPPNNBM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27E2840", Offset = "0x27E1A40", VA = "0x1827E2840")]
	public static MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, JIBOJEDJIDF<PFJDLPPNNBM>.HMLCCDDJFHA> HNFIMGGLLOJ(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<PFJDLPPNNBM>, JIBOJEDJIDF<PFJDLPPNNBM>.HMLCCDDJFHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x27E25A0", Offset = "0x27E17A0", VA = "0x1827E25A0")]
	public static IEnumerable<int> ENEOHNEBEKG(this CLKBMAMAHOE CEENCLMGJAM, int CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x27E26C0", Offset = "0x27E18C0", VA = "0x1827E26C0")]
	public static int GAIJBIPDDMA(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27E2940", Offset = "0x27E1B40", VA = "0x1827E2940")]
	public static int IOLPKOAIPIP(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x27E2610", Offset = "0x27E1810", VA = "0x1827E2610")]
	public static JFIBBLJIDCN<KLMHALNMEAA> FHIDLGLPGII(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, JFIBBLJIDCN<EJFMCNHIBMC> ACPHKIIOJAK)
	{
		return default(JFIBBLJIDCN<KLMHALNMEAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x27E2740", Offset = "0x27E1940", VA = "0x1827E2740")]
	public static MAIDBPOBJJB<JFIBBLJIDCN<KLMHALNMEAA>, JIBOJEDJIDF<KLMHALNMEAA>.HMLCCDDJFHA> HGHNKELPJOE(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<KLMHALNMEAA>, JIBOJEDJIDF<KLMHALNMEAA>.HMLCCDDJFHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27E37B0", Offset = "0x27E29B0", VA = "0x1827E37B0")]
	public static IEnumerable<int> MGLFKJKLABJ(this CLKBMAMAHOE CEENCLMGJAM, int CANDMCKMDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x27E3820", Offset = "0x27E2A20", VA = "0x1827E3820")]
	public static JFIBBLJIDCN<PKEJDDGKOJK> MOPDPFMCDGM(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x27E2480", Offset = "0x27E1680", VA = "0x1827E2480")]
	public static JFIBBLJIDCN<PKEJDDGKOJK> BKBMFCJLEIE(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return default(JFIBBLJIDCN<PKEJDDGKOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x27E3890", Offset = "0x27E2A90", VA = "0x1827E3890")]
	public static void NNPFKBFFGAM(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27E29C0", Offset = "0x27E1BC0", VA = "0x1827E29C0")]
	public static void JFJELMEFNHD(this CLKBMAMAHOE CEENCLMGJAM, int CANDMCKMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27E34D0", Offset = "0x27E26D0", VA = "0x1827E34D0")]
	public static void LIPFGLHJADE(this CLKBMAMAHOE CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class IJOEHICMFBL
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27DFC10", Offset = "0x27DEE10", VA = "0x1827DFC10")]
	public static LEHBKJGNPOI JKAINKAKBPB(this IODGKPICJDF CEENCLMGJAM)
	{
		return default(LEHBKJGNPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x27DF930", Offset = "0x27DEB30", VA = "0x1827DF930")]
	public static void EFCGIOJACBM(this IODGKPICJDF CEENCLMGJAM, int MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x27DFA00", Offset = "0x27DEC00", VA = "0x1827DFA00")]
	[CompilerGenerated]
	internal static PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> GBLLHJCNPDN(BBFEBPPKAMH CEENCLMGJAM)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class JHBCPNIGJBD
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x27E0370", Offset = "0x27DF570", VA = "0x1827E0370")]
	public static MNNOLNDILAM JKAINKAKBPB(this FGINKOKPILJ CEENCLMGJAM)
	{
		return default(MNNOLNDILAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x27E0090", Offset = "0x27DF290", VA = "0x1827E0090")]
	public static void EFCGIOJACBM(this FGINKOKPILJ CEENCLMGJAM, int MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x27E0160", Offset = "0x27DF360", VA = "0x1827E0160")]
	[CompilerGenerated]
	internal static PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> FPLBJIDKIIC(BKICFBACFKA CEENCLMGJAM)
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>);
	}
}
namespace Cpp2IlInjected
{
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
}

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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x269ED00", Offset = "0x269E100", VA = "0x18269ED00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HFECLDEDGPI : IEnumerator<FEBHGHLDFDK>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IPCDFJEEDHP<DIEOFHIAEHN>.NENPGCDJCNB MFHHNBEELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> AAMIOKEBOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD NPMNCHHJHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MKOHKCIKHHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FEBHGHLDFDK JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x269B800", Offset = "0x269AC00", VA = "0x18269B800", Slot = "4")]
		get
		{
			return default(FEBHGHLDFDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x269B740", Offset = "0x269AB40", VA = "0x18269B740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x269B790", Offset = "0x269AB90", VA = "0x18269B790")]
	internal HFECLDEDGPI([In] IPCDFJEEDHP<DIEOFHIAEHN>.NENPGCDJCNB JABGKFBCCNE, [In] LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> DBFFNNONBMH, [In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD PIDAKFOPJFM, bool LCEMNDOHODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x269B540", Offset = "0x269A940", VA = "0x18269B540", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x269B700", Offset = "0x269AB00", VA = "0x18269B700", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x269B4D0", Offset = "0x269A8D0", VA = "0x18269B4D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ALEEBNPINMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ABBLMFBFHOK FOLOELFHJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HNCOIOEKIJJ CBNNLOGIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal MMMIFJKDNEB EOEFCBDINPM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2699B90", Offset = "0x2698F90", VA = "0x182699B90")]
	internal ALEEBNPINMM([In] ABBLMFBFHOK COMKEBALMJE, [In] HNCOIOEKIJJ EENOIMJOHCP, [In] MMMIFJKDNEB KMMNNCOJCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2698170", Offset = "0x2697570", VA = "0x182698170")]
	public static ALEEBNPINMM HBLBJMFGHFK()
	{
		return default(ALEEBNPINMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2697A90", Offset = "0x2696E90", VA = "0x182697A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2699720", Offset = "0x2698B20", VA = "0x182699720")]
	public readonly KDDMPELACCE PELCBGJOJPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2697730", Offset = "0x2696B30", VA = "0x182697730")]
	public void DMOPEJIPECC(IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2697350", Offset = "0x2696750", VA = "0x182697350")]
	public IJOGBJOFPED<KHMKGBDANIH> BADCBNKEGKA(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2697EB0", Offset = "0x26972B0", VA = "0x182697EB0")]
	public IJOGBJOFPED<EICBKBBFNCN> FCCLECDOCFK()
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2699880", Offset = "0x2698C80", VA = "0x182699880")]
	public IJOGBJOFPED<DIEOFHIAEHN> PLGPPBKHECL(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26971C0", Offset = "0x26965C0", VA = "0x1826971C0")]
	public readonly bool APFHODBDDPH(IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2697930", Offset = "0x2696D30", VA = "0x182697930")]
	public readonly DCFBMJCCGFF<FEBHGHLDFDK, HFECLDEDGPI> DODHNCDHLJP()
	{
		return default(DCFBMJCCGFF<FEBHGHLDFDK, HFECLDEDGPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2698F70", Offset = "0x2698370", VA = "0x182698F70")]
	public readonly HFECLDEDGPI LDKLOKINNOC()
	{
		return default(HFECLDEDGPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2697BC0", Offset = "0x2696FC0", VA = "0x182697BC0")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, IPCDFJEEDHP<KHMKGBDANIH>.NENPGCDJCNB> EEHNDKOAHMK()
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, IPCDFJEEDHP<KHMKGBDANIH>.NENPGCDJCNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2697120", Offset = "0x2696520", VA = "0x182697120")]
	public readonly IJOGBJOFPED<KHMKGBDANIH> AMBIHCKIBDN(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, int FNJFCLABCPK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26995D0", Offset = "0x26989D0", VA = "0x1826995D0")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<HEMNMAIIMJK>, PCNDONFGOFI<HEMNMAIIMJK>> ONPNONBINHI(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<HEMNMAIIMJK>, PCNDONFGOFI<HEMNMAIIMJK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2697510", Offset = "0x2696910", VA = "0x182697510")]
	public readonly PCNDONFGOFI<HEMNMAIIMJK> BEMPLFPDCHL(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(PCNDONFGOFI<HEMNMAIIMJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2698ED0", Offset = "0x26982D0", VA = "0x182698ED0")]
	public readonly IJOGBJOFPED<KHMKGBDANIH> LCLNGILDDKL(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<HEMNMAIIMJK> FNJFCLABCPK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2699660", Offset = "0x2698A60", VA = "0x182699660")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, CJJPBMNKHFE> PAONIBLLBHA(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, CJJPBMNKHFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2698CB0", Offset = "0x26980B0", VA = "0x182698CB0")]
	public readonly CJJPBMNKHFE KKFFPMLJHFA(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(CJJPBMNKHFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26991A0", Offset = "0x26985A0", VA = "0x1826991A0")]
	public readonly FONPLHOCLEB<IJOGBJOFPED<KHMKGBDANIH>, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD> MJFNKDGOCOP(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(FONPLHOCLEB<IJOGBJOFPED<KHMKGBDANIH>, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26973F0", Offset = "0x26967F0", VA = "0x1826973F0")]
	public readonly AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD BCPHFCNPBMK(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2698940", Offset = "0x2697D40", VA = "0x182698940")]
	public readonly FONPLHOCLEB<IJOGBJOFPED<KHMKGBDANIH>, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD> JBEMANADPCO(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(FONPLHOCLEB<IJOGBJOFPED<KHMKGBDANIH>, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2699520", Offset = "0x2698920", VA = "0x182699520")]
	public readonly AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD OLKKJKNCGEF(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2699250", Offset = "0x2698650", VA = "0x182699250")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<EICBKBBFNCN>, EBGKNCAOICF> MLJFEPPOHEB(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<EICBKBBFNCN>, EBGKNCAOICF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2697020", Offset = "0x2696420", VA = "0x182697020")]
	public readonly EBGKNCAOICF AMBHJEJDJHP(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(EBGKNCAOICF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26994B0", Offset = "0x26988B0", VA = "0x1826994B0")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<EICBKBBFNCN>, IPCDFJEEDHP<EICBKBBFNCN>.NENPGCDJCNB> OBOBCEPJBJC()
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<EICBKBBFNCN>, IPCDFJEEDHP<EICBKBBFNCN>.NENPGCDJCNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26997D0", Offset = "0x2698BD0", VA = "0x1826997D0")]
	public readonly IPCDFJEEDHP<EICBKBBFNCN>.NENPGCDJCNB PGGIFGLMPLP()
	{
		return default(IPCDFJEEDHP<EICBKBBFNCN>.NENPGCDJCNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2697D20", Offset = "0x2697120", VA = "0x182697D20")]
	public readonly int EPLGMBLLHIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2699840", Offset = "0x2698C40", VA = "0x182699840")]
	public readonly int PHMMNANAENP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2697570", Offset = "0x2696970", VA = "0x182697570")]
	public readonly int BEOIMAIMALK(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2698800", Offset = "0x2697C00", VA = "0x182698800")]
	public readonly int IJFBDPDCAFO(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2698880", Offset = "0x2697C80", VA = "0x182698880")]
	public readonly int IKICANKIMEA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2699470", Offset = "0x2698870", VA = "0x182699470")]
	public readonly int OAKLOGHAHFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2697FB0", Offset = "0x26973B0", VA = "0x182697FB0")]
	public readonly int FODOAHAEJIH(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2698690", Offset = "0x2697A90", VA = "0x182698690")]
	public readonly int HOBNNMLOHOG(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2697690", Offset = "0x2696A90", VA = "0x182697690")]
	public readonly IJOGBJOFPED<DIEOFHIAEHN> COJBFJLENOF(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, int MCIKILGHAHK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2698030", Offset = "0x2697430", VA = "0x182698030")]
	public readonly DCFBMJCCGFF<IJOGBJOFPED<PHBAJLIMCFA>, PCNDONFGOFI<PHBAJLIMCFA>> GAFNJLCFECL(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<PHBAJLIMCFA>, PCNDONFGOFI<PHBAJLIMCFA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2698DA0", Offset = "0x26981A0", VA = "0x182698DA0")]
	public readonly PCNDONFGOFI<PHBAJLIMCFA> KNGNDIGNMJH(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(PCNDONFGOFI<PHBAJLIMCFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x26975F0", Offset = "0x26969F0", VA = "0x1826975F0")]
	public readonly IJOGBJOFPED<DIEOFHIAEHN> BIFHLGCEGAD(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<PHBAJLIMCFA> MCIKILGHAHK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2699020", Offset = "0x2698420", VA = "0x182699020")]
	public readonly FONPLHOCLEB<IJOGBJOFPED<DIEOFHIAEHN>, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD> MCOFOKGNLLO(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(FONPLHOCLEB<IJOGBJOFPED<DIEOFHIAEHN>, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2697C30", Offset = "0x2697030", VA = "0x182697C30")]
	public readonly AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD EGLIINCNINM(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2698710", Offset = "0x2697B10", VA = "0x182698710")]
	public readonly MDOEKAHCOCK IEBODAKPMBP(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(MDOEKAHCOCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26974A0", Offset = "0x26968A0", VA = "0x1826974A0")]
	public readonly IPCDFJEEDHP<DIEOFHIAEHN>.NENPGCDJCNB BEEDEBAMPPP()
	{
		return default(IPCDFJEEDHP<DIEOFHIAEHN>.NENPGCDJCNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26980C0", Offset = "0x26974C0", VA = "0x1826980C0")]
	public readonly FONPLHOCLEB<IJOGBJOFPED<DIEOFHIAEHN>, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD> GPGMFCMBLIL(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(FONPLHOCLEB<IJOGBJOFPED<DIEOFHIAEHN>, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26985E0", Offset = "0x26979E0", VA = "0x1826985E0")]
	public readonly AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD HLEPLABGKCC(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26988C0", Offset = "0x2697CC0", VA = "0x1826988C0")]
	public readonly IJOGBJOFPED<EICBKBBFNCN> ILKJAKBBKKG(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2698E50", Offset = "0x2698250", VA = "0x182698E50")]
	public readonly IJOGBJOFPED<EICBKBBFNCN> LAINDEKPFEK(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26989F0", Offset = "0x2697DF0", VA = "0x1826989F0")]
	public readonly bool KDLDOMEDIBC(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26993B0", Offset = "0x26987B0", VA = "0x1826993B0")]
	public IJOGBJOFPED<KHMKGBDANIH> NBKIEKOHKLJ(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<HEMNMAIIMJK> FNJFCLABCPK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26990C0", Offset = "0x26984C0", VA = "0x1826990C0")]
	public IJOGBJOFPED<DIEOFHIAEHN> MDGFAIJCAJB(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<PHBAJLIMCFA> MCIKILGHAHK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2697A70", Offset = "0x2696E70", VA = "0x182697A70")]
	public readonly bool DOMDKJDMPJJ(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2699180", Offset = "0x2698580", VA = "0x182699180")]
	public readonly bool MINMFACLLIA(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2697AC0", Offset = "0x2696EC0", VA = "0x182697AC0")]
	public void ECBLBHOHJHO(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<HEMNMAIIMJK> KINBLKCJOGI, IJOGBJOFPED<HEMNMAIIMJK> JJEJONAJNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26984E0", Offset = "0x26978E0", VA = "0x1826984E0")]
	public void HIBLMBHLDBA(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<PHBAJLIMCFA> CFANAHMGAAD, IJOGBJOFPED<PHBAJLIMCFA> MLAJKPEIOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2697CD0", Offset = "0x26970D0", VA = "0x182697CD0")]
	public readonly bool EPFHCCENKAH(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2698E00", Offset = "0x2698200", VA = "0x182698E00")]
	public readonly bool LAAMFACMFDI(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2697830", Offset = "0x2696C30", VA = "0x182697830")]
	public void DNGEAGBENIM(IJOGBJOFPED<DIEOFHIAEHN> NOOHCNGJKGB, IJOGBJOFPED<KHMKGBDANIH> CINNJNFNKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2699920", Offset = "0x2698D20", VA = "0x182699920")]
	public void POAHFLCBHHI(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2696A60", Offset = "0x2695E60", VA = "0x182696A60")]
	public void AAKICOGDCIA(IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2698A40", Offset = "0x2697E40", VA = "0x182698A40")]
	public void KEDEIJBBLHF(IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GDOHIPGMLFC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
	public static IPCDFJEEDHP<KHMKGBDANIH> KNPJODBKLPJ([In] this ALEEBNPINMM JOCJBPPJMJJ)
	{
		return default(IPCDFJEEDHP<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x269B4B0", Offset = "0x269A8B0", VA = "0x18269B4B0")]
	public static IPCDFJEEDHP<DIEOFHIAEHN> AGKJEEOMAHK([In] this ALEEBNPINMM JOCJBPPJMJJ)
	{
		return default(IPCDFJEEDHP<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x269B4C0", Offset = "0x269A8C0", VA = "0x18269B4C0")]
	public static IPCDFJEEDHP<EICBKBBFNCN> HAPHIPMKDPD([In] this ALEEBNPINMM JOCJBPPJMJJ)
	{
		return default(IPCDFJEEDHP<EICBKBBFNCN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct ABBLMFBFHOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public IPCDFJEEDHP<KHMKGBDANIH> IGJMBPBFOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<EICBKBBFNCN>> KDGBJAMIJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public LPLBBMCLGNH<KHMKGBDANIH, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> CIFEHPEBAJA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x26969F0", Offset = "0x2695DF0", VA = "0x1826969F0")]
	public ABBLMFBFHOK([In] IPCDFJEEDHP<KHMKGBDANIH> OGNADJONOEA, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<EICBKBBFNCN>> KMMNNCOJCAG, [In] LPLBBMCLGNH<KHMKGBDANIH, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> EENOIMJOHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2696500", Offset = "0x2695900", VA = "0x182696500")]
	public static ABBLMFBFHOK HBLBJMFGHFK()
	{
		return default(ABBLMFBFHOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2696280", Offset = "0x2695680", VA = "0x182696280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2696740", Offset = "0x2695B40", VA = "0x182696740")]
	public readonly BNBEGMEDDLK PELCBGJOJPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x26961C0", Offset = "0x26955C0", VA = "0x1826961C0")]
	public IJOGBJOFPED<KHMKGBDANIH> DKJCAAJLIFL(IJOGBJOFPED<EICBKBBFNCN> BLGGFHHEDNC)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2696420", Offset = "0x2695820", VA = "0x182696420")]
	public void FEMKONHLAGL(IJOGBJOFPED<KHMKGBDANIH> NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26965E0", Offset = "0x26959E0", VA = "0x1826965E0")]
	[CompilerGenerated]
	internal static AKLFJOCLAEN JGOADMLPDAC([In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CJJPBMNKHFE : IEnumerator<IJOGBJOFPED<KHMKGBDANIH>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD MFHHNBEELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD GPLCOLLFLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> DMLAFJGDEKH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IJOGBJOFPED<KHMKGBDANIH> JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2699F40", Offset = "0x2699340", VA = "0x182699F40", Slot = "4")]
		get
		{
			return default(IJOGBJOFPED<KHMKGBDANIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2699E70", Offset = "0x2699270", VA = "0x182699E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2699EE0", Offset = "0x26992E0", VA = "0x182699EE0")]
	internal CJJPBMNKHFE([In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD JABGKFBCCNE, [In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD NAPOACACNFG, [In] LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> AGGMOEFEMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2699CD0", Offset = "0x26990D0", VA = "0x182699CD0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2699E10", Offset = "0x2699210", VA = "0x182699E10", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2699C70", Offset = "0x2699070", VA = "0x182699C70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct MMMIFJKDNEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public IPCDFJEEDHP<EICBKBBFNCN> IGJMBPBFOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public LPLBBMCLGNH<EICBKBBFNCN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> DMKKLIPKDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public LPLBBMCLGNH<EICBKBBFNCN, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> CIFEHPEBAJA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26969F0", Offset = "0x2695DF0", VA = "0x1826969F0")]
	public MMMIFJKDNEB([In] IPCDFJEEDHP<EICBKBBFNCN> OGNADJONOEA, [In] LPLBBMCLGNH<EICBKBBFNCN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> COMKEBALMJE, [In] LPLBBMCLGNH<EICBKBBFNCN, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> EENOIMJOHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x269E1E0", Offset = "0x269D5E0", VA = "0x18269E1E0")]
	public static MMMIFJKDNEB HBLBJMFGHFK()
	{
		return default(MMMIFJKDNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x269DDD0", Offset = "0x269D1D0", VA = "0x18269DDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x269E2C0", Offset = "0x269D6C0", VA = "0x18269E2C0")]
	public readonly HPCFHMAOHNK PELCBGJOJPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x269DD20", Offset = "0x269D120", VA = "0x18269DD20")]
	public IJOGBJOFPED<EICBKBBFNCN> DKJCAAJLIFL([In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> COMKEBALMJE, [In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> EENOIMJOHCP)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x269E0A0", Offset = "0x269D4A0", VA = "0x18269E0A0")]
	public void FEMKONHLAGL(IJOGBJOFPED<EICBKBBFNCN> NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x269DBC0", Offset = "0x269CFC0", VA = "0x18269DBC0")]
	[CompilerGenerated]
	internal static MAKOAPBMJFH DDFMJLIABKE([In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x269DA60", Offset = "0x269CE60", VA = "0x18269DA60")]
	[CompilerGenerated]
	internal static CJMIDJMBOLO CKLHLMNCLDO([In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EBGKNCAOICF : IEnumerator<IJOGBJOFPED<EICBKBBFNCN>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CJJPBMNKHFE CPDIADDLJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<EICBKBBFNCN>> JNGLEGPDKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private MDOEKAHCOCK PENOCIGAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<EICBKBBFNCN>> KOCLHAGEFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool DKDOOGMMNFE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly IJOGBJOFPED<EICBKBBFNCN> JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x269ABD0", Offset = "0x2699FD0", VA = "0x18269ABD0", Slot = "4")]
		get
		{
			return default(IJOGBJOFPED<EICBKBBFNCN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x269AAD0", Offset = "0x2699ED0", VA = "0x18269AAD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x269AB20", Offset = "0x2699F20", VA = "0x18269AB20")]
	internal EBGKNCAOICF([In] CJJPBMNKHFE KHAMDCEAGKG, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<EICBKBBFNCN>> FJFELNIKBKN, [In] MDOEKAHCOCK JNNKLFFALEH, [In] LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<EICBKBBFNCN>> COGINIEGENB, bool DDPPLAJAPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x269A9D0", Offset = "0x2699DD0", VA = "0x18269A9D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x269AA20", Offset = "0x2699E20", VA = "0x18269AA20", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x269A930", Offset = "0x2699D30", VA = "0x18269A930", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct HNCOIOEKIJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IPCDFJEEDHP<DIEOFHIAEHN> IGJMBPBFOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<EICBKBBFNCN>> KDGBJAMIJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> DMKKLIPKDML;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x26969F0", Offset = "0x2695DF0", VA = "0x1826969F0")]
	public HNCOIOEKIJJ([In] IPCDFJEEDHP<DIEOFHIAEHN> OGNADJONOEA, [In] LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<EICBKBBFNCN>> KMMNNCOJCAG, [In] LPLBBMCLGNH<DIEOFHIAEHN, AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>> COMKEBALMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x269BBD0", Offset = "0x269AFD0", VA = "0x18269BBD0")]
	public static HNCOIOEKIJJ HBLBJMFGHFK()
	{
		return default(HNCOIOEKIJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x269B950", Offset = "0x269AD50", VA = "0x18269B950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x269BE10", Offset = "0x269B210", VA = "0x18269BE10")]
	public readonly HMAGDDBPEIF PELCBGJOJPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x269B890", Offset = "0x269AC90", VA = "0x18269B890")]
	public IJOGBJOFPED<DIEOFHIAEHN> DKJCAAJLIFL(IJOGBJOFPED<EICBKBBFNCN> BLGGFHHEDNC)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x269BAF0", Offset = "0x269AEF0", VA = "0x18269BAF0")]
	public void FEMKONHLAGL(IJOGBJOFPED<DIEOFHIAEHN> NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x269BCB0", Offset = "0x269B0B0", VA = "0x18269BCB0")]
	[CompilerGenerated]
	internal static DNHLMBCIHMG IMMIJONGCHA([In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MDOEKAHCOCK : IEnumerator<IJOGBJOFPED<DIEOFHIAEHN>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD ALOCEKJNBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD IENPDCLOIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly LPLBBMCLGNH<KHMKGBDANIH, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> PGLALOHANNJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IJOGBJOFPED<DIEOFHIAEHN> JKNLEFEANEI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x269DA20", Offset = "0x269CE20", VA = "0x18269DA20", Slot = "4")]
		get
		{
			return default(IJOGBJOFPED<DIEOFHIAEHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x269D9B0", Offset = "0x269CDB0", VA = "0x18269D9B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2699EE0", Offset = "0x26992E0", VA = "0x182699EE0")]
	internal MDOEKAHCOCK([In] AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>.DPAKAGMDJOD CCMELDKJOHA, [In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>.DPAKAGMDJOD JFHMKPENMJL, [In] LPLBBMCLGNH<KHMKGBDANIH, AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>> GNMLCLBCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x269D810", Offset = "0x269CC10", VA = "0x18269D810", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x269D950", Offset = "0x269CD50", VA = "0x18269D950", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x269D7B0", Offset = "0x269CBB0", VA = "0x18269D7B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class DGHEKAOKBBK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x269A2A0", Offset = "0x26996A0", VA = "0x18269A2A0")]
	public static MMMIFJKDNEB HFAEDKNMEEN(this HPCFHMAOHNK JOCJBPPJMJJ)
	{
		return default(MMMIFJKDNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x269A190", Offset = "0x2699590", VA = "0x18269A190")]
	public static void FEMKONHLAGL(this HPCFHMAOHNK JOCJBPPJMJJ, int NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x269A720", Offset = "0x2699B20", VA = "0x18269A720")]
	[CompilerGenerated]
	internal static AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> PAJOKCPMKOF(MAKOAPBMJFH JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2699F80", Offset = "0x2699380", VA = "0x182699F80")]
	[CompilerGenerated]
	internal static AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> AIIMGDCAGJL(CJMIDJMBOLO JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MCLHHLEGEPA
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x269C900", Offset = "0x269BD00", VA = "0x18269C900")]
	public static ALEEBNPINMM HFAEDKNMEEN(this KDDMPELACCE JOCJBPPJMJJ)
	{
		return default(ALEEBNPINMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x269D220", Offset = "0x269C620", VA = "0x18269D220")]
	public static IJOGBJOFPED<KHMKGBDANIH> LCLNGILDDKL(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<HEMNMAIIMJK> FNJFCLABCPK)
	{
		return default(IJOGBJOFPED<KHMKGBDANIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x269D3D0", Offset = "0x269C7D0", VA = "0x18269D3D0")]
	public static DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, EIHMEFMCJOH<KHMKGBDANIH>.ALGCKBOBHFB> MJFNKDGOCOP(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<KHMKGBDANIH>, EIHMEFMCJOH<KHMKGBDANIH>.ALGCKBOBHFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x269CE60", Offset = "0x269C260", VA = "0x18269CE60")]
	public static IEnumerable<int> JBEMANADPCO(this KDDMPELACCE JOCJBPPJMJJ, int CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x269CD70", Offset = "0x269C170", VA = "0x18269CD70")]
	public static int IJFBDPDCAFO(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x269CCF0", Offset = "0x269C0F0", VA = "0x18269CCF0")]
	public static int HOBNNMLOHOG(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x269C7E0", Offset = "0x269BBE0", VA = "0x18269C7E0")]
	public static IJOGBJOFPED<DIEOFHIAEHN> BIFHLGCEGAD(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, IJOGBJOFPED<PHBAJLIMCFA> MCIKILGHAHK)
	{
		return default(IJOGBJOFPED<DIEOFHIAEHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x269D2D0", Offset = "0x269C6D0", VA = "0x18269D2D0")]
	public static DCFBMJCCGFF<IJOGBJOFPED<DIEOFHIAEHN>, EIHMEFMCJOH<DIEOFHIAEHN>.ALGCKBOBHFB> MCOFOKGNLLO(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<DIEOFHIAEHN>, EIHMEFMCJOH<DIEOFHIAEHN>.ALGCKBOBHFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x269C890", Offset = "0x269BC90", VA = "0x18269C890")]
	public static IEnumerable<int> GPGMFCMBLIL(this KDDMPELACCE JOCJBPPJMJJ, int CCBIHMLAAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x269CDF0", Offset = "0x269C1F0", VA = "0x18269CDF0")]
	public static IJOGBJOFPED<EICBKBBFNCN> ILKJAKBBKKG(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x269D1B0", Offset = "0x269C5B0", VA = "0x18269D1B0")]
	public static IJOGBJOFPED<EICBKBBFNCN> LAINDEKPFEK(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return default(IJOGBJOFPED<EICBKBBFNCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x269D4D0", Offset = "0x269C8D0", VA = "0x18269D4D0")]
	public static void POAHFLCBHHI(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x269C0C0", Offset = "0x269B4C0", VA = "0x18269C0C0")]
	public static void AAKICOGDCIA(this KDDMPELACCE JOCJBPPJMJJ, int CCBIHMLAAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x269CED0", Offset = "0x269C2D0", VA = "0x18269CED0")]
	public static void KEDEIJBBLHF(this KDDMPELACCE JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class EGDEHHAIOKL
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x269AE20", Offset = "0x269A220", VA = "0x18269AE20")]
	public static ABBLMFBFHOK HFAEDKNMEEN(this BNBEGMEDDLK JOCJBPPJMJJ)
	{
		return default(ABBLMFBFHOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x269AD50", Offset = "0x269A150", VA = "0x18269AD50")]
	public static void FEMKONHLAGL(this BNBEGMEDDLK JOCJBPPJMJJ, int NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x269B2A0", Offset = "0x269A6A0", VA = "0x18269B2A0")]
	[CompilerGenerated]
	internal static AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> MKNCBLKJGFM(AKLFJOCLAEN JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class NGMMIDLGGCD
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x269E670", Offset = "0x269DA70", VA = "0x18269E670")]
	public static HNCOIOEKIJJ HFAEDKNMEEN(this HMAGDDBPEIF JOCJBPPJMJJ)
	{
		return default(HNCOIOEKIJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x269E5A0", Offset = "0x269D9A0", VA = "0x18269E5A0")]
	public static void FEMKONHLAGL(this HMAGDDBPEIF JOCJBPPJMJJ, int NCJKGMLAKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x269EAF0", Offset = "0x269DEF0", VA = "0x18269EAF0")]
	[CompilerGenerated]
	internal static AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> NGKEDIJFNFC(DNHLMBCIHMG JOCJBPPJMJJ)
	{
		return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
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

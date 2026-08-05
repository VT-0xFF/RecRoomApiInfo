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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x200BA70", Offset = "0x200AE70", VA = "0x18200BA70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EICAKPJBDBP : IEnumerator<IOMKNCGAKAA>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HHJPMJCHLHK<ADOPGBMODDE>.EAAFCKAMMFI IIKBBLGDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> JFEPEBJPMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE PMOFOCOFNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool PPAMKHOANAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IOMKNCGAKAA AKMKAIGAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2008C90", Offset = "0x2008090", VA = "0x182008C90", Slot = "4")]
		get
		{
			return default(IOMKNCGAKAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2008BD0", Offset = "0x2007FD0", VA = "0x182008BD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2008C20", Offset = "0x2008020", VA = "0x182008C20")]
	internal EICAKPJBDBP([In] HHJPMJCHLHK<ADOPGBMODDE>.EAAFCKAMMFI NHMMGAFKHFM, [In] AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> PLKOCFJLNKN, [In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE NOJNCGOGHHO, bool HAOCAAMBEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20089D0", Offset = "0x2007DD0", VA = "0x1820089D0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2008B90", Offset = "0x2007F90", VA = "0x182008B90", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2008960", Offset = "0x2007D60", VA = "0x182008960", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AOLEHGPIGML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DNGAPNAKHNH PBOEMHCPOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HKOPDIAENKI OMBNDGFOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ENJMFBHOCCF KOIPKLOCMDH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2007C50", Offset = "0x2007050", VA = "0x182007C50")]
	internal AOLEHGPIGML([In] DNGAPNAKHNH BFGMEIFFLLC, [In] HKOPDIAENKI JGFPDEKBLBG, [In] ENJMFBHOCCF LPNMGCMAJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2005200", Offset = "0x2004600", VA = "0x182005200")]
	public static AOLEHGPIGML DDEJLDFANAB()
	{
		return default(AOLEHGPIGML);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20055C0", Offset = "0x20049C0", VA = "0x1820055C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2006EE0", Offset = "0x20062E0", VA = "0x182006EE0")]
	public readonly CNLDOEBJPAM KPIBKDOHBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20055F0", Offset = "0x20049F0", VA = "0x1820055F0")]
	public void EAAEFGHFEFC(DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20050B0", Offset = "0x20044B0", VA = "0x1820050B0")]
	public DFKPAEMPCKH<OGMOCINGCKO> COEGOGMGKHN(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20068A0", Offset = "0x2005CA0", VA = "0x1820068A0")]
	public DFKPAEMPCKH<CEAIECNFGDF> JCFNJBDOEDM()
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2004D50", Offset = "0x2004150", VA = "0x182004D50")]
	public DFKPAEMPCKH<ADOPGBMODDE> AMLBEKNKHNL(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2006C10", Offset = "0x2006010", VA = "0x182006C10")]
	public readonly bool KDJCHCHFMCK(DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20061B0", Offset = "0x20055B0", VA = "0x1820061B0")]
	public readonly JHKHMDNDIMN<IOMKNCGAKAA, EICAKPJBDBP> HHBOMLEHNIM()
	{
		return default(JHKHMDNDIMN<IOMKNCGAKAA, EICAKPJBDBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2007BA0", Offset = "0x2006FA0", VA = "0x182007BA0")]
	public readonly EICAKPJBDBP PMAOLGOFDFI()
	{
		return default(EICAKPJBDBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2005B80", Offset = "0x2004F80", VA = "0x182005B80")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<OGMOCINGCKO>, HHJPMJCHLHK<OGMOCINGCKO>.EAAFCKAMMFI> GMJFFJPFMKM()
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<OGMOCINGCKO>, HHJPMJCHLHK<OGMOCINGCKO>.EAAFCKAMMFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20071B0", Offset = "0x20065B0", VA = "0x1820071B0")]
	public readonly DFKPAEMPCKH<OGMOCINGCKO> LMGFKLBMLFC(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL, int OGEMJMHDFLE)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20077D0", Offset = "0x2006BD0", VA = "0x1820077D0")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<MGEFODJLGMO>, GNBDNDFBODH<MGEFODJLGMO>> NIAENONDEMD(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<MGEFODJLGMO>, GNBDNDFBODH<MGEFODJLGMO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20076C0", Offset = "0x2006AC0", VA = "0x1820076C0")]
	public readonly GNBDNDFBODH<MGEFODJLGMO> NAHGNKFBJGK(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(GNBDNDFBODH<MGEFODJLGMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20059F0", Offset = "0x2004DF0", VA = "0x1820059F0")]
	public readonly DFKPAEMPCKH<OGMOCINGCKO> GFNFKHJFHCK(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<MGEFODJLGMO> OGEMJMHDFLE)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2004FA0", Offset = "0x20043A0", VA = "0x182004FA0")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<OGMOCINGCKO>, JKEBCCHJGII> CCIKEGEEFEC(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<OGMOCINGCKO>, JKEBCCHJGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2007080", Offset = "0x2006480", VA = "0x182007080")]
	public readonly JKEBCCHJGII LJFHGPJONLL(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(JKEBCCHJGII);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2005150", Offset = "0x2004550", VA = "0x182005150")]
	public readonly KDPIKIBKNJN<DFKPAEMPCKH<OGMOCINGCKO>, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE> DCFHLICMMOC(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(KDPIKIBKNJN<DFKPAEMPCKH<OGMOCINGCKO>, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20067D0", Offset = "0x2005BD0", VA = "0x1820067D0")]
	public readonly PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE IPIIBEKGKGK(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2004E70", Offset = "0x2004270", VA = "0x182004E70")]
	public readonly KDPIKIBKNJN<DFKPAEMPCKH<OGMOCINGCKO>, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE> BGGNBIHDJFI(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(KDPIKIBKNJN<DFKPAEMPCKH<OGMOCINGCKO>, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20063F0", Offset = "0x20057F0", VA = "0x1820063F0")]
	public readonly PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE HLJNDJMFFBA(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2005780", Offset = "0x2004B80", VA = "0x182005780")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<CEAIECNFGDF>, AAJLKNNDEDL> EMDPLOOKCJP(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<CEAIECNFGDF>, AAJLKNNDEDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2007250", Offset = "0x2006650", VA = "0x182007250")]
	public readonly AAJLKNNDEDL LPIHGDDBCNP(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(AAJLKNNDEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2007940", Offset = "0x2006D40", VA = "0x182007940")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<CEAIECNFGDF>, HHJPMJCHLHK<CEAIECNFGDF>.EAAFCKAMMFI> OGNLKDEEBHC()
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<CEAIECNFGDF>, HHJPMJCHLHK<CEAIECNFGDF>.EAAFCKAMMFI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2004B40", Offset = "0x2003F40", VA = "0x182004B40")]
	public readonly int AACILIINKHL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2006EA0", Offset = "0x20062A0", VA = "0x182006EA0")]
	public readonly int KPGMGMMAHFL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2006E20", Offset = "0x2006220", VA = "0x182006E20")]
	public readonly int KMNNEAEAJAN(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2004CD0", Offset = "0x20040D0", VA = "0x182004CD0")]
	public readonly int ALOAAMKDFDN(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2007170", Offset = "0x2006570", VA = "0x182007170")]
	public readonly int LKPKCEIPBBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2007900", Offset = "0x2006D00", VA = "0x182007900")]
	public readonly int OELOIBKPDPB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2007000", Offset = "0x2006400", VA = "0x182007000")]
	public readonly int LBEAOGOOCIL(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2004F20", Offset = "0x2004320", VA = "0x182004F20")]
	public readonly int BGOFEBONOFM(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x20064A0", Offset = "0x20058A0", VA = "0x1820064A0")]
	public readonly DFKPAEMPCKH<ADOPGBMODDE> HOPCJOGIFIC(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA, int OCOBGNMIFDP)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20056F0", Offset = "0x2004AF0", VA = "0x1820056F0")]
	public readonly JHKHMDNDIMN<DFKPAEMPCKH<JJNHPAOOAJK>, GNBDNDFBODH<JJNHPAOOAJK>> EGJHDCKNNMM(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<JJNHPAOOAJK>, GNBDNDFBODH<JJNHPAOOAJK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20069A0", Offset = "0x2005DA0", VA = "0x1820069A0")]
	public readonly GNBDNDFBODH<JJNHPAOOAJK> JHHAPCBKNCI(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(GNBDNDFBODH<JJNHPAOOAJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20079B0", Offset = "0x2006DB0", VA = "0x1820079B0")]
	public readonly DFKPAEMPCKH<ADOPGBMODDE> ONIGIEIIOCD(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JJNHPAOOAJK> OCOBGNMIFDP)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2007A50", Offset = "0x2006E50", VA = "0x182007A50")]
	public readonly KDPIKIBKNJN<DFKPAEMPCKH<ADOPGBMODDE>, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE> PAJPJHBGINP(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(KDPIKIBKNJN<DFKPAEMPCKH<ADOPGBMODDE>, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2007860", Offset = "0x2006C60", VA = "0x182007860")]
	public readonly PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE NIOFKCMGCPB(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2005A90", Offset = "0x2004E90", VA = "0x182005A90")]
	public readonly CHDOMIFJMFM GKCFEEPODJH(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(CHDOMIFJMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2006F90", Offset = "0x2006390", VA = "0x182006F90")]
	public readonly HHJPMJCHLHK<ADOPGBMODDE>.EAAFCKAMMFI KPMBOOHGAAN()
	{
		return default(HHJPMJCHLHK<ADOPGBMODDE>.EAAFCKAMMFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2007720", Offset = "0x2006B20", VA = "0x182007720")]
	public readonly KDPIKIBKNJN<DFKPAEMPCKH<ADOPGBMODDE>, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE> NDBJCMELMDK(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(KDPIKIBKNJN<DFKPAEMPCKH<ADOPGBMODDE>, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2007AF0", Offset = "0x2006EF0", VA = "0x182007AF0")]
	public readonly PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE PGKGFFGCLGE(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2004DF0", Offset = "0x20041F0", VA = "0x182004DF0")]
	public readonly DFKPAEMPCKH<CEAIECNFGDF> AOPNMBCCFDC(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2006DA0", Offset = "0x20061A0", VA = "0x182006DA0")]
	public readonly DFKPAEMPCKH<CEAIECNFGDF> KICAPEIDEMF(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20058E0", Offset = "0x2004CE0", VA = "0x1820058E0")]
	public readonly bool FHMEEEGHKPK(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2005930", Offset = "0x2004D30", VA = "0x182005930")]
	public DFKPAEMPCKH<OGMOCINGCKO> GEPMLOHBMKI(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<MGEFODJLGMO> OGEMJMHDFLE)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2006A50", Offset = "0x2005E50", VA = "0x182006A50")]
	public DFKPAEMPCKH<ADOPGBMODDE> JNBACAPJKCI(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JJNHPAOOAJK> OCOBGNMIFDP)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2006540", Offset = "0x2005940", VA = "0x182006540")]
	public readonly bool IBLGCLPGOIL(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2006880", Offset = "0x2005C80", VA = "0x182006880")]
	public readonly bool JAEKGJJCNPO(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2006B10", Offset = "0x2005F10", VA = "0x182006B10")]
	public void JONBFHDFJIB(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<MGEFODJLGMO> CIOFFPDGHFL, DFKPAEMPCKH<MGEFODJLGMO> NEHBHGFFGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20062F0", Offset = "0x20056F0", VA = "0x1820062F0")]
	public void HJEJKEPCFBC(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, DFKPAEMPCKH<JJNHPAOOAJK> JMNKPNIAOLE, DFKPAEMPCKH<JJNHPAOOAJK> JELJCFGFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2006A00", Offset = "0x2005E00", VA = "0x182006A00")]
	public readonly bool JLHCCGOFAIJ(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2005060", Offset = "0x2004460", VA = "0x182005060")]
	public readonly bool CHJMDHHDFHK(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2007350", Offset = "0x2006750", VA = "0x182007350")]
	public void MJHCINJOKGH(DFKPAEMPCKH<ADOPGBMODDE> PFLEHOGNODD, DFKPAEMPCKH<OGMOCINGCKO> MDPLAEBCIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2007450", Offset = "0x2006850", VA = "0x182007450")]
	public void MLJCLPHBFPD(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2005BF0", Offset = "0x2004FF0", VA = "0x182005BF0")]
	public void GOCNFOLGEJD(DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2006560", Offset = "0x2005960", VA = "0x182006560")]
	public void IEBMJFBKJPC(DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OANBHBHIONN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x200BAF0", Offset = "0x200AEF0", VA = "0x18200BAF0")]
	public static AOLEHGPIGML JLCLGLEKPEG(this CNLDOEBJPAM ABPJKOBADEP)
	{
		return default(AOLEHGPIGML);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KLMAHGJABCC
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static HHJPMJCHLHK<OGMOCINGCKO> KMGBPHKMIJM([In] this AOLEHGPIGML ABPJKOBADEP)
	{
		return default(HHJPMJCHLHK<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x200BA60", Offset = "0x200AE60", VA = "0x18200BA60")]
	public static HHJPMJCHLHK<ADOPGBMODDE> GFHINIIFPED([In] this AOLEHGPIGML ABPJKOBADEP)
	{
		return default(HHJPMJCHLHK<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x200BA50", Offset = "0x200AE50", VA = "0x18200BA50")]
	public static HHJPMJCHLHK<CEAIECNFGDF> EEHKDBPOHAN([In] this AOLEHGPIGML ABPJKOBADEP)
	{
		return default(HHJPMJCHLHK<CEAIECNFGDF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal struct DNGAPNAKHNH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public HHJPMJCHLHK<OGMOCINGCKO> EAGKPCLLPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<CEAIECNFGDF>> EAPLGFNFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public AEOJAEFAFAE<OGMOCINGCKO, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> AFNDAMFLKHF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x20088F0", Offset = "0x2007CF0", VA = "0x1820088F0")]
	public DNGAPNAKHNH([In] HHJPMJCHLHK<OGMOCINGCKO> JPDAPDOGCLE, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<CEAIECNFGDF>> LPNMGCMAJOP, [In] AEOJAEFAFAE<OGMOCINGCKO, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> JGFPDEKBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2008180", Offset = "0x2007580", VA = "0x182008180")]
	public static DNGAPNAKHNH DDEJLDFANAB()
	{
		return default(DNGAPNAKHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2008260", Offset = "0x2007660", VA = "0x182008260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2008570", Offset = "0x2007970", VA = "0x182008570")]
	public readonly LADHNICFHEI KPIBKDOHBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2008830", Offset = "0x2007C30", VA = "0x182008830")]
	public DFKPAEMPCKH<OGMOCINGCKO> NCEEJBBIDDO(DFKPAEMPCKH<CEAIECNFGDF> ILPFPPMNEDJ)
	{
		return default(DFKPAEMPCKH<OGMOCINGCKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2008040", Offset = "0x2007440", VA = "0x182008040")]
	public void BNLEGFFBAHJ(DFKPAEMPCKH<OGMOCINGCKO> GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2008400", Offset = "0x2007800", VA = "0x182008400")]
	[CompilerGenerated]
	internal static AMCMIECDCNA IPAHMAMJBHH([In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JKEBCCHJGII : IEnumerator<DFKPAEMPCKH<OGMOCINGCKO>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE IIKBBLGDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE MBJPLBLIDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> MEMEFBAODAG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DFKPAEMPCKH<OGMOCINGCKO> AKMKAIGAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x200B370", Offset = "0x200A770", VA = "0x18200B370", Slot = "4")]
		get
		{
			return default(DFKPAEMPCKH<OGMOCINGCKO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x200B300", Offset = "0x200A700", VA = "0x18200B300", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2007FA0", Offset = "0x20073A0", VA = "0x182007FA0")]
	internal JKEBCCHJGII([In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE NHMMGAFKHFM, [In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE EGKLPPJDMHL, [In] AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> NJILGHOJAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x200B160", Offset = "0x200A560", VA = "0x18200B160", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x200B2A0", Offset = "0x200A6A0", VA = "0x18200B2A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x200B100", Offset = "0x200A500", VA = "0x18200B100", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class FOLOMCMBOFB
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x200A3E0", Offset = "0x20097E0", VA = "0x18200A3E0")]
	public static DNGAPNAKHNH JLCLGLEKPEG(this LADHNICFHEI ABPJKOBADEP)
	{
		return default(DNGAPNAKHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x200A1B0", Offset = "0x20095B0", VA = "0x18200A1B0")]
	[CompilerGenerated]
	internal static PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> FHKNKEJIHPG(AMCMIECDCNA ABPJKOBADEP)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct ENJMFBHOCCF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public HHJPMJCHLHK<CEAIECNFGDF> EAGKPCLLPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public AEOJAEFAFAE<CEAIECNFGDF, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> ILHLENJMJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public AEOJAEFAFAE<CEAIECNFGDF, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> AFNDAMFLKHF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x20088F0", Offset = "0x2007CF0", VA = "0x1820088F0")]
	public ENJMFBHOCCF([In] HHJPMJCHLHK<CEAIECNFGDF> JPDAPDOGCLE, [In] AEOJAEFAFAE<CEAIECNFGDF, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> BFGMEIFFLLC, [In] AEOJAEFAFAE<CEAIECNFGDF, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> JGFPDEKBLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2008EB0", Offset = "0x20082B0", VA = "0x182008EB0")]
	public static ENJMFBHOCCF DDEJLDFANAB()
	{
		return default(ENJMFBHOCCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2008F90", Offset = "0x2008390", VA = "0x182008F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2009260", Offset = "0x2008660", VA = "0x182009260")]
	public readonly PPIIIILHODF KPIBKDOHBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2009830", Offset = "0x2008C30", VA = "0x182009830")]
	public DFKPAEMPCKH<CEAIECNFGDF> NCEEJBBIDDO([In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> BFGMEIFFLLC, [In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> JGFPDEKBLBG)
	{
		return default(DFKPAEMPCKH<CEAIECNFGDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2008D20", Offset = "0x2008120", VA = "0x182008D20")]
	public void BNLEGFFBAHJ(DFKPAEMPCKH<CEAIECNFGDF> GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2009550", Offset = "0x2008950", VA = "0x182009550")]
	[CompilerGenerated]
	internal static JMPIOEAGJEE MBHPGBPDGBM([In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> ABPJKOBADEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x20096C0", Offset = "0x2008AC0", VA = "0x1820096C0")]
	[CompilerGenerated]
	internal static MCMKNFCJCCO MMIHMLGKDBJ([In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AAJLKNNDEDL : IEnumerator<DFKPAEMPCKH<CEAIECNFGDF>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JKEBCCHJGII HNNGBFNLPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<CEAIECNFGDF>> BAGHFFIHCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private CHDOMIFJMFM HOJHCONDBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<CEAIECNFGDF>> JPNBCCJLPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool LOGKAKEGICN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly DFKPAEMPCKH<CEAIECNFGDF> AKMKAIGAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x20049C0", Offset = "0x2003DC0", VA = "0x1820049C0", Slot = "4")]
		get
		{
			return default(DFKPAEMPCKH<CEAIECNFGDF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20048C0", Offset = "0x2003CC0", VA = "0x1820048C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2004910", Offset = "0x2003D10", VA = "0x182004910")]
	internal AAJLKNNDEDL([In] JKEBCCHJGII IJOCDKCHPJF, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<CEAIECNFGDF>> OMCHNNDEAIM, [In] CHDOMIFJMFM ABKFJENOHJL, [In] AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<CEAIECNFGDF>> AHFMDJFIFPO, bool INNCKAHEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20047C0", Offset = "0x2003BC0", VA = "0x1820047C0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2004810", Offset = "0x2003C10", VA = "0x182004810", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2004720", Offset = "0x2003B20", VA = "0x182004720", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class FGJJNGBCGKN
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2009D40", Offset = "0x2009140", VA = "0x182009D40")]
	internal static ENJMFBHOCCF JLCLGLEKPEG(this PPIIIILHODF ABPJKOBADEP)
	{
		return default(ENJMFBHOCCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20098E0", Offset = "0x2008CE0", VA = "0x1820098E0")]
	[CompilerGenerated]
	internal static PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> CBDAEKDHMHC(JMPIOEAGJEE ABPJKOBADEP)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2009B10", Offset = "0x2008F10", VA = "0x182009B10")]
	[CompilerGenerated]
	internal static PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> HJCDBOJCKMN(MCMKNFCJCCO ABPJKOBADEP)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal struct HKOPDIAENKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public HHJPMJCHLHK<ADOPGBMODDE> EAGKPCLLPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<CEAIECNFGDF>> EAPLGFNFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> ILHLENJMJDO;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20088F0", Offset = "0x2007CF0", VA = "0x1820088F0")]
	public HKOPDIAENKI([In] HHJPMJCHLHK<ADOPGBMODDE> JPDAPDOGCLE, [In] AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<CEAIECNFGDF>> LPNMGCMAJOP, [In] AEOJAEFAFAE<ADOPGBMODDE, PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>> BFGMEIFFLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x200A990", Offset = "0x2009D90", VA = "0x18200A990")]
	public static HKOPDIAENKI DDEJLDFANAB()
	{
		return default(HKOPDIAENKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x200AA70", Offset = "0x2009E70", VA = "0x18200AA70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x200AD80", Offset = "0x200A180", VA = "0x18200AD80")]
	public readonly MKLBPLPDLBG KPIBKDOHBCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x200B040", Offset = "0x200A440", VA = "0x18200B040")]
	public DFKPAEMPCKH<ADOPGBMODDE> NCEEJBBIDDO(DFKPAEMPCKH<CEAIECNFGDF> ILPFPPMNEDJ)
	{
		return default(DFKPAEMPCKH<ADOPGBMODDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x200A850", Offset = "0x2009C50", VA = "0x18200A850")]
	public void BNLEGFFBAHJ(DFKPAEMPCKH<ADOPGBMODDE> GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x200AC10", Offset = "0x200A010", VA = "0x18200AC10")]
	[CompilerGenerated]
	internal static IFFKMFDICLP GBOOBKGGFIL([In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> ABPJKOBADEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CHDOMIFJMFM : IEnumerator<DFKPAEMPCKH<ADOPGBMODDE>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE DOLMLIFAGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE CDPKKNPAABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly AEOJAEFAFAE<OGMOCINGCKO, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> DPIHLACILEE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DFKPAEMPCKH<ADOPGBMODDE> AKMKAIGAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2008000", Offset = "0x2007400", VA = "0x182008000", Slot = "4")]
		get
		{
			return default(DFKPAEMPCKH<ADOPGBMODDE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2007F30", Offset = "0x2007330", VA = "0x182007F30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2007FA0", Offset = "0x20073A0", VA = "0x182007FA0")]
	internal CHDOMIFJMFM([In] PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>.EECPBEONMBE FJKAOIDJBAF, [In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>.EECPBEONMBE AMOOACFMKKJ, [In] AEOJAEFAFAE<OGMOCINGCKO, PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>>> HIOKGPGGMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2007D90", Offset = "0x2007190", VA = "0x182007D90", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2007ED0", Offset = "0x20072D0", VA = "0x182007ED0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2007D30", Offset = "0x2007130", VA = "0x182007D30", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class JKKLKOGBDGH
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x200B3B0", Offset = "0x200A7B0", VA = "0x18200B3B0")]
	public static HKOPDIAENKI JLCLGLEKPEG(this MKLBPLPDLBG ABPJKOBADEP)
	{
		return default(HKOPDIAENKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x200B820", Offset = "0x200AC20", VA = "0x18200B820")]
	[CompilerGenerated]
	internal static PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> JPKNNIHJBGA(IFFKMFDICLP ABPJKOBADEP)
	{
		return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>);
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

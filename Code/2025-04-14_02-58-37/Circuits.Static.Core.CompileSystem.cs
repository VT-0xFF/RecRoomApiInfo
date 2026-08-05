using System;
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x26B60F0", Offset = "0x26B4AF0", VA = "0x1826B60F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct MCBANPPEIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> MLKHHLJPAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int KHMMHBDHIKP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
	public MCBANPPEIJN(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> OINHMALLBOO, int LMGBAALNFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OCNPCNJNAIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MDGFPFHPOOG : PDGDIMJIDJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NJHLOJOHMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly MAHBDBKPKJC<byte> ONBNBKAMEHK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2663FC0", Offset = "0x26629C0", VA = "0x182663FC0")]
		public NJHLOJOHMEL(MAHBDBKPKJC<byte> OHAFLBCBHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x26B6080", Offset = "0x26B4A80", VA = "0x1826B6080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ABBIPPBMKGN : PDGDIMJIDJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct DFBINPHMPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> BAPEPCAAAAL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public DFBINPHMPMF(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> MLGBFNFHJGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NJOLKJNKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class JADKIDDLLDJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PDGDIMJIDJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HHHJCDKONPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly NJOLKJNKCHH BAIECMFNGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly NBPBIJJFIMI<PDGDIMJIDJN> JMBIJFPKJIJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		public HHHJCDKONPK(NJOLKJNKCHH CCNJGHCOOKI, NBPBIJJFIMI<PDGDIMJIDJN> BAEEFOAPAND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class LDABODAAFBP : PDGDIMJIDJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct AFDIMGLCCJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FHGEGPAFIPO;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public AFDIMGLCCJK(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class LLNHIANCKBG : PDGDIMJIDJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct LDMAAAEPDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GBBLAFAAPBP GNKEEHPINAO;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public LDMAAAEPDBI(GBBLAFAAPBP NMIJFPEAPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26B4AE0", Offset = "0x26B34E0", VA = "0x1826B4AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal GMOODHAOECL<JADKIDDLLDJ, HHHJCDKONPK> JFHOKFOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal GMOODHAOECL<MDGFPFHPOOG, NJHLOJOHMEL> NCLHAFEMKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal GMOODHAOECL<ABBIPPBMKGN, DFBINPHMPMF> IDKHJDALBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GMOODHAOECL<LDABODAAFBP, AFDIMGLCCJK> KCFMOIFLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal GMOODHAOECL<LLNHIANCKBG, LDMAAAEPDBI> IGEKCOKOHPN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26B62B0", Offset = "0x26B4CB0", VA = "0x1826B62B0")]
	private OCNPCNJNAIL([In] GMOODHAOECL<JADKIDDLLDJ, HHHJCDKONPK> IKEKHCIOGKI, [In] GMOODHAOECL<MDGFPFHPOOG, NJHLOJOHMEL> ICPEIJFMNEI, [In] GMOODHAOECL<ABBIPPBMKGN, DFBINPHMPMF> FCHNDHAGOBH, [In] GMOODHAOECL<LDABODAAFBP, AFDIMGLCCJK> FLKKNNPHGCD, [In] GMOODHAOECL<LLNHIANCKBG, LDMAAAEPDBI> ICCNEKCANFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26B6170", Offset = "0x26B4B70", VA = "0x1826B6170")]
	public static OCNPCNJNAIL DDDHPONDPCL()
	{
		return default(OCNPCNJNAIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KGAPNCOBCKL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26B4A30", Offset = "0x26B3430", VA = "0x1826B4A30")]
	public static void HEJCAAOAKNK(this OCNPCNJNAIL IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum MEKHHHAMEGN
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MJKHHJCMIGA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class LHOEFPBJACC : DBJINMEEEMK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LGHNFILBBDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> DMPFHKNMLFJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public LGHNFILBBDO(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CCJDKDEIJID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum GJMIEKFHDJO
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class CNHLFDNADPP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class DBJINMEEEMK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct BFFPDAGNCNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly GJMIEKFHDJO BAIECMFNGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly NBPBIJJFIMI<DBJINMEEEMK> JMBIJFPKJIJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		public BFFPDAGNCNB(GJMIEKFHDJO CCNJGHCOOKI, NBPBIJJFIMI<DBJINMEEEMK> BAEEFOAPAND)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GMOODHAOECL<CNHLFDNADPP, BFFPDAGNCNB> JFHOKFOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GMOODHAOECL<LHOEFPBJACC, LGHNFILBBDO> GPMHIAADEJB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26AD6F0", Offset = "0x26AC0F0", VA = "0x1826AD6F0")]
	private MJKHHJCMIGA([In] GMOODHAOECL<CNHLFDNADPP, BFFPDAGNCNB> IKEKHCIOGKI, [In] GMOODHAOECL<LHOEFPBJACC, LGHNFILBBDO> PGCGANJHIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26B5C60", Offset = "0x26B4660", VA = "0x1826B5C60")]
	public static MJKHHJCMIGA DDDHPONDPCL()
	{
		return default(MJKHHJCMIGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MJJHJKEGMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26B5C00", Offset = "0x26B4600", VA = "0x1826B5C00")]
	public static void HEJCAAOAKNK(this MJKHHJCMIGA IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JIAICMGPCEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public CHFNJPOOAHD<int> FHHAGCNNMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public CHFNJPOOAHD<int> EBADGNPBCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PDEFFDJENKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int ABAOLENEBIF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26B4700", Offset = "0x26B3100", VA = "0x1826B4700")]
	private JIAICMGPCEA([In] CHFNJPOOAHD<int> KMFELDPPIDN, [In] CHFNJPOOAHD<int> CMLBNGOIDEL, int BJOHOFHOLNK, int JMMCAEHEAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26B4660", Offset = "0x26B3060", VA = "0x1826B4660")]
	public static JIAICMGPCEA DDDHPONDPCL()
	{
		return default(JIAICMGPCEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FMMAOMOHJGF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26B2E60", Offset = "0x26B1860", VA = "0x1826B2E60")]
	public static void HEJCAAOAKNK(this JIAICMGPCEA IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IPIEOJOIPKI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum AIKMFMDKBGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class NLGFMIHODMJ : JGIKFOEPLFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct FBFPLEIJHKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly NBPBIJJFIMI<LKCPKGPKGPC> LPHFLBBFIDI;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public FBFPLEIJHKK(NBPBIJJFIMI<LKCPKGPKGPC> KCJMJIGDJMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LJJOELGJPEH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class JGIKFOEPLFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct EMEOCIDIPPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly AIKMFMDKBGC BAIECMFNGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly NBPBIJJFIMI<JGIKFOEPLFA> JMBIJFPKJIJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		private EMEOCIDIPPK(AIKMFMDKBGC CCNJGHCOOKI, NBPBIJJFIMI<JGIKFOEPLFA> BAEEFOAPAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x26B2C00", Offset = "0x26B1600", VA = "0x1826B2C00")]
		public static EMEOCIDIPPK DDDHPONDPCL(AIKMFMDKBGC CCNJGHCOOKI, NBPBIJJFIMI<JGIKFOEPLFA> BAEEFOAPAND)
		{
			return default(EMEOCIDIPPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NBHCGJMEPCI : JGIKFOEPLFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PFNHFBMJIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly NBPBIJJFIMI<LKCPKGPKGPC> LPHFLBBFIDI;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public PFNHFBMJIIM(NBPBIJJFIMI<LKCPKGPKGPC> KCJMJIGDJMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class LKCPKGPKGPC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct COMJIBCFKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CHFNJPOOAHD<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> HPNFOIGHCHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CHFNJPOOAHD<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> OBNEMAIDLOC;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26AD6F0", Offset = "0x26AC0F0", VA = "0x1826AD6F0")]
		private COMJIBCFKKO([In] CHFNJPOOAHD<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> ONKFKALHDID, [In] CHFNJPOOAHD<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> BLBAKABABNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x26AD670", Offset = "0x26AC070", VA = "0x1826AD670")]
		public static COMJIBCFKKO DDDHPONDPCL()
		{
			return default(COMJIBCFKKO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal GMOODHAOECL<LJJOELGJPEH, EMEOCIDIPPK> JFHOKFOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal GMOODHAOECL<NBHCGJMEPCI, PFNHFBMJIIM> NBEGNBIGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GMOODHAOECL<NLGFMIHODMJ, FBFPLEIJHKK> NPMECGEIILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal CHFNJPOOAHD<(NBPBIJJFIMI<LJJOELGJPEH> CallId, NBPBIJJFIMI<LKCPKGPKGPC> IOId)> DOFKADGFFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GMOODHAOECL<LKCPKGPKGPC, COMJIBCFKKO> JKCLHONJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal GDANPEAMDGC<LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> AFLIEEKGNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal GDANPEAMDGC<LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> JJIKEDIGKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26B3A90", Offset = "0x26B2490", VA = "0x1826B3A90")]
	private IPIEOJOIPKI([In] GMOODHAOECL<LJJOELGJPEH, EMEOCIDIPPK> IKEKHCIOGKI, [In] GMOODHAOECL<NBHCGJMEPCI, PFNHFBMJIIM> IEEEDCGJPLE, [In] GMOODHAOECL<NLGFMIHODMJ, FBFPLEIJHKK> LLOPPOBMKKG, [In] CHFNJPOOAHD<(NBPBIJJFIMI<LJJOELGJPEH> CallId, NBPBIJJFIMI<LKCPKGPKGPC> IOId)> LKJHOGIKKNF, [In] GMOODHAOECL<LKCPKGPKGPC, COMJIBCFKKO> IONDNFBAFDJ, [In] GDANPEAMDGC<LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> OCFMMDKIAML, [In] GDANPEAMDGC<LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> FNLHHLHDEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x26B38F0", Offset = "0x26B22F0", VA = "0x1826B38F0")]
	public static IPIEOJOIPKI DDDHPONDPCL()
	{
		return default(IPIEOJOIPKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MJDIEPMFAJE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26B5A20", Offset = "0x26B4420", VA = "0x1826B5A20")]
	private static void HEJCAAOAKNK(this IPIEOJOIPKI.COMJIBCFKKO IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26B5810", Offset = "0x26B4210", VA = "0x1826B5810")]
	public static void HEJCAAOAKNK(this IPIEOJOIPKI IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LOMNDDKOIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CHFNJPOOAHD<byte> LAEFJJDIIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IPIEOJOIPKI DLOONKBMEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GCNDGJPHGKF ODFKCPPPGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> PDFOPOCPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OCNPCNJNAIL FMLAEKLCCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal MJKHHJCMIGA PDKEJJKAFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GDANPEAMDGC<OGEPMJHDEGM, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>?> HGGKCIIFMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal CHFNJPOOAHD<NBPBIJJFIMI<OGEPMJHDEGM>> NCACINLKAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> NPJKODFLGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> OGLIEDAPPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> FIFCFNCAJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal NJBCONPEEFH ABMPDHGLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ENGAOHDJFLC JCCKLMOOEKJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26B54B0", Offset = "0x26B3EB0", VA = "0x1826B54B0")]
	private LOMNDDKOIEJ([In] CHFNJPOOAHD<byte> KLCNPGEPCCL, [In] IPIEOJOIPKI KBLJHONNCLO, [In] GCNDGJPHGKF LJCCDAOJBNL, [In] OCNPCNJNAIL PHICKPCCMOI, [In] MJKHHJCMIGA OMABBHBMGOG, [In] GDANPEAMDGC<OGEPMJHDEGM, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>?> AFHAOCGKDBF, [In] CHFNJPOOAHD<NBPBIJJFIMI<OGEPMJHDEGM>> JLNHDDCMGIM, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> DOJMNPPBJKI, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> GHKGJMNHKEO, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> GJGILLJLMOK, [In] NJBCONPEEFH INGHIMPNENF, [In] ENGAOHDJFLC FEOOPGBPPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26B4B00", Offset = "0x26B3500", VA = "0x1826B4B00")]
	public static LOMNDDKOIEJ DDDHPONDPCL()
	{
		return default(LOMNDDKOIEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CKCIKADEJDJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct FJEABMNKFIG : OJMCCCMJCGL<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x26B2D90", Offset = "0x26B1790", VA = "0x1826B2D90")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x26B2D60", Offset = "0x26B1760", VA = "0x1826B2D60", Slot = "4")]
		public NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		public bool DLGEKMAGCLA(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "5")]
		private bool JAFNMNFLODH(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x26B2D50", Offset = "0x26B1750", VA = "0x1826B2D50", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> GCKKCMJOGNA(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct AFGHPPBBKHA : JCFLNMNHOLD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x26AA850", Offset = "0x26A9250", VA = "0x1826AA850")]
		public CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> HNFGHLLJOKP(int MMEKJMOECKP, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x26AA980", Offset = "0x26A9380", VA = "0x1826AA980")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x26AA8C0", Offset = "0x26A92C0", VA = "0x1826AA8C0", Slot = "6")]
		public void LEIIDDCJGHD(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x26AA850", Offset = "0x26A9250", VA = "0x1826AA850", Slot = "4")]
		private CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> EPHKPGPDGBF(int MMEKJMOECKP, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x26AA840", Offset = "0x26A9240", VA = "0x1826AA840", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> CDKLJDBHIFI(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct NBNONDAMOJA : OJMCCCMJCGL<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D30", Offset = "0x26B4730", VA = "0x1826B5D30")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D00", Offset = "0x26B4700", VA = "0x1826B5D00", Slot = "4")]
		public NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		public bool DLGEKMAGCLA(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "5")]
		private bool JPJDHIECIGB(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x26B5CF0", Offset = "0x26B46F0", VA = "0x1826B5CF0", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> FFLNHHEICPL(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct FPMIHEKPOKB : JCFLNMNHOLD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x26B2F60", Offset = "0x26B1960", VA = "0x1826B2F60")]
		public CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> HNFGHLLJOKP(int MMEKJMOECKP, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x26B30A0", Offset = "0x26B1AA0", VA = "0x1826B30A0")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26B2FE0", Offset = "0x26B19E0", VA = "0x1826B2FE0", Slot = "6")]
		public void LEIIDDCJGHD(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26B2F60", Offset = "0x26B1960", VA = "0x1826B2F60", Slot = "4")]
		private CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> AACECBNLGIA(int MMEKJMOECKP, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x26B2FD0", Offset = "0x26B19D0", VA = "0x1826B2FD0", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> HEIOGAEBELE(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> DOAKEFBOPIA, [In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct MJHIMKDCDPJ : OJMCCCMJCGL<NBPBIJJFIMI<FNKGPOLCLJE>, GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x26B5B30", Offset = "0x26B4530", VA = "0x1826B5B30")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x26B5AF0", Offset = "0x26B44F0", VA = "0x1826B5AF0", Slot = "4")]
		public NBPBIJJFIMI<FNKGPOLCLJE> JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(NBPBIJJFIMI<FNKGPOLCLJE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x26B5A70", Offset = "0x26B4470", VA = "0x1826B5A70")]
		public bool DLGEKMAGCLA(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x26B5A70", Offset = "0x26B4470", VA = "0x1826B5A70", Slot = "5")]
		private bool DJCHBFJOAGB(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26B5B20", Offset = "0x26B4520", VA = "0x1826B5B20", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> KFMFGKPPDHE(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct HBCKBAJAAEN : JCFLNMNHOLD<NBPBIJJFIMI<FNKGPOLCLJE>, GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26B3560", Offset = "0x26B1F60", VA = "0x1826B3560")]
		public CHFNJPOOAHD<NBPBIJJFIMI<FNKGPOLCLJE>> HNFGHLLJOKP(int MMEKJMOECKP, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<FNKGPOLCLJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x26B36C0", Offset = "0x26B20C0", VA = "0x1826B36C0")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x26B35E0", Offset = "0x26B1FE0", VA = "0x1826B35E0", Slot = "6")]
		public void LEIIDDCJGHD(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26B3560", Offset = "0x26B1F60", VA = "0x1826B3560", Slot = "4")]
		private CHFNJPOOAHD<NBPBIJJFIMI<FNKGPOLCLJE>> GDGMEHOIMIJ(int MMEKJMOECKP, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<NBPBIJJFIMI<FNKGPOLCLJE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26B35D0", Offset = "0x26B1FD0", VA = "0x1826B35D0", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> HAFIOBHLFCO(NBPBIJJFIMI<FNKGPOLCLJE> DOAKEFBOPIA, [In] GDANPEAMDGC<FNKGPOLCLJE, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>?> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct PHMDHGMABBL : OJMCCCMJCGL<int, CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26B6400", Offset = "0x26B4E00", VA = "0x1826B6400")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD2D4E0", Offset = "0xD2BEE0", VA = "0x180D2D4E0", Slot = "4")]
		public int JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		public bool DLGEKMAGCLA(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "5")]
		private bool EHCDIJOHFBE(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x26B63F0", Offset = "0x26B4DF0", VA = "0x1826B63F0", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> ACHHACKFFAP(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct KEODACLBHIH : JCFLNMNHOLD<int, CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x26B4820", Offset = "0x26B3220", VA = "0x1826B4820")]
		public CHFNJPOOAHD<int> HNFGHLLJOKP(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26B4990", Offset = "0x26B3390", VA = "0x1826B4990")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26B4890", Offset = "0x26B3290", VA = "0x1826B4890", Slot = "6")]
		public void LEIIDDCJGHD(int DOAKEFBOPIA, CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x26B4820", Offset = "0x26B3220", VA = "0x1826B4820", Slot = "4")]
		private CHFNJPOOAHD<int> OEPAANEKLNL(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x26B4810", Offset = "0x26B3210", VA = "0x1826B4810", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> BNEFMMCKKFG(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> VariableId, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<GDGLAEPKNCJ>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct ONNOOGMBIEI : OJMCCCMJCGL<int, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x26B6350", Offset = "0x26B4D50", VA = "0x1826B6350")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD2D4E0", Offset = "0xD2BEE0", VA = "0x180D2D4E0", Slot = "4")]
		public int JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		public bool DLGEKMAGCLA(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "5")]
		private bool EKAIPNHFOLL(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26B6340", Offset = "0x26B4D40", VA = "0x1826B6340", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> CEIJJLGGNKI(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct ALKDFAFEPPA : JCFLNMNHOLD<int, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26AAA30", Offset = "0x26A9430", VA = "0x1826AAA30")]
		public CHFNJPOOAHD<int> HNFGHLLJOKP(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26AABA0", Offset = "0x26A95A0", VA = "0x1826AABA0")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x26AAAB0", Offset = "0x26A94B0", VA = "0x1826AAAB0", Slot = "6")]
		public void LEIIDDCJGHD(int DOAKEFBOPIA, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x26AAA30", Offset = "0x26A9430", VA = "0x1826AAA30", Slot = "4")]
		private CHFNJPOOAHD<int> DBBEBAKJCMH(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x26AAAA0", Offset = "0x26A94A0", VA = "0x1826AAAA0", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> DPEHPAJIHLB(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct FNJFEDCMEMH : OJMCCCMJCGL<int, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x26B2EC0", Offset = "0x26B18C0", VA = "0x1826B2EC0")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD2D4E0", Offset = "0xD2BEE0", VA = "0x180D2D4E0", Slot = "4")]
		public int JNJKANCDIJN(int DOAKEFBOPIA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410")]
		public bool DLGEKMAGCLA(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "5")]
		private bool EKAIPNHFOLL(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x26B2EB0", Offset = "0x26B18B0", VA = "0x1826B2EB0", Slot = "6")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> CEIJJLGGNKI(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct DKBJBICJIBK : JCFLNMNHOLD<int, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x26AD730", Offset = "0x26AC130", VA = "0x1826AD730")]
		public CHFNJPOOAHD<int> HNFGHLLJOKP(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x26AD8B0", Offset = "0x26AC2B0", VA = "0x1826AD8B0")]
		public NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x26AD7B0", Offset = "0x26AC1B0", VA = "0x1826AD7B0", Slot = "6")]
		public void LEIIDDCJGHD(int DOAKEFBOPIA, CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x26AD730", Offset = "0x26AC130", VA = "0x1826AD730", Slot = "4")]
		private CHFNJPOOAHD<int> DBBEBAKJCMH(int MMEKJMOECKP, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(CHFNJPOOAHD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x26AD7A0", Offset = "0x26AC1A0", VA = "0x1826AD7A0", Slot = "5")]
		private NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> DPEHPAJIHLB(int DOAKEFBOPIA, [In] CHFNJPOOAHD<(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> Target, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> ByteCodeWriteLocation)> IOMEFCNHNJN)
		{
			return default(NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct HHGJIAJIEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> LPDLJCDNLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool ALKKJOLEEAB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D7A9D0", Offset = "0x1D793D0", VA = "0x181D7A9D0")]
		public HHGJIAJIEAP(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, bool NOALDLNHHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x26B3790", Offset = "0x26B2190", VA = "0x1826B3790")]
		public void EHJACGLEOBL([Out] NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, [Out] bool NOALDLNHHGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct GPLIPIMNOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly NBPBIJJFIMI<FNKGPOLCLJE> GCALAECMENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> LPDLJCDNLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool ALKKJOLEEAB;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x26B3550", Offset = "0x26B1F50", VA = "0x1826B3550")]
		public GPLIPIMNOKL(NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, bool NOALDLNHHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x26B3540", Offset = "0x26B1F40", VA = "0x1826B3540")]
		public void EHJACGLEOBL([Out] NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, [Out] bool NOALDLNHHGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x26B3520", Offset = "0x26B1F20", VA = "0x1826B3520")]
		public void EHJACGLEOBL([Out] NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, [Out] NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ, [Out] bool NOALDLNHHGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct HKOGBMKAMKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly NBPBIJJFIMI<FNKGPOLCLJE> GCALAECMENJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> LPDLJCDNLPJ;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		public HKOGBMKAMKD(NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x26B3850", Offset = "0x26B2250", VA = "0x1826B3850")]
		public void EHJACGLEOBL([Out] NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG, [Out] NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26ABE10", Offset = "0x26AA810", VA = "0x1826ABE10")]
	public static void HEJCAAOAKNK(this LOMNDDKOIEJ IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26AC9D0", Offset = "0x26AB3D0", VA = "0x1826AC9D0")]
	public static void JLLBJEPLLGJ(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CMIEEONFFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26AB540", Offset = "0x26A9F40", VA = "0x1826AB540")]
	public static void CFJBLDFECPJ(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CMIEEONFFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26ACAE0", Offset = "0x26AB4E0", VA = "0x1826ACAE0")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>? LAIPKMFEGEF([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26AC360", Offset = "0x26AAD60", VA = "0x1826AC360")]
	public static NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> IAOKLNNMLHH([In] this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26AC5C0", Offset = "0x26AAFC0", VA = "0x1826AC5C0")]
	private static void IEDAHJCEAAE(this LOMNDDKOIEJ IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26ABB00", Offset = "0x26AA500", VA = "0x1826ABB00")]
	private static NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>? FGDLEJPMKCM([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26AB760", Offset = "0x26AA160", VA = "0x1826AB760")]
	public static void ECKHGEHIPFL(this LOMNDDKOIEJ IJPDNJELPLO, [In] CHFNJPOOAHD<MCBANPPEIJN> FAGOBBANKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x26ACA60", Offset = "0x26AB460", VA = "0x1826ACA60")]
	public static OCNPCNJNAIL.NJOLKJNKCHH KPEIJBGMKDI([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(OCNPCNJNAIL.NJOLKJNKCHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26AC7B0", Offset = "0x26AB1B0", VA = "0x1826AC7B0")]
	public static MAHBDBKPKJC<byte> IPBMGJHEAPB([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(MAHBDBKPKJC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26AD130", Offset = "0x26ABB30", VA = "0x1826AD130")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> MNLOIFBFNDO([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26AB160", Offset = "0x26A9B60", VA = "0x1826AB160")]
	public static GBBLAFAAPBP AFDNCCJLFOA([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(GBBLAFAAPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x34241C0", Offset = "0x3422BC0", VA = "0x1834241C0")]
	private static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> LBDIIHKOKEJ<TMJoin>(this LOMNDDKOIEJ IJPDNJELPLO, OCNPCNJNAIL.NJOLKJNKCHH CCNJGHCOOKI, NBPBIJJFIMI<TMJoin> BAEEFOAPAND) where TMJoin : OCNPCNJNAIL.PDGDIMJIDJN
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26AC730", Offset = "0x26AB130", VA = "0x1826AC730")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> IODGKKHMBGK(this LOMNDDKOIEJ IJPDNJELPLO, bool IKKJHJNLFID)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26AB320", Offset = "0x26A9D20", VA = "0x1826AB320")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> ALGHCBFJHOO(this LOMNDDKOIEJ IJPDNJELPLO, MAHBDBKPKJC<byte> OHAFLBCBHHH)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26ACBA0", Offset = "0x26AB5A0", VA = "0x1826ACBA0")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> LDHKOPKLDLE(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> MLGBFNFHJGM)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26AB2A0", Offset = "0x26A9CA0", VA = "0x1826AB2A0")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> AJNJNLLPMGA(this LOMNDDKOIEJ IJPDNJELPLO, int AMIOHDOCHMP)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26AD3B0", Offset = "0x26ABDB0", VA = "0x1826AD3B0")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> PEIFAJAFMJE(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3424010", Offset = "0x3422A10", VA = "0x183424010")]
	private static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> IDNHNDGNCDC<TMJoin>(this LOMNDDKOIEJ IJPDNJELPLO, MJKHHJCMIGA.GJMIEKFHDJO CCNJGHCOOKI, NBPBIJJFIMI<TMJoin> BAEEFOAPAND) where TMJoin : MJKHHJCMIGA.DBJINMEEEMK
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x26ABDD0", Offset = "0x26AA7D0", VA = "0x1826ABDD0")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> GBFFLCNOENA(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26AB250", Offset = "0x26A9C50", VA = "0x1826AB250")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> AINIEDJLJFI(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x26AB610", Offset = "0x26AA010", VA = "0x1826AB610")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> DFAOJJJPHAJ(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CCJDKDEIJID)
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x26AB9C0", Offset = "0x26AA3C0", VA = "0x1826AB9C0")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> EJAEOIFBECD(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x26AD2E0", Offset = "0x26ABCE0", VA = "0x1826AD2E0")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> OLNLFEAIBBA(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x26AD330", Offset = "0x26ABD30", VA = "0x1826AD330")]
	public static IPIEOJOIPKI.AIKMFMDKBGC PACDMKFEAIA([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM)
	{
		return default(IPIEOJOIPKI.AIKMFMDKBGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x26AC580", Offset = "0x26AAF80", VA = "0x1826AC580")]
	public static ANPIJCPJHJI<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, CGFMEJBEPBH<IPIEOJOIPKI.LKCPKGPKGPC>> ICBKDNHAENF([In] this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(ANPIJCPJHJI<NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>, CGFMEJBEPBH<IPIEOJOIPKI.LKCPKGPKGPC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26ACCB0", Offset = "0x26AB6B0", VA = "0x1826ACCB0")]
	public static NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> MCFGHJANNIL([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM)
	{
		return default(NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26AAFF0", Offset = "0x26A99F0", VA = "0x1826AAFF0")]
	public static IPIEOJOIPKI.COMJIBCFKKO ACLDCGAKDNA([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> KCJMJIGDJMJ)
	{
		return default(IPIEOJOIPKI.COMJIBCFKKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26AD0B0", Offset = "0x26ABAB0", VA = "0x1826AD0B0")]
	public static IPIEOJOIPKI.COMJIBCFKKO MMMHLLNKHEA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> KCJMJIGDJMJ)
	{
		return default(IPIEOJOIPKI.COMJIBCFKKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3423F70", Offset = "0x3422970", VA = "0x183423F70")]
	private static NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> HCNBIDFHIPL<TMJoin>(this LOMNDDKOIEJ IJPDNJELPLO, IPIEOJOIPKI.AIKMFMDKBGC CCNJGHCOOKI, NBPBIJJFIMI<TMJoin> BAEEFOAPAND) where TMJoin : IPIEOJOIPKI.JGIKFOEPLFA
	{
		return default(NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26ABBC0", Offset = "0x26AA5C0", VA = "0x1826ABBC0")]
	public static (NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>) FIBCPKKHKBD(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default((NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26ACE90", Offset = "0x26AB890", VA = "0x1826ACE90")]
	public static (NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>) MGNPKBEABEA(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default((NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26AD220", Offset = "0x26ABC20", VA = "0x1826AD220")]
	public static NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> NNDILNGNJEC(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26AC4F0", Offset = "0x26AAEF0", VA = "0x1826AC4F0")]
	public static void IBPIGKPBPEP(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC> KCJMJIGDJMJ, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> AIDDMGCACIL, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>> LCFPLEBDCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3422740", Offset = "0x3421140", VA = "0x183422740")]
	public static HHGJIAJIEAP CMHPAMHGMHL<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ) where TDeps : NEIOICCJMDO<TStateSys>
	{
		return default(HHGJIAJIEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3424270", Offset = "0x3422C70", VA = "0x183424270")]
	public static GPLIPIMNOKL MCOLJPHAGIG<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<EAOBDBIODMJ> EGEPAJMBPNL, int CHLIFNNKBAA) where TDeps : NEIOICCJMDO<TStateSys>
	{
		return default(GPLIPIMNOKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3423570", Offset = "0x3421F70", VA = "0x183423570")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>? DNNANCAJGJK<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<EAOBDBIODMJ> EGEPAJMBPNL, [In] ReadOnlySpan<int> OAHFDFJHECA, [In] Span<HKOGBMKAMKD> DAAMMDALHDJ) where TDeps : NEIOICCJMDO<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34239B0", Offset = "0x34223B0", VA = "0x1834239B0")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> FAMOEOFDGHL<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO) where TDeps : NEIOICCJMDO<TStateSys>
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x26AB070", Offset = "0x26A9A70", VA = "0x1826AB070")]
	public static GCNDGJPHGKF.GGPGPJFCFJA AEJANIMNCMA([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return default(GCNDGJPHGKF.GGPGPJFCFJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x26AD580", Offset = "0x26ABF80", VA = "0x1826AD580")]
	public static GCNDGJPHGKF.GEKLJLANEPN POGKPDHHMPI([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return default(GCNDGJPHGKF.GEKLJLANEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x26AB8D0", Offset = "0x26AA2D0", VA = "0x1826AB8D0")]
	public static GCNDGJPHGKF.GBJLPHLDCEC EEMOONBBNDE([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return default(GCNDGJPHGKF.GBJLPHLDCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x26AB3B0", Offset = "0x26A9DB0", VA = "0x1826AB3B0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> BLAKJMLHMLH(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG, string EMLAIMJKHOE)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x26ABA10", Offset = "0x26AA410", VA = "0x1826ABA10")]
	public static GCNDGJPHGKF.DJJFAFBNMEH EKDMILHDIKD([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return default(GCNDGJPHGKF.DJJFAFBNMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x26AD040", Offset = "0x26ABA40", VA = "0x1826AD040")]
	public static GCNDGJPHGKF.POBFHJHDCOF MIGLJECDFIP([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return default(GCNDGJPHGKF.POBFHJHDCOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x26AD270", Offset = "0x26ABC70", VA = "0x1826AD270")]
	public static int? NOKEOOECDOK([In] this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x34240C0", Offset = "0x3422AC0", VA = "0x1834240C0")]
	private static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> KMMGFFAADEC<TMJoin>(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG, GCNDGJPHGKF.POBFHJHDCOF CCNJGHCOOKI, NBPBIJJFIMI<TMJoin> BAEEFOAPAND) where TMJoin : GCNDGJPHGKF.IPGKPGDBLKO
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26AC2B0", Offset = "0x26AACB0", VA = "0x1826AC2B0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HPPCEFGMPGI(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM, int DOAKEFBOPIA)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26AC970", Offset = "0x26AB370", VA = "0x1826AC970")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JKOLEAKNCJO(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26AD430", Offset = "0x26ABE30", VA = "0x1826AD430")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PJMAJHKMIIN(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? FJJJMMFDEKL, int? LKGMFDDKHLG)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26ACC20", Offset = "0x26AB620", VA = "0x1826ACC20")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> LHFJABKODEF(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG, int DOAKEFBOPIA)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26ABD70", Offset = "0x26AA770", VA = "0x1826ABD70")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FMMIPHJKJMD(this LOMNDDKOIEJ IJPDNJELPLO, int? LKGMFDDKHLG)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26AC170", Offset = "0x26AAB70", VA = "0x1826AC170")]
	public static void HMEGKHLNNFG(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM, int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26AC3C0", Offset = "0x26AADC0", VA = "0x1826AC3C0")]
	public static void IBOCHHJEJIO(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG, int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x26AC8A0", Offset = "0x26AB2A0", VA = "0x1826AC8A0")]
	public static void JAANELBPMGD(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26AC0E0", Offset = "0x26AAAE0", VA = "0x1826AC0E0")]
	public static void HGGKIAECOBM(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> HIKBDNMPFJK, NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> GHOEGJIGBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26AB690", Offset = "0x26AA090", VA = "0x1826AB690")]
	public static void DHOKCMNGAHD(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG, NBPBIJJFIMI<HBOGCCEGENA<KFLLEEAHILP>> DCBPKGLLBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3424510", Offset = "0x3422F10", VA = "0x183424510")]
	public static void PCBBJFMAEBH<M>(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EAAKMOIEGHG, NBPBIJJFIMI<HBOGCCEGENA<KBAFBHHBEMI<M>>> DCBPKGLLBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NEIOICCJMDO<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBPBIJJFIMI<MJPFCOJMNNI> HIBOOLGFAFJ(TStateSys OIKGJCKECJL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBPBIJJFIMI<MJPFCOJMNNI> PPPNIKDOBPG(TStateSys OIKGJCKECJL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBPBIJJFIMI<MJPFCOJMNNI> IPIJHJGFGAL(TStateSys OIKGJCKECJL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBPBIJJFIMI<MJPFCOJMNNI> DCCPCAOKKJM(TStateSys OIKGJCKECJL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> IMAONIIBENN(TStateSys OIKGJCKECJL, LOMNDDKOIEJ FJNIJPIMCOD, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> AGAEIOGGBPB(TStateSys OIKGJCKECJL, LOMNDDKOIEJ FJNIJPIMCOD, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BFCLNMKIGJE(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NBPBIJJFIMI<OGEPMJHDEGM> FABGCOGEFPL(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ, int OKIHHAGELCC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MEKHHHAMEGN NIJFDILCIPF(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MMBJIFFFOJG(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CKIIFCKOMBP(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MAHBDBKPKJC<byte> FJFMPMNCOPF(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(MAHBDBKPKJC<byte>, NBPBIJJFIMI<MJPFCOJMNNI>) LGGOOPELJLD(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<FNKGPOLCLJE> DMIKPHIAJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CPEHMGJOFBG(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NBPBIJJFIMI<FNKGPOLCLJE> CAHKLDGDBNL(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<OGEPMJHDEGM> EPJOALGENAO, int CHLIFNNKBAA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NBPBIJJFIMI<FNKGPOLCLJE> GFAANIEIGAL(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, NBPBIJJFIMI<EAOBDBIODMJ> EGEPAJMBPNL, int CHLIFNNKBAA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int LOIDPEIBGGI(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? OIIGLCDEBNB(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int CMJNMFJANGP(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? ONKJKBJLDME(TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG, int DOAKEFBOPIA);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EICLECKGLPK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34BE2C0", Offset = "0x34BCCC0", VA = "0x1834BE2C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI?> AJPINOOMHCG<T, TOpInput, TOpOutput>(this LOMNDDKOIEJ IJPDNJELPLO, T HIHOACCANFP, T JJEIFHEKJKL, int LCOKMFBHCMO, IntPtr AOJHJIACIOB)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34C0840", Offset = "0x34BF240", VA = "0x1834C0840")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI?> MPJCJNGAAJD<T, TOpInput, TOpOutput>(this LOMNDDKOIEJ IJPDNJELPLO, T HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL, int LCOKMFBHCMO, IntPtr AOJHJIACIOB)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34BE5C0", Offset = "0x34BCFC0", VA = "0x1834BE5C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI?> BEMDIFNKJFL<TOpInput, TOpOutput>(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL, int LCOKMFBHCMO, IntPtr AOJHJIACIOB)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26AE7C0", Offset = "0x26AD1C0", VA = "0x1826AE7C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EFNMOJEGILK(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, float IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x26AE540", Offset = "0x26ACF40", VA = "0x1826AE540")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DLPIPJPGKKO(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x26ADAD0", Offset = "0x26AC4D0", VA = "0x1826ADAD0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> BGNHAGMEGGH(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x26AED20", Offset = "0x26AD720", VA = "0x1826AED20")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FAPHDNFDKPH(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x26AF9A0", Offset = "0x26AE3A0", VA = "0x1826AF9A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HKIEDEBJILB(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x26AF1A0", Offset = "0x26ADBA0", VA = "0x1826AF1A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FGFPJCEEOCA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x26AFC00", Offset = "0x26AE600", VA = "0x1826AFC00")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HNFLKMDFBOM(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x26ADD10", Offset = "0x26AC710", VA = "0x1826ADD10")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CGCGIKIAPMD(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x26AE680", Offset = "0x26AD080", VA = "0x1826AE680")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EENKDKGEOKE(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x26AEB00", Offset = "0x26AD500", VA = "0x1826AEB00")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ELJCAHGKCKJ(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, int JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC00", Offset = "0x26AD600", VA = "0x1826AEC00")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ENKCHFBLNBP(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26AF2E0", Offset = "0x26ADCE0", VA = "0x1826AF2E0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FMMIOCNJAIC(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x26B1F10", Offset = "0x26B0910", VA = "0x1826B1F10")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OBCGCIABHPF(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, float JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26B01C0", Offset = "0x26AEBC0", VA = "0x1826B01C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> INEKJKKDGCN(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26B0410", Offset = "0x26AEE10", VA = "0x1826B0410")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JAHOAOFHPJI(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26B1D50", Offset = "0x26B0750", VA = "0x1826B1D50")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OAGPFCEEDCE(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, int JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x26ADA50", Offset = "0x26AC450", VA = "0x1826ADA50")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> BELPBMJAHJN(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26B0680", Offset = "0x26AF080", VA = "0x1826B0680")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> KDCOBKIKEPO(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x26AF520", Offset = "0x26ADF20", VA = "0x1826AF520")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> GNPNJKANEME(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, float JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x26AF420", Offset = "0x26ADE20", VA = "0x1826AF420")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> GIJIPIBOBLI(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26AEFE0", Offset = "0x26AD9E0", VA = "0x1826AEFE0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FDLBKKGJBIL(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x26B16D0", Offset = "0x26B00D0", VA = "0x1826B16D0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> MLOCEJHNONH(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, int JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x26AEE20", Offset = "0x26AD820", VA = "0x1826AEE20")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FDDFJJBOFDK(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x26AFD00", Offset = "0x26AE700", VA = "0x1826AFD00")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IDCOPPJCNBA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26B0780", Offset = "0x26AF180", VA = "0x1826B0780")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> KKIHPHEDOLK(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, float JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x26AF4A0", Offset = "0x26ADEA0", VA = "0x1826AF4A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> GLGMCCFKPMN(this LOMNDDKOIEJ IJPDNJELPLO, float HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x26ADC10", Offset = "0x26AC610", VA = "0x1826ADC10")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CACDCPACHBF(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x26B2A50", Offset = "0x26B1450", VA = "0x1826B2A50")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> PPGFLJMMKAG(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x26B12E0", Offset = "0x26AFCE0", VA = "0x1826B12E0")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> LLIIFFBMLBE(this LOMNDDKOIEJ IJPDNJELPLO, int PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x26AE9C0", Offset = "0x26AD3C0", VA = "0x1826AE9C0")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> EHNFFAGMDLG(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x26ADF50", Offset = "0x26AC950", VA = "0x1826ADF50")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> DGOENCLNLBK(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> OHMJCCMFGJG)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26B1590", Offset = "0x26AFF90", VA = "0x1826B1590")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> MBFKPHNGEEB(this LOMNDDKOIEJ IJPDNJELPLO, int PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26AEA60", Offset = "0x26AD460", VA = "0x1826AEA60")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> EICELMFCKAI(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x26AE100", Offset = "0x26ACB00", VA = "0x1826AE100")]
	public static (NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>) DHEFENKNDCE(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<EOKHHKDGEPC> LMIIMLGBDOG, [In] ReadOnlySpan<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> ONKFKALHDID, [In] ReadOnlySpan<int?> HILDLJFDNIH, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> CMLAHCBGNIG)
	{
		return default((NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26B0B00", Offset = "0x26AF500", VA = "0x1826B0B00")]
	public static (NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>) KPCHKKJHGOF(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<LKAJLDGJAFC> NNBNDLJKGEC, [In] ReadOnlySpan<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> ONKFKALHDID, [In] ReadOnlySpan<int?> HILDLJFDNIH, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> CMLAHCBGNIG)
	{
		return default((NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x34BFC00", Offset = "0x34BE600", VA = "0x1834BFC00")]
	public static (NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<MJPFCOJMNNI>>, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>, NBPBIJJFIMI<HBOGCCEGENA<TMarker>>, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>) LECFDMKLGMA<TMarker>(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<MJPFCOJMNNI> LCDNACJEBPN, [In] ReadOnlySpan<byte> DFPGGEDGGGN)
	{
		return default((NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<HBOGCCEGENA<MJPFCOJMNNI>>, NBPBIJJFIMI<HBOGCCEGENA<FPLJMKJPJAD>>, NBPBIJJFIMI<HBOGCCEGENA<TMarker>>, NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26B1610", Offset = "0x26B0010", VA = "0x1826B1610")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> MCHLBHOOOGE(this LOMNDDKOIEJ IJPDNJELPLO, int CGKFGDDBBPE, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x26AFD80", Offset = "0x26AE780", VA = "0x1826AFD80")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IFHELELHNAG(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CGKFGDDBBPE, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x26AF8B0", Offset = "0x26AE2B0", VA = "0x1826AF8B0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HKFLGECPHIE(this LOMNDDKOIEJ IJPDNJELPLO, [In] ReadOnlySpan<byte> CGKFGDDBBPE, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26B00A0", Offset = "0x26AEAA0", VA = "0x1826B00A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IMKKMDLOOLA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CGKFGDDBBPE, int PICLDLMFMMM, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x26AF6A0", Offset = "0x26AE0A0", VA = "0x1826AF6A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HEHPEIFMGDB(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, float IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26B2930", Offset = "0x26B1330", VA = "0x1826B2930")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PKHBMNLFHEE(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x26AFAC0", Offset = "0x26AE4C0", VA = "0x1826AFAC0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HKKFHOAMGNF(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x26B1360", Offset = "0x26AFD60", VA = "0x1826B1360")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> LNPPMBPJHGG(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x26B2710", Offset = "0x26B1110", VA = "0x1826B2710")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OMIJFLPLAHN(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x26B18D0", Offset = "0x26B02D0", VA = "0x1826B18D0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> NCDKENKKCII(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x26ADC90", Offset = "0x26AC690", VA = "0x1826ADC90")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CADNOCPLAJJ(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, int JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26B1850", Offset = "0x26B0250", VA = "0x1826B1850")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> NCDBMEBBLDH(this LOMNDDKOIEJ IJPDNJELPLO, int HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x26B0700", Offset = "0x26AF100", VA = "0x1826B0700")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> KIFPKNJMAKJ(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HIHOACCANFP, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JJEIFHEKJKL)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x26B1A10", Offset = "0x26B0410", VA = "0x1826B1A10")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> NENJHIOBHMM(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, float IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26AFE70", Offset = "0x26AE870", VA = "0x1826AFE70")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IGCAJKFBNDH(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26B24D0", Offset = "0x26B0ED0", VA = "0x1826B24D0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OJOANJNMGKN(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x26AF5A0", Offset = "0x26ADFA0", VA = "0x1826AF5A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HCEAIJDDCIJ(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x26B02F0", Offset = "0x26AECF0", VA = "0x1826B02F0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> JABJJMAEFAK(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x26B1080", Offset = "0x26AFA80", VA = "0x1826B1080")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> LFHMEAJAELA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26AE660", Offset = "0x26AD060", VA = "0x1826AE660")]
	public static NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>> EBBCPABHDFH(this LOMNDDKOIEJ IJPDNJELPLO)
	{
		return default(NBPBIJJFIMI<HBOGCCEGENA<HBOGCCEGENA<OCDOLOPOJIC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26B2830", Offset = "0x26B1230", VA = "0x1826B2830")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OPGBEPGMLLH(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, float IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x26B1C30", Offset = "0x26B0630", VA = "0x1826B1C30")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> NNODMNCIOAO(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x26AF060", Offset = "0x26ADA60", VA = "0x1826AF060")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FGAPGOKNFLM(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x26AD950", Offset = "0x26AC350", VA = "0x1826AD950")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ABJELBEKOGA(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x26B1B10", Offset = "0x26B0510", VA = "0x1826B1B10")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> NMJOOKPEOOB(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x26B1DD0", Offset = "0x26B07D0", VA = "0x1826B1DD0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OAIIDFJNNMO(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x26B2610", Offset = "0x26B1010", VA = "0x1826B2610")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OKNKKJHIJGL(this LOMNDDKOIEJ IJPDNJELPLO, int PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x26AF7A0", Offset = "0x26AE1A0", VA = "0x1826AF7A0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HJJJHOHGKEK(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PPJFMHBDGNA)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x26B1460", Offset = "0x26AFE60", VA = "0x1826B1460")]
	public static void LOCIOHCALKD(this LOMNDDKOIEJ IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x26AFFA0", Offset = "0x26AE9A0", VA = "0x1826AFFA0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IKHFOCCGAKO(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, float IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26B11C0", Offset = "0x26AFBC0", VA = "0x1826B11C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> LJDOMFJACOM(this LOMNDDKOIEJ IJPDNJELPLO, float DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x26B2010", Offset = "0x26B0A10", VA = "0x1826B2010")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OCDJLIJCLNJ(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x26AE8C0", Offset = "0x26AD2C0", VA = "0x1826AE8C0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EGIOFHDNFKB(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x26B1470", Offset = "0x26AFE70", VA = "0x1826B1470")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> MBDBJMHJFCG(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x26B0F40", Offset = "0x26AF940", VA = "0x1826B0F40")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> LCCMGADMBLK(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x26B2150", Offset = "0x26B0B50", VA = "0x1826B2150")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> OIHCKBOMJEH(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> JGDCHLIONIP, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> GPPIKHPADEM)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x26B1750", Offset = "0x26B0150", VA = "0x1826B1750")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> MOPNGNGOAMF(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, int IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x26ADE30", Offset = "0x26AC830", VA = "0x1826ADE30")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CIEDFNFGGDL(this LOMNDDKOIEJ IJPDNJELPLO, int DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26AEEA0", Offset = "0x26AD8A0", VA = "0x1826AEEA0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FDJOKIMLAPL(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DJAIIGFHKEC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> IENOKGHGHNF)
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x34C02A0", Offset = "0x34BECA0", VA = "0x1834C02A0")]
	public static void MLGIECKNHNG<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<EOKHHKDGEPC> LMIIMLGBDOG, [In] ReadOnlySpan<NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>> AEEIKBGEFHI, [In] ReadOnlySpan<int?> HILDLJFDNIH, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> CMLAHCBGNIG, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> MLAFDLGFMHP, [In] ReadOnlySpan<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>?> AHKKJGBMACJ) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x34BFD00", Offset = "0x34BE700", VA = "0x1834BFD00")]
	public static void LPNKIAKMBOE<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<LKAJLDGJAFC> KEEHKILKFBL, [In] ReadOnlySpan<NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>> GDMELLMDCHF, [In] ReadOnlySpan<int?> HILDLJFDNIH, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> CMLAHCBGNIG, [In] Span<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>> MLAFDLGFMHP, [In] ReadOnlySpan<NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>?> AHKKJGBMACJ) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x34BF5E0", Offset = "0x34BDFE0", VA = "0x1834BF5E0")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> EICOJNJLMFA<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> FJJJMMFDEKL, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34BF180", Offset = "0x34BDB80", VA = "0x1834BF180")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> DBBHHOJMPJN<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CCJDKDEIJID, [Optional] NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34BF9D0", Offset = "0x34BE3D0", VA = "0x1834BF9D0")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> HKDJFMBMJJA<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL) where TDeps : notnull, NEIOICCJMDO<TStateSys> where TStateSys : notnull
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34BF7C0", Offset = "0x34BE1C0", VA = "0x1834BF7C0")]
	public static NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP> FNPAAALAIME<TDeps, TStateSys>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL) where TDeps : notnull, NEIOICCJMDO<TStateSys> where TStateSys : notnull
	{
		return default(NBPBIJJFIMI<MJKHHJCMIGA.CNHLFDNADPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x26B0550", Offset = "0x26AEF50", VA = "0x1826B0550")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> KBMNBKCLKAO(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> CLJCDKHCCIK, IntPtr MNKPHIFJIGO, IntPtr KKIHPJEDNKG)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x26B0800", Offset = "0x26AF200", VA = "0x1826B0800")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> KNCAJCNOOMA(this LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> ACGHKMIHFDH, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> IDEGLFAOMOH, IntPtr ENLLLHNNIIP, IntPtr PBHCEAKDPOM, IntPtr FBLHBMAIMFK, bool PHOMBCMFKBJ)
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x34BEA50", Offset = "0x34BD450", VA = "0x1834BEA50")]
	public static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> BKBHBEDHGID<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<EOKHHKDGEPC> CNCGHMLMLBO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> ACGHKMIHFDH, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> IDEGLFAOMOH, int? MGIENKHFBFD, [Optional] IntPtr GNPODNDBAPG) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x34BE730", Offset = "0x34BD130", VA = "0x1834BE730")]
	private static NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> BKBHBEDHGID<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<EOKHHKDGEPC> CNCGHMLMLBO, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> ACGHKMIHFDH, NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ> IDEGLFAOMOH, int? MGIENKHFBFD) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
		return default(NBPBIJJFIMI<OCNPCNJNAIL.JADKIDDLLDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x34C0E70", Offset = "0x34BF870", VA = "0x1834C0E70")]
	public static NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> PKJMNGIGAPP<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> CGKFGDDBBPE, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>? JCDJPNMFCEK) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
		return default(NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34C0BE0", Offset = "0x34BF5E0", VA = "0x1834C0BE0")]
	public static void OPGHFPFMGDN<TDeps, TState>(this LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TState JCFJJCIGDKC, int EFKBBHCIMJH) where TDeps : notnull, NEIOICCJMDO<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IGBFOADMDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> DMFEPGOHEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> EOGPOHCICJE;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
	public IGBFOADMDEF(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> GCBBJOEKNPL, NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> PLBKPPECLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x26B38E0", Offset = "0x26B22E0", VA = "0x1826B38E0")]
	public static IGBFOADMDEF DDDHPONDPCL(NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>> GCBBJOEKNPL)
	{
		return default(IGBFOADMDEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GCNDGJPHGKF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class BAEMLLHPBKM : IPGKPGDBLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct GGPGPJFCFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> GAHCFNPJBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LIGNGKONFNM;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		public GGPGPJFCFJA(NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM, int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KHEDCMFOOEI : IPGKPGDBLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GEKLJLANEPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LIGNGKONFNM;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public GEKLJLANEPN(int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class EPNLOFJKABA : IPGKPGDBLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct GBJLPHLDCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> GAHCFNPJBMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LIGNGKONFNM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
		public GBJLPHLDCEC(NBPBIJJFIMI<IPIEOJOIPKI.LJJOELGJPEH> PLAPDJCOHMM, int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum POBFHJHDCOF
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class CCFNPBBNGCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class IPGKPGDBLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FKBKONNCEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? LCFBIEBHCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IGBFOADMDEF GNPELHCAOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public POBFHJHDCOF BAIECMFNGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NBPBIJJFIMI<IPGKPGDBLKO> JMBIJFPKJIJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x26B2E40", Offset = "0x26B1840", VA = "0x1826B2E40")]
		public FKBKONNCEMN(int? LKGMFDDKHLG, [In] IGBFOADMDEF DMJHGGNMKFO, POBFHJHDCOF CCNJGHCOOKI, NBPBIJJFIMI<IPGKPGDBLKO> BAEEFOAPAND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class NAANDHMMCIO : IPGKPGDBLKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DJJFAFBNMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LIGNGKONFNM;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		public DJJFAFBNMEH(int DOAKEFBOPIA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GCBIIEODMFK<CCFNPBBNGCI, FKBKONNCEMN> JFHOKFOANDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GCBIIEODMFK<BAEMLLHPBKM, GGPGPJFCFJA> JHPAFPPGJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GCBIIEODMFK<EPNLOFJKABA, GBJLPHLDCEC> GHICLGHCJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GCBIIEODMFK<NAANDHMMCIO, DJJFAFBNMEH> KEDFEHKFMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GCBIIEODMFK<KHEDCMFOOEI, GEKLJLANEPN> HBAOKIFIKJE;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x26B3340", Offset = "0x26B1D40", VA = "0x1826B3340")]
	private GCNDGJPHGKF([In] GCBIIEODMFK<CCFNPBBNGCI, FKBKONNCEMN> IKEKHCIOGKI, [In] GCBIIEODMFK<BAEMLLHPBKM, GGPGPJFCFJA> HJPKNCCHLPC, [In] GCBIIEODMFK<EPNLOFJKABA, GBJLPHLDCEC> ALGIOGCIIII, [In] GCBIIEODMFK<NAANDHMMCIO, DJJFAFBNMEH> JEEKOMKHIEE, [In] GCBIIEODMFK<KHEDCMFOOEI, GEKLJLANEPN> GENFNPLHGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x26B3150", Offset = "0x26B1B50", VA = "0x1826B3150")]
	public static GCNDGJPHGKF DDDHPONDPCL()
	{
		return default(GCNDGJPHGKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GJHHKIELPLK
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x26B3470", Offset = "0x26B1E70", VA = "0x1826B3470")]
	public static void HEJCAAOAKNK(this GCNDGJPHGKF IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ALNMOGOLDCG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x26AAC40", Offset = "0x26A9640", VA = "0x1826AAC40")]
	public static void OBEHDDJHDFO(LOMNDDKOIEJ IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NJBCONPEEFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, JIAICMGPCEA> EEDPCILFAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int GOEBIEINKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int DKCLDNCNEJO;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x26B6040", Offset = "0x26B4A40", VA = "0x1826B6040")]
	private NJBCONPEEFH([In] GDANPEAMDGC<IPIEOJOIPKI.LKCPKGPKGPC, JIAICMGPCEA> LLIHMJAAFBJ, int IADFCPBHIII, int AGLDCFDOMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x26B5DE0", Offset = "0x26B47E0", VA = "0x1826B5DE0")]
	public static NJBCONPEEFH DDDHPONDPCL()
	{
		return default(NJBCONPEEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26B5E50", Offset = "0x26B4850", VA = "0x1826B5E50")]
	public void HEJCAAOAKNK([In] LOMNDDKOIEJ PJENKJOEENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37ECD90", Offset = "0x37EB790", VA = "0x1837ECD90")]
	public static void OBEHDDJHDFO<TDeps, TStateSys>(LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL, NBPBIJJFIMI<IHOCDEAAOKH> PLGEGLLPNNG) where TDeps : notnull, NEIOICCJMDO<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CBAOFHIBHGF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x26AAE20", Offset = "0x26A9820", VA = "0x1826AAE20")]
	public static void OBEHDDJHDFO(LOMNDDKOIEJ IJPDNJELPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ENGAOHDJFLC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KPAOMMAIIMN(CHFNJPOOAHD<byte> KLCNPGEPCCL, int JPFONHFFJAN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct IEBGBIABHLP : FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x26B3860", Offset = "0x26B2260", VA = "0x1826B3860", Slot = "4")]
		public void KPAOMMAIIMN(CHFNJPOOAHD<byte> KLCNPGEPCCL, int JPFONHFFJAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct HIMDHBGAGJH : FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x26B37A0", Offset = "0x26B21A0", VA = "0x1826B37A0", Slot = "4")]
		public void KPAOMMAIIMN(CHFNJPOOAHD<byte> KLCNPGEPCCL, int JPFONHFFJAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct BKEGDHLJECN : FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x26AADA0", Offset = "0x26A97A0", VA = "0x1826AADA0", Slot = "4")]
		public void KPAOMMAIIMN(CHFNJPOOAHD<byte> KLCNPGEPCCL, int JPFONHFFJAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct JLEIBKNPBPI : FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x26B4760", Offset = "0x26B3160", VA = "0x1826B4760", Slot = "4")]
		public void KPAOMMAIIMN(CHFNJPOOAHD<byte> KLCNPGEPCCL, int JPFONHFFJAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class OPIEFMEBDNF<TCallProcessorDeps> where TCallProcessorDeps : struct, FHKPAHDNLBP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps LGCCMBFCAMH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8A50", Offset = "0x3CF7450", VA = "0x183CF8A50")]
		public static int OBEHDDJHDFO<TDeps, TStateSys>(TDeps DODNABDPAAP, TStateSys JCFJJCIGDKC, LOMNDDKOIEJ PJENKJOEENI, [In] CHFNJPOOAHD<byte> KPBCFMLJKCG, int LENMCKJFPLG) where TDeps : NEIOICCJMDO<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private CHFNJPOOAHD<MCBANPPEIJN> OKFBJIEICJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> EGBIPCAMMND;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x26B2D10", Offset = "0x26B1710", VA = "0x1826B2D10")]
	private ENGAOHDJFLC([In] CHFNJPOOAHD<MCBANPPEIJN> FAGOBBANKDG, Dictionary<NBPBIJJFIMI<HBOGCCEGENA<OCDOLOPOJIC>>, NBPBIJJFIMI<IPIEOJOIPKI.LKCPKGPKGPC>> DEMAHDEKDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x26B2C10", Offset = "0x26B1610", VA = "0x1826B2C10")]
	public static ENGAOHDJFLC DDDHPONDPCL()
	{
		return default(ENGAOHDJFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x26B2CD0", Offset = "0x26B16D0", VA = "0x1826B2CD0")]
	public void HEJCAAOAKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x34C9250", Offset = "0x34C7C50", VA = "0x1834C9250")]
	public static void OBEHDDJHDFO<TDeps, TStateSys>(LOMNDDKOIEJ IJPDNJELPLO, TDeps DODNABDPAAP, TStateSys OIKGJCKECJL) where TDeps : NEIOICCJMDO<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JEKHGIPFIDM
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct OHGKNJAOOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> HCPHMOEEILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int KDMNIBEAMJC;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int GHLPNONJFFF;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int IICLGDDOEKC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26B3C80", Offset = "0x26B2680", VA = "0x1826B3C80")]
	public static void OBEHDDJHDFO(LOMNDDKOIEJ IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x26B4480", Offset = "0x26B2E80", VA = "0x1826B4480")]
	private static void OKHNAIKAOKB([In] LOMNDDKOIEJ IJPDNJELPLO, NBPBIJJFIMI<GCNDGJPHGKF.CCFNPBBNGCI> ICHIIHCEGJD, CHFNJPOOAHD<byte> OCGJFHAJMFI, List<OHGKNJAOOPN> PAACCJCNMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26B4340", Offset = "0x26B2D40", VA = "0x1826B4340")]
	private static void OKHNAIKAOKB(CHFNJPOOAHD<byte> OCGJFHAJMFI, int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x26B3B50", Offset = "0x26B2550", VA = "0x1826B3B50")]
	private static void AFGPKBNGIMN(LOMNDDKOIEJ IJPDNJELPLO, List<OHGKNJAOOPN> PAACCJCNMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DLJHCAHBKDF<TDeps, TIndex, TValues> where TDeps : struct, JCFLNMNHOLD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps LGCCMBFCAMH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3F23BE0", Offset = "0x3F225E0", VA = "0x183F23BE0")]
	public static void OBEHDDJHDFO([In] CHFNJPOOAHD<MCBANPPEIJN> FAGOBBANKDG, int MMEKJMOECKP, TValues IOMEFCNHNJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JCFLNMNHOLD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CHFNJPOOAHD<TIndex> HNFGHLLJOKP(int MMEKJMOECKP, [In] TValues IOMEFCNHNJN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(TIndex DOAKEFBOPIA, [In] TValues IOMEFCNHNJN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEIIDDCJGHD(TIndex DOAKEFBOPIA, TValues IOMEFCNHNJN, NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface OJMCCCMJCGL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex JNJKANCDIJN(int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DLGEKMAGCLA(TIndex DOAKEFBOPIA, [In] TValues IOMEFCNHNJN);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NBPBIJJFIMI<HBOGCCEGENA<GDGLAEPKNCJ>> PCGKKGCIKAC(TIndex DOAKEFBOPIA, [In] TValues IOMEFCNHNJN);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ACEICGJCNKF<TDeps, TIndex, TValues> where TDeps : struct, OJMCCCMJCGL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps LGCCMBFCAMH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4855A60", Offset = "0x4854460", VA = "0x184855A60")]
	public static CHFNJPOOAHD<TIndex> OBEHDDJHDFO(int MMEKJMOECKP, [In] TValues IOMEFCNHNJN)
	{
		return default(CHFNJPOOAHD<TIndex>);
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

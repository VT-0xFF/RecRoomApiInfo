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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x29052B0", Offset = "0x2903CB0", VA = "0x1829052B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct KLGCIBMDIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> HHAHENEBBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int LEHDAHFOAEI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
	public KLGCIBMDIEB(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> MBPDMFKLIJB, int BACDJHJBLPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KNHECKPIODN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GFKCAAJOBIA : EMPAFOKIBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NCHHAEHLAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly BEGCCOONNLO<byte> FPKHFIMGCLP;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2898C40", Offset = "0x2897640", VA = "0x182898C40")]
		public NCHHAEHLAJD(BEGCCOONNLO<byte> OKLLDHNGOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2905220", Offset = "0x2903C20", VA = "0x182905220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ADBOLCDMHKB : EMPAFOKIBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct POEMHHLNNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> IODPCKJIHJN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public POEMHHLNNCH(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> OAJIOLBCICG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum EADGEPPCENE
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
	public sealed class LAPCJIMOFPI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class EMPAFOKIBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct IOBEPBFNEDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly EADGEPPCENE ABJPJDOFLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EHLNDDDNIPO<EMPAFOKIBNG> IODCNMGKMGJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		public IOBEPBFNEDM(EADGEPPCENE ILBKJJNBJPM, EHLNDDDNIPO<EMPAFOKIBNG> FOBEDGJCMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class MDOLMLOODJO : EMPAFOKIBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct IKKJKELNJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PDGCNNGNEBD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public IKKJKELNJMM(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GMHANIFBEBN : EMPAFOKIBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct EOODAAEHMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly ILCBHHHGFAE OLPJFJBJHAM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public EOODAAEHMOB(ILCBHHHGFAE CNEEBKHNEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2900D20", Offset = "0x28FF720", VA = "0x182900D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal LLAJLAONCJN<LAPCJIMOFPI, IOBEPBFNEDM> FFKDBMNBACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal LLAJLAONCJN<GFKCAAJOBIA, NCHHAEHLAJD> PGKJCOPIGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LLAJLAONCJN<ADBOLCDMHKB, POEMHHLNNCH> ANKGLHMAGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LLAJLAONCJN<MDOLMLOODJO, IKKJKELNJMM> KEAMEKIGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LLAJLAONCJN<GMHANIFBEBN, EOODAAEHMOB> HIPGGCODGCG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2903C30", Offset = "0x2902630", VA = "0x182903C30")]
	private KNHECKPIODN([In] LLAJLAONCJN<LAPCJIMOFPI, IOBEPBFNEDM> DKPEINKAPEC, [In] LLAJLAONCJN<GFKCAAJOBIA, NCHHAEHLAJD> EAIFCNGPDCH, [In] LLAJLAONCJN<ADBOLCDMHKB, POEMHHLNNCH> PPACPBBNENO, [In] LLAJLAONCJN<MDOLMLOODJO, IKKJKELNJMM> BMODBAHOJOP, [In] LLAJLAONCJN<GMHANIFBEBN, EOODAAEHMOB> HJLDANIOIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2903AF0", Offset = "0x29024F0", VA = "0x182903AF0")]
	public static KNHECKPIODN FMDOFBCLPJB()
	{
		return default(KNHECKPIODN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GPOJKCJMBIL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2901110", Offset = "0x28FFB10", VA = "0x182901110")]
	public static void EFCPNMLOGFP(this KNHECKPIODN NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IFCMHENNBBG
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
public struct AHGPLNKAAGG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class KEIBDALGKOA : HCGPAKAGMKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct MMPKLMMCIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> CKOKJBOAMPM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public MMPKLMMCIFE(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> LCCMPIAEPGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum PNNEBAHOKOC
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
	public sealed class IHDNKAADMFM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class HCGPAKAGMKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DFJECGHFLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly PNNEBAHOKOC ABJPJDOFLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EHLNDDDNIPO<HCGPAKAGMKF> IODCNMGKMGJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		public DFJECGHFLJP(PNNEBAHOKOC ILBKJJNBJPM, EHLNDDDNIPO<HCGPAKAGMKF> FOBEDGJCMOP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LLAJLAONCJN<IHDNKAADMFM, DFJECGHFLJP> FFKDBMNBACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LLAJLAONCJN<KEIBDALGKOA, MMPKLMMCIFE> DNCDADAJPLN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28FA4D0", Offset = "0x28F8ED0", VA = "0x1828FA4D0")]
	private AHGPLNKAAGG([In] LLAJLAONCJN<IHDNKAADMFM, DFJECGHFLJP> DKPEINKAPEC, [In] LLAJLAONCJN<KEIBDALGKOA, MMPKLMMCIFE> GNICMFNHKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28FA440", Offset = "0x28F8E40", VA = "0x1828FA440")]
	public static AHGPLNKAAGG FMDOFBCLPJB()
	{
		return default(AHGPLNKAAGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EACCMFCCNGP
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2900C40", Offset = "0x28FF640", VA = "0x182900C40")]
	public static void EFCPNMLOGFP(this AHGPLNKAAGG NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NAGMKCKMGBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public KEIHFOCJOJN<int> PKFDBDEMAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public KEIHFOCJOJN<int> KIBPNDJFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GJLLKLPEKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int CKNCKJKLJFG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29051C0", Offset = "0x2903BC0", VA = "0x1829051C0")]
	private NAGMKCKMGBG([In] KEIHFOCJOJN<int> AMEFANPGDBG, [In] KEIHFOCJOJN<int> DIIGAAMLFNG, int GKNKOBLLOAI, int PFBEHKEEBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2905120", Offset = "0x2903B20", VA = "0x182905120")]
	public static NAGMKCKMGBG FMDOFBCLPJB()
	{
		return default(NAGMKCKMGBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HAGPBELAAHN
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29011C0", Offset = "0x28FFBC0", VA = "0x1829011C0")]
	public static void EFCPNMLOGFP(this NAGMKCKMGBG NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OBIFONDNCDL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum NHFDOEIIEEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CMOELJMFIDO : FBCNECHKKOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct AGFHGHHAFPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EHLNDDDNIPO<LNPMCEKEONL> ENJCPMBAPEG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public AGFHGHHAFPE(EHLNDDDNIPO<LNPMCEKEONL> EEMMFMDGADH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class IIOIIMIOOJO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class FBCNECHKKOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct OOHEMGMOBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly NHFDOEIIEEI ABJPJDOFLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly EHLNDDDNIPO<FBCNECHKKOC> IODCNMGKMGJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		private OOHEMGMOBFD(NHFDOEIIEEI ILBKJJNBJPM, EHLNDDDNIPO<FBCNECHKKOC> FOBEDGJCMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2905620", Offset = "0x2904020", VA = "0x182905620")]
		public static OOHEMGMOBFD FMDOFBCLPJB(NHFDOEIIEEI ILBKJJNBJPM, EHLNDDDNIPO<FBCNECHKKOC> FOBEDGJCMOP)
		{
			return default(OOHEMGMOBFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GBIEGCHNOKL : FBCNECHKKOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BEEFIGFDLJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly EHLNDDDNIPO<LNPMCEKEONL> ENJCPMBAPEG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public BEEFIGFDLJM(EHLNDDDNIPO<LNPMCEKEONL> EEMMFMDGADH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class LNPMCEKEONL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct HONKLCLKDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KEIHFOCJOJN<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PDJNEPGMKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KEIHFOCJOJN<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> IMMJOOKDPOO;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28FA4D0", Offset = "0x28F8ED0", VA = "0x1828FA4D0")]
		private HONKLCLKDAF([In] KEIHFOCJOJN<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> FOABHHONDMI, [In] KEIHFOCJOJN<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> BDMHJPIAKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2903650", Offset = "0x2902050", VA = "0x182903650")]
		public static HONKLCLKDAF FMDOFBCLPJB()
		{
			return default(HONKLCLKDAF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal LLAJLAONCJN<IIOIIMIOOJO, OOHEMGMOBFD> FFKDBMNBACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal LLAJLAONCJN<GBIEGCHNOKL, BEEFIGFDLJM> LMPIGMGNJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal LLAJLAONCJN<CMOELJMFIDO, AGFHGHHAFPE> ELEMALGGBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal KEIHFOCJOJN<(EHLNDDDNIPO<IIOIIMIOOJO> CallId, EHLNDDDNIPO<LNPMCEKEONL> IOId)> BHIKEIIGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LLAJLAONCJN<LNPMCEKEONL, HONKLCLKDAF> MNFHPNEFIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal CFFOMBMNIPG<LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> NDGHEDGCDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal CFFOMBMNIPG<LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> ILNKINPLBCO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29054D0", Offset = "0x2903ED0", VA = "0x1829054D0")]
	private OBIFONDNCDL([In] LLAJLAONCJN<IIOIIMIOOJO, OOHEMGMOBFD> DKPEINKAPEC, [In] LLAJLAONCJN<GBIEGCHNOKL, BEEFIGFDLJM> HPEPDIFHKJE, [In] LLAJLAONCJN<CMOELJMFIDO, AGFHGHHAFPE> AIFKOLHGBIP, [In] KEIHFOCJOJN<(EHLNDDDNIPO<IIOIIMIOOJO> CallId, EHLNDDDNIPO<LNPMCEKEONL> IOId)> EGFBMDEODEA, [In] LLAJLAONCJN<LNPMCEKEONL, HONKLCLKDAF> DGCMFLOHINI, [In] CFFOMBMNIPG<LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> DIOABEAMIAF, [In] CFFOMBMNIPG<LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> HIBNLDJLIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2905330", Offset = "0x2903D30", VA = "0x182905330")]
	public static OBIFONDNCDL FMDOFBCLPJB()
	{
		return default(OBIFONDNCDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GCEODEEBJPO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2900D40", Offset = "0x28FF740", VA = "0x182900D40")]
	private static void EFCPNMLOGFP(this OBIFONDNCDL.HONKLCLKDAF NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2900D90", Offset = "0x28FF790", VA = "0x182900D90")]
	public static void EFCPNMLOGFP(this OBIFONDNCDL NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KPNJGMAPGMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public KEIHFOCJOJN<byte> FHMFDAHFGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal OBIFONDNCDL MDBBCHONIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OPHPNKHHADF HJLMDNLBPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PBFHCLKNNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal KNHECKPIODN JOMIIEHJNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal AHGPLNKAAGG LFCBPPDCPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal CFFOMBMNIPG<AJNLPJGEJEJ, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>?> HAGPKIJINFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal KEIHFOCJOJN<EHLNDDDNIPO<AJNLPJGEJEJ>> NBMCHKNDJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OLHGPMGAHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> AAFAMKOFLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> AIDDCCMEBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DMPMGEKJHIE DNNHOILBAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal KKAMBJHANGP MBGMGBILEBF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2904670", Offset = "0x2903070", VA = "0x182904670")]
	private KPNJGMAPGMG([In] KEIHFOCJOJN<byte> IOKIADMGOHK, [In] OBIFONDNCDL DMKDNJNPADI, [In] OPHPNKHHADF BFEDAOMKBJF, [In] KNHECKPIODN DLKMNBAKNEC, [In] AHGPLNKAAGG CBCDNICHJLF, [In] CFFOMBMNIPG<AJNLPJGEJEJ, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>?> GLKIOPDENMG, [In] KEIHFOCJOJN<EHLNDDDNIPO<AJNLPJGEJEJ>> CJGCEGMJBAF, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> MHMPJHPALNK, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> GDAFFEPANHD, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> EGIGJINBFOK, [In] DMPMGEKJHIE INAPDPJOAKO, [In] KKAMBJHANGP DAJFKHBFINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2903CC0", Offset = "0x29026C0", VA = "0x182903CC0")]
	public static KPNJGMAPGMG FMDOFBCLPJB()
	{
		return default(KPNJGMAPGMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HJICDODOBND
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JHFHPIFFCDN : BCEPJLLMEBP<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2903710", Offset = "0x2902110", VA = "0x182903710")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2903790", Offset = "0x2902190", VA = "0x182903790", Slot = "4")]
		public EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		public bool EABALGLCBLD(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "5")]
		private bool NHENLEIBLMI(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2903710", Offset = "0x2902110", VA = "0x182903710", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> IPIAGHHJCMA(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct CBLFCOPPIEO : JKGJCAOIIBG<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28FFD30", Offset = "0x28FE730", VA = "0x1828FFD30")]
		public KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> IOPFAJOIFDO(int IIKKPJLEBBM, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28FFCB0", Offset = "0x28FE6B0", VA = "0x1828FFCB0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x28FFDA0", Offset = "0x28FE7A0", VA = "0x1828FFDA0", Slot = "6")]
		public void PEOPFFIGFME(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28FFD30", Offset = "0x28FE730", VA = "0x1828FFD30", Slot = "4")]
		private KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> OJCEFNMFMEL(int IIKKPJLEBBM, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28FFCB0", Offset = "0x28FE6B0", VA = "0x1828FFCB0", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ODKJEIBCCAI(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct MFJMKIGCKMA : BCEPJLLMEBP<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2904E20", Offset = "0x2903820", VA = "0x182904E20")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2904EA0", Offset = "0x29038A0", VA = "0x182904EA0", Slot = "4")]
		public EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		public bool EABALGLCBLD(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "5")]
		private bool NMKINKKBKAN(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2904E20", Offset = "0x2903820", VA = "0x182904E20", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> LIKHIJDHEIM(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct BEELNIPAIIJ : JKGJCAOIIBG<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28FF9E0", Offset = "0x28FE3E0", VA = "0x1828FF9E0")]
		public KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> IOPFAJOIFDO(int IIKKPJLEBBM, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28FF960", Offset = "0x28FE360", VA = "0x1828FF960")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28FFA50", Offset = "0x28FE450", VA = "0x1828FFA50", Slot = "6")]
		public void PEOPFFIGFME(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28FF9E0", Offset = "0x28FE3E0", VA = "0x1828FF9E0", Slot = "4")]
		private KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> KMLKPADDADE(int IIKKPJLEBBM, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28FF960", Offset = "0x28FE360", VA = "0x1828FF960", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> EJHMPBIIFBJ(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> MNFHMLCLFEB, [In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct CCEDMINMAON : BCEPJLLMEBP<EHLNDDDNIPO<BGLCIALODCA>, CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28FFEA0", Offset = "0x28FE8A0", VA = "0x1828FFEA0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28FFF40", Offset = "0x28FE940", VA = "0x1828FFF40", Slot = "4")]
		public EHLNDDDNIPO<BGLCIALODCA> OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(EHLNDDDNIPO<BGLCIALODCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28FFE30", Offset = "0x28FE830", VA = "0x1828FFE30")]
		public bool EABALGLCBLD(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28FFE30", Offset = "0x28FE830", VA = "0x1828FFE30", Slot = "5")]
		private bool DCFDHMJDBHC(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28FFE90", Offset = "0x28FE890", VA = "0x1828FFE90", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> FMIKNEHDNKN(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BJLHJNFPENB : JKGJCAOIIBG<EHLNDDDNIPO<BGLCIALODCA>, CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28FFB80", Offset = "0x28FE580", VA = "0x1828FFB80")]
		public KEIHFOCJOJN<EHLNDDDNIPO<BGLCIALODCA>> IOPFAJOIFDO(int IIKKPJLEBBM, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<BGLCIALODCA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28FFAE0", Offset = "0x28FE4E0", VA = "0x1828FFAE0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28FFC00", Offset = "0x28FE600", VA = "0x1828FFC00", Slot = "6")]
		public void PEOPFFIGFME(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28FFB80", Offset = "0x28FE580", VA = "0x1828FFB80", Slot = "4")]
		private KEIHFOCJOJN<EHLNDDDNIPO<BGLCIALODCA>> KOKBMCDCODO(int IIKKPJLEBBM, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<EHLNDDDNIPO<BGLCIALODCA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28FFBF0", Offset = "0x28FE5F0", VA = "0x1828FFBF0", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> MFPHDILJGIB(EHLNDDDNIPO<BGLCIALODCA> MNFHMLCLFEB, [In] CFFOMBMNIPG<BGLCIALODCA, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>?> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct OCNMNFOFGGG : BCEPJLLMEBP<int, KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x29055A0", Offset = "0x2903FA0", VA = "0x1829055A0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAEE000", Offset = "0xAECA00", VA = "0x180AEE000", Slot = "4")]
		public int OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		public bool EABALGLCBLD(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "5")]
		private bool KAPNCHKIHDB(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2905590", Offset = "0x2903F90", VA = "0x182905590", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> DEACFJIADMC(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct KJFHPNKMHDK : JKGJCAOIIBG<int, KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2903840", Offset = "0x2902240", VA = "0x182903840")]
		public KEIHFOCJOJN<int> IOPFAJOIFDO(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x29037C0", Offset = "0x29021C0", VA = "0x1829037C0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x29038C0", Offset = "0x29022C0", VA = "0x1829038C0", Slot = "6")]
		public void PEOPFFIGFME(int MNFHMLCLFEB, KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2903840", Offset = "0x2902240", VA = "0x182903840", Slot = "4")]
		private KEIHFOCJOJN<int> LCDGLHKDEJI(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x29038B0", Offset = "0x29022B0", VA = "0x1829038B0", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> LGNEBOEGIPD(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> VariableId, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<GJCAOKDFKPI>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct EAKJGNILDLH : BCEPJLLMEBP<int, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2900CA0", Offset = "0x28FF6A0", VA = "0x182900CA0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAEE000", Offset = "0xAECA00", VA = "0x180AEE000", Slot = "4")]
		public int OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		public bool EABALGLCBLD(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "5")]
		private bool JJJGCJHLJPJ(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2900CA0", Offset = "0x28FF6A0", VA = "0x182900CA0", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> KIICCNGLDGM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct LBNMFGLHALL : JKGJCAOIIBG<int, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2904A50", Offset = "0x2903450", VA = "0x182904A50")]
		public KEIHFOCJOJN<int> IOPFAJOIFDO(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x29049D0", Offset = "0x29033D0", VA = "0x1829049D0")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2904AC0", Offset = "0x29034C0", VA = "0x182904AC0", Slot = "6")]
		public void PEOPFFIGFME(int MNFHMLCLFEB, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2904A50", Offset = "0x2903450", VA = "0x182904A50", Slot = "4")]
		private KEIHFOCJOJN<int> PIIHMBGPLIL(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x29049D0", Offset = "0x29033D0", VA = "0x1829049D0", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> GOOIOPOPIKA(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct AIBAJEDKKBB : BCEPJLLMEBP<int, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28FA510", Offset = "0x28F8F10", VA = "0x1828FA510")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAEE000", Offset = "0xAECA00", VA = "0x180AEE000", Slot = "4")]
		public int OEBBDDNBPPG(int MNFHMLCLFEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0")]
		public bool EABALGLCBLD(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "5")]
		private bool JJJGCJHLJPJ(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28FA590", Offset = "0x28F8F90", VA = "0x1828FA590", Slot = "6")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> KIICCNGLDGM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct MBIIOEHHPNM : JKGJCAOIIBG<int, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2904CC0", Offset = "0x29036C0", VA = "0x182904CC0")]
		public KEIHFOCJOJN<int> IOPFAJOIFDO(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2904C40", Offset = "0x2903640", VA = "0x182904C40")]
		public EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2904D30", Offset = "0x2903730", VA = "0x182904D30", Slot = "6")]
		public void PEOPFFIGFME(int MNFHMLCLFEB, KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2904CC0", Offset = "0x29036C0", VA = "0x182904CC0", Slot = "4")]
		private KEIHFOCJOJN<int> PIIHMBGPLIL(int IIKKPJLEBBM, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(KEIHFOCJOJN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2904C30", Offset = "0x2903630", VA = "0x182904C30", Slot = "5")]
		private EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> GOOIOPOPIKA(int MNFHMLCLFEB, [In] KEIHFOCJOJN<(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> Target, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ByteCodeWriteLocation)> OKEIIBNBBOL)
		{
			return default(EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct HMEPGJMKJPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> PIJOGHONNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool GEGOJMDEDLG;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FCBE70", Offset = "0x1FCA870", VA = "0x181FCBE70")]
		public HMEPGJMKJPJ(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, bool ABGABOGFOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2903640", Offset = "0x2902040", VA = "0x182903640")]
		public void AJIECABKDHF([Out] EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, [Out] bool ABGABOGFOIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct IBKBDCHNMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EHLNDDDNIPO<BGLCIALODCA> ELGKHENIFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> PIJOGHONNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool GEGOJMDEDLG;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2903700", Offset = "0x2902100", VA = "0x182903700")]
		public IBKBDCHNMPO(EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, bool ABGABOGFOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x29036F0", Offset = "0x29020F0", VA = "0x1829036F0")]
		public void AJIECABKDHF([Out] EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, [Out] bool ABGABOGFOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x29036D0", Offset = "0x29020D0", VA = "0x1829036D0")]
		public void AJIECABKDHF([Out] EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, [Out] EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD, [Out] bool ABGABOGFOIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct GOJPPCGBKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly EHLNDDDNIPO<BGLCIALODCA> ELGKHENIFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> PIJOGHONNJG;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		public GOJPPCGBKJD(EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2901100", Offset = "0x28FFB00", VA = "0x182901100")]
		public void AJIECABKDHF([Out] EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM, [Out] EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2901CA0", Offset = "0x29006A0", VA = "0x182901CA0")]
	public static void EFCPNMLOGFP(this KPNJGMAPGMG NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2902810", Offset = "0x2901210", VA = "0x182902810")]
	public static void IPPPEEGONEC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BNHONHOCDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29026E0", Offset = "0x29010E0", VA = "0x1829026E0")]
	public static void INJIKBFKALM(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BNHONHOCDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2902AF0", Offset = "0x29014F0", VA = "0x182902AF0")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>? LIHAMJLHOOM([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29014C0", Offset = "0x28FFEC0", VA = "0x1829014C0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> BIPOCFCFAPD([In] this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2902FF0", Offset = "0x29019F0", VA = "0x182902FF0")]
	private static void NKDCGEBCDKA(this KPNJGMAPGMG NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2901FC0", Offset = "0x29009C0", VA = "0x182901FC0")]
	private static EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>? GMDDILFLBOG([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2901770", Offset = "0x2900170", VA = "0x182901770")]
	public static void CJJHNAMLJOE(this KPNJGMAPGMG NMEFAPBBOCD, [In] KEIHFOCJOJN<KLGCIBMDIEB> CJNFJKPENPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2901580", Offset = "0x28FFF80", VA = "0x182901580")]
	public static KNHECKPIODN.EADGEPPCENE CDIJOIPKAML([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(KNHECKPIODN.EADGEPPCENE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2901AB0", Offset = "0x29004B0", VA = "0x182901AB0")]
	public static BEGCCOONNLO<byte> DGBBOLDFEPF([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(BEGCCOONNLO<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29034E0", Offset = "0x2901EE0", VA = "0x1829034E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PNGADLNPLLP([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2902EC0", Offset = "0x29018C0", VA = "0x182902EC0")]
	public static ILCBHHHGFAE NAHIDEAIKMD([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(ILCBHHHGFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A87080", Offset = "0x3A85A80", VA = "0x183A87080")]
	private static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> IDOCKFFBEBG<TMJoin>(this KPNJGMAPGMG NMEFAPBBOCD, KNHECKPIODN.EADGEPPCENE ILBKJJNBJPM, EHLNDDDNIPO<TMJoin> FOBEDGJCMOP) where TMJoin : KNHECKPIODN.EMPAFOKIBNG
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29012C0", Offset = "0x28FFCC0", VA = "0x1829012C0")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> ANLDBHGIONE(this KPNJGMAPGMG NMEFAPBBOCD, bool MHMDPCCBCNG)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2902150", Offset = "0x2900B50", VA = "0x182902150")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> HHLLDEOPFAJ(this KPNJGMAPGMG NMEFAPBBOCD, BEGCCOONNLO<byte> OKLLDHNGOMI)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29019D0", Offset = "0x29003D0", VA = "0x1829019D0")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> DAEFCOIBIMF(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> OAJIOLBCICG)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2902F70", Offset = "0x2901970", VA = "0x182902F70")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> NHFMMNLMJPG(this KPNJGMAPGMG NMEFAPBBOCD, int OLMEHPMACFF)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2902D40", Offset = "0x2901740", VA = "0x182902D40")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> LKOIJIGKJJB(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A87E30", Offset = "0x3A86830", VA = "0x183A87E30")]
	private static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> PMDHCFMMFPA<TMJoin>(this KPNJGMAPGMG NMEFAPBBOCD, AHGPLNKAAGG.PNNEBAHOKOC ILBKJJNBJPM, EHLNDDDNIPO<TMJoin> FOBEDGJCMOP) where TMJoin : AHGPLNKAAGG.HCGPAKAGMKF
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29024C0", Offset = "0x2900EC0", VA = "0x1829024C0")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> HKNICLJDDEK(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2902E70", Offset = "0x2901870", VA = "0x182902E70")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> MMCHJPJHIFO(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29032B0", Offset = "0x2901CB0", VA = "0x1829032B0")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> PHIKNOPFGOB(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> LCCMPIAEPGL)
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2901F70", Offset = "0x2900970", VA = "0x182901F70")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> FFEKCBPDKKB(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29020A0", Offset = "0x2900AA0", VA = "0x1829020A0")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> HCPFICBGBKI(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2903210", Offset = "0x2901C10", VA = "0x182903210")]
	public static OBIFONDNCDL.NHFDOEIIEEI OCFFJCMIPDA([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ)
	{
		return default(OBIFONDNCDL.NHFDOEIIEEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2903270", Offset = "0x2901C70", VA = "0x182903270")]
	public static GLIIFEKENJO<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, MNBJLPENCJL<OBIFONDNCDL.LNPMCEKEONL>> OJFJAMFJLNA([In] this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(GLIIFEKENJO<EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>, MNBJLPENCJL<OBIFONDNCDL.LNPMCEKEONL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2901340", Offset = "0x28FFD40", VA = "0x182901340")]
	public static EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> BDFGFEAJPBC([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ)
	{
		return default(EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29018E0", Offset = "0x29002E0", VA = "0x1829018E0")]
	public static OBIFONDNCDL.HONKLCLKDAF CKAMKGENOAJ([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> EEMMFMDGADH)
	{
		return default(OBIFONDNCDL.HONKLCLKDAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2901A50", Offset = "0x2900450", VA = "0x182901A50")]
	public static OBIFONDNCDL.HONKLCLKDAF DFDMKCBBEJF(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> EEMMFMDGADH)
	{
		return default(OBIFONDNCDL.HONKLCLKDAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A86F10", Offset = "0x3A85910", VA = "0x183A86F10")]
	private static EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> FCDGPOMAAEF<TMJoin>(this KPNJGMAPGMG NMEFAPBBOCD, OBIFONDNCDL.NHFDOEIIEEI ILBKJJNBJPM, EHLNDDDNIPO<TMJoin> FOBEDGJCMOP) where TMJoin : OBIFONDNCDL.FBCNECHKKOC
	{
		return default(EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2902310", Offset = "0x2900D10", VA = "0x182902310")]
	public static (EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>) HKMMKNBAGDF(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default((EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2903330", Offset = "0x2901D30", VA = "0x182903330")]
	public static (EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>) PIICHDDBIAM(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default((EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2902050", Offset = "0x2900A50", VA = "0x182902050")]
	public static EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> HADCAHBFFDK(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2901940", Offset = "0x2900340", VA = "0x182901940")]
	public static void CNAPCLNPBCP(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL> EEMMFMDGADH, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> JIEPCLIFECH, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>> HGCJNNLAHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A860B0", Offset = "0x3A84AB0", VA = "0x183A860B0")]
	public static HMEPGJMKJPJ CHJKDMLPKAJ<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD) where TDeps : ACNNICGFMOO<TStateSys>
	{
		return default(HMEPGJMKJPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A87110", Offset = "0x3A85B10", VA = "0x183A87110")]
	public static IBKBDCHNMPO IKCHNBOJOKP<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG, int AOEKFBBDHFP) where TDeps : ACNNICGFMOO<TStateSys>
	{
		return default(IBKBDCHNMPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A87A10", Offset = "0x3A86410", VA = "0x183A87A10")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>? PHBAJFPOKPJ<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG, [In] ReadOnlySpan<int> PGHHOKHDJEA, [In] Span<GOJPPCGBKJD> LIFDGPBBFPF) where TDeps : ACNNICGFMOO<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3A87390", Offset = "0x3A85D90", VA = "0x183A87390")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> KJBDLEPDEBG<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ) where TDeps : ACNNICGFMOO<TStateSys>
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2902A40", Offset = "0x2901440", VA = "0x182902A40")]
	public static OPHPNKHHADF.CKLPEIDPCPE LDGFKPBOOIN([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return default(OPHPNKHHADF.CKLPEIDPCPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2901BF0", Offset = "0x29005F0", VA = "0x182901BF0")]
	public static OPHPNKHHADF.OILCONCCJBL ECCNDNFHIIO([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return default(OPHPNKHHADF.OILCONCCJBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2903590", Offset = "0x2901F90", VA = "0x182903590")]
	public static OPHPNKHHADF.LOEDFOPOFMO POCOGNMJINI([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return default(OPHPNKHHADF.LOEDFOPOFMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2902B80", Offset = "0x2901580", VA = "0x182902B80")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LJNGNJMGEFM(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND, string GBCFHNGPBLM)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2902930", Offset = "0x2901330", VA = "0x182902930")]
	public static OPHPNKHHADF.KFPGJNBIMGK KJPBFINKBMN([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return default(OPHPNKHHADF.KFPGJNBIMGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29029E0", Offset = "0x29013E0", VA = "0x1829029E0")]
	public static OPHPNKHHADF.BJAPCHDNOLD LAFKDMOGAHO([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return default(OPHPNKHHADF.BJAPCHDNOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29027B0", Offset = "0x29011B0", VA = "0x1829027B0")]
	public static int? IPLEPGKGIFE([In] this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3A86FA0", Offset = "0x3A859A0", VA = "0x183A86FA0")]
	private static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HDAMHAAMAHB<TMJoin>(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND, OPHPNKHHADF.BJAPCHDNOLD ILBKJJNBJPM, EHLNDDDNIPO<TMJoin> FOBEDGJCMOP) where TMJoin : OPHPNKHHADF.JLBOKCOPIAO
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2902DC0", Offset = "0x29017C0", VA = "0x182902DC0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MDFOCMNIJJL(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ, int MNFHMLCLFEB)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29020F0", Offset = "0x2900AF0", VA = "0x1829020F0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HEDOCCJIJFH(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29015E0", Offset = "0x28FFFE0", VA = "0x1829015E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CHFIBIJIJMN(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? JOBFADCKIAA, int? MKFEFGIMBND)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29028A0", Offset = "0x29012A0", VA = "0x1829028A0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KDINBBBIDPP(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND, int MNFHMLCLFEB)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2901520", Offset = "0x28FFF20", VA = "0x182901520")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CDEGJOPNAFD(this KPNJGMAPGMG NMEFAPBBOCD, int? MKFEFGIMBND)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29021E0", Offset = "0x2900BE0", VA = "0x1829021E0")]
	public static void HICIIOCAGLF(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ, int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29025C0", Offset = "0x2900FC0", VA = "0x1829025C0")]
	public static void IEANDKIKHLB(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH, int MNFHMLCLFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2903150", Offset = "0x2901B50", VA = "0x182903150")]
	public static void NMIMILPFMIA(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2901B60", Offset = "0x2900560", VA = "0x182901B60")]
	public static void DKAFGDNEGFH(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> DKLAGICAOGN, EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> FHJEJCNGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2902500", Offset = "0x2900F00", VA = "0x182902500")]
	public static void IDGLKGLLALD(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH, EHLNDDDNIPO<DBKGEMIMENE<NJPMPOALPLB>> JMEFJOLOGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3A87920", Offset = "0x3A86320", VA = "0x183A87920")]
	public static void LEDAOCINMJE<M>(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LNLJNPCALJH, EHLNDDDNIPO<DBKGEMIMENE<NKFCLCHDDPH<M>>> JMEFJOLOGKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ACNNICGFMOO<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHLNDDDNIPO<JGGKNECOACC> GPCJMEDDNFH(TStateSys MPKNDDKICDI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHLNDDDNIPO<JGGKNECOACC> CBOPNPBCNAC(TStateSys MPKNDDKICDI);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHLNDDDNIPO<JGGKNECOACC> DIPMODGJLDF(TStateSys MPKNDDKICDI);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHLNDDDNIPO<JGGKNECOACC> KIOGDHIAKGJ(TStateSys MPKNDDKICDI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> OGDMJAKEIJG(TStateSys MPKNDDKICDI, KPNJGMAPGMG PINNMMPLMCL, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> CKIEFJBABIB(TStateSys MPKNDDKICDI, KPNJGMAPGMG PINNMMPLMCL, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KOAPKAPKMBF(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EHLNDDDNIPO<AJNLPJGEJEJ> IBMFFJCBHHB(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD, int JIAJIIKJPEG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IFCMHENNBBG KOOCDHAMEMO(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OHJLAIAJEKA(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int PKOHBIMOBIK(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BEGCCOONNLO<byte> CNEDKDEOLGC(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(BEGCCOONNLO<byte>, EHLNDDDNIPO<JGGKNECOACC>) COJBAKBJAJD(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<BGLCIALODCA> PBDIIHEGDKD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FGPJLJCBDJI(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EHLNDDDNIPO<BGLCIALODCA> FCPMKLINNFL(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> AOFCGKHNGDJ, int AOEKFBBDHFP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EHLNDDDNIPO<BGLCIALODCA> BELJPNBNBMJ(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG, int AOEKFBBDHFP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int IHBAPDHFCFB(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? NNJLCBGHOEO(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int GJLEOINABFO(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? LGOGFBHGDHM(TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, int MNFHMLCLFEB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BBLOEPHALKG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x37E8AD0", Offset = "0x37E74D0", VA = "0x1837E8AD0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK?> BJIBFJNGIKI<T, TOpInput, TOpOutput>(this KPNJGMAPGMG NMEFAPBBOCD, T LCMCGCNDGLJ, T JAOCPECLJLL, int HDLCOPNNOAA, IntPtr ECPGINANOKO)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x37EAF20", Offset = "0x37E9920", VA = "0x1837EAF20")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK?> MPDPHPCFMHG<T, TOpInput, TOpOutput>(this KPNJGMAPGMG NMEFAPBBOCD, T LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL, int HDLCOPNNOAA, IntPtr ECPGINANOKO)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x37EAE00", Offset = "0x37E9800", VA = "0x1837EAE00")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK?> MLAGAAFEFOP<TOpInput, TOpOutput>(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL, int HDLCOPNNOAA, IntPtr ECPGINANOKO)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28FBB50", Offset = "0x28FA550", VA = "0x1828FBB50")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> FBBJEEFKAIO(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28FD510", Offset = "0x28FBF10", VA = "0x1828FD510")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> INMLDIKLKDD(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28FADA0", Offset = "0x28F97A0", VA = "0x1828FADA0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CHKBGGGNKBG(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28FA7E0", Offset = "0x28F91E0", VA = "0x1828FA7E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> AMIIFELDAPI(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28FB870", Offset = "0x28FA270", VA = "0x1828FB870")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EBCHNGEONIA(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28FE0F0", Offset = "0x28FCAF0", VA = "0x1828FE0F0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KMPKHKEINMC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x28FB280", Offset = "0x28F9C80", VA = "0x1828FB280")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> DEELEKIAABE(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x28FE900", Offset = "0x28FD300", VA = "0x1828FE900")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MKHIAIBOFCN(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x28FAC60", Offset = "0x28F9660", VA = "0x1828FAC60")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> BJGIKDAABNO(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x28FC5B0", Offset = "0x28FAFB0", VA = "0x1828FC5B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> GMDAKIIOJMI(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, int JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x28FE470", Offset = "0x28FCE70", VA = "0x1828FE470")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MEIBKHECCHC(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28FDEB0", Offset = "0x28FC8B0", VA = "0x1828FDEB0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KKAAHCIMBML(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28FD890", Offset = "0x28FC290", VA = "0x1828FD890")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JDJLDBCCJDC(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, float JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x28FA5A0", Offset = "0x28F8FA0", VA = "0x1828FA5A0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> AFIJAKAFAEH(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x28FDC50", Offset = "0x28FC650", VA = "0x1828FDC50")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KFPNFCIFPMN(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x28FDBD0", Offset = "0x28FC5D0", VA = "0x1828FDBD0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KECGDFPAFON(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, int JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x28FC4B0", Offset = "0x28FAEB0", VA = "0x1828FC4B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> GEENAAGPMJH(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x28FF8E0", Offset = "0x28FE2E0", VA = "0x1828FF8E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PPMCAJFGIEG(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28FC530", Offset = "0x28FAF30", VA = "0x1828FC530")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> GLEPFIAGKIG(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, float JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28FAEE0", Offset = "0x28F98E0", VA = "0x1828FAEE0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CKGMCOECAHG(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x28FC910", Offset = "0x28FB310", VA = "0x1828FC910")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HKNEHHNCDOL(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x28FB1E0", Offset = "0x28F9BE0", VA = "0x1828FB1E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> DDEHDHFENOF(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, int JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28FF7C0", Offset = "0x28FE1C0", VA = "0x1828FF7C0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PIJDHMJIBPI(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28FD270", Offset = "0x28FBC70", VA = "0x1828FD270")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> IECFGIPBNEC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28FB990", Offset = "0x28FA390", VA = "0x1828FB990")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EGOJEOHPHGF(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, float JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28FD810", Offset = "0x28FC210", VA = "0x1828FD810")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JBAIIIENADE(this KPNJGMAPGMG NMEFAPBBOCD, float LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x28FF000", Offset = "0x28FDA00", VA = "0x1828FF000")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NFJHBIGNCIA(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x28FCF90", Offset = "0x28FB990", VA = "0x1828FCF90")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> IBNILPMLKPA(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x28FEF80", Offset = "0x28FD980", VA = "0x1828FEF80")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> NBGDDLJACGC(this KPNJGMAPGMG NMEFAPBBOCD, int PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x28FF840", Offset = "0x28FE240", VA = "0x1828FF840")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> PONLEFJBBOJ(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28FD630", Offset = "0x28FC030", VA = "0x1828FD630")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> JAFOEOPGONG(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> BHCNBAMKBJM)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28FAAA0", Offset = "0x28F94A0", VA = "0x1828FAAA0")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> BBOLMLKMCBE(this KPNJGMAPGMG NMEFAPBBOCD, int PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28FAA00", Offset = "0x28F9400", VA = "0x1828FAA00")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> ANPJMBGAHDB(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28FB380", Offset = "0x28F9D80", VA = "0x1828FB380")]
	public static (EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>) DHIKCIKBFBH(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<NMDBEOHACCF> AKBAGFFBKCD, [In] ReadOnlySpan<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> FOABHHONDMI, [In] ReadOnlySpan<int?> JJBIIKFGIJJ, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PFMDEDFBDLK)
	{
		return default((EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28FC990", Offset = "0x28FB390", VA = "0x1828FC990")]
	public static (EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>) HMBOEPJFPIK(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<PJODMDDODDF> JHCAOEOFIPE, [In] ReadOnlySpan<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> FOABHHONDMI, [In] ReadOnlySpan<int?> JJBIIKFGIJJ, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PFMDEDFBDLK)
	{
		return default((EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37E9C20", Offset = "0x37E8620", VA = "0x1837E9C20")]
	public static (EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>) JLAKLANBPME<TMarker>(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<JGGKNECOACC> HLNAPJKFGHA, [In] ReadOnlySpan<byte> HPGIDELCODH)
	{
		return default((EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<DBKGEMIMENE<JGGKNECOACC>>, EHLNDDDNIPO<DBKGEMIMENE<HHAFOACDJND>>, EHLNDDDNIPO<DBKGEMIMENE<TMarker>>, EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28FF5D0", Offset = "0x28FDFD0", VA = "0x1828FF5D0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> OLIAFEIEELE(this KPNJGMAPGMG NMEFAPBBOCD, int PHBACDCOLMA, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28FF080", Offset = "0x28FDA80", VA = "0x1828FF080")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NGKMDMDBMOM(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PHBACDCOLMA, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28FE810", Offset = "0x28FD210", VA = "0x1828FE810")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MHJIFHOLMBP(this KPNJGMAPGMG NMEFAPBBOCD, [In] ReadOnlySpan<byte> PHBACDCOLMA, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28FDAB0", Offset = "0x28FC4B0", VA = "0x1828FDAB0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JONELEFPCKE(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PHBACDCOLMA, int OPKPFANIILK, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28FD170", Offset = "0x28FBB70", VA = "0x1828FD170")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> ICAKJPLGLEH(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28FC6B0", Offset = "0x28FB0B0", VA = "0x1828FC6B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HAMIDLNDFMC(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28FE6D0", Offset = "0x28FD0D0", VA = "0x1828FE6D0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MGLEDFMCJNO(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x28FE370", Offset = "0x28FCD70", VA = "0x1828FE370")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LJKCOOLJPJN(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x28FEAA0", Offset = "0x28FD4A0", VA = "0x1828FEAA0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NAOENOMKNDI(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28FE230", Offset = "0x28FCC30", VA = "0x1828FE230")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LGEJLPCHIED(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28FEA20", Offset = "0x28FD420", VA = "0x1828FEA20")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MKNNLAPHMBA(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, int JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28FCF00", Offset = "0x28FB900", VA = "0x1828FCF00")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> IABALHBPKEM(this KPNJGMAPGMG NMEFAPBBOCD, int LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x28FB7F0", Offset = "0x28FA1F0", VA = "0x1828FB7F0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> DIAIPCJNJDJ(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> LCMCGCNDGLJ, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JAOCPECLJLL)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x28FF3B0", Offset = "0x28FDDB0", VA = "0x1828FF3B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> OBLODHFKKKC(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x28FF690", Offset = "0x28FE090", VA = "0x1828FF690")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> ONJPEKFOHJM(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28FB0A0", Offset = "0x28F9AA0", VA = "0x1828FB0A0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CMODIKMPLAC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x28FCE00", Offset = "0x28FB800", VA = "0x1828FCE00")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HNOIPHLMEHA(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x28FDD90", Offset = "0x28FC790", VA = "0x1828FDD90")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KGNMLDGBAIH(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28FAF60", Offset = "0x28F9960", VA = "0x1828FAF60")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> CLEOMBECIEH(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28FB260", Offset = "0x28F9C60", VA = "0x1828FB260")]
	public static EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>> DDPNLMLLABI(this KPNJGMAPGMG NMEFAPBBOCD)
	{
		return default(EHLNDDDNIPO<DBKGEMIMENE<DBKGEMIMENE<LMLEJHGBBKH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x28FBD50", Offset = "0x28FA750", VA = "0x1828FBD50")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> FLNAFEGEHLE(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x28FD2F0", Offset = "0x28FBCF0", VA = "0x1828FD2F0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> IJCDLPHHPBI(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x28FE590", Offset = "0x28FCF90", VA = "0x1828FE590")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> MGHDBIOAHEC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x28FF2B0", Offset = "0x28FDCB0", VA = "0x1828FF2B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NKJLIGHDPFL(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x28FD990", Offset = "0x28FC390", VA = "0x1828FD990")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JKELFLJLFAB(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x28FC7D0", Offset = "0x28FB1D0", VA = "0x1828FC7D0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HBAFPOHAIJG(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28FDFF0", Offset = "0x28FC9F0", VA = "0x1828FDFF0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KKLNCPKHNPN(this KPNJGMAPGMG NMEFAPBBOCD, int PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28FA6D0", Offset = "0x28F90D0", VA = "0x1828FA6D0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> AKKEDOPPNHO(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PCDAHJCDHHF)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x28FCF80", Offset = "0x28FB980", VA = "0x1828FCF80")]
	public static void IBJIGKNMDPG(this KPNJGMAPGMG NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x28FD410", Offset = "0x28FBE10", VA = "0x1828FD410")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> IMDBJHOPLJJ(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, float EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x28FF4B0", Offset = "0x28FDEB0", VA = "0x1828FF4B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> OFEEBDJILHH(this KPNJGMAPGMG NMEFAPBBOCD, float HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x28FAB20", Offset = "0x28F9520", VA = "0x1828FAB20")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> BEFJNHKAHOC(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x28FBC50", Offset = "0x28FA650", VA = "0x1828FBC50")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> FCCLJGMGHMJ(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x28FC290", Offset = "0x28FAC90", VA = "0x1828FC290")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> GCJICCADADA(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x28FBA10", Offset = "0x28FA410", VA = "0x1828FBA10")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKADIDJCBKO(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x28FEBC0", Offset = "0x28FD5C0", VA = "0x1828FEBC0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NBDLIPPIFGL(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> PPLPJDNHAPM, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> DCOBIANLKAO)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x28FC3B0", Offset = "0x28FADB0", VA = "0x1828FC3B0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> GDNGDKJEMGC(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, int EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x28FA8E0", Offset = "0x28F92E0", VA = "0x1828FA8E0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> ANNBKHGIMGF(this KPNJGMAPGMG NMEFAPBBOCD, int HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28FF170", Offset = "0x28FDB70", VA = "0x1828FF170")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> NJOKPIFAAHK(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HPEEBFHHNPH, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> EKNFFHMABLK)
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x37EB200", Offset = "0x37E9C00", VA = "0x1837EB200")]
	public static void NLIOPBAHGPI<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<NMDBEOHACCF> AKBAGFFBKCD, [In] ReadOnlySpan<EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>> JGNCLEOGEAA, [In] ReadOnlySpan<int?> JJBIIKFGIJJ, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PFMDEDFBDLK, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> HKIMNODBMHI, [In] ReadOnlySpan<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>?> MJEJJEJGMAG) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x37E9710", Offset = "0x37E8110", VA = "0x1837E9710")]
	public static void INDDDOLIMLC<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<PJODMDDODDF> IDNDDAFIIDI, [In] ReadOnlySpan<EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>> NHOEPKNJDOL, [In] ReadOnlySpan<int?> JJBIIKFGIJJ, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> PFMDEDFBDLK, [In] Span<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>> HKIMNODBMHI, [In] ReadOnlySpan<EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>?> MJEJJEJGMAG) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x37E90D0", Offset = "0x37E7AD0", VA = "0x1837E90D0")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> ECKGIHKGMLM<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JOBFADCKIAA, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x37EB710", Offset = "0x37EA110", VA = "0x1837EB710")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PAHGDNOFMBN<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> LCCMPIAEPGL, [Optional] EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x37E9D10", Offset = "0x37E8710", VA = "0x1837E9D10")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> KAFPIEBJGBJ<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI) where TDeps : notnull, ACNNICGFMOO<TStateSys> where TStateSys : notnull
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x37E8D80", Offset = "0x37E7780", VA = "0x1837E8D80")]
	public static EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM> DKLHCFCIMAI<TDeps, TStateSys>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI) where TDeps : notnull, ACNNICGFMOO<TStateSys> where TStateSys : notnull
	{
		return default(EHLNDDDNIPO<AHGPLNKAAGG.IHDNKAADMFM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28FC150", Offset = "0x28FAB50", VA = "0x1828FC150")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> FOGIKMKDFEI(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> AAEODHGLLIC, IntPtr BLHENAJKNBL, IntPtr PGDMLDNKOAH)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28FBE50", Offset = "0x28FA850", VA = "0x1828FBE50")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> FNCGNGDPDAN(this KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> HHBBIHJADHN, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> NABILIKKLEI, IntPtr GFCOGNACBBF, IntPtr DHEPCEPPCLN, IntPtr JGFGJFKHEPK, bool IGNEDEHBLNF)
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x37EA750", Offset = "0x37E9150", VA = "0x1837EA750")]
	public static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> MEGEMMCJLFN<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<NMDBEOHACCF> MCNHNNEOKHM, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> HHBBIHJADHN, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> NABILIKKLEI, int? FAALBMDFEFK, [Optional] IntPtr KMGNMBHFEIN) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x37EA440", Offset = "0x37E8E40", VA = "0x1837EA440")]
	private static EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> MEGEMMCJLFN<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<NMDBEOHACCF> MCNHNNEOKHM, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> HHBBIHJADHN, EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI> NABILIKKLEI, int? FAALBMDFEFK) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
		return default(EHLNDDDNIPO<KNHECKPIODN.LAPCJIMOFPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x37E9290", Offset = "0x37E7C90", VA = "0x1837E9290")]
	public static EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> HMBKELJDPCJ<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> PHBACDCOLMA, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>? NNIEOPCEMIL) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
		return default(EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x37EA080", Offset = "0x37E8A80", VA = "0x1837EA080")]
	public static void KIOOHFOMDOM<TDeps, TState>(this KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TState LOPOEJHIPKN, int PGEPONADGHE) where TDeps : notnull, ACNNICGFMOO<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LFECGALFPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> FBJLIFNJMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> COJLFGKMDDL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
	public LFECGALFPMB(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> GHFLNKKCOEG, EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> MGCFMOABIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2904BA0", Offset = "0x29035A0", VA = "0x182904BA0")]
	public static LFECGALFPMB FMDOFBCLPJB(EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>> GHFLNKKCOEG)
	{
		return default(LFECGALFPMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OPHPNKHHADF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class EKBNKIDAIKB : JLBOKCOPIAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CKLPEIDPCPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> CGOHMOFKLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int FOIACCDFCND;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		public CKLPEIDPCPE(EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ, int MNFHMLCLFEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FGJAJLPMGMB : JLBOKCOPIAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct OILCONCCJBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int FOIACCDFCND;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public OILCONCCJBL(int MNFHMLCLFEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class NFPOHIDCIMH : JLBOKCOPIAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LOEDFOPOFMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> CGOHMOFKLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int FOIACCDFCND;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
		public LOEDFOPOFMO(EHLNDDDNIPO<OBIFONDNCDL.IIOIIMIOOJO> GCBDOCLFOJJ, int MNFHMLCLFEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum BJAPCHDNOLD
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
	public sealed class CGJMPCBJINK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class JLBOKCOPIAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NDCNLGAGILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? ILPIHEDADCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LFECGALFPMB JMPICLAFJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BJAPCHDNOLD ABJPJDOFLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EHLNDDDNIPO<JLBOKCOPIAO> IODCNMGKMGJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2905290", Offset = "0x2903C90", VA = "0x182905290")]
		public NDCNLGAGILL(int? MKFEFGIMBND, [In] LFECGALFPMB KIEJLKGPKPL, BJAPCHDNOLD ILBKJJNBJPM, EHLNDDDNIPO<JLBOKCOPIAO> FOBEDGJCMOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class BNPLHCCNFNJ : JLBOKCOPIAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KFPGJNBIMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int FOIACCDFCND;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		public KFPGJNBIMGK(int MNFHMLCLFEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal HEJGBCNHHDF<CGJMPCBJINK, NDCNLGAGILL> FFKDBMNBACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal HEJGBCNHHDF<EKBNKIDAIKB, CKLPEIDPCPE> IFMIAAEJMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal HEJGBCNHHDF<NFPOHIDCIMH, LOEDFOPOFMO> IJBDEGMGGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal HEJGBCNHHDF<BNPLHCCNFNJ, KFPGJNBIMGK> GDOMFGHHLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal HEJGBCNHHDF<FGJAJLPMGMB, OILCONCCJBL> NHOPMGNCJME;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2905820", Offset = "0x2904220", VA = "0x182905820")]
	private OPHPNKHHADF([In] HEJGBCNHHDF<CGJMPCBJINK, NDCNLGAGILL> DKPEINKAPEC, [In] HEJGBCNHHDF<EKBNKIDAIKB, CKLPEIDPCPE> GAKLGBFBHMO, [In] HEJGBCNHHDF<NFPOHIDCIMH, LOEDFOPOFMO> PDKHHEOMMOP, [In] HEJGBCNHHDF<BNPLHCCNFNJ, KFPGJNBIMGK> LOKKFPPEDLB, [In] HEJGBCNHHDF<FGJAJLPMGMB, OILCONCCJBL> CCPPOPADGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2905630", Offset = "0x2904030", VA = "0x182905630")]
	public static OPHPNKHHADF FMDOFBCLPJB()
	{
		return default(OPHPNKHHADF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class HEHBHOKLCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2901210", Offset = "0x28FFC10", VA = "0x182901210")]
	public static void EFCPNMLOGFP(this OPHPNKHHADF NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GKHGGLEIPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2900FA0", Offset = "0x28FF9A0", VA = "0x182900FA0")]
	public static void IJLCGHNANIM(KPNJGMAPGMG NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DMPMGEKJHIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, NAGMKCKMGBG> LBLFLGPJALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int NJAFOIAFFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int KADEPCKLIOD;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2900C00", Offset = "0x28FF600", VA = "0x182900C00")]
	private DMPMGEKJHIE([In] CFFOMBMNIPG<OBIFONDNCDL.LNPMCEKEONL, NAGMKCKMGBG> ECEKBBIGFNP, int IEECNGCLLLE, int FDJCMCGIEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2900B90", Offset = "0x28FF590", VA = "0x182900B90")]
	public static DMPMGEKJHIE FMDOFBCLPJB()
	{
		return default(DMPMGEKJHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29009C0", Offset = "0x28FF3C0", VA = "0x1829009C0")]
	public void EFCPNMLOGFP([In] KPNJGMAPGMG MOCCEAFKGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x38D38A0", Offset = "0x38D22A0", VA = "0x1838D38A0")]
	public static void IJLCGHNANIM<TDeps, TStateSys>(KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI, EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF) where TDeps : notnull, ACNNICGFMOO<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MKLNCBJFNEI
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2904F70", Offset = "0x2903970", VA = "0x182904F70")]
	public static void IJLCGHNANIM(KPNJGMAPGMG NMEFAPBBOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KKAMBJHANGP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void POBMBBEKDED(KEIHFOCJOJN<byte> IOKIADMGOHK, int BMPLPIFKIOI);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct POFKEDCPLBA : NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x29059F0", Offset = "0x29043F0", VA = "0x1829059F0", Slot = "4")]
		public void POBMBBEKDED(KEIHFOCJOJN<byte> IOKIADMGOHK, int BMPLPIFKIOI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct MGOIKODENMB : NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2904ED0", Offset = "0x29038D0", VA = "0x182904ED0", Slot = "4")]
		public void POBMBBEKDED(KEIHFOCJOJN<byte> IOKIADMGOHK, int BMPLPIFKIOI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct LIPCAGCDJNA : NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2904BB0", Offset = "0x29035B0", VA = "0x182904BB0", Slot = "4")]
		public void POBMBBEKDED(KEIHFOCJOJN<byte> IOKIADMGOHK, int BMPLPIFKIOI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct PNOKGMJGGEG : NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2905950", Offset = "0x2904350", VA = "0x182905950", Slot = "4")]
		public void POBMBBEKDED(KEIHFOCJOJN<byte> IOKIADMGOHK, int BMPLPIFKIOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class NDGCIPGPNKP<TCallProcessorDeps> where TCallProcessorDeps : struct, NPDOAHHPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps JIMKFPLDKKF;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x41DDE60", Offset = "0x41DC860", VA = "0x1841DDE60")]
		public static int IJLCGHNANIM<TDeps, TStateSys>(TDeps BFPFMKIIKBG, TStateSys LOPOEJHIPKN, KPNJGMAPGMG MOCCEAFKGMN, [In] KEIHFOCJOJN<byte> NILLPAMKAEK, int DDJAIBEMOAN) where TDeps : ACNNICGFMOO<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private KEIHFOCJOJN<KLGCIBMDIEB> GILGEDKEAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> OGGJBPDHBEC;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2903AB0", Offset = "0x29024B0", VA = "0x182903AB0")]
	private KKAMBJHANGP([In] KEIHFOCJOJN<KLGCIBMDIEB> CJNFJKPENPI, Dictionary<EHLNDDDNIPO<DBKGEMIMENE<LMLEJHGBBKH>>, EHLNDDDNIPO<OBIFONDNCDL.LNPMCEKEONL>> NNBCOBMIBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29039F0", Offset = "0x29023F0", VA = "0x1829039F0")]
	public static KKAMBJHANGP FMDOFBCLPJB()
	{
		return default(KKAMBJHANGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x29039B0", Offset = "0x29023B0", VA = "0x1829039B0")]
	public void EFCPNMLOGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B910", Offset = "0x3B0A310", VA = "0x183B0B910")]
	public static void IJLCGHNANIM<TDeps, TStateSys>(KPNJGMAPGMG NMEFAPBBOCD, TDeps BFPFMKIIKBG, TStateSys MPKNDDKICDI) where TDeps : ACNNICGFMOO<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CFMDGMAMBKD
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KICEAGMLCCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> JDOPICNJJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int OGCHDCFGJKG;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int MNHDJNCGEPI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int NFMMOJPHDNA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x29002D0", Offset = "0x28FECD0", VA = "0x1829002D0")]
	public static void IJLCGHNANIM(KPNJGMAPGMG NMEFAPBBOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29000B0", Offset = "0x28FEAB0", VA = "0x1829000B0")]
	private static void CBOHNOOIKAP([In] KPNJGMAPGMG NMEFAPBBOCD, EHLNDDDNIPO<OPHPNKHHADF.CGJMPCBJINK> KHNIMGKFPOO, KEIHFOCJOJN<byte> DGHPFFEGHIG, List<KICEAGMLCCK> JMMAPKIOJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28FFF70", Offset = "0x28FE970", VA = "0x1828FFF70")]
	private static void CBOHNOOIKAP(KEIHFOCJOJN<byte> DGHPFFEGHIG, int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2900840", Offset = "0x28FF240", VA = "0x182900840")]
	private static void JBHJOPKLBLD(KPNJGMAPGMG NMEFAPBBOCD, List<KICEAGMLCCK> JMMAPKIOJJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LPJOIJBMLCB<TDeps, TIndex, TValues> where TDeps : struct, JKGJCAOIIBG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x52A42C0", Offset = "0x52A2CC0", VA = "0x1852A42C0")]
	public static void IJLCGHNANIM([In] KEIHFOCJOJN<KLGCIBMDIEB> CJNFJKPENPI, int IIKKPJLEBBM, TValues OKEIIBNBBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JKGJCAOIIBG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEIHFOCJOJN<TIndex> IOPFAJOIFDO(int IIKKPJLEBBM, [In] TValues OKEIIBNBBOL);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(TIndex MNFHMLCLFEB, [In] TValues OKEIIBNBBOL);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEOPFFIGFME(TIndex MNFHMLCLFEB, TValues OKEIIBNBBOL, EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BCEPJLLMEBP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex OEBBDDNBPPG(int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EABALGLCBLD(TIndex MNFHMLCLFEB, [In] TValues OKEIIBNBBOL);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHLNDDDNIPO<DBKGEMIMENE<GJCAOKDFKPI>> ICAJBKAICNM(TIndex MNFHMLCLFEB, [In] TValues OKEIIBNBBOL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class ECAPAEPNIJN<TDeps, TIndex, TValues> where TDeps : struct, BCEPJLLMEBP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4686F70", Offset = "0x4685970", VA = "0x184686F70")]
	public static KEIHFOCJOJN<TIndex> IJLCGHNANIM(int IIKKPJLEBBM, [In] TValues OKEIIBNBBOL)
	{
		return default(KEIHFOCJOJN<TIndex>);
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

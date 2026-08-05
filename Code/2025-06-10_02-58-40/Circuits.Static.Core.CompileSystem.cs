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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B8DA0", Offset = "0x28B7FA0", VA = "0x1828B8DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ICLJDJKGEKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> HPGIIHFCGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int IJIKKLFMGBN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
	public ICLJDJKGEKJ(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> LCIIKPIOJGB, int GJBFKFHLHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OPJBOJHLFPP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BIBJHIBHIFD : OGHMHDDJJBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HIPJBBLGAPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly ILFFKBCDJGN<byte> JMDPAHCFOMO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2859A80", Offset = "0x2858C80", VA = "0x182859A80")]
		public HIPJBBLGAPB(ILFFKBCDJGN<byte> DJMFMHNIFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28AF9C0", Offset = "0x28AEBC0", VA = "0x1828AF9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GLIPBGOPCCN : OGHMHDDJJBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct DAFGELMMBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> PIFBEHLHFKI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public DAFGELMMBFE(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> OFDLHDHKPIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum BDBKPAEPFOP
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
	public sealed class OKICMFBMLKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class OGHMHDDJJBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct NHHCIAFMDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly BDBKPAEPFOP CFMOMCNKDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly KCKEEEOMPIF<OGHMHDDJJBB> PJKGGHCHACK;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public NHHCIAFMDOK(BDBKPAEPFOP NOKEJIADLKI, KCKEEEOMPIF<OGHMHDDJJBB> AIGIDHMNLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class OJFCMPDFONA : OGHMHDDJJBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct EABADABFJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KOGMIGKLJEF;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public EABADABFJFB(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class EFMLLPFEKDK : OGHMHDDJJBB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct EDNMDDBOEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OBLBHHNOHDI MMHIOJCCGFE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public EDNMDDBOEFI(OBLBHHNOHDI LLDHPJNEFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF0E0", Offset = "0x28AE2E0", VA = "0x1828AF0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal OJGJOGNCCBE<OKICMFBMLKG, NHHCIAFMDOK> CNPJOIOLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal OJGJOGNCCBE<BIBJHIBHIFD, HIPJBBLGAPB> LDOIAAIBHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal OJGJOGNCCBE<GLIPBGOPCCN, DAFGELMMBFE> EMPPPPDCJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal OJGJOGNCCBE<OJFCMPDFONA, EABADABFJFB> EFCACHGNINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal OJGJOGNCCBE<EFMLLPFEKDK, EDNMDDBOEFI> LOILLLOBBME;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28B90B0", Offset = "0x28B82B0", VA = "0x1828B90B0")]
	private OPJBOJHLFPP([In] OJGJOGNCCBE<OKICMFBMLKG, NHHCIAFMDOK> MAAHDIIGPBA, [In] OJGJOGNCCBE<BIBJHIBHIFD, HIPJBBLGAPB> AGHMPDLACAJ, [In] OJGJOGNCCBE<GLIPBGOPCCN, DAFGELMMBFE> AODOBCCFHNO, [In] OJGJOGNCCBE<OJFCMPDFONA, EABADABFJFB> MPIFNPDGFHJ, [In] OJGJOGNCCBE<EFMLLPFEKDK, EDNMDDBOEFI> ODOKKJDCCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28B8F70", Offset = "0x28B8170", VA = "0x1828B8F70")]
	public static OPJBOJHLFPP FAHGDJGLLGD()
	{
		return default(OPJBOJHLFPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JAJIBJFGFGP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28B0B40", Offset = "0x28AFD40", VA = "0x1828B0B40")]
	public static void BEPHGAAGPAM(this OPJBOJHLFPP IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KNDILLIINBG
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
public struct AGAJBAOHLOH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class CBLOCOBFMFN : FPPBFFBIKMK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct JDNKPEFPPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> EFIMFCHMCBO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public JDNKPEFPPGD(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> EJCOJMEMLPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum OJDJGBFIGMB
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
	public sealed class AGEMGEABODI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class FPPBFFBIKMK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KHGBFKNGFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly OJDJGBFIGMB CFMOMCNKDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KCKEEEOMPIF<FPPBFFBIKMK> PJKGGHCHACK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public KHGBFKNGFJE(OJDJGBFIGMB NOKEJIADLKI, KCKEEEOMPIF<FPPBFFBIKMK> AIGIDHMNLGF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal OJGJOGNCCBE<AGEMGEABODI, KHGBFKNGFJE> CNPJOIOLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OJGJOGNCCBE<CBLOCOBFMFN, JDNKPEFPPGD> KPHCLEJOGDI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28ADCD0", Offset = "0x28ACED0", VA = "0x1828ADCD0")]
	private AGAJBAOHLOH([In] OJGJOGNCCBE<AGEMGEABODI, KHGBFKNGFJE> MAAHDIIGPBA, [In] OJGJOGNCCBE<CBLOCOBFMFN, JDNKPEFPPGD> IKLNLJPOKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC40", Offset = "0x28ACE40", VA = "0x1828ADC40")]
	public static AGAJBAOHLOH FAHGDJGLLGD()
	{
		return default(AGAJBAOHLOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FPPBJKMJKGC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28AF510", Offset = "0x28AE710", VA = "0x1828AF510")]
	public static void BEPHGAAGPAM(this AGAJBAOHLOH IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DIFAIJOHEJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public LNOHLJBMIPK<int> PHPMDJIJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public LNOHLJBMIPK<int> ABGDFMOEEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PDADMFDHJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int NIKMNCCPGMP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28AE370", Offset = "0x28AD570", VA = "0x1828AE370")]
	private DIFAIJOHEJP([In] LNOHLJBMIPK<int> JGFNDGPJICO, [In] LNOHLJBMIPK<int> FNBMKFNLMOI, int FPKMJPLDLID, int MLONAIAPKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x28AE2D0", Offset = "0x28AD4D0", VA = "0x1828AE2D0")]
	public static DIFAIJOHEJP FAHGDJGLLGD()
	{
		return default(DIFAIJOHEJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CEDMLMIKIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28ADDA0", Offset = "0x28ACFA0", VA = "0x1828ADDA0")]
	public static void BEPHGAAGPAM(this DIFAIJOHEJP IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JHPMMFOCADB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DJGKKMHBGOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CHNLJCPNFCL : NLEAPIKOEHE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct JOAPLHIHPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly KCKEEEOMPIF<FJENOPFDEEJ> PLELONEMOHN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public JOAPLHIHPLA(KCKEEEOMPIF<FJENOPFDEEJ> FFFFNEAGPOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EGCJEKPMBID
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class NLEAPIKOEHE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct HGLEAGLOKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly DJGKKMHBGOK CFMOMCNKDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly KCKEEEOMPIF<NLEAPIKOEHE> PJKGGHCHACK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		private HGLEAGLOKFL(DJGKKMHBGOK NOKEJIADLKI, KCKEEEOMPIF<NLEAPIKOEHE> AIGIDHMNLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28AF7E0", Offset = "0x28AE9E0", VA = "0x1828AF7E0")]
		public static HGLEAGLOKFL FAHGDJGLLGD(DJGKKMHBGOK NOKEJIADLKI, KCKEEEOMPIF<NLEAPIKOEHE> AIGIDHMNLGF)
		{
			return default(HGLEAGLOKFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HPPMIMFPNDM : NLEAPIKOEHE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PLONEEEEMBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly KCKEEEOMPIF<FJENOPFDEEJ> PLELONEMOHN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public PLONEEEEMBE(KCKEEEOMPIF<FJENOPFDEEJ> FFFFNEAGPOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class FJENOPFDEEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MBMCBGFLJAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LNOHLJBMIPK<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> BOHFENNAMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LNOHLJBMIPK<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> CAKKPAODMHK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28ADCD0", Offset = "0x28ACED0", VA = "0x1828ADCD0")]
		private MBMCBGFLJAO([In] LNOHLJBMIPK<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> IGDEBNHMJLC, [In] LNOHLJBMIPK<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> LMGKOEAKFGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28B38E0", Offset = "0x28B2AE0", VA = "0x1828B38E0")]
		public static MBMCBGFLJAO FAHGDJGLLGD()
		{
			return default(MBMCBGFLJAO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal OJGJOGNCCBE<EGCJEKPMBID, HGLEAGLOKFL> CNPJOIOLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal OJGJOGNCCBE<HPPMIMFPNDM, PLONEEEEMBE> CJLIGHFFKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal OJGJOGNCCBE<CHNLJCPNFCL, JOAPLHIHPLA> PELLCEMGNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LNOHLJBMIPK<(KCKEEEOMPIF<EGCJEKPMBID> CallId, KCKEEEOMPIF<FJENOPFDEEJ> IOId)> FLDOMPANMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal OJGJOGNCCBE<FJENOPFDEEJ, MBMCBGFLJAO> KBHHCMMGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal ENEMFDFPNBB<FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> MNKEIAGCLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal ENEMFDFPNBB<FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> EJKCCBIEFEL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28B0D90", Offset = "0x28AFF90", VA = "0x1828B0D90")]
	private JHPMMFOCADB([In] OJGJOGNCCBE<EGCJEKPMBID, HGLEAGLOKFL> MAAHDIIGPBA, [In] OJGJOGNCCBE<HPPMIMFPNDM, PLONEEEEMBE> BHIBOODOAGF, [In] OJGJOGNCCBE<CHNLJCPNFCL, JOAPLHIHPLA> DCOHGFDNAEM, [In] LNOHLJBMIPK<(KCKEEEOMPIF<EGCJEKPMBID> CallId, KCKEEEOMPIF<FJENOPFDEEJ> IOId)> GEDEEEENFIP, [In] OJGJOGNCCBE<FJENOPFDEEJ, MBMCBGFLJAO> IKGEJIMLGEG, [In] ENEMFDFPNBB<FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> AGPADMJLNJK, [In] ENEMFDFPNBB<FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> ALAEMEDICJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28B0BF0", Offset = "0x28AFDF0", VA = "0x1828B0BF0")]
	public static JHPMMFOCADB FAHGDJGLLGD()
	{
		return default(JHPMMFOCADB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KLLGLMGNKOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28B0E90", Offset = "0x28B0090", VA = "0x1828B0E90")]
	private static void BEPHGAAGPAM(this JHPMMFOCADB.MBMCBGFLJAO IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28B0EE0", Offset = "0x28B00E0", VA = "0x1828B0EE0")]
	public static void BEPHGAAGPAM(this JHPMMFOCADB IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DIMBOFFMCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LNOHLJBMIPK<byte> CNFBLDBOFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal JHPMMFOCADB CPANNJOPBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IGOBBLMOCPA GFPOCKMFNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> OBKMHJCNCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OPJBOJHLFPP DCKFCOAEHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal AGAJBAOHLOH JANLNOHGBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal ENEMFDFPNBB<DOFCOOPBBLO, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>?> JPGOONFOBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal LNOHLJBMIPK<KCKEEEOMPIF<DOFCOOPBBLO>> MMKOOCGNNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> OECPEGNDKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> FBOOBPLEPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> DOEGANBOPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal KOHMAIJJLFF GEJNDIPDIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal DGEIDLIPHPA OBFMLIHDHEF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x28AED80", Offset = "0x28ADF80", VA = "0x1828AED80")]
	private DIMBOFFMCBK([In] LNOHLJBMIPK<byte> HCNIACJNMLK, [In] JHPMMFOCADB LAMMBALOLCA, [In] IGOBBLMOCPA HCPLOFNBGFN, [In] OPJBOJHLFPP KPEFCNFIIIL, [In] AGAJBAOHLOH CACONDOFGLA, [In] ENEMFDFPNBB<DOFCOOPBBLO, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>?> BHPPIKEBGPC, [In] LNOHLJBMIPK<KCKEEEOMPIF<DOFCOOPBBLO>> GDOCOKFBLEL, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> ILEHBAOILIE, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> MPCEHDAIKPG, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> KBOCGGPGLGI, [In] KOHMAIJJLFF NGIDCPKCMKM, [In] DGEIDLIPHPA PCIABLBJGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x28AE3D0", Offset = "0x28AD5D0", VA = "0x1828AE3D0")]
	public static DIMBOFFMCBK FAHGDJGLLGD()
	{
		return default(DIMBOFFMCBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LHCLLBDENCC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct MAGLEGMGMHF : DDOMJGLHFBF<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28B3830", Offset = "0x28B2A30", VA = "0x1828B3830")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28B38B0", Offset = "0x28B2AB0", VA = "0x1828B38B0", Slot = "4")]
		public KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		public bool NOEIMAINNDD(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "5")]
		private bool HBHDAOLADBP(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28B3830", Offset = "0x28B2A30", VA = "0x1828B3830", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> ENCMDHJLBLO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct IMKGLKDPMBC : OFLPDOCBHPB<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x28B0920", Offset = "0x28AFB20", VA = "0x1828B0920")]
		public LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> MAMGAMPHPBI(int MHHOBBLHHGN, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28B0990", Offset = "0x28AFB90", VA = "0x1828B0990")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x28B0A10", Offset = "0x28AFC10", VA = "0x1828B0A10", Slot = "6")]
		public void LONADOJLOGO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28B0920", Offset = "0x28AFB20", VA = "0x1828B0920", Slot = "4")]
		private LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> ALPGMPHPADA(int MHHOBBLHHGN, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28B0990", Offset = "0x28AFB90", VA = "0x1828B0990", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> GAEIJMLJBAK(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct LJKOJJIBOEI : DDOMJGLHFBF<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28B3780", Offset = "0x28B2980", VA = "0x1828B3780")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28B3800", Offset = "0x28B2A00", VA = "0x1828B3800", Slot = "4")]
		public KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		public bool NOEIMAINNDD(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "5")]
		private bool EAGLIFPOKGD(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x28B3780", Offset = "0x28B2980", VA = "0x1828B3780", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> EGGLKCFODLC(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct EEAPCEELGPH : OFLPDOCBHPB<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x28AF180", Offset = "0x28AE380", VA = "0x1828AF180")]
		public LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> MAMGAMPHPBI(int MHHOBBLHHGN, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28AF100", Offset = "0x28AE300", VA = "0x1828AF100")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF1F0", Offset = "0x28AE3F0", VA = "0x1828AF1F0", Slot = "6")]
		public void LONADOJLOGO(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28AF180", Offset = "0x28AE380", VA = "0x1828AF180", Slot = "4")]
		private LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> CEEBHMMJDEG(int MHHOBBLHHGN, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28AF100", Offset = "0x28AE300", VA = "0x1828AF100", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> AOPHJCAHGJK(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> CMDFFDAPDIB, [In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct OEGCNDKFMAD : DDOMJGLHFBF<KCKEEEOMPIF<FJGEHMMFOEB>, ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28B8E20", Offset = "0x28B8020", VA = "0x1828B8E20")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28B8F30", Offset = "0x28B8130", VA = "0x1828B8F30", Slot = "4")]
		public KCKEEEOMPIF<FJGEHMMFOEB> GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(KCKEEEOMPIF<FJGEHMMFOEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28B8ED0", Offset = "0x28B80D0", VA = "0x1828B8ED0")]
		public bool NOEIMAINNDD(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28B8ED0", Offset = "0x28B80D0", VA = "0x1828B8ED0", Slot = "5")]
		private bool FJPGMLJFAKE(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28B8EC0", Offset = "0x28B80C0", VA = "0x1828B8EC0", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> FIAJNONGLGF(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct HIBGMNKKDKE : OFLPDOCBHPB<KCKEEEOMPIF<FJGEHMMFOEB>, ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28AF890", Offset = "0x28AEA90", VA = "0x1828AF890")]
		public LNOHLJBMIPK<KCKEEEOMPIF<FJGEHMMFOEB>> MAMGAMPHPBI(int MHHOBBLHHGN, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<FJGEHMMFOEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28AF7F0", Offset = "0x28AE9F0", VA = "0x1828AF7F0")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28AF900", Offset = "0x28AEB00", VA = "0x1828AF900", Slot = "6")]
		public void LONADOJLOGO(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x28AF890", Offset = "0x28AEA90", VA = "0x1828AF890", Slot = "4")]
		private LNOHLJBMIPK<KCKEEEOMPIF<FJGEHMMFOEB>> HJCOGMKJGON(int MHHOBBLHHGN, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<KCKEEEOMPIF<FJGEHMMFOEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x28AF9B0", Offset = "0x28AEBB0", VA = "0x1828AF9B0", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> NMCAHFKHCEJ(KCKEEEOMPIF<FJGEHMMFOEB> CMDFFDAPDIB, [In] ENEMFDFPNBB<FJGEHMMFOEB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>?> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct PBMDBKLIHHO : DDOMJGLHFBF<int, LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9140", Offset = "0x28B8340", VA = "0x1828B9140")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAC71B0", Offset = "0xAC63B0", VA = "0x180AC71B0", Slot = "4")]
		public int GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		public bool NOEIMAINNDD(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "5")]
		private bool MLMMKNDHMDH(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28B91C0", Offset = "0x28B83C0", VA = "0x1828B91C0", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> MOEPIMILOPD(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct CHIINNIIGCK : OFLPDOCBHPB<int, LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28AE020", Offset = "0x28AD220", VA = "0x1828AE020")]
		public LNOHLJBMIPK<int> MAMGAMPHPBI(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28ADFA0", Offset = "0x28AD1A0", VA = "0x1828ADFA0")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28AE0A0", Offset = "0x28AD2A0", VA = "0x1828AE0A0", Slot = "6")]
		public void LONADOJLOGO(int CMDFFDAPDIB, LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28AE020", Offset = "0x28AD220", VA = "0x1828AE020", Slot = "4")]
		private LNOHLJBMIPK<int> DPGENOFMPIE(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28AE090", Offset = "0x28AD290", VA = "0x1828AE090", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> EOEBBPAKHNH(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> VariableId, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<GHACCAJHFPL>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct MDLMLLCMELO : DDOMJGLHFBF<int, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x28B3960", Offset = "0x28B2B60", VA = "0x1828B3960")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAC71B0", Offset = "0xAC63B0", VA = "0x180AC71B0", Slot = "4")]
		public int GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		public bool NOEIMAINNDD(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "5")]
		private bool KFDBGEOAFHL(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28B3960", Offset = "0x28B2B60", VA = "0x1828B3960", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> DFOAPEILMND(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct FOBEJOEOJPI : OFLPDOCBHPB<int, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28AF4A0", Offset = "0x28AE6A0", VA = "0x1828AF4A0")]
		public LNOHLJBMIPK<int> MAMGAMPHPBI(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28AF340", Offset = "0x28AE540", VA = "0x1828AF340")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28AF3C0", Offset = "0x28AE5C0", VA = "0x1828AF3C0", Slot = "6")]
		public void LONADOJLOGO(int CMDFFDAPDIB, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28AF4A0", Offset = "0x28AE6A0", VA = "0x1828AF4A0", Slot = "4")]
		private LNOHLJBMIPK<int> MNEHEMICKPP(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28AF340", Offset = "0x28AE540", VA = "0x1828AF340", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> IIGNEBOEJIO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LEBGHOJCADF : DDOMJGLHFBF<int, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28B1370", Offset = "0x28B0570", VA = "0x1828B1370")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAC71B0", Offset = "0xAC63B0", VA = "0x180AC71B0", Slot = "4")]
		public int GLMMGDOHEHO(int CMDFFDAPDIB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570")]
		public bool NOEIMAINNDD(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "5")]
		private bool KFDBGEOAFHL(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28B13F0", Offset = "0x28B05F0", VA = "0x1828B13F0", Slot = "6")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> DFOAPEILMND(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct GBNMNOEKBHK : OFLPDOCBHPB<int, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28AF6F0", Offset = "0x28AE8F0", VA = "0x1828AF6F0")]
		public LNOHLJBMIPK<int> MAMGAMPHPBI(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28AF570", Offset = "0x28AE770", VA = "0x1828AF570")]
		public KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28AF600", Offset = "0x28AE800", VA = "0x1828AF600", Slot = "6")]
		public void LONADOJLOGO(int CMDFFDAPDIB, LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28AF6F0", Offset = "0x28AE8F0", VA = "0x1828AF6F0", Slot = "4")]
		private LNOHLJBMIPK<int> MNEHEMICKPP(int MHHOBBLHHGN, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(LNOHLJBMIPK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28AF5F0", Offset = "0x28AE7F0", VA = "0x1828AF5F0", Slot = "5")]
		private KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> IIGNEBOEJIO(int CMDFFDAPDIB, [In] LNOHLJBMIPK<(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> Target, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> ByteCodeWriteLocation)> LMKJLPPFOFC)
		{
			return default(KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct FGPIMCAHLEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> MJLAJLACCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool FODIMJDIMEC;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D1C0", Offset = "0x1F5C3C0", VA = "0x181F5D1C0")]
		public FGPIMCAHLEK(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, bool IGCMBBKCMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x28AF330", Offset = "0x28AE530", VA = "0x1828AF330")]
		public void PCEFEHILDBC([Out] KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, [Out] bool IGCMBBKCMOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct JPNCBBFEJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly KCKEEEOMPIF<FJGEHMMFOEB> NKJELLMNKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> MJLAJLACCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool FODIMJDIMEC;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E80", Offset = "0x28B0080", VA = "0x1828B0E80")]
		public JPNCBBFEJDA(KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, bool IGCMBBKCMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E50", Offset = "0x28B0050", VA = "0x1828B0E50")]
		public void PCEFEHILDBC([Out] KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, [Out] bool IGCMBBKCMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x28B0E60", Offset = "0x28B0060", VA = "0x1828B0E60")]
		public void PCEFEHILDBC([Out] KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, [Out] KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO, [Out] bool IGCMBBKCMOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct OGFKFPICKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly KCKEEEOMPIF<FJGEHMMFOEB> NKJELLMNKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> MJLAJLACCJN;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public OGFKFPICKHF(KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x28B8F60", Offset = "0x28B8160", VA = "0x1828B8F60")]
		public void PCEFEHILDBC([Out] KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ, [Out] KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x28B14B0", Offset = "0x28B06B0", VA = "0x1828B14B0")]
	public static void BEPHGAAGPAM(this DIMBOFFMCBK IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28B3630", Offset = "0x28B2830", VA = "0x1828B3630")]
	public static void PHFNLOEPBNF(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> KJKMGAFGEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28B2180", Offset = "0x28B1380", VA = "0x1828B2180")]
	public static void GIFOLAGAKFI(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> KJKMGAFGEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28B27E0", Offset = "0x28B19E0", VA = "0x1828B27E0")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>? JGNDEIKOBJI([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x28B1400", Offset = "0x28B0600", VA = "0x1828B1400")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> AMBGCKFIFHE([In] this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x28B2EB0", Offset = "0x28B20B0", VA = "0x1828B2EB0")]
	private static void KFFAIMHKOGB(this DIMBOFFMCBK IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x28B2470", Offset = "0x28B1670", VA = "0x1828B2470")]
	private static KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>? HKKANIABLKF([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x28B1CD0", Offset = "0x28B0ED0", VA = "0x1828B1CD0")]
	public static void FDHJNKLLLGN(this DIMBOFFMCBK IPOCHJJJBCM, [In] LNOHLJBMIPK<ICLJDJKGEKJ> IGBENLEKLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28B2250", Offset = "0x28B1450", VA = "0x1828B2250")]
	public static OPJBOJHLFPP.BDBKPAEPFOP HCNDAPGONEL([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(OPJBOJHLFPP.BDBKPAEPFOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28B1EA0", Offset = "0x28B10A0", VA = "0x1828B1EA0")]
	public static ILFFKBCDJGN<byte> FJBEPMIKGDP([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(ILFFKBCDJGN<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x28B1820", Offset = "0x28B0A20", VA = "0x1828B1820")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CDLIOMAJDIG([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28B2A90", Offset = "0x28B1C90", VA = "0x1828B2A90")]
	public static OBLBHHNOHDI JNJHBPJHMKF([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(OBLBHHNOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8AD0", Offset = "0x3AC7CD0", VA = "0x183AC8AD0")]
	private static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> PIKJNFHFKFM<TMJoin>(this DIMBOFFMCBK IPOCHJJJBCM, OPJBOJHLFPP.BDBKPAEPFOP NOKEJIADLKI, KCKEEEOMPIF<TMJoin> AIGIDHMNLGF) where TMJoin : OPJBOJHLFPP.OGHMHDDJJBB
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28B2870", Offset = "0x28B1A70", VA = "0x1828B2870")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> JICJMIJPIGE(this DIMBOFFMCBK IPOCHJJJBCM, bool GLMEIPAHNKJ)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28B2680", Offset = "0x28B1880", VA = "0x1828B2680")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> ICBBCMFBAKA(this DIMBOFFMCBK IPOCHJJJBCM, ILFFKBCDJGN<byte> DJMFMHNIFDE)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28B2710", Offset = "0x28B1910", VA = "0x1828B2710")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> IKFFHIFKCLA(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> OFDLHDHKPIB)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x28B1C50", Offset = "0x28B0E50", VA = "0x1828B1C50")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> ELKLGAEAOMD(this DIMBOFFMCBK IPOCHJJJBCM, int GMMEMBEBJMD)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28B28F0", Offset = "0x28B1AF0", VA = "0x1828B28F0")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> JJHJCLIGJCP(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7070", Offset = "0x3AC6270", VA = "0x183AC7070")]
	private static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> ELLHNPLNNFB<TMJoin>(this DIMBOFFMCBK IPOCHJJJBCM, AGAJBAOHLOH.OJDJGBFIGMB NOKEJIADLKI, KCKEEEOMPIF<TMJoin> AIGIDHMNLGF) where TMJoin : AGAJBAOHLOH.FPPBFFBIKMK
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28B1780", Offset = "0x28B0980", VA = "0x1828B1780")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> BJIIENPIIMM(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x28B2790", Offset = "0x28B1990", VA = "0x1828B2790")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> JBDJMBGFPJD(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28B2100", Offset = "0x28B1300", VA = "0x1828B2100")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> GAMCPMAALCE(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> EJCOJMEMLPC)
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28B25A0", Offset = "0x28B17A0", VA = "0x1828B25A0")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> HONOLFPLICA(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28B2370", Offset = "0x28B1570", VA = "0x1828B2370")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> HIEFBAMJOGJ(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28B3260", Offset = "0x28B2460", VA = "0x1828B3260")]
	public static JHPMMFOCADB.DJGKKMHBGOK LEBADOIACCN([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG)
	{
		return default(JHPMMFOCADB.DJGKKMHBGOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28B2560", Offset = "0x28B1760", VA = "0x1828B2560")]
	public static MNFEJHFBPAJ<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, GGGJHBGGKGJ<JHPMMFOCADB.FJENOPFDEEJ>> HNNKCPBLLNL([In] this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(MNFEJHFBPAJ<KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>, GGGJHBGGKGJ<JHPMMFOCADB.FJENOPFDEEJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28B3420", Offset = "0x28B2620", VA = "0x1828B3420")]
	public static KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> OENHDNLNNBM([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG)
	{
		return default(KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28B1BF0", Offset = "0x28B0DF0", VA = "0x1828B1BF0")]
	public static JHPMMFOCADB.MBMCBGFLJAO DKOEOHPEHHM([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> FFFFNEAGPOH)
	{
		return default(JHPMMFOCADB.MBMCBGFLJAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28B1E40", Offset = "0x28B1040", VA = "0x1828B1E40")]
	public static JHPMMFOCADB.MBMCBGFLJAO FFHOGMGCLLN(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> FFFFNEAGPOH)
	{
		return default(JHPMMFOCADB.MBMCBGFLJAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7520", Offset = "0x3AC6720", VA = "0x183AC7520")]
	private static KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> FGALDIDBBCE<TMJoin>(this DIMBOFFMCBK IPOCHJJJBCM, JHPMMFOCADB.DJGKKMHBGOK NOKEJIADLKI, KCKEEEOMPIF<TMJoin> AIGIDHMNLGF) where TMJoin : JHPMMFOCADB.NLEAPIKOEHE
	{
		return default(KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28B1F50", Offset = "0x28B1150", VA = "0x1828B1F50")]
	public static (KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>) FMAKGEKLGOI(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default((KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28B2D00", Offset = "0x28B1F00", VA = "0x1828B2D00")]
	public static (KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>) KDAELNNLCGJ(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default((KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28B1460", Offset = "0x28B0660", VA = "0x1828B1460")]
	public static KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> AMPHGJFGOHP(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28B35A0", Offset = "0x28B27A0", VA = "0x1828B35A0")]
	public static void OIMNHKAJNAI(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ> FFFFNEAGPOH, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> DAJDBPDGIDN, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>> NAAHEFNAEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7CF0", Offset = "0x3AC6EF0", VA = "0x183AC7CF0")]
	public static FGPIMCAHLEK OIKOLEMLFOJ<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO) where TDeps : FBAHGEOEFCI<TStateSys>
	{
		return default(FGPIMCAHLEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6DF0", Offset = "0x3AC5FF0", VA = "0x183AC6DF0")]
	public static JPNCBBFEJDA CKBBHFMMBJB<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF, int IGNBIIOEOLJ) where TDeps : FBAHGEOEFCI<TStateSys>
	{
		return default(JPNCBBFEJDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7100", Offset = "0x3AC6300", VA = "0x183AC7100")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>? FEHJEAJGNOK<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF, [In] ReadOnlySpan<int> GGDOCKNKNBG, [In] Span<OGFKFPICKHF> FJKKGAAJHNJ) where TDeps : FBAHGEOEFCI<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AC75B0", Offset = "0x3AC67B0", VA = "0x183AC75B0")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> FNNBHGMAMPP<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM) where TDeps : FBAHGEOEFCI<TStateSys>
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28B2BF0", Offset = "0x28B1DF0", VA = "0x1828B2BF0")]
	public static IGOBBLMOCPA.OJMHEAGIOKH KBHBFPPEDLH([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return default(IGOBBLMOCPA.OJMHEAGIOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28B3370", Offset = "0x28B2570", VA = "0x1828B3370")]
	public static IGOBBLMOCPA.FBOHGKAPGKL NNIGNKOEBNC([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return default(IGOBBLMOCPA.FBOHGKAPGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28B32C0", Offset = "0x28B24C0", VA = "0x1828B32C0")]
	public static IGOBBLMOCPA.APPFJELNNBL LPHDNOMONAD([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return default(IGOBBLMOCPA.APPFJELNNBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28B3010", Offset = "0x28B2210", VA = "0x1828B3010")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KJEFDEJMIMB(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD, string GBOCGPJOEEK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x28B23C0", Offset = "0x28B15C0", VA = "0x1828B23C0")]
	public static IGOBBLMOCPA.IPFELFGDPIN HKJJAHJEJJN([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return default(IGOBBLMOCPA.IPFELFGDPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x28B2CA0", Offset = "0x28B1EA0", VA = "0x1828B2CA0")]
	public static IGOBBLMOCPA.HCNHDHIJIDO KBPBBECFIFF([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return default(IGOBBLMOCPA.HCNHDHIJIDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28B2500", Offset = "0x28B1700", VA = "0x1828B2500")]
	public static int? HMDKDEMDFCJ([In] this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7C10", Offset = "0x3AC6E10", VA = "0x183AC7C10")]
	private static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MAEFKNCABGI<TMJoin>(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD, IGOBBLMOCPA.HCNHDHIJIDO NOKEJIADLKI, KCKEEEOMPIF<TMJoin> AIGIDHMNLGF) where TMJoin : IGOBBLMOCPA.CEIDJOCBLAN
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28B2B40", Offset = "0x28B1D40", VA = "0x1828B2B40")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KBDKCIHCGHM(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG, int CMDFFDAPDIB)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28B1B90", Offset = "0x28B0D90", VA = "0x1828B1B90")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DHGFFPDOOMO(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x28B18D0", Offset = "0x28B0AD0", VA = "0x1828B18D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CIDBDAEBJOE(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? FMANDFAGDDE, int? LAPNNOMNEHD)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28B31D0", Offset = "0x28B23D0", VA = "0x1828B31D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KKEGLKLABGE(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD, int CMDFFDAPDIB)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28B17C0", Offset = "0x28B09C0", VA = "0x1828B17C0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BLKPOPINHLC(this DIMBOFFMCBK IPOCHJJJBCM, int? LAPNNOMNEHD)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28B1A60", Offset = "0x28B0C60", VA = "0x1828B1A60")]
	public static void DEHAEOBPMCF(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG, int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28B2970", Offset = "0x28B1B70", VA = "0x1828B2970")]
	public static void JNAGEFCPIMP(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG, int CMDFFDAPDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28B36C0", Offset = "0x28B28C0", VA = "0x1828B36C0")]
	public static void POKJBGEKJPK(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28B25F0", Offset = "0x28B17F0", VA = "0x1828B25F0")]
	public static void HPKCJOMDOHD(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> LBPEJPMBIKP, KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> BFGNDOKFNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28B22B0", Offset = "0x28B14B0", VA = "0x1828B22B0")]
	public static void HICIAPBPFFB(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG, KCKEEEOMPIF<OPBMEBGEBHE<ANNMPPHBLPO>> EEBJGHLIBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7B50", Offset = "0x3AC6D50", VA = "0x183AC7B50")]
	public static void HIGEODOKBJL<M>(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PFJBOJBEGPG, KCKEEEOMPIF<OPBMEBGEBHE<MAGPEGIPAOJ<M>>> EEBJGHLIBME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FBAHGEOEFCI<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCKEEEOMPIF<DPFCDDFFAMI> BDENOEHDKMF(TStateSys JEPGLPCKKJP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCKEEEOMPIF<DPFCDDFFAMI> GNLCMFFLPOE(TStateSys JEPGLPCKKJP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCKEEEOMPIF<DPFCDDFFAMI> LEOBIADONJO(TStateSys JEPGLPCKKJP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KCKEEEOMPIF<DPFCDDFFAMI> CPNGMEENCLM(TStateSys JEPGLPCKKJP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> NPFGAEAHDKJ(TStateSys JEPGLPCKKJP, DIMBOFFMCBK COIPDIHOONF, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> KHFJHKEBGNC(TStateSys JEPGLPCKKJP, DIMBOFFMCBK COIPDIHOONF, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OOBGEMEBDBH(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KCKEEEOMPIF<DOFCOOPBBLO> NLDEIBMKNME(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO, int CPGMEKLDNJF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KNDILLIINBG HGJLNCFHHED(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MGOECMLNLIB(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int MLJCMHGJBBE(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ILFFKBCDJGN<byte> IKODNMGNNPP(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(ILFFKBCDJGN<byte>, KCKEEEOMPIF<DPFCDDFFAMI>) CJIBAOPEJDA(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<FJGEHMMFOEB> LBDFNNKFDEO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int DPNCJPEKMIO(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KCKEEEOMPIF<FJGEHMMFOEB> MNDCJAAOMAP(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> GOIOKDJMNJM, int IGNBIIOEOLJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KCKEEEOMPIF<FJGEHMMFOEB> JGLHCLMMICG(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF, int IGNBIIOEOLJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int ENDJHEMCEGF(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? INPENHIHIDK(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int CMMOAPIMBMP(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? LAJGLCJBMLL(TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, int CMDFFDAPDIB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MHOGFOCDCJE
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6930", Offset = "0x3AF5B30", VA = "0x183AF6930")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO?> GHFPDIIFAAI<T, TOpInput, TOpOutput>(this DIMBOFFMCBK IPOCHJJJBCM, T LNELGBOPHHN, T CKNMBJOIDBN, int DOFAPFCHDBK, IntPtr HNAPICGNPBO)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7CD0", Offset = "0x3AF6ED0", VA = "0x183AF7CD0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO?> KLBEONJJMOI<T, TOpInput, TOpOutput>(this DIMBOFFMCBK IPOCHJJJBCM, T LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN, int DOFAPFCHDBK, IntPtr HNAPICGNPBO)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6300", Offset = "0x3AF5500", VA = "0x183AF6300")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO?> GGIANNDFNJB<TOpInput, TOpOutput>(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN, int DOFAPFCHDBK, IntPtr HNAPICGNPBO)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28B6280", Offset = "0x28B5480", VA = "0x1828B6280")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IBADOCIGDCA(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, float OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x28B5570", Offset = "0x28B4770", VA = "0x1828B5570")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DJFDHCJGNJO(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x28B79E0", Offset = "0x28B6BE0", VA = "0x1828B79E0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MODLCEDIMDK(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28B71D0", Offset = "0x28B63D0", VA = "0x1828B71D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KHLPIEFGKLE(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x28B6160", Offset = "0x28B5360", VA = "0x1828B6160")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IAELJMMMBFB(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28B39F0", Offset = "0x28B2BF0", VA = "0x1828B39F0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> AAIPCPHJDFH(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x28B59F0", Offset = "0x28B4BF0", VA = "0x1828B59F0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EMKJLOJHLPC(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x28B4710", Offset = "0x28B3910", VA = "0x1828B4710")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BOINLAKIKPB(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x28B7B20", Offset = "0x28B6D20", VA = "0x1828B7B20")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MOILIJPEDJD(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x28B8160", Offset = "0x28B7360", VA = "0x1828B8160")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OJABALJDIAP(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, int CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x28B6FB0", Offset = "0x28B61B0", VA = "0x1828B6FB0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KEANGFOBNAP(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28B8A30", Offset = "0x28B7C30", VA = "0x1828B8A30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PMOGFAOHIBA(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28B3C70", Offset = "0x28B2E70", VA = "0x1828B3C70")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> ACOFEMBONJK(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, float CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x28B8B70", Offset = "0x28B7D70", VA = "0x1828B8B70")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PNDPNEBFLAG(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x28B7490", Offset = "0x28B6690", VA = "0x1828B7490")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LGHBHNIOEBH(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x28B44B0", Offset = "0x28B36B0", VA = "0x1828B44B0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BHFMOOPGJPB(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, int CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x28B6CC0", Offset = "0x28B5EC0", VA = "0x1828B6CC0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> JGPDBDEHNBF(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x28B5690", Offset = "0x28B4890", VA = "0x1828B5690")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DLCMJPGLLEH(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28B5710", Offset = "0x28B4910", VA = "0x1828B5710")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DPOBNLBDGEJ(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, float CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28B6520", Offset = "0x28B5720", VA = "0x1828B6520")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IFEAEEHMJGP(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x28B64A0", Offset = "0x28B56A0", VA = "0x1828B64A0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IBFCNHKGHDN(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x28B6C40", Offset = "0x28B5E40", VA = "0x1828B6C40")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> JAEDBEOELAE(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, int CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28B8260", Offset = "0x28B7460", VA = "0x1828B8260")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMDANBILBLP(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x28B5D30", Offset = "0x28B4F30", VA = "0x1828B5D30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> GFCOJNCJJCM(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x28B5B90", Offset = "0x28B4D90", VA = "0x1828B5B90")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> FDNNCEGIBHH(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, float CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x28B4F60", Offset = "0x28B4160", VA = "0x1828B4F60")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CPCEIDDPGMI(this DIMBOFFMCBK IPOCHJJJBCM, float LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x28B5DB0", Offset = "0x28B4FB0", VA = "0x1828B5DB0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> GLCGBGNILHM(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x28B7F00", Offset = "0x28B7100", VA = "0x1828B7F00")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> NPELBBKOHFG(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x28B7410", Offset = "0x28B6610", VA = "0x1828B7410")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> KMFOIAGDLLP(this DIMBOFFMCBK IPOCHJJJBCM, int KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x28B4EC0", Offset = "0x28B40C0", VA = "0x1828B4EC0")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> CLNDEHCAKNJ(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x28B4530", Offset = "0x28B3730", VA = "0x1828B4530")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> BKDNHEPLKCM(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> BPDDGIBGOHJ)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28B6D40", Offset = "0x28B5F40", VA = "0x1828B6D40")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> JMMJKOGPNDO(this DIMBOFFMCBK IPOCHJJJBCM, int KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28B5AF0", Offset = "0x28B4CF0", VA = "0x1828B5AF0")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> EPOGPFAFCPK(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x28B5100", Offset = "0x28B4300", VA = "0x1828B5100")]
	public static (KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>) DJFBKDAIOFP(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<BBBFDNCOMBD> BHLPBENOFDH, [In] ReadOnlySpan<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> IGDEBNHMJLC, [In] ReadOnlySpan<int?> PGAAFBAOEPO, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> MLLFFANJADC)
	{
		return default((KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28B4A50", Offset = "0x28B3C50", VA = "0x1828B4A50")]
	public static (KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>) CIJPOFEIEJA(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<LCDMNAHFDAI> ENBCKIOAODG, [In] ReadOnlySpan<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> IGDEBNHMJLC, [In] ReadOnlySpan<int?> PGAAFBAOEPO, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> MLLFFANJADC)
	{
		return default((KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7FB0", Offset = "0x3AF71B0", VA = "0x183AF7FB0")]
	public static (KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<DPFCDDFFAMI>>, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>, KCKEEEOMPIF<OPBMEBGEBHE<TMarker>>, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>) OKJDNFJCHIB<TMarker>(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<DPFCDDFFAMI> PDNEAPGKHDC, [In] ReadOnlySpan<byte> CAIGHLKIDBF)
	{
		return default((KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<OPBMEBGEBHE<DPFCDDFFAMI>>, KCKEEEOMPIF<OPBMEBGEBHE<BCEMFLBFKNN>>, KCKEEEOMPIF<OPBMEBGEBHE<TMarker>>, KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x28B3D70", Offset = "0x28B2F70", VA = "0x1828B3D70")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> ANJILONAFIN(this DIMBOFFMCBK IPOCHJJJBCM, int IMEMPJAIKHP, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x28B6DC0", Offset = "0x28B5FC0", VA = "0x1828B6DC0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> JNBGLEAJJDL(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IMEMPJAIKHP, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x28B78F0", Offset = "0x28B6AF0", VA = "0x1828B78F0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MHGMCJAODGP(this DIMBOFFMCBK IPOCHJJJBCM, [In] ReadOnlySpan<byte> IMEMPJAIKHP, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28B4FE0", Offset = "0x28B41E0", VA = "0x1828B4FE0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DAMMIMFHMLM(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IMEMPJAIKHP, int GCFCAGDGDIN, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x28B3FF0", Offset = "0x28B31F0", VA = "0x1828B3FF0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BBKIJOKMECB(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, float OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28B5790", Offset = "0x28B4990", VA = "0x1828B5790")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EDGEHCKMOPN(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28B66C0", Offset = "0x28B58C0", VA = "0x1828B66C0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IHGBJEPHHCL(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x28B8640", Offset = "0x28B7840", VA = "0x1828B8640")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PDDCFDFAEAL(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x28B5C10", Offset = "0x28B4E10", VA = "0x1828B5C10")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> FMEIMGCEFME(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28B58B0", Offset = "0x28B4AB0", VA = "0x1828B58B0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EFEBDFIINHL(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28B8740", Offset = "0x28B7940", VA = "0x1828B8740")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PEMMNAFNHFO(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, int CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28B80E0", Offset = "0x28B72E0", VA = "0x1828B80E0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OILCOCGBBDK(this DIMBOFFMCBK IPOCHJJJBCM, int LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x28B3F70", Offset = "0x28B3170", VA = "0x1828B3F70")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BANIDPDGHFI(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LNELGBOPHHN, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CKNMBJOIDBN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x28B76D0", Offset = "0x28B68D0", VA = "0x1828B76D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MAEJCDKIGFA(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, float OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x28B87C0", Offset = "0x28B79C0", VA = "0x1828B87C0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PGKGPJOKHCH(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28B6B00", Offset = "0x28B5D00", VA = "0x1828B6B00")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IJGOEPGODGN(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x28B6EB0", Offset = "0x28B60B0", VA = "0x1828B6EB0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KBHJLDHMLFK(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x28B5F30", Offset = "0x28B5130", VA = "0x1828B5F30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> GMIBNICHMDB(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28B8500", Offset = "0x28B7700", VA = "0x1828B8500")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PBMMBELDDGF(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28B7C60", Offset = "0x28B6E60", VA = "0x1828B7C60")]
	public static KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>> NFIJEIJJBDN(this DIMBOFFMCBK IPOCHJJJBCM)
	{
		return default(KCKEEEOMPIF<OPBMEBGEBHE<OPBMEBGEBHE<GOCBHKMCGNE>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x28B5E30", Offset = "0x28B5030", VA = "0x1828B5E30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> GMGPECCLBHB(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, float OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x28B65A0", Offset = "0x28B57A0", VA = "0x1828B65A0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IGBHLDNNIJC(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x28B3E30", Offset = "0x28B3030", VA = "0x1828B3E30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APNIGHPGCDC(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x28B75D0", Offset = "0x28B67D0", VA = "0x1828B75D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> LHNDEIEEOOB(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x28B6380", Offset = "0x28B5580", VA = "0x1828B6380")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IBEMAFJOPOP(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x28B88F0", Offset = "0x28B7AF0", VA = "0x1828B88F0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PIOKEANOHLP(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x28B8400", Offset = "0x28B7600", VA = "0x1828B8400")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OPCDICMMKNK(this DIMBOFFMCBK IPOCHJJJBCM, int KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28B6050", Offset = "0x28B5250", VA = "0x1828B6050")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> HNPGJGHOMEH(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KJIOHKMJAPE)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x28B39E0", Offset = "0x28B2BE0", VA = "0x1828B39E0")]
	public static void AABKOGNKDAN(this DIMBOFFMCBK IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x28B4830", Offset = "0x28B3A30", VA = "0x1828B4830")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CBNPOLMDFOM(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, float OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x28B4930", Offset = "0x28B3B30", VA = "0x1828B4930")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> CCPLJFMKNDB(this DIMBOFFMCBK IPOCHJJJBCM, float EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x28B7C80", Offset = "0x28B6E80", VA = "0x1828B7C80")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> NHGABOHDODD(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x28B70D0", Offset = "0x28B62D0", VA = "0x1828B70D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KEFOKPLNFLE(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x28B82E0", Offset = "0x28B74E0", VA = "0x1828B82E0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> ONKDIAIGBMO(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x28B3B30", Offset = "0x28B2D30", VA = "0x1828B3B30")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> ACADJEHACKC(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x28B40F0", Offset = "0x28B32F0", VA = "0x1828B40F0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> BEPGBDIOKOD(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> MNPMLHFDFDB, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> JIEKFNHMHGN)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x28B8CA0", Offset = "0x28B7EA0", VA = "0x1828B8CA0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> PNEFDPPCKHD(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, int OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x28B77D0", Offset = "0x28B69D0", VA = "0x1828B77D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> MGGLGEHHKCD(this DIMBOFFMCBK IPOCHJJJBCM, int EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x28B72D0", Offset = "0x28B64D0", VA = "0x1828B72D0")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> KJLOHCHIFHM(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> EELMGPHLBOC, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> OMOJJPGAJGK)
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6420", Offset = "0x3AF5620", VA = "0x183AF6420")]
	public static void GGINBDKEMFH<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<BBBFDNCOMBD> BHLPBENOFDH, [In] ReadOnlySpan<KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>> BLKECHEMPOI, [In] ReadOnlySpan<int?> PGAAFBAOEPO, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> MLLFFANJADC, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> GCAFALINPHK, [In] ReadOnlySpan<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>?> HBAHNFANFBK) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AF51F0", Offset = "0x3AF43F0", VA = "0x183AF51F0")]
	public static void CNEBIIPAIFC<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<LCDMNAHFDAI> PJBCEMJEHFE, [In] ReadOnlySpan<KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>> DAJIINDAKCC, [In] ReadOnlySpan<int?> PGAAFBAOEPO, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> MLLFFANJADC, [In] Span<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>> GCAFALINPHK, [In] ReadOnlySpan<KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>?> HBAHNFANFBK) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5030", Offset = "0x3AF4230", VA = "0x183AF5030")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> AKKOGLECIOD<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> FMANDFAGDDE, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5700", Offset = "0x3AF4900", VA = "0x183AF5700")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DKANJDNFJOA<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> EJCOJMEMLPC, [Optional] KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6BE0", Offset = "0x3AF5DE0", VA = "0x183AF6BE0")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> ICKGBEMPNDM<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP) where TDeps : notnull, FBAHGEOEFCI<TStateSys> where TStateSys : notnull
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5B30", Offset = "0x3AF4D30", VA = "0x183AF5B30")]
	public static KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI> ELGDKNCKHFE<TDeps, TStateSys>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP) where TDeps : notnull, FBAHGEOEFCI<TStateSys> where TStateSys : notnull
	{
		return default(KCKEEEOMPIF<AGAJBAOHLOH.AGEMGEABODI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x28B7DC0", Offset = "0x28B6FC0", VA = "0x1828B7DC0")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> NNPFMNPHAGF(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> ADEELJJHLFE, IntPtr FNGBPCPBBJA, IntPtr JJOAELJLKOC)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28B6800", Offset = "0x28B5A00", VA = "0x1828B6800")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> IJFKOLDDDLG(this DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> NMEAFJABOAJ, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> INECKPOABAC, IntPtr HHFCIHKBPIM, IntPtr IKMHEMLAKAB, IntPtr CIOIFEPHEAI, bool MIPOFPCMNNH)
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7260", Offset = "0x3AF6460", VA = "0x183AF7260")]
	public static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> IEICGABKOEK<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<BBBFDNCOMBD> OEPHECDLLNF, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> NMEAFJABOAJ, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> INECKPOABAC, int? BBBOFABHEKH, [Optional] IntPtr BFGKMNABFJO) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6F50", Offset = "0x3AF6150", VA = "0x183AF6F50")]
	private static KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> IEICGABKOEK<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<BBBFDNCOMBD> OEPHECDLLNF, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> NMEAFJABOAJ, KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG> INECKPOABAC, int? BBBOFABHEKH) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
		return default(KCKEEEOMPIF<OPJBOJHLFPP.OKICMFBMLKG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5E80", Offset = "0x3AF5080", VA = "0x183AF5E80")]
	public static KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> FEODKHBGJHK<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> IMEMPJAIKHP, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>? DIFDEOAGFLM) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
		return default(KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF7910", Offset = "0x3AF6B10", VA = "0x183AF7910")]
	public static void IPBDECJKBLB<TDeps, TState>(this DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TState CKCKEFFHJAP, int HGNIOIKEMCP) where TDeps : notnull, FBAHGEOEFCI<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BLGNHJGPKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> BIGJABCBPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> NBMHIEPHBNG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
	public BLGNHJGPKOK(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> CHMIGDGIJCB, KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> PIFOKPBEJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x28ADD90", Offset = "0x28ACF90", VA = "0x1828ADD90")]
	public static BLGNHJGPKOK FAHGDJGLLGD(KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>> CHMIGDGIJCB)
	{
		return default(BLGNHJGPKOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct IGOBBLMOCPA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CJBLOPLIPMO : CEIDJOCBLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct OJMHEAGIOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> INCMJFHBOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int IJCKDBACFFD;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public OJMHEAGIOKH(KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG, int CMDFFDAPDIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class PBGJFOOMJOC : CEIDJOCBLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct FBOHGKAPGKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int IJCKDBACFFD;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public FBOHGKAPGKL(int CMDFFDAPDIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class EHIMINLIFCH : CEIDJOCBLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct APPFJELNNBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> INCMJFHBOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int IJCKDBACFFD;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
		public APPFJELNNBL(KCKEEEOMPIF<JHPMMFOCADB.EGCJEKPMBID> MNKGFBDKOHG, int CMDFFDAPDIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum HCNHDHIJIDO
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
	public sealed class DKAMAALLMFO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class CEIDJOCBLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IDLIJEJLEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? LOELCIMGPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BLGNHJGPKOK ABKKOMMBOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HCNHDHIJIDO CFMOMCNKDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KCKEEEOMPIF<CEIDJOCBLAN> PJKGGHCHACK;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28AFB90", Offset = "0x28AED90", VA = "0x1828AFB90")]
		public IDLIJEJLEKM(int? LAPNNOMNEHD, [In] BLGNHJGPKOK KKPPDLDMFJN, HCNHDHIJIDO NOKEJIADLKI, KCKEEEOMPIF<CEIDJOCBLAN> AIGIDHMNLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class IDEGKOAFOIC : CEIDJOCBLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IPFELFGDPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int IJCKDBACFFD;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		public IPFELFGDPIN(int CMDFFDAPDIB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal BACNAJMDHIJ<DKAMAALLMFO, IDLIJEJLEKM> CNPJOIOLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal BACNAJMDHIJ<CJBLOPLIPMO, OJMHEAGIOKH> LGJBCCAONHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal BACNAJMDHIJ<EHIMINLIFCH, APPFJELNNBL> BHICAOMLPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal BACNAJMDHIJ<IDEGKOAFOIC, IPFELFGDPIN> AJECNHHEHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal BACNAJMDHIJ<PBGJFOOMJOC, FBOHGKAPGKL> FCHLPNCIENB;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x28B07F0", Offset = "0x28AF9F0", VA = "0x1828B07F0")]
	private IGOBBLMOCPA([In] BACNAJMDHIJ<DKAMAALLMFO, IDLIJEJLEKM> MAAHDIIGPBA, [In] BACNAJMDHIJ<CJBLOPLIPMO, OJMHEAGIOKH> PHMPMNIAJFG, [In] BACNAJMDHIJ<EHIMINLIFCH, APPFJELNNBL> OMCMNINDFAC, [In] BACNAJMDHIJ<IDEGKOAFOIC, IPFELFGDPIN> LMNNEABGNEO, [In] BACNAJMDHIJ<PBGJFOOMJOC, FBOHGKAPGKL> ILJKMDNKJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x28B0600", Offset = "0x28AF800", VA = "0x1828B0600")]
	public static IGOBBLMOCPA FAHGDJGLLGD()
	{
		return default(IGOBBLMOCPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EIPBKIGDFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x28AF280", Offset = "0x28AE480", VA = "0x1828AF280")]
	public static void BEPHGAAGPAM(this IGOBBLMOCPA IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IAENJBKPBNG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x28AFA30", Offset = "0x28AEC30", VA = "0x1828AFA30")]
	public static void JGHBEDNJLDN(DIMBOFFMCBK IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KOHMAIJJLFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, DIFAIJOHEJP> DEHCCDIMEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JBPLMIBIFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int JGKHINOGBNC;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x28B1330", Offset = "0x28B0530", VA = "0x1828B1330")]
	private KOHMAIJJLFF([In] ENEMFDFPNBB<JHPMMFOCADB.FJENOPFDEEJ, DIFAIJOHEJP> ABBLMGEPONH, int CHCONKJKLPC, int GLEHOPNFKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x28B12C0", Offset = "0x28B04C0", VA = "0x1828B12C0")]
	public static KOHMAIJJLFF FAHGDJGLLGD()
	{
		return default(KOHMAIJJLFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x28B10F0", Offset = "0x28B02F0", VA = "0x1828B10F0")]
	public void BEPHGAAGPAM([In] DIMBOFFMCBK DBNOECLKCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB98C0", Offset = "0x3AB8AC0", VA = "0x183AB98C0")]
	public static void JGHBEDNJLDN<TDeps, TStateSys>(DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP, KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA) where TDeps : notnull, FBAHGEOEFCI<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CEIGKMNLFLI
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x28ADDF0", Offset = "0x28ACFF0", VA = "0x1828ADDF0")]
	public static void JGHBEDNJLDN(DIMBOFFMCBK IPOCHJJJBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DGEIDLIPHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OPONFBOPHMM(LNOHLJBMIPK<byte> HCNIACJNMLK, int CMKHFEIOEGD);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct BIKMCHMONNJ : GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28ADD10", Offset = "0x28ACF10", VA = "0x1828ADD10", Slot = "4")]
		public void OPONFBOPHMM(LNOHLJBMIPK<byte> HCNIACJNMLK, int CMKHFEIOEGD)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct INIOHGBJDLH : GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28B0AA0", Offset = "0x28AFCA0", VA = "0x1828B0AA0", Slot = "4")]
		public void OPONFBOPHMM(LNOHLJBMIPK<byte> HCNIACJNMLK, int CMKHFEIOEGD)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct GPDBJELNJHJ : GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x28AF760", Offset = "0x28AE960", VA = "0x1828AF760", Slot = "4")]
		public void OPONFBOPHMM(LNOHLJBMIPK<byte> HCNIACJNMLK, int CMKHFEIOEGD)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct AFPMHBOKIEK : GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28ADBA0", Offset = "0x28ACDA0", VA = "0x1828ADBA0", Slot = "4")]
		public void OPONFBOPHMM(LNOHLJBMIPK<byte> HCNIACJNMLK, int CMKHFEIOEGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class GEAOGNDLLAI<TCallProcessorDeps> where TCallProcessorDeps : struct, GAOOAPDIFEP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps EMPPIJCDCNI;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3B9A7C0", Offset = "0x3B999C0", VA = "0x183B9A7C0")]
		public static int JGHBEDNJLDN<TDeps, TStateSys>(TDeps AHPCPGHNHGP, TStateSys CKCKEFFHJAP, DIMBOFFMCBK DBNOECLKCOC, [In] LNOHLJBMIPK<byte> FLNODPBLCII, int HLHDAHEMMKO) where TDeps : FBAHGEOEFCI<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private LNOHLJBMIPK<ICLJDJKGEKJ> IDJCEAMHGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> IBCOAHHDDPB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x28AE290", Offset = "0x28AD490", VA = "0x1828AE290")]
	private DGEIDLIPHPA([In] LNOHLJBMIPK<ICLJDJKGEKJ> IGBENLEKLHC, Dictionary<KCKEEEOMPIF<OPBMEBGEBHE<GOCBHKMCGNE>>, KCKEEEOMPIF<JHPMMFOCADB.FJENOPFDEEJ>> BHOEODBCNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x28AE1D0", Offset = "0x28AD3D0", VA = "0x1828AE1D0")]
	public static DGEIDLIPHPA FAHGDJGLLGD()
	{
		return default(DGEIDLIPHPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x28AE190", Offset = "0x28AD390", VA = "0x1828AE190")]
	public void BEPHGAAGPAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3858EE0", Offset = "0x38580E0", VA = "0x183858EE0")]
	public static void JGHBEDNJLDN<TDeps, TStateSys>(DIMBOFFMCBK IPOCHJJJBCM, TDeps AHPCPGHNHGP, TStateSys JEPGLPCKKJP) where TDeps : FBAHGEOEFCI<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IFJLCMNNCIF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct DOBBEGHJJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> DMMKKHMABPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int EBHCGIIIHFI;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int GEHMEMFONCL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int POMANOCLKBA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x28B0040", Offset = "0x28AF240", VA = "0x1828B0040")]
	public static void JGHBEDNJLDN(DIMBOFFMCBK IPOCHJJJBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x28AFCE0", Offset = "0x28AEEE0", VA = "0x1828AFCE0")]
	private static void FHDOENPPKKO([In] DIMBOFFMCBK IPOCHJJJBCM, KCKEEEOMPIF<IGOBBLMOCPA.DKAMAALLMFO> APBCLGNDGBE, LNOHLJBMIPK<byte> DLJBPEBOJEM, List<DOBBEGHJJIO> NDCPJIKEDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x28AFF00", Offset = "0x28AF100", VA = "0x1828AFF00")]
	private static void FHDOENPPKKO(LNOHLJBMIPK<byte> DLJBPEBOJEM, int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x28AFBB0", Offset = "0x28AEDB0", VA = "0x1828AFBB0")]
	private static void BFMBNNLHEGD(DIMBOFFMCBK IPOCHJJJBCM, List<DOBBEGHJJIO> NDCPJIKEDMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class HAFFIMCFKPI<TDeps, TIndex, TValues> where TDeps : struct, OFLPDOCBHPB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4C91B10", Offset = "0x4C90D10", VA = "0x184C91B10")]
	public static void JGHBEDNJLDN([In] LNOHLJBMIPK<ICLJDJKGEKJ> IGBENLEKLHC, int MHHOBBLHHGN, TValues LMKJLPPFOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface OFLPDOCBHPB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNOHLJBMIPK<TIndex> MAMGAMPHPBI(int MHHOBBLHHGN, [In] TValues LMKJLPPFOFC);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(TIndex CMDFFDAPDIB, [In] TValues LMKJLPPFOFC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LONADOJLOGO(TIndex CMDFFDAPDIB, TValues LMKJLPPFOFC, KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DDOMJGLHFBF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex GLMMGDOHEHO(int CMDFFDAPDIB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NOEIMAINNDD(TIndex CMDFFDAPDIB, [In] TValues LMKJLPPFOFC);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCKEEEOMPIF<OPBMEBGEBHE<GHACCAJHFPL>> CEKEGCFPOJO(TIndex CMDFFDAPDIB, [In] TValues LMKJLPPFOFC);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IIAKPHIAIEI<TDeps, TIndex, TValues> where TDeps : struct, DDOMJGLHFBF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4DED110", Offset = "0x4DEC310", VA = "0x184DED110")]
	public static LNOHLJBMIPK<TIndex> JGHBEDNJLDN(int MHHOBBLHHGN, [In] TValues LMKJLPPFOFC)
	{
		return default(LNOHLJBMIPK<TIndex>);
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

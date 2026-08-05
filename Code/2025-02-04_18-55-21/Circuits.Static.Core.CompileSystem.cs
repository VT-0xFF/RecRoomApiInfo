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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x254D130", Offset = "0x254BF30", VA = "0x18254D130")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FLLPKDOBFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> OCJDOIHMINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int NJLELLEMFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public FLLPKDOBFOE(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> PPGAJAMICJG, int DACBEFNKNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OMMAEFGDFIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class JDMFBHJHHHE : ACHMEFAJDPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OBFCICLLEDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly HGHMKAOFCFL<byte> JODGGDJNIIM;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24E0CC0", Offset = "0x24DFAC0", VA = "0x1824E0CC0")]
		public OBFCICLLEDK(HGHMKAOFCFL<byte> MDJJEFJEKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x254D2A0", Offset = "0x254C0A0", VA = "0x18254D2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ALPDMCEMHBB : ACHMEFAJDPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AHDPPIDDENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> FNFBICECPBL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public AHDPPIDDENB(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> MALOKIKFBAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum KJPGLOHNIMF
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
	public sealed class HLAPCBAAPJA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class ACHMEFAJDPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HCBGBLNJCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly KJPGLOHNIMF AJICJKAIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MMBOLDIBAHF<ACHMEFAJDPK> MJEABNONFOL;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public HCBGBLNJCEK(KJPGLOHNIMF IOJKOOGMCJD, MMBOLDIBAHF<ACHMEFAJDPK> ABFEHJOJNAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class JKFHHHPELML : ACHMEFAJDPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct HBMJKCAKKMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> BLHBKFEBIMO;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public HBMJKCAKKMC(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FJFMECKAOBA : ACHMEFAJDPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JKAPHGCICDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OJEEBABOFGM IACOFNJCGML;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public JKAPHGCICDN(OJEEBABOFGM GOIGIFLJCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x25464A0", Offset = "0x25452A0", VA = "0x1825464A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DBNLGBOIAHC<HLAPCBAAPJA, HCBGBLNJCEK> LKGMGHNEFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DBNLGBOIAHC<JDMFBHJHHHE, OBFCICLLEDK> FGIBCKHLPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DBNLGBOIAHC<ALPDMCEMHBB, AHDPPIDDENB> FELJJMPCAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DBNLGBOIAHC<JKFHHHPELML, HBMJKCAKKMC> KIKENAICBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DBNLGBOIAHC<FJFMECKAOBA, JKAPHGCICDN> JFPOKPHMOBJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x254D560", Offset = "0x254C360", VA = "0x18254D560")]
	private OMMAEFGDFIJ([In] DBNLGBOIAHC<HLAPCBAAPJA, HCBGBLNJCEK> IIFNGJHFFND, [In] DBNLGBOIAHC<JDMFBHJHHHE, OBFCICLLEDK> FKOMNHNEAKK, [In] DBNLGBOIAHC<ALPDMCEMHBB, AHDPPIDDENB> NOLDHEFMCGD, [In] DBNLGBOIAHC<JKFHHHPELML, HBMJKCAKKMC> DMLBLAHMDFD, [In] DBNLGBOIAHC<FJFMECKAOBA, JKAPHGCICDN> PMFMECNGPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x254D420", Offset = "0x254C220", VA = "0x18254D420")]
	public static OMMAEFGDFIJ MKHEJJEDOII()
	{
		return default(OMMAEFGDFIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MKNGJKDALAB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x254C0E0", Offset = "0x254AEE0", VA = "0x18254C0E0")]
	public static void MJMAPJMIAED(this OMMAEFGDFIJ DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IAPKGKDHLNO
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
public struct DGDGBDOJINE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DKLCBCHFKIG : OINHDKAOEND
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct JPJHLFEAIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> DIJGGLGBFHF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public JPJHLFEAIDL(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CMGFIJKPFID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NIKOFNGBLFB
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
	public sealed class GMHOJNHIGHD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class OINHDKAOEND
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct HBLMCPGMCMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly NIKOFNGBLFB AJICJKAIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly MMBOLDIBAHF<OINHDKAOEND> MJEABNONFOL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public HBLMCPGMCMM(NIKOFNGBLFB IOJKOOGMCJD, MMBOLDIBAHF<OINHDKAOEND> ABFEHJOJNAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal DBNLGBOIAHC<GMHOJNHIGHD, HBLMCPGMCMM> LKGMGHNEFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DBNLGBOIAHC<DKLCBCHFKIG, JPJHLFEAIDL> IAIOLNJKDIO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25426D0", Offset = "0x25414D0", VA = "0x1825426D0")]
	private DGDGBDOJINE([In] DBNLGBOIAHC<GMHOJNHIGHD, HBLMCPGMCMM> IIFNGJHFFND, [In] DBNLGBOIAHC<DKLCBCHFKIG, JPJHLFEAIDL> DLBLIGNGAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2542640", Offset = "0x2541440", VA = "0x182542640")]
	public static DGDGBDOJINE MKHEJJEDOII()
	{
		return default(DGDGBDOJINE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OCLDKAENDDK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x254D310", Offset = "0x254C110", VA = "0x18254D310")]
	public static void MJMAPJMIAED(this DGDGBDOJINE DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HBAGJLPBNPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public ICNNLNCPOAH<int> DMLMHFJDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public ICNNLNCPOAH<int> DBHMFLMJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int KKICFIIEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MHJBFKPILBO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2543B20", Offset = "0x2542920", VA = "0x182543B20")]
	private HBAGJLPBNPI([In] ICNNLNCPOAH<int> BNDCCNDCGJE, [In] ICNNLNCPOAH<int> MAFDEFOMLIK, int EIBPOLMJIDD, int FFCCHKPIPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2543A80", Offset = "0x2542880", VA = "0x182543A80")]
	public static HBAGJLPBNPI MKHEJJEDOII()
	{
		return default(HBAGJLPBNPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EAOOIEPMCBO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x25429A0", Offset = "0x25417A0", VA = "0x1825429A0")]
	public static void MJMAPJMIAED(this HBAGJLPBNPI DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct LNAOPIINMHO
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum KDIMGEIEAJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class FNLNDHFBCIE : BPKMAKJIFFL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct LNBKEABNGMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly MMBOLDIBAHF<CPLHAEDMBGJ> DBOKEGDLJHO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public LNBKEABNGMB(MMBOLDIBAHF<CPLHAEDMBGJ> BMPFAGMLFMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class DHBGCBFCGAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class BPKMAKJIFFL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct NCGOODNMDKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly KDIMGEIEAJK AJICJKAIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MMBOLDIBAHF<BPKMAKJIFFL> MJEABNONFOL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		private NCGOODNMDKI(KDIMGEIEAJK IOJKOOGMCJD, MMBOLDIBAHF<BPKMAKJIFFL> ABFEHJOJNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x254C320", Offset = "0x254B120", VA = "0x18254C320")]
		public static NCGOODNMDKI MKHEJJEDOII(KDIMGEIEAJK IOJKOOGMCJD, MMBOLDIBAHF<BPKMAKJIFFL> ABFEHJOJNAL)
		{
			return default(NCGOODNMDKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class HOKJNFHGDEE : BPKMAKJIFFL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PGBBMGEMCCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MMBOLDIBAHF<CPLHAEDMBGJ> DBOKEGDLJHO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public PGBBMGEMCCJ(MMBOLDIBAHF<CPLHAEDMBGJ> BMPFAGMLFMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CPLHAEDMBGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct HHKBJODJHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public ICNNLNCPOAH<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> IGAOKCKOGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ICNNLNCPOAH<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> HNEPHOINNJM;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25426D0", Offset = "0x25414D0", VA = "0x1825426D0")]
		private HHKBJODJHAF([In] ICNNLNCPOAH<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> CAGPAHEIFDH, [In] ICNNLNCPOAH<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> FIEKJGDFHCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2543B80", Offset = "0x2542980", VA = "0x182543B80")]
		public static HHKBJODJHAF MKHEJJEDOII()
		{
			return default(HHKBJODJHAF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal DBNLGBOIAHC<DHBGCBFCGAF, NCGOODNMDKI> LKGMGHNEFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal DBNLGBOIAHC<HOKJNFHGDEE, PGBBMGEMCCJ> BLLHGIABMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DBNLGBOIAHC<FNLNDHFBCIE, LNBKEABNGMB> OIAGDKBLPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal ICNNLNCPOAH<(MMBOLDIBAHF<DHBGCBFCGAF> CallId, MMBOLDIBAHF<CPLHAEDMBGJ> IOId)> HKHHPGHKEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DBNLGBOIAHC<CPLHAEDMBGJ, HHKBJODJHAF> MDAGDKMOJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal DPNOAAEGBEI<CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> MJNEHMFHABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal DPNOAAEGBEI<CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> NGBDAKHFKOJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x254BDF0", Offset = "0x254ABF0", VA = "0x18254BDF0")]
	private LNAOPIINMHO([In] DBNLGBOIAHC<DHBGCBFCGAF, NCGOODNMDKI> IIFNGJHFFND, [In] DBNLGBOIAHC<HOKJNFHGDEE, PGBBMGEMCCJ> HALOCDDOEFA, [In] DBNLGBOIAHC<FNLNDHFBCIE, LNBKEABNGMB> BLCHNGIAPDF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<DHBGCBFCGAF> CallId, MMBOLDIBAHF<CPLHAEDMBGJ> IOId)> CJGKIHCDAPD, [In] DBNLGBOIAHC<CPLHAEDMBGJ, HHKBJODJHAF> AHHAJIBGOCI, [In] DPNOAAEGBEI<CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> ODLHNPKJEMM, [In] DPNOAAEGBEI<CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> EHECHHDHBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x254BC50", Offset = "0x254AA50", VA = "0x18254BC50")]
	public static LNAOPIINMHO MKHEJJEDOII()
	{
		return default(LNAOPIINMHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FPNKNOOIMLH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2542C80", Offset = "0x2541A80", VA = "0x182542C80")]
	private static void MJMAPJMIAED(this LNAOPIINMHO.HHKBJODJHAF DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2542A70", Offset = "0x2541870", VA = "0x182542A70")]
	public static void MJMAPJMIAED(this LNAOPIINMHO DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NMJJLMHGEAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public ICNNLNCPOAH<byte> JIEFCICFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal LNAOPIINMHO CJFNEEAKPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PNKABBIJFGA KGFNMNNOBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> CPJONGOFEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OMMAEFGDFIJ PNNKCCOEFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal DGDGBDOJINE CLIFFGDIGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal DPNOAAEGBEI<BGEDOHJDFGJ, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>?> DGOEMKODJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal ICNNLNCPOAH<MMBOLDIBAHF<BGEDOHJDFGJ>> BNLLCFDPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> OIFNIOECAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> NMNNBEADEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> AFDCOBLKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal CHDLLDHODEM IENPOKHJIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal KBFHKIOFDHE PLAHAOFOJMN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x254CDD0", Offset = "0x254BBD0", VA = "0x18254CDD0")]
	private NMJJLMHGEAL([In] ICNNLNCPOAH<byte> HLJAPDBOKNM, [In] LNAOPIINMHO GJODGBMOBHM, [In] PNKABBIJFGA GDKPDOIALKC, [In] OMMAEFGDFIJ LKOJKHJDGBM, [In] DGDGBDOJINE CNEBEIDADMI, [In] DPNOAAEGBEI<BGEDOHJDFGJ, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>?> ACMHJMIPBAK, [In] ICNNLNCPOAH<MMBOLDIBAHF<BGEDOHJDFGJ>> BIAMMLFHNHF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> HLKKABIINCK, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> LJPCDMBKBAG, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> LGAMNGGBHJH, [In] CHDLLDHODEM EAOBJPLMJOP, [In] KBFHKIOFDHE NPAECKFKPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x254C420", Offset = "0x254B220", VA = "0x18254C420")]
	public static NMJJLMHGEAL MKHEJJEDOII()
	{
		return default(NMJJLMHGEAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JCHGMBALJOG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct NKGLDGPIBFD : FBENLHAINLO<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x254C370", Offset = "0x254B170", VA = "0x18254C370")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x254C330", Offset = "0x254B130", VA = "0x18254C330", Slot = "4")]
		public MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		public bool LGBOBGBKDMC(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		private bool BKGFPGPIBBP(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x254C360", Offset = "0x254B160", VA = "0x18254C360", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> FNOGNAKOGPK(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct BNFNCJBGKIK : JJDAMONMKHK<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2542190", Offset = "0x2540F90", VA = "0x182542190")]
		public ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> KFIBKDHEIDE(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2542200", Offset = "0x2541000", VA = "0x182542200")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x25422C0", Offset = "0x25410C0", VA = "0x1825422C0", Slot = "6")]
		public void KIIGNLKAGOI(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2542190", Offset = "0x2540F90", VA = "0x182542190", Slot = "4")]
		private ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> CJIJBKKNPPI(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x25422B0", Offset = "0x25410B0", VA = "0x1825422B0", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> JGGFKONJLLE(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OAJEEJPKNEA : FBENLHAINLO<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x254D1E0", Offset = "0x254BFE0", VA = "0x18254D1E0")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x254D1B0", Offset = "0x254BFB0", VA = "0x18254D1B0", Slot = "4")]
		public MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		public bool LGBOBGBKDMC(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		private bool LCKMBBOODFB(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x254D290", Offset = "0x254C090", VA = "0x18254D290", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> PCEFPLGAMEL(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct GFBGNIBGCON : JJDAMONMKHK<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2543890", Offset = "0x2542690", VA = "0x182543890")]
		public ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> KFIBKDHEIDE(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2543900", Offset = "0x2542700", VA = "0x182543900")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25439B0", Offset = "0x25427B0", VA = "0x1825439B0", Slot = "6")]
		public void KIIGNLKAGOI(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2543890", Offset = "0x2542690", VA = "0x182543890", Slot = "4")]
		private ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> ALPIDDIGDII(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2543A70", Offset = "0x2542870", VA = "0x182543A70", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> MIKEJPIGGNA(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> KNCPCNBMDNF, [In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NAHAKMJNDCJ : FBENLHAINLO<MMBOLDIBAHF<LILDJNMHNBP>, DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x254C240", Offset = "0x254B040", VA = "0x18254C240")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x254C210", Offset = "0x254B010", VA = "0x18254C210", Slot = "4")]
		public MMBOLDIBAHF<LILDJNMHNBP> EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(MMBOLDIBAHF<LILDJNMHNBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x254C190", Offset = "0x254AF90", VA = "0x18254C190")]
		public bool LGBOBGBKDMC(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x254C190", Offset = "0x254AF90", VA = "0x18254C190", Slot = "5")]
		private bool DHBNCCJJOIC(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x254C310", Offset = "0x254B110", VA = "0x18254C310", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> NNGAKLHPBMC(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct LFAALEFBAJM : JJDAMONMKHK<MMBOLDIBAHF<LILDJNMHNBP>, DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x254BAE0", Offset = "0x254A8E0", VA = "0x18254BAE0")]
		public ICNNLNCPOAH<MMBOLDIBAHF<LILDJNMHNBP>> KFIBKDHEIDE(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LILDJNMHNBP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x254BA10", Offset = "0x254A810", VA = "0x18254BA10")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x254BB50", Offset = "0x254A950", VA = "0x18254BB50", Slot = "6")]
		public void KIIGNLKAGOI(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x254BAE0", Offset = "0x254A8E0", VA = "0x18254BAE0", Slot = "4")]
		private ICNNLNCPOAH<MMBOLDIBAHF<LILDJNMHNBP>> JOCIBMEBDID(int CKNCKLJDHHE, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<MMBOLDIBAHF<LILDJNMHNBP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x254BC30", Offset = "0x254AA30", VA = "0x18254BC30", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> NFBAEFBPPKG(MMBOLDIBAHF<LILDJNMHNBP> KNCPCNBMDNF, [In] DPNOAAEGBEI<LILDJNMHNBP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>?> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct GANOIPHEIJM : FBENLHAINLO<int, ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2542CE0", Offset = "0x2541AE0", VA = "0x182542CE0")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC690A0", Offset = "0xC67EA0", VA = "0x180C690A0", Slot = "4")]
		public int EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		public bool LGBOBGBKDMC(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		private bool LILHJALBNDK(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2542CD0", Offset = "0x2541AD0", VA = "0x182542CD0", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> BNIDLLIBANO(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct IJNLHFKJMEO : JJDAMONMKHK<int, ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2543C00", Offset = "0x2542A00", VA = "0x182543C00")]
		public ICNNLNCPOAH<int> KFIBKDHEIDE(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2543C70", Offset = "0x2542A70", VA = "0x182543C70")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2543D20", Offset = "0x2542B20", VA = "0x182543D20", Slot = "6")]
		public void KIIGNLKAGOI(int KNCPCNBMDNF, ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2543C00", Offset = "0x2542A00", VA = "0x182543C00", Slot = "4")]
		private ICNNLNCPOAH<int> AFOGLGAANBL(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2543D10", Offset = "0x2542B10", VA = "0x182543D10", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> HONMMBIGNMP(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> VariableId, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<BJAKAGNMCDN>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct BKJHJBJDMKD : FBENLHAINLO<int, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x25420F0", Offset = "0x2540EF0", VA = "0x1825420F0")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC690A0", Offset = "0xC67EA0", VA = "0x180C690A0", Slot = "4")]
		public int EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		public bool LGBOBGBKDMC(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		private bool IFAEBLKHAAI(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x25420E0", Offset = "0x2540EE0", VA = "0x1825420E0", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GBLKGPOMPGE(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct OOIDEPFJFJP : JJDAMONMKHK<int, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x254D690", Offset = "0x254C490", VA = "0x18254D690")]
		public ICNNLNCPOAH<int> KFIBKDHEIDE(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x254D5F0", Offset = "0x254C3F0", VA = "0x18254D5F0")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x254D700", Offset = "0x254C500", VA = "0x18254D700", Slot = "6")]
		public void KIIGNLKAGOI(int KNCPCNBMDNF, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x254D690", Offset = "0x254C490", VA = "0x18254D690", Slot = "4")]
		private ICNNLNCPOAH<int> PEPENGKFPBC(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x254D7F0", Offset = "0x254C5F0", VA = "0x18254D7F0", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> MINEPPNPEHF(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct PKGAIKIAGJC : FBENLHAINLO<int, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x254D890", Offset = "0x254C690", VA = "0x18254D890")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC690A0", Offset = "0xC67EA0", VA = "0x180C690A0", Slot = "4")]
		public int EBJAAFCBFIG(int KNCPCNBMDNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		public bool LGBOBGBKDMC(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "5")]
		private bool IFAEBLKHAAI(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x254D880", Offset = "0x254C680", VA = "0x18254D880", Slot = "6")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GBLKGPOMPGE(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct LPCGKDEILHP : JJDAMONMKHK<int, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x254BF50", Offset = "0x254AD50", VA = "0x18254BF50")]
		public ICNNLNCPOAH<int> KFIBKDHEIDE(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x254BEB0", Offset = "0x254ACB0", VA = "0x18254BEB0")]
		public MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x254BFC0", Offset = "0x254ADC0", VA = "0x18254BFC0", Slot = "6")]
		public void KIIGNLKAGOI(int KNCPCNBMDNF, ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x254BF50", Offset = "0x254AD50", VA = "0x18254BF50", Slot = "4")]
		private ICNNLNCPOAH<int> PEPENGKFPBC(int CKNCKLJDHHE, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(ICNNLNCPOAH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x254C0C0", Offset = "0x254AEC0", VA = "0x18254C0C0", Slot = "5")]
		private MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> MINEPPNPEHF(int KNCPCNBMDNF, [In] ICNNLNCPOAH<(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> Target, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ByteCodeWriteLocation)> DCFFMJLJGJB)
		{
			return default(MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct MIBDOGGAMEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> BBLFBDOFGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool BHLOAIPEDBM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1BEE3A0", Offset = "0x1BED1A0", VA = "0x181BEE3A0")]
		public MIBDOGGAMEG(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, bool IJHMKCPKBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x254C0D0", Offset = "0x254AED0", VA = "0x18254C0D0")]
		public void AHAOIMLDBFI([Out] MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, [Out] bool IJHMKCPKBJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct AAHLLHBHLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MMBOLDIBAHF<LILDJNMHNBP> BLFFICFHPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> BBLFBDOFGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool BHLOAIPEDBM;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2542020", Offset = "0x2540E20", VA = "0x182542020")]
		public AAHLLHBHLFL(MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, bool IJHMKCPKBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2541FF0", Offset = "0x2540DF0", VA = "0x182541FF0")]
		public void AHAOIMLDBFI([Out] MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, [Out] bool IJHMKCPKBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2542000", Offset = "0x2540E00", VA = "0x182542000")]
		public void AHAOIMLDBFI([Out] MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, [Out] MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD, [Out] bool IJHMKCPKBJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LIPFGMPICDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MMBOLDIBAHF<LILDJNMHNBP> BLFFICFHPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> BBLFBDOFGIH;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public LIPFGMPICDJ(MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x254BC40", Offset = "0x254AA40", VA = "0x18254BC40")]
		public void AHAOIMLDBFI([Out] MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ, [Out] MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2545AD0", Offset = "0x25448D0", VA = "0x182545AD0")]
	public static void MJMAPJMIAED(this NMJJLMHGEAL DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2544D70", Offset = "0x2543B70", VA = "0x182544D70")]
	public static void HEJLJFLGJCJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> EDNFBFELALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25462E0", Offset = "0x25450E0", VA = "0x1825462E0")]
	public static void PJOCJELGCBO(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> EDNFBFELALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2545DA0", Offset = "0x2544BA0", VA = "0x182545DA0")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>? NHEENBFDBAP([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2544E80", Offset = "0x2543C80", VA = "0x182544E80")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> HHAIHADEHPH([In] this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2544EE0", Offset = "0x2543CE0", VA = "0x182544EE0")]
	private static void HMIHNHPMBEF(this NMJJLMHGEAL DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25442E0", Offset = "0x25430E0", VA = "0x1825442E0")]
	private static MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>? DAGKOGAJMBI([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25448C0", Offset = "0x25436C0", VA = "0x1825448C0")]
	public static void FFHEBMODPNM(this NMJJLMHGEAL DJAJDIFOIHP, [In] ICNNLNCPOAH<FLLPKDOBFOE> JCPBHFKFHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25456D0", Offset = "0x25444D0", VA = "0x1825456D0")]
	public static OMMAEFGDFIJ.KJPGLOHNIMF LEMAIBCAHLJ([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(OMMAEFGDFIJ.KJPGLOHNIMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2544C30", Offset = "0x2543A30", VA = "0x182544C30")]
	public static HGHMKAOFCFL<byte> GOFBMFDEBJF([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(HGHMKAOFCFL<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25452F0", Offset = "0x25440F0", VA = "0x1825452F0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JMKKIGGJHAP([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25459E0", Offset = "0x25447E0", VA = "0x1825459E0")]
	public static OJEEBABOFGM MCICIIBKNFL([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(OJEEBABOFGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3338F50", Offset = "0x3337D50", VA = "0x183338F50")]
	private static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> HIDPCCBIACN<TMJoin>(this NMJJLMHGEAL DJAJDIFOIHP, OMMAEFGDFIJ.KJPGLOHNIMF IOJKOOGMCJD, MMBOLDIBAHF<TMJoin> ABFEHJOJNAL) where TMJoin : OMMAEFGDFIJ.ACHMEFAJDPK
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2546080", Offset = "0x2544E80", VA = "0x182546080")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> OHMKFDBJIDO(this NMJJLMHGEAL DJAJDIFOIHP, bool EKIDKHHJPHL)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2546100", Offset = "0x2544F00", VA = "0x182546100")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PGAINACFMAG(this NMJJLMHGEAL DJAJDIFOIHP, HGHMKAOFCFL<byte> MDJJEFJEKNO)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2544740", Offset = "0x2543540", VA = "0x182544740")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> EKDBMHBFLPL(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> MALOKIKFBAH)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2543E70", Offset = "0x2542C70", VA = "0x182543E70")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> AHKJFHNNCEI(this NMJJLMHGEAL DJAJDIFOIHP, int CCJBCEDNBPH)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2545650", Offset = "0x2544450", VA = "0x182545650")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> LEAMBMMLCBJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3339E20", Offset = "0x3338C20", VA = "0x183339E20")]
	private static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> IPOJMMJAPML<TMJoin>(this NMJJLMHGEAL DJAJDIFOIHP, DGDGBDOJINE.NIKOFNGBLFB IOJKOOGMCJD, MMBOLDIBAHF<TMJoin> ABFEHJOJNAL) where TMJoin : DGDGBDOJINE.OINHDKAOEND
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2544200", Offset = "0x2543000", VA = "0x182544200")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> CEPCLAPONNC(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2544BE0", Offset = "0x25439E0", VA = "0x182544BE0")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> GFCKKDHGKND(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2544840", Offset = "0x2543640", VA = "0x182544840")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> FEEBEFAAIDA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CMGFIJKPFID)
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2544D20", Offset = "0x2543B20", VA = "0x182544D20")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> HCOJNOEMEMK(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2545050", Offset = "0x2543E50", VA = "0x182545050")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> IFLOHHBCGFN(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2544E00", Offset = "0x2543C00", VA = "0x182544E00")]
	public static LNAOPIINMHO.KDIMGEIEAJK HFGHBLCENGO([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH)
	{
		return default(LNAOPIINMHO.KDIMGEIEAJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25442A0", Offset = "0x25430A0", VA = "0x1825442A0")]
	public static CCJJBDDAFNK<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, JBCIHIIMBCE<LNAOPIINMHO.CPLHAEDMBGJ>> CNEBFFMPAIB([In] this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(CCJJBDDAFNK<MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>, JBCIHIIMBCE<LNAOPIINMHO.CPLHAEDMBGJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25443A0", Offset = "0x25431A0", VA = "0x1825443A0")]
	public static MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> DJHIMIOPDNE([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH)
	{
		return default(MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25447C0", Offset = "0x25435C0", VA = "0x1825447C0")]
	public static LNAOPIINMHO.HHKBJODJHAF FCPNGLBPAEI([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> BMPFAGMLFMP)
	{
		return default(LNAOPIINMHO.HHKBJODJHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25451E0", Offset = "0x2543FE0", VA = "0x1825451E0")]
	public static LNAOPIINMHO.HHKBJODJHAF JGANINAHMIC(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> BMPFAGMLFMP)
	{
		return default(LNAOPIINMHO.HHKBJODJHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3338C10", Offset = "0x3337A10", VA = "0x183338C10")]
	private static MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> FFCKCKKDGKD<TMJoin>(this NMJJLMHGEAL DJAJDIFOIHP, LNAOPIINMHO.KDIMGEIEAJK IOJKOOGMCJD, MMBOLDIBAHF<TMJoin> ABFEHJOJNAL) where TMJoin : LNAOPIINMHO.BPKMAKJIFFL
	{
		return default(MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2544050", Offset = "0x2542E50", VA = "0x182544050")]
	public static (MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>) BOJOICJEGCN(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default((MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2544A30", Offset = "0x2543830", VA = "0x182544A30")]
	public static (MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>) FOHOMPIPDPP(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default((MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2543E20", Offset = "0x2542C20", VA = "0x182543E20")]
	public static MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> AAHABLIGINJ(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2545E60", Offset = "0x2544C60", VA = "0x182545E60")]
	public static void NMHHLHFEPBM(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ> BMPFAGMLFMP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> FHONJDONLHN, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>> IPAOOMPBAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3339000", Offset = "0x3337E00", VA = "0x183339000")]
	public static MIBDOGGAMEG ILCCHFNENOB<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD) where TDeps : EBLJAHBMBBD<TStateSys>
	{
		return default(MIBDOGGAMEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3338CB0", Offset = "0x3337AB0", VA = "0x183338CB0")]
	public static AAHLLHBHLFL HDKGEAOECJB<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, int BCFPEDLJBCN) where TDeps : EBLJAHBMBBD<TStateSys>
	{
		return default(AAHLLHBHLFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3338140", Offset = "0x3336F40", VA = "0x183338140")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>? BMIELDKIJEN<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, [In] ReadOnlySpan<int> LHDGNLGMJDM, [In] Span<LIPFGMPICDJ> MNKIAGFNCBC) where TDeps : EBLJAHBMBBD<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3338650", Offset = "0x3337450", VA = "0x183338650")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> FDABDHIMJDI<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE) where TDeps : EBLJAHBMBBD<TStateSys>
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2544650", Offset = "0x2543450", VA = "0x182544650")]
	public static PNKABBIJFGA.EPMFKGENKJB ECEDFOOLLGD([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return default(PNKABBIJFGA.EPMFKGENKJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x25463B0", Offset = "0x25451B0", VA = "0x1825463B0")]
	public static PNKABBIJFGA.GICBKJINNEM PPKHNAKOMJN([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return default(PNKABBIJFGA.GICBKJINNEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2545840", Offset = "0x2544640", VA = "0x182545840")]
	public static PNKABBIJFGA.OAMGDMBLMLJ LMPGFEDHJFD([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return default(PNKABBIJFGA.OAMGDMBLMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25454C0", Offset = "0x25442C0", VA = "0x1825454C0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> LDHODOOGFKC(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK, string PPKJBGAOBJL)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2545750", Offset = "0x2544550", VA = "0x182545750")]
	public static PNKABBIJFGA.MCALBGIKLBI LHNPCDGAGCN([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return default(PNKABBIJFGA.MCALBGIKLBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2545450", Offset = "0x2544250", VA = "0x182545450")]
	public static PNKABBIJFGA.JNFOODFPGDC KIDCPMIEIJF([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return default(PNKABBIJFGA.JNFOODFPGDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25453E0", Offset = "0x25441E0", VA = "0x1825453E0")]
	public static int? KHPCOACHDOB([In] this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3339ED0", Offset = "0x3338CD0", VA = "0x183339ED0")]
	private static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PDFJMNEHGLE<TMJoin>(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK, PNKABBIJFGA.JNFOODFPGDC IOJKOOGMCJD, MMBOLDIBAHF<TMJoin> ABFEHJOJNAL) where TMJoin : PNKABBIJFGA.ECGGPDHDOHN
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2545930", Offset = "0x2544730", VA = "0x182545930")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MAGDMCLPKGE(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH, int KNCPCNBMDNF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2544240", Offset = "0x2543040", VA = "0x182544240")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CMHHLBGMKNI(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2546190", Offset = "0x2544F90", VA = "0x182546190")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PIPEBLBBNKO(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? BDDMCBPOPKN, int? ECAKBOPOGHK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2543FC0", Offset = "0x2542DC0", VA = "0x182543FC0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> BNOLAOMBDBG(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK, int KNCPCNBMDNF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2545EF0", Offset = "0x2544CF0", VA = "0x182545EF0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NOOMGBOMAPL(this NMJJLMHGEAL DJAJDIFOIHP, int? ECAKBOPOGHK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25450A0", Offset = "0x2543EA0", VA = "0x1825450A0")]
	public static void JFCHGKPDABC(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH, int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2545F50", Offset = "0x2544D50", VA = "0x182545F50")]
	public static void ODCPFHIEEOD(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA, int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2543EF0", Offset = "0x2542CF0", VA = "0x182543EF0")]
	public static void BFFKHGCILFN(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2545260", Offset = "0x2544060", VA = "0x182545260")]
	public static void JKODHGNCGKN(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> OBIPBFFAILK, MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> DJNJPLMKHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2544580", Offset = "0x2543380", VA = "0x182544580")]
	public static void DJILLCPHOOB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA, MMBOLDIBAHF<GDBEKIHBPGN<MKGBKNDKFGL>> ANHEFMAPNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3338580", Offset = "0x3337380", VA = "0x183338580")]
	public static void CAKJNMJEGHG<M>(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIMKBCLGNLA, MMBOLDIBAHF<GDBEKIHBPGN<OHHDAOJKLLK<M>>> ANHEFMAPNJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EBLJAHBMBBD<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMBOLDIBAHF<MOJBBOONJIG> AMEPIDDGCKP(TStateSys GEONDLGKAEP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMBOLDIBAHF<MOJBBOONJIG> GEGODJBJBDJ(TStateSys GEONDLGKAEP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBOLDIBAHF<MOJBBOONJIG> FOLKEFBEEKC(TStateSys GEONDLGKAEP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MMBOLDIBAHF<MOJBBOONJIG> NDFJKEHJMKM(TStateSys GEONDLGKAEP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> NNFGIOIBJAP(TStateSys GEONDLGKAEP, NMJJLMHGEAL EKFMOEJCKAL, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> IGBFJGMLOCA(TStateSys GEONDLGKAEP, NMJJLMHGEAL EKFMOEJCKAL, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CBCBKOBOPKD(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MMBOLDIBAHF<BGEDOHJDFGJ> PAMJMINEFBC(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD, int KADNPDEALKM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IAPKGKDHLNO OOJABIMFPCA(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ICCPJPAIMJD(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NJBJBNDEIAE(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HGHMKAOFCFL<byte> CNLGCCAHAGJ(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(HGHMKAOFCFL<byte>, MMBOLDIBAHF<MOJBBOONJIG>) AHBMBGLABJO(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int AMLGFONNLGP(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MMBOLDIBAHF<LILDJNMHNBP> MEEJGPOCILF(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE, int BCFPEDLJBCN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MMBOLDIBAHF<LILDJNMHNBP> ONOPGAOBJIB(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, int BCFPEDLJBCN);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NGGGKDELELH(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IJNMPPNFDJC(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int CLPPLAJIFLN(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? GJFJKCLNHPJ(TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, int KNCPCNBMDNF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LBBLFKLJEFP
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x339E650", Offset = "0x339D450", VA = "0x18339E650")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP?> LMPHMOLFPIN<T, TOpInput, TOpOutput>(this NMJJLMHGEAL DJAJDIFOIHP, T NMOPBJNEFKL, T KCJDGOIFCIF, int HBOKOGDICKC, IntPtr NGIDBJPEGDH)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x339E0D0", Offset = "0x339CED0", VA = "0x18339E0D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP?> KJMPPHJOEIH<T, TOpInput, TOpOutput>(this NMJJLMHGEAL DJAJDIFOIHP, T NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF, int HBOKOGDICKC, IntPtr NGIDBJPEGDH)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x339C9E0", Offset = "0x339B7E0", VA = "0x18339C9E0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP?> CKGNLJMHADF<TOpInput, TOpOutput>(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF, int HBOKOGDICKC, IntPtr NGIDBJPEGDH)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25496D0", Offset = "0x25484D0", VA = "0x1825496D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KGOHPFNMANC(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2547750", Offset = "0x2546550", VA = "0x182547750")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> EKCCLMOIILJ(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2546860", Offset = "0x2545660", VA = "0x182546860")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> ANMKMENIFGF(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25495D0", Offset = "0x25483D0", VA = "0x1825495D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KEPOFIDBIII(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2547B20", Offset = "0x2546920", VA = "0x182547B20")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> GEIPHHMIHMH(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x254B7E0", Offset = "0x254A5E0", VA = "0x18254B7E0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PPEJJBPNDAO(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x254B520", Offset = "0x254A320", VA = "0x18254B520")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PKCOPEJCGGD(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x254B260", Offset = "0x254A060", VA = "0x18254B260")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PGLPOOCFOLH(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2547FA0", Offset = "0x2546DA0", VA = "0x182547FA0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> HFNMFCDNGKB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2547D80", Offset = "0x2546B80", VA = "0x182547D80")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> GIAPLPDMOON(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, int KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x254A6A0", Offset = "0x25494A0", VA = "0x18254A6A0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NJGNDMIMEII(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2548A00", Offset = "0x2547800", VA = "0x182548A00")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IDJLHDPNMPD(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2548B40", Offset = "0x2547940", VA = "0x182548B40")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IIEPDEBJGMA(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, float KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2548FF0", Offset = "0x2547DF0", VA = "0x182548FF0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JJMIPHHOGOH(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x25469A0", Offset = "0x25457A0", VA = "0x1825469A0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> APLANCEFGMP(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x25497D0", Offset = "0x25485D0", VA = "0x1825497D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KIFKPBJOCNL(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, int KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x25476D0", Offset = "0x25464D0", VA = "0x1825476D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> EJFOHDEFOEA(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2548E70", Offset = "0x2547C70", VA = "0x182548E70")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JDDNCLCGCCA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2546C90", Offset = "0x2545A90", VA = "0x182546C90")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> BKBHJMLJNFK(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, float KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2547870", Offset = "0x2546670", VA = "0x182547870")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> ELOMNACHEJI(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2548160", Offset = "0x2546F60", VA = "0x182548160")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> HHEMFOCGNEB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x254ACE0", Offset = "0x2549AE0", VA = "0x18254ACE0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OIBIEPFOPGO(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, int KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2547050", Offset = "0x2545E50", VA = "0x182547050")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DBKCPPGDFPG(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x254AC60", Offset = "0x2549A60", VA = "0x18254AC60")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> ODNOLHHPJLA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x254AD60", Offset = "0x2549B60", VA = "0x18254AD60")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> OKFADFBMNAD(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, float KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x25480E0", Offset = "0x2546EE0", VA = "0x1825480E0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> HGKOIFJPEKC(this NMJJLMHGEAL DJAJDIFOIHP, float NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x254B4A0", Offset = "0x254A2A0", VA = "0x18254B4A0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PJIJFPKACFG(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x25481E0", Offset = "0x2546FE0", VA = "0x1825481E0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> HKDLOBDAINO(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2547650", Offset = "0x2546450", VA = "0x182547650")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> EIKMIKJHJLH(this NMJJLMHGEAL DJAJDIFOIHP, int IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x254A7C0", Offset = "0x25495C0", VA = "0x18254A7C0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> NKHEJMLNEKL(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2546AE0", Offset = "0x25458E0", VA = "0x182546AE0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> BEFFGIHGCGJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> PCIOBMADJDJ)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2549DD0", Offset = "0x2548BD0", VA = "0x182549DD0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> KOMJMKGNAMP(this NMJJLMHGEAL DJAJDIFOIHP, int IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x254A1A0", Offset = "0x2548FA0", VA = "0x18254A1A0")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> MBPGBBHIBJF(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2549850", Offset = "0x2548650", VA = "0x182549850")]
	public static (MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>) KLBJPPGNHMJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<CKICNIFKGGD> IKKMGFBMNGM, [In] ReadOnlySpan<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> CAGPAHEIFDH, [In] ReadOnlySpan<int?> MAJGIGBGMHL, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> GMFKMFBKEBP)
	{
		return default((MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x25470D0", Offset = "0x2545ED0", VA = "0x1825470D0")]
	public static (MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>) EBPDJKDKMIL(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<DEKEAGJKOGP> EKNGFMKPGLL, [In] ReadOnlySpan<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> CAGPAHEIFDH, [In] ReadOnlySpan<int?> MAJGIGBGMHL, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> GMFKMFBKEBP)
	{
		return default((MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x339CF90", Offset = "0x339BD90", VA = "0x18339CF90")]
	public static (MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>) FBKDIPMBJKL<TMarker>(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<MOJBBOONJIG> PIBLDGGEMPC, [In] ReadOnlySpan<byte> JOAPLPPIFPC)
	{
		return default((MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<GDBEKIHBPGN<MOJBBOONJIG>>, MMBOLDIBAHF<GDBEKIHBPGN<NMADBMEFDOA>>, MMBOLDIBAHF<GDBEKIHBPGN<TMarker>>, MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x254B620", Offset = "0x254A420", VA = "0x18254B620")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> POAECEGKPCF(this NMJJLMHGEAL DJAJDIFOIHP, int CEJLFCDIIBN, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x254B920", Offset = "0x254A720", VA = "0x18254B920")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PPJHAHMMGHJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CEJLFCDIIBN, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2549260", Offset = "0x2548060", VA = "0x182549260")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JMFNNDOKELH(this NMJJLMHGEAL DJAJDIFOIHP, [In] ReadOnlySpan<byte> CEJLFCDIIBN, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2547530", Offset = "0x2546330", VA = "0x182547530")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> EFKJLMHNFBJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CEJLFCDIIBN, int IECADCKMGOP, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x254B6E0", Offset = "0x254A4E0", VA = "0x18254B6E0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PPDLHJNFEAC(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x254A240", Offset = "0x2549040", VA = "0x18254A240")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MPHADJDNEJL(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2548390", Offset = "0x2547190", VA = "0x182548390")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> HKNPODONFEB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2546E30", Offset = "0x2545C30", VA = "0x182546E30")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CGPMNICOIGL(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x254B380", Offset = "0x254A180", VA = "0x18254B380")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PILIOBPJJAK(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2547C40", Offset = "0x2546A40", VA = "0x182547C40")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> GIAMPPONAEA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2548980", Offset = "0x2547780", VA = "0x182548980")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> ICONKOHMDED(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, int KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x25478F0", Offset = "0x25466F0", VA = "0x1825478F0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> EMFFBLCLCMN(this NMJJLMHGEAL DJAJDIFOIHP, int NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2547AA0", Offset = "0x25468A0", VA = "0x182547AA0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> GBEDEBFCIEB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NMOPBJNEFKL, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCJDGOIFCIF)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2548D70", Offset = "0x2547B70", VA = "0x182548D70")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IPFECLHNDHF(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2548C40", Offset = "0x2547A40", VA = "0x182548C40")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IILIMPMLPIK(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2549120", Offset = "0x2547F20", VA = "0x182549120")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JKCFCMGNOKM(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2546760", Offset = "0x2545560", VA = "0x182546760")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> AAFJNACPNME(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x25484D0", Offset = "0x25472D0", VA = "0x1825484D0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> HLONEECLAED(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2548840", Offset = "0x2547640", VA = "0x182548840")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> ICAOKOCECCE(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2547510", Offset = "0x2546310", VA = "0x182547510")]
	public static MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>> ECOJCJKPNLN(this NMJJLMHGEAL DJAJDIFOIHP)
	{
		return default(MMBOLDIBAHF<GDBEKIHBPGN<GDBEKIHBPGN<PNDHOCJOEON>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2548600", Offset = "0x2547400", VA = "0x182548600")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IAHIKBLLAHC(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2546D10", Offset = "0x2545B10", VA = "0x182546D10")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CEOOFBNLHMB(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2548700", Offset = "0x2547500", VA = "0x182548700")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IAIHOAIAAFB(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2548EF0", Offset = "0x2547CF0", VA = "0x182548EF0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JGMCACEMEDD(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2549E50", Offset = "0x2548C50", VA = "0x182549E50")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> LAJDHGKONBD(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2549350", Offset = "0x2548150", VA = "0x182549350")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> JNENPLJPOHA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x254A860", Offset = "0x2549660", VA = "0x18254A860")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NLAIDJNPNGP(this NMJJLMHGEAL DJAJDIFOIHP, int IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2549F70", Offset = "0x2548D70", VA = "0x182549F70")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> LGBMPMDECDK(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> IPHILEOFJLB)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x25485F0", Offset = "0x25473F0", VA = "0x1825485F0")]
	public static void HPIEMBEHGCM(this NMJJLMHGEAL DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x254ADE0", Offset = "0x2549BE0", VA = "0x18254ADE0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PBBNJPKGPPI(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, float DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x254A080", Offset = "0x2548E80", VA = "0x18254A080")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> LLPHGNCMMEF(this NMJJLMHGEAL DJAJDIFOIHP, float CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x254A460", Offset = "0x2549260", VA = "0x18254A460")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NDJPDAGCGDM(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x254A5A0", Offset = "0x25493A0", VA = "0x18254A5A0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NDKFECIFGFI(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2546F30", Offset = "0x2545D30", VA = "0x182546F30")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CNCJGPGBONE(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2549C90", Offset = "0x2548A90", VA = "0x182549C90")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KOJKLDOODCP(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x254AEE0", Offset = "0x2549CE0", VA = "0x18254AEE0")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> PFLOBBINHBN(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> NMKBMEMBJNL, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> DCLFKPALJJA)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x254A360", Offset = "0x2549160", VA = "0x18254A360")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> NCILHECCLDG(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, int DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2547E80", Offset = "0x2546C80", VA = "0x182547E80")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> GKIAKNCCLGA(this NMJJLMHGEAL DJAJDIFOIHP, int CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2549490", Offset = "0x2548290", VA = "0x182549490")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KCEDDIBLKEJ(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CHIIBHFIPJG, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> DHELNALCLMK)
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x339D440", Offset = "0x339C240", VA = "0x18339D440")]
	public static void IBHCOMNDOLM<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<CKICNIFKGGD> IKKMGFBMNGM, [In] ReadOnlySpan<MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>> ELJGBCODDPD, [In] ReadOnlySpan<int?> MAJGIGBGMHL, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> GMFKMFBKEBP, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> NCJGLPGHDDK, [In] ReadOnlySpan<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>?> BAKPNNLALBN) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x339E950", Offset = "0x339D750", VA = "0x18339E950")]
	public static void OLLLLEIHGMB<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<DEKEAGJKOGP> LLGCEMPPLIJ, [In] ReadOnlySpan<MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>> BDLMGMDCOHA, [In] ReadOnlySpan<int?> MAJGIGBGMHL, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> GMFKMFBKEBP, [In] Span<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>> NCJGLPGHDDK, [In] ReadOnlySpan<MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>?> BAKPNNLALBN) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x339E470", Offset = "0x339D270", VA = "0x18339E470")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> LMFACIBFMEH<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> BDDMCBPOPKN, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x339DC70", Offset = "0x339CA70", VA = "0x18339DC70")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KGNMHDAEBBO<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CMGFIJKPFID, [Optional] MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x339CB50", Offset = "0x339B950", VA = "0x18339CB50")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CLGBBOIMCNP<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP) where TDeps : notnull, EBLJAHBMBBD<TStateSys> where TStateSys : notnull
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x339CD80", Offset = "0x339BB80", VA = "0x18339CD80")]
	public static MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD> DPKCCMIGFDG<TDeps, TStateSys>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP) where TDeps : notnull, EBLJAHBMBBD<TStateSys> where TStateSys : notnull
	{
		return default(MMBOLDIBAHF<DGDGBDOJINE.GMHOJNHIGHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2547970", Offset = "0x2546770", VA = "0x182547970")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> FDKFEIMDPIA(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> NOEEEJEADPE, IntPtr KHPIJFLBMIB, IntPtr IAIFOJIGNJI)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x254A960", Offset = "0x2549760", VA = "0x18254A960")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> OCKDOKDILPN(this NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> JLJMCDFABGI, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> HNGBCGJBGEI, IntPtr MCIFPKDDPAG, IntPtr OGPOOEPPKJE, IntPtr DAGOLMIHNFC, bool NNOKGMPODAL)
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x339C2B0", Offset = "0x339B0B0", VA = "0x18339C2B0")]
	public static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CKGFCGMKEJI<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<CKICNIFKGGD> APHKJGOHAKA, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> JLJMCDFABGI, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> HNGBCGJBGEI, int? EEKMAFCCMNC, [Optional] IntPtr NJOPBGMNKIN) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x339BF90", Offset = "0x339AD90", VA = "0x18339BF90")]
	private static MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> CKGFCGMKEJI<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<CKICNIFKGGD> APHKJGOHAKA, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> JLJMCDFABGI, MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA> HNGBCGJBGEI, int? EEKMAFCCMNC) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
		return default(MMBOLDIBAHF<OMMAEFGDFIJ.HLAPCBAAPJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x339D090", Offset = "0x339BE90", VA = "0x18339D090")]
	public static MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> FCNJBAKPHAI<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> CEJLFCDIIBN, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>? CPMDMKKPICC) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
		return default(MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x339D9E0", Offset = "0x339C7E0", VA = "0x18339D9E0")]
	public static void JKIINPLGIMP<TDeps, TState>(this NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TState DKNLFDPIIII, int JMCCDKEKEIB) where TDeps : notnull, EBLJAHBMBBD<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DHFFBNPDNFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> DKFKPMGPLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> MENFFNCPCIB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public DHFFBNPDNFN(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> LICFPBMDNHC, MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> GGHHJDIJMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2542710", Offset = "0x2541510", VA = "0x182542710")]
	public static DHFFBNPDNFN MKHEJJEDOII(MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>> LICFPBMDNHC)
	{
		return default(DHFFBNPDNFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PNKABBIJFGA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DEKAFIFHPJE : ECGGPDHDOHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct EPMFKGENKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> KJJPHKHOGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int OFCLDJHOLLK;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public EPMFKGENKJB(MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH, int KNCPCNBMDNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class LDMDCOJAKKB : ECGGPDHDOHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GICBKJINNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int OFCLDJHOLLK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public GICBKJINNEM(int KNCPCNBMDNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PDBNIDGHPFN : ECGGPDHDOHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OAMGDMBLMLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> KJJPHKHOGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int OFCLDJHOLLK;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
		public OAMGDMBLMLJ(MMBOLDIBAHF<LNAOPIINMHO.DHBGCBFCGAF> ECLJFCBEEGH, int KNCPCNBMDNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum JNFOODFPGDC
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
	public sealed class AICDFECDCPP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class ECGGPDHDOHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CGOAPMBHOPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? IEJMPJKEPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DHFFBNPDNFN AAKOOJJBHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public JNFOODFPGDC AJICJKAIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MMBOLDIBAHF<ECGGPDHDOHN> MJEABNONFOL;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2542380", Offset = "0x2541180", VA = "0x182542380")]
		public CGOAPMBHOPJ(int? ECAKBOPOGHK, [In] DHFFBNPDNFN KJKDLPDEJLD, JNFOODFPGDC IOJKOOGMCJD, MMBOLDIBAHF<ECGGPDHDOHN> ABFEHJOJNAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class EAKLLLCOLKD : ECGGPDHDOHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct MCALBGIKLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int OFCLDJHOLLK;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		public MCALBGIKLBI(int KNCPCNBMDNF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal DCOOOPCEMHM<AICDFECDCPP, CGOAPMBHOPJ> LKGMGHNEFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal DCOOOPCEMHM<DEKAFIFHPJE, EPMFKGENKJB> LALJDNPGKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal DCOOOPCEMHM<PDBNIDGHPFN, OAMGDMBLMLJ> INLMCBCPHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal DCOOOPCEMHM<EAKLLLCOLKD, MCALBGIKLBI> AOGIKALCBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal DCOOOPCEMHM<LDMDCOJAKKB, GICBKJINNEM> FJMLMGKLIHC;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x254DB20", Offset = "0x254C920", VA = "0x18254DB20")]
	private PNKABBIJFGA([In] DCOOOPCEMHM<AICDFECDCPP, CGOAPMBHOPJ> IIFNGJHFFND, [In] DCOOOPCEMHM<DEKAFIFHPJE, EPMFKGENKJB> PJKOPFGANPH, [In] DCOOOPCEMHM<PDBNIDGHPFN, OAMGDMBLMLJ> ABNINDLDBGK, [In] DCOOOPCEMHM<EAKLLLCOLKD, MCALBGIKLBI> HNLNNFOIFMA, [In] DCOOOPCEMHM<LDMDCOJAKKB, GICBKJINNEM> PMJAEAOFOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x254D930", Offset = "0x254C730", VA = "0x18254D930")]
	public static PNKABBIJFGA MKHEJJEDOII()
	{
		return default(PNKABBIJFGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AMJODKFHPNB
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2542030", Offset = "0x2540E30", VA = "0x182542030")]
	public static void MJMAPJMIAED(this PNKABBIJFGA DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KFIDHJLHKHB
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2546600", Offset = "0x2545400", VA = "0x182546600")]
	public static void NJAAPHNJHEI(NMJJLMHGEAL DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CHDLLDHODEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, HBAGJLPBNPI> ECAFEEOCJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int IEMKNKDNHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int CPFBFIICIPA;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2542600", Offset = "0x2541400", VA = "0x182542600")]
	private CHDLLDHODEM([In] DPNOAAEGBEI<LNAOPIINMHO.CPLHAEDMBGJ, HBAGJLPBNPI> FLDILFOEGHL, int GLNGAAGHFOB, int MBIFPBKCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2542590", Offset = "0x2541390", VA = "0x182542590")]
	public static CHDLLDHODEM MKHEJJEDOII()
	{
		return default(CHDLLDHODEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25423A0", Offset = "0x25411A0", VA = "0x1825423A0")]
	public void MJMAPJMIAED([In] NMJJLMHGEAL OHLKKDIOCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x31008F0", Offset = "0x30FF6F0", VA = "0x1831008F0")]
	public static void NJAAPHNJHEI<TDeps, TStateSys>(NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO) where TDeps : notnull, EBLJAHBMBBD<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EALHFGJOFDD
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25427D0", Offset = "0x25415D0", VA = "0x1825427D0")]
	public static void NJAAPHNJHEI(NMJJLMHGEAL DJAJDIFOIHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KBFHKIOFDHE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EEINCAEOFOC(ICNNLNCPOAH<byte> HLJAPDBOKNM, int NIDANJIDHCE);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct FKGODIBENBK : HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x25429F0", Offset = "0x25417F0", VA = "0x1825429F0", Slot = "4")]
		public void EEINCAEOFOC(ICNNLNCPOAH<byte> HLJAPDBOKNM, int NIDANJIDHCE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct DIEMFCDHBGF : HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2542720", Offset = "0x2541520", VA = "0x182542720", Slot = "4")]
		public void EEINCAEOFOC(ICNNLNCPOAH<byte> HLJAPDBOKNM, int NIDANJIDHCE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct OOMEFINEDNE : HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x254D800", Offset = "0x254C600", VA = "0x18254D800", Slot = "4")]
		public void EEINCAEOFOC(ICNNLNCPOAH<byte> HLJAPDBOKNM, int NIDANJIDHCE)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct OECMABGLELA : HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x254D370", Offset = "0x254C170", VA = "0x18254D370", Slot = "4")]
		public void EEINCAEOFOC(ICNNLNCPOAH<byte> HLJAPDBOKNM, int NIDANJIDHCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class LKLAPIBKDJC<TCallProcessorDeps> where TCallProcessorDeps : struct, HKKAEGEANAM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IKKBNFCGFBJ;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x37050E0", Offset = "0x3703EE0", VA = "0x1837050E0")]
		public static int NJAAPHNJHEI<TDeps, TStateSys>(TDeps FLOGLGIGMAI, TStateSys DKNLFDPIIII, NMJJLMHGEAL OHLKKDIOCBG, [In] ICNNLNCPOAH<byte> FOABEJKJDEG, int GCNEJGKFJLN) where TDeps : EBLJAHBMBBD<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private ICNNLNCPOAH<FLLPKDOBFOE> PGLELBOEOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> MNLFANOAPLC;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25465C0", Offset = "0x25453C0", VA = "0x1825465C0")]
	private KBFHKIOFDHE([In] ICNNLNCPOAH<FLLPKDOBFOE> JCPBHFKFHEM, Dictionary<MMBOLDIBAHF<GDBEKIHBPGN<PNDHOCJOEON>>, MMBOLDIBAHF<LNAOPIINMHO.CPLHAEDMBGJ>> PCMILBHCJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2546500", Offset = "0x2545300", VA = "0x182546500")]
	public static KBFHKIOFDHE MKHEJJEDOII()
	{
		return default(KBFHKIOFDHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x25464C0", Offset = "0x25452C0", VA = "0x1825464C0")]
	public void MJMAPJMIAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x336DE50", Offset = "0x336CC50", VA = "0x18336DE50")]
	public static void NJAAPHNJHEI<TDeps, TStateSys>(NMJJLMHGEAL DJAJDIFOIHP, TDeps FLOGLGIGMAI, TStateSys GEONDLGKAEP) where TDeps : EBLJAHBMBBD<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GEBKOKONABO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct FNBHLAHOMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> KOKFBPGKHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int KJOBGIPNMHI;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int PDMHPIMJJND;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int ADPJHHIMJMJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2543180", Offset = "0x2541F80", VA = "0x182543180")]
	public static void NJAAPHNJHEI(NMJJLMHGEAL DJAJDIFOIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2542EC0", Offset = "0x2541CC0", VA = "0x182542EC0")]
	private static void EJBLNKIFOKJ([In] NMJJLMHGEAL DJAJDIFOIHP, MMBOLDIBAHF<PNKABBIJFGA.AICDFECDCPP> MIFPCBFGGLI, ICNNLNCPOAH<byte> DNIPKLLHFNC, List<FNBHLAHOMKP> GHMALICKIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2542D80", Offset = "0x2541B80", VA = "0x182542D80")]
	private static void EJBLNKIFOKJ(ICNNLNCPOAH<byte> DNIPKLLHFNC, int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2543050", Offset = "0x2541E50", VA = "0x182543050")]
	private static void FEIBLPMCMNE(NMJJLMHGEAL DJAJDIFOIHP, List<FNBHLAHOMKP> GHMALICKIKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CGJDJJFMPJJ<TDeps, TIndex, TValues> where TDeps : struct, JJDAMONMKHK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5950CC0", Offset = "0x594FAC0", VA = "0x185950CC0")]
	public static void NJAAPHNJHEI([In] ICNNLNCPOAH<FLLPKDOBFOE> JCPBHFKFHEM, int CKNCKLJDHHE, TValues DCFFMJLJGJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JJDAMONMKHK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICNNLNCPOAH<TIndex> KFIBKDHEIDE(int CKNCKLJDHHE, [In] TValues DCFFMJLJGJB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(TIndex KNCPCNBMDNF, [In] TValues DCFFMJLJGJB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIIGNLKAGOI(TIndex KNCPCNBMDNF, TValues DCFFMJLJGJB, MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface FBENLHAINLO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex EBJAAFCBFIG(int KNCPCNBMDNF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LGBOBGBKDMC(TIndex KNCPCNBMDNF, [In] TValues DCFFMJLJGJB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMBOLDIBAHF<GDBEKIHBPGN<BJAKAGNMCDN>> GEAMDDJOHPJ(TIndex KNCPCNBMDNF, [In] TValues DCFFMJLJGJB);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GBIPCCNLBHG<TDeps, TIndex, TValues> where TDeps : struct, FBENLHAINLO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps IKKBNFCGFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x44A2FC0", Offset = "0x44A1DC0", VA = "0x1844A2FC0")]
	public static ICNNLNCPOAH<TIndex> NJAAPHNJHEI(int CKNCKLJDHHE, [In] TValues DCFFMJLJGJB)
	{
		return default(ICNNLNCPOAH<TIndex>);
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

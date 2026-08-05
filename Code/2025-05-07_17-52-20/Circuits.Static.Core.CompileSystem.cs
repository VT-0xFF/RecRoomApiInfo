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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A7AE0", Offset = "0x27A6AE0", VA = "0x1827A7AE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct EAICEOLEMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> BJOPOAHKMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int PFBGAKLJGMG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
	public EAICEOLEMOA(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> GIJNGCIEONA, int LLPAIMMACAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KAMGCLNCOBN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GAGKPBPKLGL : IBDIILPBING
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct PMKCPELFGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly OFKCHFBKBDL<byte> LBLPOKKCLFA;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x273D650", Offset = "0x273C650", VA = "0x18273D650")]
		public PMKCPELFGGB(OFKCHFBKBDL<byte> ACDPPDBEDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27A8800", Offset = "0x27A7800", VA = "0x1827A8800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class FGNMAKKAANF : IBDIILPBING
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct LKOCMDDHJEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> OIMCICIKLEM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public LKOCMDDHJEH(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> BMKAPPLJFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CJBKJIDIEAF
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
	public sealed class HGPGKPGOEKE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class IBDIILPBING
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct DGACOKADHPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly CJBKJIDIEAF JDKFIPEGOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EDBALDILLBK<IBDIILPBING> IAMFLKGOHCD;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		public DGACOKADHPB(CJBKJIDIEAF PKOAACGODAM, EDBALDILLBK<IBDIILPBING> CAFBDLMGINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IABJIPHMJBJ : IBDIILPBING
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct LDFLGOPHKID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> PKBMNNAOMLH;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public LDFLGOPHKID(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class ECBHHNOGNFJ : IBDIILPBING
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct NKGNGFHHPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CDFNCNEGFME LMLDDBELDLC;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public NKGNGFHHPFL(CDFNCNEGFME MFFMAFJOIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x27A5400", Offset = "0x27A4400", VA = "0x1827A5400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal LLANCABNMML<HGPGKPGOEKE, DGACOKADHPB> OMMHMIEIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal LLANCABNMML<GAGKPBPKLGL, PMKCPELFGGB> DHGCGPOGJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LLANCABNMML<FGNMAKKAANF, LKOCMDDHJEH> BCILCGOPFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LLANCABNMML<IABJIPHMJBJ, LDFLGOPHKID> MNJIPIAAEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LLANCABNMML<ECBHHNOGNFJ, NKGNGFHHPFL> NMLLLGHBKOF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x279E7A0", Offset = "0x279D7A0", VA = "0x18279E7A0")]
	private KAMGCLNCOBN([In] LLANCABNMML<HGPGKPGOEKE, DGACOKADHPB> IKCGIPBAPFL, [In] LLANCABNMML<GAGKPBPKLGL, PMKCPELFGGB> OPKLCALLIJI, [In] LLANCABNMML<FGNMAKKAANF, LKOCMDDHJEH> EDILAAPLHPA, [In] LLANCABNMML<IABJIPHMJBJ, LDFLGOPHKID> LIGDGLFBCIO, [In] LLANCABNMML<ECBHHNOGNFJ, NKGNGFHHPFL> ILIKBFINJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x279E660", Offset = "0x279D660", VA = "0x18279E660")]
	public static KAMGCLNCOBN ACADPGMDEBE()
	{
		return default(KAMGCLNCOBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LOAKCPDHOCF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27A4EE0", Offset = "0x27A3EE0", VA = "0x1827A4EE0")]
	public static void HMHHJKJOIHP(this KAMGCLNCOBN OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CCAHAINELMH
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
public struct EPFJDBPLDCM
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class HDEGJICBFFN : CJLHGMFLAKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct MNLPJPONBCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> LBAGJNKFFHF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public MNLPJPONBCF(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PLJNGLEMEBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum BNJJKPPBJGI
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
	public sealed class IDICMAPHLGN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class CJLHGMFLAKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct OPFIKJPDOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly BNJJKPPBJGI JDKFIPEGOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EDBALDILLBK<CJLHGMFLAKG> IAMFLKGOHCD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		public OPFIKJPDOOI(BNJJKPPBJGI PKOAACGODAM, EDBALDILLBK<CJLHGMFLAKG> CAFBDLMGINN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LLANCABNMML<IDICMAPHLGN, OPFIKJPDOOI> OMMHMIEIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LLANCABNMML<HDEGJICBFFN, MNLPJPONBCF> JBOGLDIGBIL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x279DC40", Offset = "0x279CC40", VA = "0x18279DC40")]
	private EPFJDBPLDCM([In] LLANCABNMML<IDICMAPHLGN, OPFIKJPDOOI> IKCGIPBAPFL, [In] LLANCABNMML<HDEGJICBFFN, MNLPJPONBCF> KAGIHNGFJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x279DBB0", Offset = "0x279CBB0", VA = "0x18279DBB0")]
	public static EPFJDBPLDCM ACADPGMDEBE()
	{
		return default(EPFJDBPLDCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OCCDCNMADDE
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27A8670", Offset = "0x27A7670", VA = "0x1827A8670")]
	public static void HMHHJKJOIHP(this EPFJDBPLDCM OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FJAOABOEHGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public AKAJMPNFKFH<int> EKGDPCEEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public AKAJMPNFKFH<int> CJAKNLNFMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int ANJKPBPHCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LCBNDHIILII;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x279E030", Offset = "0x279D030", VA = "0x18279E030")]
	private FJAOABOEHGI([In] AKAJMPNFKFH<int> PLEEPDCKNNK, [In] AKAJMPNFKFH<int> DODJBNOFEPN, int MNOEODHODIF, int IKJKMJGCGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x279DF90", Offset = "0x279CF90", VA = "0x18279DF90")]
	public static FJAOABOEHGI ACADPGMDEBE()
	{
		return default(FJAOABOEHGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HHHAIHKCJEM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x279E460", Offset = "0x279D460", VA = "0x18279E460")]
	public static void HMHHJKJOIHP(this FJAOABOEHGI OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EGKCPMOAPKM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DBKOFGKBMFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JFLBJCECBOB : OPMINENDEFJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct HMIHDKDGOLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EDBALDILLBK<IGGNHMBKPEK> KLCJHCJDAMK;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public HMIHDKDGOLK(EDBALDILLBK<IGGNHMBKPEK> OAOLOIECNCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EPKKDPEHPPI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class OPMINENDEFJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct NPKFGPDNALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly DBKOFGKBMFF JDKFIPEGOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly EDBALDILLBK<OPMINENDEFJ> IAMFLKGOHCD;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		private NPKFGPDNALH(DBKOFGKBMFF PKOAACGODAM, EDBALDILLBK<OPMINENDEFJ> CAFBDLMGINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27A5450", Offset = "0x27A4450", VA = "0x1827A5450")]
		public static NPKFGPDNALH ACADPGMDEBE(DBKOFGKBMFF PKOAACGODAM, EDBALDILLBK<OPMINENDEFJ> CAFBDLMGINN)
		{
			return default(NPKFGPDNALH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class LGPECJHGOFE : OPMINENDEFJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KMLFBJKIJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly EDBALDILLBK<IGGNHMBKPEK> KLCJHCJDAMK;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public KMLFBJKIJKE(EDBALDILLBK<IGGNHMBKPEK> OAOLOIECNCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class IGGNHMBKPEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct HNMPLLOBKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AKAJMPNFKFH<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> LAAEFGEACPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AKAJMPNFKFH<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> JKAJGOJGDBG;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x279DC40", Offset = "0x279CC40", VA = "0x18279DC40")]
		private HNMPLLOBKCE([In] AKAJMPNFKFH<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> DLHJDCJDKHC, [In] AKAJMPNFKFH<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> NCLPAGMOJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x279E4B0", Offset = "0x279D4B0", VA = "0x18279E4B0")]
		public static HNMPLLOBKCE ACADPGMDEBE()
		{
			return default(HNMPLLOBKCE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal LLANCABNMML<EPKKDPEHPPI, NPKFGPDNALH> OMMHMIEIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal LLANCABNMML<LGPECJHGOFE, KMLFBJKIJKE> GOMEEFDCCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal LLANCABNMML<JFLBJCECBOB, HMIHDKDGOLK> FGDGKAKCBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal AKAJMPNFKFH<(EDBALDILLBK<EPKKDPEHPPI> CallId, EDBALDILLBK<IGGNHMBKPEK> IOId)> MMKNFMGOJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LLANCABNMML<IGGNHMBKPEK, HNMPLLOBKCE> FPMOIKGBBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal MDCFHPFNPDO<IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> BEKCDOIECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal MDCFHPFNPDO<IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> PBPHCLKIIEA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x279DAF0", Offset = "0x279CAF0", VA = "0x18279DAF0")]
	private EGKCPMOAPKM([In] LLANCABNMML<EPKKDPEHPPI, NPKFGPDNALH> IKCGIPBAPFL, [In] LLANCABNMML<LGPECJHGOFE, KMLFBJKIJKE> CLMPBGAHJKB, [In] LLANCABNMML<JFLBJCECBOB, HMIHDKDGOLK> OPPODANNNOH, [In] AKAJMPNFKFH<(EDBALDILLBK<EPKKDPEHPPI> CallId, EDBALDILLBK<IGGNHMBKPEK> IOId)> NHFMKGPOOBE, [In] LLANCABNMML<IGGNHMBKPEK, HNMPLLOBKCE> PDDHBBONENC, [In] MDCFHPFNPDO<IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> CFDIKDIDCLH, [In] MDCFHPFNPDO<IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> GGGHGCEFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x279D950", Offset = "0x279C950", VA = "0x18279D950")]
	public static EGKCPMOAPKM ACADPGMDEBE()
	{
		return default(EGKCPMOAPKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BKFJNNODCCH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x279D3F0", Offset = "0x279C3F0", VA = "0x18279D3F0")]
	private static void HMHHJKJOIHP(this EGKCPMOAPKM.HNMPLLOBKCE OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x279D440", Offset = "0x279C440", VA = "0x18279D440")]
	public static void HMHHJKJOIHP(this EGKCPMOAPKM OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KAONBHJKGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public AKAJMPNFKFH<byte> KEGHKJIJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EGKCPMOAPKM PODFCBKEDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GDONHAJKGGO HECGNGKIPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> EKLAAEGLDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal KAMGCLNCOBN BBIGIECAMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal EPFJDBPLDCM OAAICJNHOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal MDCFHPFNPDO<MBCPFFKFBDC, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>?> ICPJONDMOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AKAJMPNFKFH<EDBALDILLBK<MBCPFFKFBDC>> PEAOKMMFEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DMJJMBDPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> GKJAPFKGIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> KMHFKLELKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal ANMHMIGFGOP DINEFEJEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ADPBKEGPCNO NAIKCENAHLI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x279F1E0", Offset = "0x279E1E0", VA = "0x18279F1E0")]
	private KAONBHJKGKH([In] AKAJMPNFKFH<byte> PHNDCNEHGDD, [In] EGKCPMOAPKM MJNLBAPCIOK, [In] GDONHAJKGGO HPIKGAAHKNJ, [In] KAMGCLNCOBN KBNDAPDJGEG, [In] EPFJDBPLDCM CLOILOCECIP, [In] MDCFHPFNPDO<MBCPFFKFBDC, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>?> AOPPHDLAIBJ, [In] AKAJMPNFKFH<EDBALDILLBK<MBCPFFKFBDC>> ECEKKBEPMPF, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> GMLCHDLNBNC, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> JCEJMAHJHAN, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> KCOEIJMEKFO, [In] ANMHMIGFGOP GIDANDDGCCF, [In] ADPBKEGPCNO HBMOFNHCPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x279E830", Offset = "0x279D830", VA = "0x18279E830")]
	public static KAONBHJKGKH ACADPGMDEBE()
	{
		return default(KAONBHJKGKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NPMHFNDHBAF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct KKCDKODCMNO : KIAAHEKIFLO<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x27A4830", Offset = "0x27A3830", VA = "0x1827A4830")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x27A47F0", Offset = "0x27A37F0", VA = "0x1827A47F0", Slot = "4")]
		public EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		public bool BBFACCFMDMJ(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "5")]
		private bool IMMJIADBKJJ(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27A4820", Offset = "0x27A3820", VA = "0x1827A4820", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> KPNCANAPOBD(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct LBHHDANGIDE : ICCNGAHNDHH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27A4B10", Offset = "0x27A3B10", VA = "0x1827A4B10")]
		public AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> KANKCFHJEDG(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27A4B80", Offset = "0x27A3B80", VA = "0x1827A4B80")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x27A4C30", Offset = "0x27A3C30", VA = "0x1827A4C30", Slot = "6")]
		public void MMIKKBDHEAD(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x27A4B10", Offset = "0x27A3B10", VA = "0x1827A4B10", Slot = "4")]
		private AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> IOIGAMNOIAC(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x27A4B00", Offset = "0x27A3B00", VA = "0x1827A4B00", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DIFCHKDIEOE(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct FHPHFHEOMOE : KIAAHEKIFLO<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x279DEE0", Offset = "0x279CEE0", VA = "0x18279DEE0")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x279DEA0", Offset = "0x279CEA0", VA = "0x18279DEA0", Slot = "4")]
		public EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		public bool BBFACCFMDMJ(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "5")]
		private bool HIFIOGNOHFC(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x279DED0", Offset = "0x279CED0", VA = "0x18279DED0", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LAKLOHGMIMB(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LIAGELHHAJP : ICCNGAHNDHH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27A4D00", Offset = "0x27A3D00", VA = "0x1827A4D00")]
		public AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> KANKCFHJEDG(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x27A4D70", Offset = "0x27A3D70", VA = "0x1827A4D70")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27A4E20", Offset = "0x27A3E20", VA = "0x1827A4E20", Slot = "6")]
		public void MMIKKBDHEAD(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27A4D00", Offset = "0x27A3D00", VA = "0x1827A4D00", Slot = "4")]
		private AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> LEAFCHBEKBD(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x27A4CF0", Offset = "0x27A3CF0", VA = "0x1827A4CF0", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> ALENHONGFII(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OHHMJGCBCKD, [In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct BNKAIIBJLAP : KIAAHEKIFLO<EDBALDILLBK<AIHJLHNMKCJ>, MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x279D710", Offset = "0x279C710", VA = "0x18279D710")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x279D650", Offset = "0x279C650", VA = "0x18279D650", Slot = "4")]
		public EDBALDILLBK<AIHJLHNMKCJ> ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(EDBALDILLBK<AIHJLHNMKCJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x279D680", Offset = "0x279C680", VA = "0x18279D680")]
		public bool BBFACCFMDMJ(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x279D680", Offset = "0x279C680", VA = "0x18279D680", Slot = "5")]
		private bool LONHLHLKOGD(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x279D700", Offset = "0x279C700", VA = "0x18279D700", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> HOBJBKNEPHH(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BEOHFHJBCIC : ICCNGAHNDHH<EDBALDILLBK<AIHJLHNMKCJ>, MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x279D1C0", Offset = "0x279C1C0", VA = "0x18279D1C0")]
		public AKAJMPNFKFH<EDBALDILLBK<AIHJLHNMKCJ>> KANKCFHJEDG(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<AIHJLHNMKCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x279D230", Offset = "0x279C230", VA = "0x18279D230")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x279D300", Offset = "0x279C300", VA = "0x18279D300", Slot = "6")]
		public void MMIKKBDHEAD(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x279D1C0", Offset = "0x279C1C0", VA = "0x18279D1C0", Slot = "4")]
		private AKAJMPNFKFH<EDBALDILLBK<AIHJLHNMKCJ>> ODMPDNPFOIE(int LJFFHGCHHLJ, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<EDBALDILLBK<AIHJLHNMKCJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x279D3E0", Offset = "0x279C3E0", VA = "0x18279D3E0", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OBBIIMHDJFK(EDBALDILLBK<AIHJLHNMKCJ> OHHMJGCBCKD, [In] MDCFHPFNPDO<AIHJLHNMKCJ, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>?> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IEOAHFAAACD : KIAAHEKIFLO<int, AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x279E540", Offset = "0x279D540", VA = "0x18279E540")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD93580", Offset = "0xD92580", VA = "0x180D93580", Slot = "4")]
		public int ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		public bool BBFACCFMDMJ(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "5")]
		private bool LPBBKJIGOOK(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x279E530", Offset = "0x279D530", VA = "0x18279E530", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> ABLKLGOIGOA(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct FFDGIJIFMFM : ICCNGAHNDHH<int, AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x279DC80", Offset = "0x279CC80", VA = "0x18279DC80")]
		public AKAJMPNFKFH<int> KANKCFHJEDG(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x279DCF0", Offset = "0x279CCF0", VA = "0x18279DCF0")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x279DDA0", Offset = "0x279CDA0", VA = "0x18279DDA0", Slot = "6")]
		public void MMIKKBDHEAD(int OHHMJGCBCKD, AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x279DC80", Offset = "0x279CC80", VA = "0x18279DC80", Slot = "4")]
		private AKAJMPNFKFH<int> FIALJLEMCFC(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x279DD90", Offset = "0x279CD90", VA = "0x18279DD90", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> MBBPFPNEAOE(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> VariableId, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<PGHLNDOLJNP>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct EBPGICONHJF : KIAAHEKIFLO<int, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x279D8B0", Offset = "0x279C8B0", VA = "0x18279D8B0")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD93580", Offset = "0xD92580", VA = "0x180D93580", Slot = "4")]
		public int ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		public bool BBFACCFMDMJ(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "5")]
		private bool KKOJJFBBAKK(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x279D8A0", Offset = "0x279C8A0", VA = "0x18279D8A0", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBEFLKBGHGD(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct MIFJAJIJFMC : ICCNGAHNDHH<int, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27A5090", Offset = "0x27A4090", VA = "0x1827A5090")]
		public AKAJMPNFKFH<int> KANKCFHJEDG(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x27A5100", Offset = "0x27A4100", VA = "0x1827A5100")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x27A51A0", Offset = "0x27A41A0", VA = "0x1827A51A0", Slot = "6")]
		public void MMIKKBDHEAD(int OHHMJGCBCKD, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x27A5090", Offset = "0x27A4090", VA = "0x1827A5090", Slot = "4")]
		private AKAJMPNFKFH<int> OMHJAOINCOI(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27A5080", Offset = "0x27A4080", VA = "0x1827A5080", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> JKPMMNHJICK(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct DBOMCHPLBCA : KIAAHEKIFLO<int, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x279D7F0", Offset = "0x279C7F0", VA = "0x18279D7F0")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD93580", Offset = "0xD92580", VA = "0x180D93580", Slot = "4")]
		public int ALCNHAMKNBC(int OHHMJGCBCKD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680")]
		public bool BBFACCFMDMJ(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "5")]
		private bool KKOJJFBBAKK(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x279D7E0", Offset = "0x279C7E0", VA = "0x18279D7E0", Slot = "6")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> DBEFLKBGHGD(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct LABMKPBFNEO : ICCNGAHNDHH<int, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x27A48F0", Offset = "0x27A38F0", VA = "0x1827A48F0")]
		public AKAJMPNFKFH<int> KANKCFHJEDG(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x27A4960", Offset = "0x27A3960", VA = "0x1827A4960")]
		public EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x27A4A00", Offset = "0x27A3A00", VA = "0x1827A4A00", Slot = "6")]
		public void MMIKKBDHEAD(int OHHMJGCBCKD, AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x27A48F0", Offset = "0x27A38F0", VA = "0x1827A48F0", Slot = "4")]
		private AKAJMPNFKFH<int> OMHJAOINCOI(int LJFFHGCHHLJ, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(AKAJMPNFKFH<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27A48E0", Offset = "0x27A38E0", VA = "0x1827A48E0", Slot = "5")]
		private EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> JKPMMNHJICK(int OHHMJGCBCKD, [In] AKAJMPNFKFH<(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> Target, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ByteCodeWriteLocation)> DHLGAIMCINE)
		{
			return default(EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NKDEEPLEEJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PPHFBKFDGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool CHBJFPCJLDP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E456A0", Offset = "0x1E446A0", VA = "0x181E456A0")]
		public NKDEEPLEEJP(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, bool OEINIFBJKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x27A53F0", Offset = "0x27A43F0", VA = "0x1827A53F0")]
		public void BGDNOIMKKGE([Out] EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, [Out] bool OEINIFBJKAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LOAOHFMCMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EDBALDILLBK<AIHJLHNMKCJ> IGGCDBIEKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PPHFBKFDGGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool CHBJFPCJLDP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x27A4FC0", Offset = "0x27A3FC0", VA = "0x1827A4FC0")]
		public LOAOHFMCMLH(EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, bool OEINIFBJKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x27A4FB0", Offset = "0x27A3FB0", VA = "0x1827A4FB0")]
		public void BGDNOIMKKGE([Out] EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, [Out] bool OEINIFBJKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x27A4F90", Offset = "0x27A3F90", VA = "0x1827A4F90")]
		public void BGDNOIMKKGE([Out] EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, [Out] EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP, [Out] bool OEINIFBJKAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct DDFILGOCHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly EDBALDILLBK<AIHJLHNMKCJ> IGGCDBIEKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PPHFBKFDGGL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		public DDFILGOCHMH(EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x279D890", Offset = "0x279C890", VA = "0x18279D890")]
		public void BGDNOIMKKGE([Out] EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB, [Out] EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27A6940", Offset = "0x27A5940", VA = "0x1827A6940")]
	public static void HMHHJKJOIHP(this KAONBHJKGKH OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27A55C0", Offset = "0x27A45C0", VA = "0x1827A55C0")]
	public static void BJBNIDFDGOP(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> CFFOOEHHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27A61A0", Offset = "0x27A51A0", VA = "0x1827A61A0")]
	public static void GGCIMBLEGCJ(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> CFFOOEHHCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27A7570", Offset = "0x27A6570", VA = "0x1827A7570")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>? MOGEHAPBBGK([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27A5AE0", Offset = "0x27A4AE0", VA = "0x1827A5AE0")]
	public static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> EONMGPJHDMA([In] this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27A7170", Offset = "0x27A6170", VA = "0x1827A7170")]
	private static void KPHAGIFEKGL(this KAONBHJKGKH OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27A7630", Offset = "0x27A6630", VA = "0x1827A7630")]
	private static EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>? MOPJINDOPKO([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27A5BD0", Offset = "0x27A4BD0", VA = "0x1827A5BD0")]
	public static void FBFMNGCAODC(this KAONBHJKGKH OCACDKEJIIB, [In] AKAJMPNFKFH<EAICEOLEMOA> ADGDKNGOKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27A70F0", Offset = "0x27A60F0", VA = "0x1827A70F0")]
	public static KAMGCLNCOBN.CJBKJIDIEAF KMHINDFKPHN([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(KAMGCLNCOBN.CJBKJIDIEAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27A7320", Offset = "0x27A6320", VA = "0x1827A7320")]
	public static OFKCHFBKBDL<byte> LOCHOIJKMHM([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(OFKCHFBKBDL<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27A7480", Offset = "0x27A6480", VA = "0x1827A7480")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MOGBHCBGOJK([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27A5740", Offset = "0x27A4740", VA = "0x1827A5740")]
	public static CDFNCNEGFME CMPAGNLJAHL([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(CDFNCNEGFME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x399DC40", Offset = "0x399CC40", VA = "0x18399DC40")]
	private static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> OFEMEAANKKA<TMJoin>(this KAONBHJKGKH OCACDKEJIIB, KAMGCLNCOBN.CJBKJIDIEAF PKOAACGODAM, EDBALDILLBK<TMJoin> CAFBDLMGINN) where TMJoin : KAMGCLNCOBN.IBDIILPBING
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27A7A60", Offset = "0x27A6A60", VA = "0x1827A7A60")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> ONDDOIGJAKO(this KAONBHJKGKH OCACDKEJIIB, bool NNPIKMKLMFJ)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x27A5B40", Offset = "0x27A4B40", VA = "0x1827A5B40")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> FALEFNIPMAB(this KAONBHJKGKH OCACDKEJIIB, OFKCHFBKBDL<byte> ACDPPDBEDDM)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27A6270", Offset = "0x27A5270", VA = "0x1827A6270")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> GHCEACACGGB(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> BMKAPPLJFJN)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x27A6D40", Offset = "0x27A5D40", VA = "0x1827A6D40")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> IBIDEKKCIAM(this KAONBHJKGKH OCACDKEJIIB, int GNJBJNHAKAA)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27A5830", Offset = "0x27A4830", VA = "0x1827A5830")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> DFEOHBAPIDN(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x399BF50", Offset = "0x399AF50", VA = "0x18399BF50")]
	private static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> AOBNBHIBNEC<TMJoin>(this KAONBHJKGKH OCACDKEJIIB, EPFJDBPLDCM.BNJJKPPBJGI PKOAACGODAM, EDBALDILLBK<TMJoin> CAFBDLMGINN) where TMJoin : EPFJDBPLDCM.CJLHGMFLAKG
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x27A72E0", Offset = "0x27A62E0", VA = "0x1827A72E0")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> LIJDCOFCOAM(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27A6EC0", Offset = "0x27A5EC0", VA = "0x1827A6EC0")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> JFAKBPAIKOF(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27A5A60", Offset = "0x27A4A60", VA = "0x1827A5A60")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> EKMJMMOGHOK(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PLJNGLEMEBC)
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27A5570", Offset = "0x27A4570", VA = "0x1827A5570")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> BGCGPDLCOBL(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27A6F60", Offset = "0x27A5F60", VA = "0x1827A6F60")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> KCAGBOPMEAN(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27A54F0", Offset = "0x27A44F0", VA = "0x1827A54F0")]
	public static EGKCPMOAPKM.DBKOFGKBMFF AMCFAIPOJLK([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC)
	{
		return default(EGKCPMOAPKM.DBKOFGKBMFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27A7870", Offset = "0x27A6870", VA = "0x1827A7870")]
	public static GOLJDLPFDHE<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, DPBDKGNBPCC<EGKCPMOAPKM.IGGNHMBKPEK>> OEAHCPPNMHP([In] this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(GOLJDLPFDHE<EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>, DPBDKGNBPCC<EGKCPMOAPKM.IGGNHMBKPEK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27A5DF0", Offset = "0x27A4DF0", VA = "0x1827A5DF0")]
	public static EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> FPNIEDLEDCF([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC)
	{
		return default(EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27A6E40", Offset = "0x27A5E40", VA = "0x1827A6E40")]
	public static EGKCPMOAPKM.HNMPLLOBKCE IPFNMKAMPCD([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OAOLOIECNCK)
	{
		return default(EGKCPMOAPKM.HNMPLLOBKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27A6DC0", Offset = "0x27A5DC0", VA = "0x1827A6DC0")]
	public static EGKCPMOAPKM.HNMPLLOBKCE IOEEODNAKEM(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OAOLOIECNCK)
	{
		return default(EGKCPMOAPKM.HNMPLLOBKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x399CEF0", Offset = "0x399BEF0", VA = "0x18399CEF0")]
	private static EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> JBDFOGELLML<TMJoin>(this KAONBHJKGKH OCACDKEJIIB, EGKCPMOAPKM.DBKOFGKBMFF PKOAACGODAM, EDBALDILLBK<TMJoin> CAFBDLMGINN) where TMJoin : EGKCPMOAPKM.OPMINENDEFJ
	{
		return default(EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27A66C0", Offset = "0x27A56C0", VA = "0x1827A66C0")]
	public static (EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>) GPPLGMJOOAP(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default((EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27A78B0", Offset = "0x27A68B0", VA = "0x1827A78B0")]
	public static (EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>) OFLPDJKEPMB(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default((EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27A6F10", Offset = "0x27A5F10", VA = "0x1827A6F10")]
	public static EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> JGGILNHEPOA(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27A5460", Offset = "0x27A4460", VA = "0x1827A5460")]
	public static void AKGABOINLOH(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK> OAOLOIECNCK, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> CDHHJFPFLCE, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>> JJEIHCBGAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x399C000", Offset = "0x399B000", VA = "0x18399C000")]
	public static NKDEEPLEEJP CEJAOLMFPGL<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP) where TDeps : BHHIKKKFPOF<TStateSys>
	{
		return default(NKDEEPLEEJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x399D9A0", Offset = "0x399C9A0", VA = "0x18399D9A0")]
	public static LOAOHFMCMLH MMGGKKHNDBD<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, int DNBAGCFNADG) where TDeps : BHHIKKKFPOF<TStateSys>
	{
		return default(LOAOHFMCMLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x399CF90", Offset = "0x399BF90", VA = "0x18399CF90")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>? JNPMEMCLJPD<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, [In] ReadOnlySpan<int> DMKKNHAPCOP, [In] Span<DDFILGOCHMH> HNMFKBJADCP) where TDeps : BHHIKKKFPOF<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x399D3D0", Offset = "0x399C3D0", VA = "0x18399D3D0")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> MDAAGJAGMGF<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB) where TDeps : BHHIKKKFPOF<TStateSys>
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x27A5650", Offset = "0x27A4650", VA = "0x1827A5650")]
	public static GDONHAJKGGO.LDPANFINKMJ CMLHGFJDPMM([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return default(GDONHAJKGGO.LDPANFINKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x27A7780", Offset = "0x27A6780", VA = "0x1827A7780")]
	public static GDONHAJKGGO.HJJMMOAGNIG NPJJKEABCFA([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return default(GDONHAJKGGO.HJJMMOAGNIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x27A6440", Offset = "0x27A5440", VA = "0x1827A6440")]
	public static GDONHAJKGGO.EBLHKKEEPGF GNCMIMOGCKM([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return default(GDONHAJKGGO.EBLHKKEEPGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x27A6530", Offset = "0x27A5530", VA = "0x1827A6530")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GPDMEKEMGFO(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME, string NFHOBPDKIPM)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27A6350", Offset = "0x27A5350", VA = "0x1827A6350")]
	public static GDONHAJKGGO.NHJOMDKDGCM GHKODFFGEAJ([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return default(GDONHAJKGGO.NHJOMDKDGCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27A7410", Offset = "0x27A6410", VA = "0x1827A7410")]
	public static GDONHAJKGGO.DMIFGOMPEMN MMHOKCKICIC([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return default(GDONHAJKGGO.DMIFGOMPEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27A7080", Offset = "0x27A6080", VA = "0x1827A7080")]
	public static int? KLOOGIKIDFD([In] this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x399BE50", Offset = "0x399AE50", VA = "0x18399BE50")]
	private static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ADHBNKIDHHJ<TMJoin>(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME, GDONHAJKGGO.DMIFGOMPEMN PKOAACGODAM, EDBALDILLBK<TMJoin> CAFBDLMGINN) where TMJoin : GDONHAJKGGO.BPFJKDDNIMC
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27A5D40", Offset = "0x27A4D40", VA = "0x1827A5D40")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> FEOFAHLINFM(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC, int OHHMJGCBCKD)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27A62F0", Offset = "0x27A52F0", VA = "0x1827A62F0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHIIEIFLJCD(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27A58B0", Offset = "0x27A48B0", VA = "0x1827A58B0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> DMIHCFENKKE(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? ENPMEAGHCJE, int? MGNOLFLBHME)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27A6110", Offset = "0x27A5110", VA = "0x1827A6110")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GBBMAGHPKEF(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME, int OHHMJGCBCKD)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27A5A00", Offset = "0x27A4A00", VA = "0x1827A5A00")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> EAPAICFFILD(this KAONBHJKGKH OCACDKEJIIB, int? MGNOLFLBHME)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27A5FD0", Offset = "0x27A4FD0", VA = "0x1827A5FD0")]
	public static void GAODFHOOIGO(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC, int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27A6C10", Offset = "0x27A5C10", VA = "0x1827A6C10")]
	public static void HPPODDGNKFC(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ, int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27A6FB0", Offset = "0x27A5FB0", VA = "0x1827A6FB0")]
	public static void KKNMNDFOJNO(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27A76F0", Offset = "0x27A66F0", VA = "0x1827A76F0")]
	public static void NCKKMJPANKP(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> FCPOJLOEIEO, EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> DEAMALDFEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27A6870", Offset = "0x27A5870", VA = "0x1827A6870")]
	public static void HEJECMOCLFJ(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ, EDBALDILLBK<BFODHMAPOAP<CIMMGIPFHNE>> KONGBBPIKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x399CE20", Offset = "0x399BE20", VA = "0x18399CE20")]
	public static void CMNOHBKOONO<M>(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AEEAFMLBAOJ, EDBALDILLBK<BFODHMAPOAP<AJNOBLLAKEF<M>>> KONGBBPIKGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BHHIKKKFPOF<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDBALDILLBK<GEIFHGDBEKD> JJOHCFLAKFD(TStateSys IGLMFNIKLGH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDBALDILLBK<GEIFHGDBEKD> GBILGOAIBDH(TStateSys IGLMFNIKLGH);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDBALDILLBK<GEIFHGDBEKD> LCGGMHODNIA(TStateSys IGLMFNIKLGH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDBALDILLBK<GEIFHGDBEKD> FHEOKHOOAMJ(TStateSys IGLMFNIKLGH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> PHBPLHPBFFK(TStateSys IGLMFNIKLGH, KAONBHJKGKH PCHICAJOMOM, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> HDDNBIBFHBI(TStateSys IGLMFNIKLGH, KAONBHJKGKH PCHICAJOMOM, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BNKNJGLDMAB(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EDBALDILLBK<MBCPFFKFBDC> LKCLOLMPEME(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP, int MOJFMLAABNF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CCAHAINELMH EKDJBONHOBJ(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MKKBLPBGENL(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int HKBGKCLICLE(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OFKCHFBKBDL<byte> MHOIKENDANF(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(OFKCHFBKBDL<byte>, EDBALDILLBK<GEIFHGDBEKD>) IEALIBDNHOC(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int LLHEBNKKGLA(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EDBALDILLBK<AIHJLHNMKCJ> GDBDCBCNIBE(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB, int DNBAGCFNADG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EDBALDILLBK<AIHJLHNMKCJ> JPJOKPMANAN(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, int DNBAGCFNADG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int EHJOFCJPNNK(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IMGAFHEDMFI(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int ODHCDCGNDDC(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? KONOGBOFEMC(TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, int OHHMJGCBCKD);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KIKJKKJELBJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x38E1540", Offset = "0x38E0540", VA = "0x1838E1540")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL?> HKIGDLGIFIG<T, TOpInput, TOpOutput>(this KAONBHJKGKH OCACDKEJIIB, T OBNCJFFHHLB, T ODHPFGNCGDP, int GHPMIEMCBJM, IntPtr AIAOPAOOPLP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x38E1CB0", Offset = "0x38E0CB0", VA = "0x1838E1CB0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL?> NGPKPOOAHAK<T, TOpInput, TOpOutput>(this KAONBHJKGKH OCACDKEJIIB, T OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP, int GHPMIEMCBJM, IntPtr AIAOPAOOPLP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x38E0A80", Offset = "0x38DFA80", VA = "0x1838E0A80")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL?> ELMMGMBOFCD<TOpInput, TOpOutput>(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP, int GHPMIEMCBJM, IntPtr AIAOPAOOPLP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x27A3CA0", Offset = "0x27A2CA0", VA = "0x1827A3CA0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> NJBPIJECPME(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x27A0650", Offset = "0x279F650", VA = "0x1827A0650")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CADIGFCLABF(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x27A1B00", Offset = "0x27A0B00", VA = "0x1827A1B00")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HGOOMLFEBBB(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27A3EC0", Offset = "0x27A2EC0", VA = "0x1827A3EC0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OIDIOLBJHGE(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27A3FC0", Offset = "0x27A2FC0", VA = "0x1827A3FC0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OJKJFJAFOGN(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x279F720", Offset = "0x279E720", VA = "0x18279F720")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> BBKANPLOEBN(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27A2680", Offset = "0x27A1680", VA = "0x1827A2680")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> JEELNFLECJC(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27A2190", Offset = "0x27A1190", VA = "0x1827A2190")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IKMOJPHNGMG(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27A0160", Offset = "0x279F160", VA = "0x1827A0160")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> BLLBOMHMAJO(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27A1C40", Offset = "0x27A0C40", VA = "0x1827A1C40")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLMECNPKOIG(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, int ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27A0C60", Offset = "0x279FC60", VA = "0x1827A0C60")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> DPAENGOBONO(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27A2780", Offset = "0x27A1780", VA = "0x1827A2780")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> JLMBHBMFHBK(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x27A1240", Offset = "0x27A0240", VA = "0x1827A1240")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GCHPJHOGILC(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, float ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27A4580", Offset = "0x27A3580", VA = "0x1827A4580")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> PJJEPFCJNDF(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27A19C0", Offset = "0x27A09C0", VA = "0x1827A19C0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HCKJJAICGHB(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27A4160", Offset = "0x27A3160", VA = "0x1827A4160")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OMCMAGEEBLA(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, int ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27A0EA0", Offset = "0x279FEA0", VA = "0x1827A0EA0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> EPBPLCPDKDN(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27A2600", Offset = "0x27A1600", VA = "0x1827A2600")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> JAODJLMEHPI(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27A2D00", Offset = "0x27A1D00", VA = "0x1827A2D00")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> KGMGBNFMDLJ(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, float ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27A1D40", Offset = "0x27A0D40", VA = "0x1827A1D40")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HNIOHDOKGJO(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27A1340", Offset = "0x27A0340", VA = "0x1827A1340")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GFDMNDAAMNG(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27A3C20", Offset = "0x27A2C20", VA = "0x1827A3C20")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> NGEMGCBLKEK(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, int ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27A4260", Offset = "0x27A3260", VA = "0x1827A4260")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OMLDBIGFFED(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x27A4500", Offset = "0x27A3500", VA = "0x1827A4500")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> PJEAJDPAPMA(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27A4770", Offset = "0x27A3770", VA = "0x1827A4770")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> POFEHAMLOEA(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, float ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27A4360", Offset = "0x27A3360", VA = "0x1827A4360")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OPJOOMJMEFH(this KAONBHJKGKH OCACDKEJIIB, float OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27A3420", Offset = "0x27A2420", VA = "0x1827A3420")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MCGGNHJJBKK(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27A09A0", Offset = "0x279F9A0", VA = "0x1827A09A0")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> CHGPFFHIBGC(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27A42E0", Offset = "0x27A32E0", VA = "0x1827A42E0")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> ONHPPIMACOM(this KAONBHJKGKH OCACDKEJIIB, int OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27A3760", Offset = "0x27A2760", VA = "0x1827A3760")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> MHKKJLNJAGM(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27A15F0", Offset = "0x27A05F0", VA = "0x1827A15F0")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> GHJNJGLOCOF(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> KGOCNEIKKAB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27A1DD0", Offset = "0x27A0DD0", VA = "0x1827A1DD0")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> IBELKHPOGEL(this KAONBHJKGKH OCACDKEJIIB, int OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x279F680", Offset = "0x279E680", VA = "0x18279F680")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> BABFJIMMDHC(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27A28C0", Offset = "0x27A18C0", VA = "0x1827A28C0")]
	public static (EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>) KEHCAKJFKDA(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<FCFMNFHIFNB> ALGFFMKKBFM, [In] ReadOnlySpan<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> DLHJDCJDKHC, [In] ReadOnlySpan<int?> POGGADGPMAH, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> KFICEGEHCCB)
	{
		return default((EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x279FBE0", Offset = "0x279EBE0", VA = "0x18279FBE0")]
	public static (EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>) BGECGFKCIPH(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<PGHHJNEDGCL> KEFMHDCFFJB, [In] ReadOnlySpan<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> DLHJDCJDKHC, [In] ReadOnlySpan<int?> POGGADGPMAH, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> KFICEGEHCCB)
	{
		return default((EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x38E0750", Offset = "0x38DF750", VA = "0x1838E0750")]
	public static (EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>) CHALPHKCBOJ<TMarker>(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GEIFHGDBEKD> KIMGLLJONCB, [In] ReadOnlySpan<byte> APDBNIMCPID)
	{
		return default((EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<BFODHMAPOAP<GEIFHGDBEKD>>, EDBALDILLBK<BFODHMAPOAP<AKDOAODMDCG>>, EDBALDILLBK<BFODHMAPOAP<TMarker>>, EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27A46B0", Offset = "0x27A36B0", VA = "0x1827A46B0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> PLHGNFGGNGG(this KAONBHJKGKH OCACDKEJIIB, int EKBPMBFJFCG, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27A0B70", Offset = "0x279FB70", VA = "0x1827A0B70")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CKJHAPIPOHA(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> EKBPMBFJFCG, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27A1500", Offset = "0x27A0500", VA = "0x1827A1500")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHEJGCNADCI(this KAONBHJKGKH OCACDKEJIIB, [In] ReadOnlySpan<byte> EKBPMBFJFCG, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27A17A0", Offset = "0x27A07A0", VA = "0x1827A17A0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GKCIOEDKAIM(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> EKBPMBFJFCG, int CFNMLMNHCMF, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27A1140", Offset = "0x27A0140", VA = "0x1827A1140")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> FMOCEBFDJIK(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x27A3B00", Offset = "0x27A2B00", VA = "0x1827A3B00")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MOOHMCAANOO(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27A2E80", Offset = "0x27A1E80", VA = "0x1827A2E80")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> KJGJNGAPOBK(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27A2D80", Offset = "0x27A1D80", VA = "0x1827A2D80")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> KIBJNCILKLN(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x27A3DA0", Offset = "0x27A2DA0", VA = "0x1827A3DA0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> NJECKNPIGDN(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27A30E0", Offset = "0x27A20E0", VA = "0x1827A30E0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> LDCPLCPMHOG(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x27A41E0", Offset = "0x27A31E0", VA = "0x1827A41E0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OMDEELIKCDM(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, int ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27A35E0", Offset = "0x27A25E0", VA = "0x1827A35E0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MEFLGMNGJGE(this KAONBHJKGKH OCACDKEJIIB, int OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27A40E0", Offset = "0x27A30E0", VA = "0x1827A40E0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OLKJLFJCILI(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OBNCJFFHHLB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ODHPFGNCGDP)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27A3220", Offset = "0x27A2220", VA = "0x1827A3220")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> LHPLPNEIPLN(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27A0870", Offset = "0x279F870", VA = "0x1827A0870")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CGBBDLCCCPA(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27A0020", Offset = "0x279F020", VA = "0x1827A0020")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> BKHMFJNKDFE(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2320", VA = "0x1827A3320")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> LMCNMFBNGAO(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27A0D80", Offset = "0x279FD80", VA = "0x1827A0D80")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ECBAIOFPFIL(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27A34A0", Offset = "0x27A24A0", VA = "0x1827A34A0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MDMBDIDNLII(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27A0B50", Offset = "0x279FB50", VA = "0x1827A0B50")]
	public static EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>> CJIJIFAEGGG(this KAONBHJKGKH OCACDKEJIIB)
	{
		return default(EDBALDILLBK<BFODHMAPOAP<BFODHMAPOAP<FNLIENCGJGF>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27A0F20", Offset = "0x279FF20", VA = "0x1827A0F20")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> FIIHDJDNNJF(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27A23D0", Offset = "0x27A13D0", VA = "0x1827A23D0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IOPNIFLEGFP(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27A13C0", Offset = "0x27A03C0", VA = "0x1827A13C0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GFLLIOOPIHF(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27A18C0", Offset = "0x27A08C0", VA = "0x1827A18C0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GMBLNLMNIPA(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27A2FC0", Offset = "0x27A1FC0", VA = "0x1827A2FC0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> LBEENILBNNO(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27A02A0", Offset = "0x279F2A0", VA = "0x1827A02A0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> BPFPIDGHMJH(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27A0770", Offset = "0x279F770", VA = "0x1827A0770")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CALGEKIIDIO(this KAONBHJKGKH OCACDKEJIIB, int OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27A24F0", Offset = "0x27A14F0", VA = "0x1827A24F0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> JAKMHEFHFCM(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> OHLIHBDBKCE)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27A1DC0", Offset = "0x27A0DC0", VA = "0x1827A1DC0")]
	public static void IAPCPDDAHII(this KAONBHJKGKH OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27A2090", Offset = "0x27A1090", VA = "0x1827A2090")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IJJIKNPEPFG(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, float GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27A1020", Offset = "0x27A0020", VA = "0x1827A1020")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> FIJPJIMKFDH(this KAONBHJKGKH OCACDKEJIIB, float HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x279F540", Offset = "0x279E540", VA = "0x18279F540")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AOILEMAHJHN(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x27A1F90", Offset = "0x27A0F90", VA = "0x1827A1F90")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IJJIGMGALDM(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x27A43E0", Offset = "0x27A33E0", VA = "0x1827A43E0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> PCHKNDKGDAL(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x27A1E50", Offset = "0x27A0E50", VA = "0x1827A1E50")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IIENDLPDAGG(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x279F860", Offset = "0x279E860", VA = "0x18279F860")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> BCCIAEACIFI(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> LEPOELFDCIF, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> JEHIJKBOGHD)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x27A3660", Offset = "0x27A2660", VA = "0x1827A3660")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> MFPHLPLGCFM(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, int GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x27A22B0", Offset = "0x27A12B0", VA = "0x1827A22B0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> INGCOHFKHOJ(this KAONBHJKGKH OCACDKEJIIB, int HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x27A0510", Offset = "0x279F510", VA = "0x1827A0510")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CACJICCMDKJ(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HLHEEENKHNP, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> GHJJIFJECEA)
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38DFD50", Offset = "0x38DED50", VA = "0x1838DFD50")]
	public static void CCCJBPODOEP<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<FCFMNFHIFNB> ALGFFMKKBFM, [In] ReadOnlySpan<EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>> IAALDPIIEGH, [In] ReadOnlySpan<int?> POGGADGPMAH, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> KFICEGEHCCB, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> NFFIFBBHFPH, [In] ReadOnlySpan<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>?> HJHAGCMHMLN) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38E0BF0", Offset = "0x38DFBF0", VA = "0x1838E0BF0")]
	public static void HCMLFFADJNL<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<PGHHJNEDGCL> NPLDOOBBCLG, [In] ReadOnlySpan<EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>> JFHAKIHOLJL, [In] ReadOnlySpan<int?> POGGADGPMAH, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> KFICEGEHCCB, [In] Span<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>> NFFIFBBHFPH, [In] ReadOnlySpan<EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>?> HJHAGCMHMLN) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x38E1AD0", Offset = "0x38E0AD0", VA = "0x1838E1AD0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> IIKEHKHCPHH<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> ENPMEAGHCJE, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38E02F0", Offset = "0x38DF2F0", VA = "0x1838E02F0")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> CENCEHJNPEN<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PLJNGLEMEBC, [Optional] EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x38E0850", Offset = "0x38DF850", VA = "0x1838E0850")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> DOGIKADFBON<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH) where TDeps : notnull, BHHIKKKFPOF<TStateSys> where TStateSys : notnull
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x38E2050", Offset = "0x38E1050", VA = "0x1838E2050")]
	public static EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN> NJBEJLNOKNB<TDeps, TStateSys>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH) where TDeps : notnull, BHHIKKKFPOF<TStateSys> where TStateSys : notnull
	{
		return default(EDBALDILLBK<EPFJDBPLDCM.IDICMAPHLGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27A03E0", Offset = "0x279F3E0", VA = "0x1827A03E0")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> BPPOIFGIOJA(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> DBLBLFPIPJI, IntPtr IDMJGNCAGKB, IntPtr EMJELJIAKNP)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27A3800", Offset = "0x27A2800", VA = "0x1827A3800")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> MNBAPMAFLBC(this KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> EPOAPJFPFKI, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> AEKKGMEIHCO, IntPtr HNKPOGKGOBD, IntPtr OBBALNJNLBH, IntPtr IFCFCJHFCDK, bool EIJNGACDPNP)
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x38E2580", Offset = "0x38E1580", VA = "0x1838E2580")]
	public static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PFGGHECCCIM<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<FCFMNFHIFNB> LKJANGBPNJO, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> EPOAPJFPFKI, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> AEKKGMEIHCO, int? DNBDJBGEEPC, [Optional] IntPtr MBGENIEPOAB) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38E2260", Offset = "0x38E1260", VA = "0x1838E2260")]
	private static EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> PFGGHECCCIM<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<FCFMNFHIFNB> LKJANGBPNJO, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> EPOAPJFPFKI, EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE> AEKKGMEIHCO, int? DNBDJBGEEPC) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
		return default(EDBALDILLBK<KAMGCLNCOBN.HGPGKPGOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38E1190", Offset = "0x38E0190", VA = "0x1838E1190")]
	public static EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HDPJBAKLILN<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> EKBPMBFJFCG, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>? FMDPDNGNNPP) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
		return default(EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38E1840", Offset = "0x38E0840", VA = "0x1838E1840")]
	public static void IDOOGCGEAGG<TDeps, TState>(this KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TState IDAKFFICKHC, int MMFOBKFKFIA) where TDeps : notnull, BHHIKKKFPOF<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NMIBGCFEICE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> DLBLGBJOIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> BNLOAFEMCKP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
	public NMIBGCFEICE(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> OJGABAFKMCF, EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> BIBIBEFOPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27A5420", Offset = "0x27A4420", VA = "0x1827A5420")]
	public static NMIBGCFEICE ACADPGMDEBE(EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>> OJGABAFKMCF)
	{
		return default(NMIBGCFEICE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GDONHAJKGGO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CLEFDEOAJLF : BPFJKDDNIMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct LDPANFINKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> DLEMAOFDECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		public LDPANFINKMJ(EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC, int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KLPMLOFCOJE : BPFJKDDNIMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct HJJMMOAGNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public HJJMMOAGNIG(int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class NEFDPOOKGDI : BPFJKDDNIMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct EBLHKKEEPGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> DLEMAOFDECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xCFF1E0", Offset = "0xCFE1E0", VA = "0x180CFF1E0")]
		public EBLHKKEEPGF(EDBALDILLBK<EGKCPMOAPKM.EPKKDPEHPPI> MDCDILEKLCC, int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum DMIFGOMPEMN
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
	public sealed class KPAADAGPBCL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class BPFJKDDNIMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NPDEKFACHCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? EAKMILICKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NMIBGCFEICE JCPKFIOOODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public DMIFGOMPEMN JDKFIPEGOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EDBALDILLBK<BPFJKDDNIMC> IAMFLKGOHCD;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27A5430", Offset = "0x27A4430", VA = "0x1827A5430")]
		public NPDEKFACHCP(int? MGNOLFLBHME, [In] NMIBGCFEICE CCNEPEBCIKA, DMIFGOMPEMN PKOAACGODAM, EDBALDILLBK<BPFJKDDNIMC> CAFBDLMGINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class KKGLGBCGEKK : BPFJKDDNIMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NHJOMDKDGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1292E00", Offset = "0x1291E00", VA = "0x181292E00")]
		public NHJOMDKDGCM(int OHHMJGCBCKD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal ELNOMAFOOMB<KPAADAGPBCL, NPDEKFACHCP> OMMHMIEIGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal ELNOMAFOOMB<CLEFDEOAJLF, LDPANFINKMJ> GGDEOACFKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal ELNOMAFOOMB<NEFDPOOKGDI, EBLHKKEEPGF> LMPMAPIGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal ELNOMAFOOMB<KKGLGBCGEKK, NHJOMDKDGCM> JMOOCLMGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal ELNOMAFOOMB<KLPMLOFCOJE, HJJMMOAGNIG> JJNPDCAIAKB;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x279E280", Offset = "0x279D280", VA = "0x18279E280")]
	private GDONHAJKGGO([In] ELNOMAFOOMB<KPAADAGPBCL, NPDEKFACHCP> IKCGIPBAPFL, [In] ELNOMAFOOMB<CLEFDEOAJLF, LDPANFINKMJ> AOMIJDBOOMO, [In] ELNOMAFOOMB<NEFDPOOKGDI, EBLHKKEEPGF> OOBCGFPPLJA, [In] ELNOMAFOOMB<KKGLGBCGEKK, NHJOMDKDGCM> IPBHHOADGLI, [In] ELNOMAFOOMB<KLPMLOFCOJE, HJJMMOAGNIG> JPOIKJGGODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x279E090", Offset = "0x279D090", VA = "0x18279E090")]
	public static GDONHAJKGGO ACADPGMDEBE()
	{
		return default(GDONHAJKGGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PFLCEMFPMBK
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x27A86D0", Offset = "0x27A76D0", VA = "0x1827A86D0")]
	public static void HMHHJKJOIHP(this GDONHAJKGGO OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NBGBBEHGJFO
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x27A5290", Offset = "0x27A4290", VA = "0x1827A5290")]
	public static void GDMALPFODEM(KAONBHJKGKH OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ANMHMIGFGOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, FJAOABOEHGI> IJMMGGACDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int PFOMAADOIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int FKOKICBJALE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x279D180", Offset = "0x279C180", VA = "0x18279D180")]
	private ANMHMIGFGOP([In] MDCFHPFNPDO<EGKCPMOAPKM.IGGNHMBKPEK, FJAOABOEHGI> OOLIBAOKIKL, int LAGOKDOHCPE, int MCBHPOPOBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x279CF20", Offset = "0x279BF20", VA = "0x18279CF20")]
	public static ANMHMIGFGOP ACADPGMDEBE()
	{
		return default(ANMHMIGFGOP);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x279CF90", Offset = "0x279BF90", VA = "0x18279CF90")]
	public void HMHHJKJOIHP([In] KAONBHJKGKH BHEAPBGPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EB20", Offset = "0x3F6DB20", VA = "0x183F6EB20")]
	public static void GDMALPFODEM<TDeps, TStateSys>(KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD) where TDeps : notnull, BHHIKKKFPOF<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AFFKHIHILKH
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x279CD50", Offset = "0x279BD50", VA = "0x18279CD50")]
	public static void GDMALPFODEM(KAONBHJKGKH OCACDKEJIIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ADPBKEGPCNO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JCHGOOLJDCK(AKAJMPNFKFH<byte> PHNDCNEHGDD, int FNGIODNLAIP);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PLMOMGLJPKH : FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x27A8780", Offset = "0x27A7780", VA = "0x1827A8780", Slot = "4")]
		public void JCHGOOLJDCK(AKAJMPNFKFH<byte> PHNDCNEHGDD, int FNGIODNLAIP)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct MHBBLPPMIKA : FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27A4FD0", Offset = "0x27A3FD0", VA = "0x1827A4FD0", Slot = "4")]
		public void JCHGOOLJDCK(AKAJMPNFKFH<byte> PHNDCNEHGDD, int FNGIODNLAIP)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct IPDJMPPNPEL : FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x279E5E0", Offset = "0x279D5E0", VA = "0x18279E5E0", Slot = "4")]
		public void JCHGOOLJDCK(AKAJMPNFKFH<byte> PHNDCNEHGDD, int FNGIODNLAIP)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct GMGEGFIMMAC : FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x279E3B0", Offset = "0x279D3B0", VA = "0x18279E3B0", Slot = "4")]
		public void JCHGOOLJDCK(AKAJMPNFKFH<byte> PHNDCNEHGDD, int FNGIODNLAIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class EFMEOENAPCN<TCallProcessorDeps> where TCallProcessorDeps : struct, FMHFAALGDPD
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IJFOHHKJJKM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC140", Offset = "0x3CAB140", VA = "0x183CAC140")]
		public static int GDMALPFODEM<TDeps, TStateSys>(TDeps MMCKJCAOGBM, TStateSys IDAKFFICKHC, KAONBHJKGKH BHEAPBGPMHH, [In] AKAJMPNFKFH<byte> KMEJHCIEDPB, int CKKJKHJHBHK) where TDeps : BHHIKKKFPOF<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AKAJMPNFKFH<EAICEOLEMOA> COHKHGJCKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> PAIICNMEIKP;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x279CD10", Offset = "0x279BD10", VA = "0x18279CD10")]
	private ADPBKEGPCNO([In] AKAJMPNFKFH<EAICEOLEMOA> ADGDKNGOKIO, Dictionary<EDBALDILLBK<BFODHMAPOAP<FNLIENCGJGF>>, EDBALDILLBK<EGKCPMOAPKM.IGGNHMBKPEK>> ILMGPEJFMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x279CC10", Offset = "0x279BC10", VA = "0x18279CC10")]
	public static ADPBKEGPCNO ACADPGMDEBE()
	{
		return default(ADPBKEGPCNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x279CCD0", Offset = "0x279BCD0", VA = "0x18279CCD0")]
	public void HMHHJKJOIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3F64380", Offset = "0x3F63380", VA = "0x183F64380")]
	public static void GDMALPFODEM<TDeps, TStateSys>(KAONBHJKGKH OCACDKEJIIB, TDeps MMCKJCAOGBM, TStateSys IGLMFNIKLGH) where TDeps : BHHIKKKFPOF<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class OAJDCMGILPB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NGDDDBOMINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> AAGHMKJBIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int OCLCKFHDFOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int LJCMFMHBFHB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int DPNIHABGBGM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x27A7E30", Offset = "0x27A6E30", VA = "0x1827A7E30")]
	public static void GDMALPFODEM(KAONBHJKGKH OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27A7CA0", Offset = "0x27A6CA0", VA = "0x1827A7CA0")]
	private static void CMNOHFMMEND([In] KAONBHJKGKH OCACDKEJIIB, EDBALDILLBK<GDONHAJKGGO.KPAADAGPBCL> HJPLNJNIFLL, AKAJMPNFKFH<byte> CDDBHANJCMN, List<NGDDDBOMINI> BEBOGELPMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x27A7B60", Offset = "0x27A6B60", VA = "0x1827A7B60")]
	private static void CMNOHFMMEND(AKAJMPNFKFH<byte> CDDBHANJCMN, int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x27A84F0", Offset = "0x27A74F0", VA = "0x1827A84F0")]
	private static void JMJKDBEDJAA(KAONBHJKGKH OCACDKEJIIB, List<NGDDDBOMINI> BEBOGELPMCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class OAKMEOGNEHB<TDeps, TIndex, TValues> where TDeps : struct, ICCNGAHNDHH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps IJFOHHKJJKM;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54FC710", Offset = "0x54FB710", VA = "0x1854FC710")]
	public static void GDMALPFODEM([In] AKAJMPNFKFH<EAICEOLEMOA> ADGDKNGOKIO, int LJFFHGCHHLJ, TValues DHLGAIMCINE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ICCNGAHNDHH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKAJMPNFKFH<TIndex> KANKCFHJEDG(int LJFFHGCHHLJ, [In] TValues DHLGAIMCINE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(TIndex OHHMJGCBCKD, [In] TValues DHLGAIMCINE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMIKKBDHEAD(TIndex OHHMJGCBCKD, TValues DHLGAIMCINE, EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KIAAHEKIFLO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex ALCNHAMKNBC(int OHHMJGCBCKD);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBFACCFMDMJ(TIndex OHHMJGCBCKD, [In] TValues DHLGAIMCINE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDBALDILLBK<BFODHMAPOAP<PGHLNDOLJNP>> LGHBHPCGJDO(TIndex OHHMJGCBCKD, [In] TValues DHLGAIMCINE);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BBOBANDCBIL<TDeps, TIndex, TValues> where TDeps : struct, KIAAHEKIFLO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps IJFOHHKJJKM;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61AB3A0", Offset = "0x61AA3A0", VA = "0x1861AB3A0")]
	public static AKAJMPNFKFH<TIndex> GDMALPFODEM(int LJFFHGCHHLJ, [In] TValues DHLGAIMCINE)
	{
		return default(AKAJMPNFKFH<TIndex>);
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

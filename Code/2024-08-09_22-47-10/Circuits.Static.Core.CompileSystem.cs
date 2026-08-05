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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x20044A0", Offset = "0x20038A0", VA = "0x1820044A0")]
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
public readonly struct FFBNLHDDCOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> IPJOJEEGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int KGLBMPMHJKP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
	public FFBNLHDDCOA(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OLJCCAPBLAE, int BILMLHHHLMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FDKMCDBBMJE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class IEIIOEIOHPL : GNHIDOIJDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct MIHHBNFIPLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly PKPFALODBMP<byte> IGDJKEEINCK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E460", Offset = "0x1F9D860", VA = "0x181F9E460")]
		public MIHHBNFIPLK(PKPFALODBMP<byte> PLMCKIPFEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDF90", Offset = "0x1FFD390", VA = "0x181FFDF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BFDIMCNAADL : GNHIDOIJDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MGHINGHMGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> MDCGOMKCPFG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public MGHINGHMGOB(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> BJEDMELKPAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum EKGPIHKJBPF
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
	public sealed class GMICBGOAJNL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class GNHIDOIJDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct PKMAMMIMLLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly EKGPIHKJBPF FOACFDODIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly DFKPAEMPCKH<GNHIDOIJDLD> KLAPHPOCEPC;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		public PKMAMMIMLLF(EKGPIHKJBPF DFLGBFHHDID, DFKPAEMPCKH<GNHIDOIJDLD> KMLNNJBOKOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class EOJPOHEDJFN : GNHIDOIJDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct AIHGJBPEBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ADBDACKJGOJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public AIHGJBPEBGD(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NKEJMKJBOHA : GNHIDOIJDLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MBOILOHCFPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KOIDIICODKL LCACDOMFECA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public MBOILOHCFPF(KOIDIICODKL BCHEAELGIDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDF70", Offset = "0x1FFD370", VA = "0x181FFDF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal KCDOIHAGKBG<GMICBGOAJNL, PKMAMMIMLLF> CHABJKOGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal KCDOIHAGKBG<IEIIOEIOHPL, MIHHBNFIPLK> HLOLHNOEKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal KCDOIHAGKBG<BFDIMCNAADL, MGHINGHMGOB> DBOMLBIOFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal KCDOIHAGKBG<EOJPOHEDJFN, AIHGJBPEBGD> PCPMMMKMIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal KCDOIHAGKBG<NKEJMKJBOHA, MBOILOHCFPF> OOPMBNBOOJN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCA00", Offset = "0x1FFBE00", VA = "0x181FFCA00")]
	private FDKMCDBBMJE([In] KCDOIHAGKBG<GMICBGOAJNL, PKMAMMIMLLF> NCLIOLKCBMO, [In] KCDOIHAGKBG<IEIIOEIOHPL, MIHHBNFIPLK> LBNPLCJGKLF, [In] KCDOIHAGKBG<BFDIMCNAADL, MGHINGHMGOB> IIDOFFLNHOJ, [In] KCDOIHAGKBG<EOJPOHEDJFN, AIHGJBPEBGD> IBCGJBLIGNK, [In] KCDOIHAGKBG<NKEJMKJBOHA, MBOILOHCFPF> MEHEMCOOCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC8C0", Offset = "0x1FFBCC0", VA = "0x181FFC8C0")]
	public static FDKMCDBBMJE DDEJLDFANAB()
	{
		return default(FDKMCDBBMJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MPFGCNOKKPF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE330", Offset = "0x1FFD730", VA = "0x181FFE330")]
	public static void CDBCEOANHGG(this FDKMCDBBMJE ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum BCMDHBHPLLF
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
public struct MMBPEFLHLBP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class NOPHHKDGBBP : GHNODFJBCNM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ABELFOFPMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> DAAGPJMMEDF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public ABELFOFPMIJ(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> EFPKMBNDDMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NBGAHACMJNF
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
	public sealed class LJHGCPKIAKM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class GHNODFJBCNM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct FOHCGPGJJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly NBGAHACMJNF FOACFDODIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly DFKPAEMPCKH<GHNODFJBCNM> KLAPHPOCEPC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		public FOHCGPGJJDE(NBGAHACMJNF DFLGBFHHDID, DFKPAEMPCKH<GHNODFJBCNM> KMLNNJBOKOL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal KCDOIHAGKBG<LJHGCPKIAKM, FOHCGPGJJDE> CHABJKOGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KCDOIHAGKBG<NOPHHKDGBBP, ABELFOFPMIJ> PMKIFFNCBJM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC550", Offset = "0x1FFB950", VA = "0x181FFC550")]
	private MMBPEFLHLBP([In] KCDOIHAGKBG<LJHGCPKIAKM, FOHCGPGJJDE> NCLIOLKCBMO, [In] KCDOIHAGKBG<NOPHHKDGBBP, ABELFOFPMIJ> PDNKFKGDIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE040", Offset = "0x1FFD440", VA = "0x181FFE040")]
	public static MMBPEFLHLBP DDEJLDFANAB()
	{
		return default(MMBPEFLHLBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GAEHJBGCFGE
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCB20", Offset = "0x1FFBF20", VA = "0x181FFCB20")]
	public static void CDBCEOANHGG(this MMBPEFLHLBP ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BCJGIBFECDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public PCPLEDLJHDN<int> CPLNMBLGOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public PCPLEDLJHDN<int> NKBECDFANNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PPFMOGHHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JJEIIMAKHBH;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9B30", Offset = "0x1FF8F30", VA = "0x181FF9B30")]
	private BCJGIBFECDP([In] PCPLEDLJHDN<int> AAHPHMMFAEI, [In] PCPLEDLJHDN<int> GBKMHPFBDLH, int PJFJDLHPAIA, int AHIBJLNCMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9A90", Offset = "0x1FF8E90", VA = "0x181FF9A90")]
	public static BCJGIBFECDP DDEJLDFANAB()
	{
		return default(BCJGIBFECDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IFGDNNFGJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCFA0", Offset = "0x1FFC3A0", VA = "0x181FFCFA0")]
	public static void CDBCEOANHGG(this BCJGIBFECDP ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GEHAAGIBICC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum LGNLGBPKIBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class LPJCFMIBMEN : BMJPCAHENIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct FMCNHOHPPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DFKPAEMPCKH<BPIBIHJHBNG> IOMDCJJGFAG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public FMCNHOHPPKB(DFKPAEMPCKH<BPIBIHJHBNG> BADMCOPAFJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class FGIHNNEKPHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class BMJPCAHENIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct FOJNDOBIAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly LGNLGBPKIBP FOACFDODIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly DFKPAEMPCKH<BMJPCAHENIO> KLAPHPOCEPC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		private FOJNDOBIAJD(LGNLGBPKIBP DFLGBFHHDID, DFKPAEMPCKH<BMJPCAHENIO> KMLNNJBOKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCB10", Offset = "0x1FFBF10", VA = "0x181FFCB10")]
		public static FOJNDOBIAJD DDEJLDFANAB(LGNLGBPKIBP DFLGBFHHDID, DFKPAEMPCKH<BMJPCAHENIO> KMLNNJBOKOL)
		{
			return default(FOJNDOBIAJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class ENLOMKLBGAF : BMJPCAHENIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct OBEGAGDDNBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly DFKPAEMPCKH<BPIBIHJHBNG> IOMDCJJGFAG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public OBEGAGDDNBD(DFKPAEMPCKH<BPIBIHJHBNG> BADMCOPAFJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BPIBIHJHBNG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct EFDIKKFNLLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PCPLEDLJHDN<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> LNGEFNODJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PCPLEDLJHDN<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> CBCJHANGNAN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC550", Offset = "0x1FFB950", VA = "0x181FFC550")]
		private EFDIKKFNLLA([In] PCPLEDLJHDN<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> OELDEOCNNMP, [In] PCPLEDLJHDN<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> CBDJJKGKGMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC4D0", Offset = "0x1FFB8D0", VA = "0x181FFC4D0")]
		public static EFDIKKFNLLA DDEJLDFANAB()
		{
			return default(EFDIKKFNLLA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal KCDOIHAGKBG<FGIHNNEKPHC, FOJNDOBIAJD> CHABJKOGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal KCDOIHAGKBG<ENLOMKLBGAF, OBEGAGDDNBD> DAJLMIPCPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal KCDOIHAGKBG<LPJCFMIBMEN, FMCNHOHPPKB> LIKJFHNHKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal PCPLEDLJHDN<(DFKPAEMPCKH<FGIHNNEKPHC> CallId, DFKPAEMPCKH<BPIBIHJHBNG> IOId)> OBMKBLLAJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KCDOIHAGKBG<BPIBIHJHBNG, EFDIKKFNLLA> BPPLDJDFENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal AEOJAEFAFAE<BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> DBCMBLCBDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal AEOJAEFAFAE<BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> KOCEJAICILA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCD40", Offset = "0x1FFC140", VA = "0x181FFCD40")]
	private GEHAAGIBICC([In] KCDOIHAGKBG<FGIHNNEKPHC, FOJNDOBIAJD> NCLIOLKCBMO, [In] KCDOIHAGKBG<ENLOMKLBGAF, OBEGAGDDNBD> BABNHKIPJOO, [In] KCDOIHAGKBG<LPJCFMIBMEN, FMCNHOHPPKB> DAPKOLIILHO, [In] PCPLEDLJHDN<(DFKPAEMPCKH<FGIHNNEKPHC> CallId, DFKPAEMPCKH<BPIBIHJHBNG> IOId)> FBIEODOOCIA, [In] KCDOIHAGKBG<BPIBIHJHBNG, EFDIKKFNLLA> IELFFOKLDMK, [In] AEOJAEFAFAE<BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> EFFCGOFJGBD, [In] AEOJAEFAFAE<BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> CINDPNOGEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCBA0", Offset = "0x1FFBFA0", VA = "0x181FFCBA0")]
	public static GEHAAGIBICC DDEJLDFANAB()
	{
		return default(GEHAAGIBICC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MOMBJHIHFIM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE2E0", Offset = "0x1FFD6E0", VA = "0x181FFE2E0")]
	private static void CDBCEOANHGG(this GEHAAGIBICC.EFDIKKFNLLA ABPJKOBADEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE0D0", Offset = "0x1FFD4D0", VA = "0x181FFE0D0")]
	public static void CDBCEOANHGG(this GEHAAGIBICC ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NDLOJHJLJEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public PCPLEDLJHDN<byte> IHKLCOHIAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal GEHAAGIBICC FLNCJEJHGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal KCAJOOFHEEB JFLDLJKNPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> IAOBAOJPADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FDKMCDBBMJE IDIAGFNAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal MMBPEFLHLBP BADIOAHBALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>?> GJFHIDCKDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> CPKOBEDCEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> IGEOBNIDOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> DJHGMPJICAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> KMLELBLFHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal JHNBKMDPEMG OPLMHMGIDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EIOOCMNDFOL BKMIFMOLNEN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2004130", Offset = "0x2003530", VA = "0x182004130")]
	private NDLOJHJLJEA([In] PCPLEDLJHDN<byte> ICIONHOPMDE, [In] GEHAAGIBICC NNAJCLICBBE, [In] KCAJOOFHEEB PFEPKKLELDA, [In] FDKMCDBBMJE BEECICMKIBC, [In] MMBPEFLHLBP NNJJNNGOKLG, [In] AEOJAEFAFAE<ADOPGBMODDE, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>?> OPGDJLILIEH, [In] PCPLEDLJHDN<DFKPAEMPCKH<ADOPGBMODDE>> EOGNIFPMOCK, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> IAOBOKEEDGJ, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> HMMPJAGKDMO, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> AEMBNMNGODI, [In] JHNBKMDPEMG OJHCBCDMJGO, [In] EIOOCMNDFOL CPHFIIFBOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2003670", Offset = "0x2002A70", VA = "0x182003670")]
	public static NDLOJHJLJEA DDEJLDFANAB()
	{
		return default(NDLOJHJLJEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BLAICLHGICD
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct HNFLFLELMLB : GGLEDOPJLDH<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCEF0", Offset = "0x1FFC2F0", VA = "0x181FFCEF0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCEC0", Offset = "0x1FFC2C0", VA = "0x181FFCEC0", Slot = "4")]
		public DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		public bool JPPBEGCGIDI(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "5")]
		private bool ONPALDBOOLG(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCEB0", Offset = "0x1FFC2B0", VA = "0x181FFCEB0", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> DHOHIPADPGI(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct ODPBIDHCPAE : NPMBPIDPLMI<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2004520", Offset = "0x2003920", VA = "0x182004520")]
		public PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> KDJOELNMHDB(int DFICMCEEFEN, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2004650", Offset = "0x2003A50", VA = "0x182004650")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2004590", Offset = "0x2003990", VA = "0x182004590", Slot = "6")]
		public void DOIKFOCOIHM(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2004520", Offset = "0x2003920", VA = "0x182004520", Slot = "4")]
		private PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> DJGGHBNDNCA(int DFICMCEEFEN, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2004700", Offset = "0x2003B00", VA = "0x182004700", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> GHCADFOKHOF(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct LHJMLLDKLKH : GGLEDOPJLDH<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDEC0", Offset = "0x1FFD2C0", VA = "0x181FFDEC0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDE90", Offset = "0x1FFD290", VA = "0x181FFDE90", Slot = "4")]
		public DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		public bool JPPBEGCGIDI(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "5")]
		private bool OHBJCOPLOHL(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDE80", Offset = "0x1FFD280", VA = "0x181FFDE80", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> CLBNNMMAFGN(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct EGGOIMKBLAF : NPMBPIDPLMI<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC710", Offset = "0x1FFBB10", VA = "0x181FFC710")]
		public PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> KDJOELNMHDB(int DFICMCEEFEN, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC650", Offset = "0x1FFBA50", VA = "0x181FFC650")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC590", Offset = "0x1FFB990", VA = "0x181FFC590", Slot = "6")]
		public void DOIKFOCOIHM(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC710", Offset = "0x1FFBB10", VA = "0x181FFC710", Slot = "4")]
		private PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> MKBAGDDJICO(int DFICMCEEFEN, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC700", Offset = "0x1FFBB00", VA = "0x181FFC700", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> GHJHAPEOIEK(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> AGAGKNBDCIG, [In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct ILAINJJLJIL : GGLEDOPJLDH<DFKPAEMPCKH<OGMOCINGCKO>, AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD0A0", Offset = "0x1FFC4A0", VA = "0x181FFD0A0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD070", Offset = "0x1FFC470", VA = "0x181FFD070", Slot = "4")]
		public DFKPAEMPCKH<OGMOCINGCKO> EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(DFKPAEMPCKH<OGMOCINGCKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCFF0", Offset = "0x1FFC3F0", VA = "0x181FFCFF0")]
		public bool JPPBEGCGIDI(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCFF0", Offset = "0x1FFC3F0", VA = "0x181FFCFF0", Slot = "5")]
		private bool CJMKKDEJNLE(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD170", Offset = "0x1FFC570", VA = "0x181FFD170", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> KBONBMFEMDP(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AOHFJLHEEFL : NPMBPIDPLMI<DFKPAEMPCKH<OGMOCINGCKO>, AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9A20", Offset = "0x1FF8E20", VA = "0x181FF9A20")]
		public PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> KDJOELNMHDB(int DFICMCEEFEN, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9950", Offset = "0x1FF8D50", VA = "0x181FF9950")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9870", Offset = "0x1FF8C70", VA = "0x181FF9870", Slot = "6")]
		public void DOIKFOCOIHM(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9A20", Offset = "0x1FF8E20", VA = "0x181FF9A20", Slot = "4")]
		private PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>> FIMIPIOIHIJ(int DFICMCEEFEN, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<DFKPAEMPCKH<OGMOCINGCKO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9860", Offset = "0x1FF8C60", VA = "0x181FF9860", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> DDGOIAEKAOL(DFKPAEMPCKH<OGMOCINGCKO> AGAGKNBDCIG, [In] AEOJAEFAFAE<OGMOCINGCKO, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>?> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct AKGFGBFLDAN : GGLEDOPJLDH<int, PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FF97B0", Offset = "0x1FF8BB0", VA = "0x181FF97B0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x14716F0", Offset = "0x1470AF0", VA = "0x1814716F0", Slot = "4")]
		public int EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		public bool JPPBEGCGIDI(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "5")]
		private bool EFEEJOHKPHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9850", Offset = "0x1FF8C50", VA = "0x181FF9850", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FLIIHJFLCKO(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct BNDONFCPDKM : NPMBPIDPLMI<int, PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC2B0", Offset = "0x1FFB6B0", VA = "0x181FFC2B0")]
		public PCPLEDLJHDN<int> KDJOELNMHDB(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC420", Offset = "0x1FFB820", VA = "0x181FFC420")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC320", Offset = "0x1FFB720", VA = "0x181FFC320", Slot = "6")]
		public void DOIKFOCOIHM(int AGAGKNBDCIG, PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC2B0", Offset = "0x1FFB6B0", VA = "0x181FFC2B0", Slot = "4")]
		private PCPLEDLJHDN<int> DHEDJKEJPNO(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC4C0", Offset = "0x1FFB8C0", VA = "0x181FFC4C0", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> MBHIOECBHMC(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> VariableId, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<OMICMMHGCKE>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct BMPEPEONOGE : GGLEDOPJLDH<int, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC210", Offset = "0x1FFB610", VA = "0x181FFC210")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x14716F0", Offset = "0x1470AF0", VA = "0x1814716F0", Slot = "4")]
		public int EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		public bool JPPBEGCGIDI(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "5")]
		private bool KHCADDEIJED(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC200", Offset = "0x1FFB600", VA = "0x181FFC200", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> EFMCMIMGONJ(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct JLAKPMPEBGA : NPMBPIDPLMI<int, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD650", Offset = "0x1FFCA50", VA = "0x181FFD650")]
		public PCPLEDLJHDN<int> KDJOELNMHDB(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD5B0", Offset = "0x1FFC9B0", VA = "0x181FFD5B0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD4C0", Offset = "0x1FFC8C0", VA = "0x181FFD4C0", Slot = "6")]
		public void DOIKFOCOIHM(int AGAGKNBDCIG, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD650", Offset = "0x1FFCA50", VA = "0x181FFD650", Slot = "4")]
		private PCPLEDLJHDN<int> NLJNJLMJIKM(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD4B0", Offset = "0x1FFC8B0", VA = "0x181FFD4B0", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> BOLBJJOIOIK(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct GPPAMCOPIFF : GGLEDOPJLDH<int, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCE10", Offset = "0x1FFC210", VA = "0x181FFCE10")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x14716F0", Offset = "0x1470AF0", VA = "0x1814716F0", Slot = "4")]
		public int EDDPBAHONFL(int AGAGKNBDCIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		public bool JPPBEGCGIDI(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "5")]
		private bool KHCADDEIJED(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCE00", Offset = "0x1FFC200", VA = "0x181FFCE00", Slot = "6")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> EFMCMIMGONJ(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct JOJPKAAJBPB : NPMBPIDPLMI<int, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD870", Offset = "0x1FFCC70", VA = "0x181FFD870")]
		public PCPLEDLJHDN<int> KDJOELNMHDB(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD7D0", Offset = "0x1FFCBD0", VA = "0x181FFD7D0")]
		public DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD6D0", Offset = "0x1FFCAD0", VA = "0x181FFD6D0", Slot = "6")]
		public void DOIKFOCOIHM(int AGAGKNBDCIG, PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD870", Offset = "0x1FFCC70", VA = "0x181FFD870", Slot = "4")]
		private PCPLEDLJHDN<int> NLJNJLMJIKM(int DFICMCEEFEN, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(PCPLEDLJHDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD6C0", Offset = "0x1FFCAC0", VA = "0x181FFD6C0", Slot = "5")]
		private DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> BOLBJJOIOIK(int AGAGKNBDCIG, [In] PCPLEDLJHDN<(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> Target, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> ByteCodeWriteLocation)> FJJNGLOPNDO)
		{
			return default(DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct PBLEIEBLGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ADOGGOLEBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool LKOLOEMJPCJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1286730", Offset = "0x1285B30", VA = "0x181286730")]
		public PBLEIEBLGJL(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, bool FDCBHICOGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2004710", Offset = "0x2003B10", VA = "0x182004710")]
		public void JJDJPLPGAPJ([Out] DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, [Out] bool FDCBHICOGGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct MLHEEAPLHDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DFKPAEMPCKH<OGMOCINGCKO> IMGBOCJIGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ADOGGOLEBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool LKOLOEMJPCJ;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE030", Offset = "0x1FFD430", VA = "0x181FFE030")]
		public MLHEEAPLHDK(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, bool FDCBHICOGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE000", Offset = "0x1FFD400", VA = "0x181FFE000")]
		public void JJDJPLPGAPJ([Out] DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, [Out] bool FDCBHICOGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FFE010", Offset = "0x1FFD410", VA = "0x181FFE010")]
		public void JJDJPLPGAPJ([Out] DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, [Out] DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA, [Out] bool FDCBHICOGGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NOJLODDHADB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly DFKPAEMPCKH<OGMOCINGCKO> IMGBOCJIGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ADOGGOLEBAP;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		public NOJLODDHADB(DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2004490", Offset = "0x2003890", VA = "0x182004490")]
		public void JJDJPLPGAPJ([Out] DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO, [Out] DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA360", Offset = "0x1FF9760", VA = "0x181FFA360")]
	public static void CDBCEOANHGG(this NDLOJHJLJEA ABPJKOBADEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAA00", Offset = "0x1FF9E00", VA = "0x181FFAA00")]
	public static void EMONNBDCGEI(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> IEBOGLKEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB00", Offset = "0x1FFAF00", VA = "0x181FFBB00")]
	public static void LPGBDNEAJFE(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> IEBOGLKEPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB7F0", Offset = "0x1FFABF0", VA = "0x181FFB7F0")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>? LCBANDAFNHC([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA030", Offset = "0x1FF9430", VA = "0x181FFA030")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> AJADNCEJLOB([In] this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB320", Offset = "0x1FFA720", VA = "0x181FFB320")]
	private static void KGHEMNOMAJK(this NDLOJHJLJEA ABPJKOBADEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9B90", Offset = "0x1FF8F90", VA = "0x181FF9B90")]
	private static DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>? AAGIMMPBPDI([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAF10", Offset = "0x1FFA310", VA = "0x181FFAF10")]
	public static void IKODBKBFOHA(this NDLOJHJLJEA ABPJKOBADEP, [In] PCPLEDLJHDN<FFBNLHDDCOA> FIBHHIPIBDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA2E0", Offset = "0x1FF96E0", VA = "0x181FFA2E0")]
	public static FDKMCDBBMJE.EKGPIHKJBPF CABHLJDDOED([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(FDKMCDBBMJE.EKGPIHKJBPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC0D0", Offset = "0x1FFB4D0", VA = "0x181FFC0D0")]
	public static PKPFALODBMP<byte> PCBLJLJODCE([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(PKPFALODBMP<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA910", Offset = "0x1FF9D10", VA = "0x181FFA910")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EMHIHEEAGPL([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA760", Offset = "0x1FF9B60", VA = "0x181FFA760")]
	public static KOIDIICODKL DDAELLBFCPP([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(KOIDIICODKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x28ECD50", Offset = "0x28EC150", VA = "0x1828ECD50")]
	private static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> PMLFDAIKILB<TMJoin>(this NDLOJHJLJEA ABPJKOBADEP, FDKMCDBBMJE.EKGPIHKJBPF DFLGBFHHDID, DFKPAEMPCKH<TMJoin> KMLNNJBOKOL) where TMJoin : FDKMCDBBMJE.GNHIDOIJDLD
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBBD0", Offset = "0x1FFAFD0", VA = "0x181FFBBD0")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> NHPHELNFPDD(this NDLOJHJLJEA ABPJKOBADEP, bool KIPOKLHKAFO)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA250", Offset = "0x1FF9650", VA = "0x181FFA250")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> BHNJICMBNCO(this NDLOJHJLJEA ABPJKOBADEP, PKPFALODBMP<byte> PLMCKIPFEOJ)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA6A0", Offset = "0x1FF9AA0", VA = "0x181FFA6A0")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> CHBEFMLOCCC(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> BJEDMELKPAK)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA090", Offset = "0x1FF9490", VA = "0x181FFA090")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> BBMLGGDGFGD(this NDLOJHJLJEA ABPJKOBADEP, int GFPGLMLKMCI)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBEB0", Offset = "0x1FFB2B0", VA = "0x181FFBEB0")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> OIPOHDHCAHH(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28EAF50", Offset = "0x28EA350", VA = "0x1828EAF50")]
	private static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> BMLMFPAOCMN<TMJoin>(this NDLOJHJLJEA ABPJKOBADEP, MMBPEFLHLBP.NBGAHACMJNF DFLGBFHHDID, DFKPAEMPCKH<TMJoin> KMLNNJBOKOL) where TMJoin : MMBPEFLHLBP.GHNODFJBCNM
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAE50", Offset = "0x1FFA250", VA = "0x181FFAE50")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> HFJFDGDKJNG(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA720", Offset = "0x1FF9B20", VA = "0x181FFA720")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> CLPOAMBMEEM(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA890", Offset = "0x1FF9C90", VA = "0x181FFA890")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> EGMAPIBHFNP(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> EFPKMBNDDMF)
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA850", Offset = "0x1FF9C50", VA = "0x181FFA850")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> EBCAPPFLLHC(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC1C0", Offset = "0x1FFB5C0", VA = "0x181FFC1C0")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> PECDIFPLHMB(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9DE0", Offset = "0x1FF91E0", VA = "0x181FF9DE0")]
	public static GEHAAGIBICC.LGNLGBPKIBP ADCOPJCKPGP([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG)
	{
		return default(GEHAAGIBICC.LGNLGBPKIBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBDA0", Offset = "0x1FFB1A0", VA = "0x181FFBDA0")]
	public static JHKHMDNDIMN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, GNBDNDFBODH<GEHAAGIBICC.BPIBIHJHBNG>> ODOJPIFLBBB([In] this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(JHKHMDNDIMN<DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>, GNBDNDFBODH<GEHAAGIBICC.BPIBIHJHBNG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB490", Offset = "0x1FFA890", VA = "0x181FFB490")]
	public static DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> KHMAJLMIKJJ([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG)
	{
		return default(DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB080", Offset = "0x1FFA480", VA = "0x181FFB080")]
	public static GEHAAGIBICC.EFDIKKFNLLA JEGIFNMIIEH([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> BADMCOPAFJC)
	{
		return default(GEHAAGIBICC.EFDIKKFNLLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAE90", Offset = "0x1FFA290", VA = "0x181FFAE90")]
	public static GEHAAGIBICC.EFDIKKFNLLA HPABLNNBNED(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> BADMCOPAFJC)
	{
		return default(GEHAAGIBICC.EFDIKKFNLLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28EB000", Offset = "0x28EA400", VA = "0x1828EB000")]
	private static DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CNMEDAOEGCL<TMJoin>(this NDLOJHJLJEA ABPJKOBADEP, GEHAAGIBICC.LGNLGBPKIBP DFLGBFHHDID, DFKPAEMPCKH<TMJoin> KMLNNJBOKOL) where TMJoin : GEHAAGIBICC.BMJPCAHENIO
	{
		return default(DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9E60", Offset = "0x1FF9260", VA = "0x181FF9E60")]
	public static (DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>) AIMIACHDIGC(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default((DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAC30", Offset = "0x1FFA030", VA = "0x181FFAC30")]
	public static (DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>) GIHCPMKPKCB(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default((DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBDE0", Offset = "0x1FFB1E0", VA = "0x181FFBDE0")]
	public static DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> OFMOKILJMCP(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB670", Offset = "0x1FFAA70", VA = "0x181FFB670")]
	public static void KIHCBOOGKHK(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG> BADMCOPAFJC, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> DFNICIDCANF, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>> AGFPIJLMONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28EB780", Offset = "0x28EAB80", VA = "0x1828EB780")]
	public static PBLEIEBLGJL JPJMDFIKLPF<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA) where TDeps : IPBHCDGMJLI<TStateSys>
	{
		return default(PBLEIEBLGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28EB0A0", Offset = "0x28EA4A0", VA = "0x1828EB0A0")]
	public static MLHEEAPLHDK COGDCFBCBCA<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, int OGEMJMHDFLE) where TDeps : IPBHCDGMJLI<TStateSys>
	{
		return default(MLHEEAPLHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x28EB340", Offset = "0x28EA740", VA = "0x1828EB340")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>? DCHLANIPCNE<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, [In] ReadOnlySpan<int> FGMIJECMMAB, [In] Span<NOJLODDHADB> IPEHAIHDAGA) where TDeps : IPBHCDGMJLI<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28EC780", Offset = "0x28EBB80", VA = "0x1828EC780")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> PLPEHEEHDJI<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL) where TDeps : IPBHCDGMJLI<TStateSys>
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBFE0", Offset = "0x1FFB3E0", VA = "0x181FFBFE0")]
	public static KCAJOOFHEEB.CMKFGKLHGIK PBKCMJHOCMG([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return default(KCAJOOFHEEB.CMKFGKLHGIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBCB0", Offset = "0x1FFB0B0", VA = "0x181FFBCB0")]
	public static KCAJOOFHEEB.BMPLGCCOOFB OCGADHOKKAN([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return default(KCAJOOFHEEB.BMPLGCCOOFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB700", Offset = "0x1FFAB00", VA = "0x181FFB700")]
	public static KCAJOOFHEEB.BGLGLEOKJCO LBONEMKLIHK([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return default(KCAJOOFHEEB.BGLGLEOKJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9C50", Offset = "0x1FF9050", VA = "0x181FF9C50")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ABKNHJJLPMG(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH, string FIKHOKLHCII)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB980", Offset = "0x1FFAD80", VA = "0x181FFB980")]
	public static KCAJOOFHEEB.OHOBBKGJJIG LNEFCDEIPEK([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return default(KCAJOOFHEEB.OHOBBKGJJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFABC0", Offset = "0x1FF9FC0", VA = "0x181FFABC0")]
	public static KCAJOOFHEEB.GMJLCEGNHLE GEPLDNJAEGC([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return default(KCAJOOFHEEB.GMJLCEGNHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA630", Offset = "0x1FF9A30", VA = "0x181FFA630")]
	public static int? CGGLJCMEDBK([In] this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GNBDDFJPEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28EC680", Offset = "0x28EBA80", VA = "0x1828EC680")]
	private static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LGBHIGNEMHD<TMJoin>(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH, KCAJOOFHEEB.GMJLCEGNHLE DFLGBFHHDID, DFKPAEMPCKH<TMJoin> KMLNNJBOKOL) where TMJoin : KCAJOOFHEEB.POFACFAAEPG
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBF30", Offset = "0x1FFB330", VA = "0x181FFBF30")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OMKIOLPHBNL(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG, int AGAGKNBDCIG)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBC50", Offset = "0x1FFB050", VA = "0x181FFBC50")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NKAPINJHNAL(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB1D0", Offset = "0x1FFA5D0", VA = "0x181FFB1D0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KDEJBLDDCMO(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? DKPFMODHPLC, int? BLBDJHDIMPH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBA70", Offset = "0x1FFAE70", VA = "0x181FFBA70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LPAGPAFOAAJ(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH, int AGAGKNBDCIG)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FFADF0", Offset = "0x1FFA1F0", VA = "0x181FFADF0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> HBIIOJJPFOI(this NDLOJHJLJEA ABPJKOBADEP, int? BLBDJHDIMPH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA110", Offset = "0x1FF9510", VA = "0x181FFA110")]
	public static void BFCAAAKBHHN(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG, int AGAGKNBDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAA90", Offset = "0x1FF9E90", VA = "0x181FFAA90")]
	public static void FJOKHLPIFOM(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF, int AGAGKNBDCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB8B0", Offset = "0x1FFACB0", VA = "0x181FFB8B0")]
	public static void LFPPDDMGKKC(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBE20", Offset = "0x1FFB220", VA = "0x181FFBE20")]
	public static void OGMHDPMFGNF(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> KMCPIOGEAKL, DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> NJIEFKEJLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB100", Offset = "0x1FFA500", VA = "0x181FFB100")]
	public static void KAIEDGEALOJ(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF, DFKPAEMPCKH<MHCHLGAGEPI<FBKCAOEEMFC>> NCDPKIFENJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28EC5B0", Offset = "0x28EB9B0", VA = "0x1828EC5B0")]
	public static void KMBGKCDOBNN<M>(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACCHLADIJIF, DFKPAEMPCKH<MHCHLGAGEPI<IKPMLKELNKD<M>>> NCDPKIFENJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IPBHCDGMJLI<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFKPAEMPCKH<LMIGEMJAMLD> FNLNDFJBDNK(TStateSys FMLBHLJOALH);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKPAEMPCKH<LMIGEMJAMLD> AFIJLELJEMO(TStateSys FMLBHLJOALH);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DFKPAEMPCKH<LMIGEMJAMLD> PNLHMKIHOKK(TStateSys FMLBHLJOALH);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DFKPAEMPCKH<LMIGEMJAMLD> GBHENFCDJFJ(TStateSys FMLBHLJOALH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> DCLPOIEIMKJ(TStateSys FMLBHLJOALH, NDLOJHJLJEA ACPICEINECI, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> JIHDEFOBEAL(TStateSys FMLBHLJOALH, NDLOJHJLJEA ACPICEINECI, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LHEMPAMDCAN(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DFKPAEMPCKH<ADOPGBMODDE> NACNPGIAMJA(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA, int OCOBGNMIFDP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BCMDHBHPLLF LNACGPKOENL(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OAMEEOPEIOM(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int GLJKLPABHOH(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PKPFALODBMP<byte> LGLAOCFKGIB(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(PKPFALODBMP<byte>, DFKPAEMPCKH<LMIGEMJAMLD>) LHANOELEENH(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<OGMOCINGCKO> OBINEBNCEJA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int BAKOGGAJCDJ(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DFKPAEMPCKH<OGMOCINGCKO> IEKEADLLNBK(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<ADOPGBMODDE> HOLPDNLGFNL, int OGEMJMHDFLE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFKPAEMPCKH<OGMOCINGCKO> MBHFJMOOPAF(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, DFKPAEMPCKH<CEAIECNFGDF> PGFJMICDDIK, int OGEMJMHDFLE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int AHNAAENABAL(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IFLBGLNGJHF(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int GOBLOIBIPDB(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? IBBHDFDHHBL(TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM, int AGAGKNBDCIG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NBLDJKLLICC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD65D0", Offset = "0x2CD59D0", VA = "0x182CD65D0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI?> BPPNMACBOFK<T, TOpInput, TOpOutput>(this NDLOJHJLJEA ABPJKOBADEP, T LJHBAHCCIGM, T EFOLFMFJLOF, int BEDEMOIAIGC, IntPtr IHGGKNHIMDL)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8B50", Offset = "0x2CD7F50", VA = "0x182CD8B50")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI?> OJFGEFMGMAI<T, TOpInput, TOpOutput>(this NDLOJHJLJEA ABPJKOBADEP, T LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF, int BEDEMOIAIGC, IntPtr IHGGKNHIMDL)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8090", Offset = "0x2CD7490", VA = "0x182CD8090")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI?> JEKEIOOOONM<TOpInput, TOpOutput>(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF, int BEDEMOIAIGC, IntPtr IHGGKNHIMDL)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF1D0", Offset = "0x1FFE5D0", VA = "0x181FFF1D0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> DCLOLLMPGFF(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF370", Offset = "0x1FFE770", VA = "0x181FFF370")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> DNAEKKIGNIC(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2003530", Offset = "0x2002930", VA = "0x182003530")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> PPAGIMIMLCK(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE970", Offset = "0x1FFDD70", VA = "0x181FFE970")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> BFJLGOLGPIL(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20025E0", Offset = "0x20019E0", VA = "0x1820025E0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LOLMBBOACDH(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2000380", Offset = "0x1FFF780", VA = "0x182000380")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FGADJPMDFGN(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2002470", Offset = "0x2001870", VA = "0x182002470")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KOBLLOIGAEP(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2003310", Offset = "0x2002710", VA = "0x182003310")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> PFPKONIFOPD(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF490", Offset = "0x1FFE890", VA = "0x181FFF490")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> DOJELKDPGOH(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFC00", Offset = "0x1FFF000", VA = "0x181FFFC00")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ELCMFPBJACO(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, int EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2001EC0", Offset = "0x20012C0", VA = "0x182001EC0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> JJLBCADHFKF(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE830", Offset = "0x1FFDC30", VA = "0x181FFE830")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> AOHMPIFDADG(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFB00", Offset = "0x1FFEF00", VA = "0x181FFFB00")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EKMNGCEHPCM(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, float EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2001FE0", Offset = "0x20013E0", VA = "0x182001FE0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> JKBCNMDEKDF(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2002D70", Offset = "0x2002170", VA = "0x182002D70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NOEIEBALKIM(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2000C50", Offset = "0x2000050", VA = "0x182000C50")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> GILJAOIBKAH(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, int EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2000CF0", Offset = "0x20000F0", VA = "0x182000CF0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> HDLOMHIHNEP(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF800", Offset = "0x1FFEC00", VA = "0x181FFF800")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EEMKECFBCPJ(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF5D0", Offset = "0x1FFE9D0", VA = "0x181FFF5D0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> DPJEMFNKHDB(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, float EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2000A10", Offset = "0x1FFFE10", VA = "0x182000A10")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FOGABMIDJIB(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE3E0", Offset = "0x1FFD7E0", VA = "0x181FFE3E0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> AAFFEPIPAFA(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE6C0", Offset = "0x1FFDAC0", VA = "0x181FFE6C0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> AIFMPLNLJFM(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, int EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2002560", Offset = "0x2001960", VA = "0x182002560")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KOILGAPPGPC(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2002350", Offset = "0x2001750", VA = "0x182002350")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KEJGJEOJBMD(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2001790", Offset = "0x2000B90", VA = "0x182001790")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ILFIPKMMLIB(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, float EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF150", Offset = "0x1FFE550", VA = "0x181FFF150")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CODGCOFJICM(this NDLOJHJLJEA ABPJKOBADEP, float LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2002940", Offset = "0x2001D40", VA = "0x182002940")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NALIDECNCHA(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20030A0", Offset = "0x20024A0", VA = "0x1820030A0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> PCDGLKHGFMF(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF0D0", Offset = "0x1FFE4D0", VA = "0x181FFF0D0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> CMIHIMADLHG(this NDLOJHJLJEA ABPJKOBADEP, int OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20023D0", Offset = "0x20017D0", VA = "0x1820023D0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> KHDNMGHKBON(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF650", Offset = "0x1FFEA50", VA = "0x181FFF650")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> EBDIMJKIDEC(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> ODHOAOJCEHO)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2000BD0", Offset = "0x1FFFFD0", VA = "0x182000BD0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> GFPNHJPPAPB(this NDLOJHJLJEA ABPJKOBADEP, int OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF2D0", Offset = "0x1FFE6D0", VA = "0x181FFF2D0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> DMELOBFEGEJ(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFCF0", Offset = "0x1FFF0F0", VA = "0x181FFFCF0")]
	public static (DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>) EMLHKJBDEKI(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<EHPHFEHIOBB> EPPMAHLNCAC, [In] ReadOnlySpan<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> OELDEOCNNMP, [In] ReadOnlySpan<int?> IECFIFMOCDP, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> NGKJMNHAJPO)
	{
		return default((DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2000F90", Offset = "0x2000390", VA = "0x182000F90")]
	public static (DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>) IHPLIBOOPMB(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<ALBOPLJHKOM> EFNPGHHEBAB, [In] ReadOnlySpan<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> OELDEOCNNMP, [In] ReadOnlySpan<int?> IECFIFMOCDP, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> NGKJMNHAJPO)
	{
		return default((DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6D70", Offset = "0x2CD6170", VA = "0x182CD6D70")]
	public static (DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>) DNNLIBKFOGA<TMarker>(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<LMIGEMJAMLD> MOODEIAPIJP, [In] ReadOnlySpan<byte> LDNEPNAGEGN)
	{
		return default((DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<MHCHLGAGEPI<LMIGEMJAMLD>>, DFKPAEMPCKH<MHCHLGAGEPI<PJBCDDGDFDM>>, DFKPAEMPCKH<MHCHLGAGEPI<TMarker>>, DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2003250", Offset = "0x2002650", VA = "0x182003250")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> PCFOGAOMPKE(this NDLOJHJLJEA ABPJKOBADEP, int FIJIJLPKIHA, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2001950", Offset = "0x2000D50", VA = "0x182001950")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> IOGFJFELCII(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FIJIJLPKIHA, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20029C0", Offset = "0x2001DC0", VA = "0x1820029C0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NEEDCMOIJPL(this NDLOJHJLJEA ABPJKOBADEP, [In] ReadOnlySpan<byte> FIJIJLPKIHA, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20007C0", Offset = "0x1FFFBC0", VA = "0x1820007C0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FLGAILPNDGI(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FIJIJLPKIHA, int CGDIEJGGJMK, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2002C70", Offset = "0x2002070", VA = "0x182002C70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NIOCMMAMNDI(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20008E0", Offset = "0x1FFFCE0", VA = "0x1820008E0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FLPLEADFMJH(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2000A90", Offset = "0x1FFFE90", VA = "0x182000A90")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FOIHNGIHABL(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2000290", Offset = "0x1FFF690", VA = "0x182000290")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FDMLPBHJLEJ(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2000E70", Offset = "0x2000270", VA = "0x182000E70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> IBJBJJCIJJB(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF880", Offset = "0x1FFEC80", VA = "0x181FFF880")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EGBIDAFCEGB(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2002FA0", Offset = "0x20023A0", VA = "0x182002FA0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OJKKMLCBGOG(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, int EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2003020", Offset = "0x2002420", VA = "0x182003020")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OPCNBDPKLOH(this NDLOJHJLJEA ABPJKOBADEP, int LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2002AB0", Offset = "0x2001EB0", VA = "0x182002AB0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NGGKFCKLNOH(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LJHBAHCCIGM, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EFOLFMFJLOF)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2003430", Offset = "0x2002830", VA = "0x182003430")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> POLJIEKHLIB(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2001D90", Offset = "0x2001190", VA = "0x182001D90")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> JIGONOIKPLB(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEC80", Offset = "0x1FFE080", VA = "0x181FFEC80")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CDIANAHCIIC(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2002EB0", Offset = "0x20022B0", VA = "0x182002EB0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NPPBGKCMING(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2002820", Offset = "0x2001C20", VA = "0x182002820")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> MEENBKODGLO(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2002B30", Offset = "0x2001F30", VA = "0x182002B30")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> NILHFCHAGMG(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2000CD0", Offset = "0x20000D0", VA = "0x182000CD0")]
	public static DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>> GPKCFGNMMAA(this NDLOJHJLJEA ABPJKOBADEP)
	{
		return default(DFKPAEMPCKH<MHCHLGAGEPI<MHCHLGAGEPI<OLJMCCBPJLK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEB80", Offset = "0x1FFDF80", VA = "0x181FFEB80")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CDCMABGDFHK(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE460", Offset = "0x1FFD860", VA = "0x181FFE460")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> ACLNJDJGIAO(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF9C0", Offset = "0x1FFEDC0", VA = "0x181FFF9C0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> EJHHHLGPCPB(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEDC0", Offset = "0x1FFE1C0", VA = "0x181FFEDC0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CEENIMGLONO(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2001C70", Offset = "0x2001070", VA = "0x182001C70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> JGOAACGJKOF(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2001810", Offset = "0x2000C10", VA = "0x182001810")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> IMNPNDALBIF(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2000D70", Offset = "0x2000170", VA = "0x182000D70")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> HMPONLFMEGI(this NDLOJHJLJEA ABPJKOBADEP, int OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2002240", Offset = "0x2001640", VA = "0x182002240")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KAMHMEHAKJE(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> OBEEJPGJPFD)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2000A00", Offset = "0x1FFFE00", VA = "0x182000A00")]
	public static void FOFMKFKBOPJ(this NDLOJHJLJEA ABPJKOBADEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEFD0", Offset = "0x1FFE3D0", VA = "0x181FFEFD0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CGNNAFJCEGH(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, float LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2002700", Offset = "0x2001B00", VA = "0x182002700")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> MACCFBOGFLJ(this NDLOJHJLJEA ABPJKOBADEP, float KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2001A40", Offset = "0x2000E40", VA = "0x182001A40")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> IPIFIMOLALI(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE740", Offset = "0x1FFDB40", VA = "0x181FFE740")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> AJKKGDEEGHN(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEA60", Offset = "0x1FFDE60", VA = "0x181FFEA60")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> BGHJPBCDGBC(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2000150", Offset = "0x1FFF550", VA = "0x182000150")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FCNCBFDEDKP(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2001400", Offset = "0x2000800", VA = "0x182001400")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> IKIFDLLJJOH(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> OPNGPBNLDBB, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> PKFLIGLADOI)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2001B80", Offset = "0x2000F80", VA = "0x182001B80")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> JCJFNALHEOL(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, int LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FFEEB0", Offset = "0x1FFE2B0", VA = "0x181FFEEB0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> CFGMNIACPLN(this NDLOJHJLJEA ABPJKOBADEP, int KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE580", Offset = "0x1FFD980", VA = "0x181FFE580")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> AIBHJOHNANI(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> KNNDCNIIFGC, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> LLOJENMANAJ)
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8200", Offset = "0x2CD7600", VA = "0x182CD8200")]
	public static void KPBKCMALCKL<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<EHPHFEHIOBB> EPPMAHLNCAC, [In] ReadOnlySpan<DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>> AKIDLHNEFEB, [In] ReadOnlySpan<int?> IECFIFMOCDP, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> NGKJMNHAJPO, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> BJHIEDAMBBD, [In] ReadOnlySpan<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>?> CGBCFHNJIMP) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6E70", Offset = "0x2CD6270", VA = "0x182CD6E70")]
	public static void EIOBJHOPJCE<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<ALBOPLJHKOM> IAJCFKFGJIF, [In] ReadOnlySpan<DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>> FELCMMEBADC, [In] ReadOnlySpan<int?> IECFIFMOCDP, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> NGKJMNHAJPO, [In] Span<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>> BJHIEDAMBBD, [In] ReadOnlySpan<DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>?> CGBCFHNJIMP) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2CD8EF0", Offset = "0x2CD82F0", VA = "0x182CD8EF0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> PJJHBIOOINI<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> DKPFMODHPLC, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6170", Offset = "0x2CD5570", VA = "0x182CD6170")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> BANIKBHJKMF<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> EFPKMBNDDMF, [Optional] DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7E60", Offset = "0x2CD7260", VA = "0x182CD7E60")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> IMGPDOFMEDF<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH) where TDeps : notnull, IPBHCDGMJLI<TStateSys> where TStateSys : notnull
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2CD68D0", Offset = "0x2CD5CD0", VA = "0x182CD68D0")]
	public static DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM> CFNCECEHLIH<TDeps, TStateSys>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH) where TDeps : notnull, IPBHCDGMJLI<TStateSys> where TStateSys : notnull
	{
		return default(DFKPAEMPCKH<MMBPEFLHLBP.LJHGCPKIAKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2002110", Offset = "0x2001510", VA = "0x182002110")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> KACJJPKKOBP(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> NKJDJFKBNDE, IntPtr PAHLHGIOACL, IntPtr BGLLOPLCPKN)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x20004C0", Offset = "0x1FFF8C0", VA = "0x1820004C0")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FKLNCGEFEKN(this NDLOJHJLJEA ABPJKOBADEP, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FNJHGCILIMI, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FFJKMOGEDBD, IntPtr LDKFIDFHIDL, IntPtr PLOLNCMIEKH, IntPtr HOLPKBNLECA, bool JHNFLNFGALK)
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7410", Offset = "0x2CD6810", VA = "0x182CD7410")]
	public static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> GAAAEDJBOME<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<EHPHFEHIOBB> EIFIIINBDCI, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FNJHGCILIMI, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FFJKMOGEDBD, int? FEAMDIEPHFD, [Optional] IntPtr PGAKDOEDLBK) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD7620", Offset = "0x2CD6A20", VA = "0x182CD7620")]
	private static DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> GAAAEDJBOME<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<EHPHFEHIOBB> EIFIIINBDCI, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FNJHGCILIMI, DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL> FFJKMOGEDBD, int? FEAMDIEPHFD) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
		return default(DFKPAEMPCKH<FDKMCDBBMJE.GMICBGOAJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD87A0", Offset = "0x2CD7BA0", VA = "0x182CD87A0")]
	public static DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> MECAKLICGCH<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI> FIJIJLPKIHA, DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>? KFGKPLPCACH) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
		return default(DFKPAEMPCKH<KCAJOOFHEEB.OHLFKPKJNBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD6AE0", Offset = "0x2CD5EE0", VA = "0x182CD6AE0")]
	public static void DIJNGLNDJAH<TDeps, TState>(this NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TState AHEJMLCHHMA, int OEBIHKACINF) where TDeps : notnull, IPBHCDGMJLI<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JDONFDAOLPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> PEPGNHKLMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> PDEEKDDGBMF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
	public JDONFDAOLPP(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> MOCAEAMCKMB, DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> JCFMFBEIDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD180", Offset = "0x1FFC580", VA = "0x181FFD180")]
	public static JDONFDAOLPP DDEJLDFANAB(DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>> MOCAEAMCKMB)
	{
		return default(JDONFDAOLPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct KCAJOOFHEEB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class PANCKAKFCHF : POFACFAAEPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CMKFGKLHGIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> NAPINBPKEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KCOEJCJFNCN;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		public CMKFGKLHGIK(DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG, int AGAGKNBDCIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KHFMCHFPEMJ : POFACFAAEPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BMPLGCCOOFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int KCOEJCJFNCN;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public BMPLGCCOOFB(int AGAGKNBDCIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class DLEOEKCKNHC : POFACFAAEPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct BGLGLEOKJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> NAPINBPKEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int KCOEJCJFNCN;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
		public BGLGLEOKJCO(DFKPAEMPCKH<GEHAAGIBICC.FGIHNNEKPHC> CLGCMHGKMOG, int AGAGKNBDCIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum GMJLCEGNHLE
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
	public sealed class OHLFKPKJNBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class POFACFAAEPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GCBIPDJFMMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? MACMLPLLEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JDONFDAOLPP AHOALLHLOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GMJLCEGNHLE FOACFDODIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DFKPAEMPCKH<POFACFAAEPG> KLAPHPOCEPC;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCB80", Offset = "0x1FFBF80", VA = "0x181FFCB80")]
		public GCBIPDJFMMC(int? BLBDJHDIMPH, [In] JDONFDAOLPP IMGNGGEFDNP, GMJLCEGNHLE DFLGBFHHDID, DFKPAEMPCKH<POFACFAAEPG> KMLNNJBOKOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class AFGPMJMIIPI : POFACFAAEPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OHOBBKGJJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int KCOEJCJFNCN;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		public OHOBBKGJJIG(int AGAGKNBDCIG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal CEIKLJHFOBE<OHLFKPKJNBI, GCBIPDJFMMC> CHABJKOGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal CEIKLJHFOBE<PANCKAKFCHF, CMKFGKLHGIK> HJODEEDNIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal CEIKLJHFOBE<DLEOEKCKNHC, BGLGLEOKJCO> BKLMANPGNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal CEIKLJHFOBE<AFGPMJMIIPI, OHOBBKGJJIG> IEHABGEHJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal CEIKLJHFOBE<KHFMCHFPEMJ, BMPLGCCOOFB> FJMMPHCHLLH;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDCA0", Offset = "0x1FFD0A0", VA = "0x181FFDCA0")]
	private KCAJOOFHEEB([In] CEIKLJHFOBE<OHLFKPKJNBI, GCBIPDJFMMC> NCLIOLKCBMO, [In] CEIKLJHFOBE<PANCKAKFCHF, CMKFGKLHGIK> LMCFOLBLCNA, [In] CEIKLJHFOBE<DLEOEKCKNHC, BGLGLEOKJCO> BENNGIHDCCJ, [In] CEIKLJHFOBE<AFGPMJMIIPI, OHOBBKGJJIG> EMFDLLIMNIG, [In] CEIKLJHFOBE<KHFMCHFPEMJ, BMPLGCCOOFB> PIPANFHIGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1FFDAB0", Offset = "0x1FFCEB0", VA = "0x181FFDAB0")]
	public static KCAJOOFHEEB DDEJLDFANAB()
	{
		return default(KCAJOOFHEEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AEOACDPMFJA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9650", Offset = "0x1FF8A50", VA = "0x181FF9650")]
	public static void CDBCEOANHGG(this KCAJOOFHEEB ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AENCDIFFICP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1FF94F0", Offset = "0x1FF88F0", VA = "0x181FF94F0")]
	public static void JBMECBCMFCJ(NDLOJHJLJEA ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JHNBKMDPEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, BCJGIBFECDP> MIHIFPAFJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int LIPOPMLPIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int ECPJLGBJFMI;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD3F0", Offset = "0x1FFC7F0", VA = "0x181FFD3F0")]
	private JHNBKMDPEMG([In] AEOJAEFAFAE<GEHAAGIBICC.BPIBIHJHBNG, BCJGIBFECDP> APLCFFDIEFG, int FDPKDHJNOFA, int KKGCDMPCAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD380", Offset = "0x1FFC780", VA = "0x181FFD380")]
	public static JHNBKMDPEMG DDEJLDFANAB()
	{
		return default(JHNBKMDPEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD190", Offset = "0x1FFC590", VA = "0x181FFD190")]
	public void CDBCEOANHGG([In] NDLOJHJLJEA JPBIJLLMGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD7570", Offset = "0x2BD6970", VA = "0x182BD7570")]
	public static void JBMECBCMFCJ<TDeps, TStateSys>(NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH, DFKPAEMPCKH<JJIBBLMHJAE> KIEJPDOJNFM) where TDeps : notnull, IPBHCDGMJLI<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JOLEKBECFLG
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD8E0", Offset = "0x1FFCCE0", VA = "0x181FFD8E0")]
	public static void JBMECBCMFCJ(NDLOJHJLJEA ABPJKOBADEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EIOOCMNDFOL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PMMPIIPPNFA(PCPLEDLJHDN<byte> ICIONHOPMDE, int MOGDFJBOCEN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct FJGBKJHPKIL : EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FFCA90", Offset = "0x1FFBE90", VA = "0x181FFCA90", Slot = "4")]
		public void PMMPIIPPNFA(PCPLEDLJHDN<byte> ICIONHOPMDE, int MOGDFJBOCEN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct AJOJFABCIHE : EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9700", Offset = "0x1FF8B00", VA = "0x181FF9700", Slot = "4")]
		public void PMMPIIPPNFA(PCPLEDLJHDN<byte> ICIONHOPMDE, int MOGDFJBOCEN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct JKKGENMOMDL : EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FFD430", Offset = "0x1FFC830", VA = "0x181FFD430", Slot = "4")]
		public void PMMPIIPPNFA(PCPLEDLJHDN<byte> ICIONHOPMDE, int MOGDFJBOCEN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct KKOKIMKGOGP : EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1FFDDD0", Offset = "0x1FFD1D0", VA = "0x181FFDDD0", Slot = "4")]
		public void PMMPIIPPNFA(PCPLEDLJHDN<byte> ICIONHOPMDE, int MOGDFJBOCEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class LEIBNBAHKJP<TCallProcessorDeps> where TCallProcessorDeps : struct, EELIFJGLOGD
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps FNNPADDAENM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2BF3840", Offset = "0x2BF2C40", VA = "0x182BF3840")]
		public static int JBMECBCMFCJ<TDeps, TStateSys>(TDeps GPENJAMDJGM, TStateSys AHEJMLCHHMA, NDLOJHJLJEA JPBIJLLMGPO, [In] PCPLEDLJHDN<byte> JAPLNJDKPMD, int JJBIHGLNEFN) where TDeps : IPBHCDGMJLI<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private PCPLEDLJHDN<FFBNLHDDCOA> BFJPMPFJPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> NJIKLFOCOMF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC880", Offset = "0x1FFBC80", VA = "0x181FFC880")]
	private EIOOCMNDFOL([In] PCPLEDLJHDN<FFBNLHDDCOA> FIBHHIPIBDI, Dictionary<DFKPAEMPCKH<MHCHLGAGEPI<OLJMCCBPJLK>>, DFKPAEMPCKH<GEHAAGIBICC.BPIBIHJHBNG>> LCPLBEGNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC7C0", Offset = "0x1FFBBC0", VA = "0x181FFC7C0")]
	public static EIOOCMNDFOL DDEJLDFANAB()
	{
		return default(EIOOCMNDFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FFC780", Offset = "0x1FFBB80", VA = "0x181FFC780")]
	public void CDBCEOANHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x29E4340", Offset = "0x29E3740", VA = "0x1829E4340")]
	public static void JBMECBCMFCJ<TDeps, TStateSys>(NDLOJHJLJEA ABPJKOBADEP, TDeps GPENJAMDJGM, TStateSys FMLBHLJOALH) where TDeps : IPBHCDGMJLI<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IHPFGOFKAOD<TDeps, TIndex, TValues> where TDeps : struct, NPMBPIDPLMI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps FNNPADDAENM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3E4CEF0", Offset = "0x3E4C2F0", VA = "0x183E4CEF0")]
	public static void JBMECBCMFCJ([In] PCPLEDLJHDN<FFBNLHDDCOA> FIBHHIPIBDI, int DFICMCEEFEN, TValues FJJNGLOPNDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NPMBPIDPLMI<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCPLEDLJHDN<TIndex> KDJOELNMHDB(int DFICMCEEFEN, [In] TValues FJJNGLOPNDO);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(TIndex AGAGKNBDCIG, [In] TValues FJJNGLOPNDO);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOIKFOCOIHM(TIndex AGAGKNBDCIG, TValues FJJNGLOPNDO, DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> OBEEJPGJPFD);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GGLEDOPJLDH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex EDDPBAHONFL(int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JPPBEGCGIDI(TIndex AGAGKNBDCIG, [In] TValues FJJNGLOPNDO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DFKPAEMPCKH<MHCHLGAGEPI<OMICMMHGCKE>> FBKBLFPKOHA(TIndex AGAGKNBDCIG, [In] TValues FJJNGLOPNDO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class JFJLDGHBHKP<TDeps, TIndex, TValues> where TDeps : struct, GGLEDOPJLDH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps FNNPADDAENM;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4031C30", Offset = "0x4031030", VA = "0x184031C30")]
	public static PCPLEDLJHDN<TIndex> JBMECBCMFCJ(int DFICMCEEFEN, [In] TValues FJJNGLOPNDO)
	{
		return default(PCPLEDLJHDN<TIndex>);
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

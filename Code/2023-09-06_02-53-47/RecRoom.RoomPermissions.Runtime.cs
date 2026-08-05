using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65DEBB0", Offset = "0x65DD1B0", VA = "0x1865DEBB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x986BA0", Offset = "0x9851A0", VA = "0x180986BA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11F2200", Offset = "0x11F0800", VA = "0x1811F2200")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NIELEMEDLIG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OLKBILKIHKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FIFPADPDOAG CHOEDNOCHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<IIPDAEEINIG> HLPNEMLHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PLOIOJMMEAJ LJGLMOGMFAD;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<IIPDAEEINIG> COLMGMFLNKD(bool JDGDJKNNCHD = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IIPDAEEINIG NGAFBHOEFJJ(EGKKDNKLFAD AOEANNMDJIC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HHGGJHLKGMJ(EGKKDNKLFAD AOEANNMDJIC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<IIPDAEEINIG> NLNBCGGOJPH(EGKKDNKLFAD AOEANNMDJIC, bool APENBALFDOF = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NJKPBDLIABL(EGKKDNKLFAD BNIGDMGBKHF, DJAGGKCHHII ALNLIJPKHNG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IIPDAEEINIG NBKANADFABK(DJAGGKCHHII ALNLIJPKHNG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GMFEDHPGEKH<T>(DJAGGKCHHII ALNLIJPKHNG, EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, T JBBIKBFHPNN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PNCOJMMIGMD
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FDNBHLPIAMC(LCGOIIEOBDN KDIGEENFCDC, CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFHKLDMHKGF(ref LCGOIIEOBDN KDIGEENFCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HDDJNJDEFGA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OCKKBPAPJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ECMAGAAECIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool JOPDFCLFHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KGFFHHCPOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BFKLHHDPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool MFJGMCLLCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FOOKIHACLPP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<DJAGGKCHHII> IMKLIDOGILB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65D9840", Offset = "0x65D7E40", VA = "0x1865D9840")]
	public static bool NLKLONBMOLF(this EGKKDNKLFAD AKHMHONIJHJ, DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65D97C0", Offset = "0x65D7DC0", VA = "0x1865D97C0")]
	public static bool HIOEGAAJCLA(this EGKKDNKLFAD AKHMHONIJHJ, DJAGGKCHHII ALNLIJPKHNG, KBEJKBKFMKD OCMCGPHIMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class NMMAKKOBBKN : HIBOIDGEMLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly OLKBILKIHKK BKLJPGHHJOF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	[RecRoom.NoEngine.Common.Preserve]
	public NMMAKKOBBKN([BBBJPGKHPHG(null)] OLKBILKIHKK BBOHLFLOIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65DEB60", Offset = "0x65DD160", VA = "0x1865DEB60")]
	private static KJHMEALGMPM? MBANKALOKEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65DE520", Offset = "0x65DCB20", VA = "0x1865DE520", Slot = "4")]
	public bool DEGIJMNFJPJ(EGKKDNKLFAD MDNKDCKLNGB, EGKKDNKLFAD HOCCDBGFPEH, IEnumerable<EGKKDNKLFAD> DCODPACIIMJ, out NIELEMEDLIG BIBHMPHHDDF, out OAHEJBKCIGE FKALNDKPBNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65DE630", Offset = "0x65DCC30", VA = "0x1865DE630")]
	internal bool KFJNEJJPNNL(EGKKDNKLFAD MDNKDCKLNGB, EGKKDNKLFAD HOCCDBGFPEH, IEnumerable<EGKKDNKLFAD> DCODPACIIMJ, KBEJKBKFMKD OCMCGPHIMLI, KJHMEALGMPM? OIKJEAPOOIF, out NIELEMEDLIG BIBHMPHHDDF, out OAHEJBKCIGE FKALNDKPBNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KHBEPGCNCBL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string FOEECJGBGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PLAJPIHPKGJ<TPermission> PDMHKMNNDOF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void PLAJPIHPKGJ<TPermission>(TPermission LDKGIHAODNO);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void PLOIOJMMEAJ(EGKKDNKLFAD AOEANNMDJIC);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class EDEDOMCIFGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string MMBOIOPABOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type IPBPGEKOFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly JCEBBABICCB PJCPPJCNAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly EGDECOHHPCB KIHDGLGCEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public IEMEKDBKCJO KMDIEINFICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public OECEMMJEDMJ FEJLBPJLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public MLIFJBHGFFD KLNKKDEFPPD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65D8E00", Offset = "0x65D7400", VA = "0x1865D8E00")]
	public EDEDOMCIFGL(Type BPJFCKKOFHF, string KCJIKNIDHMH, EGDECOHHPCB LDKGIHAODNO, IEMEKDBKCJO CHHPDPCBMPL, OECEMMJEDMJ BKGOCLMJAHC, MLIFJBHGFFD IOMJNKKFLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65D8D10", Offset = "0x65D7310", VA = "0x1865D8D10")]
	public object CCGKCJAEJKO(object? FKJGPCABBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1A90", Offset = "0x1FB0090", VA = "0x181FB1A90")]
	public void LILFBBDBHIL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65D8D50", Offset = "0x65D7350", VA = "0x1865D8D50")]
	public void LILFBBDBHIL(Type MKBOBGNGJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class FFBODKMIEJN<T> : EDEDOMCIFGL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string KJMFDIGIEBA(T MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T OAJCNMAMOCH(string? AHKEILDBGEI, T INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GFABCODPJFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KJMFDIGIEBA serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OAJCNMAMOCH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public GFABCODPJFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x24DFAC0", Offset = "0x24DE0C0", VA = "0x1824DFAC0")]
		internal string JBOBNDEBFPJ(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x24DFB30", Offset = "0x24DE130", VA = "0x1824DFB30")]
		internal object NIFFGBFKJBC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50B0150", Offset = "0x50AE750", VA = "0x1850B0150")]
	public FFBODKMIEJN(EGDECOHHPCB LDKGIHAODNO, string KCJIKNIDHMH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8B40", Offset = "0x6E7F40")] FFBODKMIEJN<T>.KJMFDIGIEBA CHHPDPCBMPL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8BA0", Offset = "0x6E7FA0")] FFBODKMIEJN<T>.OAJCNMAMOCH BKGOCLMJAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x50AF6E0", Offset = "0x50ADCE0", VA = "0x1850AF6E0")]
	private static object? LKBINHHANLF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8C00", Offset = "0x6E8000")] FFBODKMIEJN<T?>.OAJCNMAMOCH? BKGOCLMJAHC, string? AHKEILDBGEI, object? INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50AEA30", Offset = "0x50AD030", VA = "0x1850AEA30")]
	private static string HLDMGFBCHDH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8C60", Offset = "0x6E8060")] FFBODKMIEJN<T>.KJMFDIGIEBA DBCDCAPIPAF, object? MOLEJFDINLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CGOBADLMIPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EGKKDNKLFAD BBHFOGGNFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CNNHMPNEMCB ILIBHFFOJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KBEJKBKFMKD BMOMCKMAOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CFAAINLHHCJ> FDEAHDPHLAP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action AKBEAKOGDOD;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DJAGGKCHHII OKJPNHPCBIA(EGKKDNKLFAD AOEANNMDJIC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<CFAAINLHHCJ> CHLAMFKFGMI(CancellationToken KEGMOCPJOHL);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BNCEKEGOLDF(long AHLGFJPMMNL, long HCBHLEILMNO, IReadOnlyList<CDLNOLPIAAC> EDFAONNOJIE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EGKKDNKLFAD> IOLOINDFAFD();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BBGDCDFPJNJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x65D2340", Offset = "0x65D0940", VA = "0x1865D2340")]
	public static DJAGGKCHHII BBCAPNDJDKO(this CGOBADLMIPI FHPLDKMGHDM)
	{
		return default(DJAGGKCHHII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class NCDCBMMNEHB : IIPDAEEINIG, EEKADJPADGF, HDDJNJDEFGA, KHBEPGCNCBL<EGDECOHHPCB>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly BCPLCCIEEPN ENLHELPACGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly NGNOFCMHPCD IEOIMELGEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? HLNFPOHIBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? LNJHAJHBPLD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool JHEBAOPEEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65DBBC0", Offset = "0x65DA1C0", VA = "0x1865DBBC0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool MLOPBLCOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x65DA9D0", Offset = "0x65D8FD0", VA = "0x1865DA9D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool FHHBNBLNPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x65DB650", Offset = "0x65D9C50", VA = "0x1865DB650", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool HCHCIOIMINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x65DBC10", Offset = "0x65DA210", VA = "0x1865DBC10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool CGHEPGCLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x65DBCD0", Offset = "0x65DA2D0", VA = "0x1865DBCD0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool HEINDJNNMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x65DA720", Offset = "0x65D8D20", VA = "0x1865DA720", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DJAGGKCHHII INHGEHEFOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DJAGGKCHHII);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC00670", Offset = "0xBFEC70", VA = "0x180C00670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string FOEECJGBGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x65DC720", Offset = "0x65DAD20", VA = "0x1865DC720", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x65DA890", Offset = "0x65D8E90", VA = "0x1865DA890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string LJJEMKCGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x65DC720", Offset = "0x65DAD20", VA = "0x1865DC720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HNPADKHCIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x95F8C0", Offset = "0x95DEC0", VA = "0x18095F8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x95F610", Offset = "0x95DC10", VA = "0x18095F610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool HJKKCNJLDND
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x65DC5F0", Offset = "0x65DABF0", VA = "0x1865DC5F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NIELEMEDLIG ELLMBODIAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x65DBD80", Offset = "0x65DA380", VA = "0x1865DBD80", Slot = "20")]
		get
		{
			return default(NIELEMEDLIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool INNGNNMKLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65DA7C0", Offset = "0x65D8DC0", VA = "0x1865DA7C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool FDDCJDPGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x65DBF60", Offset = "0x65DA560", VA = "0x1865DBF60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool CNJDLFNBPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x65DC160", Offset = "0x65DA760", VA = "0x1865DC160", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ELFIODCJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x65DC770", Offset = "0x65DAD70", VA = "0x1865DC770", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BBKMIIKEOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65DBFB0", Offset = "0x65DA5B0", VA = "0x1865DBFB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EGKALJJHIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65DC110", Offset = "0x65DA710", VA = "0x1865DC110", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EHAPJIHIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65DBC60", Offset = "0x65DA260", VA = "0x1865DBC60", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ABCJDBKONEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65DA8E0", Offset = "0x65D8EE0", VA = "0x1865DA8E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> HJONLCBDFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65DBD20", Offset = "0x65DA320", VA = "0x1865DBD20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EJPFOHPFOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65DBBC0", Offset = "0x65DA1C0", VA = "0x1865DBBC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JJAONJKHPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65DBCD0", Offset = "0x65DA2D0", VA = "0x1865DBCD0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool POOMIIDBOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x65DA9D0", Offset = "0x65D8FD0", VA = "0x1865DA9D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EJDEJJNNGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65DB6A0", Offset = "0x65D9CA0", VA = "0x1865DB6A0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool MPAECAKJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x65DBDD0", Offset = "0x65DA3D0", VA = "0x1865DBDD0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NJKKGOKPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65DB650", Offset = "0x65D9C50", VA = "0x1865DB650", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BBPEMAAJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x65DA770", Offset = "0x65D8D70", VA = "0x1865DA770", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KFKCBLIPCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65DBC10", Offset = "0x65DA210", VA = "0x1865DBC10", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GHKEILBMIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65DA720", Offset = "0x65D8D20", VA = "0x1865DA720", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PLAJPIHPKGJ<EGDECOHHPCB> PDMHKMNNDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65DBE20", Offset = "0x65DA420", VA = "0x1865DBE20", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x65DA930", Offset = "0x65D8F30", VA = "0x1865DA930", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20A70A0", Offset = "0x20A56A0", VA = "0x1820A70A0", Slot = "6")]
	public (bool, T?) IBDLBLNACEL<T>(EGDECOHHPCB LDKGIHAODNO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20A7060", Offset = "0x20A5660", VA = "0x1820A7060")]
	public NCDCBMMNEHB EAEFHMEBIDN<T>(EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, T MOLEJFDINLH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x65DC990", Offset = "0x65DAF90", VA = "0x1865DC990")]
	public NCDCBMMNEHB(DJAGGKCHHII ALNLIJPKHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x65DC9B0", Offset = "0x65DAFB0", VA = "0x1865DC9B0")]
	public NCDCBMMNEHB(DJAGGKCHHII ALNLIJPKHNG, [Optional] string? HLNFPOHIBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x65DC9D0", Offset = "0x65DAFD0", VA = "0x1865DC9D0")]
	public NCDCBMMNEHB(NCDCBMMNEHB EKMEBCKEJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x65DC830", Offset = "0x65DAE30", VA = "0x1865DC830")]
	internal NCDCBMMNEHB(DJAGGKCHHII CMPKOGJCBAM, [Optional] string? HLNFPOHIBKB, [Optional] NCDCBMMNEHB? EKMEBCKEJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x65DA810", Offset = "0x65D8E10", VA = "0x1865DA810")]
	public static JCEBBABICCB CJBKGHDONOP(EGDECOHHPCB LDKGIHAODNO)
	{
		return default(JCEBBABICCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65DBCB0", Offset = "0x65DA2B0", VA = "0x1865DBCB0")]
	public void IAMKIIAFHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65DB930", Offset = "0x65D9F30", VA = "0x1865DB930")]
	internal NCDCBMMNEHB GAFLCLCJFAN(NCDCBMMNEHB OALKAAKLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65DC250", Offset = "0x65DA850", VA = "0x1865DC250")]
	internal IReadOnlyCollection<EGDECOHHPCB> MOAONFLIEIF(NCDCBMMNEHB EKMEBCKEJFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x65DC640", Offset = "0x65DAC40", VA = "0x1865DC640")]
	public bool OGMGDBAGEME(EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, string DGJGLIIEBHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x65DC000", Offset = "0x65DA600", VA = "0x1865DC000")]
	public (bool, string) JPHHODHHDHB(EGDECOHHPCB LDKGIHAODNO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x65DBEC0", Offset = "0x65DA4C0", VA = "0x1865DBEC0")]
	internal void JBPNNKGEJAN(EGDECOHHPCB LDKGIHAODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x65DB6F0", Offset = "0x65D9CF0", VA = "0x1865DB6F0")]
	public JGPGKLEHGGO FONOOMCMIJC(Func<DJAGGKCHHII, Guid> EBAFBLMCANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65DAA20", Offset = "0x65D9020", VA = "0x1865DAA20")]
	public void EEBCHHALIFG(JGPGKLEHGGO LOEOELJFFGM, Func<Guid, DJAGGKCHHII> FLPFJENFFNE, [Optional] DJAGGKCHHII? PFJDCKFLFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65DC1B0", Offset = "0x65DA7B0", VA = "0x1865DC1B0")]
	[CompilerGenerated]
	private void MDOJPEDDLKM(EGDECOHHPCB HICMOGOGCCP, BIDFHDEAAEB AAHGPKLKJBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HIBOIDGEMLG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEGIJMNFJPJ(EGKKDNKLFAD MDNKDCKLNGB, EGKKDNKLFAD HOCCDBGFPEH, IEnumerable<EGKKDNKLFAD> DCODPACIIMJ, out NIELEMEDLIG BIBHMPHHDDF, out OAHEJBKCIGE FKALNDKPBNE);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OAHEJBKCIGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EEKADJPADGF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool HJKKCNJLDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool INNGNNMKLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FDDCJDPGJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool CNJDLFNBPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool ELFIODCJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool BBKMIIKEOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool EGKALJJHIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool EHAPJIHIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool ABCJDBKONEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool EJDEJJNNGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MPAECAKJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool BBPEMAAJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> HJONLCBDFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	NIELEMEDLIG ELLMBODIAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IIPDAEEINIG : EEKADJPADGF, HDDJNJDEFGA, KHBEPGCNCBL<EGDECOHHPCB>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string LJJEMKCGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DJAGGKCHHII INHGEHEFOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IBDLBLNACEL<T>(EGDECOHHPCB LDKGIHAODNO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class ELDJABGIIMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? BENHJEBBPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	protected ELDJABGIIMJ(object? JGAHGMBKENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool ALGMGODHEFB(object? MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GLNPLIFJEGN<T> : ELDJABGIIMJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T MAFIBGFBPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> OHDCMCANAGL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x95ED20", Offset = "0x95D320", VA = "0x18095ED20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4013380", Offset = "0x4011980", VA = "0x184013380", Slot = "4")]
	public override bool ALGMGODHEFB(object? MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4013860", Offset = "0x4011E60", VA = "0x184013860")]
	public bool OOAHBIIIMLA(T FDLKKOIJCDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4013B60", Offset = "0x4012160", VA = "0x184013B60")]
	public GLNPLIFJEGN(T INIEFLCMFEE, IEqualityComparer<T> OHDCMCANAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class FNBJMENOPNG
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum FKKGFMCLJPD
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly Guid MBEAGPPBAKI;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid EHAKGMMBOBK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid GGICOJKPPBM;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid KAEHGMPDDLL;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid NKJOGPBLIFC;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly CGMGKHJLCJO<DJAGGKCHHII, Guid> EIMHOIFHCMG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<DJAGGKCHHII> AKDBCKNDGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65D9260", Offset = "0x65D7860", VA = "0x1865D9260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x65D9390", Offset = "0x65D7990", VA = "0x1865D9390")]
	public static DJAGGKCHHII LPKODLNPJNH(Guid NAMBIBPENHK)
	{
		return default(DJAGGKCHHII);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65D9110", Offset = "0x65D7710", VA = "0x1865D9110")]
	public static Guid BEAKMDKKDGO(DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x65D9450", Offset = "0x65D7A50", VA = "0x1865D9450")]
	public static bool PABBJNECENJ(DJAGGKCHHII ALNLIJPKHNG, out Guid NAMBIBPENHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65D91C0", Offset = "0x65D77C0", VA = "0x1865D91C0")]
	public static bool BIFCLGMKIPC(Guid NAMBIBPENHK, out DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65D9420", Offset = "0x65D7A20", VA = "0x1865D9420")]
	public static DJAGGKCHHII ODPDDKKHMHI(DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(DJAGGKCHHII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65D92E0", Offset = "0x65D78E0", VA = "0x1865D92E0")]
	public static FKKGFMCLJPD IOHFKPNNOBF(DJAGGKCHHII IHDALHMNEFF)
	{
		return default(FKKGFMCLJPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x65D90D0", Offset = "0x65D76D0", VA = "0x1865D90D0")]
	internal static DJAGGKCHHII ACFMHLCKGFA(FKKGFMCLJPD ONINLLINAMA)
	{
		return default(DJAGGKCHHII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string IEMEKDBKCJO(object? MOLEJFDINLH);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object OECEMMJEDMJ(string? AHKEILDBGEI, [Optional] object INIEFLCMFEE);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate ELDJABGIIMJ MLIFJBHGFFD();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BCPLCCIEEPN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class GHOFFNPDINJ : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static GHOFFNPDINJ HAMPJMKDJOL;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x65D9B00", Offset = "0x65D8100", VA = "0x1865D9B00", Slot = "4")]
		public bool Equals(List<string> HEICJNINGBE, List<string> DNLDNFFNIEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x65D9C60", Offset = "0x65D8260", VA = "0x1865D9C60", Slot = "5")]
		public int GetHashCode(List<string> NKFOPKJGBEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GHOFFNPDINJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class PCNINKFLGNC : DMLEKLJDECG<NIELEMEDLIG>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x65DF260", Offset = "0x65DD860", VA = "0x1865DF260", Slot = "9")]
		public override string HLDMGFBCHDH(NIELEMEDLIG JDCGNJBJHCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x65DF070", Offset = "0x65DD670", VA = "0x1865DF070", Slot = "10")]
		protected override bool EFPKEPJKIEI(string JDCGNJBJHCM, out NIELEMEDLIG MOLEJFDINLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x65DF350", Offset = "0x65DD950", VA = "0x1865DF350")]
		public PCNINKFLGNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EEELFIAPBKN JJBHFHAPEPB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly PCNINKFLGNC KKIJCMPJLGE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<EDEDOMCIFGL> CFDCKOAEPHD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<EGDECOHHPCB> MJEONOAIECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<EGDECOHHPCB, EDEDOMCIFGL> GGGGCIKAADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x65D2F80", Offset = "0x65D1580", VA = "0x1865D2F80")]
	public BCPLCCIEEPN([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E8D40", Offset = "0x6E8140")] IList<EDEDOMCIFGL> LDHCPNCOFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65D23A0", Offset = "0x65D09A0", VA = "0x1865D23A0")]
	public EDEDOMCIFGL EMLBBPODPIL(EGDECOHHPCB LDKGIHAODNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DDAOGGMCFFN : PNCOJMMIGMD, OLKBILKIHKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ODHEDGEHFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NCDCBMMNEHB newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ODHEDGEHFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x65DEC40", Offset = "0x65DD240", VA = "0x1865DEC40")]
		internal bool NNIBMDIFDKE(NCDCBMMNEHB rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ELPEBKIEMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DJAGGKCHHII roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ELPEBKIEMIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x65D8E90", Offset = "0x65D7490", VA = "0x1865D8E90")]
		internal bool KCFGKAIOHJN(DJAGGKCHHII r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NLEADOMDJPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public LCGOIIEOBDN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DDAOGGMCFFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CFAAINLHHCJ <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private CFAAINLHHCJ <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E92D0", Offset = "0x6E86D0")]
		private TaskAwaiter<CFAAINLHHCJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NLEADOMDJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x65DDD70", Offset = "0x65DC370", VA = "0x1865DDD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ENPPEEHHGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public ENPPEEHHGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x65D8FD0", Offset = "0x65D75D0", VA = "0x1865D8FD0")]
		internal void EHDPDPMJCGJ(JGPGKLEHGGO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65D8EA0", Offset = "0x65D74A0", VA = "0x1865D8EA0")]
		internal void DIBONJLFJBP(JGPGKLEHGGO r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FEIJPEPGCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LCGOIIEOBDN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CAAPPCAJLKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9330", Offset = "0x6E8730")]
		public Func<JGPGKLEHGGO, BIDFHDEAAEB> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CAAPPCAJLKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x65D3360", Offset = "0x65D1960", VA = "0x1865D3360")]
		internal void ENLAIAEACCA(JGPGKLEHGGO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x65D32F0", Offset = "0x65D18F0", VA = "0x1865D32F0")]
		internal void EGNPPBHAAGE(JGPGKLEHGGO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x65D33D0", Offset = "0x65D19D0", VA = "0x1865D33D0")]
		internal void FOKDMFDIHEE(JGPGKLEHGGO r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PKGBEEGOPPL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public PKGBEEGOPPL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private Exception <ex>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E93F0", Offset = "0x6E87F0")]
			private TaskAwaiter<CFAAINLHHCJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x19A4C40", Offset = "0x19A3240", VA = "0x1819A4C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DDAOGGMCFFN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public EGDECOHHPCB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public DJAGGKCHHII accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public JCEBBABICCB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public PKGBEEGOPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x22B54D0", Offset = "0x22B3AD0", VA = "0x1822B54D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(PKGBEEGOPPL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GILCNAMLONH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PHAHGHPJDEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<CDLNOLPIAAC> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NHGBGOJJGHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CGOBADLMIPI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LCGOIIEOBDN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9450", Offset = "0x6E8850")]
		public IReadOnlyDictionary<DJAGGKCHHII, NCDCBMMNEHB> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public HLAAOIMKODK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E94B0", Offset = "0x6E88B0")]
		private List<CDLNOLPIAAC> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<JGPGKLEHGGO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private JGPGKLEHGGO <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private DJAGGKCHHII <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private NCDCBMMNEHB <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<EGDECOHHPCB> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<EGDECOHHPCB> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private EGDECOHHPCB <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JCEBBABICCB <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E9510", Offset = "0x6E8910")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public NHGBGOJJGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x65DD130", Offset = "0x65DB730", VA = "0x1865DD130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CGOBADLMIPI FHPLDKMGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly MEOGIOJJCJE CMDFKDHGDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HLAAOIMKODK NJMEHFFCGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, NCDCBMMNEHB> OIFNEGIIMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<DJAGGKCHHII, NCDCBMMNEHB> PBNJLAFCOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<DJAGGKCHHII, NCDCBMMNEHB> PIBOLANKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<NCDCBMMNEHB> NOBJDIEEGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DHDPFAPHKEI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly EGDECOHHPCB[] EGFBFEAECAI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FIFPADPDOAG CHOEDNOCHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<IIPDAEEINIG> HLPNEMLHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65D7E40", Offset = "0x65D6440", VA = "0x1865D7E40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PLOIOJMMEAJ LJGLMOGMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x65D8330", Offset = "0x65D6930", VA = "0x1865D8330", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x65D3440", Offset = "0x65D1A40", VA = "0x1865D3440", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x65D7390", Offset = "0x65D5990", VA = "0x1865D7390")]
	[HFALCAKMDCP(DGHGCOPCCJK.Room, BFPOMPMIJIJ.None)]
	private static void MNBLCDKPKOL(HOKFDAHMIPF COFPHJJAOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x65D8A80", Offset = "0x65D7080", VA = "0x1865D8A80")]
	[UnityEngine.Scripting.Preserve]
	internal DDAOGGMCFFN([BBBJPGKHPHG(null)] CGOBADLMIPI ANEHBIMKBBG, [BBBJPGKHPHG(null)] MEOGIOJJCJE PAAONMIJEFA, [BBBJPGKHPHG(null)] HLAAOIMKODK NJMEHFFCGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65D3D30", Offset = "0x65D2330", VA = "0x1865D3D30", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65D6920", Offset = "0x65D4F20", VA = "0x1865D6920")]
	private void MECOLKGKHEF(IEnumerable<NCDCBMMNEHB> DDHBGAOJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65D4F80", Offset = "0x65D3580", VA = "0x1865D4F80", Slot = "12")]
	public bool HHGGJHLKGMJ(EGKKDNKLFAD AOEANNMDJIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x65D37C0", Offset = "0x65D1DC0", VA = "0x1865D37C0")]
	private void AKBEAKOGDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65D6740", Offset = "0x65D4D40", VA = "0x1865D6740")]
	private void KLMLLKDHAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x65D3990", Offset = "0x65D1F90", VA = "0x1865D3990", Slot = "10")]
	public IReadOnlyList<IIPDAEEINIG> COLMGMFLNKD(bool JDGDJKNNCHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65D7D30", Offset = "0x65D6330", VA = "0x1865D7D30", Slot = "11")]
	public IIPDAEEINIG NGAFBHOEFJJ(EGKKDNKLFAD AOEANNMDJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x65D4EC0", Offset = "0x65D34C0", VA = "0x1865D4EC0")]
	private DJAGGKCHHII GPEMFPDAAEN(EGKKDNKLFAD AOEANNMDJIC)
	{
		return default(DJAGGKCHHII);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x65D7E90", Offset = "0x65D6490", VA = "0x1865D7E90", Slot = "14")]
	public bool NJKPBDLIABL(EGKKDNKLFAD BNIGDMGBKHF, DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x65D7540", Offset = "0x65D5B40", VA = "0x1865D7540", Slot = "15")]
	public IIPDAEEINIG NBKANADFABK(DJAGGKCHHII ALNLIJPKHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65D4740", Offset = "0x65D2D40", VA = "0x1865D4740")]
	private static bool EPNNMBDPEGN(BEBAFPKEKEC EHGEIDBCNHN, DJAGGKCHHII ALNLIJPKHNG, out JGPGKLEHGGO? JHPIEPCEPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x65D8030", Offset = "0x65D6630", VA = "0x1865D8030")]
	private static void OCNGCCMKGBP(BEBAFPKEKEC EHGEIDBCNHN, Action<JGPGKLEHGGO> LJBABOFDBGG, DJAGGKCHHII OFLPHFAJEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65D8130", Offset = "0x65D6730", VA = "0x1865D8130")]
	private static void OCNGCCMKGBP(BEBAFPKEKEC EHGEIDBCNHN, Action<JGPGKLEHGGO> LJBABOFDBGG, Predicate<DJAGGKCHHII> CBOEGCJJEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x65D68C0", Offset = "0x65D4EC0", VA = "0x1865D68C0")]
	private void KNGCDLKNHGJ(EGKKDNKLFAD AOEANNMDJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65D4B30", Offset = "0x65D3130", VA = "0x1865D4B30", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NLEADOMDJPL))]
	public Task FDNBHLPIAMC([CanBeNull] LCGOIIEOBDN KDIGEENFCDC, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
	public void AFHKLDMHKGF(ref LCGOIIEOBDN KDIGEENFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x65D7110", Offset = "0x65D5710", VA = "0x1865D7110")]
	private void MGBJDDPJLKF(BEBAFPKEKEC CEFDAGFBOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65D5050", Offset = "0x65D3650", VA = "0x1865D5050")]
	internal static string HMOIAAANKIM(CGOBADLMIPI FHPLDKMGHDM, LCGOIIEOBDN KDIGEENFCDC, IReadOnlyDictionary<DJAGGKCHHII, NCDCBMMNEHB> PBNJLAFCOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x65D5830", Offset = "0x65D3E30", VA = "0x1865D5830")]
	private static void KJBGFEFDDCI(LCGOIIEOBDN KDIGEENFCDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x65D5520", Offset = "0x65D3B20", VA = "0x1865D5520")]
	private static void JJNHAAMCINA(BEBAFPKEKEC FCJBGACFNMD, IReadOnlyDictionary<DJAGGKCHHII, NCDCBMMNEHB> PBNJLAFCOPN, StringBuilder HFDOCIPJGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x65D8750", Offset = "0x65D6D50", VA = "0x1865D8750")]
	private static bool PPPJBJOADJC(string HOAPCGJDFKC, out Guid FKDHNFCIFCF, out DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x65D3E40", Offset = "0x65D2440", VA = "0x1865D3E40")]
	private static void EHGJKIPODGF(LCGOIIEOBDN KDIGEENFCDC, StringBuilder HFDOCIPJGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x243C820", Offset = "0x243AE20", VA = "0x18243C820", Slot = "16")]
	public bool GMFEDHPGEKH<T>(DJAGGKCHHII ALNLIJPKHNG, EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, T JBBIKBFHPNN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x65D5370", Offset = "0x65D3970", VA = "0x1865D5370")]
	private void INDJDDADKGP(DJAGGKCHHII ALNLIJPKHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x65D37D0", Offset = "0x65D1DD0", VA = "0x1865D37D0")]
	private bool AKCNCIGOKMF(EGKKDNKLFAD AOEANNMDJIC, DJAGGKCHHII ALNLIJPKHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x65D3A10", Offset = "0x65D2010", VA = "0x1865D3A10")]
	internal NCDCBMMNEHB DCNANDAFKLL(EGKKDNKLFAD AOEANNMDJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x65D8020", Offset = "0x65D6620", VA = "0x1865D8020", Slot = "13")]
	public IReadOnlyList<IIPDAEEINIG> NLNBCGGOJPH(EGKKDNKLFAD AOEANNMDJIC, bool APENBALFDOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x65D4CA0", Offset = "0x65D32A0", VA = "0x1865D4CA0")]
	internal IReadOnlyList<NCDCBMMNEHB> GEMGGFMLIJD(EGKKDNKLFAD AOEANNMDJIC, bool APENBALFDOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x65D75F0", Offset = "0x65D5BF0", VA = "0x1865D75F0")]
	private void NCAKPCCMBJH(CFAAINLHHCJ JONDLDCLGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x65D4460", Offset = "0x65D2A60", VA = "0x1865D4460")]
	private static bool EKHKJEMOBND(NCDCBMMNEHB DFOLCJFOEIC, IReadOnlyDictionary<DJAGGKCHHII, NCDCBMMNEHB> PBNJLAFCOPN, out IReadOnlyList<EGDECOHHPCB> GMIIPJDGGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x65D37F0", Offset = "0x65D1DF0", VA = "0x1865D37F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NHGBGOJJGHN))]
	private static Task CNJLAOLKIDG(CGOBADLMIPI FHPLDKMGHDM, LCGOIIEOBDN KDIGEENFCDC, IReadOnlyDictionary<DJAGGKCHHII, NCDCBMMNEHB> PBNJLAFCOPN, HLAAOIMKODK NJMEHFFCGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x65D34E0", Offset = "0x65D1AE0", VA = "0x1865D34E0")]
	[CompilerGenerated]
	internal static void ACFOAMMHIJD(Func<JGPGKLEHGGO, BIDFHDEAAEB> HEIDDKDAPJB, ref FEIJPEPGCOO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x65D83D0", Offset = "0x65D69D0", VA = "0x1865D83D0")]
	[CompilerGenerated]
	internal static bool OPCPEAFKIAG(DJAGGKCHHII ALNLIJPKHNG, EGDECOHHPCB LDKGIHAODNO, out CDLNOLPIAAC BEFNKFAGIOL, ref PHAHGHPJDEA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum EGDECOHHPCB
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class NGNOFCMHPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<EGDECOHHPCB, bool> MMMNALJCLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<EGDECOHHPCB, ELDJABGIIMJ> LKJELDJKLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly BCPLCCIEEPN NCPELIOMMOC;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x65DCEE0", Offset = "0x65DB4E0", VA = "0x1865DCEE0")]
	public NGNOFCMHPCD(BCPLCCIEEPN NCPELIOMMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65DCE70", Offset = "0x65DB470", VA = "0x1865DCE70")]
	public bool MOIEDDFLCLJ(EGDECOHHPCB LDKGIHAODNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20AE990", Offset = "0x20ACF90", VA = "0x1820AE990")]
	public bool DBFDKFBOBBD<T>(EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, T MOLEJFDINLH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20AECA0", Offset = "0x20AD2A0", VA = "0x1820AECA0")]
	public (bool, T?) JLHCGGPEAAC<T>(EGDECOHHPCB LDKGIHAODNO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65DCB20", Offset = "0x65DB120", VA = "0x1865DCB20")]
	public bool DBFDKFBOBBD(EGDECOHHPCB LDKGIHAODNO, bool DNMLPEGBNIN, object MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x65DCD80", Offset = "0x65DB380", VA = "0x1865DCD80")]
	public (bool, object) JLHCGGPEAAC(EGDECOHHPCB LDKGIHAODNO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x20AEEA0", Offset = "0x20AD4A0", VA = "0x1820AEEA0")]
	private void LILFBBDBHIL<T>(EGDECOHHPCB LDKGIHAODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65DCA60", Offset = "0x65DB060", VA = "0x1865DCA60")]
	private ELDJABGIIMJ CIIHLPIKDDE(EGDECOHHPCB LDKGIHAODNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x65DCC00", Offset = "0x65DB200", VA = "0x1865DCC00")]
	public void IAMKIIAFHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface FIFPADPDOAG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	IIPDAEEINIG GPCJJDMICGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class MEOGIOJJCJE : FIFPADPDOAG
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static MEOGIOJJCJE CCLPKGMAKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly NCDCBMMNEHB IIOJBNBGPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<NCDCBMMNEHB> DNIHEEIFMLJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IIPDAEEINIG GPCJJDMICGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65DA620", Offset = "0x65D8C20", VA = "0x1865DA620")]
	public MEOGIOJJCJE(NCDCBMMNEHB LFLOOJCCDCP, IReadOnlyList<NCDCBMMNEHB> BNPEDIAICJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x65D9E00", Offset = "0x65D8400", VA = "0x1865D9E00")]
	private static MEOGIOJJCJE CKGAECJCCIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum PANOHOGKHJN
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Everyone
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

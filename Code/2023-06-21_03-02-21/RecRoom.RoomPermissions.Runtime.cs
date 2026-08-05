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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x68C0C10", Offset = "0x68BFE10", VA = "0x1868C0C10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GDAIKDIDOOO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LFMCGPJMHND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CFKMJFDDGFB MMGINJJFMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<HJKMBAJPMOG> MKDPEGIPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBABOKEGAJD HGMDBDABPDH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HJKMBAJPMOG> JAKCIBJPDJH(bool IOFIDOJDOKJ = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HJKMBAJPMOG HBOIEEMDPHB(NBDCAKCJOHF PDDMJDDPDGD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KHHJMIAILHI(NBDCAKCJOHF PDDMJDDPDGD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HJKMBAJPMOG> BNGAJOKAINE(NBDCAKCJOHF PDDMJDDPDGD, bool JLGFALCFAIO = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FNELIBHJDPM(NBDCAKCJOHF LFNNGALMOON, ADJGIOBJONM FBFCMANBBAF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HJKMBAJPMOG NHIIACHBILC(ADJGIOBJONM FBFCMANBBAF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FFBMFNOBKHL<T>(ADJGIOBJONM FBFCMANBBAF, BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, T ANPLPNKHBJM) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IAHBGDJDHBM
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HJDJGDKDFJO(PIKKGCCILDN ALBGHDBNPBA, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMMOGKBPEIB(ref PIKKGCCILDN ALBGHDBNPBA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ADJDCLMPNFD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LMBDENDLMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LEBFFNCONIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool APJDOEAKPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EKAONGKALMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MFAPNAFJFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KOOGHHJGBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OPAGJKCHONE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<ADJGIOBJONM> FJALNAJIODD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68C10A0", Offset = "0x68C02A0", VA = "0x1868C10A0")]
	public static bool KJHJCOLLFOA(this NBDCAKCJOHF NHDBOCCEDNJ, ADJGIOBJONM FBFCMANBBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68C1190", Offset = "0x68C0390", VA = "0x1868C1190")]
	public static bool MMPFKIPJPOP(this NBDCAKCJOHF NHDBOCCEDNJ, ADJGIOBJONM FBFCMANBBAF, ODLKOJAEFAL MGAFFPBPBBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class BAFLICFLDNL : KIAINOECFBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LFMCGPJMHND MFEMLGEPIJM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	[RecRoom.NoEngine.Common.Preserve]
	public BAFLICFLDNL([IDNKOMINBGM(null)] LFMCGPJMHND KNOPFICGEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68B9FB0", Offset = "0x68B91B0", VA = "0x1868B9FB0")]
	private static MJJEHCJGBEI? KPFACHGECNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68BA000", Offset = "0x68B9200", VA = "0x1868BA000", Slot = "4")]
	public bool LOJCFKGJJHM(NBDCAKCJOHF LIJDMMNEDME, NBDCAKCJOHF HALFFCIHHAF, IEnumerable<NBDCAKCJOHF> NGMAOGLLFKG, out GDAIKDIDOOO OEBBAIBMLHK, out CJDLALGDJEB HJMNNMKOFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68BA110", Offset = "0x68B9310", VA = "0x1868BA110")]
	internal bool PAIMNMHEOLE(NBDCAKCJOHF LIJDMMNEDME, NBDCAKCJOHF HALFFCIHHAF, IEnumerable<NBDCAKCJOHF> NGMAOGLLFKG, ODLKOJAEFAL MGAFFPBPBBG, MJJEHCJGBEI? OJPMCLMLGOG, out GDAIKDIDOOO OEBBAIBMLHK, out CJDLALGDJEB HJMNNMKOFEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PJNPHLOGBLH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string OLBDBHFEPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KOPGIOPOEAA<TPermission> DBACPOBMOBK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void KOPGIOPOEAA<TPermission>(TPermission GMLPGJPCIGB);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void BBABOKEGAJD(NBDCAKCJOHF PDDMJDDPDGD);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class GGJFOPNMAIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string OIHJKBDOAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type MDJGDPCIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly PNBGHFNCFPM OJCBOALHHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly BMAJLEEHBOO DKGDAEGBJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public MAJNEKEKHMP GJOOENGFDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public OIOIKGNEDHI DLAKGMLENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public DHJKCMODDEN IKIGKLBPKMC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68BD270", Offset = "0x68BC470", VA = "0x1868BD270")]
	public GGJFOPNMAIJ(Type JFLJLHHINEK, string PPNOBJNGMCH, BMAJLEEHBOO GMLPGJPCIGB, MAJNEKEKHMP MALPLOBEIIF, OIOIKGNEDHI DIMNNMIIMJP, DHJKCMODDEN CBGFHDONEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68BD230", Offset = "0x68BC430", VA = "0x1868BD230")]
	public object HGLNIOHFHBH(object? HPOECFLNEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B014D0", Offset = "0x2B006D0", VA = "0x182B014D0")]
	public void BIJPELJJPAC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68BD180", Offset = "0x68BC380", VA = "0x1868BD180")]
	public void BIJPELJJPAC(Type HLONAJAEKIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class HMDOMNHKIEN<T> : GGJFOPNMAIJ where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string MEBDBHIHBHJ(T ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T BFKAGCOOEOB(string? EGKLMJFBAJN, T DDGOMDBNGFF);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IOIAAMPFONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MEBDBHIHBHJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BFKAGCOOEOB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IOIAAMPFONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x275D020", Offset = "0x275C220", VA = "0x18275D020")]
		internal string JLAGHHAIHJM(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x275CFA0", Offset = "0x275C1A0", VA = "0x18275CFA0")]
		internal object EDGMKHOMBFJ(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1970", Offset = "0x2DD0B70", VA = "0x182DD1970")]
	public HMDOMNHKIEN(BMAJLEEHBOO GMLPGJPCIGB, string PPNOBJNGMCH, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E69C0", Offset = "0x7E5DC0")] HMDOMNHKIEN<T>.MEBDBHIHBHJ MALPLOBEIIF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E6A20", Offset = "0x7E5E20")] HMDOMNHKIEN<T>.BFKAGCOOEOB DIMNNMIIMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2DD02F0", Offset = "0x2DCF4F0", VA = "0x182DD02F0")]
	private static object? AKLCAJOKCCK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E6A80", Offset = "0x7E5E80")] HMDOMNHKIEN<T?>.BFKAGCOOEOB? DIMNNMIIMJP, string? EGKLMJFBAJN, object? DDGOMDBNGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1010", Offset = "0x2DD0210", VA = "0x182DD1010")]
	private static string IOEANABOGCL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E6AE0", Offset = "0x7E5EE0")] HMDOMNHKIEN<T>.MEBDBHIHBHJ PBCEKMLBFMM, object? ACKOJNNBEBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KGFBJJMFLBE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NBDCAKCJOHF POMNKEBNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MDCIINLFDMH EKHCKLMNKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ODLKOJAEFAL GIEKKMDEHMC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<NCHGNKBFHAG> FKFCNKOINMK;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action JHOGFDAKGEE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADJGIOBJONM JAPNJPIHCAG(NBDCAKCJOHF PDDMJDDPDGD);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<NCHGNKBFHAG> MLHKDAFFPPE(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task KIEJDDFMICC(long LNBFDCAEKJF, long HGPBCNPIJHG, IReadOnlyList<KHAGANHEIHC> JHNFLBBPKCE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<NBDCAKCJOHF> AOANAKEMEAO();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JGODJPNDKNH
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68BE490", Offset = "0x68BD690", VA = "0x1868BE490")]
	public static ADJGIOBJONM MFMGGEKHGEF(this KGFBJJMFLBE GMHHMLMMHPL)
	{
		return default(ADJGIOBJONM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class DPHIGEOFKIK : HJKMBAJPMOG, PLBACHBKOKF, ADJDCLMPNFD, PJNPHLOGBLH<BMAJLEEHBOO>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly KFKADAAILGB PCBPEHBOOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly EMAONCENGPJ OGAJBCOJCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? MACPAHHKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? EMOPNHPKGOJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool JNNHDEPPDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68BB1C0", Offset = "0x68BA3C0", VA = "0x1868BB1C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool LCHKOGIKNCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68BB0D0", Offset = "0x68BA2D0", VA = "0x1868BB0D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool ENJHFJCLKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68BAC90", Offset = "0x68B9E90", VA = "0x1868BAC90", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool HMOJDGPNHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68BB170", Offset = "0x68BA370", VA = "0x1868BB170", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool MFDCEFPNMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68BAB00", Offset = "0x68B9D00", VA = "0x1868BAB00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool BJPOLGPEPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68BB3A0", Offset = "0x68BA5A0", VA = "0x1868BB3A0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ADJGIOBJONM IFDIKEFAPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(ADJGIOBJONM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x911DB0", Offset = "0x910FB0", VA = "0x180911DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OLBDBHFEPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68BB4E0", Offset = "0x68BA6E0", VA = "0x1868BB4E0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68BB440", Offset = "0x68BA640", VA = "0x1868BB440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string MDCAOAKCFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68BB4E0", Offset = "0x68BA6E0", VA = "0x1868BB4E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ECNHOHFGBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x991CB0", Offset = "0x990EB0", VA = "0x180991CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x991C00", Offset = "0x990E00", VA = "0x180991C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CPLIJCKFGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68BB350", Offset = "0x68BA550", VA = "0x1868BB350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GDAIKDIDOOO PJEKLNAHMPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68BAB50", Offset = "0x68B9D50", VA = "0x1868BAB50", Slot = "20")]
		get
		{
			return default(GDAIKDIDOOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HGEDOEEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68BAAB0", Offset = "0x68B9CB0", VA = "0x1868BAAB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool NDHHFPFLPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68BC7C0", Offset = "0x68BB9C0", VA = "0x1868BC7C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NDDNDKALIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68BC2A0", Offset = "0x68BB4A0", VA = "0x1868BC2A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ICLOOMHKOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68BB530", Offset = "0x68BA730", VA = "0x1868BB530", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KKBPLGDDDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68BB210", Offset = "0x68BA410", VA = "0x1868BB210", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNPMCOPLMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68BB490", Offset = "0x68BA690", VA = "0x1868BB490", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CAFCBPCDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68BACE0", Offset = "0x68B9EE0", VA = "0x1868BACE0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EICGMBAEGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68BB120", Offset = "0x68BA320", VA = "0x1868BB120", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> IGJNDAIDCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68BC4D0", Offset = "0x68BB6D0", VA = "0x1868BC4D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CJOBHEMGMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68BB1C0", Offset = "0x68BA3C0", VA = "0x1868BB1C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool LJBAGEOFAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68BAB00", Offset = "0x68B9D00", VA = "0x1868BAB00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool AGKIAHAFLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68BB0D0", Offset = "0x68BA2D0", VA = "0x1868BB0D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FEAMCGOEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68BB3F0", Offset = "0x68BA5F0", VA = "0x1868BB3F0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool PPECINMEKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68BABA0", Offset = "0x68B9DA0", VA = "0x1868BABA0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HGOGKAOHHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68BAC90", Offset = "0x68B9E90", VA = "0x1868BAC90", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CCIIPMBCPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68BB260", Offset = "0x68BA460", VA = "0x1868BB260", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IDJLNGONAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68BB170", Offset = "0x68BA370", VA = "0x1868BB170", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IDDPOLNAOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68BB3A0", Offset = "0x68BA5A0", VA = "0x1868BB3A0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KOPGIOPOEAA<BMAJLEEHBOO> DBACPOBMOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68BABF0", Offset = "0x68B9DF0", VA = "0x1868BABF0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68BC2F0", Offset = "0x68BB4F0", VA = "0x1868BC2F0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D230", Offset = "0x2C0C430", VA = "0x182C0D230", Slot = "6")]
	public (bool, T?) OGPILGPFGEN<T>(BMAJLEEHBOO GMLPGJPCIGB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D1F0", Offset = "0x2C0C3F0", VA = "0x182C0D1F0")]
	public DPHIGEOFKIK GLFIGMBKGMC<T>(BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, T ACKOJNNBEBO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68BCA00", Offset = "0x68BBC00", VA = "0x1868BCA00")]
	public DPHIGEOFKIK(ADJGIOBJONM FBFCMANBBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68BC9E0", Offset = "0x68BBBE0", VA = "0x1868BC9E0")]
	public DPHIGEOFKIK(ADJGIOBJONM FBFCMANBBAF, [Optional] string? MACPAHHKAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68BCA20", Offset = "0x68BBC20", VA = "0x1868BCA20")]
	public DPHIGEOFKIK(DPHIGEOFKIK NNBMJJFOHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68BC880", Offset = "0x68BBA80", VA = "0x1868BC880")]
	internal DPHIGEOFKIK(ADJGIOBJONM EPMNEANJDGM, [Optional] string? MACPAHHKAPB, [Optional] DPHIGEOFKIK? NNBMJJFOHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68BC3B0", Offset = "0x68BB5B0", VA = "0x1868BC3B0")]
	public static PNBGHFNCFPM MFEGHLHMEBP(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return default(PNBGHFNCFPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68BC390", Offset = "0x68BB590", VA = "0x1868BC390")]
	public void MEFFCMINIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68BC530", Offset = "0x68BB730", VA = "0x1868BC530")]
	internal DPHIGEOFKIK OPKPIGLBFOI(DPHIGEOFKIK AFAIAFGHLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68BAD30", Offset = "0x68B9F30", VA = "0x1868BAD30")]
	internal IReadOnlyCollection<BMAJLEEHBOO> DJIGAFGLBEH(DPHIGEOFKIK NNBMJJFOHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68BA790", Offset = "0x68B9990", VA = "0x1868BA790")]
	public bool AHBLIJFDBHJ(BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, string BMCLCBCKPCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68BC190", Offset = "0x68BB390", VA = "0x1868BC190")]
	public (bool, string) JMEGLDGNNNA(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68BC430", Offset = "0x68BB630", VA = "0x1868BC430")]
	internal void OHGHNJBOHEE(BMAJLEEHBOO GMLPGJPCIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68BA870", Offset = "0x68B9A70", VA = "0x1868BA870")]
	public HAOFAINHOJE ANAJLIEIKDG(Func<ADJGIOBJONM, Guid> BLAJOMGHFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x68BB580", Offset = "0x68BA780", VA = "0x1868BB580")]
	public void IAOKONHGBHK(HAOFAINHOJE APAGHIHHOOB, Func<Guid, ADJGIOBJONM> BDFFIAJOICK, [Optional] ADJGIOBJONM? EACIKLMCKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68BB2B0", Offset = "0x68BA4B0", VA = "0x1868BB2B0")]
	[CompilerGenerated]
	private void EOJGKMGBCNH(BMAJLEEHBOO DDABNEBAECK, EIHMNMLEOCI OGMJFLKLMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KIAINOECFBG
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOJCFKGJJHM(NBDCAKCJOHF LIJDMMNEDME, NBDCAKCJOHF HALFFCIHHAF, IEnumerable<NBDCAKCJOHF> NGMAOGLLFKG, out GDAIKDIDOOO OEBBAIBMLHK, out CJDLALGDJEB HJMNNMKOFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CJDLALGDJEB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PLBACHBKOKF
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CPLIJCKFGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool HGEDOEEJOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool NDHHFPFLPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NDDNDKALIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool ICLOOMHKOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool KKBPLGDDDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KNPMCOPLMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool CAFCBPCDJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool EICGMBAEGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FEAMCGOEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool PPECINMEKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CCIIPMBCPDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> IGJNDAIDCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GDAIKDIDOOO PJEKLNAHMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HJKMBAJPMOG : PLBACHBKOKF, ADJDCLMPNFD, PJNPHLOGBLH<BMAJLEEHBOO>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string MDCAOAKCFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ADJGIOBJONM IFDIKEFAPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) OGPILGPFGEN<T>(BMAJLEEHBOO GMLPGJPCIGB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class CHGCCIDPHDD
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? AADCJFEFMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	protected CHGCCIDPHDD(object? BNFNLNLOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FAEEFOMAPPM(object? ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class LJOAAMLPGPC<T> : CHGCCIDPHDD where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T ADJAKJILKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> DFLGKGJPBLB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38BC7A0", Offset = "0x38BB9A0", VA = "0x1838BC7A0", Slot = "4")]
	public override bool FAEEFOMAPPM(object? ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38BC2C0", Offset = "0x38BB4C0", VA = "0x1838BC2C0")]
	public bool AGBEONNAGGP(T ILBFKMGONNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x38BC9C0", Offset = "0x38BBBC0", VA = "0x1838BC9C0")]
	public LJOAAMLPGPC(T DDGOMDBNGFF, IEqualityComparer<T> DFLGKGJPBLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class LOAIEIALOBM
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum ADCJOJFGCHG
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
	public static readonly Guid KLKILHLFIIB;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid NMMKBHIEOLK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid JHNOJJKDAIC;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid IPMLBLHJGMM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid PMOFBDEPDCP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly DNFLOEAJHPJ<ADJGIOBJONM, Guid> PNFKOALIANA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<ADJGIOBJONM> EIKGOLAMENE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68C06A0", Offset = "0x68BF8A0", VA = "0x1868C06A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68C08A0", Offset = "0x68BFAA0", VA = "0x1868C08A0")]
	public static ADJGIOBJONM NJDLBDEELKI(Guid CNDCJIFNLGE)
	{
		return default(ADJGIOBJONM);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x68C05B0", Offset = "0x68BF7B0", VA = "0x1868C05B0")]
	public static Guid DBHIAEONBGF(ADJGIOBJONM FBFCMANBBAF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x68C0800", Offset = "0x68BFA00", VA = "0x1868C0800")]
	public static bool KICOJMAEKGB(ADJGIOBJONM FBFCMANBBAF, out Guid CNDCJIFNLGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x68C0510", Offset = "0x68BF710", VA = "0x1868C0510")]
	public static bool ADEEDFCPHJE(Guid CNDCJIFNLGE, out ADJGIOBJONM FBFCMANBBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68C07D0", Offset = "0x68BF9D0", VA = "0x1868C07D0")]
	public static ADJGIOBJONM GGNFBOEOCPL(ADJGIOBJONM FBFCMANBBAF)
	{
		return default(ADJGIOBJONM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68C0720", Offset = "0x68BF920", VA = "0x1868C0720")]
	public static ADCJOJFGCHG GFLCAGEBNIK(ADJGIOBJONM FFJFGEGJKMG)
	{
		return default(ADCJOJFGCHG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68C0660", Offset = "0x68BF860", VA = "0x1868C0660")]
	internal static ADJGIOBJONM EIGAAAANMHE(ADCJOJFGCHG LPOGEJGMMLI)
	{
		return default(ADJGIOBJONM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string MAJNEKEKHMP(object? ACKOJNNBEBO);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object OIOIKGNEDHI(string? EGKLMJFBAJN, [Optional] object DDGOMDBNGFF);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate CHGCCIDPHDD DHJKCMODDEN();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class KFKADAAILGB
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class PJPFEDIFLHA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static PJPFEDIFLHA EBEPLDELFOG;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68C6CC0", Offset = "0x68C5EC0", VA = "0x1868C6CC0", Slot = "4")]
		public bool Equals(List<string> JNIPLDLJAIJ, List<string> GEADFOLNEOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68C6E20", Offset = "0x68C6020", VA = "0x1868C6E20", Slot = "5")]
		public int GetHashCode(List<string> BHEOHCEHIBM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PJPFEDIFLHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class IHPLGLOONOI : IKDIEMJDFDE<GDAIKDIDOOO>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68BE360", Offset = "0x68BD560", VA = "0x1868BE360", Slot = "9")]
		public override string IOEANABOGCL(GDAIKDIDOOO MPABDLGNPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68BE170", Offset = "0x68BD370", VA = "0x1868BE170", Slot = "10")]
		protected override bool ELAINAAHEGM(string MPABDLGNPLC, out GDAIKDIDOOO ACKOJNNBEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68BE450", Offset = "0x68BD650", VA = "0x1868BE450")]
		public IHPLGLOONOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly JPKFECFMBJH NMAMIACFDII;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly IHPLGLOONOI JAPDCELDNHH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<GGJFOPNMAIJ> PECMJENGGPD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<BMAJLEEHBOO> CAJIEFAFKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<BMAJLEEHBOO, GGJFOPNMAIJ> NFIAOECLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68C01A0", Offset = "0x68BF3A0", VA = "0x1868C01A0")]
	public KFKADAAILGB([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E6BC0", Offset = "0x7E5FC0")] IList<GGJFOPNMAIJ> EJFMGMCLCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68BF5C0", Offset = "0x68BE7C0", VA = "0x1868BF5C0")]
	public GGJFOPNMAIJ OGKKCONDIJE(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OPBLOBPPNBP : IAHBGDJDHBM, LFMCGPJMHND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AJBLIFPPKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DPHIGEOFKIK newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public AJBLIFPPKLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68B9F80", Offset = "0x68B9180", VA = "0x1868B9F80")]
		internal bool AFKAHCIFLLN(DPHIGEOFKIK rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MDCOIGBJCBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ADJGIOBJONM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public MDCOIGBJCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x68C0C00", Offset = "0x68BFE00", VA = "0x1868C0C00")]
		internal bool CFNCCPINFGD(ADJGIOBJONM r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KCNLJINBLHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public PIKKGCCILDN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OPBLOBPPNBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NCHGNKBFHAG <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NCHGNKBFHAG <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E7150", Offset = "0x7E6550")]
		private TaskAwaiter<NCHGNKBFHAG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KCNLJINBLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68BEE10", Offset = "0x68BE010", VA = "0x1868BEE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HACBJMPOFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HACBJMPOFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68BD300", Offset = "0x68BC500", VA = "0x1868BD300")]
		internal void NHJEKAICJKO(HAOFAINHOJE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68BD400", Offset = "0x68BC600", VA = "0x1868BD400")]
		internal void PNKMKMFIEPE(HAOFAINHOJE r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KHEOPMAHFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PIKKGCCILDN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DALEIPJCAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E71B0", Offset = "0x7E65B0")]
		public Func<HAOFAINHOJE, EIHMNMLEOCI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DALEIPJCAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68BA640", Offset = "0x68B9840", VA = "0x1868BA640")]
		internal void IPCIFHPMCIM(HAOFAINHOJE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x68BA6B0", Offset = "0x68B98B0", VA = "0x1868BA6B0")]
		internal void JMAFFJOHGGI(HAOFAINHOJE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68BA720", Offset = "0x68B9920", VA = "0x1868BA720")]
		internal void LIOGOMGOMCA(HAOFAINHOJE r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AFCKDDNNCCB<T> where T : notnull
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
			public AFCKDDNNCCB<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E7270", Offset = "0x7E6670")]
			private TaskAwaiter<NCHGNKBFHAG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2784660", Offset = "0x2783860", VA = "0x182784660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OPBLOBPPNBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BMAJLEEHBOO rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public ADJGIOBJONM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public PNBGHFNCFPM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public AFCKDDNNCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x466EBC0", Offset = "0x466DDC0", VA = "0x18466EBC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AFCKDDNNCCB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void MJIMDLLLCBF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct GMINLLJEIIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<KHAGANHEIHC> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HEOPMNGJBKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KGFBJJMFLBE rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PIKKGCCILDN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E72D0", Offset = "0x7E66D0")]
		public IReadOnlyDictionary<ADJGIOBJONM, DPHIGEOFKIK> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public OFJLDPEJIPH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E7330", Offset = "0x7E6730")]
		private List<KHAGANHEIHC> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<HAOFAINHOJE> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HAOFAINHOJE <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private ADJGIOBJONM <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private DPHIGEOFKIK <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<BMAJLEEHBOO> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<BMAJLEEHBOO> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private BMAJLEEHBOO <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PNBGHFNCFPM <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E7390", Offset = "0x7E6790")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HEOPMNGJBKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68BD530", Offset = "0x68BC730", VA = "0x1868BD530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KGFBJJMFLBE GMHHMLMMHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JNGEBBJKHHB GDBBHMFIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly OFJLDPEJIPH ENNFFJHCNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, DPHIGEOFKIK> GIPGBKIMHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<ADJGIOBJONM, DPHIGEOFKIK> DFBMMPIPDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<ADJGIOBJONM, DPHIGEOFKIK> DBBCLPFNCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<DPHIGEOFKIK> BCECICOANGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DEFGHFHBCFA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly BMAJLEEHBOO[] LGMBBGFODCN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CFKMJFDDGFB MMGINJJFMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<HJKMBAJPMOG> MKDPEGIPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x68C24C0", Offset = "0x68C16C0", VA = "0x1868C24C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BBABOKEGAJD HGMDBDABPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68C2990", Offset = "0x68C1B90", VA = "0x1868C2990", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x68C5510", Offset = "0x68C4710", VA = "0x1868C5510", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68C2010", Offset = "0x68C1210", VA = "0x1868C2010")]
	[MPKPGFJAEKF(MCJFPPEDLHH.Room, OJBJGAAILBP.None)]
	private static void CGPKALMGMIN(JLCNCEFHLIA LBDNCAMEGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68C6A30", Offset = "0x68C5C30", VA = "0x1868C6A30")]
	[UnityEngine.Scripting.Preserve]
	internal OPBLOBPPNBP([IDNKOMINBGM(null)] KGFBJJMFLBE MCIDBCHNOBE, [IDNKOMINBGM(null)] JNGEBBJKHHB IBCHKGNAHKF, [IDNKOMINBGM(null)] OFJLDPEJIPH ENNFFJHCNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68C2510", Offset = "0x68C1710", VA = "0x1868C2510", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68C57E0", Offset = "0x68C49E0", VA = "0x1868C57E0")]
	private void NKDEJAHJBFC(IEnumerable<DPHIGEOFKIK> FJAELJIDDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68C49E0", Offset = "0x68C3BE0", VA = "0x1868C49E0", Slot = "12")]
	public bool KHHJMIAILHI(NBDCAKCJOHF PDDMJDDPDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68C47B0", Offset = "0x68C39B0", VA = "0x1868C47B0")]
	private void JHOGFDAKGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68C55B0", Offset = "0x68C47B0", VA = "0x1868C55B0")]
	private void NGDCELEJDNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68C4730", Offset = "0x68C3930", VA = "0x1868C4730", Slot = "10")]
	public IReadOnlyList<HJKMBAJPMOG> JAKCIBJPDJH(bool IOFIDOJDOKJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68C2F50", Offset = "0x68C2150", VA = "0x1868C2F50", Slot = "11")]
	public HJKMBAJPMOG HBOIEEMDPHB(NBDCAKCJOHF PDDMJDDPDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68C3060", Offset = "0x68C2260", VA = "0x1868C3060")]
	private ADJGIOBJONM HEGOCJGEGIB(NBDCAKCJOHF PDDMJDDPDGD)
	{
		return default(ADJGIOBJONM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68C2A30", Offset = "0x68C1C30", VA = "0x1868C2A30", Slot = "14")]
	public bool FNELIBHJDPM(NBDCAKCJOHF LFNNGALMOON, ADJGIOBJONM FBFCMANBBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68C5730", Offset = "0x68C4930", VA = "0x1868C5730", Slot = "15")]
	public HJKMBAJPMOG NHIIACHBILC(ADJGIOBJONM FBFCMANBBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68C5FD0", Offset = "0x68C51D0", VA = "0x1868C5FD0")]
	private static bool NLDNOGBNEPB(NIBNONHEILJ OIIPDCBLKDH, ADJGIOBJONM FBFCMANBBAF, out HAOFAINHOJE? IEDBPFFMFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68C23C0", Offset = "0x68C15C0", VA = "0x1868C23C0")]
	private static void DEIIMCCJNOG(NIBNONHEILJ OIIPDCBLKDH, Action<HAOFAINHOJE> DNMPKKGPGJE, ADJGIOBJONM FAAPDDHPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68C21C0", Offset = "0x68C13C0", VA = "0x1868C21C0")]
	private static void DEIIMCCJNOG(NIBNONHEILJ OIIPDCBLKDH, Action<HAOFAINHOJE> DNMPKKGPGJE, Predicate<ADJGIOBJONM> NHILKJEBGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68C2620", Offset = "0x68C1820", VA = "0x1868C2620")]
	private void EEHGOAFJDIL(NBDCAKCJOHF PDDMJDDPDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68C4030", Offset = "0x68C3230", VA = "0x1868C4030", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCNLJINBLHJ))]
	public Task HJDJGDKDFJO([CanBeNull] PIKKGCCILDN ALBGHDBNPBA, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
	public void BMMOGKBPEIB(ref PIKKGCCILDN ALBGHDBNPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68C44B0", Offset = "0x68C36B0", VA = "0x1868C44B0")]
	private void IJJGOJAEAIL(NIBNONHEILJ OIDJJDKCDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68C13E0", Offset = "0x68C05E0", VA = "0x1868C13E0")]
	internal static string ALDCEEHOMIN(KGFBJJMFLBE GMHHMLMMHPL, PIKKGCCILDN ALBGHDBNPBA, IReadOnlyDictionary<ADJGIOBJONM, DPHIGEOFKIK> DFBMMPIPDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68C3120", Offset = "0x68C2320", VA = "0x1868C3120")]
	private static void HJAIMNCPOMM(PIKKGCCILDN ALBGHDBNPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68C41A0", Offset = "0x68C33A0", VA = "0x1868C41A0")]
	private static void HNCCGNPGMLO(NIBNONHEILJ FALLEBFIGEA, IReadOnlyDictionary<ADJGIOBJONM, DPHIGEOFKIK> DFBMMPIPDCP, StringBuilder BKNECCOEGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x68C2830", Offset = "0x68C1A30", VA = "0x1868C2830")]
	private static bool ELBFEMMMBPF(string BGCPNCBDLGF, out Guid CEAKDCFEECJ, out ADJGIOBJONM FBFCMANBBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x68C19F0", Offset = "0x68C0BF0", VA = "0x1868C19F0")]
	private static void CFPLBOEJKBB(PIKKGCCILDN ALBGHDBNPBA, StringBuilder BKNECCOEGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4C90", Offset = "0x2EA3E90", VA = "0x182EA4C90", Slot = "16")]
	public bool FFBMFNOBKHL<T>(ADJGIOBJONM FBFCMANBBAF, BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, T ANPLPNKHBJM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68C2680", Offset = "0x68C1880", VA = "0x1868C2680")]
	private void EIOMPADEHOO(ADJGIOBJONM FBFCMANBBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68C6840", Offset = "0x68C5A40", VA = "0x1868C6840")]
	private bool OPBIIGEFAAP(NBDCAKCJOHF PDDMJDDPDGD, ADJGIOBJONM FBFCMANBBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68C51F0", Offset = "0x68C43F0", VA = "0x1868C51F0")]
	internal DPHIGEOFKIK LEIPOILJPFA(NBDCAKCJOHF PDDMJDDPDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68C1700", Offset = "0x68C0900", VA = "0x1868C1700", Slot = "13")]
	public IReadOnlyList<HJKMBAJPMOG> BNGAJOKAINE(NBDCAKCJOHF PDDMJDDPDGD, bool JLGFALCFAIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x68C47C0", Offset = "0x68C39C0", VA = "0x1868C47C0")]
	internal IReadOnlyList<DPHIGEOFKIK> KFLBHCPDBFJ(NBDCAKCJOHF PDDMJDDPDGD, bool JLGFALCFAIO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x68C4AB0", Offset = "0x68C3CB0", VA = "0x1868C4AB0")]
	private void KMDHBHOAOFA(NCHGNKBFHAG CJFNINJLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x68C63C0", Offset = "0x68C55C0", VA = "0x1868C63C0")]
	private static bool ODNEPCGEOKL(DPHIGEOFKIK FPNJHJODBCE, IReadOnlyDictionary<ADJGIOBJONM, DPHIGEOFKIK> DFBMMPIPDCP, out IReadOnlyList<BMAJLEEHBOO> JIGGIOGHKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x68C66A0", Offset = "0x68C58A0", VA = "0x1868C66A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HEOPMNGJBKC))]
	private static Task OLHEINBCDLM(KGFBJJMFLBE GMHHMLMMHPL, PIKKGCCILDN ALBGHDBNPBA, IReadOnlyDictionary<ADJGIOBJONM, DPHIGEOFKIK> DFBMMPIPDCP, OFJLDPEJIPH ENNFFJHCNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x68C1710", Offset = "0x68C0910", VA = "0x1868C1710")]
	[CompilerGenerated]
	internal static void BNIICCIOMJB(Func<HAOFAINHOJE, EIHMNMLEOCI> JKGLJLDBGML, ref KHEOPMAHFMA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x68C2BC0", Offset = "0x68C1DC0", VA = "0x1868C2BC0")]
	[CompilerGenerated]
	internal static bool GIKBGDPPEPJ(ADJGIOBJONM FBFCMANBBAF, BMAJLEEHBOO GMLPGJPCIGB, out KHAGANHEIHC GBLCAHGNOIF, ref GMINLLJEIIK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum BMAJLEEHBOO
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
internal class EMAONCENGPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<BMAJLEEHBOO, bool> OJDKPDLONIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<BMAJLEEHBOO, CHGCCIDPHDD> BKPOFNAMIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly KFKADAAILGB LNHGLOIODOK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68BCF30", Offset = "0x68BC130", VA = "0x1868BCF30")]
	public EMAONCENGPJ(KFKADAAILGB LNHGLOIODOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68BCE00", Offset = "0x68BC000", VA = "0x1868BCE00")]
	public bool OFKABJENLDJ(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x33C2D30", Offset = "0x33C1F30", VA = "0x1833C2D30")]
	public bool KMGHHAJFPEL<T>(BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, T ACKOJNNBEBO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x33C3040", Offset = "0x33C2240", VA = "0x1833C3040")]
	public (bool, T?) LDFHFGOMLAB<T>(BMAJLEEHBOO GMLPGJPCIGB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68BCAB0", Offset = "0x68BBCB0", VA = "0x1868BCAB0")]
	public bool KMGHHAJFPEL(BMAJLEEHBOO GMLPGJPCIGB, bool ILCKLMFHNBD, object ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x68BCB90", Offset = "0x68BBD90", VA = "0x1868BCB90")]
	public (bool, object) LDFHFGOMLAB(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x33C2A80", Offset = "0x33C1C80", VA = "0x1833C2A80")]
	private void BIJPELJJPAC<T>(BMAJLEEHBOO GMLPGJPCIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68BCE70", Offset = "0x68BC070", VA = "0x1868BCE70")]
	private CHGCCIDPHDD PIFMOOIJHOK(BMAJLEEHBOO GMLPGJPCIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68BCC80", Offset = "0x68BBE80", VA = "0x1868BCC80")]
	public void MEFFCMINIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CFKMJFDDGFB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	HJKMBAJPMOG OJBHKIMIMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class JNGEBBJKHHB : CFKMJFDDGFB
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static JNGEBBJKHHB NEFPBLABMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly DPHIGEOFKIK LBDNHMCBNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<DPHIGEOFKIK> GFGMHAICAFN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HJKMBAJPMOG OJBHKIMIMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68BED10", Offset = "0x68BDF10", VA = "0x1868BED10")]
	public JNGEBBJKHHB(DPHIGEOFKIK MAFNLDMIIJJ, IReadOnlyList<DPHIGEOFKIK> PGLCHHAAKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68BE4F0", Offset = "0x68BD6F0", VA = "0x1868BE4F0")]
	private static JNGEBBJKHHB PIDJKJPIDNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum CCMMDLJJFLC
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

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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68E1BB0", Offset = "0x68E0BB0", VA = "0x1868E1BB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CCBKCKJLLDC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GNGIGJPAAHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OPKOGGOJHOA FMEPIKALHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<CJCCIKAKKHK> HHOAHBIEMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MDEMAIJAIOA DBGPLAGMDEJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CJCCIKAKKHK> EJAHBOIOMMK(bool MHFEGNHCEJP = false);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CJCCIKAKKHK ELIEOIPJIIC(PIPFLAHHDDO IOGAENGPLPG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FGMKKJDCPPG(PIPFLAHHDDO IOGAENGPLPG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CJCCIKAKKHK> EGIEKCFGMLM(PIPFLAHHDDO IOGAENGPLPG, bool POMGPNBFEPC = false);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KFCPICFOPOE(PIPFLAHHDDO IPFPENIBBBM, GHEPHOPAIBD FAGEECHHFAJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CJCCIKAKKHK LKHHAOKNCFO(GHEPHOPAIBD FAGEECHHFAJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LKOAAMNBNJK<T>(GHEPHOPAIBD FAGEECHHFAJ, CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, T IELOEMGHLEA) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GINBGGJNEBN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GGAJJLLDHPG(OCMKINIOLDE CAPINCBBCIM, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMLJIKNEJPO(ref OCMKINIOLDE CAPINCBBCIM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LMMIIPJHCLD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BMJNECAFILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GLPFBEDOCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DPDGKBMLEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LAABGJDCFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BNCFMFCJBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OOMNCHAMNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GBPDNOGAPOL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IReadOnlyList<GHEPHOPAIBD> IDHNEHHHNBJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68D9640", Offset = "0x68D8640", VA = "0x1868D9640")]
	public static bool JOEJNGDCCCE(this PIPFLAHHDDO AFPDMBJFOGD, GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68D95C0", Offset = "0x68D85C0", VA = "0x1868D95C0")]
	public static bool IJMLAIJKLKE(this PIPFLAHHDDO AFPDMBJFOGD, GHEPHOPAIBD FAGEECHHFAJ, EAHJJHFFELH PCNPBCBLELJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal class HDNOIPDMBLK : DMKDPIMJEPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GNGIGJPAAHG LOPKCFCAEHM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	[RecRoom.NoEngine.Common.Preserve]
	public HDNOIPDMBLK([JFLEHDEIONF(null)] GNGIGJPAAHG KPPCFAEHMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68D9F40", Offset = "0x68D8F40", VA = "0x1868D9F40")]
	private static DFNGBBLKKGN? NOBNKBJGANB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68D9E30", Offset = "0x68D8E30", VA = "0x1868D9E30", Slot = "4")]
	public bool IDDEACDKCFA(PIPFLAHHDDO LCLNEHIEJAI, PIPFLAHHDDO HNCFNCCKCKB, IEnumerable<PIPFLAHHDDO> CHEKPJLBAGH, out CCBKCKJLLDC ADNAMAEPPPD, out OPNOLCCNNNG EFOLPFBIJEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68D9900", Offset = "0x68D8900", VA = "0x1868D9900")]
	internal bool FAKOLKNCNHL(PIPFLAHHDDO LCLNEHIEJAI, PIPFLAHHDDO HNCFNCCKCKB, IEnumerable<PIPFLAHHDDO> CHEKPJLBAGH, EAHJJHFFELH PCNPBCBLELJ, DFNGBBLKKGN? AGIGLPFACCH, out CCBKCKJLLDC ADNAMAEPPPD, out OPNOLCCNNNG EFOLPFBIJEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HAHCEJIIDLA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string NKFNNELENJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event IECDMKNJDAF<TPermission> LBICNGOMBMF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void IECDMKNJDAF<TPermission>(TPermission EDEEBIHLFJB);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate void MDEMAIJAIOA(PIPFLAHHDDO IOGAENGPLPG);
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class NNBLEOPPGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly string NLMFJPMHDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly Type OFKFACICHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly NGKCPHKDOCG IOBOOBBHAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly CEMDLJMNFPP PEFKBMDLBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public KPLEMJBDCID PEICLGKAEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NFEDHHCFDHG BECLEMFPFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public LBOLKLLAEJH CHCPOJAIKHP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68E1B20", Offset = "0x68E0B20", VA = "0x1868E1B20")]
	public NNBLEOPPGGI(Type LJEFHHCBBDP, string LHJOKPNKNEM, CEMDLJMNFPP EDEEBIHLFJB, KPLEMJBDCID LHMDEMKJKIN, NFEDHHCFDHG KEAHIGNAAAL, LBOLKLLAEJH EPMDIAFBDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A30", Offset = "0x68E0A30", VA = "0x1868E1A30")]
	public object AFAMMPEGNPC(object? BKLMLPFOMCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2525B70", Offset = "0x2524B70", VA = "0x182525B70")]
	public void DNBFGFFCBMB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68E1A70", Offset = "0x68E0A70", VA = "0x1868E1A70")]
	public void DNBFGFFCBMB(Type MDNAFKJCNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class ACIPKCEKCFA<T> : NNBLEOPPGGI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal delegate string DAHHEKHEBLN(T CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal delegate T CDAKPMPIKME(string? FCLIBJCLECD, T PNJDHPAJOAO);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class EOHELMMLOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DAHHEKHEBLN serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public CDAKPMPIKME parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EOHELMMLOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC408E0", Offset = "0xC3F8E0", VA = "0x180C408E0")]
		internal string CKJNPEBKMCD(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC409D0", Offset = "0xC3F9D0", VA = "0x180C409D0")]
		internal object MJJEDNNJMFO(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC040", Offset = "0x2BEB040", VA = "0x182BEC040")]
	public ACIPKCEKCFA(CEMDLJMNFPP EDEEBIHLFJB, string LHJOKPNKNEM, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758800", Offset = "0x757C00")] ACIPKCEKCFA<T>.DAHHEKHEBLN LHMDEMKJKIN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758860", Offset = "0x757C60")] ACIPKCEKCFA<T>.CDAKPMPIKME KEAHIGNAAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA640", Offset = "0x2BE9640", VA = "0x182BEA640")]
	private static object? EILKNJCKJNI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7588C0", Offset = "0x757CC0")] ACIPKCEKCFA<T?>.CDAKPMPIKME? KEAHIGNAAAL, string? FCLIBJCLECD, object? PNJDHPAJOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BEB060", Offset = "0x2BEA060", VA = "0x182BEB060")]
	private static string IKBIGFALLCH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758920", Offset = "0x757D20")] ACIPKCEKCFA<T>.DAHHEKHEBLN AFNPKMJNJDG, object? CKDFGEALFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DKCFDHMFNAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PIPFLAHHDDO KBJDFGPGPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GDOIHMDILDL HJOOLFCHIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EAHJJHFFELH NHAIPHEJKAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<PKMEAFAIOCC> LBPJPOFMOPJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NILMFPHLOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GHEPHOPAIBD EDEINCAHFEN(PIPFLAHHDDO IOGAENGPLPG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PKMEAFAIOCC> KLDIENAOKAL(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IMKJHFEMGLK(long IHGIEILPMCA, long BPCDOJMJPPI, IReadOnlyList<JMOGAMJIIAA> DBDNGGAOGNM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PIPFLAHHDDO> IGIGHMENGJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PCODAONJLJE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68E34B0", Offset = "0x68E24B0", VA = "0x1868E34B0")]
	public static GHEPHOPAIBD PLEHCCDIJAC(this DKCFDHMFNAK HMIJDLMMOPK)
	{
		return default(GHEPHOPAIBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class FJCKLOIMNIL : CJCCIKAKKHK, HBFOEJJNHLA, LMMIIPJHCLD, HAHCEJIIDLA<CEMDLJMNFPP>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal static readonly NKBLGHAKFMH JKPGHKEKBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly OEDJHNDCGAK NHOBEPMOEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private string? FLEBEDDPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private string? GNKJPKAPPHD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private bool KIHPILMBOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68D7850", Offset = "0x68D6850", VA = "0x1868D7850", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private bool EBFLMAOKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68D9170", Offset = "0x68D8170", VA = "0x1868D9170", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private bool GMCLOMKAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68D80C0", Offset = "0x68D70C0", VA = "0x1868D80C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private bool AEHCDEHGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68D7CE0", Offset = "0x68D6CE0", VA = "0x1868D7CE0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private bool PMGOHLMLNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68D8E10", Offset = "0x68D7E10", VA = "0x1868D8E10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private bool JDPFFPCGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68D7340", Offset = "0x68D6340", VA = "0x1868D7340", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GHEPHOPAIBD LMGLJLFBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D0", Offset = "0x85E3D0", VA = "0x18085F3D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(GHEPHOPAIBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x91B1A0", Offset = "0x91A1A0", VA = "0x18091B1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string NKFNNELENJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68D9260", Offset = "0x68D8260", VA = "0x1868D9260", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68D8DC0", Offset = "0x68D7DC0", VA = "0x1868D8DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public string MALFCKDJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x68D9260", Offset = "0x68D8260", VA = "0x1868D9260", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool ANLNPJOJCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x913220", Offset = "0x912220", VA = "0x180913220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x913310", Offset = "0x912310", VA = "0x180913310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DFLDICINKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68D7570", Offset = "0x68D6570", VA = "0x1868D7570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CCBKCKJLLDC IHHKIDIFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68D92B0", Offset = "0x68D82B0", VA = "0x1868D92B0", Slot = "20")]
		get
		{
			return default(CCBKCKJLLDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool ADCBHINMDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68D72A0", Offset = "0x68D62A0", VA = "0x1868D72A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JGJHBOPPEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68D7C40", Offset = "0x68D6C40", VA = "0x1868D7C40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KOMMCDEBJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68D7E30", Offset = "0x68D6E30", VA = "0x1868D7E30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool CKNKEINLNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x68D7390", Offset = "0x68D6390", VA = "0x1868D7390", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool OCOLILFDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68D7480", Offset = "0x68D6480", VA = "0x1868D7480", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JOOIJIFGFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x68D72F0", Offset = "0x68D62F0", VA = "0x1868D72F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool AICHOHLHIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68D7C90", Offset = "0x68D6C90", VA = "0x1868D7C90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool IKIMBCLDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68D7430", Offset = "0x68D6430", VA = "0x1868D7430", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyList<string> FNKCHIDNHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68D7DD0", Offset = "0x68D6DD0", VA = "0x1868D7DD0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool DECOMBFAJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68D7850", Offset = "0x68D6850", VA = "0x1868D7850", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GEEGFMDGIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68D8E10", Offset = "0x68D7E10", VA = "0x1868D8E10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HPPGDBDDKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68D9170", Offset = "0x68D8170", VA = "0x1868D9170", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool ALLCKCCNMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68D9210", Offset = "0x68D8210", VA = "0x1868D9210", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool DEKIHEJBPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68D91C0", Offset = "0x68D81C0", VA = "0x1868D91C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JANAAKCPDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68D80C0", Offset = "0x68D70C0", VA = "0x1868D80C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool CEDHMFJHMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68D73E0", Offset = "0x68D63E0", VA = "0x1868D73E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BFBHPKJOHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68D7CE0", Offset = "0x68D6CE0", VA = "0x1868D7CE0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GKAKIDDNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68D7340", Offset = "0x68D6340", VA = "0x1868D7340", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IECDMKNJDAF<CEMDLJMNFPP> LBICNGOMBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68D74D0", Offset = "0x68D64D0", VA = "0x1868D74D0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68D8110", Offset = "0x68D7110", VA = "0x1868D8110", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FD80", Offset = "0x1B6ED80", VA = "0x181B6FD80", Slot = "6")]
	public (bool, T?) INMGIGFONMG<T>(CEMDLJMNFPP EDEEBIHLFJB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FD40", Offset = "0x1B6ED40", VA = "0x181B6FD40")]
	public FJCKLOIMNIL AIBEIJJMABO<T>(CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, T CKDFGEALFAK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68D93B0", Offset = "0x68D83B0", VA = "0x1868D93B0")]
	public FJCKLOIMNIL(GHEPHOPAIBD FAGEECHHFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68D9390", Offset = "0x68D8390", VA = "0x1868D9390")]
	public FJCKLOIMNIL(GHEPHOPAIBD FAGEECHHFAJ, [Optional] string? FLEBEDDPGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x68D93D0", Offset = "0x68D83D0", VA = "0x1868D93D0")]
	public FJCKLOIMNIL(FJCKLOIMNIL DKCMNOLECHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68D9460", Offset = "0x68D8460", VA = "0x1868D9460")]
	internal FJCKLOIMNIL(GHEPHOPAIBD JHOABEFGOLE, [Optional] string? FLEBEDDPGCN, [Optional] FJCKLOIMNIL? DKCMNOLECHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x68D8E60", Offset = "0x68D7E60", VA = "0x1868D8E60")]
	public static NGKCPHKDOCG LKNGBGMNAHG(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return default(NGKCPHKDOCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68D9300", Offset = "0x68D8300", VA = "0x1868D9300")]
	public void PPNMDJOEFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x68D75C0", Offset = "0x68D65C0", VA = "0x1868D75C0")]
	internal FJCKLOIMNIL CKPDLHEMEGA(FJCKLOIMNIL LPDCOJDNPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68D78A0", Offset = "0x68D68A0", VA = "0x1868D78A0")]
	internal IReadOnlyCollection<CEMDLJMNFPP> ENIJEBFJHBA(FJCKLOIMNIL DKCMNOLECHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68D8FF0", Offset = "0x68D7FF0", VA = "0x1868D8FF0")]
	public bool MEJMAIDAKMD(CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, string BPOOOJAHCJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x68D8EE0", Offset = "0x68D7EE0", VA = "0x1868D8EE0")]
	public (bool, string) MDBMKGLNCMO(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68D90D0", Offset = "0x68D80D0", VA = "0x1868D90D0")]
	internal void MJHOCKBFBEI(CEMDLJMNFPP EDEEBIHLFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68D7E80", Offset = "0x68D6E80", VA = "0x1868D7E80")]
	public GOIJELILNBO HOEPDNCNJAF(Func<GHEPHOPAIBD, Guid> OBJBKFCEDGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x68D81B0", Offset = "0x68D71B0", VA = "0x1868D81B0")]
	public void INJAOFDBJAG(GOIJELILNBO FKMANJEHMLJ, Func<Guid, GHEPHOPAIBD> EKEPKMHFOAO, [Optional] GHEPHOPAIBD? GNJMFBMCIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x68D7D30", Offset = "0x68D6D30", VA = "0x1868D7D30")]
	[CompilerGenerated]
	private void GMOBDMDCFFM(CEMDLJMNFPP GDCCABACHKA, GHLBAPIONFL JEEKOLHDNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DMKDPIMJEPB
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDDEACDKCFA(PIPFLAHHDDO LCLNEHIEJAI, PIPFLAHHDDO HNCFNCCKCKB, IEnumerable<PIPFLAHHDDO> CHEKPJLBAGH, out CCBKCKJLLDC ADNAMAEPPPD, out OPNOLCCNNNG EFOLPFBIJEO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OPNOLCCNNNG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HBFOEJJNHLA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DFLDICINKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool ADCBHINMDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool JGJHBOPPEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool KOMMCDEBJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool CKNKEINLNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool OCOLILFDJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool JOOIJIFGFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool AICHOHLHIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool IKIMBCLDNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool ALLCKCCNMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool DEKIHEJBPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool CEDHMFJHMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<string> FNKCHIDNHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CCBKCKJLLDC IHHKIDIFMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CJCCIKAKKHK : HBFOEJJNHLA, LMMIIPJHCLD, HAHCEJIIDLA<CEMDLJMNFPP>
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string MALFCKDJCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GHEPHOPAIBD LMGLJLFBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) INMGIGFONMG<T>(CEMDLJMNFPP EDEEBIHLFJB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal abstract class CIABFCEMNPC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public object? OADCPKPDMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
	protected CIABFCEMNPC(object? DONNHCMNIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NJLHKOGPPIM(object? CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class LKHKDGBAMMJ<T> : CIABFCEMNPC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T GKGDEAKLHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEqualityComparer<T> NPNOAOCBGIP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D0", Offset = "0x85E3D0", VA = "0x18085F3D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2507480", Offset = "0x2506480", VA = "0x182507480", Slot = "4")]
	public override bool NJLHKOGPPIM(object? CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2506DC0", Offset = "0x2505DC0", VA = "0x182506DC0")]
	public bool CCGEFKOJFBE(T CFCJNMHCMBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2507730", Offset = "0x2506730", VA = "0x182507730")]
	public LKHKDGBAMMJ(T PNJDHPAJOAO, IEqualityComparer<T> NPNOAOCBGIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal static class OODBBPAOBEL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Flags]
	public enum HJPGAKAPBNJ
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
	public static readonly Guid EJFNPBCIKEI;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly Guid GBIIHPEDBAP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly Guid IEIPLPJEJLF;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly Guid PLDGHLEDNFG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly Guid DLBPEIHLIMP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly JJAMBKNFNEK<GHEPHOPAIBD, Guid> BOJLCFLIMGN;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal static IEnumerable<GHEPHOPAIBD> EIPPOGJIJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68E2800", Offset = "0x68E1800", VA = "0x1868E2800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68E2770", Offset = "0x68E1770", VA = "0x1868E2770")]
	public static GHEPHOPAIBD BNGCJOJHOHB(Guid PLBICILNGEB)
	{
		return default(GHEPHOPAIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x68E2610", Offset = "0x68E1610", VA = "0x1868E2610")]
	public static Guid ABCMMMADNJI(GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x68E2880", Offset = "0x68E1880", VA = "0x1868E2880")]
	public static bool IJNDNNIAHKJ(GHEPHOPAIBD FAGEECHHFAJ, out Guid PLBICILNGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x68E2990", Offset = "0x68E1990", VA = "0x1868E2990")]
	public static bool PEBLCCCGECP(Guid PLBICILNGEB, out GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68E2960", Offset = "0x68E1960", VA = "0x1868E2960")]
	public static GHEPHOPAIBD LBHFKAEEJBG(GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(GHEPHOPAIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68E26C0", Offset = "0x68E16C0", VA = "0x1868E26C0")]
	public static HJPGAKAPBNJ AFMKNOFPGBK(GHEPHOPAIBD ICAIAMLLNMA)
	{
		return default(HJPGAKAPBNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68E2920", Offset = "0x68E1920", VA = "0x1868E2920")]
	internal static GHEPHOPAIBD JJPJJHLENNK(HJPGAKAPBNJ FDGPJHHLDAD)
	{
		return default(GHEPHOPAIBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal delegate string KPLEMJBDCID(object? CKDFGEALFAK);
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal delegate object NFEDHHCFDHG(string? FCLIBJCLECD, [Optional] object PNJDHPAJOAO);
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal delegate CIABFCEMNPC LBOLKLLAEJH();
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class NKBLGHAKFMH
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private class OCOOBADEPPG : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static OCOOBADEPPG HIEJPGCOIBA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68E1C40", Offset = "0x68E0C40", VA = "0x1868E1C40", Slot = "4")]
		public bool Equals(List<string> FKPADFHIFHA, List<string> NAFGCLHKJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68E1DA0", Offset = "0x68E0DA0", VA = "0x1868E1DA0", Slot = "5")]
		public int GetHashCode(List<string> EOHGDDIECBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OCOOBADEPPG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private class PMNMNCEEHCA : MJADIJMFBEK<CCBKCKJLLDC>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68E3730", Offset = "0x68E2730", VA = "0x1868E3730", Slot = "9")]
		public override string IKBIGFALLCH(CCBKCKJLLDC LEANPEDPCEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68E3540", Offset = "0x68E2540", VA = "0x1868E3540", Slot = "10")]
		protected override bool EBIMLPGNCJE(string LEANPEDPCEP, out CCBKCKJLLDC CKDFGEALFAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68E3820", Offset = "0x68E2820", VA = "0x1868E3820")]
		public PMNMNCEEHCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly NCJCEJIBNIF FPFDBDMJLMG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly PMNMNCEEHCA CEBBALADAMN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly List<NNBLEOPPGGI> AINGLBGDKLM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEnumerable<CEMDLJMNFPP> CLBMODEALOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IReadOnlyDictionary<CEMDLJMNFPP, NNBLEOPPGGI> NEONGNIPDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68E16C0", Offset = "0x68E06C0", VA = "0x1868E16C0")]
	public NKBLGHAKFMH([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758A00", Offset = "0x757E00")] IList<NNBLEOPPGGI> APLCLFPEPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68E0AE0", Offset = "0x68DFAE0", VA = "0x1868E0AE0")]
	public NNBLEOPPGGI HCDHOPBIGEF(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KAEHJHLDJEO : GINBGGJNEBN, GNGIGJPAAHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PJMCAMIMMEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FJCKLOIMNIL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public PJMCAMIMMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68E3510", Offset = "0x68E2510", VA = "0x1868E3510")]
		internal bool MHEPJCKJDCN(FJCKLOIMNIL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MMBIHBMGDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GHEPHOPAIBD roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MMBIHBMGDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x68DFA90", Offset = "0x68DEA90", VA = "0x1868DFA90")]
		internal bool FPIBKEEPOCK(GHEPHOPAIBD r)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OPJBBGPMEEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OCMKINIOLDE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public KAEHJHLDJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool <isOffline>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private PKMEAFAIOCC <tokenAndPermissionsDto>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool <hasRoomRoles>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private PKMEAFAIOCC <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <serverHasPermissions>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758F90", Offset = "0x758390")]
		private TaskAwaiter<PKMEAFAIOCC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public OPJBBGPMEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68E2D00", Offset = "0x68E1D00", VA = "0x1868E2D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LGPNIEMEFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LGPNIEMEFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68DF990", Offset = "0x68DE990", VA = "0x1868DF990")]
		internal void PGGMANFCNJO(GOIJELILNBO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x68DF860", Offset = "0x68DE860", VA = "0x1868DF860")]
		internal void JKEBGJAFKHB(GOIJELILNBO r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ACPGMNJLHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OCMKINIOLDE roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class COBDHPBFMPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x758FF0", Offset = "0x7583F0")]
		public Func<GOIJELILNBO, GHLBAPIONFL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public COBDHPBFMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68D6910", Offset = "0x68D5910", VA = "0x1868D6910")]
		internal void OKGOABDJJBL(GOIJELILNBO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x68D6830", Offset = "0x68D5830", VA = "0x1868D6830")]
		internal void DHBNPAHDPOG(GOIJELILNBO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68D68A0", Offset = "0x68D58A0", VA = "0x1868D68A0")]
		internal void OCFGCHMLBGL(GOIJELILNBO r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HEKGBCGKMNA<T> where T : notnull
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
			public HEKGBCGKMNA<T> <>4__this;

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
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7590B0", Offset = "0x7584B0")]
			private TaskAwaiter<PKMEAFAIOCC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x1B5E7D0", Offset = "0x1B5D7D0", VA = "0x181B5E7D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public KAEHJHLDJEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CEMDLJMNFPP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GHEPHOPAIBD accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NGKCPHKDOCG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HEKGBCGKMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x203F200", Offset = "0x203E200", VA = "0x18203F200")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HEKGBCGKMNA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void PKEJMADJONL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BAAANIHGCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<JMOGAMJIIAA> newPermissionOverrides;
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MNCKDCKCJMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DKCFDHMFNAK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public OCMKINIOLDE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x759110", Offset = "0x758510")]
		public IReadOnlyDictionary<GHEPHOPAIBD, FJCKLOIMNIL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public HDBPBCNEHOA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private StringBuilder <migrationLogBuilder>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x759170", Offset = "0x758570")]
		private List<JMOGAMJIIAA> <permissionsChangeBatch>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<GOIJELILNBO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GOIJELILNBO <roleData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GHEPHOPAIBD <roleAccountType>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FJCKLOIMNIL <role>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IReadOnlyList<CEMDLJMNFPP> <modifiedPermissions>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private IEnumerator<CEMDLJMNFPP> <>s__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private CEMDLJMNFPP <permission>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private NGKCPHKDOCG <recNetPermissionType>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7591D0", Offset = "0x7585D0")]
		private (bool Overrides, string SerializedValue) <serializedData>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MNCKDCKCJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68DFAA0", Offset = "0x68DEAA0", VA = "0x1868DFAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DKCFDHMFNAK HMIJDLMMOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly DHPLILHMLDG LJOOLMNJFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HDBPBCNEHOA LHHMOHHCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<int, FJCKLOIMNIL> JGNCFCNGGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly Dictionary<GHEPHOPAIBD, FJCKLOIMNIL> APMIAGNODPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly Dictionary<GHEPHOPAIBD, FJCKLOIMNIL> AIJJAADEBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly List<FJCKLOIMNIL> CGJLHFJDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool CMJAIEEFOIH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly CEMDLJMNFPP[] IIBNPKAANNC;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OPKOGGOJHOA FMEPIKALHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IEnumerable<CJCCIKAKKHK> HHOAHBIEMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x68DA4D0", Offset = "0x68D94D0", VA = "0x1868DA4D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MDEMAIJAIOA DBGPLAGMDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68DB5A0", Offset = "0x68DA5A0", VA = "0x1868DB5A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x68DA520", Offset = "0x68D9520", VA = "0x1868DA520", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68DB640", Offset = "0x68DA640", VA = "0x1868DB640")]
	[FBCFLFBFGIL(MELNECENNOL.Room, LAFFCBAHJKM.None)]
	private static void HBFKEFNCHDO(CNALHHIKJDD HDIGDGEFOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68DF5D0", Offset = "0x68DE5D0", VA = "0x1868DF5D0")]
	[UnityEngine.Scripting.Preserve]
	internal KAEHJHLDJEO([JFLEHDEIONF(null)] DKCFDHMFNAK NDIJHMLANGJ, [JFLEHDEIONF(null)] DHPLILHMLDG KMDLKHGHFOJ, [JFLEHDEIONF(null)] HDBPBCNEHOA LHHMOHHCHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68DABC0", Offset = "0x68D9BC0", VA = "0x1868DABC0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68DD060", Offset = "0x68DC060", VA = "0x1868DD060")]
	private void LPKNIBBPPHA(IEnumerable<FJCKLOIMNIL> CNBLMGBOPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68DB360", Offset = "0x68DA360", VA = "0x1868DB360", Slot = "12")]
	public bool FGMKKJDCPPG(PIPFLAHHDDO IOGAENGPLPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68DEAE0", Offset = "0x68DDAE0", VA = "0x1868DEAE0")]
	private void NILMFPHLOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68DEAF0", Offset = "0x68DDAF0", VA = "0x1868DEAF0")]
	private void NPDAGLLAJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68DB1D0", Offset = "0x68DA1D0", VA = "0x1868DB1D0", Slot = "10")]
	public IReadOnlyList<CJCCIKAKKHK> EJAHBOIOMMK(bool MHFEGNHCEJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68DB250", Offset = "0x68DA250", VA = "0x1868DB250", Slot = "11")]
	public CJCCIKAKKHK ELIEOIPJIIC(PIPFLAHHDDO IOGAENGPLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68DACD0", Offset = "0x68D9CD0", VA = "0x1868DACD0")]
	private GHEPHOPAIBD ECFNAFJMLKA(PIPFLAHHDDO IOGAENGPLPG)
	{
		return default(GHEPHOPAIBD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68DC660", Offset = "0x68DB660", VA = "0x1868DC660", Slot = "14")]
	public bool KFCPICFOPOE(PIPFLAHHDDO IPFPENIBBBM, GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68DCFB0", Offset = "0x68DBFB0", VA = "0x1868DCFB0", Slot = "15")]
	public CJCCIKAKKHK LKHHAOKNCFO(GHEPHOPAIBD FAGEECHHFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68DC270", Offset = "0x68DB270", VA = "0x1868DC270")]
	private static bool KDFAGCHGGGE(GPCPJELAKOL JCBLJFLNIEE, GHEPHOPAIBD FAGEECHHFAJ, out GOIJELILNBO? IMOEMJKMJNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68DF0E0", Offset = "0x68DE0E0", VA = "0x1868DF0E0")]
	private static void PKIHHOGCMKG(GPCPJELAKOL JCBLJFLNIEE, Action<GOIJELILNBO> POAPDHOOKCB, GHEPHOPAIBD DDCGIHKKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68DF1E0", Offset = "0x68DE1E0", VA = "0x1868DF1E0")]
	private static void PKIHHOGCMKG(GPCPJELAKOL JCBLJFLNIEE, Action<GOIJELILNBO> POAPDHOOKCB, Predicate<GHEPHOPAIBD> CMOBOLCGPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68DB7F0", Offset = "0x68DA7F0", VA = "0x1868DB7F0")]
	private void IJBLHJHONLI(PIPFLAHHDDO IOGAENGPLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68DB430", Offset = "0x68DA430", VA = "0x1868DB430", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OPJBBGPMEEO))]
	public Task GGAJJLLDHPG([CanBeNull] OCMKINIOLDE CAPINCBBCIM, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
	public void AMLJIKNEJPO(ref OCMKINIOLDE CAPINCBBCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68DAF40", Offset = "0x68D9F40", VA = "0x1868DAF40")]
	private void EGEJPGODBBD(GPCPJELAKOL NGOLAFFDPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68DA5C0", Offset = "0x68D95C0", VA = "0x1868DA5C0")]
	internal static string CPBCCCAAJDH(DKCFDHMFNAK HMIJDLMMOPK, OCMKINIOLDE CAPINCBBCIM, IReadOnlyDictionary<GHEPHOPAIBD, FJCKLOIMNIL> APMIAGNODPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68DD850", Offset = "0x68DC850", VA = "0x1868DD850")]
	private static void MCHCLFGLGMI(OCMKINIOLDE CAPINCBBCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68DEC70", Offset = "0x68DDC70", VA = "0x1868DEC70")]
	private static void OHJNOMPLPLC(GPCPJELAKOL KINMNOADGJD, IReadOnlyDictionary<GHEPHOPAIBD, FJCKLOIMNIL> APMIAGNODPJ, StringBuilder DBKJKIJIBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x68DEF80", Offset = "0x68DDF80", VA = "0x1868DEF80")]
	private static bool PFOKEEJGALE(string BNCMONCDALN, out Guid MCNLNJKIMED, out GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x68DC7F0", Offset = "0x68DB7F0", VA = "0x1868DC7F0")]
	private static void LGOELNJFPGG(OCMKINIOLDE CAPINCBBCIM, StringBuilder DBKJKIJIBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x211FE20", Offset = "0x211EE20", VA = "0x18211FE20", Slot = "16")]
	public bool LKOAAMNBNJK<T>(GHEPHOPAIBD FAGEECHHFAJ, CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, T IELOEMGHLEA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68DAD90", Offset = "0x68D9D90", VA = "0x1868DAD90")]
	private void EEOJBADMOCI(GHEPHOPAIBD FAGEECHHFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x68DF3E0", Offset = "0x68DE3E0", VA = "0x1868DF3E0")]
	private bool PNHLBIMLBHD(PIPFLAHHDDO IOGAENGPLPG, GHEPHOPAIBD FAGEECHHFAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68DA1B0", Offset = "0x68D91B0", VA = "0x1868DA1B0")]
	internal FJCKLOIMNIL BGCNDNBCLED(PIPFLAHHDDO IOGAENGPLPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x68DB1C0", Offset = "0x68DA1C0", VA = "0x1868DB1C0", Slot = "13")]
	public IReadOnlyList<CJCCIKAKKHK> EGIEKCFGMLM(PIPFLAHHDDO IOGAENGPLPG, bool POMGPNBFEPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x68D9F90", Offset = "0x68D8F90", VA = "0x1868D9F90")]
	internal IReadOnlyList<FJCKLOIMNIL> BBHAFGOCKFO(PIPFLAHHDDO IOGAENGPLPG, bool POMGPNBFEPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x68DBB30", Offset = "0x68DAB30", VA = "0x1868DBB30")]
	private void JGOPAMNMAKD(PKMEAFAIOCC KMNNMNJFLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x68DB850", Offset = "0x68DA850", VA = "0x1868DB850")]
	private static bool JFOKDFNINGH(FJCKLOIMNIL DNBIDHPICMK, IReadOnlyDictionary<GHEPHOPAIBD, FJCKLOIMNIL> APMIAGNODPJ, out IReadOnlyList<CEMDLJMNFPP> AECODIDLPIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x68DCE10", Offset = "0x68DBE10", VA = "0x1868DCE10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MNCKDCKCJMF))]
	private static Task LJLJMKCFIGG(DKCFDHMFNAK HMIJDLMMOPK, OCMKINIOLDE CAPINCBBCIM, IReadOnlyDictionary<GHEPHOPAIBD, FJCKLOIMNIL> APMIAGNODPJ, HDBPBCNEHOA LHHMOHHCHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x68DA8E0", Offset = "0x68D98E0", VA = "0x1868DA8E0")]
	[CompilerGenerated]
	internal static void DCIHKMCNIJM(Func<GOIJELILNBO, GHLBAPIONFL> BPDDGKDFECB, ref ACPGMNJLHJO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x68DE760", Offset = "0x68DD760", VA = "0x1868DE760")]
	[CompilerGenerated]
	internal static bool MHALDPHBMLE(GHEPHOPAIBD FAGEECHHFAJ, CEMDLJMNFPP EDEEBIHLFJB, out JMOGAMJIIAA IIALNCMNGEF, ref BAAANIHGCHP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum CEMDLJMNFPP
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
internal class OEDJHNDCGAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly Dictionary<CEMDLJMNFPP, bool> AOIDICDBDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<CEMDLJMNFPP, CIABFCEMNPC> LGNGPDAHGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NKBLGHAKFMH AGLHFFNFDON;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x68E23C0", Offset = "0x68E13C0", VA = "0x1868E23C0")]
	public OEDJHNDCGAK(NKBLGHAKFMH AGLHFFNFDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68E1F40", Offset = "0x68E0F40", VA = "0x1868E1F40")]
	public bool BBHGIAOFGDB(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1AC20", Offset = "0x2E19C20", VA = "0x182E1AC20")]
	public bool BMMOBGDJJEP<T>(CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, T CKDFGEALFAK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1AF70", Offset = "0x2E19F70", VA = "0x182E1AF70")]
	public (bool, T?) NNBLDJLKHPM<T>(CEMDLJMNFPP EDEEBIHLFJB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68E1FB0", Offset = "0x68E0FB0", VA = "0x1868E1FB0")]
	public bool BMMOBGDJJEP(CEMDLJMNFPP EDEEBIHLFJB, bool AANDEMIALKC, object CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x68E2150", Offset = "0x68E1150", VA = "0x1868E2150")]
	public (bool, object) NNBLDJLKHPM(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1AD50", Offset = "0x2E19D50", VA = "0x182E1AD50")]
	private void DNBFGFFCBMB<T>(CEMDLJMNFPP EDEEBIHLFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68E2090", Offset = "0x68E1090", VA = "0x1868E2090")]
	private CIABFCEMNPC GCKBHAIMNIN(CEMDLJMNFPP EDEEBIHLFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68E2240", Offset = "0x68E1240", VA = "0x1868E2240")]
	public void PPNMDJOEFDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OPKOGGOJHOA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	CJCCIKAKKHK AKKLPHFMOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class DHPLILHMLDG : OPKOGGOJHOA
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static DHPLILHMLDG KMKOCKEEMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	internal readonly FJCKLOIMNIL KFAFCGBOOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	internal readonly IReadOnlyList<FJCKLOIMNIL> LIJPCHDIBNG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public CJCCIKAKKHK AKKLPHFMOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68D71A0", Offset = "0x68D61A0", VA = "0x1868D71A0")]
	public DHPLILHMLDG(FJCKLOIMNIL PGIBNKGPEOI, IReadOnlyList<FJCKLOIMNIL> IGIAFKOCNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68D6980", Offset = "0x68D5980", VA = "0x1868D6980")]
	private static DHPLILHMLDG JAMCFNHABKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum OLHJJEIIOOB
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
